using NUnit.Framework;
using MaxMath;

namespace BitCollections.Tests
{
    internal static class _Int2x24
    {
        internal static Int2x24 TestData_LHS => new Int2x24(Int2.MaxValue, 1, -2, 0, 0, 1, -1, 0, -1, -1, 1, 0, -2, -1, 1, -2, -1, -1, -1, 0, -2, 1, -2, 0);
        internal static Int2x24 TestData_RHS => new Int2x24(Int2.MinValue, 1, -1, -1, -2, 1, 0, -2, 0, -1, -2, -2, 1, -1, 0, -2, -2, 1, 1, 1, 0, -2, -1, 0);

        private static Int2x24 Random(sbyte min = Int2.MinValue, sbyte max = Int2.MaxValue + 1)
        {
            Random8 rng = Random8.New;

            Int2x24 test = new Int2x24();
            for (int i = 0; i < 24; i++)
            {
                test[i] = rng.NextSByte(min, max);
            }

            return test;
        }
        
        private static int RandomInt(int min = Int2.MinValue, int max = Int2.MaxValue + 1)
        {
            Random32 rng = Random32.New;

            return rng.NextInt(min, max);
        }

        [Test]
        public static void Constructor_int()
        {
            bool result = true;

            Int2x24 test = new Int2x24(-2);
            result &= test.x0 == -2;
            result &= test.x1 == -2;
            result &= test.x2 == -2;
            result &= test.x3 == -2;
            result &= test.x4 == -2;
            result &= test.x5 == -2;
            result &= test.x6 == -2;
            result &= test.x7 == -2;
            result &= test.x8 == -2;
            result &= test.x9 == -2;
            result &= test.x10 == -2;
            result &= test.x11 == -2;
            result &= test.x12 == -2;
            result &= test.x13 == -2;
            result &= test.x14 == -2;
            result &= test.x15 == -2;
            result &= test.x16 == -2;
            result &= test.x17 == -2;
            result &= test.x18 == -2;
            result &= test.x19 == -2;
            result &= test.x20 == -2;
            result &= test.x21 == -2;
            result &= test.x22 == -2;
            result &= test.x23 == -2;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_intx24()
        {
            bool result = true;

            Int2x24 test = new Int2x24(1, 0, 0, -2, -1, 1, 0, -2, -1, 1, -2, 0, 1, 0, -1, -2, -1, 0, 1, -2, -2, 1, 0, -1);

            result &= test.x0 == 1;
            result &= test.x1 == 0;
            result &= test.x2 == 0;
            result &= test.x3 == -2;
            result &= test.x4 == -1;
            result &= test.x5 == 1;
            result &= test.x6 == 0;
            result &= test.x7 == -2;
            result &= test.x8 == -1;
            result &= test.x9 == 1;
            result &= test.x10 == -2;
            result &= test.x11 == 0;
            result &= test.x12 == 1;
            result &= test.x13 == 0;
            result &= test.x14 == -1;
            result &= test.x15 == -2;
            result &= test.x16 == -1;
            result &= test.x17 == 0;
            result &= test.x18 == 1;
            result &= test.x19 == -2;
            result &= test.x20 == -2;
            result &= test.x21 == 1;
            result &= test.x22 == 0;
            result &= test.x23 == -1;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void GetSingle()
        {
            bool result = true;

            result &= TestData_LHS[0] == Int2.MaxValue;
            result &= TestData_LHS[1] == 1;
            result &= TestData_LHS[2] == -2;
            result &= TestData_LHS[3] == 0;
            result &= TestData_LHS[4] == 0;
            result &= TestData_LHS[5] == 1;
            result &= TestData_LHS[6] == -1;
            result &= TestData_LHS[7] == 0;
            result &= TestData_LHS[8] == -1;
            result &= TestData_LHS[9] == -1;
            result &= TestData_LHS[10] == 1;
            result &= TestData_LHS[11] == 0;
            result &= TestData_LHS[12] == -2;
            result &= TestData_LHS[13] == -1;
            result &= TestData_LHS[14] == 1;
            result &= TestData_LHS[15] == -2;
            result &= TestData_LHS[16] == -1;
            result &= TestData_LHS[17] == -1;
            result &= TestData_LHS[18] == -1;
            result &= TestData_LHS[19] == 0;
            result &= TestData_LHS[20] == -2;
            result &= TestData_LHS[21] == 1;
            result &= TestData_LHS[22] == -2;
            result &= TestData_LHS[23] == 0;

            result &= TestData_RHS[0] == Int2.MinValue;
            result &= TestData_RHS[1] == 1;
            result &= TestData_RHS[2] == -1;
            result &= TestData_RHS[3] == -1;
            result &= TestData_RHS[4] == -2;
            result &= TestData_RHS[5] == 1;
            result &= TestData_RHS[6] == 0;
            result &= TestData_RHS[7] == -2;
            result &= TestData_RHS[8] == 0;
            result &= TestData_RHS[9] == -1;
            result &= TestData_RHS[10] == -2;
            result &= TestData_RHS[11] == -2;
            result &= TestData_RHS[12] == 1;
            result &= TestData_RHS[13] == -1;
            result &= TestData_RHS[14] == 0;
            result &= TestData_RHS[15] == -2;
            result &= TestData_RHS[16] == -2;
            result &= TestData_RHS[17] == 1;
            result &= TestData_RHS[18] == 1;
            result &= TestData_RHS[19] == 1;
            result &= TestData_RHS[20] == 0;
            result &= TestData_RHS[21] == -2;
            result &= TestData_RHS[22] == -1;
            result &= TestData_RHS[23] == 0;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetSingle()
        {
            bool result = true;

            Random32 rng = new Random32(1937519u);

            for (int i = 0; i < 24; i++)
            {
                Int2x24 test = TestData_LHS;
                int randomInt = rng.NextInt(Int2.MinValue, Int2.MaxValue + 1);
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
                result &= test[20] == ((i == 20) ? randomInt : TestData_LHS.x20);
                result &= test[21] == ((i == 21) ? randomInt : TestData_LHS.x21);
                result &= test[22] == ((i == 22) ? randomInt : TestData_LHS.x22);
                result &= test[23] == ((i == 23) ? randomInt : TestData_LHS.x23);
            }

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void GetVector()
        {
            bool result = true;

            for (int i = 0; i < 21; i++)
            {
                long4 test = TestData_LHS.GetSubArray(i);

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
            long4 vector = new long4(0, 1, -1, -2);

            for (int i = 0; i < 21; i++)
            {
                Int2x24 test = TestData_LHS;
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
                result &= test[17] == ((i == 14) ? vector.w : ((i == 15) ? vector.z : ((i == 16) ? vector.y : ((i == 17) ? vector.x : TestData_LHS.x17))));
                result &= test[18] == ((i == 15) ? vector.w : ((i == 16) ? vector.z : ((i == 17) ? vector.y : ((i == 18) ? vector.x : TestData_LHS.x18))));
                result &= test[19] == ((i == 16) ? vector.w : ((i == 17) ? vector.z : ((i == 18) ? vector.y : ((i == 19) ? vector.x : TestData_LHS.x19))));
                result &= test[20] == ((i == 17) ? vector.w : ((i == 18) ? vector.z : ((i == 19) ? vector.y : ((i == 20) ? vector.x : TestData_LHS.x20))));
                result &= test[21] == ((i == 18) ? vector.w : ((i == 19) ? vector.z : ((i == 20) ? vector.y : TestData_LHS.x21)));
                result &= test[22] == ((i == 19) ? vector.w : ((i == 20) ? vector.z : TestData_LHS.x22));
                result &= test[23] == ((i == 20) ? vector.w : TestData_LHS.x23);
            }

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Negate()
        {
            for (int i = 0; i < 64; i++)
            {
                Int2x24 l = Random();
                Int2x24 neg = -l;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(neg[j], l[j] == Int2.MinValue ? Int2.MinValue : -l[j]);
                }
            }
        }

        [Test]
        public static void AddVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int2x24 l = Random();
                Int2x24 r = Random();
                Int2x24 add = l + r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(add[j], maxmath.signextend((l[j] + r[j]) & maxmath.bitmask32((int)default(Int2).Bits), default(Int2).Bits));
                }
            }
        }

        [Test]
        public static void AddVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int2x24 l = Random();
                int r = RandomInt();
                Int2x24 add = l + r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(add[j], maxmath.signextend((l[j] + r) & maxmath.bitmask32((int)default(Int2).Bits), default(Int2).Bits));
                }
            }
        }

