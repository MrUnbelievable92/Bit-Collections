using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using MaxMath;

namespace BitCollections
{
    [Serializable]  [StructLayout(LayoutKind.Sequential, Size = 3)]
    unsafe public readonly struct Int24 : IComparable, IComparable<Int24>, IConvertible, IEquatable<Int24>, IFormattable
    {
        public const int MinValue = -8_388_608;
        public const int MaxValue = 8_388_607;
    
    
        private readonly byte byte0;
        private readonly byte byte1;
        private readonly byte byte2;
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 ToInt2(Int24 x, Int24 y)
        {
            int2 masked = new int2(*(int*)&x, *(int*)&y);

            return maxmath.signextend(masked, 24);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 ToInt3(Int24 x, Int24 y, Int24 z)
        {
            int3 masked = new int3(*(int*)&x, *(int*)&y, *(int*)&z);

            return maxmath.signextend(masked, 24);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 ToInt4(Int24 x, Int24 y, Int24 z, Int24 w)
        {
            int4 masked = new int4(*(int*)&x, *(int*)&y, *(int*)&z, *(int*)&w);

            return maxmath.signextend(masked, 24);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int8 ToInt8(Int24 x0, Int24 x1, Int24 x2, Int24 x3, Int24 x4, Int24 x5, Int24 x6, Int24 x7)
        {
            int8 masked = new int8(*(int*)&x0, *(int*)&x1, *(int*)&x2, *(int*)&x3, *(int*)&x4, *(int*)&x5, *(int*)&x6, *(int*)&x7);

            return maxmath.signextend(masked, 24);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int2(Int24 input)
        {
            return maxmath.signextend(new int2(*(int*)&input), 24);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int3(Int24 input)
        {
            return maxmath.signextend(new int3(*(int*)&input), 24);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int4(Int24 input)
        {
            return maxmath.signextend(new int4(*(int*)&input), 24);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int8(Int24 input)
        {
            return maxmath.signextend(new int8(*(int*)&input), 24);
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
        public static explicit operator Int24(quarter input)
        {
            return (Int24)((float)input);
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
            return maxmath.signextend(*(int*)&input, 24);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint(Int24 input)
        {
            return (uint)maxmath.signextend(*(int*)&input, 24);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long(Int24 input)
        {
            return maxmath.signextend(*(long*)&input, 24);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong(Int24 input)
        {
            return (ulong)maxmath.signextend(*(long*)&input, 24);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter(Int24 input)
        {
            return (quarter)((int)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half(Int24 input)
        {
            return (half)((int)input);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(Int24 input)
        {
            return (float)((int)input);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(Int24 input)
        {
            return (double)((int)input);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(Int24 input)
        {
            return (decimal)((int)input);
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator + (Int24 value)
        {
            return (Int24)(+(*(int*)&value));
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator - (Int24 value)
        {
            return (Int24)(-(*(int*)&value));
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator ~ (Int24 value)
        {
            return (Int24)(~(*(int*)&value));
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator ++ (Int24 value)
        {
            return (Int24)(++(*(int*)&value));
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator -- (Int24 value)
        {
            return (Int24)(--(*(int*)&value));
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator + (Int24 left, Int24 right)
        {
            return (Int24)(*(int*)&left + *(int*)&right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator + (Int24 left, int right)
        {
            return (Int24)(*(int*)&left + right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator + (int left, Int24 right)
        {
            return (Int24)(left + *(int*)&right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator - (Int24 left, Int24 right)
        {
            return (Int24)(*(int*)&left - *(int*)&right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator - (Int24 left, int right)
        {
            return (Int24)(*(int*)&left - right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator - (int left, Int24 right)
        {
            return (Int24)(left - *(int*)&right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator * (Int24 left, Int24 right)
        {
            return (Int24)(*(int*)&left * *(int*)&right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator * (Int24 left, int right)
        {
            return (Int24)(*(int*)&left * right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator * (int left, Int24 right)
        {
            return (Int24)(left * *(int*)&right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator / (Int24 left, Int24 right)
        {
            return (Int24)((int)left / (int)right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator / (Int24 left, int right)
        {
            return (Int24)((int)left / right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator / (int left, Int24 right)
        {
            return (Int24)(left / (int)right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator % (Int24 left, Int24 right)
        {
            return (Int24)((int)left % (int)right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator % (Int24 left, int right)
        {
            return (Int24)((int)left % right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator % (int left, Int24 right)
        {
            return (Int24)(left % (int)right);
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator & (Int24 left, Int24 right)
        {
            return (Int24)(*(int*)&left & *(int*)&right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator & (Int24 left, int right)
        {
            return (Int24)(*(int*)&left & right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator & (int left, Int24 right)
        {
            return (Int24)(left & *(int*)&right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator | (Int24 left, Int24 right)
        {
            return (Int24)(*(int*)&left | *(int*)&right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator | (Int24 left, int right)
        {
            return (Int24)(*(int*)&left | right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator | (int left, Int24 right)
        {
            return (Int24)(left | *(int*)&right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator ^ (Int24 left, Int24 right)
        {
            return (Int24)(*(int*)&left ^ *(int*)&right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator ^ (Int24 left, int right)
        {
            return (Int24)(*(int*)&left ^ right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator ^ (int left, Int24 right)
        {
            return (Int24)(left ^ *(int*)&right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator << (Int24 left, int right)
        {
            return (Int24)(*(int*)&left << right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 operator >> (Int24 left, int right)
        {
            // sign extend
            
            return (Int24)((*(int*)&left << 8) >> (8 + right));
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator == (Int24 left, Int24 right)
        {
            return (int)left == (int)right;
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
            return (int)left != (int)right;
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
        public override int GetHashCode()
        {
            return (int)this;
        }
        public TypeCode GetTypeCode()
        {
            return TypeCode.Int32;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Int24 other)
        {
            return this == other;
        }
        public override bool Equals(object obj)
        {
            return Equals((Int24)obj);
        }
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int CompareTo(Int24 other)
        {
            return maxmath.compareto((int)this, (int)other);
        }
        public int CompareTo(object obj)
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

            return (success & (Int <= MaxValue)) & (Int >= MinValue);
        }
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out Int24 result)
        {
            bool success = int.TryParse(s, style, provider, out int Int);

            result = (Int24)Int;

            return (success & (Int <= MaxValue)) & (Int >= MinValue);
        }
    
        public override string ToString()
        {
            return ((int)this).ToString();
        }
        public string ToString(string format)
        {
            return ((int)this).ToString(format);
        }
        public string ToString(IFormatProvider provider)
        {
            return ((int)this).ToString(provider);
        }
        public string ToString(string format, IFormatProvider provider)
        {
            return ((int)this).ToString(format, provider);
        }
    
        public bool ToBoolean(IFormatProvider provider)
        {
            return Convert.ToBoolean((int)this, provider);
        }
        public byte ToByte(IFormatProvider provider)
        {
            return Convert.ToByte((int)this, provider);
        }
        public char ToChar(IFormatProvider provider)
        {
            return Convert.ToChar((int)this, provider);
        }
        public DateTime ToDateTime(IFormatProvider provider)
        {
            return Convert.ToDateTime((int)this, provider);
        }
        public decimal ToDecimal(IFormatProvider provider)
        {
            return Convert.ToDecimal((int)this, provider);
        }
        public double ToDouble(IFormatProvider provider)
        {
            return Convert.ToDouble((int)this, provider);
        }
        public short ToInt16(IFormatProvider provider)
        {
            return Convert.ToInt16((int)this, provider);
        }
        public int ToInt32(IFormatProvider provider)
        {
            return Convert.ToInt32((int)this, provider);
        }
        public long ToInt64(IFormatProvider provider)
        {
            return Convert.ToInt64((int)this, provider);
        }
        public sbyte ToSByte(IFormatProvider provider)
        {
            return Convert.ToSByte((int)this, provider);
        }
        public float ToSingle(IFormatProvider provider)
        {
            return Convert.ToSingle((int)this, provider);
        }
        public object ToType(Type conversionType, IFormatProvider provider)
        {
            return Convert.ChangeType((int)this, conversionType, provider);
        }
        public ushort ToUInt16(IFormatProvider provider)
        {
            return Convert.ToUInt16((int)this, provider);
        }
        public uint ToUInt32(IFormatProvider provider)
        {
            return Convert.ToUInt32((int)this, provider);
        }
        public ulong ToUInt64(IFormatProvider provider)
        {
            return Convert.ToUInt64((int)this, provider);
        }
    }
}