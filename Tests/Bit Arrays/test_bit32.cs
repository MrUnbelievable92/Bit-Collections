using NUnit.Framework;
using MaxMath;

using static Unity.Mathematics.math;
using static MaxMath.maxmath;

namespace BitCollections.Tests
{
    internal static class _bit32
    {
        internal static bit32 TestData_LHS => new bit32{ Bits = 0b1011_0001_1101_0010_0010_1011_1001_1110 };
        internal static bit32 TestData_RHS => new bit32{ Bits = 0b1101_0110_0001_1101_1011_0101_1101_1110 };

        private static Random32 rng = Random32.New;

        private static bit32 Random => new bit32 { Bits = rng.NextUInt() };
        private static bool RandomBool => rng.NextBool();
        private static int RandomIndex() => rng.NextInt(0, 32);
        private static int RandomNumBits(int index) => rng.NextInt(0, 32 - index + 1);

        private static void AssertBitsOutsideFieldAreUntouched(bit32 t0, bit32 t1, int idx, int num)
        {
            for (int j = 0; j < idx; j++)
            {
                Assert.AreEqual(t0[j], t1[j]);
            }
            for (int j = idx + num; j < 32; j++)
            {
                Assert.AreEqual(t0[j], t1[j]);
            }
        }


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

            Assert.AreEqual(test.Bits == 0b1001_0001_1100_1000_1010_0111_1001_0001, true);
        }

        [Test]
        public static void Constructor_bool16x2()
        {
            bit32 test = new bit32(new bit16(0b0101_1101_0101_1011), new bit16(0b1111_0001_0001_0101));

            Assert.AreEqual(test.Bits == 0b1111_0001_0001_0101_0101_1101_0101_1011, true);
        }

        [Test]
        public static void Constructor_bool8x4()
        {
            bit32 test = new bit32(new bit8(0b0101_1101), new bit8(0b1111_0001), new bit8(0b0001_0101), new bit8(0b0101_1011));

            Assert.AreEqual(test.Bits == 0b0101_1011_0001_0101_1111_0001_0101_1101, true);
        }

        [Test]
        public static void Constructor_bool16_bool8_bool8()
        {
            bit32 test = new bit32(new bit16(0b0101_1101_1111_0001), new bit8(0b0001_0101), new bit8(0b0101_1011));

            Assert.AreEqual(test.Bits == 0b0101_1011_0001_0101_0101_1101_1111_0001, true);
        }

        [Test]
        public static void Constructor_bool8_bool16_bool8()
        {
            bit32 test = new bit32(new bit8(0b0101_1101), new bit16(0b1111_0001_0001_0101), new bit8(0b0101_1011));

            Assert.AreEqual(test.Bits == 0b0101_1011_1111_0001_0001_0101_0101_1101, true);
        }

        [Test]
        public static void Constructor_bool8_bool8_bool16()
        {
            bit32 test = new bit32(new bit8(0b0101_1101), new bit8(0b1111_0001), new bit16(0b0001_0101_0101_1011));

            Assert.AreEqual(test.Bits == 0b0001_0101_0101_1011_1111_0001_0101_1101, true);
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
                result &= test.Bits == (TestData_LHS.Bits & ~(1u << i));
            }

            for (int i = 0; i < 32; i++)
            {
                bit32 test = TestData_LHS;
                test[i] = true;
                result &= test.Bits == (TestData_LHS.Bits | (1u << i));
            }

