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
    unsafe public struct UInt2x8 : IArray<uint>, IEquatable<UInt2x8>
    {
        public ushort Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x8(byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7)
        {
Assert.IsNotGreater(x0, UInt2.MaxValue);
Assert.IsNotGreater(x1, UInt2.MaxValue);
Assert.IsNotGreater(x2, UInt2.MaxValue);
Assert.IsNotGreater(x3, UInt2.MaxValue);
Assert.IsNotGreater(x4, UInt2.MaxValue);
Assert.IsNotGreater(x5, UInt2.MaxValue);
Assert.IsNotGreater(x6, UInt2.MaxValue);
//Assert.IsNotGreater(x7, UInt2.MaxValue);

            Bits = (ushort)(((uint)x0 << (0 * default(UInt2).Bits))
                           | ((uint)x1 << (1 * default(UInt2).Bits))
                           | ((uint)x2 << (2 * default(UInt2).Bits))
                           | ((uint)x3 << (3 * default(UInt2).Bits))
                           | ((uint)x4 << (4 * default(UInt2).Bits))
                           | ((uint)x5 << (5 * default(UInt2).Bits))
                           | ((uint)x6 << (6 * default(UInt2).Bits))
                           | ((uint)x7 << (7 * default(UInt2).Bits)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x8(byte x0_4)
        {
            Bits = SWAR.Broadcast16<UInt2>(x0_4);
        }


        public readonly int Length => 8;


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


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt3x8(UInt2x8 input) => new UInt3x8 { Bits = (UInt24)PackUnpack.UpCast32<UInt2, UInt3>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt4x8(UInt2x8 input) => new UInt4x8 { Bits = (uint)PackUnpack.UpCast32<UInt2, UInt4>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt5x8(UInt2x8 input) => new UInt5x8 { Bits = (UInt40)PackUnpack.UpCast64<UInt2, UInt5>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt6x8(UInt2x8 input) => new UInt6x8 { Bits = (UInt48)PackUnpack.UpCast64<UInt2, UInt6>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt7x8(UInt2x8 input) => new UInt7x8 { Bits = (UInt56)PackUnpack.UpCast64<UInt2, UInt7>(input.Bits) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x8(UInt3x8 input) => new UInt2x8 { Bits = (ushort)PackUnpack.DownCast<UInt3, UInt2>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x8(UInt4x8 input) => new UInt2x8 { Bits = (ushort)PackUnpack.DownCast<UInt4, UInt2>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x8(UInt5x8 input) => new UInt2x8 { Bits = (ushort)PackUnpack.DownCast<UInt5, UInt2>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x8(UInt6x8 input) => new UInt2x8 { Bits = (ushort)PackUnpack.DownCast<UInt6, UInt2>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x8(UInt7x8 input) => new UInt2x8 { Bits = (ushort)PackUnpack.DownCast<UInt7, UInt2>(input.Bits) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator byte8(UInt2x8 input) => PackUnpack.BitIntArrayToByte8<UInt2>(input.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ushort8(UInt2x8 input) => (byte8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint8(UInt2x8 input) => (byte8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator sbyte8(UInt2x8 input) => (sbyte8)(byte8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator short8(UInt2x8 input) => (short8)(ushort8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int8(UInt2x8 input) => (int8)(uint8)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x8(byte8 input) => new UInt2x8 { Bits = (ushort)PackUnpack.DownCast<UInt2>(input) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x8(ushort8 input) => (UInt2x8)(byte8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x8(uint8 input) => (UInt2x8)(byte8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x8(sbyte8 input) => (UInt2x8)(byte8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x8(short8 input) => (UInt2x8)(ushort8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x8(int8 input) => (UInt2x8)(uint8)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator quarter8(UInt2x8 input) => (quarter8)(byte8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator half8(UInt2x8 input) => (half8)(ushort8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float8(UInt2x8 input) => (float8)(int8)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x8(quarter8 input) => (UInt2x8)(byte8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x8(half8 input) => (UInt2x8)(ushort8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x8(float8 input) => (UInt2x8)(int8)input;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator ++ (UInt2x8 value) => value + 1;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator -- (UInt2x8 value) => value - 1;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator + (UInt2x8 left, UInt2x8 right) => new UInt2x8 { Bits = SWAR.Add<UInt2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator + (UInt2x8 left, uint right) => left + new UInt2x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator + (uint left, UInt2x8 right) => right + left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator - (UInt2x8 left, UInt2x8 right) => new UInt2x8 { Bits = SWAR.Sub<UInt2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator - (UInt2x8 left, uint right) => left - new UInt2x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator - (uint left, UInt2x8 right) => new UInt2x8((byte)left) - right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator * (UInt2x8 left, UInt2x8 right) => new UInt2x8 { Bits = SWAR.Mul<UInt2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator * (UInt2x8 left, uint right)
        {
            if (SWAR.ConstMul<UInt2>(left.Bits, (ushort)right, out ushort constMul))
            {
                return new UInt2x8 { Bits = constMul };
            }
        
            return left * new UInt2x8((byte)right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator * (uint left, UInt2x8 right) => right * left;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator / (UInt2x8 left, UInt2x8 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt2x8)((byte8)left / right);
            }

            return new UInt2x8 { Bits = SWAR.DivRem<UInt2>(left.Bits, right.Bits, out _) };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator / (UInt2x8 left, uint right)
        {
            if (SWAR.ConstDiv<UInt2>(left.Bits, (short)right, out ushort constDiv))
            {
                return new UInt2x8 { Bits = constDiv };
            }
        
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt2x8)((byte8)left / (byte)right);
            }

            return left / new UInt2x8((byte)right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator / (uint left, UInt2x8 right) => new UInt2x8((byte)left) / right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator % (UInt2x8 left, UInt2x8 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt2x8)((byte8)left % right);
            }

            SWAR.DivRem<UInt2>(left.Bits, right.Bits, out ushort rem);

            return new UInt2x8 { Bits = rem};
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator % (UInt2x8 left, uint right)
        {
            if (SWAR.ConstRem<UInt2>(left.Bits, (short)right, out ushort constRem))
            {
                return new UInt2x8 { Bits = constRem };
            }
        
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt2x8)((byte8)left % (byte)right);
            }
        
            return left % new UInt2x8((byte)right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator % (uint left, UInt2x8 right) => new UInt2x8((byte)left) % right;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator << (UInt2x8 left, int right) => new UInt2x8 { Bits = SWAR.ShiftLeftLogical<UInt2>(left.Bits, right) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator >> (UInt2x8 left, int right) => new UInt2x8 { Bits = SWAR.ShiftRightLogical<UInt2>(left.Bits, right) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator ~ (UInt2x8 value) => new UInt2x8{ Bits = (ushort)(~value.Bits) };
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator ^ (UInt2x8 left, UInt2x8 right) => new UInt2x8{ Bits = (ushort)(left.Bits ^ right.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator ^ (UInt2x8 left, uint right) => left ^ new UInt2x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator ^ (uint left, UInt2x8 right) => right ^ left;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator & (UInt2x8 left, UInt2x8 right) => new UInt2x8{ Bits = (ushort)(left.Bits & right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator & (UInt2x8 left, uint right) => left & new UInt2x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator & (uint left, UInt2x8 right) => right & left;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator | (UInt2x8 left, UInt2x8 right) => new UInt2x8{ Bits = (ushort)(left.Bits | right.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator | (UInt2x8 left, uint right) => left | new UInt2x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator | (uint left, UInt2x8 right) => right | left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator == (UInt2x8 left, UInt2x8 right) => new UInt2x8 { Bits = SWAR.Equals<UInt2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator == (UInt2x8 left, uint right) => left == new UInt2x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator == (uint left, UInt2x8 right) => right == left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator != (UInt2x8 left, UInt2x8 right) => new UInt2x8 { Bits = SWAR.NotEquals<UInt2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator != (UInt2x8 left, uint right) => left != new UInt2x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator != (uint left, UInt2x8 right) => right != left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator < (UInt2x8 left, UInt2x8 right) => new UInt2x8 { Bits = SWAR.LessThan<UInt2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator < (UInt2x8 left, uint right) => left < new UInt2x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator < (uint left, UInt2x8 right) => right > left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator > (UInt2x8 left, UInt2x8 right) => new UInt2x8 { Bits = SWAR.GreaterThan<UInt2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator > (UInt2x8 left, uint right) => left > new UInt2x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator > (uint left, UInt2x8 right) => right < left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator <= (UInt2x8 left, UInt2x8 right) => new UInt2x8 { Bits = SWAR.LessThanOrEqual<UInt2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator <= (UInt2x8 left, uint right) => left <= new UInt2x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator <= (uint left, UInt2x8 right) => right >= left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator >= (UInt2x8 left, UInt2x8 right) => new UInt2x8 { Bits = SWAR.GreaterThanOrEqual<UInt2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator >= (UInt2x8 left, uint right) => left >= new UInt2x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x8 operator >= (uint left, UInt2x8 right) => right <= left;

        
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
                Bits = (ushort)BitFieldHelper.Set<UInt2>(Bits, (int)value, default(UInt2).Bits * index, default(UInt2).Bits * Length);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly UInt2x8 SetReplicate(int index, int numNumbers, uint value)
        {
            return new UInt2x8 { Bits = (ushort)BitFieldHelper.SetReplicate<UInt2>(Bits, (int)value, numNumbers, default(UInt2).Bits * index, default(UInt2).Bits * Length) };
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(UInt2x8 other)
        {
            return this.Bits == other.Bits;
        }

        public override readonly bool Equals(object obj)
        {
            return obj is UInt2x8 converted && this.Equals(converted);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
            return Bits;
        }


        public override readonly string ToString()
        {
            return GetEnumerator().ToString();
        }


        public readonly IEnumerator<uint> GetEnumerator()
        {
            return new ArrayEnumerator<UInt2x8, uint>(this);
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<UInt2x8, uint>(this);
        }
    }
}