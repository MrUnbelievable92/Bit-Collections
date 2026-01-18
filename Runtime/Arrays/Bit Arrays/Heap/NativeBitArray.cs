using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Burst;
using Unity.Burst.CompilerServices;
using DevTools;
using SIMDAlgorithms;

using static MaxMath.maxmath;

namespace BitCollections
{
    [NativeContainer]
    [DebuggerTypeProxy(typeof(NativeCollectionDebugView<bool>))]
    [NativeContainerSupportsDeallocateOnJobCompletion]
    [StructLayout(LayoutKind.Sequential)]
    unsafe public struct NativeBitArray : IArray<bool>, IEquatable<NativeBitArray>, INativeDisposable, IUnityCollectionsCheck
    {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
internal AtomicSafetyHandle m_Safety;
internal static readonly SharedStatic<int> _staticSafetyId = SharedStatic<int>.GetOrCreate<NativeBitArray>();
[NativeSetClassTypeToNullOnSchedule] private DisposeSentinel m_DisposeSentinel;
#endif

        [NativeDisableUnsafePtrRestriction]
        internal void* _ptr;
        internal readonly int _length;
#if ENABLE_UNITY_COLLECTIONS_CHECKS
        internal Allocator _allocator;
#else
        internal readonly Allocator _allocator;
#endif

        public readonly bool IsCreated => _ptr != null;

