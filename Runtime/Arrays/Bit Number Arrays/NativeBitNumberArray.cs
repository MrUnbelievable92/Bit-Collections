using DevTools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Burst;
using MaxMath;
using System.Runtime.InteropServices;

namespace BitCollections
{ 
    [StructLayout(LayoutKind.Sequential)]   [NativeContainer]    [NativeContainerSupportsDeallocateOnJobCompletion]
    unsafe public struct NativeBitNumberArray<TCollection, TElement> : IBitNumberArray<TElement>, IEquatable<NativeBitNumberArray<TCollection, TElement>>, IDisposable, INativeDisposable
        where TCollection : unmanaged, IBitNumberArray<TElement>                                                                                  
        where TElement : unmanaged, IComparable, IComparable<TElement>, IConvertible, IEquatable<TElement>, IFormattable      
    {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
private AtomicSafetyHandle m_Safety;
static readonly SharedStatic<int> s_StaticSafetyId = SharedStatic<int>.GetOrCreate<NativeBitNumberArray<TCollection, TElement>>();

[BurstDiscard]
static void CreateStaticSafetyId()
{
    s_StaticSafetyId.Data = AtomicSafetyHandle.NewStaticSafetyId<NativeBitNumberArray<TCollection, TElement>>();
}

[NativeSetClassTypeToNullOnSchedule] DisposeSentinel m_DisposeSentinel;
#endif
    
        [NativeDisableUnsafePtrRestriction] private TCollection* m_Ptr;
    
        private Allocator m_Allocator;

        private readonly int m_Length;
    
    
        public readonly TElement MinValue => new TCollection().MinValue; 
        public readonly TElement MaxValue => new TCollection().MaxValue;
    
        public readonly int BitsPerNumber => new TCollection().BitsPerNumber;
        public readonly int Length => m_Length;

        public readonly bool IsCreated => m_Ptr != null;
    
    
        public NativeBitNumberArray(int numNumbers,     Allocator allocator,      NativeArrayOptions options = NativeArrayOptions.ClearMemory)
        {
Assert.IsBetween(numNumbers, new TCollection().Length + 1, int.MaxValue / new TCollection().BitsPerNumber);
Assert.IsGreater((int)allocator, (int)Allocator.None);

            m_Length = numNumbers;
            m_Allocator = allocator;
    
            int size = maxmath.divrem(numNumbers, new TCollection().Length, out int remainder);
            size = sizeof(TCollection) * (size + maxmath.touint8(remainder != 0));

Assert.IsNotGreater(size, int.MaxValue);

            m_Ptr = (TCollection*)UnsafeUtility.Malloc(size, UnsafeUtility.AlignOf<TCollection>(), allocator);

Assert.IsNotNull(m_Ptr);

            if (options == NativeArrayOptions.ClearMemory)
            {
                UnsafeUtility.MemClear(m_Ptr, size);
            }
            else { }
    
    
#if ENABLE_UNITY_COLLECTIONS_CHECKS
DisposeSentinel.Create(out m_Safety, out m_DisposeSentinel, 2, allocator);
if (s_StaticSafetyId.Data == 0)
    CreateStaticSafetyId();
AtomicSafetyHandle.SetStaticSafetyId(ref m_Safety, s_StaticSafetyId.Data);
#endif
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly TCollection* GetUnsafePtr()
        {
            return m_Ptr;
        }


        public TElement this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
Assert.IsWithinArrayBounds(index, Length);
#if ENABLE_UNITY_COLLECTIONS_CHECKS
AtomicSafetyHandle.CheckReadAndThrow(m_Safety);
#endif          
                int outerIndex = maxmath.divrem(index, new TCollection().Length, out int innerIndex);

                return UnsafeUtility.ReadArrayElement<TCollection>(m_Ptr, outerIndex)[innerIndex];
            }
    
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsWithinArrayBounds(index, Length);
#if ENABLE_UNITY_COLLECTIONS_CHECKS
AtomicSafetyHandle.CheckWriteAndThrow(m_Safety);
#endif
                int outerIndex = maxmath.divrem(index, new TCollection().Length, out int innerIndex);

                TCollection newOne = UnsafeUtility.ReadArrayElement<TCollection>(m_Ptr, outerIndex);
                newOne[innerIndex] = value;
                UnsafeUtility.WriteArrayElement<TCollection>(m_Ptr, outerIndex, newOne);
            }
        }
    

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
Assert.IsNotNull(m_Ptr);

#if ENABLE_UNITY_COLLECTIONS_CHECKS
DisposeSentinel.Dispose(ref m_Safety, ref m_DisposeSentinel);
#endif
            if (m_Allocator > Allocator.None)
            {
                UnsafeUtility.Free(m_Ptr, m_Allocator);
                m_Allocator = Allocator.Invalid;
            }
            else { }
    
    
            m_Ptr = null;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public JobHandle Dispose(JobHandle inputDeps)
        {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
DisposeSentinel.Clear(ref m_DisposeSentinel);
#endif
            inputDeps = new NativeArrayDisposeJob
            {
                ptr = m_Ptr,
                allocator = m_Allocator
            }.Schedule(inputDeps);

#if ENABLE_UNITY_COLLECTIONS_CHECKS
AtomicSafetyHandle.Release(m_Safety);
#endif
            m_Ptr = null;


            return inputDeps;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(NativeBitNumberArray<TCollection, TElement> other)
        {
            return this.m_Ptr == other.m_Ptr;
        }

        public override readonly bool Equals(object obj)
        {
            return Equals((NativeBitNumberArray<TCollection, TElement>)obj);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
            return ((IntPtr)m_Ptr).GetHashCode();
        }

        public override string ToString()
        {
            return GetEnumerator().ToString();
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumerator<TElement>(this);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public IEnumerator<TElement> GetEnumerator()
        {
            return new Enumerator<TElement>(this);
        }
    }
}