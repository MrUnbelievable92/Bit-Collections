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
    unsafe public struct Int10x4 : IBitNumberArray<int>, IEquatable<Int10x4>
    {
        internal UInt40 intern;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int10x4(long x, long y, long z, long w) : this(new long4(x, y, z, w))
        { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int10x4(long xyzw)
        {
Assert.IsBetween(xyzw, Int10.MinValue, Int10.MaxValue);

            xyzw &= (long)maxmath.bitmask64(new Int10x4().BitsPerNumber);

            intern = (UInt40)((xyzw
                              |
                              (xyzw << new Int10x4().BitsPerNumber))
                              |
                              ((xyzw << (2 * new Int10x4().BitsPerNumber))
                              |
                              (xyzw << (3 * new Int10x4().BitsPerNumber))));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int10x4(long4 xyzw)
        {
Assert.IsBetween(xyzw.x, Int10.MinValue, Int10.MaxValue);
Assert.IsBetween(xyzw.y, Int10.MinValue, Int10.MaxValue);
Assert.IsBetween(xyzw.z, Int10.MinValue, Int10.MaxValue);
Assert.IsBetween(xyzw.w, Int10.MinValue, Int10.MaxValue);

            long4 mask = (long)maxmath.bitmask64(new Int10x4().BitsPerNumber);

            intern = (UInt40)maxmath.csum(maxmath.shl(mask & xyzw, (long)new Int10x4().BitsPerNumber * new long4(0L, 1L, 2L, 3L)));
        }


        public readonly int MinValue => Int10.MinValue;
        public readonly int MaxValue => Int10.MaxValue;
        public readonly int Length => 4;
        public readonly int BitsPerNumber => 10;


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
                // manual maxmath.signextend, saving 1 shift
                long4 temp = maxmath.shl((long)intern, 64 - (BitsPerNumber * new int4(1, 2, 3, 4)));

                return temp >> (64 - BitsPerNumber);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                this = new Int10x4(value);
            }
        }


        public int this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(Int10.MinValue, Int10.MaxValue)]
            readonly get
            {
Assert.IsWithinArrayBounds(index, Length);

                if (Constant.IsConstantExpression(index) && index == Length - 1)
                {
                    return (int)(((long)(Int40)intern) >> (index * BitsPerNumber));
                }
                else
                {
                    // manual sign extend => 1 bitshift less; same if 'index' is not a compile time constant
                    return (int)(((long)intern << (64 - ((1 + index) * BitsPerNumber))) >> (64 - BitsPerNumber));
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsBetween(value, MinValue, MaxValue);
Assert.IsWithinArrayBounds(index, Length);

                if (Constant.IsConstantExpression(index) && Constant.IsConstantExpression(value) && value == 0 && index == Length - 1)
                {
                    intern = (UInt40)maxmath.bits_zerohigh(intern, (Length - 1) * BitsPerNumber);
                }
                else
                {
                    int shiftValue = index * BitsPerNumber;
                    long newValue = ((long)value & maxmath.bitmask64(BitsPerNumber)) << shiftValue;
                    long mask = math.rol(~maxmath.bitmask64(BitsPerNumber), shiftValue);

                    intern = (UInt40)(((long)intern & mask) | newValue);
                }
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetAll(int index, int numNumbers, int value)
        {
Assert.IsBetween(value, Int10.MinValue, Int10.MaxValue);
Assert.IsValidSubarray(index, numNumbers, Length);

            if (Constant.IsConstantExpression(value))
            {
                if (Constant.IsConstantExpression(index) && Constant.IsConstantExpression(numNumbers) && index + numNumbers == Length && value == 0)
                {
                    if (index == 0)
                    {
                        intern = 0u;
                    }
                    else
                    {
                        intern = (UInt40)maxmath.bits_zerohigh(intern, index * BitsPerNumber);
                    }
                }
                else
                {
                    ulong mask = (ulong)maxmath.bitmask64(numNumbers * BitsPerNumber, index * BitsPerNumber);
                    ulong newValues = new Int10x4(value).intern & mask;
                    ulong oldValues = maxmath.andnot(intern, mask);

                    intern = (UInt40)(newValues | oldValues);
                }
            }
            else
            {
                int lastIndex = index + numNumbers;

                while (index <= lastIndex)
                {
                    this[index] = value;
                    index++;
                }
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Int10x4 other)
        {
            return this.intern == other.intern;
        }
    
        public override readonly bool Equals(object obj)
        {
            return Equals((Int10x4)obj);
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
            return intern.GetHashCode();
        }
    
    
        public override string ToString()
        {
            return new ArrayEnumerator<int>(this).ToString();
        }
    
        public IEnumerator<int> GetEnumerator()
        {
            return new ArrayEnumerator<int>(this);
        }
    
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<int>(this);
        }
    }
}