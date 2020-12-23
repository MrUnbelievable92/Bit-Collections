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
    unsafe public struct Int4x2 : IBitNumberArray<int>, IEquatable<Int4x2>
    {
        internal sbyte intern;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x2(int xy)
        {
Assert.IsBetween(xy, Int4.MinValue, Int4.MaxValue);

            xy &= (int)maxmath.bitmask32(new Int4x2().BitsPerNumber);

            intern = (sbyte)((xy << new Int4x2().BitsPerNumber) | xy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x2(int x, int y) : this(new int2(x, y))
        { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x2(int2 xy)
        {
Assert.IsBetween(xy.x, Int4.MinValue, Int4.MaxValue);
Assert.IsBetween(xy.y, Int4.MinValue, Int4.MaxValue);

            int2 mask = (int)maxmath.bitmask32(new Int4x2().BitsPerNumber);

            intern = (sbyte)math.csum(maxmath.shl(mask & xy, new Int4x2().BitsPerNumber * new int2(0, 1)));
        }


        public readonly int MinValue => Int4.MinValue;
        public readonly int MaxValue => Int4.MaxValue;
        public readonly int BitsPerNumber => 4;
        public readonly int Length => 2;


        public int x
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[0];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[0] = value;
        }
        public int y
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[1];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[1] = value;
        }

        public int2 xy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                // manual maxmath.signextend, saving 1 shift
                int2 temp = maxmath.shl((int2)intern, 32 - (BitsPerNumber * new int2(1, 2)));

                return temp >> (32 - BitsPerNumber);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                this = new Int4x2(value);
            }
        }


        public int this[[AssumeRange(0, 1)] int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(Int4.MinValue, Int4.MaxValue)]
            readonly get
            {
Assert.IsWithinArrayBounds(index, Length);

                // manual sign extend => 1 bitshift less; same if 'index' is not a compile time constant
                return (intern << (32 - ((1 + index) * BitsPerNumber))) >> (32 - BitsPerNumber);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]  [param: AssumeRange(Int4.MinValue, Int4.MaxValue)]
            set
            {
Assert.IsBetween(value, MinValue, MaxValue);
Assert.IsWithinArrayBounds(index, Length);

                int shiftValue = index * BitsPerNumber;
                int newValue = (value & (int)maxmath.bitmask32(BitsPerNumber)) << shiftValue;
                int mask = math.rol(~(int)maxmath.bitmask32(BitsPerNumber), shiftValue);

                intern = (sbyte)((intern & mask) | newValue);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Int4x2 other)
        {
            return this.intern == other.intern;
        }

        public override readonly bool Equals(object obj)
        {
            return Equals((Int4x2)obj);
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