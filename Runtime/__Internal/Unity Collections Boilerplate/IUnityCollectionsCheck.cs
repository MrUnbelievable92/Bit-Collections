using System.Runtime.CompilerServices;
using Unity.Collections.LowLevel.Unsafe;

namespace BitCollections
{
    internal interface IUnityCollectionsCheck
    {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        AtomicSafetyHandle GetAtomicSafetyHandle();
#endif
    }

    internal static class IUnityCollectionsCheckExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void CheckReadAndThrow<T>(this T collection)
            where T : IUnityCollectionsCheck
        {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
AtomicSafetyHandle.CheckReadAndThrow(collection.GetAtomicSafetyHandle());
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void CheckWriteAndThrow<T>(this T collection)
            where T : IUnityCollectionsCheck
        {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
AtomicSafetyHandle.CheckWriteAndThrow(collection.GetAtomicSafetyHandle());
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void CheckWriteAndBumpSecondaryVersion<T>(this T collection)
            where T : IUnityCollectionsCheck
        {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
AtomicSafetyHandle.CheckWriteAndBumpSecondaryVersion(collection.GetAtomicSafetyHandle());
#endif
        }
    }
}
