using DevTools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;
using Unity.Mathematics;
using MaxMath;
using MaxMath.Intrinsics;

using static MaxMath.maxmath;
using static Unity.Mathematics.math;

namespace BitCollections
{
    [Serializable]
    unsafe public struct Int2x24 : IArray<int>, IEquatable<Int2x24>
    {
        public UInt48 Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x24(sbyte x0, sbyte x1, sbyte x2, sbyte x3, sbyte x4, sbyte x5, sbyte x6, sbyte x7, sbyte x8, sbyte x9, sbyte x10, sbyte x11, sbyte x12, sbyte x13, sbyte x14, sbyte x15, sbyte x16, sbyte x17, sbyte x18, sbyte x19, sbyte x20, sbyte x21, sbyte x22, sbyte x23)
        {
            this = (Int2x24)new UInt2x24((byte)ValueHelper.TruncBits<Int2>(x0),
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
                                         (byte)                            x23);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x24(sbyte x0_23)
        {
            this = (Int2x24)new UInt2x24((byte)ValueHelper.TruncBits<Int2>(x0_23));
        }


        public readonly int Length => 24;


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


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x24(Int2x24 input) => input.Reinterpret<Int2x24, UInt2x24>();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x24(UInt2x24 input) => input.Reinterpret<UInt2x24, Int2x24>();
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator - (Int2x24 value) => new Int2x24 { Bits = SWAR.Neg<Int2>(value.Bits) };

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator ++ (Int2x24 value) => value + 1;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator -- (Int2x24 value) => value - 1;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator + (Int2x24 left, Int2x24 right) => (Int2x24)((UInt2x24)left + (UInt2x24)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator + (Int2x24 left, int right) => left + new Int2x24((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator + (int left, Int2x24 right) => new Int2x24((sbyte)left) + right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator - (Int2x24 left, Int2x24 right) => (Int2x24)((UInt2x24)left - (UInt2x24)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator - (Int2x24 left, int right) => left - new Int2x24((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator - (int left, Int2x24 right) => new Int2x24((sbyte)left) - right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator * (Int2x24 left, Int2x24 right) => (Int2x24)((UInt2x24)left * (UInt2x24)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator * (Int2x24 left, int right) => left * new Int2x24((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator * (int left, Int2x24 right) => new Int2x24((sbyte)left) * right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator / (Int2x24 left, Int2x24 right)
        {
            return new Int2x24 { Bits = SWAR.DivRem<Int2>(left.Bits, right.Bits, out _) };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator / (Int2x24 left, int right)
        {
            if (SWAR.ConstDiv<Int2>(left.Bits, (long)right, out ulong constDiv))
            {
                return new Int2x24 { Bits = constDiv };
            }
            
            return new Int2x24 { Bits = SWAR.DivRem<Int2>(left.Bits, new Int2x24((sbyte)right).Bits, out _) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator / (int left, Int2x24 right)
        {
            return new Int2x24 { Bits = SWAR.DivRem<Int2>(new Int2x24((sbyte)left).Bits, right.Bits, out _) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator % (Int2x24 left, Int2x24 right)
        {
            SWAR.DivRem<Int2>(left.Bits, right.Bits, out ulong rem);

            return new Int2x24 { Bits =  rem };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator % (Int2x24 left, int right)
        {
            if (SWAR.ConstRem<Int2>(left.Bits, (long)right, out ulong constRem))
            {
                return new Int2x24 { Bits = constRem };
            }
            
            SWAR.DivRem<Int2>(left.Bits, new Int2x24((sbyte)right).Bits, out ulong rem);

            return new Int2x24 { Bits =  rem };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator % (int left, Int2x24 right)
        {
            SWAR.DivRem<Int2>(new Int2x24((sbyte)left).Bits, right.Bits, out ulong rem);

            return new Int2x24 { Bits =  rem };
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator << (Int2x24 left, int right) => (Int2x24)((UInt2x24)left << right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator >> (Int2x24 left, int right) => new Int2x24 { Bits = SWAR.ShiftRightArithmetic<Int2>(left.Bits, right) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator ~ (Int2x24 value) => (Int2x24)~(UInt2x24)value;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator ^ (Int2x24 left, Int2x24 right) => (Int2x24)((UInt2x24)left ^ (UInt2x24)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator ^ (Int2x24 left, int right) => left ^ new Int2x24((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator ^ (int left, Int2x24 right) => new Int2x24((sbyte)left) ^ right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator & (Int2x24 left, Int2x24 right) => (Int2x24)((UInt2x24)left & (UInt2x24)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator & (Int2x24 left, int right) => left & new Int2x24((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator & (int left, Int2x24 right) => new Int2x24((sbyte)left) & right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator | (Int2x24 left, Int2x24 right) => (Int2x24)((UInt2x24)left | (UInt2x24)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator | (Int2x24 left, int right) => left | new Int2x24((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator | (int left, Int2x24 right) => new Int2x24((sbyte)left) | right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator == (Int2x24 left, Int2x24 right) => (Int2x24)((UInt2x24)left == (UInt2x24)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator == (Int2x24 left, int right) => left == new Int2x24((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator == (int left, Int2x24 right) => new Int2x24((sbyte)left) == right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator != (Int2x24 left, Int2x24 right) => (Int2x24)((UInt2x24)left != (UInt2x24)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator != (Int2x24 left, int right) => left != new Int2x24((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator != (int left, Int2x24 right) => new Int2x24((sbyte)left) != right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator < (Int2x24 left, Int2x24 right) => new Int2x24 { Bits = SWAR.LessThan<Int2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator < (Int2x24 left, int right) => left < new Int2x24((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator < (int left, Int2x24 right) => right > left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator > (Int2x24 left, Int2x24 right) => new Int2x24 { Bits = SWAR.GreaterThan<Int2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator > (Int2x24 left, int right) => left > new Int2x24((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator > (int left, Int2x24 right) => right < left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator <= (Int2x24 left, Int2x24 right) => new Int2x24 { Bits = SWAR.LessThanOrEqual<Int2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator <= (Int2x24 left, int right) => left <= new Int2x24((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator <= (int left, Int2x24 right) => right >= left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator >= (Int2x24 left, Int2x24 right) => new Int2x24 { Bits = SWAR.GreaterThanOrEqual<Int2>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator >= (Int2x24 left, int right) => left >= new Int2x24((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x24 operator >= (int left, Int2x24 right) => right <= left;


        public int this[int index]
        {
            [return: AssumeRange(Int2.MinValue, Int2.MaxValue)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
Assert.IsWithinArrayBounds(index, Length);

                if (constexpr.IS_TRUE(index == Length - 1))
                {
                    return (int)(((long)(Int48)Bits) >> (index * default(Int2).Bits));
                }
                else
                {
                    // manual sign extend => 1 bitshift less; same if 'index' is not a compile time constant
                    return (int)(((long)Bits << (64 - ((1 + index) * default(Int2).Bits))) >> (64 - default(Int2).Bits));
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsBetween(value, Int2.MinValue, Int2.MaxValue);
Assert.IsWithinArrayBounds(index, Length);

                if (constexpr.IS_TRUE(index == Length - 1) && constexpr.IS_TRUE(value == 0))
                {
                    Bits = (UInt48)bits_zerohigh((ulong)Bits, (Length - 1) * default(Int2).Bits);
                }
                else
                {
                    Bits = (UInt48)BitFieldHelper.Set<Int2>(Bits, value, default(Int2).Bits * index, default(Int2).Bits * Length);
                }
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long4 GetSubArray(int index)
        {
Assert.IsValidSubarray(index, 4, Length);

            // manual sign extend => 1 bitshift less; same if 'index' is not a compile time constant
            long4 temp = shl((long)Bits, (long4)(64 - (default(Int2).Bits * (index + new int4(1, 2, 3, 4)))));

            return temp >> (64 - default(Int2).Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetSubArray(int index, long4 value)
        {
Assert.IsValidSubarray(index, 4, Length);
Assert.IsBetween(value.x, Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(value.y, Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(value.z, Int2.MinValue, Int2.MaxValue);
Assert.IsBetween(value.w, Int2.MinValue, Int2.MaxValue);

            Bits = (UInt48)((long)andnot((ulong)Bits, (ulong)bitmask64(4 * default(Int2).Bits, index * default(Int2).Bits))
                                 |
                                 csum(shl(bitmask64((long)default(Int2).Bits) & value,      (long4)(default(Int2).Bits * (index + new int4(0, 1, 2, 3))))));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Int2x24 SetReplicate(int index, int numNumbers, int value)
        {
            return new Int2x24 { Bits = BitFieldHelper.SetReplicate<Int2>(Bits, (int)value, numNumbers, default(Int2).Bits * index, default(Int2).Bits * Length) };
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Int2x24 other)
        {
            return this.Bits == other.Bits;
        }

        public override readonly bool Equals(object obj)
        {
            return obj is Int2x24 converted && this.Equals(converted);
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
            return new ArrayEnumerator<Int2x24, int>(this);
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<Int2x24, int>(this);
        }
    }
}