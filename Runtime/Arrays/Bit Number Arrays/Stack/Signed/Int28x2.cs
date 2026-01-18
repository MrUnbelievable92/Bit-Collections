using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;
using MaxMath;
using MaxMath.Intrinsics;

using static MaxMath.maxmath;
using static Unity.Mathematics.math;
using Unity.Mathematics;

namespace BitCollections
{
    [Serializable]
    unsafe public struct Int28x2 : IArray<int>, IEquatable<Int28x2>
    {
        public UInt56 Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int28x2(int xy)
        {
            this = (Int28x2)new UInt28x2((uint)ValueHelper.TruncBits<Int28>(xy));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int28x2(int x, int y)
        {
            this = (Int28x2)new UInt28x2((uint)ValueHelper.TruncBits<Int28>(x), 
                                         (uint)                             y);
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
        public static explicit operator UInt28x2(Int28x2 input) => input.Reinterpret<Int28x2, UInt28x2>();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int28x2(UInt28x2 input) => input.Reinterpret<UInt28x2, Int28x2>();


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte2(Int28x2 input) => (byte2)(sbyte2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort2(Int28x2 input) => (ushort2)(short2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2(Int28x2 input) => (uint2)(int2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong2(Int28x2 input) => (ulong2)(long2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte2(Int28x2 input) => (sbyte2)(UInt28x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short2(Int28x2 input) => (short2)(UInt28x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int2(Int28x2 input) => signextend((int2)(UInt28x2)input, default(Int28).Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long2(Int28x2 input) => signextend((long2)(UInt28x2)input, default(Int28).Bits);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int28x2(byte2 input) => (Int28x2)(UInt28x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int28x2(ushort2 input) => (Int28x2)(UInt28x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int28x2(uint2 input) => (Int28x2)(UInt28x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int28x2(ulong2 input) => (Int28x2)(UInt28x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int28x2(sbyte2 input) => (Int28x2)(UInt28x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int28x2(short2 input) => (Int28x2)(UInt28x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int28x2(int2 input) => (Int28x2)(UInt28x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int28x2(long2 input) => (Int28x2)(UInt28x2)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter2(Int28x2 input) => (quarter2)(sbyte2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]// TODO (half2)(int2)input
        public static implicit operator half2(Int28x2 input) => (half2)(float2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2(Int28x2 input) => (float2)(int2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2(Int28x2 input) => (double2)(int2)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int28x2(quarter2 input) => (Int28x2)(int2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]// TODO (Int28x2)(int2)input
        public static explicit operator Int28x2(half2 input) => (Int28x2)(float2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int28x2(float2 input) => (Int28x2)(int2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int28x2(double2 input) => (Int28x2)(int2)input;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator - (Int28x2 value) => new Int28x2 { Bits = SWAR.Neg<Int28>(value.Bits) };

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator ++ (Int28x2 value) => value + 1;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator -- (Int28x2 value) => value - 1;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator + (Int28x2 left, Int28x2 right) => (Int28x2)((UInt28x2)left + (UInt28x2)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator + (Int28x2 left, int right) => left + new Int28x2(right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator + (int left, Int28x2 right) => new Int28x2(left) + right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator - (Int28x2 left, Int28x2 right) => (Int28x2)((UInt28x2)left - (UInt28x2)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator - (Int28x2 left, int right) => left - new Int28x2(right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator - (int left, Int28x2 right) => new Int28x2(left) - right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator * (Int28x2 left, Int28x2 right) => (Int28x2)((UInt28x2)left * (UInt28x2)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator * (Int28x2 left, int right) => left * new Int28x2(right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator * (int left, Int28x2 right) => new Int28x2(left) * right;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator / (Int28x2 left, Int28x2 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int28x2)(div((int2)left, (int2)right));
            }
            
            UInt28x2 negQuotient = (UInt28x2)(left ^ right) >> (default(Int28).Bits - 1);
            left = new Int28x2 { Bits = SWAR.Abs<Int28>(left.Bits) };
            right = new Int28x2 { Bits = SWAR.Abs<Int28>(right.Bits) };
            
            UInt28x2 absResult = (UInt28x2)left / (UInt28x2)right;
            absResult = (absResult ^ new UInt28x2 { Bits = SWAR.NegBool<Int28>(negQuotient.Bits) }) + negQuotient;

            return new Int28x2 { Bits = absResult.Bits };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator / (Int28x2 left, int right)
        {
            if (SWAR.ConstDiv<Int28>(left.Bits, (long)right, out ulong constDiv))
            {
                return new Int28x2 { Bits = constDiv };
            }
            
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int28x2)(div((int2)left, right));
            }
            
            UInt28x2 negQuotient = (UInt28x2)(left ^ right) >> (default(Int28).Bits - 1);
            left = new Int28x2 { Bits = SWAR.Abs<Int28>(left.Bits) };
            right = abs(right);
            
            UInt28x2 absResult = (UInt28x2)left / (uint)right;
            absResult = (absResult ^ new UInt28x2 { Bits = SWAR.NegBool<Int28>(negQuotient.Bits) }) + negQuotient;

            return new Int28x2 { Bits = absResult.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator / (int left, Int28x2 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int28x2)(div(left, (int2)right));
            }
            
            UInt28x2 negQuotient = (UInt28x2)(left ^ right) >> (default(Int28).Bits - 1);
            left = abs(left);
            right = new Int28x2 { Bits = SWAR.Abs<Int28>(right.Bits) };
            
            UInt28x2 absResult = (uint)left / (UInt28x2)right;
            absResult = (absResult ^ new UInt28x2 { Bits = SWAR.NegBool<Int28>(negQuotient.Bits) }) + negQuotient;

            return new Int28x2 { Bits = absResult.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator % (Int28x2 left, Int28x2 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int28x2)(mod((int2)left, (int2)right));
            }
            
            return new Int28x2((left[0] % right[0]),
                               (left[1] % right[1]));
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator % (Int28x2 left, int right)
        {
            if (SWAR.ConstRem<Int28>(left.Bits, (long)right, out ulong constRem))
            {
                return new Int28x2 { Bits = constRem };
            }
            
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int28x2)(mod((int2)left, right));
            }
            
            return new Int28x2((left[0] % right),
                               (left[1] % right));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator % (int left, Int28x2 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int28x2)(mod(left, (int2)right));
            }

            return new Int28x2((left % right[0]),
                               (left % right[1]));
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator << (Int28x2 left, int right) => (Int28x2)((UInt28x2)left << right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator >> (Int28x2 left, int right) => new Int28x2 { Bits = SWAR.ShiftRightArithmetic<Int28>(left.Bits, right) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator ~ (Int28x2 value) => (Int28x2)~(UInt28x2)value;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator ^ (Int28x2 left, Int28x2 right) => (Int28x2)((UInt28x2)left ^ (UInt28x2)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator ^ (Int28x2 left, int right) => left ^ new Int28x2(right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator ^ (int left, Int28x2 right) => new Int28x2(left) ^ right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator & (Int28x2 left, Int28x2 right) => (Int28x2)((UInt28x2)left & (UInt28x2)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator & (Int28x2 left, int right) => left & new Int28x2(right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator & (int left, Int28x2 right) => new Int28x2(left) & right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator | (Int28x2 left, Int28x2 right) => (Int28x2)((UInt28x2)left | (UInt28x2)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator | (Int28x2 left, int right) => left | new Int28x2(right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator | (int left, Int28x2 right) => new Int28x2(left) | right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator == (Int28x2 left, Int28x2 right) => (Int28x2)((UInt28x2)left == (UInt28x2)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator == (Int28x2 left, int right) => left == new Int28x2(right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator == (int left, Int28x2 right) => new Int28x2(left) == right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator != (Int28x2 left, Int28x2 right) => (Int28x2)((UInt28x2)left != (UInt28x2)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator != (Int28x2 left, int right) => left != new Int28x2(right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator != (int left, Int28x2 right) => new Int28x2(left) != right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator < (Int28x2 left, Int28x2 right) => new Int28x2 { Bits = SWAR.LessThan<Int28>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator < (Int28x2 left, int right) => left < new Int28x2(right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator < (int left, Int28x2 right) => right > left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator > (Int28x2 left, Int28x2 right) => new Int28x2 { Bits = SWAR.GreaterThan<Int28>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator > (Int28x2 left, int right) => left > new Int28x2(right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator > (int left, Int28x2 right) => right < left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator <= (Int28x2 left, Int28x2 right) => new Int28x2 { Bits = SWAR.LessThanOrEqual<Int28>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator <= (Int28x2 left, int right) => left <= new Int28x2(right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator <= (int left, Int28x2 right) => right >= left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator >= (Int28x2 left, Int28x2 right) => new Int28x2 { Bits = SWAR.GreaterThanOrEqual<Int28>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator >= (Int28x2 left, int right) => left >= new Int28x2(right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int28x2 operator >= (int left, Int28x2 right) => right <= left;

        
        public int this[int index]
        {
            [return: AssumeRange((long)Int28.MinValue, (long)Int28.MaxValue)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (int)BitFieldHelper.Get<Int28>(Bits, default(Int28).Bits * index, default(Int28).Bits * Length);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Bits = BitFieldHelper.Set<Int28>(Bits, (int)value, default(Int28).Bits * index, default(Int28).Bits * Length);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Int28x2 SetReplicate(int index, int numNumbers, uint value)
        {
            return new Int28x2 { Bits = BitFieldHelper.SetReplicate<Int28>(Bits, (int)value, numNumbers, default(Int28).Bits * index, default(Int28).Bits * Length) };
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Int28x2 other)
        {
            return this.Bits == other.Bits;
        }

        public override readonly bool Equals(object obj)
        {
            return obj is Int28x2 converted && this.Equals(converted);
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


        public readonly IEnumerator<int> GetEnumerator()
        {
            return new ArrayEnumerator<Int28x2, int>(this);
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<Int28x2, int>(this);
        }
    }
}