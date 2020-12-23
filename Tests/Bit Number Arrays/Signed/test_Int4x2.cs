using NUnit.Framework;
using Unity.Mathematics;
using MaxMath;

namespace BitCollections.Tests
{
    internal static class _Int4x2
    {
        internal static Int4x2 TestData_LHS => new Int4x2(Int4.MaxValue, -1);
        internal static Int4x2 TestData_RHS => new Int4x2(Int4.MinValue, 4);


        [Test]
        public static void Constructor_int()
        {
            bool result = true;

            Int4x2 test = new Int4x2(-4);
            result &= test.x == -4;
            result &= test.y == -4;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_intx2()
        {
            bool result = true;

            Int4x2 test = new Int4x2(4, -2);

            result &= test.x == 4;
            result &= test.y == -2;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_int2()
        {
            bool result = true;

            int2 value = new int2(2, -5);
            Int4x2 test = new Int4x2(value);
            result &= test.x == value.x;
            result &= test.y == value.y;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void GetSingle()
        {
            bool result = true;

            result &= TestData_LHS[0] == Int4.MaxValue;
            result &= TestData_LHS[1] == -1;

            result &= TestData_RHS[0] == Int4.MinValue;
            result &= TestData_RHS[1] == 4;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetSingle()
        {
            bool result = true;

            Random32 rng = new Random32(1937519u);

            for (int i = 0; i < 2; i++)
            {
                Int4x2 test = TestData_LHS;
                int randomInt = rng.NextInt(Int4.MinValue, Int4.MaxValue + 1);
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

            int2 test = TestData_LHS.xy;
            result &= test.x == TestData_LHS.x;
            result &= test.y == TestData_LHS.y;

            Assert.AreEqual(result, true);
        }
    }
}