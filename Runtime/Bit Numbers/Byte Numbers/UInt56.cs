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
    unsafe public readonly struct UInt56 : BitInt, IComparable, IComparable<UInt56>, IConvertible, IEquatable<UInt56>, IFormattable
    {
        public const ulong MinValue = 0;
        public const ulong MaxValue = 72057594037927935;

        internal readonly byte byte0;
        internal readonly byte byte1;
        internal readonly byte byte2;
        internal readonly byte byte3;
        internal readonly byte byte4;
        internal readonly byte byte5;
        internal readonly byte byte6;

        public bool IsSigned => false;
        public byte Bits => 56;
        public byte MinFullyPackedBytes => 56 / 8;
        public long MinValueAsLong => (long)MinValue;
        public long MaxValueAsLong => (long)MaxValue;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long To_long(UInt56* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (long)To_ulong(input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong To_ulong(UInt56* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (memoryAccess >= MemoryAccess.Allow8ByteRead)
            {
                return *(ulong*)input & bitmask64(56ul);
            }
            else
            {
                ulong lo = *(uint*)input;
                lo |= ((ulong)(*(ushort*)((byte*)input + 4))) << 32;
                lo |= (ulong)input->byte6 << 48;

                return lo;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 To_Int128(UInt56* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (Int128)To_UInt128(input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 To_UInt128(UInt56* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (UInt128)To_ulong(input, memoryAccess);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quarter To_quarter(UInt56* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (quarter)(To_long(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half To_half(UInt56* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (half)(To_long(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float To_float(UInt56* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (float)(To_long(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double To_double(UInt56* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (double)(To_long(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quadruple To_quadruple(UInt56* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (quadruple)(To_long(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal To_decimal(UInt56* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (decimal)(To_long(input, memoryAccess));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 To_ulong2(UInt56* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new ulong2(To_ulong(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 To_ulong3(UInt56* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new ulong3(To_ulong(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 To_ulong4(UInt56* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new ulong4(To_ulong(input, memoryAccess));
        }
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long To_long(UInt56 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_long(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong To_ulong(UInt56 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_ulong(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 To_Int128(UInt56 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_Int128(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 To_UInt128(UInt56 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_UInt128(&input, memoryAccess);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quarter To_quarter(UInt56 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_quarter(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half To_half(UInt56 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_half(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float To_float(UInt56 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_float(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double To_double(UInt56 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_double(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quadruple To_quadruple(UInt56 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_quadruple(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal To_decimal(UInt56 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_decimal(&input, memoryAccess);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 To_ulong2(UInt56 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_ulong2(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 To_ulong3(UInt56 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_ulong3(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 To_ulong4(UInt56 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_ulong4(&input, memoryAccess);
        }
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte2(UInt56 input)
        {
            return (byte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte3(UInt56 input)
        {
            return (byte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte4(UInt56 input)
        {
            return (byte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte8(UInt56 input)
        {
            return (byte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte16(UInt56 input)
        {
            return (byte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte32(UInt56 input)
        {
            return (byte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort2(UInt56 input)
        {
            return (ushort)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort3(UInt56 input)
        {
            return (ushort)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort4(UInt56 input)
        {
            return (ushort)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort8(UInt56 input)
        {
            return (ushort)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort16(UInt56 input)
        {
            return (ushort)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2(UInt56 input)
        {
            return (uint)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3(UInt56 input)
        {
            return (uint)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint4(UInt56 input)
        {
            return (uint)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint8(UInt56 input)
        {
            return (uint)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong2(UInt56 input)
        {
            return To_ulong2(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong3(UInt56 input)
        {
            return To_ulong3(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong4(UInt56 input)
        {
            return To_ulong4(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte2(UInt56 input)
        {
            return (sbyte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte3(UInt56 input)
        {
            return (sbyte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte4(UInt56 input)
        {
            return (sbyte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte8(UInt56 input)
        {
            return (sbyte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte16(UInt56 input)
        {
            return (sbyte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte32(UInt56 input)
        {
            return (sbyte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short2(UInt56 input)
        {
            return (short)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short3(UInt56 input)
        {
            return (short)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short4(UInt56 input)
        {
            return (short)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short8(UInt56 input)
        {
            return (short)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short16(UInt56 input)
        {
            return (short)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2(UInt56 input)
        {
            return (int)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3(UInt56 input)
        {
            return (int)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4(UInt56 input)
        {
            return (int)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int8(UInt56 input)
        {
            return (int)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long2(UInt56 input)
        {
            return (long2)To_ulong2(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long3(UInt56 input)
        {
            return (long3)To_ulong3(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long4(UInt56 input)
        {
            return (long4)To_ulong4(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter2(UInt56 input)
        {
            return (quarter)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter3(UInt56 input)
        {
            return (quarter)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter4(UInt56 input)
        {
            return (quarter)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter8(UInt56 input)
        {
            return (quarter)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter16(UInt56 input)
        {
            return (quarter)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter32(UInt56 input)
        {
            return (quarter)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half2(UInt56 input)
        {
            return (half)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half3(UInt56 input)
        {
            return (half)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half4(UInt56 input)
        {
            return (half)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half8(UInt56 input)
        {
            return (half)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half16(UInt56 input)
        {
            return (half)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2(UInt56 input)
        {
            return To_float(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3(UInt56 input)
        {
            return To_float(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float4(UInt56 input)
        {
            return To_float(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float8(UInt56 input)
        {
            return To_float(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2(UInt56 input)
        {
            return To_double(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double3(UInt56 input)
        {
            return To_double(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4(UInt56 input)
        {
            return To_double(input);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt56(Int56 input)
        {
            return *(UInt56*)&input;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt56(sbyte input)
        {
            ulong cast = (ulong)input;

            return *(UInt56*)&cast;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt56(byte input)
        {
            ulong cast = input;

            return *(UInt56*)&cast;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt56(short input)
        {
            ulong cast = (ulong)input;

            return *(UInt56*)&cast;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt56(ushort input)
        {
            ulong cast = input;

            return *(UInt56*)&cast;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt56(Int24 input)
        {
            return Int24.To_UInt56(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt56(UInt24 input)
        {
            return UInt24.To_UInt56(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt56(int input)
        {
            ulong cast = (ulong)input;

            return *(UInt56*)&cast;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt56(uint input)
        {
            ulong cast = input;

            return *(UInt56*)&cast;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt56(Int40 input)
        {
            return Int40.To_UInt56(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt56(UInt40 input)
        {
            return UInt40.To_UInt56(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt56(Int48 input)
        {
            return Int48.To_UInt56(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt56(UInt48 input)
        {
            return UInt48.To_UInt56(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt56(long input)
        {
            return *(UInt56*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt56(ulong input)
        {
            return *(UInt56*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt56(Int128 input)
        {
            return *(UInt56*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt56(UInt128 input)
        {
            return *(UInt56*)&input;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt56(quarter input)
        {
            return (UInt56)((uint)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt56(half input)
        {
            return (UInt56)((uint)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt56(float input)
        {
            return (UInt56)((ulong)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt56(double input)
        {
            return (UInt56)((ulong)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt56(quadruple input)
        {
            return (UInt56)((ulong)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt56(decimal input)
        {
            return (UInt56)((ulong)input);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte(UInt56 input)
        {
            return (sbyte)input.byte0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte(UInt56 input)
        {
            return input.byte0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short(UInt56 input)
        {
            return *(short*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort(UInt56 input)
        {
            return *(ushort*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int24(UInt56 input)
        {
            return *(Int24*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt24(UInt56 input)
        {
            return *(UInt24*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int(UInt56 input)
        {
            return *(int*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint(UInt56 input)
        {
            return *(uint*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int40(UInt56 input)
        {
            return *(Int40*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt40(UInt56 input)
        {
            return *(UInt40*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int48(UInt56 input)
        {
            return *(Int48*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt48(UInt56 input)
        {
            return *(UInt48*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long(UInt56 input)
        {
            return To_long(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong(UInt56 input)
        {
            return To_ulong(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int128(UInt56 input)
        {
            return To_Int128(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt128(UInt56 input)
        {
            return To_UInt128(input);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter(UInt56 input)
        {
            return To_quarter(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half(UInt56 input)
        {
            return To_half(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float(UInt56 input)
        {
            return To_float(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double(UInt56 input)
        {
            return To_double(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator quadruple(UInt56 input)
        {
            return To_quadruple(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator decimal(UInt56 input)
        {
            return To_decimal(input);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator ~ (UInt56 value)
        {
            return ~((ulong)value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator ++ (UInt56 value)
        {
            ulong cast = (ulong)value;

            return (UInt56)(++cast);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator -- (UInt56 value)
        {
            ulong cast = (ulong)value;

            return (UInt56)(--cast);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator + (UInt56 left, UInt56 right)
        {
            return (ulong)left + (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator + (uint left, UInt56 right)
        {
            return left + (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator + (UInt56 left, uint right)
        {
            return (ulong)left + right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator + (UInt56 left, ulong right)
        {
            return (ulong)left + right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator + (ulong left, UInt56 right)
        {
            return left + (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator - (UInt56 left, UInt56 right)
        {
            return (ulong)left - (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator - (UInt56 left, uint right)
        {
            return (ulong)left - right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator - (uint left, UInt56 right)
        {
            return left - (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator - (UInt56 left, ulong right)
        {
            return (ulong)left - right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator - (ulong left, UInt56 right)
        {
            return left - (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator * (UInt56 left, UInt56 right)
        {
            return (ulong)left * (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator * (UInt56 left, uint right)
        {
            return (ulong)left * right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator * (uint left, UInt56 right)
        {
            return left * (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator * (UInt56 left, ulong right)
        {
            return (ulong)left * right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator * (ulong left, UInt56 right)
        {
            return left * (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator / (UInt56 left, UInt56 right)
        {
            return (ulong)left / (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator / (UInt56 left, uint right)
        {
            return (ulong)left / right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator / (uint left, UInt56 right)
        {
            return left / (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator / (UInt56 left, ulong right)
        {
            return (ulong)left / right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator / (ulong left, UInt56 right)
        {
            return left / (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator % (UInt56 left, UInt56 right)
        {
            return (ulong)left % (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator % (UInt56 left, uint right)
        {
            return (ulong)left % right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator % (uint left, UInt56 right)
        {
            return left % (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator % (UInt56 left, ulong right)
        {
            return (ulong)left % right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator % (ulong left, UInt56 right)
        {
            return left % (ulong)right;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator & (UInt56 left, UInt56 right)
        {
            return (ulong)left & (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator & (UInt56 left, uint right)
        {
            return (ulong)left & right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator & (uint left, UInt56 right)
        {
            return left & (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator & (UInt56 left, ulong right)
        {
            return (ulong)left & right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator & (ulong left, UInt56 right)
        {
            return left & (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator | (UInt56 left, UInt56 right)
        {
            return (ulong)left | (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator | (UInt56 left, uint right)
        {
            return (ulong)left | right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator | (uint left, UInt56 right)
        {
            return left | (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator | (UInt56 left, ulong right)
        {
            return (ulong)left | right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator | (ulong left, UInt56 right)
        {
            return left | (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator ^ (UInt56 left, UInt56 right)
        {
            return (ulong)left ^ (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator ^ (UInt56 left, uint right)
        {
            return (ulong)left ^ right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator ^ (uint left, UInt56 right)
        {
            return left ^ (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator ^ (UInt56 left, ulong right)
        {
            return (ulong)left ^ right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator ^ (ulong left, UInt56 right)
        {
            return left ^ (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator << (UInt56 left, int right)
        {
            return (ulong)left << right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator >> (UInt56 left, int right)
        {
            return (ulong)left >> right;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator == (UInt56 left, UInt56 right)
        {
            return (ulong)left == (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator == (UInt56 left, uint right)
        {
            return (ulong)left == right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator == (uint left, UInt56 right)
        {
            return left == (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator == (UInt56 left, ulong right)
        {
            return (ulong)left == right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator == (ulong left, UInt56 right)
        {
            return left == (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator != (UInt56 left, UInt56 right)
        {
            return (ulong)left != (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator != (UInt56 left, uint right)
        {
            return (ulong)left != right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator != (uint left, UInt56 right)
        {
            return left != (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator != (UInt56 left, ulong right)
        {
            return (ulong)left != right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator != (ulong left, UInt56 right)
        {
            return left != (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator < (UInt56 left, UInt56 right)
        {
            return (ulong)left < (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator < (UInt56 left, uint right)
        {
            return (ulong)left < right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator < (uint left, UInt56 right)
        {
            return left < (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator < (UInt56 left, ulong right)
        {
            return (ulong)left < right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator < (ulong left, UInt56 right)
        {
            return left < (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator > (UInt56 left, UInt56 right)
        {
            return (ulong)left > (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator > (UInt56 left, uint right)
        {
            return (ulong)left > right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator > (uint left, UInt56 right)
        {
            return left > (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator > (UInt56 left, ulong right)
        {
            return (ulong)left > right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator > (ulong left, UInt56 right)
        {
            return left > (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <= (UInt56 left, UInt56 right)
        {
            return (ulong)left <= (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <= (UInt56 left, uint right)
        {
            return (ulong)left <= right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <= (uint left, UInt56 right)
        {
            return left <= (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <= (UInt56 left, ulong right)
        {
            return (ulong)left <= right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <= (ulong left, UInt56 right)
        {
            return left <= (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >= (UInt56 left, UInt56 right)
        {
            return (ulong)left >= (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >= (UInt56 left, uint right)
        {
            return (ulong)left >= right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >= (uint left, UInt56 right)
        {
            return left >= (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >= (UInt56 left, ulong right)
        {
            return (ulong)left >= right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >= (ulong left, UInt56 right)
        {
            return left >= (ulong)right;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
            return ((ulong)this).GetHashCode();
        }
        public readonly TypeCode GetTypeCode()
        {
            return TypeCode.UInt64;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(UInt56 other)
        {
            return this == other;
        }
        public override readonly bool Equals(object obj)
        {
            return obj is UInt56 converted && this.Equals(converted);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int CompareTo(UInt56 other)
        {
            return compareto((ulong)this, (ulong)other);
        }
        public readonly int CompareTo(object obj)
        {
            return CompareTo((UInt56)obj);
        }


        public static UInt56 Parse(string s)
        {
            return (UInt56)ulong.Parse(s);
        }
        public static UInt56 Parse(string s, NumberStyles style)
        {
            return (UInt56)ulong.Parse(s, style);
        }
        public static UInt56 Parse(string s, IFormatProvider provider)
        {
            return (UInt56)ulong.Parse(s, provider);
        }
        public static UInt56 Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            return (UInt56)ulong.Parse(s, style, provider);
        }
        public static bool TryParse(string s, out UInt56 result)
        {
            bool success = ulong.TryParse(s, out ulong Int);

            result = (UInt56)Int;

            return success & (Int <= MaxValue);
        }
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out UInt56 result)
        {
            bool success = ulong.TryParse(s, style, provider, out ulong Int);

            result = (UInt56)Int;

            return success & (Int <= MaxValue);
        }

        public override readonly string ToString()
        {
            return ((ulong)this).ToString();
        }
        public readonly string ToString(string format)
        {
            return ((ulong)this).ToString(format);
        }
        public readonly string ToString(IFormatProvider provider)
        {
            return ((ulong)this).ToString(provider);
        }
        public readonly string ToString(string format, IFormatProvider provider)
        {
            return ((ulong)this).ToString(format, provider);
        }

        public readonly bool ToBoolean(IFormatProvider provider)
        {
            return Convert.ToBoolean((ulong)this, provider);
        }
        public readonly byte ToByte(IFormatProvider provider)
        {
            return Convert.ToByte((byte)this, provider);
        }
        public readonly char ToChar(IFormatProvider provider)
        {
            return Convert.ToChar((ulong)this, provider);
        }
        public readonly DateTime ToDateTime(IFormatProvider provider)
        {
            return Convert.ToDateTime((ulong)this, provider);
        }
        public readonly decimal ToDecimal(IFormatProvider provider)
        {
            return Convert.ToDecimal((ulong)this, provider);
        }
        public readonly double ToDouble(IFormatProvider provider)
        {
            return Convert.ToDouble((ulong)this, provider);
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
            return Convert.ToInt64((ulong)this, provider);
        }
        public readonly sbyte ToSByte(IFormatProvider provider)
        {
            return Convert.ToSByte((sbyte)this, provider);
        }
        public readonly float ToSingle(IFormatProvider provider)
        {
            return Convert.ToSingle((ulong)this, provider);
        }
        public readonly object ToType(Type conversionType, IFormatProvider provider)
        {
            return Convert.ChangeType((ulong)this, conversionType, provider);
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
            return Convert.ToUInt64((ulong)this, provider);
        }
    }
}