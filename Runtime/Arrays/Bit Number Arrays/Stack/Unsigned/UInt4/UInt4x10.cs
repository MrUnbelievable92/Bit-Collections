//#define TESTING

using DevTools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;
using MaxMath.Intrinsics;
using MaxMath;

namespace BitCollections
{
    [Serializable]
    unsafe public struct UInt4x10 : IArray<uint>, IEquatable<UInt4x10>
    {
        public UInt40 Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x10(byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7, byte x8, byte x9)
        {
Assert.IsNotGreater(x0,  UInt4.MaxValue);
Assert.IsNotGreater(x1,  UInt4.MaxValue);
Assert.IsNotGreater(x2,  UInt4.MaxValue);
Assert.IsNotGreater(x3,  UInt4.MaxValue);
Assert.IsNotGreater(x4,  UInt4.MaxValue);
Assert.IsNotGreater(x5,  UInt4.MaxValue);
Assert.IsNotGreater(x6,  UInt4.MaxValue);
Assert.IsNotGreater(x7,  UInt4.MaxValue);
Assert.IsNotGreater(x8,  UInt4.MaxValue);
//Assert.IsNotGreater(x9,  UInt4.MaxValue);

            Bits = ((ulong)x0 << (0 * default(UInt4).Bits))
                  | ((ulong)x1 << (1 * default(UInt4).Bits))
                  | ((ulong)x2 << (2 * default(UInt4).Bits))
                  | ((ulong)x3 << (3 * default(UInt4).Bits))
                  | ((ulong)x4 << (4 * default(UInt4).Bits))
                  | ((ulong)x5 << (5 * default(UInt4).Bits))
                  | ((ulong)x6 << (6 * default(UInt4).Bits))
                  | ((ulong)x7 << (7 * default(UInt4).Bits))
                  | ((ulong)x8 << (8 * default(UInt4).Bits))
                  | ((ulong)x9 << (9 * default(UInt4).Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x10(byte x0_11)
        {
            Bits = SWAR.Broadcast64<UInt4>(x0_11);
        }


        public readonly int Length => 10;


        public uint x0
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[0];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[0] = value;
        }
        public uint x1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[1];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[1] = value;
        }
        public uint x2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[2];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[2] = value;
        }
        public uint x3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[3];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[3] = value;
        }
        public uint x4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[4];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[4] = value;
        }
        public uint x5
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[5];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[5] = value;
        }
        public uint x6
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[6];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[6] = value;
        }
        public uint x7
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[7];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[7] = value;
        }
        public uint x8
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[8];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[8] = value;
        }
        public uint x9
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[9];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[9] = value;
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator ++ (UInt4x10 value) => value + 1;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator -- (UInt4x10 value) => value - 1;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator + (UInt4x10 left, UInt4x10 right) => new UInt4x10 { Bits = SWAR.Add<UInt4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator + (UInt4x10 left, uint right) => left + new UInt4x10((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator + (uint left, UInt4x10 right) => right + left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator - (UInt4x10 left, UInt4x10 right) => new UInt4x10 { Bits = SWAR.Sub<UInt4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator - (UInt4x10 left, uint right) => left - new UInt4x10((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator - (uint left, UInt4x10 right) => new UInt4x10((byte)left) - right;

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator * (UInt4x10 left, UInt4x10 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return new UInt4x10 { Bits = PackUnpack.DownCast<UInt4>(PackUnpack.BitIntArrayToByte16<UInt4>(left.Bits) * PackUnpack.BitIntArrayToByte16<UInt4>(right.Bits)) };
            }

            return new UInt4x10 { Bits = SWAR.Mul<UInt4>(left.Bits, right.Bits) };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator * (UInt4x10 left, uint right)
        {
            if (SWAR.ConstMul<UInt4>(left.Bits, right, out ulong constMul))
            {
                return new UInt4x10 { Bits = constMul };
            }
        
            return left * new UInt4x10((byte)right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator * (uint left, UInt4x10 right) => right * left;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator / (UInt4x10 left, UInt4x10 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return new UInt4x10 { Bits = PackUnpack.DownCast<UInt4>(PackUnpack.BitIntArrayToByte16<UInt4>(left.Bits) / PackUnpack.BitIntArrayToByte16<UInt4>(right.Bits)) };
            }
            
            return new UInt4x10{ Bits = SWAR.DivRem<UInt4>(left.Bits, right.Bits, out _)};
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator / (UInt4x10 left, uint right)
        {
            if (SWAR.ConstDiv<UInt4>(left.Bits, (long)right, out ulong constDiv))
            {
                return new UInt4x10 { Bits = constDiv };
            }

            if (BurstArchitecture.IsSIMDSupported)
            {
                return new UInt4x10 { Bits = PackUnpack.DownCast<UInt4>(PackUnpack.BitIntArrayToByte16<UInt4>(left.Bits) / (byte)right) };
            }
            
            return new UInt4x10{ Bits = SWAR.DivRem<UInt4>(left.Bits, new UInt4x10((byte)right).Bits, out _)};
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator / (uint left, UInt4x10 right) => new UInt4x10((byte)left) / right;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator % (UInt4x10 left, UInt4x10 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                byte16 leftV = PackUnpack.BitIntArrayToByte16<UInt4>(left.Bits);
                byte16 rightV = PackUnpack.BitIntArrayToByte16<UInt4>(right.Bits);

            #if TESTING
                for (int i = 10; i < 16; i++)
                {
                    leftV[i] = 1;
                    rightV[i] = 1;
                }
            #endif

                return new UInt4x10 { Bits = PackUnpack.DownCast<UInt4>(leftV % rightV) };
            }

            SWAR.DivRem<UInt4>(left.Bits, right.Bits, out ulong r);

            return new UInt4x10 { Bits = r };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator % (UInt4x10 left, uint right)
        {
            if (SWAR.ConstRem<UInt4>(left.Bits, (long)right, out ulong constRem))
            {
                return new UInt4x10 { Bits = constRem };
            }

            if (BurstArchitecture.IsSIMDSupported)
            {
                byte16 leftV = PackUnpack.BitIntArrayToByte16<UInt4>(left.Bits);

            #if TESTING
                for (int i = 10; i < 16; i++)
                {
                    leftV[i] = 1;
                }
            #endif

                return new UInt4x10 { Bits = PackUnpack.DownCast<UInt4>(leftV % (byte)right) };
            }

            SWAR.DivRem<UInt4>(left.Bits, new UInt4x10((byte)right).Bits, out ulong r);

            return new UInt4x10 { Bits = r };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator % (uint left, UInt4x10 right) => new UInt4x10((byte)left) % right;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator << (UInt4x10 left, int right) => new UInt4x10 { Bits = SWAR.ShiftLeftLogical<UInt4>(left.Bits, right) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator >> (UInt4x10 left, int right) => new UInt4x10 { Bits = SWAR.ShiftRightLogical<UInt4>(left.Bits, right) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator ~ (UInt4x10 value) => new UInt4x10{ Bits = ~value.Bits };
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator ^ (UInt4x10 left, UInt4x10 right) => new UInt4x10{ Bits = left.Bits ^ right.Bits };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator ^ (UInt4x10 left, uint right) => left ^ new UInt4x10((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator ^ (uint left, UInt4x10 right) => right ^ left;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator & (UInt4x10 left, UInt4x10 right) => new UInt4x10{ Bits = left.Bits & right.Bits };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator & (UInt4x10 left, uint right) => left & new UInt4x10((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator & (uint left, UInt4x10 right) => right & left;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator | (UInt4x10 left, UInt4x10 right) => new UInt4x10{ Bits = left.Bits | right.Bits };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator | (UInt4x10 left, uint right) => left | new UInt4x10((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator | (uint left, UInt4x10 right) => right | left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator == (UInt4x10 left, UInt4x10 right) => new UInt4x10 { Bits = SWAR.Equals<UInt4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator == (UInt4x10 left, uint right) => left == new UInt4x10((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator == (uint left, UInt4x10 right) => right == left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator != (UInt4x10 left, UInt4x10 right) => new UInt4x10 { Bits = SWAR.NotEquals<UInt4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator != (UInt4x10 left, uint right) => left != new UInt4x10((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator != (uint left, UInt4x10 right) => right != left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator < (UInt4x10 left, UInt4x10 right) => new UInt4x10 { Bits = SWAR.LessThan<UInt4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator < (UInt4x10 left, uint right) => left < new UInt4x10((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator < (uint left, UInt4x10 right) => right > left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator > (UInt4x10 left, UInt4x10 right) => new UInt4x10 { Bits = SWAR.GreaterThan<UInt4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator > (UInt4x10 left, uint right) => left > new UInt4x10((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator > (uint left, UInt4x10 right) => right < left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator <= (UInt4x10 left, UInt4x10 right) => new UInt4x10 { Bits = SWAR.LessThanOrEqual<UInt4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator <= (UInt4x10 left, uint right) => left <= new UInt4x10((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator <= (uint left, UInt4x10 right) => right >= left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator >= (UInt4x10 left, UInt4x10 right) => new UInt4x10 { Bits = SWAR.GreaterThanOrEqual<UInt4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator >= (UInt4x10 left, uint right) => left >= new UInt4x10((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x10 operator >= (uint left, UInt4x10 right) => right <= left;

        
        public uint this[int index]
        {
            [return: AssumeRange((ulong)UInt4.MinValue, (ulong)UInt4.MaxValue)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (uint)BitFieldHelper.Get<UInt4>(Bits, default(UInt4).Bits * index, default(UInt4).Bits * Length);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Bits = BitFieldHelper.Set<UInt4>(Bits, (int)value, default(UInt4).Bits * index, default(UInt4).Bits * Length);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly UInt4x10 SetReplicate(int index, int numNumbers, uint value)
        {
            return new UInt4x10 { Bits = BitFieldHelper.SetReplicate<UInt4>(Bits, (int)value, numNumbers, default(UInt4).Bits * index, default(UInt4).Bits * Length) };
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(UInt4x10 other)
        {
            return this.Bits == other.Bits;
        }

        public override readonly bool Equals(object obj)
        {
            return obj is UInt4x10 converted && this.Equals(converted);
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


        public readonly IEnumerator<uint> GetEnumerator()
        {
            return new ArrayEnumerator<UInt4x10, uint>(this);
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<UInt4x10, uint>(this);
        }
    }
}