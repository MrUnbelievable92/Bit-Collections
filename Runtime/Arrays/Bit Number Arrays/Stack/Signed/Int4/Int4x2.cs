using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;
using Unity.Mathematics;
using MaxMath.Intrinsics;

using static MaxMath.maxmath;
using static Unity.Mathematics.math;
using MaxMath;

namespace BitCollections
{
    [Serializable]
    unsafe public struct Int4x2 : IArray<int>, IEquatable<Int4x2>
    {
        public byte Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x2(sbyte xyzw)
        {
            this = (Int4x2)new UInt4x2((byte)ValueHelper.TruncBits<Int4>(xyzw));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x2(sbyte x, sbyte y)
        {
            this = (Int4x2)new UInt4x2((byte)ValueHelper.TruncBits<Int4>(x), 
                                       (byte)                            y);
        }


        public readonly int Length => 2;


        public int x
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[0];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[0] = value;
        }
        public int y
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[1];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[1] = value;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x2(Int4x2 input) => input.Reinterpret<Int4x2, UInt4x2>();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x2(UInt4x2 input) => input.Reinterpret<UInt4x2, Int4x2>();


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int12x2(Int4x2 input) => (Int12x2)(short2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int20x2(Int4x2 input) => (Int20x2)(int2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int28x2(Int4x2 input) => (Int28x2)(int2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x2(Int12x2 input) => (Int4x2)(UInt12x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x2(Int20x2 input) => (Int4x2)(UInt20x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x2(Int28x2 input) => (Int4x2)(UInt28x2)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt12x2(Int4x2 input) => (UInt12x2)(Int12x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt20x2(Int4x2 input) => (UInt20x2)(Int20x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt28x2(Int4x2 input) => (UInt28x2)(Int28x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x2(UInt12x2 input) => (Int4x2)(UInt4x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x2(UInt20x2 input) => (Int4x2)(UInt4x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x2(UInt28x2 input) => (Int4x2)(UInt4x2)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte2(Int4x2 input) => (byte2)(sbyte2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort2(Int4x2 input) => (ushort2)(short2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2(Int4x2 input) => (uint2)(int2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong2(Int4x2 input) => (ulong2)(long2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator sbyte2(Int4x2 input) => signextend((sbyte2)(UInt4x2)input, default(Int4).Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator short2(Int4x2 input) => signextend((short2)(UInt4x2)input, default(Int4).Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int2(Int4x2 input) => signextend((int2)(UInt4x2)input, default(Int4).Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long2(Int4x2 input) => signextend((long2)(UInt4x2)input, default(Int4).Bits);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x2(byte2 input) => (Int4x2)(UInt4x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x2(ushort2 input) => (Int4x2)(UInt4x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x2(uint2 input) => (Int4x2)(UInt4x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x2(ulong2 input) => (Int4x2)(UInt4x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x2(sbyte2 input) => (Int4x2)(UInt4x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x2(short2 input) => (Int4x2)(UInt4x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x2(int2 input) => (Int4x2)(UInt4x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x2(long2 input) => (Int4x2)(UInt4x2)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator quarter2(Int4x2 input) => (quarter2)(sbyte2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator half2(Int4x2 input) => (half2)(short2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2(Int4x2 input) => (float2)(int2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2(Int4x2 input) => (double2)(int2)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x2(quarter2 input) => (Int4x2)(sbyte2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x2(half2 input) => (Int4x2)(short2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x2(float2 input) => (Int4x2)(int2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x2(double2 input) => (Int4x2)(int2)input;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator - (Int4x2 value) => new Int4x2 { Bits = SWAR.Neg<Int4>(value.Bits) };

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator ++ (Int4x2 value) => value + 1;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator -- (Int4x2 value) => value - 1;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator + (Int4x2 left, Int4x2 right) => (Int4x2)((UInt4x2)left + (UInt4x2)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator + (Int4x2 left, int right) => left + new Int4x2((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator + (int left, Int4x2 right) => new Int4x2((sbyte)left) + right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator - (Int4x2 left, Int4x2 right) => (Int4x2)((UInt4x2)left - (UInt4x2)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator - (Int4x2 left, int right) => left - new Int4x2((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator - (int left, Int4x2 right) => new Int4x2((sbyte)left) - right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator * (Int4x2 left, Int4x2 right) => (Int4x2)((UInt4x2)left * (UInt4x2)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator * (Int4x2 left, int right) => left * new Int4x2((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator * (int left, Int4x2 right) => new Int4x2((sbyte)left) * right;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator / (Int4x2 left, Int4x2 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int4x2)((short2)left / (short2)right);
            }
            
            UInt4x2 negQuotient = (UInt4x2)(left ^ right) >> (default(Int4).Bits - 1);
            left = new Int4x2 { Bits = SWAR.Abs<Int4>(left.Bits) };
            right = new Int4x2 { Bits = SWAR.Abs<Int4>(right.Bits) };
            
            UInt4x2 absResult = (UInt4x2)left / (UInt4x2)right;
            absResult = (absResult ^ new UInt4x2 { Bits = SWAR.NegBool<Int4>(negQuotient.Bits) }) + negQuotient;

            return new Int4x2 { Bits = absResult.Bits };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator / (Int4x2 left, int right)
        {
            if (SWAR.ConstDiv<Int4>(left.Bits, (sbyte)right, out byte constDiv))
            {
                return new Int4x2 { Bits = constDiv };
            }
            
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int4x2)((short2)left / (sbyte)right);
            }
            
            UInt4x2 negQuotient = (UInt4x2)(left ^ right) >> (default(Int4).Bits - 1);
            left = new Int4x2 { Bits = SWAR.Abs<Int4>(left.Bits) };
            right = abs(right);
            
            UInt4x2 absResult = (UInt4x2)left / (uint)right;
            absResult = (absResult ^ new UInt4x2 { Bits = SWAR.NegBool<Int4>(negQuotient.Bits) }) + negQuotient;

            return new Int4x2 { Bits = absResult.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator / (int left, Int4x2 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int4x2)((short)left / (short2)right);
            }
            
            UInt4x2 negQuotient = (UInt4x2)(left ^ right) >> (default(Int4).Bits - 1);
            left = abs(left);
            right = new Int4x2 { Bits = SWAR.Abs<Int4>(right.Bits) };
            
            UInt4x2 absResult = (uint)left / (UInt4x2)right;
            absResult = (absResult ^ new UInt4x2 { Bits = SWAR.NegBool<Int4>(negQuotient.Bits) }) + negQuotient;

            return new Int4x2 { Bits = absResult.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator % (Int4x2 left, Int4x2 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int4x2)((short2)left % (short2)right);
            }
            
            return new Int4x2((sbyte)(left[0] % right[0]),
                              (sbyte)(left[1] % right[1]));
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator % (Int4x2 left, int right)
        {
            if (SWAR.ConstRem<Int4>(left.Bits, (sbyte)right, out byte constRem))
            {
                return new Int4x2 { Bits = constRem };
            }
            
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int4x2)((short2)left % (short)right);
            }
            
            return new Int4x2((sbyte)(left[0] % right),
                              (sbyte)(left[1] % right));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator % (int left, Int4x2 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int4x2)((short)left % (short2)right);
            }

            return new Int4x2((sbyte)(left % right[0]),
                              (sbyte)(left % right[1]));
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator << (Int4x2 left, int right) => (Int4x2)((UInt4x2)left << right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator >> (Int4x2 left, int right) => new Int4x2 { Bits = SWAR.ShiftRightArithmetic<Int4>(left.Bits, right) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator ~ (Int4x2 value) => (Int4x2)~(UInt4x2)value;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator ^ (Int4x2 left, Int4x2 right) => (Int4x2)((UInt4x2)left ^ (UInt4x2)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator ^ (Int4x2 left, int right) => left ^ new Int4x2((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator ^ (int left, Int4x2 right) => new Int4x2((sbyte)left) ^ right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator & (Int4x2 left, Int4x2 right) => (Int4x2)((UInt4x2)left & (UInt4x2)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator & (Int4x2 left, int right) => left & new Int4x2((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator & (int left, Int4x2 right) => new Int4x2((sbyte)left) & right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator | (Int4x2 left, Int4x2 right) => (Int4x2)((UInt4x2)left | (UInt4x2)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator | (Int4x2 left, int right) => left | new Int4x2((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator | (int left, Int4x2 right) => new Int4x2((sbyte)left) | right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator == (Int4x2 left, Int4x2 right) => (Int4x2)((UInt4x2)left == (UInt4x2)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator == (Int4x2 left, int right) => left == new Int4x2((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator == (int left, Int4x2 right) => new Int4x2((sbyte)left) == right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator != (Int4x2 left, Int4x2 right) => (Int4x2)((UInt4x2)left != (UInt4x2)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator != (Int4x2 left, int right) => left != new Int4x2((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator != (int left, Int4x2 right) => new Int4x2((sbyte)left) != right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator < (Int4x2 left, Int4x2 right) => new Int4x2 { Bits = SWAR.LessThan<Int4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator < (Int4x2 left, int right) => left < new Int4x2((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator < (int left, Int4x2 right) => right > left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator > (Int4x2 left, Int4x2 right) => new Int4x2 { Bits = SWAR.GreaterThan<Int4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator > (Int4x2 left, int right) => left > new Int4x2((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator > (int left, Int4x2 right) => right < left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator <= (Int4x2 left, Int4x2 right) => new Int4x2 { Bits = SWAR.LessThanOrEqual<Int4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator <= (Int4x2 left, int right) => left <= new Int4x2((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator <= (int left, Int4x2 right) => right >= left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator >= (Int4x2 left, Int4x2 right) => new Int4x2 { Bits = SWAR.GreaterThanOrEqual<Int4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator >= (Int4x2 left, int right) => left >= new Int4x2((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator >= (int left, Int4x2 right) => right <= left;

        
        public int this[int index]
        {
            [return: AssumeRange((long)Int4.MinValue, (long)Int4.MaxValue)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return BitFieldHelper.Get<Int4>(Bits, default(Int4).Bits * index, default(Int4).Bits * Length);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Bits = (byte)BitFieldHelper.Set<Int4>(Bits, (int)value, default(Int4).Bits * index, default(Int4).Bits * Length);
            }
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Int4x2 SetReplicate(int index, int numNumbers, uint value)
        {
            return new Int4x2 { Bits = (byte)BitFieldHelper.SetReplicate<Int4>(Bits, (int)value, numNumbers, default(Int4).Bits * index, default(Int4).Bits * Length) };
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Int4x2 other)
        {
            return this.Bits == other.Bits;
        }

        public override readonly bool Equals(object obj)
        {
            return obj is Int4x2 converted && this.Equals(converted);
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


        public readonly IEnumerator<int> GetEnumerator()
        {
            return new ArrayEnumerator<Int4x2, int>(this);
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<Int4x2, int>(this);
        }
    }
}