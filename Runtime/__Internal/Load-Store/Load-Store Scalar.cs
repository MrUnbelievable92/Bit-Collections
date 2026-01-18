using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;
using Unity.Mathematics;
using DevTools;
using MaxMath;

using static Unity.Mathematics.math;
using static MaxMath.maxmath;

namespace BitCollections
{
    unsafe internal static partial class LoadStore
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static long LoadScalar<T>(void* basePtr, int index, int length)
            where T : BitInt
        {
Assert.IsWithinArrayBounds(index, length);

            switch (default(T).Bits)
            {
                case 1:  { SubArrayIndexer<T> i = new SubArrayIndexer<T>(index); return tobyte((*(bit8*)i.GetOuterPtr(basePtr))[(int)i.InnerIndex]); }
                case 2:  { SubArrayIndexer<T> i = new SubArrayIndexer<T>(index); return default(T).IsSigned ? (*(Int2x4*) i.GetOuterPtr(basePtr))[(int)i.InnerIndex] : (int)(*(UInt2x4*) i.GetOuterPtr(basePtr))[(int)i.InnerIndex]; }
                case 3:  { SubArrayIndexer<T> i = new SubArrayIndexer<T>(index); return default(T).IsSigned ? (*(Int3x8*) i.GetOuterPtr(basePtr))[(int)i.InnerIndex] : (int)(*(UInt3x8*) i.GetOuterPtr(basePtr))[(int)i.InnerIndex]; }
                case 4:  { SubArrayIndexer<T> i = new SubArrayIndexer<T>(index); return default(T).IsSigned ? (*(Int4x2*) i.GetOuterPtr(basePtr))[(int)i.InnerIndex] : (int)(*(UInt4x2*) i.GetOuterPtr(basePtr))[(int)i.InnerIndex]; }
                case 5:  { SubArrayIndexer<T> i = new SubArrayIndexer<T>(index); return default(T).IsSigned ? (*(Int5x8*) i.GetOuterPtr(basePtr))[(int)i.InnerIndex] : (int)(*(UInt5x8*) i.GetOuterPtr(basePtr))[(int)i.InnerIndex]; }
                case 6:  { SubArrayIndexer<T> i = new SubArrayIndexer<T>(index); return default(T).IsSigned ? (*(Int6x4*) i.GetOuterPtr(basePtr))[(int)i.InnerIndex] : (int)(*(UInt6x4*) i.GetOuterPtr(basePtr))[(int)i.InnerIndex]; }
                case 7:  { SubArrayIndexer<T> i = new SubArrayIndexer<T>(index); return default(T).IsSigned ? (*(Int7x8*) i.GetOuterPtr(basePtr))[(int)i.InnerIndex] : (int)(*(UInt7x8*) i.GetOuterPtr(basePtr))[(int)i.InnerIndex]; }
                case 10: { SubArrayIndexer<T> i = new SubArrayIndexer<T>(index); return default(T).IsSigned ? (*(Int10x4*)i.GetOuterPtr(basePtr))[(int)i.InnerIndex] : (int)(*(UInt10x4*)i.GetOuterPtr(basePtr))[(int)i.InnerIndex]; }
                case 12: { SubArrayIndexer<T> i = new SubArrayIndexer<T>(index); return default(T).IsSigned ? (*(Int12x2*)i.GetOuterPtr(basePtr))[(int)i.InnerIndex] : (int)(*(UInt12x2*)i.GetOuterPtr(basePtr))[(int)i.InnerIndex]; }
                case 14: { SubArrayIndexer<T> i = new SubArrayIndexer<T>(index); return default(T).IsSigned ? (*(Int14x4*)i.GetOuterPtr(basePtr))[(int)i.InnerIndex] : (int)(*(UInt14x4*)i.GetOuterPtr(basePtr))[(int)i.InnerIndex]; }
                case 20: { SubArrayIndexer<T> i = new SubArrayIndexer<T>(index); return default(T).IsSigned ? (*(Int20x2*)i.GetOuterPtr(basePtr))[(int)i.InnerIndex] : (int)(*(UInt20x2*)i.GetOuterPtr(basePtr))[(int)i.InnerIndex]; }
                case 28: { SubArrayIndexer<T> i = new SubArrayIndexer<T>(index); return default(T).IsSigned ? (*(Int28x2*)i.GetOuterPtr(basePtr))[(int)i.InnerIndex] : (int)(*(UInt28x2*)i.GetOuterPtr(basePtr))[(int)i.InnerIndex]; }

                default:
                {
Assert.IsBetween(default(T).Bits, 1, 63);

                    ulong startingByte = divrem((ulong)(uint)index * default(T).Bits, 8, out ulong ignoredBits);
                    byte* ptr = (byte*)basePtr + startingByte;

                    if (default(T).Bits == 8)
                    {
                        return BitFieldHelper.Get<T>(*(byte*)ptr, (int)ignoredBits, 8);
                    }
                    else if (default(T).Bits <= 16 - 7)
                    {
                        return BitFieldHelper.Get<T>(*(ushort*)ptr, (int)ignoredBits, 16);
                    }
                    else if (default(T).Bits <= 32 - 7)
                    {
                        return BitFieldHelper.Get<T>(*(uint*)ptr, (int)ignoredBits, 32);
                    }
                    else if (default(T).Bits <= 32)
                    {
                        return BitFieldHelper.Get<T>(*(ulong*)ptr, (int)ignoredBits, 64);
                    }
                    else
                    {
                        return BitFieldHelper.Get<T>(*(UInt128*)ptr, (int)ignoredBits, 128);
                    }
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreScalar<T>(void* basePtr, int index, int length, long value)
            where T : BitInt
        {
Assert.IsWithinArrayBounds(index, length);

            SubArrayIndexer<T> i = new SubArrayIndexer<T>(index);
            void* outerPtr = i.GetOuterPtr(basePtr);

            if (default(T).Bits == 1)
            {
                bit8 arr = *(bit8*)outerPtr;
                arr[(int)i.InnerIndex] = tobool(value);
                *(bit8*)outerPtr = arr;

                return;
            }

            if (default(T).IsSigned)
            {
                switch (default(T).Bits)
                {
                    case 2:
                    {
                        Int2x4 arr = *(Int2x4*)outerPtr;
                        arr[(int)i.InnerIndex] = (int)value;
                        *(Int2x4*)outerPtr = arr;

                        return;
                    }
                    case 3:
                    {
                        Int3x8 arr = *(Int3x8*)outerPtr;
                        arr[(int)i.InnerIndex] = (int)value;
                        *(Int3x8*)outerPtr = arr;

                        return;
                    }
                    case 4:
                    {
                        Int4x2 arr = *(Int4x2*)outerPtr;
                        arr[(int)i.InnerIndex] = (int)value;
                        *(Int4x2*)outerPtr = arr;

                        return;
                    }
                    case 5:
                    {
                        Int5x8 arr = *(Int5x8*)outerPtr;
                        arr[(int)i.InnerIndex] = (int)value;
                        *(Int5x8*)outerPtr = arr;

                        return;
                    }
                    case 6:
                    {
                        Int6x4 arr = *(Int6x4*)outerPtr;
                        arr[(int)i.InnerIndex] = (int)value;
                        *(Int6x4*)outerPtr = arr;

                        return;
                    }
                    case 7:
                    {
                        Int7x8 arr = *(Int7x8*)outerPtr;
                        arr[(int)i.InnerIndex] = (int)value;
                        *(Int7x8*)outerPtr = arr;

                        return;
                    }
                    case 10:
                    {
                        Int10x4 arr = *(Int10x4*)outerPtr;
                        arr[(int)i.InnerIndex] = (int)value;
                        *(Int10x4*)outerPtr = arr;

                        return;
                    }
                    case 12:
                    {
                        Int12x2 arr = *(Int12x2*)outerPtr;
                        arr[(int)i.InnerIndex] = (int)value;
                        *(Int12x2*)outerPtr = arr;

                        return;
                    }
                    case 14:
                    {
                        Int14x4 arr = *(Int14x4*)outerPtr;
                        arr[(int)i.InnerIndex] = (int)value;
                        *(Int14x4*)outerPtr = arr;

                        return;
                    }
                    case 20:
                    {
                        Int20x2 arr = *(Int20x2*)outerPtr;
                        arr[(int)i.InnerIndex] = (int)value;
                        *(Int20x2*)outerPtr = arr;

                        return;
                    }
                    case 28:
                    {
                        Int28x2 arr = *(Int28x2*)outerPtr;
                        arr[(int)i.InnerIndex] = (int)value;
                        *(Int28x2*)outerPtr = arr;

                        return;
                    }

                    default: break;
                }
            }
            else
            {
                switch (default(T).Bits)
                {
                    case 2:
                    {
                        UInt2x4 arr = *(UInt2x4*)outerPtr;
                        arr[(int)i.InnerIndex] = (uint)value;
                        *(UInt2x4*)outerPtr = arr;

                        return;
                    }
                    case 3:
                    {
                        UInt3x8 arr = *(UInt3x8*)outerPtr;
                        arr[(int)i.InnerIndex] = (uint)value;
                        *(UInt3x8*)outerPtr = arr;

                        return;
                    }
                    case 4:
                    {
                        UInt4x2 arr = *(UInt4x2*)outerPtr;
                        arr[(int)i.InnerIndex] = (uint)value;
                        *(UInt4x2*)outerPtr = arr;

                        return;
                    }
                    case 5:
                    {
                        UInt5x8 arr = *(UInt5x8*)outerPtr;
                        arr[(int)i.InnerIndex] = (uint)value;
                        *(UInt5x8*)outerPtr = arr;

                        return;
                    }
                    case 6:
                    {
                        UInt6x4 arr = *(UInt6x4*)outerPtr;
                        arr[(int)i.InnerIndex] = (uint)value;
                        *(UInt6x4*)outerPtr = arr;

                        return;
                    }
                    case 7:
                    {
                        UInt7x8 arr = *(UInt7x8*)outerPtr;
                        arr[(int)i.InnerIndex] = (uint)value;
                        *(UInt7x8*)outerPtr = arr;

                        return;
                    }
                    case 10:
                    {
                        UInt10x4 arr = *(UInt10x4*)outerPtr;
                        arr[(int)i.InnerIndex] = (uint)value;
                        *(UInt10x4*)outerPtr = arr;

                        return;
                    }
                    case 12:
                    {
                        UInt12x2 arr = *(UInt12x2*)outerPtr;
                        arr[(int)i.InnerIndex] = (uint)value;
                        *(UInt12x2*)outerPtr = arr;

                        return;
                    }
                    case 14:
                    {
                        UInt14x4 arr = *(UInt14x4*)outerPtr;
                        arr[(int)i.InnerIndex] = (uint)value;
                        *(UInt14x4*)outerPtr = arr;

                        return;
                    }
                    case 20:
                    {
                        UInt20x2 arr = *(UInt20x2*)outerPtr;
                        arr[(int)i.InnerIndex] = (uint)value;
                        *(UInt20x2*)outerPtr = arr;

                        return;
                    }
                    case 28:
                    {
                        UInt28x2 arr = *(UInt28x2*)outerPtr;
                        arr[(int)i.InnerIndex] = (uint)value;
                        *(UInt28x2*)outerPtr = arr;

                        return;
                    }

                    default: break;
                }
            }

Assert.IsBetween(default(T).Bits, 1, 63);
Assert.IsBetween(value, default(T).MinValueAsLong, default(T).MaxValueAsLong);

            ulong startingByte = divrem((ulong)(uint)index * default(T).Bits, 8, out ulong ignoredBits);
            byte* ptr = (byte*)basePtr + startingByte;

            if (default(T).Bits == 8)
            {
                *(byte*)ptr = (byte)BitFieldHelper.Set<T>(*(byte*)ptr, value, (int)ignoredBits, 16);
            }
            else if (default(T).Bits <= 16 - 7)
            {
                *(ushort*)ptr = (ushort)BitFieldHelper.Set<T>(*(ushort*)ptr, value, (int)ignoredBits, 16);
            }
            else if (default(T).Bits <= 32 - 7)
            {
                *(uint*)ptr = (uint)BitFieldHelper.Set<T>(*(uint*)ptr, value, (int)ignoredBits, 32);
            }
            else if (default(T).Bits <= 32)
            {
                *(ulong*)ptr = BitFieldHelper.Set<T>(*(ulong*)ptr, value, (int)ignoredBits, 64);
            }
            else
            {
                *(UInt128*)ptr = BitFieldHelper.Set<T>(*(UInt128*)ptr, value, (int)ignoredBits, 128);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreReplicate<T>(void* basePtr, int startIndex, int count, long value)
            where T : BitInt
        {
Assert.IsNonNegative(startIndex);
Assert.IsNonNegative(count);
            
            if (Hint.Unlikely(count == 0))
            {
                return;
            }

            if (default(T).Bits == 1)
            {
                long splatValue = -value;
                long4 splatValue4 = splatValue;
                basePtr = (byte*)basePtr + divrem((uint)startIndex, 8u, out uint retainedStartBits);
                int valuesToSetInFirstByte = min(count, 8 - (int)retainedStartBits);
                byte mask = bitmask8((uint)valuesToSetInFirstByte, retainedStartBits);

                *(byte*)basePtr = bits_select(*(byte*)basePtr, (byte)splatValue, mask);
                basePtr = (byte*)basePtr + 1;
                count -= valuesToSetInFirstByte;

                while (Hint.Likely(count >= 256))
                {
                    *(long4*)basePtr = splatValue4;
                    basePtr = (long4*)basePtr + 1;
                    count -= 256;
                }
                if (Hint.Likely(count >= 128))
                {
                    *(long2*)basePtr = splatValue4.xy;
                    basePtr = (long2*)basePtr + 1;
                    count -= 128;
                }
                if (Hint.Likely(count >= 64))
                {
                    *(long*)basePtr = splatValue;
                    basePtr = (long*)basePtr + 1;
                    count -= 64;
                }
                if (Hint.Likely(count >= 32))
                {
                    *(int*)basePtr = (int)splatValue;
                    basePtr = (int*)basePtr + 1;
                    count -= 32;
                }
                if (Hint.Likely(count >= 16))
                {
                    *(short*)basePtr = (short)splatValue;
                    basePtr = (short*)basePtr + 1;
                    count -= 16;
                }
                if (Hint.Likely(count >= 8))
                {
                    *(byte*)basePtr = (byte)splatValue;
                    basePtr = (byte*)basePtr + 1;
                    count -= 8;
                }
                if (Hint.Likely(count != 0))
                {
                    *(byte*)basePtr = bits_select(*(byte*)basePtr, (byte)splatValue, bitmask8((uint)count));
                }
            }
            else if (default(T).Bits == 2
                  || default(T).Bits == 4)
            {
                SubArrayIndexer<T> indexer = new SubArrayIndexer<T>(startIndex);
                basePtr = indexer.GetOuterPtr(basePtr);
                int innerIndex = (int)indexer.InnerIndex;
                
                byte splat = (default(T).Bits == 2) ? (default(T).IsSigned ? new Int2x4((sbyte)value).Bits
                                                                           : new UInt2x4((byte)value).Bits)
                                                    : (default(T).IsSigned ? new Int4x2((sbyte)value).Bits
                                                                           : new UInt4x2((byte)value).Bits);
                if (innerIndex != 0)
                {
                    if (default(T).Bits == 4)
                    {
                        *(byte*)basePtr = bits_select(splat, *(byte*)basePtr, bitmask8((uint)default(T).Bits));

                        count -= 1;
                    }
                    else
                    {
                        int valuesToSetInFirstByte = min(count, 4 - innerIndex);
                        byte mask = bitmask8(default(T).Bits * (uint)valuesToSetInFirstByte, default(T).Bits * (uint)innerIndex);
                        *(byte*)basePtr = bits_select(*(byte*)basePtr, splat, mask);
                        
                        count -= valuesToSetInFirstByte;
                    }

                    basePtr = (byte*)basePtr + 1;
                }

                byte32 splat32 = splat;
                while (count >= 256 / default(T).Bits)
                {
                    *(byte32*)basePtr = splat32;
                    basePtr = (byte32*)basePtr + 1;
                    count -= 256 / default(T).Bits;
                }

                if (count >= 128 / default(T).Bits)
                {
                    *(byte16*)basePtr = splat32.v16_0;
                    basePtr = (byte16*)basePtr + 1;
                    count -= 128 / default(T).Bits;
                }

                if (count >= 64 / default(T).Bits)
                {
                    *(byte8*)basePtr = splat32.v8_0;
                    basePtr = (byte8*)basePtr + 1;
                    count -= 64 / default(T).Bits;
                }

                if (count >= 32 / default(T).Bits)
                {
                    *(byte4*)basePtr = splat32.v4_0;
                    basePtr = (byte4*)basePtr + 1;
                    count -= 32 / default(T).Bits;
                }

                if (count >= 16 / default(T).Bits)
                {
                    *(byte2*)basePtr = splat32.v2_0;
                    basePtr = (byte2*)basePtr + 1;
                    count -= 16 / default(T).Bits;
                }

                if (count >= 8 / default(T).Bits)
                {
                    *(byte*)basePtr = splat32.x0;
                    basePtr = (byte*)basePtr + 1;
                    count -= 8 / default(T).Bits;
                }

                if (count != 0)
                {
                    byte mask = bitmask8(default(T).Bits * (uint)count);
                    *(byte*)basePtr = bits_select(*(byte*)basePtr, splat, mask);
                }
            }
            else
            {
                if (default(T).Bits <= 8)
                {
                    byte32 splat = (byte)value;
                    while (count >= 32)
                    {
                        StoreVector<T, byte32>(basePtr, splat, startIndex, int.MaxValue);
                        startIndex += 32;
                        count -= 32;
                    }

                    if (count >= 16)
                    {
                        StoreVector<T, byte16>(basePtr, splat.v16_0, startIndex, int.MaxValue);
                        startIndex += 16;
                        count -= 16;
                    }

                    if (count >= 8)
                    {
                        StoreVector<T, byte8>(basePtr, splat.v8_0, startIndex, int.MaxValue);
                        startIndex += 8;
                        count -= 8;
                    }

                    if (count >= 4)
                    {
                        StoreVector<T, byte4>(basePtr, splat.v4_0, startIndex, int.MaxValue);
                        startIndex += 4;
                        count -= 4;
                    }

                    if (count >= 2)
                    {
                        StoreVector<T, byte2>(basePtr, splat.v2_0, startIndex, int.MaxValue);
                        startIndex += 2;
                        count -= 2;
                    }

                    if (count != 0)
                    {
                        StoreScalar<T>(basePtr, startIndex, int.MaxValue, value);
                    }
                }
                else if (default(T).Bits <= 16)
                {
                    ushort16 splat = (ushort)value;
                    while (count >= 16)
                    {
                        StoreVector<T, ushort16>(basePtr, splat, startIndex, int.MaxValue);
                        startIndex += 16;
                        count -= 16;
                    }

                    if (count >= 8)
                    {
                        StoreVector<T, ushort8>(basePtr, splat.v8_0, startIndex, int.MaxValue);
                        startIndex += 8;
                        count -= 8;
                    }

                    if (count >= 4)
                    {
                        StoreVector<T, ushort4>(basePtr, splat.v4_0, startIndex, int.MaxValue);
                        startIndex += 4;
                        count -= 4;
                    }

                    if (count >= 2)
                    {
                        StoreVector<T, ushort2>(basePtr, splat.v2_0, startIndex, int.MaxValue);
                        startIndex += 2;
                        count -= 2;
                    }

                    if (count != 0)
                    {
                        StoreScalar<T>(basePtr, startIndex, int.MaxValue, value);
                    }
                }
                else if (default(T).Bits <= 32)
                {
                    uint8 splat = (uint)value;
                    while (count >= 8)
                    {
                        StoreVector<T, uint8>(basePtr, splat, startIndex, int.MaxValue);
                        startIndex += 8;
                        count -= 8;
                    }

                    if (count >= 4)
                    {
                        StoreVector<T, uint4>(basePtr, splat.v4_0, startIndex, int.MaxValue);
                        startIndex += 4;
                        count -= 4;
                    }

                    if (count >= 2)
                    {
                        StoreVector<T, uint2>(basePtr, splat.v2_0, startIndex, int.MaxValue);
                        startIndex += 2;
                        count -= 2;
                    }

                    if (count != 0)
                    {
                        StoreScalar<T>(basePtr, startIndex, int.MaxValue, value);
                    }
                }
                else
                {
                    long4 splat = value;
                    while (count >= 4)
                    {
                        StoreVector<T, long4>(basePtr, splat, startIndex, int.MaxValue);
                        startIndex += 4;
                        count -= 4;
                    }

                    if (count >= 2)
                    {
                        StoreVector<T, long2>(basePtr, splat.xy, startIndex, int.MaxValue);
                        startIndex += 2;
                        count -= 2;
                    }

                    if (count != 0)
                    {
                        StoreScalar<T>(basePtr, startIndex, int.MaxValue, value);
                    }
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Insert<T>(void* basePtr, int oldLength, int index, long value)
            where T : BitInt
        {
Assert.IsWithinArrayBounds(index, oldLength);
Assert.IsBetween(value, default(T).MinValueAsLong, default(T).MaxValueAsLong);

            if (default(T).Bits < 8)
            {
                CopyAscending<T>(basePtr, index, basePtr, index + 1, oldLength - index);
            }
            else
            {
                CopyDescending<T>(basePtr, oldLength - 1, basePtr, oldLength, oldLength - index);
            }

            StoreScalar<T>(basePtr, index, oldLength + 1, value);
        }
    }
}
