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
    unsafe public struct Int4x10 : IBitNumberArray<int>, IEquatable<Int4x10>
    {
        internal Int40 intern;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x10(int x0, int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9) : this(new int8(x0, x1, x2, x3, x4, x5, x6, x7), new int2(x8, x9))
        { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x10(int x0_9)
        {
            int8 vector = x0_9;

            this = new Int4x10(vector, vector.v2_0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x10(int8 x0_7, int2 x8_9)
        {
Assert.IsBetween(x0_7.x0, Int4.MinValue, Int4.MaxValue);
Assert.IsBetween(x0_7.x1, Int4.MinValue, Int4.MaxValue);
Assert.IsBetween(x0_7.x2, Int4.MinValue, Int4.MaxValue);
Assert.IsBetween(x0_7.x3, Int4.MinValue, Int4.MaxValue);
Assert.IsBetween(x0_7.x4, Int4.MinValue, Int4.MaxValue);
Assert.IsBetween(x0_7.x5, Int4.MinValue, Int4.MaxValue);
Assert.IsBetween(x0_7.x6, Int4.MinValue, Int4.MaxValue);
Assert.IsBetween(x0_7.x7, Int4.MinValue, Int4.MaxValue);
Assert.IsBetween(x8_9.x,  Int4.MinValue, Int4.MaxValue);
Assert.IsBetween(x8_9.y,  Int4.MinValue, Int4.MaxValue);

            int8 mask = (int)maxmath.bitmask32(new Int4x10().BitsPerNumber);

            intern = (Int40)((ulong)(uint)maxmath.csum(maxmath.shl(mask & x0_7, new Int4x10().BitsPerNumber * new int8(0, 1, 2, 3, 4, 5, 6, 7)))
                             |
                             ((ulong)(uint)maxmath.csum(maxmath.shl(mask.v2_0 & x8_9, new Int4x10().BitsPerNumber * new int2(0, 1))) << (new Int4x10().BitsPerNumber * 8)));
        }


        public readonly int MinValue => Int4.MinValue;
        public readonly int MaxValue => Int4.MaxValue;
        public readonly int BitsPerNumber => 4;
        public readonly int Length => 10;


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


        public int this[[AssumeRange(0, 9)] int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(Int4.MinValue, Int4.MaxValue)]
            readonly get
            {
Assert.IsWithinArrayBounds(index, Length);

                fixed (void* ptr = &this)
                {
                    // manual sign extend => 1 bitshift less; same if 'index' is not a compile time constant
                    return (int)((*(long*)ptr << (64 - ((1 + index) * BitsPerNumber))) >> (64 - BitsPerNumber));
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]  [param: AssumeRange(Int4.MinValue, Int4.MaxValue)]
            set
            {
Assert.IsBetween(value, MinValue, MaxValue);
Assert.IsWithinArrayBounds(index, Length);

                fixed (void* ptr = &this)
                {
                    int shiftValue = index * BitsPerNumber;
                    long newValue = ((long)value & (long)maxmath.bitmask64(BitsPerNumber)) << shiftValue;
                    long mask = math.rol(~(long)maxmath.bitmask64(BitsPerNumber), shiftValue);

                    intern = (Int40)(((*(long*)ptr) & mask) | newValue);
                }
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long4 GetSubArray([AssumeRange(0, 6)] int index)
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
        public void SetSubArray([AssumeRange(0, 6)] int index, long4 value)
        {
Assert.IsValidSubarray(index, 4, Length);
Assert.IsBetween(value.x, MinValue, MaxValue);
Assert.IsBetween(value.y, MinValue, MaxValue);
Assert.IsBetween(value.z, MinValue, MaxValue);
Assert.IsBetween(value.w, MinValue, MaxValue);

            fixed (void* ptr = &this)
            {
                intern = (Int40)((long)maxmath.andnot(*(ulong*)ptr, (ulong)maxmath.bitmask64(4 * BitsPerNumber,   index * BitsPerNumber))
                                 |
                                 maxmath.csum(maxmath.shl((int)maxmath.bitmask32(BitsPerNumber) & value, (long4)(BitsPerNumber * (index + new int4(0, 1, 2, 3))))));
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Int4x10 other)
        {
            return this.intern == other.intern;
        }

        public override readonly bool Equals(object obj)
        {
            return Equals((Int4x10)obj);
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