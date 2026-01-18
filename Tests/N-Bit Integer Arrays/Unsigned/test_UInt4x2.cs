using NUnit.Framework;
using Unity.Mathematics;
using MaxMath;

namespace BitCollections.Tests
{
    internal static class _UInt4x2
    {
        internal static UInt4x2 TestData_LHS => new UInt4x2(UInt4.MaxValue, 11);
        internal static UInt4x2 TestData_RHS => new UInt4x2(UInt4.MinValue, 9);


        private static UInt4x2 Random(byte min = 0, byte max = 0)
        {
            Random8 rng = Random8.New;

            UInt4x2 test = new UInt4x2();
            for (int i = 0; i < 2; i++)
            {
                test[i] = rng.NextByte(min != 0 ? min : UInt4.MinValue, max != 0 ? max : (byte)(UInt4.MaxValue + 1));
            }

            return test;
        }

        private static uint RandomUInt(ushort min = 0, ushort max = 0)
        {
            Random32 rng = Random32.New;

            return rng.NextUInt(min != 0 ? min : UInt4.MinValue, max != 0 ? max : (uint)(UInt4.MaxValue + 1));
        }


        [Test]
        public static void Constructor_uint()
        {
            bool result = true;

            UInt4x2 test = new UInt4x2(14);
            result &= test.x == 14;
            result &= test.y == 14;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_uintx2()
        {
            bool result = true;

            UInt4x2 test = new UInt4x2(4, 12);

            result &= test.x == 4;
            result &= test.y == 12;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void GetSingle()
        {
            bool result = true;

            result &= TestData_LHS[0] == UInt4.MaxValue;
            result &= TestData_LHS[1] == 11;

            result &= TestData_RHS[0] == UInt4.MinValue;
            result &= TestData_RHS[1] == 9;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetSingle()
        {
            bool result = true;

            Random32 rng = new Random32(1937519u);

            for (int i = 0; i < 2; i++)
            {
                UInt4x2 test = TestData_LHS;
                uint randomInt = rng.NextUInt(0, UInt4.MaxValue + 1);
                test[i] = randomInt;

                result &= test[0] == ((i == 0) ? randomInt : TestData_LHS.x);
                result &= test[1] == ((i == 1) ? randomInt : TestData_LHS.y);
            }

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void ToFromUInt12x2()
        {
            UInt4x2 test = Random();
            UInt12x2 byte8test = (UInt12x2)test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(test[i], byte8test[i]);
            }

            test = (UInt4x2)byte8test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(test[i], byte8test[i]);
            }
        }

        [Test]
        public static void ToFromUInt20x2()
        {
            UInt4x2 test = Random();
            UInt20x2 byte8test = (UInt20x2)test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(test[i], byte8test[i]);
            }

            test = (UInt4x2)byte8test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(test[i], byte8test[i]);
            }
        }

        [Test]
        public static void ToFromUInt28x2()
        {
            UInt4x2 test = Random();
            UInt28x2 byte8test = (UInt28x2)test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(test[i], byte8test[i]);
            }

