using NUnit.Framework;
using MaxMath;

namespace BitCollections.Tests
{
    internal static class _UInt4x6
    {
        internal static UInt4x6 TestData_LHS => new UInt4x6(UInt4.MaxValue, 11, 2, 10, 0, 15);
        internal static UInt4x6 TestData_RHS => new UInt4x6(UInt4.MinValue, 11, 3, 13, 2, 1);


        [Test]
        public static void Constructor_uint()
        {
            bool result = true;

            UInt4x6 test = new UInt4x6(2);
            result &= test.x0 == 2;
            result &= test.x1 == 2;
            result &= test.x2 == 2;
            result &= test.x3 == 2;
            result &= test.x4 == 2;
            result &= test.x5 == 2;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_uintx6()
        {
            bool result = true;

            UInt4x6 test = new UInt4x6(1, 10, 0, 12, 13, 1);

            result &= test.x0 == 1;
            result &= test.x1 == 10;
            result &= test.x2 == 0;
            result &= test.x3 == 12;
            result &= test.x4 == 13;
            result &= test.x5 == 1;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_uint8()
        {
            bool result = true;

            uint8 value = new uint8(6, 1, 11, 12, 2, 10, 0, 0);
            UInt4x6 test = new UInt4x6(value);
            result &= test.x0 == value.x0;
            result &= test.x1 == value.x1;
            result &= test.x2 == value.x2;
            result &= test.x3 == value.x3;
            result &= test.x4 == value.x4;
            result &= test.x5 == value.x5;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void GetSingle()
        {
            bool result = true;

            result &= TestData_LHS[0] == UInt4.MaxValue;
            result &= TestData_LHS[1] == 11;
            result &= TestData_LHS[2] == 2;
            result &= TestData_LHS[3] == 10;
            result &= TestData_LHS[4] == 0;
            result &= TestData_LHS[5] == 15;

            result &= TestData_RHS[0] == UInt4.MinValue;
            result &= TestData_RHS[1] == 11;
            result &= TestData_RHS[2] == 3;
            result &= TestData_RHS[3] == 13;
            result &= TestData_RHS[4] == 2;
            result &= TestData_RHS[5] == 1;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetSingle()
        {
            bool result = true;

            Random32 rng = new Random32(1937519u);

            for (int i = 0; i < 6; i++)
            {
                UInt4x6 test = TestData_LHS;
                uint randomInt = rng.NextUInt(0, UInt4.MaxValue + 1);
                test[i] = randomInt;

                result &= test[0] == ((i == 0) ? randomInt : TestData_LHS.x0);
                result &= test[1] == ((i == 1) ? randomInt : TestData_LHS.x1);
                result &= test[2] == ((i == 2) ? randomInt : TestData_LHS.x2);
                result &= test[3] == ((i == 3) ? randomInt : TestData_LHS.x3);
                result &= test[4] == ((i == 4) ? randomInt : TestData_LHS.x4);
                result &= test[5] == ((i == 5) ? randomInt : TestData_LHS.x5);
            }

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void GetVector()
        {
            bool result = true;

            uint8 test = TestData_LHS.x0_5;

            result &= test.x0 == TestData_LHS.x0;
            result &= test.x1 == TestData_LHS.x1;
            result &= test.x2 == TestData_LHS.x2;
            result &= test.x3 == TestData_LHS.x3;
            result &= test.x4 == TestData_LHS.x4;
            result &= test.x5 == TestData_LHS.x5;

            Assert.AreEqual(result, true);
        }
    }
}