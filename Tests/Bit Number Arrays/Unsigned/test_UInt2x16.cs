using NUnit.Framework;
using MaxMath;

namespace BitCollections.Tests
{
    internal static class _UInt2x16
    {
        internal static UInt2x16 TestData_LHS => new UInt2x16(UInt2.MaxValue, 1, 2, 0, 0, 1, 3, 0, 3, 3, 1, 0, 2, 3, 1, 2);
        internal static UInt2x16 TestData_RHS => new UInt2x16(UInt2.MinValue, 1, 3, 3, 2, 1, 0, 2, 0, 3, 2, 2, 1, 3, 0, 2);


        [Test]
        public static void Constructor_uint()
        {
            bool result = true;

            UInt2x16 test = new UInt2x16(2);
            result &= test.x0 == 2;
            result &= test.x1 == 2;
            result &= test.x2 == 2;
            result &= test.x3 == 2;
            result &= test.x4 == 2;
            result &= test.x5 == 2;
            result &= test.x6 == 2;
            result &= test.x7 == 2;
            result &= test.x8 == 2;
            result &= test.x9 == 2;
            result &= test.x10 == 2;
            result &= test.x11 == 2;
            result &= test.x12 == 2;
            result &= test.x13 == 2;
            result &= test.x14 == 2;
            result &= test.x15 == 2;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_uintx16()
        {
            bool result = true;

            UInt2x16 test = new UInt2x16(1, 0, 0, 2, 3, 1, 0, 2, 3, 1, 2, 0, 1, 0, 3, 2);

            result &= test.x0 == 1;
            result &= test.x1 == 0;
            result &= test.x2 == 0;
            result &= test.x3 == 2;
            result &= test.x4 == 3;
            result &= test.x5 == 1;
            result &= test.x6 == 0;
            result &= test.x7 == 2;
            result &= test.x8 == 3;
            result &= test.x9 == 1;
            result &= test.x10 == 2;
            result &= test.x11 == 0;
            result &= test.x12 == 1;
            result &= test.x13 == 0;
            result &= test.x14 == 3;
            result &= test.x15 == 2;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_uint8x2()
        {
            bool result = true;

            uint8 valueLo = new uint8(3, 1, 1, 2, 2, 0, 0, 1);
            uint8 valueHi = new uint8(2, 0, 0, 1, 2, 3, 3, 2);

            UInt2x16 test = new UInt2x16(valueLo, valueHi);
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

            result &= TestData_LHS[0] == UInt2.MaxValue;
            result &= TestData_LHS[1] == 1;
            result &= TestData_LHS[2] == 2;
            result &= TestData_LHS[3] == 0;
            result &= TestData_LHS[4] == 0;
            result &= TestData_LHS[5] == 1;
            result &= TestData_LHS[6] == 3;
            result &= TestData_LHS[7] == 0;
            result &= TestData_LHS[8] == 3;
            result &= TestData_LHS[9] == 3;
            result &= TestData_LHS[10] == 1;
            result &= TestData_LHS[11] == 0;
            result &= TestData_LHS[12] == 2;
            result &= TestData_LHS[13] == 3;
            result &= TestData_LHS[14] == 1;
            result &= TestData_LHS[15] == 2;

            result &= TestData_RHS[0] == UInt2.MinValue;
            result &= TestData_RHS[1] == 1;
            result &= TestData_RHS[2] == 3;
            result &= TestData_RHS[3] == 3;
            result &= TestData_RHS[4] == 2;
            result &= TestData_RHS[5] == 1;
            result &= TestData_RHS[6] == 0;
            result &= TestData_RHS[7] == 2;
            result &= TestData_RHS[8] == 0;
            result &= TestData_RHS[9] == 3;
            result &= TestData_RHS[10] == 2;
            result &= TestData_RHS[11] == 2;
            result &= TestData_RHS[12] == 1;
            result &= TestData_RHS[13] == 3;
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
                UInt2x16 test = TestData_LHS;
                uint randomInt = rng.NextUInt(0, UInt2.MaxValue + 1);
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

            for (int i = 0; i < 9; i++)
            {
                uint8 test = TestData_LHS.GetSubArray(i);

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
            uint8 vector = new uint8(0, 1, 3, 3, 0, 2, 1, 2);

            for (int i = 0; i < 9; i++)
            {
                UInt2x16 test = TestData_LHS;
                test.SetSubArray(i, vector);

                result &= test[0]  == ((i == 0) ? vector.x0 : TestData_LHS.x0);
                result &= test[1]  == ((i == 1) ? vector.x0 : ((i == 0) ? vector.x1 : TestData_LHS.x1));
                result &= test[2]  == ((i == 2) ? vector.x0 : ((i == 1) ? vector.x1 : ((i == 0) ? vector.x2 : TestData_LHS.x2)));
                result &= test[3]  == ((i == 3) ? vector.x0 : ((i == 2) ? vector.x1 : ((i == 1) ? vector.x2 : ((i == 0) ? vector.x3 : TestData_LHS.x3))));
                result &= test[4]  == ((i == 4) ? vector.x0 : ((i == 3) ? vector.x1 : ((i == 2) ? vector.x2 : ((i == 1) ? vector.x3 : ((i == 0) ? vector.x4 : TestData_LHS.x4)))));
                result &= test[5]  == ((i == 5) ? vector.x0 : ((i == 4) ? vector.x1 : ((i == 3) ? vector.x2 : ((i == 2) ? vector.x3 : ((i == 1) ? vector.x4 : ((i == 0) ? vector.x5 : TestData_LHS.x5))))));
                result &= test[6]  == ((i == 6) ? vector.x0 : ((i == 5) ? vector.x1 : ((i == 4) ? vector.x2 : ((i == 3) ? vector.x3 : ((i == 2) ? vector.x4 : ((i == 1) ? vector.x5 : ((i == 0) ? vector.x6 : TestData_LHS.x6)))))));
                result &= test[7]  == ((i == 7) ? vector.x0 : ((i == 6) ? vector.x1 : ((i == 5) ? vector.x2 : ((i == 4) ? vector.x3 : ((i == 3) ? vector.x4 : ((i == 2) ? vector.x5 : ((i == 1) ? vector.x6 : ((i == 0) ? vector.x7 : TestData_LHS.x7))))))));
                result &= test[8]  == ((i == 8) ? vector.x0 : ((i == 7) ? vector.x1 : ((i == 6) ? vector.x2 : ((i == 5) ? vector.x3 : ((i == 4) ? vector.x4 : ((i == 3) ? vector.x5 : ((i == 2) ? vector.x6 : ((i == 1) ? vector.x7 : TestData_LHS.x8))))))));
                result &= test[9]  == ((i == 8) ? vector.x1 : ((i == 7) ? vector.x2 : ((i == 6) ? vector.x3 : ((i == 5) ? vector.x4 : ((i == 4) ? vector.x5 : ((i == 3) ? vector.x6 : ((i == 2) ? vector.x7 : TestData_LHS.x9)))))));
                result &= test[10] == ((i == 8) ? vector.x2 : ((i == 7) ? vector.x3 : ((i == 6) ? vector.x4 : ((i == 5) ? vector.x5 : ((i == 4) ? vector.x6 : ((i == 3) ? vector.x7 : TestData_LHS.x10))))));
                result &= test[11] == ((i == 8) ? vector.x3 : ((i == 7) ? vector.x4 : ((i == 6) ? vector.x5 : ((i == 5) ? vector.x6 : ((i == 4) ? vector.x7 : TestData_LHS.x11)))));
                result &= test[12] == ((i == 8) ? vector.x4 : ((i == 7) ? vector.x5 : ((i == 6) ? vector.x6 : ((i == 5) ? vector.x7 : TestData_LHS.x12))));
                result &= test[13] == ((i == 8) ? vector.x5 : ((i == 7) ? vector.x6 : ((i == 6) ? vector.x7 : TestData_LHS.x13)));
                result &= test[14] == ((i == 8) ? vector.x6 : ((i == 7) ? vector.x7 : TestData_LHS.x14));
                result &= test[15] == ((i == 8) ? vector.x7 : TestData_LHS.x15);
            }

            Assert.AreEqual(result, true);
        }
    }
}