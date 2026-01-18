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
    unsafe public struct UInt2x4 : IArray<uint>, IEquatable<UInt2x4>
    {
        public byte Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x4(byte x, byte y, byte z, byte w)
        {
Assert.IsNotGreater(x, UInt2.MaxValue);
Assert.IsNotGreater(y, UInt2.MaxValue);
Assert.IsNotGreater(z, UInt2.MaxValue);
//Assert.IsNotGreater(w, UInt2.MaxValue);

            Bits = (byte)(((uint)x << (0 * default(UInt2).Bits))
                         | ((uint)y << (1 * default(UInt2).Bits))
                         | ((uint)z << (2 * default(UInt2).Bits))
                         | ((uint)w << (3 * default(UInt2).Bits)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x4(byte xyzw)
        {
            Bits = SWAR.Broadcast8<UInt2>(xyzw);
        }


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


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt4x4(UInt2x4 input) => new UInt4x4 { Bits = (ushort)PackUnpack.UpCast16<UInt2, UInt4>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt6x4(UInt2x4 input) => new UInt6x4 { Bits = (UInt24)PackUnpack.UpCast32<UInt2, UInt6>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt10x4(UInt2x4 input) => new UInt10x4 { Bits = (UInt40)PackUnpack.UpCast64<UInt2, UInt10>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt12x4(UInt2x4 input) => new UInt12x4 { Bits = (UInt48)PackUnpack.UpCast64<UInt2, UInt12>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt14x4(UInt2x4 input) => new UInt14x4 { Bits = (UInt56)PackUnpack.UpCast64<UInt2, UInt14>(input.Bits) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x4(UInt4x4 input) => new UInt2x4 { Bits = (byte)PackUnpack.DownCast<UInt4, UInt2>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x4(UInt6x4 input) => new UInt2x4 { Bits = (byte)PackUnpack.DownCast<UInt6, UInt2>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x4(UInt10x4 input) => new UInt2x4 { Bits = (byte)PackUnpack.DownCast<UInt10, UInt2>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x4(UInt12x4 input) => new UInt2x4 { Bits = (byte)PackUnpack.DownCast<UInt12, UInt2>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x4(UInt14x4 input) => new UInt2x4 { Bits = (byte)PackUnpack.DownCast<UInt14, UInt2>(input.Bits) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator byte4(UInt2x4 input) => PackUnpack.BitIntArrayToByte4<UInt2>(input.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ushort4(UInt2x4 input) => PackUnpack.BitIntArrayToUShort4<UInt2>(input.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint4(UInt2x4 input) => PackUnpack.BitIntArrayToUInt4<UInt2>(input.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong4(UInt2x4 input) => PackUnpack.BitIntArrayToULong4<UInt2>(input.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator sbyte4(UInt2x4 input) => (sbyte4)(byte4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator short4(UInt2x4 input) => (short4)(ushort4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int4(UInt2x4 input) => (int4)(uint4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long4(UInt2x4 input) => (long4)(ulong4)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x4(byte4 input) => new UInt2x4 { Bits = (byte)PackUnpack.DownCast<UInt2>(input) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x4(ushort4 input) => new UInt2x4 { Bits = (byte)PackUnpack.DownCast<UInt16, UInt2>(input.Reinterpret<ushort4, ulong>()) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x4(uint4 input) => new UInt2x4 { Bits = (byte)PackUnpack.DownCast<UInt2>(input) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x4(ulong4 input) => new UInt2x4 { Bits = (byte)PackUnpack.DownCast<UInt2>(input) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x4(sbyte4 input) => (UInt2x4)(byte4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x4(short4 input) => (UInt2x4)(ushort4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x4(int4 input) => (UInt2x4)(uint4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x4(long4 input) => (UInt2x4)(ulong4)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator quarter4(UInt2x4 input) => (quarter4)(byte4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator half4(UInt2x4 input) => (half4)(ushort4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float4(UInt2x4 input) => (float4)(int4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4(UInt2x4 input) => (double4)(int4)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x4(quarter4 input) => (UInt2x4)(byte4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x4(half4 input) => (UInt2x4)(ushort4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x4(float4 input) => (UInt2x4)(int4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x4(double4 input) => (UInt2x4)(int4)input;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator ++ (UInt2x4 value) => value + 1;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator -- (UInt2x4 value) => value - 1;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator + (UInt2x4 left, UInt2x4 right) => new UInt2x4 { Bits = SWAR.Add<UInt2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator + (UInt2x4 left, uint right) => left + new UInt2x4((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator + (uint left, UInt2x4 right) => right + left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator - (UInt2x4 left, UInt2x4 right) => new UInt2x4 { Bits = SWAR.Sub<UInt2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator - (UInt2x4 left, uint right) => left - new UInt2x4((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator - (uint left, UInt2x4 right) => new UInt2x4((byte)left) - right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator * (UInt2x4 left, UInt2x4 right) => new UInt2x4 { Bits = SWAR.Mul<UInt2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator * (UInt2x4 left, uint right)
        {
            if (SWAR.ConstMul<UInt2>(left.Bits, (byte)right, out byte constMul))
            {
                return new UInt2x4 { Bits = constMul };
            }
        
            return left * new UInt2x4((byte)right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator * (uint left, UInt2x4 right) => right * left;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator / (UInt2x4 left, UInt2x4 right) => new UInt2x4 { Bits = SWAR.DivRem<UInt2>(left.Bits, right.Bits, out _) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator / (UInt2x4 left, uint right)
        {
            if (SWAR.ConstDiv<UInt2>(left.Bits, (sbyte)right, out byte constDiv))
            {
                return new UInt2x4 { Bits = constDiv };
            }
        
            return left / new UInt2x4((byte)right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator / (uint left, UInt2x4 right) => new UInt2x4((byte)left) / right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator % (UInt2x4 left, UInt2x4 right)
        {
            SWAR.DivRem<UInt2>(left.Bits, right.Bits, out byte rem);

            return new UInt2x4 { Bits = rem};
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator % (UInt2x4 left, uint right)
        {
            if (SWAR.ConstRem<UInt2>(left.Bits, (sbyte)right, out byte constRem))
            {
                return new UInt2x4 { Bits = constRem };
            }
        
            return left % new UInt2x4((byte)right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator % (uint left, UInt2x4 right) => new UInt2x4((byte)left) % right;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator << (UInt2x4 left, int right) => new UInt2x4 { Bits = SWAR.ShiftLeftLogical<UInt2>(left.Bits, right) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator >> (UInt2x4 left, int right) => new UInt2x4 { Bits = SWAR.ShiftRightLogical<UInt2>(left.Bits, right) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator ~ (UInt2x4 value) => new UInt2x4{ Bits = (byte)(~value.Bits) };
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator ^ (UInt2x4 left, UInt2x4 right) => new UInt2x4{ Bits = (byte)(left.Bits ^ right.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator ^ (UInt2x4 left, uint right) => left ^ new UInt2x4((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator ^ (uint left, UInt2x4 right) => right ^ left;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator & (UInt2x4 left, UInt2x4 right) => new UInt2x4{ Bits = (byte)(left.Bits & right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator & (UInt2x4 left, uint right) => left & new UInt2x4((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator & (uint left, UInt2x4 right) => right & left;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator | (UInt2x4 left, UInt2x4 right) => new UInt2x4{ Bits = (byte)(left.Bits | right.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator | (UInt2x4 left, uint right) => left | new UInt2x4((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator | (uint left, UInt2x4 right) => right | left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator == (UInt2x4 left, UInt2x4 right) => new UInt2x4 { Bits = SWAR.Equals<UInt2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator == (UInt2x4 left, uint right) => left == new UInt2x4((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator == (uint left, UInt2x4 right) => right == left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator != (UInt2x4 left, UInt2x4 right) => new UInt2x4 { Bits = SWAR.NotEquals<UInt2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator != (UInt2x4 left, uint right) => left != new UInt2x4((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator != (uint left, UInt2x4 right) => right != left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator < (UInt2x4 left, UInt2x4 right) => new UInt2x4 { Bits = SWAR.LessThan<UInt2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator < (UInt2x4 left, uint right) => left < new UInt2x4((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator < (uint left, UInt2x4 right) => right > left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator > (UInt2x4 left, UInt2x4 right) => new UInt2x4 { Bits = SWAR.GreaterThan<UInt2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator > (UInt2x4 left, uint right) => left > new UInt2x4((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator > (uint left, UInt2x4 right) => right < left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator <= (UInt2x4 left, UInt2x4 right) => new UInt2x4 { Bits = SWAR.LessThanOrEqual<UInt2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator <= (UInt2x4 left, uint right) => left <= new UInt2x4((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator <= (uint left, UInt2x4 right) => right >= left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator >= (UInt2x4 left, UInt2x4 right) => new UInt2x4 { Bits = SWAR.GreaterThanOrEqual<UInt2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator >= (UInt2x4 left, uint right) => left >= new UInt2x4((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator >= (uint left, UInt2x4 right) => right <= left;

        
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
                Bits = (byte)BitFieldHelper.Set<UInt2>(Bits, (int)value, default(UInt2).Bits * index, default(UInt2).Bits * Length);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly UInt2x4 SetReplicate(int index, int numNumbers, uint value)
        {
            return new UInt2x4 { Bits = (byte)BitFieldHelper.SetReplicate<UInt2>(Bits, (int)value, numNumbers, default(UInt2).Bits * index, default(UInt2).Bits * Length) };
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(UInt2x4 other)
        {
            return this.Bits == other.Bits;
        }

        public override readonly bool Equals(object obj)
        {
            return obj is UInt2x4 converted && this.Equals(converted);
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
            return new ArrayEnumerator<UInt2x4, uint>(this);
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<UInt2x4, uint>(this);
        }
    }
}