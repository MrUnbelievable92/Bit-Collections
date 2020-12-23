using NUnit.Framework;

namespace BitCollections.Tests
{
    internal static class _bit8
    {
        internal static bit8 TestData_LHS => new bit8{ intern = 0b1101_1010};
        internal static bit8 TestData_RHS => new bit8{ intern = 0b1000_0110};


        [Test]        
        public static void Constructor_boolx8()
        {
            bit8 test = new bit8(true, 
                                 false,
                                 false,
                                 true,
                                 
                                 true, 
                                 true, 
                                 false, 
                                 true);

            Assert.AreEqual(test.intern == 0b1011_1001, true);
        }

        [Test]
        public static void Get()
        {
            bool result = true;

            result &= TestData_LHS[0] == false;
            result &= TestData_LHS[1] == true;
            result &= TestData_LHS[2] == false;
            result &= TestData_LHS[3] == true;

            result &= TestData_LHS[4] == true;
            result &= TestData_LHS[5] == false;
            result &= TestData_LHS[6] == true;
            result &= TestData_LHS[7] == true;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Set()
        {
            bool result = true;

            for (int i = 0; i < 8; i++)
            {
                bit8 test = TestData_LHS;
                test[i] = false;
                result &= test.intern == (TestData_LHS.intern & ~(1 << i));
            }

            for (int i = 0; i < 8; i++)
            {
                bit8 test = TestData_LHS;
                test[i] = true;
                result &= test.intern == (TestData_LHS.intern | (1 << i));
            }

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void IndexOfFirst()
        {
            bool result = true;

            result &= TestData_LHS.IndexOfFirst() == 1;
            result &= TestData_RHS.IndexOfFirst() == 1;

            result &= TestData_LHS.IndexOfFirst(4, 3) == 4;
            result &= TestData_RHS.IndexOfFirst(4, 3) == 32;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void IndexOfLast()
        {
            bool result = true;

            result &= TestData_LHS.IndexOfLast() == 7;
            result &= TestData_RHS.IndexOfLast() == 7;

            result &= TestData_LHS.IndexOfLast(4, 3) == 6;
            result &= TestData_RHS.IndexOfLast(4, 3) == -1;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void ShiftLeft()
        {
            bool result = true;

            bit8 x = TestData_LHS;
            x.ShiftLeft(4, 3, 2);
            result &= x.intern == 0b1100_1010;

            x = TestData_RHS;
            x.ShiftLeft(2, 5, 3);
            result &= x.intern == 0b1010_0010;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void ShiftRight()
        {
            bool result = true;

            bit8 x = TestData_LHS;
            x.ShiftRight(4, 3, 2);
            result &= x.intern == 0b1001_1010;

            x = TestData_RHS;
            x.ShiftRight(2, 5, 3);
            result &= x.intern == 0b1000_0010;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void RotateLeft()
        {
            bool result = true;

            bit8 x = TestData_LHS;
            x.RotateLeft(4, 3, 2);
            result &= x.intern == 0b1110_1010;

            x = TestData_RHS;
            x.RotateLeft(2, 5, 3);
            result &= x.intern == 0b1010_0010;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void RotateRight()
        {
            bool result = true;

            bit8 x = TestData_LHS;
            x.RotateRight(4, 3, 2);
            result &= x.intern == 0b1011_1010;

            x = TestData_RHS;
            x.RotateRight(2, 5, 3);
            result &= x.intern == 0b1001_0010;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Swap()
        {
            bool result = true;

            bit8 x = TestData_LHS;
            x.Swap(3, 7);
            result &= x.intern == 0b1101_1010;

            x = TestData_RHS;
            x.Swap(3, 7);
            result &= x.intern == 0b0000_1110;


            x = TestData_LHS;
            x.Swap(2, 4, 2);
            result &= x.intern == 0b1110_0110;

            x = TestData_RHS;
            x.Swap(1, 4, 3);
            result &= x.intern == 0b1011_0000;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Flip()
        {
            bool result = true;

            bit8 x = TestData_LHS;
            x.Flip(2, 4);
            result &= x.intern == 0b1110_0110;

            x = TestData_RHS;
            x.Flip(3, 3);
            result &= x.intern == 0b1011_1110;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Reverse()
        {
            bool result = true;

            bit8 x = TestData_LHS;
            x.Reverse();
            result &= x.intern == 0b0101_1011;

            x = TestData_RHS;
            x.Reverse();
            result &= x.intern == 0b0110_0001;

            x = TestData_LHS;
            x.Reverse(2, 5);
            result &= x.intern == 0b1011_0110;

            x = TestData_RHS;
            x.Reverse(5, 3);
            result &= x.intern == 0b0010_0110;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetBits()
        {
            bool result = true;

            bit8 x = TestData_LHS;
            x.SetBits(1, 4, true);
            result &= x.intern == 0b1101_1110;

            x = TestData_RHS;
            x.SetBits(2, 4, false);
            result &= x.intern == 0b1000_0010;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void CountBits()
        {
            bool result = true;

            bit8 x = TestData_LHS;
            result &= (x.CountBits(2, 4) == 2);

            x = TestData_RHS;
            result &= (x.CountBits(1, 6) == 2);

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void TestAll()
        {
            bool result = true;

            bit8 x = TestData_LHS;
            result &= (x.TestAll() == false);
            result &= (x.TestAll(6, 2) == true);

            x = TestData_RHS;
            result &= (x.TestAll() == false);
            result &= (x.TestAll(6, 2) == false);

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void TestAny()
        {
            bool result = true;

            bit8 x = TestData_LHS;
            result &= (x.TestAny() == true);
            result &= (x.TestAny(4, 3) == true);

            x = TestData_RHS;
            result &= (x.TestAny() == true);
            result &= (x.TestAny(4, 3) == false);

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void TestNone()
        {
            bool result = true;

            bit8 x = TestData_LHS;
            result &= (x.TestNone() == false);
            result &= (x.TestNone(5, 3) == false);

            x = TestData_RHS;
            result &= (x.TestNone() == false);
            result &= (x.TestNone(4, 3) == true);

            Assert.AreEqual(result, true);
        }
    }
}