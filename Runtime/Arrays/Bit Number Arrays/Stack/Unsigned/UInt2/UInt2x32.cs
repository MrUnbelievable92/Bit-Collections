using DevTools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;
using MaxMath;

namespace BitCollections
{
    [Serializable]
    unsafe public struct UInt2x32 : IArray<uint>, IEquatable<UInt2x32>
    {
        public ulong Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x32(byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7, byte x8, byte x9, byte x10, byte x11, byte x12, byte x13, byte x14, byte x15, byte x16, byte x17, byte x18, byte x19, byte x20, byte x21, byte x22, byte x23, byte x24, byte x25, byte x26, byte x27, byte x28, byte x29, byte x30, byte x31)
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
Assert.IsNotGreater(x11, UInt2.MaxValue);
Assert.IsNotGreater(x12, UInt2.MaxValue);
Assert.IsNotGreater(x13, UInt2.MaxValue);
Assert.IsNotGreater(x14, UInt2.MaxValue);
Assert.IsNotGreater(x15, UInt2.MaxValue);
Assert.IsNotGreater(x16, UInt2.MaxValue);
Assert.IsNotGreater(x17, UInt2.MaxValue);
Assert.IsNotGreater(x18, UInt2.MaxValue);
Assert.IsNotGreater(x19, UInt2.MaxValue);
Assert.IsNotGreater(x20, UInt2.MaxValue);
Assert.IsNotGreater(x21, UInt2.MaxValue);
Assert.IsNotGreater(x22, UInt2.MaxValue);
Assert.IsNotGreater(x23, UInt2.MaxValue);
Assert.IsNotGreater(x24, UInt2.MaxValue);
Assert.IsNotGreater(x25, UInt2.MaxValue);
Assert.IsNotGreater(x26, UInt2.MaxValue);
Assert.IsNotGreater(x27, UInt2.MaxValue);
Assert.IsNotGreater(x28, UInt2.MaxValue);
Assert.IsNotGreater(x29, UInt2.MaxValue);
Assert.IsNotGreater(x30, UInt2.MaxValue);
//Assert.IsNotGreater(x31, UInt2.MaxValue);

