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
    unsafe public struct Int6x8 : IBitNumberArray<int>, IEquatable<Int6x8>
    {
        internal Int48 intern;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int6x8(int x0, int x1, int x2, int x3, int x4, int x5, int x6, int x7) : this(new long4(x0, x1, x2, x3), new long4(x4, x5, x6, x7))
        { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int6x8(int x0_7)
        {
            long4 vector = new long4(x0_7);

            this = new Int6x8(vector, vector);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int6x8(long4 x0_3, long4 x4_7)
        {
Assert.IsBetween(x0_3.x, Int6.MinValue, Int6.MaxValue);
Assert.IsBetween(x0_3.y, Int6.MinValue, Int6.MaxValue);
Assert.IsBetween(x0_3.z, Int6.MinValue, Int6.MaxValue);
Assert.IsBetween(x0_3.w, Int6.MinValue, Int6.MaxValue);
Assert.IsBetween(x4_7.x, Int6.MinValue, Int6.MaxValue);
Assert.IsBetween(x4_7.y, Int6.MinValue, Int6.MaxValue);
Assert.IsBetween(x4_7.z, Int6.MinValue, Int6.MaxValue);
Assert.IsBetween(x4_7.w, Int6.MinValue, Int6.MaxValue);

            long4 mask = (long)maxmath.bitmask64(new Int6x8().BitsPerNumber);

            intern = (Int48)(maxmath.csum(maxmath.shl(mask & x0_3, (long)new Int6x8().BitsPerNumber * new long4(0L, 1L, 2L, 3L)))
                             |
                             maxmath.csum(maxmath.shl(mask & x4_7, (long)new Int6x8().BitsPerNumber * new long4(4L, 5L, 6L, 7L))));
        }


        public readonly int MinValue => Int6.MinValue;
        public readonly int MaxValue => Int6.MaxValue;
        public readonly int Length => 8;
        public readonly int BitsPerNumber => 6;


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


        public int this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(Int6.MinValue, Int6.MaxValue)]
            readonly get
            {
Assert.IsWithinArrayBounds(index, Length);

                Int48 x = intern;

                // manual sign extend => 1 bitshift less; same if 'index' is not a compile time constant
                return (int)((*(long*)&x << (64 - ((1 + index) * BitsPerNumber))) >> (64 - BitsPerNumber));
            }
    
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsBetween(value, MinValue, MaxValue);
Assert.IsWithinArrayBounds(index, Length);

                Int48 x = intern;

                int shiftValue = index * BitsPerNumber;
                long newValue = ((long)value & maxmath.bitmask64(BitsPerNumber)) << shiftValue;
                long mask = math.rol(~maxmath.bitmask64(BitsPerNumber), shiftValue);

                intern = (Int48)((*(long*)&x & mask) | newValue);
            }
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long4 GetSubArray(int index)
        {
Assert.IsValidSubarray(index, 4, Length);

            Int48 x = intern;

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

            Int48 x = intern;

            intern = (Int48)((long)maxmath.andnot(*(ulong*)&x,     (ulong)maxmath.bitmask64(4 * BitsPerNumber,   index * BitsPerNumber))
                             |
                             maxmath.csum(maxmath.shl(maxmath.bitmask64(BitsPerNumber) & value, (long4)(BitsPerNumber * (index + new int4(0, 1, 2, 3))))));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Int6x8 other)
        {
            return this.intern == other.intern;
        }

        public override readonly bool Equals(object obj)
        {
            return Equals((Int6x8)obj);
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