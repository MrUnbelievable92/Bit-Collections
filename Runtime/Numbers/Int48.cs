﻿using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using MaxMath;

namespace BitCollections
{ 
    [Serializable]  [StructLayout(LayoutKind.Sequential, Size = 6)]
    unsafe public readonly struct Int48 : IComparable, IComparable<Int48>, IConvertible, IEquatable<Int48>, IFormattable
    {
        public const long MinValue = -140_737_488_355_328;
        public const long MaxValue = 140_737_488_355_327;
    
    
        private readonly ushort byte0_byte1;
        private readonly ushort byte2_byte3;
        private readonly ushort byte4_byte5;
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long2 ToLong2(Int48 x, Int48 y)
        {
            long2 masked = new long2(*(long*)&x, *(long*)&y);

            return maxmath.signextend(masked, 48);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 ToLong3(Int48 x, Int48 y, Int48 z)
        {
            long3 masked = new long3(*(long*)&x, *(long*)&y, *(long*)&z);

            return maxmath.signextend(masked, 48);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 ToLong4(Int48 x, Int48 y, Int48 z, Int48 w)
        {
            long4 masked = new long4(*(long*)&x, *(long*)&y, *(long*)&z, *(long*)&w);

            return maxmath.signextend(masked, 48);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long2(Int48 input)
        {
            return maxmath.signextend(new long2(*(long*)&input), 48);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long3(Int48 input)
        {
            return maxmath.signextend(new long3(*(long*)&input), 48);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long4(Int48 input)
        {
            return maxmath.signextend(new long4(*(long*)&input), 48);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int48(UInt48 input)
        {
            return *(Int48*)&input;
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int48(sbyte input)
        {
            long cast = input;

            return *(Int48*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int48(byte input)
        {
            long cast = input;

            return *(Int48*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int48(short input)
        {
            long cast = input;

            return *(Int48*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int48(ushort input)
        {
            long cast = input;

            return *(Int48*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int48(Int24 input)
        {
            long cast = input;

            return *(Int48*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int48(UInt24 input)
        {
            ulong cast = input;

            return *(Int48*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int48(int input)
        {
            long cast = input;

            return *(Int48*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int48(uint input)
        {
            ulong cast = input;

            return *(Int48*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int48(Int40 input)
        {
            long cast = input;

            return *(Int48*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int48(UInt40 input)
        {
            ulong cast = input;

            return *(Int48*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int48(long input)
        {
            return *(Int48*)&input;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int48(ulong input)
        {
            return *(Int48*)&input;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int48(quarter input)
        {
            return (Int48)((float)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int48(half input)
        {
            return (Int48)((long)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int48(float input)
        {
            return (Int48)((long)input);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int48(double input)
        {
            return (Int48)((long)input);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int48(decimal input)
        {
            return (Int48)((long)input);
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte(Int48 input)
        {
            return (sbyte)input.byte0_byte1;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte(Int48 input)
        {
            return (byte)input.byte0_byte1;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short(Int48 input)
        {
            return (short)input.byte0_byte1;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort(Int48 input)
        {
            return input.byte0_byte1;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int24(Int48 input)
        {
            return *(Int24*)&input;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt24(Int48 input)
        {
            return *(UInt24*)&input;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int(Int48 input)
        {
            return *(int*)&input;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint(Int48 input)
        {
            return *(uint*)&input;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int40(Int48 input)
        {
            return *(Int40*)&input;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt40(Int48 input)
        {
            return *(UInt40*)&input;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long(Int48 input)
        {
            return maxmath.signextend(*(long*)&input, 48);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong(Int48 input)
        {
            return (ulong)maxmath.signextend(*(long*)&input, 48);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter(Int48 input)
        {
            return (quarter)((long)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half(Int48 input)
        {
            return (half)((long)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(Int48 input)
        {
            return (float)((long)input);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(Int48 input)
        {
            return (double)((long)input);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(Int48 input)
        {
            return (decimal)((long)input);
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator + (Int48 left, Int48 right)
        {
            return (Int48)(*(long*)&left + *(long*)&right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator + (Int48 left, int right)
        {
            return (Int48)(*(long*)&left + right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator + (int left, Int48 right)
        {
            return (Int48)(left + *(long*)&right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator + (Int48 left, long right)
        {
            return (Int48)(*(long*)&left + right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator + (long left, Int48 right)
        {
            return (Int48)(left + *(long*)&right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator - (Int48 left, Int48 right)
        {
            return (Int48)(*(long*)&left - *(long*)&right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator - (Int48 left, int right)
        {
            return (Int48)(*(long*)&left - right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator - (int left, Int48 right)
        {
            return (Int48)(left - *(long*)&right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator - (Int48 left, long right)
        {
            return (Int48)(*(long*)&left - right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator - (long left, Int48 right)
        {
            return (Int48)(left - *(long*)&right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator * (Int48 left, Int48 right)
        {
            return (Int48)(*(long*)&left * *(long*)&right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator * (Int48 left, int right)
        {
            return (Int48)(*(long*)&left * right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator * (int left, Int48 right)
        {
            return (Int48)(left * *(long*)&right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator * (Int48 left, long right)
        {
            return (Int48)(*(long*)&left * right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator * (long left, Int48 right)
        {
            return (Int48)(left * *(long*)&right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator / (Int48 left, Int48 right)
        {
            return (Int48)((long)left / (long)right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator / (Int48 left, int right)
        {
            return (Int48)((long)left / right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator / (int left, Int48 right)
        {
            return (Int48)(left / (long)right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator / (Int48 left, long right)
        {
            return (Int48)((long)left / right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator / (long left, Int48 right)
        {
            return (Int48)(left / (long)right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator % (Int48 left, Int48 right)
        {
            return (Int48)((long)left % (long)right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator % (Int48 left, int right)
        {
            return (Int48)((long)left % right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator % (int left, Int48 right)
        {
            return (Int48)(left % (long)right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator % (Int48 left, long right)
        {
            return (Int48)((long)left % right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator % (long left, Int48 right)
        {
            return (Int48)(left % (long)right);
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator & (Int48 left, Int48 right)
        {
            return (Int48)(*(long*)&left & *(long*)&right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator & (Int48 left, int right)
        {
            return (Int48)(*(long*)&left & right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator & (int left, Int48 right)
        {
            return (Int48)(left & *(long*)&right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator & (Int48 left, long right)
        {
            return (Int48)(*(long*)&left & right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator & (long left, Int48 right)
        {
            return (Int48)(left & *(long*)&right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator | (Int48 left, Int48 right)
        {
            return (Int48)(*(long*)&left | *(long*)&right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator | (Int48 left, int right)
        {
            return (Int48)(*(long*)&left | (long)right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator | (int left, Int48 right)
        {
            return (Int48)((long)left | *(long*)&right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator | (Int48 left, long right)
        {
            return (Int48)(*(long*)&left | right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator | (long left, Int48 right)
        {
            return (Int48)(left | *(long*)&right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator ^ (Int48 left, Int48 right)
        {
            return (Int48)(*(long*)&left ^ *(long*)&right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator ^ (Int48 left, int right)
        {
            return (Int48)(*(long*)&left ^ right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator ^ (int left, Int48 right)
        {
            return (Int48)(left ^ *(long*)&right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator ^ (Int48 left, long right)
        {
            return (Int48)(*(long*)&left ^ right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator ^ (long left, Int48 right)
        {
            return (Int48)(left ^ *(long*)&right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator << (Int48 left, int right)
        {
            return (Int48)(*(long*)&left << right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int48 operator >> (Int48 left, int right)
        {
            // sign extend

            return (Int48)((*(long*)&left << 24) >> (24 + right));
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator == (Int48 left, Int48 right)
        {
            return (long)left == (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator == (Int48 left, int right)
        {
            return (long)left == right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator == (int left, Int48 right)
        {
            return left == (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator == (Int48 left, long right)
        {
            return (long)left == right;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator == (long left, Int48 right)
        {
            return left == (long)right;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator != (Int48 left, Int48 right)
        {
            return (long)left != (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator != (Int48 left, int right)
        {
            return (long)left != right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator != (int left, Int48 right)
        {
            return left != (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator != (Int48 left, long right)
        {
            return (long)left != right;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator != (long left, Int48 right)
        {
            return left != (long)right;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator < (Int48 left, Int48 right)
        {
            return (long)left < (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator < (Int48 left, int right)
        {
            return (long)left < right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator < (int left, Int48 right)
        {
            return left < (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator < (Int48 left, long right)
        {
            return (long)left < right;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator < (long left, Int48 right)
        {
            return left < (long)right;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator > (Int48 left, Int48 right)
        {
            return (long)left > (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator > (Int48 left, int right)
        {
            return (long)left > right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator > (int left, Int48 right)
        {
            return left > (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator > (Int48 left, long right)
        {
            return (long)left > right;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator > (long left, Int48 right)
        {
            return left > (long)right;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <= (Int48 left, Int48 right)
        {
            return (long)left <= (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <= (Int48 left, int right)
        {
            return (long)left <= right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <= (int left, Int48 right)
        {
            return left <= (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <= (Int48 left, long right)
        {
            return (long)left <= right;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <= (long left, Int48 right)
        {
            return left <= (long)right;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >= (Int48 left, Int48 right)
        {
            return (long)left >= (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >= (Int48 left, int right)
        {
            return (long)left >= right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >= (int left, Int48 right)
        {
            return left >= (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >= (Int48 left, long right)
        {
            return (long)left >= right;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >= (long left, Int48 right)
        {
            return left >= (long)right;
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return ((long)this).GetHashCode();
        }
        public TypeCode GetTypeCode()
        {
            return TypeCode.Int64;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Int48 other)
        {
            return this == other;
        }
        public override bool Equals(object obj)
        {
            return Equals((Int48)obj);
        }
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int CompareTo(Int48 other)
        {
            return maxmath.compareto((long)this, (long)other);
        }
        public int CompareTo(object obj)
        {
            return CompareTo((Int48)obj);
        }
    

        public static Int48 Parse(string s)
        {
            return (Int48)long.Parse(s);
        }
        public static Int48 Parse(string s, NumberStyles style)
        {
            return (Int48)long.Parse(s, style);
        }
        public static Int48 Parse(string s, IFormatProvider provider)
        {
            return (Int48)long.Parse(s, provider);
        }
        public static Int48 Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            return (Int48)long.Parse(s, style, provider);
        }
        public static bool TryParse(string s, out Int48 result)
        {
            bool success = long.TryParse(s, out long Int);

            result = (Int48)Int;

            return (success & (Int <= MaxValue)) & (Int >= MinValue);
        }
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out Int48 result)
        {
            bool success = long.TryParse(s, style, provider, out long Int);

            result = (Int48)Int;

            return (success & (Int <= MaxValue)) & (Int >= MinValue);
        }
    
        public override string ToString()
        {
            return ((long)this).ToString();
        }
        public string ToString(string format)
        {
            return ((long)this).ToString(format);
        }
        public string ToString(IFormatProvider provider)
        {
            return ((long)this).ToString(provider);
        }
        public string ToString(string format, IFormatProvider provider)
        {
            return ((long)this).ToString(format, provider);
        }
    
        public bool ToBoolean(IFormatProvider provider)
        {
            return Convert.ToBoolean((long)this, provider);
        }
        public byte ToByte(IFormatProvider provider)
        {
            return Convert.ToByte((long)this, provider);
        }
        public char ToChar(IFormatProvider provider)
        {
            return Convert.ToChar((long)this, provider);
        }
        public DateTime ToDateTime(IFormatProvider provider)
        {
            return Convert.ToDateTime((long)this, provider);
        }
        public decimal ToDecimal(IFormatProvider provider)
        {
            return Convert.ToDecimal((long)this, provider);
        }
        public double ToDouble(IFormatProvider provider)
        {
            return Convert.ToDouble((long)this, provider);
        }
        public short ToInt16(IFormatProvider provider)
        {
            return Convert.ToInt16((long)this, provider);
        }
        public int ToInt32(IFormatProvider provider)
        {
            return Convert.ToInt32((long)this, provider);
        }
        public long ToInt64(IFormatProvider provider)
        {
            return Convert.ToInt64((long)this, provider);
        }
        public sbyte ToSByte(IFormatProvider provider)
        {
            return Convert.ToSByte((long)this, provider);
        }
        public float ToSingle(IFormatProvider provider)
        {
            return Convert.ToSingle((long)this, provider);
        }
        public object ToType(Type conversionType, IFormatProvider provider)
        {
            return Convert.ChangeType((long)this, conversionType, provider);
        }
        public ushort ToUInt16(IFormatProvider provider)
        {
            return Convert.ToUInt16((long)this, provider);
        }
        public uint ToUInt32(IFormatProvider provider)
        {
            return Convert.ToUInt32((long)this, provider);
        }
        public ulong ToUInt64(IFormatProvider provider)
        {
            return Convert.ToUInt64((long)this, provider);
        }
    }
}