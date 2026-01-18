using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;

using static Unity.Mathematics.math;
using static MaxMath.maxmath;

namespace BitCollections
{
    unsafe internal static partial class BitAlgorithms
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void InsertionSort<T>(void* ptr, int length)
            where T: BitInt
        {
            for (int i = 1; i < length; i++)
            {
                long current = LoadStore.LoadScalar<T>(ptr, i, length);
                int j = i;

                while (--j >= 0 && LoadStore.LoadScalar<T>(ptr, j, length) > current)
                {
                    LoadStore.StoreScalar<T>(ptr, j + 1, length, LoadStore.LoadScalar<T>(ptr, j, length));
                }

                LoadStore.StoreScalar<T>(ptr, j + 1, length, current);
            }
        }

        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void CountingSort<T>(void* ptr, int length)
            where T: BitInt
        {
            int* counters = stackalloc int[1 << default(T).Bits];
            for (int i = 0; i < 1 << default(T).Bits; i++)
            {
                counters[i] = 0;
            }

            long globalMin = default(T).MaxValueAsLong;
            long globalMax = default(T).MinValueAsLong;

            for (int i = 0; i < length; i++)
            {
                long value = LoadStore.LoadScalar<T>(ptr, i, length);
                counters[value - default(T).MinValueAsLong]++;
                globalMin = min(globalMin, value);
                globalMax = max(globalMax, value);
            }

            int writeIdx = 0;
            for (int i = (int)globalMin; i <= (int)globalMax; i++)
            {
                int count = counters[i - default(T).MinValueAsLong];
                LoadStore.StoreReplicate<T>(ptr, writeIdx, count, i);
                writeIdx += count;
            }
        }

        // TODO optimize
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Sort<T>(void* ptr, int length)
            where T: BitInt
        {
            if (default(T).Bits == 1)
            {
                int setBits = (int)CountBits(ptr, 0, (long)length);
                int clearedBits = length - setBits;

                LoadStore.StoreReplicate<Bit>(ptr, 0, clearedBits, tolong(false));
                LoadStore.StoreReplicate<Bit>(ptr, clearedBits, setBits, tolong(true));
            }
            else if (/*length > 256
             && */default(T).Bits <= 14) // ~64kB stackalloc
            {
                CountingSort<T>(ptr, length);
            }
            else
            {
                InsertionSort<T>(ptr, length);
            }
        }
    }
}
