using NUnit.Framework;
using MaxMath;
using Unity.Mathematics;

namespace BitCollections.Tests
{
    internal static class _UInt2x28
    {
        internal static UInt2x28 TestData_LHS => new UInt2x28(UInt2.MaxValue, 1, 2, 0, 0, 1, 3, 0, 3, 3, 1, 0, 2, 3, 1, 2, 3, 3, 3, 0, 2, 1, 2, 0, 3, 1, 2, 0);
        internal static UInt2x28 TestData_RHS => new UInt2x28(UInt2.MinValue, 1, 3, 3, 2, 1, 0, 2, 0, 3, 2, 2, 1, 3, 0, 2, 2, 1, 1, 1, 0, 2, 3, 0, 1, 0, 2, 3);
        
        private static UInt2x28 Random(byte min = 0, byte max = 0)
        {
            Random8 rng = Random8.New;

            UInt2x28 test = new UInt2x28();
            for (int i = 0; i < 28; i++)
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

            UInt2x28 test = new UInt2x28(2);
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
            result &= test.x16 == 2;
            result &= test.x17 == 2;
            result &= test.x18 == 2;
            result &= test.x19 == 2;
            result &= test.x20 == 2;
            result &= test.x21 == 2;
            result &= test.x22 == 2;
            result &= test.x23 == 2;
            result &= test.x24 == 2;
            result &= test.x25 == 2;
            result &= test.x26 == 2;
            result &= test.x27 == 2;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void Constructor_uintx28()
        {
            bool result = true;

            UInt2x28 test = new UInt2x28(1, 0, 0, 2, 3, 1, 0, 2, 3, 1, 2, 0, 1, 0, 3, 2, 3, 0, 1, 2, 2, 1, 0, 3, 3, 3, 1, 2);

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
            result &= test.x16 == 3;
            result &= test.x17 == 0;
            result &= test.x18 == 1;
            result &= test.x19 == 2;
            result &= test.x20 == 2;
            result &= test.x21 == 1;
            result &= test.x22 == 0;
            result &= test.x23 == 3;
            result &= test.x24 == 3;
            result &= test.x25 == 3;
            result &= test.x26 == 1;
            result &= test.x27 == 2;

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
            result &= TestData_LHS[16] == 3;
            result &= TestData_LHS[17] == 3;
            result &= TestData_LHS[18] == 3;
            result &= TestData_LHS[19] == 0;
            result &= TestData_LHS[20] == 2;
            result &= TestData_LHS[21] == 1;
            result &= TestData_LHS[22] == 2;
            result &= TestData_LHS[23] == 0;
            result &= TestData_LHS[24] == 3;
            result &= TestData_LHS[25] == 1;
            result &= TestData_LHS[26] == 2;
            result &= TestData_LHS[27] == 0;

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
            result &= TestData_RHS[16] == 2;
            result &= TestData_RHS[17] == 1;
            result &= TestData_RHS[18] == 1;
            result &= TestData_RHS[19] == 1;
            result &= TestData_RHS[20] == 0;
            result &= TestData_RHS[21] == 2;
            result &= TestData_RHS[22] == 3;
            result &= TestData_RHS[23] == 0;
            result &= TestData_RHS[24] == 1;
            result &= TestData_RHS[25] == 0;
            result &= TestData_RHS[26] == 2;
            result &= TestData_RHS[27] == 3;

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void SetSingle()
        {
            bool result = true;

            Random32 rng = new Random32(1937519u);

            for (int i = 0; i < 28; i++)
            {
                UInt2x28 test = TestData_LHS;
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
                result &= test[16] == ((i == 16) ? randomInt : TestData_LHS.x16);
                result &= test[17] == ((i == 17) ? randomInt : TestData_LHS.x17);
                result &= test[18] == ((i == 18) ? randomInt : TestData_LHS.x18);
                result &= test[19] == ((i == 19) ? randomInt : TestData_LHS.x19);
                result &= test[20] == ((i == 20) ? randomInt : TestData_LHS.x20);
                result &= test[21] == ((i == 21) ? randomInt : TestData_LHS.x21);
                result &= test[22] == ((i == 22) ? randomInt : TestData_LHS.x22);
                result &= test[23] == ((i == 23) ? randomInt : TestData_LHS.x23);
                result &= test[24] == ((i == 24) ? randomInt : TestData_LHS.x24);
                result &= test[25] == ((i == 25) ? randomInt : TestData_LHS.x25);
                result &= test[26] == ((i == 26) ? randomInt : TestData_LHS.x26);
                result &= test[27] == ((i == 27) ? randomInt : TestData_LHS.x27);
            }

            Assert.AreEqual(result, true);
        }

        [Test]
        public static void AddVectorVector()
        {
            for (int i = 0; i < 64; i++)
            {
                UInt2x28 l = Random();
                UInt2x28 r = Random();
                UInt2x28 add = l + r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 l = Random();
                uint r = RandomUInt();
                UInt2x28 add = l + r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 r = Random();
                UInt2x28 add = l + r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 l = Random();
                UInt2x28 r = Random();
                UInt2x28 sub = l - r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 l = Random();
                uint r = RandomUInt();
                UInt2x28 sub = l - r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 r = Random();
                UInt2x28 sub = l - r;
                
                for (int j = 0; j < 28; j++)
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
                UInt2x28 l = Random();
                UInt2x28 r = Random();
                UInt2x28 mul = l * r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 l = Random();
                uint r = RandomUInt();
                UInt2x28 mul = l * r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 r = Random();
                UInt2x28 mul = l * r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 l = Random();
                UInt2x28 r = Random(min: 1);
                UInt2x28 div = l / r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 l = Random();
                uint r = RandomUInt(min: 1);
                UInt2x28 div = l / r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 r = Random(min: 1);
                UInt2x28 div = l / r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 l = Random();
                UInt2x28 r = Random(min: 1);
                UInt2x28 mod = l % r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 l = Random();
                uint r = RandomUInt(min: 1);
                UInt2x28 mod = l % r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 r = Random(min: 1);
                UInt2x28 mod = l % r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 l = Random();
                UInt2x28 r = Random();
                UInt2x28 and = l & r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 l = Random();
                uint r = RandomUInt();
                UInt2x28 and = l & r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 r = Random();
                UInt2x28 and = l & r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 l = Random();
                UInt2x28 r = Random();
                UInt2x28 or = l | r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 l = Random();
                uint r = RandomUInt();
                UInt2x28 or = l | r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 r = Random();
                UInt2x28 or = l | r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 l = Random();
                UInt2x28 r = Random();
                UInt2x28 xor = l ^ r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 l = Random();
                uint r = RandomUInt();
                UInt2x28 xor = l ^ r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 r = Random();
                UInt2x28 xor = l ^ r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 l = Random();
                UInt2x28 r = Random();
                UInt2x28 equal = l == r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 l = Random();
                uint r = RandomUInt();
                UInt2x28 equal = l == r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 r = Random();
                UInt2x28 equal = l == r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 l = Random();
                UInt2x28 r = Random();
                UInt2x28 notEqual = l != r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 l = Random();
                uint r = RandomUInt();
                UInt2x28 notEqual = l != r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 r = Random();
                UInt2x28 notEqual = l != r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 l = Random();
                UInt2x28 r = Random();
                UInt2x28 less = l < r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 l = Random();
                uint r = RandomUInt();
                UInt2x28 less = l < r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 r = Random();
                UInt2x28 less = l < r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 l = Random();
                UInt2x28 r = Random();
                UInt2x28 greater = l > r;
                
                for (int j = 0; j < 28; j++)
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
                UInt2x28 l = Random();
                uint r = RandomUInt();
                UInt2x28 greater = l > r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 r = Random();
                UInt2x28 greater = l > r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 l = Random();
                UInt2x28 r = Random();
                UInt2x28 lessEqual = l <= r;
                
                for (int j = 0; j < 28; j++)
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
                UInt2x28 l = Random();
                uint r = RandomUInt();
                UInt2x28 lessEqual = l <= r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 r = Random();
                UInt2x28 lessEqual = l <= r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 l = Random();
                UInt2x28 r = Random();
                UInt2x28 greaterEqual = l >= r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 l = Random();
                uint r = RandomUInt();
                UInt2x28 greaterEqual = l >= r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 r = Random();
                UInt2x28 greaterEqual = l >= r;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 x = Random();
                UInt2x28 not = ~x;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 x = Random();
                int n = (int)RandomUInt(0, default(UInt2).Bits);
                UInt2x28 shiftLeft = x << n;

                for (int j = 0; j < 28; j++)
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
                UInt2x28 x = Random();
                int n = (int)RandomUInt(0, default(UInt2).Bits);
                UInt2x28 shiftRight = x >> n;

                for (int j = 0; j < 28; j++)
                {
                    Assert.AreEqual(shiftRight[j], (x[j] >> n) & maxmath.bitmask32((uint)default(UInt2).Bits));
                }
            }
        }
    }
}