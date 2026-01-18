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
using Unity.Mathematics;
using DevTools;
using MaxMath;
using MaxMath.Intrinsics;
using SIMDAlgorithms;

using static MaxMath.maxmath;
using static Unity.Mathematics.math;

namespace BitCollections
{
    [NativeContainer]
    [DebuggerTypeProxy(typeof(NativeCollectionDebugView<bool>))]
    [NativeContainerSupportsDeallocateOnJobCompletion]
    [StructLayout(LayoutKind.Sequential)]
    unsafe public struct NativeBitList : INativeList<bool>, IArray<bool>, IEquatable<NativeBitList>, INativeDisposable, IUnityCollectionsCheck
    {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
internal AtomicSafetyHandle m_Safety;
internal static readonly SharedStatic<int> _staticSafetyId = SharedStatic<int>.GetOrCreate<NativeBitList>();
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

                int value = _data->Capacity;
                constexpr.ASSUME(value % 8 == 0);
                return value;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsGreater((int)_allocator, (int)Allocator.None);
this.CheckWriteAndThrow();

                int newCapacity = (int)MemoryHelper.Capacity<Bit>(value);

Assert.IsNonNegative(newCapacity);

                if (Hint.Unlikely(newCapacity == _data->Capacity))
                {
                    return;
                }

this.CheckWriteAndBumpSecondaryVersion();

                _data->Length = math.min(Length, newCapacity);

                if (Hint.Likely(newCapacity != 0))
                {
                    void* newPtr = UnsafeUtility.Malloc((uint)newCapacity / 8u, MemoryHelper.AlignOf<Bit>(), _allocator);

                    if (Hint.Likely(_data->Capacity != 0))
                    {
                        UnsafeUtility.MemCpy(newPtr, DataPtr, (long)MemoryHelper.SizeInBytes<Bit>(_data->Length));
                        UnsafeUtility.Free(DataPtr, _allocator);
                    }

                    _data->Ptr = newPtr;
                }
                else if (Hint.Unlikely(_data->Capacity != 0))
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
            [return: AssumeRange(0, int.MaxValue / 8ul)]
            get
            {
                return MemoryHelper.SizeInBytes<Bit>(Length);
            }
        }


