using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using MaxMath;

namespace BitCollections
{
    [Serializable]  [StructLayout(LayoutKind.Sequential, Size = 7)]
    unsafe public readonly struct UInt56 : IComparable, IComparable<UInt56>, IConvertible, IEquatable<UInt56>, IFormattable
    {
        public const ulong MinValue = 0;
        public const ulong MaxValue = 72_057_594_037_927_935;
    
    
        private readonly byte byte0;
        private readonly byte byte1;
        private readonly byte byte2;
        private readonly byte byte3;
        private readonly byte byte4;
        private readonly byte byte5;
        private readonly byte byte6;
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 ToULong2(UInt56 x, UInt56 y)
        {
            return new ulong2(*(ulong*)&x, *(ulong*)&y) & MaxValue;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 ToULong3(UInt56 x, UInt56 y, UInt56 z)
        {
            return new ulong3(*(ulong*)&x, *(ulong*)&y, *(ulong*)&z) & MaxValue;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 ToULong4(UInt56 x, UInt56 y, UInt56 z, UInt56 w)
        {
            return new ulong4(*(ulong*)&x, *(ulong*)&y, *(ulong*)&z, *(ulong*)&w) & MaxValue;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong2(UInt56 input)
        {
            return new ulong2(*(ulong*)&input) & MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong3(UInt56 input)
        {
            return new ulong3(*(ulong*)&input) & MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong4(UInt56 input)
        {
            return new ulong4(*(ulong*)&input) & MaxValue;
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
            ulong cast = (ulong)input;

            return *(UInt56*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt56(UInt24 input)
        {
            ulong cast = input;

            return *(UInt56*)&cast;
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
            ulong cast = (ulong)input;

            return *(UInt56*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt56(UInt40 input)
        {
            ulong cast = input;

            return *(UInt56*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt56(Int48 input)
        {
            ulong cast = (ulong)input;

            return *(UInt56*)&cast;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt56(UInt48 input)
        {
            ulong cast = input;

            return *(UInt56*)&cast;
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
        public static explicit operator UInt56(quarter input)
        {
            return (UInt56)((float)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt56(half input)
        {
            return (UInt56)((ulong)input);
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
            return (long)MaxValue & *(long*)&input;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong(UInt56 input)
        {
            return MaxValue & *(ulong*)&input;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter(UInt56 input)
        {
            return (quarter)((long)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half(UInt56 input)
        {
            return (half)((long)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(UInt56 input)
        {
            return (float)((long)input);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(UInt56 input)
        {
            return (double)((long)input);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(UInt56 input)
        {
            return (decimal)((long)input);
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator + (UInt56 left, UInt56 right)
        {
            return (UInt56)(*(ulong*)&left + *(ulong*)&right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator + (uint left, UInt56 right)
        {
            return (UInt56)(left + *(ulong*)&right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator + (UInt56 left, uint right)
        {
            return (UInt56)(*(ulong*)&left + right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator + (UInt56 left, ulong right)
        {
            return (UInt56)(*(ulong*)&left + right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator + (ulong left, UInt56 right)
        {
            return (UInt56)(left + *(ulong*)&right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator - (UInt56 left, UInt56 right)
        {
            return (UInt56)(*(ulong*)&left - *(ulong*)&right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator - (UInt56 left, uint right)
        {
            return (UInt56)(*(ulong*)&left - right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator - (uint left, UInt56 right)
        {
            return (UInt56)(left - *(ulong*)&right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator - (UInt56 left, ulong right)
        {
            return (UInt56)(*(ulong*)&left - right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator - (ulong left, UInt56 right)
        {
            return (UInt56)(left - *(ulong*)&right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator * (UInt56 left, UInt56 right)
        {
            return (UInt56)(*(ulong*)&left * *(ulong*)&right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator * (UInt56 left, uint right)
        {
            return (UInt56)(*(ulong*)&left * right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator * (uint left, UInt56 right)
        {
            return (UInt56)(left * *(ulong*)&right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator * (UInt56 left, ulong right)
        {
            return (UInt56)(*(ulong*)&left * right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator * (ulong left, UInt56 right)
        {
            return (UInt56)(left * *(ulong*)&right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator / (UInt56 left, UInt56 right)
        {
            return (UInt40)((long)left % (long)right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator / (UInt56 left, uint right)
        {
            return (UInt56)((ulong)left / right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator / (uint left, UInt56 right)
        {
            return (UInt56)(left / (ulong)right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator / (UInt56 left, ulong right)
        {
            return (UInt56)((ulong)left / right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator / (ulong left, UInt56 right)
        {
            return (UInt56)(left / (ulong)right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator % (UInt56 left, UInt56 right)
        {
            return (UInt56)((ulong)left % (ulong)right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator % (UInt56 left, uint right)
        {
            return (UInt56)((ulong)left % right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator % (uint left, UInt56 right)
        {
            return (UInt56)(left % (ulong)right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator % (UInt56 left, ulong right)
        {
            return (UInt56)((ulong)left % right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator % (ulong left, UInt56 right)
        {
            return (UInt56)(left % (ulong)right);
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator & (UInt56 left, UInt56 right)
        {
            return (UInt56)(*(ulong*)&left & *(ulong*)&right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator & (UInt56 left, uint right)
        {
            return (UInt56)(*(ulong*)&left & right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator & (uint left, UInt56 right)
        {
            return (UInt56)(left & *(ulong*)&right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator & (UInt56 left, ulong right)
        {
            return (UInt56)(*(ulong*)&left & right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator & (ulong left, UInt56 right)
        {
            return (UInt56)(left & *(ulong*)&right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator | (UInt56 left, UInt56 right)
        {
            return (UInt56)(*(ulong*)&left | *(ulong*)&right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator | (UInt56 left, uint right)
        {
            return (UInt56)(*(ulong*)&left | right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator | (uint left, UInt56 right)
        {
            return (UInt56)(left | *(ulong*)&right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator | (UInt56 left, ulong right)
        {
            return (UInt56)(*(ulong*)&left | right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator | (ulong left, UInt56 right)
        {
            return (UInt56)(left | *(ulong*)&right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator ^ (UInt56 left, UInt56 right)
        {
            return (UInt56)(*(ulong*)&left ^ *(ulong*)&right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator ^ (UInt56 left, uint right)
        {
            return (UInt56)(*(ulong*)&left ^ right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator ^ (uint left, UInt56 right)
        {
            return (UInt56)(left ^ *(ulong*)&right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator ^ (UInt56 left, ulong right)
        {
            return (UInt56)(*(ulong*)&left ^ right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator ^ (ulong left, UInt56 right)
        {
            return (UInt56)(left ^ *(ulong*)&right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator << (UInt56 left, int right)
        {
            return (UInt56)(*(ulong*)&left << right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt56 operator >> (UInt56 left, int right)
        {
            return (UInt56)((ulong)left >> right);
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
        public override int GetHashCode()
        {
            return ((ulong)this).GetHashCode();
        }
        public TypeCode GetTypeCode()
        {
            return TypeCode.UInt64;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(UInt56 other)
        {
            return this == other;
        }
        public override bool Equals(object obj)
        {
            return Equals((UInt56)obj);
        }
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int CompareTo(UInt56 other)
        {
            return maxmath.compareto((ulong)this, (ulong)other);
        }
        public int CompareTo(object obj)
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