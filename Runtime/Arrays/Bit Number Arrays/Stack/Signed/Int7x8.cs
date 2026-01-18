using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;
using MaxMath;
using MaxMath.Intrinsics;

using static MaxMath.maxmath;
using static Unity.Mathematics.math;

namespace BitCollections
{
    [Serializable]
    unsafe public struct Int7x8 : IArray<int>, IEquatable<Int7x8>
    {
        public UInt56 Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int7x8(sbyte x0, sbyte x1, sbyte x2, sbyte x3, sbyte x4, sbyte x5, sbyte x6, sbyte x7)
        {
            this = (Int7x8)new UInt7x8((byte)ValueHelper.TruncBits<Int7>(x0),
                                       (byte)ValueHelper.TruncBits<Int7>(x1),
                                       (byte)ValueHelper.TruncBits<Int7>(x2),
                                       (byte)ValueHelper.TruncBits<Int7>(x3),
                                       (byte)ValueHelper.TruncBits<Int7>(x4),
                                       (byte)ValueHelper.TruncBits<Int7>(x5),
                                       (byte)ValueHelper.TruncBits<Int7>(x6),
                                       (byte)                            x7);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int7x8(sbyte x0_7)
        {
            this = (Int7x8)new UInt7x8((byte)ValueHelper.TruncBits<Int7>(x0_7));
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
        public static explicit operator UInt7x8(Int7x8 input) => input.Reinterpret<Int7x8, UInt7x8>();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int7x8(UInt7x8 input) => input.Reinterpret<UInt7x8, Int7x8>();


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte8(Int7x8 input) => (byte8)(sbyte8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort8(Int7x8 input) => (ushort8)(short8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint8(Int7x8 input) => (uint8)(int8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator sbyte8(Int7x8 input) => signextend((sbyte8)(UInt7x8)input, default(Int7).Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator short8(Int7x8 input) => signextend((short8)(UInt7x8)input, default(Int7).Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int8(Int7x8 input) => signextend((int8)(UInt7x8)input, default(Int7).Bits);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int7x8(byte8 input) => (Int7x8)(UInt7x8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int7x8(ushort8 input) => (Int7x8)(UInt7x8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int7x8(uint8 input) => (Int7x8)(UInt7x8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int7x8(sbyte8 input) => (Int7x8)(UInt7x8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int7x8(short8 input) => new Int7x8{ Bits = (UInt56)PackUnpack.DownCast<Int7>(input) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int7x8(int8 input) => new Int7x8{ Bits = (UInt56)PackUnpack.DownCast<Int7>(input) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter8(Int7x8 input) => (quarter8)(sbyte8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator half8(Int7x8 input) => (half8)(short8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float8(Int7x8 input) => (float8)(int8)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int7x8(quarter8 input) => (Int7x8)(sbyte8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int7x8(half8 input) => (Int7x8)(short8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int7x8(float8 input) => (Int7x8)(int8)input;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator - (Int7x8 value) => new Int7x8 { Bits = SWAR.Neg<Int7>(value.Bits) };

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator ++ (Int7x8 value) => value + 1;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator -- (Int7x8 value) => value - 1;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator + (Int7x8 left, Int7x8 right) => (Int7x8)((UInt7x8)left + (UInt7x8)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator + (Int7x8 left, int right) => left + new Int7x8((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator + (int left, Int7x8 right) => new Int7x8((sbyte)left) + right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator - (Int7x8 left, Int7x8 right) => (Int7x8)((UInt7x8)left - (UInt7x8)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator - (Int7x8 left, int right) => left - new Int7x8((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator - (int left, Int7x8 right) => new Int7x8((sbyte)left) - right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator * (Int7x8 left, Int7x8 right) => (Int7x8)((UInt7x8)left * (UInt7x8)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator * (Int7x8 left, int right) => left * new Int7x8((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator * (int left, Int7x8 right) => new Int7x8((sbyte)left) * right;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator / (Int7x8 left, Int7x8 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int7x8)((sbyte8)left / (sbyte8)right);
            }
            
            UInt7x8 negQuotient = (UInt7x8)(left ^ right) >> (default(Int7).Bits - 1);
            left = new Int7x8 { Bits = SWAR.Abs<Int7>(left.Bits) };
            right = new Int7x8 { Bits = SWAR.Abs<Int7>(right.Bits) };
            
            UInt7x8 absResult = (UInt7x8)left / (UInt7x8)right;
            absResult = (absResult ^ new UInt7x8 { Bits = SWAR.NegBool<Int7>(negQuotient.Bits) }) + negQuotient;

            return new Int7x8 { Bits = absResult.Bits };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator / (Int7x8 left, int right)
        {
            if (SWAR.ConstDiv<Int7>(left.Bits, (long)right, out ulong constDiv))
            {
                return new Int7x8 { Bits = constDiv };
            }
            
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int7x8)((sbyte8)left / (sbyte)right);
            }
            
            UInt7x8 negQuotient = (UInt7x8)(left ^ right) >> (default(Int7).Bits - 1);
            left = new Int7x8 { Bits = SWAR.Abs<Int7>(left.Bits) };
            right = abs(right);
            
            UInt7x8 absResult = (UInt7x8)left / (uint)right;
            absResult = (absResult ^ new UInt7x8 { Bits = SWAR.NegBool<Int7>(negQuotient.Bits) }) + negQuotient;

            return new Int7x8 { Bits = absResult.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator / (int left, Int7x8 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int7x8)((sbyte)left / (sbyte8)right);
            }
            
            UInt7x8 negQuotient = (UInt7x8)(left ^ right) >> (default(Int7).Bits - 1);
            left = abs(left);
            right = new Int7x8 { Bits = SWAR.Abs<Int7>(right.Bits) };
            
            UInt7x8 absResult = (uint)left / (UInt7x8)right;
            absResult = (absResult ^ new UInt7x8 { Bits = SWAR.NegBool<Int7>(negQuotient.Bits) }) + negQuotient;

            return new Int7x8 { Bits = absResult.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator % (Int7x8 left, Int7x8 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int7x8)((sbyte8)left % (sbyte8)right);
            }
            
            return new Int7x8((sbyte)(left[0] % right[0]),
                              (sbyte)(left[1] % right[1]),
                              (sbyte)(left[2] % right[2]),
                              (sbyte)(left[3] % right[3]),
                              (sbyte)(left[4] % right[4]),
                              (sbyte)(left[5] % right[5]),
                              (sbyte)(left[6] % right[6]),
                              (sbyte)(left[7] % right[7]));
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator % (Int7x8 left, int right)
        {
            if (SWAR.ConstRem<Int7>(left.Bits, (long)right, out ulong constRem))
            {
                return new Int7x8 { Bits = constRem };
            }
            
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int7x8)((sbyte8)left % (sbyte)right);
            }
            
            return new Int7x8((sbyte)(left[0] % right),
                              (sbyte)(left[1] % right),
                              (sbyte)(left[2] % right),
                              (sbyte)(left[3] % right),
                              (sbyte)(left[4] % right),
                              (sbyte)(left[5] % right),
                              (sbyte)(left[6] % right),
                              (sbyte)(left[7] % right));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator % (int left, Int7x8 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (Int7x8)((sbyte)left % (sbyte8)right);
            }
            
            return new Int7x8((sbyte)(left % right[0]),
                              (sbyte)(left % right[1]),
                              (sbyte)(left % right[2]),
                              (sbyte)(left % right[3]),
                              (sbyte)(left % right[4]),
                              (sbyte)(left % right[5]),
                              (sbyte)(left % right[6]),
                              (sbyte)(left % right[7]));
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator << (Int7x8 left, int right) => (Int7x8)((UInt7x8)left << right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator >> (Int7x8 left, int right) => new Int7x8 { Bits = SWAR.ShiftRightArithmetic<Int7>(left.Bits, right) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator ~ (Int7x8 value) => (Int7x8)~(UInt7x8)value;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator ^ (Int7x8 left, Int7x8 right) => (Int7x8)((UInt7x8)left ^ (UInt7x8)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator ^ (Int7x8 left, int right) => left ^ new Int7x8((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator ^ (int left, Int7x8 right) => new Int7x8((sbyte)left) ^ right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator & (Int7x8 left, Int7x8 right) => (Int7x8)((UInt7x8)left & (UInt7x8)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator & (Int7x8 left, int right) => left & new Int7x8((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator & (int left, Int7x8 right) => new Int7x8((sbyte)left) & right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator | (Int7x8 left, Int7x8 right) => (Int7x8)((UInt7x8)left | (UInt7x8)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator | (Int7x8 left, int right) => left | new Int7x8((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator | (int left, Int7x8 right) => new Int7x8((sbyte)left) | right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator == (Int7x8 left, Int7x8 right) => (Int7x8)((UInt7x8)left == (UInt7x8)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator == (Int7x8 left, int right) => left == new Int7x8((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator == (int left, Int7x8 right) => new Int7x8((sbyte)left) == right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator != (Int7x8 left, Int7x8 right) => (Int7x8)((UInt7x8)left != (UInt7x8)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator != (Int7x8 left, int right) => left != new Int7x8((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator != (int left, Int7x8 right) => new Int7x8((sbyte)left) != right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator < (Int7x8 left, Int7x8 right) => new Int7x8 { Bits = SWAR.LessThan<Int7>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator < (Int7x8 left, int right) => left < new Int7x8((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator < (int left, Int7x8 right) => right > left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator > (Int7x8 left, Int7x8 right) => new Int7x8 { Bits = SWAR.GreaterThan<Int7>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator > (Int7x8 left, int right) => left > new Int7x8((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator > (int left, Int7x8 right) => right < left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator <= (Int7x8 left, Int7x8 right) => new Int7x8 { Bits = SWAR.LessThanOrEqual<Int7>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator <= (Int7x8 left, int right) => left <= new Int7x8((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator <= (int left, Int7x8 right) => right >= left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator >= (Int7x8 left, Int7x8 right) => new Int7x8 { Bits = SWAR.GreaterThanOrEqual<Int7>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator >= (Int7x8 left, int right) => left >= new Int7x8((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int7x8 operator >= (int left, Int7x8 right) => right <= left;

        
        public int this[int index]
        {
            [return: AssumeRange((long)Int7.MinValue, (long)Int7.MaxValue)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (int)BitFieldHelper.Get<Int7>(Bits, default(Int7).Bits * index, default(Int7).Bits * Length);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Bits = BitFieldHelper.Set<Int7>(Bits, (int)value, default(Int7).Bits * index, default(Int7).Bits * Length);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Int7x8 SetReplicate(int index, int numNumbers, uint value)
        {
            return new Int7x8 { Bits = BitFieldHelper.SetReplicate<Int7>(Bits, (int)value, numNumbers, default(Int7).Bits * index, default(Int7).Bits * Length) };
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Int7x8 other)
        {
            return this.Bits == other.Bits;
        }

        public override readonly bool Equals(object obj)
        {
            return obj is Int7x8 converted && this.Equals(converted);
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
            return new ArrayEnumerator<Int7x8, int>(this);
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<Int7x8, int>(this);
        }
    }
}