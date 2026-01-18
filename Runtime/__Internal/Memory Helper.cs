using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Burst.CompilerServices;
using DevTools;

using static Unity.Mathematics.math;
using static MaxMath.maxmath;

namespace BitCollections
{
    unsafe internal static class MemoryHelper
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bool IsMemoryOptimized<T>()
            where T : BitInt
        {
            return default(T).Bits < 8
                || default(T).Bits == 10
                || default(T).Bits == 12
                || default(T).Bits == 14
                || default(T).Bits == 20
                || default(T).Bits == 28

                || default(T).Bits == 8
                || default(T).Bits == 16
                || default(T).Bits == 24
                || default(T).Bits == 32
                || default(T).Bits == 40
                || default(T).Bits == 48
                || default(T).Bits == 56;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int AlignOf<T>()
            where T : BitInt
        {
            if (IsMemoryOptimized<T>())
            {
                return ispow2(default(T).MinFullyPackedBytes) ? default(T).MinFullyPackedBytes : 1;
            }
            else
            {
                return default(T).Bits <= 32 ? (default(T).Bits <= 32 - 7 ? (default(T).Bits <= 16 - 7 ? (default(T).Bits == 8 ? 1 : 2) : 4) : 8) : 16;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: AssumeRange(0ul, int.MaxValue)]
        internal static ulong Capacity<T>(int numNumbers)
            where T : BitInt
        {
            if (IsMemoryOptimized<T>())
            {
                return ceilmultiple(default(T).Bits * (ulong)numNumbers, default(T).MinFullyPackedBytes * 8ul) / default(T).Bits;
            }
            else
            {
                return (SizeInBytes<T>(numNumbers) * 8) / default(T).Bits;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: AssumeRange(0ul, int.MaxValue)]
        internal static ulong SizeInBytes<T>(int numNumbers)
            where T : BitInt
        {
            if (IsMemoryOptimized<T>())
            {
                return ceilmultiple(default(T).Bits * (ulong)numNumbers, default(T).MinFullyPackedBytes * 8ul) / 8;
            }
            else
            {
                uint safetyPadding = numNumbers == 0 ? 0 : (uint)AlignOf<T>() - 1;
                return (default(T).Bits * (ulong)(uint)numNumbers) / 8u + safetyPadding;
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void* Allocate<T>(int numNumbers, Allocator allocator, NativeArrayOptions options)
            where T : BitInt
        {
Assert.AreNotEqual(0, numNumbers);

            long bytes = (long)SizeInBytes<T>(numNumbers);
            void* ptr = UnsafeUtility.Malloc(bytes, AlignOf<T>(), allocator);

Assert.IsNotNull(ptr);

            if (options == NativeArrayOptions.ClearMemory)
            {
                UnsafeUtility.MemClear(ptr, (long)SizeInBytes<T>(numNumbers));
            }

            return ptr;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void ClearUnused(void* basePtr, long bits)
        {
            ulong offset = divrem((ulong)bits, 8u, out ulong usedBits);

            if (usedBits != 0)
            {
                *((byte*)basePtr + offset) &= bitmask8((uint)usedBits);
            }
        }
    }
}
