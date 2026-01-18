using NUnit.Framework;
using MaxMath;
using Unity.Mathematics;

namespace BitCollections.Tests
{
    internal static class _UInt5x8
    {
        internal static UInt5x8 TestData_LHS => new UInt5x8(UInt5.MaxValue, 30, 2, 21, 0, 25, 23, 22);
        internal static UInt5x8 TestData_RHS => new UInt5x8(UInt5.MinValue, 21, 29, 13, 27, 1, 30, 12);

        private static UInt5x8 Random(byte min = 0, byte max = 0)
        {
            Random8 rng = Random8.New;

            UInt5x8 test = new UInt5x8();
            for (int i = 0; i < 8; i++)
            {
                test[i] = rng.NextByte(min != 0 ? min : UInt5.MinValue, max != 0 ? max : (byte)(UInt5.MaxValue + 1));
            }

            return test;
        }
        
        private static uint RandomUInt(ushort min = 0, ushort max = 0)
        {
            Random32 rng = Random32.New;

            return rng.NextUInt(min != 0 ? min : UInt5.MinValue, max != 0 ? max : (uint)(UInt5.MaxValue + 1));
        }


        [Test]
        public static void Constructor_uint()
        {
            bool result = true;

            UInt5x8 test = new UInt5x8(17);
            result &= test.x0 == 17;
            result &= test.x1 == 17;
            result &= test.x2 == 17;
            result &= test.x3 == 17;
            result &= test.x4 == 17;
            result &= test.x5 == 17;
            result &= test.x6 == 17;
            result &= test.x7 == 17;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_uintx8()
        {
            bool result = true;

            UInt5x8 test = new UInt5x8(1, 30, 12, 30, 17, 27, 11, 29);

            result &= test.x0 == 1;
            result &= test.x1 == 30;
            result &= test.x2 == 12;
            result &= test.x3 == 30;
            result &= test.x4 == 17;
            result &= test.x5 == 27;
            result &= test.x6 == 11;
            result &= test.x7 == 29;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void GetSingle()
        {
            bool result = true;

            result &= TestData_LHS[0] == UInt5.MaxValue;
            result &= TestData_LHS[1] == 30;
            result &= TestData_LHS[2] == 2;
            result &= TestData_LHS[3] == 21;
            result &= TestData_LHS[4] == 0;
            result &= TestData_LHS[5] == 25;
            result &= TestData_LHS[6] == 23;
            result &= TestData_LHS[7] == 22;

            result &= TestData_RHS[0] == UInt5.MinValue;
            result &= TestData_RHS[1] == 21;
            result &= TestData_RHS[2] == 29;
            result &= TestData_RHS[3] == 13;
            result &= TestData_RHS[4] == 27;
            result &= TestData_RHS[5] == 1;
            result &= TestData_RHS[6] == 30;
            result &= TestData_RHS[7] == 12;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetSingle()
        {
            bool result = true;

            Random32 rng = new Random32(1937519u);

            for (int i = 0; i < 8; i++)
            {
                UInt5x8 test = TestData_LHS;
                uint randomInt = rng.NextUInt(0, UInt5.MaxValue + 1);
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
        public static void ToFromUInt6x8()
        {
            UInt5x8 test = Random();
            UInt6x8 byte8test = (UInt6x8)test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual(test[i], byte8test[i]);
            }

            test = (UInt5x8)byte8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual(test[i], byte8test[i]);
            }
        }

        [Test]
        public static void ToFromUInt7x8()
        {
            UInt5x8 test = Random();
            UInt7x8 byte8test = (UInt7x8)test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual(test[i], byte8test[i]);
            }

            test = (UInt5x8)byte8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual(test[i], byte8test[i]);
            }
        }


        [Test]
        public static void ToFromByte8()
        {
            UInt5x8 test = Random();
            byte8 byte8test = test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)byte8test[i]);
            }

