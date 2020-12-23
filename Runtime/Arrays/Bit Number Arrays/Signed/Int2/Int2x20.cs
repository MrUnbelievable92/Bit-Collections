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
    unsafe public struct Int2x20 : IBitNumberArray<int>, IEquatable<Int2x20>
    {
        internal Int40 intern;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x20(int x0, int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10, int x11, int x12, int x13, int x14, int x15, int x16, int x17, int x18, int x19) : this(new int8(x0, x1, x2, x3, x4, x5, x6, x7), new int8(x8, x9, x10, x11, x12, x13, x14, x15), new int4(x16, x17, x18, x19))
        { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x20(int x0_19)
        {
            int8 vector = x0_19;

            this = new Int2x20(vector, vector, vector.v4_0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x20(int8 x0_7, int8 x8_15, int4 x16_19)
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
Assert.IsBetween(x16_19.x, Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x16_19.y, Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x16_19.z, Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x16_19.w, Int2.MinValue, Int2.MaxValue);

            int8 mask = (int)maxmath.bitmask32(new Int2x20().BitsPerNumber);

            intern = (Int40)((ulong)(uint)maxmath.csum(maxmath.shl(mask & x0_7, new Int2x20().BitsPerNumber * new int8(0, 1, 2, 3, 4, 5, 6, 7))
                                                       |
                                                       maxmath.shl(mask & x8_15, new Int2x20().BitsPerNumber * new int8(8, 9, 10, 11, 12, 13, 14, 15)))
                             |
                             ((ulong)(uint)maxmath.csum(maxmath.shl(mask & new int8(x16_19, default(int4)), new Int2x20().BitsPerNumber * new int8(0, 1, 2, 3, 4, 5, 6, 7))) << (new Int2x20().BitsPerNumber * 16)));
        }


        public readonly int MinValue => Int2.MinValue;
        public readonly int MaxValue => Int2.MaxValue;
        public readonly int BitsPerNumber => 2;
        public readonly int Length => 20;


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


        public int this[[AssumeRange(0, 19)] int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(Int2.MinValue, Int2.MaxValue)]
            readonly get
            {
Assert.IsWithinArrayBounds(index, Length);

                fixed (void* ptr = &this)
                {
                    // manual sign extend => 1 bitshift less; same if 'index' is not a compile time constant
                    return (int)((*(long*)ptr << (64 - ((1 + index) * BitsPerNumber))) >> (64 - BitsPerNumber));
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]  [param: AssumeRange(Int2.MinValue, Int2.MaxValue)]
            set
            {
Assert.IsBetween(value, MinValue, MaxValue);
Assert.IsWithinArrayBounds(index, Length);

                fixed (void* ptr = &this)
                {
                    int shiftValue = index * BitsPerNumber;
                    long newValue = (long)(value & (long)maxmath.bitmask64(BitsPerNumber)) << shiftValue;
                    long mask = math.rol(~(long)maxmath.bitmask64(BitsPerNumber), shiftValue);

                    intern = (Int40)(((*(long*)ptr)& mask) | newValue);
                }
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long4 GetSubArray([AssumeRange(0, 16)] int index)
        {
Assert.IsValidSubarray(index, 4, Length);

            fixed (void* ptr = &this)
            {
                // manual sign extend => 1 bitshift less; same if 'index' is not a compile time constant
                long4 temp = maxmath.shl((long4)(*(long*)ptr), (long4)(64 - (BitsPerNumber * (index + new int4(1, 2, 3, 4)))));

                return temp >> (64 - BitsPerNumber);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetSubArray([AssumeRange(0, 16)] int index, long4 value)
        {
Assert.IsValidSubarray(index, 4, Length);
Assert.IsBetween(value.x, MinValue, MaxValue);
Assert.IsBetween(value.y, MinValue, MaxValue);
Assert.IsBetween(value.z, MinValue, MaxValue);
Assert.IsBetween(value.w, MinValue, MaxValue);

            fixed (void* ptr = &this)
            {
                intern = (Int40)(((long)maxmath.andnot(*(ulong*)ptr, (ulong)maxmath.bitmask64(4 * BitsPerNumber, index * BitsPerNumber))
                                  |
                                  maxmath.csum(maxmath.shl((long)maxmath.bitmask64(BitsPerNumber) & value,      (long4)(BitsPerNumber * (index + new int4(0, 1, 2, 3)))))));
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Int2x20 other)
        {
            return this.intern == other.intern;
        }

        public override readonly bool Equals(object obj)
        {
            return Equals((Int2x20)obj);
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