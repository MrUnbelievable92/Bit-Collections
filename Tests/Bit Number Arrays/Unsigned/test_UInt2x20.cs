using NUnit.Framework;
using MaxMath;
using Unity.Mathematics;

namespace BitCollections.Tests
{
    internal static class _UInt2x20
    {
        internal static UInt2x20 TestData_LHS => new UInt2x20(UInt2.MaxValue, 1, 2, 0, 0, 1, 3, 0, 3, 3, 1, 0, 2, 3, 1, 2, 3, 3, 3, 0);
        internal static UInt2x20 TestData_RHS => new UInt2x20(UInt2.MinValue, 1, 3, 3, 2, 1, 0, 2, 0, 3, 2, 2, 1, 3, 0, 2, 2, 1, 1, 1);


        [Test]
        public static void Constructor_uint()
        {
            bool result = true;

            UInt2x20 test = new UInt2x20(2);
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
            result &= test.x16 == 2;
            result &= test.x17 == 2;
            result &= test.x18 == 2;
            result &= test.x19 == 2;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_uintx20()
        {
            bool result = true;

            UInt2x20 test = new UInt2x20(1, 0, 0, 2, 3, 1, 0, 2, 3, 1, 2, 0, 1, 0, 3, 2, 3, 0, 1, 2);

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
            result &= test.x16 == 3;
            result &= test.x17 == 0;
            result &= test.x18 == 1;
            result &= test.x19 == 2;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_uint8x2()
        {
            bool result = true;

            uint8 value0 = new uint8(3, 1, 1, 2, 2, 0, 0, 1);
            uint8 value1 = new uint8(2, 0, 0, 1, 2, 3, 3, 2);
            uint4 value2 = new uint4(2, 2, 0, 3);

            UInt2x20 test = new UInt2x20(value0, value1, value2);
            result &= test.x0 == value0.x0;
            result &= test.x1 == value0.x1;
            result &= test.x2 == value0.x2;
            result &= test.x3 == value0.x3;
            result &= test.x4 == value0.x4;
            result &= test.x5 == value0.x5;
            result &= test.x6 == value0.x6;
            result &= test.x7 == value0.x7;
            result &= test.x8 == value1.x0;
            result &= test.x9 == value1.x1;
            result &= test.x10 == value1.x2;
            result &= test.x11 == value1.x3;
            result &= test.x12 == value1.x4;
            result &= test.x13 == value1.x5;
            result &= test.x14 == value1.x6;
            result &= test.x15 == value1.x7;
            result &= test.x16 == value2.x;
            result &= test.x17 == value2.y;
            result &= test.x18 == value2.z;
            result &= test.x19 == value2.w;

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
            result &= TestData_LHS[16] == 3;
            result &= TestData_LHS[17] == 3;
            result &= TestData_LHS[18] == 3;
            result &= TestData_LHS[19] == 0;

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
            result &= TestData_RHS[16] == 2;
            result &= TestData_RHS[17] == 1;
            result &= TestData_RHS[18] == 1;
            result &= TestData_RHS[19] == 1;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetSingle()
        {
            bool result = true;

            Random32 rng = new Random32(1937519u);

            for (int i = 0; i < 20; i++)
            {
                UInt2x20 test = TestData_LHS;
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
                result &= test[16] == ((i == 16) ? randomInt : TestData_LHS.x16);
                result &= test[17] == ((i == 17) ? randomInt : TestData_LHS.x17);
                result &= test[18] == ((i == 18) ? randomInt : TestData_LHS.x18);
                result &= test[19] == ((i == 19) ? randomInt : TestData_LHS.x19);
            }

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void GetVector()
        {
            bool result = true;

            for (int i = 0; i < 17; i++)
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
            ulong4 vector = new ulong4(0, 1, 3, 2);

            for (int i = 0; i < 17; i++)
            {
                UInt2x20 test = TestData_LHS;
                test.SetSubArray(i, vector);

                result &= test[0]  == ((i == 0)  ? vector.x : TestData_LHS.x0);
                result &= test[1]  == ((i == 0)  ? vector.y : ((i == 1)  ? vector.x : TestData_LHS.x1));
                result &= test[2]  == ((i == 0)  ? vector.z : ((i == 1)  ? vector.y : ((i == 2)  ? vector.x : TestData_LHS.x2)));
                result &= test[3]  == ((i == 0)  ? vector.w : ((i == 1)  ? vector.z : ((i == 2)  ? vector.y : ((i == 3)  ? vector.x : TestData_LHS.x3))));
                result &= test[4]  == ((i == 1)  ? vector.w : ((i == 2)  ? vector.z : ((i == 3)  ? vector.y : ((i == 4)  ? vector.x : TestData_LHS.x4))));
                result &= test[5]  == ((i == 2)  ? vector.w : ((i == 3)  ? vector.z : ((i == 4)  ? vector.y : ((i == 5)  ? vector.x : TestData_LHS.x5))));
                result &= test[6]  == ((i == 3)  ? vector.w : ((i == 4)  ? vector.z : ((i == 5)  ? vector.y : ((i == 6)  ? vector.x : TestData_LHS.x6))));
                result &= test[7]  == ((i == 4)  ? vector.w : ((i == 5)  ? vector.z : ((i == 6)  ? vector.y : ((i == 7)  ? vector.x : TestData_LHS.x7))));
                result &= test[8]  == ((i == 5)  ? vector.w : ((i == 6)  ? vector.z : ((i == 7)  ? vector.y : ((i == 8)  ? vector.x : TestData_LHS.x8))));
                result &= test[9]  == ((i == 6)  ? vector.w : ((i == 7)  ? vector.z : ((i == 8)  ? vector.y : ((i == 9)  ? vector.x : TestData_LHS.x9))));
                result &= test[10] == ((i == 7)  ? vector.w : ((i == 8)  ? vector.z : ((i == 9)  ? vector.y : ((i == 10) ? vector.x : TestData_LHS.x10))));
                result &= test[11] == ((i == 8)  ? vector.w : ((i == 9)  ? vector.z : ((i == 10) ? vector.y : ((i == 11) ? vector.x : TestData_LHS.x11))));
                result &= test[12] == ((i == 9)  ? vector.w : ((i == 10) ? vector.z : ((i == 11) ? vector.y : ((i == 12) ? vector.x : TestData_LHS.x12))));
                result &= test[13] == ((i == 10) ? vector.w : ((i == 11) ? vector.z : ((i == 12) ? vector.y : ((i == 13) ? vector.x : TestData_LHS.x13))));
                result &= test[14] == ((i == 11) ? vector.w : ((i == 12) ? vector.z : ((i == 13) ? vector.y : ((i == 14) ? vector.x : TestData_LHS.x14))));
                result &= test[15] == ((i == 12) ? vector.w : ((i == 13) ? vector.z : ((i == 14) ? vector.y : ((i == 15) ? vector.x : TestData_LHS.x15))));
                result &= test[16] == ((i == 13) ? vector.w : ((i == 14) ? vector.z : ((i == 15) ? vector.y : ((i == 16) ? vector.x : TestData_LHS.x16))));
                result &= test[17] == ((i == 14) ? vector.w : ((i == 15) ? vector.z : ((i == 16) ? vector.y : TestData_LHS.x17)));
                result &= test[18] == ((i == 15) ? vector.w : ((i == 16) ? vector.z : TestData_LHS.x18));
                result &= test[19] == ((i == 16) ? vector.w : TestData_LHS.x19);
            }                                
                                             
            Assert.AreEqual(result, true);                   
        }
    }
}