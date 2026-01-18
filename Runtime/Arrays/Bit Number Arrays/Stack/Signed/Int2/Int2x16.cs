using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;
using MaxMath;

using static MaxMath.maxmath;

namespace BitCollections
{
    [Serializable]
    unsafe public struct Int2x16 : IArray<int>, IEquatable<Int2x16>
    {
        public uint Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x16(sbyte x0, sbyte x1, sbyte x2, sbyte x3, sbyte x4, sbyte x5, sbyte x6, sbyte x7, sbyte x8, sbyte x9, sbyte x10, sbyte x11, sbyte x12, sbyte x13, sbyte x14, sbyte x15)
        {
            this = (Int2x16)new UInt2x16((byte)ValueHelper.TruncBits<Int2>(x0),
                                         (byte)ValueHelper.TruncBits<Int2>(x1),
                                         (byte)ValueHelper.TruncBits<Int2>(x2),
                                         (byte)ValueHelper.TruncBits<Int2>(x3),
                                         (byte)ValueHelper.TruncBits<Int2>(x4),
                                         (byte)ValueHelper.TruncBits<Int2>(x5),
                                         (byte)ValueHelper.TruncBits<Int2>(x6),
                                         (byte)ValueHelper.TruncBits<Int2>(x7),
                                         (byte)ValueHelper.TruncBits<Int2>(x8),
                                         (byte)ValueHelper.TruncBits<Int2>(x9),
                                         (byte)ValueHelper.TruncBits<Int2>(x10),
                                         (byte)ValueHelper.TruncBits<Int2>(x11),
                                         (byte)ValueHelper.TruncBits<Int2>(x12),
                                         (byte)ValueHelper.TruncBits<Int2>(x13),
                                         (byte)ValueHelper.TruncBits<Int2>(x14),
                                         (byte)                            x15);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x16(sbyte x0_15)
        {
            this = (Int2x16)new UInt2x16((byte)ValueHelper.TruncBits<Int2>(x0_15));
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
        public static explicit operator UInt2x16(Int2x16 input) => input.Reinterpret<Int2x16, UInt2x16>();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x16(UInt2x16 input) => input.Reinterpret<UInt2x16, Int2x16>();


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int3x16(Int2x16 input) => (Int3x16)(sbyte16)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt3x16(Int2x16 input) => (UInt3x16)(Int3x16)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int4x16(Int2x16 input) => (Int4x16)(sbyte16)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x16(Int2x16 input) => (UInt4x16)(Int4x16)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x16(Int3x16 input) => (Int2x16)(UInt3x16)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x16(UInt3x16 input) => (Int2x16)(UInt2x16)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x16(Int4x16 input) => (Int2x16)(UInt4x16)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x16(UInt4x16 input) => (Int2x16)(UInt2x16)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte16(Int2x16 input) => (byte16)(sbyte16)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort16(Int2x16 input) => (ushort16)(short16)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator sbyte16(Int2x16 input) => signextend((sbyte16)(UInt2x16)input, default(Int2).Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator short16(Int2x16 input) => signextend((short16)(UInt2x16)input, default(Int2).Bits);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x16(byte16 input) => (Int2x16)(UInt2x16)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x16(ushort16 input) => (Int2x16)(UInt2x16)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x16(sbyte16 input) => (Int2x16)(UInt2x16)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x16(short16 input) => (Int2x16)(UInt2x16)input;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator - (Int2x16 value) => new Int2x16 { Bits = SWAR.Neg<Int2>(value.Bits) };

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator ++ (Int2x16 value) => value + 1;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator -- (Int2x16 value) => value - 1;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator + (Int2x16 left, Int2x16 right) => (Int2x16)((UInt2x16)left + (UInt2x16)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator + (Int2x16 left, int right) => left + new Int2x16((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator + (int left, Int2x16 right) => new Int2x16((sbyte)left) + right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator - (Int2x16 left, Int2x16 right) => (Int2x16)((UInt2x16)left - (UInt2x16)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator - (Int2x16 left, int right) => left - new Int2x16((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator - (int left, Int2x16 right) => new Int2x16((sbyte)left) - right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator * (Int2x16 left, Int2x16 right) => (Int2x16)((UInt2x16)left * (UInt2x16)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator * (Int2x16 left, int right) => left * new Int2x16((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator * (int left, Int2x16 right) => new Int2x16((sbyte)left) * right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator / (Int2x16 left, Int2x16 right)
        {
            return new Int2x16 { Bits = SWAR.DivRem<Int2>(left.Bits, right.Bits, out _) };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator / (Int2x16 left, int right)
        {
            if (SWAR.ConstDiv<Int2>(left.Bits, (int)right, out uint constDiv))
            {
                return new Int2x16 { Bits = constDiv };
            }
            
            return new Int2x16 { Bits = SWAR.DivRem<Int2>(left.Bits, new Int2x16((sbyte)right).Bits, out _) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator / (int left, Int2x16 right)
        {
            return new Int2x16 { Bits = SWAR.DivRem<Int2>(new Int2x16((sbyte)left).Bits, right.Bits, out _) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator % (Int2x16 left, Int2x16 right)
        {
            SWAR.DivRem<Int2>(left.Bits, right.Bits, out uint rem);

            return new Int2x16 { Bits =  rem };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator % (Int2x16 left, int right)
        {
            if (SWAR.ConstRem<Int2>(left.Bits, (int)right, out uint constRem))
            {
                return new Int2x16 { Bits = constRem };
            }
            
            SWAR.DivRem<Int2>(left.Bits, new Int2x16((sbyte)right).Bits, out uint rem);

            return new Int2x16 { Bits =  rem };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator % (int left, Int2x16 right)
        {
            SWAR.DivRem<Int2>(new Int2x16((sbyte)left).Bits, right.Bits, out uint rem);

            return new Int2x16 { Bits =  rem };
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator << (Int2x16 left, int right) => (Int2x16)((UInt2x16)left << right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator >> (Int2x16 left, int right) => new Int2x16 { Bits = SWAR.ShiftRightArithmetic<Int2>(left.Bits, right) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator ~ (Int2x16 value) => (Int2x16)~(UInt2x16)value;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator ^ (Int2x16 left, Int2x16 right) => (Int2x16)((UInt2x16)left ^ (UInt2x16)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator ^ (Int2x16 left, int right) => left ^ new Int2x16((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator ^ (int left, Int2x16 right) => new Int2x16((sbyte)left) ^ right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator & (Int2x16 left, Int2x16 right) => (Int2x16)((UInt2x16)left & (UInt2x16)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator & (Int2x16 left, int right) => left & new Int2x16((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator & (int left, Int2x16 right) => new Int2x16((sbyte)left) & right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator | (Int2x16 left, Int2x16 right) => (Int2x16)((UInt2x16)left | (UInt2x16)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator | (Int2x16 left, int right) => left | new Int2x16((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator | (int left, Int2x16 right) => new Int2x16((sbyte)left) | right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator == (Int2x16 left, Int2x16 right) => (Int2x16)((UInt2x16)left == (UInt2x16)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator == (Int2x16 left, int right) => left == new Int2x16((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator == (int left, Int2x16 right) => new Int2x16((sbyte)left) == right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator != (Int2x16 left, Int2x16 right) => (Int2x16)((UInt2x16)left != (UInt2x16)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator != (Int2x16 left, int right) => left != new Int2x16((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator != (int left, Int2x16 right) => new Int2x16((sbyte)left) != right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator < (Int2x16 left, Int2x16 right) => new Int2x16 { Bits = SWAR.LessThan<Int2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator < (Int2x16 left, int right) => left < new Int2x16((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator < (int left, Int2x16 right) => right > left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator > (Int2x16 left, Int2x16 right) => new Int2x16 { Bits = SWAR.GreaterThan<Int2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator > (Int2x16 left, int right) => left > new Int2x16((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator > (int left, Int2x16 right) => right < left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator <= (Int2x16 left, Int2x16 right) => new Int2x16 { Bits = SWAR.LessThanOrEqual<Int2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator <= (Int2x16 left, int right) => left <= new Int2x16((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator <= (int left, Int2x16 right) => right >= left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator >= (Int2x16 left, Int2x16 right) => new Int2x16 { Bits = SWAR.GreaterThanOrEqual<Int2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator >= (Int2x16 left, int right) => left >= new Int2x16((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x16 operator >= (int left, Int2x16 right) => right <= left;

        
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
                Bits = BitFieldHelper.Set<Int2>(Bits, (int)value, default(Int2).Bits * index, default(Int2).Bits * Length);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Int2x16 SetReplicate(int index, int numNumbers, uint value)
        {
            return new Int2x16 { Bits = BitFieldHelper.SetReplicate<Int2>(Bits, (int)value, numNumbers, default(Int2).Bits * index, default(Int2).Bits * Length) };
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Int2x16 other)
        {
            return this.Bits == other.Bits;
        }

        public override readonly bool Equals(object obj)
        {
            return obj is Int2x16 converted && this.Equals(converted);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
            return (int)Bits;
        }


        public override readonly string ToString()
        {
            return GetEnumerator().ToString();
        }


        public readonly IEnumerator<int> GetEnumerator()
        {
            return new ArrayEnumerator<Int2x16, int>(this);
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<Int2x16, int>(this);
        }
    }
}