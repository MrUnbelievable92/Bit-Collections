using NUnit.Framework;
using MaxMath;
using Unity.Mathematics;

namespace BitCollections.Tests
{
    internal static class _Int2x12
    {
        internal static Int2x12 TestData_LHS => new Int2x12(Int2.MaxValue, 1, -2, 0, 0, 1, -1, 0, -1, -1, 1, 0);
        internal static Int2x12 TestData_RHS => new Int2x12(Int2.MinValue, 1, -1, -1, -2, 1, 0, -2, 0, -1, -2, -2);
        
        private static Int2x12 Random(sbyte min = Int2.MinValue, sbyte max = Int2.MaxValue + 1)
        {
            Random8 rng = Random8.New;

            Int2x12 test = new Int2x12();
            for (int i = 0; i < 12; i++)
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

            Int2x12 test = new Int2x12(-2);
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

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_intx12()
        {
            bool result = true;

            Int2x12 test = new Int2x12(1, 0, 0, -2, -1, 1, 0, -2, -1, 1, -2, 0);

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

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetSingle()
        {
            bool result = true;

            Random32 rng = new Random32(1937519u);

            for (int i = 0; i < 12; i++)
            {
                Int2x12 test = TestData_LHS;
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
            }

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void ToFromInt4x12()
        {
            Int2x12 test = Random();
            Int4x12 byte12test = (Int4x12)test;

            for (int i = 0; i < 12; i++)
            {
                Assert.AreEqual(test[i], byte12test[i]);
            }

            test = (Int2x12)byte12test;

            for (int i = 0; i < 12; i++)
            {
                Assert.AreEqual(test[i], byte12test[i]);
            }
        }

        [Test]
        public static void ToFromUInt4x12()
        {
            Int2x12 test = Random(0);
            UInt4x12 byte12test = (UInt4x12)test;

            for (int i = 0; i < 12; i++)
            {
                Assert.AreEqual(((UInt4x12)((Int4x12)test))[i], byte12test[i]);
            }

            test = (Int2x12)byte12test;

            for (int i = 0; i < 12; i++)
            {
                Assert.AreEqual(((UInt4x12)((Int4x12)test))[i], byte12test[i]);
            }
        }

        [Test]
        public static void Negate()
        {
            for (int i = 0; i < 64; i++)
            {
                Int2x12 l = Random();
                Int2x12 neg = -l;

                for (int j = 0; j < 12; j++)
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
                Int2x12 l = Random();
                Int2x12 r = Random();
                Int2x12 add = l + r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 l = Random();
                int r = RandomInt();
                Int2x12 add = l + r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 r = Random();
                Int2x12 add = l + r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 l = Random();
                Int2x12 r = Random();
                Int2x12 sub = l - r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 l = Random();
                int r = RandomInt();
                Int2x12 sub = l - r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 r = Random();
                Int2x12 sub = l - r;
                
                for (int j = 0; j < 12; j++)
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
                Int2x12 l = Random();
                Int2x12 r = Random();
                Int2x12 mul = l * r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 l = Random();
                int r = RandomInt();
                Int2x12 mul = l * r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 r = Random();
                Int2x12 mul = l * r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 l = Random();
                Int2x12 r = Random();
                for (int j = 0; j < 12; j++)
                {
                    if (r[j] == 0)
                    {
                        r[j] = 1;
                    }
                }

                Int2x12 div = l / r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 l = Random();
                int r = RandomInt();
                if (r == 0)
                {
                    r = 1;
                }

                Int2x12 div = l / r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 r = Random();
                for (int j = 0; j < 12; j++)
                {
                    if (r[j] == 0)
                    {
                        r[j] = 1;
                    }
                }

                Int2x12 div = l / r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 l = Random();
                Int2x12 r = Random();
                for (int j = 0; j < 12; j++)
                {
                    if (r[j] == 0)
                    {
                        r[j] = 1;
                    }
                }

                Int2x12 mod = l % r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 l = Random();
                int r = RandomInt();
                if (r == 0)
                {
                    r = 1;
                }

                Int2x12 mod = l % r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 r = Random();
                for (int j = 0; j < 12; j++)
                {
                    if (r[j] == 0)
                    {
                        r[j] = 1;
                    }
                }

                Int2x12 mod = l % r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 l = Random();
                Int2x12 r = Random();
                Int2x12 and = l & r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 l = Random();
                int r = RandomInt();
                Int2x12 and = l & r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 r = Random();
                Int2x12 and = l & r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 l = Random();
                Int2x12 r = Random();
                Int2x12 or = l | r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 l = Random();
                int r = RandomInt();
                Int2x12 or = l | r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 r = Random();
                Int2x12 or = l | r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 l = Random();
                Int2x12 r = Random();
                Int2x12 xor = l ^ r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 l = Random();
                int r = RandomInt();
                Int2x12 xor = l ^ r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 r = Random();
                Int2x12 xor = l ^ r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 l = Random();
                Int2x12 r = Random();
                Int2x12 equal = l == r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 l = Random();
                int r = RandomInt();
                Int2x12 equal = l == r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 r = Random();
                Int2x12 equal = l == r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 l = Random();
                Int2x12 r = Random();
                Int2x12 notEqual = l != r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 l = Random();
                int r = RandomInt();
                Int2x12 notEqual = l != r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 r = Random();
                Int2x12 notEqual = l != r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 l = Random();
                Int2x12 r = Random();
                Int2x12 less = l < r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 l = Random();
                int r = RandomInt();
                Int2x12 less = l < r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 r = Random();
                Int2x12 less = l < r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 l = Random();
                Int2x12 r = Random();
                Int2x12 greater = l > r;
                
                for (int j = 0; j < 12; j++)
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
                Int2x12 l = Random();
                int r = RandomInt();
                Int2x12 greater = l > r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 r = Random();
                Int2x12 greater = l > r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 l = Random();
                Int2x12 r = Random();
                Int2x12 lessEqual = l <= r;
                
                for (int j = 0; j < 12; j++)
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
                Int2x12 l = Random();
                int r = RandomInt();
                Int2x12 lessEqual = l <= r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 r = Random();
                Int2x12 lessEqual = l <= r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 l = Random();
                Int2x12 r = Random();
                Int2x12 greaterEqual = l >= r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 l = Random();
                int r = RandomInt();
                Int2x12 greaterEqual = l >= r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 r = Random();
                Int2x12 greaterEqual = l >= r;

                for (int j = 0; j < 12; j++)
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
                Int2x12 x = Random();
                Int2x12 not = ~x;

                for (int j = 0; j < 12; j++)
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
                Int2x12 x = Random();
                int n = (int)RandomInt(0, default(Int2).Bits);
                Int2x12 shiftLeft = x << n;

                for (int j = 0; j < 12; j++)
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
                Int2x12 x = Random();
                int n = (int)RandomInt(0, default(Int2).Bits);
                Int2x12 shiftRight = x >> n;

                for (int j = 0; j < 12; j++)
                {
                    Assert.AreEqual(shiftRight[j], x[j] >> n);
                }
            }
        }
    }
}