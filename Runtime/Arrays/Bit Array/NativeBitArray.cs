﻿using DevTools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Burst;
using Unity.Burst.Intrinsics;
using MaxMath;
using System.Runtime.InteropServices;

namespace BitCollections
{
    [StructLayout(LayoutKind.Sequential)]  [NativeContainer]    [NativeContainerSupportsDeallocateOnJobCompletion]
    unsafe public struct NativeBitArray : IArray<bool>, IEquatable<NativeBitArray>, INativeDisposable
    {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
private AtomicSafetyHandle m_Safety;
static readonly SharedStatic<int> s_StaticSafetyId = SharedStatic<int>.GetOrCreate<NativeBitArray>();
[NativeSetClassTypeToNullOnSchedule] private DisposeSentinel m_DisposeSentinel;
#endif
    
        [NativeDisableUnsafePtrRestriction] private bit64* m_Ptr;
    
        private Allocator m_Allocator;

        private readonly int m_Length;


        public readonly int Length => m_Length;

        public readonly bool IsCreated => m_Ptr != null;


        public NativeBitArray(int numBits,      Allocator allocator,      NativeArrayOptions options = NativeArrayOptions.ClearMemory)
        {
Assert.IsBetween(numBits, 64 + 1, int.MaxValue);
Assert.IsGreater((int)allocator, (int)Allocator.None);

            m_Allocator = allocator;
            m_Length = numBits;
            
            uint size = maxmath.divrem((uint)numBits, 64, out uint remainder);
            size = (uint)sizeof(bit64) * (size + maxmath.touint8(remainder != 0));
    
            m_Ptr = (bit64*)UnsafeUtility.Malloc(size, 32, allocator);
    
Assert.IsNotNull(m_Ptr);

            if (options == NativeArrayOptions.ClearMemory)
            {
                UnsafeUtility.MemClear(m_Ptr, size);
            }
            else { }
    
    
#if ENABLE_UNITY_COLLECTIONS_CHECKS
DisposeSentinel.Create(out m_Safety, out m_DisposeSentinel, 2, allocator);
if (s_StaticSafetyId.Data == 0)
{
    s_StaticSafetyId.Data = AtomicSafetyHandle.NewStaticSafetyId<NativeBitArray>();
}
AtomicSafetyHandle.SetStaticSafetyId(ref m_Safety, s_StaticSafetyId.Data);
#endif
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void* GetUnsafePtr()
        {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
AtomicSafetyHandle.CheckWriteAndThrow(m_Safety);
#endif
            return m_Ptr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void* GetUnsafeReadOnlyPtr()
        {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
AtomicSafetyHandle.CheckReadAndThrow(m_Safety);
#endif
            return m_Ptr;
        }


        public readonly bool this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
Assert.IsWithinArrayBounds(index, Length);
#if ENABLE_UNITY_COLLECTIONS_CHECKS
AtomicSafetyHandle.CheckReadAndThrow(m_Safety);
#endif
                uint outerIndex = maxmath.divrem((uint)index, 64, out uint innerIndex);

                return UnsafeUtility.ReadArrayElement<bit64>(m_Ptr, (int)outerIndex)[(int)innerIndex];
            } 
    
            [MethodImpl(MethodImplOptions.AggressiveInlining)]  [WriteAccessRequired]
            set
            {
Assert.IsWithinArrayBounds(index, Length);
#if ENABLE_UNITY_COLLECTIONS_CHECKS
AtomicSafetyHandle.CheckWriteAndThrow(m_Safety);
#endif
                uint outerIndex = maxmath.divrem((uint)index, 64, out uint innerIndex);

                bit64 newOne = UnsafeUtility.ReadArrayElement<bit64>(m_Ptr, (int)outerIndex);
                newOne[(int)innerIndex] = value;
                UnsafeUtility.WriteArrayElement<bit64>(m_Ptr, (int)outerIndex, newOne);
            } 
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [WriteAccessRequired]
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
        public readonly bool Equals(NativeBitArray other)
        {
            return this.m_Ptr == other.m_Ptr;
        }

        public override readonly bool Equals(object obj)
        {
            return Equals((NativeBitArray)obj);
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
            return new Enumerator<bool>(this);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public IEnumerator<bool> GetEnumerator()
        {
            return new Enumerator<bool>(this);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadOnly AsReadOnly()
        {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
return new ReadOnly(m_Ptr, m_Length, ref m_Safety);
#else
return new ReadOnly(m_Ptr, m_Length);
#endif
        }


        [NativeContainer]  [NativeContainerIsReadOnly]
        public readonly struct ReadOnly : IReadOnlyArray<bool>
        {
            [NativeDisableUnsafePtrRestriction] private readonly bit64* m_Ptr;
            private readonly int m_Length;

#if ENABLE_UNITY_COLLECTIONS_CHECKS
private readonly AtomicSafetyHandle m_Safety;

internal ReadOnly(bit64* ptr, int length, ref AtomicSafetyHandle safety)
{
    m_Ptr = ptr;
    m_Length = length;
    m_Safety = safety;
}
#else
[MethodImpl(MethodImplOptions.AggressiveInlining)]
internal ReadOnly(bit64* ptr, int length)
{
    m_Ptr = ptr;
    m_Length = length;
}
#endif
            public bool this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
Assert.IsWithinArrayBounds(index, m_Length);
#if ENABLE_UNITY_COLLECTIONS_CHECKS
AtomicSafetyHandle.CheckReadAndThrow(m_Safety);
#endif
                    uint outerIndex = maxmath.divrem((uint)index, 64, out uint innerIndex);

                    return UnsafeUtility.ReadArrayElement<bit64>(m_Ptr, (int)outerIndex)[(int)innerIndex];
                } 
            }


            public int Length => m_Length;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public IEnumerator<bool> GetEnumerator()
            {
                return new Enumerator<bool>(this);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return new Enumerator<bool>(this);
            }
        }
    }
}