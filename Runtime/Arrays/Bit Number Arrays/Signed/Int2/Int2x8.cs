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
    unsafe public struct Int2x8 : IBitNumberArray<int>, IEquatable<Int2x8>
    {
        internal short intern;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x8(int x0, int x1, int x2, int x3, int x4, int x5, int x6, int x7) : this(new int8(x0, x1, x2, x3, x4, x5, x6, x7))
        { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x8(int x0_7) : this(new int8(x0_7))
        { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x8(int8 x0_7)
        {
Assert.IsBetween(x0_7.x0, Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x0_7.x1, Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x0_7.x2, Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x0_7.x3, Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x0_7.x4, Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x0_7.x5, Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x0_7.x6, Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(x0_7.x7, Int2.MinValue, Int2.MaxValue);

            int8 mask = (int)maxmath.bitmask32(new Int2x8().BitsPerNumber);

            intern = (short)maxmath.csum(maxmath.shl(mask & x0_7, new Int2x8().BitsPerNumber * new int8(0, 1, 2, 3, 4, 5, 6, 7)));
        }


        public readonly int MinValue => Int2.MinValue;
        public readonly int MaxValue => Int2.MaxValue;
        public readonly int BitsPerNumber => 2;
        public readonly int Length => 8;


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

        public int8 x0_7
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                // manual maxmath.signextend, saving 1 shift
                int8 temp = maxmath.shl((int8)intern, 32 - (BitsPerNumber * new int8(1, 2, 3, 4, 5, 6, 7, 8)));

                return temp >> (32 - BitsPerNumber);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                this = new Int2x8(value);
            }
        }


        public int this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(Int2.MinValue, Int2.MaxValue)]
            readonly get
            {
Assert.IsWithinArrayBounds(index, Length);

                // manual sign extend => 1 bitshift less; same if 'index' is not a compile time constant
                return (intern << (32 - ((1 + index) * BitsPerNumber))) >> (32 - BitsPerNumber);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsBetween(value, MinValue, MaxValue);
Assert.IsWithinArrayBounds(index, Length);

                int shiftValue = index * BitsPerNumber;
                int newValue = (value & (int)maxmath.bitmask32(BitsPerNumber)) << shiftValue;
                int mask = math.rol(~(int)maxmath.bitmask32(BitsPerNumber), shiftValue);

                intern = (short)((intern & mask) | newValue);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Int2x8 other)
        {
            return this.intern == other.intern;
        }

        public override readonly bool Equals(object obj)
        {
            return Equals((Int2x8)obj);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
            return intern;
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