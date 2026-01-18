using NUnit.Framework;
using MaxMath;
using Unity.Mathematics;

namespace BitCollections.Tests
{
    internal static class _Int7x8
    {
        internal static Int7x8 TestData_LHS => new Int7x8(Int7.MaxValue, -11, 2, 21, -9, 55, -33, 50);
        internal static Int7x8 TestData_RHS => new Int7x8(Int7.MinValue, -61, 43, -23, 0, 1, -9, 62);


        private static Int7x8 Random(sbyte min = Int7.MinValue, sbyte max = Int7.MaxValue + 1)
        {
            Random8 rng = Random8.New;

            Int7x8 test = new Int7x8();
            for (int i = 0; i < 8; i++)
            {
                test[i] = rng.NextSByte(min, max);
            }

            return test;
        }
        
        private static int RandomInt(int min = Int7.MinValue, int max = Int7.MaxValue + 1)
        {
            Random32 rng = Random32.New;

            return rng.NextInt(min, max);
        }

        [Test]
        public static void Constructor_int()
        {
            bool result = true;

            Int7x8 test = new Int7x8(47);
            result &= test.x0 == 47;
            result &= test.x1 == 47;
            result &= test.x2 == 47;
            result &= test.x3 == 47;
            result &= test.x4 == 47;
            result &= test.x5 == 47;
            result &= test.x6 == 47;
            result &= test.x7 == 47;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_intx8()
        {
            bool result = true;

            Int7x8 test = new Int7x8(1, 30, -20, 12, -17, 47, 0, -53);

            result &= test.x0 == 1;
            result &= test.x1 == 30;
            result &= test.x2 == -20;
            result &= test.x3 == 12;
            result &= test.x4 == -17;
            result &= test.x5 == 47;
            result &= test.x6 == 0;
            result &= test.x7 == -53;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void GetSingle()
        {
            bool result = true;

            result &= TestData_LHS[0] == Int7.MaxValue;
            result &= TestData_LHS[1] == -11;
            result &= TestData_LHS[2] == 2;
            result &= TestData_LHS[3] == 21;
            result &= TestData_LHS[4] == -9;
            result &= TestData_LHS[5] == 55;
            result &= TestData_LHS[6] == -33;
            result &= TestData_LHS[7] == 50;

            result &= TestData_RHS[0] == Int7.MinValue;
            result &= TestData_RHS[1] == -61;
            result &= TestData_RHS[2] == 43;
            result &= TestData_RHS[3] == -23;
            result &= TestData_RHS[4] == 0;
            result &= TestData_RHS[5] == 1;
            result &= TestData_RHS[6] == -9;
            result &= TestData_RHS[7] == 62;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetSingle()
        {
            bool result = true;

            Random32 rng = new Random32(1937519u);

            for (int i = 0; i < 8; i++)
            {
                Int7x8 test = TestData_LHS;
                int randomInt = rng.NextInt(Int7.MinValue, Int7.MaxValue + 1);
                test[i] = randomInt;

                result &= test[0] == ((i == 0) ? randomInt : TestData_LHS.x0);
                result &= test[1] == ((i == 1) ? randomInt : TestData_LHS.x1);
                result &= test[2] == ((i == 2) ? randomInt : TestData_LHS.x2);
                result &= test[3] == ((i == 3) ? randomInt : TestData_LHS.x3);
                result &= test[4] == ((i == 4) ? randomInt : TestData_LHS.x4);
                result &= test[5] == ((i == 5) ? randomInt : TestData_LHS.x5);
                result &= test[6] == ((i == 6) ? randomInt : TestData_LHS.x6);
                result &= test[7] == ((i == 7) ? randomInt : TestData_LHS.x7);
            }

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void ToFromByte8()
        {
            Int7x8 test = Random(0);
            byte8 byte8test = (byte8)test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((byte)test[i], byte8test[i]);
            }

            test = (Int7x8)byte8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((byte)test[i], byte8test[i]);
            }
        }

        [Test]
        public static void ToFromSByte8()
        {
            Int7x8 test = Random();
            sbyte8 sbyte8test = test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)sbyte8test[i]);
            }

