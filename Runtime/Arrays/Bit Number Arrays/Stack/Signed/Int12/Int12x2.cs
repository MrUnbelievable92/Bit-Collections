using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;
using Unity.Mathematics;
using MaxMath;
using MaxMath.Intrinsics;

using static Unity.Mathematics.math;
using static MaxMath.maxmath;

namespace BitCollections
{
    [Serializable]
    unsafe public struct Int12x2 : IArray<int>, IEquatable<Int12x2>
    {
        public UInt24 Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int12x2(short xy)
        {
            this = (Int12x2)new UInt12x2((ushort)ValueHelper.TruncBits<Int12>(xy));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int12x2(short x, short y)
        {
            this = (Int12x2)new UInt12x2((ushort)ValueHelper.TruncBits<Int12>(x), 
                                         (ushort)                             y);
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
        public static explicit operator UInt12x2(Int12x2 input) => input.Reinterpret<Int12x2, UInt12x2>();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int12x2(UInt12x2 input) => input.Reinterpret<UInt12x2, Int12x2>();


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int20x2(Int12x2 input) => (Int20x2)(int2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int28x2(Int12x2 input) => (Int28x2)(int2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int12x2(Int20x2 input) => (Int12x2)(UInt20x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int12x2(Int28x2 input) => (Int12x2)(UInt28x2)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt20x2(Int12x2 input) => (UInt20x2)(Int20x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt28x2(Int12x2 input) => (UInt28x2)(Int28x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int12x2(UInt20x2 input) => (Int12x2)(UInt12x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int12x2(UInt28x2 input) => (Int12x2)(UInt12x2)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte2(Int12x2 input) => (byte2)(sbyte2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort2(Int12x2 input) => (ushort2)(short2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2(Int12x2 input) => (uint2)(int2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong2(Int12x2 input) => (ulong2)(long2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte2(Int12x2 input) => (sbyte2)(UInt12x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator short2(Int12x2 input) => signextend((short2)(UInt12x2)input, default(Int12).Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int2(Int12x2 input) => signextend((int2)(UInt12x2)input, default(Int12).Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long2(Int12x2 input) => signextend((long2)(UInt12x2)input, default(Int12).Bits);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int12x2(byte2 input) => (Int12x2)(UInt12x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int12x2(ushort2 input) => (Int12x2)(UInt12x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int12x2(uint2 input) => (Int12x2)(UInt12x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int12x2(ulong2 input) => (Int12x2)(UInt12x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int12x2(sbyte2 input) => (Int12x2)(UInt12x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int12x2(short2 input) => (Int12x2)(UInt12x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int12x2(int2 input) => (Int12x2)(UInt12x2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int12x2(long2 input) => (Int12x2)(UInt12x2)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter2(Int12x2 input) => (quarter2)(short2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator half2(Int12x2 input) => (half2)(short2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2(Int12x2 input) => (float2)(int2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2(Int12x2 input) => (double2)(int2)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int12x2(quarter2 input) => (Int12x2)(short2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int12x2(half2 input) => (Int12x2)(short2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int12x2(float2 input) => (Int12x2)(int2)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int12x2(double2 input) => (Int12x2)(int2)input;

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator - (Int12x2 value) => new Int12x2 { Bits = SWAR.Neg<Int12>(value.Bits) };

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator ++ (Int12x2 value) => value + 1;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator -- (Int12x2 value) => value - 1;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator + (Int12x2 left, Int12x2 right) => (Int12x2)((UInt12x2)left + (UInt12x2)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator + (Int12x2 left, int right) => left + new Int12x2((short)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator + (int left, Int12x2 right) => new Int12x2((short)left) + right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator - (Int12x2 left, Int12x2 right) => (Int12x2)((UInt12x2)left - (UInt12x2)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator - (Int12x2 left, int right) => left - new Int12x2((short)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator - (int left, Int12x2 right) => new Int12x2((short)left) - right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator * (Int12x2 left, Int12x2 right) => (Int12x2)((UInt12x2)left * (UInt12x2)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator * (Int12x2 left, int right) => left * new Int12x2((short)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator * (int left, Int12x2 right) => new Int12x2((short)left) * right;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator / (Int12x2 left, Int12x2 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int12x2)((short2)left / (short2)right);
            }
            
            UInt12x2 negQuotient = (UInt12x2)(left ^ right) >> (default(Int12).Bits - 1);
            left = new Int12x2 { Bits = SWAR.Abs<Int12>(left.Bits) };
            right = new Int12x2 { Bits = SWAR.Abs<Int12>(right.Bits) };
            
            UInt12x2 absResult = (UInt12x2)left / (UInt12x2)right;
            absResult = (absResult ^ new UInt12x2 { Bits = SWAR.NegBool<Int12>(negQuotient.Bits) }) + negQuotient;

            return new Int12x2 { Bits = absResult.Bits };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator / (Int12x2 left, int right)
        {
            if (SWAR.ConstDiv<Int12>(left.Bits, (int)right, out uint constDiv))
            {
                return new Int12x2 { Bits = constDiv };
            }
            
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int12x2)((short2)left / (short)right);
            }
            
            UInt12x2 negQuotient = (UInt12x2)(left ^ right) >> (default(Int12).Bits - 1);
            left = new Int12x2 { Bits = SWAR.Abs<Int12>(left.Bits) };
            right = abs(right);
            
            UInt12x2 absResult = (UInt12x2)left / (uint)right;
            absResult = (absResult ^ new UInt12x2 { Bits = SWAR.NegBool<Int12>(negQuotient.Bits) }) + negQuotient;

            return new Int12x2 { Bits = absResult.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator / (int left, Int12x2 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int12x2)((short)left / (short2)right);
            }
            
            UInt12x2 negQuotient = (UInt12x2)(left ^ right) >> (default(Int12).Bits - 1);
            left = abs(left);
            right = new Int12x2 { Bits = SWAR.Abs<Int12>(right.Bits) };
            
            UInt12x2 absResult = (uint)left / (UInt12x2)right;
            absResult = (absResult ^ new UInt12x2 { Bits = SWAR.NegBool<Int12>(negQuotient.Bits) }) + negQuotient;

            return new Int12x2 { Bits = absResult.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator % (Int12x2 left, Int12x2 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int12x2)((short2)left % (short2)right);
            }
            
            return new Int12x2((short)(left[0] % right[0]),
                               (short)(left[1] % right[1]));
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator % (Int12x2 left, int right)
        {
            if (SWAR.ConstRem<Int12>(left.Bits, right, out uint constRem))
            {
                return new Int12x2 { Bits = constRem };
            }
            
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int12x2)((short2)left % (short)right);
            }
            
            return new Int12x2((short)(left[0] % right),
                               (short)(left[1] % right));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator % (int left, Int12x2 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int12x2)((short)left % (short2)right);
            }

            return new Int12x2((short)(left % right[0]),
                               (short)(left % right[1]));
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator << (Int12x2 left, int right) => (Int12x2)((UInt12x2)left << right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator >> (Int12x2 left, int right) => new Int12x2 { Bits = SWAR.ShiftRightArithmetic<Int12>(left.Bits, right) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator ~ (Int12x2 value) => (Int12x2)~(UInt12x2)value;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator ^ (Int12x2 left, Int12x2 right) => (Int12x2)((UInt12x2)left ^ (UInt12x2)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator ^ (Int12x2 left, int right) => left ^ new Int12x2((short)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator ^ (int left, Int12x2 right) => new Int12x2((short)left) ^ right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator & (Int12x2 left, Int12x2 right) => (Int12x2)((UInt12x2)left & (UInt12x2)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator & (Int12x2 left, int right) => left & new Int12x2((short)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator & (int left, Int12x2 right) => new Int12x2((short)left) & right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator | (Int12x2 left, Int12x2 right) => (Int12x2)((UInt12x2)left | (UInt12x2)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator | (Int12x2 left, int right) => left | new Int12x2((short)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator | (int left, Int12x2 right) => new Int12x2((short)left) | right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator == (Int12x2 left, Int12x2 right) => (Int12x2)((UInt12x2)left == (UInt12x2)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator == (Int12x2 left, int right) => left == new Int12x2((short)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator == (int left, Int12x2 right) => new Int12x2((short)left) == right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator != (Int12x2 left, Int12x2 right) => (Int12x2)((UInt12x2)left != (UInt12x2)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator != (Int12x2 left, int right) => left != new Int12x2((short)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator != (int left, Int12x2 right) => new Int12x2((short)left) != right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator < (Int12x2 left, Int12x2 right) => new Int12x2 { Bits = SWAR.LessThan<Int12>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator < (Int12x2 left, int right) => left < new Int12x2((short)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator < (int left, Int12x2 right) => right > left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator > (Int12x2 left, Int12x2 right) => new Int12x2 { Bits = SWAR.GreaterThan<Int12>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator > (Int12x2 left, int right) => left > new Int12x2((short)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator > (int left, Int12x2 right) => right < left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator <= (Int12x2 left, Int12x2 right) => new Int12x2 { Bits = SWAR.LessThanOrEqual<Int12>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator <= (Int12x2 left, int right) => left <= new Int12x2((short)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator <= (int left, Int12x2 right) => right >= left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator >= (Int12x2 left, Int12x2 right) => new Int12x2 { Bits = SWAR.GreaterThanOrEqual<Int12>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator >= (Int12x2 left, int right) => left >= new Int12x2((short)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int12x2 operator >= (int left, Int12x2 right) => right <= left;

        
        public int this[int index]
        {
            [return: AssumeRange((long)Int12.MinValue, (long)Int12.MaxValue)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (int)BitFieldHelper.Get<Int12>(Bits, default(Int12).Bits * index, default(Int12).Bits * Length);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Bits = BitFieldHelper.Set<Int12>(Bits, (int)value, default(Int12).Bits * index, default(Int12).Bits * Length);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Int12x2 SetReplicate(int index, int numNumbers, uint value)
        {
            return new Int12x2 { Bits = BitFieldHelper.SetReplicate<Int12>(Bits, (int)value, numNumbers, default(Int12).Bits * index, default(Int12).Bits * Length) };
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Int12x2 other)
        {
            return this.Bits == other.Bits;
        }

        public override readonly bool Equals(object obj)
        {
            return obj is Int12x2 converted && this.Equals(converted);
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
            return new ArrayEnumerator<Int12x2, int>(this);
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<Int12x2, int>(this);
        }
    }
}