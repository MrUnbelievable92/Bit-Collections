using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;
using MaxMath;
using MaxMath.Intrinsics;

using static MaxMath.maxmath;

namespace BitCollections
{
    [Serializable]
    unsafe public struct Int3x8 : IArray<int>, IEquatable<Int3x8>
    {
        public UInt24 Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int3x8(sbyte x0, sbyte x1, sbyte x2, sbyte x3, sbyte x4, sbyte x5, sbyte x6, sbyte x7)
        {
            this = (Int3x8)new UInt3x8((byte)ValueHelper.TruncBits<Int3>(x0),
                                       (byte)ValueHelper.TruncBits<Int3>(x1),
                                       (byte)ValueHelper.TruncBits<Int3>(x2),
                                       (byte)ValueHelper.TruncBits<Int3>(x3),
                                       (byte)ValueHelper.TruncBits<Int3>(x4),
                                       (byte)ValueHelper.TruncBits<Int3>(x5),
                                       (byte)ValueHelper.TruncBits<Int3>(x6),
                                       (byte)                            x7);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int3x8(sbyte x0_7)
        {
            this = (Int3x8)new UInt3x8((byte)ValueHelper.TruncBits<Int3>(x0_7));
        }


        public readonly int Length => 8;


        public int x0
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[0];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[0] = value;
        }
        public int x1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[1];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[1] = value;
        }
        public int x2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[2];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[2] = value;
        }
        public int x3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[3];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[3] = value;
        }
        public int x4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[4];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[4] = value;
        }
        public int x5
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[5];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[5] = value;
        }
        public int x6
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[6];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[6] = value;
        }
        public int x7
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[7];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[7] = value;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt3x8(Int3x8 input) => input.Reinterpret<Int3x8, UInt3x8>();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int3x8(UInt3x8 input) => input.Reinterpret<UInt3x8, Int3x8>();


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int4x8(Int3x8 input) => (Int4x8)(sbyte8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int5x8(Int3x8 input) => (Int5x8)(sbyte8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int6x8(Int3x8 input) => (Int6x8)(sbyte8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int7x8(Int3x8 input) => (Int7x8)(sbyte8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int3x8(Int4x8 input) => (Int3x8)(UInt4x8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int3x8(Int5x8 input) => (Int3x8)(UInt6x8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int3x8(Int6x8 input) => (Int3x8)(UInt6x8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int3x8(Int7x8 input) => (Int3x8)(UInt7x8)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x8(Int3x8 input) => (UInt4x8)(Int4x8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt5x8(Int3x8 input) => (UInt5x8)(Int5x8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt6x8(Int3x8 input) => (UInt6x8)(Int6x8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt7x8(Int3x8 input) => (UInt7x8)(Int7x8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int3x8(UInt4x8 input) => (Int3x8)(UInt3x8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int3x8(UInt5x8 input) => (Int3x8)(UInt3x8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int3x8(UInt6x8 input) => (Int3x8)(UInt3x8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int3x8(UInt7x8 input) => (Int3x8)(UInt3x8)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte8(Int3x8 input) => (byte8)(sbyte8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort8(Int3x8 input) => (ushort8)(short8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint8(Int3x8 input) => (uint8)(int8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator sbyte8(Int3x8 input) => signextend((sbyte8)(UInt3x8)input, default(Int3).Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator short8(Int3x8 input) => signextend((short8)(UInt3x8)input, default(Int3).Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int8(Int3x8 input) => signextend((int8)(UInt3x8)input, default(Int3).Bits);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int3x8(byte8 input) => (Int3x8)(UInt3x8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int3x8(ushort8 input) => (Int3x8)(UInt3x8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int3x8(uint8 input) => (Int3x8)(UInt3x8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int3x8(sbyte8 input) => (Int3x8)(UInt3x8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int3x8(short8 input) => new Int3x8{ Bits = (UInt24)PackUnpack.DownCast<Int3>(input) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int3x8(int8 input) => new Int3x8{ Bits = (UInt24)PackUnpack.DownCast<Int3>(input) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator quarter8(Int3x8 input) => (quarter8)(sbyte8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator half8(Int3x8 input) => (half8)(short8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float8(Int3x8 input) => (float8)(int8)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int3x8(quarter8 input) => (Int3x8)(sbyte8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int3x8(half8 input) => (Int3x8)(short8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int3x8(float8 input) => (Int3x8)(int8)input;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator - (Int3x8 value) => new Int3x8 { Bits = SWAR.Neg<Int3>(value.Bits) };

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator ++ (Int3x8 value) => value + 1;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator -- (Int3x8 value) => value - 1;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator + (Int3x8 left, Int3x8 right) => (Int3x8)((UInt3x8)left + (UInt3x8)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator + (Int3x8 left, int right) => left + new Int3x8((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator + (int left, Int3x8 right) => new Int3x8((sbyte)left) + right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator - (Int3x8 left, Int3x8 right) => (Int3x8)((UInt3x8)left - (UInt3x8)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator - (Int3x8 left, int right) => left - new Int3x8((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator - (int left, Int3x8 right) => new Int3x8((sbyte)left) - right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator * (Int3x8 left, Int3x8 right) => (Int3x8)((UInt3x8)left * (UInt3x8)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator * (Int3x8 left, int right) => left * new Int3x8((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator * (int left, Int3x8 right) => new Int3x8((sbyte)left) * right;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator / (Int3x8 left, Int3x8 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int3x8)((sbyte8)left / (sbyte8)right);
            }
            
            return new Int3x8 { Bits = SWAR.DivRem<Int3>(left.Bits, right.Bits, out _) };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator / (Int3x8 left, int right)
        {
            if (SWAR.ConstDiv<Int3>(left.Bits, (int)right, out uint constDiv))
            {
                return new Int3x8 { Bits = constDiv };
            }
            
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int3x8)((sbyte8)left / (sbyte)right);
            }
            
            return new Int3x8 { Bits = SWAR.DivRem<Int3>(left.Bits, new Int3x8((sbyte)right).Bits, out _) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator / (int left, Int3x8 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int3x8)((sbyte)left / (sbyte8)right);
            }
            
            return new Int3x8 { Bits = SWAR.DivRem<Int3>(new Int3x8((sbyte)left).Bits, right.Bits, out _) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator % (Int3x8 left, Int3x8 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int3x8)((sbyte8)left % (sbyte8)right);
            }
            
            SWAR.DivRem<Int3>(left.Bits, right.Bits, out uint r);

            return new Int3x8 { Bits = r };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator % (Int3x8 left, int right)
        {
            if (SWAR.ConstRem<Int3>(left.Bits, right, out uint constRem))
            {
                return new Int3x8 { Bits = constRem };
            }
            
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int3x8)((sbyte8)left % (sbyte)right);
            }
            
            SWAR.DivRem<Int3>(left.Bits, new Int3x8((sbyte)right).Bits, out uint r);

            return new Int3x8 { Bits = r };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator % (int left, Int3x8 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int3x8)((sbyte)left % (sbyte8)right);
            }
            
            SWAR.DivRem<Int3>(new Int3x8((sbyte)left).Bits, right.Bits, out uint r);

            return new Int3x8 { Bits = r };
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator << (Int3x8 left, int right) => (Int3x8)((UInt3x8)left << right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator >> (Int3x8 left, int right) => new Int3x8 { Bits = SWAR.ShiftRightArithmetic<Int3>(left.Bits, right) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator ~ (Int3x8 value) => (Int3x8)~(UInt3x8)value;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator ^ (Int3x8 left, Int3x8 right) => (Int3x8)((UInt3x8)left ^ (UInt3x8)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator ^ (Int3x8 left, int right) => left ^ new Int3x8((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator ^ (int left, Int3x8 right) => new Int3x8((sbyte)left) ^ right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator & (Int3x8 left, Int3x8 right) => (Int3x8)((UInt3x8)left & (UInt3x8)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator & (Int3x8 left, int right) => left & new Int3x8((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator & (int left, Int3x8 right) => new Int3x8((sbyte)left) & right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator | (Int3x8 left, Int3x8 right) => (Int3x8)((UInt3x8)left | (UInt3x8)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator | (Int3x8 left, int right) => left | new Int3x8((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator | (int left, Int3x8 right) => new Int3x8((sbyte)left) | right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator == (Int3x8 left, Int3x8 right) => (Int3x8)((UInt3x8)left == (UInt3x8)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator == (Int3x8 left, int right) => left == new Int3x8((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator == (int left, Int3x8 right) => new Int3x8((sbyte)left) == right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator != (Int3x8 left, Int3x8 right) => (Int3x8)((UInt3x8)left != (UInt3x8)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator != (Int3x8 left, int right) => left != new Int3x8((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator != (int left, Int3x8 right) => new Int3x8((sbyte)left) != right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator < (Int3x8 left, Int3x8 right) => new Int3x8 { Bits = SWAR.LessThan<Int3>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator < (Int3x8 left, int right) => left < new Int3x8((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator < (int left, Int3x8 right) => right > left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator > (Int3x8 left, Int3x8 right) => new Int3x8 { Bits = SWAR.GreaterThan<Int3>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator > (Int3x8 left, int right) => left > new Int3x8((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator > (int left, Int3x8 right) => right < left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator <= (Int3x8 left, Int3x8 right) => new Int3x8 { Bits = SWAR.LessThanOrEqual<Int3>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator <= (Int3x8 left, int right) => left <= new Int3x8((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator <= (int left, Int3x8 right) => right >= left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator >= (Int3x8 left, Int3x8 right) => new Int3x8 { Bits = SWAR.GreaterThanOrEqual<Int3>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator >= (Int3x8 left, int right) => left >= new Int3x8((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x8 operator >= (int left, Int3x8 right) => right <= left;

        
        public int this[int index]
        {
            [return: AssumeRange((long)Int3.MinValue, (long)Int3.MaxValue)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return BitFieldHelper.Get<Int3>(Bits, default(Int3).Bits * index, default(Int3).Bits * Length);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Bits = BitFieldHelper.Set<Int3>(Bits, (int)value, default(Int3).Bits * index, default(Int3).Bits * Length);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Int3x8 SetReplicate(int index, int numNumbers, uint value)
        {
            return new Int3x8 { Bits = BitFieldHelper.SetReplicate<Int3>(Bits, (int)value, numNumbers, default(Int3).Bits * index, default(Int3).Bits * Length) };
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Int3x8 other)
        {
            return this.Bits == other.Bits;
        }

        public override readonly bool Equals(object obj)
        {
            return obj is Int3x8 converted && this.Equals(converted);
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
            return new ArrayEnumerator<Int3x8, int>(this);
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<Int3x8, int>(this);
        }
    }
}