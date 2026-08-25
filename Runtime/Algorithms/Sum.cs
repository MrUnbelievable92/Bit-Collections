using System;
using System.Runtime.CompilerServices;
using DevTools;
using Unity.Burst.Intrinsics;
using MaxMath;
using MaxMath.CompilerServices;
using MaxMath.Intrinsics;

using static Unity.Burst.Intrinsics.X86;
using static MaxMath.math;

namespace BitCollections
{
    unsafe internal static partial class BitAlgorithms
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static ulong4 CSumBytes<T>(byte32 vec)
            where T : BitInt
        {
            if (Avx2.IsAvx2Supported)
            {
                if (default(T).IsSigned)
                {
                    v256 NORMALIZE = Avx.mm256_set1_epi8(1 << 7);
                    v256 sum = Avx2.mm256_sad_epu8(Avx2.mm256_xor_si256(vec, NORMALIZE), Avx.mm256_setzero_si256());
                    
                    return Avx2.mm256_add_epi64(sum, Avx.mm256_set1_epi64x(8 * -128));
                }
                else
                {
                    return Avx2.mm256_sad_epu8(vec, default);
                }
            }
            else if (BurstArchitecture.IsSIMDSupported)
            {
                if (default(T).IsSigned)
                {
                    v128 NORMALIZE = Xse.set1_epi8(1 << 7);
                    v128 sumlo = Xse.sad_epu8(Xse.xor_si128(vec.v16_0,  NORMALIZE), Xse.setzero_si128());
                    v128 sumhi = Xse.sad_epu8(Xse.xor_si128(vec.v16_16, NORMALIZE), Xse.setzero_si128());
                    
                    ulong2 lo = Xse.add_epi64(sumlo, Xse.set1_epi64x(8 * -128));
                    ulong2 hi = Xse.add_epi64(sumhi, Xse.set1_epi64x(8 * -128));

                    return new ulong4(lo, hi);
                }
                else
                {
                    ulong2 lo = Xse.sad_epu8(vec.v16_0,  default);
                    ulong2 hi = Xse.sad_epu8(vec.v16_16, default);

                    return new ulong4(lo, hi);
                }
            }
            else
            {
                if (default(T).IsSigned)
                {
                    return (ulong4)((sbyte32)vec).v4_0 + (ulong4)((sbyte32)vec).v4_4 + (ulong4)((sbyte32)vec).v4_8 + (ulong4)((sbyte32)vec).v4_12 + (ulong4)((sbyte32)vec).v4_16 + (ulong4)((sbyte32)vec).v4_20 + (ulong4)((sbyte32)vec).v4_24 + (ulong4)((sbyte32)vec).v4_28;
                }
                else
                {
                    return (ulong4)vec.v4_0 + (ulong4)vec.v4_4 + (ulong4)vec.v4_8 + (ulong4)vec.v4_12 + (ulong4)vec.v4_16 + (ulong4)vec.v4_20 + (ulong4)vec.v4_24 + (ulong4)vec.v4_28;
                }
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static ulong2 CSumBytes<T>(byte16 vec)
            where T : BitInt
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                if (default(T).IsSigned)
                {
                    v128 NORMALIZE = Xse.set1_epi8(1 << 7);
                    v128 sum = Xse.sad_epu8(Xse.xor_si128(vec,  NORMALIZE), Xse.setzero_si128());
                    
                    return Xse.add_epi64(sum, Xse.set1_epi64x(8 * -128));
                }
                else
                {
                    return Xse.sad_epu8(vec, default);
                }
            }
            else
            {
                if (default(T).IsSigned)
                {
                    return (ulong2)((sbyte16)vec).v2_0 + (ulong2)((sbyte16)vec).v2_2 + (ulong2)((sbyte16)vec).v2_4 + (ulong2)((sbyte16)vec).v2_6 + (ulong2)((sbyte16)vec).v2_8 + (ulong2)((sbyte16)vec).v2_10 + (ulong2)((sbyte16)vec).v2_12 + (ulong2)((sbyte16)vec).v2_14;
                }
                else
                {
                    return (ulong2)vec.v2_0 + (ulong2)vec.v2_2 + (ulong2)vec.v2_4 + (ulong2)vec.v2_6 + (ulong2)vec.v2_8 + (ulong2)vec.v2_10 + (ulong2)vec.v2_12 + (ulong2)vec.v2_14;
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Sum<T>(void* basePtr, int startIndex, int count, int arrayLength, TypeCode range)
            where T : BitInt
        {
Assert.IsWithinArrayBounds(startIndex, arrayLength);
Assert.IsWithinArrayBounds(startIndex + count - tobyte(count != 0), arrayLength);

            if (default(T).Bits == 1)
            {
                return (long)CountBits(basePtr, startIndex, count);
            }
            else if (default(T).Bits == 2
                  && !default(T).IsSigned)
            {
                SubArrayIndexer<T> indexer = new SubArrayIndexer<T>(startIndex);
                basePtr = indexer.GetOuterPtr(basePtr);
                int innerIndex = (int)indexer.InnerIndex;

                long result = 0;

                if (innerIndex != 0)
                {
                    UInt2x4 read = *(UInt2x4*)basePtr;
                    basePtr = (UInt2x4*)basePtr + 1;
                    
                    int valuesToCheckInFirstByte = min(count, 4 - innerIndex);
                    byte mask = bitmask8(default(T).Bits * (uint)valuesToCheckInFirstByte, default(T).Bits * (uint)innerIndex);
                
                    read = new UInt2x4 { Bits = (byte)(read.Bits & mask) };
                    UInt4x4 cast = read;
                    result = cast.Bits + (cast.Bits >> (2 * 4));
                    result = bitmask32(4) & (result + (result >> 4));
                
                    count -= valuesToCheckInFirstByte;
                }

                if (count >= 4 * 5 * 16)
                {
                    ulong sum0 = 0;
                    ulong sum1 = 0;
                    ulong sum2 = 0;
                    ulong sum3 = 0;
                    do
                    {
                        ulong acc0 = ((UInt4x16)((UInt2x16*)basePtr)[0]).Bits;
                        ulong acc1 = ((UInt4x16)((UInt2x16*)basePtr)[1]).Bits;
                        ulong acc2 = ((UInt4x16)((UInt2x16*)basePtr)[2]).Bits;
                        ulong acc3 = ((UInt4x16)((UInt2x16*)basePtr)[3]).Bits;
                    
                        acc0 += ((UInt4x16)((UInt2x16*)basePtr)[4]).Bits;
                        acc1 += ((UInt4x16)((UInt2x16*)basePtr)[5]).Bits;
                        acc2 += ((UInt4x16)((UInt2x16*)basePtr)[6]).Bits;
                        acc3 += ((UInt4x16)((UInt2x16*)basePtr)[7]).Bits;
                    
                        acc0 += ((UInt4x16)((UInt2x16*)basePtr)[8]).Bits;
                        acc1 += ((UInt4x16)((UInt2x16*)basePtr)[9]).Bits;
                        acc2 += ((UInt4x16)((UInt2x16*)basePtr)[10]).Bits;
                        acc3 += ((UInt4x16)((UInt2x16*)basePtr)[11]).Bits;
                    
                        acc0 += ((UInt4x16)((UInt2x16*)basePtr)[12]).Bits;
                        acc1 += ((UInt4x16)((UInt2x16*)basePtr)[13]).Bits;
                        acc2 += ((UInt4x16)((UInt2x16*)basePtr)[14]).Bits;
                        acc3 += ((UInt4x16)((UInt2x16*)basePtr)[15]).Bits;
                    
                        acc0 += ((UInt4x16)((UInt2x16*)basePtr)[16]).Bits;
                        acc1 += ((UInt4x16)((UInt2x16*)basePtr)[17]).Bits;
                        acc2 += ((UInt4x16)((UInt2x16*)basePtr)[18]).Bits;
                        acc3 += ((UInt4x16)((UInt2x16*)basePtr)[19]).Bits;
                
                        sum0 += csum((byte16)new UInt4x16 { Bits = acc0 });
                        sum1 += csum((byte16)new UInt4x16 { Bits = acc1 });
                        sum2 += csum((byte16)new UInt4x16 { Bits = acc2 });
                        sum3 += csum((byte16)new UInt4x16 { Bits = acc3 });
                    
                        basePtr = (UInt2x16*)basePtr + 20;
                        count -= 4 * 5 * 16;
                    }
                    while (count >= 4 * 5 * 16);
                
                    result += (long)(sum0 + sum1 + sum2 + sum3);
                }
                
                if (count >= 64)
                {
                    ulong acc0 = ((UInt4x16)((UInt2x16*)basePtr)[0]).Bits;
                    ulong acc1 = ((UInt4x16)((UInt2x16*)basePtr)[1]).Bits;
                    ulong acc2 = ((UInt4x16)((UInt2x16*)basePtr)[2]).Bits;
                    ulong acc3 = ((UInt4x16)((UInt2x16*)basePtr)[3]).Bits;
                
                    if (count >= 128)
                    {
                        acc0 += ((UInt4x16)((UInt2x16*)basePtr)[4]).Bits;
                        acc1 += ((UInt4x16)((UInt2x16*)basePtr)[5]).Bits;
                        acc2 += ((UInt4x16)((UInt2x16*)basePtr)[6]).Bits;
                        acc3 += ((UInt4x16)((UInt2x16*)basePtr)[7]).Bits;
                
                        if (count >= 192)
                        {
                            acc0 += ((UInt4x16)((UInt2x16*)basePtr)[8]).Bits;
                            acc1 += ((UInt4x16)((UInt2x16*)basePtr)[9]).Bits;
                            acc2 += ((UInt4x16)((UInt2x16*)basePtr)[10]).Bits;
                            acc3 += ((UInt4x16)((UInt2x16*)basePtr)[11]).Bits;
                
                            if (count >= 256)
                            {
                                acc0 += ((UInt4x16)((UInt2x16*)basePtr)[12]).Bits;
                                acc1 += ((UInt4x16)((UInt2x16*)basePtr)[13]).Bits;
                                acc2 += ((UInt4x16)((UInt2x16*)basePtr)[14]).Bits;
                                acc3 += ((UInt4x16)((UInt2x16*)basePtr)[15]).Bits;
                
                                if (count >= 288)
                                {
                                    acc2 += ((UInt4x16)((UInt2x16*)basePtr)[16]).Bits;
                                    acc3 += ((UInt4x16)((UInt2x16*)basePtr)[17]).Bits;
                                    
                                    count -= 288;
                                    basePtr = (UInt2x16*)basePtr + 18;
                                }
                                else
                                {
                                    count -= 256;
                                    basePtr = (UInt2x16*)basePtr + 16;
                                }
                            }
                            else
                            {
                                count -= 192;
                                basePtr = (UInt2x16*)basePtr + 12;
                            }
                        }
                        else
                        {
                            count -= 128;
                            basePtr = (UInt2x16*)basePtr + 8;
                        }
                    }
                    else
                    {
                        count -= 64;
                        basePtr = (UInt2x16*)basePtr + 4;
                    }
                
                    result += csum((byte16)new UInt4x16 { Bits = acc0 });
                    result += csum((byte16)new UInt4x16 { Bits = acc1 });
                    result += csum((byte16)new UInt4x16 { Bits = acc2 });
                    result += csum((byte16)new UInt4x16 { Bits = acc3 });
                }
                
                ulong acc = 0;
                if (count >= 32)
                {
                    acc = ((UInt4x16)((UInt2x16*)basePtr)[0]).Bits;
                    acc += ((UInt4x16)((UInt2x16*)basePtr)[1]).Bits;
                    count -= 32;
                    basePtr = (UInt2x16*)basePtr + 2;
                }

                acc += acc >> 32;
                acc = PackUnpack.UpCast64<UInt4, UInt8>(acc);

                if (count >= 16)
                {
                    acc += PackUnpack.UpCast64<UInt2, UInt8>(((UInt2x8*)basePtr)[0].Bits);
                    acc += PackUnpack.UpCast64<UInt2, UInt8>(((UInt2x8*)basePtr)[1].Bits);
                    count -= 16;
                    basePtr = (UInt2x8*)basePtr + 2;
                }
                if (count >= 8)
                {
                    acc += PackUnpack.UpCast64<UInt2, UInt8>(((UInt2x8*)basePtr)[0].Bits);
                    count -= 8;
                    basePtr = (UInt2x8*)basePtr + 1;
                }

                acc += acc >> 32;

                if (count >= 4)
                {
                    acc += PackUnpack.UpCast64<UInt2, UInt8>(((UInt2x4*)basePtr)[0].Bits);
                    count -= 4;
                    basePtr = (UInt2x4*)basePtr + 1;
                }
                if (count != 0)
                {
                    byte mask = bitmask8(default(T).Bits * (uint)count);
                
                    UInt2x4 read = *(UInt2x4*)basePtr;
                    ulong cast = PackUnpack.UpCast64<UInt2, UInt8>((byte)(read.Bits & mask));
                    
                    acc += cast;
                }
                
                acc += acc >> 16;
                acc += acc >> 8;
                result += (long)(acc & bitmask64(8ul));
                
                return result;
            }
            else
            {
                switch (range)
                {
                    case TypeCode.Byte:
                    case TypeCode.SByte:
                    {
                        if (default(T).Bits <= 8)
                        {
                            goto case TypeCode.UInt64;
                        }

                        byte32 acc0 = 0;
                        byte32 acc1 = 0;
                        byte32 acc2 = 0;
                        byte32 acc3 = 0;
                        while (count >= 128)
                        {
                            acc0 += LoadStore.LoadVector<T, byte32>(basePtr, startIndex +  0, arrayLength);
                            acc1 += LoadStore.LoadVector<T, byte32>(basePtr, startIndex + 32, arrayLength);
                            acc2 += LoadStore.LoadVector<T, byte32>(basePtr, startIndex + 64, arrayLength);
                            acc3 += LoadStore.LoadVector<T, byte32>(basePtr, startIndex + 96, arrayLength);

                            count -= 128;
                            startIndex += 128;
                        }

                        acc2 += acc3;

                        if (count >= 64)
                        {
                            acc0 += LoadStore.LoadVector<T, byte32>(basePtr, startIndex +  0, arrayLength);
                            acc1 += LoadStore.LoadVector<T, byte32>(basePtr, startIndex + 32, arrayLength);

                            count -= 64;
                            startIndex += 64;
                        }

                        acc1 += acc2;

                        if (count >= 32)
                        {
                            acc0 += LoadStore.LoadVector<T, byte32>(basePtr, startIndex + 0, arrayLength);

                            count -= 32;
                            startIndex += 32;
                        }
                        
                        acc0 += acc1;

                        byte16 acc128 = acc0.v16_0 + acc0.v16_16;

                        if (count >= 16)
                        {
                            acc128 += LoadStore.LoadVector<T, byte16>(basePtr, startIndex + 0, arrayLength);

                            count -= 16;
                            startIndex += 16;
                        }
                        
                        byte8 acc64 = acc128.v8_0 + acc128.v8_8;

                        if (count >= 8)
                        {
                            acc64 += LoadStore.LoadVector<T, byte8>(basePtr, startIndex + 0, arrayLength);

                            count -= 8;
                            startIndex += 8;
                        }

                        byte4 acc32 = acc64.v4_0 + acc64.v4_4;

                        if (count >= 4)
                        {
                            acc32 += LoadStore.LoadVector<T, byte4>(basePtr, startIndex + 0, arrayLength);

                            count -= 4;
                            startIndex += 4;
                        }

                        byte2 acc16 = acc32.xy + acc32.zw;

                        if (count >= 2)
                        {
                            acc16 += LoadStore.LoadVector<T, byte2>(basePtr, startIndex + 0, arrayLength);

                            count -= 2;
                            startIndex += 2;
                        }
                        
                        long result = default(T).IsSigned ? csum((sbyte2)acc16) : csum(acc16);

                        if (count != 0)
                        {
                            result += LoadStore.LoadScalar<T>(basePtr, startIndex + 0, arrayLength);
                        }

                        return result;
                    }
                    case TypeCode.Int16:
                    case TypeCode.UInt16:
                    {
                        if (default(T).Bits <= 8)
                        {
                            goto case TypeCode.UInt64;
                        }
                        if (default(T).IsSigned)
                        {
                            goto case TypeCode.UInt32;
                        }

                        ushort16 acc0 = 0;
                        ushort16 acc1 = 0;
                        ushort16 acc2 = 0;
                        ushort16 acc3 = 0;
                        while (count >= 64)
                        {
                            acc0 += LoadStore.LoadVector<T, ushort16>(basePtr, startIndex +  0, arrayLength);
                            acc1 += LoadStore.LoadVector<T, ushort16>(basePtr, startIndex + 16, arrayLength);
                            acc2 += LoadStore.LoadVector<T, ushort16>(basePtr, startIndex + 32, arrayLength);
                            acc3 += LoadStore.LoadVector<T, ushort16>(basePtr, startIndex + 48, arrayLength);

                            count -= 64;
                            startIndex += 64;
                        }

                        acc2 += acc3;

                        if (count >= 32)
                        {
                            acc0 += LoadStore.LoadVector<T, ushort16>(basePtr, startIndex +  0, arrayLength);
                            acc1 += LoadStore.LoadVector<T, ushort16>(basePtr, startIndex + 16, arrayLength);

                            count -= 32;
                            startIndex += 32;
                        }

                        acc1 += acc2;

                        if (count >= 16)
                        {
                            acc0 += LoadStore.LoadVector<T, ushort16>(basePtr, startIndex + 0, arrayLength);

                            count -= 16;
                            startIndex += 16;
                        }
                        
                        acc0 += acc1;

                        ushort8 acc128 = acc0.v8_0 + acc0.v8_8;

                        if (count >= 8)
                        {
                            acc128 += LoadStore.LoadVector<T, ushort8>(basePtr, startIndex + 0, arrayLength);

                            count -= 8;
                            startIndex += 8;
                        }
                        
                        ushort4 acc64 = acc128.v4_0 + acc128.v4_4;

                        if (count >= 4)
                        {
                            acc64 += LoadStore.LoadVector<T, ushort4>(basePtr, startIndex + 0, arrayLength);

                            count -= 4;
                            startIndex += 4;
                        }

                        ushort2 acc32 = acc64.xy + acc64.zw;

                        if (count >= 2)
                        {
                            acc32 += LoadStore.LoadVector<T, ushort2>(basePtr, startIndex + 0, arrayLength);

                            count -= 2;
                            startIndex += 2;
                        }

                        long result = default(T).IsSigned ? csum((short2)acc32) : csum(acc32);

                        if (count != 0)
                        {
                            result += LoadStore.LoadScalar<T>(basePtr, startIndex + 0, arrayLength);
                        }

                        return result;
                    }
                    case TypeCode.Int32:
                    case TypeCode.UInt32:
                    {
                        if (default(T).Bits <= 8)
                        {
                            goto case TypeCode.UInt64;
                        }
                        if (default(T).IsSigned)
                        {
                            goto case TypeCode.UInt64;
                        }

                        uint8 acc0 = 0;
                        uint8 acc1 = 0;
                        uint8 acc2 = 0;
                        uint8 acc3 = 0;
                        while (count >= 32)
                        {
                            acc0 += LoadStore.LoadVector<T, uint8>(basePtr, startIndex +  0, arrayLength);
                            acc1 += LoadStore.LoadVector<T, uint8>(basePtr, startIndex +  8, arrayLength);
                            acc2 += LoadStore.LoadVector<T, uint8>(basePtr, startIndex + 16, arrayLength);
                            acc3 += LoadStore.LoadVector<T, uint8>(basePtr, startIndex + 24, arrayLength);

                            count -= 32;
                            startIndex += 32;
                        }

                        acc2 += acc3;

                        if (count >= 16)
                        {
                            acc0 += LoadStore.LoadVector<T, uint8>(basePtr, startIndex + 0, arrayLength);
                            acc1 += LoadStore.LoadVector<T, uint8>(basePtr, startIndex + 8, arrayLength);

                            count -= 16;
                            startIndex += 16;
                        }

                        acc1 += acc2;

                        if (count >= 8)
                        {
                            acc0 += LoadStore.LoadVector<T, uint8>(basePtr, startIndex + 0, arrayLength);

                            count -= 8;
                            startIndex += 8;
                        }
                        
                        acc0 += acc1;

                        uint4 acc128 = acc0.v4_0 + acc0.v4_4;

                        if (count >= 4)
                        {
                            acc128 += LoadStore.LoadVector<T, uint4>(basePtr, startIndex + 0, arrayLength);

                            count -= 4;
                            startIndex += 4;
                        }

                        uint2 acc64 = acc128.xy + acc128.zw;

                        if (count >= 2)
                        {
                            acc64 += LoadStore.LoadVector<T, uint2>(basePtr, startIndex + 0, arrayLength);

                            count -= 2;
                            startIndex += 2;
                        }

                        long result = default(T).IsSigned ? (int)csum(acc64) : csum(acc64);

                        if (count != 0)
                        {
                            result += LoadStore.LoadScalar<T>(basePtr, startIndex + 0, arrayLength);
                        }

                        return result;
                    }
                    case TypeCode.Int64:
                    case TypeCode.UInt64:
                    {
                        ulong4 acc0 = 0;
                        ulong4 acc1 = 0;
                        ulong4 acc2 = 0;
                        ulong4 acc3 = 0;

                        if (default(T).Bits <= 8)
                        {
                            while (count >= 32 * 4)
                            {
                                acc0 += CSumBytes<T>(LoadStore.LoadVector<T, byte32>(basePtr, startIndex +  0, arrayLength));
                                acc1 += CSumBytes<T>(LoadStore.LoadVector<T, byte32>(basePtr, startIndex + 32, arrayLength));
                                acc2 += CSumBytes<T>(LoadStore.LoadVector<T, byte32>(basePtr, startIndex + 64, arrayLength));
                                acc3 += CSumBytes<T>(LoadStore.LoadVector<T, byte32>(basePtr, startIndex + 96, arrayLength));

                                count -= 32 * 4;
                                startIndex += 32 * 4;
                            }

                            acc2 += acc3;

                            if (count >= 32 * 2)
                            {
                                acc0 += CSumBytes<T>(LoadStore.LoadVector<T, byte32>(basePtr, startIndex + 0,  arrayLength));
                                acc1 += CSumBytes<T>(LoadStore.LoadVector<T, byte32>(basePtr, startIndex + 32, arrayLength));

                                count -= 32 * 2;
                                startIndex += 32 * 2;
                            }

                            acc1 += acc2;

                            if (count >= 32)
                            {
                                acc0 += CSumBytes<T>(LoadStore.LoadVector<T, byte32>(basePtr, startIndex + 0, arrayLength));

                                count -= 32;
                                startIndex += 32;
                            }

                            acc0 += acc1;

                            ulong2 acc128 = acc0.xy + acc0.zw;

                            if (count >= 16)
                            {
                                acc128 += CSumBytes<T>(LoadStore.LoadVector<T, byte16>(basePtr, startIndex + 0, arrayLength));

                                count -= 16;
                                startIndex += 16;
                            }

                            long result = (long)csum(acc128);

                            if (count >= 8)
                            {
                                byte8 load = LoadStore.LoadVector<T, byte8>(basePtr, startIndex + 0, arrayLength);
                                result += default(T).IsSigned ? csum((sbyte8)load) : csum(load);

                                count -= 8;
                                startIndex += 8;
                            }

                            if (count >= 4)
                            {
                                byte4 load = LoadStore.LoadVector<T, byte4>(basePtr, startIndex + 0, arrayLength);
                                result += default(T).IsSigned ? csum((sbyte4)load) : csum(load);

                                count -= 4;
                                startIndex += 4;
                            }

                            if (count >= 2)
                            {
                                byte2 load = LoadStore.LoadVector<T, byte2>(basePtr, startIndex + 0, arrayLength);
                                result += default(T).IsSigned ? csum((sbyte2)load) : csum(load);

                                count -= 2;
                                startIndex += 2;
                            }

                            if (count != 0)
                            {
                                result += LoadStore.LoadScalar<T>(basePtr, startIndex + 0, arrayLength);
                            }

                            return result;
                        }
                        else
                        {
                            while (count >= 16)
                            {
                                acc0 += LoadStore.LoadVector<T, ulong4>(basePtr, startIndex +  0, arrayLength);
                                acc1 += LoadStore.LoadVector<T, ulong4>(basePtr, startIndex +  4, arrayLength);
                                acc2 += LoadStore.LoadVector<T, ulong4>(basePtr, startIndex +  8, arrayLength);
                                acc3 += LoadStore.LoadVector<T, ulong4>(basePtr, startIndex + 12, arrayLength);

                                count -= 16;
                                startIndex += 16;
                            }

                            acc2 += acc3;

                            if (count >= 8)
                            {
                                acc0 += LoadStore.LoadVector<T, ulong4>(basePtr, startIndex + 0, arrayLength);
                                acc1 += LoadStore.LoadVector<T, ulong4>(basePtr, startIndex + 4, arrayLength);

                                count -= 8;
                                startIndex += 8;
                            }

                            acc1 += acc2;

                            if (count >= 4)
                            {
                                acc0 += LoadStore.LoadVector<T, ulong4>(basePtr, startIndex + 0, arrayLength);

                                count -= 4;
                                startIndex += 4;
                            }

                            acc0 += acc1;

                            ulong2 acc128 = acc0.xy + acc0.zw;

                            if (count >= 2)
                            {
                                acc128 += LoadStore.LoadVector<T, ulong2>(basePtr, startIndex + 0, arrayLength);

                                count -= 2;
                                startIndex += 2;
                            }

                            long result = (long)csum(acc128);

                            if (count != 0)
                            {
                                result += LoadStore.LoadScalar<T>(basePtr, startIndex + 0, arrayLength);
                            }

                            return result;
                        }
                    }

                    default: throw new System.InvalidCastException();
                }
            }
        }
    }
}
