using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Burst.CompilerServices;
using Unity.Mathematics;
using DevTools;
using MaxMath;
using SIMDAlgorithms;

using static Unity.Mathematics.math;
using static MaxMath.maxmath;

namespace BitCollections
{
    unsafe internal static partial class BitAlgorithms
    {
        [return: AssumeRange(-1L, int.MaxValue)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int Count<T>(void* basePtr, int startIndex, int count, long value, int arrayLength, Comparison where)
            where T : BitInt
        {
Assert.IsWithinArrayBounds(startIndex, arrayLength);
Assert.IsWithinArrayBounds(startIndex + count - tobyte(count != 0), arrayLength);
            
            int __count = 0;

            if (default(T).Bits == 1)
            {
                switch (where)
                {
                    case Comparison.GreaterThan:
                    {
                        if (value == 1)
                        {
                            return 0;
                        }
                        else
                        {
                            where = Comparison.NotEqualTo;
                            break;
                        }
                    }
                    case Comparison.LessThan:
                    {
                        if (value == 0)
                        {
                            return 0;
                        }
                        else
                        {
                            where = Comparison.NotEqualTo;
                            break;
                        }
                    }
                    case Comparison.GreaterThanOrEqualTo:
                    {
                        if (value == 0)
                        {
                            return count;
                        }
                        else
                        {
                            where = Comparison.EqualTo;
                            break;
                        }
                    }
                    case Comparison.LessThanOrEqualTo:
                    {
                        if (value == 0)
                        {
                            where = Comparison.EqualTo;
                            break;
                        }
                        else
                        {
                            return count;
                        }
                    }

                    default:
                    {
                        break;
                    }
                }

                __count = (int)CountBits(basePtr, startIndex, count);
                if ((value == 0 && where == Comparison.EqualTo)
                 || (value == 1 && where == Comparison.NotEqualTo))
                {
                    __count = count - __count;
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
                    byte read = *(byte*)basePtr;
                    basePtr = (byte*)basePtr + 1;

                    if (default(T).Bits == 4)
                    {
                        if (count == 0)
                        {
                            return 0;
                        }

                        if (default(T).IsSigned)
                        {
                            sbyte hi = (sbyte)((sbyte)read >> default(T).Bits);
                            __count += tobyte(where.Compare(hi, (sbyte)value));
                        }
                        else
                        {
                            byte hi = (byte)(read >> default(T).Bits);
                            __count += tobyte(where.Compare(hi, (byte)value));
                        }

                        count -= 1;
                    }
                    else
                    {
                        int valuesToCheckInFirstByte = min(count, 4 - innerIndex);
                        byte mask = bitmask8(default(T).Bits * (uint)valuesToCheckInFirstByte, default(T).Bits * (uint)innerIndex);
                        byte cmp = (byte)(mask & where.CompareSWAR<T>(read, splat));
                        __count += SWAR.CountBools<T>(cmp);
                        
                        count -= valuesToCheckInFirstByte;
                    }
                }

                uint8 splat256 = ((byte32)splat).Reinterpret<byte32, uint8>();

                while (count >= 256 / default(T).Bits)
                {
                    uint8 cmp = where.CompareSWAR<T>(*(uint8*)basePtr, splat256);
                    __count += SWAR.CountBools<T>(cmp);

                    count -= 256 / default(T).Bits;
                    basePtr = (uint8*)basePtr + 1;
                }

                if (count >= 128 / default(T).Bits)
                {
                    uint4 cmp = where.CompareSWAR<T>(*(uint4*)basePtr, splat256.v4_0);
                    __count += SWAR.CountBools<T>(cmp);

                    count -= 128 / default(T).Bits;
                    basePtr = (uint4*)basePtr + 1;
                }

                if (count >= 64 / default(T).Bits)
                {
                    ulong cmp = where.CompareSWAR<T>(*(ulong*)basePtr, splat256.v2_0.Reinterpret<uint2, ulong>());
                    __count += SWAR.CountBools<T>(cmp);

                    count -= 64 / default(T).Bits;
                    basePtr = (ulong*)basePtr + 1;
                }

                if (count >= 32 / default(T).Bits)
                {
                    uint cmp = where.CompareSWAR<T>(*(uint*)basePtr, splat256.x0);
                    __count += SWAR.CountBools<T>(cmp);

                    count -= 32 / default(T).Bits;
                    basePtr = (uint*)basePtr + 1;
                }

                if (count >= 16 / default(T).Bits)
                {
                    ushort cmp = where.CompareSWAR<T>(*(ushort*)basePtr, (ushort)splat256.x0);
                    __count += SWAR.CountBools<T>(cmp);

                    count -= 16 / default(T).Bits;
                    basePtr = (ushort*)basePtr + 1;
                }

                if (count >= 8 / default(T).Bits)
                {
                    byte cmp = where.CompareSWAR<T>(*(byte*)basePtr, (byte)splat256.x0);
                    __count += SWAR.CountBools<T>(cmp);

                    count -= 8 / default(T).Bits;
                    basePtr = (byte*)basePtr + 1;
                }

                if (count != 0)
                {
                    byte read = *(byte*)basePtr;

                    byte mask = bitmask8(default(T).Bits * (uint)count);
                    int cmp = mask & where.CompareSWAR<T>(read, splat);
                    __count += SWAR.CountBools<T>((byte)cmp);
                }
            }
            else
            {
                if (default(T).Bits <= 8)
                {
                    byte32 splat = (byte)value;
                    while (count >= 32)
                    {
                        byte32 load = LoadStore.LoadVector<T, byte32>(basePtr, startIndex, arrayLength);
                        __count += (int)maxmath.count(default(T).IsSigned ? where.Compare((sbyte32)load, (sbyte32)splat) : where.Compare(load, splat));

                        startIndex += 32;
                        count -= 32;
                    }

                    if (count >= 16)
                    {
                        byte16 load = LoadStore.LoadVector<T, byte16>(basePtr, startIndex, arrayLength);
                        __count += (int)maxmath.count(default(T).IsSigned ? where.Compare((sbyte16)load, (sbyte16)splat.v16_0) : where.Compare(load, splat.v16_0));

                        startIndex += 16;
                        count -= 16;
                    }

                    if (count >= 8)
                    {
                        byte8 load = LoadStore.LoadVector<T, byte8>(basePtr, startIndex, arrayLength);
                        __count += (int)maxmath.count(default(T).IsSigned ? where.Compare((sbyte8)load, (sbyte8)splat.v8_0) : where.Compare(load, splat.v8_0));

                        startIndex += 8;
                        count -= 8;
                    }

                    if (count >= 4)
                    {
                        byte4 load = LoadStore.LoadVector<T, byte4>(basePtr, startIndex, arrayLength);
                        __count += (int)maxmath.count(default(T).IsSigned ? where.Compare((sbyte4)load, (sbyte4)splat.v4_0) : where.Compare(load, splat.v4_0));

                        startIndex += 4;
                        count -= 4;
                    }

                    if (count >= 2)
                    {
                        byte2 load = LoadStore.LoadVector<T, byte2>(basePtr, startIndex, arrayLength);
                        __count += (int)maxmath.count(default(T).IsSigned ? where.Compare((sbyte2)load, (sbyte2)splat.v2_0) : where.Compare(load, splat.v2_0));

                        startIndex += 2;
                        count -= 2;
                    }

                    if (count != 0)
                    {
                        byte load = (byte)LoadStore.LoadScalar<T>(basePtr, startIndex, arrayLength);
                        __count += tobyte(default(T).IsSigned ? where.Compare((sbyte)load, (sbyte)value) : where.Compare(load, (byte)value));
                    }
                }
                else if (default(T).Bits <= 16)
                {
                    ushort16 splat = (ushort)value;
                    while (count >= 16)
                    {
                        ushort16 load = LoadStore.LoadVector<T, ushort16>(basePtr, startIndex, arrayLength);
                        __count += (int)maxmath.count(default(T).IsSigned ? where.Compare((short16)load, (short16)splat) : where.Compare(load, splat));

                        startIndex += 16;
                        count -= 16;
                    }

                    if (count >= 8)
                    {
                        ushort8 load = LoadStore.LoadVector<T, ushort8>(basePtr, startIndex, arrayLength);
                        __count += (int)maxmath.count(default(T).IsSigned ? where.Compare((short8)load, (short8)splat.v8_0) : where.Compare(load, splat.v8_0));

                        startIndex += 8;
                        count -= 8;
                    }

                    if (count >= 4)
                    {
                        ushort4 load = LoadStore.LoadVector<T, ushort4>(basePtr, startIndex, arrayLength);
                        __count += (int)maxmath.count(default(T).IsSigned ? where.Compare((short4)load, (short4)splat.v4_0) : where.Compare(load, splat.v4_0));

                        startIndex += 4;
                        count -= 4;
                    }

                    if (count >= 2)
                    {
                        ushort2 load = LoadStore.LoadVector<T, ushort2>(basePtr, startIndex, arrayLength);
                        __count += (int)maxmath.count(default(T).IsSigned ? where.Compare((short2)load, (short2)splat.v2_0) : where.Compare(load, splat.v2_0));

                        startIndex += 2;
                        count -= 2;
                    }

                    if (count != 0)
                    {
                        ushort load = (ushort)LoadStore.LoadScalar<T>(basePtr, startIndex, arrayLength);
                        __count += tobyte(default(T).IsSigned ? where.Compare((short)load, (short)value) : where.Compare(load, (ushort)value));
                    }
                }
                else if (default(T).Bits <= 32)
                {
                    uint8 splat = (uint)value;
                    while (count >= 8)
                    {
                        uint8 load = LoadStore.LoadVector<T, uint8>(basePtr, startIndex, arrayLength);
                        __count += (int)maxmath.count(default(T).IsSigned ? where.Compare((int8)load, (int8)splat) : where.Compare(load, splat));

                        startIndex += 8;
                        count -= 8;
                    }

                    if (count >= 4)
                    {
                        uint4 load = LoadStore.LoadVector<T, uint4>(basePtr, startIndex, arrayLength);
                        __count += (int)maxmath.count(default(T).IsSigned ? where.Compare((int4)load, (int4)splat.v4_0) : where.Compare(load, splat.v4_0));

                        startIndex += 4;
                        count -= 4;
                    }

                    if (count >= 2)
                    {
                        uint2 load = LoadStore.LoadVector<T, uint2>(basePtr, startIndex, arrayLength);
                        __count += (int)maxmath.count(default(T).IsSigned ? where.Compare((int2)load, (int2)splat.v2_0) : where.Compare(load, splat.v2_0));

                        startIndex += 2;
                        count -= 2;
                    }

                    if (count != 0)
                    {
                        uint load = (uint)LoadStore.LoadScalar<T>(basePtr, startIndex, arrayLength);
                        __count += tobyte(default(T).IsSigned ? where.Compare((int)load, (int)value) : where.Compare(load, (uint)value));
                    }
                }
                else
                {
                    long4 splat = value;
                    while (count >= 4)
                    {
                        ulong4 load = LoadStore.LoadVector<T, ulong4>(basePtr, startIndex, arrayLength);
                        __count += (int)maxmath.count(default(T).IsSigned ? where.Compare((long4)load, (long4)splat) : where.Compare(load, (ulong4)splat));

                        startIndex += 4;
                        count -= 4;
                    }

                    if (count >= 2)
                    {
                        ulong2 load = LoadStore.LoadVector<T, ulong2>(basePtr, startIndex, arrayLength);
                        __count += (int)maxmath.count(default(T).IsSigned ? where.Compare((long2)load, (long2)splat.xy) : where.Compare(load, (ulong2)splat.xy));

                        startIndex += 2;
                        count -= 2;
                    }

                    if (count != 0)
                    {
                        ulong load = (ulong)LoadStore.LoadScalar<T>(basePtr, startIndex, arrayLength);
                        __count += tobyte(default(T).IsSigned ? where.Compare((long)load, (long)value) : where.Compare(load, (ulong)value));
                    }
                }
            }

            return __count;
        }
    }
}
