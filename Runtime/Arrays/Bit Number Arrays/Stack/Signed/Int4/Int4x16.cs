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
    unsafe public struct Int4x16 : IArray<int>, IEquatable<Int4x16>
    {
        public ulong Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x16(sbyte x0, sbyte x1, sbyte x2, sbyte x3, sbyte x4, sbyte x5, sbyte x6, sbyte x7, sbyte x8, sbyte x9, sbyte x10, sbyte x11, sbyte x12, sbyte x13, sbyte x14, sbyte x15)
        {
            this = (Int4x16)new UInt4x16((byte)ValueHelper.TruncBits<Int4>(x0),
                                         (byte)ValueHelper.TruncBits<Int4>(x1),
                                         (byte)ValueHelper.TruncBits<Int4>(x2),
                                         (byte)ValueHelper.TruncBits<Int4>(x3),
                                         (byte)ValueHelper.TruncBits<Int4>(x4),
                                         (byte)ValueHelper.TruncBits<Int4>(x5),
                                         (byte)ValueHelper.TruncBits<Int4>(x6),
                                         (byte)ValueHelper.TruncBits<Int4>(x7),
                                         (byte)ValueHelper.TruncBits<Int4>(x8),
                                         (byte)ValueHelper.TruncBits<Int4>(x9),
                                         (byte)ValueHelper.TruncBits<Int4>(x10),
                                         (byte)ValueHelper.TruncBits<Int4>(x11),
                                         (byte)ValueHelper.TruncBits<Int4>(x12),
                                         (byte)ValueHelper.TruncBits<Int4>(x13),
                                         (byte)ValueHelper.TruncBits<Int4>(x14),
                                         (byte)                            x15);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x16(sbyte x0_15)
        {
            this = (Int4x16)new UInt4x16((byte)ValueHelper.TruncBits<Int4>(x0_15));
        }


        public readonly int Length => 16;


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
        public int x8
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[8];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[8] = value;
        }
        public int x9
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[9];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[9] = value;
        }
        public int x10
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[10];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[10] = value;
        }
        public int x11
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[11];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[11] = value;
        }
        public int x12
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[12];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[12] = value;
        }
        public int x13
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[13];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[13] = value;
        }
        public int x14
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[14];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[14] = value;
        }
        public int x15
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[15];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[15] = value;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x16(Int4x16 input) => input.Reinterpret<Int4x16, UInt4x16>();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x16(UInt4x16 input) => input.Reinterpret<UInt4x16, Int4x16>();


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte16(Int4x16 input) => (byte16)(sbyte16)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort16(Int4x16 input) => (ushort16)(short16)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator sbyte16(Int4x16 input) => signextend((sbyte16)(UInt4x16)input, default(Int4).Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator short16(Int4x16 input) => signextend((short16)(UInt4x16)input, default(Int4).Bits);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x16(byte16 input) => (Int4x16)(UInt4x16)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x16(ushort16 input) => (Int4x16)(UInt4x16)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x16(sbyte16 input) => (Int4x16)(UInt4x16)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x16(short16 input) => (Int4x16)(UInt4x16)input;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator - (Int4x16 value) => new Int4x16 { Bits = SWAR.Neg<Int4>(value.Bits) };

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator ++ (Int4x16 value) => value + 1;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator -- (Int4x16 value) => value - 1;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator + (Int4x16 left, Int4x16 right) => (Int4x16)((UInt4x16)left + (UInt4x16)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator + (Int4x16 left, int right) => left + new Int4x16((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator + (int left, Int4x16 right) => new Int4x16((sbyte)left) + right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator - (Int4x16 left, Int4x16 right) => (Int4x16)((UInt4x16)left - (UInt4x16)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator - (Int4x16 left, int right) => left - new Int4x16((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator - (int left, Int4x16 right) => new Int4x16((sbyte)left) - right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator * (Int4x16 left, Int4x16 right) => (Int4x16)((UInt4x16)left * (UInt4x16)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator * (Int4x16 left, int right) => left * new Int4x16((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator * (int left, Int4x16 right) => new Int4x16((sbyte)left) * right;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator / (Int4x16 left, Int4x16 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return new Int4x16 { Bits = PackUnpack.DownCast<Int4>(signextend((sbyte16)PackUnpack.BitIntArrayToByte16<UInt4>(left.Bits), default(Int4).Bits) / signextend((sbyte16)PackUnpack.BitIntArrayToByte16<UInt4>(right.Bits), default(Int4).Bits)) };
            }
            
            UInt4x16 negQuotient = (UInt4x16)(left ^ right) >> (default(Int4).Bits - 1);
            left = new Int4x16 { Bits = SWAR.Abs<Int4>(left.Bits) };
            right = new Int4x16 { Bits = SWAR.Abs<Int4>(right.Bits) };
            
            UInt4x16 absResult = (UInt4x16)left / (UInt4x16)right;
            absResult = (absResult ^ new UInt4x16 { Bits = SWAR.NegBool<Int4>(negQuotient.Bits) }) + negQuotient;

            return new Int4x16 { Bits = absResult.Bits };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator / (Int4x16 left, int right)
        {
            if (SWAR.ConstDiv<Int4>(left.Bits, (long)right, out ulong constDiv))
            {
                return new Int4x16 { Bits = constDiv };
            }
            
            if (BurstArchitecture.IsSIMDSupported)
            {
                return new Int4x16 { Bits = PackUnpack.DownCast<Int4>(signextend((sbyte16)PackUnpack.BitIntArrayToByte16<UInt4>(left.Bits), default(Int4).Bits) / (sbyte)right) };
            }
            
            UInt4x16 negQuotient = (UInt4x16)(left ^ right) >> (default(Int4).Bits - 1);
            left = new Int4x16 { Bits = SWAR.Abs<Int4>(left.Bits) };
            right = abs(right);
            
            UInt4x16 absResult = (UInt4x16)left / (uint)right;
            absResult = (absResult ^ new UInt4x16 { Bits = SWAR.NegBool<Int4>(negQuotient.Bits) }) + negQuotient;

            return new Int4x16 { Bits = absResult.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator / (int left, Int4x16 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return new Int4x16 { Bits = PackUnpack.DownCast<Int4>((sbyte)left / signextend((sbyte16)PackUnpack.BitIntArrayToByte16<UInt4>(right.Bits), default(Int4).Bits)) };
            }
            
            UInt4x16 negQuotient = (UInt4x16)(left ^ right) >> (default(Int4).Bits - 1);
            left = abs(left);
            right = new Int4x16 { Bits = SWAR.Abs<Int4>(right.Bits) };
            
            UInt4x16 absResult = (uint)left / (UInt4x16)right;
            absResult = (absResult ^ new UInt4x16 { Bits = SWAR.NegBool<Int4>(negQuotient.Bits) }) + negQuotient;

            return new Int4x16 { Bits = absResult.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator % (Int4x16 left, Int4x16 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return new Int4x16 { Bits = PackUnpack.DownCast<Int4>(signextend((sbyte16)PackUnpack.BitIntArrayToByte16<UInt4>(left.Bits), default(Int4).Bits) % signextend((sbyte16)PackUnpack.BitIntArrayToByte16<UInt4>(right.Bits), default(Int4).Bits)) };
            }
            
            SWAR.DivRem<Int4>(left.Bits, right.Bits, out ulong r);

            return new Int4x16 { Bits = r };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator % (Int4x16 left, int right)
        {
            if (SWAR.ConstRem<Int4>(left.Bits, (long)right, out ulong constRem))
            {
                return new Int4x16 { Bits = constRem };
            }
            
            if (BurstArchitecture.IsSIMDSupported)
            {
                return new Int4x16 { Bits = PackUnpack.DownCast<Int4>(signextend((sbyte16)PackUnpack.BitIntArrayToByte16<UInt4>(left.Bits), default(Int4).Bits) % (sbyte)right) };
            }
            
            SWAR.DivRem<Int4>(left.Bits, new Int4x16((sbyte)right).Bits, out ulong r);

            return new Int4x16 { Bits = r };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator % (int left, Int4x16 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return new Int4x16 { Bits = PackUnpack.DownCast<Int4>((sbyte)left % signextend((sbyte16)PackUnpack.BitIntArrayToByte16<UInt4>(right.Bits), default(Int4).Bits)) };
            }
            
            SWAR.DivRem<Int4>(new Int4x16((sbyte)left).Bits, right.Bits, out ulong r);

            return new Int4x16 { Bits = r };
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator << (Int4x16 left, int right) => (Int4x16)((UInt4x16)left << right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator >> (Int4x16 left, int right) => new Int4x16 { Bits = SWAR.ShiftRightArithmetic<Int4>(left.Bits, right) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator ~ (Int4x16 value) => (Int4x16)~(UInt4x16)value;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator ^ (Int4x16 left, Int4x16 right) => (Int4x16)((UInt4x16)left ^ (UInt4x16)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator ^ (Int4x16 left, int right) => left ^ new Int4x16((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator ^ (int left, Int4x16 right) => new Int4x16((sbyte)left) ^ right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator & (Int4x16 left, Int4x16 right) => (Int4x16)((UInt4x16)left & (UInt4x16)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator & (Int4x16 left, int right) => left & new Int4x16((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator & (int left, Int4x16 right) => new Int4x16((sbyte)left) & right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator | (Int4x16 left, Int4x16 right) => (Int4x16)((UInt4x16)left | (UInt4x16)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator | (Int4x16 left, int right) => left | new Int4x16((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator | (int left, Int4x16 right) => new Int4x16((sbyte)left) | right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator == (Int4x16 left, Int4x16 right) => (Int4x16)((UInt4x16)left == (UInt4x16)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator == (Int4x16 left, int right) => left == new Int4x16((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator == (int left, Int4x16 right) => new Int4x16((sbyte)left) == right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator != (Int4x16 left, Int4x16 right) => (Int4x16)((UInt4x16)left != (UInt4x16)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator != (Int4x16 left, int right) => left != new Int4x16((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator != (int left, Int4x16 right) => new Int4x16((sbyte)left) != right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator < (Int4x16 left, Int4x16 right) => new Int4x16 { Bits = SWAR.LessThan<Int4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator < (Int4x16 left, int right) => left < new Int4x16((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator < (int left, Int4x16 right) => right > left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator > (Int4x16 left, Int4x16 right) => new Int4x16 { Bits = SWAR.GreaterThan<Int4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator > (Int4x16 left, int right) => left > new Int4x16((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator > (int left, Int4x16 right) => right < left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator <= (Int4x16 left, Int4x16 right) => new Int4x16 { Bits = SWAR.LessThanOrEqual<Int4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator <= (Int4x16 left, int right) => left <= new Int4x16((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator <= (int left, Int4x16 right) => right >= left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator >= (Int4x16 left, Int4x16 right) => new Int4x16 { Bits = SWAR.GreaterThanOrEqual<Int4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator >= (Int4x16 left, int right) => left >= new Int4x16((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x16 operator >= (int left, Int4x16 right) => right <= left;

        
        public int this[int index]
        {
            [return: AssumeRange((long)Int4.MinValue, (long)Int4.MaxValue)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (int)BitFieldHelper.Get<Int4>(Bits, default(Int4).Bits * index, default(Int4).Bits * Length);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Bits = BitFieldHelper.Set<Int4>(Bits, (int)value, default(Int4).Bits * index, default(Int4).Bits * Length);
            }
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Int4x16 SetReplicate(int index, int numNumbers, uint value)
        {
            return new Int4x16 { Bits = BitFieldHelper.SetReplicate<Int4>(Bits, (int)value, numNumbers, default(Int4).Bits * index, default(Int4).Bits * Length) };
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Int4x16 other)
        {
            return this.Bits == other.Bits;
        }

        public override readonly bool Equals(object obj)
        {
            return obj is Int4x16 converted && this.Equals(converted);
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
            return new ArrayEnumerator<Int4x16, int>(this);
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<Int4x16, int>(this);
        }
    }
}