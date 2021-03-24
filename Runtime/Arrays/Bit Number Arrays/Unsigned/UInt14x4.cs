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
    unsafe public struct UInt14x4 : IBitNumberArray<uint>, IEquatable<UInt14x4>
    {
        internal UInt56 intern;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt14x4(uint x, uint y, uint z, uint w)
        {
Assert.IsNotGreater(x, UInt14.MaxValue);
Assert.IsNotGreater(y, UInt14.MaxValue);
Assert.IsNotGreater(z, UInt14.MaxValue);
Assert.IsNotGreater(w, UInt14.MaxValue);

            intern = (UInt56)(((ulong)x
                               |
                               ((ulong)y << new UInt14x4().BitsPerNumber))
                               |
                               (((ulong)z << (2 * new UInt14x4().BitsPerNumber))
                               |
                               ((ulong)w << (3 * new UInt14x4().BitsPerNumber))));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt14x4(uint xyzw)
        {
Assert.IsNotGreater(xyzw, UInt14.MaxValue);

            intern = (UInt56)(((ulong)xyzw
                               |
                               ((ulong)xyzw << new UInt14x4().BitsPerNumber))
                               |
                               (((ulong)xyzw << (2 * new UInt14x4().BitsPerNumber))
                               |
                               ((ulong)xyzw << (3 * new UInt14x4().BitsPerNumber))));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt14x4(ulong4 xyzw)
        {
Assert.IsNotGreater(xyzw.x, UInt14.MaxValue);
Assert.IsNotGreater(xyzw.y, UInt14.MaxValue);
Assert.IsNotGreater(xyzw.z, UInt14.MaxValue);
Assert.IsNotGreater(xyzw.w, UInt14.MaxValue);

            ulong4 csum = maxmath.shl(xyzw, (ulong)new UInt14x4().BitsPerNumber * new ulong4(0ul, 1ul, 2ul, 3ul));

            intern = (UInt56)maxmath.csum(csum);
        }


        public readonly uint MinValue => UInt14.MinValue;
        public readonly uint MaxValue => UInt14.MaxValue;
        public readonly int Length => 4;
        public readonly int BitsPerNumber => 14;


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
                this = new UInt14x4(value);
            }
        }
    
    
        public uint this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange((ulong)UInt14.MinValue, (ulong)UInt14.MaxValue)]
            readonly get
            {
Assert.IsWithinArrayBounds(index, Length);

                return (uint)maxmath.bits_extract(intern, index * BitsPerNumber, BitsPerNumber);
            }
    
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsNotGreater(value, MaxValue);
Assert.IsWithinArrayBounds(index, Length);

                if (Constant.IsConstantExpression(index) && Constant.IsConstantExpression(value) && value == 0 && index == Length - 1)
                {
                    intern = (UInt56)maxmath.bits_zerohigh(intern, (Length - 1) * BitsPerNumber);
                }
                else
                {
                    int shiftValue = index * BitsPerNumber;
                    ulong newValue = (ulong)value << shiftValue;
                    ulong mask = math.rol(~(ulong)MaxValue, shiftValue);

                    intern = (UInt56)((intern & mask) | newValue);
                }
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetAll(int index, int numNumbers, uint value)
        {
Assert.IsNotGreater(value, UInt14.MaxValue);
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
                        intern = (UInt56)maxmath.bits_zerohigh(intern, index * BitsPerNumber);
                    }
                }
                else
                {
                    ulong mask = (ulong)maxmath.bitmask64(numNumbers * BitsPerNumber, index * BitsPerNumber);
                    ulong newValues = new UInt14x4(value).intern & mask;
                    ulong oldValues = maxmath.andnot(intern, mask);

                    intern = (UInt56)(newValues | oldValues);
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
        public readonly bool Equals(UInt14x4 other)
        {
            return this.intern == other.intern;
        }

        public override readonly bool Equals(object obj)
        {
            return Equals((Int14x4)obj);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
            return intern.GetHashCode();
        }
    
    
        public override string ToString()
        {
            return new Enumerator<uint>(this).ToString();
        }
    
    
        public IEnumerator<uint> GetEnumerator()
        {
            return new Enumerator<uint>(this);
        }
    
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumerator<uint>(this);
        }
    }
}