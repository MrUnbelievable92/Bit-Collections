using NUnit.Framework;
using Unity.Mathematics;
using MaxMath;

namespace BitCollections.Tests
{
    internal static class _UInt28x2
    {
        internal static UInt28x2 TestData_LHS => new UInt28x2(UInt28.MaxValue, 100888777);
        internal static UInt28x2 TestData_RHS => new UInt28x2(UInt28.MinValue, 100127340);


        [Test]
        public static void Constructor_uint()
        {
            bool result = true;

            UInt28x2 test = new UInt28x2(1747000);
            result &= test.x == 1747000;
            result &= test.y == 1747000;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_uintx2()
        {
            bool result = true;

            UInt28x2 test = new UInt28x2(17, 47);

            result &= test.x == 17;
            result &= test.y == 47;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_uint2()
        {
            bool result = true;

            uint2 value = new uint2(22156523, 30901175);
            UInt28x2 test = new UInt28x2(value);
            result &= test.x == value.x;
            result &= test.y == value.y;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void GetSingle()
        {
            bool result = true;

            result &= TestData_LHS[0] == UInt28.MaxValue;
            result &= TestData_LHS[1] == 100888777;

            result &= TestData_RHS[0] == UInt28.MinValue;
            result &= TestData_RHS[1] == 100127340;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetSingle()
        {
            bool result = true;

            Random32 rng = new Random32(1937519u);

            for (int i = 0; i < 2; i++)
            {
                UInt28x2 test = TestData_LHS;
                uint randomInt = rng.NextUInt(0, UInt28.MaxValue + 1);
                test[i] = randomInt;

                result &= test[0] == ((i == 0) ? randomInt : TestData_LHS.x);
                result &= test[1] == ((i == 1) ? randomInt : TestData_LHS.y);
            }

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void GetVector()
        {
            bool result = true;

            ulong2 test = TestData_LHS.xy;
            result &= test.x == TestData_LHS.x;
            result &= test.y == TestData_LHS.y;

            Assert.AreEqual(result, true);
        }
    }
}