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
    unsafe public struct Int20x2 : IBitNumberArray<int>, IEquatable<Int20x2>
    {
        internal Int40 intern;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int20x2(long xy)
        {
Assert.IsBetween(xy, Int20.MinValue, Int20.MaxValue);

            xy &= (long)maxmath.bitmask64(new Int20x2().BitsPerNumber);

            intern = (Int40)((xy << new Int20x2().BitsPerNumber) | xy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int20x2(long x, long y) : this(new long2(x, y))
        { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int20x2(long2 xy)
        { 
Assert.IsBetween(xy.x, Int20.MinValue, Int20.MaxValue);
Assert.IsBetween(xy.y, Int20.MinValue, Int20.MaxValue);

            long2 mask = (long)maxmath.bitmask64(new Int20x2().BitsPerNumber);

            intern = (Int40)maxmath.csum(maxmath.shl(mask & xy, (long)new Int20x2().BitsPerNumber * new long2(0L, 1L)));
        }


        public readonly int MinValue => Int20.MinValue;
        public readonly int MaxValue => Int20.MaxValue;
        public readonly int Length => 2;
        public readonly int BitsPerNumber => 20;


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

        public long2 xy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                Int40 x = intern;

                // manual maxmath.signextend, saving 1 shift
                long2 temp = maxmath.shl((long2)(*(long*)&x), 64 - (BitsPerNumber * new long2(1, 2)));

                return temp >> (64 - BitsPerNumber);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                this = new Int20x2(value);
            }
        }
    
    
        public int this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(Int20.MinValue, Int20.MaxValue)]
            readonly get
            {
Assert.IsWithinArrayBounds(index, Length);

                Int40 x = intern;

                // manual sign extend => 1 bitshift less; same if 'index' is not a compile time constant
                return (int)((*(long*)&x << (64 - ((1 + index) * BitsPerNumber))) >> (64 - BitsPerNumber));
            }
    
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsBetween(value, MinValue, MaxValue);
Assert.IsWithinArrayBounds(index, Length);

                Int40 x = intern;

                int shiftValue = index * BitsPerNumber;
                long newValue = ((long)value & maxmath.bitmask64(BitsPerNumber)) << shiftValue;
                long mask = math.rol(~maxmath.bitmask64(BitsPerNumber), shiftValue);

                intern = (Int40)((*(long*)&x & mask) | newValue);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Int20x2 other)
        {
            return this.intern == other.intern;
        }

        public override readonly bool Equals(object obj)
        {
            return Equals((Int20x2)obj);
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