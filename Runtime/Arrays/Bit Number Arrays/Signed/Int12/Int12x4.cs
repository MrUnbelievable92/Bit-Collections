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
    unsafe public struct Int12x4 : IBitNumberArray<int>, IEquatable<Int12x4>
    {
        internal Int48 intern;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int12x4(long x, long y, long z, long w) : this(new long4(x, y, z, w))
        { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int12x4(long xyzw)
        {
Assert.IsBetween(xyzw, Int12.MinValue, Int12.MaxValue);

            xyzw &= (long)maxmath.bitmask64(new Int12x4().BitsPerNumber);

            intern = (Int48)((xyzw
                             |
                             (xyzw << new Int12x4().BitsPerNumber))
                             |
                             ((xyzw << (2 * new Int12x4().BitsPerNumber))
                             |
                             (xyzw << (3 * new Int12x4().BitsPerNumber))));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int12x4(long4 xyzw)
        {
Assert.IsBetween(xyzw.x, Int12.MinValue, Int12.MaxValue);
Assert.IsBetween(xyzw.y, Int12.MinValue, Int12.MaxValue);
Assert.IsBetween(xyzw.z, Int12.MinValue, Int12.MaxValue);
Assert.IsBetween(xyzw.w, Int12.MinValue, Int12.MaxValue);

            long4 mask = (long)maxmath.bitmask64(new Int12x4().BitsPerNumber);

            intern = (Int48)maxmath.csum(maxmath.shl(mask & xyzw, (long)new Int12x4().BitsPerNumber * new long4(0L, 1L, 2L, 3L)));
        }


        public readonly int MinValue => Int12.MinValue;
        public readonly int MaxValue => Int12.MaxValue;
        public readonly int Length => 4;
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

        public long4 xyzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                fixed (void* ptr = &this)
                {
                    // manual maxmath.signextend, saving 1 shift
                    long4 temp = maxmath.shl((long4)(*(long*)ptr), 64 - (BitsPerNumber * new int4(1, 2, 3, 4)));

                    return temp >> (64 - BitsPerNumber);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                this = new Int12x4(value);
            }
        }
    
    
        public int this[[AssumeRange(0, 3)] int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(Int12.MinValue, Int12.MaxValue)]
            readonly get
            {
Assert.IsWithinArrayBounds(index, Length);

                fixed (void* ptr = &this)
                {
                    // manual sign extend => 1 bitshift less; same if 'index' is not a compile time constant
                    return (int)((*(long*)ptr << (64 - ((1 + index) * BitsPerNumber))) >> (64 - BitsPerNumber));
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]  [param: AssumeRange(Int12.MinValue, Int12.MaxValue)]
            set
            {
Assert.IsBetween(value, MinValue, MaxValue);
Assert.IsWithinArrayBounds(index, Length);

                fixed (void* ptr = &this)
                {
                    int shiftValue = index * BitsPerNumber;
                    long newValue = ((long)value & (long)maxmath.bitmask64(BitsPerNumber)) << shiftValue;
                    long mask = math.rol(~(long)maxmath.bitmask64(BitsPerNumber), shiftValue);

                    intern = (Int48)((*(long*)ptr & mask) | newValue);
                }
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Int12x4 other)
        {
            return this.intern == other.intern;
        }

        public override readonly bool Equals(object obj)
        {
            return Equals((Int12x4)obj);
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