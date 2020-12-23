using NUnit.Framework;
using Unity.Mathematics;
using MaxMath;

namespace BitCollections.Tests
{
    internal static class _UInt4x2
    {
        internal static UInt4x2 TestData_LHS => new UInt4x2(UInt4.MaxValue, 11);
        internal static UInt4x2 TestData_RHS => new UInt4x2(UInt4.MinValue, 9);


        [Test]
        public static void Constructor_uint()
        {
            bool result = true;

            UInt4x2 test = new UInt4x2(14);
            result &= test.x == 14;
            result &= test.y == 14;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_uintx2()
        {
            bool result = true;

            UInt4x2 test = new UInt4x2(4, 12);

            result &= test.x == 4;
            result &= test.y == 12;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_uint2()
        {
            bool result = true;

            uint2 value = new uint2(2, 15);
            UInt4x2 test = new UInt4x2(value);
            result &= test.x == value.x;
            result &= test.y == value.y;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void GetSingle()
        {
            bool result = true;

            result &= TestData_LHS[0] == UInt4.MaxValue;
            result &= TestData_LHS[1] == 11;

            result &= TestData_RHS[0] == UInt4.MinValue;
            result &= TestData_RHS[1] == 9;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetSingle()
        {
            bool result = true;

            Random32 rng = new Random32(1937519u);

            for (int i = 0; i < 2; i++)
            {
                UInt4x2 test = TestData_LHS;
                uint randomInt = rng.NextUInt(0, UInt4.MaxValue + 1);
                test[i] = randomInt;

                result &= test[0] == ((i == 0) ? randomInt : TestData_LHS.x);
                result &= test[1] == ((i == 1) ? randomInt : TestData_LHS.y);
            }

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void GetVector()
        {
            bool result = true;

            uint2 test = TestData_LHS.xy;
            result &= test.x == TestData_LHS.x;
            result &= test.y == TestData_LHS.y;

            Assert.AreEqual(result, true);
        }
    }
}