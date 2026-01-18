using Unity.Collections.LowLevel.Unsafe;

namespace BitCollections
{
    unsafe internal struct ListData
    {
        [NativeDisableUnsafePtrRestriction] internal void* Ptr;
        internal int Length;
        internal int Capacity;
    }
}
