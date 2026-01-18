using System.Runtime.CompilerServices;
using Unity.Mathematics;
using Unity.Collections;
using DevTools;
using MaxMath;
using SIMDAlgorithms;

using static MaxMath.maxmath;
using Unity.Burst.CompilerServices;

namespace BitCollections
{
    unsafe internal static partial class LoadStore
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static V LoadVector<T, V>(void* basePtr, int index, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T : BitInt
            where V : unmanaged
        {
            if (typeof(V) == typeof(bit8))     return LoadBit8<T>(basePtr, index, length, memoryAccess).Reinterpret<bit8, V>();
            if (typeof(V) == typeof(bit16))    return LoadBit16<T>(basePtr, index, length, memoryAccess).Reinterpret<bit16, V>();
            if (typeof(V) == typeof(bit24))    return LoadBit24<T>(basePtr, index, length, memoryAccess).Reinterpret<bit24, V>();
            if (typeof(V) == typeof(bit32))    return LoadBit32<T>(basePtr, index, length, memoryAccess).Reinterpret<bit32, V>();
            if (typeof(V) == typeof(bit40))    return LoadBit40<T>(basePtr, index, length, memoryAccess).Reinterpret<bit40, V>();
            if (typeof(V) == typeof(bit48))    return LoadBit48<T>(basePtr, index, length, memoryAccess).Reinterpret<bit48, V>();
            if (typeof(V) == typeof(bit56))    return LoadBit56<T>(basePtr, index, length, memoryAccess).Reinterpret<bit56, V>();
            if (typeof(V) == typeof(bit64))    return LoadBit64<T>(basePtr, index, length, memoryAccess).Reinterpret<bit64, V>();
                                               
            if (typeof(V) == typeof(Int2x4))   return LoadInt2x4<T>(basePtr, index, length, memoryAccess).Reinterpret<Int2x4, V>();
            if (typeof(V) == typeof(Int2x8))   return LoadInt2x8<T>(basePtr, index, length, memoryAccess).Reinterpret<Int2x8, V>();
            if (typeof(V) == typeof(Int2x12))  return LoadInt2x12<T>(basePtr, index, length, memoryAccess).Reinterpret<Int2x12, V>();
            if (typeof(V) == typeof(Int2x16))  return LoadInt2x16<T>(basePtr, index, length, memoryAccess).Reinterpret<Int2x16, V>();
            if (typeof(V) == typeof(Int2x20))  return LoadInt2x20<T>(basePtr, index, length, memoryAccess).Reinterpret<Int2x20, V>();
            if (typeof(V) == typeof(Int2x24))  return LoadInt2x24<T>(basePtr, index, length, memoryAccess).Reinterpret<Int2x24, V>();
            if (typeof(V) == typeof(Int2x28))  return LoadInt2x28<T>(basePtr, index, length, memoryAccess).Reinterpret<Int2x28, V>();
            if (typeof(V) == typeof(Int2x32))  return LoadInt2x32<T>(basePtr, index, length, memoryAccess).Reinterpret<Int2x32, V>();
            if (typeof(V) == typeof(UInt2x4))  return LoadInt2x4<T>(basePtr, index, length, memoryAccess).Reinterpret<Int2x4, V>();
            if (typeof(V) == typeof(UInt2x8))  return LoadInt2x8<T>(basePtr, index, length, memoryAccess).Reinterpret<Int2x8, V>();
            if (typeof(V) == typeof(UInt2x12)) return LoadInt2x12<T>(basePtr, index, length, memoryAccess).Reinterpret<Int2x12, V>();
            if (typeof(V) == typeof(UInt2x16)) return LoadInt2x16<T>(basePtr, index, length, memoryAccess).Reinterpret<Int2x16, V>();
            if (typeof(V) == typeof(UInt2x20)) return LoadInt2x20<T>(basePtr, index, length, memoryAccess).Reinterpret<Int2x20, V>();
            if (typeof(V) == typeof(UInt2x24)) return LoadInt2x24<T>(basePtr, index, length, memoryAccess).Reinterpret<Int2x24, V>();
            if (typeof(V) == typeof(UInt2x28)) return LoadInt2x28<T>(basePtr, index, length, memoryAccess).Reinterpret<Int2x28, V>();
            if (typeof(V) == typeof(UInt2x32)) return LoadInt2x32<T>(basePtr, index, length, memoryAccess).Reinterpret<Int2x32, V>();
                                               
            if (typeof(V) == typeof(Int3x8))   return LoadInt3x8<T>(basePtr, index, length, memoryAccess).Reinterpret<Int3x8, V>();
            if (typeof(V) == typeof(Int3x16))  return LoadInt3x16<T>(basePtr, index, length, memoryAccess).Reinterpret<Int3x16, V>();
            if (typeof(V) == typeof(UInt3x8))  return LoadInt3x8<T>(basePtr, index, length, memoryAccess).Reinterpret<Int3x8, V>();
            if (typeof(V) == typeof(UInt3x16)) return LoadInt3x16<T>(basePtr, index, length, memoryAccess).Reinterpret<Int3x16, V>();
                                               
            if (typeof(V) == typeof(Int4x2))   return LoadInt4x2<T>(basePtr, index, length, memoryAccess).Reinterpret<Int4x2, V>();
            if (typeof(V) == typeof(Int4x4))   return LoadInt4x4<T>(basePtr, index, length, memoryAccess).Reinterpret<Int4x4, V>();
            if (typeof(V) == typeof(Int4x6))   return LoadInt4x6<T>(basePtr, index, length, memoryAccess).Reinterpret<Int4x6, V>();
            if (typeof(V) == typeof(Int4x8))   return LoadInt4x8<T>(basePtr, index, length, memoryAccess).Reinterpret<Int4x8, V>();
            if (typeof(V) == typeof(Int4x10))  return LoadInt4x10<T>(basePtr, index, length, memoryAccess).Reinterpret<Int4x10, V>();
            if (typeof(V) == typeof(Int4x12))  return LoadInt4x12<T>(basePtr, index, length, memoryAccess).Reinterpret<Int4x12, V>();
            if (typeof(V) == typeof(Int4x14))  return LoadInt4x14<T>(basePtr, index, length, memoryAccess).Reinterpret<Int4x14, V>();
            if (typeof(V) == typeof(Int4x16))  return LoadInt4x16<T>(basePtr, index, length, memoryAccess).Reinterpret<Int4x16, V>();
            if (typeof(V) == typeof(UInt4x2))  return LoadInt4x2<T>(basePtr, index, length, memoryAccess).Reinterpret<Int4x2, V>();
            if (typeof(V) == typeof(UInt4x4))  return LoadInt4x4<T>(basePtr, index, length, memoryAccess).Reinterpret<Int4x4, V>();
            if (typeof(V) == typeof(UInt4x6))  return LoadInt4x6<T>(basePtr, index, length, memoryAccess).Reinterpret<Int4x6, V>();
            if (typeof(V) == typeof(UInt4x8))  return LoadInt4x8<T>(basePtr, index, length, memoryAccess).Reinterpret<Int4x8, V>();
            if (typeof(V) == typeof(UInt4x10)) return LoadInt4x10<T>(basePtr, index, length, memoryAccess).Reinterpret<Int4x10, V>();
            if (typeof(V) == typeof(UInt4x12)) return LoadInt4x12<T>(basePtr, index, length, memoryAccess).Reinterpret<Int4x12, V>();
            if (typeof(V) == typeof(UInt4x14)) return LoadInt4x14<T>(basePtr, index, length, memoryAccess).Reinterpret<Int4x14, V>();
            if (typeof(V) == typeof(UInt4x16)) return LoadInt4x16<T>(basePtr, index, length, memoryAccess).Reinterpret<Int4x16, V>();
                                               
            if (typeof(V) == typeof(Int5x8))   return LoadInt5x8<T>(basePtr, index, length, memoryAccess).Reinterpret<Int5x8, V>();
            if (typeof(V) == typeof(UInt5x8))  return LoadInt5x8<T>(basePtr, index, length, memoryAccess).Reinterpret<Int5x8, V>();
                                               
            if (typeof(V) == typeof(Int6x4))   return LoadInt6x4<T>(basePtr, index, length, memoryAccess).Reinterpret<Int6x4, V>();
            if (typeof(V) == typeof(Int6x8))   return LoadInt6x8<T>(basePtr, index, length, memoryAccess).Reinterpret<Int6x8, V>();
            if (typeof(V) == typeof(UInt6x4))  return LoadInt6x4<T>(basePtr, index, length, memoryAccess).Reinterpret<Int6x4, V>();
            if (typeof(V) == typeof(UInt6x8))  return LoadInt6x8<T>(basePtr, index, length, memoryAccess).Reinterpret<Int6x8, V>();
                                               
            if (typeof(V) == typeof(Int7x8))   return LoadInt7x8<T>(basePtr, index, length, memoryAccess).Reinterpret<Int7x8, V>();
            if (typeof(V) == typeof(UInt7x8))  return LoadInt7x8<T>(basePtr, index, length, memoryAccess).Reinterpret<Int7x8, V>();
                                               
            if (typeof(V) == typeof(Int10x4))  return LoadInt10x4<T>(basePtr, index, length, memoryAccess).Reinterpret<Int10x4, V>();
            if (typeof(V) == typeof(UInt10x4)) return LoadInt10x4<T>(basePtr, index, length, memoryAccess).Reinterpret<Int10x4, V>();
                                               
            if (typeof(V) == typeof(Int12x2))  return LoadInt12x2<T>(basePtr, index, length, memoryAccess).Reinterpret<Int12x2, V>();
            if (typeof(V) == typeof(Int12x4))  return LoadInt12x4<T>(basePtr, index, length, memoryAccess).Reinterpret<Int12x4, V>();
            if (typeof(V) == typeof(UInt12x2)) return LoadInt12x2<T>(basePtr, index, length, memoryAccess).Reinterpret<Int12x2, V>();
            if (typeof(V) == typeof(UInt12x4)) return LoadInt12x4<T>(basePtr, index, length, memoryAccess).Reinterpret<Int12x4, V>();
                                               
            if (typeof(V) == typeof(Int14x4))  return LoadInt14x4<T>(basePtr, index, length, memoryAccess).Reinterpret<Int14x4, V>();
            if (typeof(V) == typeof(UInt14x4)) return LoadInt14x4<T>(basePtr, index, length, memoryAccess).Reinterpret<Int14x4, V>();
                                               
            if (typeof(V) == typeof(Int20x2))  return LoadInt20x2<T>(basePtr, index, length, memoryAccess).Reinterpret<Int20x2, V>();
            if (typeof(V) == typeof(UInt20x2)) return LoadInt20x2<T>(basePtr, index, length, memoryAccess).Reinterpret<Int20x2, V>();
                                               
            if (typeof(V) == typeof(Int28x2))  return LoadInt28x2<T>(basePtr, index, length, memoryAccess).Reinterpret<Int28x2, V>();
            if (typeof(V) == typeof(UInt28x2)) return LoadInt28x2<T>(basePtr, index, length, memoryAccess).Reinterpret<Int28x2, V>();
                                               
            if (typeof(V) == typeof(sbyte2))   return LoadByte2<T>(basePtr, index, length, memoryAccess).Reinterpret<byte2, V>();
            if (typeof(V) == typeof(sbyte3))   return LoadByte3<T>(basePtr, index, length, memoryAccess).Reinterpret<byte3, V>();
            if (typeof(V) == typeof(sbyte4))   return LoadByte4<T>(basePtr, index, length, memoryAccess).Reinterpret<byte4, V>();
            if (typeof(V) == typeof(sbyte8))   return LoadByte8<T>(basePtr, index, length, memoryAccess).Reinterpret<byte8, V>();
            if (typeof(V) == typeof(sbyte16))  return LoadByte16<T>(basePtr, index, length, memoryAccess).Reinterpret<byte16, V>();
            if (typeof(V) == typeof(sbyte32))  return LoadByte32<T>(basePtr, index, length, memoryAccess).Reinterpret<byte32, V>();
            if (typeof(V) == typeof(byte2))    return LoadByte2<T>(basePtr, index, length, memoryAccess).Reinterpret<byte2, V>();
            if (typeof(V) == typeof(byte3))    return LoadByte3<T>(basePtr, index, length, memoryAccess).Reinterpret<byte3, V>();
            if (typeof(V) == typeof(byte4))    return LoadByte4<T>(basePtr, index, length, memoryAccess).Reinterpret<byte4, V>();
            if (typeof(V) == typeof(byte8))    return LoadByte8<T>(basePtr, index, length, memoryAccess).Reinterpret<byte8, V>();
            if (typeof(V) == typeof(byte16))   return LoadByte16<T>(basePtr, index, length, memoryAccess).Reinterpret<byte16, V>();
            if (typeof(V) == typeof(byte32))   return LoadByte32<T>(basePtr, index, length, memoryAccess).Reinterpret<byte32, V>();
                                               
            if (typeof(V) == typeof(short2))   return LoadShort2<T>(basePtr, index, length, memoryAccess).Reinterpret<short2, V>();
            if (typeof(V) == typeof(short3))   return LoadShort3<T>(basePtr, index, length, memoryAccess).Reinterpret<short3, V>();
            if (typeof(V) == typeof(short4))   return LoadShort4<T>(basePtr, index, length, memoryAccess).Reinterpret<short4, V>();
            if (typeof(V) == typeof(short8))   return LoadShort8<T>(basePtr, index, length, memoryAccess).Reinterpret<short8, V>();
            if (typeof(V) == typeof(short16))  return LoadShort16<T>(basePtr, index, length, memoryAccess).Reinterpret<short16, V>();
            if (typeof(V) == typeof(ushort2))  return LoadShort2<T>(basePtr, index, length, memoryAccess).Reinterpret<short2, V>();
            if (typeof(V) == typeof(ushort3))  return LoadShort3<T>(basePtr, index, length, memoryAccess).Reinterpret<short3, V>();
            if (typeof(V) == typeof(ushort4))  return LoadShort4<T>(basePtr, index, length, memoryAccess).Reinterpret<short4, V>();
            if (typeof(V) == typeof(ushort8))  return LoadShort8<T>(basePtr, index, length, memoryAccess).Reinterpret<short8, V>();
            if (typeof(V) == typeof(ushort16)) return LoadShort16<T>(basePtr, index, length, memoryAccess).Reinterpret<short16, V>();
                                               
            if (typeof(V) == typeof(int2))     return LoadInt2<T>(basePtr, index, length, memoryAccess).Reinterpret<int2, V>();
            if (typeof(V) == typeof(int3))     return LoadInt3<T>(basePtr, index, length, memoryAccess).Reinterpret<int3, V>();
            if (typeof(V) == typeof(int4))     return LoadInt4<T>(basePtr, index, length, memoryAccess).Reinterpret<int4, V>();
            if (typeof(V) == typeof(int8))     return LoadInt8<T>(basePtr, index, length, memoryAccess).Reinterpret<int8, V>();
            if (typeof(V) == typeof(uint2))    return LoadInt2<T>(basePtr, index, length, memoryAccess).Reinterpret<int2, V>();
            if (typeof(V) == typeof(uint3))    return LoadInt3<T>(basePtr, index, length, memoryAccess).Reinterpret<int3, V>();
            if (typeof(V) == typeof(uint4))    return LoadInt4<T>(basePtr, index, length, memoryAccess).Reinterpret<int4, V>();
            if (typeof(V) == typeof(uint8))    return LoadInt8<T>(basePtr, index, length, memoryAccess).Reinterpret<int8, V>();
                                               
            if (typeof(V) == typeof(long2))    return LoadLong2<T>(basePtr, index, length, memoryAccess).Reinterpret<long2, V>();
            if (typeof(V) == typeof(long3))    return LoadLong3<T>(basePtr, index, length, memoryAccess).Reinterpret<long3, V>();
            if (typeof(V) == typeof(long4))    return LoadLong4<T>(basePtr, index, length, memoryAccess).Reinterpret<long4, V>();
            if (typeof(V) == typeof(ulong2))   return LoadLong2<T>(basePtr, index, length, memoryAccess).Reinterpret<long2, V>();
            if (typeof(V) == typeof(ulong3))   return LoadLong3<T>(basePtr, index, length, memoryAccess).Reinterpret<long3, V>();
            if (typeof(V) == typeof(ulong4))   return LoadLong4<T>(basePtr, index, length, memoryAccess).Reinterpret<long4, V>();
                                               
            if (typeof(V) == typeof(bool2))   return LoadByte2<T>(basePtr, index, length, memoryAccess).Reinterpret<byte2, V>();
            if (typeof(V) == typeof(bool3))   return LoadByte3<T>(basePtr, index, length, memoryAccess).Reinterpret<byte3, V>();
            if (typeof(V) == typeof(bool4))   return LoadByte4<T>(basePtr, index, length, memoryAccess).Reinterpret<byte4, V>();
            if (typeof(V) == typeof(bool8))   return LoadByte8<T>(basePtr, index, length, memoryAccess).Reinterpret<byte8, V>();
            if (typeof(V) == typeof(bool16))  return LoadByte16<T>(basePtr, index, length, memoryAccess).Reinterpret<byte16, V>();
            if (typeof(V) == typeof(bool32))  return LoadByte32<T>(basePtr, index, length, memoryAccess).Reinterpret<byte32, V>();

            throw new System.TypeAccessException($"{typeof(V)}");
        }

        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static byte LoadByte<T>(void* basePtr, int startIndex, int count, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T : BitInt 
        {
            byte load = Uninitialized<byte>.Create();
            CopyAscending<T>(basePtr, startIndex, &load, 0, count);
            return load;
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static ushort LoadUShort<T>(void* basePtr, int startIndex, int count, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T : BitInt
        {
            ushort load = Uninitialized<ushort>.Create();
            CopyAscending<T>(basePtr, startIndex, &load, 0, count);
            return load;
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static uint LoadUInt<T>(void* basePtr, int startIndex, int count, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T : BitInt
        {        
            uint load = Uninitialized<uint>.Create();
            CopyAscending<T>(basePtr, startIndex, &load, 0, count);
            return load;
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static ulong LoadULong<T>(void* basePtr, int startIndex, int count, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T : BitInt
        {
            ulong load = Uninitialized<ulong>.Create();
            CopyAscending<T>(basePtr, startIndex, &load, 0, count);
            return load;
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt128 LoadUInt128<T>(void* basePtr, int startIndex, int count, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T : BitInt
        {
            UInt128 load = Uninitialized<UInt128>.Create();
            CopyAscending<T>(basePtr, startIndex, &load, 0, count);
            return load;
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static __UInt256__ LoadUInt256<T>(void* basePtr, int startIndex, int count, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T : BitInt
        {
            __UInt256__ load = Uninitialized<__UInt256__>.Create();
            CopyAscending<T>(basePtr, startIndex, &load, 0, count);
            return load;
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static __UInt512__ LoadUInt512<T>(void* basePtr, int startIndex, int count, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T : BitInt
        {
            __UInt512__ load = Uninitialized<__UInt512__>.Create();
            CopyAscending<T>(basePtr, startIndex, &load, 0, count);
            return load;
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static __UInt1024__ LoadUInt1024<T>(void* basePtr, int startIndex, int count, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T : BitInt
        {
            __UInt1024__ load = Uninitialized<__UInt1024__>.Create();
            CopyAscending<T>(basePtr, startIndex, &load, 0, count);
            return load;
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static __UInt2048__ LoadUInt2048<T>(void* basePtr, int startIndex, int count, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T : BitInt
        {
            __UInt2048__ load = Uninitialized<__UInt2048__>.Create();
            CopyAscending<T>(basePtr, startIndex, &load, 0, count);
            return load;
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static __UInt4096__ LoadUInt4096<T>(void* basePtr, int startIndex, int count, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T : BitInt
        {
            __UInt4096__ load = Uninitialized<__UInt4096__>.Create();
            CopyAscending<T>(basePtr, startIndex, &load, 0, count);
            return load;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bit8 LoadBit8<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 7, length);

            if (default(T).Bits == 1)
            {
                bit8 ret = Uninitialized<bit8>.Create();
                CopyAscending<T>(basePtr, scalarIndex, &ret, 0, 8);
                return ret;
            }

            if (default(T).Bits * 8 <= 16)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUShort<T>(basePtr, scalarIndex, 8)).GetField<ushort, bit8>(0);
            }
            else if (default(T).Bits * 8 <= 32)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt<T>(basePtr, scalarIndex, 8)).GetField<uint, bit8>(0);
            }
            else if (default(T).Bits * 8 <= 64)
            {
                return PackUnpack.DownCast<T, Bit>(LoadULong<T>(basePtr, scalarIndex, 8)).GetField<ulong, bit8>(0);
            }
            else if (default(T).Bits * 8 <= 128)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt128<T>(basePtr, scalarIndex, 8)).GetField<UInt128, bit8>(0);
            }
            else if (default(T).Bits * 8 <= 256)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt256<T>(basePtr, scalarIndex, 8)).GetField<__UInt256__, bit8>(0);
            }
            else
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt512<T>(basePtr, scalarIndex, 8)).GetField<__UInt512__, bit8>(0);
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bit16 LoadBit16<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 15, length);
            
            if (default(T).Bits == 1)
            {
                bit16 ret = Uninitialized<bit16>.Create();
                CopyAscending<T>(basePtr, scalarIndex, &ret, 0, 16);
                return ret;
            }

            if (default(T).Bits * 16 <= 32)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt<T>(basePtr, scalarIndex, 16)).GetField<uint, bit16>(0);
            }
            else if (default(T).Bits * 16 <= 64)
            {
                return PackUnpack.DownCast<T, Bit>(LoadULong<T>(basePtr, scalarIndex, 16)).GetField<ulong, bit16>(0);
            }
            else if (default(T).Bits * 16 <= 128)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt128<T>(basePtr, scalarIndex, 16)).GetField<UInt128, bit16>(0);
            }
            else if (default(T).Bits * 16 <= 256)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt256<T>(basePtr, scalarIndex, 16)).GetField<__UInt256__, bit16>(0);
            }
            else if (default(T).Bits * 16 <= 512)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt512<T>(basePtr, scalarIndex, 16)).GetField<__UInt512__, bit16>(0);
            }
            else
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt1024<T>(basePtr, scalarIndex, 16)).GetField<__UInt1024__, bit16>(0);
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bit24 LoadBit24<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 23, length);
            
