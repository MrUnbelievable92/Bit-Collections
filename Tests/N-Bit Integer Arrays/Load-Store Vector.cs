using NUnit.Framework;
using Unity.Collections;
using MaxMath;
using Unity.Mathematics;

using static MaxMath.maxmath;
using static Unity.Mathematics.math;

namespace BitCollections.Tests
{
    public static class Load_Store_Vector
    {
        public static string GenerateLoadTests()
        {
            string result = string.Empty;
            foreach (Vector vector in Vector.AllVectorTypes)
            {
                long minValue = vector.Signed ? -(1L << (vector.Bits - 1)) : 0;
                long maxValue = (vector.Bits == 64 && !vector.Signed) ? long.MaxValue : (vector.Signed ? (1L << (vector.Bits - 1)) - 1 : (1L << vector.Bits) - 1);
                string randomVectorRange = $"max({minValue}, default(BitIntMock).MinValueAsLong), min({maxValue}, default(BitIntMock).MaxValueAsLong)";
				if (vector.Bits < 64)
				{
					randomVectorRange += " + 1";
				}
                string componentCastFromLong;
                if (vector.Bits > 32)
                {
                    componentCastFromLong = vector.Signed ? string.Empty : "(ulong)";
                }
                else if (vector.Bits > 16)
                {
                    componentCastFromLong = vector.Signed ? "(int)" : "(uint)";
                }
                else if (vector.Bits > 8)
                {
                    componentCastFromLong = vector.Signed ? "(short)" : "(ushort)";
                }
                else
                {
                    componentCastFromLong = vector.Signed ? "(sbyte)" : "(byte)";
                }
                string randomVectorComponent = $"{componentCastFromLong}rng.NextLong({randomVectorRange})";
				if (vector.Bits == 1)
				{
					randomVectorComponent = "tobool(" + randomVectorComponent + ")";
				}
				string loadElement0 = "vec[j - randomIndex]";
				if (vector.Bits == 1)
				{
					loadElement0 = "toulong(" + loadElement0 + ")";
				}
                string bitmaskCast = vector.Signed ? "(long)" : "(ulong)";
                string bitmask = $" & bitmask64({bitmaskCast}{vector.Bits})";
				string loadElement1= loadElement0 + bitmask;
				if (vector.Signed)
				{
					loadElement0 = "signextend(" + loadElement0 + $", {vector.Bits})";
					loadElement1 = "signextend(" + loadElement1 + $", {vector.Bits})";
				}

                result += $"\t\t[Test]\r\n"
                        + $"\t\tpublic static void Load_{vector.Name}()\r\n"
                        + $"\t\t{{\r\n"
                        + $"\t\t\tBitIntMock.ForEachBitInt\r\n"
                        + $"\t\t\t(\r\n"
                        + $"\t\t\t\t(rng) =>\r\n"
                        + $"\t\t\t\t{{\r\n"
                        + $"\t\t\t\t\tfor (int i = 0; i < 4; i++)\r\n"
                        + $"\t\t\t\t\t{{\r\n"
                        + $"\t\t\t\t\t\tint length = (int)rng.NextLong({vector.Elements}, 200);\r\n"
                        + $"\t\t\t\t\t\t\r\n"
                        + $"\t\t\t\t\t\tCreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, {minValue}, {maxValue});\r\n"
                        + $"\t\t\t\t\t\t\r\n"
                        + $"\t\t\t\t\t\tint randomIndex = (int)rng.NextLong(0, length - {vector.Elements});\r\n"
                        + $"\t\t\t\t\t\t{vector.Name} vec = mutate.LoadVector<{vector.Name}>(randomIndex);\r\n"
                        + $"\t\t\t\t\t\t\r\n"
                        + $"\t\t\t\t\t\tfor (int j = 0; j < length; j++)\r\n"
                        + $"\t\t\t\t\t\t{{\r\n"
                        + $"\t\t\t\t\t\t\tif (j < randomIndex\r\n"
                        + $"\t\t\t\t\t\t\t || j >= randomIndex + {vector.Elements})\r\n"
                        + $"\t\t\t\t\t\t\t{{\r\n"
                        + $"\t\t\t\t\t\t\t\tAssert.AreEqual(mutate[j], compare[j]);\r\n"
                        + $"\t\t\t\t\t\t\t}}\r\n"
                        + $"\t\t\t\t\t\t\telse\r\n"
                        + $"\t\t\t\t\t\t\t{{\r\n"
                        + $"\t\t\t\t\t\t\t\tif (default(BitIntMock).Bits >= {vector.Bits})\r\n"
                        + $"\t\t\t\t\t\t\t\t{{\r\n"
                        + $"\t\t\t\t\t\t\t\t\tAssert.AreEqual(mutate[j], {loadElement0});\r\n"
                        + $"\t\t\t\t\t\t\t\t}}\r\n"
                        + $"\t\t\t\t\t\t\t\telse\r\n"
                        + $"\t\t\t\t\t\t\t\t{{\r\n"
                        + $"\t\t\t\t\t\t\t\t\tAssert.AreEqual(mutate[j], {loadElement1});\r\n"
                        + $"\t\t\t\t\t\t\t\t}}\r\n"
                        + $"\t\t\t\t\t\t\t}}\r\n"
                        + $"\t\t\t\t\t\t}}\r\n"
                        + $"\t\t\t\t\t\t\r\n"
                        + $"\t\t\t\t\t\tmutate.Dispose(default);\r\n"
                        + $"\t\t\t\t\t\tcompare.Dispose(default);\r\n"
                        + $"\t\t\t\t\t}}\r\n"
                        + $"\t\t\t\t}}\r\n"
                        + $"\t\t\t);\r\n"
                        + $"\t\t}}\r\n"
                        + $"\r\n";
            }

            return result;
        }
        public static string GenerateStoreTests()
        {
            string result = string.Empty;
            foreach (Vector vector in Vector.AllVectorTypes)
            {
                long minValue = vector.Signed ? -(1L << (vector.Bits - 1)) : 0;
                long maxValue = (vector.Bits == 64 && !vector.Signed) ? long.MaxValue : (vector.Signed ? (1L << (vector.Bits - 1)) - 1 : (1L << vector.Bits) - 1);
                string randomVectorRange = $"max({minValue}, default(BitIntMock).MinValueAsLong), min({maxValue}, default(BitIntMock).MaxValueAsLong)";
				if (vector.Bits < 64)
				{
					randomVectorRange += " + 1";
				}
                string componentCastFromLong;
                if (vector.Bits > 32)
                {
                    componentCastFromLong = vector.Signed ? string.Empty : "(ulong)";
                }
                else if (vector.Bits > 16)
                {
                    componentCastFromLong = vector.Signed ? "(int)" : "(uint)";
                }
                else if (vector.Bits > 8)
                {
                    componentCastFromLong = vector.Signed ? "(short)" : "(ushort)";
                }
                else
                {
                    componentCastFromLong = vector.Signed ? "(sbyte)" : "(byte)";
                }
                string randomVectorComponent = $"{componentCastFromLong}rng.NextLong({randomVectorRange})";
				if (vector.Bits == 1)
				{
					randomVectorComponent = "tobool(" + randomVectorComponent + ")";
				}
				string loadElement0 = "rngVec[j - randomIndex]";
				if (vector.Bits == 1)
				{
					loadElement0 = "toulong(" + loadElement0 + ")";
				}
                string bitmaskCast = vector.Signed ? "(long)" : "(ulong)";
                string bitmask = $" & bitmask64({bitmaskCast}{vector.Bits})";
				string loadElement1= loadElement0 + bitmask;
				if (vector.Signed)
				{
					loadElement0 = "signextend(" + loadElement0 + $", {vector.Bits})";
					loadElement1 = "signextend(" + loadElement1 + $", {vector.Bits})";
				}

                result += $"\t\t[Test]\r\n"
                        + $"\t\tpublic static void Store_{vector.Name}()\r\n"
                        + $"\t\t{{\r\n"
                        + $"\t\t\tBitIntMock.ForEachBitInt\r\n"
                        + $"\t\t\t(\r\n"
                        + $"\t\t\t\t(rng) =>\r\n"
                        + $"\t\t\t\t{{\r\n"
                        + $"\t\t\t\t\tfor (int i = 0; i < 4; i++)\r\n"
                        + $"\t\t\t\t\t{{\r\n"
                        + $"\t\t\t\t\t\tint length = (int)rng.NextLong({vector.Elements}, 200);\r\n"
                        + $"\t\t\t\t\t\t\r\n"
                        + $"\t\t\t\t\t\tCreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);\r\n"
                        + $"\t\t\t\t\t\t{vector.Name} rngVec = default;\r\n"
                        + $"\t\t\t\t\t\tfor (int j = 0; j < {vector.Elements}; j++)\r\n"
                        + $"\t\t\t\t\t\t{{\r\n"
                        + $"\t\t\t\t\t\t\trngVec[j] = {randomVectorComponent};\r\n"
                        + $"\t\t\t\t\t\t}}\r\n"
                        + $"\t\t\t\t\t\t\r\n"
                        + $"\t\t\t\t\t\tint randomIndex = (int)rng.NextLong(0, length - {vector.Elements});\r\n"
                        + $"\t\t\t\t\t\tmutate.StoreVector<{vector.Name}>(rngVec, randomIndex);\r\n"
                        + $"\t\t\t\t\t\t\r\n"
                        + $"\t\t\t\t\t\tfor (int j = 0; j < length; j++)\r\n"
                        + $"\t\t\t\t\t\t{{\r\n"
                        + $"\t\t\t\t\t\t\tif (j < randomIndex\r\n"
                        + $"\t\t\t\t\t\t\t || j >= randomIndex + {vector.Elements})\r\n"
                        + $"\t\t\t\t\t\t\t{{\r\n"
                        + $"\t\t\t\t\t\t\t\tAssert.AreEqual(mutate[j], compare[j]);\r\n"
                        + $"\t\t\t\t\t\t\t}}\r\n"
                        + $"\t\t\t\t\t\t\telse\r\n"
                        + $"\t\t\t\t\t\t\t{{\r\n"
                        + $"\t\t\t\t\t\t\t\tif (default(BitIntMock).Bits >= {vector.Bits})\r\n"
                        + $"\t\t\t\t\t\t\t\t{{\r\n"
                        + $"\t\t\t\t\t\t\t\t\tAssert.AreEqual(mutate[j], {loadElement0});\r\n"
                        + $"\t\t\t\t\t\t\t\t}}\r\n"
                        + $"\t\t\t\t\t\t\t\telse\r\n"
                        + $"\t\t\t\t\t\t\t\t{{\r\n"
                        + $"\t\t\t\t\t\t\t\t\tAssert.AreEqual(mutate[j], {loadElement1});\r\n"
                        + $"\t\t\t\t\t\t\t\t}}\r\n"
                        + $"\t\t\t\t\t\t\t}}\r\n"
                        + $"\t\t\t\t\t\t}}\r\n"
                        + $"\t\t\t\t\t\t\r\n"
                        + $"\t\t\t\t\t\tmutate.Dispose(default);\r\n"
                        + $"\t\t\t\t\t\tcompare.Dispose(default);\r\n"
                        + $"\t\t\t\t\t}}\r\n"
                        + $"\t\t\t\t}}\r\n"
                        + $"\t\t\t);\r\n"
                        + $"\t\t}}\r\n"
                        + $"\r\n";
            }

            return result;
        }

