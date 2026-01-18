using NUnit.Framework;
using MaxMath;

namespace BitCollections.Tests
{
    internal static class _UInt2x16
    {
        internal static UInt2x16 TestData_LHS => new UInt2x16(UInt2.MaxValue, 1, 2, 0, 0, 1, 3, 0, 3, 3, 1, 0, 2, 3, 1, 2);
        internal static UInt2x16 TestData_RHS => new UInt2x16(UInt2.MinValue, 1, 3, 3, 2, 1, 0, 2, 0, 3, 2, 2, 1, 3, 0, 2);
        
        private static UInt2x16 Random(byte min = 0, byte max = 0)
        {
            Random8 rng = Random8.New;

            UInt2x16 test = new UInt2x16();
            for (int i = 0; i < 16; i++)
            {
                test[i] = rng.NextByte(min != 0 ? min : UInt2.MinValue, max != 0 ? max : (byte)(UInt2.MaxValue + 1));
            }

            return test;
        }

        private static uint RandomUInt(ushort min = 0, ushort max = 0)
        {
            Random32 rng = Random32.New;

            return rng.NextUInt(min != 0 ? min : UInt2.MinValue, max != 0 ? max : (uint)(UInt2.MaxValue + 1));
        }

        [Test]
        public static void Constructor_uint()
        {
            bool result = true;

            UInt2x16 test = new UInt2x16(2);
            result &= test.x0 == 2;
            result &= test.x1 == 2;
            result &= test.x2 == 2;
            result &= test.x3 == 2;
            result &= test.x4 == 2;
            result &= test.x5 == 2;
            result &= test.x6 == 2;
            result &= test.x7 == 2;
            result &= test.x8 == 2;
            result &= test.x9 == 2;
            result &= test.x10 == 2;
            result &= test.x11 == 2;
            result &= test.x12 == 2;
            result &= test.x13 == 2;
            result &= test.x14 == 2;
            result &= test.x15 == 2;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_uintx16()
        {
            bool result = true;

            UInt2x16 test = new UInt2x16(1, 0, 0, 2, 3, 1, 0, 2, 3, 1, 2, 0, 1, 0, 3, 2);

            result &= test.x0 == 1;
            result &= test.x1 == 0;
            result &= test.x2 == 0;
            result &= test.x3 == 2;
            result &= test.x4 == 3;
            result &= test.x5 == 1;
            result &= test.x6 == 0;
            result &= test.x7 == 2;
            result &= test.x8 == 3;
            result &= test.x9 == 1;
            result &= test.x10 == 2;
            result &= test.x11 == 0;
            result &= test.x12 == 1;
            result &= test.x13 == 0;
            result &= test.x14 == 3;
            result &= test.x15 == 2;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void GetSingle()
        {
            bool result = true;

            result &= TestData_LHS[0] == UInt2.MaxValue;
            result &= TestData_LHS[1] == 1;
            result &= TestData_LHS[2] == 2;
            result &= TestData_LHS[3] == 0;
            result &= TestData_LHS[4] == 0;
            result &= TestData_LHS[5] == 1;
            result &= TestData_LHS[6] == 3;
            result &= TestData_LHS[7] == 0;
            result &= TestData_LHS[8] == 3;
            result &= TestData_LHS[9] == 3;
            result &= TestData_LHS[10] == 1;
            result &= TestData_LHS[11] == 0;
            result &= TestData_LHS[12] == 2;
            result &= TestData_LHS[13] == 3;
            result &= TestData_LHS[14] == 1;
            result &= TestData_LHS[15] == 2;

            result &= TestData_RHS[0] == UInt2.MinValue;
            result &= TestData_RHS[1] == 1;
            result &= TestData_RHS[2] == 3;
            result &= TestData_RHS[3] == 3;
            result &= TestData_RHS[4] == 2;
            result &= TestData_RHS[5] == 1;
            result &= TestData_RHS[6] == 0;
            result &= TestData_RHS[7] == 2;
            result &= TestData_RHS[8] == 0;
            result &= TestData_RHS[9] == 3;
            result &= TestData_RHS[10] == 2;
            result &= TestData_RHS[11] == 2;
            result &= TestData_RHS[12] == 1;
            result &= TestData_RHS[13] == 3;
            result &= TestData_RHS[14] == 0;
            result &= TestData_RHS[15] == 2;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetSingle()
        {
            bool result = true;

            Random32 rng = new Random32(1937519u);

            for (int i = 0; i < 16; i++)
            {
                UInt2x16 test = TestData_LHS;
                uint randomInt = rng.NextUInt(0, UInt2.MaxValue + 1);
                test[i] = randomInt;

                result &= test[0]  == ((i == 0)  ? randomInt : TestData_LHS.x0);
                result &= test[1]  == ((i == 1)  ? randomInt : TestData_LHS.x1);
                result &= test[2]  == ((i == 2)  ? randomInt : TestData_LHS.x2);
                result &= test[3]  == ((i == 3)  ? randomInt : TestData_LHS.x3);
                result &= test[4]  == ((i == 4)  ? randomInt : TestData_LHS.x4);
                result &= test[5]  == ((i == 5)  ? randomInt : TestData_LHS.x5);
                result &= test[6]  == ((i == 6)  ? randomInt : TestData_LHS.x6);
                result &= test[7]  == ((i == 7)  ? randomInt : TestData_LHS.x7);
                result &= test[8]  == ((i == 8)  ? randomInt : TestData_LHS.x8);
                result &= test[9]  == ((i == 9)  ? randomInt : TestData_LHS.x9);
                result &= test[10] == ((i == 10) ? randomInt : TestData_LHS.x10);
                result &= test[11] == ((i == 11) ? randomInt : TestData_LHS.x11);
                result &= test[12] == ((i == 12) ? randomInt : TestData_LHS.x12);
                result &= test[13] == ((i == 13) ? randomInt : TestData_LHS.x13);
                result &= test[14] == ((i == 14) ? randomInt : TestData_LHS.x14);
                result &= test[15] == ((i == 15) ? randomInt : TestData_LHS.x15);
            }

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void ToFromUInt3x16()
        {
            UInt2x16 test = Random();
            UInt3x16 byte16test = test;

            for (int i = 0; i < 16; i++)
            {
                Assert.AreEqual(test[i], byte16test[i]);
            }

            test = (UInt2x16)byte16test;

            for (int i = 0; i < 16; i++)
            {
                Assert.AreEqual(test[i], byte16test[i]);
            }
        }

        [Test]
        public static void ToFromUInt4x16()
        {
            UInt2x16 test = Random();
            UInt4x16 byte16test = test;

            for (int i = 0; i < 16; i++)
            {
                Assert.AreEqual(test[i], byte16test[i]);
            }

            test = (UInt2x16)byte16test;

            for (int i = 0; i < 16; i++)
            {
                Assert.AreEqual(test[i], byte16test[i]);
            }
        }

        [Test]
        public static void ToFromByte16()
        {
            UInt2x16 test = Random();
            byte16 byte16test = test;

            for (int i = 0; i < 16; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)byte16test[i]);
            }

            test = (UInt2x16)byte16test;

            for (int i = 0; i < 16; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)byte16test[i]);
            }
        }

