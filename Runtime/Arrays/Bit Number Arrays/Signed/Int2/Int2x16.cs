using DevTools;
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
    unsafe public struct Int2x16 : IBitNumberArray<int>, IEquatable<Int2x16>
    {
        internal uint intern;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x16(int x0, int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10, int x11, int x12, int x13, int x14, int x15) : this(new int8(x0, x1, x2, x3, x4, x5, x6, x7), new int8(x8, x9, x10, x11, x12, x13, x14, x15))
        { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x16(int x0_15)
        {
            int8 temp = x0_15;

            this = new Int2x16(temp, temp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x16(int8 x0_7, int8 x8_15)
        {
Assert.IsBetween(x0_7.x0,  Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x0_7.x1,  Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x0_7.x2,  Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x0_7.x3,  Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x0_7.x4,  Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x0_7.x5,  Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x0_7.x6,  Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x0_7.x7,  Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x8_15.x0, Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x8_15.x1, Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x8_15.x2, Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x8_15.x3, Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x8_15.x4, Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x8_15.x5, Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x8_15.x6, Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x8_15.x7, Int2.MinValue, Int2.MaxValue);

            int8 mask = (int)maxmath.bitmask32(new Int2x16().BitsPerNumber);

            intern = (uint)maxmath.csum(maxmath.shl(mask & x0_7, new Int2x16().BitsPerNumber * new int8(0, 1, 2, 3, 4, 5, 6, 7))
                                        |
                                        maxmath.shl(mask & x8_15, new Int2x16().BitsPerNumber * new int8(8, 9, 10, 11, 12, 13, 14, 15)));
        }


        public readonly int MinValue => Int2.MinValue;
        public readonly int MaxValue => Int2.MaxValue;
        public readonly int BitsPerNumber => 2;
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
            [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(Int2.MinValue, Int2.MaxValue)]
            readonly get
            {
Assert.IsWithinArrayBounds(index, Length);

                if (Unity.Burst.Intrinsics.X86.Bmi1.IsBmi1Supported)
                {
                    return maxmath.signextend((int)maxmath.bits_extract(intern, index * BitsPerNumber, BitsPerNumber), BitsPerNumber);
                }
                else
                {
                    // manual sign extend => 1 bitshift less; same if 'index' is not a compile time constant
                    return ((int)intern << (32 - ((1 + index) * BitsPerNumber))) >> (32 - BitsPerNumber);
                }
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
                    int newValue = (value & (int)maxmath.bitmask32(BitsPerNumber)) << shiftValue;
                    int mask = math.rol(~(int)maxmath.bitmask32(BitsPerNumber), shiftValue);

                    intern = (uint)(((int)intern & mask) | newValue);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int8 GetSubArray(int index)
        {
Assert.IsValidSubarray(index, 8, Length);

            // manual sign extend => 1 bitshift less; same if 'index' is not a compile time constant
            int8 temp = maxmath.shl((int)intern, 32 - (BitsPerNumber * (index + new int8(1, 2, 3, 4, 5, 6, 7, 8))));

            return temp >> (32 - BitsPerNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetSubArray(int index, int8 value)
        {
Assert.IsValidSubarray(index, 8, Length);
Assert.IsBetween(value.x0, MinValue, MaxValue);
Assert.IsBetween(value.x1, MinValue, MaxValue);
Assert.IsBetween(value.x2, MinValue, MaxValue);
Assert.IsBetween(value.x3, MinValue, MaxValue);
Assert.IsBetween(value.x4, MinValue, MaxValue);
Assert.IsBetween(value.x5, MinValue, MaxValue);
Assert.IsBetween(value.x6, MinValue, MaxValue);
Assert.IsBetween(value.x7, MinValue, MaxValue);

            intern = (uint)((maxmath.andnot((int)intern,      maxmath.bitmask32(8 * BitsPerNumber,   index * BitsPerNumber))
                             |
                             maxmath.csum(maxmath.shl((int)maxmath.bitmask32(BitsPerNumber) & value,      BitsPerNumber * (index + new int8(0, 1, 2, 3, 4, 5, 6, 7))))));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetAll(int index, int numNumbers, int value)
        {
Assert.IsBetween(value, Int2.MinValue, Int2.MaxValue);
Assert.IsValidSubarray(index, numNumbers, Length);

            if (Constant.IsConstantExpression(value))
            {
                if (Constant.IsConstantExpression(index) && Constant.IsConstantExpression(numNumbers) && Constant.IsConstantExpression(index) && index + numNumbers == Length && value == 0)
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
                    uint mask = (uint)maxmath.bitmask32(numNumbers * BitsPerNumber, index * BitsPerNumber);
                    uint newValues = new Int2x16(value).intern & mask;
                    uint oldValues = maxmath.andnot(intern, mask);

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
        public readonly bool Equals(Int2x16 other)
        {
            return this.intern == other.intern;
        }

        public override readonly bool Equals(object obj)
        {
            return Equals((Int2x16)obj);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
            return (int)intern;
        }


        public override string ToString()
        {
            return new Enumerator<int>(this).ToString();
        }


        public IEnumerator<int> GetEnumerator()
        {
            return new Enumerator<int>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumerator<int>(this);
        }
    }
}