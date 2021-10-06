﻿using DevTools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;
using Unity.Mathematics;
using MaxMath;

namespace BitCollections
{
    [Serializable]
    unsafe public struct Int4x16 : IBitNumberArray<int>, IEquatable<Int4x16>
    {
        internal ulong intern;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x16(int x0, int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10, int x11, int x12, int x13, int x14, int x15) : this(new int8(x0, x1, x2, x3, x4, x5, x6, x7), new int8(x8, x9, x10, x11, x12, x13, x14, x15))
        { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x16(int x0_15)
        {
            int8 vector = x0_15;

            this = new Int4x16(vector, vector);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x16(int8 x0_7, int8 x8_15)
        {
Assert.IsBetween(x0_7.x0,  Int4.MinValue, Int4.MaxValue);
Assert.IsBetween(x0_7.x1,  Int4.MinValue, Int4.MaxValue);
Assert.IsBetween(x0_7.x2,  Int4.MinValue, Int4.MaxValue);
Assert.IsBetween(x0_7.x3,  Int4.MinValue, Int4.MaxValue);
Assert.IsBetween(x0_7.x4,  Int4.MinValue, Int4.MaxValue);
Assert.IsBetween(x0_7.x5,  Int4.MinValue, Int4.MaxValue);
Assert.IsBetween(x0_7.x6,  Int4.MinValue, Int4.MaxValue);
Assert.IsBetween(x0_7.x7,  Int4.MinValue, Int4.MaxValue);
Assert.IsBetween(x8_15.x0, Int4.MinValue, Int4.MaxValue);
Assert.IsBetween(x8_15.x1, Int4.MinValue, Int4.MaxValue);
Assert.IsBetween(x8_15.x2, Int4.MinValue, Int4.MaxValue);
Assert.IsBetween(x8_15.x3, Int4.MinValue, Int4.MaxValue);
Assert.IsBetween(x8_15.x4, Int4.MinValue, Int4.MaxValue);
Assert.IsBetween(x8_15.x5, Int4.MinValue, Int4.MaxValue);
Assert.IsBetween(x8_15.x6, Int4.MinValue, Int4.MaxValue);
Assert.IsBetween(x8_15.x7, Int4.MinValue, Int4.MaxValue);

            int8 mask = (int)maxmath.bitmask32(new Int4x16().BitsPerNumber);

            intern = ((ulong)(uint)maxmath.csum(maxmath.shl(mask & x0_7, new Int4x16().BitsPerNumber * new int8(0, 1, 2, 3, 4, 5, 6, 7)))
                      |
                      ((ulong)(uint)maxmath.csum(maxmath.shl(mask & x8_15, new Int4x16().BitsPerNumber * new int8(0, 1, 2, 3, 4, 5, 6, 7))) << (new Int4x16().BitsPerNumber * 8)));
        }


        public readonly int MinValue => Int4.MinValue;
        public readonly int MaxValue => Int4.MaxValue;
        public readonly int BitsPerNumber => 4;
        public readonly int Length => 16;


        public int x0
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[0];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[0] = value;
        }
        public int x1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[1];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[1] = value;
        }
        public int x2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[2];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[2] = value;
        }
        public int x3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[3];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[3] = value;
        }
        public int x4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[4];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[4] = value;
        }
        public int x5
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[5];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[5] = value;
        }
        public int x6
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[6];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[6] = value;
        }
        public int x7
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[7];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[7] = value;
        }
        public int x8
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[8];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[8] = value;
        }
        public int x9
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[9];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[9] = value;
        }
        public int x10
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[10];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[10] = value;
        }
        public int x11
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[11];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[11] = value;
        }
        public int x12
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[12];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[12] = value;
        }
        public int x13
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[13];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[13] = value;
        }
        public int x14
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[14];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[14] = value;
        }
        public int x15
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[15];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[15] = value;
        }


        public int this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(Int4.MinValue, Int4.MaxValue)]
            readonly get
            {
Assert.IsWithinArrayBounds(index, Length);

                if (Constant.IsConstantExpression(index) && index == Length - 1)
                {
                    return (int)((long)intern >> (index * BitsPerNumber));
                }
                else { }


                // manual sign extend => 1 bitshift less; same if 'index' is not a compile time constant
                return (int)(((long)intern << (64 - ((1 + index) * BitsPerNumber))) >> (64 - BitsPerNumber));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsBetween(value, MinValue, MaxValue);
Assert.IsWithinArrayBounds(index, Length);

                if (Constant.IsConstantExpression(index) && Constant.IsConstantExpression(value) && value == 0 && index == Length - 1)
                {
                    intern = maxmath.bits_zerohigh(intern, (Length - 1) * BitsPerNumber);
                }
                else
                {
                    int shiftValue = index * BitsPerNumber;
                    long newValue = ((long)value & maxmath.bitmask64(BitsPerNumber)) << shiftValue;
                    long mask = math.rol(~maxmath.bitmask64(BitsPerNumber), shiftValue);

                    intern = (intern & (ulong)mask) | (ulong)newValue;
                }
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long4 GetSubArray(int index)
        {
Assert.IsValidSubarray(index, 4, Length);

            // manual sign extend => 1 bitshift less; same if 'index' is not a compile time constant
            long4 temp = maxmath.shl((long)intern, (long4)(64 - (BitsPerNumber * (index + new int4(1, 2, 3, 4)))));

            return temp >> (64 - BitsPerNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetSubArray(int index, long4 value)
        {
Assert.IsValidSubarray(index, 4, Length);
Assert.IsBetween(value.x, MinValue, MaxValue);
Assert.IsBetween(value.y, MinValue, MaxValue);
Assert.IsBetween(value.z, MinValue, MaxValue);
Assert.IsBetween(value.w, MinValue, MaxValue);

            intern = (maxmath.andnot((ulong)intern, (ulong)maxmath.bitmask64(4 * BitsPerNumber,   index * BitsPerNumber))
                      |
                     (ulong)maxmath.csum(maxmath.shl((int)maxmath.bitmask32(BitsPerNumber) & value, (long4)(BitsPerNumber * (index + new int4(0, 1, 2, 3))))));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetAll(int index, int numNumbers, int value)
        {
Assert.IsBetween(value, Int4.MinValue, Int4.MaxValue);
Assert.IsValidSubarray(index, numNumbers, Length);

            if (Constant.IsConstantExpression(value))
            {
                if (Constant.IsConstantExpression(index) && Constant.IsConstantExpression(numNumbers) && index + numNumbers == Length && value == 0)
                {
                    if (index == 0)
                    {
                        intern = 0u;
                    }
                    else
                    {
                        intern = maxmath.bits_zerohigh(intern, index * BitsPerNumber);
                    }
                }
                else
                {
                    ulong mask = (ulong)maxmath.bitmask64(numNumbers * BitsPerNumber, index * BitsPerNumber);
                    ulong newValues = new Int4x16(value).intern & mask;
                    ulong oldValues = maxmath.andnot(intern, mask);

                    intern = newValues | oldValues;
                }
            }
            else
            {
                int lastIndex = index + numNumbers;

                while (index <= lastIndex)
                {
                    this[index] = value;
                    index++;
                }
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Int4x16 other)
        {
            return this.intern == other.intern;
        }

        public override readonly bool Equals(object obj)
        {
            return Equals((Int4x16)obj);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
            return intern.GetHashCode();
        }


        public override string ToString()
        {
            return new ArrayEnumerator<int>(this).ToString();
        }


        public IEnumerator<int> GetEnumerator()
        {
            return new ArrayEnumerator<int>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<int>(this);
        }
    }
}