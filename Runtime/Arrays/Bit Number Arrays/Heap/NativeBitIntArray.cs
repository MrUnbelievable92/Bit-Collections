using System;
using System.Linq;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Collections;
using Unity.Burst;
using Unity.Burst.CompilerServices;
using Unity.Jobs;
using DevTools;
using MaxMath;
using SIMDAlgorithms;

namespace BitCollections
{
    [NativeContainer]
    [DebuggerTypeProxy(typeof(NativeCollectionDebugView<int>))]
    [NativeContainerSupportsDeallocateOnJobCompletion]
    [StructLayout(LayoutKind.Sequential)]
    unsafe public struct NativeBitIntArray<T> : IArray<long>, IEquatable<NativeBitIntArray<T>>, INativeDisposable, IUnityCollectionsCheck
        where T : BitInt
    {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
internal AtomicSafetyHandle m_Safety;
internal static readonly SharedStatic<int> _staticSafetyId = SharedStatic<int>.GetOrCreate<NativeBitIntArray<T>>();
[NativeSetClassTypeToNullOnSchedule] DisposeSentinel m_DisposeSentinel;
#endif

        [NativeDisableUnsafePtrRestriction]
        internal void* _ptr;
        internal readonly int _length;
#if ENABLE_UNITY_COLLECTIONS_CHECKS
        internal Allocator _allocator;
#else
        internal readonly Allocator _allocator;
#endif

        public readonly int Length => _length;
        public readonly bool IsCreated => _ptr != null;

        public readonly ulong SizeInBytes
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [return: AssumeRange(0, int.MaxValue * 64ul)]
            get
            {
                return MemoryHelper.SizeInBytes<T>(Length);
            }
        }


