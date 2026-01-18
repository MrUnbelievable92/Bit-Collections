using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;
using MaxMath;
using MaxMath.Intrinsics;
using static Unity.Burst.Intrinsics.X86;

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

            if (Hint.Unlikely(n == 0))
            {
                return value;
            }
            else
            {
                if (n < 2048)
                {
                    if (constexpr.IS_TRUE(n == 1024))
                    {
                        return new __UInt4096__(0, value.lo2048.lo1024, value.lo2048.hi1024, value.hi2048.lo1024);
                    }

                    constexpr.ASSUME(n > 0 && n < 2048);

                    return new __UInt4096__(value.lo2048 << n, (value.hi2048 << n) | (value.lo2048 >> (2048 - n)));
                }
                else
                {
                    if (constexpr.IS_TRUE(n == 2048))
                    {
                        return new __UInt4096__(0, value.lo2048);
                    }
                    if (constexpr.IS_TRUE(n == 3072))
                    {
                        return new __UInt4096__(0, 0, 0, value.lo2048.lo1024);
                    }

                    constexpr.ASSUME(n > 2047 && n < 4096);

                    return new __UInt4096__(0, value.lo2048 << (n - 2048));
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt4096__ operator >> (__UInt4096__ value, int n)
        {
            n &= 4095;

            if (Hint.Unlikely(n == 0))
            {
                return value;
            }
            else
            {
                if (n < 2048)
                {
                    if (constexpr.IS_TRUE(n == 1024))
                    {
                        return new __UInt4096__(value.lo2048.hi1024, value.hi2048.lo1024, value.hi2048.hi1024, 0);
                    }

                    constexpr.ASSUME(n > 0 && n < 2048);

                    return new __UInt4096__((value.lo2048 >> n) | (value.hi2048 << (2048 - n)), value.hi2048 >> n);
                }
                else
                {
                    if (constexpr.IS_TRUE(n == 2048))
                    {
                        return new __UInt4096__(value.hi2048, 0);
                    }
                    if (constexpr.IS_TRUE(n == 3072))
                    {
                        return new __UInt4096__(value.hi2048.hi1024, 0, 0, 0);
                    }

                    constexpr.ASSUME(n > 2047 && n < 4096);

                    return new __UInt4096__(value.hi2048 >> (n - 2048), 0);
                }
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