        public readonly bool this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return tobool(LoadStore.LoadScalar<Bit>(GetUnsafeReadOnlyPtr(), index, Length));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                LoadStore.StoreScalar<Bit>(GetUnsafePtr(), index, Length, tobyte(value));
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly V LoadVector<V>(int index)
            where V : unmanaged
        {
            return LoadStore.LoadVector<Bit, V>(GetUnsafeReadOnlyPtr(), index, Length);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void StoreVector<V>(V vector, int index)
            where V : unmanaged
        {
            LoadStore.StoreVector<Bit, V>(GetUnsafePtr(), vector, index, Length);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public NativeBitList(Allocator allocator)
            : this(0, allocator)
        {

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public NativeBitList(int initialCapacity, Allocator allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory)
        {
Assert.IsGreater((int)allocator, (int)Allocator.None);
Assert.IsNonNegative(initialCapacity);

            _allocator = allocator;
            _data = (ListData*)UnsafeUtility.Malloc(sizeof(ListData), UnsafeUtility.AlignOf<ListData>(), allocator);
            _data->Length = 0;
            _data->Capacity = (int)MemoryHelper.Capacity<Bit>(initialCapacity);
            _data->Ptr = MemoryHelper.Allocate<Bit>(_data->Capacity, allocator, options);

#if ENABLE_UNITY_COLLECTIONS_CHECKS
SafetyHelper.InitSafety<NativeBitList>(allocator, _staticSafetyId, out m_Safety, out m_DisposeSentinel);
#endif
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator NativeBitArray(NativeBitList nativeBitList)
        {
            return nativeBitList.AsArray();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly NativeBitArray ToArray(Allocator allocator)
        {
            NativeBitArray result = new NativeBitArray(Length, allocator, NativeArrayOptions.UninitializedMemory);

            ulong bytes = MemoryHelper.SizeInBytes<Bit>(Length);
            UnsafeUtility.MemCpy(result.GetUnsafePtr(), GetUnsafeReadOnlyPtr(), (long)bytes);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly NativeBitArray AsArray()
        {
this.CheckWriteAndBumpSecondaryVersion();
#if ENABLE_UNITY_COLLECTIONS_CHECKS
AtomicSafetyHandle safety = m_Safety;
AtomicSafetyHandle.UseSecondaryVersion(ref safety);

            return new NativeBitArray(GetUnsafeReadOnlyPtr(), Length, Allocator.None, safety);
#else
            return new NativeBitArray(GetUnsafeReadOnlyPtr(), Length, Allocator.None);
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly NativeBitArray.ReadOnly AsReadOnly()
        {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
            return new NativeBitArray.ReadOnly(GetUnsafeReadOnlyPtr(), Length, m_Safety);
#else
            return new NativeBitArray.ReadOnly(GetUnsafeReadOnlyPtr(), Length);
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
this.CheckWriteAndThrow();

            int oldLength = Length;

            if (length > Capacity)
            {
                _data->Length = length;
                // Limits the maximum capacity to 1 billion items - compliant with Unity.Collections
                Capacity = math.ceilpow2(length);
            }
            else
            {
                Length = length;
            }

            if (options == NativeArrayOptions.ClearMemory && oldLength < length)
            {
                ulong oldSizeInBytes = MemoryHelper.SizeInBytes<Bit>(oldLength);
                ulong newSizeInBytes = MemoryHelper.SizeInBytes<Bit>(length);

                if (Hint.Likely(oldSizeInBytes != newSizeInBytes))
                {
                    UnsafeUtility.MemClear((bit8*)DataPtr + oldSizeInBytes, (long)(newSizeInBytes - oldSizeInBytes));
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void Clear()
        {
this.CheckWriteAndThrow();

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
        public ref bool ElementAt(int index)
        {
            throw new InvalidOperationException("Cannot return a reference to elements within bit fields.");
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(bool* other, int bits, int srcIndex, int dstIndex)
        {
            Length = max(Length, dstIndex + bits);
            PackUnpack.CopyConvertBoolToBit(GetUnsafePtr(), dstIndex, other, srcIndex, bits, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(bool[] other, int bits, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(bits + srcIndex, other.Length);

            fixed (bool* ptr = other)
            {
                CopyFrom(ptr, bits, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom<T>(T other, int bits, int srcIndex, int dstIndex)
            where T : IEnumerable<bool>
        {
Assert.IsNotGreater(bits + srcIndex, other.Count());

            Length = max(Length, dstIndex + bits);
            IEnumerator<bool> enumerator = other.GetEnumerator();

            int i = 0;
            do
            {
                enumerator.MoveNext();
            } 
            while (i < srcIndex);

            for (i = 0; i < bits; i++)
            {
                this[i + dstIndex] = enumerator.Current;
                enumerator.MoveNext();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeBitArray other, int bits, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(bits + srcIndex, other.Length);

            Length = max(Length, dstIndex + bits);
            LoadStore.CopyAscending<Bit>(other.GetUnsafeReadOnlyPtr(), srcIndex, this.GetUnsafePtr(), dstIndex, bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeBitList other, int bits, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(bits + srcIndex, other.Length);

            Length = max(Length, dstIndex + bits);
            LoadStore.CopyAscending<Bit>(other.GetUnsafeReadOnlyPtr(), srcIndex, this.GetUnsafePtr(), dstIndex, bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<bool> other, int bits, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(bits + srcIndex, other.Length);

            CopyFrom((bool*)other.GetUnsafeReadOnlyPtr(), bits, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<bool> other, int bits, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(bits + srcIndex, other.Length);

            CopyFrom((bool*)other.GetUnsafeReadOnlyPtr(), bits, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<bool> other, int bits, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(bits + srcIndex, other.Length);

            CopyFrom((bool*)other.GetUnsafeReadOnlyPtr(), bits, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(bool[] other, int bits, int srcIndex)
        {
            CopyFrom(other, bits, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom<T>(T other, int bits, int srcIndex)
            where T : IEnumerable<bool>
        {
            CopyFrom(other, bits, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeBitArray other, int bits, int srcIndex)
        {
            CopyFrom(other, bits, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeBitList other, int bits, int srcIndex)
        {
            CopyFrom(other, bits, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<bool> other, int bits, int srcIndex)
        {
            CopyFrom(other, bits, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<bool> other, int bits, int srcIndex)
        {
            CopyFrom(other, bits, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<bool> other, int bits, int srcIndex)
        {
            CopyFrom(other, bits, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(bool[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom<T>(T other)
            where T : IEnumerable<bool>
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeBitArray other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeBitList other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeArray<bool> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeList<bool> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyFrom(NativeSlice<bool> other)
        {
            CopyFrom(other, other.Length, 0);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Add(bool value)
        {
            int oldLength = _data->Length;
            Resize(oldLength + 1, NativeArrayOptions.UninitializedMemory);

            this[oldLength] = value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddNoResize(bool value)
        {
Assert.AreNotEqual(_data->Length, Capacity);
this.CheckWriteAndBumpSecondaryVersion();

            this[_data->Length++] = value;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(void* ptr, int bits, int startIndex)
        {
            int oldLength = Length;
            Resize(oldLength + bits, NativeArrayOptions.UninitializedMemory);

            LoadStore.CopyAscending<Bit>(ptr, startIndex, GetUnsafePtr(), oldLength, bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(bool* ptr, int bools, int startIndex)
        {
            int oldLength = Length;
            Resize(oldLength + bools, NativeArrayOptions.UninitializedMemory);
            
            PackUnpack.CopyConvertBoolToBit(GetUnsafePtr(), oldLength, ptr, startIndex, bools, false);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(bool[] array, int count, int startIndex)
        {
Assert.IsWithinArrayBounds(startIndex, array.Length);
Assert.IsNotGreater(count, array.Length - startIndex);
            
            int oldLength = Length;
            Resize(Length + count, NativeArrayOptions.UninitializedMemory);

            fixed (bool* ptr = array)
            {
                PackUnpack.CopyConvertBoolToBit(GetUnsafePtr(), oldLength, ptr, startIndex, array.Length, false);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange<T>(T array, int count, int startIndex)
            where T : IEnumerable<bool>
        {
Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            Resize(Length + count, NativeArrayOptions.UninitializedMemory);

            byte* ptr = (byte*)GetUnsafePtr();

            IEnumerator<bool> enumerator = array.GetEnumerator();
            enumerator.MoveNext();

            while (count >= 8)
            {
                bool x0 = enumerator.Current;
                enumerator.MoveNext();
                bool x1 = enumerator.Current;
                enumerator.MoveNext();
                bool x2 = enumerator.Current;
                enumerator.MoveNext();
                bool x3 = enumerator.Current;
                enumerator.MoveNext();
                bool x4 = enumerator.Current;
                enumerator.MoveNext();
                bool x5 = enumerator.Current;
                enumerator.MoveNext();
                bool x6 = enumerator.Current;
                enumerator.MoveNext();
                bool x7 = enumerator.Current;
                enumerator.MoveNext();

                count -= 8;
                *ptr++ = (byte)((tobyte(x0) << 0)
                              | (tobyte(x1) << 1)
                              | (tobyte(x2) << 2)
                              | (tobyte(x3) << 3)
                              | (tobyte(x4) << 4)
                              | (tobyte(x5) << 5)
                              | (tobyte(x6) << 6)
                              | (tobyte(x7) << 7));
            }

            if (count != 0)
            {
                byte lastByte = 0;
                int shift = 0;
                do
                {
                    bool src = enumerator.Current;
                    enumerator.MoveNext();

                    lastByte |= (byte)(tobyte(src) << shift++);
                }
                while (--count != 0);

                *ptr = lastByte;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(BitArray array, int count, int startIndex)
        {
Assert.IsWithinArrayBounds(startIndex, array.Length);
Assert.IsNotGreater(count, array.Length - startIndex);

            Resize(Length + count, NativeArrayOptions.UninitializedMemory);

            byte* ptr = (byte*)GetUnsafePtr();

            while (count >= 8)
            {
                count -= 8;
                *ptr++ = (byte)((tobyte(array[startIndex++]) << 0)
                              | (tobyte(array[startIndex++]) << 1)
                              | (tobyte(array[startIndex++]) << 2)
                              | (tobyte(array[startIndex++]) << 3)
                              | (tobyte(array[startIndex++]) << 4)
                              | (tobyte(array[startIndex++]) << 5)
                              | (tobyte(array[startIndex++]) << 6)
                              | (tobyte(array[startIndex++]) << 7));
            }

            if (count != 0)
            {
                byte lastByte = 0;
                int shift = 0;
                do
                {
                    lastByte |= (byte)(tobyte(array[startIndex++]) << shift++);
                }
                while (--count != 0);

                *ptr = lastByte;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeBitArray array, int count, int startIndex)
        {
Assert.IsWithinArrayBounds(startIndex, array.Length);
Assert.IsNotGreater(count, array.Length - startIndex);

            AddRange(array.GetUnsafeReadOnlyPtr(), count, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeBitList array, int count, int startIndex)
        {
Assert.IsWithinArrayBounds(startIndex, array.Length);
Assert.IsNotGreater(count, array.Length - startIndex);

            AddRange(array.GetUnsafeReadOnlyPtr(), count, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<bool> array, int count, int startIndex)
        {
Assert.IsWithinArrayBounds(startIndex, array.Length);
Assert.IsNotGreater(count, array.Length - startIndex);

            AddRange((bool*)array.GetUnsafeReadOnlyPtr(), count, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<bool> array, int count, int startIndex)
        {
Assert.IsWithinArrayBounds(startIndex, array.Length);
Assert.IsNotGreater(count, array.Length - startIndex);

            AddRange((bool*)array.GetUnsafeReadOnlyPtr(), count, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<bool> array, int count, int startIndex)
        {
Assert.IsWithinArrayBounds(startIndex, array.Length);
Assert.IsNotGreater(count, array.Length - startIndex);

            AddRange((bool*)array.GetUnsafeReadOnlyPtr(), count, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(bool[] array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange<T>(T array)
            where T : IEnumerable<bool>
        {
            AddRange(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(BitArray array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeBitArray array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeBitList array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeArray<bool> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeList<bool> array)
        {
            AddRange(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeSlice<bool> array)
        {
            AddRange(array, array.Length, 0);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(void* ptr, int bits, int startIndex)
        {
            IncLengthNoResize(bits, out int oldLength);

            LoadStore.CopyAscending<Bit>(ptr, startIndex, GetUnsafePtr(), oldLength, bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(bool* ptr, int bools, int startIndex)
        {
            IncLengthNoResize(bools, out int oldLength);

            PackUnpack.CopyConvertBoolToBit(GetUnsafePtr(), oldLength, ptr, startIndex, bools, false);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(bool[] array, int count, int startIndex)
        {
            IncLengthNoResize(count, out int oldLength);

            fixed (bool* ptr = array)
            {
                PackUnpack.CopyConvertBoolToBit(GetUnsafePtr(), oldLength, ptr, startIndex, count, false);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize<T>(T array, int count, int startIndex)
            where T : IEnumerable<bool>
        {
Assert.IsWithinArrayBounds(startIndex, array.Count());
Assert.IsNotGreater(count, array.Count() - startIndex);

            IncLengthNoResize(count, out int oldLength);

            byte* ptr = (byte*)GetUnsafePtr();

            IEnumerator<bool> enumerator = array.GetEnumerator();
            enumerator.MoveNext();

            while (count >= 8)
            {
                bool x0 = enumerator.Current;
                enumerator.MoveNext();
                bool x1 = enumerator.Current;
                enumerator.MoveNext();
                bool x2 = enumerator.Current;
                enumerator.MoveNext();
                bool x3 = enumerator.Current;
                enumerator.MoveNext();
                bool x4 = enumerator.Current;
                enumerator.MoveNext();
                bool x5 = enumerator.Current;
                enumerator.MoveNext();
                bool x6 = enumerator.Current;
                enumerator.MoveNext();
                bool x7 = enumerator.Current;
                enumerator.MoveNext();

                count -= 8;
                *ptr++ = (byte)((tobyte(x0) << 0)
                              | (tobyte(x1) << 1)
                              | (tobyte(x2) << 2)
                              | (tobyte(x3) << 3)
                              | (tobyte(x4) << 4)
                              | (tobyte(x5) << 5)
                              | (tobyte(x6) << 6)
                              | (tobyte(x7) << 7));
            }

            if (count != 0)
            {
                byte lastByte = 0;
                int shift = 0;
                do
                {
                    bool src = enumerator.Current;
                    enumerator.MoveNext();

                    lastByte |= (byte)(tobyte(src) << shift++);
                }
                while (--count != 0);

                *ptr = lastByte;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(BitArray array, int count, int startIndex)
        {
Assert.IsWithinArrayBounds(startIndex, array.Length);
Assert.IsNotGreater(count, array.Length - startIndex);

            IncLengthNoResize(count, out int oldLength);

            byte* ptr = (byte*)GetUnsafePtr();

            while (count >= 8)
            {
                count -= 8;
                *ptr++ = (byte)((tobyte(array[startIndex++]) << 0)
                              | (tobyte(array[startIndex++]) << 1)
                              | (tobyte(array[startIndex++]) << 2)
                              | (tobyte(array[startIndex++]) << 3)
                              | (tobyte(array[startIndex++]) << 4)
                              | (tobyte(array[startIndex++]) << 5)
                              | (tobyte(array[startIndex++]) << 6)
                              | (tobyte(array[startIndex++]) << 7));
            }

            if (count != 0)
            {
                byte lastByte = 0;
                int shift = 0;
                do
                {
                    lastByte |= (byte)(tobyte(array[startIndex++]) << shift++);
                }
                while (--count != 0);

                *ptr = lastByte;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeBitArray array, int count, int startIndex)
        {
Assert.IsWithinArrayBounds(startIndex, array.Length);

            AddRangeNoResize(array.GetUnsafeReadOnlyPtr(), count, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeBitList array, int count, int startIndex)
        {
Assert.IsWithinArrayBounds(startIndex, array.Length);

            AddRangeNoResize(array.GetUnsafeReadOnlyPtr(), count, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<bool> array, int count, int startIndex)
        {
Assert.IsWithinArrayBounds(startIndex, array.Length);

            AddRangeNoResize((bool*)array.GetUnsafeReadOnlyPtr(), count, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<bool> array, int count, int startIndex)
        {
Assert.IsWithinArrayBounds(startIndex, array.Length);

            AddRangeNoResize((bool*)array.GetUnsafeReadOnlyPtr(), count, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<bool> array, int count, int startIndex)
        {
Assert.IsWithinArrayBounds(startIndex, array.Length);

            AddRangeNoResize((bool*)array.GetUnsafeReadOnlyPtr(), count, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(bool[] array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize<T>(T array)
            where T : IEnumerable<bool>
        {
            AddRangeNoResize(array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(BitArray array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeBitArray array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeBitList array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeArray<bool> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeList<bool> array)
        {
            AddRangeNoResize(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRangeNoResize(NativeSlice<bool> array )
        {
            AddRangeNoResize(array, array.Length, 0);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddReplicate(bool value, int count)
        {
            int index = Length;
            Resize(Length + count, NativeArrayOptions.UninitializedMemory);

            LoadStore.StoreReplicate<Bit>(GetUnsafePtr(), index, count, tobyte(value));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Insert(int index, bool value)
        {
Assert.IsWithinArrayBounds(index, Length);

            int oldLength = Length;
            Resize(oldLength + 1, NativeArrayOptions.UninitializedMemory);
            LoadStore.Insert<Bit>(GetUnsafePtr(), oldLength, index, tobyte(value));
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
            Resize(Length + items);
            int itemsToCopy = oldLength - begin;

            int i = Length - 1;
            int j = oldLength - 1;

            LoadStore.CopyDescending<Bit>(GetUnsafePtr(), j, GetUnsafePtr(), i, itemsToCopy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, void* ptr, int bits, int srcIndex)
        {
            InsertRange(index, bits);
            LoadStore.CopyAscending<Bit>(ptr, srcIndex, GetUnsafePtr(), index, bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, bool* ptr, int bools, int srcIndex)
        {
            InsertRange(index, bools);
            PackUnpack.CopyConvertBoolToBit(GetUnsafePtr(), index, ptr, srcIndex, bools, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, bool[] array, int count, int srcIndex)
        {
            fixed (bool* ptr = array)
            {
                InsertRange(index, ptr, count, srcIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange<T>(int index, T array, int count, int srcIndex)
            where T : IEnumerable<bool>
        {
            InsertRange(index, count);
            IEnumerator<bool> enumerator = array.GetEnumerator();
            enumerator.MoveNext();
            for (int i = 0; i < srcIndex; i++)
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
        public void InsertRange(int index, BitArray array, int count, int srcIndex)
        {
            InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                this[index++] = array[srcIndex++];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeBitArray array, int count, int srcIndex)
        {
            InsertRange(index, (void*)array.GetUnsafePtr(), count, srcIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeBitList array, int count, int srcIndex)
        {
            InsertRange(index, (void*)array.GetUnsafePtr(), count, srcIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<bool> array, int count, int srcIndex)
        {
            InsertRange(index, (bool*)array.GetUnsafePtr(), count, srcIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<bool> array, int count, int srcIndex)
        {
            InsertRange(index, (bool*)array.GetUnsafePtr(), count, srcIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<bool> array, int count, int srcIndex)
        {
            InsertRange(index, (bool*)array.GetUnsafePtr(), count, srcIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, bool[] array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange<T>(int index, T array)
            where T : IEnumerable<bool>
        {
            InsertRange(index, array, array.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, BitArray array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeBitArray array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeBitList array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeArray<bool> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeList<bool> array)
        {
            InsertRange(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InsertRange(int index, NativeSlice<bool> array)
        {
            InsertRange(index, array, array.Length, 0);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RemoveAt(int index)
        {
Assert.IsWithinArrayBounds(index, Length);
this.CheckWriteAndBumpSecondaryVersion();


            if (constexpr.IS_TRUE(index == Length - 1))
            {
                _data->Length--;

                return;
            }

            uint byteOffset = divrem((uint)index, 8u, out uint innerIndexToRemove);
            byte* ptr = (byte*)GetUnsafePtr() + byteOffset;
            byte srcRead = *ptr;

            byte mask = bitmask8(innerIndexToRemove);
            byte lowBits = (byte)(srcRead & mask);
            srcRead >>= 1;
            byte highBits = andnot(srcRead, mask);
            byte currentLowBits = (byte)(lowBits | highBits);

            uint bytesAffected = (ceilmultiple((uint)Length, 8u) - floormultiple((uint)index, 8u)) / 8u;
            bytesAffected--;

            while (Hint.Likely(bytesAffected >= (uint)sizeof(UInt128)))
            {
                UInt128 srcRead128 = *(UInt128*)(ptr + 1);

                *(UInt128*)ptr = currentLowBits | (srcRead128 << 7);
                currentLowBits = (byte)(srcRead128.hi64 >> (64 - 7));

                ptr += (uint)sizeof(UInt128);
                bytesAffected -= (uint)sizeof(UInt128);
            }

            if (Hint.Likely(bytesAffected >= (uint)sizeof(ulong)))
            {
                ulong srcRead64 = *(ulong*)(ptr + 1);

                *(ulong*)ptr = currentLowBits | (srcRead64 << 7);
                currentLowBits = (byte)(srcRead64 >> (64 - 7));

                ptr += (uint)sizeof(ulong);
                bytesAffected -= (uint)sizeof(ulong);
            }

            if (Hint.Likely(bytesAffected >= (uint)sizeof(uint)))
            {
                uint srcRead32 = *(uint*)(ptr + 1);

                *(uint*)ptr = currentLowBits | (srcRead32 << 7);
                currentLowBits = (byte)(srcRead32 >> (32 - 7));

                ptr += (uint)sizeof(uint);
                bytesAffected -= (uint)sizeof(uint);
            }

            if (Hint.Likely(bytesAffected >= (uint)sizeof(ushort)))
            {
                ushort srcRead16 = *(ushort*)(ptr + 1);

                *(ushort*)ptr = (ushort)(currentLowBits | (srcRead16 << 7));
                currentLowBits = (byte)(srcRead16 >> (16 - 7));

                ptr += (uint)sizeof(ushort);
                bytesAffected -= (uint)sizeof(ushort);
            }

            if (Hint.Likely(bytesAffected != 0))
            {
                srcRead = *(ptr + 1);

                *ptr = (byte)(currentLowBits | (srcRead << 7));
                currentLowBits = (byte)(srcRead >> 1);

                ptr++;
                bytesAffected--;
            }

            *ptr = currentLowBits;

            _data->Length--;
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

            if (constexpr.IS_TRUE(count == 1))
            {
                RemoveAt(index);

                return;
            }

            int offset = index + count;
            LoadStore.CopyAscending<Bit>(GetUnsafePtr(), offset, GetUnsafePtr(), index, Length - offset);

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
            int srcIdx = math.max(newLength, index + count);
            count = Length - srcIdx;
            LoadStore.CopyAscending<Bit>(GetUnsafePtr(), srcIdx, GetUnsafePtr(), index, count);

            Length = newLength;
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void SetReplicate(bool value)
        {
            SetReplicate(value, 0, Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void SetReplicate(bool value, int index, int numValues)
        {
            LoadStore.StoreReplicate<Bit>(GetUnsafePtr(), index, numValues, tobyte(value));
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: AssumeRange(-1L, int.MaxValue)]
        public readonly int IndexOf(bool value, Comparison where = Comparison.EqualTo)
        {
            return IndexOf(value, 0, Length, where);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: AssumeRange(-1L, int.MaxValue)]
        public readonly int IndexOf(bool value, int index, int numValues, Comparison where = Comparison.EqualTo)
        {
            int iof = BitAlgorithms.IndexOfFirst<Bit>(GetUnsafeReadOnlyPtr(), index, numValues, tobyte(value), Length, where);
            return iof == -1 ? -1 : iof + index; 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Contains(bool value, Comparison where = Comparison.EqualTo)
        {
            return Contains(value, 0, Length, where);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Contains(bool value, int index, int numBits, Comparison where = Comparison.EqualTo)
        {
            return BitAlgorithms.Contains<Bit>(GetUnsafeReadOnlyPtr(), index, numBits, tobyte(value), Length, where);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: AssumeRange(0, int.MaxValue)]
        public readonly int Count(bool value, Comparison where = Comparison.EqualTo)
        {
            return Count(value, 0, Length, where);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: AssumeRange(0, int.MaxValue)]
        public readonly int Count(bool value, int index, int numBits, Comparison where = Comparison.EqualTo)
        {
            return BitAlgorithms.Count<Bit>(GetUnsafeReadOnlyPtr(), index, numBits, tobyte(value), Length, where);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: AssumeRange(0, int.MaxValue)]
        public readonly int FindString(bool value, int stringLength)
        {
            return FindString(value, stringLength, 0, Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: AssumeRange(0, int.MaxValue)]
        public readonly int FindString(bool value, int stringLength, int index, int numBits)
        {
            return BitAlgorithms.FindString(GetUnsafeReadOnlyPtr(), value, stringLength, index, numBits, Length);
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAny()
        {
            return Contains(true, 0, Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAll()
        {
            return !Contains(false, 0, Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestNone()
        {
            return !Contains(true, 0, Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestNotAll()
        {
            return Contains(false, 0, Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAny(int index, int numBits)
        {
            return Contains(true, index, numBits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAll(int index, int numBits)
        {
            return !Contains(false, index, numBits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestNone(int index, int numBits)
        {
            return !Contains(true, index, numBits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestNotAll(int index, int numBits)
        {
            return Contains(false, index, numBits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: AssumeRange(0, int.MaxValue)]
        public readonly int CountBits()
        {
            return CountBits(0, Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: AssumeRange(0, int.MaxValue)]
        public readonly int CountBits(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return (int)BitAlgorithms.CountBits(GetUnsafeReadOnlyPtr(), index, numBits);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void Sort()
        {
            BitAlgorithms.Sort<Bit>(GetUnsafePtr(), Length);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool ArraysEqual(NativeBitArray other)
        {
            return BitAlgorithms.ArraysEqual<Bit>(this.GetUnsafeReadOnlyPtr(), other.GetUnsafeReadOnlyPtr(), this.Length, other.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool ArraysEqual(NativeBitList other)
        {
            return BitAlgorithms.ArraysEqual<Bit>(this.GetUnsafeReadOnlyPtr(), other.GetUnsafeReadOnlyPtr(), this.Length, other.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(NativeBitList other)
        {
            return (this._data->Ptr == other._data->Ptr) &
                   (this.Length     == other.Length) &
                   (this.Length     == other.Capacity);
        }

        public override readonly bool Equals(object obj)
        {
            return obj is NativeBitList converted && this.Equals(converted);
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
        public readonly IEnumerator<bool> GetEnumerator()
        {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
            return new ArrayEnumerator<NativeBitList, bool>(this, m_Safety);
#else
            return new ArrayEnumerator<NativeBitList, bool>(this);
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