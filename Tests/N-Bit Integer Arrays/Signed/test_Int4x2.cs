using NUnit.Framework;
using Unity.Mathematics;
using MaxMath;

namespace BitCollections.Tests
{
    internal static class _Int4x2
    {
        internal static Int4x2 TestData_LHS => new Int4x2(Int4.MaxValue, -1);
        internal static Int4x2 TestData_RHS => new Int4x2(Int4.MinValue, 4);

        private static Int4x2 Random(sbyte min = Int4.MinValue, sbyte max = Int4.MaxValue + 1)
        {
            Random8 rng = Random8.New;

            Int4x2 test = new Int4x2();
            for (int i = 0; i < 2; i++)
            {
                test[i] = rng.NextSByte(min, max);
            }

            return test;
        }
        
        private static int RandomInt(int min = Int4.MinValue, int max = Int4.MaxValue + 1)
        {
            Random32 rng = Random32.New;

            return rng.NextInt(min, max);
        }

        [Test]
        public static void Constructor_int()
        {
            bool result = true;

            Int4x2 test = new Int4x2(-4);
            result &= test.x == -4;
            result &= test.y == -4;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_intx2()
        {
            bool result = true;

            Int4x2 test = new Int4x2(4, -2);

            result &= test.x == 4;
            result &= test.y == -2;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void GetSingle()
        {
            bool result = true;

            result &= TestData_LHS[0] == Int4.MaxValue;
            result &= TestData_LHS[1] == -1;

            result &= TestData_RHS[0] == Int4.MinValue;
            result &= TestData_RHS[1] == 4;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetSingle()
        {
            bool result = true;

            Random32 rng = new Random32(1937519u);

            for (int i = 0; i < 2; i++)
            {
                Int4x2 test = TestData_LHS;
                int randomInt = rng.NextInt(Int4.MinValue, Int4.MaxValue + 1);
                test[i] = randomInt;

                result &= test[0] == ((i == 0) ? randomInt : TestData_LHS.x);
                result &= test[1] == ((i == 1) ? randomInt : TestData_LHS.y);
            }

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void ToFromInt12x2()
        {
            Int4x2 test = Random();
            Int12x2 byte2test = (Int12x2)test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(test[i], byte2test[i]);
            }

            test = (Int4x2)byte2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(test[i], byte2test[i]);
            }
        }

        [Test]
        public static void ToFromUInt12x2()
        {
            Int4x2 test = Random(0);
            UInt12x2 byte2test = (UInt12x2)test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(((UInt12x2)((Int12x2)test))[i], byte2test[i]);
            }

            test = (Int4x2)byte2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(((UInt12x2)((Int12x2)test))[i], byte2test[i]);
            }
        }

        [Test]
        public static void ToFromInt20x2()
        {
            Int4x2 test = Random();
            Int20x2 byte2test = (Int20x2)test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(test[i], byte2test[i]);
            }

