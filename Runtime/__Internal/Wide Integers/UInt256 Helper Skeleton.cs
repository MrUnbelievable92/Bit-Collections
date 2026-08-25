using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;
using MaxMath;
using MaxMath.CompilerServices;

namespace BitCollections
{
    internal readonly struct __UInt256__
    {
        internal readonly ulong _63;
        internal readonly ulong _127;
        internal readonly ulong _191;
        internal readonly ulong _255;

        public UInt128 lo128 => new UInt128(_63, _127);
        public UInt128 hi128 => new UInt128(_191, _255);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal __UInt256__(ulong lo, ulong m1, ulong m2, ulong hi)
        {
            _63 = lo;
            _127 = m1;
            _191 = m2;
            _255 = hi;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal __UInt256__(UInt128 lo, UInt128 hi)
            :this(lo.lo64, lo.hi64, hi.lo64, hi.hi64) { }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator __UInt256__(ulong input)
        {
            return new __UInt256__(input, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator __UInt256__(UInt128 input)
        {
            return new __UInt256__(input, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong(__UInt256__ input)
        {
            return input._63;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt128(__UInt256__ input)
        {
            return input.lo128;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt256__ operator ~ (__UInt256__ value)
        {
            return new __UInt256__(~value.lo128, ~value.hi128);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt256__ operator << (__UInt256__ value, int n)
        {
            n &= 255;
            
            if (constexpr.IS_TRUE(n == 0))
            {
                return value;
            }
            else
            {
                int n2 = n & 127;
                bool upper = n >= 128;

                UInt128 loShifted = value.lo128 << n2;

                UInt128 carry      = (value.lo128 >> 1) >> (127 - n2);
                UInt128 hiCombined = (value.hi128 << n2) | carry;

                UInt128 outLo = upper ? 0          : loShifted;
                UInt128 outHi = upper ? loShifted  : hiCombined;

                return new __UInt256__(outLo, outHi);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt256__ operator >> (__UInt256__ value, int n)
        {
            n &= 255;
            
            if (constexpr.IS_TRUE(n == 0))
            {
                return value;
            }
            else
            {
                int n2 = n & 127;
                bool upper = n >= 128;

                UInt128 hiShifted = value.hi128 >> n2;

                UInt128 carry      = (value.hi128 << 1) << (127 - n2);
                UInt128 loCombined = (value.lo128 >> n2) | carry;

                UInt128 outHi = upper ? 0           : hiShifted;
                UInt128 outLo = upper ? hiShifted   : loCombined;

                return new __UInt256__(outLo, outHi);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt256__ operator | (__UInt256__ a, __UInt256__ b)
        {
            return new __UInt256__(a.lo128 | b.lo128, a.hi128 | b.hi128);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt256__ operator & (__UInt256__ a, __UInt256__ b)
        {
            return new __UInt256__(a.lo128 & b.lo128, a.hi128 & b.hi128);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt256__ operator ^ (__UInt256__ a, __UInt256__ b)
        {
            return new __UInt256__(a.lo128 ^ b.lo128, a.hi128 ^ b.hi128);
        }

        [return: AssumeRange(0L, 256L)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int tzcnt(__UInt256__ x)
        {
            int tzcntLo = math.tzcnt(x.lo128);
            int tzcntHi = math.tzcnt(x.hi128);
            bool lo0 = x.lo128 == 0;
            int add = lo0 ? 128 : 0;

            return add + (lo0 ? tzcntHi : tzcntLo);
        }

        [return: AssumeRange(0L, 256L)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int countbits(__UInt256__ x)
        {
            return math.countbits(x.lo128) + math.countbits(x.hi128);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt256__ andnot(__UInt256__ x, __UInt256__ y)
        {
            return new __UInt256__(math.andnot(x.lo128, y.lo128), math.andnot(x.hi128, y.hi128));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt256__ bits_select(__UInt256__ a, __UInt256__ b, __UInt256__ c)
        {
            return andnot(a, c) | (b & c);
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt256__ bits_depositparallel(__UInt256__ x, __UInt256__ mask)
        {
            int maskLoCount = math.countbits(mask.lo128);
            UInt128 lo = math.bits_depositparallel(x.lo128, mask.lo128);
            x >>= maskLoCount;
            
            UInt128 hi = math.bits_depositparallel(x.lo128, mask.hi128);
            
            return new __UInt256__(lo, hi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt256__ bits_extractparallel(__UInt256__ x, __UInt256__ mask)
        {
            UInt128 lo = math.bits_extractparallel(x.lo128, mask.lo128);
            UInt128 hi = math.bits_extractparallel(x.hi128, mask.hi128);
            int maskloCount = math.countbits(mask.lo128);
            
            return lo | ((__UInt256__)hi << maskloCount);
        }
    }
}
