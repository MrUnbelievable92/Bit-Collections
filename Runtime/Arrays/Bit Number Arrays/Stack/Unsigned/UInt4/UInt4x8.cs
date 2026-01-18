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
    unsafe public struct UInt4x8 : IArray<uint>, IEquatable<UInt4x8>
    {
        public uint Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x8(byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7)
        {
Assert.IsNotGreater(x0,  UInt4.MaxValue);
Assert.IsNotGreater(x1,  UInt4.MaxValue);
Assert.IsNotGreater(x2,  UInt4.MaxValue);
Assert.IsNotGreater(x3,  UInt4.MaxValue);
Assert.IsNotGreater(x4,  UInt4.MaxValue);
Assert.IsNotGreater(x5,  UInt4.MaxValue);
Assert.IsNotGreater(x6,  UInt4.MaxValue);
//Assert.IsNotGreater(x7,  UInt4.MaxValue);

            Bits = (((uint)x0 << (0 * default(UInt4).Bits))
                  |  ((uint)x1 << (1 * default(UInt4).Bits))
                  |  ((uint)x2 << (2 * default(UInt4).Bits))
                  |  ((uint)x3 << (3 * default(UInt4).Bits))
                  |  ((uint)x4 << (4 * default(UInt4).Bits))
                  |  ((uint)x5 << (5 * default(UInt4).Bits))
                  |  ((uint)x6 << (6 * default(UInt4).Bits))
                  |  ((uint)x7 << (7 * default(UInt4).Bits)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x8(byte x0_4)
        {
            Bits = SWAR.Broadcast32<UInt4>(x0_4);
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
        public static implicit operator UInt5x8(UInt4x8 input) => new UInt5x8 { Bits = (UInt40)PackUnpack.UpCast64<UInt4, UInt5>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt6x8(UInt4x8 input) => new UInt6x8 { Bits = (UInt48)PackUnpack.UpCast64<UInt4, UInt6>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt7x8(UInt4x8 input) => new UInt7x8 { Bits = (UInt56)PackUnpack.UpCast64<UInt4, UInt7>(input.Bits) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x8(UInt5x8 input) => new UInt4x8 { Bits = (uint)PackUnpack.DownCast<UInt5, UInt4>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x8(UInt6x8 input) => new UInt4x8 { Bits = (uint)PackUnpack.DownCast<UInt6, UInt4>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x8(UInt7x8 input) => new UInt4x8 { Bits = (uint)PackUnpack.DownCast<UInt7, UInt4>(input.Bits) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator byte8(UInt4x8 input) => PackUnpack.BitIntArrayToByte8<UInt4>(input.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ushort8(UInt4x8 input) => PackUnpack.BitIntArrayToUShort8<UInt4>(input.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint8(UInt4x8 input) => PackUnpack.BitIntArrayToUInt8<UInt4>(input.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator sbyte8(UInt4x8 input) => (sbyte8)(byte8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator short8(UInt4x8 input) => (short8)(ushort8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int8(UInt4x8 input) => (int8)(uint8)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x8(byte8 input) => new UInt4x8 { Bits = (uint)PackUnpack.DownCast<UInt4>(input) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x8(ushort8 input) => new UInt4x8 { Bits = (uint)PackUnpack.DownCast<UInt4>(input) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x8(uint8 input) => new UInt4x8 { Bits = (uint)PackUnpack.DownCast<UInt4>(input) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x8(sbyte8 input) => (UInt4x8)(byte8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x8(short8 input) => (UInt4x8)(ushort8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x8(int8 input) => (UInt4x8)(uint8)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator quarter8(UInt4x8 input) => (quarter8)(byte8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator half8(UInt4x8 input) => (half8)(ushort8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float8(UInt4x8 input) => (float8)(int8)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x8(quarter8 input) => (UInt4x8)(byte8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x8(half8 input) => (UInt4x8)(ushort8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x8(float8 input) => (UInt4x8)(int8)input;

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator ++ (UInt4x8 value) => value + 1;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator -- (UInt4x8 value) => value - 1;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator + (UInt4x8 left, UInt4x8 right) => new UInt4x8 { Bits = SWAR.Add<UInt4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator + (UInt4x8 left, uint right) => left + new UInt4x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator + (uint left, UInt4x8 right) => right + left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator - (UInt4x8 left, UInt4x8 right) => new UInt4x8 { Bits = SWAR.Sub<UInt4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator - (UInt4x8 left, uint right) => left - new UInt4x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator - (uint left, UInt4x8 right) => new UInt4x8((byte)left) - right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator * (UInt4x8 left, UInt4x8 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return new UInt4x8 { Bits = (uint)PackUnpack.DownCast<UInt4>(PackUnpack.BitIntArrayToByte8<UInt4>(left.Bits) * PackUnpack.BitIntArrayToByte8<UInt4>(right.Bits)) };
            }

            return new UInt4x8 { Bits = SWAR.Mul<UInt4>(left.Bits, right.Bits) };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator * (UInt4x8 left, uint right)
        {
            if (SWAR.ConstMul<UInt4>(left.Bits, right, out uint constMul))
            {
                return new UInt4x8 { Bits = constMul };
            }
            
            return left * new UInt4x8((byte)right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator * (uint left, UInt4x8 right) => right * left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator / (UInt4x8 left, UInt4x8 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return new UInt4x8 { Bits = (uint)PackUnpack.DownCast<UInt4>(PackUnpack.BitIntArrayToByte8<UInt4>(left.Bits) / PackUnpack.BitIntArrayToByte8<UInt4>(right.Bits)) };
            }
            
            return new UInt4x8{ Bits = SWAR.DivRem<UInt4>(left.Bits, right.Bits, out _)};
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator / (UInt4x8 left, uint right)
        {
            if (SWAR.ConstDiv<UInt4>(left.Bits, (int)right, out uint constDiv))
            {
                return new UInt4x8 { Bits = constDiv };
            }

            if (BurstArchitecture.IsSIMDSupported)
            {
                return new UInt4x8 { Bits = (uint)PackUnpack.DownCast<UInt4>(PackUnpack.BitIntArrayToByte8<UInt4>(left.Bits) / (byte)right) };
            }
            
            return new UInt4x8{ Bits = SWAR.DivRem<UInt4>(left.Bits, new UInt4x8((byte)right).Bits, out _)};
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator / (uint left, UInt4x8 right) => new UInt4x8((byte)left) / right;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator % (UInt4x8 left, UInt4x8 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return new UInt4x8 { Bits = (uint)PackUnpack.DownCast<UInt4>(PackUnpack.BitIntArrayToByte8<UInt4>(left.Bits) % PackUnpack.BitIntArrayToByte8<UInt4>(right.Bits)) };
            }

            SWAR.DivRem<UInt4>(left.Bits, right.Bits, out uint r);

            return new UInt4x8 { Bits = r };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator % (UInt4x8 left, uint right)
        {
            if (SWAR.ConstRem<UInt4>(left.Bits, (int)right, out uint constRem))
            {
                return new UInt4x8 { Bits = constRem };
            }

            if (BurstArchitecture.IsSIMDSupported)
            {
                return new UInt4x8 { Bits = (uint)PackUnpack.DownCast<UInt4>(PackUnpack.BitIntArrayToByte8<UInt4>(left.Bits) % (byte)right) };
            }

            SWAR.DivRem<UInt4>(left.Bits, new UInt4x8((byte)right).Bits, out uint r);

            return new UInt4x8 { Bits = r };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator % (uint left, UInt4x8 right) => new UInt4x8((byte)left) % right;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator << (UInt4x8 left, int right) => new UInt4x8 { Bits = SWAR.ShiftLeftLogical<UInt4>(left.Bits, right) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator >> (UInt4x8 left, int right) => new UInt4x8 { Bits = SWAR.ShiftRightLogical<UInt4>(left.Bits, right) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator ~ (UInt4x8 value) => new UInt4x8{ Bits = ~value.Bits };
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator ^ (UInt4x8 left, UInt4x8 right) => new UInt4x8{ Bits = left.Bits ^ right.Bits };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator ^ (UInt4x8 left, uint right) => left ^ new UInt4x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator ^ (uint left, UInt4x8 right) => right ^ left;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator & (UInt4x8 left, UInt4x8 right) => new UInt4x8{ Bits = left.Bits & right.Bits };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator & (UInt4x8 left, uint right) => left & new UInt4x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator & (uint left, UInt4x8 right) => right & left;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator | (UInt4x8 left, UInt4x8 right) => new UInt4x8{ Bits = left.Bits | right.Bits };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator | (UInt4x8 left, uint right) => left | new UInt4x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator | (uint left, UInt4x8 right) => right | left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator == (UInt4x8 left, UInt4x8 right) => new UInt4x8 { Bits = SWAR.Equals<UInt4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator == (UInt4x8 left, uint right) => left == new UInt4x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator == (uint left, UInt4x8 right) => right == left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator != (UInt4x8 left, UInt4x8 right) => new UInt4x8 { Bits = SWAR.NotEquals<UInt4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator != (UInt4x8 left, uint right) => left != new UInt4x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator != (uint left, UInt4x8 right) => right != left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator < (UInt4x8 left, UInt4x8 right) => new UInt4x8 { Bits = SWAR.LessThan<UInt4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator < (UInt4x8 left, uint right) => left < new UInt4x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator < (uint left, UInt4x8 right) => right > left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator > (UInt4x8 left, UInt4x8 right) => new UInt4x8 { Bits = SWAR.GreaterThan<UInt4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator > (UInt4x8 left, uint right) => left > new UInt4x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator > (uint left, UInt4x8 right) => right < left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator <= (UInt4x8 left, UInt4x8 right) => new UInt4x8 { Bits = SWAR.LessThanOrEqual<UInt4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator <= (UInt4x8 left, uint right) => left <= new UInt4x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator <= (uint left, UInt4x8 right) => right >= left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator >= (UInt4x8 left, UInt4x8 right) => new UInt4x8 { Bits = SWAR.GreaterThanOrEqual<UInt4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator >= (UInt4x8 left, uint right) => left >= new UInt4x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x8 operator >= (uint left, UInt4x8 right) => right <= left;

        
        public uint this[int index]
        {
            [return: AssumeRange((ulong)UInt4.MinValue, (ulong)UInt4.MaxValue)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (uint)BitFieldHelper.Get<UInt4>(Bits, default(UInt4).Bits * index, default(UInt4).Bits * Length);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Bits = BitFieldHelper.Set<UInt4>(Bits, (int)value, default(UInt4).Bits * index, default(UInt4).Bits * Length);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly UInt4x8 SetReplicate(int index, int numNumbers, uint value)
        {
            return new UInt4x8 { Bits = BitFieldHelper.SetReplicate<UInt4>(Bits, (int)value, numNumbers, default(UInt4).Bits * index, default(UInt4).Bits * Length) };
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(UInt4x8 other)
        {
            return this.Bits == other.Bits;
        }

        public override readonly bool Equals(object obj)
        {
            return obj is UInt4x8 converted && this.Equals(converted);
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
            return new ArrayEnumerator<UInt4x8, uint>(this);
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<UInt4x8, uint>(this);
        }
    }
}