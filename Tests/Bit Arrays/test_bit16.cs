using NUnit.Framework;

namespace BitCollections.Tests
{
    internal static class _bit16
    {
        internal static bit16 TestData_LHS => new bit16{ intern = 0b0010_1011_1001_1110 };
        internal static bit16 TestData_RHS => new bit16{ intern = 0b1011_0001_1101_0010 };


        [Test]
        public static void Constructor_boolx16()
        {
            bit16 test = new bit16(true, 
                                   false, 
                                   false, 
                                   true, 
                                   
                                   true, 
                                   true, 
                                   false,
                                   true, 

                                   false, 
                                   false, 
                                   true, 
                                   false, 
                                   
                                   true, 
                                   true, 
                                   true, 
                                   false);

            Assert.AreEqual(test.intern == 0b0111_0100_1011_1001, true);
        }

        [Test]        
        public static void Constructor_bool8x2()
        {
            bit16 test = new bit16(new bit8(true, false, false, true, true, true, false, true), new bit8(false, false, true, false, true, true, true, false));

            Assert.AreEqual(test.intern == 0b0111_0100_1011_1001, true);
        }

        [Test]
        public static void Get()
        {
            bool result = true;

            result &= TestData_LHS[0] == false;
            result &= TestData_LHS[1] == true;
            result &= TestData_LHS[2] == true;
            result &= TestData_LHS[3] == true;

            result &= TestData_LHS[4] == true;
            result &= TestData_LHS[5] == false;
            result &= TestData_LHS[6] == false;
            result &= TestData_LHS[7] == true;

            result &= TestData_LHS[8] == true;
            result &= TestData_LHS[9] == true;
            result &= TestData_LHS[10] == false;
            result &= TestData_LHS[11] == true;

            result &= TestData_LHS[12] == false;
            result &= TestData_LHS[13] == true;
            result &= TestData_LHS[14] == false;
            result &= TestData_LHS[15] == false;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Set()
        {
            bool result = true;

            for (int i = 0; i < 16; i++)
            {
                bit16 test = TestData_LHS;
                test[i] = false;
                result &= test.intern == (TestData_LHS.intern & ~(1 << i));
            }

            for (int i = 0; i < 16; i++)
            {
                bit16 test = TestData_LHS;
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

            result &= TestData_LHS.IndexOfFirst(7, 7) == 7;
            result &= TestData_RHS.IndexOfFirst(9, 6) == 12;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void IndexOfLast()
        {
            bool result = true;

            result &= TestData_LHS.IndexOfLast() == 13; 
            result &= TestData_RHS.IndexOfLast() == 15;

            result &= TestData_LHS.IndexOfLast(7, 7) == 13;
            result &= TestData_RHS.IndexOfLast(2, 6) == 7;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void ShiftLeft()
        {
            bool result = true;

            bit16 x = TestData_LHS;
            x.ShiftLeft(4, 8, 2);
            result &= x.intern == 0b0010_1110_0100_1110;

            x = TestData_RHS;
            x.ShiftLeft(2, 11, 3);
            result &= x.intern == 0b1010_1110_1000_0010;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void ShiftRight()
        {
            bool result = true;

            bit16 x = TestData_LHS;
            x.ShiftRight(4, 8, 2);
            result &= x.intern == 0b0010_0010_1110_1110;

            x = TestData_RHS;
            x.ShiftRight(2, 11, 3);
            result &= x.intern == 0b1010_0010_0011_1010;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void RotateLeft()
        {
            bool result = true;

            bit16 x = TestData_LHS;
            x.RotateLeft(4, 8, 2);
            result &= x.intern == 0b0010_1110_0110_1110;

            x = TestData_RHS;
            x.RotateLeft(2, 11, 3);
            result &= x.intern == 0b1010_1110_1001_0010;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void RotateRight()
        {
            bool result = true;

            bit16 x = TestData_LHS;
            x.RotateRight(4, 8, 2);
            result &= x.intern == 0b0010_0110_1110_1110;

            x = TestData_RHS;
            x.RotateRight(2, 11, 3);
            result &= x.intern == 0b1011_0010_0011_1010;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Swap()
        {
            bool result = true;

            bit16 x = TestData_LHS;
            x.Swap(3, 9);
            result &= x.intern == 0b0010_1011_1001_1110;

            x = TestData_RHS;
            x.Swap(3, 15);
            result &= x.intern == 0b0011_0001_1101_1010;


            x = TestData_LHS;
            x.Swap(2, 6, 3);
            result &= x.intern == 0b0010_1011_1101_1010;

            x = TestData_RHS;
            x.Swap(1, 9, 5);
            result &= x.intern == 0b1001_0011_1111_0000;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Flip()
        {
            bool result = true;

            bit16 x = TestData_LHS;
            x.Flip(2, 8);
            result &= x.intern == 0b0010_1000_0110_0010;

            x = TestData_RHS;
            x.Flip(10, 4);
            result &= x.intern == 0b1000_1101_1101_0010;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Reverse()
        {
            bool result = true;

            bit16 x = TestData_LHS;
            x.Reverse();
            result &= x.intern == 0b0111_1001_1101_0100;

            x = TestData_RHS;
            x.Reverse();
            result &= x.intern == 0b0100_1011_1000_1101;

            x = TestData_LHS;
            x.Reverse(2, 7);
            result &= x.intern == 0b0010_1011_1100_1110;

            x = TestData_RHS;
            x.Reverse(5, 6);
            result &= x.intern == 0b1011_0011_1001_0010;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetBits()
        {
            bool result = true;

            bit16 x = TestData_LHS;
            x.SetBits(1, 8, true);
            result &= x.intern == 0b0010_1011_1111_1110;

            x = TestData_RHS;
            x.SetBits(2, 9, false);
            result &= x.intern == 0b1011_0000_0000_0010;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void CountBits()
        {
            bool result = true;

            bit16 x = TestData_LHS;
            result &= (x.CountBits(2, 7) == 5);

            x = TestData_RHS;
            result &= (x.CountBits(7, 3) == 2);

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void TestAll()
        {
            bool result = true;

            bit16 x = TestData_LHS;
            result &= (x.TestAll() == false);
            result &= (x.TestAll(7, 3) == true);

            x = TestData_RHS;
            result &= (x.TestAll() == false);
            result &= (x.TestAll(0, 4) == false);

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void TestAny()
        {
            bool result = true;

            bit16 x = TestData_LHS;
            result &= (x.TestAny() == true);
            result &= (x.TestAny(4, 3) == true);

            x = TestData_RHS;
            result &= (x.TestAny() == true);
            result &= (x.TestAny(9, 3) == false);

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void TestNone()
        {
            bool result = true;

            bit16 x = TestData_LHS;
            result &= (x.TestNone() == false);
            result &= (x.TestNone(5, 3) == false);

            x = TestData_RHS;
            result &= (x.TestNone() == false);
            result &= (x.TestNone(9, 3) == true);

            Assert.AreEqual(result, true);
        }
    }
}