using DevTools;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace BitCollections
{
    unsafe internal static class SafetyHelper
    {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
        [BurstDiscard]
        private static void CreateSafetyID<T>(SharedStatic<int> staticSafetyId)
        {
            if (staticSafetyId.Data == 0)
            {
                staticSafetyId.Data = AtomicSafetyHandle.NewStaticSafetyId<T>();
            }
        }

        internal static void InitSafety<T>(Allocator allocator, SharedStatic<int> staticSafetyId, out AtomicSafetyHandle safety, out DisposeSentinel disposeSentinel)
        {
            DisposeSentinel.Create(out safety, out disposeSentinel, 2, allocator);
            CreateSafetyID<T>(staticSafetyId);
            AtomicSafetyHandle.SetStaticSafetyId(ref safety, staticSafetyId.Data);
        }
#endif
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if ENABLE_UNITY_COLLECTIONS_CHECKS
        internal static void Dispose(ref void* ptr, ref Allocator allocator, ref AtomicSafetyHandle safety, ref DisposeSentinel disposeSentinel)
#else
        internal static void Dispose(ref void* ptr, Allocator allocator)
#endif
        {
Assert.IsNotNull(ptr);
Assert.IsGreater((int)allocator, (int)Allocator.None);

            UnsafeUtility.Free(ptr, allocator);
            ptr = null;

#if ENABLE_UNITY_COLLECTIONS_CHECKS
DisposeSentinel.Dispose(ref safety, ref disposeSentinel);
allocator = Allocator.Invalid;
#endif
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if ENABLE_UNITY_COLLECTIONS_CHECKS
        internal static JobHandle Dispose(JobHandle dependency, ref void* ptr, ref Allocator allocator, ref AtomicSafetyHandle safety, ref DisposeSentinel disposeSentinel)
#else
        internal static JobHandle Dispose(JobHandle dependency, ref void* ptr, Allocator allocator)
#endif
        {
Assert.IsNotNull(ptr);
Assert.IsGreater((int)allocator, (int)Allocator.None);

            dependency = new NativeCollectionDisposeJob(ptr, allocator).Schedule(dependency);
            ptr = null;

#if ENABLE_UNITY_COLLECTIONS_CHECKS
DisposeSentinel.Clear(ref disposeSentinel);
AtomicSafetyHandle.Release(safety);
allocator = Allocator.Invalid;
#endif
            return dependency;
        }
    }
}
