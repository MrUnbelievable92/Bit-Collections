/*using DevTools;
using MaxMath;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace BitCollections
{
    [StructLayout(LayoutKind.Sequential)]  
    [NativeContainer] 
    [NativeContainerSupportsDeallocateOnJobCompletion]
    unsafe public struct NativeBitList : IList<bool>, IArray<bool>, IEquatable<NativeBitList>, INativeDisposable
    {

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator NativeBitArray(NativeBitList list)
        {

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRange(NativeBitList list)
        {

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RemoveRange(int startIndex, int endIndex)
        {

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public NativeBitArray ToArray()
        {

        }


        [NativeContainer] 
        [NativeContainerIsReadOnly]
        public readonly struct ReadOnly : IReadOnlyList<bool>, IReadOnlyArray<bool>
        {
            [NativeDisableUnsafePtrRestriction] 
            private readonly bit64* m_Ptr;

            private readonly int m_Count;

#if ENABLE_UNITY_COLLECTIONS_CHECKS
private readonly AtomicSafetyHandle m_Safety;

internal ReadOnly(bit64* ptr, int length, ref AtomicSafetyHandle safety)
{
    m_Ptr = ptr;
    m_Count = length;
    m_Safety = safety;
}
#else
[MethodImpl(MethodImplOptions.AggressiveInlining)]
internal ReadOnly(bit64* ptr, int length)
{
    m_Ptr = ptr;
    m_Count = length;
}
#endif
            public bool this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
Assert.IsWithinArrayBounds(index, m_Count);
#if ENABLE_UNITY_COLLECTIONS_CHECKS
AtomicSafetyHandle.CheckReadAndThrow(m_Safety);
#endif
                    uint outerIndex = maxmath.divrem((uint)index, 64, out uint innerIndex);

                    return UnsafeUtility.ReadArrayElement<bit64>(m_Ptr, (int)outerIndex)[(int)innerIndex];
                } 
            }


            public readonly int Count => m_Count;
            public readonly int Length => m_Count;


            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly IEnumerator<bool> GetEnumerator()
            {
                return new Enumerator<bool>(this);
            }

            readonly IEnumerator IEnumerable.GetEnumerator()
            {
                return new Enumerator<bool>(this);
            }
        }
    }
}*/