        [Test]
        public static void ToFromSByte16()
        {
            UInt2x16 test = Random();
            sbyte16 sbyte16test = test;

            for (int i = 0; i < 16; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)sbyte16test[i]);
            }

            test = (UInt2x16)sbyte16test;

            for (int i = 0; i < 16; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)sbyte16test[i]);
            }
        }

        [Test]
        public static void ToFromUShort16()
        {
            UInt2x16 test = Random();
            ushort16 ushort16test = test;

            for (int i = 0; i < 16; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)ushort16test[i]);
            }

            test = (UInt2x16)ushort16test;

            for (int i = 0; i < 16; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)ushort16test[i]);
            }
        }

        [Test]
        public static void ToFromShort16()
        {
            UInt2x16 test = Random();
            short16 short16test = test;

            for (int i = 0; i < 16; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)short16test[i]);
            }

            test = (UInt2x16)short16test;

            for (int i = 0; i < 16; i++)
            {
                Assert.AreEqual((uint)test[i], (uint)short16test[i]);
            }
        }

        [Test]
        public static void AddVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt2x16 l = Random();
                UInt2x16 r = Random();
                UInt2x16 add = l + r;

                for (int j = 0; j < 16; j++)
                {
                    Assert.AreEqual(add[j], (l[j] + r[j]) & maxmath.bitmask32((uint)default(UInt2).Bits));
                }
            }
        }

        [Test]
        public static void AddVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt2x16 l = Random();
                uint r = RandomUInt();
                UInt2x16 add = l + r;

                for (int j = 0; j < 16; j++)
                {
                    Assert.AreEqual(add[j], (l[j] + r) & maxmath.bitmask32((uint)default(UInt2).Bits));
                }
            }
        }

        [Test]
        public static void AddScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt2x16 r = Random();
                UInt2x16 add = l + r;

                for (int j = 0; j < 16; j++)
                {
                    Assert.AreEqual(add[j], (l + r[j]) & maxmath.bitmask32((uint)default(UInt2).Bits));
                }
            }
        }

        [Test]
        public static void SubVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt2x16 l = Random();
                UInt2x16 r = Random();
                UInt2x16 sub = l - r;

                for (int j = 0; j < 16; j++)
                {
                    Assert.AreEqual(sub[j], (l[j] - r[j]) & maxmath.bitmask32((uint)default(UInt2).Bits));
                }
            }
        }

        [Test]
        public static void SubVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt2x16 l = Random();
                uint r = RandomUInt();
                UInt2x16 sub = l - r;

                for (int j = 0; j < 16; j++)
                {
                    Assert.AreEqual(sub[j], (l[j] - r) & maxmath.bitmask32((uint)default(UInt2).Bits));
                }
            }
        }

        [Test]
        public static void SubScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt2x16 r = Random();
                UInt2x16 sub = l - r;
                
                for (int j = 0; j < 16; j++)
                {
                    Assert.AreEqual(sub[j], (l - r[j]) & maxmath.bitmask32((uint)default(UInt2).Bits));
                }
            }
        }

        [Test]
        public static void MulVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt2x16 l = Random();
                UInt2x16 r = Random();
                UInt2x16 mul = l * r;

                for (int j = 0; j < 16; j++)
                {
                    Assert.AreEqual(mul[j], (l[j] * r[j]) & maxmath.bitmask32((uint)default(UInt2).Bits));
                }
            }
        }

        [Test]
        public static void MulVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt2x16 l = Random();
                uint r = RandomUInt();
                UInt2x16 mul = l * r;

                for (int j = 0; j < 16; j++)
                {
                    Assert.AreEqual(mul[j], (l[j] * r) & maxmath.bitmask32((uint)default(UInt2).Bits));
                }
            }
        }

        [Test]
        public static void MulScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt2x16 r = Random();
                UInt2x16 mul = l * r;

                for (int j = 0; j < 16; j++)
                {
                    Assert.AreEqual(mul[j], (l * r[j]) & maxmath.bitmask32((uint)default(UInt2).Bits));
                }
            }
        }

        [Test]
        public static void DivVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt2x16 l = Random();
                UInt2x16 r = Random(min: 1);
                UInt2x16 div = l / r;

                for (int j = 0; j < 16; j++)
                {
                    Assert.AreEqual(div[j], (l[j] / r[j]) & maxmath.bitmask32((uint)default(UInt2).Bits));
                }
            }
        }

        [Test]
        public static void DivVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt2x16 l = Random();
                uint r = RandomUInt(min: 1);
                UInt2x16 div = l / r;

                for (int j = 0; j < 16; j++)
                {
                    Assert.AreEqual(div[j], (l[j] / r) & maxmath.bitmask32((uint)default(UInt2).Bits));
                }
            }
        }

        [Test]
        public static void DivScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt2x16 r = Random(min: 1);
                UInt2x16 div = l / r;

                for (int j = 0; j < 16; j++)
                {
                    Assert.AreEqual(div[j], (l / r[j]) & maxmath.bitmask32((uint)default(UInt2).Bits));
                }
            }
        }

        [Test]
        public static void ModVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt2x16 l = Random();
                UInt2x16 r = Random(min: 1);
                UInt2x16 mod = l % r;

                for (int j = 0; j < 16; j++)
                {
                    Assert.AreEqual(mod[j], (l[j] % r[j]) & maxmath.bitmask32((uint)default(UInt2).Bits));
                }
            }
        }

        [Test]
        public static void ModVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt2x16 l = Random();
                uint r = RandomUInt(min: 1);
                UInt2x16 mod = l % r;

                for (int j = 0; j < 16; j++)
                {
                    Assert.AreEqual(mod[j], (l[j] % r) & maxmath.bitmask32((uint)default(UInt2).Bits));
                }
            }
        }

        [Test]
        public static void ModScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt2x16 r = Random(min: 1);
                UInt2x16 mod = l % r;

                for (int j = 0; j < 16; j++)
                {
                    Assert.AreEqual(mod[j], (l % r[j]) & maxmath.bitmask32((uint)default(UInt2).Bits));
                }
            }
        }

        [Test]
        public static void AndVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt2x16 l = Random();
                UInt2x16 r = Random();
                UInt2x16 and = l & r;

                for (int j = 0; j < 16; j++)
                {
                    Assert.AreEqual(and[j], (l[j] & r[j]) & maxmath.bitmask32((uint)default(UInt2).Bits));
                }
            }
        }

        [Test]
        public static void AndVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt2x16 l = Random();
                uint r = RandomUInt();
                UInt2x16 and = l & r;

                for (int j = 0; j < 16; j++)
                {
                    Assert.AreEqual(and[j], (l[j] & r) & maxmath.bitmask32((uint)default(UInt2).Bits));
                }
            }
        }

        [Test]
        public static void AndScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt2x16 r = Random();
                UInt2x16 and = l & r;

                for (int j = 0; j < 16; j++)
                {
                    Assert.AreEqual(and[j], (l & r[j]) & maxmath.bitmask32((uint)default(UInt2).Bits));
                }
            }
        }

        [Test]
        public static void OrVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt2x16 l = Random();
                UInt2x16 r = Random();
                UInt2x16 or = l | r;

                for (int j = 0; j < 16; j++)
                {
                    Assert.AreEqual(or[j], (l[j] | r[j]) & maxmath.bitmask32((uint)default(UInt2).Bits));
                }
            }
        }

        [Test]
        public static void OrVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt2x16 l = Random();
                uint r = RandomUInt();
                UInt2x16 or = l | r;

                for (int j = 0; j < 16; j++)
                {
                    Assert.AreEqual(or[j], (l[j] | r) & maxmath.bitmask32((uint)default(UInt2).Bits));
                }
            }
        }

        [Test]
        public static void OrScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt2x16 r = Random();
                UInt2x16 or = l | r;

                for (int j = 0; j < 16; j++)
                {
                    Assert.AreEqual(or[j], (l | r[j]) & maxmath.bitmask32((uint)default(UInt2).Bits));
                }
            }
        }

        [Test]
        public static void XorVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt2x16 l = Random();
                UInt2x16 r = Random();
                UInt2x16 xor = l ^ r;

                for (int j = 0; j < 16; j++)
                {
                    Assert.AreEqual(xor[j], (l[j] ^ r[j]) & maxmath.bitmask32((uint)default(UInt2).Bits));
                }
            }
        }

        [Test]
        public static void XorVectorScalar()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt2x16 l = Random();
                uint r = RandomUInt();
                UInt2x16 xor = l ^ r;

                for (int j = 0; j < 16; j++)
                {
                    Assert.AreEqual(xor[j], (l[j] ^ r) & maxmath.bitmask32((uint)default(UInt2).Bits));
                }
            }
        }

        [Test]
        public static void XorScalarVector()
        {
            for (int i = 0; i < 64; i++)
            {
                uint l = RandomUInt();
                UInt2x16 r = Random();
                UInt2x16 xor = l ^ r;

                for (int j = 0; j < 16; j++)
                {
                    Assert.AreEqual(xor[j], (l ^ r[j]) & maxmath.bitmask32((uint)default(UInt2).Bits));
                }
            }
        }

        [Test]
        public static void EqualVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt2x16 l = Random();
                UInt2x16 r = Random();
                UInt2x16 equal = l == r;

                for (int j = 0; j < 16; j++)
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
                UInt2x16 l = Random();
                uint r = RandomUInt();
                UInt2x16 equal = l == r;

                for (int j = 0; j < 16; j++)
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
                UInt2x16 r = Random();
                UInt2x16 equal = l == r;

                for (int j = 0; j < 16; j++)
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
                UInt2x16 l = Random();
                UInt2x16 r = Random();
                UInt2x16 notEqual = l != r;

                for (int j = 0; j < 16; j++)
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
                UInt2x16 l = Random();
                uint r = RandomUInt();
                UInt2x16 notEqual = l != r;

                for (int j = 0; j < 16; j++)
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
                UInt2x16 r = Random();
                UInt2x16 notEqual = l != r;

                for (int j = 0; j < 16; j++)
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
                UInt2x16 l = Random();
                UInt2x16 r = Random();
                UInt2x16 less = l < r;

                for (int j = 0; j < 16; j++)
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
                UInt2x16 l = Random();
                uint r = RandomUInt();
                UInt2x16 less = l < r;

                for (int j = 0; j < 16; j++)
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
                UInt2x16 r = Random();
                UInt2x16 less = l < r;

                for (int j = 0; j < 16; j++)
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
                UInt2x16 l = Random();
                UInt2x16 r = Random();
                UInt2x16 greater = l > r;
                
                for (int j = 0; j < 16; j++)
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
                UInt2x16 l = Random();
                uint r = RandomUInt();
                UInt2x16 greater = l > r;

                for (int j = 0; j < 16; j++)
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
                UInt2x16 r = Random();
                UInt2x16 greater = l > r;

                for (int j = 0; j < 16; j++)
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
                UInt2x16 l = Random();
                UInt2x16 r = Random();
                UInt2x16 lessEqual = l <= r;
                
                for (int j = 0; j < 16; j++)
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
                UInt2x16 l = Random();
                uint r = RandomUInt();
                UInt2x16 lessEqual = l <= r;

                for (int j = 0; j < 16; j++)
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
                UInt2x16 r = Random();
                UInt2x16 lessEqual = l <= r;

                for (int j = 0; j < 16; j++)
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
                UInt2x16 l = Random();
                UInt2x16 r = Random();
                UInt2x16 greaterEqual = l >= r;

                for (int j = 0; j < 16; j++)
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
                UInt2x16 l = Random();
                uint r = RandomUInt();
                UInt2x16 greaterEqual = l >= r;

                for (int j = 0; j < 16; j++)
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
                UInt2x16 r = Random();
                UInt2x16 greaterEqual = l >= r;

                for (int j = 0; j < 16; j++)
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
                UInt2x16 x = Random();
                UInt2x16 not = ~x;

                for (int j = 0; j < 16; j++)
                {
                    Assert.AreEqual(not[j], (~x[j]) & maxmath.bitmask32((uint)default(UInt2).Bits));
                }
            }
        }

        [Test]
        public static void ShiftLeft()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt2x16 x = Random();
                int n = (int)RandomUInt(0, default(UInt2).Bits);
                UInt2x16 shiftLeft = x << n;

                for (int j = 0; j < 16; j++)
                {
                    Assert.AreEqual(shiftLeft[j], (x[j] << n) & maxmath.bitmask32((uint)default(UInt2).Bits));
                }
            }
        }

        [Test]
        public static void ShiftRight()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt2x16 x = Random();
                int n = (int)RandomUInt(0, default(UInt2).Bits);
                UInt2x16 shiftRight = x >> n;

                for (int j = 0; j < 16; j++)
                {
                    Assert.AreEqual(shiftRight[j], (x[j] >> n) & maxmath.bitmask32((uint)default(UInt2).Bits));
                }
            }
        }
    }
}