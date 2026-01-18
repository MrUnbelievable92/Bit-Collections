using DevTools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;
using Unity.Mathematics;
using MaxMath;

using static MaxMath.maxmath;
using MaxMath.Intrinsics;

namespace BitCollections
{
    [Serializable]
    unsafe public struct UInt28x2 : IArray<uint>, IEquatable<UInt28x2>
    {
        public UInt56 Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt28x2(uint xy)
            : this(xy, xy)
        {

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt28x2(uint x, uint y)
        {
Assert.IsNotGreater(x, UInt28.MaxValue);
//Assert.IsNotGreater(y, UInt28.MaxValue);

            Bits = (((ulong)x << (0 * default(UInt28).Bits))
                  |  ((ulong)y << (1 * default(UInt28).Bits)));
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
        public static explicit operator byte2(UInt28x2 input) => PackUnpack.DownCast<UInt28, UInt8>(input.Bits).GetField<ulong, byte2>(0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort2(UInt28x2 input) => PackUnpack.DownCast<UInt28, UInt16>(input.Bits).GetField<ulong, ushort2>(0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint2(UInt28x2 input) => PackUnpack.BitIntArrayToUInt2<UInt28>(input.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong2(UInt28x2 input) => PackUnpack.BitIntArrayToULong2<UInt28>(input.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte2(UInt28x2 input) => (sbyte2)(byte2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short2(UInt28x2 input) => (short2)(ushort2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int2(UInt28x2 input) => (int2)(uint2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long2(UInt28x2 input) => (long2)(ulong2)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt28x2(byte2 input) => new UInt28x2 { Bits = (UInt56)PackUnpack.UpCast64<UInt8, UInt28>(input.Reinterpret<byte2, ushort>()) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt28x2(ushort2 input) => new UInt28x2 { Bits = (UInt56)PackUnpack.UpCast64<UInt16, UInt28>(input.Reinterpret<ushort2, uint>()) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt28x2(uint2 input) => new UInt28x2 { Bits = (UInt56)PackUnpack.DownCast<UInt28>(input) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt28x2(ulong2 input) => new UInt28x2 { Bits = (UInt56)PackUnpack.DownCast<UInt28>(input) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt28x2(sbyte2 input) => (UInt28x2)(byte2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt28x2(short2 input) => (UInt28x2)(ushort2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt28x2(int2 input) => (UInt28x2)(uint2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt28x2(long2 input) => (UInt28x2)(ulong2)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter2(UInt28x2 input) => (quarter2)(byte2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half2(UInt28x2 input) => (half2)(ushort2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2(UInt28x2 input) => (float2)(int2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2(UInt28x2 input) => (double2)(int2)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt28x2(quarter2 input) => (UInt28x2)(byte2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt28x2(half2 input) => (UInt28x2)(ushort2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt28x2(float2 input) => (UInt28x2)(int2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt28x2(double2 input) => (UInt28x2)(int2)input;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator ++ (UInt28x2 value) => value + 1;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator -- (UInt28x2 value) => value - 1;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator + (UInt28x2 left, UInt28x2 right) => new UInt28x2 { Bits = SWAR.Add<UInt28>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator + (UInt28x2 left, uint right) => left + new UInt28x2((uint)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator + (uint left, UInt28x2 right) => right + left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator - (UInt28x2 left, UInt28x2 right) => new UInt28x2 { Bits = SWAR.Sub<UInt28>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator - (UInt28x2 left, uint right) => left - new UInt28x2((uint)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator - (uint left, UInt28x2 right) => new UInt28x2((uint)left) - right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator * (UInt28x2 left, UInt28x2 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt28x2)((uint2)left * right);
            }

            ulong lo = left.Bits & bitmask64((ulong)default(UInt28).Bits, 0u * (ulong)default(UInt28).Bits);
            ulong hi = left.Bits & bitmask64((ulong)default(UInt28).Bits, 1u * (ulong)default(UInt28).Bits);

            lo *= right[0];
            hi *= right[1];

            return new UInt28x2 { Bits = bits_select(hi, lo, bitmask64((ulong)default(UInt28).Bits)) };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator * (UInt28x2 left, uint right)
        {
            if (SWAR.ConstMul<UInt28>(left.Bits, right, out ulong constMul))
            {
                return new UInt28x2 { Bits = constMul };
            }
            
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt28x2)((uint2)left * (uint)right);
            }

            ulong lo = left.Bits & bitmask64((ulong)default(UInt28).Bits, 0u * (ulong)default(UInt28).Bits);
            ulong hi = left.Bits & bitmask64((ulong)default(UInt28).Bits, 1u * (ulong)default(UInt28).Bits);

            lo *= right;
            hi *= right;

            return new UInt28x2 { Bits = bits_select(hi, lo, bitmask64((ulong)default(UInt28).Bits)) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator * (uint left, UInt28x2 right) => right * left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator / (UInt28x2 left, UInt28x2 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt28x2)(div((uint2)left, right));
            }

            ulong lo = left.Bits & bitmask64((ulong)default(UInt28).Bits, 0u * (ulong)default(UInt28).Bits);
            ulong hi = left.Bits & bitmask64((ulong)default(UInt28).Bits, 1u * (ulong)default(UInt28).Bits);

            lo /= right[0];
            hi /= right[1];

            return new UInt28x2 { Bits = bits_select(hi, lo, bitmask64((ulong)default(UInt28).Bits)) };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator / (UInt28x2 left, uint right)
        {
            if (SWAR.ConstDiv<UInt28>(left.Bits, (long)right, out ulong constDiv))
            {
                return new UInt28x2 { Bits = constDiv };
            }
            
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt28x2)(div((uint2)left, right));
            }

            ulong lo = left.Bits & bitmask64((ulong)default(UInt28).Bits, 0u * (ulong)default(UInt28).Bits);
            ulong hi = left.Bits & bitmask64((ulong)default(UInt28).Bits, 1u * (ulong)default(UInt28).Bits);

            lo /= right;
            hi /= right;

            return new UInt28x2 { Bits = bits_select(hi, lo, bitmask64((ulong)default(UInt28).Bits)) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator / (uint left, UInt28x2 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt28x2)(div((uint2)left, right));
            }
            
            ulong lo = (ulong)left << (0 * default(UInt28).Bits);
            ulong hi = (ulong)left << (1 * default(UInt28).Bits);
        
            lo /= right[0];
            hi /= right[1];

            return new UInt28x2 { Bits = bits_select(hi, lo, bitmask64((ulong)default(UInt28).Bits)) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator % (UInt28x2 left, UInt28x2 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt28x2)(mod((uint2)left, right));
            }
            
            return new UInt28x2((uint)(left[0] % right[0]),
                                (uint)(left[1] % right[1]));
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator % (UInt28x2 left, uint right)
        {
            if (SWAR.ConstRem<UInt28>(left.Bits, (long)right, out ulong constRem))
            {
                return new UInt28x2 { Bits = constRem };
            }
            
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt28x2)(mod((uint2)left, right));
            }
            
            return new UInt28x2((uint)(left[0] % right),
                                (uint)(left[1] % right));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator % (uint left, UInt28x2 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt28x2)(mod((uint2)left, right));
            }

            return new UInt28x2((uint)(left % right[0]),
                                (uint)(left % right[1]));
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator << (UInt28x2 left, int right) => new UInt28x2 { Bits = SWAR.ShiftLeftLogical<UInt28>(left.Bits, right) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator >> (UInt28x2 left, int right) => new UInt28x2 { Bits = SWAR.ShiftRightLogical<UInt28>(left.Bits, right) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator ~ (UInt28x2 value) => new UInt28x2{ Bits = ~value.Bits };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator ^ (UInt28x2 left, UInt28x2 right) => new UInt28x2{ Bits = left.Bits ^ right.Bits };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator ^ (UInt28x2 left, uint right) => left ^ new UInt28x2((uint)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator ^ (uint left, UInt28x2 right) => right ^ left;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator & (UInt28x2 left, UInt28x2 right) => new UInt28x2{ Bits = left.Bits & right.Bits };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator & (UInt28x2 left, uint right) => left & new UInt28x2((uint)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator & (uint left, UInt28x2 right) => right & left;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator | (UInt28x2 left, UInt28x2 right) => new UInt28x2{ Bits = left.Bits | right.Bits };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator | (UInt28x2 left, uint right) => left | new UInt28x2((uint)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator | (uint left, UInt28x2 right) => right | left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator == (UInt28x2 left, UInt28x2 right) => new UInt28x2 { Bits = SWAR.Equals<UInt28>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator == (UInt28x2 left, uint right) => left == new UInt28x2((uint)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator == (uint left, UInt28x2 right) => right == left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator != (UInt28x2 left, UInt28x2 right) => new UInt28x2 { Bits = SWAR.NotEquals<UInt28>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator != (UInt28x2 left, uint right) => left != new UInt28x2((uint)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator != (uint left, UInt28x2 right) => right != left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator < (UInt28x2 left, UInt28x2 right) => new UInt28x2 { Bits = SWAR.LessThan<UInt28>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator < (UInt28x2 left, uint right) => left < new UInt28x2((uint)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator < (uint left, UInt28x2 right) => right > left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator > (UInt28x2 left, UInt28x2 right) => new UInt28x2 { Bits = SWAR.GreaterThan<UInt28>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator > (UInt28x2 left, uint right) => left > new UInt28x2((uint)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator > (uint left, UInt28x2 right) => right < left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator <= (UInt28x2 left, UInt28x2 right) => new UInt28x2 { Bits = SWAR.LessThanOrEqual<UInt28>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator <= (UInt28x2 left, uint right) => left <= new UInt28x2((uint)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator <= (uint left, UInt28x2 right) => right >= left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator >= (UInt28x2 left, UInt28x2 right) => new UInt28x2 { Bits = SWAR.GreaterThanOrEqual<UInt28>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator >= (UInt28x2 left, uint right) => left >= new UInt28x2((uint)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt28x2 operator >= (uint left, UInt28x2 right) => right <= left;

        
        public uint this[int index]
        {
            [return: AssumeRange((ulong)UInt28.MinValue, (ulong)UInt28.MaxValue)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (uint)BitFieldHelper.Get<UInt28>(Bits, default(UInt28).Bits * index, default(UInt28).Bits * Length);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Bits = BitFieldHelper.Set<UInt28>(Bits, (int)value, default(UInt28).Bits * index, default(UInt28).Bits * Length);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly UInt28x2 SetReplicate(int index, int numNumbers, uint value)
        {
            return new UInt28x2 { Bits = BitFieldHelper.SetReplicate<UInt28>(Bits, (int)value, numNumbers, default(UInt28).Bits * index, default(UInt28).Bits * Length) };
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(UInt28x2 other)
        {
            return this.Bits == other.Bits;
        }

        public override readonly bool Equals(object obj)
        {
            return obj is UInt28x2 converted && this.Equals(converted);
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
            return new ArrayEnumerator<UInt28x2, uint>(this);
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<UInt28x2, uint>(this);
        }
    }
}