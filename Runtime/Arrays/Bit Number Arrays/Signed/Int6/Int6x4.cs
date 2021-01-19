﻿using DevTools;
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
    unsafe public struct Int6x4 : IBitNumberArray<int>, IEquatable<Int6x4>
    {
        internal Int24 intern;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int6x4(int x, int y, int z, int w) : this(new int4(x, y, z, w))
        { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int6x4(int xyzw)
        {
Assert.IsBetween(xyzw, Int6.MinValue, Int6.MaxValue);

            xyzw &= (int)maxmath.bitmask32(new Int6x4().BitsPerNumber);

            intern = (Int24)((xyzw
                            |
                            (xyzw << new Int6x4().BitsPerNumber))
                            |
                            ((xyzw << (2 * new Int6x4().BitsPerNumber))
                            |
                            (xyzw << (3 * new Int6x4().BitsPerNumber))));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int6x4(int4 xyzw)
        {
Assert.IsBetween(xyzw.x, Int6.MinValue, Int6.MaxValue);
Assert.IsBetween(xyzw.y, Int6.MinValue, Int6.MaxValue);
Assert.IsBetween(xyzw.z, Int6.MinValue, Int6.MaxValue);
Assert.IsBetween(xyzw.w, Int6.MinValue, Int6.MaxValue);

            int4 mask = (int)maxmath.bitmask32(new Int6x4().BitsPerNumber);

            intern = (Int24)math.csum(maxmath.shl(mask & xyzw, new Int6x4().BitsPerNumber * new int4(0, 1, 2, 3)));
        }


        public readonly int MinValue => Int6.MinValue;
        public readonly int MaxValue => Int6.MaxValue;
        public readonly int Length => 4;
        public readonly int BitsPerNumber => 6;


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
        public int z
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[2];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[2] = value;
        }
        public int w
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[3];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[3] = value;
        }

        public int4 xyzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                Int24 x = intern;

                // manual maxmath.signextend, saving 1 shift
                int4 temp = maxmath.shl((int4)(*(int*)&x), 32 - (BitsPerNumber * new int4(1, 2, 3, 4)));

                return temp >> (32 - BitsPerNumber);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                this = new Int6x4(value);
            }
        }
    
    
        public int this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(Int6.MinValue, Int6.MaxValue)]
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
        public readonly bool Equals(Int6x4 other)
        {
            return this.intern == other.intern;
        }

        public override readonly bool Equals(object obj)
        {
            return Equals((Int6x4)obj);
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