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
    unsafe public struct Int2x28 : IBitNumberArray<int>, IEquatable<Int2x28>
    {
        internal Int56 intern;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x28(int x0, int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10, int x11, int x12, int x13, int x14, int x15, int x16, int x17, int x18, int x19, int x20, int x21, int x22, int x23, int x24, int x25, int x26, int x27) : this(new int8(x0, x1, x2, x3, x4, x5, x6, x7), new int8(x8, x9, x10, x11, x12, x13, x14, x15), new int8(x16, x17, x18, x19, x20, x21, x22, x23), new int4(x24, x25, x26, x27))
        { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x28(int x0_27)
        {
            int8 vector = x0_27;

            this = new Int2x28(vector, vector, vector, vector.v4_0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x28(int8 x0_7, int8 x8_15, int8 x16_23, int4 x24_27)
        {
Assert.IsBetween(x0_7.x0,   Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x0_7.x1,   Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x0_7.x2,   Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x0_7.x3,   Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x0_7.x4,   Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x0_7.x5,   Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x0_7.x6,   Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x0_7.x7,   Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x8_15.x0,  Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x8_15.x1,  Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x8_15.x2,  Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x8_15.x3,  Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x8_15.x4,  Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x8_15.x5,  Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x8_15.x6,  Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x8_15.x7,  Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x16_23.x0, Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x16_23.x1, Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x16_23.x2, Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x16_23.x3, Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x16_23.x4, Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x16_23.x5, Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x16_23.x6, Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x16_23.x7, Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x24_27.x,  Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x24_27.y,  Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x24_27.z,  Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x24_27.w,  Int2.MinValue, Int2.MaxValue);

            int8 mask = (int)maxmath.bitmask32(new Int2x28().BitsPerNumber);

            intern = (Int56)((ulong)(uint)maxmath.csum(maxmath.shl(mask & x0_7, new Int2x28().BitsPerNumber * new int8(0, 1, 2, 3, 4, 5, 6, 7))
                                                       |
                                                       maxmath.shl(mask & x8_15, new Int2x28().BitsPerNumber * new int8(8, 9, 10, 11, 12, 13, 14, 15)))
                             |
                             ((ulong)(uint)maxmath.csum(maxmath.shl(mask & x16_23, new Int2x28().BitsPerNumber * new int8(0, 1, 2, 3, 4, 5, 6, 7))
                                                        |
                                                        maxmath.shl(mask & new int8(x24_27, default(int4)), new Int2x28().BitsPerNumber * new int8(8, 9, 10, 11, 12, 13, 14, 15))) << (new Int2x28().BitsPerNumber * 16)));
        }


        public readonly int MinValue => Int2.MinValue;
        public readonly int MaxValue => Int2.MaxValue;
        public readonly int BitsPerNumber => 2;
        public readonly int Length => 28;


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
        public int x16
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[16];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[16] = value;
        }
        public int x17
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[17];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[17] = value;
        }
        public int x18
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[18];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[18] = value;
        }
        public int x19
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[19];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[19] = value;
        }
        public int x20
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[20];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[20] = value;
        }
        public int x21
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[21];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[21] = value;
        }
        public int x22
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[22];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[22] = value;
        }
        public int x23
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[23];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[23] = value;
        }
        public int x24
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[24];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[24] = value;
        }
        public int x25
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[25];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[25] = value;
        }
        public int x26
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[26];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[26] = value;
        }
        public int x27
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[27];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[27] = value;
        }


        public int this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(Int2.MinValue, Int2.MaxValue)]
            readonly get
            {
Assert.IsWithinArrayBounds(index, Length);

                Int56 x = intern;

                // manual sign extend => 1 bitshift less; same if 'index' is not a compile time constant
                return (int)(((*(long*)&x)<< (64 - ((1 + index) * BitsPerNumber))) >> (64 - BitsPerNumber));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsBetween(value, MinValue, MaxValue);
Assert.IsWithinArrayBounds(index, Length);

                Int56 x = intern;

                int shiftValue = index * BitsPerNumber;
                long newValue = (long)(value & maxmath.bitmask64(BitsPerNumber)) << shiftValue;
                long mask = math.rol(~maxmath.bitmask64(BitsPerNumber), shiftValue);

                intern = (Int56)(((*(long*)&x) & mask) | newValue);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long4 GetSubArray(int index)
        {
Assert.IsValidSubarray(index, 4, Length);

            Int56 x = intern;

            // manual sign extend => 1 bitshift less; same if 'index' is not a compile time constant
            long4 temp = maxmath.shl((long4)(*(long*)&x), (long4)(64 - (BitsPerNumber * (index + new int4(1, 2, 3, 4)))));

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

            Int56 x = intern;

            intern = (Int56)((long)maxmath.andnot(*(ulong*)&x, (ulong)maxmath.bitmask64(4 * BitsPerNumber, index * BitsPerNumber))
                                 |
                                 maxmath.csum(maxmath.shl(maxmath.bitmask64(BitsPerNumber) & value, (long4)(BitsPerNumber * (index + new int4(0, 1, 2, 3))))));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Int2x28 other)
        {
            return this.intern == other.intern;
        }

        public override readonly bool Equals(object obj)
        {
            return Equals((Int2x28)obj);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
            return intern.GetHashCode();
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