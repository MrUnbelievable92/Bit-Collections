using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;
using Unity.Mathematics;
using MaxMath.Intrinsics;

using static MaxMath.maxmath;
using MaxMath;

namespace BitCollections
{
    [Serializable]
    unsafe public struct Int2x4 : IArray<int>, IEquatable<Int2x4>
    {
        public byte Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x4(sbyte xyzw)
        {
            this = (Int2x4)new UInt2x4((byte)ValueHelper.TruncBits<Int2>(xyzw));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x4(sbyte x, sbyte y, sbyte z, sbyte w)
        {
            this = (Int2x4)new UInt2x4((byte)ValueHelper.TruncBits<Int2>(x),
                                       (byte)ValueHelper.TruncBits<Int2>(y),
                                       (byte)ValueHelper.TruncBits<Int2>(z),
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
        public static explicit operator UInt2x4(Int2x4 input) => input.Reinterpret<Int2x4, UInt2x4>();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x4(UInt2x4 input) => input.Reinterpret<UInt2x4, Int2x4>();


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int4x4(Int2x4 input) => (Int4x4)(sbyte4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int6x4(Int2x4 input) => (Int6x4)(sbyte4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int10x4(Int2x4 input) => (Int10x4)(short4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int12x4(Int2x4 input) => (Int12x4)(short4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int14x4(Int2x4 input) => (Int14x4)(short4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x4(Int4x4 input) => (Int2x4)(UInt4x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x4(Int6x4 input) => (Int2x4)(UInt6x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x4(Int10x4 input) => (Int2x4)(UInt10x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x4(Int12x4 input) => (Int2x4)(UInt12x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x4(Int14x4 input) => (Int2x4)(UInt14x4)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x4(Int2x4 input) => (UInt4x4)(Int4x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt6x4(Int2x4 input) => (UInt6x4)(Int6x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt10x4(Int2x4 input) => (UInt10x4)(Int10x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt12x4(Int2x4 input) => (UInt12x4)(Int12x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt14x4(Int2x4 input) => (UInt14x4)(Int14x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x4(UInt4x4 input) => (Int2x4)(UInt2x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x4(UInt6x4 input) => (Int2x4)(UInt2x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x4(UInt10x4 input) => (Int2x4)(UInt2x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x4(UInt12x4 input) => (Int2x4)(UInt2x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x4(UInt14x4 input) => (Int2x4)(UInt2x4)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte4(Int2x4 input) => (byte4)(sbyte4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort4(Int2x4 input) => (ushort4)(short4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint4(Int2x4 input) => (uint4)(int4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong4(Int2x4 input) => (ulong4)(long4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator sbyte4(Int2x4 input) => signextend((sbyte4)(UInt2x4)input, default(Int2).Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator short4(Int2x4 input) => signextend((short4)(UInt2x4)input, default(Int2).Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int4(Int2x4 input) => signextend((int4)(UInt2x4)input, default(Int2).Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long4(Int2x4 input) => signextend((long4)(UInt2x4)input, default(Int2).Bits);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x4(byte4 input) => (Int2x4)(UInt2x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x4(ushort4 input) => (Int2x4)(UInt2x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x4(uint4 input) => (Int2x4)(UInt2x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x4(ulong4 input) => (Int2x4)(UInt2x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x4(sbyte4 input) => (Int2x4)(UInt2x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x4(short4 input) => (Int2x4)(UInt2x4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x4(int4 input) => new Int2x4{ Bits = (byte)PackUnpack.DownCast<Int2>(input) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x4(long4 input) => new Int2x4{ Bits = (byte)PackUnpack.DownCast<Int2>(input) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator quarter4(Int2x4 input) => (quarter4)(sbyte4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator half4(Int2x4 input) => (half4)(short4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float4(Int2x4 input) => (float4)(int4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4(Int2x4 input) => (double4)(int4)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x4(quarter4 input) => (Int2x4)(sbyte4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x4(half4 input) => (Int2x4)(short4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x4(float4 input) => (Int2x4)(int4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x4(double4 input) => (Int2x4)(int4)input;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator - (Int2x4 value) => new Int2x4 { Bits = SWAR.Neg<Int2>(value.Bits) };

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator ++ (Int2x4 value) => value + 1;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator -- (Int2x4 value) => value - 1;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator + (Int2x4 left, Int2x4 right) => (Int2x4)((UInt2x4)left + (UInt2x4)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator + (Int2x4 left, int right) => left + new Int2x4((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator + (int left, Int2x4 right) => new Int2x4((sbyte)left) + right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator - (Int2x4 left, Int2x4 right) => (Int2x4)((UInt2x4)left - (UInt2x4)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator - (Int2x4 left, int right) => left - new Int2x4((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator - (int left, Int2x4 right) => new Int2x4((sbyte)left) - right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator * (Int2x4 left, Int2x4 right) => (Int2x4)((UInt2x4)left * (UInt2x4)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator * (Int2x4 left, int right) => left * new Int2x4((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator * (int left, Int2x4 right) => new Int2x4((sbyte)left) * right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator / (Int2x4 left, Int2x4 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int2x4)((short4)left / (short4)right);
            }
            
            return new Int2x4 { Bits = SWAR.DivRem<Int2>(left.Bits, right.Bits, out _) };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator / (Int2x4 left, int right)
        {
            if (SWAR.ConstDiv<Int2>(left.Bits, (sbyte)right, out byte constDiv))
            {
                return new Int2x4 { Bits = constDiv };
            }
            
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int2x4)((short4)left / (short)right);
            }

            return new Int2x4 { Bits = SWAR.DivRem<Int2>(left.Bits, new Int2x4((sbyte)right).Bits, out _) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator / (int left, Int2x4 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int2x4)((short)left / (short4)right);
            }
            
            return new Int2x4 { Bits = SWAR.DivRem<Int2>(new Int2x4((sbyte)left).Bits, right.Bits, out _) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator % (Int2x4 left, Int2x4 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int2x4)((short4)left % (short4)right);
            }
            
            return new Int2x4((sbyte)(left[0] % right[0]),
                              (sbyte)(left[1] % right[1]),
                              (sbyte)(left[2] % right[2]),
                              (sbyte)(left[3] % right[3]));
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator % (Int2x4 left, int right)
        {
            if (SWAR.ConstRem<Int2>(left.Bits, (sbyte)right, out byte constRem))
            {
                return new Int2x4 { Bits = constRem };
            }
            
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int2x4)((short4)left % (short)right);
            }
            
            return new Int2x4((sbyte)(left[0] % right),
                              (sbyte)(left[1] % right),
                              (sbyte)(left[2] % right),
                              (sbyte)(left[3] % right));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator % (int left, Int2x4 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int2x4)((short)left % (short4)right);
            }
            
            return new Int2x4((sbyte)(left % right[0]),
                              (sbyte)(left % right[1]),
                              (sbyte)(left % right[2]),
                              (sbyte)(left % right[3]));
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator << (Int2x4 left, int right) => (Int2x4)((UInt2x4)left << right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator >> (Int2x4 left, int right) => new Int2x4 { Bits = SWAR.ShiftRightArithmetic<Int2>(left.Bits, right) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator ~ (Int2x4 value) => (Int2x4)~(UInt2x4)value;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator ^ (Int2x4 left, Int2x4 right) => (Int2x4)((UInt2x4)left ^ (UInt2x4)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator ^ (Int2x4 left, int right) => left ^ new Int2x4((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator ^ (int left, Int2x4 right) => new Int2x4((sbyte)left) ^ right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator & (Int2x4 left, Int2x4 right) => (Int2x4)((UInt2x4)left & (UInt2x4)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator & (Int2x4 left, int right) => left & new Int2x4((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator & (int left, Int2x4 right) => new Int2x4((sbyte)left) & right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator | (Int2x4 left, Int2x4 right) => (Int2x4)((UInt2x4)left | (UInt2x4)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator | (Int2x4 left, int right) => left | new Int2x4((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator | (int left, Int2x4 right) => new Int2x4((sbyte)left) | right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator == (Int2x4 left, Int2x4 right) => (Int2x4)((UInt2x4)left == (UInt2x4)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator == (Int2x4 left, int right) => left == new Int2x4((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator == (int left, Int2x4 right) => new Int2x4((sbyte)left) == right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator != (Int2x4 left, Int2x4 right) => (Int2x4)((UInt2x4)left != (UInt2x4)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator != (Int2x4 left, int right) => left != new Int2x4((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator != (int left, Int2x4 right) => new Int2x4((sbyte)left) != right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator < (Int2x4 left, Int2x4 right) => new Int2x4 { Bits = SWAR.LessThan<Int2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator < (Int2x4 left, int right) => left < new Int2x4((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator < (int left, Int2x4 right) => right > left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator > (Int2x4 left, Int2x4 right) => new Int2x4 { Bits = SWAR.GreaterThan<Int2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator > (Int2x4 left, int right) => left > new Int2x4((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator > (int left, Int2x4 right) => right < left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator <= (Int2x4 left, Int2x4 right) => new Int2x4 { Bits = SWAR.LessThanOrEqual<Int2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator <= (Int2x4 left, int right) => left <= new Int2x4((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator <= (int left, Int2x4 right) => right >= left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator >= (Int2x4 left, Int2x4 right) => new Int2x4 { Bits = SWAR.GreaterThanOrEqual<Int2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator >= (Int2x4 left, int right) => left >= new Int2x4((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator >= (int left, Int2x4 right) => right <= left;

        
        public int this[int index]
        {
            [return: AssumeRange((long)Int2.MinValue, (long)Int2.MaxValue)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return BitFieldHelper.Get<Int2>(Bits, default(Int2).Bits * index, default(Int2).Bits * Length);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Bits = (byte)BitFieldHelper.Set<Int2>(Bits, (int)value, default(Int2).Bits * index, default(Int2).Bits * Length);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Int2x4 SetReplicate(int index, int numNumbers, uint value)
        {
            return new Int2x4 { Bits = (byte)BitFieldHelper.SetReplicate<Int2>(Bits, (int)value, numNumbers, default(Int2).Bits * index, default(Int2).Bits * Length) };
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Int2x4 other)
        {
            return this.Bits == other.Bits;
        }

        public override readonly bool Equals(object obj)
        {
            return obj is Int2x4 converted && this.Equals(converted);
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
            return new ArrayEnumerator<Int2x4, int>(this);
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<Int2x4, int>(this);
        }
    }
}