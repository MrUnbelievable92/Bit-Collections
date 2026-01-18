using NUnit.Framework;
using MaxMath;
using Unity.Mathematics;

namespace BitCollections.Tests
{
    internal static class _Int3x8
    {
        internal static Int3x8 TestData_LHS => new Int3x8(Int3.MaxValue, 1, -4, -3, 0, 1, -1, 2);
        internal static Int3x8 TestData_RHS => new Int3x8(Int3.MinValue, -4, 3, -2, 2, 0, -1, -3);

        private static Int3x8 Random(sbyte min = Int3.MinValue, sbyte max = Int3.MaxValue + 1)
        {
            Random8 rng = Random8.New;

            Int3x8 test = new Int3x8();
            for (int i = 0; i < 8; i++)
            {
                test[i] = rng.NextSByte(min, max);
            }

            return test;
        }
        
        private static int RandomInt(int min = Int3.MinValue, int max = Int3.MaxValue + 1)
        {
            Random32 rng = Random32.New;

            return rng.NextInt(min, max);
        }

        [Test]
        public static void Constructor_int()
        {
            bool result = true;

            Int3x8 test = new Int3x8(-2);
            result &= test.x0 == -2;
            result &= test.x1 == -2;
            result &= test.x2 == -2;
            result &= test.x3 == -2;
            result &= test.x4 == -2;
            result &= test.x5 == -2;
            result &= test.x6 == -2;
            result &= test.x7 == -2;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_intx8()
        {
            bool result = true;

            Int3x8 test = new Int3x8(-4, -3, 0, 2, 1, -1, 0, 2);

            result &= test.x0 == -4;
            result &= test.x1 == -3;
            result &= test.x2 == 0;
            result &= test.x3 == 2;
            result &= test.x4 == 1;
            result &= test.x5 == -1;
            result &= test.x6 == 0;
            result &= test.x7 == 2;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void GetSingle()
        {
            bool result = true;

            result &= TestData_LHS[0] == Int3.MaxValue;
            result &= TestData_LHS[1] == 1;
            result &= TestData_LHS[2] == -4;
            result &= TestData_LHS[3] == -3;
            result &= TestData_LHS[4] == 0;
            result &= TestData_LHS[5] == 1;
            result &= TestData_LHS[6] == -1;
            result &= TestData_LHS[7] == 2;

            result &= TestData_RHS[0] == Int3.MinValue;
            result &= TestData_RHS[1] == -4;
            result &= TestData_RHS[2] == 3;
            result &= TestData_RHS[3] == -2;
            result &= TestData_RHS[4] == 2;
            result &= TestData_RHS[5] == 0;
            result &= TestData_RHS[6] == -1;
            result &= TestData_RHS[7] == -3;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetSingle()
        {
            bool result = true;

            Random32 rng = new Random32(1937519u);

            for (int i = 0; i < 8; i++)
            {
                Int3x8 test = TestData_LHS;
                int randomInt = rng.NextInt(Int3.MinValue, Int3.MaxValue + 1);
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
        public static void ToFromInt4x8()
        {
            Int3x8 test = Random();
            Int4x8 byte8test = (Int4x8)test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual(test[i], byte8test[i]);
            }

            test = (Int3x8)byte8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual(test[i], byte8test[i]);
            }
        }

        [Test]
        public static void ToFromUInt4x8()
        {
            Int3x8 test = Random(0);
            UInt4x8 byte8test = (UInt4x8)test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual(((UInt4x8)((Int4x8)test))[i], byte8test[i]);
            }

            test = (Int3x8)byte8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual(((UInt4x8)((Int4x8)test))[i], byte8test[i]);
            }
        }

        [Test]
        public static void ToFromInt5x8()
        {
            Int3x8 test = Random();
            Int5x8 byte8test = (Int5x8)test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual(test[i], byte8test[i]);
            }

            test = (Int3x8)byte8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual(test[i], byte8test[i]);
            }
        }

        [Test]
        public static void ToFromUInt5x8()
        {
            Int3x8 test = Random(0);
            UInt5x8 byte8test = (UInt5x8)test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual(((UInt5x8)((Int5x8)test))[i], byte8test[i]);
            }

