using NUnit.Framework;
using Unity.Mathematics;
using MaxMath;

namespace BitCollections.Tests
{
    internal static class _Int2x4
    {
        internal static Int2x4 TestData_LHS => new Int2x4(Int2.MaxValue, 1, -2, 0);
        internal static Int2x4 TestData_RHS => new Int2x4(Int2.MinValue, 1, -1, -1);


        [Test]
        public static void Constructor_int()
        {
            bool result = true;

            Int2x4 test = new Int2x4(-2);
            result &= test.x == -2;
            result &= test.y == -2;
            result &= test.z == -2;
            result &= test.w == -2;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_intx2()
        {
            bool result = true;

            Int2x4 test = new Int2x4(1, 0, 0, -2);

            result &= test.x == 1;
            result &= test.y == 0;
            result &= test.z == 0;
            result &= test.w == -2;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_int4()
        {
            bool result = true;

            int4 value = new int4(-1, 1, 1, -2);
            Int2x4 test = new Int2x4(value);
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

            result &= TestData_LHS[0] == Int2.MaxValue;
            result &= TestData_LHS[1] == 1;
            result &= TestData_LHS[2] == -2;
            result &= TestData_LHS[3] == 0;

            result &= TestData_RHS[0] == Int2.MinValue;
            result &= TestData_RHS[1] == 1;
            result &= TestData_RHS[2] == -1;
            result &= TestData_RHS[3] == -1;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetSingle()
        {
            bool result = true;

            Random32 rng = new Random32(1937519u);

            for (int i = 0; i < 4; i++)
            {
                Int2x4 test = TestData_LHS;
                int randomInt = rng.NextInt(Int2.MinValue, Int2.MaxValue + 1);
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