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

namespace BitCollections
{
    [Serializable]
    unsafe public struct UInt12x4 : IArray<uint>, IEquatable<UInt12x4>
    {
        public UInt48 Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt12x4(ushort x, ushort y, ushort z, ushort w)
        {
Assert.IsNotGreater(x, UInt12.MaxValue);
Assert.IsNotGreater(y, UInt12.MaxValue);
Assert.IsNotGreater(z, UInt12.MaxValue);
//Assert.IsNotGreater(w, UInt12.MaxValue);

            Bits = ((ulong)x << (0 * default(UInt12).Bits))
                  | ((ulong)y << (1 * default(UInt12).Bits))
                  | ((ulong)z << (2 * default(UInt12).Bits))
                  | ((ulong)w << (3 * default(UInt12).Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt12x4(ushort xyzw)
        {
            Bits = SWAR.Broadcast64<UInt12>(xyzw);
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
        public static implicit operator UInt14x4(UInt12x4 input) => new UInt14x4 { Bits = (UInt56)PackUnpack.UpCast64<UInt12, UInt14>(input.Bits) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt12x4(UInt14x4 input) => new UInt12x4 { Bits = (UInt48)PackUnpack.DownCast<UInt14, UInt12>(input.Bits) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte4(UInt12x4 input) => PackUnpack.DownCast<UInt12, UInt8>(input.Bits).GetField<ulong, byte4>(0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ushort4(UInt12x4 input) => PackUnpack.BitIntArrayToUShort4<UInt12>(input.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint4(UInt12x4 input) => PackUnpack.BitIntArrayToUInt4<UInt12>(input.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong4(UInt12x4 input) => PackUnpack.BitIntArrayToULong4<UInt12>(input.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte4(UInt12x4 input) => (sbyte4)(byte4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator short4(UInt12x4 input) => (short4)(ushort4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int4(UInt12x4 input) => (int4)(uint4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long4(UInt12x4 input) => (long4)(ulong4)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt12x4(byte4 input) => new UInt12x4 { Bits = (UInt48)PackUnpack.UpCast64<UInt8, UInt12>(input.Reinterpret<byte4, uint>()) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt12x4(ushort4 input) => new UInt12x4 { Bits = (UInt48)PackUnpack.DownCast<UInt12>(input) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt12x4(uint4 input) => new UInt12x4 { Bits = (UInt48)PackUnpack.DownCast<UInt12>(input) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt12x4(ulong4 input) => new UInt12x4 { Bits = (UInt48)PackUnpack.DownCast<UInt12>(input) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt12x4(sbyte4 input) => (UInt12x4)(byte4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt12x4(short4 input) => (UInt12x4)(ushort4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt12x4(int4 input) => (UInt12x4)(uint4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt12x4(long4 input) => (UInt12x4)(ulong4)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter4(UInt12x4 input) => (quarter4)(byte4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator half4(UInt12x4 input) => (half4)(ushort4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float4(UInt12x4 input) => (float4)(int4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4(UInt12x4 input) => (double4)(int4)input;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt12x4(quarter4 input) => (UInt12x4)(byte4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt12x4(half4 input) => (UInt12x4)(ushort4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt12x4(float4 input) => (UInt12x4)(int4)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt12x4(double4 input) => (UInt12x4)(int4)input;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator ++ (UInt12x4 value) => value + 1;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator -- (UInt12x4 value) => value - 1;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator + (UInt12x4 left, UInt12x4 right) => new UInt12x4 { Bits = SWAR.Add<UInt12>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator + (UInt12x4 left, uint right) => left + new UInt12x4((ushort)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator + (uint left, UInt12x4 right) => right + left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator - (UInt12x4 left, UInt12x4 right) => new UInt12x4 { Bits = SWAR.Sub<UInt12>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator - (UInt12x4 left, uint right) => left - new UInt12x4((ushort)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator - (uint left, UInt12x4 right) => new UInt12x4((ushort)left) - right;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator * (UInt12x4 left, UInt12x4 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt12x4)((ushort4)left * right);
            }

            ulong x0 = left.Bits & bitmask64((ulong)default(UInt12).Bits, 0ul * (ulong)default(UInt12).Bits);
            ulong x1 = left.Bits & bitmask64((ulong)default(UInt12).Bits, 1ul * (ulong)default(UInt12).Bits);
            ulong x2 = left.Bits & bitmask64((ulong)default(UInt12).Bits, 2ul * (ulong)default(UInt12).Bits);
            ulong x3 = left.Bits & bitmask64((ulong)default(UInt12).Bits, 3ul * (ulong)default(UInt12).Bits);
            
            x0 *= right[0];
            x1 *= right[1];
            x2 *= right[2];
            x3 *= right[3];
            
            ulong lo = bits_select(x1, x0, bitmask64((ulong)default(UInt12).Bits));
            ulong hi = bits_select(x3, x2, bitmask64((ulong)default(UInt12).Bits, 2ul * (ulong)default(UInt12).Bits));
            
            return new UInt12x4 { Bits = bits_select(hi, lo, bitmask64(2ul * (ulong)default(UInt12).Bits)) };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator * (UInt12x4 left, uint right)
        {
            if (SWAR.ConstMul<UInt12>(left.Bits, right, out ulong constMul))
            {
                return new UInt12x4 { Bits = constMul };
            }
        
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt12x4)((ushort4)left * (ushort)right);
            }

            ulong x0 = left.Bits & bitmask64((ulong)default(UInt12).Bits, 0ul * (ulong)default(UInt12).Bits);
            ulong x1 = left.Bits & bitmask64((ulong)default(UInt12).Bits, 1ul * (ulong)default(UInt12).Bits);
            ulong x2 = left.Bits & bitmask64((ulong)default(UInt12).Bits, 2ul * (ulong)default(UInt12).Bits);
            ulong x3 = left.Bits & bitmask64((ulong)default(UInt12).Bits, 3ul * (ulong)default(UInt12).Bits);
            
            x0 *= right;
            x1 *= right;
            x2 *= right;
            x3 *= right;

            ulong lo = bits_select(x1, x0, bitmask64((ulong)default(UInt12).Bits));
            ulong hi = bits_select(x3, x2, bitmask64((ulong)default(UInt12).Bits, 2ul * (ulong)default(UInt12).Bits));

            return new UInt12x4 { Bits = bits_select(hi, lo, bitmask64(2ul * (ulong)default(UInt12).Bits)) };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator * (uint left, UInt12x4 right) => right * left;
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator / (UInt12x4 left, UInt12x4 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt12x4)((ushort4)left / right);
            }
            else
            {
                ulong x0 = left.Bits & bitmask64((ulong)default(UInt12).Bits, 0ul * (ulong)default(UInt12).Bits);
                ulong x1 = left.Bits & bitmask64((ulong)default(UInt12).Bits, 1ul * (ulong)default(UInt12).Bits);
                ulong x2 = left.Bits & bitmask64((ulong)default(UInt12).Bits, 2ul * (ulong)default(UInt12).Bits);
                ulong x3 = left.Bits & bitmask64((ulong)default(UInt12).Bits, 3ul * (ulong)default(UInt12).Bits);
                
                x0 /= right[0];
                x1 /= right[1];
                x2 /= right[2];
                x3 /= right[3];

                ulong lo = bits_select(x1, x0, bitmask64((ulong)default(UInt12).Bits));
                ulong hi = bits_select(x3, x2, bitmask64((ulong)default(UInt12).Bits, 2ul * (ulong)default(UInt12).Bits));

                return new UInt12x4 { Bits = bits_select(hi, lo, bitmask64(2ul * (ulong)default(UInt12).Bits)) };
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator / (UInt12x4 left, uint right)
        {
            if (SWAR.ConstDiv<UInt12>(left.Bits, (long)right, out ulong constDiv))
            {
                return new UInt12x4 { Bits = constDiv };
            }
        
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt12x4)((ushort4)left / (ushort)right);
            }
            else
            {
                ulong x0 = left.Bits & bitmask64((ulong)default(UInt12).Bits, 0ul * (ulong)default(UInt12).Bits);
                ulong x1 = left.Bits & bitmask64((ulong)default(UInt12).Bits, 1ul * (ulong)default(UInt12).Bits);
                ulong x2 = left.Bits & bitmask64((ulong)default(UInt12).Bits, 2ul * (ulong)default(UInt12).Bits);
                ulong x3 = left.Bits & bitmask64((ulong)default(UInt12).Bits, 3ul * (ulong)default(UInt12).Bits);
        
                x0 /= right;
                x1 /= right;
                x2 /= right;
                x3 /= right;

                ulong lo = bits_select(x1, x0, bitmask64((ulong)default(UInt12).Bits));
                ulong hi = bits_select(x3, x2, bitmask64((ulong)default(UInt12).Bits, 2ul * (ulong)default(UInt12).Bits));

                return new UInt12x4 { Bits = bits_select(hi, lo, bitmask64(2ul * (ulong)default(UInt12).Bits)) };
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator / (uint left, UInt12x4 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt12x4)((ushort)left / (ushort4)right);
            }
            else
            {
                ulong x0 = (ulong)left << (0 * default(UInt12).Bits);
                ulong x1 = (ulong)left << (1 * default(UInt12).Bits);
                ulong x2 = (ulong)left << (2 * default(UInt12).Bits);
                ulong x3 = (ulong)left << (3 * default(UInt12).Bits);
        
                x0 /= right[0];
                x1 /= right[1];
                x2 /= right[2];
                x3 /= right[3];

                ulong lo = bits_select(x1, x0, bitmask64((ulong)default(UInt12).Bits));
                ulong hi = bits_select(x3, x2, bitmask64((ulong)default(UInt12).Bits, 2ul * (ulong)default(UInt12).Bits));

                return new UInt12x4 { Bits = bits_select(hi, lo, bitmask64(2ul * (ulong)default(UInt12).Bits)) };
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator % (UInt12x4 left, UInt12x4 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt12x4)((ushort4)left % right);
            }
            else
            {
                return new UInt12x4((ushort)(left[0] % right[0]),
                                    (ushort)(left[1] % right[1]),
                                    (ushort)(left[2] % right[2]),
                                    (ushort)(left[3] % right[3]));
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator % (UInt12x4 left, uint right)
        {
            if (SWAR.ConstRem<UInt12>(left.Bits, (long)right, out ulong constRem))
            {
                return new UInt12x4 { Bits = constRem };
            }
        
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt12x4)((ushort4)left % (ushort)right);
            }
            else
            {
                return new UInt12x4((ushort)(left[0] % right),
                                    (ushort)(left[1] % right),
                                    (ushort)(left[2] % right),
                                    (ushort)(left[3] % right));
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator % (uint left, UInt12x4 right)
        {
            if (BurstArchitecture.IsSIMDSupported)
            {
                return (UInt12x4)((ushort)left % (ushort4)right);
            }
            else
            {
                return new UInt12x4((ushort)(left % right[0]),
                                    (ushort)(left % right[1]),
                                    (ushort)(left % right[2]),
                                    (ushort)(left % right[3]));
            }
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator << (UInt12x4 left, int right) => new UInt12x4 { Bits = SWAR.ShiftLeftLogical<UInt12>(left.Bits, right) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator >> (UInt12x4 left, int right) => new UInt12x4 { Bits = SWAR.ShiftRightLogical<UInt12>(left.Bits, right) };


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator ~ (UInt12x4 value) => new UInt12x4{ Bits = ~value.Bits };
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator ^ (UInt12x4 left, UInt12x4 right) => new UInt12x4{ Bits = left.Bits ^ right.Bits };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator ^ (UInt12x4 left, uint right) => left ^ new UInt12x4((ushort)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator ^ (uint left, UInt12x4 right) => right ^ left;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator & (UInt12x4 left, UInt12x4 right) => new UInt12x4{ Bits = left.Bits & right.Bits };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator & (UInt12x4 left, uint right) => left & new UInt12x4((ushort)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator & (uint left, UInt12x4 right) => right & left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator | (UInt12x4 left, UInt12x4 right) => new UInt12x4{ Bits = left.Bits | right.Bits };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator | (UInt12x4 left, uint right) => left | new UInt12x4((ushort)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator | (uint left, UInt12x4 right) => right | left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator == (UInt12x4 left, UInt12x4 right) => new UInt12x4 { Bits = SWAR.Equals<UInt12>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator == (UInt12x4 left, uint right) => left == new UInt12x4((ushort)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator == (uint left, UInt12x4 right) => right == left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator != (UInt12x4 left, UInt12x4 right) => new UInt12x4 { Bits = SWAR.NotEquals<UInt12>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator != (UInt12x4 left, uint right) => left != new UInt12x4((ushort)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator != (uint left, UInt12x4 right) => right != left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator < (UInt12x4 left, UInt12x4 right) => new UInt12x4 { Bits = SWAR.LessThan<UInt12>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator < (UInt12x4 left, uint right) => left < new UInt12x4((ushort)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator < (uint left, UInt12x4 right) => right > left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator > (UInt12x4 left, UInt12x4 right) => new UInt12x4 { Bits = SWAR.GreaterThan<UInt12>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator > (UInt12x4 left, uint right) => left > new UInt12x4((ushort)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator > (uint left, UInt12x4 right) => right < left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator <= (UInt12x4 left, UInt12x4 right) => new UInt12x4 { Bits = SWAR.LessThanOrEqual<UInt12>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator <= (UInt12x4 left, uint right) => left <= new UInt12x4((ushort)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator <= (uint left, UInt12x4 right) => right >= left;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator >= (UInt12x4 left, UInt12x4 right) => new UInt12x4 { Bits = SWAR.GreaterThanOrEqual<UInt12>(left.Bits, right.Bits) };
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator >= (UInt12x4 left, uint right) => left >= new UInt12x4((ushort)right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt12x4 operator >= (uint left, UInt12x4 right) => right <= left;


        public uint this[int index]
        {
            [return: AssumeRange((ulong)UInt12.MinValue, (ulong)UInt12.MaxValue)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (uint)BitFieldHelper.Get<UInt12>(Bits, default(UInt12).Bits * index, default(UInt12).Bits * Length);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Bits = BitFieldHelper.Set<UInt12>(Bits, (int)value, default(UInt12).Bits * index, default(UInt12).Bits * Length);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly UInt12x4 SetReplicate(int index, int numNumbers, uint value)
        {
            return new UInt12x4 { Bits = BitFieldHelper.SetReplicate<UInt12>(Bits, (int)value, numNumbers, default(UInt12).Bits * index, default(UInt12).Bits * Length) };
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(UInt12x4 other)
        {
            return this.Bits == other.Bits;
        }

        public override readonly bool Equals(object obj)
        {
            return obj is UInt12x4 converted && this.Equals(converted);
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
            return new ArrayEnumerator<UInt12x4, uint>(this);
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<UInt12x4, uint>(this);
        }
    }
}