            test = (Int3x8)byte8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual(((UInt5x8)((Int5x8)test))[i], byte8test[i]);
            }
        }

        [Test]
        public static void ToFromInt6x8()
        {
            Int3x8 test = Random();
            Int6x8 byte8test = (Int6x8)test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual(test[i], byte8test[i]);
            }

            test = (Int3x8)byte8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual(test[i], byte8test[i]);
            }
        }

        [Test]
        public static void ToFromUInt6x8()
        {
            Int3x8 test = Random(0);
            UInt6x8 byte8test = (UInt6x8)test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual(((UInt6x8)((Int6x8)test))[i], byte8test[i]);
            }

            test = (Int3x8)byte8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual(((UInt6x8)((Int6x8)test))[i], byte8test[i]);
            }
        }

        [Test]
        public static void ToFromInt7x8()
        {
            Int3x8 test = Random();
            Int7x8 byte8test = (Int7x8)test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual(test[i], byte8test[i]);
            }

            test = (Int3x8)byte8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual(test[i], byte8test[i]);
            }
        }

        [Test]
        public static void ToFromUInt7x8()
        {
            Int3x8 test = Random(0);
            UInt7x8 byte8test = (UInt7x8)test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual(((UInt7x8)((Int7x8)test))[i], byte8test[i]);
            }

            test = (Int3x8)byte8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual(((UInt7x8)((Int7x8)test))[i], byte8test[i]);
            }
        }

        [Test]
        public static void ToFromByte8()
        {
            Int3x8 test = Random(0);
            byte8 byte8test = (byte8)test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((byte)test[i], byte8test[i]);
            }

            test = (Int3x8)byte8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((byte)test[i], byte8test[i]);
            }
        }

        [Test]
        public static void ToFromSByte8()
        {
            Int3x8 test = Random();
            sbyte8 sbyte8test = test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)sbyte8test[i]);
            }

            test = (Int3x8)sbyte8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)sbyte8test[i]);
            }
        }

        [Test]
        public static void ToFromUShort8()
        {
            Int3x8 test = Random(0);
            ushort8 ushort8test = (ushort8)test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual(((ushort8)((short8)test))[i], ushort8test[i]);
            }

            test = (Int3x8)ushort8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual(((ushort8)((short8)test))[i], ushort8test[i]);
            }
        }

        [Test]
        public static void ToFromShort8()
        {
            Int3x8 test = Random();
            short8 short8test = test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)short8test[i]);
            }

            test = (Int3x8)short8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)short8test[i]);
            }
        }

        [Test]
        public static void ToFromUInt8()
        {
            Int3x8 test = Random(0);
            uint8 uint8test = (uint8)test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual(((uint8)((int8)test))[i], uint8test[i]);
            }

            test = (Int3x8)uint8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual(((uint8)((int8)test))[i], uint8test[i]);
            }
        }

        [Test]
        public static void ToFromInt8()
        {
            Int3x8 test = Random();
            int8 int8test = test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)int8test[i]);
            }

            test = (Int3x8)int8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)int8test[i]);
            }
        }

        [Test]
        public static void ToFromQuarter8()
        {
            Int3x8 test = Random();
            quarter8 quarter8test = (quarter8)test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((quarter)test[i], quarter8test[i]);
            }

            test = (Int3x8)quarter8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((quarter)test[i], quarter8test[i]);
            }
        }

        [Test]
        public static void ToFromHalf8()
        {
            Int3x8 test = Random();
            half8 half8test = test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((half)test[i], half8test[i]);
            }

            test = (Int3x8)half8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((half)test[i], half8test[i]);
            }
        }

        [Test]
        public static void ToFromFloat8()
        {
            Int3x8 test = Random();
            float8 float8test = test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((float)test[i], float8test[i]);
            }

            test = (Int3x8)float8test;

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
                Int3x8 l = Random();
                Int3x8 neg = -l;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(neg[j], l[j] == Int3.MinValue ? Int3.MinValue : -l[j]);
                }
            }
        }

        [Test]
        public static void AddVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int3x8 l = Random();
                Int3x8 r = Random();
                Int3x8 add = l + r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(add[j], maxmath.signextend((l[j] + r[j]) & maxmath.bitmask32((int)default(Int3).Bits), default(Int3).Bits));
                }
            }
        }

        [Test]
        public static void AddVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int3x8 l = Random();
                int r = RandomInt();
                Int3x8 add = l + r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(add[j], maxmath.signextend((l[j] + r) & maxmath.bitmask32((int)default(Int3).Bits), default(Int3).Bits));
                }
            }
        }

        [Test]
        public static void AddScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int3x8 r = Random();
                Int3x8 add = l + r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(add[j], maxmath.signextend((l + r[j]) & maxmath.bitmask32((int)default(Int3).Bits), default(Int3).Bits));
                }
            }
        }

        [Test]
        public static void SubVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int3x8 l = Random();
                Int3x8 r = Random();
                Int3x8 sub = l - r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(sub[j], maxmath.signextend((l[j] - r[j]) & maxmath.bitmask32((int)default(Int3).Bits), default(Int3).Bits));
                }
            }
        }

        [Test]
        public static void SubVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int3x8 l = Random();
                int r = RandomInt();
                Int3x8 sub = l - r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(sub[j], maxmath.signextend((l[j] - r) & maxmath.bitmask32((int)default(Int3).Bits), default(Int3).Bits));
                }
            }
        }

        [Test]
        public static void SubScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int3x8 r = Random();
                Int3x8 sub = l - r;
                
                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(sub[j], maxmath.signextend((l - r[j]) & maxmath.bitmask32((int)default(Int3).Bits), default(Int3).Bits));
                }
            }
        }

        [Test]
        public static void MulVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int3x8 l = Random();
                Int3x8 r = Random();
                Int3x8 mul = l * r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(mul[j], maxmath.signextend((l[j] * r[j]) & maxmath.bitmask32((int)default(Int3).Bits), default(Int3).Bits));
                }
            }
        }

        [Test]
        public static void MulVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int3x8 l = Random();
                int r = RandomInt();
                Int3x8 mul = l * r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(mul[j], maxmath.signextend((l[j] * r) & maxmath.bitmask32((int)default(Int3).Bits), default(Int3).Bits));
                }
            }
        }

        [Test]
        public static void MulScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int3x8 r = Random();
                Int3x8 mul = l * r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(mul[j], maxmath.signextend((l * r[j]) & maxmath.bitmask32((int)default(Int3).Bits), default(Int3).Bits));
                }
            }
        }

        [Test]
        public static void DivVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int3x8 l = Random();
                Int3x8 r = Random();
                for (int j = 0; j < 8; j++)
                {
                    if (r[j] == 0)
                    {
                        r[j] = 1;
                    }
                }

                Int3x8 div = l / r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(div[j], maxmath.signextend((l[j] / r[j]) & maxmath.bitmask32((int)default(Int3).Bits), default(Int3).Bits));
                }
            }
        }

        [Test]
        public static void DivVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int3x8 l = Random();
                int r = RandomInt();
                if (r == 0)
                {
                    r = 1;
                }

                Int3x8 div = l / r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(div[j], maxmath.signextend((l[j] / r) & maxmath.bitmask32((int)default(Int3).Bits), default(Int3).Bits));
                }
            }
        }

        [Test]
        public static void DivScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int3x8 r = Random();
                for (int j = 0; j < 8; j++)
                {
                    if (r[j] == 0)
                    {
                        r[j] = 1;
                    }
                }

                Int3x8 div = l / r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(div[j], maxmath.signextend((l / r[j]) & maxmath.bitmask32((int)default(Int3).Bits), default(Int3).Bits));
                }
            }
        }

        [Test]
        public static void ModVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int3x8 l = Random();
                Int3x8 r = Random();
                for (int j = 0; j < 8; j++)
                {
                    if (r[j] == 0)
                    {
                        r[j] = 1;
                    }
                }

                Int3x8 mod = l % r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(mod[j], maxmath.signextend((l[j] % r[j]) & maxmath.bitmask32((int)default(Int3).Bits), default(Int3).Bits));
                }
            }
        }

        [Test]
        public static void ModVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int3x8 l = Random();
                int r = RandomInt();
                if (r == 0)
                {
                    r = 1;
                }

                Int3x8 mod = l % r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(mod[j], maxmath.signextend((l[j] % r) & maxmath.bitmask32((int)default(Int3).Bits), default(Int3).Bits));
                }
            }
        }

        [Test]
        public static void ModScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int3x8 r = Random();
                for (int j = 0; j < 8; j++)
                {
                    if (r[j] == 0)
                    {
                        r[j] = 1;
                    }
                }

                Int3x8 mod = l % r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(mod[j], maxmath.signextend((l % r[j]) & maxmath.bitmask32((int)default(Int3).Bits), default(Int3).Bits));
                }
            }
        }

        [Test]
        public static void AndVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int3x8 l = Random();
                Int3x8 r = Random();
                Int3x8 and = l & r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(and[j], maxmath.signextend((l[j] & r[j]) & maxmath.bitmask32((int)default(Int3).Bits), default(Int3).Bits));
                }
            }
        }

        [Test]
        public static void AndVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int3x8 l = Random();
                int r = RandomInt();
                Int3x8 and = l & r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(and[j], maxmath.signextend((l[j] & r) & maxmath.bitmask32((int)default(Int3).Bits), default(Int3).Bits));
                }
            }
        }

        [Test]
        public static void AndScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int3x8 r = Random();
                Int3x8 and = l & r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(and[j], maxmath.signextend((l & r[j]) & maxmath.bitmask32((int)default(Int3).Bits), default(Int3).Bits));
                }
            }
        }

        [Test]
        public static void OrVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int3x8 l = Random();
                Int3x8 r = Random();
                Int3x8 or = l | r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(or[j], maxmath.signextend((l[j] | r[j]) & maxmath.bitmask32((int)default(Int3).Bits), default(Int3).Bits));
                }
            }
        }

        [Test]
        public static void OrVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int3x8 l = Random();
                int r = RandomInt();
                Int3x8 or = l | r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(or[j], maxmath.signextend((l[j] | r) & maxmath.bitmask32((int)default(Int3).Bits), default(Int3).Bits));
                }
            }
        }

        [Test]
        public static void OrScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int3x8 r = Random();
                Int3x8 or = l | r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(or[j], maxmath.signextend((l | r[j]) & maxmath.bitmask32((int)default(Int3).Bits), default(Int3).Bits));
                }
            }
        }

        [Test]
        public static void XorVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int3x8 l = Random();
                Int3x8 r = Random();
                Int3x8 xor = l ^ r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(xor[j], maxmath.signextend((l[j] ^ r[j]) & maxmath.bitmask32((int)default(Int3).Bits), default(Int3).Bits));
                }
            }
        }

        [Test]
        public static void XorVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                Int3x8 l = Random();
                int r = RandomInt();
                Int3x8 xor = l ^ r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(xor[j], maxmath.signextend((l[j] ^ r) & maxmath.bitmask32((int)default(Int3).Bits), default(Int3).Bits));
                }
            }
        }

        [Test]
        public static void XorScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                int l = RandomInt();
                Int3x8 r = Random();
                Int3x8 xor = l ^ r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(xor[j], maxmath.signextend((l ^ r[j]) & maxmath.bitmask32((int)default(Int3).Bits), default(Int3).Bits));
                }
            }
        }

        [Test]
        public static void EqualVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                Int3x8 l = Random();
                Int3x8 r = Random();
                Int3x8 equal = l == r;

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
                Int3x8 l = Random();
                int r = RandomInt();
                Int3x8 equal = l == r;

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
                Int3x8 r = Random();
                Int3x8 equal = l == r;

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
                Int3x8 l = Random();
                Int3x8 r = Random();
                Int3x8 notEqual = l != r;

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
                Int3x8 l = Random();
                int r = RandomInt();
                Int3x8 notEqual = l != r;

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
                Int3x8 r = Random();
                Int3x8 notEqual = l != r;

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
                Int3x8 l = Random();
                Int3x8 r = Random();
                Int3x8 less = l < r;

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
                Int3x8 l = Random();
                int r = RandomInt();
                Int3x8 less = l < r;

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
                Int3x8 r = Random();
                Int3x8 less = l < r;

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
                Int3x8 l = Random();
                Int3x8 r = Random();
                Int3x8 greater = l > r;
                
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
                Int3x8 l = Random();
                int r = RandomInt();
                Int3x8 greater = l > r;

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
                Int3x8 r = Random();
                Int3x8 greater = l > r;

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
                Int3x8 l = Random();
                Int3x8 r = Random();
                Int3x8 lessEqual = l <= r;
                
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
                Int3x8 l = Random();
                int r = RandomInt();
                Int3x8 lessEqual = l <= r;

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
                Int3x8 r = Random();
                Int3x8 lessEqual = l <= r;

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
                Int3x8 l = Random();
                Int3x8 r = Random();
                Int3x8 greaterEqual = l >= r;

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
                Int3x8 l = Random();
                int r = RandomInt();
                Int3x8 greaterEqual = l >= r;

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
                Int3x8 r = Random();
                Int3x8 greaterEqual = l >= r;

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
                Int3x8 x = Random();
                Int3x8 not = ~x;

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
                Int3x8 x = Random();
                int n = (int)RandomInt(0, default(Int3).Bits);
                Int3x8 shiftLeft = x << n;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(shiftLeft[j], maxmath.signextend((x[j] << n) & maxmath.bitmask32((int)default(Int3).Bits), default(Int3).Bits));
                }
            }
        }

        [Test]
        public static void ShiftRight()
        {
            for (int i = 0; i < 64; i++)
            {
                Int3x8 x = Random();
                int n = (int)RandomInt(0, default(Int3).Bits);
                Int3x8 shiftRight = x >> n;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(shiftRight[j], x[j] >> n);
                }
            }
        }
    }
}