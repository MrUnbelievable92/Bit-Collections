using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using MaxMath;
using SIMDAlgorithms;

using static MaxMath.maxmath;

namespace BitCollections
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, Size = 7)]
    unsafe public readonly struct Int56 : BitInt, IComparable, IComparable<Int56>, IConvertible, IEquatable<Int56>, IFormattable
    {
        public const long MinValue = -36028797018963968;
        public const long MaxValue = 36028797018963967;

        internal readonly byte byte0;
        internal readonly byte byte1;
        internal readonly byte byte2;
        internal readonly byte byte3;
        internal readonly byte byte4;
        internal readonly byte byte5;
        internal readonly byte byte6;

        public bool IsSigned => true;
        public byte Bits => 56;
        public byte MinFullyPackedBytes => 56 / 8;
        public long MinValueAsLong => MinValue;
        public long MaxValueAsLong => MaxValue;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static long ToFakeLong(Int56 x)
        {
            long lo = *(uint*)&x;
            lo |= ((long)(*(ushort*)&x.byte4)) << 32;
            lo |= (long)x.byte6 << 48;

            return lo;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long To_long(Int56* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (memoryAccess >= MemoryAccess.Allow8ByteRead)
            {
                return (*(long*)input << (64 - 56)) >> (64 - 56);
            }
            else
            {
                long lo = *(uint*)input;
                lo |= ((long)(*(ushort*)((byte*)input + 4))) << 32;
                // sign extension
                lo |= ((long)input->byte6 << 56) >> 8;

                return lo;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong To_ulong(Int56* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (ulong)To_long(input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 To_Int128(Int56* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (memoryAccess >= MemoryAccess.Allow8ByteRead)
            {
                long upshift = (*(long*)input << (64 - 56));
                return new Int128(upshift >> (64 - 56), upshift >> 63);
            }
            else
            {
                long lo = *(uint*)input;
                lo |= ((long)(*(ushort*)((byte*)input + 4))) << 32;
                // sign extension
                lo |= ((long)input->byte6 << 56) >> 8;
                long hi = ((long)input->byte6 << 56) >> 63;

                return new Int128(lo, hi);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 To_UInt128(Int56* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (UInt128)To_Int128(input, memoryAccess);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quarter To_quarter(Int56* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (quarter)(To_long(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half To_half(Int56* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (half)(To_long(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float To_float(Int56* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (float)(To_long(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double To_double(Int56* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (double)(To_long(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quadruple To_quadruple(Int56* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (quadruple)(To_long(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal To_decimal(Int56* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (decimal)(To_long(input, memoryAccess));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long2 To_long2(Int56* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new long2(To_long(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 To_long3(Int56* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new long3(To_long(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 To_long4(Int56* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new long4(To_long(input, memoryAccess));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long To_long(Int56 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_long(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong To_ulong(Int56 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_ulong(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 To_Int128(Int56 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_Int128(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 To_UInt128(Int56 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_UInt128(&input, memoryAccess);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quarter To_quarter(Int56 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_quarter(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half To_half(Int56 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_half(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float To_float(Int56 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_float(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double To_double(Int56 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_double(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quadruple To_quadruple(Int56 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_quadruple(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal To_decimal(Int56 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_decimal(&input, memoryAccess);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long2 To_long2(Int56 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_long2(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 To_long3(Int56 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_long3(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 To_long4(Int56 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_long4(&input, memoryAccess);
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte2(Int56 input)
        {
            return (byte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte3(Int56 input)
        {
            return (byte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte4(Int56 input)
        {
            return (byte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte8(Int56 input)
        {
            return (byte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte16(Int56 input)
        {
            return (byte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte32(Int56 input)
        {
            return (byte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort2(Int56 input)
        {
            return (ushort)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort3(Int56 input)
        {
            return (ushort)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort4(Int56 input)
        {
            return (ushort)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort8(Int56 input)
        {
            return (ushort)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort16(Int56 input)
        {
            return (ushort)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2(Int56 input)
        {
            return (uint)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3(Int56 input)
        {
            return (uint)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint4(Int56 input)
        {
            return (uint)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint8(Int56 input)
        {
            return (uint)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong2(Int56 input)
        {
            return (ulong2)To_long2(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong3(Int56 input)
        {
            return (ulong3)To_long3(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong4(Int56 input)
        {
            return (ulong4)To_long4(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte2(Int56 input)
        {
            return (sbyte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte3(Int56 input)
        {
            return (sbyte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte4(Int56 input)
        {
            return (sbyte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte8(Int56 input)
        {
            return (sbyte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte16(Int56 input)
        {
            return (sbyte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte32(Int56 input)
        {
            return (sbyte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short2(Int56 input)
        {
            return (short)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short3(Int56 input)
        {
            return (short)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short4(Int56 input)
        {
            return (short)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short8(Int56 input)
        {
            return (short)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short16(Int56 input)
        {
            return (short)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2(Int56 input)
        {
            return (int)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3(Int56 input)
        {
            return (int)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4(Int56 input)
        {
            return (int)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int8(Int56 input)
        {
            return (int)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long2(Int56 input)
        {
            return To_long2(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long3(Int56 input)
        {
            return To_long3(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long4(Int56 input)
        {
            return To_long4(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter2(Int56 input)
        {
            return (quarter)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter3(Int56 input)
        {
            return (quarter)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter4(Int56 input)
        {
            return (quarter)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter8(Int56 input)
        {
            return (quarter)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter16(Int56 input)
        {
            return (quarter)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter32(Int56 input)
        {
            return (quarter)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half2(Int56 input)
        {
            return (half)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half3(Int56 input)
        {
            return (half)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half4(Int56 input)
        {
            return (half)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half8(Int56 input)
        {
            return (half)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half16(Int56 input)
        {
            return (half)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2(Int56 input)
        {
            return To_float(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3(Int56 input)
        {
            return To_float(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float4(Int56 input)
        {
            return To_float(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float8(Int56 input)
        {
            return To_float(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2(Int56 input)
        {
            return To_double(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double3(Int56 input)
        {
            return To_double(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4(Int56 input)
        {
            return To_double(input);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int56(UInt56 input)
        {
            return *(Int56*)&input;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int56(sbyte input)
        {
            long cast = input;

            return *(Int56*)&cast;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int56(byte input)
        {
            long cast = input;

            return *(Int56*)&cast;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int56(short input)
        {
            long cast = input;

            return *(Int56*)&cast;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int56(ushort input)
        {
            ulong cast = input;

            return *(Int56*)&cast;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int56(Int24 input)
        {
            return Int24.To_Int56(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int56(UInt24 input)
        {
            return UInt24.To_Int56(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int56(int input)
        {
            long cast = input;

            return *(Int56*)&cast;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int56(uint input)
        {
            ulong cast = input;

            return *(Int56*)&cast;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int56(Int40 input)
        {
            return Int40.To_Int56(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int56(UInt40 input)
        {
            return UInt40.To_Int56(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int56(Int48 input)
        {
            return Int48.To_Int56(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int56(UInt48 input)
        {
            return UInt48.To_Int56(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int56(long input)
        {
            return *(Int56*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int56(ulong input)
        {
            return *(Int56*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int56(Int128 input)
        {
            return *(Int56*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int56(UInt128 input)
        {
            return *(Int56*)&input;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int56(quarter input)
        {
            return (Int56)((int)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int56(half input)
        {
            return (Int56)((int)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int56(float input)
        {
            return (Int56)((long)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int56(double input)
        {
            return (Int56)((long)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int56(quadruple input)
        {
            return (Int56)((long)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int56(decimal input)
        {
            return (Int56)((long)input);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte(Int56 input)
        {
            return (sbyte)input.byte0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte(Int56 input)
        {
            return input.byte0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short(Int56 input)
        {
            return *(short*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort(Int56 input)
        {
            return *(ushort*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int24(Int56 input)
        {
            return *(Int24*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt24(Int56 input)
        {
            return *(UInt24*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int(Int56 input)
        {
            return *(int*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint(Int56 input)
        {
            return *(uint*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int40(Int56 input)
        {
            return *(Int40*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt40(Int56 input)
        {
            return *(UInt40*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int48(Int56 input)
        {
            return *(Int48*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt48(Int56 input)
        {
            return *(UInt48*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long(Int56 input)
        {
            return To_long(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong(Int56 input)
        {
            return To_ulong(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int128(Int56 input)
        {
            return To_Int128(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt128(Int56 input)
        {
            return To_UInt128(input);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter(Int56 input)
        {
            return To_quarter(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half(Int56 input)
        {
            return To_half(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float(Int56 input)
        {
            return To_float(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double(Int56 input)
        {
            return To_double(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator quadruple(Int56 input)
        {
            return To_quadruple(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator decimal(Int56 input)
        {
            return To_decimal(input);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int56 operator - (Int56 value)
        {
            return -(ToFakeLong(value));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int56 operator ~ (Int56 value)
        {
            return ~(ToFakeLong(value));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int56 operator ++ (Int56 value)
        {
            long cast = ToFakeLong(value);

            return (Int56)(++cast);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int56 operator -- (Int56 value)
        {
            long cast = ToFakeLong(value);

            return (Int56)(--cast);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int56 operator + (Int56 left, Int56 right)
        {
            return ToFakeLong(left) + ToFakeLong(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator + (Int56 left, long right)
        {
            return (long)left + right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator + (long left, Int56 right)
        {
            return left + (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int56 operator - (Int56 left, Int56 right)
        {
            return ToFakeLong(left) - ToFakeLong(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator - (Int56 left, long right)
        {
            return (long)left - right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator - (long left, Int56 right)
        {
            return left - (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int56 operator * (Int56 left, Int56 right)
        {
            return ToFakeLong(left) * ToFakeLong(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator * (Int56 left, long right)
        {
            return (long)left * right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator * (long left, Int56 right)
        {
            return left * (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator / (Int56 left, Int56 right)
        {
            return (long)left / (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator / (Int56 left, long right)
        {
            return (long)left / right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator / (long left, Int56 right)
        {
            return left / (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator % (Int56 left, Int56 right)
        {
            return (long)left % (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator % (Int56 left, long right)
        {
            return (long)left % right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator % (long left, Int56 right)
        {
            return left % (long)right;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int56 operator & (Int56 left, Int56 right)
        {
            return ToFakeLong(left) & ToFakeLong(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator & (Int56 left, long right)
        {
            return (long)left & right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator & (long left, Int56 right)
        {
            return left & (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int56 operator | (Int56 left, Int56 right)
        {
            return ToFakeLong(left) | ToFakeLong(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator | (Int56 left, long right)
        {
            return (long)left | right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator | (long left, Int56 right)
        {
            return left | (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int56 operator ^ (Int56 left, Int56 right)
        {
            return ToFakeLong(left) ^ ToFakeLong(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator ^ (Int56 left, long right)
        {
            return (long)left ^ right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator ^ (long left, Int56 right)
        {
            return left ^ (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int56 operator << (Int56 left, int right)
        {
            return ToFakeLong(left) << right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator >> (Int56 left, int right)
        {
            return (long)left >> right;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator == (Int56 left, Int56 right)
        {
            return ToFakeLong(left) == ToFakeLong(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator == (Int56 left, int right)
        {
            return (long)left == right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator == (int left, Int56 right)
        {
            return left == (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator == (Int56 left, long right)
        {
            return (long)left == right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator == (long left, Int56 right)
        {
            return left == (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator != (Int56 left, Int56 right)
        {
            return ToFakeLong(left) != ToFakeLong(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator != (Int56 left, int right)
        {
            return (long)left != right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator != (int left, Int56 right)
        {
            return left != (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator != (Int56 left, long right)
        {
            return (long)left != right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator != (long left, Int56 right)
        {
            return left != (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator < (Int56 left, Int56 right)
        {
            return (long)left < (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator < (Int56 left, int right)
        {
            return (long)left < right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator < (int left, Int56 right)
        {
            return left < (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator < (Int56 left, long right)
        {
            return (long)left < right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator < (long left, Int56 right)
        {
            return left < (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator > (Int56 left, Int56 right)
        {
            return (long)left > (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator > (Int56 left, int right)
        {
            return (long)left > right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator > (int left, Int56 right)
        {
            return left > (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator > (Int56 left, long right)
        {
            return (long)left > right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator > (long left, Int56 right)
        {
            return left > (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <= (Int56 left, Int56 right)
        {
            return (long)left <= (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <= (Int56 left, int right)
        {
            return (long)left <= right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <= (int left, Int56 right)
        {
            return left <= (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <= (Int56 left, long right)
        {
            return (long)left <= right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <= (long left, Int56 right)
        {
            return left <= (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >= (Int56 left, Int56 right)
        {
            return (long)left >= (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >= (Int56 left, int right)
        {
            return (long)left >= right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >= (int left, Int56 right)
        {
            return left >= (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >= (Int56 left, long right)
        {
            return (long)left >= right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >= (long left, Int56 right)
        {
            return left >= (long)right;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
            return ((long)this).GetHashCode();
        }
        public readonly TypeCode GetTypeCode()
        {
            return TypeCode.Int64;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Int56 other)
        {
            return this == other;
        }
        public override readonly bool Equals(object obj)
        {
            return obj is Int56 converted && this.Equals(converted);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int CompareTo(Int56 other)
        {
            return compareto((long)this, (long)other);
        }
        public readonly int CompareTo(object obj)
        {
            return CompareTo((Int56)obj);
        }


        public static Int56 Parse(string s)
        {
            return (Int56)long.Parse(s);
        }
        public static Int56 Parse(string s, NumberStyles style)
        {
            return (Int56)long.Parse(s, style);
        }
        public static Int56 Parse(string s, IFormatProvider provider)
        {
            return (Int56)long.Parse(s, provider);
        }
        public static Int56 Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            return (Int56)long.Parse(s, style, provider);
        }
        public static bool TryParse(string s, out Int56 result)
        {
            bool success = long.TryParse(s, out long Int);

            result = (Int56)Int;

            return success & isinrange(Int, MinValue, MaxValue);
        }
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out Int56 result)
        {
            bool success = long.TryParse(s, style, provider, out long Int);

            result = (Int56)Int;

            return success & isinrange(Int, MinValue, MaxValue);
        }

        public override readonly string ToString()
        {
            return ((long)this).ToString();
        }
        public readonly string ToString(string format)
        {
            return ((long)this).ToString(format);
        }
        public readonly string ToString(IFormatProvider provider)
        {
            return ((long)this).ToString(provider);
        }
        public readonly string ToString(string format, IFormatProvider provider)
        {
            return ((long)this).ToString(format, provider);
        }

        public readonly bool ToBoolean(IFormatProvider provider)
        {
            return Convert.ToBoolean((long)this, provider);
        }
        public readonly byte ToByte(IFormatProvider provider)
        {
            return Convert.ToByte((byte)this, provider);
        }
        public readonly char ToChar(IFormatProvider provider)
        {
            return Convert.ToChar((long)this, provider);
        }
        public readonly DateTime ToDateTime(IFormatProvider provider)
        {
            return Convert.ToDateTime((long)this, provider);
        }
        public readonly decimal ToDecimal(IFormatProvider provider)
        {
            return Convert.ToDecimal((long)this, provider);
        }
        public readonly double ToDouble(IFormatProvider provider)
        {
            return Convert.ToDouble((long)this, provider);
        }
        public readonly short ToInt16(IFormatProvider provider)
        {
            return Convert.ToInt16((short)this, provider);
        }
        public readonly int ToInt32(IFormatProvider provider)
        {
            return Convert.ToInt32((int)this, provider);
        }
        public readonly long ToInt64(IFormatProvider provider)
        {
            return Convert.ToInt64((long)this, provider);
        }
        public readonly sbyte ToSByte(IFormatProvider provider)
        {
            return Convert.ToSByte((sbyte)this, provider);
        }
        public readonly float ToSingle(IFormatProvider provider)
        {
            return Convert.ToSingle((long)this, provider);
        }
        public readonly object ToType(Type conversionType, IFormatProvider provider)
        {
            return Convert.ChangeType((long)this, conversionType, provider);
        }
        public readonly ushort ToUInt16(IFormatProvider provider)
        {
            return Convert.ToUInt16((ushort)this, provider);
        }
        public readonly uint ToUInt32(IFormatProvider provider)
        {
            return Convert.ToUInt32((uint)this, provider);
        }
        public readonly ulong ToUInt64(IFormatProvider provider)
        {
            return Convert.ToUInt64((long)this, provider);
        }
    }
}