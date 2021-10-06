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
    unsafe public struct UInt10x4 : IBitNumberArray<uint>, IEquatable<UInt10x4>
    {
        internal UInt40 intern;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt10x4(uint x, uint y, uint z, uint w)
        {
Assert.IsNotGreater(x, UInt10.MaxValue);
Assert.IsNotGreater(y, UInt10.MaxValue);
Assert.IsNotGreater(z, UInt10.MaxValue);
Assert.IsNotGreater(w, UInt10.MaxValue);

            intern = (UInt40)(((ulong)x
                               |
                               ((ulong)y << new UInt10x4().BitsPerNumber))
                               |
                               (((ulong)z << (2 * new UInt10x4().BitsPerNumber))
                               |
                               ((ulong)w << (3 * new UInt10x4().BitsPerNumber))));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt10x4(uint xyzw)
        {
Assert.IsNotGreater(xyzw, UInt10.MaxValue);

            intern = (UInt40)(((ulong)xyzw
                               |
                               ((ulong)xyzw << new UInt10x4().BitsPerNumber))
                               |
                               (((ulong)xyzw << (2 * new UInt10x4().BitsPerNumber))
                               |
                               ((ulong)xyzw << (3 * new UInt10x4().BitsPerNumber))));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt10x4(ulong4 xyzw)
        {
Assert.IsNotGreater(xyzw.x, UInt10.MaxValue);
Assert.IsNotGreater(xyzw.y, UInt10.MaxValue);
Assert.IsNotGreater(xyzw.z, UInt10.MaxValue);
Assert.IsNotGreater(xyzw.w, UInt10.MaxValue);

            ulong4 csum = maxmath.shl(xyzw, (ulong)new UInt10x4().BitsPerNumber * new ulong4(0ul, 1ul, 2ul, 3ul));

            intern = (UInt40)maxmath.csum(csum);
        }


        public readonly uint MinValue => UInt10.MinValue;
        public readonly uint MaxValue => UInt10.MaxValue;
        public readonly int Length => 4;
        public readonly int BitsPerNumber => 10;


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

        public ulong4 xyzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return MaxValue & maxmath.shrl(intern, (ulong)BitsPerNumber * new ulong4(0ul, 1ul, 2ul, 3ul));
            }
        
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                this = new UInt10x4(value);
            }
        }
    
    
        public uint this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange((ulong)UInt10.MinValue, (ulong)UInt10.MaxValue)]
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
                    intern = (UInt40)maxmath.bits_zerohigh(intern, (Length - 1) * BitsPerNumber);
                }
                else
                {
                    int shiftValue = index * BitsPerNumber;
                    ulong newValue = (ulong)value << shiftValue;
                    ulong mask = math.rol(~(ulong)MaxValue, shiftValue);

                    intern = (UInt40)((intern & mask) | newValue);
                }
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetAll(int index, int numNumbers, uint value)
        {
Assert.IsNotGreater(value, UInt10.MaxValue);
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
                    ulong newValues = new UInt10x4(value).intern & mask;
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
        public readonly bool Equals(UInt10x4 other)
        {
            return this.intern == other.intern;
        }

        public override readonly bool Equals(object obj)
        {
            return Equals((UInt10x4)obj);
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