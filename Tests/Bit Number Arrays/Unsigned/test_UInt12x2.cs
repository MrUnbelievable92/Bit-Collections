using NUnit.Framework;
using Unity.Mathematics;
using MaxMath;

namespace BitCollections.Tests
{
    internal static class _UInt12x2
    {
        internal static UInt12x2 TestData_LHS => new UInt12x2(UInt12.MaxValue, 1512);
        internal static UInt12x2 TestData_RHS => new UInt12x2(UInt12.MinValue, 3333);


        [Test]
        public static void Constructor_uint()
        {
            bool result = true;

            UInt12x2 test = new UInt12x2(1747);
            result &= test.x == 1747;
            result &= test.y == 1747;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_uintx2()
        {
            bool result = true;

            UInt12x2 test = new UInt12x2(17, 47);

            result &= test.x == 17;
            result &= test.y == 47;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_uint2()
        {
            bool result = true;

            uint2 value = new uint2(1235, 999);
            UInt12x2 test = new UInt12x2(value);
            result &= test.x == value.x;
            result &= test.y == value.y;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void GetSingle()
        {
            bool result = true;

            result &= TestData_LHS[0] == UInt12.MaxValue;
            result &= TestData_LHS[1] == 1512;

            result &= TestData_RHS[0] == UInt12.MinValue;
            result &= TestData_RHS[1] == 3333;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetSingle()
        {
            bool result = true;

            Random32 rng = new Random32(1937519u);

            for (int i = 0; i < 2; i++)
            {
                UInt12x2 test = TestData_LHS;
                uint randomInt = rng.NextUInt(0, UInt12.MaxValue + 1);
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