using NUnit.Framework;
using MaxMath;
using Unity.Mathematics;

namespace BitCollections.Tests
{
    internal static class _Int14x4
    {
        internal static Int14x4 TestData_LHS => new Int14x4(Int14.MaxValue, -17, -47, 6000);
        internal static Int14x4 TestData_RHS => new Int14x4(Int14.MinValue, 8000, -999, 194);

        

        private static Int14x4 Random(short min = Int14.MinValue, short max = Int14.MaxValue + 1)
        {
            Random16 rng = Random16.New;

            Int14x4 test = new Int14x4();
            for (int i = 0; i < 4; i++)
            {
                test[i] = rng.NextShort(min, max);
            }

            return test;
        }

        private static int RandomInt(int min = Int14.MinValue, int max = Int14.MaxValue + 1)
        {
            Random32 rng = Random32.New;

            return rng.NextInt(min, max);
        }


        [Test]
        public static void Constructor_int()
        {
            bool result = true;

            Int14x4 test = new Int14x4(-1747);
            result &= test.x == -1747;
            result &= test.y == -1747;
            result &= test.z == -1747;
            result &= test.w == -1747;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_intx4()
        {
            bool result = true;

            Int14x4 test = new Int14x4(17, 47, 41, -3333);

            result &= test.x == 17;
            result &= test.y == 47;
            result &= test.z == 41;
            result &= test.w == -3333;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void GetSingle()
        {
            bool result = true;

            result &= TestData_LHS[0] == Int14.MaxValue;
            result &= TestData_LHS[1] == -17;
            result &= TestData_LHS[2] == -47;
            result &= TestData_LHS[3] == 6000;

            result &= TestData_RHS[0] == Int14.MinValue;
            result &= TestData_RHS[1] == 8000;
            result &= TestData_RHS[2] == -999;
            result &= TestData_RHS[3] == 194;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetSingle()
        {
            bool result = true;

            Random32 rng = new Random32(1937519u);

            for (int i = 0; i < 4; i++)
            {
                Int14x4 test = TestData_LHS;
                int randomInt = rng.NextInt(Int14.MinValue, Int14.MaxValue + 1);
                test[i] = randomInt;

                result &= test[0] == ((i == 0) ? randomInt : TestData_LHS.x);
                result &= test[1] == ((i == 1) ? randomInt : TestData_LHS.y);
                result &= test[2] == ((i == 2) ? randomInt : TestData_LHS.z);
                result &= test[3] == ((i == 3) ? randomInt : TestData_LHS.w);
            }

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void ToFromByte4()
        {
            Int14x4 test = Random(0, byte.MaxValue + 1);
            byte4 byte4test = (byte4)test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((byte)test[i], byte4test[i]);
            }

            test = (Int14x4)byte4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((byte)test[i], byte4test[i]);
            }
        }

        [Test]
        public static void ToFromSByte4()
        {
            Int14x4 test = Random(sbyte.MinValue, sbyte.MaxValue + 1);
            sbyte4 sbyte4test = (sbyte4)test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((sbyte)test[i], sbyte4test[i]);
            }

            test = (Int14x4)sbyte4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((sbyte)test[i], sbyte4test[i]);
            }
        }

        [Test]
        public static void ToFromUShort4()
        {
            Int14x4 test = Random(0);
            ushort4 ushort4test = (ushort4)test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((ushort)test[i], ushort4test[i]);
            }

