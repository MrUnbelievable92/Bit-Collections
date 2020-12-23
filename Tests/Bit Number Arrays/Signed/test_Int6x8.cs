using NUnit.Framework;
using MaxMath;

namespace BitCollections.Tests
{
    internal static class _Int6x8
    {
        internal static Int6x8 TestData_LHS => new Int6x8(Int6.MaxValue, 11, 2, 21, 0, -15, 23, -30);
        internal static Int6x8 TestData_RHS => new Int6x8(Int6.MinValue, 21, -1, -23, 22, 1, 20, -12);


        [Test]
        public static void Constructor_int()
        {
            bool result = true;

            Int6x8 test = new Int6x8(-1);
            result &= test.x0 == -1;
            result &= test.x1 == -1;
            result &= test.x2 == -1;
            result &= test.x3 == -1;
            result &= test.x4 == -1;
            result &= test.x5 == -1;
            result &= test.x6 == -1;
            result &= test.x7 == -1;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_intx8()
        {
            bool result = true;

            Int6x8 test = new Int6x8(1, 30, -20, 12, 17, -17, -1, 13);

            result &= test.x0 == 1;
            result &= test.x1 == 30;
            result &= test.x2 == -20;
            result &= test.x3 == 12;
            result &= test.x4 == 17;
            result &= test.x5 == -17;
            result &= test.x6 == -1;
            result &= test.x7 == 13;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_int8()
        {
            bool result = true;

            long4 valueLo = new long4(-1, 21, 11, -22);
            long4 valueHi = new long4(17, -7, -2, 13);
            Int6x8 test = new Int6x8(valueLo, valueHi);
            result &= test.x0 == valueLo.x;
            result &= test.x1 == valueLo.y;
            result &= test.x2 == valueLo.z;
            result &= test.x3 == valueLo.w;
            result &= test.x4 == valueHi.x;
            result &= test.x5 == valueHi.y;
            result &= test.x6 == valueHi.z;
            result &= test.x7 == valueHi.w;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void GetSingle()
        {
            bool result = true;

            result &= TestData_LHS[0] == Int6.MaxValue;
            result &= TestData_LHS[1] == 11;
            result &= TestData_LHS[2] == 2;
            result &= TestData_LHS[3] == 21;
            result &= TestData_LHS[4] == 0;
            result &= TestData_LHS[5] == -15;
            result &= TestData_LHS[6] == 23;
            result &= TestData_LHS[7] == -30;

            result &= TestData_RHS[0] == Int6.MinValue;
            result &= TestData_RHS[1] == 21;
            result &= TestData_RHS[2] == -1;
            result &= TestData_RHS[3] == -23;
            result &= TestData_RHS[4] == 22;
            result &= TestData_RHS[5] == 1;
            result &= TestData_RHS[6] == 20;
            result &= TestData_RHS[7] == -12;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetSingle()
        {
            bool result = true;

            Random32 rng = new Random32(1937519u);

            for (int i = 0; i < 8; i++)
            {
                Int6x8 test = TestData_LHS;
                int randomInt = rng.NextInt(Int6.MinValue, Int6.MaxValue + 1);
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

        public static void GetVector()
        {
            bool result = true;

            for (int i = 0; i < 5; i++)
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
            long4 vector = new long4(-25, 21, 17, -17);

            for (int i = 0; i < 5; i++)
            {
                Int6x8 test = TestData_LHS;
                test.SetSubArray(i, vector);

                result &= test[0] == ((i == 0) ? vector.x : TestData_LHS.x0);
                result &= test[1] == ((i == 1) ? vector.x : ((i == 0) ? vector.y : TestData_LHS.x1));
                result &= test[2] == ((i == 2) ? vector.x : ((i == 1) ? vector.y : ((i == 0) ? vector.z : TestData_LHS.x2)));
                result &= test[3] == ((i == 3) ? vector.x : ((i == 2) ? vector.y : ((i == 1) ? vector.z : ((i == 0) ? vector.w : TestData_LHS.x3))));
                result &= test[4] == ((i == 4) ? vector.x : ((i == 3) ? vector.y : ((i == 2) ? vector.z : ((i == 1) ? vector.w : TestData_LHS.x4))));
                result &= test[5] == ((i == 4) ? vector.y : ((i == 3) ? vector.z : ((i == 2) ? vector.w : TestData_LHS.x5)));
                result &= test[6] == ((i == 4) ? vector.z : ((i == 3) ? vector.w : TestData_LHS.x6));
                result &= test[7] == ((i == 4) ? vector.w : TestData_LHS.x7);
            }

            Assert.AreEqual(result, true);
        }
    }
}