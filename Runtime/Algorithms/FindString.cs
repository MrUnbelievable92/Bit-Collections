using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;
using DevTools;
using MaxMath.Intrinsics;
using SIMDAlgorithms;

using static Unity.Mathematics.math;
using static MaxMath.maxmath;
using System;

namespace BitCollections
{
    unsafe internal static partial class BitAlgorithms
    {
        [return: AssumeRange(0, 32)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int Find1String(byte x, int n)
        {
            int shift = n >> 1;
            x &= (byte)(x >> shift);
            n -= shift;
            shift = n >> 1;
            x &= (byte)(x >> shift);
            n -= shift;
            shift = n >> 1;
            x &= (byte)(x >> shift);

            return tzcnt((uint)x);
        }
        
        [return: AssumeRange(0, 32)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int Find1String(ushort x, int n)
        {
            int shift = n >> 1;
            x &= (ushort)(x >> shift);
            n -= shift;
            shift = n >> 1;
            x &= (ushort)(x >> shift);
            n -= shift;
            shift = n >> 1;
            x &= (ushort)(x >> shift);
            n -= shift;
            shift = n >> 1;
            x &= (ushort)(x >> shift);

            return tzcnt((uint)x);
        }
        
        [return: AssumeRange(0, 32)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int Find1String(uint x, int n)
        {
            int shift = n >> 1;
            x &= x >> shift;
            n -= shift;
            shift = n >> 1;
            x &= x >> shift;
            n -= shift;
            shift = n >> 1;
            x &= x >> shift;
            n -= shift;
            shift = n >> 1;
            x &= x >> shift;
            n -= shift;
            shift = n >> 1;
            x &= x >> shift;

            return tzcnt(x);
        }
        
        [return: AssumeRange(0, 64)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int Find1String(ulong x, int n)
        {
            int shift = n >> 1;
            x &= x >> shift;
            n -= shift;
            shift = n >> 1;
            x &= x >> shift;
            n -= shift;
            shift = n >> 1;
            x &= x >> shift;
            n -= shift;
            shift = n >> 1;
            x &= x >> shift;
            n -= shift;
            shift = n >> 1;
            x &= x >> shift;
            n -= shift;
            shift = n >> 1;
            x &= x >> shift;

            return tzcnt(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool IsStart(byte x, bool stringOfOnes, out int startCount)
        {
            return (startCount = stringOfOnes ? t1cnt(x) : tzcnt(x)) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool IsEnd(byte x, bool stringOfOnes, out int endCount)
        {
            return (endCount = stringOfOnes ? l1cnt(x) : lzcnt(x)) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool IsContinue(byte x, bool stringOfOnes)
        {
            return x == (stringOfOnes ? byte.MaxValue : 0);
        }
        
        // TODO optimize
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int FindString(void* basePtr, bool stringOfOnes, int stringLength, int startIndex, int count, int arrayLength)
        {
Assert.IsWithinArrayBounds(startIndex, arrayLength);
Assert.IsWithinArrayBounds(startIndex + count - tobyte(count != 0), arrayLength);
            
            //uint byteOffset = divrem((uint)startIndex, 8u, out uint discardedBitsInFirstByte);
            //basePtr = (byte*)basePtr + byteOffset;
            //
            //int current = 0;
            //
            //byte mask = bitmask8(discardedBitsInFirstByte);
            //byte load = *(byte*)basePtr;
            //load = stringOfOnes ? andnot(load, mask) : (byte)(load | mask); 

            
            int currentCount = 0;
            int currentIndex = startIndex;

            while (count != 0)
            {
                if (LoadStore.LoadScalar<Bit>(basePtr, startIndex, arrayLength) == tolong(stringOfOnes))
                {
                    currentCount++;
                    if (currentCount >= stringLength)
                    {
                        return currentIndex;
                    }
                    startIndex++;
                }
                else
                {
                    startIndex++;
                    currentCount = 0;
                    currentIndex = startIndex;
                }

                count--;
            }

            return -1;
        }
    }
}
