using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using MaxMath;
using System.Resources;

namespace BitCollections
{
    [Serializable]  [StructLayout(LayoutKind.Sequential, Size = 5)]
    unsafe public readonly struct UInt40 : IComparable, IComparable<UInt40>, IConvertible, IEquatable<UInt40>, IFormattable
    {
        public const ulong MinValue = 0;
        public const ulong MaxValue = 1_099_511_627_775;
    
    
        internal readonly byte byte0;
        internal readonly byte byte1;
        internal readonly byte byte2;
        internal readonly byte byte3;
        internal readonly byte byte4;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong2(UInt40 input)
        {
            return new ulong2(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong3(UInt40 input)
        {
            return new ulong3(input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong4(UInt40 input)
        {
            return new ulong4(input);
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
            ulong cast = (ulong)input;

            return *(UInt40*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt40(UInt24 input)
        {
            ulong cast = input;

            return *(UInt40*)&cast;
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
        public static explicit operator UInt40(quarter input)
        {
            return (UInt40)((float)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt40(half input)
        {
            return (UInt40)((ulong)input);
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
            return (long)(ulong)input;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong(UInt40 input)
        {
            ulong lo = *(uint*)&input;
            lo |= ((ulong)input.byte4 << 32);

            return lo;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter(UInt40 input)
        {
            return (quarter)((long)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half(UInt40 input)
        {
            return (half)((long)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(UInt40 input)
        {
            return (float)((long)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(UInt40 input)
        {
            return (double)((long)input);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(UInt40 input)
        {
            return (decimal)((long)input);
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
        public override int GetHashCode()
        {
            return ((ulong)this).GetHashCode();
        }
        public TypeCode GetTypeCode()
        {
            return TypeCode.UInt64;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(UInt40 other)
        {
            return this == other;
        }
        public override bool Equals(object obj)
        {
            return Equals((UInt40)obj);
        }
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int CompareTo(UInt40 other)
        {
            return maxmath.compareto((ulong)this, (ulong)other);
        }
        public int CompareTo(object obj)
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
    
        public override string ToString()
        {
            return ((ulong)this).ToString();
        }
        public string ToString(string format)
        {
            return ((ulong)this).ToString(format);
        }
        public string ToString(IFormatProvider provider)
        {
            return ((ulong)this).ToString(provider);
        }
        public string ToString(string format, IFormatProvider provider)
        {
            return ((ulong)this).ToString(format, provider);
        }

        public bool ToBoolean(IFormatProvider provider)
        {
            return Convert.ToBoolean((ulong)this, provider);
        }
        public byte ToByte(IFormatProvider provider)
        {
            return Convert.ToByte((byte)this, provider);
        }
        public char ToChar(IFormatProvider provider)
        {
            return Convert.ToChar((ulong)this, provider);
        }
        public DateTime ToDateTime(IFormatProvider provider)
        {
            return Convert.ToDateTime((ulong)this, provider);
        }
        public decimal ToDecimal(IFormatProvider provider)
        {
            return Convert.ToDecimal((ulong)this, provider);
        }
        public double ToDouble(IFormatProvider provider)
        {
            return Convert.ToDouble((ulong)this, provider);
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
            return Convert.ToInt64((ulong)this, provider);
        }
        public sbyte ToSByte(IFormatProvider provider)
        {
            return Convert.ToSByte((sbyte)this, provider);
        }
        public float ToSingle(IFormatProvider provider)
        {
            return Convert.ToSingle((ulong)this, provider);
        }
        public object ToType(Type conversionType, IFormatProvider provider)
        {
            return Convert.ChangeType((ulong)this, conversionType, provider);
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
            return Convert.ToUInt64((ulong)this, provider);
        }
    }
}