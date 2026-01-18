using System;
using MaxMath;

using static MaxMath.maxmath;

namespace BitCollections.Tests
{
    internal struct BitIntMock : BitInt
    {
        private BitIntMock(int bits, bool signed)
        {
            __IsSigned = signed;
            __Bits = (byte)bits;
            __MinEvenBytes = (byte)(lcm(bits, 8) / 8);
            __MinValueAsLong = signed ? -(1L << (bits - 1)) : 0;
            __MaxValueAsLong = (1L << (bits - toint(signed))) - 1;
        }

        private static bool __IsSigned;
        private static byte __Bits;
        private static byte __MinEvenBytes;
        private static long __MinValueAsLong;
        private static long __MaxValueAsLong;

        public readonly bool IsSigned => __IsSigned;
        public readonly byte Bits => __Bits;
        public readonly byte MinFullyPackedBytes => __MinEvenBytes;
        public readonly long MinValueAsLong => __MinValueAsLong;
        public readonly long MaxValueAsLong => __MaxValueAsLong;


        internal static long Random(ref Random64 rng)
        {
            return rng.NextLong(__MinValueAsLong, __MaxValueAsLong + (__Bits == 63 ? 0 : 1));
        }

        internal static void ForEachBitInt(Action<Random64> test, byte maxBits = 63, bool unsigned = true, bool signed = true)
        {
            Random64 rng = Random64.New;

            for (int bits = 1; bits <= maxBits; bits++)
            {
                try
                {
                    if (unsigned)
                    {
                        new BitIntMock(bits, false);
                        test(rng);
                    }

                    if (bits != 1
                     && signed)
                    {
                        new BitIntMock(bits, true);
                        test(rng);
                    }
                }
                catch
                {
                    UnityEngine.Debug.Log($"{nameof(BitIntMock)}: Bits: {__Bits}, Signed: {__IsSigned}");
                    throw;
                }
            }
        }
    }

    internal struct BitIntMock2 : BitInt
    {
        private BitIntMock2(int bits, bool signed)
        {
            __IsSigned = signed;
            __Bits = (byte)bits;
            __MinEvenBytes = (byte)(lcm(bits, 8) / 8);
            __MinValueAsLong = signed ? -(1L << (bits - 1)) : 0;
            __MaxValueAsLong = (1L << (bits - toint(signed))) - 1;
        }

        private static bool __IsSigned;
        private static byte __Bits;
        private static byte __MinEvenBytes;
        private static long __MinValueAsLong;
        private static long __MaxValueAsLong;

        public readonly bool IsSigned => __IsSigned;
        public readonly byte Bits => __Bits;
        public readonly byte MinFullyPackedBytes => __MinEvenBytes;
        public readonly long MinValueAsLong => __MinValueAsLong;
        public readonly long MaxValueAsLong => __MaxValueAsLong;


        internal static long Random(ref Random64 rng)
        {
            return rng.NextLong(__MinValueAsLong, __MaxValueAsLong + (__Bits == 63 ? 0 : 1));
        }

        internal static void ForEachBitInt(Action<Random64> test, byte maxBits = 63, bool unsigned = true, bool signed = true)
        {
            Random64 rng = Random64.New;

            for (int bits = 1; bits <= maxBits; bits++)
            {
                try
                {
                    if (unsigned)
                    {
                        new BitIntMock2(bits, false);
                        test(rng);
                    }

                    if (bits != 1
                     && signed)
                    {
                        new BitIntMock2(bits, true);
                        test(rng);
                    }
                }
                catch
                {
                    UnityEngine.Debug.Log($"{nameof(BitIntMock2)}: Bits: {__Bits}, Signed: {__IsSigned}");
                    throw;
                }
            }
        }
    }
}
