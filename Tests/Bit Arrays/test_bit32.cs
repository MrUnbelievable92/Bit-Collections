using NUnit.Framework;
using MaxMath;
using Unity.Collections;

namespace BitCollections.Tests
{
    internal static class _bit32
    {
        internal static bit32 TestData_LHS => new bit32{ intern = 0b1011_0001_1101_0010_0010_1011_1001_1110 };
        internal static bit32 TestData_RHS => new bit32{ intern = 0b1101_0110_0001_1101_1011_0101_1101_1110 };


        [Test]
        public static void Constructor_boolx32()
        {
            bit32 test = new bit32(true, 
                                   false, 
                                   false, 
                                   false, 

                                   true, 
                                   false, 
                                   false, 
                                   true, 

                                   true, 
                                   true, 
                                   true, 
                                   false, 

                                   false, 
                                   true, 
                                   false, 
                                   true, 

                                   false, 
                                   false, 
                                   false, 
                                   true, 

                                   false, 
                                   false, 
                                   true, 
                                   true, 

                                   true, 
                                   false, 
                                   false, 
                                   false, 

                                   true, 
                                   false, 
                                   false, 
                                   true);

            Assert.AreEqual(test.intern == 0b1001_0001_1100_1000_1010_0111_1001_0001, true);
        }

        [Test]        
        public static void Constructor_bool16x2()
        {
            bit32 test = new bit32(new bit16(0b0101_1101_0101_1011), new bit16(0b1111_0001_0001_0101));

            Assert.AreEqual(test.intern == 0b1111_0001_0001_0101_0101_1101_0101_1011, true);
        }

        [Test]
        public static void Constructor_bool8x4()
        {
            bit32 test = new bit32(new bit8(0b0101_1101), new bit8(0b1111_0001), new bit8(0b0001_0101), new bit8(0b0101_1011));

            Assert.AreEqual(test.intern == 0b0101_1011_0001_0101_1111_0001_0101_1101, true);
        }

        [Test]
        public static void Constructor_bool16_bool8_bool8()
        {
            bit32 test = new bit32(new bit16(0b0101_1101_1111_0001), new bit8(0b0001_0101), new bit8(0b0101_1011));

            Assert.AreEqual(test.intern == 0b0101_1011_0001_0101_0101_1101_1111_0001, true);
        }

        [Test]
        public static void Constructor_bool8_bool16_bool8()
        {
            bit32 test = new bit32(new bit8(0b0101_1101), new bit16(0b1111_0001_0001_0101), new bit8(0b0101_1011));

            Assert.AreEqual(test.intern == 0b0101_1011_1111_0001_0001_0101_0101_1101, true);
        }

