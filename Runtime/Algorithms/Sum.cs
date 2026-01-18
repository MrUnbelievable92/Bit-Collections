using System;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using DevTools;
using MaxMath;

using static Unity.Mathematics.math;
using static MaxMath.maxmath;

namespace BitCollections
{
    unsafe internal static partial class BitAlgorithms
    {
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
            else if (default(T).Bits == 4
                  && !default(T).IsSigned)
            {
                SubArrayIndexer<T> indexer = new SubArrayIndexer<T>(startIndex);
                basePtr = indexer.GetOuterPtr(basePtr);
                int innerIndex = (int)indexer.InnerIndex;

                long result;
                if (innerIndex != 0
                  & count != 0)
                {
                    byte read = *(byte*)basePtr;
                    basePtr = (byte*)basePtr + 1;
                    
                    result = (byte)(read >> 4);
                    
                    count -= 1;
                }
                else
                {
                    result = 0;
                }
                
                ulong acc0 = 0;
                ulong acc1 = 0;
                ulong acc2 = 0;
                ulong acc3 = 0;

                if (count >= 4 * 17 * 8)
                {
                    ushort8 sum0 = 0;
                    ushort8 sum1 = 0;
                    ushort8 sum2 = 0;
                    ushort8 sum3 = 0;
                    int counter = 0;
                    do
                    {
                        for (int i = 0; i < 17; i++)
                        {
                            acc0 += PackUnpack.UpCast64<UInt4, UInt8>(((UInt4x8*)basePtr)[0].Bits);
                            acc1 += PackUnpack.UpCast64<UInt4, UInt8>(((UInt4x8*)basePtr)[1].Bits);
                            acc2 += PackUnpack.UpCast64<UInt4, UInt8>(((UInt4x8*)basePtr)[2].Bits);
                            acc3 += PackUnpack.UpCast64<UInt4, UInt8>(((UInt4x8*)basePtr)[3].Bits);
                            basePtr = (UInt4x8*)basePtr + 4;
                        }
                
                        if (range != TypeCode.Byte
                         && range != TypeCode.SByte
                         && range != TypeCode.Int16
                         && range != TypeCode.UInt16)
                        {
                            if (counter++ >= (ushort.MaxValue / byte.MaxValue) / 8)
                            {
                                result += csum(sum0);
                                result += csum(sum1);
                                result += csum(sum2);
                                result += csum(sum3);
                                sum0 = 0;
                                sum1 = 0;
                                sum2 = 0;
                                sum3 = 0;
                            }
                        }
                
                        sum0 += acc0.Reinterpret<ulong, byte8>();
                        sum1 += acc1.Reinterpret<ulong, byte8>();
                        sum2 += acc2.Reinterpret<ulong, byte8>();
                        sum3 += acc3.Reinterpret<ulong, byte8>();
                        acc0 = 0;
                        acc1 = 0;
                        acc2 = 0;
                        acc3 = 0;
                        
                        count -= 4 * 17 * 8;
                    }
                    while (count >= 4 * 17 * 8);
                
                    result += csum(sum0);
                    result += csum(sum1);
                    result += csum(sum2);
                    result += csum(sum3);
                }

                if (count >= 4 * 8)
                {
                    do
                    {
                        acc0 += PackUnpack.UpCast64<UInt4, UInt8>(((UInt4x8*)basePtr)[0].Bits);
                        acc1 += PackUnpack.UpCast64<UInt4, UInt8>(((UInt4x8*)basePtr)[1].Bits);
                        acc2 += PackUnpack.UpCast64<UInt4, UInt8>(((UInt4x8*)basePtr)[2].Bits);
                        acc3 += PackUnpack.UpCast64<UInt4, UInt8>(((UInt4x8*)basePtr)[3].Bits);

                        count -= 4 * 8;
                        basePtr = (UInt4x8*)basePtr + 4;
                    } 
                    while (count >= 4 * 8);
                    
                    result += csum((ushort8)acc0.Reinterpret<ulong, byte8>());
                    result += csum((ushort8)acc1.Reinterpret<ulong, byte8>());
                    result += csum((ushort8)acc2.Reinterpret<ulong, byte8>());
                    result += csum((ushort8)acc3.Reinterpret<ulong, byte8>());

                    acc0 = 0;
                }

                if (count >= 16)
                {
                    acc0 = PackUnpack.UpCast64<UInt4, UInt8>(((UInt4x8*)basePtr)[0].Bits);
                    acc0 += PackUnpack.UpCast64<UInt4, UInt8>(((UInt4x8*)basePtr)[1].Bits);

                    count -= 16;
                    basePtr = (UInt4x8*)basePtr + 2;
                }

                if (count >= 8)
                {
                    acc0 += PackUnpack.UpCast64<UInt4, UInt8>(((UInt4x8*)basePtr)[0].Bits);

                    count -= 8;
                    basePtr = (UInt4x8*)basePtr + 1;
                }

                acc0 += acc0 >> 32;

                if (count >= 4)
                {
                    acc0 += PackUnpack.UpCast32<UInt4, UInt8>(((UInt4x4*)basePtr)[0].Bits);

                    count -= 4;
                    basePtr = (UInt4x4*)basePtr + 1;
                }

                if (count >= 2)
                {
                    acc0 += PackUnpack.UpCast16<UInt4, UInt8>(((UInt4x2*)basePtr)[0].Bits);

                    count -= 2;
                    basePtr = (UInt4x2*)basePtr + 1;
                }

                if (count != 0)
                {
                    acc0 += (byte)(*(byte*)basePtr & bitmask8(4));
                }

                acc0 = PackUnpack.UpCast64<UInt8, UInt16>(acc0);
                acc0 += acc0 >> 32;
                acc0 += acc0 >> 16;

                result += (uint)acc0 & bitmask32(16u);

                return result;
            }
            else
            {
                switch (range)
                {
                    case TypeCode.Byte:
                    case TypeCode.SByte:
                    {
                        if (default(T).IsSigned
                         && default(T).Bits > 4)
                        {
                            goto case TypeCode.UInt16;
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

                    default: throw new System.InvalidCastException();
                }
            }
        }
    }
}
