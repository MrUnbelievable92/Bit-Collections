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
    unsafe public struct UInt4x4 : IBitNumberArray<uint>, IEquatable<UInt4x4>
    {
        internal ushort intern;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x4(uint x, uint y, uint z, uint w)
        {
Assert.IsNotGreater(x, UInt4.MaxValue);
Assert.IsNotGreater(y, UInt4.MaxValue);
Assert.IsNotGreater(z, UInt4.MaxValue);
Assert.IsNotGreater(w, UInt4.MaxValue);

            intern = (ushort)((x
                              |
                              (y << new UInt4x4().BitsPerNumber))
                              |
                              ((z << (2 * new UInt4x4().BitsPerNumber))
                              |
                              (w << (3 * new UInt4x4().BitsPerNumber))));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x4(uint xyzw)
        {
Assert.IsNotGreater(xyzw, UInt4.MaxValue);

            intern = (ushort)((xyzw
                              |
                              (xyzw << new UInt4x4().BitsPerNumber))
                              |
                              ((xyzw << (2 * new UInt4x4().BitsPerNumber))
                              |
                              (xyzw << (3 * new UInt4x4().BitsPerNumber))));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x4(uint4 xyzw)
        {
Assert.IsNotGreater(xyzw.x, UInt4.MaxValue);
Assert.IsNotGreater(xyzw.y, UInt4.MaxValue);
Assert.IsNotGreater(xyzw.z, UInt4.MaxValue);
Assert.IsNotGreater(xyzw.w, UInt4.MaxValue);

            intern = (ushort)math.csum(maxmath.shl(xyzw, (uint)new UInt4x4().BitsPerNumber * new uint4(0u, 1u, 2u, 3u)));
        }


        public readonly uint MinValue => UInt4.MinValue;
        public readonly uint MaxValue => UInt4.MaxValue;
        public readonly int BitsPerNumber => 4;
        public readonly int Length => 4;


        public uint x
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[0];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[0] = value;
        }
        public uint y
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[1];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[1] = value;
        }
        public uint z
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[2];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[2] = value;
        }
        public uint w
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[3];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[3] = value;
        }

        public uint4 xyzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return MaxValue & maxmath.shrl(intern, (uint)BitsPerNumber * new uint4(0u, 1u, 2u, 3u));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                this = new UInt4x4(value);
            }
        }


        public uint this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange((ulong)UInt4.MinValue, (ulong)UInt4.MaxValue)]
            readonly get
            {
Assert.IsWithinArrayBounds(index, Length);

                if (Constant.IsConstantExpression(index))
                {
                    if (index == 0)
                    {
                        return intern & (uint)maxmath.bitmask32(BitsPerNumber);
                    }
                    else if (index == Length - 1)
                    {
                        return (uint)intern >> (index * BitsPerNumber);
                    }
                    else { }
                }
                else { }


                return (uint)maxmath.bits_extract(intern, index * BitsPerNumber, BitsPerNumber);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsNotGreater(value, UInt4.MaxValue);
Assert.IsWithinArrayBounds(index, Length);

                if (Constant.IsConstantExpression(index) && Constant.IsConstantExpression(value) && value == 0 && index == Length - 1)
                {
                    intern = (ushort)maxmath.bits_zerohigh(intern, (Length - 1) * BitsPerNumber);
                }
                else
                {
                    int shiftValue = index * BitsPerNumber;
                    uint newValue = value << shiftValue;
                    uint mask = math.rol(~MaxValue, shiftValue);

                    intern = (ushort)((intern & mask) | newValue);
                }
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetAll(int index, int numNumbers, uint value)
        {
Assert.IsNotGreater(value, UInt4.MaxValue);
Assert.IsValidSubarray(index, numNumbers, Length);

            if (Constant.IsConstantExpression(value))
            {
                if (Constant.IsConstantExpression(index) && Constant.IsConstantExpression(numNumbers) && index + numNumbers == Length && value == 0)
                {
                    if (index == 0)
                    {
                        intern = 0;
                    }
                    else
                    {
                        intern = (ushort)maxmath.bits_zerohigh(intern, index * BitsPerNumber);
                    }
                }
                else
                {
                    uint mask = (uint)maxmath.bitmask32(numNumbers * BitsPerNumber, index * BitsPerNumber);
                    uint newValues = new UInt4x4(value).intern & mask;
                    uint oldValues = maxmath.andnot(intern, mask);

                    intern = (ushort)(newValues | oldValues);
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
        public readonly bool Equals(UInt4x4 other)
        {
            return this.intern == other.intern;
        }

        public override readonly bool Equals(object obj)
        {
            return Equals((UInt4x4)obj);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
            return intern;
        }


        public override string ToString()
        {
            return new ArrayEnumerator<uint>(this).ToString();
        }


        public IEnumerator<uint> GetEnumerator()
        {
            return new ArrayEnumerator<uint>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<uint>(this);
        }
    }
}