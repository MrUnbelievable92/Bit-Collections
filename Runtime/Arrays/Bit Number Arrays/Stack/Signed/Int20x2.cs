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
    unsafe public struct Int20x2 : IArray<int>, IEquatable<Int20x2>
    {
        public UInt40 Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int20x2(int xy)
        {
            this = (Int20x2)new UInt20x2((uint)ValueHelper.TruncBits<Int20>(xy));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int20x2(int x, int y)
        {
            this = (Int20x2)new UInt20x2((uint)ValueHelper.TruncBits<Int20>(x), 
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
        public static explicit operator UInt20x2(Int20x2 input) => input.Reinterpret<Int20x2, UInt20x2>();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int20x2(UInt20x2 input) => input.Reinterpret<UInt20x2, Int20x2>();


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int28x2(Int20x2 input) => (Int28x2)(int2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int20x2(Int28x2 input) => (Int20x2)(UInt28x2)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt28x2(Int20x2 input) => (UInt28x2)(Int28x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int20x2(UInt28x2 input) => (Int20x2)(UInt20x2)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte2(Int20x2 input) => (byte2)(sbyte2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort2(Int20x2 input) => (ushort2)(short2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2(Int20x2 input) => (uint2)(int2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong2(Int20x2 input) => (ulong2)(long2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte2(Int20x2 input) => (sbyte2)(UInt20x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short2(Int20x2 input) => (short2)(UInt20x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int2(Int20x2 input) => signextend((int2)(UInt20x2)input, default(Int20).Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long2(Int20x2 input) => signextend((long2)(UInt20x2)input, default(Int20).Bits);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int20x2(byte2 input) => (Int20x2)(UInt20x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int20x2(ushort2 input) => (Int20x2)(UInt20x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int20x2(uint2 input) => (Int20x2)(UInt20x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int20x2(ulong2 input) => (Int20x2)(UInt20x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int20x2(sbyte2 input) => (Int20x2)(UInt20x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int20x2(short2 input) => (Int20x2)(UInt20x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int20x2(int2 input) => (Int20x2)(UInt20x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int20x2(long2 input) => (Int20x2)(UInt20x2)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter2(Int20x2 input) => (quarter2)(sbyte2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]// TODO (half2)(int2)input
        public static implicit operator half2(Int20x2 input) => (half2)(float2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2(Int20x2 input) => (float2)(int2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2(Int20x2 input) => (double2)(int2)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int20x2(quarter2 input) => (Int20x2)(int2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]// TODO (Int20x2)(int2)input
        public static explicit operator Int20x2(half2 input) => (Int20x2)(float2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int20x2(float2 input) => (Int20x2)(int2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int20x2(double2 input) => (Int20x2)(int2)input;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator - (Int20x2 value) => new Int20x2 { Bits = SWAR.Neg<Int20>(value.Bits) };

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator ++ (Int20x2 value) => value + 1;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator -- (Int20x2 value) => value - 1;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator + (Int20x2 left, Int20x2 right) => (Int20x2)((UInt20x2)left + (UInt20x2)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator + (Int20x2 left, int right) => left + new Int20x2(right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator + (int left, Int20x2 right) => new Int20x2(left) + right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator - (Int20x2 left, Int20x2 right) => (Int20x2)((UInt20x2)left - (UInt20x2)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator - (Int20x2 left, int right) => left - new Int20x2(right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator - (int left, Int20x2 right) => new Int20x2(left) - right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator * (Int20x2 left, Int20x2 right) => (Int20x2)((UInt20x2)left * (UInt20x2)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator * (Int20x2 left, int right) => left * new Int20x2(right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator * (int left, Int20x2 right) => new Int20x2(left) * right;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator / (Int20x2 left, Int20x2 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int20x2)(div((int2)left, (int2)right));
            }
            
            UInt20x2 negQuotient = (UInt20x2)(left ^ right) >> (default(Int20).Bits - 1);
            left = new Int20x2 { Bits = SWAR.Abs<Int20>(left.Bits) };
            right = new Int20x2 { Bits = SWAR.Abs<Int20>(right.Bits) };
            
            UInt20x2 absResult = (UInt20x2)left / (UInt20x2)right;
            absResult = (absResult ^ new UInt20x2 { Bits = SWAR.NegBool<Int20>(negQuotient.Bits) }) + negQuotient;

            return new Int20x2 { Bits = absResult.Bits };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator / (Int20x2 left, int right)
        {
            if (SWAR.ConstDiv<Int20>(left.Bits, (long)right, out ulong constDiv))
            {
                return new Int20x2 { Bits = constDiv };
            }
            
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int20x2)(div((int2)left, right));
            }
            
            UInt20x2 negQuotient = (UInt20x2)(left ^ right) >> (default(Int20).Bits - 1);
            left = new Int20x2 { Bits = SWAR.Abs<Int20>(left.Bits) };
            right = abs(right);
            
            UInt20x2 absResult = (UInt20x2)left / (uint)right;
            absResult = (absResult ^ new UInt20x2 { Bits = SWAR.NegBool<Int20>(negQuotient.Bits) }) + negQuotient;

            return new Int20x2 { Bits = absResult.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator / (int left, Int20x2 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int20x2)(div(left, (int2)right));
            }
            
            UInt20x2 negQuotient = (UInt20x2)(left ^ right) >> (default(Int20).Bits - 1);
            left = abs(left);
            right = new Int20x2 { Bits = SWAR.Abs<Int20>(right.Bits) };
            
            UInt20x2 absResult = (uint)left / (UInt20x2)right;
            absResult = (absResult ^ new UInt20x2 { Bits = SWAR.NegBool<Int20>(negQuotient.Bits) }) + negQuotient;

            return new Int20x2 { Bits = absResult.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator % (Int20x2 left, Int20x2 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int20x2)(mod((int2)left, (int2)right));
            }
            
            return new Int20x2((left[0] % right[0]),
                               (left[1] % right[1]));
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator % (Int20x2 left, int right)
        {
            if (SWAR.ConstRem<Int20>(left.Bits, (long)right, out ulong constRem))
            {
                return new Int20x2 { Bits = constRem };
            }
            
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int20x2)(mod((int2)left, right));
            }
            
            return new Int20x2((left[0] % right),
                               (left[1] % right));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator % (int left, Int20x2 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int20x2)(mod(left, (int2)right));
            }

            return new Int20x2((left % right[0]),
                               (left % right[1]));
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator << (Int20x2 left, int right) => (Int20x2)((UInt20x2)left << right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator >> (Int20x2 left, int right) => new Int20x2 { Bits = SWAR.ShiftRightArithmetic<Int20>(left.Bits, right) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator ~ (Int20x2 value) => (Int20x2)~(UInt20x2)value;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator ^ (Int20x2 left, Int20x2 right) => (Int20x2)((UInt20x2)left ^ (UInt20x2)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator ^ (Int20x2 left, int right) => left ^ new Int20x2(right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator ^ (int left, Int20x2 right) => new Int20x2(left) ^ right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator & (Int20x2 left, Int20x2 right) => (Int20x2)((UInt20x2)left & (UInt20x2)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator & (Int20x2 left, int right) => left & new Int20x2(right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator & (int left, Int20x2 right) => new Int20x2(left) & right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator | (Int20x2 left, Int20x2 right) => (Int20x2)((UInt20x2)left | (UInt20x2)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator | (Int20x2 left, int right) => left | new Int20x2(right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator | (int left, Int20x2 right) => new Int20x2(left) | right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator == (Int20x2 left, Int20x2 right) => (Int20x2)((UInt20x2)left == (UInt20x2)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator == (Int20x2 left, int right) => left == new Int20x2(right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator == (int left, Int20x2 right) => new Int20x2(left) == right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator != (Int20x2 left, Int20x2 right) => (Int20x2)((UInt20x2)left != (UInt20x2)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator != (Int20x2 left, int right) => left != new Int20x2(right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator != (int left, Int20x2 right) => new Int20x2(left) != right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator < (Int20x2 left, Int20x2 right) => new Int20x2 { Bits = SWAR.LessThan<Int20>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator < (Int20x2 left, int right) => left < new Int20x2(right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator < (int left, Int20x2 right) => right > left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator > (Int20x2 left, Int20x2 right) => new Int20x2 { Bits = SWAR.GreaterThan<Int20>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator > (Int20x2 left, int right) => left > new Int20x2(right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator > (int left, Int20x2 right) => right < left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator <= (Int20x2 left, Int20x2 right) => new Int20x2 { Bits = SWAR.LessThanOrEqual<Int20>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator <= (Int20x2 left, int right) => left <= new Int20x2(right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator <= (int left, Int20x2 right) => right >= left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator >= (Int20x2 left, Int20x2 right) => new Int20x2 { Bits = SWAR.GreaterThanOrEqual<Int20>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator >= (Int20x2 left, int right) => left >= new Int20x2(right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int20x2 operator >= (int left, Int20x2 right) => right <= left;

        
        public int this[int index]
        {
            [return: AssumeRange((long)Int20.MinValue, (long)Int20.MaxValue)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (int)BitFieldHelper.Get<Int20>(Bits, default(Int20).Bits * index, default(Int20).Bits * Length);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Bits = BitFieldHelper.Set<Int20>(Bits, (int)value, default(Int20).Bits * index, default(Int20).Bits * Length);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Int20x2 SetReplicate(int index, int numNumbers, uint value)
        {
            return new Int20x2 { Bits = BitFieldHelper.SetReplicate<Int20>(Bits, (int)value, numNumbers, default(Int20).Bits * index, default(Int20).Bits * Length) };
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Int20x2 other)
        {
            return this.Bits == other.Bits;
        }

        public override readonly bool Equals(object obj)
        {
            return obj is Int20x2 converted && this.Equals(converted);
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
            return new ArrayEnumerator<Int20x2, int>(this);
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<Int20x2, int>(this);
        }
    }
}