        [Test]
        public static void Constructor_bool8_bool8_bool16()
        {
            bit32 test = new bit32(new bit8(0b0101_1101), new bit8(0b1111_0001), new bit16(0b0001_0101_0101_1011));

            Assert.AreEqual(test.intern == 0b0001_0101_0101_1011_1111_0001_0101_1101, true);
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

            result &= TestData_LHS[16] == false;
            result &= TestData_LHS[17] == true;
            result &= TestData_LHS[18] == false;
            result &= TestData_LHS[19] == false;

            result &= TestData_LHS[20] == true;
            result &= TestData_LHS[21] == false;
            result &= TestData_LHS[22] == true;
            result &= TestData_LHS[23] == true;

            result &= TestData_LHS[24] == true;
            result &= TestData_LHS[25] == false;
            result &= TestData_LHS[26] == false;
            result &= TestData_LHS[27] == false;

            result &= TestData_LHS[28] == true;
            result &= TestData_LHS[29] == true;
            result &= TestData_LHS[30] == false;
            result &= TestData_LHS[31] == true;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Set()
        {
            bool result = true;

            for (int i = 0; i < 32; i++)
            {
                bit32 test = TestData_LHS;
                test[i] = false;
                result &= test.intern == (TestData_LHS.intern & ~(1u << i));
            }

            for (int i = 0; i < 32; i++)
            {
                bit32 test = TestData_LHS;
                test[i] = true;
                result &= test.intern == (TestData_LHS.intern | (1u << i));
            }

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void IndexOfFirst()
        {
            bool result = true;

            result &= TestData_LHS.IndexOfFirst() == 1; 
            result &= TestData_RHS.IndexOfFirst() == 1;

            result &= TestData_LHS.IndexOfFirst(15, 9) == 17;
            result &= TestData_RHS.IndexOfFirst(21, 9) == 25;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void IndexOfLast()
        {
            bool result = true;

            result &= TestData_LHS.IndexOfLast() == 31; 
            result &= TestData_RHS.IndexOfLast() == 31;

            result &= TestData_LHS.IndexOfLast(15, 10) == 24;
            result &= TestData_RHS.IndexOfLast(21, 10) == 30;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void ResetFirst()
        {
            bool result = true;


            bit32 _0 = TestData_LHS;
            bit32 _1 = TestData_RHS;

            _0.ResetFirst();
            result &= _0.intern == 0b1011_0001_1101_0010_0010_1011_1001_1100;
            _1.ResetFirst();
            result &= _1.intern == 0b1101_0110_0001_1101_1011_0101_1101_1100;

            _0 = TestData_LHS;
            _1 = TestData_RHS;

            _0.ResetFirst(12, 4);
            result &= _0.intern == 0b1011_0001_1101_0010_0000_1011_1001_1110;
            _1.ResetFirst(8, 4);
            result &= _1.intern == 0b1101_0110_0001_1101_1011_0100_1101_1110;


            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetFirst()
        {
            bool result = true;


            bit32 _0 = TestData_LHS;
            bit32 _1 = TestData_RHS;

            _0.SetFirst();
            result &= _0.intern == 0b1011_0001_1101_0010_0010_1011_1001_1111;
            _1.SetFirst();
            result &= _1.intern == 0b1101_0110_0001_1101_1011_0101_1101_1111;

            _0 = TestData_LHS;
            _1 = TestData_RHS;

            _0.SetFirst(12, 4);
            result &= _0.intern == 0b1011_0001_1101_0010_0011_1011_1001_1110;
            _1.SetFirst(4, 4);
            result &= _1.intern == 0b1101_0110_0001_1101_1011_0101_1111_1110;


            Assert.AreEqual(result, true);
        }

        [Test]
        public static void ResetLast()
        {
            bool result = true;


            bit32 _0 = TestData_LHS;
            bit32 _1 = TestData_RHS;

            _0.ResetLast();
            result &= _0.intern == 0b0011_0001_1101_0010_0010_1011_1001_1110;
            _1.ResetLast();
            result &= _1.intern == 0b0101_0110_0001_1101_1011_0101_1101_1110;

            _0 = TestData_LHS;
            _1 = TestData_RHS;

            _0.ResetLast(16, 4);
            result &= _0.intern == 0b1011_0001_1101_0000_0010_1011_1001_1110;
            _1.ResetLast(4, 8);
            result &= _1.intern == 0b1101_0110_0001_1101_1011_0001_1101_1110;


            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetLast()
        {
            bool result = true;


            bit32 _0 = TestData_LHS;
            bit32 _1 = TestData_RHS;

            _0.SetLast();
            result &= _0.intern == 0b1111_0001_1101_0010_0010_1011_1001_1110;
            _1.SetLast();
            result &= _1.intern == 0b1111_0110_0001_1101_1011_0101_1101_1110;

            _0 = TestData_LHS;
            _1 = TestData_RHS;

            _0.SetLast(16, 8);
            result &= _0.intern == 0b1011_0001_1111_0010_0010_1011_1001_1110;
            _1.SetLast(20, 8);
            result &= _1.intern == 0b1101_1110_0001_1101_1011_0101_1101_1110;


            Assert.AreEqual(result, true);
        }


        [Test]
        public static void ShiftLeft()
        {
            bool result = true;

            bit32 x = TestData_LHS;
            x.ShiftLeft(8, 20, 5);
            result &= x.intern == 0b1011_1010_0100_0101_0110_0000_1001_1110;

            x = TestData_RHS;
            x.ShiftLeft(16, 11, 3);
            result &= x.intern == 0b1101_0000_1110_1000_1011_0101_1101_1110;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void ShiftRight()
        {
            bool result = true;

            bit32 x = TestData_LHS;
            x.ShiftRight(8, 20, 5);
            result &= x.intern == 0b1011_0000_0000_1110_1001_0001_1001_1110;

            x = TestData_RHS;
            x.ShiftRight(16, 11, 3);
            result &= x.intern == 0b1101_0000_1100_0011_1011_0101_1101_1110;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void RotateLeft()
        {
            bool result = true;

            bit32 x = TestData_LHS;
            x.RotateLeft(8, 20, 5);
            result &= x.intern == 0b1011_1010_0100_0101_0110_0011_1001_1110;

            x = TestData_RHS;
            x.RotateLeft(16, 11, 3);
            result &= x.intern == 0b1101_0000_1110_1110_1011_0101_1101_1110;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void RotateRight()
        {
            bool result = true;

            bit32 x = TestData_LHS;
            x.RotateRight(8, 20, 5);
            result &= x.intern == 0b1011_0101_1000_1110_1001_0001_1001_1110;

            x = TestData_RHS;
            x.RotateRight(16, 11, 3);
            result &= x.intern == 0b1101_0101_1100_0011_1011_0101_1101_1110;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Swap()
        {
            bool result = true;

            bit32 x = TestData_LHS;
            x.Swap(3, 25);
            result &= x.intern == 0b1011_0011_1101_0010_0010_1011_1001_0110;

            x = TestData_RHS;
            x.Swap(11, 25);
            result &= x.intern == 0b1101_0100_0001_1101_1011_1101_1101_1110;


            x = TestData_LHS;
            x.Swap(2, 16, 8);
            result &= x.intern == 0b1011_0001_1110_0111_0010_1011_0100_1010;

            x = TestData_RHS;
            x.Swap(4, 24, 6);
            result &= x.intern == 0b1101_1101_0001_1101_1011_0101_0110_1110;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Flip()
        {
            bool result = true;

            bit32 x = TestData_LHS;
            x.Flip(12, 8); 
            result &= x.intern == 0b1011_0001_1101_1101_1101_1011_1001_1110;

            x = TestData_RHS;
            x.Flip(10, 20);
            result &= x.intern == 0b1110_1001_1110_0010_0100_1001_1101_1110;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Reverse()
        {
            bool result = true;

            bit32 x = TestData_LHS;
            x.Reverse();
            result &= x.intern == 0b0111_1001_1101_0100_0100_1011_1000_1101;

            x = TestData_RHS;
            x.Reverse();
            result &= x.intern == 0b0111_1011_1010_1101_1011_1000_0110_1011;

            x = TestData_LHS;
            x.Reverse(12, 8);
            result &= x.intern == 0b1011_0001_1101_0100_0100_1011_1001_1110;

            x = TestData_RHS;
            x.Reverse(15, 9);
            result &= x.intern == 0b1101_0110_1101_1100_0011_0101_1101_1110;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetBits()
        {
            bool result = true;

            bit32 x = TestData_LHS;
            x.SetBits(9, 15, true);
            result &= x.intern == 0b1011_0001_1111_1111_1111_1111_1001_1110;

            x = TestData_RHS;
            x.SetBits(22, 9, false);
            result &= x.intern == 0b1000_0000_0001_1101_1011_0101_1101_1110;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void CountBits()
        {
            bool result = true;

            bit32 x = TestData_LHS;
            result &= (x.CountBits(2, 22) == 12);

            x = TestData_RHS;
            result &= (x.CountBits(16, 10) == 5);

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void TestAll()
        {
            bool result = true;

            bit32 x = TestData_LHS;
            result &= (x.TestAll() == false);
            result &= (x.TestAll(1, 4) == true);

            x = TestData_RHS;
            result &= (x.TestAll() == false);
            result &= (x.TestAll(15, 9) == false);

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void TestAny()
        {
            bool result = true;

            bit32 x = TestData_LHS;
            result &= (x.TestAny() == true);
            result &= (x.TestAny(6, 9) == true);

            x = TestData_RHS;
            result &= (x.TestAny() == true);
            result &= (x.TestAny(21, 4) == false);

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void TestNone()
        {
            bool result = true;

            bit32 x = TestData_LHS;
            result &= (x.TestNone() == false);
            result &= (x.TestNone(5, 12) == false);

            x = TestData_RHS;
            result &= (x.TestNone() == false);
            result &= (x.TestNone(21, 4) == true);

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Shuffle()
        {
            Random32 rng = new Random32(123);

            for (int i = 0; i < 16; i++)
            {
                bit32 x = TestData_LHS;

                uint bits = x.CountBits();

                x.Shuffle(ref rng);

                Assert.AreEqual(bits, x.CountBits());
            }
        }

        [Test]
        public static void ShuffleBitField()
        {
            Random32 rng = new Random32(123);

            for (int i = 0; i < 16; i++)
            {
                bit32 x = TestData_LHS;
                int index = rng.NextInt(0, x.Length);
                int numBits = rng.NextInt(1, x.Length - index + 1);

                uint bits = x.CountBits(index, numBits);

                x.Shuffle(index, numBits, ref rng);

                Assert.AreEqual(bits, x.CountBits(index, numBits));
            }
        }

        public static void CopyToArray_Base(int srcIndex = 0)
        {
            Random32 rng = new Random32(265);

            for (int i = 0; i < 16; i++)
            {
                bit32 bits = (bit32)rng.NextInt();
                NativeArray<bool> array = new NativeArray<bool>(rng.NextInt(bits.Length, 200), Allocator.Temp);
                NativeArray<bool> arrayCpy = new NativeArray<bool>(array.Length, Allocator.Temp);

                for (int j = 0; j < array.Length; j++)
                {
                    bool next = rng.NextBool();
                    array[j] = next;
                    arrayCpy[j] = next;
                }

                for (int numValues = 1; numValues <= bits.Length - srcIndex; numValues++)
                {
                    int dstIndex = rng.NextInt(0, array.Length - (numValues - 1));
                    bits.CopyTo(array, dstIndex, numValues, srcIndex);

                    for (int k = 0;k < array.Length;k++)
                    {
                        if (k >= dstIndex && k <= dstIndex + (numValues - 1))
                        {
                            Assert.AreEqual(array[k], bits[k - dstIndex + srcIndex]);
                        }
                        else
                        {
                            Assert.AreEqual(array[k], arrayCpy[k]);
                        }
                    }
                    
                    for (int j = dstIndex; j < dstIndex + numValues; j++)
                    {
                        array[j] = arrayCpy[j];
                    }
                }

                array.Dispose();
                arrayCpy.Dispose();
            }
        }

        public static void CopyToBitArray_IndexIsMultipleOf8_Base(int srcIndex = 0)
        {
            Random32 rng = new Random32(265);

            for (int i = 0; i < 16; i++)
            {
                bit32 bits = (bit32)rng.NextInt();
                NativeBitArray array = new NativeBitArray(rng.NextInt(bits.Length, 200), Allocator.Temp);
                NativeBitArray arrayCpy = new NativeBitArray(array.Length, Allocator.Temp);

                for (int j = 0; j < array.Length; j++)
                {
                    bool next = rng.NextBool();
                    array[j] = next;
                    arrayCpy[j] = next;
                }

                for (int numValues = 1; numValues <= bits.Length - srcIndex; numValues++)
                {
                    int dstIndex = 8 * rng.NextInt(0, (array.Length - (numValues - 1)) / 8);
                    bits.CopyTo(array, dstIndex, numValues, srcIndex);

                    for (int k = 0;k < array.Length;k++)
                    {
                        if (k >= dstIndex && k <= dstIndex + (numValues - 1))
                        {
                            Assert.AreEqual(array[k], bits[k - dstIndex + srcIndex]);
                        }
                        else
                        {
                            Assert.AreEqual(array[k], arrayCpy[k]);
                        }
                    }
                    
                    for (int j = dstIndex; j < dstIndex + numValues; j++)
                    {
                        array[j] = arrayCpy[j];
                    }
                }

                array.Dispose();
                arrayCpy.Dispose();
            }
        }

        public static void CopyToBitArray_IndexIsNotMultipleOf8_Base(int srcIndex = 0)
        {
            Random32 rng = new Random32(265);

            for (int i = 0; i < 16; i++)
            {
                bit32 bits = (bit32)rng.NextInt();
                NativeBitArray array = new NativeBitArray(rng.NextInt(bits.Length, 200), Allocator.Temp);
                NativeBitArray arrayCpy = new NativeBitArray(array.Length, Allocator.Temp);

                for (int j = 0; j < array.Length; j++)
                {
                    bool next = rng.NextBool();
                    array[j] = next;
                    arrayCpy[j] = next;
                }

                for (int numValues = 1; numValues <= bits.Length - srcIndex; numValues++)
                {
                    int dstIndex = rng.NextInt(0, array.Length - (numValues - 1));
                    if (dstIndex % 8 == 0)
                    {
                        if (dstIndex == 0)
                        {
                            if (numValues != bits.Length)
                            {
                                dstIndex++;
                            }
                        }
                        else
                        {
                            dstIndex--;
                        }
                    }

                    bits.CopyTo(array, dstIndex, numValues, srcIndex);

                    for (int k = 0;k < array.Length;k++)
                    {
                        if (k >= dstIndex && k <= dstIndex + (numValues - 1))
                        {
                            Assert.AreEqual(array[k], bits[k - dstIndex + srcIndex]);
                        }
                        else
                        {
                            Assert.AreEqual(array[k], arrayCpy[k]);
                        }
                    }
                    
                    for (int j = dstIndex; j < dstIndex + numValues; j++)
                    {
                        array[j] = arrayCpy[j];
                    }
                }

                array.Dispose();
                arrayCpy.Dispose();
            }
        }

        [Test]
        public static void CopyToArray()
        {
            CopyToArray_Base(0);
        }

        [Test]
        public static void CopyToBitArray_IndexIsMultipleOf8()
        {
            CopyToBitArray_IndexIsMultipleOf8_Base(0);
        }

        [Test]
        public static void CopyToBitArray_IndexIsNotMultipleOf8()
        {
            CopyToBitArray_IndexIsNotMultipleOf8_Base(0);
        }

        [Test]
        public static void CopyToArray_VaryingSourceIndex()
        {
            for (int i = 1; i < 32; i++)
            {
                CopyToArray_Base(i);
            }
        }

        [Test]
        public static void CopyToBitArray_IndexIsMultipleOf8_VaryingSourceIndex()
        {
            for (int i = 1; i < 32; i++)
            {
                CopyToBitArray_IndexIsMultipleOf8_Base(i);
            }
        }

        [Test]
        public static void CopyToBitArray_IndexIsNotMultipleOf8_VaryingSourceIndex()
        {
            for (int i = 1; i < 32; i++)
            {
                CopyToBitArray_IndexIsNotMultipleOf8_Base(i);
            }
        }
    }
}