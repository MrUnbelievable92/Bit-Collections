using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;
using MaxMath;
using MaxMath.CompilerServices;

namespace BitCollections
{
    internal readonly struct __UInt4096__
    {
        internal readonly __UInt1024__ _1023;
        internal readonly __UInt1024__ _2047;
        internal readonly __UInt1024__ _3071;
        internal readonly __UInt1024__ _4095;

        public __UInt2048__ lo2048 => new __UInt2048__(_1023, _2047);
        public __UInt2048__ hi2048 => new __UInt2048__(_3071, _4095);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal __UInt4096__(__UInt1024__ lo, __UInt1024__ m1, __UInt1024__ m2, __UInt1024__ hi)
        {
            _1023  = lo;
            _2047 = m1;
            _3071 = m2;
            _4095 = hi;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal __UInt4096__(__UInt2048__ lo, __UInt2048__ hi)
            :this(lo.lo1024, lo.hi1024, hi.lo1024, hi.hi1024) { }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator __UInt4096__(ulong input)
        {
            return new __UInt4096__(input, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator __UInt4096__(__UInt2048__ input)
        {
            return new __UInt4096__(input, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator __UInt4096__(__UInt1024__ input)
        {
            return new __UInt4096__(input, 0, 0, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator __UInt4096__(__UInt512__ input)
        {
            return new __UInt4096__(new __UInt1024__(input, 0), 0, 0, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator __UInt4096__(__UInt256__ input)
        {
            return new __UInt4096__(new __UInt1024__(input, 0), 0, 0, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator __UInt4096__(UInt128 input)
        {
            return new __UInt4096__(new __UInt1024__(input, 0), 0, 0, 0);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt4096__ operator ~ (__UInt4096__ value)
        {
            return new __UInt4096__(~value.lo2048, ~value.hi2048);
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt4096__ operator << (__UInt4096__ value, int n)
        {
            n &= 4095;
            
            if (constexpr.IS_TRUE(n == 0))
            {
                return value;
            }
            else
            {
                int n2 = n & 2047;
                bool upper = n >= 2048;

                __UInt2048__ loShifted = value.lo2048 << n2;

                __UInt2048__ carry      = (value.lo2048 >> 1) >> (2047 - n2);
                __UInt2048__ hiCombined = (value.hi2048 << n2) | carry;

                __UInt2048__ outLo = upper ? 0          : loShifted;
                __UInt2048__ outHi = upper ? loShifted  : hiCombined;

                return new __UInt4096__(outLo, outHi);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt4096__ operator >> (__UInt4096__ value, int n)
        {
            n &= 4095;
            
            if (constexpr.IS_TRUE(n == 0))
            {
                return value;
            }
            else
            {
                int n2 = n & 2047;
                bool upper = n >= 2048;

                __UInt2048__ hiShifted = value.hi2048 >> n2;

                __UInt2048__ carry      = (value.hi2048 << 1) << (2047 - n2);
                __UInt2048__ loCombined = (value.lo2048 >> n2) | carry;

                __UInt2048__ outHi = upper ? 0           : hiShifted;
                __UInt2048__ outLo = upper ? hiShifted   : loCombined;

                return new __UInt4096__(outLo, outHi);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt4096__ operator | (__UInt4096__ a, __UInt4096__ b)
        {
            return new __UInt4096__(a.lo2048 | b.lo2048, a.hi2048 | b.hi2048);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt4096__ operator & (__UInt4096__ a, __UInt4096__ b)
        {
            return new __UInt4096__(a.lo2048 & b.lo2048, a.hi2048 & b.hi2048);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt4096__ operator ^ (__UInt4096__ a, __UInt4096__ b)
        {
            return new __UInt4096__(a.lo2048 ^ b.lo2048, a.hi2048 ^ b.hi2048);
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt4096__ andnot(__UInt4096__ x, __UInt4096__ y)
        {
            return new __UInt4096__(__UInt2048__.andnot(x.lo2048, y.lo2048), __UInt2048__.andnot(x.hi2048, y.hi2048));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt4096__ bits_select(__UInt4096__ a, __UInt4096__ b, __UInt4096__ c)
        {
            return andnot(a, c) | (b & c);
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt4096__ bits_depositparallel(__UInt4096__ x, __UInt4096__ mask)
        {
            int maskLoCount = __UInt2048__.countbits(mask.lo2048);
            __UInt2048__ lo = __UInt2048__.bits_depositparallel(x.lo2048, mask.lo2048);
            x >>= maskLoCount;
            
            __UInt2048__ hi = __UInt2048__.bits_depositparallel(x.lo2048, mask.hi2048);
            
            return new __UInt4096__(lo, hi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt4096__ bits_extractparallel(__UInt4096__ x, __UInt4096__ mask)
        {
            __UInt2048__ lo = __UInt2048__.bits_extractparallel(x.lo2048, mask.lo2048);
            __UInt2048__ hi = __UInt2048__.bits_extractparallel(x.hi2048, mask.hi2048);
            int maskloCount = __UInt2048__.countbits(mask.lo2048);
            
            return lo | ((__UInt4096__)hi << maskloCount);
        }
    }
}
