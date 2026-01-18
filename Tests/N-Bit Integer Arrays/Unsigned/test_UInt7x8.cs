using NUnit.Framework;
using MaxMath;
using Unity.Mathematics;

namespace BitCollections.Tests
{
    internal static class _UInt7x8
    {
        internal static UInt7x8 TestData_LHS => new UInt7x8(UInt7.MaxValue, 111, 2, 21, 99, 55, 123, 50);
        internal static UInt7x8 TestData_RHS => new UInt7x8(UInt7.MinValue, 121, 43, 123, 0, 1, 89, 62);

        private static UInt7x8 Random(byte min = 0, byte max = 0)
        {
            Random8 rng = Random8.New;

            UInt7x8 test = new UInt7x8();
            for (int i = 0; i < 8; i++)
            {
                test[i] = rng.NextByte(min != 0 ? min : UInt7.MinValue, max != 0 ? max : (byte)(UInt7.MaxValue + 1));
            }

            return test;
        }
        
        private static uint RandomUInt(ushort min = 0, ushort max = 0)
        {
            Random32 rng = Random32.New;

            return rng.NextUInt(min != 0 ? min : UInt7.MinValue, max != 0 ? max : (uint)(UInt7.MaxValue + 1));
        }

        [Test]
        public static void Constructor_uint()
        {
            bool result = true;

            UInt7x8 test = new UInt7x8(47);
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
        public static void Constructor_uintx8()
        {
            bool result = true;

            UInt7x8 test = new UInt7x8(1, 30, 120, 12, 117, 47, 0, 113);

            result &= test.x0 == 1;
            result &= test.x1 == 30;
            result &= test.x2 == 120;
            result &= test.x3 == 12;
            result &= test.x4 == 117;
            result &= test.x5 == 47;
            result &= test.x6 == 0;
            result &= test.x7 == 113;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void GetSingle()
        {
            bool result = true;

            result &= TestData_LHS[0] == UInt7.MaxValue;
            result &= TestData_LHS[1] == 111;
            result &= TestData_LHS[2] == 2;
            result &= TestData_LHS[3] == 21;
            result &= TestData_LHS[4] == 99;
            result &= TestData_LHS[5] == 55;
            result &= TestData_LHS[6] == 123;
            result &= TestData_LHS[7] == 50;

            result &= TestData_RHS[0] == UInt7.MinValue;
            result &= TestData_RHS[1] == 121;
            result &= TestData_RHS[2] == 43;
            result &= TestData_RHS[3] == 123;
            result &= TestData_RHS[4] == 0;
            result &= TestData_RHS[5] == 1;
            result &= TestData_RHS[6] == 89;
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
                UInt7x8 test = TestData_LHS;
                uint randomInt = rng.NextUInt(0, UInt7.MaxValue + 1);
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
            UInt7x8 test = Random();
            byte8 byte8test = test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)byte8test[i]);
            }

