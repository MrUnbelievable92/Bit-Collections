using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;
using MaxMath;

namespace BitCollections
{
    [Serializable]
    unsafe public struct Int2x28 : IArray<int>, IEquatable<Int2x28>
    {
        public UInt56 Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x28(sbyte x0, sbyte x1, sbyte x2, sbyte x3, sbyte x4, sbyte x5, sbyte x6, sbyte x7, sbyte x8, sbyte x9, sbyte x10, sbyte x11, sbyte x12, sbyte x13, sbyte x14, sbyte x15, sbyte x16, sbyte x17, sbyte x18, sbyte x19, sbyte x20, sbyte x21, sbyte x22, sbyte x23, sbyte x24, sbyte x25, sbyte x26, sbyte x27)
        {
            this = (Int2x28)new UInt2x28((byte)ValueHelper.TruncBits<Int2>(x0),
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
                                         (byte)ValueHelper.TruncBits<Int2>(x15),
                                         (byte)ValueHelper.TruncBits<Int2>(x16),
                                         (byte)ValueHelper.TruncBits<Int2>(x17),
                                         (byte)ValueHelper.TruncBits<Int2>(x18),
                                         (byte)ValueHelper.TruncBits<Int2>(x19),
                                         (byte)ValueHelper.TruncBits<Int2>(x20),
                                         (byte)ValueHelper.TruncBits<Int2>(x21),
                                         (byte)ValueHelper.TruncBits<Int2>(x22),
                                         (byte)ValueHelper.TruncBits<Int2>(x23),
                                         (byte)ValueHelper.TruncBits<Int2>(x24),
                                         (byte)ValueHelper.TruncBits<Int2>(x25),
                                         (byte)ValueHelper.TruncBits<Int2>(x26),
                                         (byte)                            x27);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x28(sbyte x0_26)
        {
            this = (Int2x28)new UInt2x28((byte)ValueHelper.TruncBits<Int2>(x0_26));
        }


        public readonly int Length => 28;


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
        public int x16
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[16];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[16] = value;
        }
        public int x17
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[17];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[17] = value;
        }
        public int x18
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[18];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[18] = value;
        }
        public int x19
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[19];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[19] = value;
        }
        public int x20
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[20];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[20] = value;
        }
        public int x21
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[21];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[21] = value;
        }
        public int x22
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[22];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[22] = value;
        }
        public int x23
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[23];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[23] = value;
        }
        public int x24
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[24];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[24] = value;
        }
        public int x25
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[25];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[25] = value;
        }
        public int x26
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[26];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[26] = value;
        }
        public int x27
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[27];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[27] = value;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x28(Int2x28 input) => input.Reinterpret<Int2x28, UInt2x28>();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x28(UInt2x28 input) => input.Reinterpret<UInt2x28, Int2x28>();
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator - (Int2x28 value) => new Int2x28 { Bits = SWAR.Neg<Int2>(value.Bits) };

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator ++ (Int2x28 value) => value + 1;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator -- (Int2x28 value) => value - 1;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator + (Int2x28 left, Int2x28 right) => (Int2x28)((UInt2x28)left + (UInt2x28)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator + (Int2x28 left, int right) => left + new Int2x28((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator + (int left, Int2x28 right) => new Int2x28((sbyte)left) + right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator - (Int2x28 left, Int2x28 right) => (Int2x28)((UInt2x28)left - (UInt2x28)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator - (Int2x28 left, int right) => left - new Int2x28((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator - (int left, Int2x28 right) => new Int2x28((sbyte)left) - right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator * (Int2x28 left, Int2x28 right) => (Int2x28)((UInt2x28)left * (UInt2x28)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator * (Int2x28 left, int right) => left * new Int2x28((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator * (int left, Int2x28 right) => new Int2x28((sbyte)left) * right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator / (Int2x28 left, Int2x28 right)
        {
            return new Int2x28 { Bits = SWAR.DivRem<Int2>(left.Bits, right.Bits, out _) };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator / (Int2x28 left, int right)
        {
            if (SWAR.ConstDiv<Int2>(left.Bits, (long)right, out ulong constDiv))
            {
                return new Int2x28 { Bits = constDiv };
            }
            
            return new Int2x28 { Bits = SWAR.DivRem<Int2>(left.Bits, new Int2x28((sbyte)right).Bits, out _) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator / (int left, Int2x28 right)
        {
            return new Int2x28 { Bits = SWAR.DivRem<Int2>(new Int2x28((sbyte)left).Bits, right.Bits, out _) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator % (Int2x28 left, Int2x28 right)
        {
            SWAR.DivRem<Int2>(left.Bits, right.Bits, out ulong rem);

            return new Int2x28 { Bits =  rem };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator % (Int2x28 left, int right)
        {
            if (SWAR.ConstRem<Int2>(left.Bits, (long)right, out ulong constRem))
            {
                return new Int2x28 { Bits = constRem };
            }
            
            SWAR.DivRem<Int2>(left.Bits, new Int2x28((sbyte)right).Bits, out ulong rem);

            return new Int2x28 { Bits =  rem };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator % (int left, Int2x28 right)
        {
            SWAR.DivRem<Int2>(new Int2x28((sbyte)left).Bits, right.Bits, out ulong rem);

            return new Int2x28 { Bits =  rem };
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator << (Int2x28 left, int right) => (Int2x28)((UInt2x28)left << right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator >> (Int2x28 left, int right) => new Int2x28 { Bits = SWAR.ShiftRightArithmetic<Int2>(left.Bits, right) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator ~ (Int2x28 value) => (Int2x28)~(UInt2x28)value;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator ^ (Int2x28 left, Int2x28 right) => (Int2x28)((UInt2x28)left ^ (UInt2x28)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator ^ (Int2x28 left, int right) => left ^ new Int2x28((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator ^ (int left, Int2x28 right) => new Int2x28((sbyte)left) ^ right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator & (Int2x28 left, Int2x28 right) => (Int2x28)((UInt2x28)left & (UInt2x28)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator & (Int2x28 left, int right) => left & new Int2x28((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator & (int left, Int2x28 right) => new Int2x28((sbyte)left) & right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator | (Int2x28 left, Int2x28 right) => (Int2x28)((UInt2x28)left | (UInt2x28)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator | (Int2x28 left, int right) => left | new Int2x28((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator | (int left, Int2x28 right) => new Int2x28((sbyte)left) | right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator == (Int2x28 left, Int2x28 right) => (Int2x28)((UInt2x28)left == (UInt2x28)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator == (Int2x28 left, int right) => left == new Int2x28((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator == (int left, Int2x28 right) => new Int2x28((sbyte)left) == right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator != (Int2x28 left, Int2x28 right) => (Int2x28)((UInt2x28)left != (UInt2x28)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator != (Int2x28 left, int right) => left != new Int2x28((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator != (int left, Int2x28 right) => new Int2x28((sbyte)left) != right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator < (Int2x28 left, Int2x28 right) => new Int2x28 { Bits = SWAR.LessThan<Int2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator < (Int2x28 left, int right) => left < new Int2x28((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator < (int left, Int2x28 right) => right > left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator > (Int2x28 left, Int2x28 right) => new Int2x28 { Bits = SWAR.GreaterThan<Int2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator > (Int2x28 left, int right) => left > new Int2x28((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator > (int left, Int2x28 right) => right < left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator <= (Int2x28 left, Int2x28 right) => new Int2x28 { Bits = SWAR.LessThanOrEqual<Int2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator <= (Int2x28 left, int right) => left <= new Int2x28((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator <= (int left, Int2x28 right) => right >= left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator >= (Int2x28 left, Int2x28 right) => new Int2x28 { Bits = SWAR.GreaterThanOrEqual<Int2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator >= (Int2x28 left, int right) => left >= new Int2x28((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x28 operator >= (int left, Int2x28 right) => right <= left;

        
        public int this[int index]
        {
            [return: AssumeRange((long)Int2.MinValue, (long)Int2.MaxValue)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (int)BitFieldHelper.Get<Int2>(Bits, default(Int2).Bits * index, default(Int2).Bits * Length);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Bits = BitFieldHelper.Set<Int2>(Bits, (int)value, default(Int2).Bits * index, default(Int2).Bits * Length);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Int2x28 SetReplicate(int index, int numNumbers, uint value)
        {
            return new Int2x28 { Bits = BitFieldHelper.SetReplicate<Int2>(Bits, (int)value, numNumbers, default(Int2).Bits * index, default(Int2).Bits * Length) };
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Int2x28 other)
        {
            return this.Bits == other.Bits;
        }

        public override readonly bool Equals(object obj)
        {
            return obj is Int2x28 converted && this.Equals(converted);
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
            return new ArrayEnumerator<Int2x28, int>(this);
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<Int2x28, int>(this);
        }
    }
}