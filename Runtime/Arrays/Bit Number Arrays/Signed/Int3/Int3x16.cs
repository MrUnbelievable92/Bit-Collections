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
    unsafe public struct Int3x16 : IBitNumberArray<int>, IEquatable<Int3x16>
    {
        internal Int48 intern;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int3x16(int x0, int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10, int x11, int x12, int x13, int x14, int x15) : this(new int8(x0, x1, x2, x3, x4, x5, x6, x7), new int8(x8, x9, x10, x11, x12, x13, x14, x15))
        { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int3x16(int x0_15)
        {
            int8 temp = x0_15;

            this = new Int3x16(temp, temp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int3x16(int8 x0_7, int8 x8_15)
        {
Assert.IsBetween(x0_7.x0,  Int3.MinValue, Int3.MaxValue);
Assert.IsBetween(x0_7.x1,  Int3.MinValue, Int3.MaxValue);
Assert.IsBetween(x0_7.x2,  Int3.MinValue, Int3.MaxValue);
Assert.IsBetween(x0_7.x3,  Int3.MinValue, Int3.MaxValue);
Assert.IsBetween(x0_7.x4,  Int3.MinValue, Int3.MaxValue);
Assert.IsBetween(x0_7.x5,  Int3.MinValue, Int3.MaxValue);
Assert.IsBetween(x0_7.x6,  Int3.MinValue, Int3.MaxValue);
Assert.IsBetween(x0_7.x7,  Int3.MinValue, Int3.MaxValue);
Assert.IsBetween(x8_15.x0, Int3.MinValue, Int3.MaxValue);
Assert.IsBetween(x8_15.x1, Int3.MinValue, Int3.MaxValue);
Assert.IsBetween(x8_15.x2, Int3.MinValue, Int3.MaxValue);
Assert.IsBetween(x8_15.x3, Int3.MinValue, Int3.MaxValue);
Assert.IsBetween(x8_15.x4, Int3.MinValue, Int3.MaxValue);
Assert.IsBetween(x8_15.x5, Int3.MinValue, Int3.MaxValue);
Assert.IsBetween(x8_15.x6, Int3.MinValue, Int3.MaxValue);
Assert.IsBetween(x8_15.x7, Int3.MinValue, Int3.MaxValue);

            int8 mask = (int)maxmath.bitmask32(new Int3x16().BitsPerNumber);
                
            intern = (Int48)((ulong)(uint)maxmath.csum(maxmath.shl(mask & x0_7, new Int3x16().BitsPerNumber * new int8(0, 1, 2, 3, 4, 5, 6, 7)))
                             |
                             ((ulong)(uint)maxmath.csum(maxmath.shl(mask & x8_15, new Int3x16().BitsPerNumber * new int8(0, 1, 2, 3, 4, 5, 6, 7))) << (8 * new Int3x16().BitsPerNumber)));
        }


        public readonly int MinValue => Int3.MinValue;
        public readonly int MaxValue => Int3.MaxValue;
        public readonly int Length => 16;
        public readonly int BitsPerNumber => 3;


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
            [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(Int3.MinValue, Int3.MaxValue)]
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

            intern = (Int48)((long)maxmath.andnot(*(ulong*)&x, (ulong)maxmath.bitmask64(4 * BitsPerNumber, index * BitsPerNumber))
                                 |
                                 maxmath.csum(maxmath.shl(maxmath.bitmask64(BitsPerNumber) & value, (long4)(BitsPerNumber * (index + new int4(0, 1, 2, 3))))));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Int3x16 other)
        {
            return this.intern == other.intern;
        }

        public override readonly bool Equals(object obj)
        {
            return Equals((Int3x16)obj);
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