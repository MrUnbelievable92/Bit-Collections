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
        internal UInt24 intern;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int12x2(int xy)
        {
Assert.IsBetween(xy, Int12.MinValue, Int12.MaxValue);

            xy &= (int)maxmath.bitmask32(new Int12x2().BitsPerNumber);

            intern = (UInt24)((xy << new Int12x2().BitsPerNumber) | xy);
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

            intern = (UInt24)math.csum(maxmath.shl(mask & xy, new Int12x2().BitsPerNumber * new int2(0, 1)));
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
                // manual maxmath.signextend, saving 1 shift
                int2 temp = maxmath.shl((int2)(int)intern, 32 - (BitsPerNumber * new int2(1, 2)));

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

                if (Unity.Burst.Intrinsics.X86.Bmi1.IsBmi1Supported)
                {
                    return maxmath.signextend((int)maxmath.bits_extract(intern, index * BitsPerNumber, BitsPerNumber), BitsPerNumber);
                }
                else
                {
                    // manual sign extend => 1 bitshift less; same if 'index' is not a compile time constant
                    return ((int)intern << (32 - ((1 + index) * BitsPerNumber))) >> (32 - BitsPerNumber);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsBetween(value, MinValue, MaxValue);
Assert.IsWithinArrayBounds(index, Length);

                if (Constant.IsConstantExpression(index) && Constant.IsConstantExpression(value) && value == 0 && index == Length - 1)
                {
                    intern = (UInt24)maxmath.bits_zerohigh(intern, (Length - 1) * BitsPerNumber);    
                }
                else
                {
                    int shiftValue = index * BitsPerNumber;
                    int newValue = (value & (int)maxmath.bitmask32(BitsPerNumber)) << shiftValue;
                    int mask = math.rol(~(int)maxmath.bitmask32(BitsPerNumber), shiftValue);

                    intern = (UInt24)(((int)intern & mask) | newValue);
                }
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetAll(int index, int numNumbers, int value)
        {
Assert.IsBetween(value, Int12.MinValue, Int12.MaxValue);
Assert.IsValidSubarray(index, numNumbers, Length);

            if (Constant.IsConstantExpression(value))
            {
                if (Constant.IsConstantExpression(index) && Constant.IsConstantExpression(numNumbers) && Constant.IsConstantExpression(index) && index + numNumbers == Length && value == 0)
                {
                    if (index == 0)
                    {
                        intern = 0u;
                    }
                    else
                    {
                        intern = (UInt24)maxmath.bits_zerohigh(intern, index * BitsPerNumber);
                    }
                }
                else
                {
                    uint mask = (uint)maxmath.bitmask32(numNumbers * BitsPerNumber, index * BitsPerNumber);
                    uint newValues = new Int12x2(value).intern & mask;
                    uint oldValues = maxmath.andnot(intern, mask);

                    intern = (UInt24)(newValues | oldValues);
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