            test = (UInt7x8)byte8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)byte8test[i]);
            }
        }

        [Test]
        public static void ToFromSByte8()
        {
            UInt7x8 test = Random();
            sbyte8 sbyte8test = test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)sbyte8test[i]);
            }

            test = (UInt7x8)sbyte8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)sbyte8test[i]);
            }
        }

        [Test]
        public static void ToFromUShort8()
        {
            UInt7x8 test = Random();
            ushort8 ushort8test = test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)ushort8test[i]);
            }

            test = (UInt7x8)ushort8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)ushort8test[i]);
            }
        }

        [Test]
        public static void ToFromShort8()
        {
            UInt7x8 test = Random();
            short8 short8test = test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)short8test[i]);
            }

            test = (UInt7x8)short8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)short8test[i]);
            }
        }

        [Test]
        public static void ToFromUInt8()
        {
            UInt7x8 test = Random();
            uint8 uint8test = test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)uint8test[i]);
            }

            test = (UInt7x8)uint8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)uint8test[i]);
            }
        }

        [Test]
        public static void ToFromInt8()
        {
            UInt7x8 test = Random();
            int8 int8test = test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)int8test[i]);
            }

            test = (UInt7x8)int8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)int8test[i]);
            }
        }

        [Test]
        public static void ToFromQuarter8()
        {
            UInt7x8 test = Random(0, (byte)(quarter.MaxValue + 1));
            quarter8 quarter8test = (quarter8)test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((quarter)test[i], quarter8test[i]);
            }

            test = (UInt7x8)quarter8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((quarter)test[i], quarter8test[i]);
            }
        }

        [Test]
        public static void ToFromHalf8()
        {
            UInt7x8 test = Random();
            half8 half8test = test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((half)test[i], half8test[i]);
            }

            test = (UInt7x8)half8test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((half)test[i], half8test[i]);
            }
        }

        [Test]
        public static void ToFromFloat8()
        {
            UInt7x8 test = Random();
            float8 float8test = test;

            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual((float)test[i], float8test[i]);
            }

            test = (UInt7x8)float8test;

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
                UInt7x8 l = Random();
                UInt7x8 r = Random();
                UInt7x8 add = l + r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(add[j], (l[j] + r[j]) & maxmath.bitmask32((uint)default(UInt7).Bits));
                }
            }
        }

        [Test]
        public static void AddVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt7x8 l = Random();
                uint r = RandomUInt();
                UInt7x8 add = l + r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(add[j], (l[j] + r) & maxmath.bitmask32((uint)default(UInt7).Bits));
                }
            }
        }

        [Test]
        public static void AddScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt7x8 r = Random();
                UInt7x8 add = l + r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(add[j], (l + r[j]) & maxmath.bitmask32((uint)default(UInt7).Bits));
                }
            }
        }

        [Test]
        public static void SubVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt7x8 l = Random();
                UInt7x8 r = Random();
                UInt7x8 sub = l - r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(sub[j], (l[j] - r[j]) & maxmath.bitmask32((uint)default(UInt7).Bits));
                }
            }
        }

        [Test]
        public static void SubVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt7x8 l = Random();
                uint r = RandomUInt();
                UInt7x8 sub = l - r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(sub[j], (l[j] - r) & maxmath.bitmask32((uint)default(UInt7).Bits));
                }
            }
        }

        [Test]
        public static void SubScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt7x8 r = Random();
                UInt7x8 sub = l - r;
                
                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(sub[j], (l - r[j]) & maxmath.bitmask32((uint)default(UInt7).Bits));
                }
            }
        }

        [Test]
        public static void MulVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt7x8 l = Random();
                UInt7x8 r = Random();
                UInt7x8 mul = l * r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(mul[j], (l[j] * r[j]) & maxmath.bitmask32((uint)default(UInt7).Bits));
                }
            }
        }

        [Test]
        public static void MulVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt7x8 l = Random();
                uint r = RandomUInt();
                UInt7x8 mul = l * r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(mul[j], (l[j] * r) & maxmath.bitmask32((uint)default(UInt7).Bits));
                }
            }
        }

        [Test]
        public static void MulScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt7x8 r = Random();
                UInt7x8 mul = l * r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(mul[j], (l * r[j]) & maxmath.bitmask32((uint)default(UInt7).Bits));
                }
            }
        }

        [Test]
        public static void DivVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt7x8 l = Random();
                UInt7x8 r = Random(min: 1);
                UInt7x8 div = l / r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(div[j], (l[j] / r[j]) & maxmath.bitmask32((uint)default(UInt7).Bits));
                }
            }
        }

        [Test]
        public static void DivVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt7x8 l = Random();
                uint r = RandomUInt(min: 1);
                UInt7x8 div = l / r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(div[j], (l[j] / r) & maxmath.bitmask32((uint)default(UInt7).Bits));
                }
            }
        }

        [Test]
        public static void DivScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt7x8 r = Random(min: 1);
                UInt7x8 div = l / r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(div[j], (l / r[j]) & maxmath.bitmask32((uint)default(UInt7).Bits));
                }
            }
        }

        [Test]
        public static void ModVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt7x8 l = Random();
                UInt7x8 r = Random(min: 1);
                UInt7x8 mod = l % r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(mod[j], (l[j] % r[j]) & maxmath.bitmask32((uint)default(UInt7).Bits));
                }
            }
        }

        [Test]
        public static void ModVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt7x8 l = Random();
                uint r = RandomUInt(min: 1);
                UInt7x8 mod = l % r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(mod[j], (l[j] % r) & maxmath.bitmask32((uint)default(UInt7).Bits));
                }
            }
        }

        [Test]
        public static void ModScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt7x8 r = Random(min: 1);
                UInt7x8 mod = l % r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(mod[j], (l % r[j]) & maxmath.bitmask32((uint)default(UInt7).Bits));
                }
            }
        }

        [Test]
        public static void AndVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt7x8 l = Random();
                UInt7x8 r = Random();
                UInt7x8 and = l & r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(and[j], (l[j] & r[j]) & maxmath.bitmask32((uint)default(UInt7).Bits));
                }
            }
        }

        [Test]
        public static void AndVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt7x8 l = Random();
                uint r = RandomUInt();
                UInt7x8 and = l & r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(and[j], (l[j] & r) & maxmath.bitmask32((uint)default(UInt7).Bits));
                }
            }
        }

        [Test]
        public static void AndScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt7x8 r = Random();
                UInt7x8 and = l & r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(and[j], (l & r[j]) & maxmath.bitmask32((uint)default(UInt7).Bits));
                }
            }
        }

        [Test]
        public static void OrVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt7x8 l = Random();
                UInt7x8 r = Random();
                UInt7x8 or = l | r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(or[j], (l[j] | r[j]) & maxmath.bitmask32((uint)default(UInt7).Bits));
                }
            }
        }

        [Test]
        public static void OrVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt7x8 l = Random();
                uint r = RandomUInt();
                UInt7x8 or = l | r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(or[j], (l[j] | r) & maxmath.bitmask32((uint)default(UInt7).Bits));
                }
            }
        }

        [Test]
        public static void OrScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt7x8 r = Random();
                UInt7x8 or = l | r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(or[j], (l | r[j]) & maxmath.bitmask32((uint)default(UInt7).Bits));
                }
            }
        }

        [Test]
        public static void XorVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt7x8 l = Random();
                UInt7x8 r = Random();
                UInt7x8 xor = l ^ r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(xor[j], (l[j] ^ r[j]) & maxmath.bitmask32((uint)default(UInt7).Bits));
                }
            }
        }

        [Test]
        public static void XorVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt7x8 l = Random();
                uint r = RandomUInt();
                UInt7x8 xor = l ^ r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(xor[j], (l[j] ^ r) & maxmath.bitmask32((uint)default(UInt7).Bits));
                }
            }
        }

        [Test]
        public static void XorScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt7x8 r = Random();
                UInt7x8 xor = l ^ r;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(xor[j], (l ^ r[j]) & maxmath.bitmask32((uint)default(UInt7).Bits));
                }
            }
        }

        [Test]
        public static void EqualVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt7x8 l = Random();
                UInt7x8 r = Random();
                UInt7x8 equal = l == r;

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
                UInt7x8 l = Random();
                uint r = RandomUInt();
                UInt7x8 equal = l == r;

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
                UInt7x8 r = Random();
                UInt7x8 equal = l == r;

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
                UInt7x8 l = Random();
                UInt7x8 r = Random();
                UInt7x8 notEqual = l != r;

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
                UInt7x8 l = Random();
                uint r = RandomUInt();
                UInt7x8 notEqual = l != r;

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
                UInt7x8 r = Random();
                UInt7x8 notEqual = l != r;

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
                UInt7x8 l = Random();
                UInt7x8 r = Random();
                UInt7x8 less = l < r;

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
                UInt7x8 l = Random();
                uint r = RandomUInt();
                UInt7x8 less = l < r;

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
                UInt7x8 r = Random();
                UInt7x8 less = l < r;

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
                UInt7x8 l = Random();
                UInt7x8 r = Random();
                UInt7x8 greater = l > r;
                
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
                UInt7x8 l = Random();
                uint r = RandomUInt();
                UInt7x8 greater = l > r;

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
                UInt7x8 r = Random();
                UInt7x8 greater = l > r;

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
                UInt7x8 l = Random();
                UInt7x8 r = Random();
                UInt7x8 lessEqual = l <= r;
                
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
                UInt7x8 l = Random();
                uint r = RandomUInt();
                UInt7x8 lessEqual = l <= r;

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
                UInt7x8 r = Random();
                UInt7x8 lessEqual = l <= r;

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
                UInt7x8 l = Random();
                UInt7x8 r = Random();
                UInt7x8 greaterEqual = l >= r;

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
                UInt7x8 l = Random();
                uint r = RandomUInt();
                UInt7x8 greaterEqual = l >= r;

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
                UInt7x8 r = Random();
                UInt7x8 greaterEqual = l >= r;

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
                UInt7x8 x = Random();
                UInt7x8 not = ~x;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(not[j], (~x[j]) & maxmath.bitmask32((uint)default(UInt7).Bits));
                }
            }
        }

        [Test]
        public static void ShiftLeft()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt7x8 x = Random();
                int n = (int)RandomUInt(0, default(UInt7).Bits);
                UInt7x8 shiftLeft = x << n;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(shiftLeft[j], (x[j] << n) & maxmath.bitmask32((uint)default(UInt7).Bits));
                }
            }
        }

        [Test]
        public static void ShiftRight()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt7x8 x = Random();
                int n = (int)RandomUInt(0, default(UInt7).Bits);
                UInt7x8 shiftRight = x >> n;

                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(shiftRight[j], (x[j] >> n) & maxmath.bitmask32((uint)default(UInt7).Bits));
                }
            }
        }
    }
}