using NUnit.Framework;
using Unity.Mathematics;
using MaxMath;

namespace BitCollections.Tests
{
    internal static class _Int28x2
    {
        internal static Int28x2 TestData_LHS => new Int28x2(Int28.MaxValue, -100888777);
        internal static Int28x2 TestData_RHS => new Int28x2(Int28.MinValue, 100127340);

        
        private static Int28x2 Random(int min = Int28.MinValue, int max = Int28.MaxValue + 1)
        {
            Random32 rng = Random32.New;

            Int28x2 test = new Int28x2();
            for (int i = 0; i < 2; i++)
            {
                test[i] = rng.NextInt(min, max);
            }

            return test;
        }
        
        private static int RandomInt(int min = Int28.MinValue, int max = Int28.MaxValue + 1)
        {
            Random32 rng = Random32.New;

            return rng.NextInt(min, max);
        }


        [Test]
        public static void Constructor_int()
        {
            bool result = true;

            Int28x2 test = new Int28x2(-1747000);
            result &= test.x == -1747000;
            result &= test.y == -1747000;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_intx2()
        {
            bool result = true;

            Int28x2 test = new Int28x2(-17, 47);

            result &= test.x == -17;
            result &= test.y == 47;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void GetSingle()
        {
            bool result = true;

            result &= TestData_LHS[0] == Int28.MaxValue;
            result &= TestData_LHS[1] == -100888777;

            result &= TestData_RHS[0] == Int28.MinValue;
            result &= TestData_RHS[1] == 100127340;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetSingle()
        {
            bool result = true;

            Random32 rng = new Random32(1937519u);

            for (int i = 0; i < 2; i++)
            {
                Int28x2 test = TestData_LHS;
                int randomInt = rng.NextInt(Int28.MinValue, Int28.MaxValue + 1);
                test[i] = randomInt;

                result &= test[0] == ((i == 0) ? randomInt : TestData_LHS.x);
                result &= test[1] == ((i == 1) ? randomInt : TestData_LHS.y);
            }

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void ToFromByte2()
        {
            Int28x2 test = Random(0, byte.MaxValue + 1);
            byte2 byte2test = (byte2)test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((byte)test[i], byte2test[i]);
            }

            test = (Int28x2)byte2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((byte)test[i], byte2test[i]);
            }
        }

        [Test]
        public static void ToFromSByte2()
        {
            Int28x2 test = Random(sbyte.MinValue, sbyte.MaxValue + 1);
            sbyte2 sbyte2test = (sbyte2)test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((sbyte)test[i], sbyte2test[i]);
            }

            test = (Int28x2)sbyte2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((sbyte)test[i], sbyte2test[i]);
            }
        }

        [Test]
        public static void ToFromUShort2()
        {
            Int28x2 test = Random(0, ushort.MaxValue + 1);
            ushort2 ushort2test = (ushort2)test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((ushort)test[i], ushort2test[i]);
            }

