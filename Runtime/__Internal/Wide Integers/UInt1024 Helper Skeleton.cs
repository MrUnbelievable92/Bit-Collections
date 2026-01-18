using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;
using MaxMath;
using MaxMath.Intrinsics;
using static Unity.Burst.Intrinsics.X86;

namespace BitCollections
{
    internal readonly struct __UInt1024__
    {
        internal readonly __UInt256__ _255;
        internal readonly __UInt256__ _511;
        internal readonly __UInt256__ _767;
        internal readonly __UInt256__ _1023;

        public __UInt512__ lo512 => new __UInt512__(_255, _511);
        public __UInt512__ hi512 => new __UInt512__(_767, _1023);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal __UInt1024__(__UInt256__ lo, __UInt256__ m1, __UInt256__ m2, __UInt256__ hi)
        {
            _255 = lo;
            _511 = m1;
            _767 = m2;
            _1023 = hi;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal __UInt1024__(__UInt512__ lo, __UInt512__ hi)
            :this(lo.lo256, lo.hi256, hi.lo256, hi.hi256) { }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator __UInt1024__(ulong input)
        {
            return new __UInt1024__(input, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator __UInt1024__(__UInt512__ input)
        {
            return new __UInt1024__(input, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator __UInt1024__(__UInt256__ input)
        {
            return new __UInt1024__(input, 0, 0, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator __UInt1024__(UInt128 input)
        {
            return new __UInt1024__(new __UInt256__(input, 0), 0, 0, 0);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt1024__ operator ~ (__UInt1024__ value)
        {
            return new __UInt1024__(~value.lo512, ~value.hi512);
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt1024__ operator << (__UInt1024__ value, int n)
        {
            n &= 1023;

            if (Hint.Unlikely(n == 0))
            {
                return value;
            }
            else
            {
                if (n < 512)
                {
                    if (constexpr.IS_TRUE(n == 256))
                    {
                        return new __UInt1024__(0, value.lo512.lo256, value.lo512.hi256, value.hi512.lo256);
                    }

                    constexpr.ASSUME(n > 0 && n < 512);

                    return new __UInt1024__(value.lo512 << n, (value.hi512 << n) | (value.lo512 >> (512 - n)));
                }
                else
                {
                    if (constexpr.IS_TRUE(n == 512))
                    {
                        return new __UInt1024__(0, value.lo512);
                    }
                    if (constexpr.IS_TRUE(n == 768))
                    {
                        return new __UInt1024__(0, 0, 0, value.lo512.lo256);
                    }

                    constexpr.ASSUME(n > 511 && n < 1024);

                    return new __UInt1024__(0, value.lo512 << (n - 512));
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt1024__ operator >> (__UInt1024__ value, int n)
        {
            n &= 1023;

            if (Hint.Unlikely(n == 0))
            {
                return value;
            }
            else
            {
                if (n < 512)
                {
                    if (constexpr.IS_TRUE(n == 256))
                    {
                        return new __UInt1024__(value.lo512.hi256, value.hi512.lo256, value.hi512.hi256, 0);
                    }

                    constexpr.ASSUME(n > 0 && n < 512);

                    return new __UInt1024__((value.lo512 >> n) | (value.hi512 << (512 - n)), value.hi512 >> n);
                }
                else
                {
                    if (constexpr.IS_TRUE(n == 512))
                    {
                        return new __UInt1024__(value.hi512, 0);
                    }
                    if (constexpr.IS_TRUE(n == 768))
                    {
                        return new __UInt1024__(value.hi512.hi256, 0, 0, 0);
                    }

                    constexpr.ASSUME(n > 511 && n < 1024);

                    return new __UInt1024__(value.hi512 >> (n - 512), 0);
                }
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt1024__ operator | (__UInt1024__ a, __UInt1024__ b)
        {
            return new __UInt1024__(a.lo512 | b.lo512, a.hi512 | b.hi512);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt1024__ operator & (__UInt1024__ a, __UInt1024__ b)
        {
            return new __UInt1024__(a.lo512 & b.lo512, a.hi512 & b.hi512);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt1024__ operator ^ (__UInt1024__ a, __UInt1024__ b)
        {
            return new __UInt1024__(a.lo512 ^ b.lo512, a.hi512 ^ b.hi512);
        }

        
        [return: AssumeRange(0L, 1024L)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int countbits(__UInt1024__ x)
        {
            return __UInt512__.countbits(x.lo512) + __UInt512__.countbits(x.hi512);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt1024__ andnot(__UInt1024__ x, __UInt1024__ y)
        {
            return new __UInt1024__(__UInt512__.andnot(x.lo512, y.lo512), __UInt512__.andnot(x.hi512, y.hi512));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt1024__ bits_select(__UInt1024__ a, __UInt1024__ b, __UInt1024__ c)
        {
            return andnot(a, c) | (b & c);
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt1024__ bits_depositparallel(__UInt1024__ x, __UInt1024__ mask)
        {
            int maskLoCount = __UInt512__.countbits(mask.lo512);
            __UInt512__ lo = __UInt512__.bits_depositparallel(x.lo512, mask.lo512);
            x >>= maskLoCount;
            
            __UInt512__ hi = __UInt512__.bits_depositparallel(x.lo512, mask.hi512);
            
            return new __UInt1024__(lo, hi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt1024__ bits_extractparallel(__UInt1024__ x, __UInt1024__ mask)
        {
            __UInt512__ lo = __UInt512__.bits_extractparallel(x.lo512, mask.lo512);
            __UInt512__ hi = __UInt512__.bits_extractparallel(x.hi512, mask.hi512);
            int maskloCount = __UInt512__.countbits(mask.lo512);
            
            return lo | ((__UInt1024__)hi << maskloCount);
        }
    }
}