        public readonly int Length
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [return: AssumeRange(0, int.MaxValue)]
            get
            {
                return _length;
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
#if ENABLE_UNITY_COLLECTIONS_CHECKS
        internal NativeBitArray(void* ptr, int length, Allocator allocator, AtomicSafetyHandle safety)
        {
            m_Safety = safety;
            m_DisposeSentinel = null;
#else
        internal NativeBitArray(void* ptr, int length, Allocator allocator)
        {
#endif
Assert.IsGreater((int)allocator, (int)Allocator.None);
Assert.IsNonNegative(length);

            _ptr = ptr;
            _length = length;
            _allocator = allocator;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public NativeBitArray(int numBits, Allocator allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory)
        {
Assert.IsGreater((int)allocator, (int)Allocator.None);
Assert.IsNonNegative(numBits);

            _ptr = MemoryHelper.Allocate<Bit>(numBits, allocator, options);
            _length = numBits;
            _allocator = allocator;

#if ENABLE_UNITY_COLLECTIONS_CHECKS
SafetyHelper.InitSafety<NativeBitArray>(allocator, _staticSafetyId, out m_Safety, out m_DisposeSentinel);
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public NativeBitArray(void* bits, Allocator allocator, int srcLength, int srcStartIndex = 0)
        {
Assert.IsGreater((int)allocator, (int)Allocator.None);

            _ptr = MemoryHelper.Allocate<Bit>(srcLength, allocator, NativeArrayOptions.UninitializedMemory);
            _length = srcLength;
            _allocator = allocator;

            LoadStore.CopyAscending<Bit>(bits, srcStartIndex, _ptr, 0, srcLength);

#if ENABLE_UNITY_COLLECTIONS_CHECKS
SafetyHelper.InitSafety<NativeBitArray>(allocator, _staticSafetyId, out m_Safety, out m_DisposeSentinel);
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public NativeBitArray(bool* values, Allocator allocator, int srcLength, int srcStartIndex = 0)
            : this(srcLength - srcStartIndex, allocator, NativeArrayOptions.UninitializedMemory)
        {
            PackUnpack.CopyConvertBoolToBit(_ptr, 0, values, srcStartIndex, _length, false);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public NativeBitArray(NativeArray<bool> values, Allocator allocator, int srcStartIndex = 0)
            : this((bool*)values.GetUnsafeReadOnlyPtr(), allocator, values.Length, srcStartIndex)
        {

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public NativeBitArray(NativeList<bool> values, Allocator allocator, int srcStartIndex = 0)
            : this((bool*)values.GetUnsafeReadOnlyPtr(), allocator, values.Length, srcStartIndex)
        {

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public NativeBitArray(NativeSlice<bool> values, Allocator allocator, int srcStartIndex = 0)
            : this((bool*)values.GetUnsafeReadOnlyPtr(), allocator, values.Length, srcStartIndex)
        {

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public NativeBitArray(bool[] values, Allocator allocator, int srcStartIndex = 0)
            : this(values.Length - srcStartIndex, allocator, NativeArrayOptions.UninitializedMemory)
        {
            fixed (bool* ptr = values)
            {
                PackUnpack.CopyConvertBoolToBit(_ptr, 0, ptr, srcStartIndex, _length, false);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public NativeBitArray(IEnumerable<bool> values, Allocator allocator, int srcStartIndex = 0)
            : this(values.Count() - srcStartIndex, allocator, NativeArrayOptions.UninitializedMemory)
        {
            IEnumerator<bool> enumerator = values.GetEnumerator();
            enumerator.MoveNext();

            for (int i = 0; i < srcStartIndex; i++)
            {
                enumerator.MoveNext();
            }

            int j = 0;

            while (enumerator.MoveNext())
            {
                this[j] = enumerator.Current;
            }
        }
        

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(bool* other, int bits, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(bits + dstIndex, Length);

            PackUnpack.CopyConvertBoolToBit(GetUnsafePtr(), dstIndex, other, srcIndex, bits, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(bool[] other, int bits, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(bits + srcIndex, other.Length);

            fixed (bool* ptr = other)
            {
                CopyFrom(ptr, bits, srcIndex, dstIndex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom<T>(T other, int bits, int srcIndex, int dstIndex)
            where T : IEnumerable<bool>
        {
Assert.IsNotGreater(bits + srcIndex, other.Count());
Assert.IsNotGreater(bits + dstIndex, Length);

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
        public readonly void CopyFrom(NativeBitArray other, int bits, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(bits + srcIndex, other.Length);
Assert.IsNotGreater(bits + dstIndex, Length);

            LoadStore.CopyAscending<Bit>(other.GetUnsafeReadOnlyPtr(), srcIndex, this.GetUnsafePtr(), dstIndex, bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeBitList other, int bits, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(bits + srcIndex, other.Length);
Assert.IsNotGreater(bits + dstIndex, Length);

            LoadStore.CopyAscending<Bit>(other.GetUnsafeReadOnlyPtr(), srcIndex, this.GetUnsafePtr(), dstIndex, bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<bool> other, int bits, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(bits + srcIndex, other.Length);

            CopyFrom((bool*)other.GetUnsafeReadOnlyPtr(), bits, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<bool> other, int bits, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(bits + srcIndex, other.Length);

            CopyFrom((bool*)other.GetUnsafeReadOnlyPtr(), bits, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<bool> other, int bits, int srcIndex, int dstIndex)
        {
Assert.IsNotGreater(bits + srcIndex, other.Length);

            CopyFrom((bool*)other.GetUnsafeReadOnlyPtr(), bits, srcIndex, dstIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(bool[] other, int bits, int srcIndex)
        {
            CopyFrom(other, bits, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom<T>(T other, int bits, int srcIndex)
            where T : IEnumerable<bool>
        {
            CopyFrom(other, bits, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeBitArray other, int bits, int srcIndex)
        {
            CopyFrom(other, bits, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeBitList other, int bits, int srcIndex)
        {
            CopyFrom(other, bits, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<bool> other, int bits, int srcIndex)
        {
            CopyFrom(other, bits, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<bool> other, int bits, int srcIndex)
        {
            CopyFrom(other, bits, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<bool> other, int bits, int srcIndex)
        {
            CopyFrom(other, bits, srcIndex, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(bool[] other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom<T>(T other)
            where T : IEnumerable<bool>
        {
            CopyFrom(other, other.Count(), 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeBitArray other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeBitList other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeArray<bool> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeList<bool> other)
        {
            CopyFrom(other, other.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyFrom(NativeSlice<bool> other)
        {
            CopyFrom(other, other.Length, 0);
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
        public readonly bool Equals(NativeBitArray other)
        {
            return (this._ptr    == other._ptr) &
                   (this._length == other._length);
        }

        public override readonly bool Equals(object obj)
        {
            return obj is NativeBitArray converted && this.Equals(converted);
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
        public readonly IEnumerator<bool> GetEnumerator()
        {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
            return new ArrayEnumerator<NativeBitArray, bool>(this, m_Safety);
#else
            return new ArrayEnumerator<NativeBitArray, bool>(this);
#endif
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ReadOnly AsReadOnly()
        {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
            return new ReadOnly(GetUnsafeReadOnlyPtr(), _length, m_Safety);
#else
            return new ReadOnly(GetUnsafeReadOnlyPtr(), _length);
#endif
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


        [NativeContainer]
        [NativeContainerIsReadOnly]
        public readonly struct ReadOnly : IReadOnlyArray<bool>, IUnityCollectionsCheck
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


            public bool this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
this.CheckReadAndThrow();

                    return tobool(LoadStore.LoadScalar<Bit>(_ptr, index, Length));
                }
            }
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly V LoadVector<V>(int index)
                where V : unmanaged
            {
this.CheckReadAndThrow();

                return LoadStore.LoadVector<Bit, V>(_ptr, index, Length);
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
this.CheckReadAndThrow();

                int iof = BitAlgorithms.IndexOfFirst<Bit>(_ptr, index, numValues, tobyte(value), Length, where);
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
this.CheckReadAndThrow();

                return BitAlgorithms.Contains<Bit>(_ptr, index, numBits, tobyte(value), Length, where);
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
this.CheckReadAndThrow();

                return BitAlgorithms.Count<Bit>(_ptr, index, numBits, tobyte(value), Length, where);
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
this.CheckReadAndThrow();

                return BitAlgorithms.FindString(_ptr, value, stringLength, index, numBits, Length);
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
this.CheckReadAndThrow();
Assert.IsValidSubarray(index, numBits, Length);

                return (int)BitAlgorithms.CountBits(_ptr, index, numBits);
            }


            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly bool ArraysEqual(NativeBitArray other)
            {
this.CheckReadAndThrow();

                return BitAlgorithms.ArraysEqual<Bit>(_ptr, other.GetUnsafeReadOnlyPtr(), this.Length, other.Length);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly bool ArraysEqual(NativeBitArray.ReadOnly other)
            {
this.CheckReadAndThrow();
other.CheckReadAndThrow();

                return BitAlgorithms.ArraysEqual<Bit>(_ptr, other._ptr, this.Length, other.Length);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly bool ArraysEqual(NativeBitList other)
            {
this.CheckReadAndThrow();

                return BitAlgorithms.ArraysEqual<Bit>(_ptr, other.GetUnsafeReadOnlyPtr(), this.Length, other.Length);
            }


            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly IEnumerator<bool> GetEnumerator()
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                return new ArrayEnumerator<NativeBitArray.ReadOnly, bool>(this, m_Safety);
#else
                return new ArrayEnumerator<NativeBitArray.ReadOnly, bool>(this);
#endif
            }

            readonly IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}