            test = (Int4x2)byte2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(test[i], byte2test[i]);
            }
        }

        [Test]
        public static void ToFromUInt20x2()
        {
            Int4x2 test = Random(0);
            UInt20x2 byte2test = (UInt20x2)test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(((UInt20x2)((Int20x2)test))[i], byte2test[i]);
            }

            test = (Int4x2)byte2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(((UInt20x2)((Int20x2)test))[i], byte2test[i]);
            }
        }

        [Test]
        public static void ToFromInt28x2()
        {
            Int4x2 test = Random();
            Int28x2 byte2test = (Int28x2)test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(test[i], byte2test[i]);
            }

            test = (Int4x2)byte2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(test[i], byte2test[i]);
            }
        }

        [Test]
        public static void ToFromUInt28x2()
        {
            Int4x2 test = Random(0);
            UInt28x2 byte2test = (UInt28x2)test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(((UInt28x2)((Int28x2)test))[i], byte2test[i]);
            }

            test = (Int4x2)byte2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(((UInt28x2)((Int28x2)test))[i], byte2test[i]);
            }
        }

        [Test]
        public static void ToFromByte2()
        {
            Int4x2 test = Random(0);
            byte2 byte2test = (byte2)test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((byte)test[i], byte2test[i]);
            }

            test = (Int4x2)byte2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((byte)test[i], byte2test[i]);
            }
        }

        [Test]
        public static void ToFromSByte2()
        {
            Int4x2 test = Random();
            sbyte2 sbyte2test = test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)sbyte2test[i]);
            }

            test = (Int4x2)sbyte2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)sbyte2test[i]);
            }
        }

        [Test]
        public static void ToFromUShort2()
        {
            Int4x2 test = Random(0);
            ushort2 ushort2test = (ushort2)test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((ushort)test[i], ushort2test[i]);
            }

            test = (Int4x2)ushort2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((ushort)test[i], ushort2test[i]);
            }
        }

        [Test]
        public static void ToFromShort2()
        {
            Int4x2 test = Random();
            short2 short2test = test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)short2test[i]);
            }

            test = (Int4x2)short2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)short2test[i]);
            }
        }

        [Test]
        public static void ToFromUInt2()
        {
            Int4x2 test = Random(0);
            uint2 uint2test = (uint2)test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((uint)test[i], uint2test[i]);
            }

            test = (Int4x2)uint2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((uint)test[i], uint2test[i]);
            }
        }

        [Test]
        public static void ToFromInt2()
        {
            Int4x2 test = Random();
            int2 int2test = test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)int2test[i]);
            }

            test = (Int4x2)int2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)int2test[i]);
            }
        }

        [Test]
        public static void ToFromULong2()
        {
            Int4x2 test = Random(0);
            ulong2 ulong2test = (ulong2)test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((ulong)test[i], ulong2test[i]);
            }

            test = (Int4x2)ulong2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((ulong)test[i], ulong2test[i]);
            }
        }

        [Test]
        public static void ToFromLong2()
        {
            Int4x2 test = Random();
            long2 long2test = test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((ulong)test[i], (ulong)long2test[i]);
            }

            test = (Int4x2)long2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((ulong)test[i], (ulong)long2test[i]);
            }
        }

        [Test]
        public static void ToFromQuarter2()
        {
            Int4x2 test = Random();
            quarter2 quarter2test = (quarter2)test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((quarter)test[i], quarter2test[i]);
            }

            test = (Int4x2)quarter2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((quarter)test[i], quarter2test[i]);
            }
        }

        [Test]
        public static void ToFromHalf2()
        {
            Int4x2 test = Random();
            half2 half2test = test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((half)test[i], half2test[i]);
            }

            test = (Int4x2)half2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((half)test[i], half2test[i]);
            }
        }

        [Test]
        public static void ToFromFloat2()
        {
            Int4x2 test = Random();
            float2 float2test = test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((float)test[i], float2test[i]);
            }

            test = (Int4x2)float2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((float)test[i], float2test[i]);
            }
        }

        [Test]
        public static void ToFromDouble2()
        {
            Int4x2 test = Random();
            double2 double2test = test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((double)test[i], double2test[i]);
            }

            test = (Int4x2)double2test;

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
                Int4x2 l = Random();
                Int4x2 neg = -l;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(neg[j], l[j] == Int4.MinValue ? Int4.MinValue : -l[j]);
                }
            }
        }

        [Test]
        public static void AddVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int4x2 l = Random();
                Int4x2 r = Random();
                Int4x2 add = l + r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(add[j], maxmath.signextend((l[j] + r[j]) & maxmath.bitmask32((int)default(Int4).Bits), default(Int4).Bits));
                }
            }
        }

        [Test]
        public static void AddVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int4x2 l = Random();
                int r = RandomInt();
                Int4x2 add = l + r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(add[j], maxmath.signextend((l[j] + r) & maxmath.bitmask32((int)default(Int4).Bits), default(Int4).Bits));
                }
            }
        }

        [Test]
        public static void AddScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int4x2 r = Random();
                Int4x2 add = l + r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(add[j], maxmath.signextend((l + r[j]) & maxmath.bitmask32((int)default(Int4).Bits), default(Int4).Bits));
                }
            }
        }

        [Test]
        public static void SubVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int4x2 l = Random();
                Int4x2 r = Random();
                Int4x2 sub = l - r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(sub[j], maxmath.signextend((l[j] - r[j]) & maxmath.bitmask32((int)default(Int4).Bits), default(Int4).Bits));
                }
            }
        }

        [Test]
        public static void SubVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int4x2 l = Random();
                int r = RandomInt();
                Int4x2 sub = l - r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(sub[j], maxmath.signextend((l[j] - r) & maxmath.bitmask32((int)default(Int4).Bits), default(Int4).Bits));
                }
            }
        }

        [Test]
        public static void SubScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int4x2 r = Random();
                Int4x2 sub = l - r;
                
                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(sub[j], maxmath.signextend((l - r[j]) & maxmath.bitmask32((int)default(Int4).Bits), default(Int4).Bits));
                }
            }
        }

        [Test]
        public static void MulVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int4x2 l = Random();
                Int4x2 r = Random();
                Int4x2 mul = l * r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(mul[j], maxmath.signextend((l[j] * r[j]) & maxmath.bitmask32((int)default(Int4).Bits), default(Int4).Bits));
                }
            }
        }

        [Test]
        public static void MulVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int4x2 l = Random();
                int r = RandomInt();
                Int4x2 mul = l * r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(mul[j], maxmath.signextend((l[j] * r) & maxmath.bitmask32((int)default(Int4).Bits), default(Int4).Bits));
                }
            }
        }

        [Test]
        public static void MulScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int4x2 r = Random();
                Int4x2 mul = l * r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(mul[j], maxmath.signextend((l * r[j]) & maxmath.bitmask32((int)default(Int4).Bits), default(Int4).Bits));
                }
            }
        }

        [Test]
        public static void DivVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int4x2 l = Random();
                Int4x2 r = Random();
                for (int j = 0; j < 2; j++)
                {
                    if (r[j] == 0)
                    {
                        r[j] = 1;
                    }
                }

                Int4x2 div = l / r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(div[j], maxmath.signextend((l[j] / r[j]) & maxmath.bitmask32((int)default(Int4).Bits), default(Int4).Bits));
                }
            }
        }

        [Test]
        public static void DivVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int4x2 l = Random();
                int r = RandomInt();
                if (r == 0)
                {
                    r = 1;
                }

                Int4x2 div = l / r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(div[j], maxmath.signextend((l[j] / r) & maxmath.bitmask32((int)default(Int4).Bits), default(Int4).Bits));
                }
            }
        }

        [Test]
        public static void DivScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int4x2 r = Random();
                for (int j = 0; j < 2; j++)
                {
                    if (r[j] == 0)
                    {
                        r[j] = 1;
                    }
                }

                Int4x2 div = l / r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(div[j], maxmath.signextend((l / r[j]) & maxmath.bitmask32((int)default(Int4).Bits), default(Int4).Bits));
                }
            }
        }

        [Test]
        public static void ModVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int4x2 l = Random();
                Int4x2 r = Random();
                for (int j = 0; j < 2; j++)
                {
                    if (r[j] == 0)
                    {
                        r[j] = 1;
                    }
                }

                Int4x2 mod = l % r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(mod[j], maxmath.signextend((l[j] % r[j]) & maxmath.bitmask32((int)default(Int4).Bits), default(Int4).Bits));
                }
            }
        }

        [Test]
        public static void ModVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int4x2 l = Random();
                int r = RandomInt();
                if (r == 0)
                {
                    r = 1;
                }

                Int4x2 mod = l % r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(mod[j], maxmath.signextend((l[j] % r) & maxmath.bitmask32((int)default(Int4).Bits), default(Int4).Bits));
                }
            }
        }

        [Test]
        public static void ModScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int4x2 r = Random();
                for (int j = 0; j < 2; j++)
                {
                    if (r[j] == 0)
                    {
                        r[j] = 1;
                    }
                }

                Int4x2 mod = l % r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(mod[j], maxmath.signextend((l % r[j]) & maxmath.bitmask32((int)default(Int4).Bits), default(Int4).Bits));
                }
            }
        }

        [Test]
        public static void AndVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int4x2 l = Random();
                Int4x2 r = Random();
                Int4x2 and = l & r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(and[j], maxmath.signextend((l[j] & r[j]) & maxmath.bitmask32((int)default(Int4).Bits), default(Int4).Bits));
                }
            }
        }

        [Test]
        public static void AndVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int4x2 l = Random();
                int r = RandomInt();
                Int4x2 and = l & r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(and[j], maxmath.signextend((l[j] & r) & maxmath.bitmask32((int)default(Int4).Bits), default(Int4).Bits));
                }
            }
        }

        [Test]
        public static void AndScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int4x2 r = Random();
                Int4x2 and = l & r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(and[j], maxmath.signextend((l & r[j]) & maxmath.bitmask32((int)default(Int4).Bits), default(Int4).Bits));
                }
            }
        }

        [Test]
        public static void OrVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int4x2 l = Random();
                Int4x2 r = Random();
                Int4x2 or = l | r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(or[j], maxmath.signextend((l[j] | r[j]) & maxmath.bitmask32((int)default(Int4).Bits), default(Int4).Bits));
                }
            }
        }

        [Test]
        public static void OrVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int4x2 l = Random();
                int r = RandomInt();
                Int4x2 or = l | r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(or[j], maxmath.signextend((l[j] | r) & maxmath.bitmask32((int)default(Int4).Bits), default(Int4).Bits));
                }
            }
        }

        [Test]
        public static void OrScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int4x2 r = Random();
                Int4x2 or = l | r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(or[j], maxmath.signextend((l | r[j]) & maxmath.bitmask32((int)default(Int4).Bits), default(Int4).Bits));
                }
            }
        }

        [Test]
        public static void XorVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int4x2 l = Random();
                Int4x2 r = Random();
                Int4x2 xor = l ^ r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(xor[j], maxmath.signextend((l[j] ^ r[j]) & maxmath.bitmask32((int)default(Int4).Bits), default(Int4).Bits));
                }
            }
        }

        [Test]
        public static void XorVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int4x2 l = Random();
                int r = RandomInt();
                Int4x2 xor = l ^ r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(xor[j], maxmath.signextend((l[j] ^ r) & maxmath.bitmask32((int)default(Int4).Bits), default(Int4).Bits));
                }
            }
        }

        [Test]
        public static void XorScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int4x2 r = Random();
                Int4x2 xor = l ^ r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(xor[j], maxmath.signextend((l ^ r[j]) & maxmath.bitmask32((int)default(Int4).Bits), default(Int4).Bits));
                }
            }
        }

        [Test]
        public static void EqualVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int4x2 l = Random();
                Int4x2 r = Random();
                Int4x2 equal = l == r;

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
                Int4x2 l = Random();
                int r = RandomInt();
                Int4x2 equal = l == r;

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
                Int4x2 r = Random();
                Int4x2 equal = l == r;

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
                Int4x2 l = Random();
                Int4x2 r = Random();
                Int4x2 notEqual = l != r;

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
                Int4x2 l = Random();
                int r = RandomInt();
                Int4x2 notEqual = l != r;

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
                Int4x2 r = Random();
                Int4x2 notEqual = l != r;

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
                Int4x2 l = Random();
                Int4x2 r = Random();
                Int4x2 less = l < r;

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
                Int4x2 l = Random();
                int r = RandomInt();
                Int4x2 less = l < r;

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
                Int4x2 r = Random();
                Int4x2 less = l < r;

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
                Int4x2 l = Random();
                Int4x2 r = Random();
                Int4x2 greater = l > r;
                
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
                Int4x2 l = Random();
                int r = RandomInt();
                Int4x2 greater = l > r;

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
                Int4x2 r = Random();
                Int4x2 greater = l > r;

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
                Int4x2 l = Random();
                Int4x2 r = Random();
                Int4x2 lessEqual = l <= r;
                
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
                Int4x2 l = Random();
                int r = RandomInt();
                Int4x2 lessEqual = l <= r;

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
                Int4x2 r = Random();
                Int4x2 lessEqual = l <= r;

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
                Int4x2 l = Random();
                Int4x2 r = Random();
                Int4x2 greaterEqual = l >= r;

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
                Int4x2 l = Random();
                int r = RandomInt();
                Int4x2 greaterEqual = l >= r;

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
                Int4x2 r = Random();
                Int4x2 greaterEqual = l >= r;

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
                Int4x2 x = Random();
                Int4x2 not = ~x;

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
                Int4x2 x = Random();
                int n = (int)RandomInt(0, default(Int4).Bits);
                Int4x2 shiftLeft = x << n;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(shiftLeft[j], maxmath.signextend((x[j] << n) & maxmath.bitmask32((int)default(Int4).Bits), default(Int4).Bits));
                }
            }
        }

        [Test]
        public static void ShiftRight()
        {
            for (int i = 0; i < 64; i++)
            {
                Int4x2 x = Random();
                int n = (int)RandomInt(0, default(Int4).Bits);
                Int4x2 shiftRight = x >> n;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(shiftRight[j], x[j] >> n);
                }
            }
        }
    }
}