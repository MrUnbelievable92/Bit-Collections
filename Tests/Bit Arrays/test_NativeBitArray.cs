using NUnit.Framework;
using Unity.Collections;
using MaxMath;

using static Unity.Mathematics.math;
using static MaxMath.maxmath;

namespace BitCollections.Tests
{
    public static class _NativeBitArray
    {
        [Test]
        public static void GetSet()
        {
            Random32 rng = Random32.New;

            for (int i = 0; i < 4; i++)
            {
                using NativeBitArray arr = new NativeBitArray(rng.NextInt(1, 10000), Allocator.Persistent);

                for (int j = 0; j < arr.Length; j++)
                {
                    Assert.IsFalse(arr[j]);
                    arr[j] = true;
                    Assert.IsTrue(arr[j]);
                }

                bool[] cmp = new bool[arr.Length];

                for (int j = 0; j < arr.Length; j++)
                {
                    arr[j] = rng.NextBool();
                    cmp[j] = arr[j];
                    Assert.AreEqual(arr[j], cmp[j]);
                }

                for (int j = 0; j < arr.Length; j++)
                {
                    Assert.AreEqual(arr[j], cmp[j]);
                }
            }
        }

        [Test]
        public static void CountBits()
        {
            Random32 rng = Random32.New;

            for (int i = 0; i < 4; i++)
            {
                using NativeBitArray arr = new NativeBitArray(rng.NextInt(1, 10000), Allocator.Persistent);

                int std = 0;

                for (int j = 0; j < arr.Length; j++)
                {
                    arr[j] = rng.NextBool();
                    std += maxmath.toint(arr[j]);
                }

                Assert.AreEqual(std, arr.CountBits());
                Assert.AreEqual(std, arr.CountBits(0, arr.Length));

                std = 0;
                int start = rng.NextInt(0, arr.Length / 2);
                int end = rng.NextInt(start, arr.Length);
                int numBits = 1 + (end - start);

                for (int j = start; j <= end; j++)
                {
                    std += maxmath.toint(arr[j]);
                }

                Assert.AreEqual(std, arr.CountBits(start, numBits));
            }

            using NativeBitArray staticSize1 = new NativeBitArray(6, Allocator.Temp);
            int stdStatic = 0;

            for (int i = 0; i < staticSize1.Length; i++)
            {
                staticSize1[i] = rng.NextBool();
                stdStatic += maxmath.toint(staticSize1[i]);
            }

            Assert.AreEqual(stdStatic, staticSize1.CountBits());
            Assert.AreEqual(stdStatic, staticSize1.CountBits(0, 6));

            using NativeBitArray staticSize2 = new NativeBitArray(13, Allocator.Temp);
            stdStatic = 0;

            for (int i = 0; i < staticSize2.Length; i++)
            {
                staticSize2[i] = rng.NextBool();
                stdStatic += maxmath.toint(staticSize2[i]);
            }

            Assert.AreEqual(stdStatic, staticSize2.CountBits());
            Assert.AreEqual(stdStatic, staticSize2.CountBits(0, 13));

            stdStatic = 0;

            for (int i = 8; i < 11; i++)
            {
                stdStatic += maxmath.toint(staticSize2[i]);
            }

            Assert.AreEqual(stdStatic, staticSize2.CountBits(8, 3));

            stdStatic = 0;

            for (int i = 7; i < staticSize2.Length; i++)
            {
                stdStatic += maxmath.toint(staticSize2[i]);
            }

            Assert.AreEqual(stdStatic, staticSize2.CountBits(7, 6));

            stdStatic = maxmath.toint(staticSize2[9]);
            Assert.AreEqual(stdStatic, staticSize2.CountBits(9, 1));
        }

        [Test]
        public static void ArraysEqual()
        {
           Random32 rng = Random32.New;

            for (int i = 0; i < 50; i++)
            {
                int length = rng.NextInt(0, 500);

                NativeBitArray lhs = new NativeBitArray(length, Allocator.Persistent, NativeArrayOptions.UninitializedMemory);
                NativeBitArray rhs = new NativeBitArray(length, Allocator.Persistent, NativeArrayOptions.UninitializedMemory);

                for (int j = 0; j < length; j++)
                {
                    lhs[j] = rhs[j] = rng.NextBool();
                }

                int rngIndex = rng.NextInt(0, length);
                int rngCount = rng.NextInt(0, length - rngIndex);

                Assert.IsTrue(lhs.ArraysEqual(rhs));

                int changedIndex = rng.NextInt(rngIndex, rngIndex + rngCount);
                if (changedIndex < length)
                {
                    lhs[changedIndex] ^= true;

                    Assert.IsFalse(lhs.ArraysEqual(rhs));
                }

                lhs.Dispose(default);
                rhs.Dispose(default);
            }
        }
        
