using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;
using MaxMath.Intrinsics;
using SIMDAlgorithms;

using static Unity.Burst.Intrinsics.X86;
using static MaxMath.maxmath;

namespace BitCollections
{
    unsafe internal static partial class BitAlgorithms
    {
        // up to 4 loop iterations
        private static int COUNTBITS_VS_EARLY_OUT_THRESHOLD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                int vectorSize;
                if (Avx2.IsAvx2Supported)
                {
                    vectorSize = 256;
                }
                else if (BurstArchitecture.IsSIMDSupported)
                {
                    vectorSize = 128;
                }
                else
                {
                    vectorSize = 0;
                }

                return 4 * ((4 * vectorSize) + (4 * 64));
            }
        }
        
        [return: AssumeRange(0ul, 64ul * int.MaxValue)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong CountBits(void* basePtr, long startIndex, long count)
        {
            if (constexpr.IS_TRUE(startIndex == 0))
            {
                if (constexpr.IS_TRUE(isdivisible(count, 8)))
                {
                    return (uint)Algorithms.SIMD_CountBits((byte*)basePtr, (long)((ulong)count / 8));
                }
                else
                {
                    MemoryHelper.ClearUnused(basePtr, count);

                    ulong oneBits = 0;

                    ulong bytes = divrem((ulong)count, 8u, out ulong residuals);
                    if (Hint.Likely(residuals != 0))
                    {
                        bit8 rest = (bit8)(*((byte*)basePtr + bytes));
                        oneBits += rest.CountBits(0, (int)residuals);
                    }

                    oneBits += Algorithms.SIMD_CountBits((byte*)basePtr, (long)bytes);

                    return (uint)oneBits;
                }
            }
            else
            {
                uint oneBits = 0;

                ulong byteOffset = divrem((ulong)startIndex, 8, out ulong discardedBitsInFirstByte);
                basePtr = (byte*)basePtr + byteOffset;

                if (Hint.Likely(discardedBitsInFirstByte != 0))
                {
                    ulong bitsToCheckInFirstByte = 8 - discardedBitsInFirstByte;

                    if (Hint.Unlikely(bitsToCheckInFirstByte >= (ulong)count))
                    {
                        return (*(bit8*)basePtr).CountBits((int)discardedBitsInFirstByte, (int)count);
                    }
                    else
                    {
                        oneBits += (*(bit8*)basePtr).CountBits((int)discardedBitsInFirstByte, (int)bitsToCheckInFirstByte);

                        count -= (long)bitsToCheckInFirstByte;
                        basePtr = (byte*)basePtr + 1;
                    }
                }

                ulong bytes = divrem((ulong)count, 8, out ulong residuals);
                oneBits += (uint)Algorithms.SIMD_CountBits((byte*)basePtr, (long)bytes);

                if (Hint.Likely(residuals != 0))
                {
                    bit8 rest = (bit8)(*((byte*)basePtr + bytes));
                    oneBits += rest.CountBits(0, (int)residuals);
                }

                return oneBits;
            }
        }
    }
}
