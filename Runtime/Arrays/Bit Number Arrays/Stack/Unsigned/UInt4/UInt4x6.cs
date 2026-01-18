//#define TESTING

using DevTools;
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
    unsafe public struct UInt4x6 : IArray<uint>, IEquatable<UInt4x6>
    {
        public UInt24 Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x6(byte x0, byte x1, byte x2, byte x3, byte x4, byte x5)
        {
Assert.IsNotGreater(x0,  UInt4.MaxValue);
Assert.IsNotGreater(x1,  UInt4.MaxValue);
Assert.IsNotGreater(x2,  UInt4.MaxValue);
Assert.IsNotGreater(x3,  UInt4.MaxValue);
Assert.IsNotGreater(x4,  UInt4.MaxValue);
//Assert.IsNotGreater(x5,  UInt4.MaxValue);

            Bits = (((uint)x0 << (0 * default(UInt4).Bits))
                  |  ((uint)x1 << (1 * default(UInt4).Bits))
                  |  ((uint)x2 << (2 * default(UInt4).Bits))
                  |  ((uint)x3 << (3 * default(UInt4).Bits))
                  |  ((uint)x4 << (4 * default(UInt4).Bits))
                  |  ((uint)x5 << (5 * default(UInt4).Bits)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x6(byte x0_7)
        {
            Bits = SWAR.Broadcast32<UInt4>(x0_7);
        }


        public readonly int Length => 6;


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
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator ++ (UInt4x6 value) => value + 1;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator -- (UInt4x6 value) => value - 1;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator + (UInt4x6 left, UInt4x6 right) => new UInt4x6 { Bits = SWAR.Add<UInt4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator + (UInt4x6 left, uint right) => left + new UInt4x6((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator + (uint left, UInt4x6 right) => right + left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator - (UInt4x6 left, UInt4x6 right) => new UInt4x6 { Bits = SWAR.Sub<UInt4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator - (UInt4x6 left, uint right) => left - new UInt4x6((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator - (uint left, UInt4x6 right) => new UInt4x6((byte)left) - right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator * (UInt4x6 left, UInt4x6 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return new UInt4x6 { Bits = (uint)PackUnpack.DownCast<UInt4>(PackUnpack.BitIntArrayToByte8<UInt4>(left.Bits) * PackUnpack.BitIntArrayToByte8<UInt4>(right.Bits)) };
            }
            
            uint x0  = left.Bits & bitmask32((uint)default(UInt4).Bits, 0u * (uint)default(UInt4).Bits);
            uint x1  = left.Bits & bitmask32((uint)default(UInt4).Bits, 1u * (uint)default(UInt4).Bits);
            uint x2  = left.Bits & bitmask32((uint)default(UInt4).Bits, 2u * (uint)default(UInt4).Bits);
            uint x3  = left.Bits & bitmask32((uint)default(UInt4).Bits, 3u * (uint)default(UInt4).Bits);
            uint x4  = left.Bits & bitmask32((uint)default(UInt4).Bits, 4u * (uint)default(UInt4).Bits);
            uint x5  = left.Bits & bitmask32((uint)default(UInt4).Bits, 5u * (uint)default(UInt4).Bits);
            
            x0 *= right[0];
            x1 *= right[1];
            x2 *= right[2];
            x3 *= right[3];
            x4 *= right[4];
            x5 *= right[5];

            uint blend0 = bits_select(x1,  x0,  bitmask32((uint)default(UInt4).Bits));
            uint blend1 = bits_select(x3,  x2,  bitmask32((uint)default(UInt4).Bits, 2u * (uint)default(UInt4).Bits));
            uint blend2 = bits_select(x5,  x4,  bitmask32((uint)default(UInt4).Bits, 4u * (uint)default(UInt4).Bits));

            blend0 = bits_select(blend1, blend0, bitmask32(2u * (uint)default(UInt4).Bits));
            blend1 = bits_select(0,      blend2, bitmask32(2u * (uint)default(UInt4).Bits, 4u * (uint)default(UInt4).Bits));
            
            blend0 = bits_select(blend1, blend0, bitmask32(4u * (uint)default(UInt4).Bits));

            return new UInt4x6 { Bits = blend0 };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator * (UInt4x6 left, uint right)
        {
            if (SWAR.ConstMul<UInt4>(left.Bits, right, out uint constMul))
            {
                return new UInt4x6 { Bits = constMul };
            }
        
            if (BurstArchitecture.IsSIMDSupported)
            {
                return new UInt4x6 { Bits = (uint)PackUnpack.DownCast<UInt4>(PackUnpack.BitIntArrayToByte8<UInt4>(left.Bits) * (byte)right) };
            }
            
            uint x0  = left.Bits & bitmask32((uint)default(UInt4).Bits, 0u * (uint)default(UInt4).Bits);
            uint x1  = left.Bits & bitmask32((uint)default(UInt4).Bits, 1u * (uint)default(UInt4).Bits);
            uint x2  = left.Bits & bitmask32((uint)default(UInt4).Bits, 2u * (uint)default(UInt4).Bits);
            uint x3  = left.Bits & bitmask32((uint)default(UInt4).Bits, 3u * (uint)default(UInt4).Bits);
            uint x4  = left.Bits & bitmask32((uint)default(UInt4).Bits, 4u * (uint)default(UInt4).Bits);
            uint x5  = left.Bits & bitmask32((uint)default(UInt4).Bits, 5u * (uint)default(UInt4).Bits);
            
            x0 *= right;
            x1 *= right;
            x2 *= right;
            x3 *= right;
            x4 *= right;
            x5 *= right;

            uint blend0 = bits_select(x1,  x0,  bitmask32((uint)default(UInt4).Bits));
            uint blend1 = bits_select(x3,  x2,  bitmask32((uint)default(UInt4).Bits, 2u * (uint)default(UInt4).Bits));
            uint blend2 = bits_select(x5,  x4,  bitmask32((uint)default(UInt4).Bits, 4u * (uint)default(UInt4).Bits));

            blend0 = bits_select(blend1, blend0, bitmask32(2u * (uint)default(UInt4).Bits));
            blend1 = bits_select(0,      blend2, bitmask32(2u * (uint)default(UInt4).Bits, 4u * (uint)default(UInt4).Bits));
            
            blend0 = bits_select(blend1, blend0, bitmask32(4u * (uint)default(UInt4).Bits));

            return new UInt4x6 { Bits = blend0 };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator * (uint left, UInt4x6 right) => right * left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator / (UInt4x6 left, UInt4x6 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return new UInt4x6 { Bits = (uint)PackUnpack.DownCast<UInt4>(PackUnpack.BitIntArrayToByte8<UInt4>(left.Bits) / PackUnpack.BitIntArrayToByte8<UInt4>(right.Bits)) };
            }

            uint x0  = left.Bits & bitmask32((uint)default(UInt4).Bits, 0u * (uint)default(UInt4).Bits);
            uint x1  = left.Bits & bitmask32((uint)default(UInt4).Bits, 1u * (uint)default(UInt4).Bits);
            uint x2  = left.Bits & bitmask32((uint)default(UInt4).Bits, 2u * (uint)default(UInt4).Bits);
            uint x3  = left.Bits & bitmask32((uint)default(UInt4).Bits, 3u * (uint)default(UInt4).Bits);
            uint x4  = left.Bits & bitmask32((uint)default(UInt4).Bits, 4u * (uint)default(UInt4).Bits);
            uint x5  = left.Bits & bitmask32((uint)default(UInt4).Bits, 5u * (uint)default(UInt4).Bits);
            
            x0 /= right[0];
            x1 /= right[1];
            x2 /= right[2];
            x3 /= right[3];
            x4 /= right[4];
            x5 /= right[5];

            uint blend0 = bits_select(x1,  x0,  bitmask32((uint)default(UInt4).Bits));
            uint blend1 = bits_select(x3,  x2,  bitmask32((uint)default(UInt4).Bits, 2u * (uint)default(UInt4).Bits));
            uint blend2 = bits_select(x5,  x4,  bitmask32((uint)default(UInt4).Bits, 4u * (uint)default(UInt4).Bits));

            blend0 = bits_select(blend1, blend0, bitmask32(2u * (uint)default(UInt4).Bits));
            blend1 = bits_select(0,      blend2, bitmask32(2u * (uint)default(UInt4).Bits, 4u * (uint)default(UInt4).Bits));
            
            blend0 = bits_select(blend1, blend0, bitmask32(4u * (uint)default(UInt4).Bits));

            return new UInt4x6 { Bits = blend0 };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator / (UInt4x6 left, uint right)
        {
            if (SWAR.ConstDiv<UInt4>(left.Bits, (int)right, out uint constDiv))
            {
                return new UInt4x6 { Bits = constDiv };
            }
        
            if (BurstArchitecture.IsSIMDSupported)
            {
                return new UInt4x6 { Bits = (uint)PackUnpack.DownCast<UInt4>(PackUnpack.BitIntArrayToByte8<UInt4>(left.Bits) / (byte)right) };
            }

            uint x0  = left.Bits & bitmask32((uint)default(UInt4).Bits, 0u * (uint)default(UInt4).Bits);
            uint x1  = left.Bits & bitmask32((uint)default(UInt4).Bits, 1u * (uint)default(UInt4).Bits);
            uint x2  = left.Bits & bitmask32((uint)default(UInt4).Bits, 2u * (uint)default(UInt4).Bits);
            uint x3  = left.Bits & bitmask32((uint)default(UInt4).Bits, 3u * (uint)default(UInt4).Bits);
            uint x4  = left.Bits & bitmask32((uint)default(UInt4).Bits, 4u * (uint)default(UInt4).Bits);
            uint x5  = left.Bits & bitmask32((uint)default(UInt4).Bits, 5u * (uint)default(UInt4).Bits);
            
            x0 /= right;
            x1 /= right;
            x2 /= right;
            x3 /= right;
            x4 /= right;
            x5 /= right;

            uint blend0 = bits_select(x1,  x0,  bitmask32((uint)default(UInt4).Bits));
            uint blend1 = bits_select(x3,  x2,  bitmask32((uint)default(UInt4).Bits, 2u * (uint)default(UInt4).Bits));
            uint blend2 = bits_select(x5,  x4,  bitmask32((uint)default(UInt4).Bits, 4u * (uint)default(UInt4).Bits));

            blend0 = bits_select(blend1, blend0, bitmask32(2u * (uint)default(UInt4).Bits));
            blend1 = bits_select(0,      blend2, bitmask32(2u * (uint)default(UInt4).Bits, 4u * (uint)default(UInt4).Bits));
            
            blend0 = bits_select(blend1, blend0, bitmask32(4u * (uint)default(UInt4).Bits));

            return new UInt4x6 { Bits = blend0 };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator / (uint left, UInt4x6 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return new UInt4x6 { Bits = (uint)PackUnpack.DownCast<UInt4>((byte)left / PackUnpack.BitIntArrayToByte8<UInt4>(right.Bits)) };
            }

            uint x0  = left << (0 * default(UInt4).Bits);
            uint x1  = left << (1 * default(UInt4).Bits);
            uint x2  = left << (2 * default(UInt4).Bits);
            uint x3  = left << (3 * default(UInt4).Bits);
            uint x4  = left << (4 * default(UInt4).Bits);
            uint x5  = left << (5 * default(UInt4).Bits);
            
            x0 /= right[0];
            x1 /= right[1];
            x2 /= right[2];
            x3 /= right[3];
            x4 /= right[4];
            x5 /= right[5];

            uint blend0 = bits_select(x1,  x0,  bitmask32((uint)default(UInt4).Bits));
            uint blend1 = bits_select(x3,  x2,  bitmask32((uint)default(UInt4).Bits, 2u * (uint)default(UInt4).Bits));
            uint blend2 = bits_select(x5,  x4,  bitmask32((uint)default(UInt4).Bits, 4u * (uint)default(UInt4).Bits));

            blend0 = bits_select(blend1, blend0, bitmask32(2u * (uint)default(UInt4).Bits));
            blend1 = bits_select(0,      blend2, bitmask32(2u * (uint)default(UInt4).Bits, 4u * (uint)default(UInt4).Bits));
            
            blend0 = bits_select(blend1, blend0, bitmask32(4u * (uint)default(UInt4).Bits));

            return new UInt4x6 { Bits = blend0 };
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator % (UInt4x6 left, UInt4x6 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                byte8 leftV = PackUnpack.BitIntArrayToByte8<UInt4>(left.Bits);
                byte8 rightV = PackUnpack.BitIntArrayToByte8<UInt4>(right.Bits);

            #if TESTING
                for (int i = 6; i < 8; i++)
                {
                    leftV[i] = 1;
                    rightV[i] = 1;
                }
            #endif

                return new UInt4x6 { Bits = (uint)PackUnpack.DownCast<UInt4>(leftV % rightV) };
            }

            return new UInt4x6((byte)(left[0] % right[0]),
                               (byte)(left[1] % right[1]),
                               (byte)(left[2] % right[2]),
                               (byte)(left[3] % right[3]),
                               (byte)(left[4] % right[4]),
                               (byte)(left[5] % right[5]));
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator % (UInt4x6 left, uint right)
        {
            if (SWAR.ConstRem<UInt4>(left.Bits, (int)right, out uint constRem))
            {
                return new UInt4x6 { Bits = constRem };
            }

            if (BurstArchitecture.IsSIMDSupported)
            {
                byte8 leftV = PackUnpack.BitIntArrayToByte8<UInt4>(left.Bits);

            #if TESTING
                for (int i = 6; i < 8; i++)
                {
                    leftV[i] = 1;
                }
            #endif

                return new UInt4x6 { Bits = (uint)PackUnpack.DownCast<UInt4>(leftV % (byte)right) };
            }
            
            return new UInt4x6((byte)(left[0] % right),
                               (byte)(left[1] % right),
                               (byte)(left[2] % right),
                               (byte)(left[3] % right),
                               (byte)(left[4] % right),
                               (byte)(left[5] % right));
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator % (uint left, UInt4x6 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                byte8 rightV = PackUnpack.BitIntArrayToByte8<UInt4>(right.Bits);

            #if TESTING
                for (int i = 6; i < 8; i++)
                {
                    rightV[i] = 1;
                }
            #endif

                return new UInt4x6 { Bits = (uint)PackUnpack.DownCast<UInt4>((byte)left % rightV) };
            }
            
            return new UInt4x6((byte)(left % right[0]),
                               (byte)(left % right[1]),
                               (byte)(left % right[2]),
                               (byte)(left % right[3]),
                               (byte)(left % right[4]),
                               (byte)(left % right[5]));
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator << (UInt4x6 left, int right) => new UInt4x6 { Bits = SWAR.ShiftLeftLogical<UInt4>(left.Bits, right) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator >> (UInt4x6 left, int right) => new UInt4x6 { Bits = SWAR.ShiftRightLogical<UInt4>(left.Bits, right) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator ~ (UInt4x6 value) => new UInt4x6{ Bits = ~value.Bits };
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator ^ (UInt4x6 left, UInt4x6 right) => new UInt4x6{ Bits = left.Bits ^ right.Bits };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator ^ (UInt4x6 left, uint right) => left ^ new UInt4x6((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator ^ (uint left, UInt4x6 right) => right ^ left;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator & (UInt4x6 left, UInt4x6 right) => new UInt4x6{ Bits = left.Bits & right.Bits };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator & (UInt4x6 left, uint right) => left & new UInt4x6((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator & (uint left, UInt4x6 right) => right & left;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator | (UInt4x6 left, UInt4x6 right) => new UInt4x6{ Bits = left.Bits | right.Bits };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator | (UInt4x6 left, uint right) => left | new UInt4x6((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator | (uint left, UInt4x6 right) => right | left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator == (UInt4x6 left, UInt4x6 right) => new UInt4x6 { Bits = SWAR.Equals<UInt4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator == (UInt4x6 left, uint right) => left == new UInt4x6((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator == (uint left, UInt4x6 right) => right == left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator != (UInt4x6 left, UInt4x6 right) => new UInt4x6 { Bits = SWAR.NotEquals<UInt4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator != (UInt4x6 left, uint right) => left != new UInt4x6((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator != (uint left, UInt4x6 right) => right != left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator < (UInt4x6 left, UInt4x6 right) => new UInt4x6 { Bits = SWAR.LessThan<UInt4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator < (UInt4x6 left, uint right) => left < new UInt4x6((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator < (uint left, UInt4x6 right) => right > left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator > (UInt4x6 left, UInt4x6 right) => new UInt4x6 { Bits = SWAR.GreaterThan<UInt4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator > (UInt4x6 left, uint right) => left > new UInt4x6((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator > (uint left, UInt4x6 right) => right < left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator <= (UInt4x6 left, UInt4x6 right) => new UInt4x6 { Bits = SWAR.LessThanOrEqual<UInt4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator <= (UInt4x6 left, uint right) => left <= new UInt4x6((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator <= (uint left, UInt4x6 right) => right >= left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator >= (UInt4x6 left, UInt4x6 right) => new UInt4x6 { Bits = SWAR.GreaterThanOrEqual<UInt4>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator >= (UInt4x6 left, uint right) => left >= new UInt4x6((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x6 operator >= (uint left, UInt4x6 right) => right <= left;

        
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
        public readonly UInt4x6 SetReplicate(int index, int numNumbers, uint value)
        {
            return new UInt4x6 { Bits = BitFieldHelper.SetReplicate<UInt4>(Bits, (int)value, numNumbers, default(UInt4).Bits * index, default(UInt4).Bits * Length) };
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(UInt4x6 other)
        {
            return this.Bits == other.Bits;
        }

        public override readonly bool Equals(object obj)
        {
            return obj is UInt4x6 converted && this.Equals(converted);
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


        public readonly IEnumerator<uint> GetEnumerator()
        {
            return new ArrayEnumerator<UInt4x6, uint>(this);
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<UInt4x6, uint>(this);
        }
    }
}