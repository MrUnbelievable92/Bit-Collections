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
    unsafe public struct Int4x4 : IArray<int>, IEquatable<Int4x4>
    {
        public ushort Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x4(sbyte xyzw)
        {
            this = (Int4x4)new UInt4x4((byte)ValueHelper.TruncBits<Int4>(xyzw));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x4(sbyte x, sbyte y, sbyte z, sbyte w)
        {
            this = (Int4x4)new UInt4x4((byte)ValueHelper.TruncBits<Int4>(x),
                                       (byte)ValueHelper.TruncBits<Int4>(y),
                                       (byte)ValueHelper.TruncBits<Int4>(z),
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
        public static explicit operator UInt4x4(Int4x4 input) => input.Reinterpret<Int4x4, UInt4x4>();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x4(UInt4x4 input) => input.Reinterpret<UInt4x4, Int4x4>();


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int6x4(Int4x4 input) => (Int6x4)(sbyte4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int10x4(Int4x4 input) => (Int10x4)(short4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int12x4(Int4x4 input) => (Int12x4)(short4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int14x4(Int4x4 input) => (Int14x4)(short4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x4(Int6x4 input) => (Int4x4)(UInt6x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x4(Int10x4 input) => (Int4x4)(UInt10x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x4(Int12x4 input) => (Int4x4)(UInt12x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x4(Int14x4 input) => (Int4x4)(UInt14x4)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt6x4(Int4x4 input) => (UInt6x4)(Int6x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt10x4(Int4x4 input) => (UInt10x4)(Int10x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt12x4(Int4x4 input) => (UInt12x4)(Int12x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt14x4(Int4x4 input) => (UInt14x4)(Int14x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x4(UInt6x4 input) => (Int4x4)(UInt4x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x4(UInt10x4 input) => (Int4x4)(UInt4x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x4(UInt12x4 input) => (Int4x4)(UInt4x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x4(UInt14x4 input) => (Int4x4)(UInt4x4)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte4(Int4x4 input) => (byte4)(sbyte4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort4(Int4x4 input) => (ushort4)(short4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint4(Int4x4 input) => (uint4)(int4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong4(Int4x4 input) => (ulong4)(long4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator sbyte4(Int4x4 input) => signextend((sbyte4)(UInt4x4)input, default(Int4).Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator short4(Int4x4 input) => signextend((short4)(UInt4x4)input, default(Int4).Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int4(Int4x4 input) => signextend((int4)(UInt4x4)input, default(Int4).Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long4(Int4x4 input) => signextend((long4)(UInt4x4)input, default(Int4).Bits);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x4(byte4 input) => (Int4x4)(UInt4x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x4(ushort4 input) => (Int4x4)(UInt4x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x4(uint4 input) => (Int4x4)(UInt4x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x4(ulong4 input) => (Int4x4)(UInt4x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x4(sbyte4 input) => (Int4x4)(UInt4x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x4(short4 input) => (Int4x4)(UInt4x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x4(int4 input) => new Int4x4{ Bits = (ushort)PackUnpack.DownCast<Int4>(input) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x4(long4 input) => new Int4x4{ Bits = (ushort)PackUnpack.DownCast<Int4>(input) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator quarter4(Int4x4 input) => (quarter4)(sbyte4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator half4(Int4x4 input) => (half4)(short4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float4(Int4x4 input) => (float4)(int4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4(Int4x4 input) => (double4)(int4)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x4(quarter4 input) => (Int4x4)(sbyte4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x4(half4 input) => (Int4x4)(short4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x4(float4 input) => (Int4x4)(int4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x4(double4 input) => (Int4x4)(int4)input;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator - (Int4x4 value) => new Int4x4 { Bits = SWAR.Neg<Int4>(value.Bits) };

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator ++ (Int4x4 value) => value + 1;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator -- (Int4x4 value) => value - 1;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator + (Int4x4 left, Int4x4 right) => (Int4x4)((UInt4x4)left + (UInt4x4)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator + (Int4x4 left, int right) => left + new Int4x4((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator + (int left, Int4x4 right) => new Int4x4((sbyte)left) + right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator - (Int4x4 left, Int4x4 right) => (Int4x4)((UInt4x4)left - (UInt4x4)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator - (Int4x4 left, int right) => left - new Int4x4((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator - (int left, Int4x4 right) => new Int4x4((sbyte)left) - right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator * (Int4x4 left, Int4x4 right) => (Int4x4)((UInt4x4)left * (UInt4x4)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator * (Int4x4 left, int right) => left * new Int4x4((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator * (int left, Int4x4 right) => new Int4x4((sbyte)left) * right;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator / (Int4x4 left, Int4x4 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int4x4)((short4)left / (short4)right);
            }
            
            UInt4x4 negQuotient = (UInt4x4)(left ^ right) >> (default(Int4).Bits - 1);
            left = new Int4x4 { Bits = SWAR.Abs<Int4>(left.Bits) };
            right = new Int4x4 { Bits = SWAR.Abs<Int4>(right.Bits) };
            
            UInt4x4 absResult = (UInt4x4)left / (UInt4x4)right;
            absResult = (absResult ^ new UInt4x4 { Bits = SWAR.NegBool<Int4>(negQuotient.Bits) }) + negQuotient;

            return new Int4x4 { Bits = absResult.Bits };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator / (Int4x4 left, int right)
        {
            if (SWAR.ConstDiv<Int4>(left.Bits, (short)right, out ushort constDiv))
            {
                return new Int4x4 { Bits = constDiv };
            }
            
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int4x4)((short4)left / (short)right);
            }
            
            UInt4x4 negQuotient = (UInt4x4)(left ^ right) >> (default(Int4).Bits - 1);
            left = new Int4x4 { Bits = SWAR.Abs<Int4>(left.Bits) };
            right = abs(right);
            
            UInt4x4 absResult = (UInt4x4)left / (uint)right;
            absResult = (absResult ^ new UInt4x4 { Bits = SWAR.NegBool<Int4>(negQuotient.Bits) }) + negQuotient;

            return new Int4x4 { Bits = absResult.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator / (int left, Int4x4 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int4x4)((short)left / (short4)right);
            }
            
            UInt4x4 negQuotient = (UInt4x4)(left ^ right) >> (default(Int4).Bits - 1);
            left = abs(left);
            right = new Int4x4 { Bits = SWAR.Abs<Int4>(right.Bits) };
            
            UInt4x4 absResult = (uint)left / (UInt4x4)right;
            absResult = (absResult ^ new UInt4x4 { Bits = SWAR.NegBool<Int4>(negQuotient.Bits) }) + negQuotient;

            return new Int4x4 { Bits = absResult.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator % (Int4x4 left, Int4x4 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int4x4)((short4)left % (short4)right);
            }
            
            return new Int4x4((sbyte)(left[0] % right[0]),
                              (sbyte)(left[1] % right[1]),
                              (sbyte)(left[2] % right[2]),
                              (sbyte)(left[3] % right[3]));
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator % (Int4x4 left, int right)
        {
            if (SWAR.ConstRem<Int4>(left.Bits, (short)right, out ushort constRem))
            {
                return new Int4x4 { Bits = constRem };
            }
            
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int4x4)((short4)left % (short)right);
            }
            
            return new Int4x4((sbyte)(left[0] % right),
                              (sbyte)(left[1] % right),
                              (sbyte)(left[2] % right),
                              (sbyte)(left[3] % right));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator % (int left, Int4x4 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int4x4)((short)left % (short4)right);
            }
            
            return new Int4x4((sbyte)(left % right[0]),
                              (sbyte)(left % right[1]),
                              (sbyte)(left % right[2]),
                              (sbyte)(left % right[3]));
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator << (Int4x4 left, int right) => (Int4x4)((UInt4x4)left << right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator >> (Int4x4 left, int right) => new Int4x4 { Bits = SWAR.ShiftRightArithmetic<Int4>(left.Bits, right) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator ~ (Int4x4 value) => (Int4x4)~(UInt4x4)value;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator ^ (Int4x4 left, Int4x4 right) => (Int4x4)((UInt4x4)left ^ (UInt4x4)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator ^ (Int4x4 left, int right) => left ^ new Int4x4((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator ^ (int left, Int4x4 right) => new Int4x4((sbyte)left) ^ right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator & (Int4x4 left, Int4x4 right) => (Int4x4)((UInt4x4)left & (UInt4x4)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator & (Int4x4 left, int right) => left & new Int4x4((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator & (int left, Int4x4 right) => new Int4x4((sbyte)left) & right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator | (Int4x4 left, Int4x4 right) => (Int4x4)((UInt4x4)left | (UInt4x4)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator | (Int4x4 left, int right) => left | new Int4x4((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator | (int left, Int4x4 right) => new Int4x4((sbyte)left) | right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator == (Int4x4 left, Int4x4 right) => (Int4x4)((UInt4x4)left == (UInt4x4)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator == (Int4x4 left, int right) => left == new Int4x4((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator == (int left, Int4x4 right) => new Int4x4((sbyte)left) == right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator != (Int4x4 left, Int4x4 right) => (Int4x4)((UInt4x4)left != (UInt4x4)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator != (Int4x4 left, int right) => left != new Int4x4((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator != (int left, Int4x4 right) => new Int4x4((sbyte)left) != right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator < (Int4x4 left, Int4x4 right) => new Int4x4 { Bits = SWAR.LessThan<Int4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator < (Int4x4 left, int right) => left < new Int4x4((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator < (int left, Int4x4 right) => right > left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator > (Int4x4 left, Int4x4 right) => new Int4x4 { Bits = SWAR.GreaterThan<Int4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator > (Int4x4 left, int right) => left > new Int4x4((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator > (int left, Int4x4 right) => right < left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator <= (Int4x4 left, Int4x4 right) => new Int4x4 { Bits = SWAR.LessThanOrEqual<Int4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator <= (Int4x4 left, int right) => left <= new Int4x4((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator <= (int left, Int4x4 right) => right >= left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator >= (Int4x4 left, Int4x4 right) => new Int4x4 { Bits = SWAR.GreaterThanOrEqual<Int4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator >= (Int4x4 left, int right) => left >= new Int4x4((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator >= (int left, Int4x4 right) => right <= left;

        
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
                Bits = (ushort)BitFieldHelper.Set<Int4>(Bits, (int)value, default(Int4).Bits * index, default(Int4).Bits * Length);
            }
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Int4x4 SetReplicate(int index, int numNumbers, uint value)
        {
            return new Int4x4 { Bits = (ushort)BitFieldHelper.SetReplicate<Int4>(Bits, (int)value, numNumbers, default(Int4).Bits * index, default(Int4).Bits * Length) };
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Int4x4 other)
        {
            return this.Bits == other.Bits;
        }

        public override readonly bool Equals(object obj)
        {
            return obj is Int4x4 converted && this.Equals(converted);
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
            return new ArrayEnumerator<Int4x4, int>(this);
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<Int4x4, int>(this);
        }
    }
}