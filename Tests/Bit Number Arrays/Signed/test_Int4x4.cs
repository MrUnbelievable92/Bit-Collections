using NUnit.Framework;
using Unity.Mathematics;
using MaxMath;

namespace BitCollections.Tests
{
    internal static class _Int4x4
    {
        internal static Int4x4 TestData_LHS => new Int4x4(Int4.MaxValue, 1, -1, 4);
        internal static Int4x4 TestData_RHS => new Int4x4(Int4.MinValue, -7, 3, 5);


        [Test]
        public static void Constructor_int()
        {
            bool result = true;

            Int4x4 test = new Int4x4(-4);
            result &= test.x == -4;
            result &= test.y == -4;
            result &= test.z == -4;
            result &= test.w == -4;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_intx2()
        {
            bool result = true;

            Int4x4 test = new Int4x4(-2, 4, 7, 2);

            result &= test.x == -2;
            result &= test.y == 4;
            result &= test.z == 7;
            result &= test.w == 2;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_int4()
        {
            bool result = true;

            int4 value = new int4(-1, -3, 4, 7);
            Int4x4 test = new Int4x4(value);
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

            result &= TestData_LHS[0] == Int4.MaxValue;
            result &= TestData_LHS[1] == 1;
            result &= TestData_LHS[2] == -1;
            result &= TestData_LHS[3] == 4;

            result &= TestData_RHS[0] == Int4.MinValue;
            result &= TestData_RHS[1] == -7;
            result &= TestData_RHS[2] == 3;
            result &= TestData_RHS[3] == 5;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetSingle()
        {
            bool result = true;

            Random32 rng = new Random32(1937519u);

            for (int i = 0; i < 4; i++)
            {
                Int4x4 test = TestData_LHS;
                int randomInt = rng.NextInt(Int4.MinValue, Int4.MaxValue + 1);
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