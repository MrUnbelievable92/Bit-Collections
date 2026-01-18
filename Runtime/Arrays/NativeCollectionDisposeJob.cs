using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Burst;

namespace BitCollections
{
    [BurstCompile]
    [NativeContainer]
    unsafe internal struct NativeCollectionDisposeJob : IJob
    {
        [NativeDisableUnsafePtrRestriction]
        public void* Ptr;
        public Allocator Allocator;


        public NativeCollectionDisposeJob(void* ptr, Allocator allocator)
        {
            Ptr = ptr;
            Allocator = allocator;
        }


        public void Execute()
        {
            UnsafeUtility.Free(Ptr, Allocator);
        }
    }
}