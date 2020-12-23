using NUnit.Framework;
using MaxMath;

namespace BitCollections.Tests
{
    internal static class _UInt5x8
    {
        internal static UInt5x8 TestData_LHS => new UInt5x8(UInt5.MaxValue, 30, 2, 21, 0, 25, 23, 22);
        internal static UInt5x8 TestData_RHS => new UInt5x8(UInt5.MinValue, 21, 29, 13, 27, 1, 30, 12);


        [Test]
        public static void Constructor_uint()
        {
            bool result = true;

            UInt5x8 test = new UInt5x8(17);
            result &= test.x0 == 17;
            result &= test.x1 == 17;
            result &= test.x2 == 17;
            result &= test.x3 == 17;
            result &= test.x4 == 17;
            result &= test.x5 == 17;
            result &= test.x6 == 17;
            result &= test.x7 == 17;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_uintx8()
        {
            bool result = true;

            UInt5x8 test = new UInt5x8(1, 30, 12, 30, 17, 27, 11, 29);

            result &= test.x0 == 1;
            result &= test.x1 == 30;
            result &= test.x2 == 12;
            result &= test.x3 == 30;
            result &= test.x4 == 17;
            result &= test.x5 == 27;
            result &= test.x6 == 11;
            result &= test.x7 == 29;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_uint8()
        {
            bool result = true;

            ulong4 valueLo = new ulong4(31, 21, 11, 22);
            ulong4 valueHi = new ulong4(29, 27, 17, 13);
            UInt5x8 test = new UInt5x8(valueLo, valueHi);
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

            result &= TestData_LHS[0] == UInt5.MaxValue;
            result &= TestData_LHS[1] == 30;
            result &= TestData_LHS[2] == 2;
            result &= TestData_LHS[3] == 21;
            result &= TestData_LHS[4] == 0;
            result &= TestData_LHS[5] == 25;
            result &= TestData_LHS[6] == 23;
            result &= TestData_LHS[7] == 22;

            result &= TestData_RHS[0] == UInt5.MinValue;
            result &= TestData_RHS[1] == 21;
            result &= TestData_RHS[2] == 29;
            result &= TestData_RHS[3] == 13;
            result &= TestData_RHS[4] == 27;
            result &= TestData_RHS[5] == 1;
            result &= TestData_RHS[6] == 30;
            result &= TestData_RHS[7] == 12;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetSingle()
        {
            bool result = true;

            Random32 rng = new Random32(1937519u);

            for (int i = 0; i < 8; i++)
            {
                UInt5x8 test = TestData_LHS;
                uint randomInt = rng.NextUInt(0, UInt5.MaxValue + 1);
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
                ulong4 test = TestData_LHS.GetSubArray(i);

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
            ulong4 vector = new ulong4(15, 21, 17, 27);

            for (int i = 0; i < 5; i++)
            {
                UInt5x8 test = TestData_LHS;
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