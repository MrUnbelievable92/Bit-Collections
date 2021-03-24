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
    unsafe public struct Int2x4 : IBitNumberArray<int>, IEquatable<Int2x4>
    {
        internal byte intern;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x4(int x, int y, int z, int w) : this(new int4(x, y, z, w))
        { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x4(int xyzw)
        {
Assert.IsBetween(xyzw, Int2.MinValue, Int2.MaxValue);

            xyzw &= (int)maxmath.bitmask32(new Int2x4().BitsPerNumber);

            intern = (byte)((xyzw
                           |
                           (xyzw << new Int2x4().BitsPerNumber))
                           |
                           ((xyzw << (2 * new Int2x4().BitsPerNumber))
                           |
                           (xyzw << (3 * new Int2x4().BitsPerNumber))));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x4(int4 xyzw)
        {
Assert.IsBetween(xyzw.x, Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(xyzw.y, Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(xyzw.z, Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(xyzw.w, Int2.MinValue, Int2.MaxValue);

            int4 mask = (int)maxmath.bitmask32(new Int2x4().BitsPerNumber);

            intern = (byte)math.csum(maxmath.shl(mask & xyzw, new Int2x4().BitsPerNumber * new int4(0, 1, 2, 3)));
        }


        public readonly int MinValue => Int2.MinValue;
        public readonly int MaxValue => Int2.MaxValue;
        public readonly int BitsPerNumber => 2;
        public readonly int Length => 4;


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
                // manual maxmath.signextend, saving 1 shift
                int4 temp = maxmath.shl((int)intern, 32 - (BitsPerNumber * new int4(1, 2, 3, 4)));

                return temp >> (32 - BitsPerNumber);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                this = new Int2x4(value);
            }
        }


        public int this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(Int2.MinValue, Int2.MaxValue)]
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
                    return (intern << (32 - ((1 + index) * BitsPerNumber))) >> (32 - BitsPerNumber);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsBetween(value, MinValue, MaxValue);
Assert.IsWithinArrayBounds(index, Length);

                if (Constant.IsConstantExpression(index) && Constant.IsConstantExpression(value) && value == 0 && index == Length - 1)
                {
                    intern = (byte)maxmath.bits_zerohigh(intern, (Length - 1) * BitsPerNumber);
                }
                else
                {
                    int shiftValue = index * BitsPerNumber;
                    int newValue = (value & (int)maxmath.bitmask32(BitsPerNumber)) << shiftValue;
                    int mask = math.rol(~(int)maxmath.bitmask32(BitsPerNumber), shiftValue);

                    intern = (byte)((intern & mask) | newValue);
                }
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetAll(int index, int numNumbers, int value)
        {
Assert.IsBetween(value, Int2.MinValue, Int2.MaxValue);
Assert.IsValidSubarray(index, numNumbers, Length);

            if (Constant.IsConstantExpression(value))
            {
                if (Constant.IsConstantExpression(index) && Constant.IsConstantExpression(numNumbers) && Constant.IsConstantExpression(index) && index + numNumbers == Length && value == 0)
                {
                    if (index == 0)
                    {
                        intern = 0;
                    }
                    else
                    {
                        intern = (byte)maxmath.bits_zerohigh(intern, index * BitsPerNumber);
                    }
                }
                else
                {
                    uint mask = (uint)maxmath.bitmask32(numNumbers * BitsPerNumber, index * BitsPerNumber);
                    uint newValues = new Int2x4(value).intern & mask;
                    uint oldValues = maxmath.andnot(intern, mask);

                    intern = (byte)(newValues | oldValues);
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
        public readonly bool Equals(Int2x4 other)
        {
            return this.intern == other.intern;
        }

        public override readonly bool Equals(object obj)
        {
            return Equals((Int2x4)obj);
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