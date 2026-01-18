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
    unsafe public struct UInt5x8 : IArray<uint>, IEquatable<UInt5x8>
    {
        public UInt40 Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt5x8(byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7)
        {
Assert.IsNotGreater(x0, UInt5.MaxValue);
Assert.IsNotGreater(x1, UInt5.MaxValue);
Assert.IsNotGreater(x2, UInt5.MaxValue);
Assert.IsNotGreater(x3, UInt5.MaxValue);
Assert.IsNotGreater(x4, UInt5.MaxValue);
Assert.IsNotGreater(x5, UInt5.MaxValue);
Assert.IsNotGreater(x6, UInt5.MaxValue);
//Assert.IsNotGreater(x7, UInt5.MaxValue);

            Bits = (((ulong)x0 << (0 * default(UInt5).Bits))
                  |  ((ulong)x1 << (1 * default(UInt5).Bits))
                  |  ((ulong)x2 << (2 * default(UInt5).Bits))
                  |  ((ulong)x3 << (3 * default(UInt5).Bits))
                  |  ((ulong)x4 << (4 * default(UInt5).Bits))
                  |  ((ulong)x5 << (5 * default(UInt5).Bits))
                  |  ((ulong)x6 << (6 * default(UInt5).Bits))
                  |  ((ulong)x7 << (7 * default(UInt5).Bits)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt5x8(byte x0_7)
        {
            Bits = SWAR.Broadcast64<UInt5>(x0_7);
        }


        public readonly int Length => 8;


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


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt6x8(UInt5x8 input) => new UInt6x8 { Bits = (UInt48)PackUnpack.UpCast64<UInt5, UInt6>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt7x8(UInt5x8 input) => new UInt7x8 { Bits = (UInt56)PackUnpack.UpCast64<UInt5, UInt7>(input.Bits) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt5x8(UInt6x8 input) => new UInt5x8 { Bits = (UInt40)PackUnpack.DownCast<UInt6, UInt5>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt5x8(UInt7x8 input) => new UInt5x8 { Bits = (UInt40)PackUnpack.DownCast<UInt7, UInt5>(input.Bits) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator byte8(UInt5x8 input) => PackUnpack.BitIntArrayToByte8<UInt5>(input.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ushort8(UInt5x8 input) => PackUnpack.BitIntArrayToUShort8<UInt5>(input.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint8(UInt5x8 input) => PackUnpack.BitIntArrayToUInt8<UInt5>(input.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator sbyte8(UInt5x8 input) => (sbyte8)(byte8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator short8(UInt5x8 input) => (short8)(ushort8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int8(UInt5x8 input) => (int8)(uint8)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt5x8(byte8 input) => new UInt5x8 { Bits = (UInt40)PackUnpack.DownCast<UInt5>(input) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt5x8(ushort8 input) => new UInt5x8 { Bits = (UInt40)PackUnpack.DownCast<UInt5>(input) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt5x8(uint8 input) => new UInt5x8 { Bits = (UInt40)PackUnpack.DownCast<UInt5>(input) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt5x8(sbyte8 input) => (UInt5x8)(byte8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt5x8(short8 input) => (UInt5x8)(ushort8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt5x8(int8 input) => (UInt5x8)(uint8)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter8(UInt5x8 input) => (quarter8)(byte8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator half8(UInt5x8 input) => (half8)(ushort8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float8(UInt5x8 input) => (float8)(int8)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt5x8(quarter8 input) => (UInt5x8)(byte8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt5x8(half8 input) => (UInt5x8)(ushort8)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt5x8(float8 input) => (UInt5x8)(int8)input;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator ++ (UInt5x8 value) => value + 1;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator -- (UInt5x8 value) => value - 1;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator + (UInt5x8 left, UInt5x8 right) => new UInt5x8 { Bits = SWAR.Add<UInt5>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator + (UInt5x8 left, uint right) => left + new UInt5x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator + (uint left, UInt5x8 right) => right + left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator - (UInt5x8 left, UInt5x8 right) => new UInt5x8 { Bits = SWAR.Sub<UInt5>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator - (UInt5x8 left, uint right) => left - new UInt5x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator - (uint left, UInt5x8 right) => new UInt5x8((byte)left) - right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator * (UInt5x8 left, UInt5x8 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return new UInt5x8 { Bits = (ulong)PackUnpack.DownCast<UInt5>(PackUnpack.BitIntArrayToByte8<UInt5>(left.Bits) * PackUnpack.BitIntArrayToByte8<UInt5>(right.Bits)) };
            }

            return new UInt5x8 { Bits = SWAR.Mul<UInt5>(left.Bits, right.Bits) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator * (UInt5x8 left, uint right)
        {
            if (SWAR.ConstMul<UInt5>(left.Bits, right, out ulong constMul))
            {
                return new UInt5x8 { Bits = constMul };
            }
        
            return left * new UInt5x8((byte)right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator * (uint left, UInt5x8 right) => right * left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator / (UInt5x8 left, UInt5x8 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return new UInt5x8 { Bits = (ulong)PackUnpack.DownCast<UInt5>(PackUnpack.BitIntArrayToByte8<UInt5>(left.Bits) / PackUnpack.BitIntArrayToByte8<UInt5>(right.Bits)) };
            }

            ulong x0  = left.Bits & bitmask64((ulong)default(UInt5).Bits, 0u * (ulong)default(UInt5).Bits);
            ulong x1  = left.Bits & bitmask64((ulong)default(UInt5).Bits, 1u * (ulong)default(UInt5).Bits);
            ulong x2  = left.Bits & bitmask64((ulong)default(UInt5).Bits, 2u * (ulong)default(UInt5).Bits);
            ulong x3  = left.Bits & bitmask64((ulong)default(UInt5).Bits, 3u * (ulong)default(UInt5).Bits);
            ulong x4  = left.Bits & bitmask64((ulong)default(UInt5).Bits, 4u * (ulong)default(UInt5).Bits);
            ulong x5  = left.Bits & bitmask64((ulong)default(UInt5).Bits, 5u * (ulong)default(UInt5).Bits);
            ulong x6  = left.Bits & bitmask64((ulong)default(UInt5).Bits, 6u * (ulong)default(UInt5).Bits);
            ulong x7  = left.Bits & bitmask64((ulong)default(UInt5).Bits, 7u * (ulong)default(UInt5).Bits);
            
            x0 /= right[0];
            x1 /= right[1];
            x2 /= right[2];
            x3 /= right[3];
            x4 /= right[4];
            x5 /= right[5];
            x6 /= right[6];
            x7 /= right[7];

            ulong blend0 = bits_select(x1,  x0,  bitmask64((ulong)default(UInt5).Bits));
            ulong blend1 = bits_select(x3,  x2,  bitmask64((ulong)default(UInt5).Bits, 2u * (ulong)default(UInt5).Bits));
            ulong blend2 = bits_select(x5,  x4,  bitmask64((ulong)default(UInt5).Bits, 4u * (ulong)default(UInt5).Bits));
            ulong blend3 = bits_select(x7,  x6,  bitmask64((ulong)default(UInt5).Bits, 6u * (ulong)default(UInt5).Bits));

            blend0 = bits_select(blend1, blend0, bitmask64(2u * (ulong)default(UInt5).Bits));
            blend1 = bits_select(blend3, blend2, bitmask64(2u * (ulong)default(UInt5).Bits, 4u * (ulong)default(UInt5).Bits));
            
            blend0 = bits_select(blend1, blend0, bitmask64(4u * (ulong)default(UInt5).Bits));

            return new UInt5x8 { Bits = blend0 };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator / (UInt5x8 left, uint right)
        {
            if (SWAR.ConstDiv<UInt5>(left.Bits, (long)right, out ulong constDiv))
            {
                return new UInt5x8 { Bits = constDiv };
            }

            if (BurstArchitecture.IsSIMDSupported)
            {
                return new UInt5x8 { Bits = (ulong)PackUnpack.DownCast<UInt5>(PackUnpack.BitIntArrayToByte8<UInt5>(left.Bits) / (byte)right) };
            }

            ulong x0  = left.Bits & bitmask64((ulong)default(UInt5).Bits, 0u * (ulong)default(UInt5).Bits);
            ulong x1  = left.Bits & bitmask64((ulong)default(UInt5).Bits, 1u * (ulong)default(UInt5).Bits);
            ulong x2  = left.Bits & bitmask64((ulong)default(UInt5).Bits, 2u * (ulong)default(UInt5).Bits);
            ulong x3  = left.Bits & bitmask64((ulong)default(UInt5).Bits, 3u * (ulong)default(UInt5).Bits);
            ulong x4  = left.Bits & bitmask64((ulong)default(UInt5).Bits, 4u * (ulong)default(UInt5).Bits);
            ulong x5  = left.Bits & bitmask64((ulong)default(UInt5).Bits, 5u * (ulong)default(UInt5).Bits);
            ulong x6  = left.Bits & bitmask64((ulong)default(UInt5).Bits, 6u * (ulong)default(UInt5).Bits);
            ulong x7  = left.Bits & bitmask64((ulong)default(UInt5).Bits, 7u * (ulong)default(UInt5).Bits);
            
            x0 /= right;
            x1 /= right;
            x2 /= right;
            x3 /= right;
            x4 /= right;
            x5 /= right;
            x6 /= right;
            x7 /= right;

            ulong blend0 = bits_select(x1,  x0,  bitmask64((ulong)default(UInt5).Bits));
            ulong blend1 = bits_select(x3,  x2,  bitmask64((ulong)default(UInt5).Bits, 2u * (ulong)default(UInt5).Bits));
            ulong blend2 = bits_select(x5,  x4,  bitmask64((ulong)default(UInt5).Bits, 4u * (ulong)default(UInt5).Bits));
            ulong blend3 = bits_select(x7,  x6,  bitmask64((ulong)default(UInt5).Bits, 6u * (ulong)default(UInt5).Bits));

            blend0 = bits_select(blend1, blend0, bitmask64(2u * (ulong)default(UInt5).Bits));
            blend1 = bits_select(blend3, blend2, bitmask64(2u * (ulong)default(UInt5).Bits, 4u * (ulong)default(UInt5).Bits));
            
            blend0 = bits_select(blend1, blend0, bitmask64(4u * (ulong)default(UInt5).Bits));

            return new UInt5x8 { Bits = blend0 };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator / (uint left, UInt5x8 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return new UInt5x8 { Bits = (ulong)PackUnpack.DownCast<UInt5>((byte)left / PackUnpack.BitIntArrayToByte8<UInt5>(right.Bits)) };
            }

            ulong x0 = (ulong)left << (0 * default(UInt5).Bits);
            ulong x1 = (ulong)left << (1 * default(UInt5).Bits);
            ulong x2 = (ulong)left << (2 * default(UInt5).Bits);
            ulong x3 = (ulong)left << (3 * default(UInt5).Bits);
            ulong x4 = (ulong)left << (4 * default(UInt5).Bits);
            ulong x5 = (ulong)left << (5 * default(UInt5).Bits);
            ulong x6 = (ulong)left << (6 * default(UInt5).Bits);
            ulong x7 = (ulong)left << (7 * default(UInt5).Bits);
            
            x0 /= right[0];
            x1 /= right[1];
            x2 /= right[2];
            x3 /= right[3];
            x4 /= right[4];
            x5 /= right[5];
            x6 /= right[6];
            x7 /= right[7];

            ulong blend0 = bits_select(x1,  x0,  bitmask64((ulong)default(UInt5).Bits));
            ulong blend1 = bits_select(x3,  x2,  bitmask64((ulong)default(UInt5).Bits, 2u * (ulong)default(UInt5).Bits));
            ulong blend2 = bits_select(x5,  x4,  bitmask64((ulong)default(UInt5).Bits, 4u * (ulong)default(UInt5).Bits));
            ulong blend3 = bits_select(x7,  x6,  bitmask64((ulong)default(UInt5).Bits, 6u * (ulong)default(UInt5).Bits));

            blend0 = bits_select(blend1, blend0, bitmask64(2u * (ulong)default(UInt5).Bits));
            blend1 = bits_select(blend3, blend2, bitmask64(2u * (ulong)default(UInt5).Bits, 4u * (ulong)default(UInt5).Bits));
            
            blend0 = bits_select(blend1, blend0, bitmask64(4u * (ulong)default(UInt5).Bits));

            return new UInt5x8 { Bits = blend0 };
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator % (UInt5x8 left, UInt5x8 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return new UInt5x8 { Bits = (ulong)PackUnpack.DownCast<UInt5>(PackUnpack.BitIntArrayToByte8<UInt5>(left.Bits) % PackUnpack.BitIntArrayToByte8<UInt5>(right.Bits)) };
            }

            return new UInt5x8((byte)(left[0] % right[0]),
                               (byte)(left[1] % right[1]),
                               (byte)(left[2] % right[2]),
                               (byte)(left[3] % right[3]),
                               (byte)(left[4] % right[4]),
                               (byte)(left[5] % right[5]),
                               (byte)(left[6] % right[6]),
                               (byte)(left[7] % right[7]));
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator % (UInt5x8 left, uint right)
        {
            if (SWAR.ConstRem<UInt5>(left.Bits, (long)right, out ulong constRem))
            {
                return new UInt5x8 { Bits = constRem };
            }

            if (BurstArchitecture.IsSIMDSupported)
            {
                return new UInt5x8 { Bits = (ulong)PackUnpack.DownCast<UInt5>(PackUnpack.BitIntArrayToByte8<UInt5>(left.Bits) % (byte)right) };
            }
            
            return new UInt5x8((byte)(left[0] % right),
                               (byte)(left[1] % right),
                               (byte)(left[2] % right),
                               (byte)(left[3] % right),
                               (byte)(left[4] % right),
                               (byte)(left[5] % right),
                               (byte)(left[6] % right),
                               (byte)(left[7] % right));
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator % (uint left, UInt5x8 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return new UInt5x8 { Bits = (ulong)PackUnpack.DownCast<UInt5>((byte)left % PackUnpack.BitIntArrayToByte8<UInt5>(right.Bits)) };
            }
            
            return new UInt5x8((byte)(left % right[0]),
                               (byte)(left % right[1]),
                               (byte)(left % right[2]),
                               (byte)(left % right[3]),
                               (byte)(left % right[4]),
                               (byte)(left % right[5]),
                               (byte)(left % right[6]),
                               (byte)(left % right[7]));
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator << (UInt5x8 left, int right) => new UInt5x8 { Bits = SWAR.ShiftLeftLogical<UInt5>(left.Bits, right) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator >> (UInt5x8 left, int right) => new UInt5x8 { Bits = SWAR.ShiftRightLogical<UInt5>(left.Bits, right) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator ~ (UInt5x8 value) => new UInt5x8{ Bits = ~value.Bits };
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator ^ (UInt5x8 left, UInt5x8 right) => new UInt5x8{ Bits = left.Bits ^ right.Bits };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator ^ (UInt5x8 left, uint right) => left ^ new UInt5x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator ^ (uint left, UInt5x8 right) => right ^ left;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator & (UInt5x8 left, UInt5x8 right) => new UInt5x8{ Bits = left.Bits & right.Bits };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator & (UInt5x8 left, uint right) => left & new UInt5x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator & (uint left, UInt5x8 right) => right & left;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator | (UInt5x8 left, UInt5x8 right) => new UInt5x8{ Bits = left.Bits | right.Bits };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator | (UInt5x8 left, uint right) => left | new UInt5x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator | (uint left, UInt5x8 right) => right | left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator == (UInt5x8 left, UInt5x8 right) => new UInt5x8 { Bits = SWAR.Equals<UInt5>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator == (UInt5x8 left, uint right) => left == new UInt5x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator == (uint left, UInt5x8 right) => right == left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator != (UInt5x8 left, UInt5x8 right) => new UInt5x8 { Bits = SWAR.NotEquals<UInt5>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator != (UInt5x8 left, uint right) => left != new UInt5x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator != (uint left, UInt5x8 right) => right != left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator < (UInt5x8 left, UInt5x8 right) => new UInt5x8 { Bits = SWAR.LessThan<UInt5>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator < (UInt5x8 left, uint right) => left < new UInt5x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator < (uint left, UInt5x8 right) => right > left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator > (UInt5x8 left, UInt5x8 right) => new UInt5x8 { Bits = SWAR.GreaterThan<UInt5>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator > (UInt5x8 left, uint right) => left > new UInt5x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator > (uint left, UInt5x8 right) => right < left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator <= (UInt5x8 left, UInt5x8 right) => new UInt5x8 { Bits = SWAR.LessThanOrEqual<UInt5>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator <= (UInt5x8 left, uint right) => left <= new UInt5x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator <= (uint left, UInt5x8 right) => right >= left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator >= (UInt5x8 left, UInt5x8 right) => new UInt5x8 { Bits = SWAR.GreaterThanOrEqual<UInt5>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator >= (UInt5x8 left, uint right) => left >= new UInt5x8((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt5x8 operator >= (uint left, UInt5x8 right) => right <= left;

        
        public uint this[int index]
        {
            [return: AssumeRange((ulong)UInt5.MinValue, (ulong)UInt5.MaxValue)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (uint)BitFieldHelper.Get<UInt5>(Bits, default(UInt5).Bits * index, default(UInt5).Bits * Length);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Bits = BitFieldHelper.Set<UInt5>(Bits, (int)value, default(UInt5).Bits * index, default(UInt5).Bits * Length);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly UInt5x8 SetReplicate(int index, int numNumbers, uint value)
        {
            return new UInt5x8 { Bits = BitFieldHelper.SetReplicate<UInt5>(Bits, (int)value, numNumbers, default(UInt5).Bits * index, default(UInt5).Bits * Length) };
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(UInt5x8 other)
        {
            return this.Bits == other.Bits;
        }

        public override readonly bool Equals(object obj)
        {
            return obj is UInt5x8 converted && this.Equals(converted);
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
            return new ArrayEnumerator<UInt5x8, uint>(this);
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<UInt5x8, uint>(this);
        }
    }
}