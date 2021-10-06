using NUnit.Framework;
using MaxMath;
using Unity.Collections;

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
        public static void ResetFirst()
        {
            bool result = true;


            bit16 _0 = TestData_LHS;
            bit16 _1 = TestData_RHS;

            _0.ResetFirst();
            result &= _0.intern == 0b0010_1011_1001_1100;
            _1.ResetFirst();
            result &= _1.intern == 0b1011_0001_1101_0000;

            _0 = TestData_LHS;
            _1 = TestData_RHS;

            _0.ResetFirst(2, 3);
            result &= _0.intern == 0b0010_1011_1001_1010;
            _1.ResetFirst(4, 4);
            result &= _1.intern == 0b1011_0001_1100_0010;


            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetFirst()
        {
            bool result = true;


            bit16 _0 = TestData_LHS;
            bit16 _1 = TestData_RHS;

            _0.SetFirst();
            result &= _0.intern == 0b0010_1011_1001_1111;
            _1.SetFirst();
            result &= _1.intern == 0b1011_0001_1101_0011;

            _0 = TestData_LHS;
            _1 = TestData_RHS;
            
            _0.SetFirst(2, 3);
            result &= _0.intern == 0b0010_1011_1001_1110;
            _1.SetFirst(4, 4);
            result &= _1.intern == 0b1011_0001_1111_0010;


            Assert.AreEqual(result, true);
        }

        [Test]
        public static void ResetLast()
        {
            bool result = true;


            bit16 _0 = TestData_LHS;
            bit16 _1 = TestData_RHS;

            _0.ResetLast();
            result &= _0.intern == 0b0000_1011_1001_1110;
            _1.ResetLast();
            result &= _1.intern == 0b0011_0001_1101_0010;

            _0 = TestData_LHS;
            _1 = TestData_RHS;

            _0.ResetLast(2, 3);
            result &= _0.intern == 0b0010_1011_1000_1110;
            _1.ResetLast(4, 8);
            result &= _1.intern == 0b1011_0000_1101_0010;


            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetLast()
        {
            bool result = true;


            bit16 _0 = TestData_LHS;
            bit16 _1 = TestData_RHS;

            _0.SetLast();
            result &= _0.intern == 0b1010_1011_1001_1110;
            _1.SetLast();
            result &= _1.intern == 0b1111_0001_1101_0010;

            _0 = TestData_LHS;
            _1 = TestData_RHS;

            _0.SetLast(2, 3);
            result &= _0.intern == 0b0010_1011_1001_1110;
            _1.SetLast(4, 4);
            result &= _1.intern == 0b1011_0001_1111_0010;


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

        [Test]
        public static void Shuffle()
        {
            Random16 rng = new Random16(123);

            for (int i = 0; i < 16; i++)
            {
                bit16 x = TestData_LHS;

                uint bits = x.CountBits();

                x.Shuffle(ref rng);

                Assert.AreEqual(bits, x.CountBits());
            }
        }

        [Test]
        public static void ShuffleBitField()
        {
            Random16 rng = new Random16(123);

            for (int i = 0; i < 16; i++)
            {
                bit16 x = TestData_LHS;
                int index = rng.NextUShort(0, (ushort)x.Length);
                int numBits = rng.NextUShort(1, (ushort)(x.Length - index + 1));

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
                bit16 bits = (bit16)(ushort)rng.NextInt();
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
                bit16 bits = (bit16)(ushort)rng.NextInt();
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
                bit16 bits = (bit16)(ushort)rng.NextInt();
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
            for (int i = 1; i < 16; i++)
            {
                CopyToArray_Base(i);
            }
        }

        [Test]
        public static void CopyToBitArray_IndexIsMultipleOf8_VaryingSourceIndex()
        {
            for (int i = 1; i < 16; i++)
            {
                CopyToBitArray_IndexIsMultipleOf8_Base(i);
            }
        }

        [Test]
        public static void CopyToBitArray_IndexIsNotMultipleOf8_VaryingSourceIndex()
        {
            for (int i = 1; i < 16; i++)
            {
                CopyToBitArray_IndexIsNotMultipleOf8_Base(i);
            }
        }
    }
}