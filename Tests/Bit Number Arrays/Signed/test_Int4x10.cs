using NUnit.Framework;
using MaxMath;
using Unity.Mathematics;

namespace BitCollections.Tests
{
    internal static class _Int4x10
    {
        internal static Int4x10 TestData_LHS => new Int4x10(Int4.MaxValue, 1, 7, -1, 4, -2, 3, 2, -5, 3);
        internal static Int4x10 TestData_RHS => new Int4x10(Int4.MinValue, 1, -3, 3, 2, -4, 0, -5, -1, 6);


        [Test]
        public static void Constructor_int()
        {
            bool result = true;

            Int4x10 test = new Int4x10(-2);
            result &= test.x0 == -2;
            result &= test.x1 == -2;
            result &= test.x2 == -2;
            result &= test.x3 == -2;
            result &= test.x4 == -2;
            result &= test.x5 == -2;
            result &= test.x6 == -2;
            result &= test.x7 == -2;
            result &= test.x8 == -2;
            result &= test.x9 == -2;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_intx10()
        {
            bool result = true;

            Int4x10 test = new Int4x10(1, 7, -1, -2, 6, -1, -5, 2, -8, 1);

            result &= test.x0 == 1;
            result &= test.x1 == 7;
            result &= test.x2 == -1;
            result &= test.x3 == -2;
            result &= test.x4 == 6;
            result &= test.x5 == -1;
            result &= test.x6 == -5;
            result &= test.x7 == 2;
            result &= test.x8 == -8;
            result &= test.x9 == 1;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_int8x2()
        {
            bool result = true;

            int8 valueLo = new int8(-3, 7, -1, 6, -2, 0, -6, 1);
            int2 valueHi = new int2(-2, 7);

            Int4x10 test = new Int4x10(valueLo, valueHi);
            result &= test.x0 == valueLo.x0;
            result &= test.x1 == valueLo.x1;
            result &= test.x2 == valueLo.x2;
            result &= test.x3 == valueLo.x3;
            result &= test.x4 == valueLo.x4;
            result &= test.x5 == valueLo.x5;
            result &= test.x6 == valueLo.x6;
            result &= test.x7 == valueLo.x7;
            result &= test.x8 == valueHi.x;
            result &= test.x9 == valueHi.y;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void GetSingle()
        {
            bool result = true;

            result &= TestData_LHS[0] == Int4.MaxValue;
            result &= TestData_LHS[1] == 1;
            result &= TestData_LHS[2] == 7;
            result &= TestData_LHS[3] == -1;
            result &= TestData_LHS[4] == 4;
            result &= TestData_LHS[5] == -2;
            result &= TestData_LHS[6] == 3;
            result &= TestData_LHS[7] == 2;
            result &= TestData_LHS[8] == -5;
            result &= TestData_LHS[9] == 3;

            result &= TestData_RHS[0] == Int4.MinValue;
            result &= TestData_RHS[1] == 1;
            result &= TestData_RHS[2] == -3;
            result &= TestData_RHS[3] == 3;
            result &= TestData_RHS[4] == 2;
            result &= TestData_RHS[5] == -4;
            result &= TestData_RHS[6] == 0;
            result &= TestData_RHS[7] == -5;
            result &= TestData_RHS[8] == -1;
            result &= TestData_RHS[9] == 6;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetSingle()
        {
            bool result = true;

            Random32 rng = new Random32(1937519u);

            for (int i = 0; i < 10; i++)
            {
                Int4x10 test = TestData_LHS;
                int randomInt = rng.NextInt(Int4.MinValue, Int4.MaxValue + 1);
                test[i] = randomInt;

                result &= test[0]  == ((i == 0)  ? randomInt : TestData_LHS.x0);
                result &= test[1]  == ((i == 1)  ? randomInt : TestData_LHS.x1);
                result &= test[2]  == ((i == 2)  ? randomInt : TestData_LHS.x2);
                result &= test[3]  == ((i == 3)  ? randomInt : TestData_LHS.x3);
                result &= test[4]  == ((i == 4)  ? randomInt : TestData_LHS.x4);
                result &= test[5]  == ((i == 5)  ? randomInt : TestData_LHS.x5);
                result &= test[6]  == ((i == 6)  ? randomInt : TestData_LHS.x6);
                result &= test[7]  == ((i == 7)  ? randomInt : TestData_LHS.x7);
                result &= test[8]  == ((i == 8)  ? randomInt : TestData_LHS.x8);
                result &= test[9]  == ((i == 9)  ? randomInt : TestData_LHS.x9);
            }

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void GetVector()
        {
            bool result = true;

            for (int i = 0; i < 7; i++)
            {
                long4 test = TestData_LHS.GetSubArray(i);

                result &= test.x == TestData_LHS[i];
                result &= test.y == TestData_LHS[i + 1];
                result &= test.z == TestData_LHS[i + 2];
                result &= test.w == TestData_LHS[i + 3];
            }

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetVector()
        {
            bool result = true;
            long4 vector = new long4(-5, -1, 7, 0);

            for (int i = 0; i < 7; i++)
            {
                Int4x10 test = TestData_LHS;
                test.SetSubArray(i, vector);

                result &= test[0] == ((i == 0)  ? vector.x : TestData_LHS.x0);
                result &= test[1] == ((i == 0)  ? vector.y : ((i == 1)  ? vector.x : TestData_LHS.x1));
                result &= test[2] == ((i == 0)  ? vector.z : ((i == 1)  ? vector.y : ((i == 2)  ? vector.x : TestData_LHS.x2)));
                result &= test[3] == ((i == 0)  ? vector.w : ((i == 1)  ? vector.z : ((i == 2)  ? vector.y : ((i == 3) ? vector.x : TestData_LHS.x3))));
                result &= test[4] == ((i == 1)  ? vector.w : ((i == 2)  ? vector.z : ((i == 3)  ? vector.y : ((i == 4) ? vector.x : TestData_LHS.x4))));
                result &= test[5] == ((i == 2)  ? vector.w : ((i == 3)  ? vector.z : ((i == 4)  ? vector.y : ((i == 5) ? vector.x : TestData_LHS.x5))));
                result &= test[6] == ((i == 3)  ? vector.w : ((i == 4)  ? vector.z : ((i == 5)  ? vector.y : ((i == 6) ? vector.x : TestData_LHS.x6))));
                result &= test[7] == ((i == 4)  ? vector.w : ((i == 5)  ? vector.z : ((i == 6)  ? vector.y : TestData_LHS.x7)));
                result &= test[8] == ((i == 5)  ? vector.w : ((i == 6)  ? vector.z : TestData_LHS.x8));
                result &= test[9] == ((i == 6)  ? vector.w : TestData_LHS.x9);
            }

            Assert.AreEqual(result, true);
        }
    }
}