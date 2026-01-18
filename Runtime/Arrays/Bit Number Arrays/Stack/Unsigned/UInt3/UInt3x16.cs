using DevTools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;
using MaxMath;
using MaxMath.Intrinsics;

namespace BitCollections
{
    [Serializable]
    unsafe public struct UInt3x16 : IArray<uint>, IEquatable<UInt3x16>
    {
        public UInt48 Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt3x16(byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7, byte x8, byte x9, byte x10, byte x11, byte x12, byte x13, byte x14, byte x15)
        {
Assert.IsNotGreater(x0,  UInt3.MaxValue);
Assert.IsNotGreater(x1,  UInt3.MaxValue);
Assert.IsNotGreater(x2,  UInt3.MaxValue);
Assert.IsNotGreater(x3,  UInt3.MaxValue);
Assert.IsNotGreater(x4,  UInt3.MaxValue);
Assert.IsNotGreater(x5,  UInt3.MaxValue);
Assert.IsNotGreater(x6,  UInt3.MaxValue);
Assert.IsNotGreater(x7,  UInt3.MaxValue);
Assert.IsNotGreater(x8,  UInt3.MaxValue);
Assert.IsNotGreater(x9,  UInt3.MaxValue);
Assert.IsNotGreater(x10, UInt3.MaxValue);
Assert.IsNotGreater(x11, UInt3.MaxValue);
Assert.IsNotGreater(x12, UInt3.MaxValue);
Assert.IsNotGreater(x13, UInt3.MaxValue);
Assert.IsNotGreater(x14, UInt3.MaxValue);
//Assert.IsNotGreater(x15, UInt3.MaxValue);

            Bits = ((ulong)x0  << (0  * default(UInt3).Bits))
                  | ((ulong)x1  << (1  * default(UInt3).Bits))
                  | ((ulong)x2  << (2  * default(UInt3).Bits))
                  | ((ulong)x3  << (3  * default(UInt3).Bits))
                  | ((ulong)x4  << (4  * default(UInt3).Bits))
                  | ((ulong)x5  << (5  * default(UInt3).Bits))
                  | ((ulong)x6  << (6  * default(UInt3).Bits))
                  | ((ulong)x7  << (7  * default(UInt3).Bits))
                  | ((ulong)x8  << (8  * default(UInt3).Bits))
                  | ((ulong)x9  << (9  * default(UInt3).Bits))
                  | ((ulong)x10 << (10 * default(UInt3).Bits))
                  | ((ulong)x11 << (11 * default(UInt3).Bits))
                  | ((ulong)x12 << (12 * default(UInt3).Bits))
                  | ((ulong)x13 << (13 * default(UInt3).Bits))
                  | ((ulong)x14 << (14 * default(UInt3).Bits))
                  | ((ulong)x15 << (15 * default(UInt3).Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt3x16(byte x0_15)
        {
            Bits = SWAR.Broadcast64<UInt3>(x0_15);
        }


        public readonly int Length => 16;


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


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt4x16(UInt3x16 input) => new UInt4x16 { Bits = (ulong)PackUnpack.UpCast64<UInt3, UInt4>(input.Bits) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt3x16(UInt4x16 input) => new UInt3x16 { Bits = (UInt48)PackUnpack.DownCast<UInt4, UInt3>(input.Bits) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator byte16(UInt3x16 input) => PackUnpack.BitIntArrayToByte16<UInt3>(input.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ushort16(UInt3x16 input) => (byte16)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator sbyte16(UInt3x16 input) => (sbyte16)(byte16)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator short16(UInt3x16 input) => (short16)(ushort16)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt3x16(byte16 input) => new UInt3x16 { Bits = (UInt48)PackUnpack.DownCast<UInt3>(input) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt3x16(ushort16 input) => (UInt3x16)(byte16)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt3x16(sbyte16 input) => (UInt3x16)(byte16)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt3x16(short16 input) => (UInt3x16)(ushort16)input;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator ++ (UInt3x16 value) => value + 1;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator -- (UInt3x16 value) => value - 1;

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator + (UInt3x16 left, UInt3x16 right) => new UInt3x16 { Bits = SWAR.Add<UInt3>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator + (UInt3x16 left, uint right) => left + new UInt3x16((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator + (uint left, UInt3x16 right) => right + left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator - (UInt3x16 left, UInt3x16 right) => new UInt3x16 { Bits = SWAR.Sub<UInt3>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator - (UInt3x16 left, uint right) => left - new UInt3x16((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator - (uint left, UInt3x16 right) => new UInt3x16((byte)left) - right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator * (UInt3x16 left, UInt3x16 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return new UInt3x16 { Bits = PackUnpack.DownCast<UInt3>(PackUnpack.BitIntArrayToByte16<UInt3>(left.Bits) * PackUnpack.BitIntArrayToByte16<UInt3>(right.Bits)) };
            }

            return new UInt3x16 { Bits = SWAR.Mul<UInt3>(left.Bits, right.Bits) };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator * (UInt3x16 left, uint right)
        {
            if (SWAR.ConstMul<UInt3>(left.Bits, right, out ulong constMul))
            {
                return new UInt3x16 { Bits = constMul };
            }
        
            return left * new UInt3x16((byte)right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator * (uint left, UInt3x16 right) => right * left;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator / (UInt3x16 left, UInt3x16 right)
        {   
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt3x16)((byte16)left / right);
            }

            return new UInt3x16 { Bits = SWAR.DivRem<UInt3>(left.Bits, right.Bits, out _) };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator / (UInt3x16 left, uint right)
        {
            if (SWAR.ConstDiv<UInt3>(left.Bits, (long)right, out ulong constDiv))
            {
                return new UInt3x16 { Bits = constDiv };
            }

            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt3x16)((byte16)left / (byte)right);
            }
            
            return new UInt3x16{ Bits = SWAR.DivRem<UInt3>(left.Bits, new UInt3x16((byte)right).Bits, out _)};
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator / (uint left, UInt3x16 right) => new UInt3x16((byte)left) / right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator % (UInt3x16 left, UInt3x16 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt3x16)((byte16)left % right);
            }

            SWAR.DivRem<UInt3>(left.Bits, right.Bits, out ulong r);

            return new UInt3x16 { Bits = r };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator % (UInt3x16 left, uint right)
        {
            if (SWAR.ConstRem<UInt3>(left.Bits, (long)right, out ulong constRem))
            {
                return new UInt3x16 { Bits = constRem };
            }

            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt3x16)((byte16)left % (byte)right);
            }
            
            SWAR.DivRem<UInt3>(left.Bits, new UInt3x16((byte)right).Bits, out ulong r);

            return new UInt3x16{ Bits = r};
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator % (uint left, UInt3x16 right) => new UInt3x16((byte)left) % right;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator << (UInt3x16 left, int right) => new UInt3x16 { Bits = SWAR.ShiftLeftLogical<UInt3>(left.Bits, right) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator >> (UInt3x16 left, int right) => new UInt3x16 { Bits = SWAR.ShiftRightLogical<UInt3>(left.Bits, right) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator ~ (UInt3x16 value) => new UInt3x16{ Bits = ~value.Bits };
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator ^ (UInt3x16 left, UInt3x16 right) => new UInt3x16{ Bits = left.Bits ^ right.Bits };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator ^ (UInt3x16 left, uint right) => left ^ new UInt3x16((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator ^ (uint left, UInt3x16 right) => right ^ left;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator & (UInt3x16 left, UInt3x16 right) => new UInt3x16{ Bits = left.Bits & right.Bits };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator & (UInt3x16 left, uint right) => left & new UInt3x16((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator & (uint left, UInt3x16 right) => right & left;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator | (UInt3x16 left, UInt3x16 right) => new UInt3x16{ Bits = left.Bits | right.Bits };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator | (UInt3x16 left, uint right) => left | new UInt3x16((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator | (uint left, UInt3x16 right) => right | left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator == (UInt3x16 left, UInt3x16 right) => new UInt3x16 { Bits = SWAR.Equals<UInt3>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator == (UInt3x16 left, uint right) => left == new UInt3x16((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator == (uint left, UInt3x16 right) => right == left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator != (UInt3x16 left, UInt3x16 right) => new UInt3x16 { Bits = SWAR.NotEquals<UInt3>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator != (UInt3x16 left, uint right) => left != new UInt3x16((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator != (uint left, UInt3x16 right) => right != left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator < (UInt3x16 left, UInt3x16 right) => new UInt3x16 { Bits = SWAR.LessThan<UInt3>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator < (UInt3x16 left, uint right) => left < new UInt3x16((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator < (uint left, UInt3x16 right) => right > left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator > (UInt3x16 left, UInt3x16 right) => new UInt3x16 { Bits = SWAR.GreaterThan<UInt3>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator > (UInt3x16 left, uint right) => left > new UInt3x16((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator > (uint left, UInt3x16 right) => right < left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator <= (UInt3x16 left, UInt3x16 right) => new UInt3x16 { Bits = SWAR.LessThanOrEqual<UInt3>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator <= (UInt3x16 left, uint right) => left <= new UInt3x16((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator <= (uint left, UInt3x16 right) => right >= left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator >= (UInt3x16 left, UInt3x16 right) => new UInt3x16 { Bits = SWAR.GreaterThanOrEqual<UInt3>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator >= (UInt3x16 left, uint right) => left >= new UInt3x16((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x16 operator >= (uint left, UInt3x16 right) => right <= left;

        
        public uint this[int index]
        {
            [return: AssumeRange((ulong)UInt3.MinValue, (ulong)UInt3.MaxValue)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (uint)BitFieldHelper.Get<UInt3>(Bits, default(UInt3).Bits * index, default(UInt3).Bits * Length);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Bits = BitFieldHelper.Set<UInt3>(Bits, (int)value, default(UInt3).Bits * index, default(UInt3).Bits * Length);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly UInt3x16 SetReplicate(int index, int numNumbers, uint value)
        {
            return new UInt3x16 { Bits = BitFieldHelper.SetReplicate<UInt3>(Bits, (int)value, numNumbers, default(UInt3).Bits * index, default(UInt3).Bits * Length) };
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(UInt3x16 other)
        {
            return this.Bits == other.Bits;
        }

        public override readonly bool Equals(object obj)
        {
            return obj is UInt3x16 converted && this.Equals(converted);
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
            return new ArrayEnumerator<UInt3x16, uint>(this);
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<UInt3x16, uint>(this);
        }
    }
}