using NUnit.Framework;
using MaxMath;

namespace BitCollections.Tests
{
    internal static class _Int3x16
    {
        internal static Int3x16 TestData_LHS => new Int3x16(Int3.MaxValue, 1, -4, 0, -3, 1, 3, 2, -2, 3, 1, -1, 2, 3, -4, 2);
        internal static Int3x16 TestData_RHS => new Int3x16(Int3.MinValue, 1, 3, 3, 2, -3, 0, -2, 0, -1, 2, -1, 1, -4, 0, 2);


        [Test]
        public static void Constructor_int()
        {
            bool result = true;

            Int3x16 test = new Int3x16(-3);
            result &= test.x0 == -3;
            result &= test.x1 == -3;
            result &= test.x2 == -3;
            result &= test.x3 == -3;
            result &= test.x4 == -3;
            result &= test.x5 == -3;
            result &= test.x6 == -3;
            result &= test.x7 == -3;
            result &= test.x8 == -3;
            result &= test.x9 == -3;
            result &= test.x10 == -3;
            result &= test.x11 == -3;
            result &= test.x12 == -3;
            result &= test.x13 == -3;
            result &= test.x14 == -3;
            result &= test.x15 == -3;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_intx16()
        {
            bool result = true;

            Int3x16 test = new Int3x16(1, -4, 0, 2, -3, 1, -2, 2, 3, 1, -1, 0, -4, -3, 3, 2);

            result &= test.x0 == 1;
            result &= test.x1 == -4;
            result &= test.x2 == 0;
            result &= test.x3 == 2;
            result &= test.x4 == -3;
            result &= test.x5 == 1;
            result &= test.x6 == -2;
            result &= test.x7 == 2;
            result &= test.x8 == 3;
            result &= test.x9 == 1;
            result &= test.x10 == -1;
            result &= test.x11 == 0;
            result &= test.x12 == -4;
            result &= test.x13 == -3;
            result &= test.x14 == 3;
            result &= test.x15 == 2;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_int8x2()
        {
            bool result = true;

            int8 valueLo = new int8(3, -4, 1, -3, 2, 0, -3, 1);
            int8 valueHi = new int8(2, -4, -2, 1, 2, -1, -1, 2);

            Int3x16 test = new Int3x16(valueLo, valueHi);
            result &= test.x0 == valueLo.x0;
            result &= test.x1 == valueLo.x1;
            result &= test.x2 == valueLo.x2;
            result &= test.x3 == valueLo.x3;
            result &= test.x4 == valueLo.x4;
            result &= test.x5 == valueLo.x5;
            result &= test.x6 == valueLo.x6;
            result &= test.x7 == valueLo.x7;
            result &= test.x8 == valueHi.x0;
            result &= test.x9 == valueHi.x1;
            result &= test.x10 == valueHi.x2;
            result &= test.x11 == valueHi.x3;
            result &= test.x12 == valueHi.x4;
            result &= test.x13 == valueHi.x5;
            result &= test.x14 == valueHi.x6;
            result &= test.x15 == valueHi.x7;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void GetSingle()
        {
            bool result = true;

            result &= TestData_LHS[0] == Int3.MaxValue;
            result &= TestData_LHS[1] == 1;
            result &= TestData_LHS[2] == -4;
            result &= TestData_LHS[3] == 0;
            result &= TestData_LHS[4] == -3;
            result &= TestData_LHS[5] == 1;
            result &= TestData_LHS[6] == 3;
            result &= TestData_LHS[7] == 2;
            result &= TestData_LHS[8] == -2;
            result &= TestData_LHS[9] == 3;
            result &= TestData_LHS[10] == 1;
            result &= TestData_LHS[11] == -1;
            result &= TestData_LHS[12] == 2;
            result &= TestData_LHS[13] == 3;
            result &= TestData_LHS[14] == -4;
            result &= TestData_LHS[15] == 2;

            result &= TestData_RHS[0] == Int3.MinValue;
            result &= TestData_RHS[1] == 1;
            result &= TestData_RHS[2] == 3;
            result &= TestData_RHS[3] == 3;
            result &= TestData_RHS[4] == 2;
            result &= TestData_RHS[5] == -3;
            result &= TestData_RHS[6] == 0;
            result &= TestData_RHS[7] == -2;
            result &= TestData_RHS[8] == 0;
            result &= TestData_RHS[9] == -1;
            result &= TestData_RHS[10] == 2;
            result &= TestData_RHS[11] == -1;
            result &= TestData_RHS[12] == 1;
            result &= TestData_RHS[13] == -4;
            result &= TestData_RHS[14] == 0;
            result &= TestData_RHS[15] == 2;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetSingle()
        {
            bool result = true;

            Random32 rng = new Random32(1937519u);

            for (int i = 0; i < 16; i++)
            {
                Int3x16 test = TestData_LHS;
                int randomInt = rng.NextInt(Int3.MinValue, Int3.MaxValue + 1);
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
                result &= test[10] == ((i == 10) ? randomInt : TestData_LHS.x10);
                result &= test[11] == ((i == 11) ? randomInt : TestData_LHS.x11);
                result &= test[12] == ((i == 12) ? randomInt : TestData_LHS.x12);
                result &= test[13] == ((i == 13) ? randomInt : TestData_LHS.x13);
                result &= test[14] == ((i == 14) ? randomInt : TestData_LHS.x14);
                result &= test[15] == ((i == 15) ? randomInt : TestData_LHS.x15);
            }

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void GetVector()
        {
            bool result = true;

            for (int i = 0; i < 13; i++)
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
            long4 vector = new long4(-1, 1, -4, 0);

            for (int i = 0; i < 13; i++)
            {
                Int3x16 test = TestData_LHS;
                test.SetSubArray(i, vector);

                result &= test[0]  == ((i == 0)  ? vector.x : TestData_LHS.x0);
                result &= test[1]  == ((i == 1)  ? vector.x : ((i == 0)  ? vector.y : TestData_LHS.x1));
                result &= test[2]  == ((i == 2)  ? vector.x : ((i == 1)  ? vector.y : ((i == 0)  ? vector.z : TestData_LHS.x2)));
                result &= test[3]  == ((i == 3)  ? vector.x : ((i == 2)  ? vector.y : ((i == 1)  ? vector.z : ((i == 0) ? vector.w : TestData_LHS.x3))));
                result &= test[4]  == ((i == 4)  ? vector.x : ((i == 3)  ? vector.y : ((i == 2)  ? vector.z : ((i == 1) ? vector.w : TestData_LHS.x4))));
                result &= test[5]  == ((i == 5)  ? vector.x : ((i == 4)  ? vector.y : ((i == 3)  ? vector.z : ((i == 2) ? vector.w : TestData_LHS.x5))));
                result &= test[6]  == ((i == 6)  ? vector.x : ((i == 5)  ? vector.y : ((i == 4)  ? vector.z : ((i == 3) ? vector.w : TestData_LHS.x6))));
                result &= test[7]  == ((i == 7)  ? vector.x : ((i == 6)  ? vector.y : ((i == 5)  ? vector.z : ((i == 4) ? vector.w : TestData_LHS.x7))));
                result &= test[8]  == ((i == 8)  ? vector.x : ((i == 7)  ? vector.y : ((i == 6)  ? vector.z : ((i == 5) ? vector.w : TestData_LHS.x8))));
                result &= test[9]  == ((i == 9)  ? vector.x : ((i == 8)  ? vector.y : ((i == 7)  ? vector.z : ((i == 6) ? vector.w : TestData_LHS.x9))));
                result &= test[10] == ((i == 10) ? vector.x : ((i == 9)  ? vector.y : ((i == 8)  ? vector.z : ((i == 7) ? vector.w : TestData_LHS.x10))));
                result &= test[11] == ((i == 11) ? vector.x : ((i == 10) ? vector.y : ((i == 9)  ? vector.z : ((i == 8) ? vector.w : TestData_LHS.x11))));
                result &= test[12] == ((i == 12) ? vector.x : ((i == 11) ? vector.y : ((i == 10) ? vector.z : ((i == 9) ? vector.w : TestData_LHS.x12))));
                result &= test[13] == ((i == 12) ? vector.y : ((i == 11) ? vector.z : ((i == 10) ? vector.w : TestData_LHS.x13)));
                result &= test[14] == ((i == 12) ? vector.z : ((i == 11) ? vector.w : TestData_LHS.x14));
                result &= test[15] == ((i == 12) ? vector.w : TestData_LHS.x15);
            }

            Assert.AreEqual(result, true);
        }
    }
}