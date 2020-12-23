using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using MaxMath;

namespace BitCollections
{
    [Serializable]  [StructLayout(LayoutKind.Sequential, Size = 6)]
    unsafe public struct UInt48 : IComparable, IComparable<UInt48>, IConvertible, IEquatable<UInt48>, IFormattable
    {
        public const ulong MinValue = 0;
        public const ulong MaxValue = 281_474_976_710_655;
    
    
        private byte byte0;
        private byte byte1;
        private byte byte2;
        private byte byte3;
        private byte byte4;
        private byte byte5;
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 ToULong2(UInt48 x, UInt48 y)
        {
            return new ulong2(*(ulong*)&x, *(ulong*)&y) & MaxValue;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 ToULong3(UInt48 x, UInt48 y, UInt48 z)
        {
            return new ulong3(*(ulong*)&x, *(ulong*)&y, *(ulong*)&z) & MaxValue;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 ToULong4(UInt48 x, UInt48 y, UInt48 z, UInt48 w)
        {
            return new ulong4(*(ulong*)&x, *(ulong*)&y, *(ulong*)&z, *(ulong*)&w) & MaxValue;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong2(UInt48 input)
        {
            return new ulong2(*(ulong*)&input) & MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong3(UInt48 input)
        {
            return new ulong3(*(ulong*)&input) & MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong4(UInt48 input)
        {
            return new ulong4(*(ulong*)&input) & MaxValue;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt48(Int48 input)
        {
            return *(UInt48*)&input;
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt48(sbyte input)
        {
            ulong cast = (ulong)input;

            return *(UInt48*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt48(byte input)
        {
            ulong cast = input;

            return *(UInt48*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt48(short input)
        {
            ulong cast = (ulong)input;

            return *(UInt48*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt48(ushort input)
        {
            ulong cast = input;

            return *(UInt48*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt48(Int24 input)
        {
            ulong cast = (ulong)input;

            return *(UInt48*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt48(UInt24 input)
        {
            ulong cast = input;

            return *(UInt48*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt48(int input)
        {
            ulong cast = (ulong)input;

            return *(UInt48*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt48(uint input)
        {
            ulong cast = input;

            return *(UInt48*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt48(Int40 input)
        {
            ulong cast = (ulong)input;

            return *(UInt48*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt48(UInt40 input)
        {
            ulong cast = input;

            return *(UInt48*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt48(long input)
        {
            return *(UInt48*)&input;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt48(ulong input)
        {
            return *(UInt48*)&input;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt48(half input)
        {
            return (UInt48)((ulong)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt48(float input)
        {
            return (UInt48)((ulong)input);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt48(double input)
        {
            return (UInt48)((ulong)input);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt48(decimal input)
        {
            return (UInt48)((ulong)input);
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte(UInt48 input)
        {
            return (sbyte)input.byte0;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte(UInt48 input)
        {
            return input.byte0;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short(UInt48 input)
        {
            return *(short*)&input;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort(UInt48 input)
        {
            return *(ushort*)&input;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int24(UInt48 input)
        {
            return *(Int24*)&input;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt24(UInt48 input)
        {
            return *(UInt24*)&input;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int(UInt48 input)
        {
            return *(int*)&input;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint(UInt48 input)
        {
            return *(uint*)&input;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int40(UInt48 input)
        {
            return *(Int40*)&input;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt40(UInt48 input)
        {
            return *(UInt40*)&input;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long(UInt48 input)
        {
            return (long)MaxValue & *(long*)&input;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong(UInt48 input)
        {
            return MaxValue & *(ulong*)&input;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half(UInt48 input)
        {
            return (half)((long)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(UInt48 input)
        {
            return (float)((long)input);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(UInt48 input)
        {
            return (double)((long)input);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(UInt48 input)
        {
            return (decimal)((long)input);
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt48 operator +(UInt48 value)
        {
            return (UInt48)(+(*(ulong*)&value));
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt48 operator ~(UInt48 value)
        {
            return (UInt48)(~(*(ulong*)&value));
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt48 operator ++(UInt48 value)
        {
            return (UInt48)(++(*(ulong*)&value));
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt48 operator --(UInt48 value)
        {
            return (UInt48)(--(*(ulong*)&value));
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt48 operator +(UInt48 lhs, UInt48 rhs)
        {
            return (UInt48)(*(ulong*)&lhs + *(ulong*)&rhs);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt48 operator +(UInt48 lhs, ulong rhs)
        {
            return (UInt48)(*(ulong*)&lhs + rhs);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt48 operator +(ulong lhs, UInt48 rhs)
        {
            return (UInt48)(lhs + *(ulong*)&rhs);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt48 operator -(UInt48 lhs, UInt48 rhs)
        {
            return (UInt48)(*(ulong*)&lhs - *(ulong*)&rhs);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt48 operator -(UInt48 lhs, ulong rhs)
        {
            return (UInt48)(*(ulong*)&lhs - rhs);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt48 operator -(ulong lhs, UInt48 rhs)
        {
            return (UInt48)(lhs - *(ulong*)&rhs);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt48 operator * (UInt48 lhs, UInt48 rhs)
        {
            return (UInt48)(*(ulong*)&lhs * *(ulong*)&rhs);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt48 operator * (UInt48 lhs, ulong rhs)
        {
            return (UInt48)(*(ulong*)&lhs * rhs);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt48 operator * (ulong lhs, UInt48 rhs)
        {
            return (UInt48)(lhs * *(ulong*)&rhs);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt48 operator /(UInt48 lhs, UInt48 rhs)
        {
            return (UInt40)((long)lhs % (long)rhs);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt48 operator /(UInt48 lhs, ulong rhs)
        {
            return (UInt48)((ulong)lhs / rhs);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt48 operator /(ulong lhs, UInt48 rhs)
        {
            return (UInt48)(lhs / (ulong)rhs);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt48 operator %(UInt48 lhs, UInt48 rhs)
        {
            return (UInt48)((ulong)lhs % (ulong)rhs);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt48 operator %(UInt48 lhs, ulong rhs)
        {
            return (UInt48)((ulong)lhs % rhs);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt48 operator %(ulong lhs, UInt48 rhs)
        {
            return (UInt48)(lhs % (ulong)rhs);
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt48 operator &(UInt48 lhs, UInt48 rhs)
        {
            return (UInt48)(*(ulong*)&lhs & *(ulong*)&rhs);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt48 operator &(UInt48 lhs, ulong rhs)
        {
            return (UInt48)(*(ulong*)&lhs & rhs);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt48 operator &(ulong lhs, UInt48 rhs)
        {
            return (UInt48)(lhs & *(ulong*)&rhs);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt48 operator |(UInt48 lhs, UInt48 rhs)
        {
            return (UInt48)(*(ulong*)&lhs | *(ulong*)&rhs);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt48 operator |(UInt48 lhs, ulong rhs)
        {
            return (UInt48)(*(ulong*)&lhs | rhs);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt48 operator |(ulong lhs, UInt48 rhs)
        {
            return (UInt48)(lhs | *(ulong*)&rhs);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt48 operator ^(UInt48 lhs, UInt48 rhs)
        {
            return (UInt48)(*(ulong*)&lhs ^ *(ulong*)&rhs);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt48 operator ^(UInt48 lhs, ulong rhs)
        {
            return (UInt48)(*(ulong*)&lhs ^ rhs);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt48 operator ^(ulong lhs, UInt48 rhs)
        {
            return (UInt48)(lhs ^ *(ulong*)&rhs);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt48 operator <<(UInt48 lhs, int rhs)
        {
            return (UInt48)(*(ulong*)&lhs << rhs);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt48 operator >>(UInt48 lhs, int rhs)
        {
            return (UInt48)((ulong)lhs >> rhs);
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(UInt48 lhs, UInt48 rhs)
        {
            return (ulong)lhs == (ulong)rhs;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(UInt48 lhs, ulong rhs)
        {
            return (ulong)lhs == rhs;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(ulong lhs, UInt48 rhs)
        {
            return lhs == (ulong)rhs;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(UInt48 lhs, UInt48 rhs)
        {
            return (ulong)lhs != (ulong)rhs;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(UInt48 lhs, ulong rhs)
        {
            return (ulong)lhs != rhs;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(ulong lhs, UInt48 rhs)
        {
            return lhs != (ulong)rhs;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <(UInt48 lhs, UInt48 rhs)
        {
            return (ulong)lhs < (ulong)rhs;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <(UInt48 lhs, ulong rhs)
        {
            return (ulong)lhs < rhs;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <(ulong lhs, UInt48 rhs)
        {
            return lhs < (ulong)rhs;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >(UInt48 lhs, UInt48 rhs)
        {
            return (ulong)lhs > (ulong)rhs;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >(UInt48 lhs, ulong rhs)
        {
            return (ulong)lhs > rhs;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >(ulong lhs, UInt48 rhs)
        {
            return lhs > (ulong)rhs;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <=(UInt48 lhs, UInt48 rhs)
        {
            return (ulong)lhs <= (ulong)rhs;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <=(UInt48 lhs, ulong rhs)
        {
            return (ulong)lhs <= rhs;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <=(ulong lhs, UInt48 rhs)
        {
            return lhs <= (ulong)rhs;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >=(UInt48 lhs, UInt48 rhs)
        {
            return (ulong)lhs >= (ulong)rhs;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >=(UInt48 lhs, ulong rhs)
        {
            return (ulong)lhs >= rhs;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >=(ulong lhs, UInt48 rhs)
        {
            return lhs >= (ulong)rhs;
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
            return ((ulong)this).GetHashCode();
        }
        public TypeCode GetTypeCode()
        {
            return TypeCode.UInt64;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(UInt48 other)
        {
            return this == other;
        }
        public override readonly bool Equals(object obj)
        {
            return Equals((UInt48)obj);
        }
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int CompareTo(UInt48 other)
        {
            ulong cmp = this - other;

            return (int)((((long)cmp) >> 63) | maxmath.touint8(cmp != 0));
        }
        public int CompareTo(object obj)
        {
            return CompareTo((UInt48)obj);
        }

    
        public static UInt48 Parse(string s)
        {
            return (UInt48)ulong.Parse(s);
        }
        public static UInt48 Parse(string s, NumberStyles style)
        {
            return (UInt48)ulong.Parse(s, style);
        }
        public static UInt48 Parse(string s, IFormatProvider provider)
        {
            return (UInt48)ulong.Parse(s, provider);
        }
        public static UInt48 Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            return (UInt48)ulong.Parse(s, style, provider);
        }
        public static bool TryParse(string s, out UInt48 result)
        {
            bool success = ulong.TryParse(s, out ulong Int);

            result = (UInt48)Int;

            return success & (Int <= MaxValue);
        }
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out UInt48 result)
        {
            bool success = ulong.TryParse(s, style, provider, out ulong Int);

            result = (UInt48)Int;

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
            return Convert.ToByte((ulong)this, provider);
        }
        public char ToChar(IFormatProvider provider)
        {
            return Convert.ToChar((ulong)this, provider);
        }
        public System.DateTime ToDateTime(IFormatProvider provider)
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
            return Convert.ToInt16((ulong)this, provider);
        }
        public int ToInt32(IFormatProvider provider)
        {
            return Convert.ToInt32((ulong)this, provider);
        }
        public long ToInt64(IFormatProvider provider)
        {
            return Convert.ToInt64((ulong)this, provider);
        }
        public sbyte ToSByte(IFormatProvider provider)
        {
            return Convert.ToSByte((ulong)this, provider);
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
            return Convert.ToUInt16((ulong)this, provider);
        }
        public uint ToUInt32(IFormatProvider provider)
        {
            return Convert.ToUInt32((ulong)this, provider);
        }
        public ulong ToUInt64(IFormatProvider provider)
        {
            return Convert.ToUInt64((ulong)this, provider);
        }
    }
}