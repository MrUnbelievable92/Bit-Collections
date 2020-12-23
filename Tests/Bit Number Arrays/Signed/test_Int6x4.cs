using NUnit.Framework;
using Unity.Mathematics;
using MaxMath;

namespace BitCollections.Tests
{
    internal static class _Int6x4
    {
        internal static Int6x4 TestData_LHS => new Int6x4(Int6.MaxValue, -21, 16, -29);
        internal static Int6x4 TestData_RHS => new Int6x4(Int6.MinValue, 30, -23, 25);


        [Test]
        public static void Constructor_int()
        {
            bool result = true;

            Int6x4 test = new Int6x4(-16);
            result &= test.x == -16;
            result &= test.y == -16;
            result &= test.z == -16;
            result &= test.w == -16;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_intx2()
        {
            bool result = true;

            Int6x4 test = new Int6x4(12, -29, -1, 19);

            result &= test.x == 12;
            result &= test.y == -29;
            result &= test.z == -1;
            result &= test.w == 19;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_int4()
        {
            bool result = true;

            int4 value = new int4(22, 13, -7, 16);
            Int6x4 test = new Int6x4(value);
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

            result &= TestData_LHS[0] == Int6.MaxValue;
            result &= TestData_LHS[1] == -21;
            result &= TestData_LHS[2] == 16;
            result &= TestData_LHS[3] == -29;

            result &= TestData_RHS[0] == Int6.MinValue;
            result &= TestData_RHS[1] == 30;
            result &= TestData_RHS[2] == -23;
            result &= TestData_RHS[3] == 25;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetSingle()
        {
            bool result = true;

            Random32 rng = new Random32(1937519u);

            for (int i = 0; i < 4; i++)
            {
                Int6x4 test = TestData_LHS;
                int randomInt = rng.NextInt(Int6.MinValue, Int6.MaxValue + 1);
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

            int4 test = TestData_LHS.xyzw;
            result &= test.x == TestData_LHS.x;
            result &= test.y == TestData_LHS.y;
            result &= test.z == TestData_LHS.z;
            result &= test.w == TestData_LHS.w;

            Assert.AreEqual(result, true);
        }
    }
}