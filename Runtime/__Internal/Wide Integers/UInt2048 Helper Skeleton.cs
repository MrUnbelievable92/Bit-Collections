using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;
using MaxMath;
using MaxMath.CompilerServices;

namespace BitCollections
{
    internal readonly struct __UInt2048__
    {
        internal readonly __UInt512__ _511;
        internal readonly __UInt512__ _1023;
        internal readonly __UInt512__ _1535;
        internal readonly __UInt512__ _2047;

        public __UInt1024__ lo1024 => new __UInt1024__(_511, _1023);
        public __UInt1024__ hi1024 => new __UInt1024__(_1535, _2047);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal __UInt2048__(__UInt512__ lo, __UInt512__ m1, __UInt512__ m2, __UInt512__ hi)
        {
            _511  = lo;
            _1023 = m1;
            _1535 = m2;
            _2047 = hi;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal __UInt2048__(__UInt1024__ lo, __UInt1024__ hi)
            :this(lo.lo512, lo.hi512, hi.lo512, hi.hi512) { }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator __UInt2048__(ulong input)
        {
            return new __UInt2048__(input, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator __UInt2048__(__UInt1024__ input)
        {
            return new __UInt2048__(input, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator __UInt2048__(__UInt512__ input)
        {
            return new __UInt2048__(input, 0, 0, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator __UInt2048__(__UInt256__ input)
        {
            return new __UInt2048__(new __UInt512__(input, 0), 0, 0, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator __UInt2048__(UInt128 input)
        {
            return new __UInt2048__(new __UInt512__(input, 0), 0, 0, 0);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt2048__ operator ~ (__UInt2048__ value)
        {
            return new __UInt2048__(~value.lo1024, ~value.hi1024);
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt2048__ operator << (__UInt2048__ value, int n)
        {
            n &= 2047;
            
            if (constexpr.IS_TRUE(n == 0))
            {
                return value;
            }
            else
            {
                int n2 = n & 1023;
                bool upper = n >= 1024;

                __UInt1024__ loShifted = value.lo1024 << n2;

                __UInt1024__ carry      = (value.lo1024 >> 1) >> (1023 - n2);
                __UInt1024__ hiCombined = (value.hi1024 << n2) | carry;

                __UInt1024__ outLo = upper ? 0          : loShifted;
                __UInt1024__ outHi = upper ? loShifted  : hiCombined;

                return new __UInt2048__(outLo, outHi);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt2048__ operator >> (__UInt2048__ value, int n)
        {
            n &= 2047;
            
            if (constexpr.IS_TRUE(n == 0))
            {
                return value;
            }
            else
            {
                int n2 = n & 1023;
                bool upper = n >= 1024;

                __UInt1024__ hiShifted = value.hi1024 >> n2;

                __UInt1024__ carry      = (value.hi1024 << 1) << (1023 - n2);
                __UInt1024__ loCombined = (value.lo1024 >> n2) | carry;

                __UInt1024__ outHi = upper ? 0           : hiShifted;
                __UInt1024__ outLo = upper ? hiShifted   : loCombined;

                return new __UInt2048__(outLo, outHi);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt2048__ operator | (__UInt2048__ a, __UInt2048__ b)
        {
            return new __UInt2048__(a.lo1024 | b.lo1024, a.hi1024 | b.hi1024);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt2048__ operator & (__UInt2048__ a, __UInt2048__ b)
        {
            return new __UInt2048__(a.lo1024 & b.lo1024, a.hi1024 & b.hi1024);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt2048__ operator ^ (__UInt2048__ a, __UInt2048__ b)
        {
            return new __UInt2048__(a.lo1024 ^ b.lo1024, a.hi1024 ^ b.hi1024);
        }


        [return: AssumeRange(0L, 2048L)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int countbits(__UInt2048__ x)
        {
            return __UInt1024__.countbits(x.lo1024) + __UInt1024__.countbits(x.hi1024);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt2048__ andnot(__UInt2048__ x, __UInt2048__ y)
        {
            return new __UInt2048__(__UInt1024__.andnot(x.lo1024, y.lo1024), __UInt1024__.andnot(x.hi1024, y.hi1024));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt2048__ bits_select(__UInt2048__ a, __UInt2048__ b, __UInt2048__ c)
        {
            return andnot(a, c) | (b & c);
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt2048__ bits_depositparallel(__UInt2048__ x, __UInt2048__ mask)
        {
            int maskLoCount = __UInt1024__.countbits(mask.lo1024);
            __UInt1024__ lo = __UInt1024__.bits_depositparallel(x.lo1024, mask.lo1024);
            x >>= maskLoCount;
            
            __UInt1024__ hi = __UInt1024__.bits_depositparallel(x.lo1024, mask.hi1024);
            
            return new __UInt2048__(lo, hi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt2048__ bits_extractparallel(__UInt2048__ x, __UInt2048__ mask)
        {
            __UInt1024__ lo = __UInt1024__.bits_extractparallel(x.lo1024, mask.lo1024);
            __UInt1024__ hi = __UInt1024__.bits_extractparallel(x.hi1024, mask.hi1024);
            int maskloCount = __UInt1024__.countbits(mask.lo1024);
            
            return lo | ((__UInt2048__)hi << maskloCount);
        }
    }
}
