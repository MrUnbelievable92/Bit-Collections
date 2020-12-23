using NUnit.Framework;
using MaxMath;

namespace BitCollections.Tests
{
    internal static class _UInt7x8
    {
        internal static UInt7x8 TestData_LHS => new UInt7x8(UInt7.MaxValue, 111, 2, 21, 99, 55, 123, 50);
        internal static UInt7x8 TestData_RHS => new UInt7x8(UInt7.MinValue, 121, 43, 123, 0, 1, 89, 62);


        [Test]
        public static void Constructor_uint()
        {
            bool result = true;

            UInt7x8 test = new UInt7x8(47);
            result &= test.x0 == 47;
            result &= test.x1 == 47;
            result &= test.x2 == 47;
            result &= test.x3 == 47;
            result &= test.x4 == 47;
            result &= test.x5 == 47;
            result &= test.x6 == 47;
            result &= test.x7 == 47;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_uintx8()
        {
            bool result = true;

            UInt7x8 test = new UInt7x8(1, 30, 120, 12, 117, 47, 0, 113);

            result &= test.x0 == 1;
            result &= test.x1 == 30;
            result &= test.x2 == 120;
            result &= test.x3 == 12;
            result &= test.x4 == 117;
            result &= test.x5 == 47;
            result &= test.x6 == 0;
            result &= test.x7 == 113;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_uint8()
        {
            bool result = true;

            ulong4 valueLo = new ulong4(61, 121, 0, 52);
            ulong4 valueHi = new ulong4(17, 47, 62, 113);
            UInt7x8 test = new UInt7x8(valueLo, valueHi);
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

            result &= TestData_LHS[0] == UInt7.MaxValue;
            result &= TestData_LHS[1] == 111;
            result &= TestData_LHS[2] == 2;
            result &= TestData_LHS[3] == 21;
            result &= TestData_LHS[4] == 99;
            result &= TestData_LHS[5] == 55;
            result &= TestData_LHS[6] == 123;
            result &= TestData_LHS[7] == 50;

            result &= TestData_RHS[0] == UInt7.MinValue;
            result &= TestData_RHS[1] == 121;
            result &= TestData_RHS[2] == 43;
            result &= TestData_RHS[3] == 123;
            result &= TestData_RHS[4] == 0;
            result &= TestData_RHS[5] == 1;
            result &= TestData_RHS[6] == 89;
            result &= TestData_RHS[7] == 62;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetSingle()
        {
            bool result = true;

            Random32 rng = new Random32(1937519u);

            for (int i = 0; i < 8; i++)
            {
                UInt7x8 test = TestData_LHS;
                uint randomInt = rng.NextUInt(0, UInt7.MaxValue + 1);
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
            ulong4 vector = new ulong4(55, 121, 17, 47);

            for (int i = 0; i < 5; i++)
            {
                UInt7x8 test = TestData_LHS;
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