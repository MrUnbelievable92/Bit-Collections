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
    unsafe public struct Int10x4 : IArray<int>, IEquatable<Int10x4>
    {
        public UInt40 Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int10x4(short xyzw)
        {
            this = (Int10x4)new UInt10x4((ushort)ValueHelper.TruncBits<Int10>(xyzw));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int10x4(short x, short y, short z, short w)
        {
            this = (Int10x4)new UInt10x4((ushort)ValueHelper.TruncBits<Int10>(x),
                                         (ushort)ValueHelper.TruncBits<Int10>(y),
                                         (ushort)ValueHelper.TruncBits<Int10>(z),
                                         (ushort)                             w);
        }


        public readonly int Length => 4;


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
        public int z
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[2];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[2] = value;
        }
        public int w
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[3];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[3] = value;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt10x4(Int10x4 input) => input.Reinterpret<Int10x4, UInt10x4>();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int10x4(UInt10x4 input) => input.Reinterpret<UInt10x4, Int10x4>();


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int12x4(Int10x4 input) => (Int12x4)(short4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int14x4(Int10x4 input) => (Int14x4)(short4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int10x4(Int12x4 input) => (Int10x4)(UInt12x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int10x4(Int14x4 input) => (Int10x4)(UInt14x4)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt12x4(Int10x4 input) => (UInt12x4)(Int12x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt14x4(Int10x4 input) => (UInt14x4)(Int14x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int10x4(UInt12x4 input) => (Int10x4)(UInt10x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int10x4(UInt14x4 input) => (Int10x4)(UInt10x4)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte4(Int10x4 input) => (byte4)(short4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort4(Int10x4 input) => (ushort4)(short4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint4(Int10x4 input) => (uint4)(short4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong4(Int10x4 input) => (ulong4)(long4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte4(Int10x4 input) => (sbyte4)(UInt10x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator short4(Int10x4 input) => signextend((short4)(UInt10x4)input, default(Int10).Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int4(Int10x4 input) => signextend((int4)(UInt10x4)input, default(Int10).Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long4(Int10x4 input) => signextend((long4)(UInt10x4)input, default(Int10).Bits);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int10x4(byte4 input) => (Int10x4)(UInt10x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int10x4(ushort4 input) => (Int10x4)(UInt10x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int10x4(uint4 input) => (Int10x4)(UInt10x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int10x4(ulong4 input) => (Int10x4)(UInt10x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int10x4(sbyte4 input) => (Int10x4)(UInt10x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int10x4(short4 input) => (Int10x4)(UInt10x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int10x4(int4 input) => new Int10x4{ Bits = (UInt40)PackUnpack.DownCast<Int10>(input) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int10x4(long4 input) => new Int10x4{ Bits = (UInt40)PackUnpack.DownCast<Int10>(input) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter4(Int10x4 input) => (quarter4)(short4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator half4(Int10x4 input) => (half4)(short4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float4(Int10x4 input) => (float4)(short4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4(Int10x4 input) => (double4)(short4)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int10x4(quarter4 input) => (Int10x4)(short4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int10x4(half4 input) => (Int10x4)(short4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int10x4(float4 input) => (Int10x4)(short4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int10x4(double4 input) => (Int10x4)(short4)input;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator - (Int10x4 value) => new Int10x4 { Bits = SWAR.Neg<Int10>(value.Bits) };

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator ++ (Int10x4 value) => value + 1;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator -- (Int10x4 value) => value - 1;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator + (Int10x4 left, Int10x4 right) => (Int10x4)((UInt10x4)left + (UInt10x4)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator + (Int10x4 left, int right) => left + new Int10x4((short)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator + (int left, Int10x4 right) => new Int10x4((short)left) + right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator - (Int10x4 left, Int10x4 right) => (Int10x4)((UInt10x4)left - (UInt10x4)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator - (Int10x4 left, int right) => left - new Int10x4((short)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator - (int left, Int10x4 right) => new Int10x4((short)left) - right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator * (Int10x4 left, Int10x4 right) => (Int10x4)((UInt10x4)left * (UInt10x4)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator * (Int10x4 left, int right) => left * new Int10x4((short)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator * (int left, Int10x4 right) => new Int10x4((short)left) * right;
        
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator / (Int10x4 left, Int10x4 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int10x4)((short4)left / (short4)right);
            }
            
            UInt10x4 negQuotient = (UInt10x4)(left ^ right) >> (default(Int10).Bits - 1);
            left = new Int10x4 { Bits = SWAR.Abs<Int10>(left.Bits) };
            right = new Int10x4 { Bits = SWAR.Abs<Int10>(right.Bits) };
            
            UInt10x4 absResult = (UInt10x4)left / (UInt10x4)right;
            absResult = (absResult ^ new UInt10x4 { Bits = SWAR.NegBool<Int10>(negQuotient.Bits) }) + negQuotient;

            return new Int10x4 { Bits = absResult.Bits };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator / (Int10x4 left, int right)
        {
            if (SWAR.ConstDiv<Int10>(left.Bits, (long)right, out ulong constDiv))
            {
                return new Int10x4 { Bits = constDiv };
            }
            
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int10x4)((short4)left / (short)right);
            }
            
            UInt10x4 negQuotient = (UInt10x4)(left ^ right) >> (default(Int10).Bits - 1);
            left = new Int10x4 { Bits = SWAR.Abs<Int10>(left.Bits) };
            right = abs(right);
            
            UInt10x4 absResult = (UInt10x4)left / (uint)right;
            absResult = (absResult ^ new UInt10x4 { Bits = SWAR.NegBool<Int10>(negQuotient.Bits) }) + negQuotient;

            return new Int10x4 { Bits = absResult.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator / (int left, Int10x4 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int10x4)((short)left / (short4)right);
            }
            
            UInt10x4 negQuotient = (UInt10x4)(left ^ right) >> (default(Int10).Bits - 1);
            left = abs(left);
            right = new Int10x4 { Bits = SWAR.Abs<Int10>(right.Bits) };
            
            UInt10x4 absResult = (uint)left / (UInt10x4)right;
            absResult = (absResult ^ new UInt10x4 { Bits = SWAR.NegBool<Int10>(negQuotient.Bits) }) + negQuotient;

            return new Int10x4 { Bits = absResult.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator % (Int10x4 left, Int10x4 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int10x4)((short4)left % (short4)right);
            }
            
            return new Int10x4((short)(left[0] % right[0]),
                               (short)(left[1] % right[1]),
                               (short)(left[2] % right[2]),
                               (short)(left[3] % right[3]));
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator % (Int10x4 left, int right)
        {
            if (SWAR.ConstRem<Int10>(left.Bits, right, out ulong constRem))
            {
                return new Int10x4 { Bits = constRem };
            }
            
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int10x4)((short4)left % (short)right);
            }
            
            return new Int10x4((short)(left[0] % right),
                               (short)(left[1] % right),
                               (short)(left[2] % right),
                               (short)(left[3] % right));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator % (int left, Int10x4 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int10x4)((short)left % (short4)right);
            }
            
            return new Int10x4((short)(left % right[0]),
                               (short)(left % right[1]),
                               (short)(left % right[2]),
                               (short)(left % right[3]));
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator << (Int10x4 left, int right) => (Int10x4)((UInt10x4)left << right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator >> (Int10x4 left, int right) => new Int10x4 { Bits = SWAR.ShiftRightArithmetic<Int10>(left.Bits, right) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator ~ (Int10x4 value) => (Int10x4)~(UInt10x4)value;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator ^ (Int10x4 left, Int10x4 right) => (Int10x4)((UInt10x4)left ^ (UInt10x4)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator ^ (Int10x4 left, int right) => left ^ new Int10x4((short)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator ^ (int left, Int10x4 right) => new Int10x4((short)left) ^ right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator & (Int10x4 left, Int10x4 right) => (Int10x4)((UInt10x4)left & (UInt10x4)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator & (Int10x4 left, int right) => left & new Int10x4((short)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator & (int left, Int10x4 right) => new Int10x4((short)left) & right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator | (Int10x4 left, Int10x4 right) => (Int10x4)((UInt10x4)left | (UInt10x4)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator | (Int10x4 left, int right) => left | new Int10x4((short)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator | (int left, Int10x4 right) => new Int10x4((short)left) | right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator == (Int10x4 left, Int10x4 right) => (Int10x4)((UInt10x4)left == (UInt10x4)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator == (Int10x4 left, int right) => left == new Int10x4((short)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator == (int left, Int10x4 right) => new Int10x4((short)left) == right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator != (Int10x4 left, Int10x4 right) => (Int10x4)((UInt10x4)left != (UInt10x4)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator != (Int10x4 left, int right) => left != new Int10x4((short)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator != (int left, Int10x4 right) => new Int10x4((short)left) != right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator < (Int10x4 left, Int10x4 right) => new Int10x4 { Bits = SWAR.LessThan<Int10>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator < (Int10x4 left, int right) => left < new Int10x4((short)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator < (int left, Int10x4 right) => right > left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator > (Int10x4 left, Int10x4 right) => new Int10x4 { Bits = SWAR.GreaterThan<Int10>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator > (Int10x4 left, int right) => left > new Int10x4((short)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator > (int left, Int10x4 right) => right < left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator <= (Int10x4 left, Int10x4 right) => new Int10x4 { Bits = SWAR.LessThanOrEqual<Int10>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator <= (Int10x4 left, int right) => left <= new Int10x4((short)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator <= (int left, Int10x4 right) => right >= left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator >= (Int10x4 left, Int10x4 right) => new Int10x4 { Bits = SWAR.GreaterThanOrEqual<Int10>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator >= (Int10x4 left, int right) => left >= new Int10x4((short)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int10x4 operator >= (int left, Int10x4 right) => right <= left;

        
        public int this[int index]
        {
            [return: AssumeRange((long)Int10.MinValue, (long)Int10.MaxValue)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (int)BitFieldHelper.Get<Int10>(Bits, default(Int10).Bits * index, default(Int10).Bits * Length);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Bits = BitFieldHelper.Set<Int10>(Bits, (int)value, default(Int10).Bits * index, default(Int10).Bits * Length);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Int10x4 SetReplicate(int index, int numNumbers, uint value)
        {
            return new Int10x4 { Bits = BitFieldHelper.SetReplicate<Int10>(Bits, (int)value, numNumbers, default(Int10).Bits * index, default(Int10).Bits * Length) };
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Int10x4 other)
        {
            return this.Bits == other.Bits;
        }

        public override readonly bool Equals(object obj)
        {
            return obj is Int10x4 converted && this.Equals(converted);
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
            return new ArrayEnumerator<Int10x4, int>(this);
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<Int10x4, int>(this);
        }
    }
}