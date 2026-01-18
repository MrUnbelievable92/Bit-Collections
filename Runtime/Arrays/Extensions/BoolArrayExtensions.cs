using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Burst;

using static Unity.Mathematics.math;
using static MaxMath.maxmath;
using DevTools;

namespace BitCollections
{
    unsafe public static class BoolArrayExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void CopyFrom([NoAlias] void* dst, int dstLength, [NoAlias] void* src, int srcLength, int dstIndex, int srcIndex, int count)
        {
Assert.IsNotGreater(count, srcLength - srcIndex);
Assert.IsNotGreater(count, dstLength - dstIndex);

            if (count == -1)
            {
                count = min(srcLength - srcIndex, dstLength - dstIndex);
            }

            PackUnpack.CopyConvertBitToBool(dst, dstIndex, src, srcIndex, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void AddRange(NativeList<bool> list, void* src, int srcLength, int srcIndex, int count)
        {
            int oldLength = list.Length;

            count = count == -1 ? srcLength - srcIndex: count;
            list.ResizeUninitialized(oldLength + count);
            
Assert.IsNotGreater(count, srcLength - srcIndex);
Assert.IsNotGreater(count, list.Length - oldLength);

            PackUnpack.CopyConvertBitToBool(list.GetUnsafePtr(), oldLength, src, srcIndex, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void InsertRange(NativeList<bool> list, int dstIndex, void* src, int srcLength, int srcIndex, int count)
        {
            count = count == -1 ? srcLength - srcIndex: count;
            list.InsertRange(dstIndex, count);
            
Assert.IsNotGreater(count, srcLength - srcIndex);
Assert.IsNotGreater(count, list.Length - dstIndex);

            PackUnpack.CopyConvertBitToBool(list.GetUnsafePtr(), dstIndex, src, srcIndex, count);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CopyFrom(this NativeArray<bool> array, NativeBitArray src, int index = 0, int srcIndex = 0, int count = -1)
        {
            CopyFrom(array.GetUnsafePtr(), array.Length, src.GetUnsafeReadOnlyPtr(), src.Length, index, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CopyFrom(this NativeArray<bool> array, NativeBitList src, int index = 0, int srcIndex = 0, int count = -1)
        {
            CopyFrom(array.GetUnsafePtr(), array.Length, src.GetUnsafeReadOnlyPtr(), src.Length, index, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CopyFrom(this NativeArray<bool> array, bit8 src, int index = 0, int srcIndex = 0, int count = -1)
        {
            CopyFrom(array.GetUnsafePtr(), array.Length, &src, src.Length, index, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CopyFrom(this NativeArray<bool> array, bit16 src, int index = 0, int srcIndex = 0, int count = -1)
        {
            CopyFrom(array.GetUnsafePtr(), array.Length, &src, src.Length, index, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CopyFrom(this NativeArray<bool> array, bit24 src, int index = 0, int srcIndex = 0, int count = -1)
        {
            CopyFrom(array.GetUnsafePtr(), array.Length, &src, src.Length, index, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CopyFrom(this NativeArray<bool> array, bit32 src, int index = 0, int srcIndex = 0, int count = -1)
        {
            CopyFrom(array.GetUnsafePtr(), array.Length, &src, src.Length, index, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CopyFrom(this NativeArray<bool> array, bit40 src, int index = 0, int srcIndex = 0, int count = -1)
        {
            CopyFrom(array.GetUnsafePtr(), array.Length, &src, src.Length, index, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CopyFrom(this NativeArray<bool> array, bit48 src, int index = 0, int srcIndex = 0, int count = -1)
        {
            CopyFrom(array.GetUnsafePtr(), array.Length, &src, src.Length, index, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CopyFrom(this NativeArray<bool> array, bit56 src, int index = 0, int srcIndex = 0, int count = -1)
        {
            CopyFrom(array.GetUnsafePtr(), array.Length, &src, src.Length, index, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CopyFrom(this NativeArray<bool> array, bit64 src, int index = 0, int srcIndex = 0, int count = -1)
        {
            CopyFrom(array.GetUnsafePtr(), array.Length, &src, src.Length, index, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CopyFrom(this NativeList<bool> list, NativeBitArray src, int index = 0, int srcIndex = 0, int count = -1)
        {
            CopyFrom(list.GetUnsafePtr(), list.Length, src.GetUnsafeReadOnlyPtr(), src.Length, index, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CopyFrom(this NativeList<bool> array, bit8 src, int index = 0, int srcIndex = 0, int count = -1)
        {
            CopyFrom(array.GetUnsafePtr(), array.Length, &src, src.Length, index, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CopyFrom(this NativeList<bool> array, bit16 src, int index = 0, int srcIndex = 0, int count = -1)
        {
            CopyFrom(array.GetUnsafePtr(), array.Length, &src, src.Length, index, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CopyFrom(this NativeList<bool> array, bit24 src, int index = 0, int srcIndex = 0, int count = -1)
        {
            CopyFrom(array.GetUnsafePtr(), array.Length, &src, src.Length, index, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CopyFrom(this NativeList<bool> array, bit32 src, int index = 0, int srcIndex = 0, int count = -1)
        {
            CopyFrom(array.GetUnsafePtr(), array.Length, &src, src.Length, index, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CopyFrom(this NativeList<bool> array, bit40 src, int index = 0, int srcIndex = 0, int count = -1)
        {
            CopyFrom(array.GetUnsafePtr(), array.Length, &src, src.Length, index, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CopyFrom(this NativeList<bool> array, bit48 src, int index = 0, int srcIndex = 0, int count = -1)
        {
            CopyFrom(array.GetUnsafePtr(), array.Length, &src, src.Length, index, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CopyFrom(this NativeList<bool> array, bit56 src, int index = 0, int srcIndex = 0, int count = -1)
        {
            CopyFrom(array.GetUnsafePtr(), array.Length, &src, src.Length, index, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CopyFrom(this NativeList<bool> array, bit64 src, int index = 0, int srcIndex = 0, int count = -1)
        {
            CopyFrom(array.GetUnsafePtr(), array.Length, &src, src.Length, index, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CopyFrom(this NativeList<bool> list, NativeBitList src, int index = 0, int srcIndex = 0, int count = -1)
        {
            CopyFrom(list.GetUnsafePtr(), list.Length, src.GetUnsafeReadOnlyPtr(), src.Length, index, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CopyFrom(this NativeSlice<bool> list, NativeBitArray src, int index = 0, int srcIndex = 0, int count = -1)
        {
            CopyFrom(list.GetUnsafePtr(), list.Length, src.GetUnsafeReadOnlyPtr(), src.Length, index, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CopyFrom(this NativeSlice<bool> list, NativeBitList src, int index = 0, int srcIndex = 0, int count = -1)
        {
            CopyFrom(list.GetUnsafePtr(), list.Length, src.GetUnsafeReadOnlyPtr(), src.Length, index, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CopyFrom(this NativeSlice<bool> array, bit8 src, int index = 0, int srcIndex = 0, int count = -1)
        {
            CopyFrom(array.GetUnsafePtr(), array.Length, &src, src.Length, index, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CopyFrom(this NativeSlice<bool> array, bit16 src, int index = 0, int srcIndex = 0, int count = -1)
        {
            CopyFrom(array.GetUnsafePtr(), array.Length, &src, src.Length, index, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CopyFrom(this NativeSlice<bool> array, bit24 src, int index = 0, int srcIndex = 0, int count = -1)
        {
            CopyFrom(array.GetUnsafePtr(), array.Length, &src, src.Length, index, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CopyFrom(this NativeSlice<bool> array, bit32 src, int index = 0, int srcIndex = 0, int count = -1)
        {
            CopyFrom(array.GetUnsafePtr(), array.Length, &src, src.Length, index, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CopyFrom(this NativeSlice<bool> array, bit40 src, int index = 0, int srcIndex = 0, int count = -1)
        {
            CopyFrom(array.GetUnsafePtr(), array.Length, &src, src.Length, index, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CopyFrom(this NativeSlice<bool> array, bit48 src, int index = 0, int srcIndex = 0, int count = -1)
        {
            CopyFrom(array.GetUnsafePtr(), array.Length, &src, src.Length, index, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CopyFrom(this NativeSlice<bool> array, bit56 src, int index = 0, int srcIndex = 0, int count = -1)
        {
            CopyFrom(array.GetUnsafePtr(), array.Length, &src, src.Length, index, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CopyFrom(this NativeSlice<bool> array, bit64 src, int index = 0, int srcIndex = 0, int count = -1)
        {
            CopyFrom(array.GetUnsafePtr(), array.Length, &src, src.Length, index, srcIndex, count);
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddRange(this NativeList<bool> list, NativeBitArray src, int srcIndex = 0, int count = -1)
        {
            AddRange(list, src.GetUnsafeReadOnlyPtr(), src.Length, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddRange(this NativeList<bool> list, NativeBitList src, int srcIndex = 0, int count = -1)
        {
            AddRange(list, src.GetUnsafeReadOnlyPtr(), src.Length, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddRange(this NativeList<bool> list, bit8 src, int srcIndex = 0, int count = -1)
        {
            AddRange(list, &src, src.Length, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddRange(this NativeList<bool> list, bit16 src, int srcIndex = 0, int count = -1)
        {
            AddRange(list, &src, src.Length, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddRange(this NativeList<bool> list, bit24 src, int srcIndex = 0, int count = -1)
        {
            AddRange(list, &src, src.Length, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddRange(this NativeList<bool> list, bit32 src, int srcIndex = 0, int count = -1)
        {
            AddRange(list, &src, src.Length, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddRange(this NativeList<bool> list, bit40 src, int srcIndex = 0, int count = -1)
        {
            AddRange(list, &src, src.Length, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddRange(this NativeList<bool> list, bit48 src, int srcIndex = 0, int count = -1)
        {
            AddRange(list, &src, src.Length, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddRange(this NativeList<bool> list, bit56 src, int srcIndex = 0, int count = -1)
        {
            AddRange(list, &src, src.Length, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddRange(this NativeList<bool> list, bit64 src, int srcIndex = 0, int count = -1)
        {
            AddRange(list, &src, src.Length, srcIndex, count);
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void InsertRange(this NativeList<bool> list, NativeBitArray array, int index = 0, int srcIndex = 0, int count = -1)
        {
            InsertRange(list, index, array.GetUnsafeReadOnlyPtr(), array.Length, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void InsertRange(this NativeList<bool> list, NativeBitList array, int index = 0, int srcIndex = 0, int count = -1)
        {
            InsertRange(list, index, array.GetUnsafeReadOnlyPtr(), array.Length, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void InsertRange(this NativeList<bool> list, bit8 array, int index = 0, int srcIndex = 0, int count = -1)
        {
            InsertRange(list, index, &array, array.Length, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void InsertRange(this NativeList<bool> list, bit16 array, int index = 0, int srcIndex = 0, int count = -1)
        {
            InsertRange(list, index, &array, array.Length, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void InsertRange(this NativeList<bool> list, bit24 array, int index = 0, int srcIndex = 0, int count = -1)
        {
            InsertRange(list, index, &array, array.Length, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void InsertRange(this NativeList<bool> list, bit32 array, int index = 0, int srcIndex = 0, int count = -1)
        {
            InsertRange(list, index, &array, array.Length, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void InsertRange(this NativeList<bool> list, bit40 array, int index = 0, int srcIndex = 0, int count = -1)
        {
            InsertRange(list, index, &array, array.Length, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void InsertRange(this NativeList<bool> list, bit48 array, int index = 0, int srcIndex = 0, int count = -1)
        {
            InsertRange(list, index, &array, array.Length, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void InsertRange(this NativeList<bool> list, bit56 array, int index = 0, int srcIndex = 0, int count = -1)
        {
            InsertRange(list, index, &array, array.Length, srcIndex, count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void InsertRange(this NativeList<bool> list, bit64 array, int index = 0, int srcIndex = 0, int count = -1)
        {
            InsertRange(list, index, &array, array.Length, srcIndex, count);
        }
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static V LoadVector<V>(this NativeArray<bool> list, int index)
            where V : unmanaged
        {
            return LoadStore.LoadVector<UInt8, V>(list.GetUnsafeReadOnlyPtr(), index, list.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static V LoadVector<V>(this NativeList<bool> list, int index)
            where V : unmanaged
        {
            return LoadStore.LoadVector<UInt8, V>(list.GetUnsafeReadOnlyPtr(), index, list.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static V LoadVector<V>(this NativeSlice<bool> list, int index)
            where V : unmanaged
        {
            return LoadStore.LoadVector<UInt8, V>(list.GetUnsafeReadOnlyPtr(), index, list.Length);
        }
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void StoreVector<V>(this NativeArray<bool> list, V vector, int index)
            where V : unmanaged
        {
            LoadStore.StoreVector<UInt8, V>(list.GetUnsafeReadOnlyPtr(), vector, index, list.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void StoreVector<V>(this NativeList<bool> list, V vector, int index)
            where V : unmanaged
        {
            LoadStore.StoreVector<UInt8, V>(list.GetUnsafeReadOnlyPtr(), vector, index, list.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void StoreVector<V>(this NativeSlice<bool> list, V vector, int index)
            where V : unmanaged
        {
            LoadStore.StoreVector<UInt8, V>(list.GetUnsafeReadOnlyPtr(), vector, index, list.Length);
        }
    }
}