            test = (UInt4x2)byte8test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(test[i], byte8test[i]);
            }
        }


        [Test]
        public static void ToFromByte2()
        {
            UInt4x2 test = Random();
            byte2 byte2test = test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)byte2test[i]);
            }

            test = (UInt4x2)byte2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)byte2test[i]);
            }
        }

        [Test]
        public static void ToFromSByte2()
        {
            UInt4x2 test = Random();
            sbyte2 sbyte2test = test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)sbyte2test[i]);
            }

            test = (UInt4x2)sbyte2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)sbyte2test[i]);
            }
        }

        [Test]
        public static void ToFromUShort2()
        {
            UInt4x2 test = Random();
            ushort2 ushort2test = test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)ushort2test[i]);
            }

            test = (UInt4x2)ushort2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)ushort2test[i]);
            }
        }

        [Test]
        public static void ToFromShort2()
        {
            UInt4x2 test = Random();
            short2 short2test = test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)short2test[i]);
            }

            test = (UInt4x2)short2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)short2test[i]);
            }
        }

        [Test]
        public static void ToFromUInt2()
        {
            UInt4x2 test = Random();
            uint2 uint2test = test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)uint2test[i]);
            }

            test = (UInt4x2)uint2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)uint2test[i]);
            }
        }

        [Test]
        public static void ToFromInt2()
        {
            UInt4x2 test = Random();
            int2 int2test = test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)int2test[i]);
            }

            test = (UInt4x2)int2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)int2test[i]);
            }
        }

        [Test]
        public static void ToFromQuarter2()
        {
            UInt4x2 test = Random(0, (byte)(quarter.MaxValue + 1));
            quarter2 quarter2test = (quarter2)test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((quarter)test[i], quarter2test[i]);
            }

            test = (UInt4x2)quarter2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((quarter)test[i], quarter2test[i]);
            }
        }

        [Test]
        public static void ToFromHalf2()
        {
            UInt4x2 test = Random();
            half2 half2test = (half2)test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((half)test[i], half2test[i]);
            }

            test = (UInt4x2)half2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((half)test[i], half2test[i]);
            }
        }

        [Test]
        public static void ToFromFloat2()
        {
            UInt4x2 test = Random();
            float2 float2test = test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((float)test[i], float2test[i]);
            }

            test = (UInt4x2)float2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((float)test[i], float2test[i]);
            }
        }

        [Test]
        public static void ToFromDouble2()
        {
            UInt4x2 test = Random();
            double2 float2test = test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((double)test[i], float2test[i]);
            }

            test = (UInt4x2)float2test;

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual((double)test[i], float2test[i]);
            }
        }

        [Test]
        public static void AddVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt4x2 l = Random();
                UInt4x2 r = Random();
                UInt4x2 add = l + r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(add[j], (l[j] + r[j]) & maxmath.bitmask32((uint)default(UInt4).Bits));
                }
            }
        }

        [Test]
        public static void AddVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt4x2 l = Random();
                uint r = RandomUInt();
                UInt4x2 add = l + r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(add[j], (l[j] + r) & maxmath.bitmask32((uint)default(UInt4).Bits));
                }
            }
        }

        [Test]
        public static void AddScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt4x2 r = Random();
                UInt4x2 add = l + r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(add[j], (l + r[j]) & maxmath.bitmask32((uint)default(UInt4).Bits));
                }
            }
        }

        [Test]
        public static void SubVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt4x2 l = Random();
                UInt4x2 r = Random();
                UInt4x2 sub = l - r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(sub[j], (l[j] - r[j]) & maxmath.bitmask32((uint)default(UInt4).Bits));
                }
            }
        }

        [Test]
        public static void SubVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt4x2 l = Random();
                uint r = RandomUInt();
                UInt4x2 sub = l - r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(sub[j], (l[j] - r) & maxmath.bitmask32((uint)default(UInt4).Bits));
                }
            }
        }

        [Test]
        public static void SubScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt4x2 r = Random();
                UInt4x2 sub = l - r;
                
                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(sub[j], (l - r[j]) & maxmath.bitmask32((uint)default(UInt4).Bits));
                }
            }
        }

        [Test]
        public static void MulVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt4x2 l = Random();
                UInt4x2 r = Random();
                UInt4x2 mul = l * r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(mul[j], (l[j] * r[j]) & maxmath.bitmask32((uint)default(UInt4).Bits));
                }
            }
        }

        [Test]
        public static void MulVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt4x2 l = Random();
                uint r = RandomUInt();
                UInt4x2 mul = l * r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(mul[j], (l[j] * r) & maxmath.bitmask32((uint)default(UInt4).Bits));
                }
            }
        }

        [Test]
        public static void MulScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt4x2 r = Random();
                UInt4x2 mul = l * r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(mul[j], (l * r[j]) & maxmath.bitmask32((uint)default(UInt4).Bits));
                }
            }
        }

        [Test]
        public static void DivVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt4x2 l = Random();
                UInt4x2 r = Random(min: 1);
                UInt4x2 div = l / r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(div[j], (l[j] / r[j]) & maxmath.bitmask32((uint)default(UInt4).Bits));
                }
            }
        }

        [Test]
        public static void DivVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt4x2 l = Random();
                uint r = RandomUInt(min: 1);
                UInt4x2 div = l / r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(div[j], (l[j] / r) & maxmath.bitmask32((uint)default(UInt4).Bits));
                }
            }
        }

        [Test]
        public static void DivScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt4x2 r = Random(min: 1);
                UInt4x2 div = l / r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(div[j], (l / r[j]) & maxmath.bitmask32((uint)default(UInt4).Bits));
                }
            }
        }

        [Test]
        public static void ModVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt4x2 l = Random();
                UInt4x2 r = Random(min: 1);
                UInt4x2 mod = l % r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(mod[j], (l[j] % r[j]) & maxmath.bitmask32((uint)default(UInt4).Bits));
                }
            }
        }

        [Test]
        public static void ModVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt4x2 l = Random();
                uint r = RandomUInt(min: 1);
                UInt4x2 mod = l % r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(mod[j], (l[j] % r) & maxmath.bitmask32((uint)default(UInt4).Bits));
                }
            }
        }

        [Test]
        public static void ModScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt4x2 r = Random(min: 1);
                UInt4x2 mod = l % r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(mod[j], (l % r[j]) & maxmath.bitmask32((uint)default(UInt4).Bits));
                }
            }
        }

        [Test]
        public static void AndVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt4x2 l = Random();
                UInt4x2 r = Random();
                UInt4x2 and = l & r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(and[j], (l[j] & r[j]) & maxmath.bitmask32((uint)default(UInt4).Bits));
                }
            }
        }

        [Test]
        public static void AndVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt4x2 l = Random();
                uint r = RandomUInt();
                UInt4x2 and = l & r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(and[j], (l[j] & r) & maxmath.bitmask32((uint)default(UInt4).Bits));
                }
            }
        }

        [Test]
        public static void AndScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt4x2 r = Random();
                UInt4x2 and = l & r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(and[j], (l & r[j]) & maxmath.bitmask32((uint)default(UInt4).Bits));
                }
            }
        }

        [Test]
        public static void OrVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt4x2 l = Random();
                UInt4x2 r = Random();
                UInt4x2 or = l | r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(or[j], (l[j] | r[j]) & maxmath.bitmask32((uint)default(UInt4).Bits));
                }
            }
        }

        [Test]
        public static void OrVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt4x2 l = Random();
                uint r = RandomUInt();
                UInt4x2 or = l | r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(or[j], (l[j] | r) & maxmath.bitmask32((uint)default(UInt4).Bits));
                }
            }
        }

        [Test]
        public static void OrScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt4x2 r = Random();
                UInt4x2 or = l | r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(or[j], (l | r[j]) & maxmath.bitmask32((uint)default(UInt4).Bits));
                }
            }
        }

        [Test]
        public static void XorVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt4x2 l = Random();
                UInt4x2 r = Random();
                UInt4x2 xor = l ^ r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(xor[j], (l[j] ^ r[j]) & maxmath.bitmask32((uint)default(UInt4).Bits));
                }
            }
        }

        [Test]
        public static void XorVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt4x2 l = Random();
                uint r = RandomUInt();
                UInt4x2 xor = l ^ r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(xor[j], (l[j] ^ r) & maxmath.bitmask32((uint)default(UInt4).Bits));
                }
            }
        }

        [Test]
        public static void XorScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt4x2 r = Random();
                UInt4x2 xor = l ^ r;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(xor[j], (l ^ r[j]) & maxmath.bitmask32((uint)default(UInt4).Bits));
                }
            }
        }

        [Test]
        public static void EqualVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt4x2 l = Random();
                UInt4x2 r = Random();
                UInt4x2 equal = l == r;

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
                UInt4x2 l = Random();
                uint r = RandomUInt();
                UInt4x2 equal = l == r;

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
                uint l = RandomUInt();
                UInt4x2 r = Random();
                UInt4x2 equal = l == r;

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
                UInt4x2 l = Random();
                UInt4x2 r = Random();
                UInt4x2 notEqual = l != r;

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
                UInt4x2 l = Random();
                uint r = RandomUInt();
                UInt4x2 notEqual = l != r;

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
                uint l = RandomUInt();
                UInt4x2 r = Random();
                UInt4x2 notEqual = l != r;

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
                UInt4x2 l = Random();
                UInt4x2 r = Random();
                UInt4x2 less = l < r;

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
                UInt4x2 l = Random();
                uint r = RandomUInt();
                UInt4x2 less = l < r;

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
                uint l = RandomUInt();
                UInt4x2 r = Random();
                UInt4x2 less = l < r;

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
                UInt4x2 l = Random();
                UInt4x2 r = Random();
                UInt4x2 greater = l > r;
                
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
                UInt4x2 l = Random();
                uint r = RandomUInt();
                UInt4x2 greater = l > r;

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
                uint l = RandomUInt();
                UInt4x2 r = Random();
                UInt4x2 greater = l > r;

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
                UInt4x2 l = Random();
                UInt4x2 r = Random();
                UInt4x2 lessEqual = l <= r;
                
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
                UInt4x2 l = Random();
                uint r = RandomUInt();
                UInt4x2 lessEqual = l <= r;

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
                uint l = RandomUInt();
                UInt4x2 r = Random();
                UInt4x2 lessEqual = l <= r;

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
                UInt4x2 l = Random();
                UInt4x2 r = Random();
                UInt4x2 greaterEqual = l >= r;

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
                UInt4x2 l = Random();
                uint r = RandomUInt();
                UInt4x2 greaterEqual = l >= r;

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
                uint l = RandomUInt();
                UInt4x2 r = Random();
                UInt4x2 greaterEqual = l >= r;

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
                UInt4x2 x = Random();
                UInt4x2 not = ~x;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(not[j], (~x[j]) & maxmath.bitmask32((uint)default(UInt4).Bits));
                }
            }
        }

        [Test]
        public static void ShiftLeft()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt4x2 x = Random();
                int n = (int)RandomUInt(0, default(UInt4).Bits);
                UInt4x2 shiftLeft = x << n;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(shiftLeft[j], (x[j] << n) & maxmath.bitmask32((uint)default(UInt4).Bits));
                }
            }
        }

        [Test]
        public static void ShiftRight()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt4x2 x = Random();
                int n = (int)RandomUInt(0, default(UInt4).Bits);
                UInt4x2 shiftRight = x >> n;

                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(shiftRight[j], (x[j] >> n) & maxmath.bitmask32((uint)default(UInt4).Bits));
                }
            }
        }
    }
}