            Bits = ((ulong)x0  << (0  * default(UInt2).Bits))
                  | ((ulong)x1  << (1  * default(UInt2).Bits))
                  | ((ulong)x2  << (2  * default(UInt2).Bits))
                  | ((ulong)x3  << (3  * default(UInt2).Bits))
                  | ((ulong)x4  << (4  * default(UInt2).Bits))
                  | ((ulong)x5  << (5  * default(UInt2).Bits))
                  | ((ulong)x6  << (6  * default(UInt2).Bits))
                  | ((ulong)x7  << (7  * default(UInt2).Bits))
                  | ((ulong)x8  << (8  * default(UInt2).Bits))
                  | ((ulong)x9  << (9  * default(UInt2).Bits))
                  | ((ulong)x10 << (10 * default(UInt2).Bits))
                  | ((ulong)x11 << (11 * default(UInt2).Bits))
                  | ((ulong)x12 << (12 * default(UInt2).Bits))
                  | ((ulong)x13 << (13 * default(UInt2).Bits))
                  | ((ulong)x14 << (14 * default(UInt2).Bits))
                  | ((ulong)x15 << (15 * default(UInt2).Bits))
                  | ((ulong)x16 << (16 * default(UInt2).Bits))
                  | ((ulong)x17 << (17 * default(UInt2).Bits))
                  | ((ulong)x18 << (18 * default(UInt2).Bits))
                  | ((ulong)x19 << (19 * default(UInt2).Bits))
                  | ((ulong)x20 << (20 * default(UInt2).Bits))
                  | ((ulong)x21 << (21 * default(UInt2).Bits))
                  | ((ulong)x22 << (22 * default(UInt2).Bits))
                  | ((ulong)x23 << (23 * default(UInt2).Bits))
                  | ((ulong)x24 << (24 * default(UInt2).Bits))
                  | ((ulong)x25 << (25 * default(UInt2).Bits))
                  | ((ulong)x26 << (26 * default(UInt2).Bits))
                  | ((ulong)x27 << (27 * default(UInt2).Bits))
                  | ((ulong)x28 << (28 * default(UInt2).Bits))
                  | ((ulong)x29 << (29 * default(UInt2).Bits))
                  | ((ulong)x30 << (30 * default(UInt2).Bits))
                  | ((ulong)x31 << (31 * default(UInt2).Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x32(byte x0_31)
        {
            Bits = SWAR.Broadcast64<UInt2>(x0_31);
        }


        public readonly int Length => 32;


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
        public uint x12
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[12];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[12] = value;
        }
        public uint x13
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[13];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[13] = value;
        }
        public uint x14
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[14];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[14] = value;
        }
        public uint x15
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[15];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[15] = value;
        }
        public uint x16
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[16];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[16] = value;
        }
        public uint x17
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[17];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[17] = value;
        }
        public uint x18
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[18];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[18] = value;
        }
        public uint x19
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[19];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[19] = value;
        }
        public uint x20
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[20];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[20] = value;
        }
        public uint x21
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[21];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[21] = value;
        }
        public uint x22
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[22];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[22] = value;
        }
        public uint x23
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[23];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[23] = value;
        }
        public uint x24
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[24];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[24] = value;
        }
        public uint x25
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[25];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[25] = value;
        }
        public uint x26
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[26];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[26] = value;
        }
        public uint x27
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[27];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[27] = value;
        }
        public uint x28
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[28];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[28] = value;
        }
        public uint x29
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[29];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[29] = value;
        }
        public uint x30
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[30];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[30] = value;
        }
        public uint x31
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[31];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[31] = value;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator byte32(UInt2x32 input) => PackUnpack.BitIntArrayToByte32<UInt2>(input.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator sbyte32(UInt2x32 input) => (sbyte32)(byte32)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x32(byte32 input) => new UInt2x32 { Bits = PackUnpack.DownCast<UInt2>(input) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x32(sbyte32 input) => (UInt2x32)(byte32)input;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator ++ (UInt2x32 value) => value + 1;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator -- (UInt2x32 value) => value - 1;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator + (UInt2x32 left, UInt2x32 right) => new UInt2x32 { Bits = SWAR.Add<UInt2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator + (UInt2x32 left, uint right) => left + new UInt2x32((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator + (uint left, UInt2x32 right) => right + left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator - (UInt2x32 left, UInt2x32 right) => new UInt2x32 { Bits = SWAR.Sub<UInt2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator - (UInt2x32 left, uint right) => left - new UInt2x32((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator - (uint left, UInt2x32 right) => new UInt2x32((byte)left) - right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator * (UInt2x32 left, UInt2x32 right) => new UInt2x32 { Bits = SWAR.Mul<UInt2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator * (UInt2x32 left, uint right)
        {
            if (SWAR.ConstMul<UInt2>(left.Bits, right, out ulong constMul))
            {
                return new UInt2x32 { Bits = constMul };
            }
        
            return left * new UInt2x32((byte)right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator * (uint left, UInt2x32 right) => right * left;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator / (UInt2x32 left, UInt2x32 right) => new UInt2x32 { Bits = SWAR.DivRem<UInt2>(left.Bits, right.Bits, out _) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator / (UInt2x32 left, uint right)
        {
            if (SWAR.ConstDiv<UInt2>(left.Bits, (long)right, out ulong constDiv))
            {
                return new UInt2x32 { Bits = constDiv };
            }
        
            return left / new UInt2x32((byte)right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator / (uint left, UInt2x32 right) => new UInt2x32((byte)left) / right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator % (UInt2x32 left, UInt2x32 right) { SWAR.DivRem<UInt2>(left.Bits, right.Bits, out ulong rem);     return new UInt2x32 { Bits = rem}; }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator % (UInt2x32 left, uint right)
        {
            if (SWAR.ConstRem<UInt2>(left.Bits, (long)right, out ulong constRem))
            {
                return new UInt2x32 { Bits = constRem };
            }
        
            return left % new UInt2x32((byte)right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator % (uint left, UInt2x32 right) => new UInt2x32((byte)left) % right;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator << (UInt2x32 left, int right) => new UInt2x32 { Bits = SWAR.ShiftLeftLogical<UInt2>(left.Bits, right) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator >> (UInt2x32 left, int right) => new UInt2x32 { Bits = SWAR.ShiftRightLogical<UInt2>(left.Bits, right) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator ~ (UInt2x32 value) => new UInt2x32{ Bits = ~value.Bits };
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator ^ (UInt2x32 left, UInt2x32 right) => new UInt2x32{ Bits = left.Bits ^ right.Bits };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator ^ (UInt2x32 left, uint right) => left ^ new UInt2x32((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator ^ (uint left, UInt2x32 right) => right ^ left;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator & (UInt2x32 left, UInt2x32 right) => new UInt2x32{ Bits = left.Bits & right.Bits };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator & (UInt2x32 left, uint right) => left & new UInt2x32((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator & (uint left, UInt2x32 right) => right & left;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator | (UInt2x32 left, UInt2x32 right) => new UInt2x32{ Bits = left.Bits | right.Bits };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator | (UInt2x32 left, uint right) => left | new UInt2x32((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator | (uint left, UInt2x32 right) => right | left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator == (UInt2x32 left, UInt2x32 right) => new UInt2x32 { Bits = SWAR.Equals<UInt2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator == (UInt2x32 left, uint right) => left == new UInt2x32((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator == (uint left, UInt2x32 right) => right == left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator != (UInt2x32 left, UInt2x32 right) => new UInt2x32 { Bits = SWAR.NotEquals<UInt2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator != (UInt2x32 left, uint right) => left != new UInt2x32((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator != (uint left, UInt2x32 right) => right != left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator < (UInt2x32 left, UInt2x32 right) => new UInt2x32 { Bits = SWAR.LessThan<UInt2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator < (UInt2x32 left, uint right) => left < new UInt2x32((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator < (uint left, UInt2x32 right) => right > left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator > (UInt2x32 left, UInt2x32 right) => new UInt2x32 { Bits = SWAR.GreaterThan<UInt2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator > (UInt2x32 left, uint right) => left > new UInt2x32((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator > (uint left, UInt2x32 right) => right < left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator <= (UInt2x32 left, UInt2x32 right) => new UInt2x32 { Bits = SWAR.LessThanOrEqual<UInt2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator <= (UInt2x32 left, uint right) => left <= new UInt2x32((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator <= (uint left, UInt2x32 right) => right >= left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator >= (UInt2x32 left, UInt2x32 right) => new UInt2x32 { Bits = SWAR.GreaterThanOrEqual<UInt2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator >= (UInt2x32 left, uint right) => left >= new UInt2x32((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x32 operator >= (uint left, UInt2x32 right) => right <= left;

        
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
        public readonly UInt2x32 SetReplicate(int index, int numNumbers, uint value)
        {
            return new UInt2x32 { Bits = BitFieldHelper.SetReplicate<UInt2>(Bits, (int)value, numNumbers, default(UInt2).Bits * index, default(UInt2).Bits * Length) };
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(UInt2x32 other)
        {
            return this.Bits == other.Bits;
        }

        public override readonly bool Equals(object obj)
        {
            return obj is UInt2x32 converted && this.Equals(converted);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
            return Bits.GetHashCode();
        }


        public override readonly string ToString()
        {
            return GetEnumerator().ToString();
        }


        public readonly IEnumerator<uint> GetEnumerator()
        {
            return new ArrayEnumerator<UInt2x32, uint>(this);
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<UInt2x32, uint>(this);
        }
    }
}