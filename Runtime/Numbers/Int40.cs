using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using MaxMath;

namespace BitCollections
{
    [Serializable]  [StructLayout(LayoutKind.Sequential, Size = 5)]
    unsafe public readonly struct Int40 : IComparable, IComparable<Int40>, IConvertible, IEquatable<Int40>, IFormattable
    {
        public const long MinValue = -549_755_813_888;
        public const long MaxValue = 549_755_813_887;
    
    
        private readonly byte byte0;
        private readonly byte byte1;
        private readonly byte byte2;
        private readonly byte byte3;
        private readonly byte byte4;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static long ToFakeLong(Int40 x)
        {
            long lo = *(uint*)&x;
            lo |= ((long)x.byte4 << 32);

            return lo;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long2(Int40 input)
        {
            return new long2(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long3(Int40 input)
        {
            return new long3(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long4(Int40 input)
        {
            return new long4(input);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int40(UInt40 input)
        {
            return *(Int40*)&input;
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int40(sbyte input)
        {
            long cast = input;

            return *(Int40*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int40(byte input)
        {
            long cast = input;

            return *(Int40*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int40(short input)
        {
            long cast = input;

            return *(Int40*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int40(ushort input)
        {
            ulong cast = input;

            return *(Int40*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int40(Int24 input)
        {
            long cast = input;

            return *(Int40*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int40(UInt24 input)
        {
            ulong cast = input;

            return *(Int40*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int40(int input)
        {
            long cast = input;

            return *(Int40*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int40(uint input)
        {
            ulong cast = input;

            return *(Int40*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int40(long input)
        {
            return *(Int40*)&input;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int40(ulong input)
        {
            return *(Int40*)&input;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int40(quarter input)
        {
            return (Int40)((float)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int40(half input)
        {
            return (Int40)((long)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int40(float input)
        {
            return (Int40)((long)input);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int40(double input)
        {
            return (Int40)((long)input);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int40(decimal input)
        {
            return (Int40)((long)input);
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte(Int40 input)
        {
            return (sbyte)input.byte0;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte(Int40 input)
        {
            return input.byte0;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short(Int40 input)
        {
            return *(short*)&input;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort(Int40 input)
        {
            return *(ushort*)&input;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int24(Int40 input)
        {
            return *(Int24*)&input;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt24(Int40 input)
        {
            return *(UInt24*)&input;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int(Int40 input)
        {
            return *(int*)&input;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint(Int40 input)
        {
            return *(uint*)&input;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long(Int40 input)
        {

            long lo = *(uint*)&input;
            lo |= ((long)input.byte4 << 56) >> 24;

            return lo;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong(Int40 input)
        {
            return (ulong)(long)input;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter(Int40 input)
        {
            return (quarter)((long)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half(Int40 input)
        {
            return (half)((long)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(Int40 input)
        {
            return (float)((long)input);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(Int40 input)
        {
            return (double)((long)input);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(Int40 input)
        {
            return (decimal)((long)input);
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator - (Int40 value)
        {
            return -(ToFakeLong(value));
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator ~ (Int40 value)
        {
            return ~(ToFakeLong(value));
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int40 operator ++ (Int40 value)
        {
            long cast = ToFakeLong(value);

            return (Int40)(++cast);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int40 operator -- (Int40 value)
        {
            long cast = ToFakeLong(value);

            return (Int40)(--cast);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator + (Int40 left, Int40 right)
        {
            return ToFakeLong(left) + ToFakeLong(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator + (Int40 left, int right)
        {
            return ToFakeLong(left) + right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator + (int left, Int40 right)
        {
            return left + ToFakeLong(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator + (Int40 left, long right)
        {
            return ToFakeLong(left) + right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator + (long left, Int40 right)
        {
            return left + ToFakeLong(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator - (Int40 left, Int40 right)
        {
            return ToFakeLong(left) - ToFakeLong(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator - (Int40 left, int right)
        {
            return ToFakeLong(left) - right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator - (int left, Int40 right)
        {
            return left - ToFakeLong(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator - (Int40 left, long right)
        {
            return ToFakeLong(left) - right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator - (long left, Int40 right)
        {
            return left - ToFakeLong(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator * (Int40 left, Int40 right)
        {
            return ToFakeLong(left) * ToFakeLong(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator * (Int40 left, int right)
        {
            return ToFakeLong(left) * right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator * (int left, Int40 right)
        {
            return left * ToFakeLong(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator * (Int40 left, long right)
        {
            return ToFakeLong(left) * right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator * (long left, Int40 right)
        {
            return left * ToFakeLong(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator / (Int40 left, Int40 right)
        {
            return (long)left / (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator / (Int40 left, int right)
        {
            return (long)left / right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator / (int left, Int40 right)
        {
            return left / (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator / (Int40 left, long right)
        {
            return (long)left / right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator / (long left, Int40 right)
        {
            return left / (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator % (Int40 left, Int40 right)
        {
            return (long)left % (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator % (Int40 left, int right)
        {
            return (long)left % right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator % (int left, Int40 right)
        {
            return left % (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator % (Int40 left, long right)
        {
            return (long)left % right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator % (long left, Int40 right)
        {
            return left % (long)right;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator & (Int40 left, Int40 right)
        {
            return ToFakeLong(left) & ToFakeLong(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator & (Int40 left, int right)
        {
            return ToFakeLong(left) & right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator & (int left, Int40 right)
        {
            return left & ToFakeLong(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator & (Int40 left, long right)
        {
            return ToFakeLong(left) & right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator & (long left, Int40 right)
        {
            return left & ToFakeLong(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator | (Int40 left, Int40 right)
        {
            return ToFakeLong(left) | ToFakeLong(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator | (Int40 left, int right)
        {
            return ToFakeLong(left) | (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator | (int left, Int40 right)
        {
            return (long)left | ToFakeLong(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator | (Int40 left, long right)
        {
            return ToFakeLong(left) | right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator | (long left, Int40 right)
        {
            return left | ToFakeLong(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator ^ (Int40 left, Int40 right)
        {
            return ToFakeLong(left) ^ ToFakeLong(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator ^ (Int40 left, int right)
        {
            return ToFakeLong(left) ^ right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator ^ (int left, Int40 right)
        {
            return left ^ ToFakeLong(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator ^ (Int40 left, long right)
        {
            return ToFakeLong(left) ^ right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator ^ (long left, Int40 right)
        {
            return left ^ ToFakeLong(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator << (Int40 left, int right)
        {
            return ToFakeLong(left) << right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long operator >> (Int40 left, int right)
        {
            return (long)left >> right;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator == (Int40 left, Int40 right)
        {
            return (long)left == (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator == (Int40 left, int right)
        {
            return (long)left == right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator == (int left, Int40 right)
        {
            return left == (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator == (Int40 left, long right)
        {
            return (long)left == right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator == (long left, Int40 right)
        {
            return left == (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator != (Int40 left, Int40 right)
        {
            return (long)left != (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator != (Int40 left, int right)
        {
            return (long)left != right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator != (int left, Int40 right)
        {
            return left != (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator != (Int40 left, long right)
        {
            return (long)left != right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator != (long left, Int40 right)
        {
            return left != (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator < (Int40 left, Int40 right)
        {
            return (long)left < (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator < (Int40 left, int right)
        {
            return (long)left < right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator < (int left, Int40 right)
        {
            return left < (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator < (Int40 left, long right)
        {
            return (long)left < right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator < (long left, Int40 right)
        {
            return left < (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator > (Int40 left, Int40 right)
        {
            return (long)left > (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator > (Int40 left, int right)
        {
            return (long)left > right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator > (int left, Int40 right)
        {
            return left > (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator > (Int40 left, long right)
        {
            return (long)left > right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator > (long left, Int40 right)
        {
            return left > (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <= (Int40 left, Int40 right)
        {
            return (long)left <= (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <= (Int40 left, int right)
        {
            return (long)left <= right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <= (int left, Int40 right)
        {
            return left <= (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <= (Int40 left, long right)
        {
            return (long)left <= right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <= (long left, Int40 right)
        {
            return left <= (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >= (Int40 left, Int40 right)
        {
            return (long)left >= (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >= (Int40 left, int right)
        {
            return (long)left >= right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >= (int left, Int40 right)
        {
            return left >= (long)right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >= (Int40 left, long right)
        {
            return (long)left >= right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >= (long left, Int40 right)
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
        public bool Equals(Int40 other)
        {
            return this == other;
        }
        public override bool Equals(object obj)
        {
            return Equals((Int40)obj);
        }
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int CompareTo(Int40 other)
        {
            return maxmath.compareto((long)this, (long)other);
        }
        public int CompareTo(object obj)
        {
            return CompareTo((Int40)obj);
        }
    

        public static Int40 Parse(string s)
        {
            return (Int40)long.Parse(s);
        }
        public static Int40 Parse(string s, NumberStyles style)
        {
            return (Int40)long.Parse(s, style);
        }
        public static Int40 Parse(string s, IFormatProvider provider)
        {
            return (Int40)long.Parse(s, provider);
        }
        public static Int40 Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            return (Int40)long.Parse(s, style, provider);
        }
        public static bool TryParse(string s, out Int40 result)
        {
            bool success = long.TryParse(s, out long Int);

            result = (Int40)Int;

            return (success & (Int <= MaxValue)) & (Int >= MinValue);
        }
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out Int40 result)
        {
            bool success = long.TryParse(s, style, provider, out long Int);

            result = (Int40)Int;

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