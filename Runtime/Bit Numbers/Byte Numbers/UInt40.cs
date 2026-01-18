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
    [StructLayout(LayoutKind.Sequential, Size = 5)]
    unsafe public readonly struct UInt40 : BitInt, IComparable, IComparable<UInt40>, IConvertible, IEquatable<UInt40>, IFormattable
    {
        public const ulong MinValue = 0;
        public const ulong MaxValue = 1099511627775;

        internal readonly byte byte0;
        internal readonly byte byte1;
        internal readonly byte byte2;
        internal readonly byte byte3;
        internal readonly byte byte4;

        public bool IsSigned => false;
        public byte Bits => 40;
        public byte MinFullyPackedBytes => 40 / 8;
        public long MinValueAsLong => (long)MinValue;
        public long MaxValueAsLong => (long)MaxValue;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long To_long(UInt40* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (long)To_ulong(input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong To_ulong(UInt40* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (memoryAccess >= MemoryAccess.Allow8ByteRead)
            {
                return *(ulong*)input & bitmask64(40ul);
            }
            else
            {
                ulong lo = *(uint*)input;
                lo |= ((ulong)input->byte4 << 32);

                return lo;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 To_Int128(UInt40* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (Int128)To_UInt128(input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 To_UInt128(UInt40* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (UInt128)To_ulong(input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 To_Int48(UInt40* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (Int48)To_long(input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt48 To_UInt48(UInt40* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (UInt48)To_Int48(input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int56 To_Int56(UInt40* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (Int56)To_long(input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 To_UInt56(UInt40* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (UInt56)To_Int56(input, memoryAccess);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quarter To_quarter(UInt40* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (quarter)(To_long(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half To_half(UInt40* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (half)(To_long(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float To_float(UInt40* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (float)(To_long(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double To_double(UInt40* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (double)(To_long(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quadruple To_quadruple(UInt40* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (quadruple)(To_long(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal To_decimal(UInt40* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return (decimal)(To_long(input, memoryAccess));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 To_ulong2(UInt40* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new ulong2(To_ulong(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 To_ulong3(UInt40* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new ulong3(To_ulong(input, memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 To_ulong4(UInt40* input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new ulong4(To_ulong(input, memoryAccess));
        }
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long To_long(UInt40 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_long(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong To_ulong(UInt40 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_ulong(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 To_Int128(UInt40 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_Int128(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 To_UInt128(UInt40 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_UInt128(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 To_Int48(UInt40 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_Int48(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt48 To_UInt48(UInt40 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_UInt48(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int56 To_Int56(UInt40 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_Int56(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 To_UInt56(UInt40 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_UInt56(&input, memoryAccess);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quarter To_quarter(UInt40 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_quarter(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half To_half(UInt40 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_half(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float To_float(UInt40 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_float(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double To_double(UInt40 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_double(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quadruple To_quadruple(UInt40 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_quadruple(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal To_decimal(UInt40 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_decimal(&input, memoryAccess);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 To_ulong2(UInt40 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_ulong2(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 To_ulong3(UInt40 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_ulong3(&input, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 To_ulong4(UInt40 input, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return To_ulong4(&input, memoryAccess);
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte2(UInt40 input)
        {
            return (byte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte3(UInt40 input)
        {
            return (byte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte4(UInt40 input)
        {
            return (byte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte8(UInt40 input)
        {
            return (byte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte16(UInt40 input)
        {
            return (byte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte32(UInt40 input)
        {
            return (byte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort2(UInt40 input)
        {
            return (ushort)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort3(UInt40 input)
        {
            return (ushort)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort4(UInt40 input)
        {
            return (ushort)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort8(UInt40 input)
        {
            return (ushort)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort16(UInt40 input)
        {
            return (ushort)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2(UInt40 input)
        {
            return (uint)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3(UInt40 input)
        {
            return (uint)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint4(UInt40 input)
        {
            return (uint)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint8(UInt40 input)
        {
            return (uint)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong2(UInt40 input)
        {
            return To_ulong2(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong3(UInt40 input)
        {
            return To_ulong3(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong4(UInt40 input)
        {
            return To_ulong4(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte2(UInt40 input)
        {
            return (sbyte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte3(UInt40 input)
        {
            return (sbyte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte4(UInt40 input)
        {
            return (sbyte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte8(UInt40 input)
        {
            return (sbyte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte16(UInt40 input)
        {
            return (sbyte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte32(UInt40 input)
        {
            return (sbyte)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short2(UInt40 input)
        {
            return (short)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short3(UInt40 input)
        {
            return (short)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short4(UInt40 input)
        {
            return (short)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short8(UInt40 input)
        {
            return (short)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short16(UInt40 input)
        {
            return (short)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2(UInt40 input)
        {
            return (int)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3(UInt40 input)
        {
            return (int)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4(UInt40 input)
        {
            return (int)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int8(UInt40 input)
        {
            return (int)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long2(UInt40 input)
        {
            return (long2)To_ulong2(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long3(UInt40 input)
        {
            return (long3)To_ulong3(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long4(UInt40 input)
        {
            return (long4)To_ulong4(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter2(UInt40 input)
        {
            return (quarter)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter3(UInt40 input)
        {
            return (quarter)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter4(UInt40 input)
        {
            return (quarter)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter8(UInt40 input)
        {
            return (quarter)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter16(UInt40 input)
        {
            return (quarter)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter32(UInt40 input)
        {
            return (quarter)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half2(UInt40 input)
        {
            return (half)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half3(UInt40 input)
        {
            return (half)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half4(UInt40 input)
        {
            return (half)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half8(UInt40 input)
        {
            return (half)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half16(UInt40 input)
        {
            return (half)input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2(UInt40 input)
        {
            return To_float(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3(UInt40 input)
        {
            return To_float(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float4(UInt40 input)
        {
            return To_float(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float8(UInt40 input)
        {
            return To_float(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2(UInt40 input)
        {
            return To_double(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double3(UInt40 input)
        {
            return To_double(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4(UInt40 input)
        {
            return To_double(input);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt40(Int40 input)
        {
            return *(UInt40*)&input;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt40(sbyte input)
        {
            ulong cast = (ulong)input;

            return *(UInt40*)&cast;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt40(byte input)
        {
            ulong cast = input;

            return *(UInt40*)&cast;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt40(short input)
        {
            ulong cast = (ulong)input;

            return *(UInt40*)&cast;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt40(ushort input)
        {
            ulong cast = input;

            return *(UInt40*)&cast;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt40(Int24 input)
        {
            return Int24.To_UInt40(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt40(UInt24 input)
        {
            return UInt24.To_UInt40(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt40(int input)
        {
            ulong cast = (ulong)input;

            return *(UInt40*)&cast;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt40(uint input)
        {
            ulong cast = input;

            return *(UInt40*)&cast;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt40(long input)
        {
            return *(UInt40*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt40(ulong input)
        {
            return *(UInt40*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt40(Int128 input)
        {
            return *(UInt40*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt40(UInt128 input)
        {
            return *(UInt40*)&input;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt40(quarter input)
        {
            return (UInt40)((uint)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt40(half input)
        {
            return (UInt40)((uint)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt40(float input)
        {
            return (UInt40)((ulong)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt40(double input)
        {
            return (UInt40)((ulong)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt40(quadruple input)
        {
            return (UInt40)((ulong)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt40(decimal input)
        {
            return (UInt40)((ulong)input);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte(UInt40 input)
        {
            return (sbyte)input.byte0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte(UInt40 input)
        {
            return input.byte0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short(UInt40 input)
        {
            return *(short*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort(UInt40 input)
        {
            return *(ushort*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int24(UInt40 input)
        {
            return *(Int24*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt24(UInt40 input)
        {
            return *(UInt24*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int(UInt40 input)
        {
            return *(int*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint(UInt40 input)
        {
            return *(uint*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long(UInt40 input)
        {
            return To_long(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong(UInt40 input)
        {
            return To_ulong(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int128(UInt40 input)
        {
            return To_Int128(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt128(UInt40 input)
        {
            return To_UInt128(input);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter(UInt40 input)
        {
            return To_quarter(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half(UInt40 input)
        {
            return To_half(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float(UInt40 input)
        {
            return To_float(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double(UInt40 input)
        {
            return To_double(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator quadruple(UInt40 input)
        {
            return To_quadruple(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator decimal(UInt40 input)
        {
            return To_decimal(input);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator ~ (UInt40 value)
        {
            return ~((ulong)value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt40 operator ++ (UInt40 value)
        {
            ulong cast = (ulong)value;

            return (UInt40)(++cast);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt40 operator -- (UInt40 value)
        {
            ulong cast = (ulong)value;

            return (UInt40)(--cast);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator + (UInt40 left, UInt40 right)
        {
            return (ulong)left + (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator + (uint left, UInt40 right)
        {
            return left + (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator + (UInt40 left, uint right)
        {
            return (ulong)left + right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator + (UInt40 left, ulong right)
        {
            return (ulong)left + right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator + (ulong left, UInt40 right)
        {
            return left + (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator - (UInt40 left, UInt40 right)
        {
            return (ulong)left - (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator - (UInt40 left, uint right)
        {
            return (ulong)left - right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator - (uint left, UInt40 right)
        {
            return left - (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator - (UInt40 left, ulong right)
        {
            return (ulong)left - right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator - (ulong left, UInt40 right)
        {
            return left - (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator * (UInt40 left, UInt40 right)
        {
            return (ulong)left * (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator * (UInt40 left, uint right)
        {
            return (ulong)left * right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator * (uint left, UInt40 right)
        {
            return left * (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator * (UInt40 left, ulong right)
        {
            return (ulong)left * right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator * (ulong left, UInt40 right)
        {
            return left * (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator / (UInt40 left, UInt40 right)
        {
            return (ulong)left / (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator / (UInt40 left, uint right)
        {
            return (ulong)left / right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator / (uint left, UInt40 right)
        {
            return left / (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator / (UInt40 left, ulong right)
        {
            return (ulong)left / right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator / (ulong left, UInt40 right)
        {
            return left / (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator % (UInt40 left, UInt40 right)
        {
            return (ulong)left % (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator % (UInt40 left, uint right)
        {
            return (ulong)left % right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator % (uint left, UInt40 right)
        {
            return left % (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator % (UInt40 left, ulong right)
        {
            return (ulong)left % right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator % (ulong left, UInt40 right)
        {
            return left % (ulong)right;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator & (UInt40 left, UInt40 right)
        {
            return (ulong)left & (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator & (UInt40 left, uint right)
        {
            return (ulong)left & right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator & (uint left, UInt40 right)
        {
            return left & (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator & (UInt40 left, ulong right)
        {
            return (ulong)left & right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator & (ulong left, UInt40 right)
        {
            return left & (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator | (UInt40 left, UInt40 right)
        {
            return (ulong)left | (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator | (UInt40 left, uint right)
        {
            return (ulong)left | right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator | (uint left, UInt40 right)
        {
            return left | (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator | (UInt40 left, ulong right)
        {
            return (ulong)left | right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator | (ulong left, UInt40 right)
        {
            return left | (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator ^ (UInt40 left, UInt40 right)
        {
            return (ulong)left ^ (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator ^ (UInt40 left, uint right)
        {
            return (ulong)left ^ right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator ^ (uint left, UInt40 right)
        {
            return left ^ (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator ^ (UInt40 left, ulong right)
        {
            return (ulong)left ^ right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator ^ (ulong left, UInt40 right)
        {
            return left ^ (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator << (UInt40 left, int right)
        {
            return (ulong)left << right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong operator >> (UInt40 left, int right)
        {
            return (ulong)left >> right;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator == (UInt40 left, UInt40 right)
        {
            return (ulong)left == (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator == (UInt40 left, uint right)
        {
            return (ulong)left == right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator == (uint left, UInt40 right)
        {
            return left == (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator == (UInt40 left, ulong right)
        {
            return (ulong)left == right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator == (ulong left, UInt40 right)
        {
            return left == (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator != (UInt40 left, UInt40 right)
        {
            return (ulong)left != (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator != (UInt40 left, uint right)
        {
            return (ulong)left != right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator != (uint left, UInt40 right)
        {
            return left != (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator != (UInt40 left, ulong right)
        {
            return (ulong)left != right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator != (ulong left, UInt40 right)
        {
            return left != (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator < (UInt40 left, UInt40 right)
        {
            return (ulong)left < (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator < (UInt40 left, uint right)
        {
            return (ulong)left < right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator < (uint left, UInt40 right)
        {
            return left < (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator < (UInt40 left, ulong right)
        {
            return (ulong)left < right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator < (ulong left, UInt40 right)
        {
            return left < (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator > (UInt40 left, UInt40 right)
        {
            return (ulong)left > (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator > (UInt40 left, uint right)
        {
            return (ulong)left > right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator > (uint left, UInt40 right)
        {
            return left > (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator > (UInt40 left, ulong right)
        {
            return (ulong)left > right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator > (ulong left, UInt40 right)
        {
            return left > (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <= (UInt40 left, UInt40 right)
        {
            return (ulong)left <= (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <= (UInt40 left, uint right)
        {
            return (ulong)left <= right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <= (uint left, UInt40 right)
        {
            return left <= (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <= (UInt40 left, ulong right)
        {
            return (ulong)left <= right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <= (ulong left, UInt40 right)
        {
            return left <= (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >= (UInt40 left, UInt40 right)
        {
            return (ulong)left >= (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >= (UInt40 left, uint right)
        {
            return (ulong)left >= right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >= (uint left, UInt40 right)
        {
            return left >= (ulong)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >= (UInt40 left, ulong right)
        {
            return (ulong)left >= right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >= (ulong left, UInt40 right)
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
        public readonly bool Equals(UInt40 other)
        {
            return this == other;
        }
        public override readonly bool Equals(object obj)
        {
            return obj is UInt40 converted && this.Equals(converted);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int CompareTo(UInt40 other)
        {
            return compareto((ulong)this, (ulong)other);
        }
        public readonly int CompareTo(object obj)
        {
            return CompareTo((UInt40)obj);
        }


        public static UInt40 Parse(string s)
        {
            return (UInt40)ulong.Parse(s);
        }
        public static UInt40 Parse(string s, NumberStyles style)
        {
            return (UInt40)ulong.Parse(s, style);
        }
        public static UInt40 Parse(string s, IFormatProvider provider)
        {
            return (UInt40)ulong.Parse(s, provider);
        }
        public static UInt40 Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            return (UInt40)ulong.Parse(s, style, provider);
        }
        public static bool TryParse(string s, out UInt40 result)
        {
            bool success = ulong.TryParse(s, out ulong Int);

            result = (UInt40)Int;

            return success & (Int <= MaxValue);
        }
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out UInt40 result)
        {
            bool success = ulong.TryParse(s, style, provider, out ulong Int);

            result = (UInt40)Int;

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