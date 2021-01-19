using DevTools;
using MaxMath;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;
using Unity.Mathematics;

namespace BitCollections
{
    [Serializable]
    unsafe public struct Int12x2 : IBitNumberArray<int>, IEquatable<Int12x2>
    {
        internal Int24 intern;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int12x2(int xy)
        {
Assert.IsBetween(xy, Int12.MinValue, Int12.MaxValue);

            xy &= (int)maxmath.bitmask32(new Int12x2().BitsPerNumber);

            intern = (Int24)((xy << new Int12x2().BitsPerNumber) | xy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int12x2(int x, int y) : this(new int2(x, y))
        { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int12x2(int2 xy)
        { 
Assert.IsBetween(xy.x, Int12.MinValue, Int12.MaxValue);
Assert.IsBetween(xy.y, Int12.MinValue, Int12.MaxValue);

            int2 mask = (int)maxmath.bitmask32(new Int12x2().BitsPerNumber);

            intern = math.csum(maxmath.shl(mask & xy, new Int12x2().BitsPerNumber * new int2(0, 1)));
        }


        public readonly int MinValue => Int12.MinValue;
        public readonly int MaxValue => Int12.MaxValue;
        public readonly int Length => 2;
        public readonly int BitsPerNumber => 12;


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
                Int24 x = intern;

                // manual maxmath.signextend, saving 1 shift
                int2 temp = maxmath.shl((int2)(*(int*)&x), 32 - (BitsPerNumber * new int2(1, 2)));

                return temp >> (32 - BitsPerNumber);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                this = new Int12x2(value);
            }
        }
    
    
        public int this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(Int12.MinValue, Int12.MaxValue)]
            readonly get
            {
Assert.IsWithinArrayBounds(index, Length);

                Int24 x = intern;

                // manual sign extend => 1 bitshift less; same if 'index' is not a compile time constant
                return (*(int*)&x << (32 - ((1 + index) * BitsPerNumber))) >> (32 - BitsPerNumber);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsBetween(value, MinValue, MaxValue);
Assert.IsWithinArrayBounds(index, Length);

                Int24 x = intern;

                int shiftValue = index * BitsPerNumber;
                int newValue = (value & (int)maxmath.bitmask32(BitsPerNumber)) << shiftValue;
                int mask = math.rol(~(int)maxmath.bitmask32(BitsPerNumber), shiftValue);

                intern = (Int24)((*(int*)&x & mask) | newValue);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Int12x2 other)
        {
            return this.intern == other.intern;
        }
    
        public override readonly bool Equals(object obj)
        {
            return Equals((Int12x2)obj);
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