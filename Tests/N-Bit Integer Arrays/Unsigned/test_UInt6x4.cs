using NUnit.Framework;
using Unity.Mathematics;
using MaxMath;

namespace BitCollections.Tests
{
    internal static class _UInt6x4
    {
        internal static UInt6x4 TestData_LHS => new UInt6x4(UInt6.MaxValue, 32, 47, 21);
        internal static UInt6x4 TestData_RHS => new UInt6x4(UInt6.MinValue, 60, 63, 25);


        private static UInt6x4 Random(byte min = 0, byte max = 0)
        {
            Random8 rng = Random8.New;

            UInt6x4 test = new UInt6x4();
            for (int i = 0; i < 4; i++)
            {
                test[i] = rng.NextByte(min != 0 ? min : UInt6.MinValue, max != 0 ? max : (byte)(UInt6.MaxValue + 1));
            }

            return test;
        }

        private static uint RandomUInt(ushort min = 0, ushort max = 0)
        {
            Random32 rng = Random32.New;

            return rng.NextUInt(min != 0 ? min : UInt6.MinValue, max != 0 ? max : (uint)(UInt6.MaxValue + 1));
        }


        [Test]
        public static void Constructor_uint()
        {
            bool result = true;

            UInt6x4 test = new UInt6x4(47);
            result &= test.x == 47;
            result &= test.y == 47;
            result &= test.z == 47;
            result &= test.w == 47;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_uintx2()
        {
            bool result = true;

            UInt6x4 test = new UInt6x4(12, 47, 37, 19);

            result &= test.x == 12;
            result &= test.y == 47;
            result &= test.z == 37;
            result &= test.w == 19;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void GetSingle()
        {
            bool result = true;

            result &= TestData_LHS[0] == UInt6.MaxValue;
            result &= TestData_LHS[1] == 32;
            result &= TestData_LHS[2] == 47;
            result &= TestData_LHS[3] == 21;

            result &= TestData_RHS[0] == UInt6.MinValue;
            result &= TestData_RHS[1] == 60;
            result &= TestData_RHS[2] == 63;
            result &= TestData_RHS[3] == 25;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetSingle()
        {
            bool result = true;

            Random32 rng = new Random32(1937519u);

            for (int i = 0; i < 4; i++)
            {
                UInt6x4 test = TestData_LHS;
                uint randomInt = rng.NextUInt(0, UInt6.MaxValue + 1);
                test[i] = randomInt;

                result &= test[0] == ((i == 0) ? randomInt : TestData_LHS.x);
                result &= test[1] == ((i == 1) ? randomInt : TestData_LHS.y);
                result &= test[2] == ((i == 2) ? randomInt : TestData_LHS.z);
                result &= test[3] == ((i == 3) ? randomInt : TestData_LHS.w);
            }

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void ToFromUInt10x4()
        {
            UInt6x4 test = Random();
            UInt10x4 byte4test = (UInt10x4)test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual(test[i], byte4test[i]);
            }

            test = (UInt6x4)byte4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual(test[i], byte4test[i]);
            }
        }

        [Test]
        public static void ToFromUInt12x4()
        {
            UInt6x4 test = Random();
            UInt12x4 byte4test = (UInt12x4)test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual(test[i], byte4test[i]);
            }

            test = (UInt6x4)byte4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual(test[i], byte4test[i]);
            }
        }

        [Test]
        public static void ToFromUInt14x4()
        {
            UInt6x4 test = Random();
            UInt14x4 byte4test = (UInt14x4)test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual(test[i], byte4test[i]);
            }

