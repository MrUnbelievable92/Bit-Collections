using DevTools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;

namespace BitCollections
{
    [Serializable]
    unsafe public struct UInt2x12 : IArray<uint>, IEquatable<UInt2x12>
    {
        public UInt24 Bits;



        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x12(byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7, byte x8, byte x9, byte x10, byte x11)
        {
Assert.IsNotGreater(x0,  UInt2.MaxValue);
Assert.IsNotGreater(x1,  UInt2.MaxValue);
Assert.IsNotGreater(x2,  UInt2.MaxValue);
Assert.IsNotGreater(x3,  UInt2.MaxValue);
Assert.IsNotGreater(x4,  UInt2.MaxValue);
Assert.IsNotGreater(x5,  UInt2.MaxValue);
Assert.IsNotGreater(x6,  UInt2.MaxValue);
Assert.IsNotGreater(x7,  UInt2.MaxValue);
Assert.IsNotGreater(x8,  UInt2.MaxValue);
Assert.IsNotGreater(x9,  UInt2.MaxValue);
Assert.IsNotGreater(x10, UInt2.MaxValue);
//Assert.IsNotGreater(x11, UInt2.MaxValue);

            Bits = ((uint)x0  << (0  * default(UInt2).Bits))
                  | ((uint)x1  << (1  * default(UInt2).Bits))
                  | ((uint)x2  << (2  * default(UInt2).Bits))
                  | ((uint)x3  << (3  * default(UInt2).Bits))
                  | ((uint)x4  << (4  * default(UInt2).Bits))
                  | ((uint)x5  << (5  * default(UInt2).Bits))
                  | ((uint)x6  << (6  * default(UInt2).Bits))
                  | ((uint)x7  << (7  * default(UInt2).Bits))
                  | ((uint)x8  << (8  * default(UInt2).Bits))
                  | ((uint)x9  << (9  * default(UInt2).Bits))
                  | ((uint)x10 << (10 * default(UInt2).Bits))
                  | ((uint)x11 << (11 * default(UInt2).Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x12(byte x0_11)
        {
            Bits = SWAR.Broadcast32<UInt2>(x0_11);
        }


        public readonly int Length => 12;


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
        public uint x8
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[8];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[8] = value;
        }
        public uint x9
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[9];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[9] = value;
        }
        public uint x10
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[10];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[10] = value;
        }
        public uint x11
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[11];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[11] = value;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt4x12(UInt2x12 input) => new UInt4x12 { Bits = (UInt48)PackUnpack.UpCast64<UInt2, UInt4>(input.Bits) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x12(UInt4x12 input) => new UInt2x12 { Bits = (UInt24)PackUnpack.DownCast<UInt4, UInt2>(input.Bits) };
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator ++ (UInt2x12 value) => value + 1;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator -- (UInt2x12 value) => value - 1;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator + (UInt2x12 left, UInt2x12 right) => new UInt2x12 { Bits = SWAR.Add<UInt2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator + (UInt2x12 left, uint right) => left + new UInt2x12((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator + (uint left, UInt2x12 right) => right + left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator - (UInt2x12 left, UInt2x12 right) => new UInt2x12 { Bits = SWAR.Sub<UInt2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator - (UInt2x12 left, uint right) => left - new UInt2x12((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator - (uint left, UInt2x12 right) => new UInt2x12((byte)left) - right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator * (UInt2x12 left, UInt2x12 right) => new UInt2x12 { Bits = SWAR.Mul<UInt2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator * (UInt2x12 left, uint right)
        {
            if (SWAR.ConstMul<UInt2>(left.Bits, right, out uint constMul))
            {
                return new UInt2x12 { Bits = constMul };
            }
        
            return left * new UInt2x12((byte)right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator * (uint left, UInt2x12 right) => right * left;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator / (UInt2x12 left, UInt2x12 right) => new UInt2x12 { Bits = SWAR.DivRem<UInt2>(left.Bits, right.Bits, out _) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator / (UInt2x12 left, uint right)
        {
            if (SWAR.ConstDiv<UInt2>(left.Bits, (int)right, out uint constDiv))
            {
                return new UInt2x12 { Bits = constDiv };
            }
        
            return left / new UInt2x12((byte)right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator / (uint left, UInt2x12 right) => new UInt2x12((byte)left) / right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator % (UInt2x12 left, UInt2x12 right) { SWAR.DivRem<UInt2>(left.Bits, right.Bits, out uint rem);     return new UInt2x12 { Bits = rem}; }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator % (UInt2x12 left, uint right)
        {
            if (SWAR.ConstRem<UInt2>(left.Bits, (int)right, out uint constRem))
            {
                return new UInt2x12 { Bits = constRem };
            }
        
            return left % new UInt2x12((byte)right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator % (uint left, UInt2x12 right) => new UInt2x12((byte)left) % right;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator << (UInt2x12 left, int right) => new UInt2x12 { Bits = SWAR.ShiftLeftLogical<UInt2>(left.Bits, right) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator >> (UInt2x12 left, int right) => new UInt2x12 { Bits = SWAR.ShiftRightLogical<UInt2>(left.Bits, right) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator ~ (UInt2x12 value) => new UInt2x12{ Bits = ~value.Bits };
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator ^ (UInt2x12 left, UInt2x12 right) => new UInt2x12{ Bits = left.Bits ^ right.Bits };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator ^ (UInt2x12 left, uint right) => left ^ new UInt2x12((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator ^ (uint left, UInt2x12 right) => right ^ left;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator & (UInt2x12 left, UInt2x12 right) => new UInt2x12{ Bits = left.Bits & right.Bits };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator & (UInt2x12 left, uint right) => left & new UInt2x12((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator & (uint left, UInt2x12 right) => right & left;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator | (UInt2x12 left, UInt2x12 right) => new UInt2x12{ Bits = left.Bits | right.Bits };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator | (UInt2x12 left, uint right) => left | new UInt2x12((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator | (uint left, UInt2x12 right) => right | left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator == (UInt2x12 left, UInt2x12 right) => new UInt2x12 { Bits = SWAR.Equals<UInt2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator == (UInt2x12 left, uint right) => left == new UInt2x12((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator == (uint left, UInt2x12 right) => right == left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator != (UInt2x12 left, UInt2x12 right) => new UInt2x12 { Bits = SWAR.NotEquals<UInt2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator != (UInt2x12 left, uint right) => left != new UInt2x12((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator != (uint left, UInt2x12 right) => right != left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator < (UInt2x12 left, UInt2x12 right) => new UInt2x12 { Bits = SWAR.LessThan<UInt2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator < (UInt2x12 left, uint right) => left < new UInt2x12((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator < (uint left, UInt2x12 right) => right > left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator > (UInt2x12 left, UInt2x12 right) => new UInt2x12 { Bits = SWAR.GreaterThan<UInt2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator > (UInt2x12 left, uint right) => left > new UInt2x12((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator > (uint left, UInt2x12 right) => right < left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator <= (UInt2x12 left, UInt2x12 right) => new UInt2x12 { Bits = SWAR.LessThanOrEqual<UInt2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator <= (UInt2x12 left, uint right) => left <= new UInt2x12((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator <= (uint left, UInt2x12 right) => right >= left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator >= (UInt2x12 left, UInt2x12 right) => new UInt2x12 { Bits = SWAR.GreaterThanOrEqual<UInt2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator >= (UInt2x12 left, uint right) => left >= new UInt2x12((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x12 operator >= (uint left, UInt2x12 right) => right <= left;

        
        public uint this[int index]
        {
            [return: AssumeRange((ulong)UInt2.MinValue, (ulong)UInt2.MaxValue)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (uint)BitFieldHelper.Get<UInt2>(Bits, default(UInt2).Bits * index, default(UInt2).Bits * Length);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Bits = BitFieldHelper.Set<UInt2>(Bits, (int)value, default(UInt2).Bits * index, default(UInt2).Bits * Length);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly UInt2x12 SetReplicate(int index, int numNumbers, uint value)
        {
            return new UInt2x12 { Bits = BitFieldHelper.SetReplicate<UInt2>(Bits, (int)value, numNumbers, default(UInt2).Bits * index, default(UInt2).Bits * Length) };
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(UInt2x12 other)
        {
            return this.Bits == other.Bits;
        }

        public override readonly bool Equals(object obj)
        {
            return obj is UInt2x12 converted && this.Equals(converted);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
            return (int)Bits;
        }


        public override readonly string ToString()
        {
            return GetEnumerator().ToString();
        }


        public readonly IEnumerator<uint> GetEnumerator()
        {
            return new ArrayEnumerator<UInt2x12, uint>(this);
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<UInt2x12, uint>(this);
        }
    }
}