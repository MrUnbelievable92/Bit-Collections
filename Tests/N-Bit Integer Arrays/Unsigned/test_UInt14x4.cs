using NUnit.Framework;
using MaxMath;
using Unity.Mathematics;

namespace BitCollections.Tests
{
    internal static class _UInt14x4
    {
        internal static UInt14x4 TestData_LHS => new UInt14x4(UInt14.MaxValue, 17, 47, 6000);
        internal static UInt14x4 TestData_RHS => new UInt14x4(UInt14.MinValue, 9000, 999, 192);

        private static UInt14x4 Random(ushort min = 0, ushort max = 0)
        {
            Random16 rng = Random16.New;

            UInt14x4 test = new UInt14x4();
            for (int i = 0; i < 4; i++)
            {
                test[i] = rng.NextUShort(min != 0 ? min : UInt14.MinValue, max != 0 ? max : (ushort)(UInt14.MaxValue + 1));
            }

            return test;
        }

        private static uint RandomUInt(ushort min = 0, ushort max = 0)
        {
            Random32 rng = Random32.New;

            return rng.NextUInt(min != 0 ? min : UInt14.MinValue, max != 0 ? max : (uint)(UInt14.MaxValue + 1));
        }


        [Test]
        public static void Constructor_uint()
        {
            bool result = true;

            UInt14x4 test = new UInt14x4(1747);
            result &= test.x == 1747;
            result &= test.y == 1747;
            result &= test.z == 1747;
            result &= test.w == 1747;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_uintx2()
        {
            bool result = true;

            UInt14x4 test = new UInt14x4(17, 47, 21, 3333);

            result &= test.x == 17;
            result &= test.y == 47;
            result &= test.z == 21;
            result &= test.w == 3333;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void GetSingle()
        {
            bool result = true;

            result &= TestData_LHS[0] == UInt14.MaxValue;
            result &= TestData_LHS[1] == 17;
            result &= TestData_LHS[2] == 47;
            result &= TestData_LHS[3] == 6000;

            result &= TestData_RHS[0] == UInt14.MinValue;
            result &= TestData_RHS[1] == 9000;
            result &= TestData_RHS[2] == 999;
            result &= TestData_RHS[3] == 192;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetSingle()
        {
            bool result = true;

            Random32 rng = new Random32(1937519u);

            for (int i = 0; i < 4; i++)
            {
                UInt14x4 test = TestData_LHS;
                uint randomInt = rng.NextUInt(0, UInt14.MaxValue + 1);
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
            UInt14x4 test = Random(0, byte.MaxValue + 1);
            byte4 byte4test = (byte4)test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)byte4test[i]);
            }

            test = (UInt14x4)byte4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)byte4test[i]);
            }
        }

        [Test]
        public static void ToFromSByte4()
        {
            UInt14x4 test = Random(0, sbyte.MaxValue + 1);
            sbyte4 sbyte4test = (sbyte4)test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)sbyte4test[i]);
            }

            test = (UInt14x4)sbyte4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)sbyte4test[i]);
            }
        }
        [Test]
        public static void ToFromUShort4()
        {
            UInt14x4 test = Random();
            ushort4 ushort4test = test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)ushort4test[i]);
            }

            test = (UInt14x4)ushort4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)ushort4test[i]);
            }
        }

        [Test]
        public static void ToFromShort4()
        {
            UInt14x4 test = Random();
            short4 short4test = test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)short4test[i]);
            }

            test = (UInt14x4)short4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)short4test[i]);
            }
        }

        [Test]
        public static void ToFromUInt4()
        {
            UInt14x4 test = Random();
            uint4 uint4test = test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)uint4test[i]);
            }

            test = (UInt14x4)uint4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)uint4test[i]);
            }
        }

        [Test]
        public static void ToFromInt4()
        {
            UInt14x4 test = Random();
            int4 int4test = test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)int4test[i]);
            }

            test = (UInt14x4)int4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)int4test[i]);
            }
        }

        [Test]
        public static void ToFromULong4()
        {
            UInt14x4 test = Random();
            ulong4 ulong4test = test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((ulong)test[i], (ulong)ulong4test[i]);
            }

            test = (UInt14x4)ulong4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((ulong)test[i], (ulong)ulong4test[i]);
            }
        }

        [Test]
        public static void ToFromLong4()
        {
            UInt14x4 test = Random();
            long4 long4test = test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((ulong)test[i], (ulong)long4test[i]);
            }

            test = (UInt14x4)long4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((ulong)test[i], (ulong)long4test[i]);
            }
        }

        [Test]
        public static void ToFromQuarter4()
        {
            UInt14x4 test = Random(0, (byte)(quarter.MaxValue + 1));
            quarter4 quarter4test = (quarter4)test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((quarter)test[i], quarter4test[i]);
            }

            test = (UInt14x4)quarter4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((quarter)test[i], quarter4test[i]);
            }
        }

        [Test]
        public static void ToFromHalf4()
        {
            UInt14x4 test = Random();
            half4 half4test = test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((half)test[i], half4test[i]);
            }

            test = (UInt14x4)half4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((half)test[i], half4test[i]);
            }
        }

        [Test]
        public static void ToFromFloat4()
        {
            UInt14x4 test = Random();
            float4 float4test = test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((float)test[i], float4test[i]);
            }

            test = (UInt14x4)float4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((float)test[i], float4test[i]);
            }
        }

        [Test]
        public static void ToFromDouble4()
        {
            UInt14x4 test = Random();
            double4 float4test = test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((double)test[i], float4test[i]);
            }

            test = (UInt14x4)float4test;

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual((double)test[i], float4test[i]);
            }
        }

        [Test]
        public static void AddVectorVector()
        {
            for (int i = 0; i < 144; i++)
            {
                UInt14x4 l = Random();
                UInt14x4 r = Random();
                UInt14x4 add = l + r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(add[j], (l[j] + r[j]) & maxmath.bitmask32((uint)default(UInt14).Bits));
                }
            }
        }

        [Test]
        public static void AddVectorScalar()
        {
            for (int i = 0; i < 144; i++)
            {
                UInt14x4 l = Random();
                uint r = RandomUInt();
                UInt14x4 add = l + r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(add[j], (l[j] + r) & maxmath.bitmask32((uint)default(UInt14).Bits));
                }
            }
        }

        [Test]
        public static void AddScalarVector()
        {
            for (int i = 0; i < 144; i++)
            {
                uint l = RandomUInt();
                UInt14x4 r = Random();
                UInt14x4 add = l + r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(add[j], (l + r[j]) & maxmath.bitmask32((uint)default(UInt14).Bits));
                }
            }
        }

        [Test]
        public static void SubVectorVector()
        {
            for (int i = 0; i < 144; i++)
            {
                UInt14x4 l = Random();
                UInt14x4 r = Random();
                UInt14x4 sub = l - r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(sub[j], (l[j] - r[j]) & maxmath.bitmask32((uint)default(UInt14).Bits));
                }
            }
        }

        [Test]
        public static void SubVectorScalar()
        {
            for (int i = 0; i < 144; i++)
            {
                UInt14x4 l = Random();
                uint r = RandomUInt();
                UInt14x4 sub = l - r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(sub[j], (l[j] - r) & maxmath.bitmask32((uint)default(UInt14).Bits));
                }
            }
        }

        [Test]
        public static void SubScalarVector()
        {
            for (int i = 0; i < 144; i++)
            {
                uint l = RandomUInt();
                UInt14x4 r = Random();
                UInt14x4 sub = l - r;
                
                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(sub[j], (l - r[j]) & maxmath.bitmask32((uint)default(UInt14).Bits));
                }
            }
        }

        [Test]
        public static void MulVectorVector()
        {
            for (int i = 0; i < 144; i++)
            {
                UInt14x4 l = Random();
                UInt14x4 r = Random();
                UInt14x4 mul = l * r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(mul[j], (l[j] * r[j]) & maxmath.bitmask32((uint)default(UInt14).Bits));
                }
            }
        }

        [Test]
        public static void MulVectorScalar()
        {
            for (int i = 0; i < 144; i++)
            {
                UInt14x4 l = Random();
                uint r = RandomUInt();
                UInt14x4 mul = l * r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(mul[j], (l[j] * r) & maxmath.bitmask32((uint)default(UInt14).Bits));
                }
            }
        }

        [Test]
        public static void MulScalarVector()
        {
            for (int i = 0; i < 144; i++)
            {
                uint l = RandomUInt();
                UInt14x4 r = Random();
                UInt14x4 mul = l * r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(mul[j], (l * r[j]) & maxmath.bitmask32((uint)default(UInt14).Bits));
                }
            }
        }

        [Test]
        public static void DivVectorVector()
        {
            for (int i = 0; i < 144; i++)
            {
                UInt14x4 l = Random();
                UInt14x4 r = Random(min: 1);
                UInt14x4 div = l / r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(div[j], (l[j] / r[j]) & maxmath.bitmask32((uint)default(UInt14).Bits));
                }
            }
        }

        [Test]
        public static void DivVectorScalar()
        {
            for (int i = 0; i < 144; i++)
            {
                UInt14x4 l = Random();
                uint r = RandomUInt(min: 1);
                UInt14x4 div = l / r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(div[j], (l[j] / r) & maxmath.bitmask32((uint)default(UInt14).Bits));
                }
            }
        }

        [Test]
        public static void DivScalarVector()
        {
            for (int i = 0; i < 144; i++)
            {
                uint l = RandomUInt();
                UInt14x4 r = Random(min: 1);
                UInt14x4 div = l / r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(div[j], (l / r[j]) & maxmath.bitmask32((uint)default(UInt14).Bits));
                }
            }
        }

        [Test]
        public static void ModVectorVector()
        {
            for (int i = 0; i < 144; i++)
            {
                UInt14x4 l = Random();
                UInt14x4 r = Random(min: 1);
                UInt14x4 mod = l % r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(mod[j], (l[j] % r[j]) & maxmath.bitmask32((uint)default(UInt14).Bits));
                }
            }
        }

        [Test]
        public static void ModVectorScalar()
        {
            for (int i = 0; i < 144; i++)
            {
                UInt14x4 l = Random();
                uint r = RandomUInt(min: 1);
                UInt14x4 mod = l % r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(mod[j], (l[j] % r) & maxmath.bitmask32((uint)default(UInt14).Bits));
                }
            }
        }

        [Test]
        public static void ModScalarVector()
        {
            for (int i = 0; i < 144; i++)
            {
                uint l = RandomUInt();
                UInt14x4 r = Random(min: 1);
                UInt14x4 mod = l % r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(mod[j], (l % r[j]) & maxmath.bitmask32((uint)default(UInt14).Bits));
                }
            }
        }

        [Test]
        public static void AndVectorVector()
        {
            for (int i = 0; i < 144; i++)
            {
                UInt14x4 l = Random();
                UInt14x4 r = Random();
                UInt14x4 and = l & r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(and[j], (l[j] & r[j]) & maxmath.bitmask32((uint)default(UInt14).Bits));
                }
            }
        }

        [Test]
        public static void AndVectorScalar()
        {
            for (int i = 0; i < 144; i++)
            {
                UInt14x4 l = Random();
                uint r = RandomUInt();
                UInt14x4 and = l & r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(and[j], (l[j] & r) & maxmath.bitmask32((uint)default(UInt14).Bits));
                }
            }
        }

        [Test]
        public static void AndScalarVector()
        {
            for (int i = 0; i < 144; i++)
            {
                uint l = RandomUInt();
                UInt14x4 r = Random();
                UInt14x4 and = l & r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(and[j], (l & r[j]) & maxmath.bitmask32((uint)default(UInt14).Bits));
                }
            }
        }

        [Test]
        public static void OrVectorVector()
        {
            for (int i = 0; i < 144; i++)
            {
                UInt14x4 l = Random();
                UInt14x4 r = Random();
                UInt14x4 or = l | r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(or[j], (l[j] | r[j]) & maxmath.bitmask32((uint)default(UInt14).Bits));
                }
            }
        }

        [Test]
        public static void OrVectorScalar()
        {
            for (int i = 0; i < 144; i++)
            {
                UInt14x4 l = Random();
                uint r = RandomUInt();
                UInt14x4 or = l | r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(or[j], (l[j] | r) & maxmath.bitmask32((uint)default(UInt14).Bits));
                }
            }
        }

        [Test]
        public static void OrScalarVector()
        {
            for (int i = 0; i < 144; i++)
            {
                uint l = RandomUInt();
                UInt14x4 r = Random();
                UInt14x4 or = l | r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(or[j], (l | r[j]) & maxmath.bitmask32((uint)default(UInt14).Bits));
                }
            }
        }

        [Test]
        public static void XorVectorVector()
        {
            for (int i = 0; i < 144; i++)
            {
                UInt14x4 l = Random();
                UInt14x4 r = Random();
                UInt14x4 xor = l ^ r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(xor[j], (l[j] ^ r[j]) & maxmath.bitmask32((uint)default(UInt14).Bits));
                }
            }
        }

        [Test]
        public static void XorVectorScalar()
        {
            for (int i = 0; i < 144; i++)
            {
                UInt14x4 l = Random();
                uint r = RandomUInt();
                UInt14x4 xor = l ^ r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(xor[j], (l[j] ^ r) & maxmath.bitmask32((uint)default(UInt14).Bits));
                }
            }
        }

        [Test]
        public static void XorScalarVector()
        {
            for (int i = 0; i < 144; i++)
            {
                uint l = RandomUInt();
                UInt14x4 r = Random();
                UInt14x4 xor = l ^ r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(xor[j], (l ^ r[j]) & maxmath.bitmask32((uint)default(UInt14).Bits));
                }
            }
        }

        [Test]
        public static void EqualVectorVector()
        {
            for (int i = 0; i < 144; i++)
            {
                UInt14x4 l = Random();
                UInt14x4 r = Random();
                UInt14x4 equal = l == r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(maxmath.tobool(equal[j]), l[j] == r[j]);
                }
            }
        }

        [Test]
        public static void EqualVectorScalar()
        {
            for (int i = 0; i < 144; i++)
            {
                UInt14x4 l = Random();
                uint r = RandomUInt();
                UInt14x4 equal = l == r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(maxmath.tobool(equal[j]), l[j] == r);
                }
            }
        }

        [Test]
        public static void EqualScalarVector()
        {
            for (int i = 0; i < 144; i++)
            {
                uint l = RandomUInt();
                UInt14x4 r = Random();
                UInt14x4 equal = l == r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(maxmath.tobool(equal[j]), l == r[j]);
                }
            }
        }

        [Test]
        public static void NotEqualVectorVector()
        {
            for (int i = 0; i < 144; i++)
            {
                UInt14x4 l = Random();
                UInt14x4 r = Random();
                UInt14x4 notEqual = l != r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(maxmath.tobool(notEqual[j]), l[j] != r[j]);
                }
            }
        }

        [Test]
        public static void NotEqualVectorScalar()
        {
            for (int i = 0; i < 144; i++)
            {
                UInt14x4 l = Random();
                uint r = RandomUInt();
                UInt14x4 notEqual = l != r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(maxmath.tobool(notEqual[j]), l[j] != r);
                }
            }
        }

        [Test]
        public static void NotEqualScalarVector()
        {
            for (int i = 0; i < 144; i++)
            {
                uint l = RandomUInt();
                UInt14x4 r = Random();
                UInt14x4 notEqual = l != r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(maxmath.tobool(notEqual[j]), l != r[j]);
                }
            }
        }

        [Test]
        public static void LessVectorVector()
        {
            for (int i = 0; i < 144; i++)
            {
                UInt14x4 l = Random();
                UInt14x4 r = Random();
                UInt14x4 less = l < r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(maxmath.tobool(less[j]), l[j] < r[j]);
                }
            }
        }

        [Test]
        public static void LessVectorScalar()
        {
            for (int i = 0; i < 144; i++)
            {
                UInt14x4 l = Random();
                uint r = RandomUInt();
                UInt14x4 less = l < r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(maxmath.tobool(less[j]), l[j] < r);
                }
            }
        }

        [Test]
        public static void LessScalarVector()
        {
            for (int i = 0; i < 144; i++)
            {
                uint l = RandomUInt();
                UInt14x4 r = Random();
                UInt14x4 less = l < r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(maxmath.tobool(less[j]), l < r[j]);
                }
            }
        }

        [Test]
        public static void GreaterVectorVector()
        {
            for (int i = 0; i < 144; i++)
            {
                UInt14x4 l = Random();
                UInt14x4 r = Random();
                UInt14x4 greater = l > r;
                
                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(maxmath.tobool(greater[j]), l[j] > r[j]);
                }
            }
        }

        [Test]
        public static void GreaterVectorScalar()
        {
            for (int i = 0; i < 144; i++)
            {
                UInt14x4 l = Random();
                uint r = RandomUInt();
                UInt14x4 greater = l > r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(maxmath.tobool(greater[j]), l[j] > r);
                }
            }
        }

        [Test]
        public static void GreaterScalarVector()
        {
            for (int i = 0; i < 144; i++)
            {
                uint l = RandomUInt();
                UInt14x4 r = Random();
                UInt14x4 greater = l > r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(maxmath.tobool(greater[j]), l > r[j]);
                }
            }
        }

        [Test]
        public static void LessEqualVectorVector()
        {
            for (int i = 0; i < 144; i++)
            {
                UInt14x4 l = Random();
                UInt14x4 r = Random();
                UInt14x4 lessEqual = l <= r;
                
                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(maxmath.tobool(lessEqual[j]), l[j] <= r[j]);
                }
            }
        }

        [Test]
        public static void LessEqualVectorScalar()
        {
            for (int i = 0; i < 144; i++)
            {
                UInt14x4 l = Random();
                uint r = RandomUInt();
                UInt14x4 lessEqual = l <= r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(maxmath.tobool(lessEqual[j]), l[j] <= r);
                }
            }
        }

        [Test]
        public static void LessEqualScalarVector()
        {
            for (int i = 0; i < 144; i++)
            {
                uint l = RandomUInt();
                UInt14x4 r = Random();
                UInt14x4 lessEqual = l <= r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(maxmath.tobool(lessEqual[j]), l <= r[j]);
                }
            }
        }

        [Test]
        public static void GreaterEqualVectorVector()
        {
            for (int i = 0; i < 144; i++)
            {
                UInt14x4 l = Random();
                UInt14x4 r = Random();
                UInt14x4 greaterEqual = l >= r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(maxmath.tobool(greaterEqual[j]), l[j] >= r[j]);
                }
            }
        }

        [Test]
        public static void GreaterEqualVectorScalar()
        {
            for (int i = 0; i < 144; i++)
            {
                UInt14x4 l = Random();
                uint r = RandomUInt();
                UInt14x4 greaterEqual = l >= r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(maxmath.tobool(greaterEqual[j]), l[j] >= r);
                }
            }
        }

        [Test]
        public static void GreaterEqualScalarVector()
        {
            for (int i = 0; i < 144; i++)
            {
                uint l = RandomUInt();
                UInt14x4 r = Random();
                UInt14x4 greaterEqual = l >= r;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(maxmath.tobool(greaterEqual[j]), l >= r[j]);
                }
            }
        }

        [Test]
        public static void Not()
        {
            for (int i = 0; i < 144; i++)
            {
                UInt14x4 x = Random();
                UInt14x4 not = ~x;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(not[j], (~x[j]) & maxmath.bitmask32((uint)default(UInt14).Bits));
                }
            }
        }

        [Test]
        public static void ShiftLeft()
        {
            for (int i = 0; i < 144; i++)
            {
                UInt14x4 x = Random();
                int n = (int)RandomUInt(0, default(UInt14).Bits);
                UInt14x4 shiftLeft = x << n;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(shiftLeft[j], (x[j] << n) & maxmath.bitmask32((uint)default(UInt14).Bits));
                }
            }
        }

        [Test]
        public static void ShiftRight()
        {
            for (int i = 0; i < 144; i++)
            {
                UInt14x4 x = Random();
                int n = (int)RandomUInt(0, default(UInt14).Bits);
                UInt14x4 shiftRight = x >> n;

                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(shiftRight[j], (x[j] >> n) & maxmath.bitmask32((uint)default(UInt14).Bits));
                }
            }
        }
    }
}