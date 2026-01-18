using System.Runtime.CompilerServices;
using Unity.Mathematics;
using Unity.Burst;
using Unity.Burst.CompilerServices;
using MaxMath;

using static MaxMath.maxmath;
using static Unity.Mathematics.math;
using static Unity.Burst.Intrinsics.X86;

namespace BitCollections
{
    unsafe internal static partial class PackUnpack
    {
        // TODO optimize
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void CopyConvert<TSource, TDestination>([NoAlias] void* srcPtr, int srcStartIndex, [NoAlias] void* dstPtr, int dstStartIndex, int count, bool merge = true)
            where TSource      : BitInt
            where TDestination : BitInt
        {
            if (default(TSource).Bits == default(TDestination).Bits)
            {
                LoadStore.CopyAscending<TSource>(srcPtr, srcStartIndex, dstPtr, dstStartIndex, count);
            }
            else
            {
                if (default(TSource).Bits == default(Bit).Bits
                 && default(TDestination).Bits == default(UInt8).Bits)
                {
                    CopyConvertBitToBool(dstPtr, dstStartIndex, srcPtr, srcStartIndex, count);
                }
                else if (default(TSource).Bits == default(UInt8).Bits
                      && default(TDestination).Bits == default(Bit).Bits)
                {
                    CopyConvertBoolToBit(dstPtr, dstStartIndex, srcPtr, srcStartIndex, count, merge);
                }
                else
                {
                    //if (default(TSource).Bits > default(TDestination).Bits)
                    //{
                    //
                    //}
                    //else
                    //{
                    //
                    //}
                    for (int i = 0; i < count; i++)
                    {
                        LoadStore.StoreScalar<TDestination>(dstPtr, dstStartIndex + i, int.MaxValue, LoadStore.LoadScalar<TSource>(srcPtr, srcStartIndex + i, int.MaxValue));
                    }
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void CopyConvertBitToBool([NoAlias] void* dst, int dstIndex, [NoAlias] void* src, int srcIndex, int count)
        {
            dst = (bool*)dst + dstIndex;

            SubArrayIndexer<Bit> indexer = new SubArrayIndexer<Bit>(srcIndex);
            src = indexer.GetOuterPtr(src);

            if (Hint.Likely(!isdivisible((uint)srcIndex, 8)))
            {
                int index = (int)indexer.InnerIndex;
                byte lo = *(byte*)src;
                lo >>= index;
                bool8 cvt = tobool8(lo);
                int countSrc = min(8 - index, count);

                if (Hint.Likely(countSrc >= 4))
                {
                    *(bool4*)dst = cvt.v4_0;
                    dst = (bool*)dst + 4;
                    count -= 4;
                    countSrc -= 4;
                    cvt = vshr(cvt, 4);
                }
                
                if (Hint.Likely(countSrc >= 2))
                {
                    *(bool2*)dst = cvt.v2_0;
                    dst = (bool*)dst + 2;
                    count -= 2;
                    countSrc -= 2;
                    cvt = vshr(cvt, 2);
                }

                if (Hint.Likely(countSrc != 0))
                {
                    *(bool*)dst = cvt.x0;
                    dst = (bool*)dst + 1;
                    count -= 1;
                }

                src = (byte*)src + 1;
            }

            if (COMPILATION_OPTIONS.OPTIMIZE_FOR == OptimizeFor.Performance)
            {
                while (Hint.Likely(count >= 128))
                {
                    *((bool32*)dst + 0) = tobool32(*((int*)src + 0));
                    *((bool32*)dst + 1) = tobool32(*((int*)src + 1));
                    if (Bmi2.IsBmi2Supported)
                    {
                        *((ulong*)dst + 8)  = bits_depositparallel((ulong)*((byte*)src + 8),  0x0101_0101_0101_0101);
                        *((ulong*)dst + 9)  = bits_depositparallel((ulong)*((byte*)src + 9),  0x0101_0101_0101_0101);
                        *((ulong*)dst + 10) = bits_depositparallel((ulong)*((byte*)src + 10), 0x0101_0101_0101_0101);
                        *((ulong*)dst + 11) = bits_depositparallel((ulong)*((byte*)src + 11), 0x0101_0101_0101_0101);
                    }
                    else
                    {
                        *((bool32*)dst + 2) = tobool32(*((int*)src + 2));
                    }
                    *((bool32*)dst + 3) = tobool32(*((int*)src + 3));

                    dst = (bool*)dst + 128;
                    src = (byte*)src + 128 / 8;

                    count -= 128;
                }

                if (Hint.Likely(count >= 64))
                {
                    *((bool32*)dst + 0) = tobool32(*((int*)src + 0));
                    *((bool32*)dst + 1) = tobool32(*((int*)src + 1));

                    dst = (bool*)dst + 64;
                    src = (byte*)src + 64 / 8;

                    count -= 64;
                }

                if (Hint.Likely(count >= 32))
                {
                    *((bool32*)dst + 0) = tobool32(*((int*)src + 0));

                    dst = (bool*)dst + 32;
                    src = (byte*)src + 32 / 8;

                    count -= 32;
                }
            }
            else
            {
                while (Hint.Likely(count >= 32))
                {
                    *((bool32*)dst + 0) = tobool32(*((int*)src + 0));

                    dst = (bool*)dst + 32;
                    src = (byte*)src + 32 / 8;

                    count -= 32;
                }
            }

            if (Hint.Likely(count >= 16))
            {
                *((bool16*)dst + 0) = tobool16(*((ushort*)src + 0));

                dst = (bool*)dst + 16;
                src = (byte*)src + 16 / 8;

                count -= 16;
            }

            if (Hint.Likely(count >= 8))
            {
                *((bool8*)dst + 0) = tobool8(*((byte*)src + 0));

                dst = (bool*)dst + 8;
                src = (byte*)src + 8 / 8;

                count -= 8;
            }

            if (Hint.Likely(count != 0))
            {
                bool8 last = tobool8(*(byte*)src);

                if (Hint.Likely(count >= 4))
                {
                    *((bool4*)dst + 0) = last.v4_0;

                    dst = (bool*)dst + 4;
                    last = vshr(last, 4);

                    count -= 4;
                }

                if (Hint.Likely(count >= 2))
                {
                    *((bool2*)dst + 0) = last.v2_0;

                    dst = (bool*)dst + 2;
                    last = vshr(last, 2);

                    count -= 2;
                }

                if (Hint.Likely(count != 0))
                {
                    *((bool*)dst + 0) = last.x0;
                }
            }
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void CopyConvertBoolToBit([NoAlias] void* dst, int dstIndex, [NoAlias] void* src, int srcIndex, int count, bool merge = true)
        {
            src = (bool*)src + srcIndex;
            SubArrayIndexer<Bit> indexer = new SubArrayIndexer<Bit>(dstIndex);
            dst = indexer.GetOuterPtr(dst);
            uint dstByteOffset = divrem((uint)dstIndex, 8u, out uint usedBitsInDstByte);

            if (usedBitsInDstByte == 0)
            {
                if (COMPILATION_OPTIONS.OPTIMIZE_FOR == OptimizeFor.Performance)
                {
                    while (Hint.Likely(count >= 128))
                    {
                        *((int*)dst + 0) = bitmask(*((bool32*)src + 0));
                        *((int*)dst + 1) = bitmask(*((bool32*)src + 1));
                        if (Bmi2.IsBmi2Supported)
                        {
                            *((byte*)dst + 8)  = (byte)bits_extractparallel(*((ulong*)src + 8),  0x0101_0101_0101_0101);
                            *((byte*)dst + 9)  = (byte)bits_extractparallel(*((ulong*)src + 9),  0x0101_0101_0101_0101);
                            *((byte*)dst + 10) = (byte)bits_extractparallel(*((ulong*)src + 10), 0x0101_0101_0101_0101);
                            *((byte*)dst + 11) = (byte)bits_extractparallel(*((ulong*)src + 11), 0x0101_0101_0101_0101);
                        }
                        else
                        {
                            *((int*)dst + 2) = bitmask(*((bool32*)src + 2));
                        }
                        *((int*)dst + 3) = bitmask(*((bool32*)src + 3));

                        src = (bool*)src + 128;
                        dst = (byte*)dst + 128 / 8;

                        count -= 128;
                    }

                    if (Hint.Likely(count >= 64))
                    {
                        *((int*)dst + 0) = bitmask(*((bool32*)src + 0));
                        *((int*)dst + 1) = bitmask(*((bool32*)src + 1));

                        src = (bool*)src + 64;
                        dst = (byte*)dst + 64 / 8;

                        count -= 64;
                    }

                    if (Hint.Likely(count >= 32))
                    {
                        *((int*)dst + 0) = bitmask(*((bool32*)src + 0));

                        src = (bool*)src + 32;
                        dst = (byte*)dst + 32 / 8;

                        count -= 32;
                    }
                }
                else
                {
                    while (Hint.Likely(count >= 32))
                    {
                        *((int*)dst + 0) = bitmask(*((bool32*)src + 0));

                        src = (bool*)src + 32;
                        dst = (byte*)dst + 32 / 8;

                        count -= 32;
                    }
                }

                if (Hint.Likely(count >= 16))
                {
                    *((ushort*)dst + 0) = (ushort)bitmask(*((bool16*)src + 0));
                
                    src = (bool*)src + 16;
                    dst = (byte*)dst + 16 / 8;
                
                    count -= 16;
                }

                if (Hint.Likely(count >= 8))
                {
                    *((byte*)dst + 0) = (byte)bitmask(*((bool8*)src + 0));
                
                    src = (bool*)src + 8;
                    dst = (byte*)dst + 8 / 8;
                
                    count -= 8;
                }

                if (Hint.Likely(count != 0))
                {
                    byte last = 0;
                    int index = 0;
                    byte mask = bitmask8((uint)count);

                    if (Hint.Likely(count >= 4))
                    {
                        last |= (byte)bitmask(*((bool4*)src + 0));
                        index += 4;

                        src = (bool*)src + 4;
                    
                        count -= 4;
                    }

                    if (Hint.Likely(count >= 2))
                    {
                        last |= (byte)(bitmask(*((bool2*)src + 0)) << index);
                        index += 2;
                    
                        src = (bool*)src + 2;
                    
                        count -= 2;
                    }

                    if (Hint.Likely(count != 0))
                    {
                        last |= (byte)(tobyte(*((bool*)src + 0)) << index);
                    }

                    if (!merge)
                    {
                        *((byte*)dst + 0) = last;
                    }
                    else
                    {
                        *((byte*)dst + 0) = bits_select(*((byte*)dst + 0), last, mask);
                    }
                }
            }
            else
            {
                int shiftRightPostMerge = 32 - (int)usedBitsInDstByte;
                int currentLowBits = *(byte*)dst & bitmask8(usedBitsInDstByte);

                while (count >= 32)
                {
                    uint load = (uint)bitmask(*(bool32*)src);

                    *(uint*)dst = (uint)(currentLowBits | (int)(load << (int)usedBitsInDstByte));
                    currentLowBits = (int)(load >> shiftRightPostMerge);

                    count -= 32;
                    src = (bool*)src + 32;
                    dst = (uint*)dst + 1;
                }

                shiftRightPostMerge -= 16;

                if (count >= 16)
                {
                    ushort load = (ushort)bitmask(*(bool16*)src);

                    *(ushort*)dst = (ushort)(currentLowBits | (load << (int)usedBitsInDstByte));
                    currentLowBits = (ushort)(load >> shiftRightPostMerge);

                    count -= 16;
                    src = (bool*)src + 16;
                    dst = (ushort*)dst + 1;
                }

                shiftRightPostMerge -= 8;

                if (count >= 8)
                {
                    byte load = (byte)bitmask(*(bool8*)src);

                    *(byte*)dst = (byte)(currentLowBits | (load << (int)usedBitsInDstByte));
                    currentLowBits = (byte)(load >> shiftRightPostMerge);

                    count -= 8;
                    src = (bool*)src + 8;
                    dst = (byte*)dst + 1;
                }

                int writtenBits = (int)usedBitsInDstByte;

                if (count >= 4)
                {
                    currentLowBits |= bitmask(*(bool4*)src) << writtenBits;

                    count -= 4;
                    src = (bool*)src + 4;
                    writtenBits += 4;
                }

                if (count >= 2)
                {
                    currentLowBits |= bitmask(*(bool2*)src) << writtenBits;

                    count -= 2;
                    src = (bool*)src + 2;
                    writtenBits += 2;
                }

                if (count != 0)
                {
                    currentLowBits |= *(byte*)src << writtenBits;

                    writtenBits += 1;
                }

                if (writtenBits > 8)
                {
                    if (merge)
                    {
                        *(ushort*)dst = (ushort)bits_select(*(ushort*)dst, currentLowBits, bitmask32(writtenBits));
                    }
                    else
                    {
                        *(ushort*)dst = (ushort)currentLowBits;
                    }
                }
                else
                {
                    if (merge)
                    {
                        *(byte*)dst = (byte)bits_select(*(byte*)dst, currentLowBits, bitmask32(writtenBits));
                    }
                    else
                    {
                        *(byte*)dst = (byte)currentLowBits;
                    }
                }
            }
        }
    }
}
