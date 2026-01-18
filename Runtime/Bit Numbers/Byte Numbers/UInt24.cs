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
    [StructLayout(LayoutKind.Sequential, Size = 3)]
    unsafe public readonly struct UInt24 : IComparable, IComparable<UInt24>, IConvertible, IEquatable<UInt24>, IFormattable, BitInt
    {
        public const uint MinValue = 0;
        public const uint MaxValue = 16777215;


		public bool IsSigned => false;
		public byte Bits => 24;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
		public byte MinFullyPackedBytes => 24 / 8;


        internal readonly byte byte0;
        internal readonly byte byte1;
        internal readonly byte byte2;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int To_int(UInt24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (int)To_uint(input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint To_uint(UInt24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (memoryAccess >= MemoryAccess.Allow4ByteRead)
            {
                return *(uint*)input & bitmask32(24u);
            }
            else
            {
                uint hi = (uint)(input->byte2 << 16);
                *(ushort*)&hi = *(ushort*)input;

                return hi;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long To_long(UInt24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (long)To_ulong(input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong To_ulong(UInt24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (memoryAccess >= MemoryAccess.Allow8ByteRead)
            {
                return *(ulong*)input & bitmask64(24ul);
            }
            else
            {
                ulong hi = ((ulong)input->byte2 << 16);
                *(ushort*)&hi = *(ushort*)input;

                return hi;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 To_Int128(UInt24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (Int128)To_UInt128(input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 To_UInt128(UInt24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (UInt128)To_ulong(input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int40 To_Int40(UInt24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (Int40)To_long(input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt40 To_UInt40(UInt24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (UInt40)To_Int40(input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 To_Int48(UInt24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (Int48)To_long(input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt48 To_UInt48(UInt24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (UInt48)To_Int48(input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int56 To_Int56(UInt24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (Int56)To_long(input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 To_UInt56(UInt24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (UInt56)To_Int56(input, memoryAccess);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quarter To_quarter(UInt24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (quarter)(To_int(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half To_half(UInt24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (half)(To_int(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float To_float(UInt24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (float)(To_int(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double To_double(UInt24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (double)(To_int(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quadruple To_quadruple(UInt24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (quadruple)(To_int(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal To_decimal(UInt24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (decimal)(To_int(input, memoryAccess));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 To_uint2(UInt24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new uint2(To_uint(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 To_uint3(UInt24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new uint3(To_uint(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 To_uint4(UInt24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new uint4(To_uint(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint8 To_uint8(UInt24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new uint8(To_uint(input, memoryAccess));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 To_ulong2(UInt24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new ulong2(To_ulong(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 To_ulong3(UInt24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new ulong3(To_ulong(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 To_ulong4(UInt24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new ulong4(To_ulong(input, memoryAccess));
        }
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int To_int(UInt24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_int(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint To_uint(UInt24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_uint(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long To_long(UInt24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_long(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong To_ulong(UInt24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_ulong(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 To_Int128(UInt24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_Int128(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 To_UInt128(UInt24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_UInt128(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int40 To_Int40(UInt24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_Int40(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt40 To_UInt40(UInt24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_UInt40(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 To_Int48(UInt24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_Int48(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt48 To_UInt48(UInt24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_UInt48(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int56 To_Int56(UInt24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_Int56(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 To_UInt56(UInt24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_UInt56(&input, memoryAccess);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quarter To_quarter(UInt24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_quarter(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half To_half(UInt24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_half(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float To_float(UInt24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_float(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double To_double(UInt24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_double(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quadruple To_quadruple(UInt24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_quadruple(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal To_decimal(UInt24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_decimal(&input, memoryAccess);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 To_uint2(UInt24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_uint2(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 To_uint3(UInt24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_uint3(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 To_uint4(UInt24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_uint4(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint8 To_uint8(UInt24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_uint8(&input, memoryAccess);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 To_ulong2(UInt24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_ulong2(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 To_ulong3(UInt24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_ulong3(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 To_ulong4(UInt24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_ulong4(&input, memoryAccess);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte2(UInt24 input)
        {
            return (byte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte3(UInt24 input)
        {
            return (byte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte4(UInt24 input)
        {
            return (byte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte8(UInt24 input)
        {
            return (byte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte16(UInt24 input)
        {
            return (byte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte32(UInt24 input)
        {
            return (byte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort2(UInt24 input)
        {
            return (ushort)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort3(UInt24 input)
        {
            return (ushort)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort4(UInt24 input)
        {
            return (ushort)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort8(UInt24 input)
        {
            return (ushort)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort16(UInt24 input)
        {
            return (ushort)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint2(UInt24 input)
        {
            return To_uint2(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint3(UInt24 input)
        {
            return To_uint3(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint4(UInt24 input)
        {
            return To_uint4(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint8(UInt24 input)
        {
            return To_uint8(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong2(UInt24 input)
        {
            return To_ulong2(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong3(UInt24 input)
        {
            return To_ulong3(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong4(UInt24 input)
        {
            return To_ulong4(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte2(UInt24 input)
        {
            return (sbyte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte3(UInt24 input)
        {
            return (sbyte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte4(UInt24 input)
        {
            return (sbyte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte8(UInt24 input)
        {
            return (sbyte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte16(UInt24 input)
        {
            return (sbyte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte32(UInt24 input)
        {
            return (sbyte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short2(UInt24 input)
        {
            return (short)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short3(UInt24 input)
        {
            return (short)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short4(UInt24 input)
        {
            return (short)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short8(UInt24 input)
        {
            return (short)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short16(UInt24 input)
        {
            return (short)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int2(UInt24 input)
        {
            return (int2)To_uint2(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int3(UInt24 input)
        {
            return (int3)To_uint3(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int4(UInt24 input)
        {
            return (int4)To_uint4(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int8(UInt24 input)
        {
            return (int8)To_uint8(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long2(UInt24 input)
        {
            return (long2)To_ulong2(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long3(UInt24 input)
        {
            return (long3)To_ulong3(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long4(UInt24 input)
        {
            return (long4)To_ulong4(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter2(UInt24 input)
        {
            return (quarter)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter3(UInt24 input)
        {
            return (quarter)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter4(UInt24 input)
        {
            return (quarter)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter8(UInt24 input)
        {
            return (quarter)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter16(UInt24 input)
        {
            return (quarter)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter32(UInt24 input)
        {
            return (quarter)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half2(UInt24 input)
        {
            return (half)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half3(UInt24 input)
        {
            return (half)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half4(UInt24 input)
        {
            return (half)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half8(UInt24 input)
        {
            return (half)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half16(UInt24 input)
        {
            return (half)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2(UInt24 input)
        {
            return To_float(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3(UInt24 input)
        {
            return To_float(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float4(UInt24 input)
        {
            return To_float(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float8(UInt24 input)
        {
            return To_float(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2(UInt24 input)
        {
            return To_double(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double3(UInt24 input)
        {
            return To_double(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4(UInt24 input)
        {
            return To_double(input);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt24(Int24 input)
        {
            return *(UInt24*)&input;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt24(sbyte input)
        {
            uint cast = (uint)input;

            return *(UInt24*)&cast;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt24(byte input)
        {
            uint cast = input;

            return *(UInt24*)&cast;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt24(short input)
        {
            uint cast = (uint)input;

            return *(UInt24*)&cast;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt24(ushort input)
        {
            uint cast = input;

            return *(UInt24*)&cast;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt24(int input)
        {
            return *(UInt24*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt24(uint input)
        {
            return *(UInt24*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt24(long input)
        {
            return *(UInt24*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt24(ulong input)
        {
            return *(UInt24*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt24(Int128 input)
        {
            return *(UInt24*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt24(UInt128 input)
        {
            return *(UInt24*)&input;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt24(quarter input)
        {
            return (UInt24)((uint)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt24(half input)
        {
            return (UInt24)((uint)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt24(float input)
        {
            return (UInt24)((uint)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt24(double input)
        {
            return (UInt24)((uint)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt24(quadruple input)
        {
            return (UInt24)((uint)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt24(decimal input)
        {
            return (UInt24)((uint)input);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte(UInt24 input)
        {
            return (sbyte)input.byte0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte(UInt24 input)
        {
            return input.byte0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short(UInt24 input)
        {
            return *(short*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort(UInt24 input)
        {
            return *(ushort*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int(UInt24 input)
        {
            return To_int(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint(UInt24 input)
        {
            return To_uint(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long(UInt24 input)
        {
            return To_long(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong(UInt24 input)
        {
            return To_ulong(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int128(UInt24 input)
        {
            return To_Int128(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt128(UInt24 input)
        {
            return To_UInt128(input);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter(UInt24 input)
        {
            return To_quarter(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half(UInt24 input)
        {
            return To_half(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float(UInt24 input)
        {
            return To_float(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double(UInt24 input)
        {
            return To_double(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator quadruple(UInt24 input)
        {
            return To_quadruple(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator decimal(UInt24 input)
        {
            return To_decimal(input);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint operator ~ (UInt24 value)
        {
            return ~((uint)value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 operator ++ (UInt24 value)
        {
            uint cast = (uint)value;

            return (UInt24)(++cast);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 operator -- (UInt24 value)
        {
            uint cast = (uint)value;

            return (UInt24)(--cast);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint operator + (UInt24 left, UInt24 right)
        {
            return (uint)left + (uint)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint operator + (uint left, UInt24 right)
        {
            return left + (uint)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint operator + (UInt24 left, uint right)
        {
            return (uint)left + right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint operator - (UInt24 left, UInt24 right)
        {
            return (uint)left - (uint)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint operator - (UInt24 left, uint right)
        {
            return (uint)left - right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint operator - (uint left, UInt24 right)
        {
            return left - (uint)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint operator * (UInt24 left, UInt24 right)
        {
            return (uint)left * (uint)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint operator * (UInt24 left, uint right)
        {
            return (uint)left * right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint operator * (uint left, UInt24 right)
        {
            return left * (uint)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint operator / (UInt24 left, UInt24 right)
        {
            return (uint)left / (uint)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint operator / (UInt24 left, uint right)
        {
            return (uint)left / right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint operator / (uint left, UInt24 right)
        {
            return left / (uint)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint operator % (UInt24 left, UInt24 right)
        {
            return (uint)left % (uint)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint operator % (UInt24 left, uint right)
        {
            return (uint)left % right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint operator % (uint left, UInt24 right)
        {
            return left % (uint)right;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint operator & (UInt24 left, UInt24 right)
        {
            return (uint)left & (uint)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint operator & (UInt24 left, uint right)
        {
            return (uint)left & right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint operator & (uint left, UInt24 right)
        {
            return left & (uint)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint operator | (UInt24 left, UInt24 right)
        {
            return (uint)left | (uint)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint operator | (UInt24 left, uint right)
        {
            return (uint)left | right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint operator | (uint left, UInt24 right)
        {
            return left | (uint)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint operator ^ (UInt24 left, UInt24 right)
        {
            return (uint)left ^ (uint)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint operator ^ (UInt24 left, uint right)
        {
            return (uint)left ^ right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint operator ^ (uint left, UInt24 right)
        {
            return left ^ (uint)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint operator << (UInt24 left, int right)
        {
            return (uint)left << right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint operator >> (UInt24 left, int right)
        {
            return (uint)left >> right;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator == (UInt24 left, UInt24 right)
        {
            return (uint)left == (uint)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator == (UInt24 left, uint right)
        {
            return (uint)left == right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator == (uint left, UInt24 right)
        {
            return left == (uint)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator != (UInt24 left, UInt24 right)
        {
            return (uint)left != (uint)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator != (UInt24 left, uint right)
        {
            return (uint)left != right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator != (uint left, UInt24 right)
        {
            return left != (uint)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator < (UInt24 left, UInt24 right)
        {
            return (uint)left < (uint)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator < (UInt24 left, uint right)
        {
            return (uint)left < right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator < (uint left, UInt24 right)
        {
            return left < (uint)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator > (UInt24 left, UInt24 right)
        {
            return (uint)left > (uint)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator > (UInt24 left, uint right)
        {
            return (uint)left > right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator > (uint left, UInt24 right)
        {
            return left > (uint)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <= (UInt24 left, UInt24 right)
        {
            return (uint)left <= (uint)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <= (UInt24 left, uint right)
        {
            return (uint)left <= right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <= (uint left, UInt24 right)
        {
            return left <= (uint)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >= (UInt24 left, UInt24 right)
        {
            return (uint)left >= (uint)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >= (UInt24 left, uint right)
        {
            return (uint)left >= right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >= (uint left, UInt24 right)
        {
            return left >= (uint)right;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
            return (int)this;
        }
        public readonly TypeCode GetTypeCode()
        {
            return TypeCode.UInt32;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(UInt24 other)
        {
            return this == other;
        }
        public override readonly bool Equals(object obj)
        {
            return obj is UInt24 converted && this.Equals(converted);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int CompareTo(UInt24 other)
        {
            return compareto((uint)this, (uint)other);
        }
        public readonly int CompareTo(object obj)
        {
            return CompareTo((UInt24)obj);
        }


        public static UInt24 Parse(string s)
        {
            return (UInt24)uint.Parse(s);
        }
        public static UInt24 Parse(string s, NumberStyles style)
        {
            return (UInt24)uint.Parse(s, style);
        }
        public static UInt24 Parse(string s, IFormatProvider provider)
        {
            return (UInt24)uint.Parse(s, provider);
        }
        public static UInt24 Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            return (UInt24)uint.Parse(s, style, provider);
        }
        public static bool TryParse(string s, out UInt24 result)
        {
            bool success = uint.TryParse(s, out uint Int);

            result = (UInt24)Int;

            return success & (Int <= MaxValue);
        }
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out UInt24 result)
        {
            bool success = uint.TryParse(s, style, provider, out uint Int);

            result = (UInt24)Int;

            return success & (Int <= MaxValue);
        }

        public override readonly string ToString()
        {
            return ((uint)this).ToString();
        }
        public readonly string ToString(string format)
        {
            return ((uint)this).ToString(format);
        }
        public readonly string ToString(IFormatProvider provider)
        {
            return ((uint)this).ToString(provider);
        }
        public readonly string ToString(string format, IFormatProvider provider)
        {
            return ((uint)this).ToString(format, provider);
        }

        public readonly bool ToBoolean(IFormatProvider provider)
        {
            return Convert.ToBoolean((uint)this, provider);
        }
        public readonly byte ToByte(IFormatProvider provider)
        {
            return Convert.ToByte((byte)this, provider);
        }
        public readonly char ToChar(IFormatProvider provider)
        {
            return Convert.ToChar((uint)this, provider);
        }
        public readonly DateTime ToDateTime(IFormatProvider provider)
        {
            return Convert.ToDateTime((uint)this, provider);
        }
        public readonly decimal ToDecimal(IFormatProvider provider)
        {
            return Convert.ToDecimal((uint)this, provider);
        }
        public readonly double ToDouble(IFormatProvider provider)
        {
            return Convert.ToDouble((uint)this, provider);
        }
        public readonly short ToInt16(IFormatProvider provider)
        {
            return Convert.ToInt16((short)this, provider);
        }
        public readonly int ToInt32(IFormatProvider provider)
        {
            return Convert.ToInt32((uint)this, provider);
        }
        public readonly long ToInt64(IFormatProvider provider)
        {
            return Convert.ToInt64((uint)this, provider);
        }
        public readonly sbyte ToSByte(IFormatProvider provider)
        {
            return Convert.ToSByte((sbyte)this, provider);
        }
        public readonly float ToSingle(IFormatProvider provider)
        {
            return Convert.ToSingle((uint)this, provider);
        }
        public readonly object ToType(Type conversionType, IFormatProvider provider)
        {
            return Convert.ChangeType((uint)this, conversionType, provider);
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
            return Convert.ToUInt64((uint)this, provider);
        }
    }
}