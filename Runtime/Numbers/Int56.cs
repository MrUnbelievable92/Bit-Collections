﻿using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using MaxMath;

namespace BitCollections
{ 
    [Serializable]  [StructLayout(LayoutKind.Sequential, Size = 7)]
    unsafe public readonly struct Int56 : IComparable, IComparable<Int56>, IConvertible, IEquatable<Int56>, IFormattable
    {
        public const long MinValue = -36_028_797_018_963_968;
        public const long MaxValue = 36_028_797_018_963_967;
    
    
        internal readonly byte byte0;
        internal readonly byte byte1;
        internal readonly byte byte2;
        internal readonly byte byte3;
        internal readonly byte byte4;
        internal readonly byte byte5;
        internal readonly byte byte6;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static long ToFakeLong(Int56 x)
        {
            long lo = *(uint*)&x;
            lo |= ((long)(*(ushort*)&x.byte4)) << 32;
            lo |= (long)x.byte6 << 48;

            return lo;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long2(Int56 input)
        {
            return new long2(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long3(Int56 input)
        {
            return new long3(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long4(Int56 input)
        {
            return new long4(input);
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
            long cast = input;

            return *(Int56*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int56(UInt24 input)
        {
            ulong cast = input;

            return *(Int56*)&cast;
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
            long cast = input;

            return *(Int56*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int56(UInt40 input)
        {
            ulong cast = input;

            return *(Int56*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int56(Int48 input)
        {
            long cast = input;

            return *(Int56*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int56(UInt48 input)
        {
            ulong cast = input;

            return *(Int56*)&cast;
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
        public static explicit operator Int56(quarter input)
        {
            return (Int56)((float)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int56(half input)
        {
            return (Int56)((long)input);
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
            long lo = *(uint*)&input;
            lo |= ((long)(*(ushort*)&input.byte4)) << 32;
            // sign extension
            lo |= ((long)input.byte6 << 56) >> 8;

            return lo;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong(Int56 input)
        {
            return (ulong)(long)input;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter(Int56 input)
        {
            return (quarter)((long)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half(Int56 input)
        {
            return (half)((long)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(Int56 input)
        {
            return (float)((long)input);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(Int56 input)
        {
            return (double)((long)input);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(Int56 input)
        {
            return (decimal)((long)input);
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
        public override int GetHashCode()
        {
            return ((long)this).GetHashCode();
        }
        public TypeCode GetTypeCode()
        {
            return TypeCode.Int64;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Int56 other)
        {
            return this == other;
        }
        public override bool Equals(object obj)
        {
            return Equals((Int56)obj);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int CompareTo(Int56 other)
        {
            return maxmath.compareto((long)this, (long)other);
        }
        public int CompareTo(object obj)
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

            return success & maxmath.isinrange(Int, MinValue, MaxValue);
        }
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out Int56 result)
        {
            bool success = long.TryParse(s, style, provider, out long Int);

            result = (Int56)Int;

            return success & maxmath.isinrange(Int, MinValue, MaxValue);
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
            return Convert.ToByte((byte)this, provider);
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
            return Convert.ToInt16((short)this, provider);
        }
        public int ToInt32(IFormatProvider provider)
        {
            return Convert.ToInt32((int)this, provider);
        }
        public long ToInt64(IFormatProvider provider)
        {
            return Convert.ToInt64((long)this, provider);
        }
        public sbyte ToSByte(IFormatProvider provider)
        {
            return Convert.ToSByte((sbyte)this, provider);
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
            return Convert.ToUInt16((ushort)this, provider);
        }
        public uint ToUInt32(IFormatProvider provider)
        {
            return Convert.ToUInt32((uint)this, provider);
        }
        public ulong ToUInt64(IFormatProvider provider)
        {
            return Convert.ToUInt64((long)this, provider);
        }
    }
}