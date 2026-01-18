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
    unsafe public readonly struct Int24 : IComparable, IComparable<Int24>, IConvertible, IEquatable<Int24>, IFormattable, BitInt
    {
        public const int MinValue = -8388608;
        public const int MaxValue = 8388607;


		public bool IsSigned => true;
		public byte Bits => 24;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
		public byte MinFullyPackedBytes => 24 / 8;


        internal readonly byte byte0;
        internal readonly byte byte1;
        internal readonly byte byte2;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int ToFakeInt(Int24 x)
        {
            int hi = (x.byte2 << 16);
            *(short*)&hi = *(short*)&x;

            return hi;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int To_int(Int24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (memoryAccess >= MemoryAccess.Allow4ByteRead)
            {
                return (*(int*)input << (32 - 24)) >> (32 - 24);
            }
            else
            {
                int hi = (input->byte2 << 24) >> (32 - 24);
                *(short*)&hi = *(short*)input;

                return hi;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint To_uint(Int24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (uint)To_int(input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long To_long(Int24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (memoryAccess >= MemoryAccess.Allow8ByteRead)
            {
                return (*(long*)input << (64 - 24)) >> (64 - 24);
            }
            else
            {
                long hi = ((long)input->byte2 << 56) >> (64 - 24);
                *(short*)&hi = *(short*)input;

                return hi;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong To_ulong(Int24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (ulong)To_long(input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 To_Int128(Int24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (memoryAccess >= MemoryAccess.Allow8ByteRead)
            {
                long upshift = (*(long*)input << (64 - 24));
                return new Int128(upshift >> (64 - 24), upshift >> 63);
            }
            else
            {
                long hi = ((long)input->byte2 << 56) >> (64 - 24);
                long lo = hi;
                *(short*)&lo = *(short*)input;

                return new Int128(lo, hi);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 To_UInt128(Int24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (UInt128)To_Int128(input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int40 To_Int40(Int24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (Int40)To_long(input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt40 To_UInt40(Int24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (UInt40)To_Int40(input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 To_Int48(Int24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (Int48)To_long(input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt48 To_UInt48(Int24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (UInt48)To_Int48(input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int56 To_Int56(Int24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (Int56)To_long(input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 To_UInt56(Int24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (UInt56)To_Int56(input, memoryAccess);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quarter To_quarter(Int24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (quarter)(To_int(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half To_half(Int24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (half)(To_int(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float To_float(Int24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (float)(To_int(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double To_double(Int24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (double)(To_int(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quadruple To_quadruple(Int24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (quadruple)(To_int(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal To_decimal(Int24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (decimal)(To_int(input, memoryAccess));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 To_int2(Int24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new int2(To_int(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 To_int3(Int24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new int3(To_int(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 To_int4(Int24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new int4(To_int(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int8 To_int8(Int24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new int8(To_int(input, memoryAccess));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long2 To_long2(Int24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new long2(To_long(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 To_long3(Int24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new long3(To_long(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 To_long4(Int24* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new long4(To_long(input, memoryAccess));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int To_int(Int24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_int(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint To_uint(Int24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_uint(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long To_long(Int24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_long(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong To_ulong(Int24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_ulong(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 To_Int128(Int24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_Int128(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 To_UInt128(Int24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_UInt128(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int40 To_Int40(Int24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_Int40(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt40 To_UInt40(Int24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_UInt40(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 To_Int48(Int24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_Int48(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt48 To_UInt48(Int24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_UInt48(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int56 To_Int56(Int24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_Int56(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 To_UInt56(Int24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_UInt56(&input, memoryAccess);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quarter To_quarter(Int24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_quarter(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half To_half(Int24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_half(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float To_float(Int24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_float(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double To_double(Int24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_double(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quadruple To_quadruple(Int24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_quadruple(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal To_decimal(Int24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_decimal(&input, memoryAccess);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 To_int2(Int24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_int2(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 To_int3(Int24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_int3(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 To_int4(Int24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_int4(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int8 To_int8(Int24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_int8(&input, memoryAccess);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long2 To_long2(Int24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_long2(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 To_long3(Int24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_long3(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 To_long4(Int24 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_long4(&input, memoryAccess);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte2(Int24 input)
        {
            return (byte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte3(Int24 input)
        {
            return (byte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte4(Int24 input)
        {
            return (byte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte8(Int24 input)
        {
            return (byte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte16(Int24 input)
        {
            return (byte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte32(Int24 input)
        {
            return (byte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort2(Int24 input)
        {
            return (ushort)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort3(Int24 input)
        {
            return (ushort)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort4(Int24 input)
        {
            return (ushort)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort8(Int24 input)
        {
            return (ushort)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort16(Int24 input)
        {
            return (ushort)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2(Int24 input)
        {
            return (uint2)To_int2(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3(Int24 input)
        {
            return (uint3)To_int3(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint4(Int24 input)
        {
            return (uint4)To_int4(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint8(Int24 input)
        {
            return (uint8)To_int8(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong2(Int24 input)
        {
            return (ulong2)To_long2(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong3(Int24 input)
        {
            return (ulong3)To_long3(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong4(Int24 input)
        {
            return (ulong4)To_long4(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte2(Int24 input)
        {
            return (sbyte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte3(Int24 input)
        {
            return (sbyte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte4(Int24 input)
        {
            return (sbyte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte8(Int24 input)
        {
            return (sbyte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte16(Int24 input)
        {
            return (sbyte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte32(Int24 input)
        {
            return (sbyte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short2(Int24 input)
        {
            return (short)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short3(Int24 input)
        {
            return (short)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short4(Int24 input)
        {
            return (short)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short8(Int24 input)
        {
            return (short)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short16(Int24 input)
        {
            return (short)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int2(Int24 input)
        {
            return To_int2(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int3(Int24 input)
        {
            return To_int3(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int4(Int24 input)
        {
            return To_int4(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int8(Int24 input)
        {
            return To_int8(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long2(Int24 input)
        {
            return To_long2(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long3(Int24 input)
        {
            return To_long3(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long4(Int24 input)
        {
            return To_long4(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter2(Int24 input)
        {
            return (quarter)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter3(Int24 input)
        {
            return (quarter)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter4(Int24 input)
        {
            return (quarter)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter8(Int24 input)
        {
            return (quarter)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter16(Int24 input)
        {
            return (quarter)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter32(Int24 input)
        {
            return (quarter)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half2(Int24 input)
        {
            return (half)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half3(Int24 input)
        {
            return (half)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half4(Int24 input)
        {
            return (half)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half8(Int24 input)
        {
            return (half)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half16(Int24 input)
        {
            return (half)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2(Int24 input)
        {
            return To_float(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3(Int24 input)
        {
            return To_float(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float4(Int24 input)
        {
            return To_float(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float8(Int24 input)
        {
            return To_float(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2(Int24 input)
        {
            return To_double(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double3(Int24 input)
        {
            return To_double(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4(Int24 input)
        {
            return To_double(input);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int24(UInt24 input)
        {
            return *(Int24*)&input;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int24(sbyte input)
        {
            int cast = input;

            return *(Int24*)&cast;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int24(byte input)
        {
            int cast = input;

            return *(Int24*)&cast;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int24(short input)
        {
            int cast = input;

            return *(Int24*)&cast;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int24(ushort input)
        {
            uint cast = input;

            return *(Int24*)&cast;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int24(int input)
        {
            return *(Int24*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int24(uint input)
        {
            return *(Int24*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int24(long input)
        {
            return *(Int24*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int24(ulong input)
        {
            return *(Int24*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int24(Int128 input)
        {
            return *(Int24*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int24(UInt128 input)
        {
            return *(Int24*)&input;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int24(quarter input)
        {
            return (Int24)((int)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int24(half input)
        {
            return (Int24)((int)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int24(float input)
        {
            return (Int24)((int)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int24(double input)
        {
            return (Int24)((int)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int24(quadruple input)
        {
            return (Int24)((int)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int24(decimal input)
        {
            return (Int24)((int)input);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte(Int24 input)
        {
            return (sbyte)input.byte0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte(Int24 input)
        {
            return input.byte0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short(Int24 input)
        {
            return *(short*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort(Int24 input)
        {
            return *(ushort*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int(Int24 input)
        {
            return To_int(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint(Int24 input)
        {
            return To_uint(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long(Int24 input)
        {
            return To_long(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong(Int24 input)
        {
            return To_ulong(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int128(Int24 input)
        {
            return To_Int128(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt128(Int24 input)
        {
            return To_UInt128(input);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter(Int24 input)
        {
            return To_quarter(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half(Int24 input)
        {
            return To_half(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float(Int24 input)
        {
            return To_float(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double(Int24 input)
        {
            return To_double(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator quadruple(Int24 input)
        {
            return To_quadruple(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator decimal(Int24 input)
        {
            return To_decimal(input);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator - (Int24 value)
        {
            return -(ToFakeInt(value));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator ~ (Int24 value)
        {
            return ~(ToFakeInt(value));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator ++ (Int24 value)
        {
            int cast = ToFakeInt(value);

            return (Int24)(++cast);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator -- (Int24 value)
        {
            int cast = ToFakeInt(value);

            return (Int24)(--cast);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator + (Int24 left, Int24 right)
        {
            return ToFakeInt(left) + ToFakeInt(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int operator + (Int24 left, int right)
        {
            return (int)left + right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int operator + (int left, Int24 right)
        {
            return left + (int)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator - (Int24 left, Int24 right)
        {
            return ToFakeInt(left) - ToFakeInt(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int operator - (Int24 left, int right)
        {
            return (int)left - right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int operator - (int left, Int24 right)
        {
            return left - (int)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator * (Int24 left, Int24 right)
        {
            return ToFakeInt(left) * ToFakeInt(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int operator * (Int24 left, int right)
        {
            return (int)left * right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int operator * (int left, Int24 right)
        {
            return left * (int)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int operator / (Int24 left, Int24 right)
        {
            return (int)left / (int)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int operator / (Int24 left, int right)
        {
            return (int)left / right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int operator / (int left, Int24 right)
        {
            return left / (int)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int operator % (Int24 left, Int24 right)
        {
            return (int)left % (int)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int operator % (Int24 left, int right)
        {
            return (int)left % right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int operator % (int left, Int24 right)
        {
            return left % (int)right;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator & (Int24 left, Int24 right)
        {
            return ToFakeInt(left) & ToFakeInt(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int operator & (Int24 left, int right)
        {
            return (int)left & right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int operator & (int left, Int24 right)
        {
            return left & (int)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator | (Int24 left, Int24 right)
        {
            return ToFakeInt(left) | ToFakeInt(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int operator | (Int24 left, int right)
        {
            return (int)left | right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int operator | (int left, Int24 right)
        {
            return left | (int)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator ^ (Int24 left, Int24 right)
        {
            return ToFakeInt(left) ^ ToFakeInt(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int operator ^ (Int24 left, int right)
        {
            return (int)left ^ right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int operator ^ (int left, Int24 right)
        {
            return left ^ (int)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator << (Int24 left, int right)
        {
            return ToFakeInt(left) << right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int operator >> (Int24 left, int right)
        {
            return (int)left >> right;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator == (Int24 left, Int24 right)
        {
            return ToFakeInt(left) == ToFakeInt(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator == (Int24 left, int right)
        {
            return (int)left == right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator == (int left, Int24 right)
        {
            return left == (int)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator != (Int24 left, Int24 right)
        {
            return ToFakeInt(left) != ToFakeInt(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator != (Int24 left, int right)
        {
            return (int)left != right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator != (int left, Int24 right)
        {
            return left != (int)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator < (Int24 left, Int24 right)
        {
            return (int)left < (int)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator < (Int24 left, int right)
        {
            return (int)left < right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator < (int left, Int24 right)
        {
            return left < (int)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator > (Int24 left, Int24 right)
        {
            return (int)left > (int)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator > (Int24 left, int right)
        {
            return (int)left > right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator > (int left, Int24 right)
        {
            return left > (int)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <= (Int24 left, Int24 right)
        {
            return (int)left <= (int)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <= (Int24 left, int right)
        {
            return (int)left <= right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <= (int left, Int24 right)
        {
            return left <= (int)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >= (Int24 left, Int24 right)
        {
            return (int)left >= (int)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >= (Int24 left, int right)
        {
            return (int)left >= right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >= (int left, Int24 right)
        {
            return left >= (int)right;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
            return (int)this;
        }
        public readonly TypeCode GetTypeCode()
        {
            return TypeCode.Int32;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Int24 other)
        {
            return this == other;
        }
        public override readonly bool Equals(object obj)
        {
            return obj is Int24 converted && this.Equals(converted);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int CompareTo(Int24 other)
        {
            return compareto((int)this, (int)other);
        }
        public readonly int CompareTo(object obj)
        {
            return CompareTo((Int24)obj);
        }


        public static Int24 Parse(string s)
        {
            return (Int24)int.Parse(s);
        }
        public static Int24 Parse(string s, NumberStyles style)
        {
            return (Int24)int.Parse(s, style);
        }
        public static Int24 Parse(string s, IFormatProvider provider)
        {
            return (Int24)int.Parse(s, provider);
        }
        public static Int24 Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            return (Int24)int.Parse(s, style, provider);
        }
        public static bool TryParse(string s, out Int24 result)
        {
            bool success = int.TryParse(s, out int Int);

            result = (Int24)Int;

            return success & isinrange(Int, MinValue, MaxValue);
        }
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out Int24 result)
        {
            bool success = int.TryParse(s, style, provider, out int Int);

            result = (Int24)Int;

            return success & isinrange(Int, MinValue, MaxValue);
        }

        public override readonly string ToString()
        {
            return ((int)this).ToString();
        }
        public readonly string ToString(string format)
        {
            return ((int)this).ToString(format);
        }
        public readonly string ToString(IFormatProvider provider)
        {
            return ((int)this).ToString(provider);
        }
        public readonly string ToString(string format, IFormatProvider provider)
        {
            return ((int)this).ToString(format, provider);
        }

        public readonly bool ToBoolean(IFormatProvider provider)
        {
            return Convert.ToBoolean((int)this, provider);
        }
        public readonly byte ToByte(IFormatProvider provider)
        {
            return Convert.ToByte((byte)this, provider);
        }
        public readonly char ToChar(IFormatProvider provider)
        {
            return Convert.ToChar((int)this, provider);
        }
        public readonly DateTime ToDateTime(IFormatProvider provider)
        {
            return Convert.ToDateTime((int)this, provider);
        }
        public readonly decimal ToDecimal(IFormatProvider provider)
        {
            return Convert.ToDecimal((int)this, provider);
        }
        public readonly double ToDouble(IFormatProvider provider)
        {
            return Convert.ToDouble((int)this, provider);
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
            return Convert.ToInt64((int)this, provider);
        }
        public readonly sbyte ToSByte(IFormatProvider provider)
        {
            return Convert.ToSByte((sbyte)this, provider);
        }
        public readonly float ToSingle(IFormatProvider provider)
        {
            return Convert.ToSingle((int)this, provider);
        }
        public readonly object ToType(Type conversionType, IFormatProvider provider)
        {
            return Convert.ChangeType((int)this, conversionType, provider);
        }
        public readonly ushort ToUInt16(IFormatProvider provider)
        {
            return Convert.ToUInt16((ushort)this, provider);
        }
        public readonly uint ToUInt32(IFormatProvider provider)
        {
            return Convert.ToUInt32((int)this, provider);
        }
        public readonly ulong ToUInt64(IFormatProvider provider)
        {
            return Convert.ToUInt64((int)this, provider);
        }
    }
}