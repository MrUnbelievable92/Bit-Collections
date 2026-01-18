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
    unsafe public struct UInt3x8 : IArray<uint>, IEquatable<UInt3x8>
    {
        public UInt24 Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt3x8(byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7)
        {
Assert.IsNotGreater(x0, UInt3.MaxValue);
Assert.IsNotGreater(x1, UInt3.MaxValue);
Assert.IsNotGreater(x2, UInt3.MaxValue);
Assert.IsNotGreater(x3, UInt3.MaxValue);
Assert.IsNotGreater(x4, UInt3.MaxValue);
Assert.IsNotGreater(x5, UInt3.MaxValue);
Assert.IsNotGreater(x6, UInt3.MaxValue);
//Assert.IsNotGreater(x7, UInt3.MaxValue);

            Bits = ((uint)x0 << (0 * default(UInt3).Bits))
                  | ((uint)x1 << (1 * default(UInt3).Bits))
                  | ((uint)x2 << (2 * default(UInt3).Bits))
                  | ((uint)x3 << (3 * default(UInt3).Bits))
                  | ((uint)x4 << (4 * default(UInt3).Bits))
                  | ((uint)x5 << (5 * default(UInt3).Bits))
                  | ((uint)x6 << (6 * default(UInt3).Bits))
                  | ((uint)x7 << (7 * default(UInt3).Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt3x8(byte x0_4)
        {
            Bits = SWAR.Broadcast32<UInt3>(x0_4);
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
        public static implicit operator UInt4x8(UInt3x8 input) => new UInt4x8 { Bits = (uint)PackUnpack.UpCast32<UInt3, UInt4>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt5x8(UInt3x8 input) => new UInt5x8 { Bits = (UInt40)PackUnpack.UpCast64<UInt3, UInt5>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt6x8(UInt3x8 input) => new UInt6x8 { Bits = (UInt48)PackUnpack.UpCast64<UInt3, UInt6>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt7x8(UInt3x8 input) => new UInt7x8 { Bits = (UInt56)PackUnpack.UpCast64<UInt3, UInt7>(input.Bits) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt3x8(UInt4x8 input) => new UInt3x8 { Bits = (uint)PackUnpack.DownCast<UInt4, UInt3>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt3x8(UInt5x8 input) => new UInt3x8 { Bits = (uint)PackUnpack.DownCast<UInt5, UInt3>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt3x8(UInt6x8 input) => new UInt3x8 { Bits = (uint)PackUnpack.DownCast<UInt6, UInt3>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt3x8(UInt7x8 input) => new UInt3x8 { Bits = (uint)PackUnpack.DownCast<UInt7, UInt3>(input.Bits) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator byte8(UInt3x8 input) => PackUnpack.BitIntArrayToByte8<UInt3>(input.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ushort8(UInt3x8 input) => PackUnpack.BitIntArrayToUShort8<UInt3>(input.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint8(UInt3x8 input) => PackUnpack.BitIntArrayToUInt8<UInt3>(input.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator sbyte8(UInt3x8 input) => (sbyte8)(byte8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator short8(UInt3x8 input) => (short8)(ushort8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int8(UInt3x8 input) => (int8)(uint8)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt3x8(byte8 input) => new UInt3x8 { Bits = (UInt24)PackUnpack.DownCast<UInt3>(input) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt3x8(ushort8 input) => new UInt3x8 { Bits = (UInt24)PackUnpack.DownCast<UInt3>(input) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt3x8(uint8 input) => new UInt3x8 { Bits = (UInt24)PackUnpack.DownCast<UInt3>(input) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt3x8(sbyte8 input) => (UInt3x8)(byte8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt3x8(short8 input) => (UInt3x8)(ushort8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt3x8(int8 input) => (UInt3x8)(uint8)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator quarter8(UInt3x8 input) => (quarter8)(byte8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator half8(UInt3x8 input) => (half8)(ushort8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float8(UInt3x8 input) => (float8)(int8)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt3x8(quarter8 input) => (UInt3x8)(byte8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt3x8(half8 input) => (UInt3x8)(ushort8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt3x8(float8 input) => (UInt3x8)(int8)input;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator ++ (UInt3x8 value) => value + 1;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator -- (UInt3x8 value) => value - 1;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator + (UInt3x8 left, UInt3x8 right) => new UInt3x8 { Bits = SWAR.Add<UInt3>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator + (UInt3x8 left, uint right) => left + new UInt3x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator + (uint left, UInt3x8 right) => right + left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator - (UInt3x8 left, UInt3x8 right) => new UInt3x8 { Bits = SWAR.Sub<UInt3>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator - (UInt3x8 left, uint right) => left - new UInt3x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator - (uint left, UInt3x8 right) => new UInt3x8((byte)left) - right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator * (UInt3x8 left, UInt3x8 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return new UInt3x8 { Bits = (uint)PackUnpack.DownCast<UInt3>(PackUnpack.BitIntArrayToByte8<UInt3>(left.Bits) * PackUnpack.BitIntArrayToByte8<UInt3>(right.Bits)) };
            }

            return new UInt3x8 { Bits = SWAR.Mul<UInt3>(left.Bits, right.Bits) };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator * (UInt3x8 left, uint right)
        {
            if (SWAR.ConstMul<UInt3>(left.Bits, right, out uint constMul))
            {
                return new UInt3x8 { Bits = constMul };
            }
        
            return left * new UInt3x8((byte)right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator * (uint left, UInt3x8 right) => right * left;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator / (UInt3x8 left, UInt3x8 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt3x8)((byte8)left / right);
            }

            return new UInt3x8{ Bits = SWAR.DivRem<UInt3>(left.Bits, right.Bits, out _) };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator / (UInt3x8 left, uint right)
        {
            if (SWAR.ConstDiv<UInt3>(left.Bits, (int)right, out uint constDiv))
            {
                return new UInt3x8 { Bits = constDiv };
            }
        
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt3x8)((byte8)left / (byte)right);
            }
        
            return new UInt3x8{ Bits = SWAR.DivRem<UInt3>(left.Bits, new UInt3x8((byte)right).Bits, out _) };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator / (uint left, UInt3x8 right) => new UInt3x8((byte)left) / right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator % (UInt3x8 left, UInt3x8 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt3x8)((byte8)left % right);
            }

            SWAR.DivRem<UInt3>(left.Bits, right.Bits, out uint r);

            return new UInt3x8{ Bits = r };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator % (UInt3x8 left, uint right)
        {
            if (SWAR.ConstRem<UInt3>(left.Bits, (int)right, out uint constRem))
            {
                return new UInt3x8 { Bits = constRem };
            }
        
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt3x8)((byte8)left % (byte)right);
            }
            
            SWAR.DivRem<UInt3>(left.Bits, new UInt3x8((byte)right).Bits, out uint r);

            return new UInt3x8{ Bits = r};
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator % (uint left, UInt3x8 right) => new UInt3x8((byte)left) % right;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator << (UInt3x8 left, int right) => new UInt3x8 { Bits = SWAR.ShiftLeftLogical<UInt3>(left.Bits, right) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator >> (UInt3x8 left, int right) => new UInt3x8 { Bits = SWAR.ShiftRightLogical<UInt3>(left.Bits, right) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator ~ (UInt3x8 value) => new UInt3x8{ Bits = ~value.Bits };
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator ^ (UInt3x8 left, UInt3x8 right) => new UInt3x8{ Bits = left.Bits ^ right.Bits };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator ^ (UInt3x8 left, uint right) => left ^ new UInt3x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator ^ (uint left, UInt3x8 right) => right ^ left;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator & (UInt3x8 left, UInt3x8 right) => new UInt3x8{ Bits = left.Bits & right.Bits };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator & (UInt3x8 left, uint right) => left & new UInt3x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator & (uint left, UInt3x8 right) => right & left;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator | (UInt3x8 left, UInt3x8 right) => new UInt3x8{ Bits = left.Bits | right.Bits };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator | (UInt3x8 left, uint right) => left | new UInt3x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator | (uint left, UInt3x8 right) => right | left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator == (UInt3x8 left, UInt3x8 right) => new UInt3x8 { Bits = SWAR.Equals<UInt3>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator == (UInt3x8 left, uint right) => left == new UInt3x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator == (uint left, UInt3x8 right) => right == left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator != (UInt3x8 left, UInt3x8 right) => new UInt3x8 { Bits = SWAR.NotEquals<UInt3>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator != (UInt3x8 left, uint right) => left != new UInt3x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator != (uint left, UInt3x8 right) => right != left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator < (UInt3x8 left, UInt3x8 right) => new UInt3x8 { Bits = SWAR.LessThan<UInt3>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator < (UInt3x8 left, uint right) => left < new UInt3x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator < (uint left, UInt3x8 right) => right > left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator > (UInt3x8 left, UInt3x8 right) => new UInt3x8 { Bits = SWAR.GreaterThan<UInt3>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator > (UInt3x8 left, uint right) => left > new UInt3x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator > (uint left, UInt3x8 right) => right < left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator <= (UInt3x8 left, UInt3x8 right) => new UInt3x8 { Bits = SWAR.LessThanOrEqual<UInt3>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator <= (UInt3x8 left, uint right) => left <= new UInt3x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator <= (uint left, UInt3x8 right) => right >= left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator >= (UInt3x8 left, UInt3x8 right) => new UInt3x8 { Bits = SWAR.GreaterThanOrEqual<UInt3>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator >= (UInt3x8 left, uint right) => left >= new UInt3x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x8 operator >= (uint left, UInt3x8 right) => right <= left;

        
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
        public readonly UInt3x8 SetReplicate(int index, int numNumbers, uint value)
        {
            return new UInt3x8 { Bits = BitFieldHelper.SetReplicate<UInt3>(Bits, (int)value, numNumbers, default(UInt3).Bits * index, default(UInt3).Bits * Length) };
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(UInt3x8 other)
        {
            return this.Bits == other.Bits;
        }

        public override readonly bool Equals(object obj)
        {
            return obj is UInt3x8 converted && this.Equals(converted);
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
            return new ArrayEnumerator<UInt3x8, uint>(this);
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<UInt3x8, uint>(this);
        }
    }
}