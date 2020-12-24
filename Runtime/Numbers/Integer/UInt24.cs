using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using MaxMath;

namespace BitCollections
{
    [Serializable]  [StructLayout(LayoutKind.Sequential, Size = 3)]
    unsafe public readonly struct UInt24 : IComparable, IComparable<UInt24>, IConvertible, IEquatable<UInt24>, IFormattable
    {
        public const uint MinValue = 0;
        public const uint MaxValue = 16_777_215;
    
    
        private readonly byte byte0;
        private readonly byte byte1;
        private readonly byte byte2;
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 ToUInt2(UInt24 x, UInt24 y)
        {
            return new uint2(*(uint*)&x, *(uint*)&y) & MaxValue;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 ToUInt3(UInt24 x, UInt24 y, UInt24 z)
        {
            return new uint3(*(uint*)&x, *(uint*)&y, *(uint*)&z) & MaxValue;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 ToUInt4(UInt24 x, UInt24 y, UInt24 z, UInt24 w)
        {
            return new uint4(*(uint*)&x, *(uint*)&y, *(uint*)&z, *(uint*)&w) & MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint8 ToUInt8(UInt24 x0, UInt24 x1, UInt24 x2, UInt24 x3, UInt24 x4, UInt24 x5, UInt24 x6, UInt24 x7)
        {
            return new uint8(*(uint*)&x0, *(uint*)&x1, *(uint*)&x2, *(uint*)&x3, *(uint*)&x4, *(uint*)&x5, *(uint*)&x6, *(uint*)&x7) & MaxValue;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint2(UInt24 input)
        {
            return new uint2(*(uint*)&input) & MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint3(UInt24 input)
        {
            return new uint3(*(uint*)&input) & MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint4(UInt24 input)
        {
            return new uint4(*(uint*)&input) & MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint8(UInt24 input)
        {
            return new uint8(*(uint*)&input) & MaxValue;
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
            return (int)MaxValue & *(int*)&input;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint(UInt24 input)
        {
            return MaxValue & *(uint*)&input;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long(UInt24 input)
        {
            return 0x0000_0000_00FF_FFFF & *(long*)&input;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong(UInt24 input)
        {
            return 0x0000_0000_00FF_FFFFul & *(ulong*)&input;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half(UInt24 input)
        {
            return (half)((int)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(UInt24 input)
        {
            return (float)((int)input);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(UInt24 input)
        {
            return (double)((int)input);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(UInt24 input)
        {
            return (decimal)((int)input);
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 operator + (UInt24 value)
        {
            return (UInt24)(+(*(uint*)&value));
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 operator ~ (UInt24 value)
        {
            return (UInt24)(~(*(uint*)&value));
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 operator ++ (UInt24 value)
        {
            return (UInt24)(++(*(uint*)&value));
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 operator -- (UInt24 value)
        {
            return (UInt24)(--(*(uint*)&value));
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 operator + (UInt24 left, UInt24 right)
        {
            return (UInt24)(*(uint*)&left + *(uint*)&right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 operator + (UInt24 left, uint right)
        {
            return (UInt24)(*(uint*)&left + right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 operator + (uint left, UInt24 right)
        {
            return (UInt24)(left + *(uint*)&right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 operator - (UInt24 left, UInt24 right)
        {
            return (UInt24)(*(uint*)&left - *(uint*)&right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 operator - (UInt24 left, uint right)
        {
            return (UInt24)(*(uint*)&left - right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 operator - (uint left, UInt24 right)
        {
            return (UInt24)(left - *(uint*)&right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 operator * (UInt24 left, UInt24 right)
        {
            return (UInt24)(*(uint*)&left * *(uint*)&right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 operator * (UInt24 left, uint right)
        {
            return (UInt24)(*(uint*)&left * right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 operator * (uint left, UInt24 right)
        {
            return (UInt24)(left * *(uint*)&right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 operator / (UInt24 left, UInt24 right)
        {
            return (UInt24)((ulong)left / (ulong)right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 operator / (UInt24 left, uint right)
        {
            return (UInt24)((uint)left / right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 operator / (uint left, UInt24 right)
        {
            return (UInt24)(left / (uint)right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 operator % (UInt24 left, UInt24 right)
        {
            return (UInt24)((uint)left % (uint)right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 operator % (UInt24 left, uint right)
        {
            return (UInt24)((uint)left % right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 operator % (uint left, UInt24 right)
        {
            return (UInt24)(left % (uint)right);
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 operator & (UInt24 left, UInt24 right)
        {
            return (UInt24)(*(uint*)&left & *(uint*)&right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 operator & (UInt24 left, uint right)
        {
            return (UInt24)(*(uint*)&left & right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 operator & (uint left, UInt24 right)
        {
            return (UInt24)(left & *(uint*)&right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 operator | (UInt24 left, UInt24 right)
        {
            return (UInt24)(*(uint*)&left | *(uint*)&right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 operator | (UInt24 left, uint right)
        {
            return (UInt24)(*(uint*)&left | right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 operator | (uint left, UInt24 right)
        {
            return (UInt24)(left | *(uint*)&right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 operator ^ (UInt24 left, UInt24 right)
        {
            return (UInt24)(*(uint*)&left ^ *(uint*)&right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 operator ^ (UInt24 left, uint right)
        {
            return (UInt24)(*(uint*)&left ^ right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 operator ^ (uint left, UInt24 right)
        {
            return (UInt24)(left ^ *(uint*)&right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 operator << (UInt24 left, int right)
        {
            return (UInt24)(*(uint*)&left << right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 operator >> (UInt24 left, int right)
        {
            return (UInt24)((uint)left >> right);
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
        public override int GetHashCode()
        {
            return (int)this;
        }
        public TypeCode GetTypeCode()
        {
            return TypeCode.UInt32;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(UInt24 other)
        {
            return this == other;
        }
        public override bool Equals(object obj)
        {
            return Equals((UInt24)obj);
        }
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int CompareTo(UInt24 other)
        {
            return maxmath.compareto((uint)this, (uint)other);
        }
        public int CompareTo(object obj)
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
        
        public override string ToString()
        {
            return ((uint)this).ToString();
        }
        public string ToString(string format)
        {
            return ((uint)this).ToString(format);
        }
        public string ToString(IFormatProvider provider)
        {
            return ((uint)this).ToString(provider);
        }
        public string ToString(string format, IFormatProvider provider)
        {
            return ((uint)this).ToString(format, provider);
        }
        
        public bool ToBoolean(IFormatProvider provider)
        {
            return Convert.ToBoolean((uint)this, provider);
        }
        public byte ToByte(IFormatProvider provider)
        {
            return Convert.ToByte((uint)this, provider);
        }
        public char ToChar(IFormatProvider provider)
        {
            return Convert.ToChar((uint)this, provider);
        }
        public System.DateTime ToDateTime(IFormatProvider provider)
        {
            return Convert.ToDateTime((uint)this, provider);
        }
        public decimal ToDecimal(IFormatProvider provider)
        {
            return Convert.ToDecimal((uint)this, provider);
        }
        public double ToDouble(IFormatProvider provider)
        {
            return Convert.ToDouble((uint)this, provider);
        }
        public short ToInt16(IFormatProvider provider)
        {
            return Convert.ToInt16((uint)this, provider);
        }
        public int ToInt32(IFormatProvider provider)
        {
            return Convert.ToInt32((uint)this, provider);
        }
        public long ToInt64(IFormatProvider provider)
        {
            return Convert.ToInt64((uint)this, provider);
        }
        public sbyte ToSByte(IFormatProvider provider)
        {
            return Convert.ToSByte((uint)this, provider);
        }
        public float ToSingle(IFormatProvider provider)
        {
            return Convert.ToSingle((uint)this, provider);
        }
        public object ToType(Type conversionType, IFormatProvider provider)
        {
            return Convert.ChangeType((uint)this, conversionType, provider);
        }
        public ushort ToUInt16(IFormatProvider provider)
        {
            return Convert.ToUInt16((uint)this, provider);
        }
        public uint ToUInt32(IFormatProvider provider)
        {
            return Convert.ToUInt32((uint)this, provider);
        }
        public ulong ToUInt64(IFormatProvider provider)
        {
            return Convert.ToUInt64((uint)this, provider);
        }
    }
}