            Assert.AreEqual(result, true);
        }

        
        [Test]
        public static void SetReplicate()
        {
            for (int i = 0; i < 128; i++)
            {
                bool b = RandomBool;
                bit32 t = Random.SetReplicate(b);

                for (int j = 0; j < 32; j++)
                {
                    Assert.AreEqual(b, t[j]);
                }
            }
        }

        [Test]
        public static void SetReplicate_BitField()
        {
            for (int i = 0; i < 128; i++)
            {
                bool b = RandomBool;
                int idx = RandomIndex();
                int num = RandomNumBits(idx);
                bit32 t0 = Random;
                bit32 t1 = t0.SetReplicate(idx, num, b);

                AssertBitsOutsideFieldAreUntouched(t0, t1, idx, num);
                for (int j = 0; j < num; j++)
                {
                    Assert.AreEqual(t1[j + idx], b);
                }
            }
        }

        [Test]
        public static void ResetFirst()
        {
            for (int i = 0; i < 128; i++)
            {
                bit32 t0 = Random;
                bit32 t1 = t0.ResetFirst();

                int iof = t0.IndexOfFirst();
                for (int j = 0; j < 32; j++)
                {
                    if (j == iof)
                    {
                        Assert.IsFalse(t1[j]);
                    }
                    else
                    {
                        Assert.AreEqual(t0[j], t1[j]);
                    }
                }
            }
        }

        [Test]
        public static void ResetFirst_BitField()
        {
            for (int i = 0; i < 128; i++)
            {
                int idx = RandomIndex();
                int num = RandomNumBits(idx);
                bit32 t0 = Random;
                bit32 t1 = t0.ResetFirst(idx, num);

                int iof = t0.IndexOfFirst(idx, num);
                for (int j = 0; j < 32; j++)
                {
                    if (j == iof)
                    {
                        Assert.IsFalse(t1[j]);
                    }
                    else
                    {
                        Assert.AreEqual(t0[j], t1[j]);
                    }
                }
            }
        }

        [Test]
        public static void SetFirst()
        {
            for (int i = 0; i < 128; i++)
            {
                bit32 t0 = Random;
                bit32 t1 = t0.SetFirst();

                int iof = (!t0).IndexOfFirst();
                for (int j = 0; j < 32; j++)
                {
                    if (j == iof)
                    {
                        Assert.IsTrue(t1[j]);
                    }
                    else
                    {
                        Assert.AreEqual(t0[j], t1[j]);
                    }
                }
            }
        }

        [Test]
        public static void SetFirst_BitField()
        {
            for (int i = 0; i < 128; i++)
            {
                int idx = RandomIndex();
                int num = RandomNumBits(idx);
                bit32 t0 = Random;
                bit32 t1 = t0.SetFirst(idx, num);

                int iof = (!t0).IndexOfFirst(idx, num);
                for (int j = 0; j < 32; j++)
                {
                    if (j == iof)
                    {
                        Assert.IsTrue(t1[j]);
                    }
                    else
                    {
                        Assert.AreEqual(t0[j], t1[j]);
                    }
                }
            }
        }

        [Test]
        public static void ResetLast()
        {
            for (int i = 0; i < 128; i++)
            {
                bit32 t0 = Random;
                bit32 t1 = t0.ResetLast();

                int iof = t0.IndexOfLast();
                for (int j = 0; j < 32; j++)
                {
                    if (j == iof)
                    {
                        Assert.IsFalse(t1[j]);
                    }
                    else
                    {
                        Assert.AreEqual(t0[j], t1[j]);
                    }
                }
            }
        }

        [Test]
        public static void ResetLast_BitField()
        {
            for (int i = 0; i < 128; i++)
            {
                int idx = RandomIndex();
                int num = RandomNumBits(idx);
                bit32 t0 = Random;
                bit32 t1 = t0.ResetLast(idx, num);

                int iof = t0.IndexOfLast(idx, num);
                for (int j = 0; j < 32; j++)
                {
                    if (j == iof)
                    {
                        Assert.IsFalse(t1[j]);
                    }
                    else
                    {
                        Assert.AreEqual(t0[j], t1[j]);
                    }
                }
            }
        }

        [Test]
        public static void SetLast()
        {
            for (int i = 0; i < 128; i++)
            {
                bit32 t0 = Random;
                bit32 t1 = t0.SetLast();

                int iof = (!t0).IndexOfLast();
                for (int j = 0; j < 32; j++)
                {
                    if (j == iof)
                    {
                        Assert.IsTrue(t1[j]);
                    }
                    else
                    {
                        Assert.AreEqual(t0[j], t1[j]);
                    }
                }
            }
        }

        [Test]
        public static void SetLast_BitField()
        {
            for (int i = 0; i < 128; i++)
            {
                int idx = RandomIndex();
                int num = RandomNumBits(idx);
                bit32 t0 = Random;
                bit32 t1 = t0.SetLast(idx, num);

                int iof = (!t0).IndexOfLast(idx, num);
                for (int j = 0; j < 32; j++)
                {
                    if (j == iof)
                    {
                        Assert.IsTrue(t1[j]);
                    }
                    else
                    {
                        Assert.AreEqual(t0[j], t1[j]);
                    }
                }
            }
        }

        [Test]
        public static void ShiftLeft()
        {
            for (int i = 0; i < 128; i++)
            {
                int n = RandomNumBits(0) % 32;
                bit32 t0 = Random;
                bit32 t1 = t0.ShiftLeft(n);

                for (int j = 0; j < 32; j++)
                {
                    if (j < n)
                    {
                        Assert.IsFalse(t1[j]);
                    }
                    else
                    {
                        Assert.AreEqual(t0[j - n], t1[j]);
                    }
                }
            }
        }

        [Test]
        public static void ShiftLeft_BitField()
        {
            for (int i = 0; i < 128; i++)
            {
                int idx = RandomIndex();
                int num = RandomNumBits(idx);
                int n = rng.NextInt(0, num + 1);
                bit32 t0 = Random;
                bit32 t1 = t0.ShiftLeft(idx, num, n);
                
                AssertBitsOutsideFieldAreUntouched(t0, t1, idx, num);
                for (int j = 0; j < n; j++)
                {
                    Assert.IsFalse(t1[j + idx]);
                }
                for (int j = n; j < num - n; j++)
                {
                    Assert.AreEqual(t0[j + idx - n], t1[j + idx]);
                }
            }
        }

        [Test]
        public static void ShiftRight()
        {
            for (int i = 0; i < 128; i++)
            {
                int n = RandomNumBits(0) % 32;
                bit32 t0 = Random;
                bit32 t1 = t0.ShiftRight(n);

                for (int j = 0; j < 32; j++)
                {
                    if (j >= 32 - n)
                    {
                        Assert.IsFalse(t1[j]);
                    }
                    else
                    {
                        Assert.AreEqual(t0[j + n], t1[j]);
                    }
                }
            }
        }

        [Test]
        public static void ShiftRight_BitField()
        {
            for (int i = 0; i < 128; i++)
            {
                int idx = RandomIndex();
                int num = RandomNumBits(idx);
                int n = rng.NextInt(0, num + 1);
                bit32 t0 = Random;
                bit32 t1 = t0.ShiftRight(idx, num, n);
                
                AssertBitsOutsideFieldAreUntouched(t0, t1, idx, num);
                for (int j = idx; j < idx + num - n; j++)
                {
                    Assert.AreEqual(t0[j + n], t1[j]);
                }
                for (int j = idx + num - n; j < idx + num; j++)
                {
                    Assert.IsFalse(t1[j]);
                }
            }
        }

        [Test]
        public static void RotateLeft()
        {
            for (int i = 0; i < 128; i++)
            {
                int n = RandomNumBits(0);
                bit32 t0 = Random;
                bit32 t1 = t0.RotateLeft(n);

                for (int j = 0; j < 32; j++)
                {
                    Assert.AreEqual(t0[(j - n + 32) % 32], t1[j]);
                }
            }
        }

        [Test]
        public static void RotateLeft_BitField()
        {
            for (int i = 0; i < 128; i++)
            {
                int idx = RandomIndex();
                int num = RandomNumBits(idx);
                int n = rng.NextInt(0, num + 1);
                bit32 t0 = Random;
                bit32 t1 = num == 0 ? t0 : t0.RotateLeft(idx, num, n);
                
                AssertBitsOutsideFieldAreUntouched(t0, t1, idx, num);
                if (n == 0)
                {
                    Assert.AreEqual(t0.Bits, t1.Bits);
                }
                else
                {
                    for (int j = 0; j < num; j++)
                    {
                        int srcInField = (j - n + num) % num;
                        int srcIndex = idx + srcInField;
                        int dstIndex = idx + j;

                        Assert.AreEqual(t0[srcIndex], t1[dstIndex]);
                    }
                }
            }
        }

        [Test]
        public static void RotateRight()
        {
            for (int i = 0; i < 128; i++)
            {
                int n = RandomNumBits(0);
                bit32 t0 = Random;
                bit32 t1 = t0.RotateRight(n);

                for (int j = 0; j < 32; j++)
                {
                    Assert.AreEqual(t0[(j + n + 32) % 32], t1[j]);
                }
            }
        }

        [Test]
        public static void RotateRight_BitField()
        {
            for (int i = 0; i < 128; i++)
            {
                int idx = RandomIndex();
                int num = RandomNumBits(idx);
                int n = rng.NextInt(0, num + 1);
                bit32 t0 = Random;
                bit32 t1 = num == 0 ? t0 : t0.RotateRight(idx, num, n);
                
                AssertBitsOutsideFieldAreUntouched(t0, t1, idx, num);
                if (n == 0)
                {
                    Assert.AreEqual(t0.Bits, t1.Bits);
                }
                else
                {
                    for (int j = 0; j < num; j++)
                    {
                        int srcInField = (j + n + num) % num;
                        int srcIndex = idx + srcInField;
                        int dstIndex = idx + j;

                        Assert.AreEqual(t0[srcIndex], t1[dstIndex]);
                    }
                }
            }
        }

        [Test]
        public static void Reverse()
        {
            for (int i = 0; i < 128; i++)
            {
                bit32 t0 = Random;
                bit32 t1 = t0.Reverse();

                for (int j = 0; j < 32; j++)
                {
                    Assert.AreEqual(t0[(32 - 1) - j], t1[j]);
                }
            }
        }

        [Test]
        public static void Reverse_BitField()
        {
            for (int i = 0; i < 128; i++)
            {
                int idx = RandomIndex();
                int num = RandomNumBits(idx);
                bit32 t0 = Random;
                bit32 t1 = t0.Reverse(idx, num);
                
                AssertBitsOutsideFieldAreUntouched(t0, t1, idx, num);
                for (int j = 0; j < num; j++)
                {
                    Assert.AreEqual(t0[(num - 1) - j + idx], t1[j + idx]);
                }
            }
        }

        [Test]
        public static void Swap()
        {
            for (int i = 0; i < 128; i++)
            {
                int idx0 = RandomIndex();
                int idx1 = RandomIndex();
                bit32 t0 = Random;
                bit32 t1 = t0.Swap(idx0, idx1);
                
                Assert.AreEqual(t0[idx0], t1[idx1]);
                Assert.AreEqual(t0[idx1], t1[idx0]);

                for (int j = 0; j < 32; j++)
                {
                    if (j != idx0
                     && j != idx1)
                    {
                        Assert.AreEqual(t0[j], t1[j]);
                    }
                }
            }
        }

        [Test]
        public static void Swap_BitField()
        {
            for (int i = 0; i < 128; i++)
            {
                int num = rng.NextInt(0, (32 / 2) + 1);
                int idx0 = rng.NextInt(0, 32 - 2 * num + tobyte(num != 0));
                int idx1 = rng.NextInt(idx0 + num, 32 - num + tobyte(num != 0));
                bit32 t0 = Random;
                bit32 t1 = t0.Swap(idx0, idx1, num);

                for (int j = 0; j < num; j++)
                {
                    Assert.AreEqual(t0[j + idx0], t1[j + idx1]);
                    Assert.AreEqual(t0[j + idx1], t1[j + idx0]);
                }

                for (int j = 0; j < 32; j++)
                {
                    if (!isinrange(j, idx0, idx0 + num - 1)
                     && !isinrange(j, idx1, idx1 + num - 1))
                    {
                        Assert.AreEqual(t0[j], t1[j]);
                    }
                }
            }
        }
        
        [Test]
        public static void Flip()
        {
            for (int i = 0; i < 128; i++)
            {
                bit32 t0 = Random;
                bit32 t1 = t0.Flip();

                for (int j = 0; j < 32; j++)
                {
                    Assert.AreEqual(t1[j], !t0[j]);
                }
            }
        }

        [Test]
        public static void Flip_BitField()
        {
            for (int i = 0; i < 128; i++)
            {
                int idx = RandomIndex();
                int num = RandomNumBits(idx);
                bit32 t0 = Random;
                bit32 t1 = t0.Flip(idx, num);

                AssertBitsOutsideFieldAreUntouched(t0, t1, idx, num);
                for (int j = 0; j < num; j++)
                {
                    Assert.AreEqual(t1[j + idx], !t0[j + idx]);
                }
            }
        }
        
        [Test]
        public static void IndexOfFirst()
        {
            for (int i = 0; i < 128; i++)
            {
                bit32 t = Random;
                int iof = t.IndexOfFirst();

                if (iof != 32)
                {
                    Assert.IsTrue(t[iof]);
                }
                for (int j = 0; j < min(iof, 32); j++)
                {
                    Assert.IsFalse(t[j]);
                }
            }
        }

        [Test]
        public static void IndexOfFirst_BitField()
        {
            for (int i = 0; i < 128; i++)
            {
                int idx = RandomIndex();
                int num = RandomNumBits(idx);
                bit32 t = Random;
                int iof = t.IndexOfFirst(idx, num);

                if (num == 0)
                {
                    Assert.IsFalse(isinrange(iof, 0, 31));
                    break;
                }

                if (iof != 32)
                {
                    Assert.IsTrue(t[iof]);
                }
                for (int j = idx; j < min(iof, idx + num); j++)
                {
                    Assert.IsFalse(t[j]);
                }
            }
        }
        
        [Test]
        public static void IndexOfLast()
        {
            for (int i = 0; i < 128; i++)
            {
                bit32 t = Random;
                int iol = t.IndexOfLast();

                if (iol >= 0)
                {
                    Assert.IsTrue(t[iol]);
                    for (int j = 31; j > iol; j--)
                    {
                        Assert.IsFalse(t[j]);
                    }
                }
                else
                {
                    for (int j = 31; j >= 0; j--)
                    {
                        Assert.IsFalse(t[j]);
                    }
                }
            }
        }

        [Test]
        public static void IndexOfLast_BitField()
        {
            for (int i = 0; i < 128; i++)
            {
                int idx = RandomIndex();
                int num = RandomNumBits(idx);
                bit32 t = Random;
                int iol = t.IndexOfLast(idx, num);
                
                if (num == 0)
                {
                    Assert.IsFalse(isinrange(iol, 0, 31));
                    break;
                }

                if (iol >= 0)
                {
                    Assert.IsTrue(t[iol]);
                    for (int j = idx + num - 1; j > iol; j--)
                    {
                        Assert.IsFalse(t[j]);
                    }
                }
                else
                {
                    for (int j = idx + num - 1; j >= idx; j--)
                    {
                        Assert.IsFalse(t[j]);
                    }
                }
            }
        }

        private static int __countbits(bit32 t, int idx, int num)
        {
            int r = 0;
            for (int i = 0; i < num; i++)
            {
                r += tobyte(t[i + idx]);
            }
            return r;
        }
        
        [Test]
        public static void CountBits()
        {
            for (int i = 0; i < 128; i++)
            {
                bit32 t = Random;

                Assert.AreEqual(t.CountBits(), __countbits(t, 0, 32));
            }
        }

        [Test]
        public static void CountBits_BitField()
        {
            for (int i = 0; i < 128; i++)
            {
                int idx = RandomIndex();
                int num = RandomNumBits(idx);
                bit32 t = Random;
                
                Assert.AreEqual(t.CountBits(idx, num), __countbits(t, idx, num));
            }
        }
        
        private static int __longeststring(bool value, bit32 t, int idx, int num)
        {
            if (num <= 0) 
            {
                return 0;
            }

            int maximum = 0;
            int current = 0;
            for (int i = idx; i < idx + num; i++)
            {
                if (t[i] == value)
                {
                    maximum = max(++current, maximum);
                }
                else
                {
                    current = 0;
                }
            }

            return maximum;
        }

        [Test]
        public static void FindString()
        {
            for (int i = 0; i < 128; i++)
            {
                bit32 t = Random;
                int count = rng.NextInt(0, 32 + 1);

                int iof = t.FindString(true, count);
                if (iof != 32)
                {
                    if (count != 0)
                    {
                        Assert.IsTrue(__longeststring(true, t, 0, iof) < count);
                    }
                    for (int j = 0; j < count; j++)
                    {
                        Assert.IsTrue(t[j + iof]);
                    }
                }

                iof = t.FindString(false, count);
                if (iof != 32)
                {
                    if (count != 0)
                    {
                        Assert.IsTrue(__longeststring(false, t, 0, iof) < count);
                    }
                    for (int j = 0; j < count; j++)
                    {
                        Assert.IsFalse(t[j + iof]);
                    }
                }
            }
        }

        [Test]
        public static void FindString_BitField()
        {
            for (int i = 0; i < 128; i++)
            {
                bit32 t = Random;
                int idx = RandomIndex();
                int num = RandomNumBits(idx);
                int count = rng.NextInt(0, num + 1);

                int iof = t.FindString(idx, num, true, count);
                if (iof != 32)
                {
                    if (count != 0)
                    {
                        Assert.IsTrue(__longeststring(true, t, idx, iof - idx) < count);
                    }
                    for (int j = 0; j < count; j++)
                    {
                        Assert.IsTrue(t[j + iof]);
                    }
                }
                
                iof = t.FindString(idx, num, false, count);
                if (iof != 32)
                {
                    if (count != 0)
                    {
                        Assert.IsTrue(__longeststring(false, t, idx, iof - idx) < count);
                    }
                    for (int j = 0; j < count; j++)
                    {
                        Assert.IsFalse(t[j + iof]);
                    }
                }
            }
        }
        
        [Test]
        public static void TestAll()
        {
            for (int i = 0; i < 128; i++)
            {
                bit32 t = Random;

                Assert.AreEqual(t.TestAll(), __countbits(t, 0, 32) == 32);
            }
        }

        [Test]
        public static void TestAll_BitField()
        {
            for (int i = 0; i < 128; i++)
            {
                int idx = RandomIndex();
                int num = RandomNumBits(idx);
                bit32 t = Random;

                Assert.AreEqual(t.TestAll(idx, num), __countbits(t, idx, num) == num);
            }
        }
        
        [Test]
        public static void TestAny()
        {
            for (int i = 0; i < 128; i++)
            {
                bit32 t = Random;

                Assert.AreEqual(t.TestAny(), __countbits(t, 0, 32) != 0);
            }
        }

        [Test]
        public static void TestAny_BitField()
        {
            for (int i = 0; i < 128; i++)
            {
                int idx = RandomIndex();
                int num = RandomNumBits(idx);
                bit32 t = Random;

                Assert.AreEqual(t.TestAny(idx, num), __countbits(t, idx, num) != 0);
            }
        }
        
        [Test]
        public static void TestNone()
        {
            for (int i = 0; i < 128; i++)
            {
                bit32 t = Random;

                Assert.AreEqual(t.TestNone(), __countbits(t, 0, 32) == 0);
            }
        }

        [Test]
        public static void TestNone_BitField()
        {
            for (int i = 0; i < 128; i++)
            {
                int idx = RandomIndex();
                int num = RandomNumBits(idx);
                bit32 t = Random;

                Assert.AreEqual(t.TestNone(idx, num), __countbits(t, idx, num) == 0);
            }
        }
        
        [Test]
        public static void TestNotAll()
        {
            for (int i = 0; i < 128; i++)
            {
                bit32 t = Random;

                Assert.AreEqual(t.TestNotAll(), __countbits(t, 0, 32) != 32);
            }
        }

        [Test]
        public static void TestNotAll_BitField()
        {
            for (int i = 0; i < 128; i++)
            {
                int idx = RandomIndex();
                int num = RandomNumBits(idx);
                bit32 t = Random;

                Assert.AreEqual(t.TestNotAll(idx, num), __countbits(t, idx, num) != num);
            }
        }
    }
}