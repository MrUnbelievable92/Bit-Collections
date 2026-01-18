using DevTools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;
using Unity.Mathematics;
using MaxMath;

using static MaxMath.maxmath;
using MaxMath.Intrinsics;

namespace BitCollections
{
    [Serializable]
    unsafe public struct UInt6x4 : IArray<uint>, IEquatable<UInt6x4>
    {
        public UInt24 Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt6x4(byte x, byte y, byte z, byte w)
        {
Assert.IsNotGreater(x, UInt6.MaxValue);
Assert.IsNotGreater(y, UInt6.MaxValue);
Assert.IsNotGreater(z, UInt6.MaxValue);
//Assert.IsNotGreater(w, UInt6.MaxValue);

            Bits = (((uint)x << (0 * default(UInt6).Bits))
                  |  ((uint)y << (1 * default(UInt6).Bits))
                  |  ((uint)z << (2 * default(UInt6).Bits))
                  |  ((uint)w << (3 * default(UInt6).Bits)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt6x4(byte xyzw)
        {
            Bits = SWAR.Broadcast32<UInt6>(xyzw);
        }


        public readonly int Length => 4;


        public uint x
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[0];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[0] = value;
        }
        public uint y
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[1];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[1] = value;
        }
        public uint z
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[2];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[2] = value;
        }
        public uint w
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[3];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[3] = value;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt10x4(UInt6x4 input) => new UInt10x4 { Bits = (UInt40)PackUnpack.UpCast64<UInt6, UInt10>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt12x4(UInt6x4 input) => new UInt12x4 { Bits = (UInt48)PackUnpack.UpCast64<UInt6, UInt12>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt14x4(UInt6x4 input) => new UInt14x4 { Bits = (UInt56)PackUnpack.UpCast64<UInt6, UInt14>(input.Bits) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt6x4(UInt10x4 input) => new UInt6x4 { Bits = (UInt24)PackUnpack.DownCast<UInt10, UInt6>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt6x4(UInt12x4 input) => new UInt6x4 { Bits = (UInt24)PackUnpack.DownCast<UInt12, UInt6>(input.Bits) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt6x4(UInt14x4 input) => new UInt6x4 { Bits = (UInt24)PackUnpack.DownCast<UInt14, UInt6>(input.Bits) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator byte4(UInt6x4 input) => PackUnpack.BitIntArrayToByte4<UInt6>(input.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ushort4(UInt6x4 input) => PackUnpack.BitIntArrayToUShort4<UInt6>(input.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint4(UInt6x4 input) => PackUnpack.BitIntArrayToUInt4<UInt6>(input.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong4(UInt6x4 input) => PackUnpack.BitIntArrayToULong4<UInt6>(input.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator sbyte4(UInt6x4 input) => (sbyte4)(byte4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator short4(UInt6x4 input) => (short4)(ushort4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int4(UInt6x4 input) => (int4)(uint4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long4(UInt6x4 input) => (long4)(ulong4)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt6x4(byte4 input) => new UInt6x4 { Bits = (UInt24)PackUnpack.DownCast<UInt6>(input) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt6x4(ushort4 input) => new UInt6x4 { Bits = (UInt24)PackUnpack.DownCast<UInt16, UInt6>(input.Reinterpret<ushort4, ulong>()) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt6x4(uint4 input) => new UInt6x4 { Bits = (UInt24)PackUnpack.DownCast<UInt6>(input) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt6x4(ulong4 input) => new UInt6x4 { Bits = (UInt24)PackUnpack.DownCast<UInt6>(input) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt6x4(sbyte4 input) => (UInt6x4)(byte4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt6x4(short4 input) => (UInt6x4)(ushort4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt6x4(int4 input) => (UInt6x4)(uint4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt6x4(long4 input) => (UInt6x4)(ulong4)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter4(UInt6x4 input) => (quarter4)(byte4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator half4(UInt6x4 input) => (half4)(ushort4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float4(UInt6x4 input) => (float4)(int4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4(UInt6x4 input) => (double4)(int4)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt6x4(quarter4 input) => (UInt6x4)(byte4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt6x4(half4 input) => (UInt6x4)(ushort4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt6x4(float4 input) => (UInt6x4)(int4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt6x4(double4 input) => (UInt6x4)(int4)input;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator ++ (UInt6x4 value) => value + 1;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator -- (UInt6x4 value) => value - 1;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator + (UInt6x4 left, UInt6x4 right) => new UInt6x4 { Bits = SWAR.Add<UInt6>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator + (UInt6x4 left, uint right) => left + new UInt6x4((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator + (uint left, UInt6x4 right) => right + left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator - (UInt6x4 left, UInt6x4 right) => new UInt6x4 { Bits = SWAR.Sub<UInt6>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator - (UInt6x4 left, uint right) => left - new UInt6x4((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator - (uint left, UInt6x4 right) => new UInt6x4((byte)left) - right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator * (UInt6x4 left, UInt6x4 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return new UInt6x4 { Bits = (uint)PackUnpack.DownCast<UInt6>(PackUnpack.BitIntArrayToUShort4<UInt6>(left.Bits) * PackUnpack.BitIntArrayToUShort4<UInt6>(right.Bits)) };
            }
            
            uint x0  = left.Bits & bitmask32((uint)default(UInt6).Bits, 0u * (uint)default(UInt6).Bits);
            uint x1  = left.Bits & bitmask32((uint)default(UInt6).Bits, 1u * (uint)default(UInt6).Bits);
            uint x2  = left.Bits & bitmask32((uint)default(UInt6).Bits, 2u * (uint)default(UInt6).Bits);
            uint x3  = left.Bits & bitmask32((uint)default(UInt6).Bits, 3u * (uint)default(UInt6).Bits);
            
            x0 *= right[0];
            x1 *= right[1];
            x2 *= right[2];
            x3 *= right[3];

            uint blend0 = bits_select(x1,  x0,  bitmask32((uint)default(UInt6).Bits));
            uint blend1 = bits_select(x3,  x2,  bitmask32((uint)default(UInt6).Bits, 2u * (uint)default(UInt6).Bits));

            blend0 = bits_select(blend1, blend0, bitmask32(2u * (uint)default(UInt6).Bits));

            return new UInt6x4 { Bits = blend0 };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator * (UInt6x4 left, uint right)
        {
            if (SWAR.ConstMul<UInt6>(left.Bits, right, out uint constMul))
            {
                return new UInt6x4 { Bits = constMul };
            }
        
            uint x0  = left.Bits & bitmask32((uint)default(UInt6).Bits, 0u * (uint)default(UInt6).Bits);
            uint x1  = left.Bits & bitmask32((uint)default(UInt6).Bits, 1u * (uint)default(UInt6).Bits);
            uint x2  = left.Bits & bitmask32((uint)default(UInt6).Bits, 2u * (uint)default(UInt6).Bits);
            uint x3  = left.Bits & bitmask32((uint)default(UInt6).Bits, 3u * (uint)default(UInt6).Bits);
            
            x0 *= right;
            x1 *= right;
            x2 *= right;
            x3 *= right;

            uint blend0 = bits_select(x1,  x0,  bitmask32((uint)default(UInt6).Bits));
            uint blend1 = bits_select(x3,  x2,  bitmask32((uint)default(UInt6).Bits, 2u * (uint)default(UInt6).Bits));

            blend0 = bits_select(blend1, blend0, bitmask32(2u * (uint)default(UInt6).Bits));

            return new UInt6x4 { Bits = blend0 };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator * (uint left, UInt6x4 right) => right * left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator / (UInt6x4 left, UInt6x4 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return new UInt6x4 { Bits = (uint)PackUnpack.DownCast<UInt6>(PackUnpack.BitIntArrayToUShort4<UInt6>(left.Bits) / PackUnpack.BitIntArrayToUShort4<UInt6>(right.Bits)) };
            }

            uint x0  = left.Bits & bitmask32((uint)default(UInt6).Bits, 0u * (uint)default(UInt6).Bits);
            uint x1  = left.Bits & bitmask32((uint)default(UInt6).Bits, 1u * (uint)default(UInt6).Bits);
            uint x2  = left.Bits & bitmask32((uint)default(UInt6).Bits, 2u * (uint)default(UInt6).Bits);
            uint x3  = left.Bits & bitmask32((uint)default(UInt6).Bits, 3u * (uint)default(UInt6).Bits);
            
            x0 /= right[0];
            x1 /= right[1];
            x2 /= right[2];
            x3 /= right[3];

            uint blend0 = bits_select(x1,  x0,  bitmask32((uint)default(UInt6).Bits));
            uint blend1 = bits_select(x3,  x2,  bitmask32((uint)default(UInt6).Bits, 2u * (uint)default(UInt6).Bits));

            blend0 = bits_select(blend1, blend0, bitmask32(2u * (uint)default(UInt6).Bits));

            return new UInt6x4 { Bits = blend0 };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator / (UInt6x4 left, uint right)
        {
            if (SWAR.ConstDiv<UInt6>(left.Bits, (int)right, out uint constDiv))
            {
                return new UInt6x4 { Bits = constDiv };
            }
        
            if (BurstArchitecture.IsSIMDSupported)
            {
                return new UInt6x4 { Bits = (uint)PackUnpack.DownCast<UInt6>(PackUnpack.BitIntArrayToUShort4<UInt6>(left.Bits) / (ushort)right) };
            }

            uint x0  = left.Bits & bitmask32((uint)default(UInt6).Bits, 0u * (uint)default(UInt6).Bits);
            uint x1  = left.Bits & bitmask32((uint)default(UInt6).Bits, 1u * (uint)default(UInt6).Bits);
            uint x2  = left.Bits & bitmask32((uint)default(UInt6).Bits, 2u * (uint)default(UInt6).Bits);
            uint x3  = left.Bits & bitmask32((uint)default(UInt6).Bits, 3u * (uint)default(UInt6).Bits);

            x0 /= right;
            x1 /= right;
            x2 /= right;
            x3 /= right;

            uint blend0 = bits_select(x1,  x0,  bitmask32((uint)default(UInt6).Bits));
            uint blend1 = bits_select(x3,  x2,  bitmask32((uint)default(UInt6).Bits, 2u * (uint)default(UInt6).Bits));

            blend0 = bits_select(blend1, blend0, bitmask32(2u * (uint)default(UInt6).Bits));

            return new UInt6x4 { Bits = blend0 };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator / (uint left, UInt6x4 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return new UInt6x4 { Bits = (uint)PackUnpack.DownCast<UInt6>((ushort)left / PackUnpack.BitIntArrayToUShort4<UInt6>(right.Bits)) };
            }
            else
            {
                uint x0 = left << (0 * default(UInt6).Bits);
                uint x1 = left << (1 * default(UInt6).Bits);
                uint x2 = left << (2 * default(UInt6).Bits);
                uint x3 = left << (3 * default(UInt6).Bits);
        
                x0 /= right[0];
                x1 /= right[1];
                x2 /= right[2];
                x3 /= right[3];

                uint lo = bits_select(x1, x0, bitmask32((uint)default(UInt6).Bits));
                uint hi = bits_select(x3, x2, bitmask32((uint)default(UInt6).Bits, 2u * (uint)default(UInt6).Bits));

                return new UInt6x4 { Bits = bits_select(hi, lo, bitmask32(2u * (uint)default(UInt6).Bits)) };
            }
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator % (UInt6x4 left, UInt6x4 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt6x4)((byte4)left % right);
            }
            else
            {
                return new UInt6x4((byte)(left[0] % right[0]),
                                   (byte)(left[1] % right[1]),
                                   (byte)(left[2] % right[2]),
                                   (byte)(left[3] % right[3]));
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator % (UInt6x4 left, uint right)
        {
            if (SWAR.ConstRem<UInt6>(left.Bits, (int)right, out uint constRem))
            {
                return new UInt6x4 { Bits = constRem };
            }
        
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt6x4)((byte4)left % (byte)right);
            }
            else
            {
                return new UInt6x4((byte)(left[0] % right),
                                   (byte)(left[1] % right),
                                   (byte)(left[2] % right),
                                   (byte)(left[3] % right));
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator % (uint left, UInt6x4 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt6x4)((byte)left % (byte4)right);
            }
            else
            {
                return new UInt6x4((byte)(left % right[0]),
                                   (byte)(left % right[1]),
                                   (byte)(left % right[2]),
                                   (byte)(left % right[3]));
            }
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator << (UInt6x4 left, int right) => new UInt6x4 { Bits = SWAR.ShiftLeftLogical<UInt6>(left.Bits, right) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator >> (UInt6x4 left, int right) => new UInt6x4 { Bits = SWAR.ShiftRightLogical<UInt6>(left.Bits, right) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator ~ (UInt6x4 value) => new UInt6x4{ Bits = ~value.Bits };
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator ^ (UInt6x4 left, UInt6x4 right) => new UInt6x4{ Bits = left.Bits ^ right.Bits };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator ^ (UInt6x4 left, uint right) => left ^ new UInt6x4((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator ^ (uint left, UInt6x4 right) => right ^ left;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator & (UInt6x4 left, UInt6x4 right) => new UInt6x4{ Bits = left.Bits & right.Bits };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator & (UInt6x4 left, uint right) => left & new UInt6x4((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator & (uint left, UInt6x4 right) => right & left;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator | (UInt6x4 left, UInt6x4 right) => new UInt6x4{ Bits = left.Bits | right.Bits };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator | (UInt6x4 left, uint right) => left | new UInt6x4((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator | (uint left, UInt6x4 right) => right | left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator == (UInt6x4 left, UInt6x4 right) => new UInt6x4 { Bits = SWAR.Equals<UInt6>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator == (UInt6x4 left, uint right) => left == new UInt6x4((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator == (uint left, UInt6x4 right) => right == left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator != (UInt6x4 left, UInt6x4 right) => new UInt6x4 { Bits = SWAR.NotEquals<UInt6>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator != (UInt6x4 left, uint right) => left != new UInt6x4((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator != (uint left, UInt6x4 right) => right != left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator < (UInt6x4 left, UInt6x4 right) => new UInt6x4 { Bits = SWAR.LessThan<UInt6>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator < (UInt6x4 left, uint right) => left < new UInt6x4((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator < (uint left, UInt6x4 right) => right > left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator > (UInt6x4 left, UInt6x4 right) => new UInt6x4 { Bits = SWAR.GreaterThan<UInt6>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator > (UInt6x4 left, uint right) => left > new UInt6x4((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator > (uint left, UInt6x4 right) => right < left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator <= (UInt6x4 left, UInt6x4 right) => new UInt6x4 { Bits = SWAR.LessThanOrEqual<UInt6>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator <= (UInt6x4 left, uint right) => left <= new UInt6x4((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator <= (uint left, UInt6x4 right) => right >= left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator >= (UInt6x4 left, UInt6x4 right) => new UInt6x4 { Bits = SWAR.GreaterThanOrEqual<UInt6>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator >= (UInt6x4 left, uint right) => left >= new UInt6x4((byte)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt6x4 operator >= (uint left, UInt6x4 right) => right <= left;

        
        public uint this[int index]
        {
            [return: AssumeRange((ulong)UInt6.MinValue, (ulong)UInt6.MaxValue)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (uint)BitFieldHelper.Get<UInt6>(Bits, default(UInt6).Bits * index, default(UInt6).Bits * Length);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Bits = BitFieldHelper.Set<UInt6>(Bits, (int)value, default(UInt6).Bits * index, default(UInt6).Bits * Length);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly UInt6x4 SetReplicate(int index, int numNumbers, uint value)
        {
            return new UInt6x4 { Bits = BitFieldHelper.SetReplicate<UInt6>(Bits, (int)value, numNumbers, default(UInt6).Bits * index, default(UInt6).Bits * Length) };
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(UInt6x4 other)
        {
            return this.Bits == other.Bits;
        }

        public override readonly bool Equals(object obj)
        {
            return obj is UInt6x4 converted && this.Equals(converted);
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
            return new ArrayEnumerator<UInt6x4, uint>(this);
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<UInt6x4, uint>(this);
        }
    }
}