            if (default(T).Bits == 1)
            {
                bit24 ret = Uninitialized<bit24>.Create();
                CopyAscending<T>(basePtr, scalarIndex, &ret, 0, 24);
                return ret;
            }

            if (default(T).Bits * 24 <= 32)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt<T>(basePtr, scalarIndex, 24)).GetField<uint, bit24>(0);
            }
            else if (default(T).Bits * 24 <= 64)
            {
                return PackUnpack.DownCast<T, Bit>(LoadULong<T>(basePtr, scalarIndex, 24)).GetField<ulong, bit24>(0);
            }
            else if (default(T).Bits * 24 <= 128)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt128<T>(basePtr, scalarIndex, 24)).GetField<UInt128, bit24>(0);
            }
            else if (default(T).Bits * 24 <= 256)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt256<T>(basePtr, scalarIndex, 24)).GetField<__UInt256__, bit24>(0);
            }
            else if (default(T).Bits * 24 <= 512)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt512<T>(basePtr, scalarIndex, 24)).GetField<__UInt512__, bit24>(0);
            }
            else if (default(T).Bits * 24 <= 1024)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt1024<T>(basePtr, scalarIndex, 24)).GetField<__UInt1024__, bit24>(0);
            }
            else
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt2048<T>(basePtr, scalarIndex, 24)).GetField<__UInt2048__, bit24>(0);
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bit32 LoadBit32<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 31, length);
            
            if (default(T).Bits == 1)
            {
                bit32 ret = Uninitialized<bit32>.Create();
                CopyAscending<T>(basePtr, scalarIndex, &ret, 0, 32);
                return ret;
            }

            if (default(T).Bits * 32 <= 64)
            {
                return PackUnpack.DownCast<T, Bit>(LoadULong<T>(basePtr, scalarIndex, 32)).GetField<ulong, bit32>(0);
            }
            else if (default(T).Bits * 32 <= 128)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt128<T>(basePtr, scalarIndex, 32)).GetField<UInt128, bit32>(0);
            }
            else if (default(T).Bits * 32 <= 256)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt256<T>(basePtr, scalarIndex, 32)).GetField<__UInt256__, bit32>(0);
            }
            else if (default(T).Bits * 32 <= 512)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt512<T>(basePtr, scalarIndex, 32)).GetField<__UInt512__, bit32>(0);
            }
            else if (default(T).Bits * 32 <= 1024)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt1024<T>(basePtr, scalarIndex, 32)).GetField<__UInt1024__, bit32>(0);
            }
            else
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt2048<T>(basePtr, scalarIndex, 32)).GetField<__UInt2048__, bit32>(0);
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bit40 LoadBit40<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 39, length);
            
            if (default(T).Bits == 1)
            {
                bit40 ret = Uninitialized<bit40>.Create();
                CopyAscending<T>(basePtr, scalarIndex, &ret, 0, 40);
                return ret;
            }

            if (default(T).Bits * 40 <= 64)
            {
                return PackUnpack.DownCast<T, Bit>(LoadULong<T>(basePtr, scalarIndex, 40)).GetField<ulong, bit40>(0);
            }
            else if (default(T).Bits * 40 <= 128)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt128<T>(basePtr, scalarIndex, 40)).GetField<UInt128, bit40>(0);
            }
            else if (default(T).Bits * 40 <= 256)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt256<T>(basePtr, scalarIndex, 40)).GetField<__UInt256__, bit40>(0);
            }
            else if (default(T).Bits * 40 <= 512)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt512<T>(basePtr, scalarIndex, 40)).GetField<__UInt512__, bit40>(0);
            }
            else if (default(T).Bits * 40 <= 1024)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt1024<T>(basePtr, scalarIndex, 40)).GetField<__UInt1024__, bit40>(0);
            }
            else if (default(T).Bits * 40 <= 2048)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt2048<T>(basePtr, scalarIndex, 40)).GetField<__UInt2048__, bit40>(0);
            }
            else
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt4096<T>(basePtr, scalarIndex, 40)).GetField<__UInt4096__, bit40>(0);
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bit48 LoadBit48<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 47, length);
            
            if (default(T).Bits == 1)
            {
                bit48 ret = Uninitialized<bit48>.Create();
                CopyAscending<T>(basePtr, scalarIndex, &ret, 0, 48);
                return ret;
            }

            if (default(T).Bits * 48 <= 64)
            {
                return PackUnpack.DownCast<T, Bit>(LoadULong<T>(basePtr, scalarIndex, 48)).GetField<ulong, bit48>(0);
            }
            else if (default(T).Bits * 48 <= 128)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt128<T>(basePtr, scalarIndex, 48)).GetField<UInt128, bit48>(0);
            }
            else if (default(T).Bits * 48 <= 256)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt256<T>(basePtr, scalarIndex, 48)).GetField<__UInt256__, bit48>(0);
            }
            else if (default(T).Bits * 48 <= 512)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt512<T>(basePtr, scalarIndex, 48)).GetField<__UInt512__, bit48>(0);
            }
            else if (default(T).Bits * 48 <= 1024)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt1024<T>(basePtr, scalarIndex, 48)).GetField<__UInt1024__, bit48>(0);
            }
            else if (default(T).Bits * 48 <= 2048)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt2048<T>(basePtr, scalarIndex, 48)).GetField<__UInt2048__, bit48>(0);
            }
            else
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt4096<T>(basePtr, scalarIndex, 48)).GetField<__UInt4096__, bit48>(0);
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bit56 LoadBit56<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 55, length);
            
            if (default(T).Bits == 1)
            {
                bit56 ret = Uninitialized<bit56>.Create();
                CopyAscending<T>(basePtr, scalarIndex, &ret, 0, 56);
                return ret;
            }

            if (default(T).Bits * 56 <= 64)
            {
                return PackUnpack.DownCast<T, Bit>(LoadULong<T>(basePtr, scalarIndex, 56)).GetField<ulong, bit56>(0);
            }
            else if (default(T).Bits * 56 <= 128)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt128<T>(basePtr, scalarIndex, 56)).GetField<UInt128, bit56>(0);
            }
            else if (default(T).Bits * 56 <= 256)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt256<T>(basePtr, scalarIndex, 56)).GetField<__UInt256__, bit56>(0);
            }
            else if (default(T).Bits * 56 <= 512)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt512<T>(basePtr, scalarIndex, 56)).GetField<__UInt512__, bit56>(0);
            }
            else if (default(T).Bits * 56 <= 1024)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt1024<T>(basePtr, scalarIndex, 56)).GetField<__UInt1024__, bit56>(0);
            }
            else if (default(T).Bits * 56 <= 2048)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt2048<T>(basePtr, scalarIndex, 56)).GetField<__UInt2048__, bit56>(0);
            }
            else
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt4096<T>(basePtr, scalarIndex, 56)).GetField<__UInt4096__, bit56>(0);
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bit64 LoadBit64<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 63, length);
            
            if (default(T).Bits == 1)
            {
                bit64 ret = Uninitialized<bit64>.Create();
                CopyAscending<T>(basePtr, scalarIndex, &ret, 0, 64);
                return ret;
            }

            if (default(T).Bits * 64 <= 128)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt128<T>(basePtr, scalarIndex, 64)).GetField<UInt128, bit64>(0);
            }
            else if (default(T).Bits * 64 <= 256)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt256<T>(basePtr, scalarIndex, 64)).GetField<__UInt256__, bit64>(0);
            }
            else if (default(T).Bits * 64 <= 512)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt512<T>(basePtr, scalarIndex, 64)).GetField<__UInt512__, bit64>(0);
            }
            else if (default(T).Bits * 64 <= 1024)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt1024<T>(basePtr, scalarIndex, 64)).GetField<__UInt1024__, bit64>(0);
            }
            else if (default(T).Bits * 64 <= 2048)
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt2048<T>(basePtr, scalarIndex, 64)).GetField<__UInt2048__, bit64>(0);
            }
            else
            {
                return PackUnpack.DownCast<T, Bit>(LoadUInt4096<T>(basePtr, scalarIndex, 64)).GetField<__UInt4096__, bit64>(0);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Int2x4 LoadInt2x4<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 3, length);
            
            if (default(T).Bits == 2)
            {
                Int2x4 ret = Uninitialized<Int2x4>.Create();
                CopyAscending<T>(basePtr, scalarIndex, &ret, 0, 4);
                return ret;
            }

            if (default(T).Bits < 2)
            {
                return PackUnpack.UpCast8<T, UInt2>(LoadByte<T>(basePtr, scalarIndex, 4)).GetField<byte, Int2x4>(0);
            }
            else
            {
                if (default(T).Bits * 4 <= 16)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUShort<T>(basePtr, scalarIndex, 4)).GetField<ushort, Int2x4>(0);
                }
                else if (default(T).Bits * 4 <= 32)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt<T>(basePtr, scalarIndex, 4)).GetField<uint, Int2x4>(0);
                }
                else if (default(T).Bits * 4 <= 64)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadULong<T>(basePtr, scalarIndex, 4)).GetField<ulong, Int2x4>(0);
                }
                else if (default(T).Bits * 4 <= 128)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt128<T>(basePtr, scalarIndex, 4)).GetField<UInt128, Int2x4>(0);
                }
                else 
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt256<T>(basePtr, scalarIndex, 4)).GetField<__UInt256__, Int2x4>(0);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Int2x8 LoadInt2x8<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 7, length);
            
            if (default(T).Bits == 2)
            {
                Int2x8 ret = Uninitialized<Int2x8>.Create();
                CopyAscending<T>(basePtr, scalarIndex, &ret, 0, 8);
                return ret;
            }

            if (default(T).Bits < 2)
            {
                return PackUnpack.UpCast16<T, UInt2>(LoadByte<T>(basePtr, scalarIndex, 8)).GetField<ushort, Int2x8>(0);
            }
            else
            {
                if (default(T).Bits * 8 <= 32)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt<T>(basePtr, scalarIndex, 8)).GetField<uint, Int2x8>(0);
                }
                else if (default(T).Bits * 8 <= 64)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadULong<T>(basePtr, scalarIndex, 8)).GetField<ulong, Int2x8>(0);
                }
                else if (default(T).Bits * 8 <= 128)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt128<T>(basePtr, scalarIndex, 8)).GetField<UInt128, Int2x8>(0);
                }
                else if (default(T).Bits * 8 <= 256)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt256<T>(basePtr, scalarIndex, 8)).GetField<__UInt256__, Int2x8>(0);
                }
                else
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt512<T>(basePtr, scalarIndex, 8)).GetField<__UInt512__, Int2x8>(0);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Int2x12 LoadInt2x12<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 11, length);
            
            if (default(T).Bits == 2)
            {
                Int2x12 ret = Uninitialized<Int2x12>.Create();
                CopyAscending<T>(basePtr, scalarIndex, &ret, 0, 12);
                return ret;
            }

            if (default(T).Bits < 2)
            {
                return PackUnpack.UpCast32<T, UInt2>(LoadUShort<T>(basePtr, scalarIndex, 12)).GetField<uint, Int2x12>(0);
            }
            else
            {
                if (default(T).Bits * 12 <= 32)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt<T>(basePtr, scalarIndex, 12)).GetField<uint, Int2x12>(0);
                }
                else if (default(T).Bits * 12 <= 64)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadULong<T>(basePtr, scalarIndex, 12)).GetField<ulong, Int2x12>(0);
                }
                else if (default(T).Bits * 12 <= 128)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt128<T>(basePtr, scalarIndex, 12)).GetField<UInt128, Int2x12>(0);
                }
                else if (default(T).Bits * 12 <= 256)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt256<T>(basePtr, scalarIndex, 12)).GetField<__UInt256__, Int2x12>(0);
                }
                else if (default(T).Bits * 12 <= 512)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt512<T>(basePtr, scalarIndex, 12)).GetField<__UInt512__, Int2x12>(0);
                }
                else
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt1024<T>(basePtr, scalarIndex, 12)).GetField<__UInt1024__, Int2x12>(0);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Int2x16 LoadInt2x16<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 15, length);
            
            if (default(T).Bits == 2)
            {
                Int2x16 ret = Uninitialized<Int2x16>.Create();
                CopyAscending<T>(basePtr, scalarIndex, &ret, 0, 16);
                return ret;
            }

            if (default(T).Bits < 2)
            {
                return PackUnpack.UpCast32<T, UInt2>(LoadUShort<T>(basePtr, scalarIndex, 16)).GetField<uint, Int2x16>(0);
            }
            else
            {
                if (default(T).Bits * 16 <= 64)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadULong<T>(basePtr, scalarIndex, 16)).GetField<ulong, Int2x16>(0);
                }
                else if (default(T).Bits * 16 <= 128)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt128<T>(basePtr, scalarIndex, 16)).GetField<UInt128, Int2x16>(0);
                }
                else if (default(T).Bits * 16 <= 256)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt256<T>(basePtr, scalarIndex, 16)).GetField<__UInt256__, Int2x16>(0);
                }
                else if (default(T).Bits * 16 <= 512)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt512<T>(basePtr, scalarIndex, 16)).GetField<__UInt512__, Int2x16>(0);
                }
                else
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt1024<T>(basePtr, scalarIndex, 16)).GetField<__UInt1024__, Int2x16>(0);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Int2x20 LoadInt2x20<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 19, length);
            
            if (default(T).Bits == 2)
            {
                Int2x20 ret = Uninitialized<Int2x20>.Create();
                CopyAscending<T>(basePtr, scalarIndex, &ret, 0, 20);
                return ret;
            }

            if (default(T).Bits < 2)
            {
                return PackUnpack.UpCast64<T, UInt2>(LoadUInt<T>(basePtr, scalarIndex, 20)).GetField<ulong, Int2x20>(0);
            }
            else
            {
                if (default(T).Bits * 20 <= 64)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadULong<T>(basePtr, scalarIndex, 20)).GetField<ulong, Int2x20>(0);
                }
                else if (default(T).Bits * 20 <= 128)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt128<T>(basePtr, scalarIndex, 20)).GetField<UInt128, Int2x20>(0);
                }
                else if (default(T).Bits * 20 <= 256)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt256<T>(basePtr, scalarIndex, 20)).GetField<__UInt256__, Int2x20>(0);
                }
                else if (default(T).Bits * 20 <= 512)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt512<T>(basePtr, scalarIndex, 20)).GetField<__UInt512__, Int2x20>(0);
                }
                else if (default(T).Bits * 20 <= 1024)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt1024<T>(basePtr, scalarIndex, 20)).GetField<__UInt1024__, Int2x20>(0);
                }
                else
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt2048<T>(basePtr, scalarIndex, 20)).GetField<__UInt2048__, Int2x20>(0);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Int2x24 LoadInt2x24<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 23, length);
            
            if (default(T).Bits == 2)
            {
                Int2x24 ret = Uninitialized<Int2x24>.Create();
                CopyAscending<T>(basePtr, scalarIndex, &ret, 0, 24);
                return ret;
            }

            if (default(T).Bits < 2)
            {
                return PackUnpack.UpCast64<T, UInt2>(LoadUInt<T>(basePtr, scalarIndex, 24)).GetField<ulong, Int2x24>(0);
            }
            else
            {
                if (default(T).Bits * 24 <= 64)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadULong<T>(basePtr, scalarIndex, 24)).GetField<ulong, Int2x24>(0);
                }
                else if (default(T).Bits * 24 <= 128)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt128<T>(basePtr, scalarIndex, 24)).GetField<UInt128, Int2x24>(0);
                }
                else if (default(T).Bits * 24 <= 128)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt256<T>(basePtr, scalarIndex, 24)).GetField<__UInt256__, Int2x24>(0);
                }
                else if (default(T).Bits * 24 <= 256)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt256<T>(basePtr, scalarIndex, 24)).GetField<__UInt256__, Int2x24>(0);
                }
                else if (default(T).Bits * 24 <= 512)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt512<T>(basePtr, scalarIndex, 24)).GetField<__UInt512__, Int2x24>(0);
                }
                else if (default(T).Bits * 24 <= 1024)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt1024<T>(basePtr, scalarIndex, 24)).GetField<__UInt1024__, Int2x24>(0);
                }
                else
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt2048<T>(basePtr, scalarIndex, 24)).GetField<__UInt2048__, Int2x24>(0);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Int2x28 LoadInt2x28<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 27, length);
            
            if (default(T).Bits == 2)
            {
                Int2x28 ret = Uninitialized<Int2x28>.Create();
                CopyAscending<T>(basePtr, scalarIndex, &ret, 0, 28);
                return ret;
            }

            if (default(T).Bits < 2)
            {
                return PackUnpack.UpCast64<T, UInt2>(LoadUInt<T>(basePtr, scalarIndex, 28)).GetField<ulong, Int2x28>(0);
            }
            else
            {
                if (default(T).Bits * 28 <= 64)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadULong<T>(basePtr, scalarIndex, 28)).GetField<ulong, Int2x28>(0);
                }
                else if (default(T).Bits * 28 <= 128)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt128<T>(basePtr, scalarIndex, 28)).GetField<UInt128, Int2x28>(0);
                }
                else if (default(T).Bits * 28 <= 256)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt256<T>(basePtr, scalarIndex, 28)).GetField<__UInt256__, Int2x28>(0);
                }
                else if (default(T).Bits * 28 <= 512)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt512<T>(basePtr, scalarIndex, 28)).GetField<__UInt512__, Int2x28>(0);
                }
                else if (default(T).Bits * 28 <= 1024)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt1024<T>(basePtr, scalarIndex, 28)).GetField<__UInt1024__, Int2x28>(0);
                }
                else
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt2048<T>(basePtr, scalarIndex, 28)).GetField<__UInt2048__, Int2x28>(0);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Int2x32 LoadInt2x32<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 31, length);
            
            if (default(T).Bits == 2)
            {
                Int2x32 ret = Uninitialized<Int2x32>.Create();
                CopyAscending<T>(basePtr, scalarIndex, &ret, 0, 32);
                return ret;
            }

            if (default(T).Bits < 2)
            {
                return PackUnpack.UpCast64<T, UInt2>(LoadUInt<T>(basePtr, scalarIndex, 32)).GetField<ulong, Int2x32>(0);
            }
            else
            {
                if (default(T).Bits * 32 <= 128)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt128<T>(basePtr, scalarIndex, 32)).GetField<UInt128, Int2x32>(0);
                }
                else if (default(T).Bits * 32 <= 256)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt256<T>(basePtr, scalarIndex, 32)).GetField<__UInt256__, Int2x32>(0);
                }
                else if (default(T).Bits * 32 <= 512)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt512<T>(basePtr, scalarIndex, 32)).GetField<__UInt512__, Int2x32>(0);
                }
                else if (default(T).Bits * 32 <= 1024)
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt1024<T>(basePtr, scalarIndex, 32)).GetField<__UInt1024__, Int2x32>(0);
                }
                else
                {
                    return PackUnpack.DownCast<T, UInt2>(LoadUInt2048<T>(basePtr, scalarIndex, 32)).GetField<__UInt2048__, Int2x32>(0);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Int3x8 LoadInt3x8<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 7, length);
            
            if (default(T).Bits == 3)
            {
                Int3x8 ret = Uninitialized<Int3x8>.Create();
                CopyAscending<T>(basePtr, scalarIndex, &ret, 0, 8);
                return ret;
            }

            if (default(T).Bits < 3)
            {
                if (default(T).IsSigned)
                {
                    return (Int3x8)LoadByte8<T>(basePtr, scalarIndex, length);
                }
                else
                {
                    if (default(T).Bits * 8 <= 8)
                    {
                        return PackUnpack.UpCast32<T, UInt3>(LoadByte<T>(basePtr, scalarIndex, 8)).GetField<uint, Int3x8>(0);
                    }
                    else
                    {
                        return PackUnpack.UpCast32<T, UInt3>(LoadUShort<T>(basePtr, scalarIndex, 8)).GetField<uint, Int3x8>(0);
                    }
                }
            }
            else
            {
                if (default(T).Bits * 8 <= 32)
                {
                    return PackUnpack.DownCast<T, UInt3>(LoadUInt<T>(basePtr, scalarIndex, 8)).GetField<uint, Int3x8>(0);
                }
                else if (default(T).Bits * 8 <= 64)
                {
                    return PackUnpack.DownCast<T, UInt3>(LoadULong<T>(basePtr, scalarIndex, 8)).GetField<ulong, Int3x8>(0);
                }
                else if (default(T).Bits * 8 <= 128)
                {
                    return PackUnpack.DownCast<T, UInt3>(LoadUInt128<T>(basePtr, scalarIndex, 8)).GetField<UInt128, Int3x8>(0);
                }
                else if (default(T).Bits * 8 <= 256)
                {
                    return PackUnpack.DownCast<T, UInt3>(LoadUInt256<T>(basePtr, scalarIndex, 8)).GetField<__UInt256__, Int3x8>(0);
                }
                else
                {
                    return PackUnpack.DownCast<T, UInt3>(LoadUInt512<T>(basePtr, scalarIndex, 8)).GetField<__UInt512__, Int3x8>(0);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Int3x16 LoadInt3x16<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 15, length);
            
            if (default(T).Bits == 3)
            {
                Int3x16 ret = Uninitialized<Int3x16>.Create();
                CopyAscending<T>(basePtr, scalarIndex, &ret, 0, 16);
                return ret;
            }

            if (default(T).Bits < 3)
            {
                if (default(T).IsSigned)
                {
                    return (Int3x16)LoadByte16<T>(basePtr, scalarIndex, length);
                }
                else
                {
                    if (default(T).Bits * 16 <= 16)
                    {
                        return PackUnpack.UpCast64<T, UInt3>(LoadUShort<T>(basePtr, scalarIndex, 16)).GetField<ulong, Int3x16>(0);
                    }
                    else
                    {
                        return PackUnpack.UpCast64<T, UInt3>(LoadUInt<T>(basePtr, scalarIndex, 16)).GetField<ulong, Int3x16>(0);
                    }
                }
            }
            else
            {
                if (default(T).Bits * 16 <= 64)
                {
                    return PackUnpack.DownCast<T, UInt3>(LoadULong<T>(basePtr, scalarIndex, 16)).GetField<ulong, Int3x16>(0);
                }
                else if (default(T).Bits * 16 <= 128)
                {
                    return PackUnpack.DownCast<T, UInt3>(LoadUInt128<T>(basePtr, scalarIndex, 16)).GetField<UInt128, Int3x16>(0);
                }
                else if (default(T).Bits * 16 <= 256)
                {
                    return PackUnpack.DownCast<T, UInt3>(LoadUInt256<T>(basePtr, scalarIndex, 16)).GetField<__UInt256__, Int3x16>(0);
                }
                else if (default(T).Bits * 16 <= 512)
                {
                    return PackUnpack.DownCast<T, UInt3>(LoadUInt512<T>(basePtr, scalarIndex, 16)).GetField<__UInt512__, Int3x16>(0);
                }
                else
                {
                    return PackUnpack.DownCast<T, UInt3>(LoadUInt1024<T>(basePtr, scalarIndex, 16)).GetField<__UInt1024__, Int3x16>(0);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Int4x2 LoadInt4x2<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 1, length);
            
            if (default(T).Bits == 4)
            {
                Int4x2 ret = Uninitialized<Int4x2>.Create();
                CopyAscending<T>(basePtr, scalarIndex, &ret, 0, 2);
                return ret;
            }

            if (default(T).Bits < 4)
            {
                if (default(T).IsSigned)
                {
                    return (Int4x2)LoadByte2<T>(basePtr, scalarIndex, length);
                }
                else
                {
                    return PackUnpack.UpCast8<T, UInt4>(LoadByte<T>(basePtr, scalarIndex, 2)).GetField<byte, Int4x2>(0);
                }
            }
            else
            {
                if (default(T).Bits * 2 <= 16)
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadUShort<T>(basePtr, scalarIndex, 2)).GetField<ushort, Int4x2>(0);
                }
                else if (default(T).Bits * 2 <= 32)
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadUInt<T>(basePtr, scalarIndex, 2)).GetField<uint, Int4x2>(0);
                }
                else if (default(T).Bits * 2 <= 64)
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadULong<T>(basePtr, scalarIndex, 2)).GetField<ulong, Int4x2>(0);
                }
                else if (default(T).Bits * 2 <= 128)
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadUInt128<T>(basePtr, scalarIndex, 2)).GetField<UInt128, Int4x2>(0);
                }
                else if (default(T).Bits * 2 <= 256)
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadUInt256<T>(basePtr, scalarIndex, 2)).GetField<__UInt256__, Int4x2>(0);
                }
                else
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadUInt512<T>(basePtr, scalarIndex, 2)).GetField<__UInt512__, Int4x2>(0);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Int4x4 LoadInt4x4<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 3, length);
            
            if (default(T).Bits == 4)
            {
                Int4x4 ret = Uninitialized<Int4x4>.Create();
                CopyAscending<T>(basePtr, scalarIndex, &ret, 0, 4);
                return ret;
            }

            if (default(T).Bits < 4)
            {
                if (default(T).IsSigned)
                {
                    return (Int4x4)LoadByte4<T>(basePtr, scalarIndex, length);
                }
                else
                {
                    if (default(T).Bits * 4 <= 8)
                    {
                        return PackUnpack.UpCast16<T, UInt4>(LoadByte<T>(basePtr, scalarIndex, 4)).GetField<ushort, Int4x4>(0);
                    }
                    else
                    {
                        return PackUnpack.UpCast16<T, UInt4>(LoadUShort<T>(basePtr, scalarIndex, 4)).GetField<ushort, Int4x4>(0);
                    }
                }
            }
            else
            {
                if (default(T).Bits * 4 <= 32)
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadUInt<T>(basePtr, scalarIndex, 4)).GetField<uint, Int4x4>(0);
                }
                else if (default(T).Bits * 4 <= 64)
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadULong<T>(basePtr, scalarIndex, 4)).GetField<ulong, Int4x4>(0);
                }
                else if (default(T).Bits * 4 <= 128)
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadUInt128<T>(basePtr, scalarIndex, 4)).GetField<UInt128, Int4x4>(0);
                }
                else if (default(T).Bits * 4 <= 256)
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadUInt256<T>(basePtr, scalarIndex, 4)).GetField<__UInt256__, Int4x4>(0);
                }
                else
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadUInt512<T>(basePtr, scalarIndex, 4)).GetField<__UInt512__, Int4x4>(0);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Int4x6 LoadInt4x6<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 5, length);
            
            if (default(T).Bits == 4)
            {
                Int4x6 ret = Uninitialized<Int4x6>.Create();
                CopyAscending<T>(basePtr, scalarIndex, &ret, 0, 6);
                return ret;
            }

            if (default(T).Bits < 4)
            {
                if (default(T).IsSigned)
                {
                    return ((Int4x8)LoadByte6<T>(basePtr, scalarIndex, length)).GetField<Int4x8, Int4x6>(0);
                }
                else
                {
                    if (default(T).Bits * 6 <= 8)
                    {
                        return PackUnpack.UpCast32<T, UInt4>(LoadByte<T>(basePtr, scalarIndex, 6)).GetField<uint, Int4x6>(0);
                    }
                    else if (default(T).Bits * 6 <= 16)
                    {
                        return PackUnpack.UpCast32<T, UInt4>(LoadUShort<T>(basePtr, scalarIndex, 6)).GetField<uint, Int4x6>(0);
                    }
                    else
                    {
                        return PackUnpack.UpCast32<T, UInt4>(LoadUInt<T>(basePtr, scalarIndex, 6)).GetField<uint, Int4x6>(0);
                    }
                }
            }
            else
            {
                if (default(T).Bits * 6 <= 32)
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadUInt<T>(basePtr, scalarIndex, 6)).GetField<uint, Int4x6>(0);
                }
                else if (default(T).Bits * 6 <= 64)
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadULong<T>(basePtr, scalarIndex, 6)).GetField<ulong, Int4x6>(0);
                }
                else if (default(T).Bits * 6 <= 128)
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadUInt128<T>(basePtr, scalarIndex, 6)).GetField<UInt128, Int4x6>(0);
                }
                else if (default(T).Bits * 6 <= 256)
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadUInt256<T>(basePtr, scalarIndex, 6)).GetField<__UInt256__, Int4x6>(0);
                }
                else
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadUInt512<T>(basePtr, scalarIndex, 6)).GetField<__UInt512__, Int4x6>(0);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Int4x8 LoadInt4x8<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 7, length);
            
            if (default(T).Bits == 4)
            {
                Int4x8 ret = Uninitialized<Int4x8>.Create();
                CopyAscending<T>(basePtr, scalarIndex, &ret, 0, 8);
                return ret;
            }

            if (default(T).Bits < 4)
            {
                if (default(T).IsSigned)
                {
                    return (Int4x8)LoadByte8<T>(basePtr, scalarIndex, length);
                }
                else
                {
                    if (default(T).Bits * 8 <= 8)
                    {
                        return PackUnpack.UpCast32<T, UInt4>(LoadByte<T>(basePtr, scalarIndex, 8)).GetField<uint, Int4x8>(0);
                    }
                    else if (default(T).Bits * 8 <= 16)
                    {
                        return PackUnpack.UpCast32<T, UInt4>(LoadUShort<T>(basePtr, scalarIndex, 8)).GetField<uint, Int4x8>(0);
                    }
                    else
                    {
                        return PackUnpack.UpCast32<T, UInt4>(LoadUInt<T>(basePtr, scalarIndex, 8)).GetField<uint, Int4x8>(0);
                    }
                }
            }
            else
            {
                if (default(T).Bits * 8 <= 64)
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadULong<T>(basePtr, scalarIndex, 8)).GetField<ulong, Int4x8>(0);
                }
                else if (default(T).Bits * 8 <= 128)
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadUInt128<T>(basePtr, scalarIndex, 8)).GetField<UInt128, Int4x8>(0);
                }
                else if (default(T).Bits * 8 <= 256)
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadUInt256<T>(basePtr, scalarIndex, 8)).GetField<__UInt256__, Int4x8>(0);
                }
                else
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadUInt512<T>(basePtr, scalarIndex, 8)).GetField<__UInt512__, Int4x8>(0);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Int4x10 LoadInt4x10<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 9, length);
            
            if (default(T).Bits == 4)
            {
                Int4x10 ret = Uninitialized<Int4x10>.Create();
                CopyAscending<T>(basePtr, scalarIndex, &ret, 0, 10);
                return ret;
            }

            if (default(T).Bits < 4)
            {
                if (default(T).IsSigned)
                {
                    return ((Int4x16)LoadByte10<T>(basePtr, scalarIndex, length)).GetField<Int4x16, Int4x10>(0);
                }
                else
                {
                    if (default(T).Bits * 10 <= 16)
                    {
                        return PackUnpack.UpCast64<T, UInt4>(LoadUShort<T>(basePtr, scalarIndex, 10)).GetField<ulong, Int4x10>(0);
                    }
                    else if (default(T).Bits * 10 <= 32)
                    {
                        return PackUnpack.UpCast64<T, UInt4>(LoadUInt<T>(basePtr, scalarIndex, 10)).GetField<ulong, Int4x10>(0);
                    }
                    else
                    {
                        return PackUnpack.UpCast64<T, UInt4>(LoadULong<T>(basePtr, scalarIndex, 10)).GetField<ulong, Int4x10>(0);
                    }
                }
            }
            else
            {
                if (default(T).Bits * 10 <= 64)
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadULong<T>(basePtr, scalarIndex, 10)).GetField<ulong, Int4x10>(0);
                }
                else if (default(T).Bits * 10 <= 128)
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadUInt128<T>(basePtr, scalarIndex, 10)).GetField<UInt128, Int4x10>(0);
                }
                else if (default(T).Bits * 10 <= 256)
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadUInt256<T>(basePtr, scalarIndex, 10)).GetField<__UInt256__, Int4x10>(0);
                }
                else if (default(T).Bits * 10 <= 512)
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadUInt512<T>(basePtr, scalarIndex, 10)).GetField<__UInt512__, Int4x10>(0);
                }
                else
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadUInt1024<T>(basePtr, scalarIndex, 10)).GetField<__UInt1024__, Int4x10>(0);
                }
            }
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Int4x12 LoadInt4x12<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 11, length);
            
            if (default(T).Bits == 4)
            {
                Int4x12 ret = Uninitialized<Int4x12>.Create();
                CopyAscending<T>(basePtr, scalarIndex, &ret, 0, 12);
                return ret;
            }

            if (default(T).Bits < 4)
            {
                if (default(T).IsSigned)
                {
                    return ((Int4x16)LoadByte12<T>(basePtr, scalarIndex, length)).GetField<Int4x16, Int4x12>(0);
                }
                else
                {
                    if (default(T).Bits * 12 <= 16)
                    {
                        return PackUnpack.UpCast64<T, UInt4>(LoadUShort<T>(basePtr, scalarIndex, 12)).GetField<ulong, Int4x12>(0);
                    }
                    else if (default(T).Bits * 12 <= 32)
                    {
                        return PackUnpack.UpCast64<T, UInt4>(LoadUInt<T>(basePtr, scalarIndex, 12)).GetField<ulong, Int4x12>(0);
                    }
                    else
                    {
                        return PackUnpack.UpCast64<T, UInt4>(LoadULong<T>(basePtr, scalarIndex, 12)).GetField<ulong, Int4x12>(0);
                    }
                }
            }
            else
            {
                if (default(T).Bits * 12 <= 64)
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadULong<T>(basePtr, scalarIndex, 12)).GetField<ulong, Int4x12>(0);
                }
                else if (default(T).Bits * 12 <= 128)
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadUInt128<T>(basePtr, scalarIndex, 12)).GetField<UInt128, Int4x12>(0);
                }
                else if (default(T).Bits * 12 <= 256)
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadUInt256<T>(basePtr, scalarIndex, 12)).GetField<__UInt256__, Int4x12>(0);
                }
                else if (default(T).Bits * 12 <= 512)
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadUInt512<T>(basePtr, scalarIndex, 12)).GetField<__UInt512__, Int4x12>(0);
                }
                else
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadUInt1024<T>(basePtr, scalarIndex, 12)).GetField<__UInt1024__, Int4x12>(0);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Int4x14 LoadInt4x14<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 13, length);
            
            if (default(T).Bits == 4)
            {
                Int4x14 ret = Uninitialized<Int4x14>.Create();
                CopyAscending<T>(basePtr, scalarIndex, &ret, 0, 14);
                return ret;
            }

            if (default(T).Bits < 4)
            {
                if (default(T).IsSigned)
                {
                    return ((Int4x16)LoadByte14<T>(basePtr, scalarIndex, length)).GetField<Int4x16, Int4x14>(0);
                }
                else
                {
                    if (default(T).Bits * 14 <= 16)
                    {
                        return PackUnpack.UpCast64<T, UInt4>(LoadUShort<T>(basePtr, scalarIndex, 14)).GetField<ulong, Int4x14>(0);
                    }
                    else if (default(T).Bits * 14 <= 32)
                    {
                        return PackUnpack.UpCast64<T, UInt4>(LoadUInt<T>(basePtr, scalarIndex, 14)).GetField<ulong, Int4x14>(0);
                    }
                    else
                    {
                        return PackUnpack.UpCast64<T, UInt4>(LoadULong<T>(basePtr, scalarIndex, 14)).GetField<ulong, Int4x14>(0);
                    }
                }
            }
            else
            {
                if (default(T).Bits * 14 <= 128)
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadUInt128<T>(basePtr, scalarIndex, 14)).GetField<UInt128, Int4x14>(0);
                }
                else if (default(T).Bits * 14 <= 256)
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadUInt256<T>(basePtr, scalarIndex, 14)).GetField<__UInt256__, Int4x14>(0);
                }
                else if (default(T).Bits * 14 <= 512)
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadUInt512<T>(basePtr, scalarIndex, 14)).GetField<__UInt512__, Int4x14>(0);
                }
                else
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadUInt1024<T>(basePtr, scalarIndex, 14)).GetField<__UInt1024__, Int4x14>(0);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Int4x16 LoadInt4x16<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 15, length);
            
            if (default(T).Bits == 4)
            {
                Int4x16 ret = Uninitialized<Int4x16>.Create();
                CopyAscending<T>(basePtr, scalarIndex, &ret, 0, 16);
                return ret;
            }

            if (default(T).Bits < 4)
            {
                if (default(T).IsSigned)
                {
                    return (Int4x16)LoadByte16<T>(basePtr, scalarIndex, length);
                }
                else
                {
                    if (default(T).Bits * 16 <= 16)
                    {
                        return PackUnpack.UpCast64<T, UInt4>(LoadUShort<T>(basePtr, scalarIndex, 16)).GetField<ulong, Int4x16>(0);
                    }
                    else if (default(T).Bits * 16 <= 32)
                    {
                        return PackUnpack.UpCast64<T, UInt4>(LoadUInt<T>(basePtr, scalarIndex, 16)).GetField<ulong, Int4x16>(0);
                    }
                    else
                    {
                        return PackUnpack.UpCast64<T, UInt4>(LoadULong<T>(basePtr, scalarIndex, 16)).GetField<ulong, Int4x16>(0);
                    }
                }
            }
            else
            {
                if (default(T).Bits * 16 <= 128)
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadUInt128<T>(basePtr, scalarIndex, 16)).GetField<UInt128, Int4x16>(0);
                }
                else if (default(T).Bits * 16 <= 256)
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadUInt256<T>(basePtr, scalarIndex, 16)).GetField<__UInt256__, Int4x16>(0);
                }
                else if (default(T).Bits * 16 <= 512)
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadUInt512<T>(basePtr, scalarIndex, 16)).GetField<__UInt512__, Int4x16>(0);
                }
                else
                {
                    return PackUnpack.DownCast<T, UInt4>(LoadUInt1024<T>(basePtr, scalarIndex, 16)).GetField<__UInt1024__, Int4x16>(0);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Int5x8 LoadInt5x8<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 7, length);
            
            if (default(T).Bits == 5)
            {
                Int5x8 ret = Uninitialized<Int5x8>.Create();
                CopyAscending<T>(basePtr, scalarIndex, &ret, 0, 8);
                return ret;
            }

            if (default(T).Bits < 5)
            {
                if (default(T).IsSigned)
                {
                    return (Int5x8)LoadByte8<T>(basePtr, scalarIndex, length);
                }
                else
                {
                    if (default(T).Bits * 8 <= 8)
                    {
                        return PackUnpack.UpCast64<T, UInt5>(LoadByte<T>(basePtr, scalarIndex, 8)).GetField<ulong, Int5x8>(0);
                    }
                    else if (default(T).Bits * 8 <= 16)
                    {
                        return PackUnpack.UpCast64<T, UInt5>(LoadUShort<T>(basePtr, scalarIndex, 8)).GetField<ulong, Int5x8>(0);
                    }
                    else
                    {
                        return PackUnpack.UpCast64<T, UInt5>(LoadUInt<T>(basePtr, scalarIndex, 8)).GetField<ulong, Int5x8>(0);
                    }
                }
            }
            else
            {
                if (default(T).Bits * 8 <= 64)
                {
                    return PackUnpack.DownCast<T, UInt5>(LoadULong<T>(basePtr, scalarIndex, 8)).GetField<ulong, Int5x8>(0);
                }
                else if (default(T).Bits * 8 <= 128)
                {
                    return PackUnpack.DownCast<T, UInt5>(LoadUInt128<T>(basePtr, scalarIndex, 8)).GetField<UInt128, Int5x8>(0);
                }
                else if (default(T).Bits * 8 <= 256)
                {
                    return PackUnpack.DownCast<T, UInt5>(LoadUInt256<T>(basePtr, scalarIndex, 8)).GetField<__UInt256__, Int5x8>(0);
                }
                else
                {
                    return PackUnpack.DownCast<T, UInt5>(LoadUInt512<T>(basePtr, scalarIndex, 8)).GetField<__UInt512__, Int5x8>(0);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Int6x4 LoadInt6x4<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 3, length);
            
            if (default(T).Bits == 6)
            {
                Int6x4 ret = Uninitialized<Int6x4>.Create();
                CopyAscending<T>(basePtr, scalarIndex, &ret, 0, 4);
                return ret;
            }

            if (default(T).Bits < 6)
            {
                if (default(T).IsSigned)
                {
                    return (Int6x4)LoadByte4<T>(basePtr, scalarIndex, length);
                }
                else
                {
                    if (default(T).Bits * 4 <= 8)
                    {
                        return PackUnpack.UpCast32<T, UInt6>(LoadByte<T>(basePtr, scalarIndex, 4)).GetField<uint, Int6x4>(0);
                    }
                    else if (default(T).Bits * 4 <= 16)
                    {
                        return PackUnpack.UpCast32<T, UInt6>(LoadUShort<T>(basePtr, scalarIndex, 4)).GetField<uint, Int6x4>(0);
                    }
                    else
                    {
                        return PackUnpack.UpCast32<T, UInt6>(LoadUInt<T>(basePtr, scalarIndex, 4)).GetField<uint, Int6x4>(0);
                    }
                }
            }
            else
            {
                if (default(T).Bits * 4 <= 64)
                {
                    return PackUnpack.DownCast<T, UInt6>(LoadULong<T>(basePtr, scalarIndex, 4)).GetField<ulong, Int6x4>(0);
                }
                else if (default(T).Bits * 4 <= 128)
                {
                    return PackUnpack.DownCast<T, UInt6>(LoadUInt128<T>(basePtr, scalarIndex, 4)).GetField<UInt128, Int6x4>(0);
                }
                else if (default(T).Bits * 4 <= 256)
                {
                    return PackUnpack.DownCast<T, UInt6>(LoadUInt256<T>(basePtr, scalarIndex, 4)).GetField<__UInt256__, Int6x4>(0);
                }
                else
                {
                    return PackUnpack.DownCast<T, UInt6>(LoadUInt512<T>(basePtr, scalarIndex, 4)).GetField<__UInt512__, Int6x4>(0);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Int6x8 LoadInt6x8<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 7, length);
            
            if (default(T).Bits == 6)
            {
                Int6x8 ret = Uninitialized<Int6x8>.Create();
                CopyAscending<T>(basePtr, scalarIndex, &ret, 0, 8);
                return ret;
            }

            if (default(T).Bits < 6)
            {
                if (default(T).IsSigned)
                {
                    return (Int6x8)LoadByte8<T>(basePtr, scalarIndex, length);
                }
                else
                {
                    if (default(T).Bits * 8 <= 8)
                    {
                        return PackUnpack.UpCast64<T, UInt6>(LoadByte<T>(basePtr, scalarIndex, 8)).GetField<ulong, Int6x8>(0);
                    }
                    else if (default(T).Bits * 8 <= 16)
                    {
                        return PackUnpack.UpCast64<T, UInt6>(LoadUShort<T>(basePtr, scalarIndex, 8)).GetField<ulong, Int6x8>(0);
                    }
                    else if (default(T).Bits * 8 <= 32)
                    {
                        return PackUnpack.UpCast64<T, UInt6>(LoadUInt<T>(basePtr, scalarIndex, 8)).GetField<ulong, Int6x8>(0);
                    }
                    else
                    {
                        return PackUnpack.UpCast64<T, UInt6>(LoadULong<T>(basePtr, scalarIndex, 8)).GetField<ulong, Int6x8>(0);
                    }
                }
            }
            else
            {
                if (default(T).Bits * 8 <= 64)
                {
                    return PackUnpack.DownCast<T, UInt6>(LoadULong<T>(basePtr, scalarIndex, 8)).GetField<ulong, Int6x8>(0);
                }
                else if (default(T).Bits * 8 <= 128)
                {
                    return PackUnpack.DownCast<T, UInt6>(LoadUInt128<T>(basePtr, scalarIndex, 8)).GetField<UInt128, Int6x8>(0);
                }
                else if (default(T).Bits * 8 <= 256)
                {
                    return PackUnpack.DownCast<T, UInt6>(LoadUInt256<T>(basePtr, scalarIndex, 8)).GetField<__UInt256__, Int6x8>(0);
                }
                else
                {
                    return PackUnpack.DownCast<T, UInt6>(LoadUInt512<T>(basePtr, scalarIndex, 8)).GetField<__UInt512__, Int6x8>(0);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Int7x8 LoadInt7x8<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 7, length);
            
            if (default(T).Bits == 7)
            {
                Int7x8 ret = Uninitialized<Int7x8>.Create();
                CopyAscending<T>(basePtr, scalarIndex, &ret, 0, 8);
                return ret;
            }

            if (default(T).Bits < 7)
            {
                if (default(T).IsSigned)
                {
                    return (Int7x8)LoadByte8<T>(basePtr, scalarIndex, length);
                }
                else
                {
                    if (default(T).Bits * 8 <= 8)
                    {
                        return PackUnpack.UpCast64<T, UInt7>(LoadByte<T>(basePtr, scalarIndex, 8)).GetField<ulong, Int7x8>(0);
                    }
                    else if (default(T).Bits * 8 <= 16)
                    {
                        return PackUnpack.UpCast64<T, UInt7>(LoadUShort<T>(basePtr, scalarIndex, 8)).GetField<ulong, Int7x8>(0);
                    }
                    else if (default(T).Bits * 8 <= 32)
                    {
                        return PackUnpack.UpCast64<T, UInt7>(LoadUInt<T>(basePtr, scalarIndex, 8)).GetField<ulong, Int7x8>(0);
                    }
                    else
                    {
                        return PackUnpack.UpCast64<T, UInt7>(LoadULong<T>(basePtr, scalarIndex, 8)).GetField<ulong, Int7x8>(0);
                    }
                }
            }
            else
            {
                if (default(T).Bits * 8 <= 64)
                {
                    return PackUnpack.DownCast<T, UInt7>(LoadULong<T>(basePtr, scalarIndex, 8)).GetField<ulong, Int7x8>(0);
                }
                else if (default(T).Bits * 8 <= 128)
                {
                    return PackUnpack.DownCast<T, UInt7>(LoadUInt128<T>(basePtr, scalarIndex, 8)).GetField<UInt128, Int7x8>(0);
                }
                else if (default(T).Bits * 8 <= 256)
                {
                    return PackUnpack.DownCast<T, UInt7>(LoadUInt256<T>(basePtr, scalarIndex, 8)).GetField<__UInt256__, Int7x8>(0);
                }
                else
                {
                    return PackUnpack.DownCast<T, UInt7>(LoadUInt512<T>(basePtr, scalarIndex, 8)).GetField<__UInt512__, Int7x8>(0);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Int10x4 LoadInt10x4<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 3, length);
            
            if (default(T).Bits == 10)
            {
                Int10x4 ret = Uninitialized<Int10x4>.Create();
                CopyAscending<T>(basePtr, scalarIndex, &ret, 0, 4);
                return ret;
            }

            if (default(T).Bits < 10)
            {
                if (default(T).IsSigned)
                {
                    return (Int10x4)LoadShort4<T>(basePtr, scalarIndex, length);
                }
                else
                {
                    if (default(T).Bits * 4 <= 8)
                    {
                        return PackUnpack.UpCast64<T, UInt10>(LoadByte<T>(basePtr, scalarIndex, 4)).GetField<ulong, Int10x4>(0);
                    }
                    else if (default(T).Bits * 4 <= 16)
                    {
                        return PackUnpack.UpCast64<T, UInt10>(LoadUShort<T>(basePtr, scalarIndex, 4)).GetField<ulong, Int10x4>(0);
                    }
                    else if (default(T).Bits * 4 <= 32)
                    {
                        return PackUnpack.UpCast64<T, UInt10>(LoadUInt<T>(basePtr, scalarIndex, 4)).GetField<ulong, Int10x4>(0);
                    }
                    else
                    {
                        return PackUnpack.UpCast64<T, UInt10>(LoadULong<T>(basePtr, scalarIndex, 4)).GetField<ulong, Int10x4>(0);
                    }
                }
            }
            else
            {
                if (default(T).Bits * 4 <= 64)
                {
                    return PackUnpack.DownCast<T, UInt10>(LoadULong<T>(basePtr, scalarIndex, 4)).GetField<ulong, Int10x4>(0);
                }
                else if (default(T).Bits * 4 <= 128)
                {
                    return PackUnpack.DownCast<T, UInt10>(LoadUInt128<T>(basePtr, scalarIndex, 4)).GetField<UInt128, Int10x4>(0);
                }
                else if (default(T).Bits * 4 <= 256)
                {
                    return PackUnpack.DownCast<T, UInt10>(LoadUInt256<T>(basePtr, scalarIndex, 4)).GetField<__UInt256__, Int10x4>(0);
                }
                else
                {
                    return PackUnpack.DownCast<T, UInt10>(LoadUInt512<T>(basePtr, scalarIndex, 4)).GetField<__UInt512__, Int10x4>(0);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Int12x2 LoadInt12x2<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 1, length);
            
            if (default(T).Bits == 12)
            {
                Int12x2 ret = Uninitialized<Int12x2>.Create();
                CopyAscending<T>(basePtr, scalarIndex, &ret, 0, 2);
                return ret;
            }

            if (default(T).Bits < 12)
            {
                if (default(T).IsSigned)
                {
                    return (Int12x2)LoadShort2<T>(basePtr, scalarIndex, length);
                }
                else
                {
                    if (default(T).Bits * 2 <= 8)
                    {
                        return PackUnpack.UpCast32<T, UInt12>(LoadByte<T>(basePtr, scalarIndex, 2)).GetField<uint, Int12x2>(0);
                    }
                    else if (default(T).Bits * 2 <= 16)
                    {
                        return PackUnpack.UpCast32<T, UInt12>(LoadUShort<T>(basePtr, scalarIndex, 2)).GetField<uint, Int12x2>(0);
                    }
                    else
                    {
                        return PackUnpack.UpCast32<T, UInt12>(LoadUInt<T>(basePtr, scalarIndex, 2)).GetField<uint, Int12x2>(0);
                    }
                }
            }
            else
            {
                if (default(T).Bits * 2 <= 32)
                {
                    return PackUnpack.DownCast<T, UInt12>(LoadUInt<T>(basePtr, scalarIndex, 2)).GetField<uint, Int12x2>(0);
                }
                else if (default(T).Bits * 2 <= 64)
                {
                    return PackUnpack.DownCast<T, UInt12>(LoadULong<T>(basePtr, scalarIndex, 2)).GetField<ulong, Int12x2>(0);
                }
                else if (default(T).Bits * 2 <= 128)
                {
                    return PackUnpack.DownCast<T, UInt12>(LoadUInt128<T>(basePtr, scalarIndex, 2)).GetField<UInt128, Int12x2>(0);
                }
                else if (default(T).Bits * 2 <= 256)
                {
                    return PackUnpack.DownCast<T, UInt12>(LoadUInt256<T>(basePtr, scalarIndex, 2)).GetField<__UInt256__, Int12x2>(0);
                }
                else
                {
                    return PackUnpack.DownCast<T, UInt12>(LoadUInt512<T>(basePtr, scalarIndex, 2)).GetField<__UInt512__, Int12x2>(0);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Int12x4 LoadInt12x4<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 3, length);
            
            if (default(T).Bits == 12)
            {
                Int12x4 ret = Uninitialized<Int12x4>.Create();
                CopyAscending<T>(basePtr, scalarIndex, &ret, 0, 4);
                return ret;
            }

            if (default(T).Bits < 12)
            {
                if (default(T).IsSigned)
                {
                    return (Int12x4)LoadShort4<T>(basePtr, scalarIndex, length);
                }
                else
                {
                    if (default(T).Bits * 4 <= 8)
                    {
                        return PackUnpack.UpCast64<T, UInt12>(LoadByte<T>(basePtr, scalarIndex, 4)).GetField<ulong, Int12x4>(0);
                    }
                    else if (default(T).Bits * 4 <= 16)
                    {
                        return PackUnpack.UpCast64<T, UInt12>(LoadUShort<T>(basePtr, scalarIndex, 4)).GetField<ulong, Int12x4>(0);
                    }
                    else if (default(T).Bits * 4 <= 32)
                    {
                        return PackUnpack.UpCast64<T, UInt12>(LoadUInt<T>(basePtr, scalarIndex, 4)).GetField<ulong, Int12x4>(0);
                    }
                    else
                    {
                        return PackUnpack.UpCast64<T, UInt12>(LoadULong<T>(basePtr, scalarIndex, 4)).GetField<ulong, Int12x4>(0);
                    }
                }
            }
            else
            {
                if (default(T).Bits * 4 <= 64)
                {
                    return PackUnpack.DownCast<T, UInt12>(LoadULong<T>(basePtr, scalarIndex, 4)).GetField<ulong, Int12x4>(0);
                }
                else if (default(T).Bits * 4 <= 128)
                {
                    return PackUnpack.DownCast<T, UInt12>(LoadUInt128<T>(basePtr, scalarIndex, 4)).GetField<UInt128, Int12x4>(0);
                }
                else if (default(T).Bits * 4 <= 256)
                {
                    return PackUnpack.DownCast<T, UInt12>(LoadUInt256<T>(basePtr, scalarIndex, 4)).GetField<__UInt256__, Int12x4>(0);
                }
                else
                {
                    return PackUnpack.DownCast<T, UInt12>(LoadUInt512<T>(basePtr, scalarIndex, 4)).GetField<__UInt512__, Int12x4>(0);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Int14x4 LoadInt14x4<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 3, length);
            
            if (default(T).Bits == 14)
            {
                Int14x4 ret = Uninitialized<Int14x4>.Create();
                CopyAscending<T>(basePtr, scalarIndex, &ret, 0, 4);
                return ret;
            }

            if (default(T).Bits < 14)
            {
                if (default(T).IsSigned)
                {
                    return (Int14x4)LoadShort4<T>(basePtr, scalarIndex, length);
                }
                else
                {
                    if (default(T).Bits * 4 <= 8)
                    {
                        return PackUnpack.UpCast64<T, UInt14>(LoadByte<T>(basePtr, scalarIndex, 4)).GetField<ulong, Int14x4>(0);
                    }
                    else if (default(T).Bits * 4 <= 16)
                    {
                        return PackUnpack.UpCast64<T, UInt14>(LoadUShort<T>(basePtr, scalarIndex, 4)).GetField<ulong, Int14x4>(0);
                    }
                    else if (default(T).Bits * 4 <= 32)
                    {
                        return PackUnpack.UpCast64<T, UInt14>(LoadUInt<T>(basePtr, scalarIndex, 4)).GetField<ulong, Int14x4>(0);
                    }
                    else
                    {
                        return PackUnpack.UpCast64<T, UInt14>(LoadULong<T>(basePtr, scalarIndex, 4)).GetField<ulong, Int14x4>(0);
                    }
                }
            }
            else
            {
                if (default(T).Bits * 4 <= 128)
                {
                    return PackUnpack.DownCast<T, UInt14>(LoadUInt128<T>(basePtr, scalarIndex, 4)).GetField<UInt128, Int14x4>(0);
                }
                else if (default(T).Bits * 4 <= 256)
                {
                    return PackUnpack.DownCast<T, UInt14>(LoadUInt256<T>(basePtr, scalarIndex, 4)).GetField<__UInt256__, Int14x4>(0);
                }
                else
                {
                    return PackUnpack.DownCast<T, UInt14>(LoadUInt512<T>(basePtr, scalarIndex, 4)).GetField<__UInt512__, Int14x4>(0);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Int20x2 LoadInt20x2<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 1, length);
            
            if (default(T).Bits == 20)
            {
                Int20x2 ret = Uninitialized<Int20x2>.Create();
                CopyAscending<T>(basePtr, scalarIndex, &ret, 0, 2);
                return ret;
            }

            if (default(T).Bits < 20)
            {
                if (default(T).IsSigned)
                {
                    return (Int20x2)LoadInt2<T>(basePtr, scalarIndex, length);
                }
                else
                {
                    if (default(T).Bits * 2 <= 8)
                    {
                        return PackUnpack.UpCast64<T, UInt20>(LoadByte<T>(basePtr, scalarIndex, 2)).GetField<ulong, Int20x2>(0);
                    }
                    else if (default(T).Bits * 2 <= 16)
                    {
                        return PackUnpack.UpCast64<T, UInt20>(LoadUShort<T>(basePtr, scalarIndex, 2)).GetField<ulong, Int20x2>(0);
                    }
                    else if (default(T).Bits * 2 <= 32)
                    {
                        return PackUnpack.UpCast64<T, UInt20>(LoadUInt<T>(basePtr, scalarIndex, 2)).GetField<ulong, Int20x2>(0);
                    }
                    else
                    {
                        return PackUnpack.UpCast64<T, UInt20>(LoadULong<T>(basePtr, scalarIndex, 2)).GetField<ulong, Int20x2>(0);
                    }
                }
            }
            else
            {
                if (default(T).Bits * 2 <= 64)
                {
                    return PackUnpack.DownCast<T, UInt20>(LoadULong<T>(basePtr, scalarIndex, 2)).GetField<ulong, Int20x2>(0);
                }
                else if (default(T).Bits * 2 <= 208)
                {
                    return PackUnpack.DownCast<T, UInt20>(LoadUInt128<T>(basePtr, scalarIndex, 2)).GetField<UInt128, Int20x2>(0);
                }
                else if (default(T).Bits * 2 <= 256)
                {
                    return PackUnpack.DownCast<T, UInt20>(LoadUInt256<T>(basePtr, scalarIndex, 2)).GetField<__UInt256__, Int20x2>(0);
                }
                else
                {
                    return PackUnpack.DownCast<T, UInt20>(LoadUInt512<T>(basePtr, scalarIndex, 2)).GetField<__UInt512__, Int20x2>(0);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Int28x2 LoadInt28x2<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 1, length);
            
            if (default(T).Bits == 28)
            {
                Int28x2 ret = Uninitialized<Int28x2>.Create();
                CopyAscending<T>(basePtr, scalarIndex, &ret, 0, 2);
                return ret;
            }

            if (default(T).Bits < 28)
            {
                if (default(T).IsSigned)
                {
                    return (Int28x2)LoadInt2<T>(basePtr, scalarIndex, length);
                }
                else
                {
                    if (default(T).Bits * 2 <= 8)
                    {
                        return PackUnpack.UpCast64<T, UInt28>(LoadByte<T>(basePtr, scalarIndex, 2)).GetField<ulong, Int28x2>(0);
                    }
                    else if (default(T).Bits * 2 <= 16)
                    {
                        return PackUnpack.UpCast64<T, UInt28>(LoadUShort<T>(basePtr, scalarIndex, 2)).GetField<ulong, Int28x2>(0);
                    }
                    else if (default(T).Bits * 2 <= 32)
                    {
                        return PackUnpack.UpCast64<T, UInt28>(LoadUInt<T>(basePtr, scalarIndex, 2)).GetField<ulong, Int28x2>(0);
                    }
                    else
                    {
                        return PackUnpack.UpCast64<T, UInt28>(LoadULong<T>(basePtr, scalarIndex, 2)).GetField<ulong, Int28x2>(0);
                    }
                }
            }
            else
            {
                if (default(T).Bits * 2 <= 64)
                {
                    return PackUnpack.DownCast<T, UInt28>(LoadULong<T>(basePtr, scalarIndex, 2)).GetField<ulong, Int28x2>(0);
                }
                else if (default(T).Bits * 2 <= 288)
                {
                    return PackUnpack.DownCast<T, UInt28>(LoadUInt128<T>(basePtr, scalarIndex, 2)).GetField<UInt128, Int28x2>(0);
                }
                else if (default(T).Bits * 2 <= 256)
                {
                    return PackUnpack.DownCast<T, UInt28>(LoadUInt256<T>(basePtr, scalarIndex, 2)).GetField<__UInt256__, Int28x2>(0);
                }
                else
                {
                    return PackUnpack.DownCast<T, UInt28>(LoadUInt512<T>(basePtr, scalarIndex, 2)).GetField<__UInt512__, Int28x2>(0);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte2 LoadByte2<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 1, length);

            if (default(T).Bits == 8)
            {
                return *(byte2*)((byte*)basePtr + scalarIndex);
            }

            if (default(T).IsSigned)
            {
                if (default(T).Bits == 24)
                {
                    return (byte2)Load_i24_to8x2((Int24*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 40)
                {
                    return (byte2)Load_i40_to8x2((Int40*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 48)
                {
                    return (byte2)Load_i48_to8x2((Int48*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 56)
                {
                    return (byte2)Load_i56_to8x2((Int56*)basePtr + scalarIndex, memoryAccess);
                }
            }
            else
            {
                if (default(T).Bits == 24)
                {
                    return (byte2)Load_u24_to8x2((UInt24*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 40)
                {
                    return (byte2)Load_u40_to8x2((UInt40*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 48)
                {
                    return (byte2)Load_u48_to8x2((UInt48*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 56)
                {
                    return (byte2)Load_u56_to8x2((UInt56*)basePtr + scalarIndex, memoryAccess);
                }
            }

            if (default(T).Bits * 2 <= 8)
            {
                byte2 ret = PackUnpack.UpCast16<T, UInt8>(LoadByte<T>(basePtr, scalarIndex, 2)).GetField<ushort, byte2>(0);

                if (default(T).IsSigned)
                {
                    ret = (byte2)signextend((sbyte2)ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 2 <= 16)
            {
                byte2 ret = PackUnpack.UpCast16<T, UInt8>(LoadUShort<T>(basePtr, scalarIndex, 2)).GetField<ushort, byte2>(0);

                if (default(T).IsSigned)
                {
                    ret = (byte2)signextend((sbyte2)ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 2 <= 32)
            {
                return PackUnpack.DownCast<T, UInt8>(LoadUInt<T>(basePtr, scalarIndex, 2)).GetField<uint, byte2>(0);
            }
            else if (default(T).Bits * 2 <= 64)
            {
                return PackUnpack.DownCast<T, UInt8>(LoadULong<T>(basePtr, scalarIndex, 2)).GetField<ulong, byte2>(0);
            }
            else
            {
                return PackUnpack.DownCast<T, UInt8>(LoadUInt128<T>(basePtr, scalarIndex, 2)).GetField<UInt128, byte2>(0);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte3 LoadByte3<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 2, length);
            
            if (default(T).Bits == 8)
            {
                return *(byte3*)((byte*)basePtr + scalarIndex);
            }

            if (default(T).IsSigned)
            {
                if (default(T).Bits == 24)
                {
                    return (byte3)Load_i24_to8x3((Int24*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 40)
                {
                    return (byte3)Load_i40_to8x3((Int40*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 48)
                {
                    return (byte3)Load_i48_to8x3((Int48*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 56)
                {
                    return (byte3)Load_i56_to8x3((Int56*)basePtr + scalarIndex, memoryAccess);
                }
            }
            else
            {
                if (default(T).Bits == 24)
                {
                    return (byte3)Load_u24_to8x3((UInt24*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 40)
                {
                    return (byte3)Load_u40_to8x3((UInt40*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 48)
                {
                    return (byte3)Load_u48_to8x3((UInt48*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 56)
                {
                    return (byte3)Load_u56_to8x3((UInt56*)basePtr + scalarIndex, memoryAccess);
                }
            }

            if (default(T).Bits * 3 <= 8)
            {
                byte3 ret = PackUnpack.UpCast32<T, UInt8>(LoadByte<T>(basePtr, scalarIndex, 3)).GetField<uint, byte3>(0);

                if (default(T).IsSigned)
                {
                    ret = (byte3)signextend((sbyte3)ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 3 <= 16)
            {
                byte3 ret = PackUnpack.UpCast32<T, UInt8>(LoadUShort<T>(basePtr, scalarIndex, 3)).GetField<uint, byte3>(0);

                if (default(T).IsSigned)
                {
                    ret = (byte3)signextend((sbyte3)ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 3 <= 32)
            {
                if (default(T).Bits < 8)
                {
                    byte3 ret = PackUnpack.UpCast32<T, UInt8>(LoadUInt<T>(basePtr, scalarIndex, 3)).GetField<uint, byte3>(0);

                    if (default(T).IsSigned)
                    {
                        ret = (byte3)signextend((sbyte3)ret, default(T).Bits);
                    }

                    return ret;
                }
                else
                {
                    return PackUnpack.DownCast<T, UInt8>(LoadUInt<T>(basePtr, scalarIndex, 3)).GetField<uint, byte3>(0);
                }
            }
            else if (default(T).Bits * 3 <= 64)
            {
                return PackUnpack.DownCast<T, UInt8>(LoadULong<T>(basePtr, scalarIndex, 3)).GetField<ulong, byte3>(0);
            }
            else if (default(T).Bits * 3 <= 128)
            {
                return PackUnpack.DownCast<T, UInt8>(LoadUInt128<T>(basePtr, scalarIndex, 3)).GetField<UInt128, byte3>(0);
            }
            else
            {
                return PackUnpack.DownCast<T, UInt8>(LoadUInt256<T>(basePtr, scalarIndex, 3)).GetField<__UInt256__, byte3>(0);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte4 LoadByte4<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 3, length);
            
            if (default(T).Bits == 8)
            {
                return *(byte4*)((byte*)basePtr + scalarIndex);
            }

            if (default(T).IsSigned)
            {
                if (default(T).Bits == 24)
                {
                    return (byte4)Load_i24_to8x4((Int24*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 40)
                {
                    return (byte4)Load_i40_to8x4((Int40*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 48)
                {
                    return (byte4)Load_i48_to8x4((Int48*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 56)
                {
                    return (byte4)Load_i56_to8x4((Int56*)basePtr + scalarIndex, memoryAccess);
                }
            }
            else
            {
                if (default(T).Bits == 24)
                {
                    return (byte4)Load_u24_to8x4((UInt24*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 40)
                {
                    return (byte4)Load_u40_to8x4((UInt40*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 48)
                {
                    return (byte4)Load_u48_to8x4((UInt48*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 56)
                {
                    return (byte4)Load_u56_to8x4((UInt56*)basePtr + scalarIndex, memoryAccess);
                }
            }

            if (default(T).Bits * 4 <= 8)
            {
                byte4 ret = PackUnpack.UpCast32<T, UInt8>(LoadByte<T>(basePtr, scalarIndex, 4)).GetField<uint, byte4>(0);

                if (default(T).IsSigned)
                {
                    ret = (byte4)signextend((sbyte4)ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 4 <= 16)
            {
                byte4 ret = PackUnpack.UpCast32<T, UInt8>(LoadUShort<T>(basePtr, scalarIndex, 4)).GetField<uint, byte4>(0);

                if (default(T).IsSigned)
                {
                    ret = (byte4)signextend((sbyte4)ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 4 <= 32)
            {
                byte4 ret = PackUnpack.UpCast32<T, UInt8>(LoadUInt<T>(basePtr, scalarIndex, 4)).GetField<uint, byte4>(0);

                if (default(T).IsSigned)
                {
                    ret = (byte4)signextend((sbyte4)ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 4 <= 64)
            {
                return PackUnpack.DownCast<T, UInt8>(LoadULong<T>(basePtr, scalarIndex, 4)).GetField<ulong, byte4>(0);
            }
            else if (default(T).Bits * 4 <= 128)
            {
                return PackUnpack.DownCast<T, UInt8>(LoadUInt128<T>(basePtr, scalarIndex, 4)).GetField<UInt128, byte4>(0);
            }
            else
            {
                return PackUnpack.DownCast<T, UInt8>(LoadUInt256<T>(basePtr, scalarIndex, 4)).GetField<__UInt256__, byte4>(0);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte8 LoadByte6<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 5, length);
            
            if (default(T).Bits == 8)
            {
                return LoadULong<T>(basePtr, scalarIndex, 6).GetField<ulong, byte8>(0);
            }

            if (default(T).Bits * 6 <= 8)
            {
                byte8 ret = PackUnpack.UpCast64<T, UInt8>(LoadByte<T>(basePtr, scalarIndex, 6)).GetField<ulong, byte8>(0);

                if (default(T).IsSigned)
                {
                    ret = (byte8)signextend((sbyte8)ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 6 <= 16)
            {
                byte8 ret = PackUnpack.UpCast64<T, UInt8>(LoadUShort<T>(basePtr, scalarIndex, 6)).GetField<ulong, byte8>(0);

                if (default(T).IsSigned)
                {
                    ret = (byte8)signextend((sbyte8)ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 6 <= 32)
            {
                byte8 ret = PackUnpack.UpCast64<T, UInt8>(LoadUInt<T>(basePtr, scalarIndex, 6)).GetField<ulong, byte8>(0);

                if (default(T).IsSigned)
                {
                    ret = (byte8)signextend((sbyte8)ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 6 <= 64)
            {
                byte8 ret = PackUnpack.UpCast64<T, UInt8>(LoadULong<T>(basePtr, scalarIndex, 6)).GetField<ulong, byte8>(0);

                if (default(T).IsSigned)
                {
                    ret = (byte8)signextend((sbyte8)ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 6 <= 128)
            {
                return PackUnpack.DownCast<T, UInt8>(LoadUInt128<T>(basePtr, scalarIndex, 6)).GetField<UInt128, byte8>(0);
            }
            else if (default(T).Bits * 6 <= 256)
            {
                return PackUnpack.DownCast<T, UInt8>(LoadUInt256<T>(basePtr, scalarIndex, 6)).GetField<__UInt256__, byte8>(0);
            }
            else
            {
                return PackUnpack.DownCast<T, UInt8>(LoadUInt512<T>(basePtr, scalarIndex, 6)).GetField<__UInt512__, byte8>(0);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte8 LoadByte8<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 7, length);
            
            if (default(T).Bits == 8)
            {
                return *(byte8*)((byte*)basePtr + scalarIndex);
            }

            if (default(T).IsSigned)
            {
                if (default(T).Bits == 24)
                {
                    return (byte8)Load_i24_to8x8((Int24*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 40)
                {
                    return (byte8)Load_i40_to8x8((Int40*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 48)
                {
                    return (byte8)Load_i48_to8x8((Int48*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 56)
                {
                    return (byte8)Load_i56_to8x8((Int56*)basePtr + scalarIndex, memoryAccess);
                }
            }
            else
            {
                if (default(T).Bits == 24)
                {
                    return (byte8)Load_u24_to8x8((UInt24*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 40)
                {
                    return (byte8)Load_u40_to8x8((UInt40*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 48)
                {
                    return (byte8)Load_u48_to8x8((UInt48*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 56)
                {
                    return (byte8)Load_u56_to8x8((UInt56*)basePtr + scalarIndex, memoryAccess);
                }
            }

            if (default(T).Bits * 8 <= 8)
            {
                byte8 ret = PackUnpack.UpCast64<T, UInt8>(LoadByte<T>(basePtr, scalarIndex, 8)).GetField<ulong, byte8>(0);

                if (default(T).IsSigned)
                {
                    ret = (byte8)signextend((sbyte8)ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 8 <= 16)
            {
                byte8 ret = PackUnpack.UpCast64<T, UInt8>(LoadUShort<T>(basePtr, scalarIndex, 8)).GetField<ulong, byte8>(0);

                if (default(T).IsSigned)
                {
                    ret = (byte8)signextend((sbyte8)ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 8 <= 32)
            {
                byte8 ret = PackUnpack.UpCast64<T, UInt8>(LoadUInt<T>(basePtr, scalarIndex, 8)).GetField<ulong, byte8>(0);

                if (default(T).IsSigned)
                {
                    ret = (byte8)signextend((sbyte8)ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 8 <= 64)
            {
                byte8 ret = PackUnpack.UpCast64<T, UInt8>(LoadULong<T>(basePtr, scalarIndex, 8)).GetField<ulong, byte8>(0);

                if (default(T).IsSigned)
                {
                    ret = (byte8)signextend((sbyte8)ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 8 <= 128)
            {
                return PackUnpack.DownCast<T, UInt8>(LoadUInt128<T>(basePtr, scalarIndex, 8)).GetField<UInt128, byte8>(0);
            }
            else if (default(T).Bits * 8 <= 256)
            {
                return PackUnpack.DownCast<T, UInt8>(LoadUInt256<T>(basePtr, scalarIndex, 8)).GetField<__UInt256__, byte8>(0);
            }
            else
            {
                return PackUnpack.DownCast<T, UInt8>(LoadUInt512<T>(basePtr, scalarIndex, 8)).GetField<__UInt512__, byte8>(0);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte16 LoadByte10<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 9, length);
            
            if (default(T).Bits == 8)
            {
                return LoadUInt128<T>(basePtr, scalarIndex, 10).GetField<UInt128, byte16>(0);
            }

            if (default(T).Bits * 10 <= 16)
            {
                byte16 ret = PackUnpack.UpCast128<T, UInt8>((UInt128)LoadUShort<T>(basePtr, scalarIndex, 10)).GetField<UInt128, byte16>(0);

                if (default(T).IsSigned)
                {
                    ret = (byte16)signextend((sbyte16)ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 10 <= 32)
            {
                byte16 ret = PackUnpack.UpCast128<T, UInt8>((UInt128)LoadUInt<T>(basePtr, scalarIndex, 10)).GetField<UInt128, byte16>(0);

                if (default(T).IsSigned)
                {
                    ret = (byte16)signextend((sbyte16)ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 10 <= 64)
            {
                byte16 ret = PackUnpack.UpCast128<T, UInt8>((UInt128)LoadULong<T>(basePtr, scalarIndex, 10)).GetField<UInt128, byte16>(0);

                if (default(T).IsSigned)
                {
                    ret = (byte16)signextend((sbyte16)ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 10 <= 128)
            {
                byte16 ret = PackUnpack.UpCast128<T, UInt8>(LoadUInt128<T>(basePtr, scalarIndex, 10)).GetField<UInt128, byte16>(0);

                if (default(T).IsSigned)
                {
                    ret = (byte16)signextend((sbyte16)ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 10 <= 256)
            {
                return PackUnpack.DownCast<T, UInt8>(LoadUInt256<T>(basePtr, scalarIndex, 10)).GetField<__UInt256__, byte16>(0);
            }
            else if (default(T).Bits * 10 <= 512)
            {
                return PackUnpack.DownCast<T, UInt8>(LoadUInt512<T>(basePtr, scalarIndex, 10)).GetField<__UInt512__, byte16>(0);
            }
            else
            {
                return PackUnpack.DownCast<T, UInt8>(LoadUInt1024<T>(basePtr, scalarIndex, 10)).GetField<__UInt1024__, byte16>(0);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte16 LoadByte12<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 11, length);
            
            if (default(T).Bits == 8)
            {
                return LoadUInt128<T>(basePtr, scalarIndex, 12).GetField<UInt128, byte16>(0);
            }

            if (default(T).Bits * 12 <= 16)
            {
                byte16 ret = PackUnpack.UpCast128<T, UInt8>((UInt128)LoadUShort<T>(basePtr, scalarIndex, 12)).GetField<UInt128, byte16>(0);

                if (default(T).IsSigned)
                {
                    ret = (byte16)signextend((sbyte16)ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 12 <= 32)
            {
                byte16 ret = PackUnpack.UpCast128<T, UInt8>((UInt128)LoadUInt<T>(basePtr, scalarIndex, 12)).GetField<UInt128, byte16>(0);

                if (default(T).IsSigned)
                {
                    ret = (byte16)signextend((sbyte16)ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 12 <= 64)
            {
                byte16 ret = PackUnpack.UpCast128<T, UInt8>((UInt128)LoadULong<T>(basePtr, scalarIndex, 12)).GetField<UInt128, byte16>(0);

                if (default(T).IsSigned)
                {
                    ret = (byte16)signextend((sbyte16)ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 12 <= 128)
            {
                byte16 ret = PackUnpack.UpCast128<T, UInt8>(LoadUInt128<T>(basePtr, scalarIndex, 12)).GetField<UInt128, byte16>(0);

                if (default(T).IsSigned)
                {
                    ret = (byte16)signextend((sbyte16)ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 12 <= 256)
            {
                return PackUnpack.DownCast<T, UInt8>(LoadUInt256<T>(basePtr, scalarIndex, 12)).GetField<__UInt256__, byte16>(0);
            }
            else if (default(T).Bits * 12 <= 512)
            {
                return PackUnpack.DownCast<T, UInt8>(LoadUInt512<T>(basePtr, scalarIndex, 12)).GetField<__UInt512__, byte16>(0);
            }
            else
            {
                return PackUnpack.DownCast<T, UInt8>(LoadUInt1024<T>(basePtr, scalarIndex, 12)).GetField<__UInt1024__, byte16>(0);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte16 LoadByte14<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 13, length);
            
            if (default(T).Bits == 8)
            {
                return LoadUInt128<T>(basePtr, scalarIndex, 14).GetField<UInt128, byte16>(0);
            }

            if (default(T).Bits * 14 <= 16)
            {
                byte16 ret = PackUnpack.UpCast128<T, UInt8>((UInt128)LoadUShort<T>(basePtr, scalarIndex, 14)).GetField<UInt128, byte16>(0);

                if (default(T).IsSigned)
                {
                    ret = (byte16)signextend((sbyte16)ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 14 <= 32)
            {
                byte16 ret = PackUnpack.UpCast128<T, UInt8>((UInt128)LoadUInt<T>(basePtr, scalarIndex, 14)).GetField<UInt128, byte16>(0);

                if (default(T).IsSigned)
                {
                    ret = (byte16)signextend((sbyte16)ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 14 <= 64)
            {
                byte16 ret = PackUnpack.UpCast128<T, UInt8>((UInt128)LoadULong<T>(basePtr, scalarIndex, 14)).GetField<UInt128, byte16>(0);

                if (default(T).IsSigned)
                {
                    ret = (byte16)signextend((sbyte16)ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 14 <= 128)
            {
                byte16 ret = PackUnpack.UpCast128<T, UInt8>(LoadUInt128<T>(basePtr, scalarIndex, 14)).GetField<UInt128, byte16>(0);

                if (default(T).IsSigned)
                {
                    ret = (byte16)signextend((sbyte16)ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 14 <= 256)
            {
                return PackUnpack.DownCast<T, UInt8>(LoadUInt256<T>(basePtr, scalarIndex, 14)).GetField<__UInt256__, byte16>(0);
            }
            else if (default(T).Bits * 14 <= 512)
            {
                return PackUnpack.DownCast<T, UInt8>(LoadUInt512<T>(basePtr, scalarIndex, 14)).GetField<__UInt512__, byte16>(0);
            }
            else
            {
                return PackUnpack.DownCast<T, UInt8>(LoadUInt1024<T>(basePtr, scalarIndex, 14)).GetField<__UInt1024__, byte16>(0);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte16 LoadByte16<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 15, length);
            
            if (default(T).Bits == 8)
            {
                return *(byte16*)((byte*)basePtr + scalarIndex);
            }

            if (default(T).IsSigned)
            {
                if (default(T).Bits == 24)
                {
                    return (byte16)Load_i24_to8x16((Int24*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 40)
                {
                    return (byte16)Load_i40_to8x16((Int40*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 48)
                {
                    return (byte16)Load_i48_to8x16((Int48*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 56)
                {
                    return (byte16)Load_i56_to8x16((Int56*)basePtr + scalarIndex, memoryAccess);
                }
            }
            else
            {
                if (default(T).Bits == 24)
                {
                    return (byte16)Load_u24_to8x16((UInt24*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 40)
                {
                    return (byte16)Load_u40_to8x16((UInt40*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 48)
                {
                    return (byte16)Load_u48_to8x16((UInt48*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 56)
                {
                    return (byte16)Load_u56_to8x16((UInt56*)basePtr + scalarIndex, memoryAccess);
                }
            }

            if (default(T).Bits * 16 <= 16)
            {
                byte16 ret = PackUnpack.UpCast128<T, UInt8>((UInt128)LoadUShort<T>(basePtr, scalarIndex, 16)).GetField<UInt128, byte16>(0);

                if (default(T).IsSigned)
                {
                    ret = (byte16)signextend((sbyte16)ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 16 <= 32)
            {
                byte16 ret = PackUnpack.UpCast128<T, UInt8>((UInt128)LoadUInt<T>(basePtr, scalarIndex, 16)).GetField<UInt128, byte16>(0);

                if (default(T).IsSigned)
                {
                    ret = (byte16)signextend((sbyte16)ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 16 <= 64)
            {
                byte16 ret = PackUnpack.UpCast128<T, UInt8>((UInt128)LoadULong<T>(basePtr, scalarIndex, 16)).GetField<UInt128, byte16>(0);

                if (default(T).IsSigned)
                {
                    ret = (byte16)signextend((sbyte16)ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 16 <= 128)
            {
                byte16 ret = PackUnpack.UpCast128<T, UInt8>(LoadUInt128<T>(basePtr, scalarIndex, 16)).GetField<UInt128, byte16>(0);

                if (default(T).IsSigned)
                {
                    ret = (byte16)signextend((sbyte16)ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 16 <= 256)
            {
                return PackUnpack.DownCast<T, UInt8>(LoadUInt256<T>(basePtr, scalarIndex, 16)).GetField<__UInt256__, byte16>(0);
            }
            else if (default(T).Bits * 16 <= 512)
            {
                return PackUnpack.DownCast<T, UInt8>(LoadUInt512<T>(basePtr, scalarIndex, 16)).GetField<__UInt512__, byte16>(0);
            }
            else
            {
                return PackUnpack.DownCast<T, UInt8>(LoadUInt1024<T>(basePtr, scalarIndex, 16)).GetField<__UInt1024__, byte16>(0);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte32 LoadByte32<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 31, length);
            
            if (default(T).Bits == 8)
            {
                return *(byte32*)((byte*)basePtr + scalarIndex);
            }

            if (default(T).IsSigned)
            {
                if (default(T).Bits == 24)
                {
                    return (byte32)Load_i24_to8x32((Int24*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 40)
                {
                    return (byte32)Load_i40_to8x32((Int40*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 48)
                {
                    return (byte32)Load_i48_to8x32((Int48*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 56)
                {
                    return (byte32)Load_i56_to8x32((Int56*)basePtr + scalarIndex, memoryAccess);
                }
            }
            else
            {
                if (default(T).Bits == 24)
                {
                    return (byte32)Load_u24_to8x32((UInt24*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 40)
                {
                    return (byte32)Load_u40_to8x32((UInt40*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 48)
                {
                    return (byte32)Load_u48_to8x32((UInt48*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 56)
                {
                    return (byte32)Load_u56_to8x32((UInt56*)basePtr + scalarIndex, memoryAccess);
                }
            }

            if (default(T).Bits * 32 <= 32)
            {
                byte32 ret = PackUnpack.UpCast256<T, UInt8>((__UInt256__)LoadUInt<T>(basePtr, scalarIndex, 32)).GetField<__UInt256__, byte32>(0);

                if (default(T).IsSigned)
                {
                    ret = (byte32)signextend((sbyte32)ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 32 <= 64)
            {
                byte32 ret = PackUnpack.UpCast256<T, UInt8>((__UInt256__)LoadULong<T>(basePtr, scalarIndex, 32)).GetField<__UInt256__, byte32>(0);

                if (default(T).IsSigned)
                {
                    ret = (byte32)signextend((sbyte32)ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 32 <= 128)
            {
                byte32 ret = PackUnpack.UpCast256<T, UInt8>((__UInt256__)LoadUInt128<T>(basePtr, scalarIndex, 32)).GetField<__UInt256__, byte32>(0);

                if (default(T).IsSigned)
                {
                    ret = (byte32)signextend((sbyte32)ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 32 <= 256)
            {
                byte32 ret = PackUnpack.UpCast256<T, UInt8>(LoadUInt256<T>(basePtr, scalarIndex, 32)).GetField<__UInt256__, byte32>(0);

                if (default(T).IsSigned)
                {
                    ret = (byte32)signextend((sbyte32)ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 32 <= 512)
            {
                return PackUnpack.DownCast<T, UInt8>(LoadUInt512<T>(basePtr, scalarIndex, 32)).GetField<__UInt512__, byte32>(0);
            }
            else if (default(T).Bits * 32 <= 1024)
            {
                return PackUnpack.DownCast<T, UInt8>(LoadUInt1024<T>(basePtr, scalarIndex, 32)).GetField<__UInt1024__, byte32>(0);
            }
            else
            {
                return PackUnpack.DownCast<T, UInt8>(LoadUInt2048<T>(basePtr, scalarIndex, 32)).GetField<__UInt2048__, byte32>(0);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static short2 LoadShort2<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 1, length);
            
            if (default(T).Bits == 16)
            {
                return *(short2*)((short*)basePtr + scalarIndex);
            }

            if (default(T).IsSigned)
            {
                if (default(T).Bits == 24)
                {
                    return (short2)Load_i24_to16x2((Int24*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 40)
                {
                    return (short2)Load_i40_to16x2((Int40*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 48)
                {
                    return (short2)Load_i48_to16x2((Int48*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 56)
                {
                    return (short2)Load_i56_to16x2((Int56*)basePtr + scalarIndex, memoryAccess);
                }
            }
            else
            {
                if (default(T).Bits == 24)
                {
                    return (short2)Load_u24_to16x2((UInt24*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 40)
                {
                    return (short2)Load_u40_to16x2((UInt40*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 48)
                {
                    return (short2)Load_u48_to16x2((UInt48*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 56)
                {
                    return (short2)Load_u56_to16x2((UInt56*)basePtr + scalarIndex, memoryAccess);
                }
            }

            if (default(T).Bits * 2 <= 8)
            {
                short2 ret = PackUnpack.UpCast32<T, UInt16>(LoadByte<T>(basePtr, scalarIndex, 2)).GetField<uint, short2>(0);

                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 2 <= 16)
            {
                short2 ret = PackUnpack.UpCast32<T, UInt16>(LoadUShort<T>(basePtr, scalarIndex, 2)).GetField<uint, short2>(0);

                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 2 <= 32)
            {
                short2 ret = PackUnpack.UpCast32<T, UInt16>(LoadUInt<T>(basePtr, scalarIndex, 2)).GetField<uint, short2>(0);

                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 2 <= 64)
            {
                return PackUnpack.DownCast<T, UInt16>(LoadULong<T>(basePtr, scalarIndex, 2)).GetField<ulong, short2>(0);
            }
            else
            {
                return PackUnpack.DownCast<T, UInt16>(LoadUInt128<T>(basePtr, scalarIndex, 2)).GetField<UInt128, short2>(0);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static short3 LoadShort3<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 2, length);
            
            if (default(T).Bits == 16)
            {
                return *(short3*)((short*)basePtr + scalarIndex);
            }

            if (default(T).IsSigned)
            {
                if (default(T).Bits == 24)
                {
                    return (short3)Load_i24_to16x3((Int24*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 40)
                {
                    return (short3)Load_i40_to16x3((Int40*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 48)
                {
                    return (short3)Load_i48_to16x3((Int48*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 56)
                {
                    return (short3)Load_i56_to16x3((Int56*)basePtr + scalarIndex, memoryAccess);
                }
            }
            else
            {
                if (default(T).Bits == 24)
                {
                    return (short3)Load_u24_to16x3((UInt24*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 40)
                {
                    return (short3)Load_u40_to16x3((UInt40*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 48)
                {
                    return (short3)Load_u48_to16x3((UInt48*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 56)
                {
                    return (short3)Load_u56_to16x3((UInt56*)basePtr + scalarIndex, memoryAccess);
                }
            }

            if (default(T).Bits * 3 <= 8)
            {
                short3 ret = PackUnpack.UpCast64<T, UInt16>(LoadByte<T>(basePtr, scalarIndex, 3)).GetField<ulong, short3>(0);

                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 3 <= 16)
            {
                short3 ret = PackUnpack.UpCast64<T, UInt16>(LoadUShort<T>(basePtr, scalarIndex, 3)).GetField<ulong, short3>(0);

                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 3 <= 32)
            {
                short3 ret = PackUnpack.UpCast64<T, UInt16>(LoadUInt<T>(basePtr, scalarIndex, 3)).GetField<ulong, short3>(0);

                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 3 <= 64)
            {
                if (default(T).Bits < 16)
                {
                    short3 ret = PackUnpack.UpCast64<T, UInt16>(LoadULong<T>(basePtr, scalarIndex, 3)).GetField<ulong, short3>(0);

                    if (default(T).IsSigned)
                    {
                        ret = signextend(ret, default(T).Bits);
                    }

                    return ret;
                }
                else
                {
                    return PackUnpack.DownCast<T, UInt16>(LoadULong<T>(basePtr, scalarIndex, 3)).GetField<ulong, short3>(0);
                }
            }
            else if (default(T).Bits * 3 <= 128)
            {
                return PackUnpack.DownCast<T, UInt16>(LoadUInt128<T>(basePtr, scalarIndex, 3)).GetField<UInt128, short3>(0);
            }
            else
            {
                return PackUnpack.DownCast<T, UInt16>(LoadUInt256<T>(basePtr, scalarIndex, 3)).GetField<__UInt256__, short3>(0);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static short4 LoadShort4<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 3, length);
            
            if (default(T).Bits == 16)
            {
                return *(short4*)((short*)basePtr + scalarIndex);
            }

            if (default(T).IsSigned)
            {
                if (default(T).Bits == 24)
                {
                    return (short4)Load_i24_to16x4((Int24*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 40)
                {
                    return (short4)Load_i40_to16x4((Int40*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 48)
                {
                    return (short4)Load_i48_to16x4((Int48*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 56)
                {
                    return (short4)Load_i56_to16x4((Int56*)basePtr + scalarIndex, memoryAccess);
                }
            }
            else
            {
                if (default(T).Bits == 24)
                {
                    return (short4)Load_u24_to16x4((UInt24*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 40)
                {
                    return (short4)Load_u40_to16x4((UInt40*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 48)
                {
                    return (short4)Load_u48_to16x4((UInt48*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 56)
                {
                    return (short4)Load_u56_to16x4((UInt56*)basePtr + scalarIndex, memoryAccess);
                }
            }

            if (default(T).Bits * 4 <= 8)
            {
                short4 ret = PackUnpack.UpCast64<T, UInt16>(LoadByte<T>(basePtr, scalarIndex, 4)).GetField<ulong, short4>(0);

                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 4 <= 16)
            {
                short4 ret = PackUnpack.UpCast64<T, UInt16>(LoadUShort<T>(basePtr, scalarIndex, 4)).GetField<ulong, short4>(0);

                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 4 <= 32)
            {
                short4 ret = PackUnpack.UpCast64<T, UInt16>(LoadUInt<T>(basePtr, scalarIndex, 4)).GetField<ulong, short4>(0);

                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 4 <= 64)
            {
                short4 ret = PackUnpack.UpCast64<T, UInt16>(LoadULong<T>(basePtr, scalarIndex, 4)).GetField<ulong, short4>(0);
                
                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }
                
                return ret;
            }
            else if (default(T).Bits * 4 <= 128)
            {
                return PackUnpack.DownCast<T, UInt16>(LoadUInt128<T>(basePtr, scalarIndex, 4)).GetField<UInt128, short4>(0);
            }
            else
            {
                return PackUnpack.DownCast<T, UInt16>(LoadUInt256<T>(basePtr, scalarIndex, 4)).GetField<__UInt256__, short4>(0);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static short8 LoadShort8<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 7, length);
            
            if (default(T).Bits == 16)
            {
                return *(short8*)((short*)basePtr + scalarIndex);
            }

            if (default(T).IsSigned)
            {
                if (default(T).Bits == 24)
                {
                    return (short8)Load_i24_to16x8((Int24*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 40)
                {
                    return (short8)Load_i40_to16x8((Int40*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 48)
                {
                    return (short8)Load_i48_to16x8((Int48*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 56)
                {
                    return (short8)Load_i56_to16x8((Int56*)basePtr + scalarIndex, memoryAccess);
                }
            }
            else
            {
                if (default(T).Bits == 24)
                {
                    return (short8)Load_u24_to16x8((UInt24*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 40)
                {
                    return (short8)Load_u40_to16x8((UInt40*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 48)
                {
                    return (short8)Load_u48_to16x8((UInt48*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 56)
                {
                    return (short8)Load_u56_to16x8((UInt56*)basePtr + scalarIndex, memoryAccess);
                }
            }

            if (default(T).Bits * 8 <= 8)
            {
                short8 ret = PackUnpack.UpCast128<T, UInt16>(LoadByte<T>(basePtr, scalarIndex, 8)).GetField<UInt128, short8>(0);

                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 8 <= 16)
            {
                short8 ret = PackUnpack.UpCast128<T, UInt16>(LoadUShort<T>(basePtr, scalarIndex, 8)).GetField<UInt128, short8>(0);

                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 8 <= 32)
            {
                short8 ret = PackUnpack.UpCast128<T, UInt16>(LoadUInt<T>(basePtr, scalarIndex, 8)).GetField<UInt128, short8>(0);

                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 8 <= 64)
            {
                short8 ret = PackUnpack.UpCast128<T, UInt16>(LoadULong<T>(basePtr, scalarIndex, 8)).GetField<UInt128, short8>(0);
                
                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }
                
                return ret;
            }
            else if (default(T).Bits * 8 <= 128)
            {
                short8 ret = PackUnpack.UpCast128<T, UInt16>(LoadUInt128<T>(basePtr, scalarIndex, 8)).GetField<UInt128, short8>(0);
                
                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }
                
                return ret;
            }
            else if (default(T).Bits * 8 <= 256)
            {
                return PackUnpack.DownCast<T, UInt16>(LoadUInt256<T>(basePtr, scalarIndex, 8)).GetField<__UInt256__, short8>(0);
            }
            else
            {
                return PackUnpack.DownCast<T, UInt16>(LoadUInt512<T>(basePtr, scalarIndex, 8)).GetField<__UInt512__, short8>(0);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static short16 LoadShort16<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 15, length);
            
            if (default(T).Bits == 16)
            {
                return *(short16*)((short*)basePtr + scalarIndex);
            }

            if (default(T).IsSigned)
            {
                if (default(T).Bits == 24)
                {
                    return (short16)Load_i24_to16x16((Int24*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 40)
                {
                    return (short16)Load_i40_to16x16((Int40*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 48)
                {
                    return (short16)Load_i48_to16x16((Int48*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 56)
                {
                    return (short16)Load_i56_to16x16((Int56*)basePtr + scalarIndex, memoryAccess);
                }
            }
            else
            {
                if (default(T).Bits == 24)
                {
                    return (short16)Load_u24_to16x16((UInt24*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 40)
                {
                    return (short16)Load_u40_to16x16((UInt40*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 48)
                {
                    return (short16)Load_u48_to16x16((UInt48*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 56)
                {
                    return (short16)Load_u56_to16x16((UInt56*)basePtr + scalarIndex, memoryAccess);
                }
            }

            if (default(T).Bits * 16 <= 16)
            {
                short16 ret = PackUnpack.UpCast256<T, UInt16>(LoadUShort<T>(basePtr, scalarIndex, 16)).GetField<__UInt256__, short16>(0);

                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 16 <= 32)
            {
                short16 ret = PackUnpack.UpCast256<T, UInt16>(LoadUInt<T>(basePtr, scalarIndex, 16)).GetField<__UInt256__, short16>(0);

                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 16 <= 64)
            {
                short16 ret = PackUnpack.UpCast256<T, UInt16>(LoadULong<T>(basePtr, scalarIndex, 16)).GetField<__UInt256__, short16>(0);
                
                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }
                
                return ret;
            }
            else if (default(T).Bits * 16 <= 128)
            {
                short16 ret = PackUnpack.UpCast256<T, UInt16>(LoadUInt128<T>(basePtr, scalarIndex, 16)).GetField<__UInt256__, short16>(0);
                
                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }
                
                return ret;
            }
            else if (default(T).Bits * 16 <= 256)
            {
                short16 ret = PackUnpack.UpCast256<T, UInt16>(LoadUInt256<T>(basePtr, scalarIndex, 16)).GetField<__UInt256__, short16>(0);
                
                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }
                
                return ret;
            }
            else if (default(T).Bits * 16 <= 512)
            {
                return PackUnpack.DownCast<T, UInt16>(LoadUInt512<T>(basePtr, scalarIndex, 16)).GetField<__UInt512__, short16>(0);
            }
            else
            {
                return PackUnpack.DownCast<T, UInt16>(LoadUInt1024<T>(basePtr, scalarIndex, 16)).GetField<__UInt1024__, short16>(0);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int2 LoadInt2<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 1, length);
            
            if (default(T).Bits == 32)
            {
                return *(int2*)((int*)basePtr + scalarIndex);
            }

            if (default(T).IsSigned)
            {
                if (default(T).Bits == 24)
                {
                    return (int2)Load_i24_to32x2((Int24*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 40)
                {
                    return (int2)Load_i40_to32x2((Int40*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 48)
                {
                    return (int2)Load_i48_to32x2((Int48*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 56)
                {
                    return (int2)Load_i56_to32x2((Int56*)basePtr + scalarIndex, memoryAccess);
                }
            }
            else
            {
                if (default(T).Bits == 24)
                {
                    return (int2)Load_u24_to32x2((UInt24*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 40)
                {
                    return (int2)Load_u40_to32x2((UInt40*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 48)
                {
                    return (int2)Load_u48_to32x2((UInt48*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 56)
                {
                    return (int2)Load_u56_to32x2((UInt56*)basePtr + scalarIndex, memoryAccess);
                }
            }

            if (default(T).Bits * 2 <= 8)
            {
                int2 ret = PackUnpack.UpCast64<T, UInt32>(LoadByte<T>(basePtr, scalarIndex, 2)).GetField<ulong, int2>(0);

                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 2 <= 16)
            {
                int2 ret = PackUnpack.UpCast64<T, UInt32>(LoadUShort<T>(basePtr, scalarIndex, 2)).GetField<ulong, int2>(0);

                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 2 <= 32)
            {
                int2 ret = PackUnpack.UpCast64<T, UInt32>(LoadUInt<T>(basePtr, scalarIndex, 2)).GetField<ulong, int2>(0);

                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 2 <= 64)
            {
                int2 ret = PackUnpack.UpCast64<T, UInt32>(LoadULong<T>(basePtr, scalarIndex, 2)).GetField<ulong, int2>(0);

                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }

                return ret;
            }
            else
            {
                return PackUnpack.DownCast<T, UInt32>(LoadUInt128<T>(basePtr, scalarIndex, 2)).GetField<UInt128, int2>(0);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int3 LoadInt3<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 2, length);
            
            if (default(T).Bits == 32)
            {
                return *(int3*)((int*)basePtr + scalarIndex);
            }

            if (default(T).IsSigned)
            {
                if (default(T).Bits == 24)
                {
                    return (int3)Load_i24_to32x3((Int24*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 40)
                {
                    return (int3)Load_i40_to32x3((Int40*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 48)
                {
                    return (int3)Load_i48_to32x3((Int48*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 56)
                {
                    return (int3)Load_i56_to32x3((Int56*)basePtr + scalarIndex, memoryAccess);
                }
            }
            else
            {
                if (default(T).Bits == 24)
                {
                    return (int3)Load_u24_to32x3((UInt24*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 40)
                {
                    return (int3)Load_u40_to32x3((UInt40*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 48)
                {
                    return (int3)Load_u48_to32x3((UInt48*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 56)
                {
                    return (int3)Load_u56_to32x3((UInt56*)basePtr + scalarIndex, memoryAccess);
                }
            }

            if (default(T).Bits * 3 <= 8)
            {
                int3 ret = PackUnpack.UpCast128<T, UInt32>(LoadByte<T>(basePtr, scalarIndex, 3)).GetField<UInt128, int3>(0);

                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 3 <= 16)
            {
                int3 ret = PackUnpack.UpCast128<T, UInt32>(LoadUShort<T>(basePtr, scalarIndex, 3)).GetField<UInt128, int3>(0);

                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 3 <= 32)
            {
                int3 ret = PackUnpack.UpCast128<T, UInt32>(LoadUInt<T>(basePtr, scalarIndex, 3)).GetField<UInt128, int3>(0);

                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 3 <= 64)
            {
                int3 ret = PackUnpack.UpCast128<T, UInt32>(LoadULong<T>(basePtr, scalarIndex, 3)).GetField<UInt128, int3>(0);

                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 3 <= 128)
            {
                if (default(T).Bits < 32)
                {
                    int3 ret = PackUnpack.UpCast128<T, UInt32>(LoadUInt128<T>(basePtr, scalarIndex, 3)).GetField<UInt128, int3>(0);

                    if (default(T).IsSigned)
                    {
                        ret = signextend(ret, default(T).Bits);
                    }

                    return ret;
                }
                else
                {
                    return PackUnpack.DownCast<T, UInt32>(LoadUInt128<T>(basePtr, scalarIndex, 3)).GetField<UInt128, int3>(0);
                }
            }
            else
            {
                return PackUnpack.DownCast<T, UInt32>(LoadUInt256<T>(basePtr, scalarIndex, 3)).GetField<__UInt256__, int3>(0);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int4 LoadInt4<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 3, length);
            
            if (default(T).Bits == 32)
            {
                return *(int4*)((int*)basePtr + scalarIndex);
            }

            if (default(T).IsSigned)
            {
                if (default(T).Bits == 24)
                {
                    return (int4)Load_i24_to32x4((Int24*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 40)
                {
                    return (int4)Load_i40_to32x4((Int40*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 48)
                {
                    return (int4)Load_i48_to32x4((Int48*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 56)
                {
                    return (int4)Load_i56_to32x4((Int56*)basePtr + scalarIndex, memoryAccess);
                }
            }
            else
            {
                if (default(T).Bits == 24)
                {
                    return (int4)Load_u24_to32x4((UInt24*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 40)
                {
                    return (int4)Load_u40_to32x4((UInt40*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 48)
                {
                    return (int4)Load_u48_to32x4((UInt48*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 56)
                {
                    return (int4)Load_u56_to32x4((UInt56*)basePtr + scalarIndex, memoryAccess);
                }
            }

            if (default(T).Bits * 4 <= 8)
            {
                int4 ret = PackUnpack.UpCast128<T, UInt32>(LoadByte<T>(basePtr, scalarIndex, 4)).GetField<UInt128, int4>(0);

                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 4 <= 16)
            {
                int4 ret = PackUnpack.UpCast128<T, UInt32>(LoadUShort<T>(basePtr, scalarIndex, 4)).GetField<UInt128, int4>(0);

                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 4 <= 32)
            {
                int4 ret = PackUnpack.UpCast128<T, UInt32>(LoadUInt<T>(basePtr, scalarIndex, 4)).GetField<UInt128, int4>(0);

                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 4 <= 64)
            {
                int4 ret = PackUnpack.UpCast128<T, UInt32>(LoadULong<T>(basePtr, scalarIndex, 4)).GetField<UInt128, int4>(0);

                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 4 <= 128)
            {
                int4 ret = PackUnpack.UpCast128<T, UInt32>(LoadUInt128<T>(basePtr, scalarIndex, 4)).GetField<UInt128, int4>(0);
                
                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }
                
                return ret;
            }
            else
            {
                return PackUnpack.DownCast<T, UInt32>(LoadUInt256<T>(basePtr, scalarIndex, 4)).GetField<__UInt256__, int4>(0);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int8 LoadInt8<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 7, length);
            
            if (default(T).Bits == 32)
            {
                return *(int8*)((int*)basePtr + scalarIndex);
            }

            if (default(T).IsSigned)
            {
                if (default(T).Bits == 24)
                {
                    return (int8)Load_i24_to32x8((Int24*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 40)
                {
                    return (int8)Load_i40_to32x8((Int40*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 48)
                {
                    return (int8)Load_i48_to32x8((Int48*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 56)
                {
                    return (int8)Load_i56_to32x8((Int56*)basePtr + scalarIndex, memoryAccess);
                }
            }
            else
            {
                if (default(T).Bits == 24)
                {
                    return (int8)Load_u24_to32x8((UInt24*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 40)
                {
                    return (int8)Load_u40_to32x8((UInt40*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 48)
                {
                    return (int8)Load_u48_to32x8((UInt48*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 56)
                {
                    return (int8)Load_u56_to32x8((UInt56*)basePtr + scalarIndex, memoryAccess);
                }
            }

            if (default(T).Bits * 8 <= 8)
            {
                int8 ret = PackUnpack.UpCast256<T, UInt32>(LoadByte<T>(basePtr, scalarIndex, 8)).GetField<__UInt256__, int8>(0);

                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 8 <= 16)
            {
                int8 ret = PackUnpack.UpCast256<T, UInt32>(LoadUShort<T>(basePtr, scalarIndex, 8)).GetField<__UInt256__, int8>(0);

                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 8 <= 32)
            {
                int8 ret = PackUnpack.UpCast256<T, UInt32>(LoadUInt<T>(basePtr, scalarIndex, 8)).GetField<__UInt256__, int8>(0);

                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 8 <= 64)
            {
                int8 ret = PackUnpack.UpCast256<T, UInt32>(LoadULong<T>(basePtr, scalarIndex, 8)).GetField<__UInt256__, int8>(0);

                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }

                return ret;
            }
            else if (default(T).Bits * 8 <= 128)
            {
                int8 ret = PackUnpack.UpCast256<T, UInt32>(LoadUInt128<T>(basePtr, scalarIndex, 8)).GetField<__UInt256__, int8>(0);
                
                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }
                
                return ret;
            }
            else if (default(T).Bits * 8 <= 256)
            {
                int8 ret = PackUnpack.UpCast256<T, UInt32>(LoadUInt256<T>(basePtr, scalarIndex, 8)).GetField<__UInt256__, int8>(0);
                
                if (default(T).IsSigned)
                {
                    ret = signextend(ret, default(T).Bits);
                }
                
                return ret;
            }
            else
            {
                return PackUnpack.DownCast<T, UInt32>(LoadUInt512<T>(basePtr, scalarIndex, 8)).GetField<__UInt512__, int8>(0);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static long2 LoadLong2<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 1, length);
            
            if (default(T).Bits == 64)
            {
                return *(long2*)((long*)basePtr + scalarIndex);
            }

            if (default(T).IsSigned)
            {
                if (default(T).Bits == 24)
                {
                    return (long2)Load_i24_to64x2((Int24*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 40)
                {
                    return (long2)Load_i40_to64x2((Int40*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 48)
                {
                    return (long2)Load_i48_to64x2((Int48*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 56)
                {
                    return (long2)Load_i56_to64x2((Int56*)basePtr + scalarIndex, memoryAccess);
                }
            }
            else
            {
                if (default(T).Bits == 24)
                {
                    return (long2)Load_u24_to64x2((UInt24*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 40)
                {
                    return (long2)Load_u40_to64x2((UInt40*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 48)
                {
                    return (long2)Load_u48_to64x2((UInt48*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 56)
                {
                    return (long2)Load_u56_to64x2((UInt56*)basePtr + scalarIndex, memoryAccess);
                }
            }

            long2 ret;

            if (default(T).Bits * 2 <= 8)
            {
                ret = PackUnpack.UpCast128<T, UInt64>(LoadByte<T>(basePtr, scalarIndex, 2)).GetField<UInt128, long2>(0);
            }
            else if (default(T).Bits * 2 <= 16)
            {
                ret = PackUnpack.UpCast128<T, UInt64>(LoadUShort<T>(basePtr, scalarIndex, 2)).GetField<UInt128, long2>(0);
            }
            else if (default(T).Bits * 2 <= 32)
            {
                ret = PackUnpack.UpCast128<T, UInt64>(LoadUInt<T>(basePtr, scalarIndex, 2)).GetField<UInt128, long2>(0);
            }
            else if (default(T).Bits * 2 <= 64)
            {
                ret = PackUnpack.UpCast128<T, UInt64>(LoadULong<T>(basePtr, scalarIndex, 2)).GetField<UInt128, long2>(0);
            }
            else
            {
                ret = PackUnpack.UpCast128<T, UInt64>(LoadUInt128<T>(basePtr, scalarIndex, 2)).GetField<UInt128, long2>(0);
            }

            if (default(T).IsSigned)
            {
                ret = signextend(ret, default(T).Bits);
            }

            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static long3 LoadLong3<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 2, length);
            
            if (default(T).Bits == 64)
            {
                return *(long3*)((long*)basePtr + scalarIndex);
            }

            if (default(T).IsSigned)
            {
                if (default(T).Bits == 24)
                {
                    return (long3)Load_i24_to64x3((Int24*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 40)
                {
                    return (long3)Load_i40_to64x3((Int40*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 48)
                {
                    return (long3)Load_i48_to64x3((Int48*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 56)
                {
                    return (long3)Load_i56_to64x3((Int56*)basePtr + scalarIndex, memoryAccess);
                }
            }
            else
            {
                if (default(T).Bits == 24)
                {
                    return (long3)Load_u24_to64x3((UInt24*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 40)
                {
                    return (long3)Load_u40_to64x3((UInt40*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 48)
                {
                    return (long3)Load_u48_to64x3((UInt48*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 56)
                {
                    return (long3)Load_u56_to64x3((UInt56*)basePtr + scalarIndex, memoryAccess);
                }
            }

            long3 ret;

            if (default(T).Bits * 3 <= 8)
            {
                ret = PackUnpack.UpCast256<T, UInt64>(LoadByte<T>(basePtr, scalarIndex, 3)).GetField<__UInt256__, long3>(0);
            }
            else if (default(T).Bits * 3 <= 16)
            {
                ret = PackUnpack.UpCast256<T, UInt64>(LoadUShort<T>(basePtr, scalarIndex, 3)).GetField<__UInt256__, long3>(0);
            }
            else if (default(T).Bits * 3 <= 32)
            {
                ret = PackUnpack.UpCast256<T, UInt64>(LoadUInt<T>(basePtr, scalarIndex, 3)).GetField<__UInt256__, long3>(0);
            }
            else if (default(T).Bits * 3 <= 64)
            {
                ret = PackUnpack.UpCast256<T, UInt64>(LoadULong<T>(basePtr, scalarIndex, 3)).GetField<__UInt256__, long3>(0);
            }
            else if (default(T).Bits * 3 <= 128)
            {
                ret = PackUnpack.UpCast256<T, UInt64>(LoadUInt128<T>(basePtr, scalarIndex, 3)).GetField<__UInt256__, long3>(0);
            }
            else
            {
                ret = PackUnpack.UpCast256<T, UInt64>(LoadUInt256<T>(basePtr, scalarIndex, 3)).GetField<__UInt256__, long3>(0);
            }

            if (default(T).IsSigned)
            {
                ret = signextend(ret, default(T).Bits);
            }

            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static long4 LoadLong4<T>(void* basePtr, int scalarIndex, int length, MemoryAccess memoryAccess = MemoryAccess.Strict)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 3, length);
            
            if (default(T).Bits == 64)
            {
                return *(long4*)((long*)basePtr + scalarIndex);
            }

            if (default(T).IsSigned)
            {
                if (default(T).Bits == 24)
                {
                    return (long4)Load_i24_to64x4((Int24*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 40)
                {
                    return (long4)Load_i40_to64x4((Int40*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 48)
                {
                    return (long4)Load_i48_to64x4((Int48*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 56)
                {
                    return (long4)Load_i56_to64x4((Int56*)basePtr + scalarIndex, memoryAccess);
                }
            }
            else
            {
                if (default(T).Bits == 24)
                {
                    return (long4)Load_u24_to64x4((UInt24*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 40)
                {
                    return (long4)Load_u40_to64x4((UInt40*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 48)
                {
                    return (long4)Load_u48_to64x4((UInt48*)basePtr + scalarIndex, memoryAccess);
                }
                if (default(T).Bits == 56)
                {
                    return (long4)Load_u56_to64x4((UInt56*)basePtr + scalarIndex, memoryAccess);
                }
            }

            long4 ret;

            if (default(T).Bits * 4 <= 8)
            {
                ret = PackUnpack.UpCast256<T, UInt64>(LoadByte<T>(basePtr, scalarIndex, 4)).GetField<__UInt256__, long4>(0);
            }
            else if (default(T).Bits * 4 <= 16)
            {
                ret = PackUnpack.UpCast256<T, UInt64>(LoadUShort<T>(basePtr, scalarIndex, 4)).GetField<__UInt256__, long4>(0);
            }
            else if (default(T).Bits * 4 <= 32)
            {
                ret = PackUnpack.UpCast256<T, UInt64>(LoadUInt<T>(basePtr, scalarIndex, 4)).GetField<__UInt256__, long4>(0);
            }
            else if (default(T).Bits * 4 <= 64)
            {
                ret = PackUnpack.UpCast256<T, UInt64>(LoadULong<T>(basePtr, scalarIndex, 4)).GetField<__UInt256__, long4>(0);
            }
            else if (default(T).Bits * 4 <= 128)
            {
                ret = PackUnpack.UpCast256<T, UInt64>(LoadUInt128<T>(basePtr, scalarIndex, 4)).GetField<__UInt256__, long4>(0);
            }
            else
            {
                ret = PackUnpack.UpCast256<T, UInt64>(LoadUInt256<T>(basePtr, scalarIndex, 4)).GetField<__UInt256__, long4>(0);
            }

            if (default(T).IsSigned)
            {
                ret = signextend(ret, default(T).Bits);
            }

            return ret;
        }
    }
}
