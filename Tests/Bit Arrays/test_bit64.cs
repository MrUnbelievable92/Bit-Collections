using NUnit.Framework;
using MaxMath;
using Unity.Collections;

namespace BitCollections.Tests
{
    internal static class _bit64
    {
        internal static bit64 TestData_LHS => new bit64{ intern = 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110 };
        internal static bit64 TestData_RHS => new bit64{ intern = 0b1110_1100_1011_0001_1010_1111_1010_1010_1001_1011_1101_0001_1011_0110_0000_0110 };


        [Test]
        public static void Constructor_boolx64()
        {
            bit64 test = new bit64(false,
                                   true,
                                   true,
                                   false,

                                   false,
                                   false,
                                   false,
                                   false,

                                   false,
                                   true,
                                   true,
                                   false,

                                   true,
                                   true,
                                   false,
                                   true,

                                   true,
                                   false,
                                   false,
                                   false,

                                   true,
                                   false,
                                   true,
                                   true,

                                   true,
                                   true,
                                   false,
                                   true,

                                   true,
                                   false,
                                   false,
                                   true,

                                   false,
                                   true,
                                   false,
                                   true,

                                   false,
                                   true,
                                   false,
                                   true,

                                   true,
                                   true,
                                   true,
                                   true,

                                   false,
                                   true,
                                   false,
                                   true,

                                   true,
                                   false,
                                   false,
                                   false,

                                   true,
                                   true,
                                   false,
                                   true,

                                   false,
                                   false,
                                   true,
                                   true,

                                   false,
                                   true,
                                   true,
                                   true);


            Assert.AreEqual(test.intern == 0b1110_1100_1011_0001_1010_1111_1010_1010_1001_1011_1101_0001_1011_0110_0000_0110, true);
        }

