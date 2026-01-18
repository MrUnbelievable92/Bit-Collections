using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using SIMDAlgorithms;

namespace BitCollections
{
    unsafe public static class ByteNumberArrayExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static V LoadVector<V>(this NativeArray<UInt24> array, int index, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where V : unmanaged
        {
            return LoadStore.LoadVector<UInt24, V>(array.GetUnsafePtr(), index, array.Length, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static V LoadVector<V>(this NativeList<UInt24> array, int index, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where V : unmanaged
        {
            return LoadStore.LoadVector<UInt24, V>(array.GetUnsafePtr(), index, array.Length, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static V LoadVector<V>(this NativeSlice<UInt24> array, int index, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where V : unmanaged
        {
            return LoadStore.LoadVector<UInt24, V>(array.GetUnsafePtr(), index, array.Length, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static V LoadVector<V>(this NativeArray<UInt40> array, int index, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where V : unmanaged
        {
            return LoadStore.LoadVector<UInt40, V>(array.GetUnsafePtr(), index, array.Length, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static V LoadVector<V>(this NativeList<UInt40> array, int index, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where V : unmanaged
        {
            return LoadStore.LoadVector<UInt40, V>(array.GetUnsafePtr(), index, array.Length, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static V LoadVector<V>(this NativeSlice<UInt40> array, int index, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where V : unmanaged
        {
            return LoadStore.LoadVector<UInt40, V>(array.GetUnsafePtr(), index, array.Length, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static V LoadVector<V>(this NativeArray<UInt48> array, int index, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where V : unmanaged
        {
            return LoadStore.LoadVector<UInt48, V>(array.GetUnsafePtr(), index, array.Length, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static V LoadVector<V>(this NativeList<UInt48> array, int index, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where V : unmanaged
        {
            return LoadStore.LoadVector<UInt48, V>(array.GetUnsafePtr(), index, array.Length, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static V LoadVector<V>(this NativeSlice<UInt48> array, int index, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where V : unmanaged
        {
            return LoadStore.LoadVector<UInt48, V>(array.GetUnsafePtr(), index, array.Length, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static V LoadVector<V>(this NativeArray<UInt56> array, int index, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where V : unmanaged
        {
            return LoadStore.LoadVector<UInt56, V>(array.GetUnsafePtr(), index, array.Length, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static V LoadVector<V>(this NativeList<UInt56> array, int index, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where V : unmanaged
        {
            return LoadStore.LoadVector<UInt56, V>(array.GetUnsafePtr(), index, array.Length, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static V LoadVector<V>(this NativeSlice<UInt56> array, int index, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where V : unmanaged
        {
            return LoadStore.LoadVector<UInt56, V>(array.GetUnsafePtr(), index, array.Length, memoryAccess);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static V LoadVector<V>(this NativeArray<Int24> array, int index, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where V : unmanaged
        {
            return LoadStore.LoadVector<Int24, V>(array.GetUnsafePtr(), index, array.Length, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static V LoadVector<V>(this NativeList<Int24> array, int index, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where V : unmanaged
        {
            return LoadStore.LoadVector<Int24, V>(array.GetUnsafePtr(), index, array.Length, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static V LoadVector<V>(this NativeSlice<Int24> array, int index, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where V : unmanaged
        {
            return LoadStore.LoadVector<Int24, V>(array.GetUnsafePtr(), index, array.Length, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static V LoadVector<V>(this NativeArray<Int40> array, int index, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where V : unmanaged
        {
            return LoadStore.LoadVector<Int40, V>(array.GetUnsafePtr(), index, array.Length, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static V LoadVector<V>(this NativeList<Int40> array, int index, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where V : unmanaged
        {
            return LoadStore.LoadVector<Int40, V>(array.GetUnsafePtr(), index, array.Length, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static V LoadVector<V>(this NativeSlice<Int40> array, int index, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where V : unmanaged
        {
            return LoadStore.LoadVector<Int40, V>(array.GetUnsafePtr(), index, array.Length, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static V LoadVector<V>(this NativeArray<Int48> array, int index, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where V : unmanaged
        {
            return LoadStore.LoadVector<Int48, V>(array.GetUnsafePtr(), index, array.Length, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static V LoadVector<V>(this NativeList<Int48> array, int index, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where V : unmanaged
        {
            return LoadStore.LoadVector<Int48, V>(array.GetUnsafePtr(), index, array.Length, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static V LoadVector<V>(this NativeSlice<Int48> array, int index, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where V : unmanaged
        {
            return LoadStore.LoadVector<Int48, V>(array.GetUnsafePtr(), index, array.Length, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static V LoadVector<V>(this NativeArray<Int56> array, int index, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where V : unmanaged
        {
            return LoadStore.LoadVector<Int56, V>(array.GetUnsafePtr(), index, array.Length, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static V LoadVector<V>(this NativeList<Int56> array, int index, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where V : unmanaged
        {
            return LoadStore.LoadVector<Int56, V>(array.GetUnsafePtr(), index, array.Length, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static V LoadVector<V>(this NativeSlice<Int56> array, int index, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where V : unmanaged
        {
            return LoadStore.LoadVector<Int56, V>(array.GetUnsafePtr(), index, array.Length, memoryAccess);
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void StoreVector<V>(this NativeArray<UInt24> array, V vector, int index)
            where V : unmanaged
        {
            LoadStore.StoreVector<UInt24, V>(array.GetUnsafePtr(), vector, index, array.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void StoreVector<V>(this NativeList<UInt24> array, V vector, int index)
            where V : unmanaged
        {
            LoadStore.StoreVector<UInt24, V>(array.GetUnsafePtr(), vector, index, array.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void StoreVector<V>(this NativeSlice<UInt24> array, V vector, int index)
            where V : unmanaged
        {
            LoadStore.StoreVector<UInt24, V>(array.GetUnsafePtr(), vector, index, array.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void StoreVector<V>(this NativeArray<UInt40> array, V vector, int index)
            where V : unmanaged
        {
            LoadStore.StoreVector<UInt40, V>(array.GetUnsafePtr(), vector, index, array.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void StoreVector<V>(this NativeList<UInt40> array, V vector, int index)
            where V : unmanaged
        {
            LoadStore.StoreVector<UInt40, V>(array.GetUnsafePtr(), vector, index, array.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void StoreVector<V>(this NativeSlice<UInt40> array, V vector, int index)
            where V : unmanaged
        {
            LoadStore.StoreVector<UInt40, V>(array.GetUnsafePtr(), vector, index, array.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void StoreVector<V>(this NativeArray<UInt48> array, V vector, int index)
            where V : unmanaged
        {
            LoadStore.StoreVector<UInt48, V>(array.GetUnsafePtr(), vector, index, array.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void StoreVector<V>(this NativeList<UInt48> array, V vector, int index)
            where V : unmanaged
        {
            LoadStore.StoreVector<UInt48, V>(array.GetUnsafePtr(), vector, index, array.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void StoreVector<V>(this NativeSlice<UInt48> array, V vector, int index)
            where V : unmanaged
        {
            LoadStore.StoreVector<UInt48, V>(array.GetUnsafePtr(), vector, index, array.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void StoreVector<V>(this NativeArray<UInt56> array, V vector, int index)
            where V : unmanaged
        {
            LoadStore.StoreVector<UInt56, V>(array.GetUnsafePtr(), vector, index, array.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void StoreVector<V>(this NativeList<UInt56> array, V vector, int index)
            where V : unmanaged
        {
            LoadStore.StoreVector<UInt56, V>(array.GetUnsafePtr(), vector, index, array.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void StoreVector<V>(this NativeSlice<UInt56> array, V vector, int index)
            where V : unmanaged
        {
            LoadStore.StoreVector<UInt56, V>(array.GetUnsafePtr(), vector, index, array.Length);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void StoreVector<V>(this NativeArray<Int24> array, V vector, int index)
            where V : unmanaged
        {
            LoadStore.StoreVector<Int24, V>(array.GetUnsafePtr(), vector, index, array.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void StoreVector<V>(this NativeList<Int24> array, V vector, int index)
            where V : unmanaged
        {
            LoadStore.StoreVector<Int24, V>(array.GetUnsafePtr(), vector, index, array.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void StoreVector<V>(this NativeSlice<Int24> array, V vector, int index)
            where V : unmanaged
        {
            LoadStore.StoreVector<Int24, V>(array.GetUnsafePtr(), vector, index, array.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void StoreVector<V>(this NativeArray<Int40> array, V vector, int index)
            where V : unmanaged
        {
            LoadStore.StoreVector<Int40, V>(array.GetUnsafePtr(), vector, index, array.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void StoreVector<V>(this NativeList<Int40> array, V vector, int index)
            where V : unmanaged
        {
            LoadStore.StoreVector<Int40, V>(array.GetUnsafePtr(), vector, index, array.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void StoreVector<V>(this NativeSlice<Int40> array, V vector, int index)
            where V : unmanaged
        {
            LoadStore.StoreVector<Int40, V>(array.GetUnsafePtr(), vector, index, array.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void StoreVector<V>(this NativeArray<Int48> array, V vector, int index)
            where V : unmanaged
        {
            LoadStore.StoreVector<Int48, V>(array.GetUnsafePtr(), vector, index, array.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void StoreVector<V>(this NativeList<Int48> array, V vector, int index)
            where V : unmanaged
        {
            LoadStore.StoreVector<Int48, V>(array.GetUnsafePtr(), vector, index, array.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void StoreVector<V>(this NativeSlice<Int48> array, V vector, int index)
            where V : unmanaged
        {
            LoadStore.StoreVector<Int48, V>(array.GetUnsafePtr(), vector, index, array.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void StoreVector<V>(this NativeArray<Int56> array, V vector, int index)
            where V : unmanaged
        {
            LoadStore.StoreVector<Int56, V>(array.GetUnsafePtr(), vector, index, array.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void StoreVector<V>(this NativeList<Int56> array, V vector, int index)
            where V : unmanaged
        {
            LoadStore.StoreVector<Int56, V>(array.GetUnsafePtr(), vector, index, array.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void StoreVector<V>(this NativeSlice<Int56> array, V vector, int index)
            where V : unmanaged
        {
            LoadStore.StoreVector<Int56, V>(array.GetUnsafePtr(), vector, index, array.Length);
        }
    }
}