        public NativeBitIntArray(int numNumbers, Allocator allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory)
        {
Assert.IsNonNegative(numNumbers);
Assert.IsGreater((int)allocator, (int)Allocator.None);

            _length = numNumbers;
            _allocator = allocator;
            _ptr = MemoryHelper.Allocate<T>(numNumbers, allocator, options);

#if ENABLE_UNITY_COLLECTIONS_CHECKS
SafetyHelper.InitSafety<NativeBitIntArray<T>>(allocator, _staticSafetyId, out m_Safety, out m_DisposeSentinel);
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if ENABLE_UNITY_COLLECTIONS_CHECKS
        internal NativeBitIntArray(void* ptr, int length, Allocator allocator, AtomicSafetyHandle safety)
        {
            m_Safety = safety;
            m_DisposeSentinel = null;
#else
        internal NativeBitIntArray(void* ptr, int length, Allocator allocator)
        {
#endif
Assert.IsGreater((int)allocator, (int)Allocator.None);
Assert.IsNonNegative(length);

            _ptr = ptr;
            _length = length;
            _allocator = allocator;
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

            return _ptr;
        }

#if ENABLE_UNITY_COLLECTIONS_CHECKS
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly AtomicSafetyHandle GetAtomicSafetyHandle()
        {
            return m_Safety;
        }
#endif

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

        #region CopyFrom
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(byte* other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + dstIndex, Length);

            PackUnpack.CopyConvert<UInt8, T>(other, srcIndex, GetUnsafePtr(), dstIndex, count, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(sbyte* other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + dstIndex, Length);

            PackUnpack.CopyConvert<Int8, T>(other, srcIndex, GetUnsafePtr(), dstIndex, count, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(ushort* other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + dstIndex, Length);

            PackUnpack.CopyConvert<UInt16, T>(other, srcIndex, GetUnsafePtr(), dstIndex, count, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(short* other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + dstIndex, Length);

            PackUnpack.CopyConvert<Int16, T>(other, srcIndex, GetUnsafePtr(), dstIndex, count, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(UInt24* other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + dstIndex, Length);

            PackUnpack.CopyConvert<UInt24, T>(other, srcIndex, GetUnsafePtr(), dstIndex, count, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(Int24* other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + dstIndex, Length);

            PackUnpack.CopyConvert<Int24, T>(other, srcIndex, GetUnsafePtr(), dstIndex, count, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(uint* other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + dstIndex, Length);

            PackUnpack.CopyConvert<UInt32, T>(other, srcIndex, GetUnsafePtr(), dstIndex, count, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(int* other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + dstIndex, Length);

            PackUnpack.CopyConvert<Int32, T>(other, srcIndex, GetUnsafePtr(), dstIndex, count, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(UInt40* other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + dstIndex, Length);

            PackUnpack.CopyConvert<UInt40, T>(other, srcIndex, GetUnsafePtr(), dstIndex, count, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(Int40* other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + dstIndex, Length);

            PackUnpack.CopyConvert<Int40, T>(other, srcIndex, GetUnsafePtr(), dstIndex, count, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(UInt48* other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + dstIndex, Length);

            PackUnpack.CopyConvert<UInt48, T>(other, srcIndex, GetUnsafePtr(), dstIndex, count, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(Int48* other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + dstIndex, Length);

            PackUnpack.CopyConvert<Int48, T>(other, srcIndex, GetUnsafePtr(), dstIndex, count, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(UInt56* other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + dstIndex, Length);

            PackUnpack.CopyConvert<UInt56, T>(other, srcIndex, GetUnsafePtr(), dstIndex, count, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(Int56* other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + dstIndex, Length);

            PackUnpack.CopyConvert<Int56, T>(other, srcIndex, GetUnsafePtr(), dstIndex, count, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(ulong* other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + dstIndex, Length);

            PackUnpack.CopyConvert<UInt64, T>(other, srcIndex, GetUnsafePtr(), dstIndex, count, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(long* other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + dstIndex, Length);

            PackUnpack.CopyConvert<UInt64, T>(other, srcIndex, GetUnsafePtr(), dstIndex, count, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(UInt128* other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + dstIndex, Length);

            for (int i = 0; i < count; i++)
            {
                this[i + dstIndex] = (long)other[i + srcIndex];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(Int128* other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + dstIndex, Length);

            for (int i = 0; i < count; i++)
            {
                this[i + dstIndex] = (long)other[i + srcIndex];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(byte[] other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            fixed (byte* ptr = other)
            {
                CopyFrom(ptr, count, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(sbyte[] other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            fixed (sbyte* ptr = other)
            {
                CopyFrom(ptr, count, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(ushort[] other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            fixed (ushort* ptr = other)
            {
                CopyFrom(ptr, count, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(short[] other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            fixed (short* ptr = other)
            {
                CopyFrom(ptr, count, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(UInt24[] other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            fixed (UInt24* ptr = other)
            {
                CopyFrom(ptr, count, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(Int24[] other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            fixed (Int24* ptr = other)
            {
                CopyFrom(ptr, count, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(uint[] other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            fixed (uint* ptr = other)
            {
                CopyFrom(ptr, count, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(int[] other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            fixed (int* ptr = other)
            {
                CopyFrom(ptr, count, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(UInt40[] other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            fixed (UInt40* ptr = other)
            {
                CopyFrom(ptr, count, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(Int40[] other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            fixed (Int40* ptr = other)
            {
                CopyFrom(ptr, count, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(UInt48[] other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            fixed (UInt48* ptr = other)
            {
                CopyFrom(ptr, count, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(Int48[] other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            fixed (Int48* ptr = other)
            {
                CopyFrom(ptr, count, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(UInt56[] other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            fixed (UInt56* ptr = other)
            {
                CopyFrom(ptr, count, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(Int56[] other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            fixed (Int56* ptr = other)
            {
                CopyFrom(ptr, count, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(ulong[] other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            fixed (ulong* ptr = other)
            {
                CopyFrom(ptr, count, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(long[] other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            fixed (long* ptr = other)
            {
                CopyFrom(ptr, count, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(UInt128[] other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            fixed (UInt128* ptr = other)
            {
                CopyFrom(ptr, count, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(Int128[] other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            fixed (Int128* ptr = other)
            {
                CopyFrom(ptr, count, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<byte> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Count());
Assert.IsNotGreater(count + dstIndex, Length);

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
        public readonly void CopyFrom(IEnumerable<sbyte> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Count());
Assert.IsNotGreater(count + dstIndex, Length);

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
        public readonly void CopyFrom(IEnumerable<ushort> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Count());
Assert.IsNotGreater(count + dstIndex, Length);

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
        public readonly void CopyFrom(IEnumerable<short> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Count());
Assert.IsNotGreater(count + dstIndex, Length);

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
        public readonly void CopyFrom(IEnumerable<UInt24> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Count());
Assert.IsNotGreater(count + dstIndex, Length);

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
        public readonly void CopyFrom(IEnumerable<Int24> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Count());
Assert.IsNotGreater(count + dstIndex, Length);

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
        public readonly void CopyFrom(IEnumerable<uint> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Count());
Assert.IsNotGreater(count + dstIndex, Length);

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
        public readonly void CopyFrom(IEnumerable<int> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Count());
Assert.IsNotGreater(count + dstIndex, Length);

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
        public readonly void CopyFrom(IEnumerable<UInt40> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Count());
Assert.IsNotGreater(count + dstIndex, Length);

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
        public readonly void CopyFrom(IEnumerable<Int40> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Count());
Assert.IsNotGreater(count + dstIndex, Length);

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
        public readonly void CopyFrom(IEnumerable<UInt48> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Count());
Assert.IsNotGreater(count + dstIndex, Length);

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
        public readonly void CopyFrom(IEnumerable<Int48> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Count());
Assert.IsNotGreater(count + dstIndex, Length);

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
        public readonly void CopyFrom(IEnumerable<UInt56> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Count());
Assert.IsNotGreater(count + dstIndex, Length);

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
        public readonly void CopyFrom(IEnumerable<Int56> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Count());
Assert.IsNotGreater(count + dstIndex, Length);

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
        public readonly void CopyFrom(IEnumerable<ulong> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Count());
Assert.IsNotGreater(count + dstIndex, Length);

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
        public readonly void CopyFrom(IEnumerable<long> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Count());
Assert.IsNotGreater(count + dstIndex, Length);

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
        public readonly void CopyFrom(IEnumerable<UInt128> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Count());
Assert.IsNotGreater(count + dstIndex, Length);

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
        public readonly void CopyFrom(IEnumerable<Int128> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Count());
Assert.IsNotGreater(count + dstIndex, Length);

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
        public readonly void CopyFrom<U>(NativeBitIntArray<U> other, int count, int srcIndex, int dstIndex)
            where U : BitInt
        {
Assert.IsNotGreater(count + srcIndex, other.Length);
Assert.IsNotGreater(count + dstIndex, Length);

            PackUnpack.CopyConvert<U, T>(other.GetUnsafeReadOnlyPtr(), srcIndex, GetUnsafePtr(), dstIndex, count, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom<U>(NativeBitIntList<U> other, int count, int srcIndex, int dstIndex)
            where U : BitInt
        {
Assert.IsNotGreater(count + srcIndex, other.Length);
Assert.IsNotGreater(count + dstIndex, Length);

            PackUnpack.CopyConvert<U, T>(other.GetUnsafeReadOnlyPtr(), srcIndex, GetUnsafePtr(), dstIndex, count, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<byte> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((byte*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<sbyte> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((sbyte*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<ushort> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((ushort*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<short> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((short*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<UInt24> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((UInt24*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<Int24> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((Int24*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<uint> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((uint*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<int> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((int*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<UInt40> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((UInt40*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<Int40> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((Int40*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<UInt48> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((UInt48*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<Int48> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((Int48*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<UInt56> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((UInt56*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<Int56> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((Int56*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<ulong> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((ulong*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<long> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((long*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<UInt128> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((UInt128*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<Int128> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((Int128*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<byte> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((byte*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<sbyte> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((sbyte*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<ushort> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((ushort*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<short> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((short*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<UInt24> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((UInt24*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<Int24> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((Int24*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<uint> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((uint*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<int> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((int*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<UInt40> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((UInt40*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<Int40> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((Int40*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<UInt48> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((UInt48*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<Int48> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((Int48*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<UInt56> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((UInt56*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<Int56> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((Int56*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<ulong> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((ulong*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<long> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((long*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<UInt128> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((UInt128*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<Int128> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((Int128*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<byte> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((byte*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<sbyte> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((sbyte*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<ushort> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((ushort*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<short> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((short*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<UInt24> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((UInt24*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<Int24> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((Int24*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<uint> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((uint*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<int> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((int*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<UInt40> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((UInt40*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<Int40> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((Int40*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<UInt48> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((UInt48*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<Int48> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((Int48*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<UInt56> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((UInt56*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<Int56> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((Int56*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<ulong> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((ulong*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<long> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((long*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<UInt128> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((UInt128*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<Int128> other, int count, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(count + srcIndex, other.Length);

            CopyFrom((Int128*)other.GetUnsafeReadOnlyPtr(), count, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(byte* other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(sbyte* other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(ushort* other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(short* other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(UInt24* other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(Int24* other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(uint* other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(int* other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(UInt40* other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(Int40* other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(UInt48* other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(Int48* other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(UInt56* other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(Int56* other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(ulong* other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(long* other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(UInt128* other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(Int128* other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(byte[] other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(sbyte[] other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(ushort[] other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(short[] other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(UInt24[] other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(Int24[] other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(uint[] other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(int[] other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(UInt40[] other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(Int40[] other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(UInt48[] other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(Int48[] other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(UInt56[] other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(Int56[] other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(ulong[] other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(long[] other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(UInt128[] other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(Int128[] other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<byte> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<sbyte> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<ushort> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<short> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<UInt24> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<Int24> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<uint> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<int> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<UInt40> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<Int40> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<UInt48> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<Int48> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<UInt56> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<Int56> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<ulong> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<long> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<UInt128> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<Int128> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom<U>(NativeBitIntArray<U> other, int count, int srcIndex)
            where U : BitInt
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom<U>(NativeBitIntList<U> other, int count, int srcIndex)
            where U : BitInt
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<byte> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<sbyte> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<ushort> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<short> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<UInt24> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<Int24> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<uint> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<int> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<UInt40> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<Int40> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<UInt48> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<Int48> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<UInt56> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<Int56> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<ulong> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<long> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<UInt128> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<Int128> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<byte> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<sbyte> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<ushort> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<short> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<UInt24> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<Int24> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<uint> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<int> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<UInt40> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<Int40> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<UInt48> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<Int48> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<UInt56> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<Int56> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<ulong> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<long> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<UInt128> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<Int128> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<byte> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<sbyte> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<ushort> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<short> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<UInt24> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<Int24> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<uint> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<int> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<UInt40> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<Int40> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<UInt48> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<Int48> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<UInt56> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<Int56> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<ulong> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<long> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<UInt128> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<Int128> other, int count, int srcIndex)
        {
            CopyFrom(other, count, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(byte[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(sbyte[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(ushort[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(short[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(UInt24[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(Int24[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(uint[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(int[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(UInt40[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(Int40[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(UInt48[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(Int48[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(UInt56[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(Int56[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(ulong[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(long[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(UInt128[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(Int128[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<byte> other)
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<sbyte> other)
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<ushort> other)
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<short> other)
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<UInt24> other)
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<Int24> other)
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<uint> other)
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<int> other)
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<UInt40> other)
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<Int40> other)
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<UInt48> other)
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<Int48> other)
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<UInt56> other)
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<Int56> other)
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<ulong> other)
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<long> other)
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<UInt128> other)
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(IEnumerable<Int128> other)
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom<U>(NativeBitIntArray<U> other)
            where U : BitInt
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom<U>(NativeBitIntList<U> other)
            where U : BitInt
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<byte> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<sbyte> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<ushort> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<short> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<UInt24> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<Int24> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<uint> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<int> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<UInt40> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<Int40> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<UInt48> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<Int48> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<UInt56> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<Int56> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<ulong> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<long> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<UInt128> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<Int128> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<byte> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<sbyte> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<ushort> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<short> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<UInt24> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<Int24> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<uint> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<int> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<UInt40> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<Int40> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<UInt48> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<Int48> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<UInt56> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<Int56> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<ulong> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<long> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<UInt128> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<Int128> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<byte> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<sbyte> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<ushort> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<short> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<UInt24> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<Int24> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<uint> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<int> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<UInt40> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<Int40> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<UInt48> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<Int48> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<UInt56> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<Int56> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<ulong> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<long> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<UInt128> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<Int128> other)
        {
            CopyFrom(other, other.Length, 0);
        }
        #endregion
        
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
Assert.IsValidSubarray(index, numValues, Length);

            return BitAlgorithms.Sum<T>(GetUnsafeReadOnlyPtr(), index, numValues, Length, range);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void Sort()
        {
            BitAlgorithms.Sort<T>(this.GetUnsafePtr(), Length);
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
        public readonly bool Equals(NativeBitIntArray<T> other)
        {
            return (this._ptr == other._ptr) &
                   (this._length == other._length);
        }

        public override readonly bool Equals(object obj)
        {
            return obj is NativeBitIntArray<T> converted && this.Equals(converted);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public override readonly string ToString()
        {
            return GetEnumerator().ToString();
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly IEnumerator<long> GetEnumerator()
        {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
            return new ArrayEnumerator<NativeBitIntArray<T>, long>(this, m_Safety);
#else
            return new ArrayEnumerator<NativeBitIntArray<T>, long>(this);
#endif
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
        #if ENABLE_UNITY_COLLECTIONS_CHECKS
            SafetyHelper.Dispose(ref _ptr, ref _allocator, ref m_Safety, ref m_DisposeSentinel);
        #else
            SafetyHelper.Dispose(ref _ptr, _allocator);
        #endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public JobHandle Dispose(JobHandle dependency)
        {
        #if ENABLE_UNITY_COLLECTIONS_CHECKS
            return SafetyHelper.Dispose(dependency, ref _ptr, ref _allocator, ref m_Safety, ref m_DisposeSentinel);
        #else
            return SafetyHelper.Dispose(dependency, ref _ptr, _allocator);
        #endif
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ReadOnly AsReadOnly()
        {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
            return new ReadOnly(GetUnsafeReadOnlyPtr(), Length, m_Safety);
#else
            return new ReadOnly(GetUnsafeReadOnlyPtr(), _length);
#endif
        }


        [NativeContainer]
        [NativeContainerIsReadOnly]
        public readonly struct ReadOnly : IReadOnlyArray<long>, IUnityCollectionsCheck
        {
            [NativeDisableUnsafePtrRestriction]
            internal readonly void* _ptr;
            internal readonly int _length;

#if ENABLE_UNITY_COLLECTIONS_CHECKS
internal readonly AtomicSafetyHandle m_Safety;

internal ReadOnly(void* ptr, int length, AtomicSafetyHandle safety)
{
    _ptr = ptr;
    _length = length;
    m_Safety = safety;
}

[MethodImpl(MethodImplOptions.AggressiveInlining)]
public AtomicSafetyHandle GetAtomicSafetyHandle()
{
    return m_Safety;
}
#else
[MethodImpl(MethodImplOptions.AggressiveInlining)]
internal ReadOnly(void* ptr, int length)
{
    _ptr = ptr;
    _length = length;
}
#endif
            public readonly int Length => _length;


            public long this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
this.CheckReadAndThrow();

                    return LoadStore.LoadScalar<T>(_ptr, index, Length);
                }
            }
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly V LoadVector<V>(int index)
                where V : unmanaged
            {
this.CheckReadAndThrow();

                return LoadStore.LoadVector<T, V>(_ptr, index, Length);
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
this.CheckReadAndThrow();

                int iof = BitAlgorithms.IndexOfFirst<T>(_ptr, index, numValues, value, Length, where);
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
this.CheckReadAndThrow();

                return BitAlgorithms.Contains<T>(_ptr, index, numValues, value, Length, where);
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
this.CheckReadAndThrow();

                return BitAlgorithms.Count<T>(_ptr, index, numValues, value, Length, where);
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
this.CheckReadAndThrow();
Assert.IsValidSubarray(index, numValues, Length);
            
                return (long)BitAlgorithms.CountBits(_ptr, (long)index * default(T).Bits, numValues * default(T).Bits);
            }
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly long Sum(TypeCode range = TypeCode.Int64)
            {
                return Sum(0, Length, range);
            }
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly long Sum(int index, int numValues, TypeCode range = TypeCode.Int64)
            {
this.CheckReadAndThrow();
Assert.IsValidSubarray(index, numValues, Length);

                return BitAlgorithms.Sum<T>(_ptr, index, numValues, Length, range);
            }


            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly bool ArraysEqual(NativeBitIntArray<T>.ReadOnly other)
            {
this.CheckReadAndThrow();
other.CheckReadAndThrow();

                return BitAlgorithms.ArraysEqual<T>(_ptr, other._ptr, this.Length, other.Length);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly bool ArraysEqual(NativeBitIntArray<T> other)
            {
this.CheckReadAndThrow();

                return BitAlgorithms.ArraysEqual<T>(_ptr, other.GetUnsafeReadOnlyPtr(), this.Length, other.Length);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly bool ArraysEqual(NativeBitIntList<T> other)
            {
this.CheckReadAndThrow();

                return BitAlgorithms.ArraysEqual<T>(_ptr, other.GetUnsafeReadOnlyPtr(), this.Length, other.Length);
            }
        


            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly IEnumerator<long> GetEnumerator()
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                return new ArrayEnumerator<NativeBitIntArray<T>.ReadOnly, long>(this, m_Safety);
#else
                return new ArrayEnumerator<NativeBitIntArray<T>.ReadOnly, long>(this);
#endif
            }

            readonly IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}