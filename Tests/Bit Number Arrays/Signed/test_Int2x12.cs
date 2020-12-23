using NUnit.Framework;
using MaxMath;
using Unity.Mathematics;

namespace BitCollections.Tests
{
    internal static class _Int2x12
    {
        internal static Int2x12 TestData_LHS => new Int2x12(Int2.MaxValue, 1, -2, 0, 0, 1, -1, 0, -1, -1, 1, 0);
        internal static Int2x12 TestData_RHS => new Int2x12(Int2.MinValue, 1, -1, -1, -2, 1, 0, -2, 0, -1, -2, -2);


        [Test]
        public static void Constructor_int()
        {
            bool result = true;

            Int2x12 test = new Int2x12(-2);
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
            result &= test.x10 == -2;
            result &= test.x11 == -2;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_intx12()
        {
            bool result = true;

            Int2x12 test = new Int2x12(1, 0, 0, -2, -1, 1, 0, -2, -1, 1, -2, 0);

            result &= test.x0 == 1;
            result &= test.x1 == 0;
            result &= test.x2 == 0;
            result &= test.x3 == -2;
            result &= test.x4 == -1;
            result &= test.x5 == 1;
            result &= test.x6 == 0;
            result &= test.x7 == -2;
            result &= test.x8 == -1;
            result &= test.x9 == 1;
            result &= test.x10 == -2;
            result &= test.x11 == 0;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_int8x2()
        {
            bool result = true;

            int8 valueLo = new int8(-1, 1, 1, -2, -2, 0, 0, 1);
            int4 valueHi = new int4(-2, 0, 0, 1);

            Int2x12 test = new Int2x12(valueLo, valueHi);
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
            result &= test.x10 == valueHi.z;
            result &= test.x11 == valueHi.w;

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
            result &= TestData_LHS[4] == 0;
            result &= TestData_LHS[5] == 1;
            result &= TestData_LHS[6] == -1;
            result &= TestData_LHS[7] == 0;
            result &= TestData_LHS[8] == -1;
            result &= TestData_LHS[9] == -1;
            result &= TestData_LHS[10] == 1;
            result &= TestData_LHS[11] == 0;

            result &= TestData_RHS[0] == Int2.MinValue;
            result &= TestData_RHS[1] == 1;
            result &= TestData_RHS[2] == -1;
            result &= TestData_RHS[3] == -1;
            result &= TestData_RHS[4] == -2;
            result &= TestData_RHS[5] == 1;
            result &= TestData_RHS[6] == 0;
            result &= TestData_RHS[7] == -2;
            result &= TestData_RHS[8] == 0;
            result &= TestData_RHS[9] == -1;
            result &= TestData_RHS[10] == -2;
            result &= TestData_RHS[11] == -2;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetSingle()
        {
            bool result = true;

            Random32 rng = new Random32(1937519u);

            for (int i = 0; i < 12; i++)
            {
                Int2x12 test = TestData_LHS;
                int randomInt = rng.NextInt(Int2.MinValue, Int2.MaxValue + 1);
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
            }

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void GetVector()
        {
            bool result = true;

            for (int i = 0; i < 5; i++)
            {
                int8 test = TestData_LHS.GetSubArray(i);

                result &= test.x0 == TestData_LHS[i];
                result &= test.x1 == TestData_LHS[i + 1];
                result &= test.x2 == TestData_LHS[i + 2];
                result &= test.x3 == TestData_LHS[i + 3];
                result &= test.x4 == TestData_LHS[i + 4];
                result &= test.x5 == TestData_LHS[i + 5];
                result &= test.x6 == TestData_LHS[i + 6];
                result &= test.x7 == TestData_LHS[i + 7];
            }

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetVector()
        {
            bool result = true;
            int8 vector = new int8(0, 1, -1, -1, 0, -2, 1, -2);

            for (int i = 0; i < 5; i++)
            {
                Int2x12 test = TestData_LHS;
                test.SetSubArray(i, vector);

                result &= test[0]  == ((i == 0) ? vector.x0 : TestData_LHS.x0);
                result &= test[1]  == ((i == 1) ? vector.x0 : ((i == 0) ? vector.x1 : TestData_LHS.x1));
                result &= test[2]  == ((i == 2) ? vector.x0 : ((i == 1) ? vector.x1 : ((i == 0) ? vector.x2 : TestData_LHS.x2)));
                result &= test[3]  == ((i == 3) ? vector.x0 : ((i == 2) ? vector.x1 : ((i == 1) ? vector.x2 : ((i == 0) ? vector.x3 : TestData_LHS.x3))));
                result &= test[4]  == ((i == 4) ? vector.x0 : ((i == 3) ? vector.x1 : ((i == 2) ? vector.x2 : ((i == 1) ? vector.x3 : ((i == 0) ? vector.x4 : TestData_LHS.x4)))));
                result &= test[5]  == ((i == 4) ? vector.x1 : ((i == 3) ? vector.x2 : ((i == 2) ? vector.x3 : ((i == 1) ? vector.x4 : ((i == 0) ? vector.x5 : ((i == 0) ? vector.x6 : TestData_LHS.x5))))));
                result &= test[6]  == ((i == 4) ? vector.x2 : ((i == 3) ? vector.x3 : ((i == 2) ? vector.x4 : ((i == 1) ? vector.x5 : ((i == 0) ? vector.x6 : ((i == 1) ? vector.x7 : TestData_LHS.x6))))));
                result &= test[7]  == ((i == 4) ? vector.x3 : ((i == 3) ? vector.x4 : ((i == 2) ? vector.x5 : ((i == 1) ? vector.x6 : ((i == 0) ? vector.x7 : TestData_LHS.x7)))));
                result &= test[8]  == ((i == 4) ? vector.x4 : ((i == 3) ? vector.x5 : ((i == 2) ? vector.x6 : ((i == 1) ? vector.x7 : TestData_LHS.x8))));
                result &= test[9]  == ((i == 4) ? vector.x5 : ((i == 3) ? vector.x6 : ((i == 2) ? vector.x7 : TestData_LHS.x9)));
                result &= test[10] == ((i == 4) ? vector.x6 : ((i == 3) ? vector.x7 : TestData_LHS.x10));
                result &= test[11] == ((i == 4) ? vector.x7 : TestData_LHS.x11);
            }

            Assert.AreEqual(result, true);
        }
    }
}