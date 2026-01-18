using System.Runtime.CompilerServices;

using static MaxMath.maxmath;

namespace BitCollections
{
    unsafe internal readonly ref struct SubArrayIndexer<T>
        where T : BitInt
    {
        public readonly ulong OuterIndex;
        public readonly ulong InnerIndex;
        public readonly ulong SizeOf;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public SubArrayIndexer(int index)
        {
            SizeOf = default(T).MinFullyPackedBytes;
            ulong length = SizeOf * 8u / default(T).Bits;
            OuterIndex = divrem((ulong)(uint)index, length, out InnerIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void* GetOuterPtr(void* basePtr)
        {
            return (byte*)basePtr + SizeOf * OuterIndex;
        }
    }
}