        private static int __longeststring(bool value, NativeBitArray t, int idx, int num)
        {
            if (num <= 0) 
            {
                return 0;
            }

            int maximum = 0;
            int current = 0;
            for (int i = idx; i < idx + num; i++)
            {
                if (t[i] == value)
                {
                    maximum = max(++current, maximum);
                }
                else
                {
                    current = 0;
                }
            }

            return maximum;
        }

        [Test]
        public static void FindString()
        {
            Random32 rng = Random32.New;

            for (int i = 0; i < 512; i++)
            {
                int length = rng.NextInt(0, 10000);
                int stringLength = rng.NextInt(0, min(length, 64));
                NativeBitArray array = new NativeBitArray(length, Allocator.Persistent);

                for (int j = 0; j < length; j++)
                {
                    array[j] = rng.NextBool();
                }

                int iof_true = array.FindString(true, stringLength);
                int iof_false = array.FindString(false, stringLength);

                if (iof_true == -1)
                {
                    if (stringLength != 0)
                    {
                        Assert.IsTrue(__longeststring(true, array, 0, length) < stringLength);
                    }
                }
                else
                {
                    if (stringLength != 0)
                    {
                        Assert.IsTrue(__longeststring(true, array, 0, iof_true) < stringLength);
                    }

                    for (int j = 0; j < stringLength; j++)
                    {
                        Assert.IsTrue(array[j + iof_true]);
                    }
                }

                if (iof_false == -1)
                {
                    if (stringLength != 0)
                    {
                        Assert.IsTrue(__longeststring(false, array, 0, length) < stringLength);
                    }
                }
                else
                {
                    if (stringLength != 0)
                    {
                        Assert.IsTrue(__longeststring(false, array, 0, iof_false) < stringLength);
                    }

                    for (int j = 0; j < stringLength; j++)
                    {
                        Assert.IsFalse(array[j + iof_false]);
                    }
                }

                for (int j = 0; j < length; j++)
                {
                    array[j] = true;
                }
                Assert.AreEqual(array.FindString(true, length), 0);

                for (int j = 0; j < length; j++)
                {
                    array[j] = false;
                }
                Assert.AreEqual(array.FindString(false, length), 0);

                array.Dispose(default);
            }
        }

        [Test]
        public static void FindStringBeginEnd()
        {
            Random32 rng = Random32.New;

            for (int i = 0; i < 512; i++)
            {
                int length = rng.NextInt(0, 10000);
                int startIndex = rng.NextInt(0, length);
                int numTests = rng.NextInt(0, length - startIndex + 1);
                int stringLength = rng.NextInt(0, numTests + 1);
                NativeBitArray array = new NativeBitArray(length, Allocator.Persistent);

                for (int j = 0; j < length; j++)
                {
                    array[j] = rng.NextBool();
                }

                int iof_true = array.FindString(true, stringLength, startIndex, numTests);
                int iof_false = array.FindString(false, stringLength, startIndex, numTests);

                if (iof_true == -1)
                {
                    if (stringLength != 0)
                    {
                        Assert.IsTrue(__longeststring(true, array, startIndex, numTests) < stringLength);
                    }
                }
                else
                {
                    if (stringLength != 0)
                    {
                        Assert.IsTrue(__longeststring(true, array, startIndex, iof_true - startIndex) < stringLength);
                    }

                    for (int j = 0; j < stringLength; j++)
                    {
                        Assert.IsTrue(array[j + iof_true]);
                    }
                }

                if (iof_false == -1)
                {
                    if (stringLength != 0)
                    {
                        Assert.IsTrue(__longeststring(false, array, startIndex, numTests) < stringLength);
                    }
                }
                else
                {
                    if (stringLength != 0)
                    {
                        Assert.IsTrue(__longeststring(false, array, startIndex, iof_false - startIndex) < stringLength);
                    }

                    for (int j = 0; j < stringLength; j++)
                    {
                        Assert.IsFalse(array[j + iof_false]);
                    }
                }

                if (numTests != 0)
                {
                    for (int j = 0; j < numTests; j++)
                    {
                        array[j + startIndex] = true;
                    }
                    Assert.AreEqual(array.FindString(true, numTests, startIndex, numTests), startIndex);
                    
                    for (int j = 0; j < numTests; j++)
                    {
                        array[j + startIndex] = false;
                    }
                    Assert.AreEqual(array.FindString(false, numTests, startIndex, numTests), startIndex);
                }

                array.Dispose(default);
            }
        }
    }
}