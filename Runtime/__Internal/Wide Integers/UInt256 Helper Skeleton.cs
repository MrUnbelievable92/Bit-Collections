using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;
using MaxMath;
using MaxMath.Intrinsics;
using static Unity.Burst.Intrinsics.X86;

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

            if (Hint.Unlikely(n == 0))
            {
                return value;
            }
            else
            {
                if (n < 128)
                {
                    if (constexpr.IS_TRUE(n == 64))
                    {
                        return new __UInt256__(0, value.lo128.lo64, value.lo128.hi64, value.hi128.lo64);
                    }

                    constexpr.ASSUME(n > 0 && n < 128);

                    return new __UInt256__(value.lo128 << n, (value.hi128 << n) | (value.lo128 >> (128 - n)));
                }
                else
                {
                    if (constexpr.IS_TRUE(n == 128))
                    {
                        return new __UInt256__(0, value.lo128);
                    }
                    if (constexpr.IS_TRUE(n == 192))
                    {
                        return new __UInt256__(0, 0, 0, value.lo128.lo64);
                    }

                    constexpr.ASSUME(n > 127 && n < 256);

                    return new __UInt256__(0, value.lo128 << (n - 128));
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt256__ operator >> (__UInt256__ value, int n)
        {
            n &= 255;

            if (Hint.Unlikely(n == 0))
            {
                return value;
            }
            else
            {
                if (n < 128)
                {
                    if (constexpr.IS_TRUE(n == 64))
                    {
                        return new __UInt256__(value.lo128.hi64, value.hi128.lo64, value.hi128.hi64, 0);
                    }

                    constexpr.ASSUME(n > 0 && n < 128);

                    return new __UInt256__((value.lo128 >> n) | (value.hi128 << (128 - n)), value.hi128 >> n);
                }
                else
                {
                    if (constexpr.IS_TRUE(n == 128))
                    {
                        return new __UInt256__(value.hi128, 0);
                    }
                    if (constexpr.IS_TRUE(n == 192))
                    {
                        return new __UInt256__(value.hi128.hi64, 0, 0, 0);
                    }

                    constexpr.ASSUME(n > 127 && n < 256);

                    return new __UInt256__(value.hi128 >> (n - 128), 0);
                }
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
            int tzcntLo = maxmath.tzcnt(x.lo128);
            int tzcntHi = maxmath.tzcnt(x.hi128);
            bool lo0 = x.lo128 == 0;
            int add = lo0 ? 128 : 0;

            return add + (lo0 ? tzcntHi : tzcntLo);
        }

        [return: AssumeRange(0L, 256L)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int countbits(__UInt256__ x)
        {
            return maxmath.countbits(x.lo128) + maxmath.countbits(x.hi128);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt256__ andnot(__UInt256__ x, __UInt256__ y)
        {
            return new __UInt256__(maxmath.andnot(x.lo128, y.lo128), maxmath.andnot(x.hi128, y.hi128));
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
            int maskLoCount = maxmath.countbits(mask.lo128);
            UInt128 lo = maxmath.bits_depositparallel(x.lo128, mask.lo128);
            x >>= maskLoCount;
            
            UInt128 hi = maxmath.bits_depositparallel(x.lo128, mask.hi128);
            
            return new __UInt256__(lo, hi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static __UInt256__ bits_extractparallel(__UInt256__ x, __UInt256__ mask)
        {
            UInt128 lo = maxmath.bits_extractparallel(x.lo128, mask.lo128);
            UInt128 hi = maxmath.bits_extractparallel(x.hi128, mask.hi128);
            int maskloCount = maxmath.countbits(mask.lo128);
            
            return lo | ((__UInt256__)hi << maskloCount);
        }
    }
}