            test = (Int28x2)ushort2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((ushort)test[i], ushort2test[i]);
            }
        }

        [Test]
        public static void ToFromShort2()
        {
            Int28x2 test = Random(short.MinValue, short.MaxValue + 1);
            short2 short2test = (short2)test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((short)test[i], short2test[i]);
            }

            test = (Int28x2)short2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((short)test[i], short2test[i]);
            }
        }

        [Test]
        public static void ToFromUInt2()
        {
            Int28x2 test = Random(0);
            uint2 uint2test = (uint2)test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((uint)test[i], uint2test[i]);
            }

            test = (Int28x2)uint2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((uint)test[i], uint2test[i]);
            }
        }

        [Test]
        public static void ToFromInt2()
        {
            Int28x2 test = Random();
            int2 int2test = test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(test[i], int2test[i]);
            }

            test = (Int28x2)int2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(test[i], int2test[i]);
            }
        }


        [Test]
        public static void ToFromULong2()
        {
            Int28x2 test = Random(0);
            ulong2 ulong2test = (ulong2)test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((ulong)test[i], ulong2test[i]);
            }

            test = (Int28x2)ulong2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((ulong)test[i], ulong2test[i]);
            }
        }

        [Test]
        public static void ToFromLong2()
        {
            Int28x2 test = Random();
            long2 long2test = test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(test[i], long2test[i]);
            }

            test = (Int28x2)long2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(test[i], long2test[i]);
            }
        }

        [Test]
        public static void ToFromQuarter2()
        {
            Int28x2 test = Random((int)quarter.MinValue, (int)quarter.MaxValue + 1);
            quarter2 quarter2test = (quarter2)test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((quarter)test[i], quarter2test[i]);
            }

            test = (Int28x2)quarter2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((quarter)test[i], quarter2test[i]);
            }
        }

        [Test]
        public static void ToFromHalf2()
        {
            Int28x2 test = Random((int)half.MinValue, (int)half.MaxValue + 1);
            half2 half2test = test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((half)test[i], half2test[i]);
            }

            test = (Int28x2)half2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((half)test[i], half2test[i]);
            }
        }

        [Test]
        public static void ToFromFloat2()
        {
            Int28x2 test = Random();
            float2 float2test = test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((float)test[i], float2test[i]);
            }

            test = (Int28x2)float2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((float)test[i], float2test[i]);
            }
        }

        [Test]
        public static void ToFromDouble2()
        {
            Int28x2 test = Random();
            double2 double2test = test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((double)test[i], double2test[i]);
            }

            test = (Int28x2)double2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((double)test[i], double2test[i]);
            }
        }

        [Test]
        public static void Negate()
        {
            for (int i = 0; i < 64; i++)
            {
                Int28x2 l = Random();
                Int28x2 neg = -l;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(neg[j], l[j] == Int28.MinValue ? Int28.MinValue : -l[j]);
                }
            }
        }

        [Test]
        public static void AddVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int28x2 l = Random();
                Int28x2 r = Random();
                Int28x2 add = l + r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(add[j], maxmath.signextend((l[j] + r[j]) & maxmath.bitmask32((int)default(Int28).Bits), default(Int28).Bits));
                }
            }
        }

        [Test]
        public static void AddVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int28x2 l = Random();
                int r = RandomInt();
                Int28x2 add = l + r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(add[j], maxmath.signextend((l[j] + r) & maxmath.bitmask32((int)default(Int28).Bits), default(Int28).Bits));
                }
            }
        }

        [Test]
        public static void AddScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int28x2 r = Random();
                Int28x2 add = l + r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(add[j], maxmath.signextend((l + r[j]) & maxmath.bitmask32((int)default(Int28).Bits), default(Int28).Bits));
                }
            }
        }

        [Test]
        public static void SubVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int28x2 l = Random();
                Int28x2 r = Random();
                Int28x2 sub = l - r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(sub[j], maxmath.signextend((l[j] - r[j]) & maxmath.bitmask32((int)default(Int28).Bits), default(Int28).Bits));
                }
            }
        }

        [Test]
        public static void SubVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int28x2 l = Random();
                int r = RandomInt();
                Int28x2 sub = l - r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(sub[j], maxmath.signextend((l[j] - r) & maxmath.bitmask32((int)default(Int28).Bits), default(Int28).Bits));
                }
            }
        }

        [Test]
        public static void SubScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int28x2 r = Random();
                Int28x2 sub = l - r;
                
                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(sub[j], maxmath.signextend((l - r[j]) & maxmath.bitmask32((int)default(Int28).Bits), default(Int28).Bits));
                }
            }
        }

        [Test]
        public static void MulVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int28x2 l = Random();
                Int28x2 r = Random();
                Int28x2 mul = l * r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(mul[j], maxmath.signextend((l[j] * r[j]) & maxmath.bitmask32((int)default(Int28).Bits), default(Int28).Bits));
                }
            }
        }

        [Test]
        public static void MulVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int28x2 l = Random();
                int r = RandomInt();
                Int28x2 mul = l * r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(mul[j], maxmath.signextend((l[j] * r) & maxmath.bitmask32((int)default(Int28).Bits), default(Int28).Bits));
                }
            }
        }

        [Test]
        public static void MulScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int28x2 r = Random();
                Int28x2 mul = l * r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(mul[j], maxmath.signextend((l * r[j]) & maxmath.bitmask32((int)default(Int28).Bits), default(Int28).Bits));
                }
            }
        }

        [Test]
        public static void DivVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int28x2 l = Random();
                Int28x2 r = Random();
                for (int j = 0; j < 2; j++)
                {
                    if (r[j] == 0)
                    {
                        r[j] = 1;
                    }
                }

                Int28x2 div = l / r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(div[j], maxmath.signextend((l[j] / r[j]) & maxmath.bitmask32((int)default(Int28).Bits), default(Int28).Bits));
                }
            }
        }

        [Test]
        public static void DivVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int28x2 l = Random();
                int r = RandomInt();
                if (r == 0)
                {
                    r = 1;
                }

                Int28x2 div = l / r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(div[j], maxmath.signextend((l[j] / r) & maxmath.bitmask32((int)default(Int28).Bits), default(Int28).Bits));
                }
            }
        }

        [Test]
        public static void DivScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int28x2 r = Random();
                for (int j = 0; j < 2; j++)
                {
                    if (r[j] == 0)
                    {
                        r[j] = 1;
                    }
                }

                Int28x2 div = l / r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(div[j], maxmath.signextend((l / r[j]) & maxmath.bitmask32((int)default(Int28).Bits), default(Int28).Bits));
                }
            }
        }

        [Test]
        public static void ModVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int28x2 l = Random();
                Int28x2 r = Random();
                for (int j = 0; j < 2; j++)
                {
                    if (r[j] == 0)
                    {
                        r[j] = 1;
                    }
                }

                Int28x2 mod = l % r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(mod[j], maxmath.signextend((l[j] % r[j]) & maxmath.bitmask32((int)default(Int28).Bits), default(Int28).Bits));
                }
            }
        }

        [Test]
        public static void ModVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int28x2 l = Random();
                int r = RandomInt();
                if (r == 0)
                {
                    r = 1;
                }

                Int28x2 mod = l % r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(mod[j], maxmath.signextend((l[j] % r) & maxmath.bitmask32((int)default(Int28).Bits), default(Int28).Bits));
                }
            }
        }

        [Test]
        public static void ModScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int28x2 r = Random();
                for (int j = 0; j < 2; j++)
                {
                    if (r[j] == 0)
                    {
                        r[j] = 1;
                    }
                }

                Int28x2 mod = l % r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(mod[j], maxmath.signextend((l % r[j]) & maxmath.bitmask32((int)default(Int28).Bits), default(Int28).Bits));
                }
            }
        }

        [Test]
        public static void AndVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int28x2 l = Random();
                Int28x2 r = Random();
                Int28x2 and = l & r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(and[j], maxmath.signextend((l[j] & r[j]) & maxmath.bitmask32((int)default(Int28).Bits), default(Int28).Bits));
                }
            }
        }

        [Test]
        public static void AndVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int28x2 l = Random();
                int r = RandomInt();
                Int28x2 and = l & r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(and[j], maxmath.signextend((l[j] & r) & maxmath.bitmask32((int)default(Int28).Bits), default(Int28).Bits));
                }
            }
        }

        [Test]
        public static void AndScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int28x2 r = Random();
                Int28x2 and = l & r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(and[j], maxmath.signextend((l & r[j]) & maxmath.bitmask32((int)default(Int28).Bits), default(Int28).Bits));
                }
            }
        }

        [Test]
        public static void OrVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int28x2 l = Random();
                Int28x2 r = Random();
                Int28x2 or = l | r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(or[j], maxmath.signextend((l[j] | r[j]) & maxmath.bitmask32((int)default(Int28).Bits), default(Int28).Bits));
                }
            }
        }

        [Test]
        public static void OrVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int28x2 l = Random();
                int r = RandomInt();
                Int28x2 or = l | r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(or[j], maxmath.signextend((l[j] | r) & maxmath.bitmask32((int)default(Int28).Bits), default(Int28).Bits));
                }
            }
        }

        [Test]
        public static void OrScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int28x2 r = Random();
                Int28x2 or = l | r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(or[j], maxmath.signextend((l | r[j]) & maxmath.bitmask32((int)default(Int28).Bits), default(Int28).Bits));
                }
            }
        }

        [Test]
        public static void XorVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int28x2 l = Random();
                Int28x2 r = Random();
                Int28x2 xor = l ^ r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(xor[j], maxmath.signextend((l[j] ^ r[j]) & maxmath.bitmask32((int)default(Int28).Bits), default(Int28).Bits));
                }
            }
        }

        [Test]
        public static void XorVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int28x2 l = Random();
                int r = RandomInt();
                Int28x2 xor = l ^ r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(xor[j], maxmath.signextend((l[j] ^ r) & maxmath.bitmask32((int)default(Int28).Bits), default(Int28).Bits));
                }
            }
        }

        [Test]
        public static void XorScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int28x2 r = Random();
                Int28x2 xor = l ^ r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(xor[j], maxmath.signextend((l ^ r[j]) & maxmath.bitmask32((int)default(Int28).Bits), default(Int28).Bits));
                }
            }
        }

        [Test]
        public static void EqualVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int28x2 l = Random();
                Int28x2 r = Random();
                Int28x2 equal = l == r;

                for (int j = 0; j < 2; j++)
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
                Int28x2 l = Random();
                int r = RandomInt();
                Int28x2 equal = l == r;

                for (int j = 0; j < 2; j++)
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
                Int28x2 r = Random();
                Int28x2 equal = l == r;

                for (int j = 0; j < 2; j++)
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
                Int28x2 l = Random();
                Int28x2 r = Random();
                Int28x2 notEqual = l != r;

                for (int j = 0; j < 2; j++)
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
                Int28x2 l = Random();
                int r = RandomInt();
                Int28x2 notEqual = l != r;

                for (int j = 0; j < 2; j++)
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
                Int28x2 r = Random();
                Int28x2 notEqual = l != r;

                for (int j = 0; j < 2; j++)
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
                Int28x2 l = Random();
                Int28x2 r = Random();
                Int28x2 less = l < r;

                for (int j = 0; j < 2; j++)
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
                Int28x2 l = Random();
                int r = RandomInt();
                Int28x2 less = l < r;

                for (int j = 0; j < 2; j++)
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
                Int28x2 r = Random();
                Int28x2 less = l < r;

                for (int j = 0; j < 2; j++)
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
                Int28x2 l = Random();
                Int28x2 r = Random();
                Int28x2 greater = l > r;
                
                for (int j = 0; j < 2; j++)
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
                Int28x2 l = Random();
                int r = RandomInt();
                Int28x2 greater = l > r;

                for (int j = 0; j < 2; j++)
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
                Int28x2 r = Random();
                Int28x2 greater = l > r;

                for (int j = 0; j < 2; j++)
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
                Int28x2 l = Random();
                Int28x2 r = Random();
                Int28x2 lessEqual = l <= r;
                
                for (int j = 0; j < 2; j++)
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
                Int28x2 l = Random();
                int r = RandomInt();
                Int28x2 lessEqual = l <= r;

                for (int j = 0; j < 2; j++)
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
                Int28x2 r = Random();
                Int28x2 lessEqual = l <= r;

                for (int j = 0; j < 2; j++)
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
                Int28x2 l = Random();
                Int28x2 r = Random();
                Int28x2 greaterEqual = l >= r;

                for (int j = 0; j < 2; j++)
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
                Int28x2 l = Random();
                int r = RandomInt();
                Int28x2 greaterEqual = l >= r;

                for (int j = 0; j < 2; j++)
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
                Int28x2 r = Random();
                Int28x2 greaterEqual = l >= r;

                for (int j = 0; j < 2; j++)
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
                Int28x2 x = Random();
                Int28x2 not = ~x;

                for (int j = 0; j < 2; j++)
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
                Int28x2 x = Random();
                int n = (int)RandomInt(0, default(Int28).Bits);
                Int28x2 shiftLeft = x << n;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(shiftLeft[j], maxmath.signextend((x[j] << n) & maxmath.bitmask32((int)default(Int28).Bits), default(Int28).Bits));
                }
            }
        }

        [Test]
        public static void ShiftRight()
        {
            for (int i = 0; i < 64; i++)
            {
                Int28x2 x = Random();
                int n = (int)RandomInt(0, default(Int28).Bits);
                Int28x2 shiftRight = x >> n;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(shiftRight[j], x[j] >> n);
                }
            }
        }
    }
}