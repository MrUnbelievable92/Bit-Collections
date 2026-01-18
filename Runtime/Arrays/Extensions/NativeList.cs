using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace BitCollections
{
    unsafe public static class NativeListExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Insert<T>(this UnsafeList<T> list, int index, T item)
            where T : unmanaged
        {
            list.InsertRange(index, 1);
            list[index] = item;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Insert<T>(this NativeList<T> list, int index, T item)
            where T : unmanaged
        {
            list.InsertRange(index, 1);
            list[index] = item;
        }
    }
}
