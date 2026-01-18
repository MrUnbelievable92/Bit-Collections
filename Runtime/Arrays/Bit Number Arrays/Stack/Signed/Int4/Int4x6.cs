//#define TESTING

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
    unsafe public struct Int4x6 : IArray<int>, IEquatable<Int4x6>
    {
        public UInt24 Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x6(sbyte x0, sbyte x1, sbyte x2, sbyte x3, sbyte x4, sbyte x5)
        {
            this = (Int4x6)new UInt4x6((byte)ValueHelper.TruncBits<Int4>(x0),
                                       (byte)ValueHelper.TruncBits<Int4>(x1),
                                       (byte)ValueHelper.TruncBits<Int4>(x2),
                                       (byte)ValueHelper.TruncBits<Int4>(x3),
                                       (byte)ValueHelper.TruncBits<Int4>(x4),
                                       (byte)                            x5);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x6(sbyte x0_7)
        {
            this = (Int4x6)new UInt4x6((byte)ValueHelper.TruncBits<Int4>(x0_7));
        }


        public readonly int Length => 6;


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


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x6(Int4x6 input) => input.Reinterpret<Int4x6, UInt4x6>();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x6(UInt4x6 input) => input.Reinterpret<UInt4x6, Int4x6>();
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator - (Int4x6 value) => new Int4x6 { Bits = SWAR.Neg<Int4>(value.Bits) };

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator ++ (Int4x6 value) => value + 1;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator -- (Int4x6 value) => value - 1;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator + (Int4x6 left, Int4x6 right) => (Int4x6)((UInt4x6)left + (UInt4x6)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator + (Int4x6 left, int right) => left + new Int4x6((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator + (int left, Int4x6 right) => new Int4x6((sbyte)left) + right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator - (Int4x6 left, Int4x6 right) => (Int4x6)((UInt4x6)left - (UInt4x6)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator - (Int4x6 left, int right) => left - new Int4x6((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator - (int left, Int4x6 right) => new Int4x6((sbyte)left) - right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator * (Int4x6 left, Int4x6 right) => (Int4x6)((UInt4x6)left * (UInt4x6)right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator * (Int4x6 left, int right) => left * new Int4x6((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator * (int left, Int4x6 right) => new Int4x6((sbyte)left) * right;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator / (Int4x6 left, Int4x6 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                sbyte8 leftV = signextend((sbyte8)PackUnpack.BitIntArrayToByte8<UInt4>(left.Bits), default(Int4).Bits);
                sbyte8 rightV = signextend((sbyte8)PackUnpack.BitIntArrayToByte8<UInt4>(right.Bits), default(Int4).Bits);

            #if TESTING
                for (int i = 6; i < 8; i++)
                {
                    leftV[i] = 1;
                    rightV[i] = 1;
                }
            #endif

                return new Int4x6 { Bits = (uint)PackUnpack.DownCast<Int4>(leftV / rightV) };
            }
            
            UInt4x6 negQuotient = (UInt4x6)(left ^ right) >> (default(Int4).Bits - 1);
            left = new Int4x6 { Bits = SWAR.Abs<Int4>(left.Bits) };
            right = new Int4x6 { Bits = SWAR.Abs<Int4>(right.Bits) };
            
            UInt4x6 absResult = (UInt4x6)left / (UInt4x6)right;
            absResult = (absResult ^ new UInt4x6 { Bits = SWAR.NegBool<Int4>(negQuotient.Bits) }) + negQuotient;

            return new Int4x6 { Bits = absResult.Bits };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator / (Int4x6 left, int right)
        {
            if (SWAR.ConstDiv<Int4>(left.Bits, (int)right, out uint constDiv))
            {
                return new Int4x6 { Bits = constDiv };
            }
            
            if (BurstArchitecture.IsSIMDSupported)
            {
                sbyte8 leftV = signextend((sbyte8)PackUnpack.BitIntArrayToByte8<UInt4>(left.Bits), default(Int4).Bits);

            #if TESTING
                for (int i = 6; i < 8; i++)
                {
                    leftV[i] = 1;
                }
            #endif

                return new Int4x6 { Bits = (uint)PackUnpack.DownCast<Int4>(leftV / (sbyte)right) };
            }
            
            UInt4x6 negQuotient = (UInt4x6)(left ^ right) >> (default(Int4).Bits - 1);
            left = new Int4x6 { Bits = SWAR.Abs<Int4>(left.Bits) };
            right = abs(right);
            
            UInt4x6 absResult = (UInt4x6)left / (uint)right;
            absResult = (absResult ^ new UInt4x6 { Bits = SWAR.NegBool<Int4>(negQuotient.Bits) }) + negQuotient;

            return new Int4x6 { Bits = absResult.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator / (int left, Int4x6 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                sbyte8 rightV = signextend((sbyte8)PackUnpack.BitIntArrayToByte8<UInt4>(right.Bits), default(Int4).Bits);

            #if TESTING
                for (int i = 6; i < 8; i++)
                {
                    rightV[i] = 1;
                }
            #endif

                return new Int4x6 { Bits = (uint)PackUnpack.DownCast<Int4>((sbyte)left / rightV) };
            }
            
            UInt4x6 negQuotient = (UInt4x6)(left ^ right) >> (default(Int4).Bits - 1);
            left = abs(left);
            right = new Int4x6 { Bits = SWAR.Abs<Int4>(right.Bits) };
            
            UInt4x6 absResult = (uint)left / (UInt4x6)right;
            absResult = (absResult ^ new UInt4x6 { Bits = SWAR.NegBool<Int4>(negQuotient.Bits) }) + negQuotient;

            return new Int4x6 { Bits = absResult.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator % (Int4x6 left, Int4x6 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                sbyte8 leftV = signextend((sbyte8)PackUnpack.BitIntArrayToByte8<UInt4>(left.Bits), default(Int4).Bits);
                sbyte8 rightV = signextend((sbyte8)PackUnpack.BitIntArrayToByte8<UInt4>(right.Bits), default(Int4).Bits);

            #if TESTING
                for (int i = 6; i < 8; i++)
                {
                    leftV[i] = 1;
                    rightV[i] = 1;
                }
            #endif

                return new Int4x6 { Bits = (uint)PackUnpack.DownCast<Int4>(leftV % rightV) };
            }
            
            return new Int4x6((sbyte)(left[0] % right[0]),
                              (sbyte)(left[1] % right[1]),
                              (sbyte)(left[2] % right[2]),
                              (sbyte)(left[3] % right[3]),
                              (sbyte)(left[4] % right[4]),
                              (sbyte)(left[5] % right[5]));
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator % (Int4x6 left, int right)
        {
            if (SWAR.ConstRem<Int4>(left.Bits, (int)right, out uint constRem))
            {
                return new Int4x6 { Bits = constRem };
            }
            
            if (BurstArchitecture.IsSIMDSupported)
            {
                sbyte8 leftV = signextend((sbyte8)PackUnpack.BitIntArrayToByte8<UInt4>(left.Bits), default(Int4).Bits);

            #if TESTING
                for (int i = 6; i < 8; i++)
                {
                    leftV[i] = 1;
                }
            #endif

                return new Int4x6 { Bits = (uint)PackUnpack.DownCast<Int4>(leftV % (sbyte)right) };
            }
            
            return new Int4x6((sbyte)(left[0] % right),
                              (sbyte)(left[1] % right),
                              (sbyte)(left[2] % right),
                              (sbyte)(left[3] % right),
                              (sbyte)(left[4] % right),
                              (sbyte)(left[5] % right));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator % (int left, Int4x6 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                sbyte8 rightV = signextend((sbyte8)PackUnpack.BitIntArrayToByte8<UInt4>(right.Bits), default(Int4).Bits);

            #if TESTING
                for (int i = 6; i < 8; i++)
                {
                    rightV[i] = 1;
                }
            #endif

                return new Int4x6 { Bits = (uint)PackUnpack.DownCast<Int4>((sbyte)left % rightV) };
            }
            
            return new Int4x6((sbyte)(left % right[0]),
                              (sbyte)(left % right[1]),
                              (sbyte)(left % right[2]),
                              (sbyte)(left % right[3]),
                              (sbyte)(left % right[4]),
                              (sbyte)(left % right[5]));
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator << (Int4x6 left, int right) => (Int4x6)((UInt4x6)left << right);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator >> (Int4x6 left, int right) => new Int4x6 { Bits = SWAR.ShiftRightArithmetic<Int4>(left.Bits, right) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator ~ (Int4x6 value) => (Int4x6)~(UInt4x6)value;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator ^ (Int4x6 left, Int4x6 right) => (Int4x6)((UInt4x6)left ^ (UInt4x6)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator ^ (Int4x6 left, int right) => left ^ new Int4x6((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator ^ (int left, Int4x6 right) => new Int4x6((sbyte)left) ^ right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator & (Int4x6 left, Int4x6 right) => (Int4x6)((UInt4x6)left & (UInt4x6)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator & (Int4x6 left, int right) => left & new Int4x6((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator & (int left, Int4x6 right) => new Int4x6((sbyte)left) & right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator | (Int4x6 left, Int4x6 right) => (Int4x6)((UInt4x6)left | (UInt4x6)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator | (Int4x6 left, int right) => left | new Int4x6((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator | (int left, Int4x6 right) => new Int4x6((sbyte)left) | right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator == (Int4x6 left, Int4x6 right) => (Int4x6)((UInt4x6)left == (UInt4x6)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator == (Int4x6 left, int right) => left == new Int4x6((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator == (int left, Int4x6 right) => new Int4x6((sbyte)left) == right;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator != (Int4x6 left, Int4x6 right) => (Int4x6)((UInt4x6)left != (UInt4x6)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator != (Int4x6 left, int right) => left != new Int4x6((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator != (int left, Int4x6 right) => new Int4x6((sbyte)left) != right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator < (Int4x6 left, Int4x6 right) => new Int4x6 { Bits = SWAR.LessThan<Int4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator < (Int4x6 left, int right) => left < new Int4x6((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator < (int left, Int4x6 right) => right > left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator > (Int4x6 left, Int4x6 right) => new Int4x6 { Bits = SWAR.GreaterThan<Int4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator > (Int4x6 left, int right) => left > new Int4x6((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator > (int left, Int4x6 right) => right < left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator <= (Int4x6 left, Int4x6 right) => new Int4x6 { Bits = SWAR.LessThanOrEqual<Int4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator <= (Int4x6 left, int right) => left <= new Int4x6((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator <= (int left, Int4x6 right) => right >= left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator >= (Int4x6 left, Int4x6 right) => new Int4x6 { Bits = SWAR.GreaterThanOrEqual<Int4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator >= (Int4x6 left, int right) => left >= new Int4x6((sbyte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x6 operator >= (int left, Int4x6 right) => right <= left;

        
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
                Bits = BitFieldHelper.Set<Int4>(Bits, (int)value, default(Int4).Bits * index, default(Int4).Bits * Length);
            }
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Int4x6 SetReplicate(int index, int numNumbers, uint value)
        {
            return new Int4x6 { Bits = BitFieldHelper.SetReplicate<Int4>(Bits, (int)value, numNumbers, default(Int4).Bits * index, default(Int4).Bits * Length) };
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Int4x6 other)
        {
            return this.Bits == other.Bits;
        }

        public override readonly bool Equals(object obj)
        {
            return obj is Int4x6 converted && this.Equals(converted);
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
            return new ArrayEnumerator<Int4x6, int>(this);
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<Int4x6, int>(this);
        }
    }
}