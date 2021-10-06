using NUnit.Framework;
using MaxMath;
using Unity.Collections;

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
        public static void ResetFirst()
        {
            bool result = true;


            bit8 _0 = TestData_LHS;
            bit8 _1 = TestData_RHS;

            _0.ResetFirst();
            result &= _0.intern == 0b1101_1000;
            _1.ResetFirst();
            result &= _1.intern == 0b1000_0100;

            _0 = TestData_LHS;
            _1 = TestData_RHS;

            _0.ResetFirst(2, 3);
            result &= _0.intern == 0b1101_0010;
            _1.ResetFirst(4, 4);
            result &= _1.intern == 0b0000_0110;


            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetFirst()
        {
            bool result = true;


            bit8 _0 = TestData_LHS;
            bit8 _1 = TestData_RHS;

            _0.SetFirst();
            result &= _0.intern == 0b1101_1011;
            _1.SetFirst();
            result &= _1.intern == 0b1000_0111;

            _0 = TestData_LHS;
            _1 = TestData_RHS;

            _0.SetFirst(2, 3);
            result &= _0.intern == 0b1101_1110;
            _1.SetFirst(4, 4);
            result &= _1.intern == 0b1001_0110;


            Assert.AreEqual(result, true);
        }

        [Test]
        public static void ResetLast()
        {
            bool result = true;


            bit8 _0 = TestData_LHS;
            bit8 _1 = TestData_RHS;

            _0.ResetLast();
            result &= _0.intern == 0b0101_1010;
            _1.ResetLast();
            result &= _1.intern == 0b0000_0110;

            _0 = TestData_LHS;
            _1 = TestData_RHS;
            
            _0.ResetLast(2, 3);
            result &= _0.intern == 0b1100_1010;
            _1.ResetLast(4, 4);
            result &= _1.intern == 0b0000_0110;


            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetLast()
        {
            bool result = true;


            bit8 _0 = TestData_LHS;
            bit8 _1 = TestData_RHS;

            _0.SetLast();
            result &= _0.intern == 0b1111_1010;
            _1.SetLast();
            result &= _1.intern == 0b1100_0110;

            _0 = TestData_LHS;
            _1 = TestData_RHS;

            _0.SetLast(2, 3);
            result &= _0.intern == 0b1101_1110;
            _1.SetLast(4, 4);
            result &= _1.intern == 0b1100_0110;


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

        [Test]
        public static void Overwrite()
        {
            bool result = true;

            bit8 x = TestData_LHS;
            bit16 y = _bit16.TestData_LHS;
            bit32 z = _bit32.TestData_LHS;
            bit64 w = _bit64.TestData_LHS;

            bit8 test = x;
            test.Overwrite(3, 3, y, 2);
            result &= test[0] == x[0];
            result &= test[1] == x[1];
            result &= test[2] == x[2];
            result &= test[3] == y[2];
            result &= test[4] == y[3];
            result &= test[5] == y[4];
            result &= test[6] == x[6];
            result &= test[7] == x[7];

            test = x;
            test.Overwrite(0, 4, z, 0);
            result &= test[0] == z[0];
            result &= test[1] == z[1];
            result &= test[2] == z[2];
            result &= test[3] == z[3];
            result &= test[4] == x[4];
            result &= test[5] == x[5];
            result &= test[6] == x[6];
            result &= test[7] == x[7];

            test = x;
            test.Overwrite(4, 4, w, 47);
            result &= test[0] == x[0];
            result &= test[1] == x[1];
            result &= test[2] == x[2];
            result &= test[3] == x[3];
            result &= test[4] == w[47];
            result &= test[5] == w[48];
            result &= test[6] == w[49];
            result &= test[7] == w[50];

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Shuffle()
        {
            Random8 rng = new Random8(123);

            for (int i = 0; i < 16; i++)
            {
                bit8 x = TestData_LHS;

                uint bits = x.CountBits();

                x.Shuffle(ref rng);

                Assert.AreEqual(bits, x.CountBits());
            }
        }

        [Test]
        public static void ShuffleBitField()
        {
            Random8 rng = new Random8(123);

            for (int i = 0; i < 16; i++)
            {
                bit8 x = TestData_LHS;
                int index = rng.NextByte(0, (byte)x.Length);
                int numBits = rng.NextByte(1, (byte)(x.Length - index + 1));

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
                bit8 bits = (bit8)(byte)rng.NextInt();
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
                bit8 bits = (bit8)(byte)rng.NextInt();
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
                bit8 bits = (bit8)(byte)rng.NextInt();
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
            for (int i = 1; i < 8; i++)
            {
                CopyToArray_Base(i);
            }
        }

        [Test]
        public static void CopyToBitArray_IndexIsMultipleOf8_VaryingSourceIndex()
        {
            for (int i = 1; i < 8; i++)
            {
                CopyToBitArray_IndexIsMultipleOf8_Base(i);
            }
        }

        [Test]
        public static void CopyToBitArray_IndexIsNotMultipleOf8_VaryingSourceIndex()
        {
            for (int i = 1; i < 8; i++)
            {
                CopyToBitArray_IndexIsNotMultipleOf8_Base(i);
            }
        }
    }
}