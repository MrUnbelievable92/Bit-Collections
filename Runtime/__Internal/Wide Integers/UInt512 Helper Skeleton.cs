using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;
using MaxMath;
using MaxMath.CompilerServices;

namespace BitCollections
{
    internal readonly struct __UInt512__
    {
        internal readonly UInt128 _127;
        internal readonly UInt128 _255;
        internal readonly UInt128 _383;
        internal readonly UInt128 _511;

        public __UInt256__ lo256 => new __UInt256__(_127, _255);
        public __UInt256__ hi256 => new __UInt256__(_383, _511);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal __UInt512__(UInt128 lo, UInt128 m1, UInt128 m2, UInt128 hi)
        {
            _127 = lo;
            _255 = m1;
            _383 = m2;
            _511 = hi;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal __UInt512__(__UInt256__ lo, __UInt256__ hi)
            :this(lo.lo128, lo.hi128, hi.lo128, hi.hi128) { }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator __UInt512__(ulong input)
        {
            return new __UInt512__(input, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator __UInt512__(__UInt256__ input)
        {
            return new __UInt512__(input, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator __UInt512__(UInt128 input)
        {
            return new __UInt512__(input, 0, 0, 0);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt512__ operator ~ (__UInt512__ value)
        {
            return new __UInt512__(~value.lo256, ~value.hi256);
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt512__ operator << (__UInt512__ value, int n)
        {
            n &= 511;
            
            if (constexpr.IS_TRUE(n == 0))
            {
                return value;
            }
            else
            {
                int n2 = n & 255;
                bool upper = n >= 256;

                __UInt256__ loShifted = value.lo256 << n2;

                __UInt256__ carry      = (value.lo256 >> 1) >> (255 - n2);
                __UInt256__ hiCombined = (value.hi256 << n2) | carry;

                __UInt256__ outLo = upper ? 0          : loShifted;
                __UInt256__ outHi = upper ? loShifted  : hiCombined;

                return new __UInt512__(outLo, outHi);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt512__ operator >> (__UInt512__ value, int n)
        {
            n &= 511;
            
            if (constexpr.IS_TRUE(n == 0))
            {
                return value;
            }
            else
            {
                int n2 = n & 255;
                bool upper = n >= 256;

                __UInt256__ hiShifted = value.hi256 >> n2;

                __UInt256__ carry      = (value.hi256 << 1) << (255 - n2);
                __UInt256__ loCombined = (value.lo256 >> n2) | carry;

                __UInt256__ outHi = upper ? 0           : hiShifted;
                __UInt256__ outLo = upper ? hiShifted   : loCombined;

                return new __UInt512__(outLo, outHi);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt512__ operator | (__UInt512__ a, __UInt512__ b)
        {
            return new __UInt512__(a.lo256 | b.lo256, a.hi256 | b.hi256);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt512__ operator & (__UInt512__ a, __UInt512__ b)
        {
            return new __UInt512__(a.lo256 & b.lo256, a.hi256 & b.hi256);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt512__ operator ^ (__UInt512__ a, __UInt512__ b)
        {
            return new __UInt512__(a.lo256 ^ b.lo256, a.hi256 ^ b.hi256);
        }


        [return: AssumeRange(0L, 512L)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int countbits(__UInt512__ x)
        {
            return __UInt256__.countbits(x.lo256) + __UInt256__.countbits(x.hi256);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt512__ andnot(__UInt512__ x, __UInt512__ y)
        {
            return new __UInt512__(__UInt256__.andnot(x.lo256, y.lo256), __UInt256__.andnot(x.hi256, y.hi256));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt512__ bits_select(__UInt512__ a, __UInt512__ b, __UInt512__ c)
        {
            return andnot(a, c) | (b & c);
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt512__ bits_depositparallel(__UInt512__ x, __UInt512__ mask)
        {
            int maskLoCount = __UInt256__.countbits(mask.lo256);
            __UInt256__ lo = __UInt256__.bits_depositparallel(x.lo256, mask.lo256);
            x >>= maskLoCount;
            
            __UInt256__ hi = __UInt256__.bits_depositparallel(x.lo256, mask.hi256);
            
            return new __UInt512__(lo, hi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt512__ bits_extractparallel(__UInt512__ x, __UInt512__ mask)
        {
            __UInt256__ lo = __UInt256__.bits_extractparallel(x.lo256, mask.lo256);
            __UInt256__ hi = __UInt256__.bits_extractparallel(x.hi256, mask.hi256);
            int maskloCount = __UInt256__.countbits(mask.lo256);
            
            return lo | ((__UInt512__)hi << maskloCount);
        }
    }
}