        private static void CreateRandomBitIntMockLists<T>(int length, ref Random64 rng, out NativeBitIntList<T> a, out NativeBitIntList<T> b, long min = long.MinValue, long max = long.MaxValue)
            where T : unmanaged, BitInt
        {
            a = new NativeBitIntList<T>(length, Allocator.Persistent);
            b = new NativeBitIntList<T>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
				long next;
				if (min == long.MinValue && max == long.MaxValue)
				{
					next = rng.NextLong(default(T).MinValueAsLong, default(T).MaxValueAsLong + (default(T).Bits == 63 ? 0 : 1));
				}
				else
				{
					next = rng.NextLong(math.max(default(T).MinValueAsLong, min), math.min(default(T).MaxValueAsLong + (default(T).Bits == 63 ? 0 : 1), max));
				}
                a.Add(next);
                b.Add(next);
            }
        }

		[Test]
		public static void Load_bit8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 1);
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						bit8 vec = mutate.LoadVector<bit8>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 1)
								{
									Assert.AreEqual(mutate[j], toulong(vec[j - randomIndex]));
								}
								else
								{
									Assert.AreEqual(mutate[j], toulong(vec[j - randomIndex]) & bitmask64((ulong)1));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_bit16()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(16, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 1);
						
						int randomIndex = (int)rng.NextLong(0, length - 16);
						bit16 vec = mutate.LoadVector<bit16>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 16)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 1)
								{
									Assert.AreEqual(mutate[j], toulong(vec[j - randomIndex]));
								}
								else
								{
									Assert.AreEqual(mutate[j], toulong(vec[j - randomIndex]) & bitmask64((ulong)1));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_bit24()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(24, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 1);
						
						int randomIndex = (int)rng.NextLong(0, length - 24);
						bit24 vec = mutate.LoadVector<bit24>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 24)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 1)
								{
									Assert.AreEqual(mutate[j], toulong(vec[j - randomIndex]));
								}
								else
								{
									Assert.AreEqual(mutate[j], toulong(vec[j - randomIndex]) & bitmask64((ulong)1));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_bit32()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(32, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 1);
						
						int randomIndex = (int)rng.NextLong(0, length - 32);
						bit32 vec = mutate.LoadVector<bit32>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 32)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 1)
								{
									Assert.AreEqual(mutate[j], toulong(vec[j - randomIndex]));
								}
								else
								{
									Assert.AreEqual(mutate[j], toulong(vec[j - randomIndex]) & bitmask64((ulong)1));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_bit40()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(40, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 1);
						
						int randomIndex = (int)rng.NextLong(0, length - 40);
						bit40 vec = mutate.LoadVector<bit40>(randomIndex);

						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 40)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 1)
								{
									Assert.AreEqual(mutate[j], toulong(vec[j - randomIndex]));
								}
								else
								{
									Assert.AreEqual(mutate[j], toulong(vec[j - randomIndex]) & bitmask64((ulong)1));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_bit48()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(48, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 1);
						
						int randomIndex = (int)rng.NextLong(0, length - 48);
						bit48 vec = mutate.LoadVector<bit48>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 48)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 1)
								{
									Assert.AreEqual(mutate[j], toulong(vec[j - randomIndex]));
								}
								else
								{
									Assert.AreEqual(mutate[j], toulong(vec[j - randomIndex]) & bitmask64((ulong)1));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_bit56()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(56, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 1);
						
						int randomIndex = (int)rng.NextLong(0, length - 56);
						bit56 vec = mutate.LoadVector<bit56>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 56)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 1)
								{
									Assert.AreEqual(mutate[j], toulong(vec[j - randomIndex]));
								}
								else
								{
									Assert.AreEqual(mutate[j], toulong(vec[j - randomIndex]) & bitmask64((ulong)1));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_bit64()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(64, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 1);
						
						int randomIndex = (int)rng.NextLong(0, length - 64);
						bit64 vec = mutate.LoadVector<bit64>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 64)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 1)
								{
									Assert.AreEqual(mutate[j], toulong(vec[j - randomIndex]));
								}
								else
								{
									Assert.AreEqual(mutate[j], toulong(vec[j - randomIndex]) & bitmask64((ulong)1));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_Int2x4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -2, 1);
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						Int2x4 vec = mutate.LoadVector<Int2x4>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 2)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 2));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)2), 2));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_Int2x8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -2, 1);
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						Int2x8 vec = mutate.LoadVector<Int2x8>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 2)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 2));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)2), 2));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_Int2x12()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(12, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -2, 1);
						
						int randomIndex = (int)rng.NextLong(0, length - 12);
						Int2x12 vec = mutate.LoadVector<Int2x12>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 12)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 2)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 2));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)2), 2));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_Int2x16()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(16, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -2, 1);
						
						int randomIndex = (int)rng.NextLong(0, length - 16);
						Int2x16 vec = mutate.LoadVector<Int2x16>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 16)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 2)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 2));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)2), 2));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_Int2x20()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(20, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -2, 1);
						
						int randomIndex = (int)rng.NextLong(0, length - 20);
						Int2x20 vec = mutate.LoadVector<Int2x20>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 20)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 2)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 2));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)2), 2));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_Int2x24()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(24, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -2, 1);
						
						int randomIndex = (int)rng.NextLong(0, length - 24);
						Int2x24 vec = mutate.LoadVector<Int2x24>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 24)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 2)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 2));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)2), 2));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_Int2x28()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(28, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -2, 1);
						
						int randomIndex = (int)rng.NextLong(0, length - 28);
						Int2x28 vec = mutate.LoadVector<Int2x28>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 28)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 2)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 2));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)2), 2));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_Int2x32()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(32, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -2, 1);
						
						int randomIndex = (int)rng.NextLong(0, length - 32);
						Int2x32 vec = mutate.LoadVector<Int2x32>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 32)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 2)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 2));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)2), 2));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_UInt2x4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 3);
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						UInt2x4 vec = mutate.LoadVector<UInt2x4>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 2)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)2));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_UInt2x8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 3);
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						UInt2x8 vec = mutate.LoadVector<UInt2x8>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 2)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)2));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_UInt2x12()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(12, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 3);
						
						int randomIndex = (int)rng.NextLong(0, length - 12);
						UInt2x12 vec = mutate.LoadVector<UInt2x12>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 12)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 2)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)2));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_UInt2x16()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(16, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 3);
						
						int randomIndex = (int)rng.NextLong(0, length - 16);
						UInt2x16 vec = mutate.LoadVector<UInt2x16>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 16)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 2)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)2));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_UInt2x20()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(20, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 3);
						
						int randomIndex = (int)rng.NextLong(0, length - 20);
						UInt2x20 vec = mutate.LoadVector<UInt2x20>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 20)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 2)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)2));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_UInt2x24()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(24, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 3);
						
						int randomIndex = (int)rng.NextLong(0, length - 24);
						UInt2x24 vec = mutate.LoadVector<UInt2x24>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 24)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 2)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)2));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_UInt2x28()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(28, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 3);
						
						int randomIndex = (int)rng.NextLong(0, length - 28);
						UInt2x28 vec = mutate.LoadVector<UInt2x28>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 28)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 2)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)2));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_UInt2x32()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(32, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 3);
						
						int randomIndex = (int)rng.NextLong(0, length - 32);
						UInt2x32 vec = mutate.LoadVector<UInt2x32>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 32)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 2)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)2));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_Int3x8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -4, 3);
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						Int3x8 vec = mutate.LoadVector<Int3x8>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 3)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 3));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)3), 3));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_Int3x16()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(16, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -4, 3);
						
						int randomIndex = (int)rng.NextLong(0, length - 16);
						Int3x16 vec = mutate.LoadVector<Int3x16>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 16)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 3)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 3));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)3), 3));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_UInt3x8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 7);
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						UInt3x8 vec = mutate.LoadVector<UInt3x8>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 3)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)3));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_UInt3x16()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(16, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 7);
						
						int randomIndex = (int)rng.NextLong(0, length - 16);
						UInt3x16 vec = mutate.LoadVector<UInt3x16>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 16)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 3)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)3));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_Int4x2()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(2, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -8, 7);
						
						int randomIndex = (int)rng.NextLong(0, length - 2);
						Int4x2 vec = mutate.LoadVector<Int4x2>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 2)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 4)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 4));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)4), 4));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_Int4x4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -8, 7);
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						Int4x4 vec = mutate.LoadVector<Int4x4>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 4)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 4));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)4), 4));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_Int4x6()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(6, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -8, 7);
						
						int randomIndex = (int)rng.NextLong(0, length - 6);
						Int4x6 vec = mutate.LoadVector<Int4x6>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 6)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 4)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 4));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)4), 4));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_Int4x8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -8, 7);
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						Int4x8 vec = mutate.LoadVector<Int4x8>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 4)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 4));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)4), 4));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_Int4x10()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(10, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -8, 7);
						
						int randomIndex = (int)rng.NextLong(0, length - 10);
						Int4x10 vec = mutate.LoadVector<Int4x10>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 10)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 4)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 4));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)4), 4));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_Int4x12()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(12, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -8, 7);
						
						int randomIndex = (int)rng.NextLong(0, length - 12);
						Int4x12 vec = mutate.LoadVector<Int4x12>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 12)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 4)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 4));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)4), 4));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_Int4x14()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(14, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -8, 7);
						
						int randomIndex = (int)rng.NextLong(0, length - 14);
						Int4x14 vec = mutate.LoadVector<Int4x14>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 14)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 4)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 4));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)4), 4));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_Int4x16()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(16, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -8, 7);
						
						int randomIndex = (int)rng.NextLong(0, length - 16);
						Int4x16 vec = mutate.LoadVector<Int4x16>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 16)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 4)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 4));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)4), 4));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_UInt4x2()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(2, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 15);
						
						int randomIndex = (int)rng.NextLong(0, length - 2);
						UInt4x2 vec = mutate.LoadVector<UInt4x2>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 2)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 4)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)4));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_UInt4x4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 15);
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						UInt4x4 vec = mutate.LoadVector<UInt4x4>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 4)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)4));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_UInt4x6()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(6, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 15);
						
						int randomIndex = (int)rng.NextLong(0, length - 6);
						UInt4x6 vec = mutate.LoadVector<UInt4x6>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 6)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 4)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)4));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_UInt4x8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 15);
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						UInt4x8 vec = mutate.LoadVector<UInt4x8>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 4)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)4));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_UInt4x10()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(10, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 15);
						
						int randomIndex = (int)rng.NextLong(0, length - 10);
						UInt4x10 vec = mutate.LoadVector<UInt4x10>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 10)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 4)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)4));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_UInt4x12()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(12, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 15);
						
						int randomIndex = (int)rng.NextLong(0, length - 12);
						UInt4x12 vec = mutate.LoadVector<UInt4x12>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 12)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 4)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)4));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_UInt4x14()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(14, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 15);
						
						int randomIndex = (int)rng.NextLong(0, length - 14);
						UInt4x14 vec = mutate.LoadVector<UInt4x14>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 14)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 4)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)4));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_UInt4x16()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(16, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 15);
						
						int randomIndex = (int)rng.NextLong(0, length - 16);
						UInt4x16 vec = mutate.LoadVector<UInt4x16>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 16)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 4)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)4));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_Int5x8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -16, 15);
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						Int5x8 vec = mutate.LoadVector<Int5x8>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 5)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 5));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)5), 5));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_UInt5x8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 31);
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						UInt5x8 vec = mutate.LoadVector<UInt5x8>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 5)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)5));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_Int6x4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -32, 31);
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						Int6x4 vec = mutate.LoadVector<Int6x4>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 6)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 6));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)6), 6));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_Int6x8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -32, 31);
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						Int6x8 vec = mutate.LoadVector<Int6x8>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 6)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 6));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)6), 6));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_UInt6x4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 63);
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						UInt6x4 vec = mutate.LoadVector<UInt6x4>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 6)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)6));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_UInt6x8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 63);
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						UInt6x8 vec = mutate.LoadVector<UInt6x8>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 6)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)6));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_Int7x8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -64, 63);
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						Int7x8 vec = mutate.LoadVector<Int7x8>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 7)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 7));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)7), 7));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_UInt7x8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 127);
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						UInt7x8 vec = mutate.LoadVector<UInt7x8>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 7)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)7));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_Int10x4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -512, 511);
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						Int10x4 vec = mutate.LoadVector<Int10x4>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 10)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 10));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)10), 10));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_UInt10x4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 1023);
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						UInt10x4 vec = mutate.LoadVector<UInt10x4>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 10)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)10));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_Int12x2()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(2, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -2048, 2047);
						
						int randomIndex = (int)rng.NextLong(0, length - 2);
						Int12x2 vec = mutate.LoadVector<Int12x2>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 2)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 12)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 12));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)12), 12));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_Int12x4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -2048, 2047);
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						Int12x4 vec = mutate.LoadVector<Int12x4>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 12)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 12));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)12), 12));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_UInt12x2()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(2, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 4095);
						
						int randomIndex = (int)rng.NextLong(0, length - 2);
						UInt12x2 vec = mutate.LoadVector<UInt12x2>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 2)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 12)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)12));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_UInt12x4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 4095);
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						UInt12x4 vec = mutate.LoadVector<UInt12x4>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 12)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)12));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_Int14x4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -8192, 8191);
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						Int14x4 vec = mutate.LoadVector<Int14x4>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 14)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 14));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)14), 14));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_UInt14x4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 16383);
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						UInt14x4 vec = mutate.LoadVector<UInt14x4>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 14)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)14));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_Int20x2()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(2, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -524288, 524287);
						
						int randomIndex = (int)rng.NextLong(0, length - 2);
						Int20x2 vec = mutate.LoadVector<Int20x2>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 2)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 20)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 20));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)20), 20));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_UInt20x2()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(2, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 1048575);
						
						int randomIndex = (int)rng.NextLong(0, length - 2);
						UInt20x2 vec = mutate.LoadVector<UInt20x2>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 2)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 20)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)20));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_Int28x2()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(2, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -134217728, 134217727);
						
						int randomIndex = (int)rng.NextLong(0, length - 2);
						Int28x2 vec = mutate.LoadVector<Int28x2>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 2)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 28)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 28));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)28), 28));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_UInt28x2()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(2, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 268435455);
						
						int randomIndex = (int)rng.NextLong(0, length - 2);
						UInt28x2 vec = mutate.LoadVector<UInt28x2>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 2)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 28)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)28));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_sbyte2()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(2, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -128, 127);
						
						int randomIndex = (int)rng.NextLong(0, length - 2);
						sbyte2 vec = mutate.LoadVector<sbyte2>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 2)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 8)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 8));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)8), 8));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_sbyte3()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(3, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -128, 127);
						
						int randomIndex = (int)rng.NextLong(0, length - 3);
						sbyte3 vec = mutate.LoadVector<sbyte3>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 3)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 8)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 8));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)8), 8));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_sbyte4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -128, 127);
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						sbyte4 vec = mutate.LoadVector<sbyte4>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 8)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 8));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)8), 8));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_sbyte8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -128, 127);
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						sbyte8 vec = mutate.LoadVector<sbyte8>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 8)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 8));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)8), 8));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_sbyte16()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(16, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -128, 127);
						
						int randomIndex = (int)rng.NextLong(0, length - 16);
						sbyte16 vec = mutate.LoadVector<sbyte16>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 16)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 8)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 8));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)8), 8));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_sbyte32()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(32, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -128, 127);
						
						int randomIndex = (int)rng.NextLong(0, length - 32);
						sbyte32 vec = mutate.LoadVector<sbyte32>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 32)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 8)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 8));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)8), 8));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_byte2()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(2, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 255);
						
						int randomIndex = (int)rng.NextLong(0, length - 2);
						byte2 vec = mutate.LoadVector<byte2>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 2)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 8)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)8));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_byte3()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(3, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 255);
						
						int randomIndex = (int)rng.NextLong(0, length - 3);
						byte3 vec = mutate.LoadVector<byte3>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 3)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 8)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)8));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_byte4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 255);
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						byte4 vec = mutate.LoadVector<byte4>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 8)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)8));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_byte8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 255);
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						byte8 vec = mutate.LoadVector<byte8>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 8)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)8));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_byte16()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(16, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 255);
						
						int randomIndex = (int)rng.NextLong(0, length - 16);
						byte16 vec = mutate.LoadVector<byte16>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 16)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 8)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)8));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_byte32()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(32, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 255);
						
						int randomIndex = (int)rng.NextLong(0, length - 32);
						byte32 vec = mutate.LoadVector<byte32>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 32)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 8)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)8));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_short2()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(2, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -32768, 32767);
						
						int randomIndex = (int)rng.NextLong(0, length - 2);
						short2 vec = mutate.LoadVector<short2>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 2)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 16)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 16));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)16), 16));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_short3()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(3, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -32768, 32767);
						
						int randomIndex = (int)rng.NextLong(0, length - 3);
						short3 vec = mutate.LoadVector<short3>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 3)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 16)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 16));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)16), 16));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_short4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -32768, 32767);
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						short4 vec = mutate.LoadVector<short4>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 16)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 16));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)16), 16));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_short8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -32768, 32767);
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						short8 vec = mutate.LoadVector<short8>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 16)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 16));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)16), 16));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_short16()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(16, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -32768, 32767);
						
						int randomIndex = (int)rng.NextLong(0, length - 16);
						short16 vec = mutate.LoadVector<short16>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 16)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 16)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 16));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)16), 16));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_ushort2()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(2, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 65535);
						
						int randomIndex = (int)rng.NextLong(0, length - 2);
						ushort2 vec = mutate.LoadVector<ushort2>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 2)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 16)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)16));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_ushort3()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(3, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 65535);
						
						int randomIndex = (int)rng.NextLong(0, length - 3);
						ushort3 vec = mutate.LoadVector<ushort3>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 3)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 16)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)16));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_ushort4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 65535);
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						ushort4 vec = mutate.LoadVector<ushort4>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 16)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)16));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_ushort8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 65535);
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						ushort8 vec = mutate.LoadVector<ushort8>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 16)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)16));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_ushort16()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(16, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 65535);
						
						int randomIndex = (int)rng.NextLong(0, length - 16);
						ushort16 vec = mutate.LoadVector<ushort16>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 16)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 16)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)16));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_int2()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(2, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -2147483648, 2147483647);
						
						int randomIndex = (int)rng.NextLong(0, length - 2);
						int2 vec = mutate.LoadVector<int2>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 2)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 32)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 32));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)32), 32));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_int3()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(3, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -2147483648, 2147483647);
						
						int randomIndex = (int)rng.NextLong(0, length - 3);
						int3 vec = mutate.LoadVector<int3>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 3)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 32)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 32));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)32), 32));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_int4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -2147483648, 2147483647);
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						int4 vec = mutate.LoadVector<int4>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 32)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 32));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)32), 32));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_int8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -2147483648, 2147483647);
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						int8 vec = mutate.LoadVector<int8>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 32)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 32));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)32), 32));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_uint2()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(2, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 4294967295);
						
						int randomIndex = (int)rng.NextLong(0, length - 2);
						uint2 vec = mutate.LoadVector<uint2>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 2)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 32)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)32));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_uint3()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(3, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 4294967295);
						
						int randomIndex = (int)rng.NextLong(0, length - 3);
						uint3 vec = mutate.LoadVector<uint3>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 3)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 32)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)32));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_uint4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 4294967295);
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						uint4 vec = mutate.LoadVector<uint4>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 32)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)32));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_uint8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 4294967295);
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						uint8 vec = mutate.LoadVector<uint8>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 32)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)32));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_long2()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(2, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -9223372036854775808, 9223372036854775807);
						
						int randomIndex = (int)rng.NextLong(0, length - 2);
						long2 vec = mutate.LoadVector<long2>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 2)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 64)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 64));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)64), 64));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_long3()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(3, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -9223372036854775808, 9223372036854775807);
						
						int randomIndex = (int)rng.NextLong(0, length - 3);
						long3 vec = mutate.LoadVector<long3>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 3)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 64)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 64));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)64), 64));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_long4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, -9223372036854775808, 9223372036854775807);
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						long4 vec = mutate.LoadVector<long4>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 64)
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex], 64));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(vec[j - randomIndex] & bitmask64((long)64), 64));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_ulong2()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(2, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 9223372036854775807);
						
						int randomIndex = (int)rng.NextLong(0, length - 2);
						ulong2 vec = mutate.LoadVector<ulong2>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 2)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 64)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)64));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_ulong3()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(3, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 9223372036854775807);
						
						int randomIndex = (int)rng.NextLong(0, length - 3);
						ulong3 vec = mutate.LoadVector<ulong3>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 3)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 64)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)64));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Load_ulong4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare, 0, 9223372036854775807);
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						ulong4 vec = mutate.LoadVector<ulong4>(randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 64)
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], vec[j - randomIndex] & bitmask64((ulong)64));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}


		[Test]
		public static void Store_bit8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						bit8 vec = default;
						for (int j = 0; j < 8; j++)
						{
							vec[j] = tobool((byte)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(1, default(BitIntMock).MaxValueAsLong) + 1));
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						mutate.StoreVector<bit8>(vec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 1)
								{
									Assert.AreEqual(mutate[j], toulong(vec[j - randomIndex]));
								}
								else
								{
									Assert.AreEqual(mutate[j], toulong(vec[j - randomIndex]) & bitmask64((ulong)1));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_bit16()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(16, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						bit16 rngVec = default;
						for (int j = 0; j < 16; j++)
						{
							rngVec[j] = tobool((byte)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(1, default(BitIntMock).MaxValueAsLong) + 1));
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 16);
						mutate.StoreVector<bit16>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 16)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 1)
								{
									Assert.AreEqual(mutate[j], toulong(rngVec[j - randomIndex]));
								}
								else
								{
									Assert.AreEqual(mutate[j], toulong(rngVec[j - randomIndex]) & bitmask64((ulong)1));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_bit24()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(24, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						bit24 rngVec = default;
						for (int j = 0; j < 24; j++)
						{
							rngVec[j] = tobool((byte)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(1, default(BitIntMock).MaxValueAsLong) + 1));
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 24);
						mutate.StoreVector<bit24>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 24)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 1)
								{
									Assert.AreEqual(mutate[j], toulong(rngVec[j - randomIndex]));
								}
								else
								{
									Assert.AreEqual(mutate[j], toulong(rngVec[j - randomIndex]) & bitmask64((ulong)1));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_bit32()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(32, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						bit32 rngVec = default;
						for (int j = 0; j < 32; j++)
						{
							rngVec[j] = tobool((byte)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(1, default(BitIntMock).MaxValueAsLong) + 1));
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 32);
						mutate.StoreVector<bit32>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 32)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 1)
								{
									Assert.AreEqual(mutate[j], toulong(rngVec[j - randomIndex]));
								}
								else
								{
									Assert.AreEqual(mutate[j], toulong(rngVec[j - randomIndex]) & bitmask64((ulong)1));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_bit40()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(40, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						bit40 rngVec = default;
						for (int j = 0; j < 40; j++)
						{
							rngVec[j] = tobool((byte)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(1, default(BitIntMock).MaxValueAsLong) + 1));
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 40);
						mutate.StoreVector<bit40>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 40)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 1)
								{
									Assert.AreEqual(mutate[j], toulong(rngVec[j - randomIndex]));
								}
								else
								{
									Assert.AreEqual(mutate[j], toulong(rngVec[j - randomIndex]) & bitmask64((ulong)1));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_bit48()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(48, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						bit48 rngVec = default;
						for (int j = 0; j < 48; j++)
						{
							rngVec[j] = tobool((byte)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(1, default(BitIntMock).MaxValueAsLong) + 1));
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 48);
						mutate.StoreVector<bit48>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 48)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 1)
								{
									Assert.AreEqual(mutate[j], toulong(rngVec[j - randomIndex]));
								}
								else
								{
									Assert.AreEqual(mutate[j], toulong(rngVec[j - randomIndex]) & bitmask64((ulong)1));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_bit56()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(56, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						bit56 rngVec = default;
						for (int j = 0; j < 56; j++)
						{
							rngVec[j] = tobool((byte)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(1, default(BitIntMock).MaxValueAsLong) + 1));
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 56);
						mutate.StoreVector<bit56>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 56)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 1)
								{
									Assert.AreEqual(mutate[j], toulong(rngVec[j - randomIndex]));
								}
								else
								{
									Assert.AreEqual(mutate[j], toulong(rngVec[j - randomIndex]) & bitmask64((ulong)1));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_bit64()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(64, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						bit64 rngVec = default;
						for (int j = 0; j < 64; j++)
						{
							rngVec[j] = tobool((byte)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(1, default(BitIntMock).MaxValueAsLong) + 1));
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 64);
						mutate.StoreVector<bit64>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 64)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 1)
								{
									Assert.AreEqual(mutate[j], toulong(rngVec[j - randomIndex]));
								}
								else
								{
									Assert.AreEqual(mutate[j], toulong(rngVec[j - randomIndex]) & bitmask64((ulong)1));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_Int2x4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						Int2x4 rngVec = default;
						for (int j = 0; j < 4; j++)
						{
							rngVec[j] = (sbyte)rng.NextLong(max(-2, default(BitIntMock).MinValueAsLong), min(1, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						mutate.StoreVector<Int2x4>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 2)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 2));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)2), 2));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_Int2x8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						Int2x8 rngVec = default;
						for (int j = 0; j < 8; j++)
						{
							rngVec[j] = (sbyte)rng.NextLong(max(-2, default(BitIntMock).MinValueAsLong), min(1, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						mutate.StoreVector<Int2x8>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 2)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 2));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)2), 2));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_Int2x12()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(12, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						Int2x12 rngVec = default;
						for (int j = 0; j < 12; j++)
						{
							rngVec[j] = (sbyte)rng.NextLong(max(-2, default(BitIntMock).MinValueAsLong), min(1, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 12);
						mutate.StoreVector<Int2x12>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 12)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 2)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 2));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)2), 2));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_Int2x16()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(16, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						Int2x16 rngVec = default;
						for (int j = 0; j < 16; j++)
						{
							rngVec[j] = (sbyte)rng.NextLong(max(-2, default(BitIntMock).MinValueAsLong), min(1, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 16);
						mutate.StoreVector<Int2x16>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 16)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 2)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 2));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)2), 2));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_Int2x20()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(20, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						Int2x20 rngVec = default;
						for (int j = 0; j < 20; j++)
						{
							rngVec[j] = (sbyte)rng.NextLong(max(-2, default(BitIntMock).MinValueAsLong), min(1, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 20);
						mutate.StoreVector<Int2x20>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 20)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 2)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 2));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)2), 2));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_Int2x24()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(24, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						Int2x24 rngVec = default;
						for (int j = 0; j < 24; j++)
						{
							rngVec[j] = (sbyte)rng.NextLong(max(-2, default(BitIntMock).MinValueAsLong), min(1, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 24);
						mutate.StoreVector<Int2x24>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 24)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 2)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 2));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)2), 2));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_Int2x28()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(28, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						Int2x28 rngVec = default;
						for (int j = 0; j < 28; j++)
						{
							rngVec[j] = (sbyte)rng.NextLong(max(-2, default(BitIntMock).MinValueAsLong), min(1, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 28);
						mutate.StoreVector<Int2x28>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 28)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 2)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 2));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)2), 2));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_Int2x32()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(32, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						Int2x32 rngVec = default;
						for (int j = 0; j < 32; j++)
						{
							rngVec[j] = (sbyte)rng.NextLong(max(-2, default(BitIntMock).MinValueAsLong), min(1, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 32);
						mutate.StoreVector<Int2x32>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 32)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 2)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 2));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)2), 2));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_UInt2x4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						UInt2x4 rngVec = default;
						for (int j = 0; j < 4; j++)
						{
							rngVec[j] = (byte)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(3, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						mutate.StoreVector<UInt2x4>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 2)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)2));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_UInt2x8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						UInt2x8 rngVec = default;
						for (int j = 0; j < 8; j++)
						{
							rngVec[j] = (byte)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(3, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						mutate.StoreVector<UInt2x8>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 2)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)2));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_UInt2x12()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(12, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						UInt2x12 rngVec = default;
						for (int j = 0; j < 12; j++)
						{
							rngVec[j] = (byte)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(3, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 12);
						mutate.StoreVector<UInt2x12>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 12)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 2)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)2));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_UInt2x16()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(16, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						UInt2x16 rngVec = default;
						for (int j = 0; j < 16; j++)
						{
							rngVec[j] = (byte)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(3, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 16);
						mutate.StoreVector<UInt2x16>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 16)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 2)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)2));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_UInt2x20()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(20, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						UInt2x20 rngVec = default;
						for (int j = 0; j < 20; j++)
						{
							rngVec[j] = (byte)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(3, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 20);
						mutate.StoreVector<UInt2x20>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 20)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 2)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)2));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_UInt2x24()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(24, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						UInt2x24 rngVec = default;
						for (int j = 0; j < 24; j++)
						{
							rngVec[j] = (byte)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(3, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 24);
						mutate.StoreVector<UInt2x24>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 24)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 2)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)2));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_UInt2x28()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(28, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						UInt2x28 rngVec = default;
						for (int j = 0; j < 28; j++)
						{
							rngVec[j] = (byte)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(3, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 28);
						mutate.StoreVector<UInt2x28>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 28)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 2)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)2));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_UInt2x32()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(32, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						UInt2x32 rngVec = default;
						for (int j = 0; j < 32; j++)
						{
							rngVec[j] = (byte)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(3, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 32);
						mutate.StoreVector<UInt2x32>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 32)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 2)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)2));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_Int3x8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						Int3x8 rngVec = default;
						for (int j = 0; j < 8; j++)
						{
							rngVec[j] = (sbyte)rng.NextLong(max(-4, default(BitIntMock).MinValueAsLong), min(3, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						mutate.StoreVector<Int3x8>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 3)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 3));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)3), 3));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_Int3x16()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(16, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						Int3x16 rngVec = default;
						for (int j = 0; j < 16; j++)
						{
							rngVec[j] = (sbyte)rng.NextLong(max(-4, default(BitIntMock).MinValueAsLong), min(3, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 16);
						mutate.StoreVector<Int3x16>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 16)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 3)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 3));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)3), 3));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_UInt3x8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						UInt3x8 rngVec = default;
						for (int j = 0; j < 8; j++)
						{
							rngVec[j] = (byte)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(7, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						mutate.StoreVector<UInt3x8>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 3)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)3));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_UInt3x16()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(16, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						UInt3x16 rngVec = default;
						for (int j = 0; j < 16; j++)
						{
							rngVec[j] = (byte)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(7, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 16);
						mutate.StoreVector<UInt3x16>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 16)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 3)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)3));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_Int4x2()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(2, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						Int4x2 rngVec = default;
						for (int j = 0; j < 2; j++)
						{
							rngVec[j] = (sbyte)rng.NextLong(max(-8, default(BitIntMock).MinValueAsLong), min(7, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 2);
						mutate.StoreVector<Int4x2>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 2)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 4)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 4));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)4), 4));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_Int4x4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						Int4x4 rngVec = default;
						for (int j = 0; j < 4; j++)
						{
							rngVec[j] = (sbyte)rng.NextLong(max(-8, default(BitIntMock).MinValueAsLong), min(7, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						mutate.StoreVector<Int4x4>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 4)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 4));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)4), 4));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_Int4x6()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(6, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						Int4x6 rngVec = default;
						for (int j = 0; j < 6; j++)
						{
							rngVec[j] = (sbyte)rng.NextLong(max(-8, default(BitIntMock).MinValueAsLong), min(7, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 6);
						mutate.StoreVector<Int4x6>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 6)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 4)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 4));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)4), 4));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_Int4x8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						Int4x8 rngVec = default;
						for (int j = 0; j < 8; j++)
						{
							rngVec[j] = (sbyte)rng.NextLong(max(-8, default(BitIntMock).MinValueAsLong), min(7, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						mutate.StoreVector<Int4x8>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 4)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 4));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)4), 4));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_Int4x10()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(10, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						Int4x10 rngVec = default;
						for (int j = 0; j < 10; j++)
						{
							rngVec[j] = (sbyte)rng.NextLong(max(-8, default(BitIntMock).MinValueAsLong), min(7, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 10);
						mutate.StoreVector<Int4x10>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 10)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 4)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 4));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)4), 4));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_Int4x12()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(12, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						Int4x12 rngVec = default;
						for (int j = 0; j < 12; j++)
						{
							rngVec[j] = (sbyte)rng.NextLong(max(-8, default(BitIntMock).MinValueAsLong), min(7, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 12);
						mutate.StoreVector<Int4x12>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 12)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 4)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 4));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)4), 4));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_Int4x14()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(14, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						Int4x14 rngVec = default;
						for (int j = 0; j < 14; j++)
						{
							rngVec[j] = (sbyte)rng.NextLong(max(-8, default(BitIntMock).MinValueAsLong), min(7, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 14);
						mutate.StoreVector<Int4x14>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 14)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 4)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 4));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)4), 4));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_Int4x16()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(16, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						Int4x16 rngVec = default;
						for (int j = 0; j < 16; j++)
						{
							rngVec[j] = (sbyte)rng.NextLong(max(-8, default(BitIntMock).MinValueAsLong), min(7, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 16);
						mutate.StoreVector<Int4x16>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 16)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 4)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 4));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)4), 4));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_UInt4x2()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(2, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						UInt4x2 rngVec = default;
						for (int j = 0; j < 2; j++)
						{
							rngVec[j] = (byte)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(15, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 2);
						mutate.StoreVector<UInt4x2>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 2)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 4)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)4));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_UInt4x4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						UInt4x4 rngVec = default;
						for (int j = 0; j < 4; j++)
						{
							rngVec[j] = (byte)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(15, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						mutate.StoreVector<UInt4x4>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 4)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)4));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_UInt4x6()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(6, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						UInt4x6 rngVec = default;
						for (int j = 0; j < 6; j++)
						{
							rngVec[j] = (byte)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(15, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 6);
						mutate.StoreVector<UInt4x6>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 6)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 4)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)4));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_UInt4x8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						UInt4x8 rngVec = default;
						for (int j = 0; j < 8; j++)
						{
							rngVec[j] = (byte)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(15, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						mutate.StoreVector<UInt4x8>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 4)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)4));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_UInt4x10()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(10, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						UInt4x10 rngVec = default;
						for (int j = 0; j < 10; j++)
						{
							rngVec[j] = (byte)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(15, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 10);
						mutate.StoreVector<UInt4x10>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 10)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 4)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)4));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_UInt4x12()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(12, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						UInt4x12 rngVec = default;
						for (int j = 0; j < 12; j++)
						{
							rngVec[j] = (byte)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(15, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 12);
						mutate.StoreVector<UInt4x12>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 12)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 4)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)4));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_UInt4x14()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(14, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						UInt4x14 rngVec = default;
						for (int j = 0; j < 14; j++)
						{
							rngVec[j] = (byte)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(15, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 14);
						mutate.StoreVector<UInt4x14>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 14)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 4)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)4));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_UInt4x16()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(16, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						UInt4x16 rngVec = default;
						for (int j = 0; j < 16; j++)
						{
							rngVec[j] = (byte)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(15, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 16);
						mutate.StoreVector<UInt4x16>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 16)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 4)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)4));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_Int5x8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						Int5x8 rngVec = default;
						for (int j = 0; j < 8; j++)
						{
							rngVec[j] = (sbyte)rng.NextLong(max(-16, default(BitIntMock).MinValueAsLong), min(15, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						mutate.StoreVector<Int5x8>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 5)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 5));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)5), 5));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_UInt5x8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						UInt5x8 rngVec = default;
						for (int j = 0; j < 8; j++)
						{
							rngVec[j] = (byte)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(31, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						mutate.StoreVector<UInt5x8>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 5)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)5));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_Int6x4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						Int6x4 rngVec = default;
						for (int j = 0; j < 4; j++)
						{
							rngVec[j] = (sbyte)rng.NextLong(max(-32, default(BitIntMock).MinValueAsLong), min(31, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						mutate.StoreVector<Int6x4>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 6)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 6));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)6), 6));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_Int6x8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						Int6x8 rngVec = default;
						for (int j = 0; j < 8; j++)
						{
							rngVec[j] = (sbyte)rng.NextLong(max(-32, default(BitIntMock).MinValueAsLong), min(31, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						mutate.StoreVector<Int6x8>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 6)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 6));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)6), 6));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_UInt6x4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						UInt6x4 rngVec = default;
						for (int j = 0; j < 4; j++)
						{
							rngVec[j] = (byte)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(63, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						mutate.StoreVector<UInt6x4>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 6)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)6));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_UInt6x8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						UInt6x8 rngVec = default;
						for (int j = 0; j < 8; j++)
						{
							rngVec[j] = (byte)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(63, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						mutate.StoreVector<UInt6x8>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 6)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)6));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_Int7x8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						Int7x8 rngVec = default;
						for (int j = 0; j < 8; j++)
						{
							rngVec[j] = (sbyte)rng.NextLong(max(-64, default(BitIntMock).MinValueAsLong), min(63, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						mutate.StoreVector<Int7x8>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 7)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 7));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)7), 7));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_UInt7x8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						UInt7x8 rngVec = default;
						for (int j = 0; j < 8; j++)
						{
							rngVec[j] = (byte)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(127, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						mutate.StoreVector<UInt7x8>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 7)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)7));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_Int10x4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						Int10x4 rngVec = default;
						for (int j = 0; j < 4; j++)
						{
							rngVec[j] = (short)rng.NextLong(max(-512, default(BitIntMock).MinValueAsLong), min(511, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						mutate.StoreVector<Int10x4>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 10)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 10));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)10), 10));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_UInt10x4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						UInt10x4 rngVec = default;
						for (int j = 0; j < 4; j++)
						{
							rngVec[j] = (ushort)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(1023, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						mutate.StoreVector<UInt10x4>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 10)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)10));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_Int12x2()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(2, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						Int12x2 rngVec = default;
						for (int j = 0; j < 2; j++)
						{
							rngVec[j] = (short)rng.NextLong(max(-2048, default(BitIntMock).MinValueAsLong), min(2047, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 2);
						mutate.StoreVector<Int12x2>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 2)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 12)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 12));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)12), 12));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_Int12x4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						Int12x4 rngVec = default;
						for (int j = 0; j < 4; j++)
						{
							rngVec[j] = (short)rng.NextLong(max(-2048, default(BitIntMock).MinValueAsLong), min(2047, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						mutate.StoreVector<Int12x4>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 12)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 12));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)12), 12));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_UInt12x2()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(2, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						UInt12x2 rngVec = default;
						for (int j = 0; j < 2; j++)
						{
							rngVec[j] = (ushort)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(4095, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 2);
						mutate.StoreVector<UInt12x2>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 2)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 12)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)12));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_UInt12x4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						UInt12x4 rngVec = default;
						for (int j = 0; j < 4; j++)
						{
							rngVec[j] = (ushort)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(4095, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						mutate.StoreVector<UInt12x4>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 12)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)12));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_Int14x4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						Int14x4 rngVec = default;
						for (int j = 0; j < 4; j++)
						{
							rngVec[j] = (short)rng.NextLong(max(-8192, default(BitIntMock).MinValueAsLong), min(8191, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						mutate.StoreVector<Int14x4>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 14)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 14));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)14), 14));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_UInt14x4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						UInt14x4 rngVec = default;
						for (int j = 0; j < 4; j++)
						{
							rngVec[j] = (ushort)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(16383, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						mutate.StoreVector<UInt14x4>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 14)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)14));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_Int20x2()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(2, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						Int20x2 rngVec = default;
						for (int j = 0; j < 2; j++)
						{
							rngVec[j] = (int)rng.NextLong(max(-524288, default(BitIntMock).MinValueAsLong), min(524287, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 2);
						mutate.StoreVector<Int20x2>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 2)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 20)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 20));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)20), 20));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_UInt20x2()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(2, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						UInt20x2 rngVec = default;
						for (int j = 0; j < 2; j++)
						{
							rngVec[j] = (uint)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(1048575, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 2);
						mutate.StoreVector<UInt20x2>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 2)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 20)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)20));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_Int28x2()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(2, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						Int28x2 rngVec = default;
						for (int j = 0; j < 2; j++)
						{
							rngVec[j] = (int)rng.NextLong(max(-134217728, default(BitIntMock).MinValueAsLong), min(134217727, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 2);
						mutate.StoreVector<Int28x2>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 2)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 28)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 28));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)28), 28));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_UInt28x2()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(2, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						UInt28x2 rngVec = default;
						for (int j = 0; j < 2; j++)
						{
							rngVec[j] = (uint)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(268435455, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 2);
						mutate.StoreVector<UInt28x2>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 2)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 28)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)28));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_sbyte2()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(2, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						sbyte2 rngVec = default;
						for (int j = 0; j < 2; j++)
						{
							rngVec[j] = (sbyte)rng.NextLong(max(-128, default(BitIntMock).MinValueAsLong), min(127, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 2);
						mutate.StoreVector<sbyte2>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 2)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 8)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 8));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)8), 8));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_sbyte3()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(3, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						sbyte3 rngVec = default;
						for (int j = 0; j < 3; j++)
						{
							rngVec[j] = (sbyte)rng.NextLong(max(-128, default(BitIntMock).MinValueAsLong), min(127, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 3);
						mutate.StoreVector<sbyte3>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 3)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 8)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 8));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)8), 8));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_sbyte4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						sbyte4 rngVec = default;
						for (int j = 0; j < 4; j++)
						{
							rngVec[j] = (sbyte)rng.NextLong(max(-128, default(BitIntMock).MinValueAsLong), min(127, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						mutate.StoreVector<sbyte4>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 8)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 8));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)8), 8));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_sbyte8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						sbyte8 rngVec = default;
						for (int j = 0; j < 8; j++)
						{
							rngVec[j] = (sbyte)rng.NextLong(max(-128, default(BitIntMock).MinValueAsLong), min(127, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						mutate.StoreVector<sbyte8>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 8)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 8));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)8), 8));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_sbyte16()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(16, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						sbyte16 rngVec = default;
						for (int j = 0; j < 16; j++)
						{
							rngVec[j] = (sbyte)rng.NextLong(max(-128, default(BitIntMock).MinValueAsLong), min(127, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 16);
						mutate.StoreVector<sbyte16>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 16)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 8)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 8));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)8), 8));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_sbyte32()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(32, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						sbyte32 rngVec = default;
						for (int j = 0; j < 32; j++)
						{
							rngVec[j] = (sbyte)rng.NextLong(max(-128, default(BitIntMock).MinValueAsLong), min(127, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 32);
						mutate.StoreVector<sbyte32>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 32)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 8)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 8));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)8), 8));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_byte2()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(2, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						byte2 rngVec = default;
						for (int j = 0; j < 2; j++)
						{
							rngVec[j] = (byte)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(255, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 2);
						mutate.StoreVector<byte2>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 2)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 8)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)8));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_byte3()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(3, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						byte3 rngVec = default;
						for (int j = 0; j < 3; j++)
						{
							rngVec[j] = (byte)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(255, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 3);
						mutate.StoreVector<byte3>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 3)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 8)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)8));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_byte4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						byte4 rngVec = default;
						for (int j = 0; j < 4; j++)
						{
							rngVec[j] = (byte)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(255, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						mutate.StoreVector<byte4>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 8)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)8));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_byte8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						byte8 rngVec = default;
						for (int j = 0; j < 8; j++)
						{
							rngVec[j] = (byte)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(255, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						mutate.StoreVector<byte8>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 8)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)8));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_byte16()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(16, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						byte16 rngVec = default;
						for (int j = 0; j < 16; j++)
						{
							rngVec[j] = (byte)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(255, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 16);
						mutate.StoreVector<byte16>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 16)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 8)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)8));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_byte32()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(32, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						byte32 rngVec = default;
						for (int j = 0; j < 32; j++)
						{
							rngVec[j] = (byte)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(255, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 32);
						mutate.StoreVector<byte32>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 32)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 8)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)8));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_short2()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(2, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						short2 rngVec = default;
						for (int j = 0; j < 2; j++)
						{
							rngVec[j] = (short)rng.NextLong(max(-32768, default(BitIntMock).MinValueAsLong), min(32767, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 2);
						mutate.StoreVector<short2>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 2)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 16)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 16));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)16), 16));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_short3()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(3, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						short3 rngVec = default;
						for (int j = 0; j < 3; j++)
						{
							rngVec[j] = (short)rng.NextLong(max(-32768, default(BitIntMock).MinValueAsLong), min(32767, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 3);
						mutate.StoreVector<short3>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 3)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 16)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 16));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)16), 16));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_short4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						short4 rngVec = default;
						for (int j = 0; j < 4; j++)
						{
							rngVec[j] = (short)rng.NextLong(max(-32768, default(BitIntMock).MinValueAsLong), min(32767, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						mutate.StoreVector<short4>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 16)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 16));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)16), 16));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_short8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						short8 rngVec = default;
						for (int j = 0; j < 8; j++)
						{
							rngVec[j] = (short)rng.NextLong(max(-32768, default(BitIntMock).MinValueAsLong), min(32767, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						mutate.StoreVector<short8>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 16)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 16));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)16), 16));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_short16()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(16, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						short16 rngVec = default;
						for (int j = 0; j < 16; j++)
						{
							rngVec[j] = (short)rng.NextLong(max(-32768, default(BitIntMock).MinValueAsLong), min(32767, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 16);
						mutate.StoreVector<short16>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 16)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 16)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 16));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)16), 16));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_ushort2()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(2, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						ushort2 rngVec = default;
						for (int j = 0; j < 2; j++)
						{
							rngVec[j] = (ushort)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(65535, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 2);
						mutate.StoreVector<ushort2>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 2)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 16)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)16));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_ushort3()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(3, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						ushort3 rngVec = default;
						for (int j = 0; j < 3; j++)
						{
							rngVec[j] = (ushort)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(65535, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 3);
						mutate.StoreVector<ushort3>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 3)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 16)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)16));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_ushort4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						ushort4 rngVec = default;
						for (int j = 0; j < 4; j++)
						{
							rngVec[j] = (ushort)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(65535, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						mutate.StoreVector<ushort4>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 16)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)16));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_ushort8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						ushort8 rngVec = default;
						for (int j = 0; j < 8; j++)
						{
							rngVec[j] = (ushort)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(65535, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						mutate.StoreVector<ushort8>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 16)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)16));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_ushort16()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(16, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						ushort16 rngVec = default;
						for (int j = 0; j < 16; j++)
						{
							rngVec[j] = (ushort)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(65535, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 16);
						mutate.StoreVector<ushort16>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 16)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 16)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)16));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_int2()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(2, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						int2 rngVec = default;
						for (int j = 0; j < 2; j++)
						{
							rngVec[j] = (int)rng.NextLong(max(-2147483648, default(BitIntMock).MinValueAsLong), min(2147483647, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 2);
						mutate.StoreVector<int2>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 2)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 32)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 32));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)32), 32));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_int3()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(3, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						int3 rngVec = default;
						for (int j = 0; j < 3; j++)
						{
							rngVec[j] = (int)rng.NextLong(max(-2147483648, default(BitIntMock).MinValueAsLong), min(2147483647, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 3);
						mutate.StoreVector<int3>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 3)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 32)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 32));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)32), 32));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_int4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						int4 rngVec = default;
						for (int j = 0; j < 4; j++)
						{
							rngVec[j] = (int)rng.NextLong(max(-2147483648, default(BitIntMock).MinValueAsLong), min(2147483647, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						mutate.StoreVector<int4>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 32)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 32));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)32), 32));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_int8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						int8 rngVec = default;
						for (int j = 0; j < 8; j++)
						{
							rngVec[j] = (int)rng.NextLong(max(-2147483648, default(BitIntMock).MinValueAsLong), min(2147483647, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						mutate.StoreVector<int8>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 32)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 32));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)32), 32));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_uint2()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(2, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						uint2 rngVec = default;
						for (int j = 0; j < 2; j++)
						{
							rngVec[j] = (uint)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(4294967295, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 2);
						mutate.StoreVector<uint2>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 2)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 32)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)32));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_uint3()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(3, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						uint3 rngVec = default;
						for (int j = 0; j < 3; j++)
						{
							rngVec[j] = (uint)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(4294967295, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 3);
						mutate.StoreVector<uint3>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 3)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 32)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)32));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_uint4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						uint4 rngVec = default;
						for (int j = 0; j < 4; j++)
						{
							rngVec[j] = (uint)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(4294967295, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						mutate.StoreVector<uint4>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 32)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)32));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_uint8()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(8, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						uint8 rngVec = default;
						for (int j = 0; j < 8; j++)
						{
							rngVec[j] = (uint)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(4294967295, default(BitIntMock).MaxValueAsLong) + 1);
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 8);
						mutate.StoreVector<uint8>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 8)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 32)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)32));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_long2()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(2, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						long2 rngVec = default;
						for (int j = 0; j < 2; j++)
						{
							rngVec[j] = rng.NextLong(max(-9223372036854775808, default(BitIntMock).MinValueAsLong), min(9223372036854775807, default(BitIntMock).MaxValueAsLong));
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 2);
						mutate.StoreVector<long2>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 2)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 64)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 64));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)64), 64));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_long3()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(3, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						long3 rngVec = default;
						for (int j = 0; j < 3; j++)
						{
							rngVec[j] = rng.NextLong(max(-9223372036854775808, default(BitIntMock).MinValueAsLong), min(9223372036854775807, default(BitIntMock).MaxValueAsLong));
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 3);
						mutate.StoreVector<long3>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 3)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 64)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 64));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)64), 64));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_long4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						long4 rngVec = default;
						for (int j = 0; j < 4; j++)
						{
							rngVec[j] = rng.NextLong(max(-9223372036854775808, default(BitIntMock).MinValueAsLong), min(9223372036854775807, default(BitIntMock).MaxValueAsLong));
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						mutate.StoreVector<long4>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 64)
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex], 64));
								}
								else
								{
									Assert.AreEqual(mutate[j], signextend(rngVec[j - randomIndex] & bitmask64((long)64), 64));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_ulong2()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(2, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						ulong2 rngVec = default;
						for (int j = 0; j < 2; j++)
						{
							rngVec[j] = (ulong)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(9223372036854775807, default(BitIntMock).MaxValueAsLong));
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 2);
						mutate.StoreVector<ulong2>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 2)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 64)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)64));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_ulong3()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(3, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						ulong3 rngVec = default;
						for (int j = 0; j < 3; j++)
						{
							rngVec[j] = (ulong)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(9223372036854775807, default(BitIntMock).MaxValueAsLong));
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 3);
						mutate.StoreVector<ulong3>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 3)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 64)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)64));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}

		[Test]
		public static void Store_ulong4()
		{
			BitIntMock.ForEachBitInt
			(
				(rng) =>
				{
					for (int i = 0; i < 4; i++)
					{
						int length = (int)rng.NextLong(4, 200);
						
						CreateRandomBitIntMockLists<BitIntMock>(length, ref rng, out NativeBitIntList<BitIntMock> mutate, out NativeBitIntList<BitIntMock> compare);
						ulong4 rngVec = default;
						for (int j = 0; j < 4; j++)
						{
							rngVec[j] = (ulong)rng.NextLong(max(0, default(BitIntMock).MinValueAsLong), min(9223372036854775807, default(BitIntMock).MaxValueAsLong));
						}
						
						int randomIndex = (int)rng.NextLong(0, length - 4);
						mutate.StoreVector<ulong4>(rngVec, randomIndex);
						
						for (int j = 0; j < length; j++)
						{
							if (j < randomIndex
							 || j >= randomIndex + 4)
							{
								Assert.AreEqual(mutate[j], compare[j]);
							}
							else
							{
								if (default(BitIntMock).Bits >= 64)
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex]);
								}
								else
								{
									Assert.AreEqual(mutate[j], rngVec[j - randomIndex] & bitmask64((ulong)64));
								}
							}
						}
						
						mutate.Dispose(default);
						compare.Dispose(default);
					}
				}
			);
		}
	}
}
