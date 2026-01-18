using System.Runtime.CompilerServices;
using Unity.Burst;
using SIMDAlgorithms;

using static MaxMath.maxmath;

namespace BitCollections
{
    unsafe internal static partial class BitAlgorithms
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bool ArraysEqual<T>([NoAlias] void* thisPtr, [NoAlias] void* otherPtr, int thisLength, int otherLength)
            where T : BitInt
        {
            if ((thisLength | otherLength) == 0)
            {
                return true;
            }

            if (thisLength == 0 || otherLength == 0)
            {
                return false;
            }

            ulong thisLength64 = (ulong)(uint)thisLength * default(T).Bits;
            ulong otherLength64 = (ulong)(uint)otherLength * default(T).Bits;

            long fullBytes = (long)divrem(thisLength64, 8ul, out ulong bitsInLastByte);

            bool lastBitsEqual = bitsInLastByte == 0 || (*((byte*)thisPtr + fullBytes) & bitmask8((uint)bitsInLastByte)) == (*((byte*)otherPtr + fullBytes) & bitmask8((uint)bitsInLastByte));

            return ((thisLength == otherLength) & lastBitsEqual) && Algorithms.SIMD_BitsEqual(thisPtr, otherPtr, fullBytes, TraversalOrder.Descending);
        }
    }
}
