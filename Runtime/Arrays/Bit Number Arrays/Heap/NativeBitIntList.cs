using System;
using System.Linq;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Jobs;
using Unity.Burst;
using Unity.Burst.CompilerServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using DevTools;
using MaxMath;
using MaxMath.Intrinsics;
using SIMDAlgorithms;

using static Unity.Mathematics.math;
using static MaxMath.maxmath;

namespace BitCollections
{
    [NativeContainer]
    [DebuggerTypeProxy(typeof(NativeCollectionDebugView<long>))]
    [NativeContainerSupportsDeallocateOnJobCompletion]
    [StructLayout(LayoutKind.Sequential)]
    unsafe public struct NativeBitIntList<T> : INativeList<long>, IArray<long>, IEquatable<NativeBitIntList<T>>, INativeDisposable, IUnityCollectionsCheck
        where T : BitInt
    {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
internal AtomicSafetyHandle m_Safety;
internal static readonly SharedStatic<int> _staticSafetyId = SharedStatic<int>.GetOrCreate<NativeBitIntList<T>>();
[NativeSetClassTypeToNullOnSchedule] private DisposeSentinel m_DisposeSentinel;
#endif

        [NativeDisableUnsafePtrRestriction]
        internal ListData* _data;
#if ENABLE_UNITY_COLLECTIONS_CHECKS
        internal Allocator _allocator;
#else
        internal readonly Allocator _allocator;
#endif

        private void* DataPtr
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return _data->Ptr;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
this.CheckWriteAndBumpSecondaryVersion();

                _data->Ptr = value;
            }
        }

        public readonly bool IsCreated
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
this.CheckReadAndThrow();

                return _data != null;
            }
        }

        public readonly bool IsEmpty => ((uint)Length | (ulong)_data) == 0;

        public int Length
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [return: AssumeRange(0, int.MaxValue)]
            readonly get
            {
this.CheckReadAndThrow();

                return _data->Length;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsNonNegative(value);

                if (Hint.Unlikely(value > Capacity))
                {
                    Resize(value);
                }
                else
                {
this.CheckWriteAndBumpSecondaryVersion();

                    _data->Length = value;
                }
            }
        }

        public int Capacity
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [return: AssumeRange(0, int.MaxValue)]
            readonly get
            {
this.CheckReadAndThrow();

                return _data->Capacity;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsNonNegative(value);
Assert.IsGreater((int)_allocator, (int)Allocator.None);
this.CheckWriteAndThrow();
this.CheckWriteAndBumpSecondaryVersion();

                int newCapacity = (int)MemoryHelper.Capacity<T>(value);
                int oldLength = Length;
                _data->Length = min(oldLength, newCapacity);

                if (Hint.Likely(newCapacity != 0))
                {
                    void* newPtr = UnsafeUtility.Malloc((long)MemoryHelper.SizeInBytes<T>(newCapacity), MemoryHelper.AlignOf<T>(), _allocator);

                    if (Hint.Likely(_data->Capacity != 0))
                    {
                        UnsafeUtility.MemCpy(newPtr, DataPtr, (long)MemoryHelper.SizeInBytes<T>(oldLength));
                        UnsafeUtility.Free(DataPtr, _allocator);
                    }

                    _data->Ptr = newPtr;
                }
                else if (Hint.Unlikely(Capacity != 0))
                {
                    UnsafeUtility.Free(DataPtr, _allocator);

#if ENABLE_UNITY_COLLECTIONS_CHECKS
_data->Ptr = null;
#endif
                }

                _data->Capacity = newCapacity;
            }
        }

        public readonly ulong SizeInBytes
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [return: AssumeRange(0, int.MaxValue * 64ul)]
            get
            {
                return MemoryHelper.SizeInBytes<T>(Length);
            }
        }


        public readonly long this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return LoadStore.LoadScalar<T>(GetUnsafeReadOnlyPtr(), index, Length);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                LoadStore.StoreScalar<T>(GetUnsafePtr(), index, Length, value);
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly V LoadVector<V>(int index)
            where V : unmanaged
        {
            return LoadStore.LoadVector<T, V>(GetUnsafeReadOnlyPtr(), index, Length);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void StoreVector<V>(V vector, int index)
            where V : unmanaged
        {
            LoadStore.StoreVector<T, V>(GetUnsafePtr(), vector, index, Length);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public NativeBitIntList(Allocator allocator)
            : this(0, allocator)
        {

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public NativeBitIntList(int initialCapacity, Allocator allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory)
        {
Assert.IsGreater((int)allocator, (int)Allocator.None);
Assert.IsNonNegative(initialCapacity);

            _allocator = allocator;
            _data = (ListData*)UnsafeUtility.Malloc(sizeof(ListData), UnsafeUtility.AlignOf<ListData>(), allocator);
            _data->Length = 0;
            _data->Capacity = (int)MemoryHelper.Capacity<T>(initialCapacity);
            _data->Ptr = MemoryHelper.Allocate<T>(_data->Capacity, allocator, options);

#if ENABLE_UNITY_COLLECTIONS_CHECKS
SafetyHelper.InitSafety<NativeBitIntList<T>>(allocator, _staticSafetyId, out m_Safety, out m_DisposeSentinel);
#endif
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator NativeBitIntArray<T>(NativeBitIntList<T> nativeBitList)
        {
            return nativeBitList.AsArray();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly NativeBitIntArray<T> ToArray(Allocator allocator)
        {
            NativeBitIntArray<T> result = new NativeBitIntArray<T>(Length, allocator, NativeArrayOptions.UninitializedMemory);

            ulong bytes = MemoryHelper.SizeInBytes<T>(Length);
            UnsafeUtility.MemCpy(result.GetUnsafePtr(), GetUnsafeReadOnlyPtr(), (long)bytes);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly NativeBitIntArray<T> AsArray()
        {
this.CheckWriteAndBumpSecondaryVersion();
#if ENABLE_UNITY_COLLECTIONS_CHECKS
AtomicSafetyHandle safety = m_Safety;
AtomicSafetyHandle.UseSecondaryVersion(ref safety);

            return new NativeBitIntArray<T>(GetUnsafeReadOnlyPtr(), Length, Allocator.None, safety);
#else
            return new NativeBitIntArray<T>(GetUnsafeReadOnlyPtr(), Length, Allocator.None);
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly NativeBitIntArray<T>.ReadOnly AsReadOnly()
        {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
            return new NativeBitIntArray<T>.ReadOnly(GetUnsafeReadOnlyPtr(), Length, m_Safety);
#else
            return new NativeBitIntArray<T>.ReadOnly(GetUnsafeReadOnlyPtr(), Length);
#endif
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private readonly void IncLengthNoResize(int count, out int oldLength)
        {
this.CheckWriteAndBumpSecondaryVersion();

            oldLength = Length;
            _data->Length = oldLength + count;

Assert.IsNotGreater(_data->Length, _data->Capacity);
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void* GetUnsafePtr()
        {
this.CheckWriteAndThrow();

            return GetUnsafeReadOnlyPtr();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void* GetUnsafeReadOnlyPtr()
        {
this.CheckReadAndThrow();

            return DataPtr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void* GetInternalListDataPtrUnchecked()
        {
            return _data;
        }

#if ENABLE_UNITY_COLLECTIONS_CHECKS
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly AtomicSafetyHandle GetAtomicSafetyHandle()
        {
            return m_Safety;
        }
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ResizeUninitialized(int length)
        {
            Resize(length, NativeArrayOptions.UninitializedMemory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Resize(int length, NativeArrayOptions options = NativeArrayOptions.ClearMemory)
        {
Assert.IsNonNegative(length);
            int oldLength = Length;

this.CheckWriteAndThrow();

            if (length > Capacity)
            {
                _data->Length = length;
                Capacity = length + length;
            }
            else
            {
                Length = length;
            }

            if (options == NativeArrayOptions.ClearMemory && oldLength < length)
            {
                ulong oldSizeInBytes = MemoryHelper.SizeInBytes<T>(oldLength);
                ulong newSizeInBytes = MemoryHelper.SizeInBytes<T>(length);

                if (Hint.Likely(oldSizeInBytes != newSizeInBytes))
                {
                    UnsafeUtility.MemClear((byte*)DataPtr + oldSizeInBytes, (long)(newSizeInBytes - oldSizeInBytes));
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void Clear()
        {
this.CheckWriteAndBumpSecondaryVersion();

            _data->Length = 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetCapacity(int capacity)
        {
            Capacity = capacity;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void TrimExcess()
        {
            Capacity = Length;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref long ElementAt(int index)
        {
            throw new InvalidOperationException("Cannot return a reference to elements within bit fields.");
        }


        #region CopyFrom
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(byte* other, int count, int srcIndex, int dstIndex)
        {
            Length = max(Length, dstIndex + count);
            PackUnpack.CopyConvert<UInt8, T>(other, srcIndex, GetUnsafePtr(), dstIndex, count, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(sbyte* other, int count, int srcIndex, int dstIndex)
        {
            Length = max(Length, dstIndex + count);
            PackUnpack.CopyConvert<Int8, T>(other, srcIndex, GetUnsafePtr(), dstIndex, count, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(ushort* other, int count, int srcIndex, int dstIndex)
        {
            Length = max(Length, dstIndex + count);
            PackUnpack.CopyConvert<UInt16, T>(other, srcIndex, GetUnsafePtr(), dstIndex, count, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(short* other, int count, int srcIndex, int dstIndex)
        {
            Length = max(Length, dstIndex + count);
            PackUnpack.CopyConvert<Int16, T>(other, srcIndex, GetUnsafePtr(), dstIndex, count, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(UInt24* other, int count, int srcIndex, int dstIndex)
        {
            Length = max(Length, dstIndex + count);
            PackUnpack.CopyConvert<UInt24, T>(other, srcIndex, GetUnsafePtr(), dstIndex, count, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(Int24* other, int count, int srcIndex, int dstIndex)
        {
            Length = max(Length, dstIndex + count);
            PackUnpack.CopyConvert<Int24, T>(other, srcIndex, GetUnsafePtr(), dstIndex, count, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(uint* other, int count, int srcIndex, int dstIndex)
        {
            Length = max(Length, dstIndex + count);
            PackUnpack.CopyConvert<UInt32, T>(other, srcIndex, GetUnsafePtr(), dstIndex, count, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(int* other, int count, int srcIndex, int dstIndex)
        {
            Length = max(Length, dstIndex + count);
            PackUnpack.CopyConvert<Int32, T>(other, srcIndex, GetUnsafePtr(), dstIndex, count, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(UInt40* other, int count, int srcIndex, int dstIndex)
        {
            Length = max(Length, dstIndex + count);
            PackUnpack.CopyConvert<UInt40, T>(other, srcIndex, GetUnsafePtr(), dstIndex, count, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(Int40* other, int count, int srcIndex, int dstIndex)
        {
            Length = max(Length, dstIndex + count);
            PackUnpack.CopyConvert<Int40, T>(other, srcIndex, GetUnsafePtr(), dstIndex, count, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(UInt48* other, int count, int srcIndex, int dstIndex)
        {
            Length = max(Length, dstIndex + count);
            PackUnpack.CopyConvert<UInt48, T>(other, srcIndex, GetUnsafePtr(), dstIndex, count, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(Int48* other, int count, int srcIndex, int dstIndex)
        {
            Length = max(Length, dstIndex + count);
            PackUnpack.CopyConvert<Int48, T>(other, srcIndex, GetUnsafePtr(), dstIndex, count, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(UInt56* other, int count, int srcIndex, int dstIndex)
        {
            Length = max(Length, dstIndex + count);
            PackUnpack.CopyConvert<UInt56, T>(other, srcIndex, GetUnsafePtr(), dstIndex, count, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(Int56* other, int count, int srcIndex, int dstIndex)
        {
            Length = max(Length, dstIndex + count);
            PackUnpack.CopyConvert<Int56, T>(other, srcIndex, GetUnsafePtr(), dstIndex, count, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(ulong* other, int count, int srcIndex, int dstIndex)
        {
            Length = max(Length, dstIndex + count);
            PackUnpack.CopyConvert<UInt64, T>(other, srcIndex, GetUnsafePtr(), dstIndex, count, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(long* other, int count, int srcIndex, int dstIndex)
        {
            Length = max(Length, dstIndex + count);
            PackUnpack.CopyConvert<UInt64, T>(other, srcIndex, GetUnsafePtr(), dstIndex, count, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(UInt128* other, int count, int srcIndex, int dstIndex)
        {
            Length = max(Length, dstIndex + count);
            for (int i = 0; i < count; i++)
            {
                this[i + dstIndex] = (long)other[i + srcIndex];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(Int128* other, int count, int srcIndex, int dstIndex)
        {
            Length = max(Length, dstIndex + count);
            for (int i = 0; i < count; i++)
            {
                this[i + dstIndex] = (long)other[i + srcIndex];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(byte[] other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            fixed (byte* ptr = other)
            {
                CopyFrom(ptr, count, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(sbyte[] other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            fixed (sbyte* ptr = other)
            {
                CopyFrom(ptr, count, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(ushort[] other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            fixed (ushort* ptr = other)
            {
                CopyFrom(ptr, count, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(short[] other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            fixed (short* ptr = other)
            {
                CopyFrom(ptr, count, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(UInt24[] other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            fixed (UInt24* ptr = other)
            {
                CopyFrom(ptr, count, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(Int24[] other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            fixed (Int24* ptr = other)
            {
                CopyFrom(ptr, count, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(uint[] other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            fixed (uint* ptr = other)
            {
                CopyFrom(ptr, count, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(int[] other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            fixed (int* ptr = other)
            {
                CopyFrom(ptr, count, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(UInt40[] other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            fixed (UInt40* ptr = other)
            {
                CopyFrom(ptr, count, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(Int40[] other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            fixed (Int40* ptr = other)
            {
                CopyFrom(ptr, count, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(UInt48[] other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            fixed (UInt48* ptr = other)
            {
                CopyFrom(ptr, count, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(Int48[] other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            fixed (Int48* ptr = other)
            {
                CopyFrom(ptr, count, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(UInt56[] other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            fixed (UInt56* ptr = other)
            {
                CopyFrom(ptr, count, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(Int56[] other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            fixed (Int56* ptr = other)
            {
                CopyFrom(ptr, count, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(ulong[] other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            fixed (ulong* ptr = other)
            {
                CopyFrom(ptr, count, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(long[] other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            fixed (long* ptr = other)
            {
                CopyFrom(ptr, count, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(UInt128[] other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            fixed (UInt128* ptr = other)
            {
                CopyFrom(ptr, count, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(Int128[] other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            fixed (Int128* ptr = other)
            {
                CopyFrom(ptr, count, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<byte> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Count());

            Length = max(Length, dstIndex + count);
            IEnumerator<byte> enumerator = other.GetEnumerator();

            int i = 0;
            do
            {
                enumerator.MoveNext();
            } 
            while (i < srcIndex);

            for (i = 0; i < count; i++)
            {
                this[i + dstIndex] = enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<sbyte> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Count());

            Length = max(Length, dstIndex + count);
            IEnumerator<sbyte> enumerator = other.GetEnumerator();

            int i = 0;
            do
            {
                enumerator.MoveNext();
            } 
            while (i < srcIndex);

            for (i = 0; i < count; i++)
            {
                this[i + dstIndex] = enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<ushort> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Count());

            Length = max(Length, dstIndex + count);
            IEnumerator<ushort> enumerator = other.GetEnumerator();

            int i = 0;
            do
            {
                enumerator.MoveNext();
            } 
            while (i < srcIndex);

            for (i = 0; i < count; i++)
            {
                this[i + dstIndex] = enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<short> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Count());

            Length = max(Length, dstIndex + count);
            IEnumerator<short> enumerator = other.GetEnumerator();

            int i = 0;
            do
            {
                enumerator.MoveNext();
            } 
            while (i < srcIndex);

            for (i = 0; i < count; i++)
            {
                this[i + dstIndex] = enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<UInt24> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Count());

            Length = max(Length, dstIndex + count);
            IEnumerator<UInt24> enumerator = other.GetEnumerator();

            int i = 0;
            do
            {
                enumerator.MoveNext();
            } 
            while (i < srcIndex);

            for (i = 0; i < count; i++)
            {
                this[i + dstIndex] = enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<Int24> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Count());

            Length = max(Length, dstIndex + count);
            IEnumerator<Int24> enumerator = other.GetEnumerator();

            int i = 0;
            do
            {
                enumerator.MoveNext();
            } 
            while (i < srcIndex);

            for (i = 0; i < count; i++)
            {
                this[i + dstIndex] = enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<uint> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Count());

            Length = max(Length, dstIndex + count);
            IEnumerator<uint> enumerator = other.GetEnumerator();

            int i = 0;
            do
            {
                enumerator.MoveNext();
            } 
            while (i < srcIndex);

            for (i = 0; i < count; i++)
            {
                this[i + dstIndex] = enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<int> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Count());

            Length = max(Length, dstIndex + count);
            IEnumerator<int> enumerator = other.GetEnumerator();

            int i = 0;
            do
            {
                enumerator.MoveNext();
            } 
            while (i < srcIndex);

            for (i = 0; i < count; i++)
            {
                this[i + dstIndex] = enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<UInt40> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Count());

            Length = max(Length, dstIndex + count);
            IEnumerator<UInt40> enumerator = other.GetEnumerator();

            int i = 0;
            do
            {
                enumerator.MoveNext();
            } 
            while (i < srcIndex);

            for (i = 0; i < count; i++)
            {
                this[i + dstIndex] = enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<Int40> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Count());

            Length = max(Length, dstIndex + count);
            IEnumerator<Int40> enumerator = other.GetEnumerator();

            int i = 0;
            do
            {
                enumerator.MoveNext();
            } 
            while (i < srcIndex);

            for (i = 0; i < count; i++)
            {
                this[i + dstIndex] = enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<UInt48> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Count());

            Length = max(Length, dstIndex + count);
            IEnumerator<UInt48> enumerator = other.GetEnumerator();

            int i = 0;
            do
            {
                enumerator.MoveNext();
            } 
            while (i < srcIndex);

            for (i = 0; i < count; i++)
            {
                this[i + dstIndex] = enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<Int48> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Count());

            Length = max(Length, dstIndex + count);
            IEnumerator<Int48> enumerator = other.GetEnumerator();

            int i = 0;
            do
            {
                enumerator.MoveNext();
            } 
            while (i < srcIndex);

            for (i = 0; i < count; i++)
            {
                this[i + dstIndex] = enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<UInt56> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Count());

            Length = max(Length, dstIndex + count);
            IEnumerator<UInt56> enumerator = other.GetEnumerator();

            int i = 0;
            do
            {
                enumerator.MoveNext();
            } 
            while (i < srcIndex);

            for (i = 0; i < count; i++)
            {
                this[i + dstIndex] = enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<Int56> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Count());

            Length = max(Length, dstIndex + count);
            IEnumerator<Int56> enumerator = other.GetEnumerator();

            int i = 0;
            do
            {
                enumerator.MoveNext();
            } 
            while (i < srcIndex);

            for (i = 0; i < count; i++)
            {
                this[i + dstIndex] = enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<ulong> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Count());

            Length = max(Length, dstIndex + count);
            IEnumerator<ulong> enumerator = other.GetEnumerator();

            int i = 0;
            do
            {
                enumerator.MoveNext();
            } 
            while (i < srcIndex);

            for (i = 0; i < count; i++)
            {
                this[i + dstIndex] = (long)enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<long> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Count());

            Length = max(Length, dstIndex + count);
            IEnumerator<long> enumerator = other.GetEnumerator();

            int i = 0;
            do
            {
                enumerator.MoveNext();
            } 
            while (i < srcIndex);

            for (i = 0; i < count; i++)
            {
                this[i + dstIndex] = enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<UInt128> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Count());

            Length = max(Length, dstIndex + count);
            IEnumerator<UInt128> enumerator = other.GetEnumerator();

            int i = 0;
            do
            {
                enumerator.MoveNext();
            } 
            while (i < srcIndex);

            for (i = 0; i < count; i++)
            {
                this[i + dstIndex] = (long)enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<Int128> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Count());

            Length = max(Length, dstIndex + count);
            IEnumerator<Int128> enumerator = other.GetEnumerator();

            int i = 0;
            do
            {
                enumerator.MoveNext();
            } 
            while (i < srcIndex);

            for (i = 0; i < count; i++)
            {
                this[i + dstIndex] = (long)enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom<U>(NativeBitIntArray<U> other, int count, int srcIndex, int dstIndex)
            where U : BitInt
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            Length = max(Length, dstIndex + count);
            PackUnpack.CopyConvert<U, T>(other.GetUnsafeReadOnlyPtr(), srcIndex, GetUnsafePtr(), dstIndex, count, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom<U>(NativeBitIntList<U> other, int count, int srcIndex, int dstIndex)
            where U : BitInt
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            Length = max(Length, dstIndex + count);
            PackUnpack.CopyConvert<U, T>(other.GetUnsafeReadOnlyPtr(), srcIndex, GetUnsafePtr(), dstIndex, count, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<byte> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((byte*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<sbyte> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((sbyte*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<ushort> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((ushort*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<short> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((short*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<UInt24> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((UInt24*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<Int24> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((Int24*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<uint> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((uint*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<int> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((int*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<UInt40> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((UInt40*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<Int40> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((Int40*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<UInt48> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((UInt48*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<Int48> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((Int48*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<UInt56> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((UInt56*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<Int56> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((Int56*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<ulong> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((ulong*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<long> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((long*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<UInt128> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((UInt128*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<Int128> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((Int128*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<byte> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((byte*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<sbyte> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((sbyte*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<ushort> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((ushort*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<short> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((short*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<UInt24> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((UInt24*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<Int24> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((Int24*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<uint> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((uint*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<int> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((int*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<UInt40> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((UInt40*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<Int40> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((Int40*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<UInt48> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((UInt48*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<Int48> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((Int48*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<UInt56> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((UInt56*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<Int56> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((Int56*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<ulong> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((ulong*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<long> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((long*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<UInt128> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((UInt128*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<Int128> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((Int128*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<byte> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((byte*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<sbyte> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((sbyte*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<ushort> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((ushort*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<short> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((short*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<UInt24> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((UInt24*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<Int24> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((Int24*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<uint> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((uint*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<int> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((int*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<UInt40> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((UInt40*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<Int40> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((Int40*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<UInt48> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((UInt48*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<Int48> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((Int48*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<UInt56> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((UInt56*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<Int56> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((Int56*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<ulong> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((ulong*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<long> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((long*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<UInt128> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((UInt128*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<Int128> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((Int128*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(byte* other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(sbyte* other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(ushort* other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(short* other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(UInt24* other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(Int24* other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(uint* other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(int* other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(UInt40* other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(Int40* other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(UInt48* other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(Int48* other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(UInt56* other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(Int56* other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(ulong* other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(long* other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(UInt128* other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(Int128* other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(byte[] other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(sbyte[] other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(ushort[] other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(short[] other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(UInt24[] other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(Int24[] other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(uint[] other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(int[] other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(UInt40[] other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(Int40[] other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(UInt48[] other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(Int48[] other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(UInt56[] other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(Int56[] other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(ulong[] other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(long[] other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(UInt128[] other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(Int128[] other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<byte> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<sbyte> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<ushort> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<short> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<UInt24> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<Int24> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<uint> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<int> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<UInt40> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<Int40> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<UInt48> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<Int48> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<UInt56> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<Int56> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<ulong> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<long> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<UInt128> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<Int128> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom<U>(NativeBitIntArray<U> other, int count, int srcIndex)
            where U : BitInt
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom<U>(NativeBitIntList<U> other, int count, int srcIndex)
            where U : BitInt
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<byte> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<sbyte> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<ushort> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<short> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<UInt24> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<Int24> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<uint> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<int> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<UInt40> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<Int40> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<UInt48> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<Int48> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<UInt56> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<Int56> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<ulong> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<long> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<UInt128> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<Int128> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<byte> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<sbyte> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<ushort> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<short> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<UInt24> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<Int24> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<uint> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<int> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<UInt40> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<Int40> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<UInt48> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<Int48> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<UInt56> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<Int56> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<ulong> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<long> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<UInt128> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<Int128> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<byte> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<sbyte> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<ushort> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<short> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<UInt24> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<Int24> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<uint> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<int> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<UInt40> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<Int40> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<UInt48> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<Int48> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<UInt56> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<Int56> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<ulong> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<long> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<UInt128> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<Int128> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(byte[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(sbyte[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(ushort[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(short[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(UInt24[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(Int24[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(uint[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(int[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(UInt40[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(Int40[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(UInt48[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(Int48[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(UInt56[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(Int56[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(ulong[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(long[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(UInt128[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(Int128[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<byte> other)
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<sbyte> other)
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<ushort> other)
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<short> other)
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<UInt24> other)
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<Int24> other)
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<uint> other)
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<int> other)
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<UInt40> other)
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<Int40> other)
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<UInt48> other)
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<Int48> other)
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<UInt56> other)
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<Int56> other)
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<ulong> other)
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<long> other)
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<UInt128> other)
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(IEnumerable<Int128> other)
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom<U>(NativeBitIntArray<U> other)
            where U : BitInt
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom<U>(NativeBitIntList<U> other)
            where U : BitInt
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<byte> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<sbyte> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<ushort> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<short> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<UInt24> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<Int24> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<uint> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<int> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<UInt40> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<Int40> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<UInt48> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<Int48> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<UInt56> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<Int56> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<ulong> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<long> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<UInt128> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<Int128> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<byte> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<sbyte> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<ushort> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<short> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<UInt24> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<Int24> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<uint> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<int> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<UInt40> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<Int40> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<UInt48> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<Int48> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<UInt56> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<Int56> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<ulong> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<long> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<UInt128> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<Int128> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<byte> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<sbyte> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<ushort> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<short> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<UInt24> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<Int24> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<uint> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<int> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<UInt40> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<Int40> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<UInt48> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<Int48> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<UInt56> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<Int56> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<ulong> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<long> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<UInt128> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<Int128> other)
        {
            CopyFrom(other, other.Length, 0);
        }
        #endregion


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Add(long value)
        {
            int oldLength = Length;
            Resize(oldLength + 1, NativeArrayOptions.UninitializedMemory);

            this[oldLength] = value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddNoResize(long value)
        {
Assert.AreNotEqual(_data->Length, Capacity);
this.CheckWriteAndBumpSecondaryVersion();

            this[_data->Length++] = value;
        }


        #region AddRange
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange<U>(void* ptr, int count, int startIndex)
            where U : BitInt
        {
            int oldLength = Length;
            Resize(oldLength + count, NativeArrayOptions.UninitializedMemory);

            PackUnpack.CopyConvert<U, T>(ptr, startIndex, GetUnsafePtr(), oldLength, count);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(sbyte* ptr, int sbytes, int startIndex)
        {
            AddRange<Int8>(ptr, sbytes, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(byte* ptr, int bytes, int startIndex)
        {
            AddRange<UInt8>(ptr, bytes, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(short* ptr, int shorts, int startIndex)
        {
            AddRange<Int16>(ptr, shorts, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(ushort* ptr, int ushorts, int startIndex)
        {
            AddRange<UInt16>(ptr, ushorts, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(Int24* ptr, int Int24s, int startIndex)
        {
            AddRange<Int24>(ptr, Int24s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(UInt24* ptr, int Int24s, int startIndex)
        {
            AddRange<Int24>(ptr, Int24s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(int* ptr, int ints, int startIndex)
        {
            AddRange<Int24>(ptr, ints, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(uint* ptr, int ints, int startIndex)
        {
            AddRange<Int24>(ptr, ints, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(Int40* ptr, int Int40s, int startIndex)
        {
            AddRange<Int40>(ptr, Int40s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(UInt40* ptr, int Int40s, int startIndex)
        {
            AddRange<UInt40>(ptr, Int40s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(Int48* ptr, int Int48s, int startIndex)
        {
            AddRange<Int48>(ptr, Int48s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(UInt48* ptr, int Int48s, int startIndex)
        {
            AddRange<UInt48>(ptr, Int48s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(Int56* ptr, int Int56s, int startIndex)
        {
            AddRange<Int56>(ptr, Int56s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(UInt56* ptr, int Int56s, int startIndex)
        {
            AddRange<UInt56>(ptr, Int56s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(long* ptr, int longs, int startIndex)
        {
            int oldLength = Length;
            Resize(oldLength + longs, NativeArrayOptions.UninitializedMemory);

            for (int i = 0; i < longs; i++)
            {
                this[oldLength++] = (long)ptr[startIndex++];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(ulong* ptr, int longs, int startIndex)
        {
            int oldLength = Length;
            Resize(oldLength + longs, NativeArrayOptions.UninitializedMemory);

            for (int i = 0; i < longs; i++)
            {
                this[oldLength++] = (long)ptr[startIndex++];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(Int128* ptr, int longs, int startIndex)
        {
            int oldLength = Length;
            Resize(oldLength + longs, NativeArrayOptions.UninitializedMemory);

            for (int i = 0; i < longs; i++)
            {
                this[oldLength++] = (long)ptr[startIndex++];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(UInt128* ptr, int longs, int startIndex)
        {
            int oldLength = Length;
            Resize(oldLength + longs, NativeArrayOptions.UninitializedMemory);

            for (int i = 0; i < longs; i++)
            {
                this[oldLength++] = (long)ptr[startIndex++];
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(sbyte[] array, int sbytes, int startIndex)
        {
            fixed (sbyte* ptr = array)
            {
                AddRange(ptr, sbytes, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(byte[] array, int bytes, int startIndex)
        {
            fixed (byte* ptr = array)
            {
                AddRange(ptr, bytes, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(short[] array, int shorts, int startIndex)
        {
            fixed (short* ptr = array)
            {
                AddRange(ptr, shorts, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(ushort[] array, int ushorts, int startIndex)
        {
            fixed (ushort* ptr = array)
            {
                AddRange(ptr, ushorts, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(Int24[] array, int Int24s, int startIndex)
        {
            fixed (Int24* ptr = array)
            {
                AddRange(ptr, Int24s, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(UInt24[] array, int Int24s, int startIndex)
        {
            fixed (UInt24* ptr = array)
            {
                AddRange(ptr, Int24s, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(int[] array, int ints, int startIndex)
        {
            fixed (int* ptr = array)
            {
                AddRange(ptr, ints, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(uint[] array, int ints, int startIndex)
        {
            fixed (uint* ptr = array)
            {
                AddRange(ptr, ints, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(Int40[] array, int Int40s, int startIndex)
        {
            fixed (Int40* ptr = array)
            {
                AddRange(ptr, Int40s, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(UInt40[] array, int Int40s, int startIndex)
        {
            fixed (UInt40* ptr = array)
            {
                AddRange(ptr, Int40s, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(Int48[] array, int Int48s, int startIndex)
        {
            fixed (Int48* ptr = array)
            {
                AddRange(ptr, Int48s, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(UInt48[] array, int Int48s, int startIndex)
        {
            fixed (UInt48* ptr = array)
            {
                AddRange(ptr, Int48s, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(Int56[] array, int Int56s, int startIndex)
        {
            fixed (Int56* ptr = array)
            {
                AddRange(ptr, Int56s, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(UInt56[] array, int Int56s, int startIndex)
        {
            fixed (UInt56* ptr = array)
            {
                AddRange(ptr, Int56s, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(long[] array, int longs, int startIndex)
        {
            fixed (long* ptr = array)
            {
                AddRange(ptr, longs, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(ulong[] array, int longs, int startIndex)
        {
            fixed (ulong* ptr = array)
            {
                AddRange(ptr, longs, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(Int128[] array, int longs, int startIndex)
        {
            fixed (Int128* ptr = array)
            {
                AddRange(ptr, longs, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(UInt128[] array, int longs, int startIndex)
        {
            fixed (UInt128* ptr = array)
            {
                AddRange(ptr, longs, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(IEnumerable<byte> array, int count, int startIndex)
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            Resize(Length + count, NativeArrayOptions.UninitializedMemory);
            IEnumerator<byte> enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Add(enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(IEnumerable<sbyte> array, int count, int startIndex)
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            Resize(Length + count, NativeArrayOptions.UninitializedMemory);
            IEnumerator<sbyte> enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Add(enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(IEnumerable<ushort> array, int count, int startIndex)
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            Resize(Length + count, NativeArrayOptions.UninitializedMemory);
            IEnumerator<ushort> enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Add(enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(IEnumerable<short> array, int count, int startIndex)
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            Resize(Length + count, NativeArrayOptions.UninitializedMemory);
            IEnumerator<short> enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Add(enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(IEnumerable<UInt24> array, int count, int startIndex)
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            Resize(Length + count, NativeArrayOptions.UninitializedMemory);
            IEnumerator<UInt24> enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Add(enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(IEnumerable<Int24> array, int count, int startIndex)
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            Resize(Length + count, NativeArrayOptions.UninitializedMemory);
            IEnumerator<Int24> enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Add(enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(IEnumerable<uint> array, int count, int startIndex)
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            Resize(Length + count, NativeArrayOptions.UninitializedMemory);
            IEnumerator<uint> enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Add(enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(IEnumerable<int> array, int count, int startIndex)
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            Resize(Length + count, NativeArrayOptions.UninitializedMemory);
            IEnumerator<int> enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Add(enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(IEnumerable<UInt40> array, int count, int startIndex)
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            Resize(Length + count, NativeArrayOptions.UninitializedMemory);
            IEnumerator<UInt40> enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Add(enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(IEnumerable<Int40> array, int count, int startIndex)
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            Resize(Length + count, NativeArrayOptions.UninitializedMemory);
            IEnumerator<Int40> enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Add(enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(IEnumerable<UInt48> array, int count, int startIndex)
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            Resize(Length + count, NativeArrayOptions.UninitializedMemory);
            IEnumerator<UInt48> enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Add(enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(IEnumerable<Int48> array, int count, int startIndex)
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            Resize(Length + count, NativeArrayOptions.UninitializedMemory);
            IEnumerator<Int48> enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Add(enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(IEnumerable<UInt56> array, int count, int startIndex)
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            Resize(Length + count, NativeArrayOptions.UninitializedMemory);
            IEnumerator<UInt56> enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Add(enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(IEnumerable<Int56> array, int count, int startIndex)
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            Resize(Length + count, NativeArrayOptions.UninitializedMemory);
            IEnumerator<Int56> enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Add(enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(IEnumerable<ulong> array, int count, int startIndex)
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            Resize(Length + count, NativeArrayOptions.UninitializedMemory);
            IEnumerator<ulong> enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Add((long)enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(IEnumerable<long> array, int count, int startIndex)
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            Resize(Length + count, NativeArrayOptions.UninitializedMemory);
            IEnumerator<long> enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Add(enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(IEnumerable<UInt128> array, int count, int startIndex)
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            Resize(Length + count, NativeArrayOptions.UninitializedMemory);
            IEnumerator<UInt128> enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Add((long)enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(IEnumerable<Int128> array, int count, int startIndex)
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            Resize(Length + count, NativeArrayOptions.UninitializedMemory);
            IEnumerator<Int128> enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Add((long)enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange<U>(NativeBitIntArray<U> array, int count, int startIndex)
            where U : BitInt
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Length);
Assert.IsNotGreater(count, array.Length - startIndex);

            AddRange<U>(array.GetUnsafeReadOnlyPtr(), count, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange<U>(NativeBitIntList<U> array, int count, int startIndex)
            where U : BitInt
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Length);
Assert.IsNotGreater(count, array.Length - startIndex);

            AddRange<U>(array.GetUnsafeReadOnlyPtr(), count, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<sbyte> array, int sbytes, int startIndex)
        {
            AddRange<Int8>(array.GetUnsafeReadOnlyPtr(), sbytes, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<byte> array, int bytes, int startIndex)
        {
            AddRange<UInt8>(array.GetUnsafeReadOnlyPtr(), bytes, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<short> array, int shorts, int startIndex)
        {
            AddRange<Int16>(array.GetUnsafeReadOnlyPtr(), shorts, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<ushort> array, int ushorts, int startIndex)
        {
            AddRange<UInt16>(array.GetUnsafeReadOnlyPtr(), ushorts, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<Int24> array, int Int24s, int startIndex)
        {
            AddRange<Int24>(array.GetUnsafeReadOnlyPtr(), Int24s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<UInt24> array, int Int24s, int startIndex)
        {
            AddRange<Int24>(array.GetUnsafeReadOnlyPtr(), Int24s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<int> array, int ints, int startIndex)
        {
            AddRange<Int24>(array.GetUnsafeReadOnlyPtr(), ints, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<uint> array, int ints, int startIndex)
        {
            AddRange<Int24>(array.GetUnsafeReadOnlyPtr(), ints, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<Int40> array, int Int40s, int startIndex)
        {
            AddRange<Int40>(array.GetUnsafeReadOnlyPtr(), Int40s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<UInt40> array, int Int40s, int startIndex)
        {
            AddRange<UInt40>(array.GetUnsafeReadOnlyPtr(), Int40s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<Int48> array, int Int48s, int startIndex)
        {
            AddRange<Int48>(array.GetUnsafeReadOnlyPtr(), Int48s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<UInt48> array, int Int48s, int startIndex)
        {
            AddRange<UInt48>(array.GetUnsafeReadOnlyPtr(), Int48s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<Int56> array, int Int56s, int startIndex)
        {
            AddRange<Int56>(array.GetUnsafeReadOnlyPtr(), Int56s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<UInt56> array, int Int56s, int startIndex)
        {
            AddRange<UInt56>(array.GetUnsafeReadOnlyPtr(), Int56s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<long> array, int longs, int startIndex)
        {
            AddRange((long*)array.GetUnsafeReadOnlyPtr(), longs, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<ulong> array, int longs, int startIndex)
        {
            AddRange((ulong*)array.GetUnsafeReadOnlyPtr(), longs, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<Int128> array, int longs, int startIndex)
        {
            AddRange((Int128*)array.GetUnsafeReadOnlyPtr(), longs, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<UInt128> array, int longs, int startIndex)
        {
            AddRange((UInt128*)array.GetUnsafeReadOnlyPtr(), longs, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<sbyte> array, int sbytes, int startIndex)
        {
            AddRange<Int8>(array.GetUnsafeReadOnlyPtr(), sbytes, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<byte> array, int bytes, int startIndex)
        {
            AddRange<UInt8>(array.GetUnsafeReadOnlyPtr(), bytes, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<short> array, int shorts, int startIndex)
        {
            AddRange<Int16>(array.GetUnsafeReadOnlyPtr(), shorts, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<ushort> array, int ushorts, int startIndex)
        {
            AddRange<UInt16>(array.GetUnsafeReadOnlyPtr(), ushorts, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<Int24> array, int Int24s, int startIndex)
        {
            AddRange<Int24>(array.GetUnsafeReadOnlyPtr(), Int24s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<UInt24> array, int Int24s, int startIndex)
        {
            AddRange<UInt24>(array.GetUnsafeReadOnlyPtr(), Int24s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<int> array, int ints, int startIndex)
        {
            AddRange<Int32>(array.GetUnsafeReadOnlyPtr(), ints, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<uint> array, int ints, int startIndex)
        {
            AddRange<UInt32>(array.GetUnsafeReadOnlyPtr(), ints, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<Int40> array, int Int40s, int startIndex)
        {
            AddRange<Int40>(array.GetUnsafeReadOnlyPtr(), Int40s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<UInt40> array, int Int40s, int startIndex)
        {
            AddRange<UInt40>(array.GetUnsafeReadOnlyPtr(), Int40s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<Int48> array, int Int48s, int startIndex)
        {
            AddRange<Int48>(array.GetUnsafeReadOnlyPtr(), Int48s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<UInt48> array, int Int48s, int startIndex)
        {
            AddRange<UInt48>(array.GetUnsafeReadOnlyPtr(), Int48s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<Int56> array, int Int56s, int startIndex)
        {
            AddRange<Int56>(array.GetUnsafeReadOnlyPtr(), Int56s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<UInt56> array, int Int56s, int startIndex)
        {
            AddRange<UInt56>(array.GetUnsafeReadOnlyPtr(), Int56s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<long> array, int longs, int startIndex)
        {
            AddRange((long*)array.GetUnsafeReadOnlyPtr(), longs, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<ulong> array, int longs, int startIndex)
        {
            AddRange((ulong*)array.GetUnsafeReadOnlyPtr(), longs, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<Int128> array, int longs, int startIndex)
        {
            AddRange((Int128*)array.GetUnsafeReadOnlyPtr(), longs, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<UInt128> array, int longs, int startIndex)
        {
            AddRange((UInt128*)array.GetUnsafeReadOnlyPtr(), longs, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<sbyte> array, int sbytes, int startIndex)
        {
            AddRange<Int8>(array.GetUnsafeReadOnlyPtr(), sbytes, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<byte> array, int bytes, int startIndex)
        {
            AddRange<UInt8>(array.GetUnsafeReadOnlyPtr(), bytes, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<short> array, int shorts, int startIndex)
        {
            AddRange<Int16>(array.GetUnsafeReadOnlyPtr(), shorts, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<ushort> array, int ushorts, int startIndex)
        {
            AddRange<UInt16>(array.GetUnsafeReadOnlyPtr(), ushorts, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<Int24> array, int Int24s, int startIndex)
        {
            AddRange<Int24>(array.GetUnsafeReadOnlyPtr(), Int24s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<UInt24> array, int Int24s, int startIndex)
        {
            AddRange<Int24>(array.GetUnsafeReadOnlyPtr(), Int24s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<int> array, int ints, int startIndex)
        {
            AddRange<Int24>(array.GetUnsafeReadOnlyPtr(), ints, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<uint> array, int ints, int startIndex)
        {
            AddRange<Int24>(array.GetUnsafeReadOnlyPtr(), ints, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<Int40> array, int Int40s, int startIndex)
        {
            AddRange<Int40>(array.GetUnsafeReadOnlyPtr(), Int40s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<UInt40> array, int Int40s, int startIndex)
        {
            AddRange<UInt40>(array.GetUnsafeReadOnlyPtr(), Int40s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<Int48> array, int Int48s, int startIndex)
        {
            AddRange<Int48>(array.GetUnsafeReadOnlyPtr(), Int48s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<UInt48> array, int Int48s, int startIndex)
        {
            AddRange<UInt48>(array.GetUnsafeReadOnlyPtr(), Int48s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<Int56> array, int Int56s, int startIndex)
        {
            AddRange<Int56>(array.GetUnsafeReadOnlyPtr(), Int56s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<UInt56> array, int Int56s, int startIndex)
        {
            AddRange<UInt56>(array.GetUnsafeReadOnlyPtr(), Int56s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<long> array, int longs, int startIndex)
        {
            AddRange((long*)array.GetUnsafeReadOnlyPtr(), longs, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<ulong> array, int longs, int startIndex)
        {
            AddRange((ulong*)array.GetUnsafeReadOnlyPtr(), longs, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<Int128> array, int longs, int startIndex)
        {
            AddRange((Int128*)array.GetUnsafeReadOnlyPtr(), longs, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<UInt128> array, int longs, int startIndex)
        {
            AddRange((UInt128*)array.GetUnsafeReadOnlyPtr(), longs, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(sbyte[] array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(byte[] array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(short[] array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(ushort[] array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(Int24[] array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(UInt24[] array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(int[] array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(uint[] array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(Int40[] array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(UInt40[] array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(Int48[] array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(UInt48[] array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(Int56[] array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(UInt56[] array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(long[] array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(ulong[] array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(Int128[] array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(UInt128[] array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(IEnumerable<byte> array)
        {
            AddRange(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(IEnumerable<sbyte> array)
        {
            AddRange(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(IEnumerable<ushort> array)
        {
            AddRange(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(IEnumerable<short> array)
        {
            AddRange(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(IEnumerable<UInt24> array)
        {
            AddRange(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(IEnumerable<Int24> array)
        {
            AddRange(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(IEnumerable<uint> array)
        {
            AddRange(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(IEnumerable<int> array)
        {
            AddRange(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(IEnumerable<UInt40> array)
        {
            AddRange(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(IEnumerable<Int40> array)
        {
            AddRange(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(IEnumerable<UInt48> array)
        {
            AddRange(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(IEnumerable<Int48> array)
        {
            AddRange(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(IEnumerable<UInt56> array)
        {
            AddRange(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(IEnumerable<Int56> array)
        {
            AddRange(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(IEnumerable<ulong> array)
        {
            AddRange(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(IEnumerable<long> array)
        {
            AddRange(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(IEnumerable<UInt128> array)
        {
            AddRange(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(IEnumerable<Int128> array)
        {
            AddRange(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange<U>(NativeBitIntArray<U> array)
            where U : BitInt
        {
            AddRange<U>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange<U>(NativeBitIntList<U> array)
            where U : BitInt
        {
            AddRange<U>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<sbyte> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<byte> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<short> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<ushort> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<Int24> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<UInt24> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<int> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<uint> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<Int40> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<UInt40> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<Int48> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<UInt48> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<Int56> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<UInt56> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<long> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<ulong> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<Int128> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<UInt128> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<sbyte> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<byte> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<short> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<ushort> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<Int24> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<UInt24> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<int> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<uint> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<Int40> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<UInt40> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<Int48> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<UInt48> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<Int56> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<UInt56> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<long> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<ulong> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<Int128> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<UInt128> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<sbyte> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<byte> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<short> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<ushort> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<Int24> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<UInt24> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<int> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<uint> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<Int40> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<UInt40> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<Int48> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<UInt48> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<Int56> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<UInt56> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<long> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<ulong> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<Int128> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<UInt128> array)
        {
            AddRange(array, array.Length, 0);
        }
        #endregion

        #region AddRangeNoResize
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize<U>(void* ptr, int count, int startIndex)
            where U : BitInt
        {
            IncLengthNoResize(count, out int oldLength);

            PackUnpack.CopyConvert<U, T>(ptr, startIndex, GetUnsafePtr(), oldLength, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(sbyte* ptr, int sbytes, int startIndex)
        {
            AddRangeNoResize<Int8>(ptr, sbytes, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(byte* ptr, int bytes, int startIndex)
        {
            AddRangeNoResize<UInt8>(ptr, bytes, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(short* ptr, int shorts, int startIndex)
        {
            AddRangeNoResize<Int16>(ptr, shorts, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(ushort* ptr, int ushorts, int startIndex)
        {
            AddRangeNoResize<UInt16>(ptr, ushorts, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(Int24* ptr, int Int24s, int startIndex)
        {
            AddRangeNoResize<Int24>(ptr, Int24s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(UInt24* ptr, int Int24s, int startIndex)
        {
            AddRangeNoResize<Int24>(ptr, Int24s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(int* ptr, int ints, int startIndex)
        {
            AddRangeNoResize<Int24>(ptr, ints, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(uint* ptr, int ints, int startIndex)
        {
            AddRangeNoResize<Int24>(ptr, ints, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(Int40* ptr, int Int40s, int startIndex)
        {
            AddRangeNoResize<Int40>(ptr, Int40s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(UInt40* ptr, int Int40s, int startIndex)
        {
            AddRangeNoResize<UInt40>(ptr, Int40s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(Int48* ptr, int Int48s, int startIndex)
        {
            AddRangeNoResize<Int48>(ptr, Int48s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(UInt48* ptr, int Int48s, int startIndex)
        {
            AddRangeNoResize<UInt48>(ptr, Int48s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(Int56* ptr, int Int56s, int startIndex)
        {
            AddRangeNoResize<Int56>(ptr, Int56s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(UInt56* ptr, int Int56s, int startIndex)
        {
            AddRangeNoResize<UInt56>(ptr, Int56s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(long* ptr, int longs, int startIndex)
        {
            IncLengthNoResize(longs, out int oldLength);

            for (int i = 0; i < longs; i++)
            {
                AddNoResize(ptr[startIndex++]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(ulong* ptr, int longs, int startIndex)
        {
            IncLengthNoResize(longs, out int oldLength);

            for (int i = 0; i < longs; i++)
            {
                AddNoResize((long)ptr[startIndex++]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(Int128* ptr, int longs, int startIndex)
        {
            IncLengthNoResize(longs, out int oldLength);

            for (int i = 0; i < longs; i++)
            {
                AddNoResize((long)ptr[startIndex++]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(UInt128* ptr, int longs, int startIndex)
        {
            IncLengthNoResize(longs, out int oldLength);

            for (int i = 0; i < longs; i++)
            {
                AddNoResize((long)ptr[startIndex++]);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(sbyte[] array, int sbytes, int startIndex)
        {
            fixed (sbyte* ptr = array)
            {
                AddRangeNoResize(ptr, sbytes, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(byte[] array, int bytes, int startIndex)
        {
            fixed (byte* ptr = array)
            {
                AddRangeNoResize(ptr, bytes, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(short[] array, int shorts, int startIndex)
        {
            fixed (short* ptr = array)
            {
                AddRangeNoResize(ptr, shorts, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(ushort[] array, int ushorts, int startIndex)
        {
            fixed (ushort* ptr = array)
            {
                AddRangeNoResize(ptr, ushorts, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(Int24[] array, int Int24s, int startIndex)
        {
            fixed (Int24* ptr = array)
            {
                AddRangeNoResize(ptr, Int24s, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(UInt24[] array, int Int24s, int startIndex)
        {
            fixed (UInt24* ptr = array)
            {
                AddRangeNoResize(ptr, Int24s, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(int[] array, int ints, int startIndex)
        {
            fixed (int* ptr = array)
            {
                AddRangeNoResize(ptr, ints, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(uint[] array, int ints, int startIndex)
        {
            fixed (uint* ptr = array)
            {
                AddRangeNoResize(ptr, ints, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(Int40[] array, int Int40s, int startIndex)
        {
            fixed (Int40* ptr = array)
            {
                AddRangeNoResize(ptr, Int40s, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(UInt40[] array, int Int40s, int startIndex)
        {
            fixed (UInt40* ptr = array)
            {
                AddRangeNoResize(ptr, Int40s, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(Int48[] array, int Int48s, int startIndex)
        {
            fixed (Int48* ptr = array)
            {
                AddRangeNoResize(ptr, Int48s, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(UInt48[] array, int Int48s, int startIndex)
        {
            fixed (UInt48* ptr = array)
            {
                AddRangeNoResize(ptr, Int48s, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(Int56[] array, int Int56s, int startIndex)
        {
            fixed (Int56* ptr = array)
            {
                AddRangeNoResize(ptr, Int56s, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(UInt56[] array, int Int56s, int startIndex)
        {
            fixed (UInt56* ptr = array)
            {
                AddRangeNoResize(ptr, Int56s, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(long[] array, int longs, int startIndex)
        {
            fixed (long* ptr = array)
            {
                AddRangeNoResize(ptr, longs, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(ulong[] array, int longs, int startIndex)
        {
            fixed (ulong* ptr = array)
            {
                AddRangeNoResize(ptr, longs, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(Int128[] array, int longs, int startIndex)
        {
            fixed (Int128* ptr = array)
            {
                AddRangeNoResize(ptr, longs, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(UInt128[] array, int longs, int startIndex)
        {
            fixed (UInt128* ptr = array)
            {
                AddRangeNoResize(ptr, longs, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(IEnumerable<byte> array, int count, int startIndex)
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            IncLengthNoResize(count, out int oldLength);
            IEnumerator<byte> enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                AddNoResize(enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(IEnumerable<sbyte> array, int count, int startIndex)
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            IncLengthNoResize(count, out int oldLength);
            IEnumerator<sbyte> enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                AddNoResize(enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(IEnumerable<ushort> array, int count, int startIndex)
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            IncLengthNoResize(count, out int oldLength);
            IEnumerator<ushort> enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                AddNoResize(enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(IEnumerable<short> array, int count, int startIndex)
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            IncLengthNoResize(count, out int oldLength);
            IEnumerator<short> enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                AddNoResize(enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(IEnumerable<UInt24> array, int count, int startIndex)
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            IncLengthNoResize(count, out int oldLength);
            IEnumerator<UInt24> enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                AddNoResize(enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(IEnumerable<Int24> array, int count, int startIndex)
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            IncLengthNoResize(count, out int oldLength);
            IEnumerator<Int24> enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                AddNoResize(enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(IEnumerable<uint> array, int count, int startIndex)
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            IncLengthNoResize(count, out int oldLength);
            IEnumerator<uint> enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                AddNoResize(enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(IEnumerable<int> array, int count, int startIndex)
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            IncLengthNoResize(count, out int oldLength);
            IEnumerator<int> enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                AddNoResize(enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(IEnumerable<UInt40> array, int count, int startIndex)
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            IncLengthNoResize(count, out int oldLength);
            IEnumerator<UInt40> enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                AddNoResize(enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(IEnumerable<Int40> array, int count, int startIndex)
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            IncLengthNoResize(count, out int oldLength);
            IEnumerator<Int40> enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                AddNoResize(enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(IEnumerable<UInt48> array, int count, int startIndex)
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            IncLengthNoResize(count, out int oldLength);
            IEnumerator<UInt48> enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                AddNoResize(enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(IEnumerable<Int48> array, int count, int startIndex)
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            IncLengthNoResize(count, out int oldLength);
            IEnumerator<Int48> enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                AddNoResize(enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(IEnumerable<UInt56> array, int count, int startIndex)
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            IncLengthNoResize(count, out int oldLength);
            IEnumerator<UInt56> enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                AddNoResize(enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(IEnumerable<Int56> array, int count, int startIndex)
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            IncLengthNoResize(count, out int oldLength);
            IEnumerator<Int56> enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                AddNoResize(enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(IEnumerable<ulong> array, int count, int startIndex)
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            IncLengthNoResize(count, out int oldLength);
            IEnumerator<ulong> enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Add((long)enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(IEnumerable<long> array, int count, int startIndex)
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            IncLengthNoResize(count, out int oldLength);
            IEnumerator<long> enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                AddNoResize(enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(IEnumerable<UInt128> array, int count, int startIndex)
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            IncLengthNoResize(count, out int oldLength);
            IEnumerator<UInt128> enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Add((long)enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(IEnumerable<Int128> array, int count, int startIndex)
        {
if (array.Count() != 0) Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            IncLengthNoResize(count, out int oldLength);
            IEnumerator<Int128> enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                AddNoResize((long)enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize<U>(NativeBitIntArray<U> array, int count, int startIndex)
            where U : BitInt
        {
if (Length != 0) Assert.IsWithinArrayBounds(startIndex, array.Length);
Assert.IsNotGreater(count, array.Length - startIndex);

            AddRangeNoResize<U>(array.GetUnsafeReadOnlyPtr(), count, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize<U>(NativeBitIntList<U> array, int count, int startIndex)
            where U : BitInt
        {
if (Length != 0) Assert.IsWithinArrayBounds(startIndex, array.Length);
Assert.IsNotGreater(count, array.Length - startIndex);

            AddRangeNoResize<U>(array.GetUnsafeReadOnlyPtr(), count, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<sbyte> array, int sbytes, int startIndex)
        {
            AddRangeNoResize<Int8>(array.GetUnsafeReadOnlyPtr(), sbytes, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<byte> array, int bytes, int startIndex)
        {
            AddRangeNoResize<UInt8>(array.GetUnsafeReadOnlyPtr(), bytes, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<short> array, int shorts, int startIndex)
        {
            AddRangeNoResize<Int16>(array.GetUnsafeReadOnlyPtr(), shorts, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<ushort> array, int ushorts, int startIndex)
        {
            AddRangeNoResize<UInt16>(array.GetUnsafeReadOnlyPtr(), ushorts, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<Int24> array, int Int24s, int startIndex)
        {
            AddRangeNoResize<Int24>(array.GetUnsafeReadOnlyPtr(), Int24s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<UInt24> array, int Int24s, int startIndex)
        {
            AddRangeNoResize<Int24>(array.GetUnsafeReadOnlyPtr(), Int24s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<int> array, int ints, int startIndex)
        {
            AddRangeNoResize<Int24>(array.GetUnsafeReadOnlyPtr(), ints, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<uint> array, int ints, int startIndex)
        {
            AddRangeNoResize<Int24>(array.GetUnsafeReadOnlyPtr(), ints, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<Int40> array, int Int40s, int startIndex)
        {
            AddRangeNoResize<Int40>(array.GetUnsafeReadOnlyPtr(), Int40s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<UInt40> array, int Int40s, int startIndex)
        {
            AddRangeNoResize<UInt40>(array.GetUnsafeReadOnlyPtr(), Int40s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<Int48> array, int Int48s, int startIndex)
        {
            AddRangeNoResize<Int48>(array.GetUnsafeReadOnlyPtr(), Int48s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<UInt48> array, int Int48s, int startIndex)
        {
            AddRangeNoResize<UInt48>(array.GetUnsafeReadOnlyPtr(), Int48s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<Int56> array, int Int56s, int startIndex)
        {
            AddRangeNoResize<Int56>(array.GetUnsafeReadOnlyPtr(), Int56s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<UInt56> array, int Int56s, int startIndex)
        {
            AddRangeNoResize<UInt56>(array.GetUnsafeReadOnlyPtr(), Int56s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<long> array, int longs, int startIndex)
        {
            AddRangeNoResize((long*)array.GetUnsafeReadOnlyPtr(), longs, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<ulong> array, int longs, int startIndex)
        {
            AddRangeNoResize((ulong*)array.GetUnsafeReadOnlyPtr(), longs, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<Int128> array, int longs, int startIndex)
        {
            AddRangeNoResize((Int128*)array.GetUnsafeReadOnlyPtr(), longs, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<UInt128> array, int longs, int startIndex)
        {
            AddRangeNoResize((Int128*)array.GetUnsafeReadOnlyPtr(), longs, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<sbyte> array, int sbytes, int startIndex)
        {
            AddRangeNoResize<Int8>(array.GetUnsafeReadOnlyPtr(), sbytes, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<byte> array, int bytes, int startIndex)
        {
            AddRangeNoResize<UInt8>(array.GetUnsafeReadOnlyPtr(), bytes, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<short> array, int shorts, int startIndex)
        {
            AddRangeNoResize<Int16>(array.GetUnsafeReadOnlyPtr(), shorts, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<ushort> array, int ushorts, int startIndex)
        {
            AddRangeNoResize<UInt16>(array.GetUnsafeReadOnlyPtr(), ushorts, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<Int24> array, int Int24s, int startIndex)
        {
            AddRangeNoResize<Int24>(array.GetUnsafeReadOnlyPtr(), Int24s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<UInt24> array, int Int24s, int startIndex)
        {
            AddRangeNoResize<Int24>(array.GetUnsafeReadOnlyPtr(), Int24s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<int> array, int ints, int startIndex)
        {
            AddRangeNoResize<Int24>(array.GetUnsafeReadOnlyPtr(), ints, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<uint> array, int ints, int startIndex)
        {
            AddRangeNoResize<Int24>(array.GetUnsafeReadOnlyPtr(), ints, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<Int40> array, int Int40s, int startIndex)
        {
            AddRangeNoResize<Int40>(array.GetUnsafeReadOnlyPtr(), Int40s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<UInt40> array, int Int40s, int startIndex)
        {
            AddRangeNoResize<UInt40>(array.GetUnsafeReadOnlyPtr(), Int40s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<Int48> array, int Int48s, int startIndex)
        {
            AddRangeNoResize<Int48>(array.GetUnsafeReadOnlyPtr(), Int48s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<UInt48> array, int Int48s, int startIndex)
        {
            AddRangeNoResize<UInt48>(array.GetUnsafeReadOnlyPtr(), Int48s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<Int56> array, int Int56s, int startIndex)
        {
            AddRangeNoResize<Int56>(array.GetUnsafeReadOnlyPtr(), Int56s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<UInt56> array, int Int56s, int startIndex)
        {
            AddRangeNoResize<UInt56>(array.GetUnsafeReadOnlyPtr(), Int56s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<long> array, int longs, int startIndex)
        {
            AddRangeNoResize((long*)array.GetUnsafeReadOnlyPtr(), longs, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<ulong> array, int longs, int startIndex)
        {
            AddRangeNoResize((ulong*)array.GetUnsafeReadOnlyPtr(), longs, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<Int128> array, int longs, int startIndex)
        {
            AddRangeNoResize((Int128*)array.GetUnsafeReadOnlyPtr(), longs, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<UInt128> array, int longs, int startIndex)
        {
            AddRangeNoResize((UInt128*)array.GetUnsafeReadOnlyPtr(), longs, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<sbyte> array, int sbytes, int startIndex)
        {
            AddRangeNoResize<Int8>(array.GetUnsafeReadOnlyPtr(), sbytes, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<byte> array, int bytes, int startIndex)
        {
            AddRangeNoResize<UInt8>(array.GetUnsafeReadOnlyPtr(), bytes, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<short> array, int shorts, int startIndex)
        {
            AddRangeNoResize<Int16>(array.GetUnsafeReadOnlyPtr(), shorts, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<ushort> array, int ushorts, int startIndex)
        {
            AddRangeNoResize<UInt16>(array.GetUnsafeReadOnlyPtr(), ushorts, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<Int24> array, int Int24s, int startIndex)
        {
            AddRangeNoResize<Int24>(array.GetUnsafeReadOnlyPtr(), Int24s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<UInt24> array, int Int24s, int startIndex)
        {
            AddRangeNoResize<Int24>(array.GetUnsafeReadOnlyPtr(), Int24s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<int> array, int ints, int startIndex)
        {
            AddRangeNoResize<Int24>(array.GetUnsafeReadOnlyPtr(), ints, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<uint> array, int ints, int startIndex)
        {
            AddRangeNoResize<Int24>(array.GetUnsafeReadOnlyPtr(), ints, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<Int40> array, int Int40s, int startIndex)
        {
            AddRangeNoResize<Int40>(array.GetUnsafeReadOnlyPtr(), Int40s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<UInt40> array, int Int40s, int startIndex)
        {
            AddRangeNoResize<UInt40>(array.GetUnsafeReadOnlyPtr(), Int40s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<Int48> array, int Int48s, int startIndex)
        {
            AddRangeNoResize<Int48>(array.GetUnsafeReadOnlyPtr(), Int48s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<UInt48> array, int Int48s, int startIndex)
        {
            AddRangeNoResize<UInt48>(array.GetUnsafeReadOnlyPtr(), Int48s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<Int56> array, int Int56s, int startIndex)
        {
            AddRangeNoResize<Int56>(array.GetUnsafeReadOnlyPtr(), Int56s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<UInt56> array, int Int56s, int startIndex)
        {
            AddRangeNoResize<UInt56>(array.GetUnsafeReadOnlyPtr(), Int56s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<long> array, int longs, int startIndex)
        {
            AddRangeNoResize((long*)array.GetUnsafeReadOnlyPtr(), longs, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<ulong> array, int longs, int startIndex)
        {
            AddRangeNoResize((ulong*)array.GetUnsafeReadOnlyPtr(), longs, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<Int128> array, int longs, int startIndex)
        {
            AddRangeNoResize((Int128*)array.GetUnsafeReadOnlyPtr(), longs, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<UInt128> array, int longs, int startIndex)
        {
            AddRangeNoResize((UInt128*)array.GetUnsafeReadOnlyPtr(), longs, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(sbyte[] array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(byte[] array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(short[] array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(ushort[] array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(Int24[] array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(UInt24[] array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(int[] array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(uint[] array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(Int40[] array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(UInt40[] array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(Int48[] array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(UInt48[] array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(Int56[] array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(UInt56[] array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(long[] array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(ulong[] array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(Int128[] array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(UInt128[] array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(IEnumerable<byte> array)
        {
            AddRangeNoResize(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(IEnumerable<sbyte> array)
        {
            AddRangeNoResize(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(IEnumerable<ushort> array)
        {
            AddRangeNoResize(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(IEnumerable<short> array)
        {
            AddRangeNoResize(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(IEnumerable<UInt24> array)
        {
            AddRangeNoResize(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(IEnumerable<Int24> array)
        {
            AddRangeNoResize(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(IEnumerable<uint> array)
        {
            AddRangeNoResize(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(IEnumerable<int> array)
        {
            AddRangeNoResize(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(IEnumerable<UInt40> array)
        {
            AddRangeNoResize(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(IEnumerable<Int40> array)
        {
            AddRangeNoResize(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(IEnumerable<UInt48> array)
        {
            AddRangeNoResize(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(IEnumerable<Int48> array)
        {
            AddRangeNoResize(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(IEnumerable<UInt56> array)
        {
            AddRangeNoResize(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(IEnumerable<Int56> array)
        {
            AddRangeNoResize(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(IEnumerable<ulong> array)
        {
            AddRangeNoResize(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(IEnumerable<long> array)
        {
            AddRangeNoResize(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(IEnumerable<UInt128> array)
        {
            AddRangeNoResize(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(IEnumerable<Int128> array)
        {
            AddRangeNoResize(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize<U>(NativeBitIntArray<U> array)
            where U : BitInt
        {
            AddRangeNoResize<U>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize<U>(NativeBitIntList<U> array)
            where U : BitInt
        {
            AddRangeNoResize<U>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<sbyte> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<byte> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<short> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<ushort> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<Int24> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<UInt24> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<int> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<uint> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<Int40> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<UInt40> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<Int48> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<UInt48> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<Int56> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<UInt56> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<long> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<ulong> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<Int128> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<UInt128> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<sbyte> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<byte> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<short> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<ushort> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<Int24> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<UInt24> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<int> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<uint> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<Int40> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<UInt40> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<Int48> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<UInt48> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<Int56> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<UInt56> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<long> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<ulong> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<Int128> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<UInt128> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<sbyte> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<byte> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<short> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<ushort> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<Int24> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<UInt24> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<int> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<uint> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<Int40> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<UInt40> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<Int48> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<UInt48> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<Int56> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<UInt56> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<long> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<ulong> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<Int128> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<UInt128> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }
        #endregion

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddReplicate(long value, int count)
        {
            int oldLength = Length;
            Resize(oldLength + count, NativeArrayOptions.UninitializedMemory);

            LoadStore.StoreReplicate<T>(GetUnsafePtr(), oldLength, count, value);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Insert(int index, long value)
        {
Assert.IsWithinArrayBounds(index, Length);

            int oldLength = Length;
            Resize(oldLength + 1, NativeArrayOptions.UninitializedMemory);
            LoadStore.Insert<T>(GetUnsafePtr(), oldLength, index, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, int count)
        {
            InsertRangeWithBeginEnd(index, index + count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRangeWithBeginEnd(int begin, int end)
        {
Assert.IsSmallerOrEqual(begin, end);
Assert.IsNonNegative(begin);

            int items = end - begin;
            if (items < 1)
            {
                return;
            }

            int oldLength = Length;
            Resize(oldLength + items, NativeArrayOptions.UninitializedMemory);
            int itemsToCopy = oldLength - begin;

            int i = Length - 1;
            int j = oldLength - tobyte(oldLength != 0);

            LoadStore.CopyDescending<T>(GetUnsafePtr(), j, GetUnsafePtr(), i, itemsToCopy);
        }

        #region InsertRange
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange<U>(int index, void* ptr, int count, int srcIndex)
            where U : BitInt
        {
            InsertRange(index, count);
            PackUnpack.CopyConvert<U, T>(ptr, srcIndex, GetUnsafePtr(), index, count, true);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, sbyte* ptr, int sbytes, int startIndex)
        {
            InsertRange<Int8>(index, ptr, sbytes, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, byte* ptr, int bytes, int startIndex)
        {
            InsertRange<UInt8>(index, ptr, bytes, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, short* ptr, int shorts, int startIndex)
        {
            InsertRange<Int16>(index, ptr, shorts, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, ushort* ptr, int ushorts, int startIndex)
        {
            InsertRange<UInt16>(index, ptr, ushorts, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, Int24* ptr, int Int24s, int startIndex)
        {
            InsertRange<Int24>(index, ptr, Int24s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, UInt24* ptr, int Int24s, int startIndex)
        {
            InsertRange<Int24>(index, ptr, Int24s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, int* ptr, int ints, int startIndex)
        {
            InsertRange<Int24>(index, ptr, ints, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, uint* ptr, int ints, int startIndex)
        {
            InsertRange<Int24>(index, ptr, ints, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, Int40* ptr, int Int40s, int startIndex)
        {
            InsertRange<Int40>(index, ptr, Int40s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, UInt40* ptr, int Int40s, int startIndex)
        {
            InsertRange<UInt40>(index, ptr, Int40s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, Int48* ptr, int Int48s, int startIndex)
        {
            InsertRange<Int48>(index, ptr, Int48s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, UInt48* ptr, int Int48s, int startIndex)
        {
            InsertRange<UInt48>(index, ptr, Int48s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, Int56* ptr, int Int56s, int startIndex)
        {
            InsertRange<Int56>(index, ptr, Int56s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, UInt56* ptr, int Int56s, int startIndex)
        {
            InsertRange<UInt56>(index, ptr, Int56s, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, long* ptr, int longs, int startIndex)
        {
            InsertRange(index, longs);

            for (int i = 0; i < longs; i++)
            {
                this[index++] = ptr[startIndex++];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, ulong* ptr, int longs, int startIndex)
        {
            InsertRange(index, longs);

            for (int i = 0; i < longs; i++)
            {
                this[index++] = (long)ptr[startIndex++];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, Int128* ptr, int longs, int startIndex)
        {
            InsertRange(index, longs);

            for (int i = 0; i < longs; i++)
            {
                this[index++] = (long)ptr[startIndex++];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, UInt128* ptr, int longs, int startIndex)
        {
            InsertRange(index, longs);

            for (int i = 0; i < longs; i++)
            {
                this[index++] = (long)ptr[startIndex++];
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, sbyte[] array, int sbytes, int startIndex)
        {
            fixed (sbyte* ptr = array)
            {
                InsertRange(index, ptr, sbytes, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, byte[] array, int bytes, int startIndex)
        {
            fixed (byte* ptr = array)
            {
                InsertRange(index, ptr, bytes, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, short[] array, int shorts, int startIndex)
        {
            fixed (short* ptr = array)
            {
                InsertRange(index, ptr, shorts, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, ushort[] array, int ushorts, int startIndex)
        {
            fixed (ushort* ptr = array)
            {
                InsertRange(index, ptr, ushorts, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, Int24[] array, int Int24s, int startIndex)
        {
            fixed (Int24* ptr = array)
            {
                InsertRange(index, ptr, Int24s, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, UInt24[] array, int Int24s, int startIndex)
        {
            fixed (UInt24* ptr = array)
            {
                InsertRange(index, ptr, Int24s, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, int[] array, int ints, int startIndex)
        {
            fixed (int* ptr = array)
            {
                InsertRange(index, ptr, ints, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, uint[] array, int ints, int startIndex)
        {
            fixed (uint* ptr = array)
            {
                InsertRange(index, ptr, ints, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, Int40[] array, int Int40s, int startIndex)
        {
            fixed (Int40* ptr = array)
            {
                InsertRange(index, ptr, Int40s, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, UInt40[] array, int Int40s, int startIndex)
        {
            fixed (UInt40* ptr = array)
            {
                InsertRange(index, ptr, Int40s, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, Int48[] array, int Int48s, int startIndex)
        {
            fixed (Int48* ptr = array)
            {
                InsertRange(index, ptr, Int48s, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, UInt48[] array, int Int48s, int startIndex)
        {
            fixed (UInt48* ptr = array)
            {
                InsertRange(index, ptr, Int48s, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, Int56[] array, int Int56s, int startIndex)
        {
            fixed (Int56* ptr = array)
            {
                InsertRange(index, ptr, Int56s, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, UInt56[] array, int Int56s, int startIndex)
        {
            fixed (UInt56* ptr = array)
            {
                InsertRange(index, ptr, Int56s, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, long[] array, int longs, int startIndex)
        {
            fixed (long* ptr = array)
            {
                InsertRange(index, ptr, longs, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, ulong[] array, int longs, int startIndex)
        {
            fixed (ulong* ptr = array)
            {
                InsertRange(index, ptr, longs, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, Int128[] array, int longs, int startIndex)
        {
            fixed (Int128* ptr = array)
            {
                InsertRange(index, ptr, longs, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, UInt128[] array, int longs, int startIndex)
        {
            fixed (UInt128* ptr = array)
            {
                InsertRange(index, ptr, longs, startIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, IEnumerable<byte> array, int count, int startIndex)
        {
            InsertRange(index, count);
            IEnumerator<byte> enumerator = array.GetEnumerator();
            enumerator.MoveNext();
            for (int i = 0; i < startIndex; i++)
            {
                enumerator.MoveNext();
            }
            for (int i = 0; i < count; i++)
            {
                this[index++] = enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, IEnumerable<sbyte> array, int count, int startIndex)
        {
            InsertRange(index, count);
            IEnumerator<sbyte> enumerator = array.GetEnumerator();
            enumerator.MoveNext();
            for (int i = 0; i < startIndex; i++)
            {
                enumerator.MoveNext();
            }
            for (int i = 0; i < count; i++)
            {
                this[index++] = enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, IEnumerable<ushort> array, int count, int startIndex)
        {
            InsertRange(index, count);
            IEnumerator<ushort> enumerator = array.GetEnumerator();
            enumerator.MoveNext();
            for (int i = 0; i < startIndex; i++)
            {
                enumerator.MoveNext();
            }
            for (int i = 0; i < count; i++)
            {
                this[index++] = enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, IEnumerable<short> array, int count, int startIndex)
        {
            InsertRange(index, count);
            IEnumerator<short> enumerator = array.GetEnumerator();
            enumerator.MoveNext();
            for (int i = 0; i < startIndex; i++)
            {
                enumerator.MoveNext();
            }
            for (int i = 0; i < count; i++)
            {
                this[index++] = enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, IEnumerable<UInt24> array, int count, int startIndex)
        {
            InsertRange(index, count);
            IEnumerator<UInt24> enumerator = array.GetEnumerator();
            enumerator.MoveNext();
            for (int i = 0; i < startIndex; i++)
            {
                enumerator.MoveNext();
            }
            for (int i = 0; i < count; i++)
            {
                this[index++] = enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, IEnumerable<Int24> array, int count, int startIndex)
        {
            InsertRange(index, count);
            IEnumerator<Int24> enumerator = array.GetEnumerator();
            enumerator.MoveNext();
            for (int i = 0; i < startIndex; i++)
            {
                enumerator.MoveNext();
            }
            for (int i = 0; i < count; i++)
            {
                this[index++] = enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, IEnumerable<uint> array, int count, int startIndex)
        {
            InsertRange(index, count);
            IEnumerator<uint> enumerator = array.GetEnumerator();
            enumerator.MoveNext();
            for (int i = 0; i < startIndex; i++)
            {
                enumerator.MoveNext();
            }
            for (int i = 0; i < count; i++)
            {
                this[index++] = enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, IEnumerable<int> array, int count, int startIndex)
        {
            InsertRange(index, count);
            IEnumerator<int> enumerator = array.GetEnumerator();
            enumerator.MoveNext();
            for (int i = 0; i < startIndex; i++)
            {
                enumerator.MoveNext();
            }
            for (int i = 0; i < count; i++)
            {
                this[index++] = enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, IEnumerable<UInt40> array, int count, int startIndex)
        {
            InsertRange(index, count);
            IEnumerator<UInt40> enumerator = array.GetEnumerator();
            enumerator.MoveNext();
            for (int i = 0; i < startIndex; i++)
            {
                enumerator.MoveNext();
            }
            for (int i = 0; i < count; i++)
            {
                this[index++] = enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, IEnumerable<Int40> array, int count, int startIndex)
        {
            InsertRange(index, count);
            IEnumerator<Int40> enumerator = array.GetEnumerator();
            enumerator.MoveNext();
            for (int i = 0; i < startIndex; i++)
            {
                enumerator.MoveNext();
            }
            for (int i = 0; i < count; i++)
            {
                this[index++] = enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, IEnumerable<UInt48> array, int count, int startIndex)
        {
            InsertRange(index, count);
            IEnumerator<UInt48> enumerator = array.GetEnumerator();
            enumerator.MoveNext();
            for (int i = 0; i < startIndex; i++)
            {
                enumerator.MoveNext();
            }
            for (int i = 0; i < count; i++)
            {
                this[index++] = enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, IEnumerable<Int48> array, int count, int startIndex)
        {
            InsertRange(index, count);
            IEnumerator<Int48> enumerator = array.GetEnumerator();
            enumerator.MoveNext();
            for (int i = 0; i < startIndex; i++)
            {
                enumerator.MoveNext();
            }
            for (int i = 0; i < count; i++)
            {
                this[index++] = enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, IEnumerable<UInt56> array, int count, int startIndex)
        {
            InsertRange(index, count);
            IEnumerator<UInt56> enumerator = array.GetEnumerator();
            enumerator.MoveNext();
            for (int i = 0; i < startIndex; i++)
            {
                enumerator.MoveNext();
            }
            for (int i = 0; i < count; i++)
            {
                this[index++] = enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, IEnumerable<Int56> array, int count, int startIndex)
        {
            InsertRange(index, count);
            IEnumerator<Int56> enumerator = array.GetEnumerator();
            enumerator.MoveNext();
            for (int i = 0; i < startIndex; i++)
            {
                enumerator.MoveNext();
            }
            for (int i = 0; i < count; i++)
            {
                this[index++] = enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, IEnumerable<ulong> array, int count, int startIndex)
        {
            InsertRange(index, count);
            IEnumerator<ulong> enumerator = array.GetEnumerator();
            enumerator.MoveNext();
            for (int i = 0; i < startIndex; i++)
            {
                enumerator.MoveNext();
            }
            for (int i = 0; i < count; i++)
            {
                this[index++] = (long)enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, IEnumerable<long> array, int count, int startIndex)
        {
            InsertRange(index, count);
            IEnumerator<long> enumerator = array.GetEnumerator();
            enumerator.MoveNext();
            for (int i = 0; i < startIndex; i++)
            {
                enumerator.MoveNext();
            }
            for (int i = 0; i < count; i++)
            {
                this[index++] = enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, IEnumerable<UInt128> array, int count, int startIndex)
        {
            InsertRange(index, count);
            IEnumerator<UInt128> enumerator = array.GetEnumerator();
            enumerator.MoveNext();
            for (int i = 0; i < startIndex; i++)
            {
                enumerator.MoveNext();
            }
            for (int i = 0; i < count; i++)
            {
                this[index++] = (long)enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, IEnumerable<Int128> array, int count, int startIndex)
        {
            InsertRange(index, count);
            IEnumerator<Int128> enumerator = array.GetEnumerator();
            enumerator.MoveNext();
            for (int i = 0; i < startIndex; i++)
            {
                enumerator.MoveNext();
            }
            for (int i = 0; i < count; i++)
            {
                this[index++] = (long)enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange<U>(int index, NativeBitIntArray<U> array, int count, int srcStartIndex)
            where U : BitInt
        {
if (array.Length != 0) Assert.IsWithinArrayBounds(srcStartIndex, array.Length);
Assert.IsNotGreater(count, array.Length - srcStartIndex);

            InsertRange<U>(index, array.GetUnsafeReadOnlyPtr(), count, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange<U>(int index, NativeBitIntList<U> array, int count, int srcStartIndex)
            where U : BitInt
        {
if (array.Length != 0) Assert.IsWithinArrayBounds(srcStartIndex, array.Length);
Assert.IsNotGreater(count, array.Length - srcStartIndex);

            InsertRange<U>(index, array.GetUnsafeReadOnlyPtr(), count, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<sbyte> array, int sbytes, int srcStartIndex)
        {
            InsertRange<Int8>(index, array.GetUnsafeReadOnlyPtr(), sbytes, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<byte> array, int bytes, int srcStartIndex)
        {
            InsertRange<UInt8>(index, array.GetUnsafeReadOnlyPtr(), bytes, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<short> array, int shorts, int srcStartIndex)
        {
            InsertRange<Int16>(index, array.GetUnsafeReadOnlyPtr(), shorts, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<ushort> array, int ushorts, int srcStartIndex)
        {
            InsertRange<UInt16>(index, array.GetUnsafeReadOnlyPtr(), ushorts, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<Int24> array, int Int24s, int srcStartIndex)
        {
            InsertRange<Int24>(index, array.GetUnsafeReadOnlyPtr(), Int24s, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<UInt24> array, int Int24s, int srcStartIndex)
        {
            InsertRange<Int24>(index, array.GetUnsafeReadOnlyPtr(), Int24s, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<int> array, int ints, int srcStartIndex)
        {
            InsertRange<Int24>(index, array.GetUnsafeReadOnlyPtr(), ints, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<uint> array, int ints, int srcStartIndex)
        {
            InsertRange<Int24>(index, array.GetUnsafeReadOnlyPtr(), ints, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<Int40> array, int Int40s, int srcStartIndex)
        {
            InsertRange<Int40>(index, array.GetUnsafeReadOnlyPtr(), Int40s, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<UInt40> array, int Int40s, int srcStartIndex)
        {
            InsertRange<UInt40>(index, array.GetUnsafeReadOnlyPtr(), Int40s, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<Int48> array, int Int48s, int srcStartIndex)
        {
            InsertRange<Int48>(index, array.GetUnsafeReadOnlyPtr(), Int48s, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<UInt48> array, int Int48s, int srcStartIndex)
        {
            InsertRange<UInt48>(index, array.GetUnsafeReadOnlyPtr(), Int48s, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<Int56> array, int Int56s, int srcStartIndex)
        {
            InsertRange<Int56>(index, array.GetUnsafeReadOnlyPtr(), Int56s, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<UInt56> array, int Int56s, int srcStartIndex)
        {
            InsertRange<UInt56>(index, array.GetUnsafeReadOnlyPtr(), Int56s, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<long> array, int longs, int srcStartIndex)
        {
            InsertRange(index, (long*)array.GetUnsafeReadOnlyPtr(), longs, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<ulong> array, int longs, int srcStartIndex)
        {
            InsertRange(index, (ulong*)array.GetUnsafeReadOnlyPtr(), longs, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<Int128> array, int longs, int srcStartIndex)
        {
            InsertRange(index, (Int128*)array.GetUnsafeReadOnlyPtr(), longs, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<UInt128> array, int longs, int srcStartIndex)
        {
            InsertRange(index, (UInt128*)array.GetUnsafeReadOnlyPtr(), longs, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<sbyte> array, int sbytes, int srcStartIndex)
        {
            InsertRange<Int8>(index, array.GetUnsafeReadOnlyPtr(), sbytes, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<byte> array, int bytes, int srcStartIndex)
        {
            InsertRange<UInt8>(index, array.GetUnsafeReadOnlyPtr(), bytes, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<short> array, int shorts, int srcStartIndex)
        {
            InsertRange<Int16>(index, array.GetUnsafeReadOnlyPtr(), shorts, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<ushort> array, int ushorts, int srcStartIndex)
        {
            InsertRange<UInt16>(index, array.GetUnsafeReadOnlyPtr(), ushorts, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<Int24> array, int Int24s, int srcStartIndex)
        {
            InsertRange<Int24>(index, array.GetUnsafeReadOnlyPtr(), Int24s, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<UInt24> array, int Int24s, int srcStartIndex)
        {
            InsertRange<Int24>(index, array.GetUnsafeReadOnlyPtr(), Int24s, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<int> array, int ints, int srcStartIndex)
        {
            InsertRange<Int24>(index, array.GetUnsafeReadOnlyPtr(), ints, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<uint> array, int ints, int srcStartIndex)
        {
            InsertRange<Int24>(index, array.GetUnsafeReadOnlyPtr(), ints, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<Int40> array, int Int40s, int srcStartIndex)
        {
            InsertRange<Int40>(index, array.GetUnsafeReadOnlyPtr(), Int40s, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<UInt40> array, int Int40s, int srcStartIndex)
        {
            InsertRange<UInt40>(index, array.GetUnsafeReadOnlyPtr(), Int40s, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<Int48> array, int Int48s, int srcStartIndex)
        {
            InsertRange<Int48>(index, array.GetUnsafeReadOnlyPtr(), Int48s, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<UInt48> array, int Int48s, int srcStartIndex)
        {
            InsertRange<UInt48>(index, array.GetUnsafeReadOnlyPtr(), Int48s, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<Int56> array, int Int56s, int srcStartIndex)
        {
            InsertRange<Int56>(index, array.GetUnsafeReadOnlyPtr(), Int56s, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<UInt56> array, int Int56s, int srcStartIndex)
        {
            InsertRange<UInt56>(index, array.GetUnsafeReadOnlyPtr(), Int56s, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<long> array, int longs, int srcStartIndex)
        {
            InsertRange(index, (long*)array.GetUnsafeReadOnlyPtr(), longs, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<ulong> array, int longs, int srcStartIndex)
        {
            InsertRange(index, (ulong*)array.GetUnsafeReadOnlyPtr(), longs, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<Int128> array, int longs, int srcStartIndex)
        {
            InsertRange(index, (Int128*)array.GetUnsafeReadOnlyPtr(), longs, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<UInt128> array, int longs, int srcStartIndex)
        {
            InsertRange(index, (UInt128*)array.GetUnsafeReadOnlyPtr(), longs, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<sbyte> array, int sbytes, int srcStartIndex)
        {
            InsertRange<Int8>(index, array.GetUnsafeReadOnlyPtr(), sbytes, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<byte> array, int bytes, int srcStartIndex)
        {
            InsertRange<UInt8>(index, array.GetUnsafeReadOnlyPtr(), bytes, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<short> array, int shorts, int srcStartIndex)
        {
            InsertRange<Int16>(index, array.GetUnsafeReadOnlyPtr(), shorts, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<ushort> array, int ushorts, int srcStartIndex)
        {
            InsertRange<UInt16>(index, array.GetUnsafeReadOnlyPtr(), ushorts, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<Int24> array, int Int24s, int srcStartIndex)
        {
            InsertRange<Int24>(index, array.GetUnsafeReadOnlyPtr(), Int24s, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<UInt24> array, int Int24s, int srcStartIndex)
        {
            InsertRange<Int24>(index, array.GetUnsafeReadOnlyPtr(), Int24s, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<int> array, int ints, int srcStartIndex)
        {
            InsertRange<Int24>(index, array.GetUnsafeReadOnlyPtr(), ints, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<uint> array, int ints, int srcStartIndex)
        {
            InsertRange<Int24>(index, array.GetUnsafeReadOnlyPtr(), ints, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<Int40> array, int Int40s, int srcStartIndex)
        {
            InsertRange<Int40>(index, array.GetUnsafeReadOnlyPtr(), Int40s, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<UInt40> array, int Int40s, int srcStartIndex)
        {
            InsertRange<UInt40>(index, array.GetUnsafeReadOnlyPtr(), Int40s, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<Int48> array, int Int48s, int srcStartIndex)
        {
            InsertRange<Int48>(index, array.GetUnsafeReadOnlyPtr(), Int48s, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<UInt48> array, int Int48s, int srcStartIndex)
        {
            InsertRange<UInt48>(index, array.GetUnsafeReadOnlyPtr(), Int48s, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<Int56> array, int Int56s, int srcStartIndex)
        {
            InsertRange<Int56>(index, array.GetUnsafeReadOnlyPtr(), Int56s, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<UInt56> array, int Int56s, int srcStartIndex)
        {
            InsertRange<UInt56>(index, array.GetUnsafeReadOnlyPtr(), Int56s, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<long> array, int longs, int srcStartIndex)
        {
            InsertRange(index, (long*)array.GetUnsafeReadOnlyPtr(), longs, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<ulong> array, int longs, int srcStartIndex)
        {
            InsertRange(index, (ulong*)array.GetUnsafeReadOnlyPtr(), longs, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<Int128> array, int longs, int srcStartIndex)
        {
            InsertRange(index, (Int128*)array.GetUnsafeReadOnlyPtr(), longs, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<UInt128> array, int longs, int srcStartIndex)
        {
            InsertRange(index, (UInt128*)array.GetUnsafeReadOnlyPtr(), longs, srcStartIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, sbyte[] array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, byte[] array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, short[] array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, ushort[] array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, Int24[] array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, UInt24[] array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, int[] array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, uint[] array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, Int40[] array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, UInt40[] array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, Int48[] array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, UInt48[] array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, Int56[] array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, UInt56[] array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, long[] array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, ulong[] array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, Int128[] array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, UInt128[] array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, IEnumerable<byte> array)
        {
            InsertRange(index, array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, IEnumerable<sbyte> array)
        {
            InsertRange(index, array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, IEnumerable<ushort> array)
        {
            InsertRange(index, array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, IEnumerable<short> array)
        {
            InsertRange(index, array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, IEnumerable<UInt24> array)
        {
            InsertRange(index, array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, IEnumerable<Int24> array)
        {
            InsertRange(index, array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, IEnumerable<uint> array)
        {
            InsertRange(index, array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, IEnumerable<int> array)
        {
            InsertRange(index, array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, IEnumerable<UInt40> array)
        {
            InsertRange(index, array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, IEnumerable<Int40> array)
        {
            InsertRange(index, array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, IEnumerable<UInt48> array)
        {
            InsertRange(index, array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, IEnumerable<Int48> array)
        {
            InsertRange(index, array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, IEnumerable<UInt56> array)
        {
            InsertRange(index, array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, IEnumerable<Int56> array)
        {
            InsertRange(index, array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, IEnumerable<ulong> array)
        {
            InsertRange(index, array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, IEnumerable<long> array)
        {
            InsertRange(index, array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, IEnumerable<UInt128> array)
        {
            InsertRange(index, array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, IEnumerable<Int128> array)
        {
            InsertRange(index, array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange<U>(int index, NativeBitIntArray<U> array)
            where U : BitInt
        {
            InsertRange<U>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange<U>(int index, NativeBitIntList<U> array)
            where U : BitInt
        {
            InsertRange<U>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<sbyte> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<byte> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<short> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<ushort> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<Int24> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<UInt24> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<int> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<uint> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<Int40> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<UInt40> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<Int48> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<UInt48> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<Int56> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<UInt56> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<long> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<ulong> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<Int128> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<UInt128> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<sbyte> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<byte> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<short> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<ushort> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<Int24> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<UInt24> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<int> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<uint> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<Int40> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<UInt40> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<Int48> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<UInt48> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<Int56> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<UInt56> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<long> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<ulong> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<Int128> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<UInt128> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<sbyte> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<byte> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<short> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<ushort> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<Int24> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<UInt24> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<int> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<uint> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<Int40> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<UInt40> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<Int48> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<UInt48> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<Int56> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<UInt56> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<long> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<ulong> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<Int128> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<UInt128> array)
        {
            InsertRange(index, array, array.Length, 0);
        }
        #endregion


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RemoveAt(int index)
        {
            RemoveRange(index, 1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RemoveAtSwapBack(int index)
        {
Assert.IsWithinArrayBounds(index, Length);

            int newLength = Length - 1;
            this[index] = this[newLength];
            Length = newLength;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RemoveRange(int index, int count)
        {
Assert.IsNonNegative(count);
Assert.IsValidSubarray(index, count, Length);

            int offset = index + count;
            LoadStore.CopyAscending<T>(GetUnsafePtr(), offset, GetUnsafePtr(), index, Length - offset);

            Length -= count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RemoveRangeSwapBack(int index, int count)
        {
Assert.IsNonNegative(count);
Assert.IsValidSubarray(index, count, Length);

            if (constexpr.IS_TRUE(count == 1))
            {
                RemoveAtSwapBack(index);

                return;
            }

            int newLength = Length - count;
            int srcIdx = max(newLength, index + count);
            count = Length - srcIdx;
            LoadStore.CopyAscending<T>(GetUnsafePtr(), srcIdx, GetUnsafePtr(), index, count);

            Length = newLength;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void SetReplicate(long value)
        {
            SetReplicate(value, 0, Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void SetReplicate(long value, int index, int numValues)
        {
            LoadStore.StoreReplicate<T>(GetUnsafePtr(), index, numValues, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: AssumeRange(-1L, int.MaxValue)]
        public readonly int IndexOf(long value, Comparison where = Comparison.EqualTo)
        {
            return IndexOf(value, 0, Length, where);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: AssumeRange(-1L, int.MaxValue)]
        public readonly int IndexOf(long value, int index, int numValues, Comparison where = Comparison.EqualTo)
        {
            int iof = BitAlgorithms.IndexOfFirst<T>(GetUnsafeReadOnlyPtr(), index, numValues, value, Length, where);
            return iof == -1 ? -1 : iof + index; 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Contains(long value, Comparison where = Comparison.EqualTo)
        {
            return Contains(value, 0, Length, where);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Contains(long value, int index, int numValues, Comparison where = Comparison.EqualTo)
        {
            return BitAlgorithms.Contains<T>(GetUnsafeReadOnlyPtr(), index, numValues, value, Length, where);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: AssumeRange(0, int.MaxValue)]
        public readonly int Count(long value, Comparison where = Comparison.EqualTo)
        {
            return Count(value, 0, Length, where);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: AssumeRange(0, int.MaxValue)]
        public readonly int Count(long value, int index, int numValues, Comparison where = Comparison.EqualTo)
        {
            return BitAlgorithms.Count<T>(GetUnsafeReadOnlyPtr(), index, numValues, value, Length, where);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: AssumeRange(0, int.MaxValue * 63L)]
        public readonly long CountBits()
        {
            return CountBits(0, Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: AssumeRange(0, int.MaxValue * 63L)]
        public readonly long CountBits(int index, int numValues)
        {
Assert.IsValidSubarray(index, numValues, Length);
            
            return (long)BitAlgorithms.CountBits(GetUnsafeReadOnlyPtr(), (long)index * default(T).Bits, numValues * default(T).Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly long Sum(TypeCode range = TypeCode.Int64)
        {
            return Sum(0, Length, range);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly long Sum(int index, int numValues, TypeCode range = TypeCode.Int64)
        {
            return BitAlgorithms.Sum<T>(GetUnsafeReadOnlyPtr(), index, numValues, Length, range);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void Sort()
        {
            BitAlgorithms.Sort<T>(GetUnsafePtr(), Length);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool ArraysEqual(NativeBitIntArray<T> other)
        {
            return BitAlgorithms.ArraysEqual<T>(this.GetUnsafeReadOnlyPtr(), other.GetUnsafeReadOnlyPtr(), this.Length, other.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool ArraysEqual(NativeBitIntList<T> other)
        {
            return BitAlgorithms.ArraysEqual<T>(this.GetUnsafeReadOnlyPtr(), other.GetUnsafeReadOnlyPtr(), this.Length, other.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(NativeBitIntList<T> other)
        {
            return (this._data->Ptr == other._data->Ptr) &
                   (this.Length     == other.Length);
        }

        public override readonly bool Equals(object obj)
        {
            return obj is NativeBitIntList<T> converted && this.Equals(converted);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
            return ((IntPtr)_data).GetHashCode();
        }

        public override readonly string ToString()
        {
            return GetEnumerator().ToString();
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly IEnumerator<long> GetEnumerator()
        {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
            return new ArrayEnumerator<NativeBitIntList<T>, long>(this, m_Safety);
#else
            return new ArrayEnumerator<NativeBitIntList<T>, long>(this);
#endif
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            UnsafeUtility.Free(DataPtr, _allocator);

            void* ptr = _data;

        #if ENABLE_UNITY_COLLECTIONS_CHECKS
            SafetyHelper.Dispose(ref ptr, ref _allocator, ref m_Safety, ref m_DisposeSentinel);
        #else
            SafetyHelper.Dispose(ref ptr, _allocator);
        #endif

            _data = (ListData*)ptr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public JobHandle Dispose(JobHandle dependency)
        {
            dependency = new NativeCollectionDisposeJob(DataPtr, _allocator).Schedule(dependency);

            void* ptr = _data;

        #if ENABLE_UNITY_COLLECTIONS_CHECKS
            JobHandle dependency2 = SafetyHelper.Dispose(dependency, ref ptr, ref _allocator, ref m_Safety, ref m_DisposeSentinel);
        #else
            JobHandle dependency2 = SafetyHelper.Dispose(dependency, ref ptr, _allocator);
        #endif

            _data = (ListData*)ptr;

            return JobHandle.CombineDependencies(dependency, dependency2);
        }
    }
}