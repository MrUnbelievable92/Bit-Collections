using DevTools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;
using Unity.Mathematics;
using MaxMath;
using MaxMath.Intrinsics;
using static MaxMath.maxmath;

namespace BitCollections
{
    [Serializable]
    unsafe public struct UInt12x2 : IArray<uint>, IEquatable<UInt12x2>
    {
        public UInt24 Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt12x2(ushort xy)
            : this(xy, xy)
        {

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt12x2(ushort x, ushort y)
        {
Assert.IsNotGreater(x, UInt12.MaxValue);
//Assert.IsNotGreater(y, UInt12.MaxValue);

            Bits = ((uint)x << (0 * default(UInt12).Bits))
                  | ((uint)y << (1 * default(UInt12).Bits));
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
        public static implicit operator UInt20x2(UInt12x2 input) => new UInt20x2 { Bits = (UInt40)PackUnpack.UpCast64<UInt12, UInt20>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt28x2(UInt12x2 input) => new UInt28x2 { Bits = (UInt56)PackUnpack.UpCast64<UInt12, UInt28>(input.Bits) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt12x2(UInt20x2 input) => new UInt12x2 { Bits = (UInt24)PackUnpack.DownCast<UInt20, UInt12>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt12x2(UInt28x2 input) => new UInt12x2 { Bits = (UInt24)PackUnpack.DownCast<UInt28, UInt12>(input.Bits) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte2(UInt12x2 input) => PackUnpack.DownCast<UInt12, UInt8>(input.Bits).GetField<uint, byte2>(0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ushort2(UInt12x2 input) => PackUnpack.BitIntArrayToUShort2<UInt12>(input.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint2(UInt12x2 input) => PackUnpack.BitIntArrayToUInt2<UInt12>(input.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong2(UInt12x2 input) => PackUnpack.BitIntArrayToULong2<UInt12>(input.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte2(UInt12x2 input) => (sbyte2)(byte2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator short2(UInt12x2 input) => (short2)(ushort2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int2(UInt12x2 input) => (int2)(uint2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long2(UInt12x2 input) => (long2)(ulong2)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt12x2(byte2 input) => PackUnpack.UpCast32<UInt8, UInt12>(input.Reinterpret<byte2, ushort>()).GetField<uint, UInt12x2>(0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt12x2(ushort2 input) => new UInt12x2 { Bits = (UInt24)PackUnpack.DownCast<UInt12>(input) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt12x2(uint2 input) => new UInt12x2 { Bits = (UInt24)PackUnpack.DownCast<UInt12>(input) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt12x2(ulong2 input) => new UInt12x2 { Bits = (UInt24)PackUnpack.DownCast<UInt12>(input) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt12x2(sbyte2 input) => (UInt12x2)(byte2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt12x2(short2 input) => (UInt12x2)(ushort2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt12x2(int2 input) => (UInt12x2)(uint2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt12x2(long2 input) => (UInt12x2)(ulong2)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter2(UInt12x2 input) => (quarter2)(byte2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator half2(UInt12x2 input) => (half2)(ushort2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2(UInt12x2 input) => (float2)(int2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2(UInt12x2 input) => (double2)(int2)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt12x2(quarter2 input) => (UInt12x2)(byte2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt12x2(half2 input) => (UInt12x2)(ushort2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt12x2(float2 input) => (UInt12x2)(int2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt12x2(double2 input) => (UInt12x2)(int2)input;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator ++ (UInt12x2 value) => value + 1;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator -- (UInt12x2 value) => value - 1;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator + (UInt12x2 left, UInt12x2 right) => new UInt12x2 { Bits = SWAR.Add<UInt12>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator + (UInt12x2 left, uint right) => left + new UInt12x2((ushort)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator + (uint left, UInt12x2 right) => right + left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator - (UInt12x2 left, UInt12x2 right) => new UInt12x2 { Bits = SWAR.Sub<UInt12>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator - (UInt12x2 left, uint right) => left - new UInt12x2((ushort)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator - (uint left, UInt12x2 right) => new UInt12x2((ushort)left) - right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator * (UInt12x2 left, UInt12x2 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt12x2)((ushort2)left * right);
            }

            uint lo = left.Bits & bitmask32((uint)default(UInt12).Bits, 0u * (uint)default(UInt12).Bits);
            uint hi = left.Bits & bitmask32((uint)default(UInt12).Bits, 1u * (uint)default(UInt12).Bits);

            lo *= right[0];
            hi *= right[1];

            return new UInt12x2 { Bits = bits_select(hi, lo, bitmask32((uint)default(UInt12).Bits)) };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator * (UInt12x2 left, uint right)
        {
            if (SWAR.ConstMul<UInt12>(left.Bits, right, out uint constMul))
            {
                return new UInt12x2 { Bits = constMul };
            }
            
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt12x2)((ushort2)left * (ushort)right);
            }

            uint lo = left.Bits & bitmask32((uint)default(UInt12).Bits, 0u * (uint)default(UInt12).Bits);
            uint hi = left.Bits & bitmask32((uint)default(UInt12).Bits, 1u * (uint)default(UInt12).Bits);

            lo *= right;
            hi *= right;

            return new UInt12x2 { Bits = bits_select(hi, lo, bitmask32((uint)default(UInt12).Bits)) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator * (uint left, UInt12x2 right) => right * left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator / (UInt12x2 left, UInt12x2 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt12x2)((ushort2)left / right);
            }

            uint lo = left.Bits & bitmask32((uint)default(UInt12).Bits, 0u * (uint)default(UInt12).Bits);
            uint hi = left.Bits & bitmask32((uint)default(UInt12).Bits, 1u * (uint)default(UInt12).Bits);

            lo /= right[0];
            hi /= right[1];

            return new UInt12x2 { Bits = bits_select(hi, lo, bitmask32((uint)default(UInt12).Bits)) };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator / (UInt12x2 left, uint right)
        {
            if (SWAR.ConstDiv<UInt12>(left.Bits, (int)right, out uint constDiv))
            {
                return new UInt12x2 { Bits = constDiv };
            }
            
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt12x2)((ushort2)left / (ushort)right);
            }

            uint lo = left.Bits & bitmask32((uint)default(UInt12).Bits, 0u * (uint)default(UInt12).Bits);
            uint hi = left.Bits & bitmask32((uint)default(UInt12).Bits, 1u * (uint)default(UInt12).Bits);

            lo /= right;
            hi /= right;

            return new UInt12x2 { Bits = bits_select(hi, lo, bitmask32((uint)default(UInt12).Bits)) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator / (uint left, UInt12x2 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt12x2)((ushort2)left / right);
            }
            
            uint lo = left << (0 * default(UInt12).Bits);
            uint hi = left << (1 * default(UInt12).Bits);

            lo /= right[0];
            hi /= right[1];

            return new UInt12x2 { Bits = bits_select(hi, lo, bitmask32((uint)default(UInt12).Bits)) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator % (UInt12x2 left, UInt12x2 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt12x2)((ushort2)left % right);
            }
            
            return new UInt12x2((ushort)(left[0] % right[0]),
                                (ushort)(left[1] % right[1]));
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator % (UInt12x2 left, uint right)
        {
            if (SWAR.ConstRem<UInt12>(left.Bits, (int)right, out uint constRem))
            {
                return new UInt12x2 { Bits = constRem };
            }
            
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt12x2)((ushort2)left % (ushort)right);
            }
            
            return new UInt12x2((ushort)(left[0] % right),
                                (ushort)(left[1] % right));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator % (uint left, UInt12x2 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt12x2)((ushort2)left % right);
            }

            return new UInt12x2((ushort)(left % right[0]),
                                (ushort)(left % right[1]));
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator << (UInt12x2 left, int right) => new UInt12x2 { Bits = SWAR.ShiftLeftLogical<UInt12>(left.Bits, right) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator >> (UInt12x2 left, int right) => new UInt12x2 { Bits = SWAR.ShiftRightLogical<UInt12>(left.Bits, right) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator ~ (UInt12x2 value) => new UInt12x2{ Bits = ~value.Bits };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator ^ (UInt12x2 left, UInt12x2 right) => new UInt12x2{ Bits = left.Bits ^ right.Bits };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator ^ (UInt12x2 left, uint right) => left ^ new UInt12x2((ushort)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator ^ (uint left, UInt12x2 right) => right ^ left;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator & (UInt12x2 left, UInt12x2 right) => new UInt12x2{ Bits = left.Bits & right.Bits };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator & (UInt12x2 left, uint right) => left & new UInt12x2((ushort)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator & (uint left, UInt12x2 right) => right & left;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator | (UInt12x2 left, UInt12x2 right) => new UInt12x2{ Bits = left.Bits | right.Bits };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator | (UInt12x2 left, uint right) => left | new UInt12x2((ushort)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator | (uint left, UInt12x2 right) => right | left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator == (UInt12x2 left, UInt12x2 right) => new UInt12x2 { Bits = SWAR.Equals<UInt12>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator == (UInt12x2 left, uint right) => left == new UInt12x2((ushort)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator == (uint left, UInt12x2 right) => right == left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator != (UInt12x2 left, UInt12x2 right) => new UInt12x2 { Bits = SWAR.NotEquals<UInt12>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator != (UInt12x2 left, uint right) => left != new UInt12x2((ushort)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator != (uint left, UInt12x2 right) => right != left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator < (UInt12x2 left, UInt12x2 right) => new UInt12x2 { Bits = SWAR.LessThan<UInt12>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator < (UInt12x2 left, uint right) => left < new UInt12x2((ushort)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator < (uint left, UInt12x2 right) => right > left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator > (UInt12x2 left, UInt12x2 right) => new UInt12x2 { Bits = SWAR.GreaterThan<UInt12>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator > (UInt12x2 left, uint right) => left > new UInt12x2((ushort)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator > (uint left, UInt12x2 right) => right < left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator <= (UInt12x2 left, UInt12x2 right) => new UInt12x2 { Bits = SWAR.LessThanOrEqual<UInt12>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator <= (UInt12x2 left, uint right) => left <= new UInt12x2((ushort)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator <= (uint left, UInt12x2 right) => right >= left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator >= (UInt12x2 left, UInt12x2 right) => new UInt12x2 { Bits = SWAR.GreaterThanOrEqual<UInt12>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator >= (UInt12x2 left, uint right) => left >= new UInt12x2((ushort)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x2 operator >= (uint left, UInt12x2 right) => right <= left;

        public uint this[int index]
        {
            [return: AssumeRange((ulong)UInt12.MinValue, (ulong)UInt12.MaxValue)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (uint)BitFieldHelper.Get<UInt12>(Bits, default(UInt12).Bits * index, default(UInt12).Bits * Length);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Bits = BitFieldHelper.Set<UInt12>(Bits, (int)value, default(UInt12).Bits * index, default(UInt12).Bits * Length);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly UInt12x2 SetReplicate(int index, int numNumbers, uint value)
        {
            return new UInt12x2 { Bits = BitFieldHelper.SetReplicate<UInt12>(Bits, (int)value, numNumbers, default(UInt12).Bits * index, default(UInt12).Bits * Length) };
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(UInt12x2 other)
        {
            return this.Bits == other.Bits;
        }

        public override readonly bool Equals(object obj)
        {
            return obj is UInt12x2 converted && this.Equals(converted);
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
            return new ArrayEnumerator<UInt12x2, uint>(this);
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<UInt12x2, uint>(this);
        }
    }
}