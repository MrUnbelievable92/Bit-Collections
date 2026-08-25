using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;
using DevTools;

using static MaxMath.math;

namespace BitCollections
{
    unsafe internal static partial class LoadStore
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void CopyAscending<T>(void* srcPtr, int srcStartIndex, void* dstPtr, int dstStartIndex, int count)
            where T : BitInt
        {
Assert.IsNonNegative(srcStartIndex);
Assert.IsNonNegative(dstStartIndex);
Assert.IsNonNegative(count);

            ulong srcStartIndex64 = (ulong)(uint)srcStartIndex * default(T).Bits;
            ulong dstStartIndex64 = (ulong)(uint)dstStartIndex * default(T).Bits;
            ulong bitsToCopy = (ulong)(uint)count * default(T).Bits;

            if (Hint.Unlikely(bitsToCopy == 0))
            {
                return;
            }

            ulong lo;
            ulong srcByteOffset = divrem(srcStartIndex64, 8ul, out ulong unusedBitsInSrcByte);
            ulong dstByteOffset = divrem(dstStartIndex64, 8ul, out ulong usedBitsInDstByte);
            srcPtr = (byte*)srcPtr + srcByteOffset;
            dstPtr = (byte*)dstPtr + dstByteOffset;

            // Completely fill the first byte, adjust variables according to copied bits or return
            if (Hint.Likely(usedBitsInDstByte != 0))
            {
                byte loadSrc = *(byte*)srcPtr;
                loadSrc >>= (int)unusedBitsInSrcByte;
                loadSrc <<= (int)usedBitsInDstByte;

                ulong bitsToFill = 8ul - usedBitsInDstByte;

                if (Hint.Unlikely(bitsToCopy < bitsToFill))
                {
                    if (Hint.Unlikely(bitsToCopy > 8 - unusedBitsInSrcByte))
                    {
                        srcPtr = (byte*)srcPtr + 1;
                        loadSrc |= (byte)(*(byte*)srcPtr << (int)(8 - unusedBitsInSrcByte + usedBitsInDstByte));
                    }

                    byte mask = bitmask8((uint)bitsToCopy, (uint)usedBitsInDstByte);
                    *(byte*)dstPtr = bits_select(*(byte*)dstPtr, loadSrc, mask);

                    return;
                }
                else
                {
                    lo = (byte)(*(byte*)dstPtr & bitmask8((uint)usedBitsInDstByte));
                    lo |= loadSrc;

                    ulong copyableBits = 8ul - unusedBitsInSrcByte;
                    ulong occupiedBits = copyableBits + usedBitsInDstByte;

                    if (Hint.Unlikely(occupiedBits < 8))
                    {
                        bitsToCopy -= copyableBits;
                        bitsToFill = 8 - occupiedBits;

Assert.IsGreaterOrEqual(bitsToCopy, bitsToFill);
                        //if (Hint.Unlikely(bitsToCopy < bitsToFill))
                        //{
                        //    if (Hint.Unlikely(bitsToCopy > 8 - occupiedBits))
                        //    {
                        //        srcPtr = (byte*)srcPtr + 1;
                        //        loadSrc |= (byte)(*(byte*)srcPtr << (int)(8 - occupiedBits));
                        //    }
                        //
                        //    byte mask = bitmask8((uint)bitsToCopy, (uint)occupiedBits);
                        //    *(byte*)dstPtr = bits_select(*(byte*)dstPtr, lo, mask);
                        //
                        //    return;
                        //}
                        //else
                        //{
                              srcPtr = (byte*)srcPtr + 1;
                              lo |= (byte)(*(byte*)srcPtr << (int)occupiedBits);
                              unusedBitsInSrcByte = 8 - occupiedBits;
                              bitsToCopy -= unusedBitsInSrcByte;
                        //}
                    }
                    else
                    {
                        if (Hint.Likely(occupiedBits == 8))
                        {
                            srcPtr = (byte*)srcPtr + 1;
                            unusedBitsInSrcByte = 0;
                            bitsToCopy -= copyableBits;
                        }
                        else
                        {
                            bitsToCopy -= 8 - usedBitsInDstByte;
                            unusedBitsInSrcByte = 8 - (occupiedBits % 8);
                            //    unusedBitsInSrcByte += 8 - usedBitsInDstByte;
                        }
                    }

/////////////////////////////////////////////////////////////////////////////////
// The following is to avoid overwriting the source if the pointers are the same
                    ulong temp = (ulong)*(byte*)srcPtr >> (int)unusedBitsInSrcByte;
                    *(byte*)dstPtr = (byte)lo;
                    lo = temp;
                    dstPtr = (byte*)dstPtr + 1;
                }
            }
            else
            {
                lo = (ulong)*(byte*)srcPtr >> (int)unusedBitsInSrcByte;
            }
/////////////////////////////////////////////////////////////////////////////////

            if (Hint.Unlikely(unusedBitsInSrcByte == 0))
            {
                while (Hint.Likely(bitsToCopy >= 8))
                {
                    *(byte*)dstPtr = *(byte*)srcPtr;

                    dstPtr = (byte*)dstPtr + 1;
                    srcPtr = (byte*)srcPtr + 1;
                    bitsToCopy -= 8;
                }

                if (Hint.Likely(bitsToCopy != 0))
                {
                    byte lastMask = bitmask8((uint)bitsToCopy);
                    *(byte*)dstPtr = bits_select(*(byte*)dstPtr, *(byte*)srcPtr, lastMask);
                }
            }
            else
            {
                srcPtr = (byte*)srcPtr + 1;

                while (Hint.Likely(bitsToCopy >= 64))
                {
                    ulong load = *(ulong*)srcPtr;
                    ulong hi = load << (8 - (int)unusedBitsInSrcByte);
                    *(ulong*)dstPtr = lo | hi;
                    lo = load >> (56 + (int)unusedBitsInSrcByte);

                    bitsToCopy -= 64;
                    dstPtr = (ulong*)dstPtr + 1;
                    srcPtr = (ulong*)srcPtr + 1;
                }

                if (Hint.Likely(bitsToCopy >= 32))
                {
                    uint load = *(uint*)srcPtr;
                    uint hi = load << (8 - (int)unusedBitsInSrcByte);
                    *(uint*)dstPtr = (uint)lo | hi;
                    lo = load >> (24 + (int)unusedBitsInSrcByte);

                    bitsToCopy -= 32;
                    dstPtr = (uint*)dstPtr + 1;
                    srcPtr = (uint*)srcPtr + 1;
                }

                if (Hint.Likely(bitsToCopy >= 16))
                {
                    ushort load = *(ushort*)srcPtr;
                    ushort hi = (ushort)(load << (8 - (int)unusedBitsInSrcByte));
                    *(ushort*)dstPtr = (ushort)((ushort)lo | hi);
                    lo = (ushort)(load >> (8 + (int)unusedBitsInSrcByte));

                    bitsToCopy -= 16;
                    dstPtr = (ushort*)dstPtr + 1;
                    srcPtr = (ushort*)srcPtr + 1;
                }

                if (Hint.Likely(bitsToCopy >= 8))
                {
                    byte load = *(byte*)srcPtr;
                    byte hi = (byte)(load << (8 - (int)unusedBitsInSrcByte));
                    *(byte*)dstPtr = (byte)((byte)lo | hi);
                    lo = (byte)(load >> (int)unusedBitsInSrcByte);

                    bitsToCopy -= 8;
                    dstPtr = (byte*)dstPtr + 1;
                    srcPtr = (byte*)srcPtr + 1;
                }

                if (Hint.Likely(bitsToCopy != 0))
                {
                    if (Hint.Unlikely(bitsToCopy > 8 - unusedBitsInSrcByte))
                    {
                        lo |= (byte)(*(byte*)srcPtr << (int)(8 - unusedBitsInSrcByte));
                    }

                    byte lastMask = bitmask8((uint)bitsToCopy);
                    *(byte*)dstPtr = bits_select(*(byte*)dstPtr, (byte)lo, lastMask);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void CopyDescending<T>(void* srcPtr, int srcStartIndex, void* dstPtr, int dstStartIndex, int count)
            where T : BitInt
        {
Assert.IsNonNegative(srcStartIndex);
Assert.IsNonNegative(dstStartIndex);
Assert.IsNonNegative(count);
 
            ulong bitsToCopy = (ulong)(uint)count * default(T).Bits;
 
            if (Hint.Unlikely(bitsToCopy == 0))
            {
                return;
            }
 
            ulong lo;
            ulong srcTopBit = (ulong)(uint)srcStartIndex * default(T).Bits + default(T).Bits - 1;
            ulong dstTopBit = (ulong)(uint)dstStartIndex * default(T).Bits + default(T).Bits - 1;
            ulong srcByteOffset = divrem(srcTopBit, 8ul, out ulong srcTopBitInByte);
            ulong dstByteOffset = divrem(dstTopBit, 8ul, out ulong dstTopBitInByte);

            ulong unusedHighBitsInSrcByte = 7ul - srcTopBitInByte;
            ulong preservedHighBitsInDstByte = 7ul - dstTopBitInByte;
 
            srcPtr = (byte*)srcPtr + srcByteOffset;
            dstPtr = (byte*)dstPtr + dstByteOffset;
 
            // Completely fill the last byte, adjust variables according to copied bits or return
            if (Hint.Likely(preservedHighBitsInDstByte != 0))
            {
                byte loadSrc = *(byte*)srcPtr;
                loadSrc <<= (int)unusedHighBitsInSrcByte;
                loadSrc >>= (int)preservedHighBitsInDstByte;
 
                ulong bitsToFill = 8ul - preservedHighBitsInDstByte;
 
                if (Hint.Unlikely(bitsToCopy < bitsToFill))
                {
                    if (Hint.Unlikely(bitsToCopy > 8 - unusedHighBitsInSrcByte))
                    {
                        srcPtr = (byte*)srcPtr - 1;
                        loadSrc |= (byte)(*(byte*)srcPtr >> (int)(8 - unusedHighBitsInSrcByte + preservedHighBitsInDstByte));
                    }
 
                    byte mask = bitmask8((uint)bitsToCopy, (uint)(bitsToFill - bitsToCopy));
                    *(byte*)dstPtr = bits_select(*(byte*)dstPtr, loadSrc, mask);
 
                    return;
                }
                else
                {
                    lo = (byte)(*(byte*)dstPtr & bitmask8((uint)preservedHighBitsInDstByte, (uint)(8 - preservedHighBitsInDstByte)));
                    lo |= loadSrc;
 
                    ulong copyableBits = 8ul - unusedHighBitsInSrcByte;
                    ulong occupiedBits = copyableBits + preservedHighBitsInDstByte;
 
                    if (Hint.Unlikely(occupiedBits < 8))
                    {
                        bitsToCopy -= copyableBits;
 
Assert.IsGreaterOrEqual(bitsToCopy, 8 - occupiedBits);
 
                        srcPtr = (byte*)srcPtr - 1;
                        lo |= (byte)(*(byte*)srcPtr >> (int)occupiedBits);
                        unusedHighBitsInSrcByte = 8 - occupiedBits;
                        bitsToCopy -= unusedHighBitsInSrcByte;
                    }
                    else
                    {
                        if (Hint.Likely(occupiedBits == 8))
                        {
                            srcPtr = (byte*)srcPtr - 1;
                            unusedHighBitsInSrcByte = 0;
                            bitsToCopy -= copyableBits;
                        }
                        else
                        {
                            bitsToCopy -= 8 - preservedHighBitsInDstByte;
                            unusedHighBitsInSrcByte = 8 - (occupiedBits % 8);
                        }
                    }
 
/////////////////////////////////////////////////////////////////////////////////
// The following is to avoid overwriting the source if the pointers are the same
                    byte temp = (byte)(*(byte*)srcPtr << (int)unusedHighBitsInSrcByte);
                    *(byte*)dstPtr = (byte)lo;
                    lo = temp;
                    dstPtr = (byte*)dstPtr - 1;
                }
            }
            else
            {
                lo = (byte)(*(byte*)srcPtr << (int)unusedHighBitsInSrcByte);
            }
 
/////////////////////////////////////////////////////////////////////////////////

            if (Hint.Unlikely(unusedHighBitsInSrcByte == 0))
            {
                while (Hint.Likely(bitsToCopy >= 8))
                {
                    *(byte*)dstPtr = *(byte*)srcPtr;
 
                    dstPtr = (byte*)dstPtr - 1;
                    srcPtr = (byte*)srcPtr - 1;
                    bitsToCopy -= 8;
                }
 
                if (Hint.Likely(bitsToCopy != 0))
                {
                    byte lastMask = bitmask8((uint)bitsToCopy, (uint)(8 - bitsToCopy));
                    *(byte*)dstPtr = bits_select(*(byte*)dstPtr, *(byte*)srcPtr, lastMask);
                }
            }
            else
            {
                srcPtr = (byte*)srcPtr - 1;
 
                while (Hint.Likely(bitsToCopy >= 64))
                {
                    ulong load = *(ulong*)((byte*)srcPtr - 7);
                    ulong hi = load >> (8 - (int)unusedHighBitsInSrcByte);
                    *(ulong*)((byte*)dstPtr - 7) = (lo << 56) | hi;
                    lo = (byte)(load << (int)unusedHighBitsInSrcByte);
 
                    bitsToCopy -= 64;
                    dstPtr = (byte*)dstPtr - 8;
                    srcPtr = (byte*)srcPtr - 8;
                }
 
                if (Hint.Likely(bitsToCopy >= 32))
                {
                    uint load = *(uint*)((byte*)srcPtr - 3);
                    uint hi = load >> (8 - (int)unusedHighBitsInSrcByte);
                    *(uint*)((byte*)dstPtr - 3) = ((uint)lo << 24) | hi;
                    lo = (byte)(load << (int)unusedHighBitsInSrcByte);
 
                    bitsToCopy -= 32;
                    dstPtr = (byte*)dstPtr - 4;
                    srcPtr = (byte*)srcPtr - 4;
                }
 
                if (Hint.Likely(bitsToCopy >= 16))
                {
                    ushort load = *(ushort*)((byte*)srcPtr - 1);
                    ushort hi = (ushort)(load >> (8 - (int)unusedHighBitsInSrcByte));
                    *(ushort*)((byte*)dstPtr - 1) = (ushort)(((ushort)lo << 8) | hi);
                    lo = (byte)(load << (int)unusedHighBitsInSrcByte);
 
                    bitsToCopy -= 16;
                    dstPtr = (byte*)dstPtr - 2;
                    srcPtr = (byte*)srcPtr - 2;
                }
 
                if (Hint.Likely(bitsToCopy >= 8))
                {
                    byte load = *(byte*)srcPtr;
                    byte hi = (byte)(load >> (8 - (int)unusedHighBitsInSrcByte));
                    *(byte*)dstPtr = (byte)((byte)lo | hi);
                    lo = (byte)(load << (int)unusedHighBitsInSrcByte);
 
                    bitsToCopy -= 8;
                    dstPtr = (byte*)dstPtr - 1;
                    srcPtr = (byte*)srcPtr - 1;
                }
 
                if (Hint.Likely(bitsToCopy != 0))
                {
                    if (Hint.Unlikely(bitsToCopy > 8 - unusedHighBitsInSrcByte))
                    {
                        lo |= (byte)(*(byte*)srcPtr >> (int)(8 - unusedHighBitsInSrcByte));
                    }
 
                    byte lastMask = bitmask8((uint)bitsToCopy, (uint)(8 - bitsToCopy));
                    *(byte*)dstPtr = bits_select(*(byte*)dstPtr, (byte)lo, lastMask);
                }
            }
        }
    }
}
