using NUnit.Framework;
using MaxMath;

namespace BitCollections.Tests
{
    internal static class _Int10x4
    {
        internal static Int10x4 TestData_LHS => new Int10x4(Int10.MaxValue, 17, 47, -21);
        internal static Int10x4 TestData_RHS => new Int10x4(Int10.MinValue, -444, -99, 192);


        [Test]
        public static void Constructor_int()
        {
            bool result = true;

            Int10x4 test = new Int10x4(-200);
            result &= test.x == -200;
            result &= test.y == -200;
            result &= test.z == -200;
            result &= test.w == -200;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_intx2()
        {
            bool result = true;

            Int10x4 test = new Int10x4(17, 47, -21, -77);

            result &= test.x == 17;
            result &= test.y == 47;
            result &= test.z == -21;
            result &= test.w == -77;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_int4()
        {
            bool result = true;

            long4 value = new long4(256, -99, 0, -1);
            Int10x4 test = new Int10x4(value);
            result &= test.x == value.x;
            result &= test.y == value.y;
            result &= test.z == value.z;
            result &= test.w == value.w;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void GetSingle()
        {
            bool result = true;

            result &= TestData_LHS[0] == Int10.MaxValue;
            result &= TestData_LHS[1] == 17;
            result &= TestData_LHS[2] == 47;
            result &= TestData_LHS[3] == -21;

            result &= TestData_RHS[0] == Int10.MinValue;
            result &= TestData_RHS[1] == -444;
            result &= TestData_RHS[2] == -99;
            result &= TestData_RHS[3] == 192;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetSingle()
        {
            bool result = true;

            Random32 rng = new Random32(1937519u);

            for (int i = 0; i < 4; i++)
            {
                Int10x4 test = TestData_LHS;
                int randomInt = rng.NextInt(Int10.MinValue, Int10.MaxValue + 1);
                test[i] = randomInt;

                result &= test[0] == ((i == 0) ? randomInt : TestData_LHS.x);
                result &= test[1] == ((i == 1) ? randomInt : TestData_LHS.y);
                result &= test[2] == ((i == 2) ? randomInt : TestData_LHS.z);
                result &= test[3] == ((i == 3) ? randomInt : TestData_LHS.w);
            }

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void GetVector()
        {
            bool result = true;

            long4 test = TestData_LHS.xyzw;
            result &= test.x == TestData_LHS.x;
            result &= test.y == TestData_LHS.y;
            result &= test.z == TestData_LHS.z;
            result &= test.w == TestData_LHS.w;

            Assert.AreEqual(result, true);
        }
    }
}