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
        [NativeDisableUnsafePtrRestriction] public void* ptr;

        public Allocator allocator;


        public void Execute()
        {
            UnsafeUtility.Free(ptr, allocator);
        }
    }
}