        [Test]
        public static void Constructor_bit8x8()
        {
            Assert.AreEqual(new bit64(new bit8(0b1101_1110),
                             new bit8(0b1011_0101),
                             new bit8(0b0001_1101),
                             new bit8(0b1101_0110),
                             new bit8(0b1001_1110),
                             new bit8(0b0010_1011),
                             new bit8(0b1101_0010),
                             new bit8(0b1011_0001)).intern 
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit16_bit8_bit8_bit8_bit8_bit8_bit8()
        {
            Assert.AreEqual(new bit64(new bit16(0b1011_0101_1101_1110),
                             new bit8(0b0001_1101),
                             new bit8(0b1101_0110),
                             new bit8(0b1001_1110),
                             new bit8(0b0010_1011),
                             new bit8(0b1101_0010),
                             new bit8(0b1011_0001)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit8_bit16_bit8_bit8_bit8_bit8_bit8()
        {
            Assert.AreEqual(new bit64(new bit8(0b1101_1110),
                             new bit16(0b0001_1101_1011_0101),
                             new bit8(0b1101_0110),
                             new bit8(0b1001_1110),
                             new bit8(0b0010_1011),
                             new bit8(0b1101_0010),
                             new bit8(0b1011_0001)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit8_bit8_bit16_bit8_bit8_bit8_bit8()
        {
            Assert.AreEqual(new bit64(new bit8(0b1101_1110),
                             new bit8(0b1011_0101),
                             new bit16(0b1101_0110_0001_1101),
                             new bit8(0b1001_1110),
                             new bit8(0b0010_1011),
                             new bit8(0b1101_0010),
                             new bit8(0b1011_0001)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit8_bit8_bit8_bit16_bit8_bit8_bit8()
        {
            Assert.AreEqual(new bit64(new bit8(0b1101_1110),
                             new bit8(0b1011_0101),
                             new bit8(0b0001_1101),
                             new bit16(0b1001_1110_1101_0110),
                             new bit8(0b0010_1011),
                             new bit8(0b1101_0010),
                             new bit8(0b1011_0001)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit8_bit8_bit8_bit8_bit16_bit8_bit8()
        {
            Assert.AreEqual(new bit64(new bit8(0b1101_1110),
                             new bit8(0b1011_0101),
                             new bit8(0b0001_1101),
                             new bit8(0b1101_0110),
                             new bit16(0b0010_1011_1001_1110),
                             new bit8(0b1101_0010),
                             new bit8(0b1011_0001)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit8_bit8_bit8_bit8_bit8_bit16_bit8()
        {
            Assert.AreEqual(new bit64(new bit8(0b1101_1110),
                             new bit8(0b1011_0101),
                             new bit8(0b0001_1101),
                             new bit8(0b1101_0110),
                             new bit8(0b1001_1110),
                             new bit16(0b1101_0010_0010_1011),
                             new bit8(0b1011_0001)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit8_bit8_bit8_bit8_bit8_bit8_bit16()
        {
            Assert.AreEqual(new bit64(new bit8(0b1101_1110),
                             new bit8(0b1011_0101),
                             new bit8(0b0001_1101),
                             new bit8(0b1101_0110),
                             new bit8(0b1001_1110),
                             new bit8(0b0010_1011),
                             new bit16(0b1011_0001_1101_0010)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit16_bit16_bit8_bit8_bit8_bit8()
        {
            Assert.AreEqual(new bit64(new bit16(0b1011_0101_1101_1110),
                             new bit16(0b1101_0110_0001_1101),
                             new bit8(0b1001_1110),
                             new bit8(0b0010_1011),
                             new bit8(0b1101_0010),
                             new bit8(0b1011_0001)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit16_bit8_bit16_bit8_bit8_bit8()
        {
            Assert.AreEqual(new bit64(new bit16(0b1011_0101_1101_1110),
                             new bit8(0b0001_1101),
                             new bit16(0b1001_1110_1101_0110),
                             new bit8(0b0010_1011),
                             new bit8(0b1101_0010),
                             new bit8(0b1011_0001)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit16_bit8_bit8_bit16_bit8_bit8()
        {
            Assert.AreEqual(new bit64(new bit16(0b1011_0101_1101_1110),
                             new bit8(0b0001_1101),
                             new bit8(0b1101_0110),
                             new bit16(0b0010_1011_1001_1110),
                             new bit8(0b1101_0010),
                             new bit8(0b1011_0001)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit16_bit8_bit8_bit8_bit16_bit8()
        {
            Assert.AreEqual(new bit64(new bit16(0b1011_0101_1101_1110),
                             new bit8(0b0001_1101),
                             new bit8(0b1101_0110),
                             new bit8(0b1001_1110),
                             new bit16(0b1101_0010_0010_1011),
                             new bit8(0b1011_0001)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit16_bit8_bit8_bit8_bit8_bit16()
        {
            Assert.AreEqual(new bit64(new bit16(0b1011_0101_1101_1110),
                             new bit8(0b0001_1101),
                             new bit8(0b1101_0110),
                             new bit8(0b1001_1110),
                             new bit8(0b0010_1011),
                             new bit16(0b1011_0001_1101_0010)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit8_bit16_bit16_bit8_bit8_bit8()
        {
            Assert.AreEqual(new bit64(new bit8(0b1101_1110),
                             new bit16(0b0001_1101_1011_0101),
                             new bit16(0b1001_1110_1101_0110),
                             new bit8(0b0010_1011),
                             new bit8(0b1101_0010),
                             new bit8(0b1011_0001)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit8_bit16_bit8_bit16_bit8_bit8()
        {
            Assert.AreEqual(new bit64(new bit8(0b1101_1110),
                             new bit16(0b0001_1101_1011_0101),
                             new bit8(0b1101_0110),
                             new bit16(0b0010_1011_1001_1110),
                             new bit8(0b1101_0010),
                             new bit8(0b1011_0001)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit8_bit16_bit8_bit8_bit16_bit8()
        {
            Assert.AreEqual(new bit64(new bit8(0b1101_1110),
                             new bit16(0b0001_1101_1011_0101),
                             new bit8(0b1101_0110),
                             new bit8(0b1001_1110),
                             new bit16(0b1101_0010_0010_1011),
                             new bit8(0b1011_0001)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit8_bit16_bit8_bit8_bit8_bit16()
        {
            Assert.AreEqual(new bit64(new bit8(0b1101_1110),
                             new bit16(0b0001_1101_1011_0101),
                             new bit8(0b1101_0110),
                             new bit8(0b1001_1110),
                             new bit8(0b0010_1011),
                             new bit16(0b1011_0001_1101_0010)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit8_bit8_bit16_bit16_bit8_bit8()
        {
            Assert.AreEqual(new bit64(new bit8(0b1101_1110),
                             new bit8(0b1011_0101),
                             new bit16(0b1101_0110_0001_1101),
                             new bit16(0b0010_1011_1001_1110),
                             new bit8(0b1101_0010),
                             new bit8(0b1011_0001)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit8_bit8_bit16_bit8_bit16_bit8()
        {
            Assert.AreEqual(new bit64(new bit8(0b1101_1110),
                             new bit8(0b1011_0101),
                             new bit16(0b1101_0110_0001_1101),
                             new bit8(0b1001_1110),
                             new bit16(0b1101_0010_0010_1011),
                             new bit8(0b1011_0001)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit8_bit8_bit16_bit8_bit8_bit16()
        {
            Assert.AreEqual(new bit64(new bit8(0b1101_1110),
                             new bit8(0b1011_0101),
                             new bit16(0b1101_0110_0001_1101),
                             new bit8(0b1001_1110),
                             new bit8(0b0010_1011),
                             new bit16(0b1011_0001_1101_0010)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit8_bit8_bit8_bit16_bit16_bit8()
        {
            Assert.AreEqual(new bit64(new bit8(0b1101_1110),
                             new bit8(0b1011_0101),
                             new bit8(0b0001_1101),
                             new bit16(0b1001_1110_1101_0110),
                             new bit16(0b1101_0010_0010_1011),
                             new bit8(0b1011_0001)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit8_bit8_bit8_bit16_bit8_bit16()
        {
            Assert.AreEqual(new bit64(new bit8(0b1101_1110),
                             new bit8(0b1011_0101),
                             new bit8(0b0001_1101),
                             new bit16(0b1001_1110_1101_0110),
                             new bit8(0b0010_1011),
                             new bit16(0b1011_0001_1101_0010)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit8_bit8_bit8_bit8_bit16_bit16()
        {
            Assert.AreEqual(new bit64(new bit8(0b1101_1110),
                             new bit8(0b1011_0101),
                             new bit8(0b0001_1101),
                             new bit8(0b1101_0110),
                             new bit16(0b0010_1011_1001_1110),
                             new bit16(0b1011_0001_1101_0010)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit16_bit16_bit16_bit8_bit8()
        {
            Assert.AreEqual(new bit64(new bit16(0b1011_0101_1101_1110),
                             new bit16(0b1101_0110_0001_1101),
                             new bit16(0b0010_1011_1001_1110),
                             new bit8(0b1101_0010),
                             new bit8(0b1011_0001)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit16_bit16_bit8_bit16_bit8()
        {
            Assert.AreEqual(new bit64(new bit16(0b1011_0101_1101_1110),
                             new bit16(0b1101_0110_0001_1101),
                             new bit8(0b1001_1110),
                             new bit16(0b1101_0010_0010_1011),
                             new bit8(0b1011_0001)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit16_bit16_bit8_bit8_bit16()
        {
            Assert.AreEqual(new bit64(new bit16(0b1011_0101_1101_1110),
                             new bit16(0b1101_0110_0001_1101),
                             new bit8(0b1001_1110),
                             new bit8(0b0010_1011),
                             new bit16(0b1011_0001_1101_0010)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit16_bit8_bit16_bit16_bit8()
        {
            Assert.AreEqual(new bit64(new bit16(0b1011_0101_1101_1110),
                             new bit8(0b0001_1101),
                             new bit16(0b1001_1110_1101_0110),
                             new bit16(0b1101_0010_0010_1011),
                             new bit8(0b1011_0001)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit16_bit8_bit16_bit8_bit16()
        {
            Assert.AreEqual(new bit64(new bit16(0b1011_0101_1101_1110),
                             new bit8(0b0001_1101),
                             new bit16(0b1001_1110_1101_0110),
                             new bit8(0b0010_1011),
                             new bit16(0b1011_0001_1101_0010)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit16_bit8_bit8_bit16_bit16()
        {
            Assert.AreEqual(new bit64(new bit16(0b1011_0101_1101_1110),
                             new bit8(0b0001_1101),
                             new bit8(0b1101_0110),
                             new bit16(0b0010_1011_1001_1110),
                             new bit16(0b1011_0001_1101_0010)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit8_bit16_bit16_bit16_bit8()
        {
            Assert.AreEqual(new bit64(new bit8(0b1101_1110),
                             new bit16(0b0001_1101_1011_0101),
                             new bit16(0b1001_1110_1101_0110),
                             new bit16(0b1101_0010_0010_1011),
                             new bit8(0b1011_0001)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit8_bit16_bit16_bit8_bit16()
        {
            Assert.AreEqual(new bit64(new bit8(0b1101_1110),
                             new bit16(0b0001_1101_1011_0101),
                             new bit16(0b1001_1110_1101_0110),
                             new bit8(0b0010_1011),
                             new bit16(0b1011_0001_1101_0010)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit8_bit16_bit8_bit16_bit16()
        {
            Assert.AreEqual(new bit64(new bit8(0b1101_1110),
                             new bit16(0b0001_1101_1011_0101),
                             new bit8(0b1101_0110),
                             new bit16(0b0010_1011_1001_1110),
                             new bit16(0b1011_0001_1101_0010)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit8_bit8_bit16_bit16_bit16()
        {
            Assert.AreEqual(new bit64(new bit8(0b1101_1110),
                             new bit8(0b1011_0101),
                             new bit16(0b1101_0110_0001_1101),
                             new bit16(0b0010_1011_1001_1110),
                             new bit16(0b1011_0001_1101_0010)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit32_bit8_bit8_bit8_bit8()
        {
            Assert.AreEqual(new bit64(new bit32(0b1101_0110_0001_1101_1011_0101_1101_1110),
                             new bit8(0b1001_1110),
                             new bit8(0b0010_1011),
                             new bit8(0b1101_0010),
                             new bit8(0b1011_0001)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit8_bit32_bit8_bit8_bit8()
        {
            Assert.AreEqual(new bit64(new bit8(0b1101_1110),
                             new bit32(0b1001_1110_1101_0110_0001_1101_1011_0101),
                             new bit8(0b0010_1011),
                             new bit8(0b1101_0010),
                             new bit8(0b1011_0001)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit8_bit8_bit32_bit8_bit8()
        {
            Assert.AreEqual(new bit64(new bit8(0b1101_1110),
                             new bit8(0b1011_0101),
                             new bit32(0b0010_1011_1001_1110_1101_0110_0001_1101),
                             new bit8(0b1101_0010),
                             new bit8(0b1011_0001)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit8_bit8_bit8_bit32_bit8()
        {
            Assert.AreEqual(new bit64(new bit8(0b1101_1110),
                             new bit8(0b1011_0101),
                             new bit8(0b0001_1101),
                             new bit32(0b1101_0010_0010_1011_1001_1110_1101_0110),
                             new bit8(0b1011_0001)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit8_bit8_bit8_bit8_bit32()
        {
            Assert.AreEqual(new bit64(new bit8(0b1101_1110),
                             new bit8(0b1011_0101),
                             new bit8(0b0001_1101),
                             new bit8(0b1101_0110),
                             new bit32(0b1011_0001_1101_0010_0010_1011_1001_1110)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit32_bit16_bit8_bit8()
        {
            Assert.AreEqual(new bit64(new bit32(0b1101_0110_0001_1101_1011_0101_1101_1110),
                             new bit16(0b0010_1011_1001_1110),
                             new bit8(0b1101_0010),
                             new bit8(0b1011_0001)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit32_bit8_bit16_bit8()
        {
            Assert.AreEqual(new bit64(new bit32(0b1101_0110_0001_1101_1011_0101_1101_1110),
                             new bit8(0b1001_1110),
                             new bit16(0b1101_0010_0010_1011),
                             new bit8(0b1011_0001)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit32_bit8_bit8_bit16()
        {
            Assert.AreEqual(new bit64(new bit32(0b1101_0110_0001_1101_1011_0101_1101_1110),
                             new bit8(0b1001_1110),
                             new bit8(0b0010_1011),
                             new bit16(0b1011_0001_1101_0010)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit8_bit32_bit16_bit8()
        {
            Assert.AreEqual(new bit64(new bit8(0b1101_1110),
                             new bit32(0b1001_1110_1101_0110_0001_1101_1011_0101),
                             new bit16(0b1101_0010_0010_1011),
                             new bit8(0b1011_0001)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit8_bit32_bit8_bit16()
        {
            Assert.AreEqual(new bit64(new bit8(0b1101_1110),
                             new bit32(0b1001_1110_1101_0110_0001_1101_1011_0101),
                             new bit8(0b0010_1011),
                             new bit16(0b1011_0001_1101_0010)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit8_bit8_bit32_bit16()
        {
            Assert.AreEqual(new bit64(new bit8(0b1101_1110),
                             new bit8(0b1011_0101),
                             new bit32(0b0010_1011_1001_1110_1101_0110_0001_1101),
                             new bit16(0b1011_0001_1101_0010)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit16_bit32_bit8_bit8()
        {
            Assert.AreEqual(new bit64(new bit16(0b1011_0101_1101_1110),
                             new bit32(0b0010_1011_1001_1110_1101_0110_0001_1101),
                             new bit8(0b1101_0010),
                             new bit8(0b1011_0001)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit16_bit8_bit32_bit8()
        {
            Assert.AreEqual(new bit64(new bit16(0b1011_0101_1101_1110),
                             new bit8(0b0001_1101),
                             new bit32(0b1101_0010_0010_1011_1001_1110_1101_0110),
                             new bit8(0b1011_0001)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit16_bit8_bit8_bit32()
        {
            Assert.AreEqual(new bit64(new bit16(0b1011_0101_1101_1110),
                             new bit8(0b0001_1101),
                             new bit8(0b1101_0110),
                             new bit32(0b1011_0001_1101_0010_0010_1011_1001_1110)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit8_bit16_bit32_bit8()
        {
            Assert.AreEqual(new bit64(new bit8(0b1101_1110),
                             new bit16(0b0001_1101_1011_0101),
                             new bit32(0b1101_0010_0010_1011_1001_1110_1101_0110),
                             new bit8(0b1011_0001)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit8_bit16_bit8_bit32()
        {
            Assert.AreEqual(new bit64(new bit8(0b1101_1110),
                             new bit16(0b0001_1101_1011_0101),
                             new bit8(0b1101_0110),
                             new bit32(0b1011_0001_1101_0010_0010_1011_1001_1110)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit8_bit8_bit16_bit32()
        {
            Assert.AreEqual(new bit64(new bit8(0b1101_1110),
                             new bit8(0b1011_0101),
                             new bit16(0b1101_0110_0001_1101),
                             new bit32(0b1011_0001_1101_0010_0010_1011_1001_1110)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit16x4()
        {
            Assert.AreEqual(new bit64(new bit16(0b1011_0101_1101_1110),
                             new bit16(0b1101_0110_0001_1101),
                             new bit16(0b0010_1011_1001_1110),
                             new bit16(0b1011_0001_1101_0010)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit32_bit16_bit16()
        {
            Assert.AreEqual(new bit64(new bit32(0b1101_0110_0001_1101_1011_0101_1101_1110),
                             new bit16(0b0010_1011_1001_1110),
                             new bit16(0b1011_0001_1101_0010)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit16_bit32_bit16()
        {
            Assert.AreEqual(new bit64(new bit16(0b1011_0101_1101_1110),
                             new bit32(0b0010_1011_1001_1110_1101_0110_0001_1101),
                             new bit16(0b1011_0001_1101_0010)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit16_bit16_bit32()
        {
            Assert.AreEqual(new bit64(new bit16(0b1011_0101_1101_1110),
                             new bit16(0b1101_0110_0001_1101),
                             new bit32(0b1011_0001_1101_0010_0010_1011_1001_1110)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Constructor_bit32x2()
        {
            Assert.AreEqual(new bit64(new bit32(0b1101_0110_0001_1101_1011_0101_1101_1110),
                             new bit32(0b1011_0001_1101_0010_0010_1011_1001_1110)).intern
                   == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110, true);
        }

        [Test]
        public static void Get()
        {
            bool result = true;

            result &= TestData_LHS[0] == false;
            result &= TestData_LHS[1] == true;
            result &= TestData_LHS[2] == true;
            result &= TestData_LHS[3] == true;

            result &= TestData_LHS[4] == true;
            result &= TestData_LHS[5] == false;
            result &= TestData_LHS[6] == true;
            result &= TestData_LHS[7] == true;

            result &= TestData_LHS[8] == true;
            result &= TestData_LHS[9] == false;
            result &= TestData_LHS[10] == true;
            result &= TestData_LHS[11] == false;

            result &= TestData_LHS[12] == true;
            result &= TestData_LHS[13] == true;
            result &= TestData_LHS[14] == false;
            result &= TestData_LHS[15] == true;

            result &= TestData_LHS[16] == true;
            result &= TestData_LHS[17] == false;
            result &= TestData_LHS[18] == true;
            result &= TestData_LHS[19] == true;

            result &= TestData_LHS[20] == true;
            result &= TestData_LHS[21] == false;
            result &= TestData_LHS[22] == false;
            result &= TestData_LHS[23] == false;

            result &= TestData_LHS[24] == false;
            result &= TestData_LHS[25] == true;
            result &= TestData_LHS[26] == true;
            result &= TestData_LHS[27] == false;

            result &= TestData_LHS[28] == true;
            result &= TestData_LHS[29] == false;
            result &= TestData_LHS[30] == true;
            result &= TestData_LHS[31] == true;

            result &= TestData_LHS[32] == false;
            result &= TestData_LHS[33] == true;
            result &= TestData_LHS[34] == true;
            result &= TestData_LHS[35] == true;

            result &= TestData_LHS[36] == true;
            result &= TestData_LHS[37] == false;
            result &= TestData_LHS[38] == false;
            result &= TestData_LHS[39] == true;

            result &= TestData_LHS[40] == true;
            result &= TestData_LHS[41] == true;
            result &= TestData_LHS[42] == false;
            result &= TestData_LHS[43] == true;

            result &= TestData_LHS[44] == false;
            result &= TestData_LHS[45] == true;
            result &= TestData_LHS[46] == false;
            result &= TestData_LHS[47] == false;

            result &= TestData_LHS[48] == false;
            result &= TestData_LHS[49] == true;
            result &= TestData_LHS[50] == false;
            result &= TestData_LHS[51] == false;

            result &= TestData_LHS[52] == true;
            result &= TestData_LHS[53] == false;
            result &= TestData_LHS[54] == true;
            result &= TestData_LHS[55] == true;

            result &= TestData_LHS[56] == true;
            result &= TestData_LHS[57] == false;
            result &= TestData_LHS[58] == false;
            result &= TestData_LHS[59] == false;

            result &= TestData_LHS[60] == true;
            result &= TestData_LHS[61] == true;
            result &= TestData_LHS[62] == false;
            result &= TestData_LHS[63] == true;


            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Set()
        {
            bool result = true;

            for (int i = 0; i < 64; i++)
            {
                bit64 test = TestData_LHS;
                test[i] = false;
                result &= test.intern == (TestData_LHS.intern & ~(1ul << i));
            }

            for (int i = 0; i < 64; i++)
            {
                bit64 test = TestData_LHS;
                test[i] = true;
                result &= test.intern == (TestData_LHS.intern | (1ul << i));
            }

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void IndexOfFirst()
        {
            bool result = true;

            result &= TestData_LHS.IndexOfFirst() == 1; 
            result &= TestData_RHS.IndexOfFirst() == 1;

            result &= TestData_LHS.IndexOfFirst(36, 10) == 36;
            result &= TestData_RHS.IndexOfFirst(44, 10) == 45;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void IndexOfLast()
        {
            bool result = true;

            result &= TestData_LHS.IndexOfLast() == 63; 
            result &= TestData_RHS.IndexOfLast() == 63;

            result &= TestData_LHS.IndexOfLast(55, 5) == 56;
            result &= TestData_RHS.IndexOfLast(44, 10) == 53;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void ResetFirst()
        {
            bool result = true;


            bit64 _0 = TestData_LHS;
            bit64 _1 = TestData_RHS;

            _0.ResetFirst();
            result &= _0.intern == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1100;
            _1.ResetFirst();
            result &= _1.intern == 0b1110_1100_1011_0001_1010_1111_1010_1010_1001_1011_1101_0001_1011_0110_0000_0100;

            _0 = TestData_LHS;
            _1 = TestData_RHS;

            _0.ResetFirst(32, 4);
            result &= _0.intern == 0b1011_0001_1101_0010_0010_1011_1001_1100_1101_0110_0001_1101_1011_0101_1101_1110;
            _1.ResetFirst(32, 4);
            result &= _1.intern == 0b1110_1100_1011_0001_1010_1111_1010_1000_1001_1011_1101_0001_1011_0110_0000_0110;


            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetFirst()
        {
            bool result = true;


            bit64 _0 = TestData_LHS;
            bit64 _1 = TestData_RHS;

            _0.SetFirst();
            result &= _0.intern == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1111;
            _1.SetFirst();
            result &= _1.intern == 0b1110_1100_1011_0001_1010_1111_1010_1010_1001_1011_1101_0001_1011_0110_0000_0111;

            _0 = TestData_LHS;
            _1 = TestData_RHS;

            _0.SetFirst(32, 4);
            result &= _0.intern == 0b1011_0001_1101_0010_0010_1011_1001_1111_1101_0110_0001_1101_1011_0101_1101_1110;
            _1.SetFirst(32, 4);
            result &= _1.intern == 0b1110_1100_1011_0001_1010_1111_1010_1011_1001_1011_1101_0001_1011_0110_0000_0110;


            Assert.AreEqual(result, true);
        }

        [Test]
        public static void ResetLast()
        {
            bool result = true;


            bit64 _0 = TestData_LHS;
            bit64 _1 = TestData_RHS;

            _0.ResetLast();
            result &= _0.intern == 0b0011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110;
            _1.ResetLast();
            result &= _1.intern == 0b0110_1100_1011_0001_1010_1111_1010_1010_1001_1011_1101_0001_1011_0110_0000_0110;

            _0 = TestData_LHS;
            _1 = TestData_RHS;

            _0.ResetLast(32, 4);
            result &= _0.intern == 0b1011_0001_1101_0010_0010_1011_1001_0110_1101_0110_0001_1101_1011_0101_1101_1110;
            _1.ResetLast(32, 8);
            result &= _1.intern == 0b1110_1100_1011_0001_1010_1111_0010_1010_1001_1011_1101_0001_1011_0110_0000_0110;


            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetLast()
        {
            bool result = true;


            bit64 _0 = TestData_LHS;
            bit64 _1 = TestData_RHS;

            _0.SetLast();
            result &= _0.intern == 0b1111_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110;
            _1.SetLast();
            result &= _1.intern == 0b1111_1100_1011_0001_1010_1111_1010_1010_1001_1011_1101_0001_1011_0110_0000_0110;

            _0 = TestData_LHS;
            _1 = TestData_RHS;

            _0.SetLast(32, 8);
            result &= _0.intern == 0b1011_0001_1101_0010_0010_1011_1101_1110_1101_0110_0001_1101_1011_0101_1101_1110;
            _1.SetLast(32, 8);
            result &= _1.intern == 0b1110_1100_1011_0001_1010_1111_1110_1010_1001_1011_1101_0001_1011_0110_0000_0110;


            Assert.AreEqual(result, true);
        }

        [Test]
        public static void ShiftLeft()
        {
            bool result = true;

            bit64 x = TestData_LHS;
            x.ShiftLeft(28, 20, 10);
            result &= x.intern == 0b1011_0001_1101_0010_0111_1011_0100_0000_0000_0110_0001_1101_1011_0101_1101_1110;

            x = TestData_RHS;
            x.ShiftLeft(36, 11, 5);
            result &= x.intern == 0b1110_1100_1011_0001_1111_0100_0000_1010_1001_1011_1101_0001_1011_0110_0000_0110;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void ShiftRight()
        {
            bool result = true;

            bit64 x = TestData_LHS;
            x.ShiftRight(28, 20, 10);
            result &= x.intern == 0b1011_0001_1101_0010_0000_0000_0000_1010_1110_0110_0001_1101_1011_0101_1101_1110;

            x = TestData_RHS;
            x.ShiftRight(36, 11, 5);
            result &= x.intern == 0b1110_1100_1011_0001_1000_0001_0111_1010_1001_1011_1101_0001_1011_0110_0000_0110;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void RotateLeft()
        {   
            bool result = true;

            bit64 x = TestData_LHS;
            x.RotateLeft(28, 20, 10);
            result &= x.intern == 0b1011_0001_1101_0010_0111_1011_0100_1010_1110_0110_0001_1101_1011_0101_1101_1110;

            x = TestData_RHS;
            x.RotateLeft(36, 11, 5);
            result &= x.intern == 0b1110_1100_1011_0001_1111_0100_1011_1010_1001_1011_1101_0001_1011_0110_0000_0110;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void RotateRight()
        {
            bool result = true;

            bit64 x = TestData_LHS;
            x.RotateRight(28, 20, 10);
            result &= x.intern == 0b1011_0001_1101_0010_0111_1011_0100_1010_1110_0110_0001_1101_1011_0101_1101_1110;

            x = TestData_RHS;
            x.RotateRight(36, 11, 5);
            result &= x.intern == 0b1110_1100_1011_0001_1110_1001_0111_1010_1001_1011_1101_0001_1011_0110_0000_0110;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Swap()
        {
            bool result = true;

            bit64 x = TestData_LHS;
            x.Swap(13, 55);
            result &= x.intern == 0b1011_0001_1101_0010_0010_1011_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110;

            x = TestData_RHS;
            x.Swap(11, 47);
            result &= x.intern == 0b1110_1100_1011_0001_0010_1111_1010_1010_1001_1011_1101_0001_1011_1110_0000_0110;


            x = TestData_LHS;
            x.Swap(2, 32, 12);
            result &= x.intern == 0b1011_0001_1101_0010_0010_1101_0111_0111_1101_0110_0001_1101_1010_1110_0111_1010;

            x = TestData_RHS;
            x.Swap(4, 44, 10);
            result &= x.intern == 0b1110_1100_1011_0110_0000_1111_1010_1010_1001_1011_1101_0001_1011_0001_1010_0110;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Flip()
        {
            bool result = true;

            bit64 x = TestData_LHS;
            x.Flip(32, 20); 
            result &= x.intern == 0b1011_0001_1101_1101_1101_0100_0110_0001_1101_0110_0001_1101_1011_0101_1101_1110;

            x = TestData_RHS;
            x.Flip(20, 20);
            result &= x.intern == 0b1110_1100_1011_0001_1010_1111_0101_0101_0110_0100_0010_0001_1011_0110_0000_0110;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Reverse()
        {
            bool result = true;

            bit64 x = TestData_LHS;
            x.Reverse();
            result &= x.intern == 0b0111_1011_1010_1101_1011_1000_0110_1011_0111_1001_1101_0100_0100_1011_1000_1101;

            x = TestData_RHS;
            x.Reverse();
            result &= x.intern == 0b0110_0000_0110_1101_1000_1011_1101_1001_0101_0101_1111_0101_1000_1101_0011_0111;

            x = TestData_LHS;
            x.Reverse(24, 20);
            result &= x.intern == 0b1011_0001_1101_0010_0010_0110_1011_0111_1001_1101_0001_1101_1011_0101_1101_1110;

            x = TestData_RHS;
            x.Reverse(36, 16);
            result &= x.intern == 0b1110_1100_1011_0101_1111_0101_1000_1010_1001_1011_1101_0001_1011_0110_0000_0110;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetBits()
        {
            bool result = true;

            bit64 x = TestData_LHS;
            x.SetBits(40, 16, true);
            result &= x.intern == 0b1011_0001_1111_1111_1111_1111_1001_1110_1101_0110_0001_1101_1011_0101_1101_1110;

            x = TestData_RHS;
            x.SetBits(24, 28, false);
            result &= x.intern == 0b1110_1100_1011_0000_0000_0000_0000_0000_0000_0000_1101_0001_1011_0110_0000_0110;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void CountBits()
        {
            bool result = true;

            bit64 x = TestData_LHS;
            result &= (x.CountBits(24, 22) == 14);

            x = TestData_RHS;
            result &= (x.CountBits(16, 40) == 23);

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void TestAll()
        {
            bool result = true;

            bit64 x = TestData_LHS;
            result &= (x.TestAll() == false);
            result &= (x.TestAll(33, 4) == true);

            x = TestData_RHS;
            result &= (x.TestAll() == false);
            result &= (x.TestAll(35, 9) == false);

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void TestAny()
        {
            bool result = true;

            bit64 x = TestData_LHS;
            result &= (x.TestAny() == true);
            result &= (x.TestAny(36, 9) == true);

            x = TestData_RHS;
            result &= (x.TestAny() == true);
            result &= (x.TestAny(3, 6) == false);

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void TestNone()
        {
            bool result = true;

            bit64 x = TestData_LHS;
            result &= (x.TestNone() == false);
            result &= (x.TestNone(36, 8) == false);

            x = TestData_RHS;
            result &= (x.TestNone() == false);
            result &= (x.TestNone(49, 3) == true);

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Shuffle()
        {
            Random64 rng = new Random64(123);

            for (int i = 0; i < 16; i++)
            {
                bit64 x = TestData_LHS;

                uint bits = x.CountBits();

                x.Shuffle(ref rng);

                Assert.AreEqual(bits, x.CountBits());
            }
        }

        [Test]
        public static void ShuffleBitField()
        {
            Random64 rng = new Random64(123);

            for (int i = 0; i < 16; i++)
            {
                bit64 x = TestData_LHS;
                int index = (int)rng.NextLong(0, x.Length);
                int numBits = (int)rng.NextLong(1, x.Length - index + 1);

                uint bits = x.CountBits(index, numBits);

                x.Shuffle(index, numBits, ref rng);

                Assert.AreEqual(bits, x.CountBits(index, numBits));
            }
        }

        public static void CopyToArray_Base(int srcIndex = 0)
        {
            Random64 rng = new Random64(265);

            for (int i = 0; i < 16; i++)
            {
                bit64 bits = (bit64)rng.NextLong();
                NativeArray<bool> array = new NativeArray<bool>((int)rng.NextLong(bits.Length, 200), Allocator.Temp);
                NativeArray<bool> arrayCpy = new NativeArray<bool>(array.Length, Allocator.Temp);

                for (int j = 0; j < array.Length; j++)
                {
                    bool next = rng.NextBool();
                    array[j] = next;
                    arrayCpy[j] = next;
                }

                for (int numValues = 1; numValues <= bits.Length - srcIndex; numValues++)
                {
                    int dstIndex = (int)rng.NextLong(0, array.Length - (numValues - 1));
                    bits.CopyTo(array, dstIndex, numValues, srcIndex);

                    for (int k = 0;k < array.Length;k++)
                    {
                        if (k >= dstIndex && k <= dstIndex + (numValues - 1))
                        {
                            Assert.AreEqual(array[k], bits[k - dstIndex + srcIndex]);
                        }
                        else
                        {
                            Assert.AreEqual(array[k], arrayCpy[k]);
                        }
                    }
                    
                    for (int j = dstIndex; j < dstIndex + numValues; j++)
                    {
                        array[j] = arrayCpy[j];
                    }
                }

                array.Dispose();
                arrayCpy.Dispose();
            }
        }

        public static void CopyToBitArray_IndexIsMultipleOf8_Base(int srcIndex = 0)
        {
            Random64 rng = new Random64(265);

            for (int i = 0; i < 16; i++)
            {
                bit64 bits = (bit64)rng.NextLong();
                NativeBitArray array = new NativeBitArray((int)rng.NextLong(bits.Length, 200), Allocator.Temp);
                NativeBitArray arrayCpy = new NativeBitArray(array.Length, Allocator.Temp);

                for (int j = 0; j < array.Length; j++)
                {
                    bool next = rng.NextBool();
                    array[j] = next;
                    arrayCpy[j] = next;
                }

                for (int numValues = 1; numValues <= bits.Length - srcIndex; numValues++)
                {
                    int dstIndex = 8 * (int)rng.NextLong(0, (array.Length - (numValues - 1)) / 8);
                    bits.CopyTo(array, dstIndex, numValues, srcIndex);

                    for (int k = 0;k < array.Length;k++)
                    {
                        if (k >= dstIndex && k <= dstIndex + (numValues - 1))
                        {
                            Assert.AreEqual(array[k], bits[k - dstIndex + srcIndex]);
                        }
                        else
                        {
                            Assert.AreEqual(array[k], arrayCpy[k]);
                        }
                    }
                    
                    for (int j = dstIndex; j < dstIndex + numValues; j++)
                    {
                        array[j] = arrayCpy[j];
                    }
                }

                array.Dispose();
                arrayCpy.Dispose();
            }
        }

        public static void CopyToBitArray_IndexIsNotMultipleOf8_Base(int srcIndex = 0)
        {
            Random64 rng = new Random64(265);

            for (int i = 0; i < 16; i++)
            {
                bit64 bits = (bit64)rng.NextLong();
                NativeBitArray array = new NativeBitArray((int)rng.NextLong(bits.Length, 200), Allocator.Temp);
                NativeBitArray arrayCpy = new NativeBitArray(array.Length, Allocator.Temp);

                for (int j = 0; j < array.Length; j++)
                {
                    bool next = rng.NextBool();
                    array[j] = next;
                    arrayCpy[j] = next;
                }

                for (int numValues = 1; numValues <= bits.Length - srcIndex; numValues++)
                {
                    int dstIndex = (int)rng.NextLong(0, array.Length - (numValues - 1));
                    if (dstIndex % 8 == 0)
                    {
                        if (dstIndex == 0)
                        {
                            if (numValues != bits.Length)
                            {
                                dstIndex++;
                            }
                        }
                        else
                        {
                            dstIndex--;
                        }
                    }

                    bits.CopyTo(array, dstIndex, numValues, srcIndex);

                    for (int k = 0;k < array.Length;k++)
                    {
                        if (k >= dstIndex && k <= dstIndex + (numValues - 1))
                        {
                            Assert.AreEqual(array[k], bits[k - dstIndex + srcIndex]);
                        }
                        else
                        {
                            Assert.AreEqual(array[k], arrayCpy[k]);
                        }
                    }
                    
                    for (int j = dstIndex; j < dstIndex + numValues; j++)
                    {
                        array[j] = arrayCpy[j];
                    }
                }

                array.Dispose();
                arrayCpy.Dispose();
            }
        }

        [Test]
        public static void CopyToArray()
        {
            CopyToArray_Base(0);
        }

        [Test]
        public static void CopyToBitArray_IndexIsMultipleOf8()
        {
            CopyToBitArray_IndexIsMultipleOf8_Base(0);
        }

        [Test]
        public static void CopyToBitArray_IndexIsNotMultipleOf8()
        {
            CopyToBitArray_IndexIsNotMultipleOf8_Base(0);
        }

        [Test]
        public static void CopyToArray_VaryingSourceIndex()
        {
            for (int i = 1; i < 64; i++)
            {
                CopyToArray_Base(i);
            }
        }

        [Test]
        public static void CopyToBitArray_IndexIsMultipleOf8_VaryingSourceIndex()
        {
            for (int i = 1; i < 64; i++)
            {
                CopyToBitArray_IndexIsMultipleOf8_Base(i);
            }
        }

        [Test]
        public static void CopyToBitArray_IndexIsNotMultipleOf8_VaryingSourceIndex()
        {
            for (int i = 1; i < 64; i++)
            {
                CopyToBitArray_IndexIsNotMultipleOf8_Base(i);
            }
        }
    }
}