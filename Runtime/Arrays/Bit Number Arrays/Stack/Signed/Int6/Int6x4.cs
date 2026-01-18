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
    unsafe public struct Int6x4 : IArray<int>, IEquatable<Int6x4>
    {
        public UInt24 Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int6x4(sbyte xyzw)
        {
            this = (Int6x4)new UInt6x4((byte)ValueHelper.TruncBits<Int6>(xyzw));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int6x4(sbyte x, sbyte y, sbyte z, sbyte w)
        {
            this = (Int6x4)new UInt6x4((byte)ValueHelper.TruncBits<Int6>(x),
                                       (byte)ValueHelper.TruncBits<Int6>(y),
                                       (byte)ValueHelper.TruncBits<Int6>(z),
                                       (byte)                            w);
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
        public static explicit operator UInt6x4(Int6x4 input) => input.Reinterpret<Int6x4, UInt6x4>();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int6x4(UInt6x4 input) => input.Reinterpret<UInt6x4, Int6x4>();


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int10x4(Int6x4 input) => (Int10x4)(short4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int12x4(Int6x4 input) => (Int12x4)(short4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int14x4(Int6x4 input) => (Int14x4)(short4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int6x4(Int10x4 input) => (Int6x4)(UInt10x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int6x4(Int12x4 input) => (Int6x4)(UInt12x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int6x4(Int14x4 input) => (Int6x4)(UInt14x4)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt10x4(Int6x4 input) => (UInt10x4)(Int10x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt12x4(Int6x4 input) => (UInt12x4)(Int12x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt14x4(Int6x4 input) => (UInt14x4)(Int14x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int6x4(UInt10x4 input) => (Int6x4)(UInt6x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int6x4(UInt12x4 input) => (Int6x4)(UInt6x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int6x4(UInt14x4 input) => (Int6x4)(UInt6x4)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte4(Int6x4 input) => (byte4)(sbyte4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort4(Int6x4 input) => (ushort4)(sbyte4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint4(Int6x4 input) => (uint4)(sbyte4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong4(Int6x4 input) => (ulong4)(sbyte4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator sbyte4(Int6x4 input) => signextend((sbyte4)(UInt6x4)input, default(Int6).Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator short4(Int6x4 input) => signextend((short4)(UInt6x4)input, default(Int6).Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int4(Int6x4 input) => signextend((int4)(UInt6x4)input, default(Int6).Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long4(Int6x4 input) => signextend((long4)(UInt6x4)input, default(Int6).Bits);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int6x4(byte4 input) => (Int6x4)(UInt6x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int6x4(ushort4 input) => (Int6x4)(UInt6x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int6x4(uint4 input) => (Int6x4)(UInt6x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int6x4(ulong4 input) => (Int6x4)(UInt6x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int6x4(sbyte4 input) => (Int6x4)(UInt6x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int6x4(short4 input) => (Int6x4)(UInt6x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int6x4(int4 input) => new Int6x4{ Bits = (UInt24)PackUnpack.DownCast<Int6>(input) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int6x4(long4 input) => new Int6x4{ Bits = (UInt24)PackUnpack.DownCast<Int6>(input) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter4(Int6x4 input) => (quarter4)(sbyte4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator half4(Int6x4 input) => (half4)(sbyte4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float4(Int6x4 input) => (float4)(sbyte4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4(Int6x4 input) => (double4)(sbyte4)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int6x4(quarter4 input) => (Int6x4)(sbyte4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int6x4(half4 input) => (Int6x4)(sbyte4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int6x4(float4 input) => (Int6x4)(sbyte4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int6x4(double4 input) => (Int6x4)(sbyte4)input;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator - (Int6x4 value) => new Int6x4 { Bits = SWAR.Neg<Int6>(value.Bits) };

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator ++ (Int6x4 value) => value + 1;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator -- (Int6x4 value) => value - 1;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator + (Int6x4 left, Int6x4 right) => (Int6x4)((UInt6x4)left + (UInt6x4)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator + (Int6x4 left, int right) => left + new Int6x4((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator + (int left, Int6x4 right) => new Int6x4((sbyte)left) + right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator - (Int6x4 left, Int6x4 right) => (Int6x4)((UInt6x4)left - (UInt6x4)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator - (Int6x4 left, int right) => left - new Int6x4((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator - (int left, Int6x4 right) => new Int6x4((sbyte)left) - right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator * (Int6x4 left, Int6x4 right) => (Int6x4)((UInt6x4)left * (UInt6x4)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator * (Int6x4 left, int right) => left * new Int6x4((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator * (int left, Int6x4 right) => new Int6x4((sbyte)left) * right;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator / (Int6x4 left, Int6x4 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int6x4)((short4)left / (short4)right);
            }
            
            UInt6x4 negQuotient = (UInt6x4)(left ^ right) >> (default(Int6).Bits - 1);
            left = new Int6x4 { Bits = SWAR.Abs<Int6>(left.Bits) };
            right = new Int6x4 { Bits = SWAR.Abs<Int6>(right.Bits) };
            
            UInt6x4 absResult = (UInt6x4)left / (UInt6x4)right;
            absResult = (absResult ^ new UInt6x4 { Bits = SWAR.NegBool<Int6>(negQuotient.Bits) }) + negQuotient;

            return new Int6x4 { Bits = absResult.Bits };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator / (Int6x4 left, int right)
        {
            if (SWAR.ConstDiv<Int6>(left.Bits, (int)right, out uint constDiv))
            {
                return new Int6x4 { Bits = constDiv };
            }
            
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int6x4)((short4)left / (short)right);
            }
            
            UInt6x4 negQuotient = (UInt6x4)(left ^ right) >> (default(Int6).Bits - 1);
            left = new Int6x4 { Bits = SWAR.Abs<Int6>(left.Bits) };
            right = abs(right);
            
            UInt6x4 absResult = (UInt6x4)left / (uint)right;
            absResult = (absResult ^ new UInt6x4 { Bits = SWAR.NegBool<Int6>(negQuotient.Bits) }) + negQuotient;

            return new Int6x4 { Bits = absResult.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator / (int left, Int6x4 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int6x4)((short)left / (short4)right);
            }
            
            UInt6x4 negQuotient = (UInt6x4)(left ^ right) >> (default(Int6).Bits - 1);
            left = abs(left);
            right = new Int6x4 { Bits = SWAR.Abs<Int6>(right.Bits) };
            
            UInt6x4 absResult = (uint)left / (UInt6x4)right;
            absResult = (absResult ^ new UInt6x4 { Bits = SWAR.NegBool<Int6>(negQuotient.Bits) }) + negQuotient;

            return new Int6x4 { Bits = absResult.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator % (Int6x4 left, Int6x4 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int6x4)((short4)left % (short4)right);
            }
            
            return new Int6x4((sbyte)(left[0] % right[0]),
                              (sbyte)(left[1] % right[1]),
                              (sbyte)(left[2] % right[2]),
                              (sbyte)(left[3] % right[3]));
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator % (Int6x4 left, int right)
        {
            if (SWAR.ConstRem<Int6>(left.Bits, (int)right, out uint constRem))
            {
                return new Int6x4 { Bits = constRem };
            }
            
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int6x4)((short4)left % (short)right);
            }
            
            return new Int6x4((sbyte)(left[0] % right),
                              (sbyte)(left[1] % right),
                              (sbyte)(left[2] % right),
                              (sbyte)(left[3] % right));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator % (int left, Int6x4 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int6x4)((short)left % (short4)right);
            }
            
            return new Int6x4((sbyte)(left % right[0]),
                              (sbyte)(left % right[1]),
                              (sbyte)(left % right[2]),
                              (sbyte)(left % right[3]));
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator << (Int6x4 left, int right) => (Int6x4)((UInt6x4)left << right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator >> (Int6x4 left, int right) => new Int6x4 { Bits = SWAR.ShiftRightArithmetic<Int6>(left.Bits, right) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator ~ (Int6x4 value) => (Int6x4)~(UInt6x4)value;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator ^ (Int6x4 left, Int6x4 right) => (Int6x4)((UInt6x4)left ^ (UInt6x4)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator ^ (Int6x4 left, int right) => left ^ new Int6x4((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator ^ (int left, Int6x4 right) => new Int6x4((sbyte)left) ^ right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator & (Int6x4 left, Int6x4 right) => (Int6x4)((UInt6x4)left & (UInt6x4)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator & (Int6x4 left, int right) => left & new Int6x4((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator & (int left, Int6x4 right) => new Int6x4((sbyte)left) & right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator | (Int6x4 left, Int6x4 right) => (Int6x4)((UInt6x4)left | (UInt6x4)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator | (Int6x4 left, int right) => left | new Int6x4((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator | (int left, Int6x4 right) => new Int6x4((sbyte)left) | right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator == (Int6x4 left, Int6x4 right) => (Int6x4)((UInt6x4)left == (UInt6x4)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator == (Int6x4 left, int right) => left == new Int6x4((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator == (int left, Int6x4 right) => new Int6x4((sbyte)left) == right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator != (Int6x4 left, Int6x4 right) => (Int6x4)((UInt6x4)left != (UInt6x4)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator != (Int6x4 left, int right) => left != new Int6x4((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator != (int left, Int6x4 right) => new Int6x4((sbyte)left) != right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator < (Int6x4 left, Int6x4 right) => new Int6x4 { Bits = SWAR.LessThan<Int6>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator < (Int6x4 left, int right) => left < new Int6x4((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator < (int left, Int6x4 right) => right > left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator > (Int6x4 left, Int6x4 right) => new Int6x4 { Bits = SWAR.GreaterThan<Int6>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator > (Int6x4 left, int right) => left > new Int6x4((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator > (int left, Int6x4 right) => right < left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator <= (Int6x4 left, Int6x4 right) => new Int6x4 { Bits = SWAR.LessThanOrEqual<Int6>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator <= (Int6x4 left, int right) => left <= new Int6x4((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator <= (int left, Int6x4 right) => right >= left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator >= (Int6x4 left, Int6x4 right) => new Int6x4 { Bits = SWAR.GreaterThanOrEqual<Int6>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator >= (Int6x4 left, int right) => left >= new Int6x4((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int6x4 operator >= (int left, Int6x4 right) => right <= left;

        
        public int this[int index]
        {
            [return: AssumeRange((long)Int6.MinValue, (long)Int6.MaxValue)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return BitFieldHelper.Get<Int6>(Bits, default(Int6).Bits * index, default(Int6).Bits * Length);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Bits = BitFieldHelper.Set<Int6>(Bits, (int)value, default(Int6).Bits * index, default(Int6).Bits * Length);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Int6x4 SetReplicate(int index, int numNumbers, uint value)
        {
            return new Int6x4 { Bits = BitFieldHelper.SetReplicate<Int6>(Bits, (int)value, numNumbers, default(Int6).Bits * index, default(Int6).Bits * Length) };
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Int6x4 other)
        {
            return this.Bits == other.Bits;
        }

        public override readonly bool Equals(object obj)
        {
            return obj is Int6x4 converted && this.Equals(converted);
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
            return new ArrayEnumerator<Int6x4, int>(this);
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<Int6x4, int>(this);
        }
    }
}