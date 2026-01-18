using DevTools;
using MaxMath;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;
using Unity.Mathematics;
using MaxMath.Intrinsics;

using static MaxMath.maxmath;

namespace BitCollections
{
    [Serializable]
    unsafe public struct UInt4x2 : IArray<uint>, IEquatable<UInt4x2>
    {
        public byte Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x2(byte xy)
            : this(xy, xy)
        {

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x2(byte x, byte y)
        {
Assert.IsNotGreater(x, UInt4.MaxValue);
//Assert.IsNotGreater(y, UInt4.MaxValue);

            Bits = (byte)((((uint)x << (0 * default(UInt4).Bits))
                         |  ((uint)y << (1 * default(UInt4).Bits))));
        }


        public readonly int Length => 2;


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


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt12x2(UInt4x2 input) => new UInt12x2 { Bits = (UInt24)PackUnpack.UpCast32<UInt4, UInt12>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt20x2(UInt4x2 input) => new UInt20x2 { Bits = (UInt40)PackUnpack.UpCast64<UInt4, UInt20>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt28x2(UInt4x2 input) => new UInt28x2 { Bits = (UInt56)PackUnpack.UpCast64<UInt4, UInt28>(input.Bits) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x2(UInt12x2 input) => new UInt4x2 { Bits = (byte)PackUnpack.DownCast<UInt12, UInt4>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x2(UInt20x2 input) => new UInt4x2 { Bits = (byte)PackUnpack.DownCast<UInt20, UInt4>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x2(UInt28x2 input) => new UInt4x2 { Bits = (byte)PackUnpack.DownCast<UInt28, UInt4>(input.Bits) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator byte2(UInt4x2 input) => PackUnpack.BitIntArrayToByte2<UInt4>(input.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ushort2(UInt4x2 input) => PackUnpack.UpCast32<UInt4, UInt16>(input.Bits).Reinterpret<uint, ushort2>();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint2(UInt4x2 input) => PackUnpack.UpCast64<UInt4, UInt32>(input.Bits).Reinterpret<ulong, uint2>();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong2(UInt4x2 input) => PackUnpack.BitIntArrayToULong2<UInt4>(input.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator sbyte2(UInt4x2 input) => (sbyte2)(byte2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator short2(UInt4x2 input) => (short2)(ushort2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int2(UInt4x2 input) => (int2)(uint2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long2(UInt4x2 input) => (long2)(ulong2)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x2(byte2 input) => new UInt4x2 { Bits = (byte)PackUnpack.DownCast<UInt4>(input) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x2(ushort2 input) => new UInt4x2 { Bits = (byte)PackUnpack.DownCast<UInt16, UInt4>(input.Reinterpret<ushort2, uint>()) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x2(uint2 input) => new UInt4x2 { Bits = (byte)PackUnpack.DownCast<UInt32, UInt4>(input.Reinterpret<uint2, ulong>()) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x2(ulong2 input) => new UInt4x2 { Bits = (byte)PackUnpack.DownCast<UInt4>(input) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x2(sbyte2 input) => (UInt4x2)(byte2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x2(short2 input) => (UInt4x2)(ushort2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x2(int2 input) => (UInt4x2)(uint2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x2(long2 input) => (UInt4x2)(ulong2)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator quarter2(UInt4x2 input) => (quarter2)(byte2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator half2(UInt4x2 input) => (half2)(ushort2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2(UInt4x2 input) => (float2)(int2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2(UInt4x2 input) => (double2)(int2)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x2(quarter2 input) => (UInt4x2)(byte2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x2(half2 input) => (UInt4x2)(ushort2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x2(float2 input) => (UInt4x2)(int2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x2(double2 input) => (UInt4x2)(int2)input;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator ++ (UInt4x2 value) => value + 1;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator -- (UInt4x2 value) => value - 1;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator + (UInt4x2 left, UInt4x2 right) => new UInt4x2 { Bits = SWAR.Add<UInt4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator + (UInt4x2 left, uint right) => left + new UInt4x2((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator + (uint left, UInt4x2 right) => right + left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator - (UInt4x2 left, UInt4x2 right) => new UInt4x2 { Bits = SWAR.Sub<UInt4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator - (UInt4x2 left, uint right) => left - new UInt4x2((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator - (uint left, UInt4x2 right) => new UInt4x2((byte)left) - right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator * (UInt4x2 left, UInt4x2 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return new UInt4x2 { Bits = (byte)PackUnpack.DownCast<UInt4>(PackUnpack.BitIntArrayToUShort2<UInt4>(left.Bits) * PackUnpack.BitIntArrayToUShort2<UInt4>(right.Bits)) };
            }
            
            uint x0  = left.Bits & bitmask32((uint)default(UInt4).Bits, 0u * (uint)default(UInt4).Bits);
            uint x1  = left.Bits & bitmask32((uint)default(UInt4).Bits, 1u * (uint)default(UInt4).Bits);
            
            x0 *= right[0];
            x1 *= right[1];

            uint blend0 = bits_select(x1,  x0,  bitmask32((uint)default(UInt4).Bits));

            return new UInt4x2 { Bits = (byte)blend0 };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator * (UInt4x2 left, uint right)
        {
            if (SWAR.ConstMul<UInt4>(left.Bits, right, out uint constMul))
            {
                return new UInt4x2 { Bits = (byte)constMul };
            }
        
            if (BurstArchitecture.IsSIMDSupported)
            {
                return new UInt4x2 { Bits = (byte)PackUnpack.DownCast<UInt4>(PackUnpack.BitIntArrayToUShort2<UInt4>(left.Bits) * (ushort)right) };
            }
            
            uint x0  = left.Bits & bitmask32((uint)default(UInt4).Bits, 0u * (uint)default(UInt4).Bits);
            uint x1  = left.Bits & bitmask32((uint)default(UInt4).Bits, 1u * (uint)default(UInt4).Bits);
            
            x0 *= right;
            x1 *= right;

            uint blend0 = bits_select(x1,  x0,  bitmask32((uint)default(UInt4).Bits));

            return new UInt4x2 { Bits = (byte)blend0 };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator * (uint left, UInt4x2 right) => right * left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator / (UInt4x2 left, UInt4x2 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return new UInt4x2 { Bits = (byte)PackUnpack.DownCast<UInt4>(PackUnpack.BitIntArrayToUShort2<UInt4>(left.Bits) / PackUnpack.BitIntArrayToUShort2<UInt4>(right.Bits)) };
            }

            uint x0  = left.Bits & bitmask32((uint)default(UInt4).Bits, 0u * (uint)default(UInt4).Bits);
            uint x1  = left.Bits & bitmask32((uint)default(UInt4).Bits, 1u * (uint)default(UInt4).Bits);
            
            x0 /= right[0];
            x1 /= right[1];

            uint blend0 = bits_select(x1,  x0,  bitmask32((uint)default(UInt4).Bits));

            return new UInt4x2 { Bits = (byte)blend0 };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator / (UInt4x2 left, uint right)
        {
            if (SWAR.ConstDiv<UInt4>(left.Bits, (sbyte)right, out byte constDiv))
            {
                return new UInt4x2 { Bits = constDiv };
            }
        
            if (BurstArchitecture.IsSIMDSupported)
            {
                return new UInt4x2 { Bits = (byte)PackUnpack.DownCast<UInt4>(PackUnpack.BitIntArrayToUShort2<UInt4>(left.Bits) / (ushort)right) };
            }

            uint x0  = left.Bits & bitmask32((uint)default(UInt4).Bits, 0u * (uint)default(UInt4).Bits);
            uint x1  = left.Bits & bitmask32((uint)default(UInt4).Bits, 1u * (uint)default(UInt4).Bits);
            
            x0 /= right;
            x1 /= right;

            uint blend0 = bits_select(x1,  x0,  bitmask32((uint)default(UInt4).Bits));

            return new UInt4x2 { Bits = (byte)blend0 };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator / (uint left, UInt4x2 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return new UInt4x2 { Bits = (byte)PackUnpack.DownCast<UInt4>((ushort)left / PackUnpack.BitIntArrayToUShort2<UInt4>(right.Bits)) };
            }
            else
            {
                uint x0 = left << (0 * default(UInt4).Bits);
                uint x1 = left << (1 * default(UInt4).Bits);
        
                x0 /= right[0];
                x1 /= right[1];

                uint blend0 = bits_select(x1, x0, bitmask32((uint)default(UInt4).Bits));

                return new UInt4x2 { Bits = (byte)blend0 };
            }
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator % (UInt4x2 left, UInt4x2 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return new UInt4x2 { Bits = (byte)PackUnpack.DownCast<UInt4>(PackUnpack.BitIntArrayToByte2<UInt4>(left.Bits) % PackUnpack.BitIntArrayToByte2<UInt4>(right.Bits)) };
            }

            return new UInt4x2((byte)(left[0] % right[0]),
                               (byte)(left[1] % right[1]));
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator % (UInt4x2 left, uint right)
        {
            if (SWAR.ConstRem<UInt4>(left.Bits, (sbyte)right, out byte constRem))
            {
                return new UInt4x2 { Bits = constRem };
            }

            if (BurstArchitecture.IsSIMDSupported)
            {
                return new UInt4x2 { Bits = (byte)PackUnpack.DownCast<UInt4>(PackUnpack.BitIntArrayToByte2<UInt4>(left.Bits) % (byte)right) };
            }
            
            return new UInt4x2((byte)(left[0] % right),
                               (byte)(left[1] % right));
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator % (uint left, UInt4x2 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return new UInt4x2 { Bits = (byte)PackUnpack.DownCast<UInt4>((byte)left % PackUnpack.BitIntArrayToByte2<UInt4>(right.Bits)) };
            }
            
            return new UInt4x2((byte)(left % right[0]),
                               (byte)(left % right[1]));
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator << (UInt4x2 left, int right) => new UInt4x2 { Bits = SWAR.ShiftLeftLogical<UInt4>(left.Bits, right) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator >> (UInt4x2 left, int right) => new UInt4x2 { Bits = SWAR.ShiftRightLogical<UInt4>(left.Bits, right) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator ~ (UInt4x2 value) => new UInt4x2{ Bits = (byte)(~value.Bits) };
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator ^ (UInt4x2 left, UInt4x2 right) => new UInt4x2{ Bits = (byte)(left.Bits ^ right.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator ^ (UInt4x2 left, uint right) => left ^ new UInt4x2((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator ^ (uint left, UInt4x2 right) => right ^ left;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator & (UInt4x2 left, UInt4x2 right) => new UInt4x2{ Bits = (byte)(left.Bits & right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator & (UInt4x2 left, uint right) => left & new UInt4x2((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator & (uint left, UInt4x2 right) => right & left;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator | (UInt4x2 left, UInt4x2 right) => new UInt4x2{ Bits = (byte)(left.Bits | right.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator | (UInt4x2 left, uint right) => left | new UInt4x2((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator | (uint left, UInt4x2 right) => right | left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator == (UInt4x2 left, UInt4x2 right) => new UInt4x2 { Bits = SWAR.Equals<UInt4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator == (UInt4x2 left, uint right) => left == new UInt4x2((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator == (uint left, UInt4x2 right) => right == left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator != (UInt4x2 left, UInt4x2 right) => new UInt4x2 { Bits = SWAR.NotEquals<UInt4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator != (UInt4x2 left, uint right) => left != new UInt4x2((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator != (uint left, UInt4x2 right) => right != left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator < (UInt4x2 left, UInt4x2 right) => new UInt4x2 { Bits = SWAR.LessThan<UInt4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator < (UInt4x2 left, uint right) => left < new UInt4x2((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator < (uint left, UInt4x2 right) => right > left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator > (UInt4x2 left, UInt4x2 right) => new UInt4x2 { Bits = SWAR.GreaterThan<UInt4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator > (UInt4x2 left, uint right) => left > new UInt4x2((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator > (uint left, UInt4x2 right) => right < left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator <= (UInt4x2 left, UInt4x2 right) => new UInt4x2 { Bits = SWAR.LessThanOrEqual<UInt4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator <= (UInt4x2 left, uint right) => left <= new UInt4x2((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator <= (uint left, UInt4x2 right) => right >= left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator >= (UInt4x2 left, UInt4x2 right) => new UInt4x2 { Bits = SWAR.GreaterThanOrEqual<UInt4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator >= (UInt4x2 left, uint right) => left >= new UInt4x2((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator >= (uint left, UInt4x2 right) => right <= left;

        
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
                Bits = (byte)BitFieldHelper.Set<UInt4>(Bits, (int)value, default(UInt4).Bits * index, default(UInt4).Bits * Length);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly UInt4x2 SetReplicate(int index, int numNumbers, uint value)
        {
            return new UInt4x2 { Bits = (byte)BitFieldHelper.SetReplicate<UInt4>(Bits, (int)value, numNumbers, default(UInt4).Bits * index, default(UInt4).Bits * Length) };
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(UInt4x2 other)
        {
            return this.Bits == other.Bits;
        }

        public override readonly bool Equals(object obj)
        {
            return obj is UInt4x2 converted && this.Equals(converted);
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
            return new ArrayEnumerator<UInt4x2, uint>(this);
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<UInt4x2, uint>(this);
        }
    }
}