            test = (UInt5x8)byte8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)byte8test[i]);
            }
        }

        [Test]
        public static void ToFromSByte8()
        {
            UInt5x8 test = Random();
            sbyte8 sbyte8test = test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)sbyte8test[i]);
            }

            test = (UInt5x8)sbyte8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)sbyte8test[i]);
            }
        }

        [Test]
        public static void ToFromUShort8()
        {
            UInt5x8 test = Random();
            ushort8 ushort8test = test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)ushort8test[i]);
            }

            test = (UInt5x8)ushort8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)ushort8test[i]);
            }
        }

        [Test]
        public static void ToFromShort8()
        {
            UInt5x8 test = Random();
            short8 short8test = test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)short8test[i]);
            }

            test = (UInt5x8)short8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)short8test[i]);
            }
        }

        [Test]
        public static void ToFromUInt8()
        {
            UInt5x8 test = Random();
            uint8 uint8test = test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)uint8test[i]);
            }

            test = (UInt5x8)uint8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)uint8test[i]);
            }
        }

        [Test]
        public static void ToFromInt8()
        {
            UInt5x8 test = Random();
            int8 int8test = test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)int8test[i]);
            }

            test = (UInt5x8)int8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)int8test[i]);
            }
        }

        [Test]
        public static void ToFromQuarter8()
        {
            UInt5x8 test = Random(0, (byte)(quarter.MaxValue + 1));
            quarter8 quarter8test = (quarter8)test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((quarter)test[i], quarter8test[i]);
            }

            test = (UInt5x8)quarter8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((quarter)test[i], quarter8test[i]);
            }
        }

        [Test]
        public static void ToFromHalf8()
        {
            UInt5x8 test = Random();
            half8 half8test = test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((half)test[i], half8test[i]);
            }

            test = (UInt5x8)half8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((half)test[i], half8test[i]);
            }
        }

        [Test]
        public static void ToFromFloat8()
        {
            UInt5x8 test = Random();
            float8 float8test = test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((float)test[i], float8test[i]);
            }

            test = (UInt5x8)float8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((float)test[i], float8test[i]);
            }
        }

        [Test]
        public static void AddVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt5x8 l = Random();
                UInt5x8 r = Random();
                UInt5x8 add = l + r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(add[j], (l[j] + r[j]) & maxmath.bitmask32((uint)default(UInt5).Bits));
                }
            }
        }

        [Test]
        public static void AddVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt5x8 l = Random();
                uint r = RandomUInt();
                UInt5x8 add = l + r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(add[j], (l[j] + r) & maxmath.bitmask32((uint)default(UInt5).Bits));
                }
            }
        }

        [Test]
        public static void AddScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt5x8 r = Random();
                UInt5x8 add = l + r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(add[j], (l + r[j]) & maxmath.bitmask32((uint)default(UInt5).Bits));
                }
            }
        }

        [Test]
        public static void SubVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt5x8 l = Random();
                UInt5x8 r = Random();
                UInt5x8 sub = l - r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(sub[j], (l[j] - r[j]) & maxmath.bitmask32((uint)default(UInt5).Bits));
                }
            }
        }

        [Test]
        public static void SubVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt5x8 l = Random();
                uint r = RandomUInt();
                UInt5x8 sub = l - r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(sub[j], (l[j] - r) & maxmath.bitmask32((uint)default(UInt5).Bits));
                }
            }
        }

        [Test]
        public static void SubScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt5x8 r = Random();
                UInt5x8 sub = l - r;
                
                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(sub[j], (l - r[j]) & maxmath.bitmask32((uint)default(UInt5).Bits));
                }
            }
        }

        [Test]
        public static void MulVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt5x8 l = Random();
                UInt5x8 r = Random();
                UInt5x8 mul = l * r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(mul[j], (l[j] * r[j]) & maxmath.bitmask32((uint)default(UInt5).Bits));
                }
            }
        }

        [Test]
        public static void MulVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt5x8 l = Random();
                uint r = RandomUInt();
                UInt5x8 mul = l * r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(mul[j], (l[j] * r) & maxmath.bitmask32((uint)default(UInt5).Bits));
                }
            }
        }

        [Test]
        public static void MulScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt5x8 r = Random();
                UInt5x8 mul = l * r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(mul[j], (l * r[j]) & maxmath.bitmask32((uint)default(UInt5).Bits));
                }
            }
        }

        [Test]
        public static void DivVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt5x8 l = Random();
                UInt5x8 r = Random(min: 1);
                UInt5x8 div = l / r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(div[j], (l[j] / r[j]) & maxmath.bitmask32((uint)default(UInt5).Bits));
                }
            }
        }

        [Test]
        public static void DivVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt5x8 l = Random();
                uint r = RandomUInt(min: 1);
                UInt5x8 div = l / r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(div[j], (l[j] / r) & maxmath.bitmask32((uint)default(UInt5).Bits));
                }
            }
        }

        [Test]
        public static void DivScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt5x8 r = Random(min: 1);
                UInt5x8 div = l / r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(div[j], (l / r[j]) & maxmath.bitmask32((uint)default(UInt5).Bits));
                }
            }
        }

        [Test]
        public static void ModVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt5x8 l = Random();
                UInt5x8 r = Random(min: 1);
                UInt5x8 mod = l % r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(mod[j], (l[j] % r[j]) & maxmath.bitmask32((uint)default(UInt5).Bits));
                }
            }
        }

        [Test]
        public static void ModVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt5x8 l = Random();
                uint r = RandomUInt(min: 1);
                UInt5x8 mod = l % r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(mod[j], (l[j] % r) & maxmath.bitmask32((uint)default(UInt5).Bits));
                }
            }
        }

        [Test]
        public static void ModScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt5x8 r = Random(min: 1);
                UInt5x8 mod = l % r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(mod[j], (l % r[j]) & maxmath.bitmask32((uint)default(UInt5).Bits));
                }
            }
        }

        [Test]
        public static void AndVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt5x8 l = Random();
                UInt5x8 r = Random();
                UInt5x8 and = l & r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(and[j], (l[j] & r[j]) & maxmath.bitmask32((uint)default(UInt5).Bits));
                }
            }
        }

        [Test]
        public static void AndVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt5x8 l = Random();
                uint r = RandomUInt();
                UInt5x8 and = l & r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(and[j], (l[j] & r) & maxmath.bitmask32((uint)default(UInt5).Bits));
                }
            }
        }

        [Test]
        public static void AndScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt5x8 r = Random();
                UInt5x8 and = l & r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(and[j], (l & r[j]) & maxmath.bitmask32((uint)default(UInt5).Bits));
                }
            }
        }

        [Test]
        public static void OrVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt5x8 l = Random();
                UInt5x8 r = Random();
                UInt5x8 or = l | r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(or[j], (l[j] | r[j]) & maxmath.bitmask32((uint)default(UInt5).Bits));
                }
            }
        }

        [Test]
        public static void OrVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt5x8 l = Random();
                uint r = RandomUInt();
                UInt5x8 or = l | r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(or[j], (l[j] | r) & maxmath.bitmask32((uint)default(UInt5).Bits));
                }
            }
        }

        [Test]
        public static void OrScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt5x8 r = Random();
                UInt5x8 or = l | r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(or[j], (l | r[j]) & maxmath.bitmask32((uint)default(UInt5).Bits));
                }
            }
        }

        [Test]
        public static void XorVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt5x8 l = Random();
                UInt5x8 r = Random();
                UInt5x8 xor = l ^ r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(xor[j], (l[j] ^ r[j]) & maxmath.bitmask32((uint)default(UInt5).Bits));
                }
            }
        }

        [Test]
        public static void XorVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt5x8 l = Random();
                uint r = RandomUInt();
                UInt5x8 xor = l ^ r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(xor[j], (l[j] ^ r) & maxmath.bitmask32((uint)default(UInt5).Bits));
                }
            }
        }

        [Test]
        public static void XorScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt5x8 r = Random();
                UInt5x8 xor = l ^ r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(xor[j], (l ^ r[j]) & maxmath.bitmask32((uint)default(UInt5).Bits));
                }
            }
        }

        [Test]
        public static void EqualVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt5x8 l = Random();
                UInt5x8 r = Random();
                UInt5x8 equal = l == r;

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
                UInt5x8 l = Random();
                uint r = RandomUInt();
                UInt5x8 equal = l == r;

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
                uint l = RandomUInt();
                UInt5x8 r = Random();
                UInt5x8 equal = l == r;

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
                UInt5x8 l = Random();
                UInt5x8 r = Random();
                UInt5x8 notEqual = l != r;

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
                UInt5x8 l = Random();
                uint r = RandomUInt();
                UInt5x8 notEqual = l != r;

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
                uint l = RandomUInt();
                UInt5x8 r = Random();
                UInt5x8 notEqual = l != r;

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
                UInt5x8 l = Random();
                UInt5x8 r = Random();
                UInt5x8 less = l < r;

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
                UInt5x8 l = Random();
                uint r = RandomUInt();
                UInt5x8 less = l < r;

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
                uint l = RandomUInt();
                UInt5x8 r = Random();
                UInt5x8 less = l < r;

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
                UInt5x8 l = Random();
                UInt5x8 r = Random();
                UInt5x8 greater = l > r;
                
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
                UInt5x8 l = Random();
                uint r = RandomUInt();
                UInt5x8 greater = l > r;

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
                uint l = RandomUInt();
                UInt5x8 r = Random();
                UInt5x8 greater = l > r;

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
                UInt5x8 l = Random();
                UInt5x8 r = Random();
                UInt5x8 lessEqual = l <= r;
                
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
                UInt5x8 l = Random();
                uint r = RandomUInt();
                UInt5x8 lessEqual = l <= r;

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
                uint l = RandomUInt();
                UInt5x8 r = Random();
                UInt5x8 lessEqual = l <= r;

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
                UInt5x8 l = Random();
                UInt5x8 r = Random();
                UInt5x8 greaterEqual = l >= r;

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
                UInt5x8 l = Random();
                uint r = RandomUInt();
                UInt5x8 greaterEqual = l >= r;

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
                uint l = RandomUInt();
                UInt5x8 r = Random();
                UInt5x8 greaterEqual = l >= r;

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
                UInt5x8 x = Random();
                UInt5x8 not = ~x;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(not[j], (~x[j]) & maxmath.bitmask32((uint)default(UInt5).Bits));
                }
            }
        }

        [Test]
        public static void ShiftLeft()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt5x8 x = Random();
                int n = (int)RandomUInt(0, default(UInt5).Bits);
                UInt5x8 shiftLeft = x << n;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(shiftLeft[j], (x[j] << n) & maxmath.bitmask32((uint)default(UInt5).Bits));
                }
            }
        }

        [Test]
        public static void ShiftRight()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt5x8 x = Random();
                int n = (int)RandomUInt(0, default(UInt5).Bits);
                UInt5x8 shiftRight = x >> n;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(shiftRight[j], (x[j] >> n) & maxmath.bitmask32((uint)default(UInt5).Bits));
                }
            }
        }
    }
}