            test = (Int14x4)ushort4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((ushort)test[i], ushort4test[i]);
            }
        }

        [Test]
        public static void ToFromShort4()
        {
            Int14x4 test = Random();
            short4 short4test = (short4)test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((short)test[i], short4test[i]);
            }

            test = (Int14x4)short4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((short)test[i], short4test[i]);
            }
        }

        [Test]
        public static void ToFromUInt4()
        {
            Int14x4 test = Random(0);
            uint4 uint4test = (uint4)test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((uint)test[i], uint4test[i]);
            }

            test = (Int14x4)uint4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((uint)test[i], uint4test[i]);
            }
        }

        [Test]
        public static void ToFromInt4()
        {
            Int14x4 test = Random();
            int4 int4test = test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual(test[i], int4test[i]);
            }

            test = (Int14x4)int4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual(test[i], int4test[i]);
            }
        }


        [Test]
        public static void ToFromULong4()
        {
            Int14x4 test = Random(0);
            ulong4 ulong4test = (ulong4)test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((ulong)test[i], ulong4test[i]);
            }

            test = (Int14x4)ulong4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((ulong)test[i], ulong4test[i]);
            }
        }

        [Test]
        public static void ToFromLong4()
        {
            Int14x4 test = Random();
            long4 long4test = test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual(test[i], long4test[i]);
            }

            test = (Int14x4)long4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual(test[i], long4test[i]);
            }
        }

        [Test]
        public static void ToFromQuarter4()
        {
            Int14x4 test = Random((short)quarter.MinValue, (short)((int)quarter.MaxValue + 1));
            quarter4 quarter4test = (quarter4)test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((quarter)test[i], quarter4test[i]);
            }

            test = (Int14x4)quarter4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((quarter)test[i], quarter4test[i]);
            }
        }

        [Test]
        public static void ToFromHalf4()
        {
            Int14x4 test = Random();
            half4 half4test = test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((half)test[i], half4test[i]);
            }

            test = (Int14x4)half4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((half)test[i], half4test[i]);
            }
        }

        [Test]
        public static void ToFromFloat4()
        {
            Int14x4 test = Random();
            float4 float4test = test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((float)test[i], float4test[i]);
            }

            test = (Int14x4)float4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((float)test[i], float4test[i]);
            }
        }

        [Test]
        public static void ToFromDouble4()
        {
            Int14x4 test = Random();
            double4 double4test = test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((double)test[i], double4test[i]);
            }

            test = (Int14x4)double4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((double)test[i], double4test[i]);
            }
        }

        [Test]
        public static void Negate()
        {
            for (int i = 0; i < 64; i++)
            {
                Int14x4 l = Random();
                Int14x4 neg = -l;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(neg[j], l[j] == Int14.MinValue ? Int14.MinValue : -l[j]);
                }
            }
        }

        [Test]
        public static void AddVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int14x4 l = Random();
                Int14x4 r = Random();
                Int14x4 add = l + r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(add[j], maxmath.signextend((l[j] + r[j]) & maxmath.bitmask32((int)default(Int14).Bits), default(Int14).Bits));
                }
            }
        }

        [Test]
        public static void AddVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int14x4 l = Random();
                int r = RandomInt();
                Int14x4 add = l + r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(add[j], maxmath.signextend((l[j] + r) & maxmath.bitmask32((int)default(Int14).Bits), default(Int14).Bits));
                }
            }
        }

        [Test]
        public static void AddScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int14x4 r = Random();
                Int14x4 add = l + r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(add[j], maxmath.signextend((l + r[j]) & maxmath.bitmask32((int)default(Int14).Bits), default(Int14).Bits));
                }
            }
        }

        [Test]
        public static void SubVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int14x4 l = Random();
                Int14x4 r = Random();
                Int14x4 sub = l - r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(sub[j], maxmath.signextend((l[j] - r[j]) & maxmath.bitmask32((int)default(Int14).Bits), default(Int14).Bits));
                }
            }
        }

        [Test]
        public static void SubVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int14x4 l = Random();
                int r = RandomInt();
                Int14x4 sub = l - r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(sub[j], maxmath.signextend((l[j] - r) & maxmath.bitmask32((int)default(Int14).Bits), default(Int14).Bits));
                }
            }
        }

        [Test]
        public static void SubScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int14x4 r = Random();
                Int14x4 sub = l - r;
                
                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(sub[j], maxmath.signextend((l - r[j]) & maxmath.bitmask32((int)default(Int14).Bits), default(Int14).Bits));
                }
            }
        }

        [Test]
        public static void MulVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int14x4 l = Random();
                Int14x4 r = Random();
                Int14x4 mul = l * r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(mul[j], maxmath.signextend((l[j] * r[j]) & maxmath.bitmask32((int)default(Int14).Bits), default(Int14).Bits));
                }
            }
        }

        [Test]
        public static void MulVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int14x4 l = Random();
                int r = RandomInt();
                Int14x4 mul = l * r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(mul[j], maxmath.signextend((l[j] * r) & maxmath.bitmask32((int)default(Int14).Bits), default(Int14).Bits));
                }
            }
        }

        [Test]
        public static void MulScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int14x4 r = Random();
                Int14x4 mul = l * r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(mul[j], maxmath.signextend((l * r[j]) & maxmath.bitmask32((int)default(Int14).Bits), default(Int14).Bits));
                }
            }
        }

        [Test]
        public static void DivVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int14x4 l = Random();
                Int14x4 r = Random();
                for (int j = 0; j < 4; j++)
                {
                    if (r[j] == 0)
                    {
                        r[j] = 1;
                    }
                }

                Int14x4 div = l / r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(div[j], maxmath.signextend((l[j] / r[j]) & maxmath.bitmask32((int)default(Int14).Bits), default(Int14).Bits));
                }
            }
        }

        [Test]
        public static void DivVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int14x4 l = Random();
                int r = RandomInt();
                if (r == 0)
                {
                    r = 1;
                }

                Int14x4 div = l / r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(div[j], maxmath.signextend((l[j] / r) & maxmath.bitmask32((int)default(Int14).Bits), default(Int14).Bits));
                }
            }
        }

        [Test]
        public static void DivScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int14x4 r = Random();
                for (int j = 0; j < 4; j++)
                {
                    if (r[j] == 0)
                    {
                        r[j] = 1;
                    }
                }

                Int14x4 div = l / r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(div[j], maxmath.signextend((l / r[j]) & maxmath.bitmask32((int)default(Int14).Bits), default(Int14).Bits));
                }
            }
        }

        [Test]
        public static void ModVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int14x4 l = Random();
                Int14x4 r = Random();
                for (int j = 0; j < 4; j++)
                {
                    if (r[j] == 0)
                    {
                        r[j] = 1;
                    }
                }

                Int14x4 mod = l % r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(mod[j], maxmath.signextend((l[j] % r[j]) & maxmath.bitmask32((int)default(Int14).Bits), default(Int14).Bits));
                }
            }
        }

        [Test]
        public static void ModVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int14x4 l = Random();
                int r = RandomInt();
                if (r == 0)
                {
                    r = 1;
                }

                Int14x4 mod = l % r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(mod[j], maxmath.signextend((l[j] % r) & maxmath.bitmask32((int)default(Int14).Bits), default(Int14).Bits));
                }
            }
        }

        [Test]
        public static void ModScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int14x4 r = Random();
                for (int j = 0; j < 4; j++)
                {
                    if (r[j] == 0)
                    {
                        r[j] = 1;
                    }
                }

                Int14x4 mod = l % r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(mod[j], maxmath.signextend((l % r[j]) & maxmath.bitmask32((int)default(Int14).Bits), default(Int14).Bits));
                }
            }
        }

        [Test]
        public static void AndVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int14x4 l = Random();
                Int14x4 r = Random();
                Int14x4 and = l & r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(and[j], maxmath.signextend((l[j] & r[j]) & maxmath.bitmask32((int)default(Int14).Bits), default(Int14).Bits));
                }
            }
        }

        [Test]
        public static void AndVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int14x4 l = Random();
                int r = RandomInt();
                Int14x4 and = l & r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(and[j], maxmath.signextend((l[j] & r) & maxmath.bitmask32((int)default(Int14).Bits), default(Int14).Bits));
                }
            }
        }

        [Test]
        public static void AndScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int14x4 r = Random();
                Int14x4 and = l & r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(and[j], maxmath.signextend((l & r[j]) & maxmath.bitmask32((int)default(Int14).Bits), default(Int14).Bits));
                }
            }
        }

        [Test]
        public static void OrVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int14x4 l = Random();
                Int14x4 r = Random();
                Int14x4 or = l | r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(or[j], maxmath.signextend((l[j] | r[j]) & maxmath.bitmask32((int)default(Int14).Bits), default(Int14).Bits));
                }
            }
        }

        [Test]
        public static void OrVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int14x4 l = Random();
                int r = RandomInt();
                Int14x4 or = l | r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(or[j], maxmath.signextend((l[j] | r) & maxmath.bitmask32((int)default(Int14).Bits), default(Int14).Bits));
                }
            }
        }

        [Test]
        public static void OrScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int14x4 r = Random();
                Int14x4 or = l | r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(or[j], maxmath.signextend((l | r[j]) & maxmath.bitmask32((int)default(Int14).Bits), default(Int14).Bits));
                }
            }
        }

        [Test]
        public static void XorVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int14x4 l = Random();
                Int14x4 r = Random();
                Int14x4 xor = l ^ r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(xor[j], maxmath.signextend((l[j] ^ r[j]) & maxmath.bitmask32((int)default(Int14).Bits), default(Int14).Bits));
                }
            }
        }

        [Test]
        public static void XorVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int14x4 l = Random();
                int r = RandomInt();
                Int14x4 xor = l ^ r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(xor[j], maxmath.signextend((l[j] ^ r) & maxmath.bitmask32((int)default(Int14).Bits), default(Int14).Bits));
                }
            }
        }

        [Test]
        public static void XorScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int14x4 r = Random();
                Int14x4 xor = l ^ r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(xor[j], maxmath.signextend((l ^ r[j]) & maxmath.bitmask32((int)default(Int14).Bits), default(Int14).Bits));
                }
            }
        }

        [Test]
        public static void EqualVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int14x4 l = Random();
                Int14x4 r = Random();
                Int14x4 equal = l == r;

                for (int j = 0; j < 4; j++)
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
                Int14x4 l = Random();
                int r = RandomInt();
                Int14x4 equal = l == r;

                for (int j = 0; j < 4; j++)
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
                Int14x4 r = Random();
                Int14x4 equal = l == r;

                for (int j = 0; j < 4; j++)
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
                Int14x4 l = Random();
                Int14x4 r = Random();
                Int14x4 notEqual = l != r;

                for (int j = 0; j < 4; j++)
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
                Int14x4 l = Random();
                int r = RandomInt();
                Int14x4 notEqual = l != r;

                for (int j = 0; j < 4; j++)
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
                Int14x4 r = Random();
                Int14x4 notEqual = l != r;

                for (int j = 0; j < 4; j++)
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
                Int14x4 l = Random();
                Int14x4 r = Random();
                Int14x4 less = l < r;

                for (int j = 0; j < 4; j++)
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
                Int14x4 l = Random();
                int r = RandomInt();
                Int14x4 less = l < r;

                for (int j = 0; j < 4; j++)
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
                Int14x4 r = Random();
                Int14x4 less = l < r;

                for (int j = 0; j < 4; j++)
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
                Int14x4 l = Random();
                Int14x4 r = Random();
                Int14x4 greater = l > r;
                
                for (int j = 0; j < 4; j++)
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
                Int14x4 l = Random();
                int r = RandomInt();
                Int14x4 greater = l > r;

                for (int j = 0; j < 4; j++)
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
                Int14x4 r = Random();
                Int14x4 greater = l > r;

                for (int j = 0; j < 4; j++)
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
                Int14x4 l = Random();
                Int14x4 r = Random();
                Int14x4 lessEqual = l <= r;
                
                for (int j = 0; j < 4; j++)
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
                Int14x4 l = Random();
                int r = RandomInt();
                Int14x4 lessEqual = l <= r;

                for (int j = 0; j < 4; j++)
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
                Int14x4 r = Random();
                Int14x4 lessEqual = l <= r;

                for (int j = 0; j < 4; j++)
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
                Int14x4 l = Random();
                Int14x4 r = Random();
                Int14x4 greaterEqual = l >= r;

                for (int j = 0; j < 4; j++)
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
                Int14x4 l = Random();
                int r = RandomInt();
                Int14x4 greaterEqual = l >= r;

                for (int j = 0; j < 4; j++)
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
                Int14x4 r = Random();
                Int14x4 greaterEqual = l >= r;

                for (int j = 0; j < 4; j++)
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
                Int14x4 x = Random();
                Int14x4 not = ~x;

                for (int j = 0; j < 4; j++)
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
                Int14x4 x = Random();
                int n = (int)RandomInt(0, default(Int14).Bits);
                Int14x4 shiftLeft = x << n;
                
                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(shiftLeft[j], maxmath.signextend((x[j] << n) & maxmath.bitmask32((int)default(Int14).Bits), default(Int14).Bits));
                }
            }
        }

        [Test]
        public static void ShiftRight()
        {
            for (int i = 0; i < 64; i++)
            {
                Int14x4 x = Random();
                int n = (int)RandomInt(0, default(Int14).Bits);
                Int14x4 shiftRight = x >> n;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(shiftRight[j], x[j] >> n);
                }
            }
        }
    }
}