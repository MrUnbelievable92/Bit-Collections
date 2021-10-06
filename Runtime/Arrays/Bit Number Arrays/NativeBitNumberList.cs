/*using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Collections.LowLevel.Unsafe;
using System.Runtime.CompilerServices;
using DevTools;
using MaxMath;
using Unity.Collections;

namespace BitCollections
{
    [StructLayout(LayoutKind.Sequential)]  
    [NativeContainer]    
    [NativeContainerSupportsDeallocateOnJobCompletion]
    unsafe public struct NativeBitNumberList<TCollection, TElement> : IList<TElement>, IArray<TElement>, IEquatable<NativeBitNumberList<TCollection, TElement>>, INativeDisposable
        where TCollection : unmanaged, IBitNumberArray<TElement>                                                                                  
        where TElement : unmanaged, IComparable, IComparable<TElement>, IConvertible, IEquatable<TElement>, IFormattable  
    {


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeBitNumberList<TCollection, TElement> list)
        {

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RemoveRange(int startIndex, int endIndex)
        {

        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public NativeBitNumberArray<TCollection, TElement> ToArray()
        {

        }


        [NativeContainer]  
        [NativeContainerIsReadOnly]
        public readonly struct ReadOnly : IReadOnlyList<TElement>, IReadOnlyArray<TElement>
        {
            [NativeDisableUnsafePtrRestriction] 
            private readonly TCollection* m_Ptr;

            private readonly int m_Count;

#if ENABLE_UNITY_COLLECTIONS_CHECKS
private readonly AtomicSafetyHandle m_Safety;

internal ReadOnly(TCollection* ptr, int length, ref AtomicSafetyHandle safety)
{
    m_Ptr = ptr;
    m_Count = length;
    m_Safety = safety;
}
#else
[MethodImpl(MethodImplOptions.AggressiveInlining)]
internal ReadOnly(TCollection* ptr, int length)
{
    m_Ptr = ptr;
    m_Count = length;
}
#endif
            public TElement this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
Assert.IsWithinArrayBounds(index, m_Count);
#if ENABLE_UNITY_COLLECTIONS_CHECKS
AtomicSafetyHandle.CheckReadAndThrow(m_Safety);
#endif
                    uint outerIndex = maxmath.divrem((uint)index, (uint)new TCollection().Length, out uint innerIndex);

                    return UnsafeUtility.ReadArrayElement<TCollection>(m_Ptr, (int)outerIndex)[(int)innerIndex];
                }
            }

            public readonly TElement MinValue => new TCollection().MinValue;
            public readonly TElement MaxValue => new TCollection().MaxValue;
            public readonly int BitsPerNumber => new TCollection().BitsPerNumber;
            public readonly int Count => m_Count;
            public readonly int Length => m_Count;


            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly IEnumerator<TElement> GetEnumerator()
            {
                return new Enumerator<TElement>(this);
            }

            readonly IEnumerator IEnumerable.GetEnumerator()
            {
                return new Enumerator<TElement>(this);
            }
        }
    }
}*/