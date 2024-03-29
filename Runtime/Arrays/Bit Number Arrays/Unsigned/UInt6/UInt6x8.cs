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
    unsafe public struct UInt6x8 : IBitNumberArray<uint>, IEquatable<UInt6x8>
    {
        internal UInt48 intern;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt6x8(uint x0, uint x1, uint x2, uint x3, uint x4, uint x5, uint x6, uint x7) : this(new ulong4(x0, x1, x2, x3), new ulong4(x4, x5, x6, x7))
        { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt6x8(uint x0_7)
        {
            ulong4 vector = new ulong4(x0_7);

            this = new UInt6x8(vector, vector);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt6x8(ulong4 x0_3, ulong4 x4_7)
        {
Assert.IsNotGreater(x0_3.x, UInt6.MaxValue);
Assert.IsNotGreater(x0_3.y, UInt6.MaxValue);
Assert.IsNotGreater(x0_3.z, UInt6.MaxValue);
Assert.IsNotGreater(x0_3.w, UInt6.MaxValue);
Assert.IsNotGreater(x4_7.x, UInt6.MaxValue);
Assert.IsNotGreater(x4_7.y, UInt6.MaxValue);
Assert.IsNotGreater(x4_7.z, UInt6.MaxValue);
Assert.IsNotGreater(x4_7.w, UInt6.MaxValue);

            intern = (UInt48)(maxmath.csum(maxmath.shl(x0_3, (ulong)new UInt6x8().BitsPerNumber * new ulong4(0ul, 1ul, 2ul, 3ul)))
                              |
                              maxmath.csum(maxmath.shl(x4_7, (ulong)new UInt6x8().BitsPerNumber * new ulong4(4ul, 5ul, 6ul, 7ul))));
        }

        public readonly uint MinValue => UInt6.MinValue;
        public readonly uint MaxValue => UInt6.MaxValue;
        public readonly int Length => 8;
        public readonly int BitsPerNumber => 6;


        public uint x0
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[0];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[0] = value;
        }
        public uint x1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[1];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[1] = value;
        }
        public uint x2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[2];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[2] = value;
        }
        public uint x3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[3];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[3] = value;
        }
        public uint x4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[4];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[4] = value;
        }
        public uint x5
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[5];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[5] = value;
        }
        public uint x6
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[6];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[6] = value;
        }
        public uint x7
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[7];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[7] = value;
        }


        public uint this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange((ulong)UInt6.MinValue, (ulong)UInt6.MaxValue)]
            readonly get
            {
Assert.IsWithinArrayBounds(index, Length);

                if (Constant.IsConstantExpression(index))
                {
                    if (index == 0)
                    {
                        return (uint)(intern & (ulong)maxmath.bitmask64(BitsPerNumber));
                    }
                    else if (index == Length - 1)
                    {
                        return (uint)(intern >> (index * BitsPerNumber));
                    }
                    else { }
                }
                else { }


                return (uint)maxmath.bits_extract(intern, index * BitsPerNumber, BitsPerNumber);
            }
    
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsNotGreater(value, MaxValue);
Assert.IsWithinArrayBounds(index, Length);

                if (Constant.IsConstantExpression(index) && Constant.IsConstantExpression(value) && value == 0 && index == Length - 1)
                {
                    intern = (UInt48)maxmath.bits_zerohigh(intern, (Length - 1) * BitsPerNumber);
                }
                else
                {
                    int shiftValue = index * BitsPerNumber;
                    ulong newValue = (ulong)value << shiftValue;
                    ulong mask = math.rol(~(ulong)MaxValue, shiftValue);

                    intern = (UInt48)((intern & mask) | newValue);
                }
            }
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong4 GetSubArray(int index)
        {
Assert.IsValidSubarray(index, 4, Length);

            return MaxValue & maxmath.shrl(intern, (ulong4)((uint)BitsPerNumber * ((uint)index + new uint4(0u, 1u, 2u, 3u))));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetSubArray(int index, ulong4 value)
        {
Assert.IsValidSubarray(index, 4, Length);
Assert.IsNotGreater(value.x, MaxValue);
Assert.IsNotGreater(value.y, MaxValue);
Assert.IsNotGreater(value.z, MaxValue);
Assert.IsNotGreater(value.w, MaxValue);

            intern = (UInt48)(maxmath.andnot(intern,     (ulong)maxmath.bitmask64(4 * BitsPerNumber,   index * BitsPerNumber))
                              |
                              maxmath.csum(maxmath.shl(value,      (ulong4)((uint)BitsPerNumber * ((uint)index + new uint4(0u, 1u, 2u, 3u))))));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetAll(int index, int numNumbers, uint value)
        {
Assert.IsNotGreater(value, UInt6.MaxValue);
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
                        intern = (UInt48)maxmath.bits_zerohigh(intern, index * BitsPerNumber);
                    }
                }
                else
                {
                    ulong mask = (ulong)maxmath.bitmask64(numNumbers * BitsPerNumber, index * BitsPerNumber);
                    ulong newValues = new UInt6x8(value).intern & mask;
                    ulong oldValues = maxmath.andnot(intern, mask);

                    intern = (UInt48)(newValues | oldValues);
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
        public readonly bool Equals(UInt6x8 other)
        {
            return this.intern == other.intern;
        }

        public override readonly bool Equals(object obj)
        {
            return Equals((UInt6x8)obj);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
            return intern.GetHashCode();
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