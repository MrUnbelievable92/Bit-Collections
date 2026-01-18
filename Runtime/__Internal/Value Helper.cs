using System.Runtime.CompilerServices;
using DevTools;
using MaxMath.Intrinsics;

using static Unity.Mathematics.math;
using static MaxMath.maxmath;

namespace BitCollections
{
    internal static class ValueHelper
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static sbyte TruncBits<T>(sbyte x)
            where T : BitInt
        {
            if (!constexpr.IS_TRUE(x >= 0))
            {
                x &= (sbyte)bitmask8((uint)default(T).Bits);
            }

            return x;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static short TruncBits<T>(short x)
            where T : BitInt
        {
            if (!constexpr.IS_TRUE(x >= 0))
            {
                x &= (short)bitmask16((uint)default(T).Bits);
            }

            return x;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int TruncBits<T>(int x)
            where T : BitInt
        {
            if (!constexpr.IS_TRUE(x >= 0))
            {
                x &= (int)bitmask32((uint)default(T).Bits);
            }

            return x;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static long TruncBits<T>(long x)
            where T : BitInt
        {
            if (!constexpr.IS_TRUE(x >= 0))
            {
                x &= (long)bitmask64((ulong)default(T).Bits);
            }

            return x;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static sbyte Clamp<T>(sbyte x)
            where T : BitInt
        {
Assert.IsTrue(default(T).IsSigned);

            return clamp(x, (sbyte)default(T).MinValueAsLong, (sbyte)default(T).MaxValueAsLong);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static short Clamp<T>(short x)
            where T : BitInt
        {
Assert.IsTrue(default(T).IsSigned);

            return clamp(x, (short)default(T).MinValueAsLong, (short)default(T).MaxValueAsLong);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int Clamp<T>(int x)
            where T : BitInt
        {
Assert.IsTrue(default(T).IsSigned);

            return clamp(x, (int)default(T).MinValueAsLong, (int)default(T).MaxValueAsLong);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static long Clamp<T>(long x)
            where T : BitInt
        {
Assert.IsTrue(default(T).IsSigned);

            return clamp(x, default(T).MinValueAsLong, default(T).MaxValueAsLong);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte Clamp<T>(byte x)
            where T : BitInt
        {
Assert.IsFalse(default(T).IsSigned);

            return min(x, (byte)default(T).MaxValueAsLong);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort Clamp<T>(ushort x)
            where T : BitInt
        {
Assert.IsFalse(default(T).IsSigned);

            return min(x, (ushort)default(T).MaxValueAsLong);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint Clamp<T>(uint x)
            where T : BitInt
        {
Assert.IsFalse(default(T).IsSigned);

            return min(x, (byte)default(T).MaxValueAsLong);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong Clamp<T>(ulong x)
            where T : BitInt
        {
Assert.IsFalse(default(T).IsSigned);

            return min(x, (ulong)default(T).MaxValueAsLong);
        }
    }
}
