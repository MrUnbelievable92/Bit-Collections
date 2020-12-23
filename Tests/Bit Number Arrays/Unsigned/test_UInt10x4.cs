using NUnit.Framework;
using MaxMath;

namespace BitCollections.Tests
{
    internal static class _UInt10x4
    {
        internal static UInt10x4 TestData_LHS => new UInt10x4(UInt10.MaxValue, 17, 47, 21);
        internal static UInt10x4 TestData_RHS => new UInt10x4(UInt10.MinValue, 555, 999, 192);


        [Test]
        public static void Constructor_uint()
        {
            bool result = true;

            UInt10x4 test = new UInt10x4(888);
            result &= test.x == 888;
            result &= test.y == 888;
            result &= test.z == 888;
            result &= test.w == 888;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_uintx2()
        {
            bool result = true;

            UInt10x4 test = new UInt10x4(17, 47, 21, 777);

            result &= test.x == 17;
            result &= test.y == 47;
            result &= test.z == 21;
            result &= test.w == 777;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_uint4()
        {
            bool result = true;

            ulong4 value = new ulong4(256, 999, 0, 3);
            UInt10x4 test = new UInt10x4(value);
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

            result &= TestData_LHS[0] == UInt10.MaxValue;
            result &= TestData_LHS[1] == 17;
            result &= TestData_LHS[2] == 47;
            result &= TestData_LHS[3] == 21;

            result &= TestData_RHS[0] == UInt10.MinValue;
            result &= TestData_RHS[1] == 555;
            result &= TestData_RHS[2] == 999;
            result &= TestData_RHS[3] == 192;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetSingle()
        {
            bool result = true;

            Random32 rng = new Random32(1937519u);

            for (int i = 0; i < 4; i++)
            {
                UInt10x4 test = TestData_LHS;
                uint randomInt = rng.NextUInt(0, UInt10.MaxValue + 1);
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

            ulong4 test = TestData_LHS.xyzw;
            result &= test.x == TestData_LHS.x;
            result &= test.y == TestData_LHS.y;
            result &= test.z == TestData_LHS.z;
            result &= test.w == TestData_LHS.w;

            Assert.AreEqual(result, true);
        }
    }
}