        [Test]
        public static void AddScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int2x24 r = Random();
                Int2x24 add = l + r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(add[j], maxmath.signextend((l + r[j]) & maxmath.bitmask32((int)default(Int2).Bits), default(Int2).Bits));
                }
            }
        }

        [Test]
        public static void SubVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int2x24 l = Random();
                Int2x24 r = Random();
                Int2x24 sub = l - r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(sub[j], maxmath.signextend((l[j] - r[j]) & maxmath.bitmask32((int)default(Int2).Bits), default(Int2).Bits));
                }
            }
        }

        [Test]
        public static void SubVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int2x24 l = Random();
                int r = RandomInt();
                Int2x24 sub = l - r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(sub[j], maxmath.signextend((l[j] - r) & maxmath.bitmask32((int)default(Int2).Bits), default(Int2).Bits));
                }
            }
        }

        [Test]
        public static void SubScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int2x24 r = Random();
                Int2x24 sub = l - r;
                
                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(sub[j], maxmath.signextend((l - r[j]) & maxmath.bitmask32((int)default(Int2).Bits), default(Int2).Bits));
                }
            }
        }

        [Test]
        public static void MulVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int2x24 l = Random();
                Int2x24 r = Random();
                Int2x24 mul = l * r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(mul[j], maxmath.signextend((l[j] * r[j]) & maxmath.bitmask32((int)default(Int2).Bits), default(Int2).Bits));
                }
            }
        }

        [Test]
        public static void MulVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int2x24 l = Random();
                int r = RandomInt();
                Int2x24 mul = l * r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(mul[j], maxmath.signextend((l[j] * r) & maxmath.bitmask32((int)default(Int2).Bits), default(Int2).Bits));
                }
            }
        }

        [Test]
        public static void MulScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int2x24 r = Random();
                Int2x24 mul = l * r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(mul[j], maxmath.signextend((l * r[j]) & maxmath.bitmask32((int)default(Int2).Bits), default(Int2).Bits));
                }
            }
        }

        [Test]
        public static void DivVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int2x24 l = Random();
                Int2x24 r = Random();
                for (int j = 0; j < 24; j++)
                {
                    if (r[j] == 0)
                    {
                        r[j] = 1;
                    }
                }

                Int2x24 div = l / r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(div[j], maxmath.signextend((l[j] / r[j]) & maxmath.bitmask32((int)default(Int2).Bits), default(Int2).Bits));
                }
            }
        }

        [Test]
        public static void DivVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int2x24 l = Random();
                int r = RandomInt();
                if (r == 0)
                {
                    r = 1;
                }

                Int2x24 div = l / r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(div[j], maxmath.signextend((l[j] / r) & maxmath.bitmask32((int)default(Int2).Bits), default(Int2).Bits));
                }
            }
        }

        [Test]
        public static void DivScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int2x24 r = Random();
                for (int j = 0; j < 24; j++)
                {
                    if (r[j] == 0)
                    {
                        r[j] = 1;
                    }
                }

                Int2x24 div = l / r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(div[j], maxmath.signextend((l / r[j]) & maxmath.bitmask32((int)default(Int2).Bits), default(Int2).Bits));
                }
            }
        }

        [Test]
        public static void ModVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int2x24 l = Random();
                Int2x24 r = Random();
                for (int j = 0; j < 24; j++)
                {
                    if (r[j] == 0)
                    {
                        r[j] = 1;
                    }
                }

                Int2x24 mod = l % r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(mod[j], maxmath.signextend((l[j] % r[j]) & maxmath.bitmask32((int)default(Int2).Bits), default(Int2).Bits));
                }
            }
        }

        [Test]
        public static void ModVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int2x24 l = Random();
                int r = RandomInt();
                if (r == 0)
                {
                    r = 1;
                }

                Int2x24 mod = l % r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(mod[j], maxmath.signextend((l[j] % r) & maxmath.bitmask32((int)default(Int2).Bits), default(Int2).Bits));
                }
            }
        }

        [Test]
        public static void ModScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int2x24 r = Random();
                for (int j = 0; j < 24; j++)
                {
                    if (r[j] == 0)
                    {
                        r[j] = 1;
                    }
                }

                Int2x24 mod = l % r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(mod[j], maxmath.signextend((l % r[j]) & maxmath.bitmask32((int)default(Int2).Bits), default(Int2).Bits));
                }
            }
        }

        [Test]
        public static void AndVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int2x24 l = Random();
                Int2x24 r = Random();
                Int2x24 and = l & r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(and[j], maxmath.signextend((l[j] & r[j]) & maxmath.bitmask32((int)default(Int2).Bits), default(Int2).Bits));
                }
            }
        }

        [Test]
        public static void AndVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int2x24 l = Random();
                int r = RandomInt();
                Int2x24 and = l & r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(and[j], maxmath.signextend((l[j] & r) & maxmath.bitmask32((int)default(Int2).Bits), default(Int2).Bits));
                }
            }
        }

        [Test]
        public static void AndScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int2x24 r = Random();
                Int2x24 and = l & r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(and[j], maxmath.signextend((l & r[j]) & maxmath.bitmask32((int)default(Int2).Bits), default(Int2).Bits));
                }
            }
        }

        [Test]
        public static void OrVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int2x24 l = Random();
                Int2x24 r = Random();
                Int2x24 or = l | r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(or[j], maxmath.signextend((l[j] | r[j]) & maxmath.bitmask32((int)default(Int2).Bits), default(Int2).Bits));
                }
            }
        }

        [Test]
        public static void OrVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int2x24 l = Random();
                int r = RandomInt();
                Int2x24 or = l | r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(or[j], maxmath.signextend((l[j] | r) & maxmath.bitmask32((int)default(Int2).Bits), default(Int2).Bits));
                }
            }
        }

        [Test]
        public static void OrScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int2x24 r = Random();
                Int2x24 or = l | r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(or[j], maxmath.signextend((l | r[j]) & maxmath.bitmask32((int)default(Int2).Bits), default(Int2).Bits));
                }
            }
        }

        [Test]
        public static void XorVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int2x24 l = Random();
                Int2x24 r = Random();
                Int2x24 xor = l ^ r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(xor[j], maxmath.signextend((l[j] ^ r[j]) & maxmath.bitmask32((int)default(Int2).Bits), default(Int2).Bits));
                }
            }
        }

        [Test]
        public static void XorVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int2x24 l = Random();
                int r = RandomInt();
                Int2x24 xor = l ^ r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(xor[j], maxmath.signextend((l[j] ^ r) & maxmath.bitmask32((int)default(Int2).Bits), default(Int2).Bits));
                }
            }
        }

        [Test]
        public static void XorScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int2x24 r = Random();
                Int2x24 xor = l ^ r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(xor[j], maxmath.signextend((l ^ r[j]) & maxmath.bitmask32((int)default(Int2).Bits), default(Int2).Bits));
                }
            }
        }

        [Test]
        public static void EqualVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int2x24 l = Random();
                Int2x24 r = Random();
                Int2x24 equal = l == r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(maxmath.tobool(equal[j]), l[j] == r[j]);
                }
            }
        }

        [Test]
        public static void EqualVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int2x24 l = Random();
                int r = RandomInt();
                Int2x24 equal = l == r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(maxmath.tobool(equal[j]), l[j] == r);
                }
            }
        }

        [Test]
        public static void EqualScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int2x24 r = Random();
                Int2x24 equal = l == r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(maxmath.tobool(equal[j]), l == r[j]);
                }
            }
        }

        [Test]
        public static void NotEqualVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int2x24 l = Random();
                Int2x24 r = Random();
                Int2x24 notEqual = l != r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(maxmath.tobool(notEqual[j]), l[j] != r[j]);
                }
            }
        }

        [Test]
        public static void NotEqualVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int2x24 l = Random();
                int r = RandomInt();
                Int2x24 notEqual = l != r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(maxmath.tobool(notEqual[j]), l[j] != r);
                }
            }
        }

        [Test]
        public static void NotEqualScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int2x24 r = Random();
                Int2x24 notEqual = l != r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(maxmath.tobool(notEqual[j]), l != r[j]);
                }
            }
        }

        [Test]
        public static void LessVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int2x24 l = Random();
                Int2x24 r = Random();
                Int2x24 less = l < r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(maxmath.tobool(less[j]), l[j] < r[j]);
                }
            }
        }

        [Test]
        public static void LessVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int2x24 l = Random();
                int r = RandomInt();
                Int2x24 less = l < r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(maxmath.tobool(less[j]), l[j] < r);
                }
            }
        }

        [Test]
        public static void LessScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int2x24 r = Random();
                Int2x24 less = l < r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(maxmath.tobool(less[j]), l < r[j]);
                }
            }
        }

        [Test]
        public static void GreaterVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int2x24 l = Random();
                Int2x24 r = Random();
                Int2x24 greater = l > r;
                
                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(maxmath.tobool(greater[j]), l[j] > r[j]);
                }
            }
        }

        [Test]
        public static void GreaterVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int2x24 l = Random();
                int r = RandomInt();
                Int2x24 greater = l > r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(maxmath.tobool(greater[j]), l[j] > r);
                }
            }
        }

        [Test]
        public static void GreaterScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int2x24 r = Random();
                Int2x24 greater = l > r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(maxmath.tobool(greater[j]), l > r[j]);
                }
            }
        }

        [Test]
        public static void LessEqualVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int2x24 l = Random();
                Int2x24 r = Random();
                Int2x24 lessEqual = l <= r;
                
                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(maxmath.tobool(lessEqual[j]), l[j] <= r[j]);
                }
            }
        }

        [Test]
        public static void LessEqualVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int2x24 l = Random();
                int r = RandomInt();
                Int2x24 lessEqual = l <= r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(maxmath.tobool(lessEqual[j]), l[j] <= r);
                }
            }
        }

        [Test]
        public static void LessEqualScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int2x24 r = Random();
                Int2x24 lessEqual = l <= r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(maxmath.tobool(lessEqual[j]), l <= r[j]);
                }
            }
        }

        [Test]
        public static void GreaterEqualVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int2x24 l = Random();
                Int2x24 r = Random();
                Int2x24 greaterEqual = l >= r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(maxmath.tobool(greaterEqual[j]), l[j] >= r[j]);
                }
            }
        }

        [Test]
        public static void GreaterEqualVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int2x24 l = Random();
                int r = RandomInt();
                Int2x24 greaterEqual = l >= r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(maxmath.tobool(greaterEqual[j]), l[j] >= r);
                }
            }
        }

        [Test]
        public static void GreaterEqualScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int2x24 r = Random();
                Int2x24 greaterEqual = l >= r;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(maxmath.tobool(greaterEqual[j]), l >= r[j]);
                }
            }
        }

        [Test]
        public static void Not()
        {
            for (int i = 0; i < 64; i++)
            {
                Int2x24 x = Random();
                Int2x24 not = ~x;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(not[j], ~x[j]);
                }
            }
        }

        [Test]
        public static void ShiftLeft()
        {
            for (int i = 0; i < 64; i++)
            {
                Int2x24 x = Random();
                int n = (int)RandomInt(0, default(Int2).Bits);
                Int2x24 shiftLeft = x << n;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(shiftLeft[j], maxmath.signextend((x[j] << n) & maxmath.bitmask32((int)default(Int2).Bits), default(Int2).Bits));
                }
            }
        }

        [Test]
        public static void ShiftRight()
        {
            for (int i = 0; i < 64; i++)
            {
                Int2x24 x = Random();
                int n = (int)RandomInt(0, default(Int2).Bits);
                Int2x24 shiftRight = x >> n;

                for (int j = 0; j < 24; j++)
                {
                    Assert.AreEqual(shiftRight[j], x[j] >> n);
                }
            }
        }
    }
}