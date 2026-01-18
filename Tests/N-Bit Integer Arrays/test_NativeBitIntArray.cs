using NUnit.Framework;
using Unity.Collections;
using Unity.Jobs;
using MaxMath;

namespace BitCollections.Tests
{
    public static class _NativeBitIntArray
    {
        [Test]
        public static void GetSet()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int testNum = 0; testNum < 2; testNum++)
                    {
                        int size = (int)rng.NextLong(1, 300);
                        NativeArray<long> cmp = new NativeArray<long>(size, Allocator.Persistent);
                        NativeBitIntArray<BitIntMock> arr = new NativeBitIntArray<BitIntMock>(size, Allocator.Persistent);

                        for (int element = 0; element < size; element++)
                        {
                            cmp[element] = BitIntMock.Random(ref rng);
                            arr[element] = cmp[element];

                            for (int i = 0; i <= element; i++)
                            {
                                Assert.AreEqual(cmp[i], arr[i]);
                            }
                        }

                        int randomIndex = (int)rng.NextLong(0, size);
                        cmp[randomIndex] = BitIntMock.Random(ref rng);
                        arr[randomIndex] = cmp[randomIndex];
                        for (int i = 0; i < size; i++)
                        {
                            Assert.AreEqual(cmp[i], arr[i]);
                        }

                        cmp.Dispose(default(JobHandle));
                        arr.Dispose(default(JobHandle));
                    }
                }
            );
        }
    }
}