            test = (Int7x8)sbyte8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)sbyte8test[i]);
            }
        }

        [Test]
        public static void ToFromUShort8()
        {
            Int7x8 test = Random(0);
            ushort8 ushort8test = (ushort8)test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((ushort)test[i], ushort8test[i]);
            }

            test = (Int7x8)ushort8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((ushort)test[i], ushort8test[i]);
            }
        }

        [Test]
        public static void ToFromShort8()
        {
            Int7x8 test = Random();
            short8 short8test = test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)short8test[i]);
            }

            test = (Int7x8)short8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)short8test[i]);
            }
        }

        [Test]
        public static void ToFromUInt8()
        {
            Int7x8 test = Random(0);
            uint8 uint8test = (uint8)test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], uint8test[i]);
            }

            test = (Int7x8)uint8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], uint8test[i]);
            }
        }

        [Test]
        public static void ToFromInt8()
        {
            Int7x8 test = Random();
            int8 int8test = test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)int8test[i]);
            }

            test = (Int7x8)int8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)int8test[i]);
            }
        }

        [Test]
        public static void ToFromQuarter8()
        {
            Int7x8 test = Random((sbyte)(quarter.MinValue), (sbyte)(quarter.MaxValue + 1));
            quarter8 quarter8test = (quarter8)test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((quarter)test[i], quarter8test[i]);
            }

            test = (Int7x8)quarter8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((quarter)test[i], quarter8test[i]);
            }
        }

        [Test]
        public static void ToFromHalf8()
        {
            Int7x8 test = Random();
            half8 half8test = test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((half)test[i], half8test[i]);
            }

            test = (Int7x8)half8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((half)test[i], half8test[i]);
            }
        }

        [Test]
        public static void ToFromFloat8()
        {
            Int7x8 test = Random();
            float8 float8test = test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((float)test[i], float8test[i]);
            }

            test = (Int7x8)float8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((float)test[i], float8test[i]);
            }
        }

        [Test]
        public static void Negate()
        {
            for (int i = 0; i < 64; i++)
            {
                Int7x8 l = Random();
                Int7x8 neg = -l;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(neg[j], l[j] == Int7.MinValue ? Int7.MinValue : -l[j]);
                }
            }
        }

        [Test]
        public static void AddVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int7x8 l = Random();
                Int7x8 r = Random();
                Int7x8 add = l + r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(add[j], maxmath.signextend((l[j] + r[j]) & maxmath.bitmask32((int)default(Int7).Bits), default(Int7).Bits));
                }
            }
        }

        [Test]
        public static void AddVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int7x8 l = Random();
                int r = RandomInt();
                Int7x8 add = l + r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(add[j], maxmath.signextend((l[j] + r) & maxmath.bitmask32((int)default(Int7).Bits), default(Int7).Bits));
                }
            }
        }

        [Test]
        public static void AddScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int7x8 r = Random();
                Int7x8 add = l + r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(add[j], maxmath.signextend((l + r[j]) & maxmath.bitmask32((int)default(Int7).Bits), default(Int7).Bits));
                }
            }
        }

        [Test]
        public static void SubVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int7x8 l = Random();
                Int7x8 r = Random();
                Int7x8 sub = l - r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(sub[j], maxmath.signextend((l[j] - r[j]) & maxmath.bitmask32((int)default(Int7).Bits), default(Int7).Bits));
                }
            }
        }

        [Test]
        public static void SubVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int7x8 l = Random();
                int r = RandomInt();
                Int7x8 sub = l - r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(sub[j], maxmath.signextend((l[j] - r) & maxmath.bitmask32((int)default(Int7).Bits), default(Int7).Bits));
                }
            }
        }

        [Test]
        public static void SubScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int7x8 r = Random();
                Int7x8 sub = l - r;
                
                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(sub[j], maxmath.signextend((l - r[j]) & maxmath.bitmask32((int)default(Int7).Bits), default(Int7).Bits));
                }
            }
        }

        [Test]
        public static void MulVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int7x8 l = Random();
                Int7x8 r = Random();
                Int7x8 mul = l * r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(mul[j], maxmath.signextend((l[j] * r[j]) & maxmath.bitmask32((int)default(Int7).Bits), default(Int7).Bits));
                }
            }
        }

        [Test]
        public static void MulVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int7x8 l = Random();
                int r = RandomInt();
                Int7x8 mul = l * r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(mul[j], maxmath.signextend((l[j] * r) & maxmath.bitmask32((int)default(Int7).Bits), default(Int7).Bits));
                }
            }
        }

        [Test]
        public static void MulScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int7x8 r = Random();
                Int7x8 mul = l * r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(mul[j], maxmath.signextend((l * r[j]) & maxmath.bitmask32((int)default(Int7).Bits), default(Int7).Bits));
                }
            }
        }

        [Test]
        public static void DivVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int7x8 l = Random();
                Int7x8 r = Random();
                for (int j = 0; j < 8; j++)
                {
                    if (r[j] == 0)
                    {
                        r[j] = 1;
                    }
                }

                Int7x8 div = l / r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(div[j], maxmath.signextend((l[j] / r[j]) & maxmath.bitmask32((int)default(Int7).Bits), default(Int7).Bits));
                }
            }
        }

        [Test]
        public static void DivVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int7x8 l = Random();
                int r = RandomInt();
                if (r == 0)
                {
                    r = 1;
                }

                Int7x8 div = l / r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(div[j], maxmath.signextend((l[j] / r) & maxmath.bitmask32((int)default(Int7).Bits), default(Int7).Bits));
                }
            }
        }

        [Test]
        public static void DivScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int7x8 r = Random();
                for (int j = 0; j < 8; j++)
                {
                    if (r[j] == 0)
                    {
                        r[j] = 1;
                    }
                }

                Int7x8 div = l / r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(div[j], maxmath.signextend((l / r[j]) & maxmath.bitmask32((int)default(Int7).Bits), default(Int7).Bits));
                }
            }
        }

        [Test]
        public static void ModVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int7x8 l = Random();
                Int7x8 r = Random();
                for (int j = 0; j < 8; j++)
                {
                    if (r[j] == 0)
                    {
                        r[j] = 1;
                    }
                }

                Int7x8 mod = l % r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(mod[j], maxmath.signextend((l[j] % r[j]) & maxmath.bitmask32((int)default(Int7).Bits), default(Int7).Bits));
                }
            }
        }

        [Test]
        public static void ModVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int7x8 l = Random();
                int r = RandomInt();
                if (r == 0)
                {
                    r = 1;
                }

                Int7x8 mod = l % r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(mod[j], maxmath.signextend((l[j] % r) & maxmath.bitmask32((int)default(Int7).Bits), default(Int7).Bits));
                }
            }
        }

        [Test]
        public static void ModScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int7x8 r = Random();
                for (int j = 0; j < 8; j++)
                {
                    if (r[j] == 0)
                    {
                        r[j] = 1;
                    }
                }

                Int7x8 mod = l % r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(mod[j], maxmath.signextend((l % r[j]) & maxmath.bitmask32((int)default(Int7).Bits), default(Int7).Bits));
                }
            }
        }

        [Test]
        public static void AndVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int7x8 l = Random();
                Int7x8 r = Random();
                Int7x8 and = l & r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(and[j], maxmath.signextend((l[j] & r[j]) & maxmath.bitmask32((int)default(Int7).Bits), default(Int7).Bits));
                }
            }
        }

        [Test]
        public static void AndVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int7x8 l = Random();
                int r = RandomInt();
                Int7x8 and = l & r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(and[j], maxmath.signextend((l[j] & r) & maxmath.bitmask32((int)default(Int7).Bits), default(Int7).Bits));
                }
            }
        }

        [Test]
        public static void AndScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int7x8 r = Random();
                Int7x8 and = l & r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(and[j], maxmath.signextend((l & r[j]) & maxmath.bitmask32((int)default(Int7).Bits), default(Int7).Bits));
                }
            }
        }

        [Test]
        public static void OrVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int7x8 l = Random();
                Int7x8 r = Random();
                Int7x8 or = l | r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(or[j], maxmath.signextend((l[j] | r[j]) & maxmath.bitmask32((int)default(Int7).Bits), default(Int7).Bits));
                }
            }
        }

        [Test]
        public static void OrVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int7x8 l = Random();
                int r = RandomInt();
                Int7x8 or = l | r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(or[j], maxmath.signextend((l[j] | r) & maxmath.bitmask32((int)default(Int7).Bits), default(Int7).Bits));
                }
            }
        }

        [Test]
        public static void OrScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int7x8 r = Random();
                Int7x8 or = l | r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(or[j], maxmath.signextend((l | r[j]) & maxmath.bitmask32((int)default(Int7).Bits), default(Int7).Bits));
                }
            }
        }

        [Test]
        public static void XorVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int7x8 l = Random();
                Int7x8 r = Random();
                Int7x8 xor = l ^ r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(xor[j], maxmath.signextend((l[j] ^ r[j]) & maxmath.bitmask32((int)default(Int7).Bits), default(Int7).Bits));
                }
            }
        }

        [Test]
        public static void XorVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int7x8 l = Random();
                int r = RandomInt();
                Int7x8 xor = l ^ r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(xor[j], maxmath.signextend((l[j] ^ r) & maxmath.bitmask32((int)default(Int7).Bits), default(Int7).Bits));
                }
            }
        }

        [Test]
        public static void XorScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int7x8 r = Random();
                Int7x8 xor = l ^ r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(xor[j], maxmath.signextend((l ^ r[j]) & maxmath.bitmask32((int)default(Int7).Bits), default(Int7).Bits));
                }
            }
        }

        [Test]
        public static void EqualVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int7x8 l = Random();
                Int7x8 r = Random();
                Int7x8 equal = l == r;

                for (int j = 0; j < 8; j++)
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
                Int7x8 l = Random();
                int r = RandomInt();
                Int7x8 equal = l == r;

                for (int j = 0; j < 8; j++)
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
                Int7x8 r = Random();
                Int7x8 equal = l == r;

                for (int j = 0; j < 8; j++)
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
                Int7x8 l = Random();
                Int7x8 r = Random();
                Int7x8 notEqual = l != r;

                for (int j = 0; j < 8; j++)
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
                Int7x8 l = Random();
                int r = RandomInt();
                Int7x8 notEqual = l != r;

                for (int j = 0; j < 8; j++)
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
                Int7x8 r = Random();
                Int7x8 notEqual = l != r;

                for (int j = 0; j < 8; j++)
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
                Int7x8 l = Random();
                Int7x8 r = Random();
                Int7x8 less = l < r;

                for (int j = 0; j < 8; j++)
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
                Int7x8 l = Random();
                int r = RandomInt();
                Int7x8 less = l < r;

                for (int j = 0; j < 8; j++)
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
                Int7x8 r = Random();
                Int7x8 less = l < r;

                for (int j = 0; j < 8; j++)
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
                Int7x8 l = Random();
                Int7x8 r = Random();
                Int7x8 greater = l > r;
                
                for (int j = 0; j < 8; j++)
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
                Int7x8 l = Random();
                int r = RandomInt();
                Int7x8 greater = l > r;

                for (int j = 0; j < 8; j++)
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
                Int7x8 r = Random();
                Int7x8 greater = l > r;

                for (int j = 0; j < 8; j++)
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
                Int7x8 l = Random();
                Int7x8 r = Random();
                Int7x8 lessEqual = l <= r;
                
                for (int j = 0; j < 8; j++)
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
                Int7x8 l = Random();
                int r = RandomInt();
                Int7x8 lessEqual = l <= r;

                for (int j = 0; j < 8; j++)
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
                Int7x8 r = Random();
                Int7x8 lessEqual = l <= r;

                for (int j = 0; j < 8; j++)
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
                Int7x8 l = Random();
                Int7x8 r = Random();
                Int7x8 greaterEqual = l >= r;

                for (int j = 0; j < 8; j++)
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
                Int7x8 l = Random();
                int r = RandomInt();
                Int7x8 greaterEqual = l >= r;

                for (int j = 0; j < 8; j++)
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
                Int7x8 r = Random();
                Int7x8 greaterEqual = l >= r;

                for (int j = 0; j < 8; j++)
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
                Int7x8 x = Random();
                Int7x8 not = ~x;

                for (int j = 0; j < 8; j++)
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
                Int7x8 x = Random();
                int n = (int)RandomInt(0, default(Int7).Bits);
                Int7x8 shiftLeft = x << n;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(shiftLeft[j], maxmath.signextend((x[j] << n) & maxmath.bitmask32((int)default(Int7).Bits), default(Int7).Bits));
                }
            }
        }

        [Test]
        public static void ShiftRight()
        {
            for (int i = 0; i < 64; i++)
            {
                Int7x8 x = Random();
                int n = (int)RandomInt(0, default(Int7).Bits);
                Int7x8 shiftRight = x >> n;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(shiftRight[j], x[j] >> n);
                }
            }
        }
    }
}