using NUnit.Framework;
using MaxMath;

namespace BitCollections.Tests
{
    internal static class _UInt3x8
    {
        internal static UInt3x8 TestData_LHS => new UInt3x8(UInt3.MaxValue, 1, 4, 7, 0, 1, 7, 2);
        internal static UInt3x8 TestData_RHS => new UInt3x8(UInt3.MinValue, 4, 3, 6, 2, 0, 6, 5);


        [Test]
        public static void Constructor_uint()
        {
            bool result = true;

            UInt3x8 test = new UInt3x8(2);
            result &= test.x0 == 2;
            result &= test.x1 == 2;
            result &= test.x2 == 2;
            result &= test.x3 == 2;
            result &= test.x4 == 2;
            result &= test.x5 == 2;
            result &= test.x6 == 2;
            result &= test.x7 == 2;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_uintx8()
        {
            bool result = true;

            UInt3x8 test = new UInt3x8(4, 7, 0, 2, 1, 5, 0, 2);

            result &= test.x0 == 4;
            result &= test.x1 == 7;
            result &= test.x2 == 0;
            result &= test.x3 == 2;
            result &= test.x4 == 1;
            result &= test.x5 == 5;
            result &= test.x6 == 0;
            result &= test.x7 == 2;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_uint8()
        {
            bool result = true;

            uint8 value = new uint8(6, 3, 0, 7, 2, 5, 0, 1);
            UInt3x8 test = new UInt3x8(value);
            result &= test.x0 == value.x0;
            result &= test.x1 == value.x1;
            result &= test.x2 == value.x2;
            result &= test.x3 == value.x3;
            result &= test.x4 == value.x4;
            result &= test.x5 == value.x5;
            result &= test.x6 == value.x6;
            result &= test.x7 == value.x7;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void GetSingle()
        {
            bool result = true;

            result &= TestData_LHS[0] == UInt3.MaxValue;
            result &= TestData_LHS[1] == 1;
            result &= TestData_LHS[2] == 4;
            result &= TestData_LHS[3] == 7;
            result &= TestData_LHS[4] == 0;
            result &= TestData_LHS[5] == 1;
            result &= TestData_LHS[6] == 7;
            result &= TestData_LHS[7] == 2;

            result &= TestData_RHS[0] == UInt3.MinValue;
            result &= TestData_RHS[1] == 4;
            result &= TestData_RHS[2] == 3;
            result &= TestData_RHS[3] == 6;
            result &= TestData_RHS[4] == 2;
            result &= TestData_RHS[5] == 0;
            result &= TestData_RHS[6] == 6;
            result &= TestData_RHS[7] == 5;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetSingle()
        {
            bool result = true;

            Random32 rng = new Random32(1937519u);

            for (int i = 0; i < 8; i++)
            {
                UInt3x8 test = TestData_LHS;
                uint randomInt = rng.NextUInt(0, UInt3.MaxValue + 1);
                test[i] = randomInt;

                result &= test[0] == ((i == 0) ? randomInt : TestData_LHS.x0);
                result &= test[1] == ((i == 1) ? randomInt : TestData_LHS.x1);
                result &= test[2] == ((i == 2) ? randomInt : TestData_LHS.x2);
                result &= test[3] == ((i == 3) ? randomInt : TestData_LHS.x3);
                result &= test[4] == ((i == 4) ? randomInt : TestData_LHS.x4);
                result &= test[5] == ((i == 5) ? randomInt : TestData_LHS.x5);
                result &= test[6] == ((i == 6) ? randomInt : TestData_LHS.x6);
                result &= test[7] == ((i == 7) ? randomInt : TestData_LHS.x7);
            }

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void GetVector()
        {
            bool result = true;

            uint8 test = TestData_LHS.x0_7;

            result &= test.x0 == TestData_LHS.x0;
            result &= test.x1 == TestData_LHS.x1;
            result &= test.x2 == TestData_LHS.x2;
            result &= test.x3 == TestData_LHS.x3;
            result &= test.x4 == TestData_LHS.x4;
            result &= test.x5 == TestData_LHS.x5;
            result &= test.x6 == TestData_LHS.x6;
            result &= test.x7 == TestData_LHS.x7;

            Assert.AreEqual(result, true);
        }
    }
}