            test = (UInt6x4)byte4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual(test[i], byte4test[i]);
            }
        }


        [Test]
        public static void ToFromByte4()
        {
            UInt6x4 test = Random();
            byte4 byte4test = test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)byte4test[i]);
            }

            test = (UInt6x4)byte4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)byte4test[i]);
            }
        }

        [Test]
        public static void ToFromSByte4()
        {
            UInt6x4 test = Random();
            sbyte4 sbyte4test = test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)sbyte4test[i]);
            }

            test = (UInt6x4)sbyte4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)sbyte4test[i]);
            }
        }

        [Test]
        public static void ToFromUShort4()
        {
            UInt6x4 test = Random();
            ushort4 ushort4test = test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)ushort4test[i]);
            }

            test = (UInt6x4)ushort4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)ushort4test[i]);
            }
        }

        [Test]
        public static void ToFromShort4()
        {
            UInt6x4 test = Random();
            short4 short4test = test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)short4test[i]);
            }

            test = (UInt6x4)short4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)short4test[i]);
            }
        }

        [Test]
        public static void ToFromUInt4()
        {
            UInt6x4 test = Random();
            uint4 uint4test = test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)uint4test[i]);
            }

            test = (UInt6x4)uint4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)uint4test[i]);
            }
        }

        [Test]
        public static void ToFromInt4()
        {
            UInt6x4 test = Random();
            int4 int4test = test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)int4test[i]);
            }

            test = (UInt6x4)int4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)int4test[i]);
            }
        }

        [Test]
        public static void ToFromULong4()
        {
            UInt6x4 test = Random();
            ulong4 ulong4test = test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)ulong4test[i]);
            }

            test = (UInt6x4)ulong4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)ulong4test[i]);
            }
        }

        [Test]
        public static void ToFromLong4()
        {
            UInt6x4 test = Random();
            long4 long4test = test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)long4test[i]);
            }

            test = (UInt6x4)long4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)long4test[i]);
            }
        }

        [Test]
        public static void ToFromQuarter4()
        {
            UInt6x4 test = Random(0, (byte)(quarter.MaxValue + 1));
            quarter4 quarter4test = (quarter4)test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((quarter)test[i], quarter4test[i]);
            }

            test = (UInt6x4)quarter4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((quarter)test[i], quarter4test[i]);
            }
        }

        [Test]
        public static void ToFromHalf4()
        {
            UInt6x4 test = Random();
            half4 half4test = test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((half)test[i], half4test[i]);
            }

            test = (UInt6x4)half4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((half)test[i], half4test[i]);
            }
        }

        [Test]
        public static void ToFromFloat4()
        {
            UInt6x4 test = Random();
            float4 float4test = test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((float)test[i], float4test[i]);
            }

            test = (UInt6x4)float4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((float)test[i], float4test[i]);
            }
        }

        [Test]
        public static void ToFromDouble4()
        {
            UInt6x4 test = Random();
            double4 float4test = test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((double)test[i], float4test[i]);
            }

            test = (UInt6x4)float4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((double)test[i], float4test[i]);
            }
        }

        [Test]
        public static void AddVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt6x4 l = Random();
                UInt6x4 r = Random();
                UInt6x4 add = l + r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(add[j], (l[j] + r[j]) & maxmath.bitmask32((uint)default(UInt6).Bits));
                }
            }
        }

        [Test]
        public static void AddVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt6x4 l = Random();
                uint r = RandomUInt();
                UInt6x4 add = l + r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(add[j], (l[j] + r) & maxmath.bitmask32((uint)default(UInt6).Bits));
                }
            }
        }

        [Test]
        public static void AddScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt6x4 r = Random();
                UInt6x4 add = l + r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(add[j], (l + r[j]) & maxmath.bitmask32((uint)default(UInt6).Bits));
                }
            }
        }

        [Test]
        public static void SubVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt6x4 l = Random();
                UInt6x4 r = Random();
                UInt6x4 sub = l - r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(sub[j], (l[j] - r[j]) & maxmath.bitmask32((uint)default(UInt6).Bits));
                }
            }
        }

        [Test]
        public static void SubVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt6x4 l = Random();
                uint r = RandomUInt();
                UInt6x4 sub = l - r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(sub[j], (l[j] - r) & maxmath.bitmask32((uint)default(UInt6).Bits));
                }
            }
        }

        [Test]
        public static void SubScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt6x4 r = Random();
                UInt6x4 sub = l - r;
                
                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(sub[j], (l - r[j]) & maxmath.bitmask32((uint)default(UInt6).Bits));
                }
            }
        }

        [Test]
        public static void MulVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt6x4 l = Random();
                UInt6x4 r = Random();
                UInt6x4 mul = l * r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(mul[j], (l[j] * r[j]) & maxmath.bitmask32((uint)default(UInt6).Bits));
                }
            }
        }

        [Test]
        public static void MulVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt6x4 l = Random();
                uint r = RandomUInt();
                UInt6x4 mul = l * r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(mul[j], (l[j] * r) & maxmath.bitmask32((uint)default(UInt6).Bits));
                }
            }
        }

        [Test]
        public static void MulScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt6x4 r = Random();
                UInt6x4 mul = l * r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(mul[j], (l * r[j]) & maxmath.bitmask32((uint)default(UInt6).Bits));
                }
            }
        }

        [Test]
        public static void DivVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt6x4 l = Random();
                UInt6x4 r = Random(min: 1);
                UInt6x4 div = l / r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(div[j], (l[j] / r[j]) & maxmath.bitmask32((uint)default(UInt6).Bits));
                }
            }
        }

        [Test]
        public static void DivVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt6x4 l = Random();
                uint r = RandomUInt(min: 1);
                UInt6x4 div = l / r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(div[j], (l[j] / r) & maxmath.bitmask32((uint)default(UInt6).Bits));
                }
            }
        }

        [Test]
        public static void DivScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt6x4 r = Random(min: 1);
                UInt6x4 div = l / r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(div[j], (l / r[j]) & maxmath.bitmask32((uint)default(UInt6).Bits));
                }
            }
        }

        [Test]
        public static void ModVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt6x4 l = Random();
                UInt6x4 r = Random(min: 1);
                UInt6x4 mod = l % r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(mod[j], (l[j] % r[j]) & maxmath.bitmask32((uint)default(UInt6).Bits));
                }
            }
        }

        [Test]
        public static void ModVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt6x4 l = Random();
                uint r = RandomUInt(min: 1);
                UInt6x4 mod = l % r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(mod[j], (l[j] % r) & maxmath.bitmask32((uint)default(UInt6).Bits));
                }
            }
        }

        [Test]
        public static void ModScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt6x4 r = Random(min: 1);
                UInt6x4 mod = l % r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(mod[j], (l % r[j]) & maxmath.bitmask32((uint)default(UInt6).Bits));
                }
            }
        }

        [Test]
        public static void AndVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt6x4 l = Random();
                UInt6x4 r = Random();
                UInt6x4 and = l & r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(and[j], (l[j] & r[j]) & maxmath.bitmask32((uint)default(UInt6).Bits));
                }
            }
        }

        [Test]
        public static void AndVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt6x4 l = Random();
                uint r = RandomUInt();
                UInt6x4 and = l & r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(and[j], (l[j] & r) & maxmath.bitmask32((uint)default(UInt6).Bits));
                }
            }
        }

        [Test]
        public static void AndScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt6x4 r = Random();
                UInt6x4 and = l & r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(and[j], (l & r[j]) & maxmath.bitmask32((uint)default(UInt6).Bits));
                }
            }
        }

        [Test]
        public static void OrVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt6x4 l = Random();
                UInt6x4 r = Random();
                UInt6x4 or = l | r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(or[j], (l[j] | r[j]) & maxmath.bitmask32((uint)default(UInt6).Bits));
                }
            }
        }

        [Test]
        public static void OrVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt6x4 l = Random();
                uint r = RandomUInt();
                UInt6x4 or = l | r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(or[j], (l[j] | r) & maxmath.bitmask32((uint)default(UInt6).Bits));
                }
            }
        }

        [Test]
        public static void OrScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt6x4 r = Random();
                UInt6x4 or = l | r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(or[j], (l | r[j]) & maxmath.bitmask32((uint)default(UInt6).Bits));
                }
            }
        }

        [Test]
        public static void XorVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt6x4 l = Random();
                UInt6x4 r = Random();
                UInt6x4 xor = l ^ r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(xor[j], (l[j] ^ r[j]) & maxmath.bitmask32((uint)default(UInt6).Bits));
                }
            }
        }

        [Test]
        public static void XorVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt6x4 l = Random();
                uint r = RandomUInt();
                UInt6x4 xor = l ^ r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(xor[j], (l[j] ^ r) & maxmath.bitmask32((uint)default(UInt6).Bits));
                }
            }
        }

        [Test]
        public static void XorScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt6x4 r = Random();
                UInt6x4 xor = l ^ r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(xor[j], (l ^ r[j]) & maxmath.bitmask32((uint)default(UInt6).Bits));
                }
            }
        }

        [Test]
        public static void EqualVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt6x4 l = Random();
                UInt6x4 r = Random();
                UInt6x4 equal = l == r;

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
                UInt6x4 l = Random();
                uint r = RandomUInt();
                UInt6x4 equal = l == r;

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
                uint l = RandomUInt();
                UInt6x4 r = Random();
                UInt6x4 equal = l == r;

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
                UInt6x4 l = Random();
                UInt6x4 r = Random();
                UInt6x4 notEqual = l != r;

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
                UInt6x4 l = Random();
                uint r = RandomUInt();
                UInt6x4 notEqual = l != r;

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
                uint l = RandomUInt();
                UInt6x4 r = Random();
                UInt6x4 notEqual = l != r;

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
                UInt6x4 l = Random();
                UInt6x4 r = Random();
                UInt6x4 less = l < r;

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
                UInt6x4 l = Random();
                uint r = RandomUInt();
                UInt6x4 less = l < r;

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
                uint l = RandomUInt();
                UInt6x4 r = Random();
                UInt6x4 less = l < r;

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
                UInt6x4 l = Random();
                UInt6x4 r = Random();
                UInt6x4 greater = l > r;
                
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
                UInt6x4 l = Random();
                uint r = RandomUInt();
                UInt6x4 greater = l > r;

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
                uint l = RandomUInt();
                UInt6x4 r = Random();
                UInt6x4 greater = l > r;

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
                UInt6x4 l = Random();
                UInt6x4 r = Random();
                UInt6x4 lessEqual = l <= r;
                
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
                UInt6x4 l = Random();
                uint r = RandomUInt();
                UInt6x4 lessEqual = l <= r;

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
                uint l = RandomUInt();
                UInt6x4 r = Random();
                UInt6x4 lessEqual = l <= r;

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
                UInt6x4 l = Random();
                UInt6x4 r = Random();
                UInt6x4 greaterEqual = l >= r;

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
                UInt6x4 l = Random();
                uint r = RandomUInt();
                UInt6x4 greaterEqual = l >= r;

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
                uint l = RandomUInt();
                UInt6x4 r = Random();
                UInt6x4 greaterEqual = l >= r;

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
                UInt6x4 x = Random();
                UInt6x4 not = ~x;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(not[j], (~x[j]) & maxmath.bitmask32((uint)default(UInt6).Bits));
                }
            }
        }

        [Test]
        public static void ShiftLeft()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt6x4 x = Random();
                int n = (int)RandomUInt(0, default(UInt6).Bits);
                UInt6x4 shiftLeft = x << n;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(shiftLeft[j], (x[j] << n) & maxmath.bitmask32((uint)default(UInt6).Bits));
                }
            }
        }

        [Test]
        public static void ShiftRight()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt6x4 x = Random();
                int n = (int)RandomUInt(0, default(UInt6).Bits);
                UInt6x4 shiftRight = x >> n;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(shiftRight[j], (x[j] >> n) & maxmath.bitmask32((uint)default(UInt6).Bits));
                }
            }
        }
    }
}