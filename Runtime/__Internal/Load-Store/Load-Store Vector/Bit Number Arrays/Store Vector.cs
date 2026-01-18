using System.Runtime.CompilerServices;
using Unity.Mathematics;
using Unity.Burst.CompilerServices;
using Unity.Collections;
using MaxMath;
using DevTools;

using static MaxMath.maxmath;

namespace BitCollections
{
    unsafe internal static partial class LoadStore
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreVector<T, V>(void* basePtr, V vector, int index, int length)
            where T : BitInt
            where V : unmanaged
        {
            if (typeof(V) == typeof(bit8))      { StoreBit8<T>(basePtr, index, length, vector.Reinterpret<V, bit8>());          return; }
            if (typeof(V) == typeof(bit16))     { StoreBit16<T>(basePtr, index, length, vector.Reinterpret<V, bit16>());        return; }
            if (typeof(V) == typeof(bit24))     { StoreBit24<T>(basePtr, index, length, vector.Reinterpret<V, bit24>());        return; }
            if (typeof(V) == typeof(bit32))     { StoreBit32<T>(basePtr, index, length, vector.Reinterpret<V, bit32>());        return; }
            if (typeof(V) == typeof(bit40))     { StoreBit40<T>(basePtr, index, length, vector.Reinterpret<V, bit40>());        return; }
            if (typeof(V) == typeof(bit48))     { StoreBit48<T>(basePtr, index, length, vector.Reinterpret<V, bit48>());        return; }
            if (typeof(V) == typeof(bit56))     { StoreBit56<T>(basePtr, index, length, vector.Reinterpret<V, bit56>());        return; }
            if (typeof(V) == typeof(bit64))     { StoreBit64<T>(basePtr, index, length, vector.Reinterpret<V, bit64>());        return; }

            if (typeof(V) == typeof(Int2x4))    { StoreInt2x4<T>(basePtr, index, length, vector.Reinterpret<V, Int2x4>());      return; }
            if (typeof(V) == typeof(Int2x8))    { StoreInt2x8<T>(basePtr, index, length, vector.Reinterpret<V, Int2x8>());      return; }
            if (typeof(V) == typeof(Int2x12))   { StoreInt2x12<T>(basePtr, index, length, vector.Reinterpret<V, Int2x12>());    return; }
            if (typeof(V) == typeof(Int2x16))   { StoreInt2x16<T>(basePtr, index, length, vector.Reinterpret<V, Int2x16>());    return; }
            if (typeof(V) == typeof(Int2x20))   { StoreInt2x20<T>(basePtr, index, length, vector.Reinterpret<V, Int2x20>());    return; }
            if (typeof(V) == typeof(Int2x24))   { StoreInt2x24<T>(basePtr, index, length, vector.Reinterpret<V, Int2x24>());    return; }
            if (typeof(V) == typeof(Int2x28))   { StoreInt2x28<T>(basePtr, index, length, vector.Reinterpret<V, Int2x28>());    return; }
            if (typeof(V) == typeof(Int2x32))   { StoreInt2x32<T>(basePtr, index, length, vector.Reinterpret<V, Int2x32>());    return; }
            if (typeof(V) == typeof(UInt2x4))   { StoreUInt2x4<T>(basePtr, index, length, vector.Reinterpret<V, UInt2x4>());    return; }
            if (typeof(V) == typeof(UInt2x8))   { StoreUInt2x8<T>(basePtr, index, length, vector.Reinterpret<V, UInt2x8>());    return; }
            if (typeof(V) == typeof(UInt2x12))  { StoreUInt2x12<T>(basePtr, index, length, vector.Reinterpret<V, UInt2x12>());  return; }
            if (typeof(V) == typeof(UInt2x16))  { StoreUInt2x16<T>(basePtr, index, length, vector.Reinterpret<V, UInt2x16>());  return; }
            if (typeof(V) == typeof(UInt2x20))  { StoreUInt2x20<T>(basePtr, index, length, vector.Reinterpret<V, UInt2x20>());  return; }
            if (typeof(V) == typeof(UInt2x24))  { StoreUInt2x24<T>(basePtr, index, length, vector.Reinterpret<V, UInt2x24>());  return; }
            if (typeof(V) == typeof(UInt2x28))  { StoreUInt2x28<T>(basePtr, index, length, vector.Reinterpret<V, UInt2x28>());  return; }
            if (typeof(V) == typeof(UInt2x32))  { StoreUInt2x32<T>(basePtr, index, length, vector.Reinterpret<V, UInt2x32>());  return; }

            if (typeof(V) == typeof(Int3x8))    { StoreInt3x8<T>(basePtr, index, length, vector.Reinterpret<V, Int3x8>());      return; }
            if (typeof(V) == typeof(Int3x16))   { StoreInt3x16<T>(basePtr, index, length, vector.Reinterpret<V, Int3x16>());    return; }
            if (typeof(V) == typeof(UInt3x8))   { StoreUInt3x8<T>(basePtr, index, length, vector.Reinterpret<V, UInt3x8>());    return; }
            if (typeof(V) == typeof(UInt3x16))  { StoreUInt3x16<T>(basePtr, index, length, vector.Reinterpret<V, UInt3x16>());  return; }

            if (typeof(V) == typeof(Int4x2))    { StoreInt4x2<T>(basePtr, index, length, vector.Reinterpret<V, Int4x2>());      return; }
            if (typeof(V) == typeof(Int4x4))    { StoreInt4x4<T>(basePtr, index, length, vector.Reinterpret<V, Int4x4>());      return; }
            if (typeof(V) == typeof(Int4x6))    { StoreInt4x6<T>(basePtr, index, length, vector.Reinterpret<V, Int4x6>());      return; }
            if (typeof(V) == typeof(Int4x8))    { StoreInt4x8<T>(basePtr, index, length, vector.Reinterpret<V, Int4x8>());      return; }
            if (typeof(V) == typeof(Int4x10))   { StoreInt4x10<T>(basePtr, index, length, vector.Reinterpret<V, Int4x10>());    return; }
            if (typeof(V) == typeof(Int4x12))   { StoreInt4x12<T>(basePtr, index, length, vector.Reinterpret<V, Int4x12>());    return; }
            if (typeof(V) == typeof(Int4x14))   { StoreInt4x14<T>(basePtr, index, length, vector.Reinterpret<V, Int4x14>());    return; }
            if (typeof(V) == typeof(Int4x16))   { StoreInt4x16<T>(basePtr, index, length, vector.Reinterpret<V, Int4x16>());    return; }
            if (typeof(V) == typeof(UInt4x2))   { StoreUInt4x2<T>(basePtr, index, length, vector.Reinterpret<V, UInt4x2>());    return; }
            if (typeof(V) == typeof(UInt4x4))   { StoreUInt4x4<T>(basePtr, index, length, vector.Reinterpret<V, UInt4x4>());    return; }
            if (typeof(V) == typeof(UInt4x6))   { StoreUInt4x6<T>(basePtr, index, length, vector.Reinterpret<V, UInt4x6>());    return; }
            if (typeof(V) == typeof(UInt4x8))   { StoreUInt4x8<T>(basePtr, index, length, vector.Reinterpret<V, UInt4x8>());    return; }
            if (typeof(V) == typeof(UInt4x10))  { StoreUInt4x10<T>(basePtr, index, length, vector.Reinterpret<V, UInt4x10>());  return; }
            if (typeof(V) == typeof(UInt4x12))  { StoreUInt4x12<T>(basePtr, index, length, vector.Reinterpret<V, UInt4x12>());  return; }
            if (typeof(V) == typeof(UInt4x14))  { StoreUInt4x14<T>(basePtr, index, length, vector.Reinterpret<V, UInt4x14>());  return; }
            if (typeof(V) == typeof(UInt4x16))  { StoreUInt4x16<T>(basePtr, index, length, vector.Reinterpret<V, UInt4x16>());  return; }

            if (typeof(V) == typeof(Int5x8))    { StoreInt5x8<T>(basePtr, index, length, vector.Reinterpret<V, Int5x8>());      return; }
            if (typeof(V) == typeof(UInt5x8))   { StoreUInt5x8<T>(basePtr, index, length, vector.Reinterpret<V, UInt5x8>());    return; }

            if (typeof(V) == typeof(Int6x4))    { StoreInt6x4<T>(basePtr, index, length, vector.Reinterpret<V, Int6x4>());      return; }
            if (typeof(V) == typeof(Int6x8))    { StoreInt6x8<T>(basePtr, index, length, vector.Reinterpret<V, Int6x8>());      return; }
            if (typeof(V) == typeof(UInt6x4))   { StoreUInt6x4<T>(basePtr, index, length, vector.Reinterpret<V, UInt6x4>());    return; }
            if (typeof(V) == typeof(UInt6x8))   { StoreUInt6x8<T>(basePtr, index, length, vector.Reinterpret<V, UInt6x8>());    return; }

            if (typeof(V) == typeof(Int7x8))    { StoreInt7x8<T>(basePtr, index, length, vector.Reinterpret<V, Int7x8>());      return; }
            if (typeof(V) == typeof(UInt7x8))   { StoreUInt7x8<T>(basePtr, index, length, vector.Reinterpret<V, UInt7x8>());    return; }

            if (typeof(V) == typeof(Int10x4))   { StoreInt10x4<T>(basePtr, index, length, vector.Reinterpret<V, Int10x4>());    return; }
            if (typeof(V) == typeof(UInt10x4))  { StoreUInt10x4<T>(basePtr, index, length, vector.Reinterpret<V, UInt10x4>());  return; }

            if (typeof(V) == typeof(Int12x2))   { StoreInt12x2<T>(basePtr, index, length, vector.Reinterpret<V, Int12x2>());    return; }
            if (typeof(V) == typeof(Int12x4))   { StoreInt12x4<T>(basePtr, index, length, vector.Reinterpret<V, Int12x4>());    return; }
            if (typeof(V) == typeof(UInt12x2))  { StoreUInt12x2<T>(basePtr, index, length, vector.Reinterpret<V, UInt12x2>());  return; }
            if (typeof(V) == typeof(UInt12x4))  { StoreUInt12x4<T>(basePtr, index, length, vector.Reinterpret<V, UInt12x4>());  return; }

            if (typeof(V) == typeof(Int14x4))   { StoreInt14x4<T>(basePtr, index, length, vector.Reinterpret<V, Int14x4>());    return; }
            if (typeof(V) == typeof(UInt14x4))  { StoreUInt14x4<T>(basePtr, index, length, vector.Reinterpret<V, UInt14x4>());  return; }

            if (typeof(V) == typeof(Int20x2))   { StoreInt20x2<T>(basePtr, index, length, vector.Reinterpret<V, Int20x2>());    return; }
            if (typeof(V) == typeof(UInt20x2))  { StoreUInt20x2<T>(basePtr, index, length, vector.Reinterpret<V, UInt20x2>());  return; }

            if (typeof(V) == typeof(Int28x2))   { StoreInt28x2<T>(basePtr, index, length, vector.Reinterpret<V, Int28x2>());    return; }
            if (typeof(V) == typeof(UInt28x2))  { StoreUInt28x2<T>(basePtr, index, length, vector.Reinterpret<V, UInt28x2>());  return; }

            if (typeof(V) == typeof(sbyte2))    { StoreSByte2<T>(basePtr, index, length, vector.Reinterpret<V, sbyte2>());      return; }
            if (typeof(V) == typeof(sbyte3))    { StoreSByte3<T>(basePtr, index, length, vector.Reinterpret<V, sbyte3>());      return; }
            if (typeof(V) == typeof(sbyte4))    { StoreSByte4<T>(basePtr, index, length, vector.Reinterpret<V, sbyte4>());      return; }
            if (typeof(V) == typeof(sbyte8))    { StoreSByte8<T>(basePtr, index, length, vector.Reinterpret<V, sbyte8>());      return; }
            if (typeof(V) == typeof(sbyte16))   { StoreSByte16<T>(basePtr, index, length, vector.Reinterpret<V, sbyte16>());    return; }
            if (typeof(V) == typeof(sbyte32))   { StoreSByte32<T>(basePtr, index, length, vector.Reinterpret<V, sbyte32>());    return; }
            if (typeof(V) == typeof(byte2))     { StoreByte2<T>(basePtr, index, length, vector.Reinterpret<V, byte2>());        return; }
            if (typeof(V) == typeof(byte3))     { StoreByte3<T>(basePtr, index, length, vector.Reinterpret<V, byte3>());        return; }
            if (typeof(V) == typeof(byte4))     { StoreByte4<T>(basePtr, index, length, vector.Reinterpret<V, byte4>());        return; }
            if (typeof(V) == typeof(byte8))     { StoreByte8<T>(basePtr, index, length, vector.Reinterpret<V, byte8>());        return; }
            if (typeof(V) == typeof(byte16))    { StoreByte16<T>(basePtr, index, length, vector.Reinterpret<V, byte16>());      return; }
            if (typeof(V) == typeof(byte32))    { StoreByte32<T>(basePtr, index, length, vector.Reinterpret<V, byte32>());      return; }
            
            if (typeof(V) == typeof(short2))    { StoreShort2<T>(basePtr, index, length, vector.Reinterpret<V, short2>());      return; }
            if (typeof(V) == typeof(short3))    { StoreShort3<T>(basePtr, index, length, vector.Reinterpret<V, short3>());      return; }
            if (typeof(V) == typeof(short4))    { StoreShort4<T>(basePtr, index, length, vector.Reinterpret<V, short4>());      return; }
            if (typeof(V) == typeof(short8))    { StoreShort8<T>(basePtr, index, length, vector.Reinterpret<V, short8>());      return; }
            if (typeof(V) == typeof(short16))   { StoreShort16<T>(basePtr, index, length, vector.Reinterpret<V, short16>());    return; }
            if (typeof(V) == typeof(ushort2))   { StoreUShort2<T>(basePtr, index, length, vector.Reinterpret<V, ushort2>());    return; }
            if (typeof(V) == typeof(ushort3))   { StoreUShort3<T>(basePtr, index, length, vector.Reinterpret<V, ushort3>());    return; }
            if (typeof(V) == typeof(ushort4))   { StoreUShort4<T>(basePtr, index, length, vector.Reinterpret<V, ushort4>());    return; }
            if (typeof(V) == typeof(ushort8))   { StoreUShort8<T>(basePtr, index, length, vector.Reinterpret<V, ushort8>());    return; }
            if (typeof(V) == typeof(ushort16))  { StoreUShort16<T>(basePtr, index, length, vector.Reinterpret<V, ushort16>());  return; }
            
            if (typeof(V) == typeof(int2))      { StoreInt2<T>(basePtr, index, length, vector.Reinterpret<V, int2>());          return; }
            if (typeof(V) == typeof(int3))      { StoreInt3<T>(basePtr, index, length, vector.Reinterpret<V, int3>());          return; }
            if (typeof(V) == typeof(int4))      { StoreInt4<T>(basePtr, index, length, vector.Reinterpret<V, int4>());          return; }
            if (typeof(V) == typeof(int8))      { StoreInt8<T>(basePtr, index, length, vector.Reinterpret<V, int8>());          return; }
            if (typeof(V) == typeof(uint2))     { StoreUInt2<T>(basePtr, index, length, vector.Reinterpret<V, uint2>());        return; }
            if (typeof(V) == typeof(uint3))     { StoreUInt3<T>(basePtr, index, length, vector.Reinterpret<V, uint3>());        return; }
            if (typeof(V) == typeof(uint4))     { StoreUInt4<T>(basePtr, index, length, vector.Reinterpret<V, uint4>());        return; }
            if (typeof(V) == typeof(uint8))     { StoreUInt8<T>(basePtr, index, length, vector.Reinterpret<V, uint8>());        return; }
            
            if (typeof(V) == typeof(long2))     { StoreLong2<T>(basePtr, index, length, vector.Reinterpret<V, long2>());        return; }
            if (typeof(V) == typeof(long3))     { StoreLong3<T>(basePtr, index, length, vector.Reinterpret<V, long3>());        return; }
            if (typeof(V) == typeof(long4))     { StoreLong4<T>(basePtr, index, length, vector.Reinterpret<V, long4>());        return; }
            if (typeof(V) == typeof(ulong2))    { StoreULong2<T>(basePtr, index, length, vector.Reinterpret<V, ulong2>());      return; }
            if (typeof(V) == typeof(ulong3))    { StoreULong3<T>(basePtr, index, length, vector.Reinterpret<V, ulong3>());      return; }
            if (typeof(V) == typeof(ulong4))    { StoreULong4<T>(basePtr, index, length, vector.Reinterpret<V, ulong4>());      return; }

            throw new System.TypeAccessException($"{typeof(V)}");
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreBit8<T>(void* basePtr, int scalarIndex, int length, bit8 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 7, length);

            if (default(T).Bits == 8)
            {
                *(bool8*)((bool*)basePtr + scalarIndex) = tobool8(value.Bits);
            }

            if (default(T).Bits * 8 <= 64)
            {
                ulong cast = PackUnpack.UpCast64<Bit, T>((ulong)value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
            }
            else if (default(T).Bits * 8 <= 128)
            {
                UInt128 cast = PackUnpack.UpCast128<Bit, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
            }
            else if (default(T).Bits * 8 <= 256)
            {
                __UInt256__ cast = PackUnpack.UpCast256<Bit, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
            }
            else
            {
                __UInt512__ cast = PackUnpack.UpCast512<Bit, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreBit16<T>(void* basePtr, int scalarIndex, int length, bit16 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 15, length);
            
            if (default(T).Bits == 8)
            {
                *(bool16*)((bool*)basePtr + scalarIndex) = tobool16(value.Bits);
            }

            if (default(T).Bits * 16 <= 64)
            {
                ulong cast = PackUnpack.UpCast64<Bit, T>((ulong)value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 16);
            }
            else if (default(T).Bits * 16 <= 128)
            {
                UInt128 cast = PackUnpack.UpCast128<Bit, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 16);
            }
            else if (default(T).Bits * 16 <= 256)
            {
                __UInt256__ cast = PackUnpack.UpCast256<Bit, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 16);
            }
            else if (default(T).Bits * 16 <= 512)
            {
                __UInt512__ cast = PackUnpack.UpCast512<Bit, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 16);
            }
            else
            {
                __UInt1024__ cast = PackUnpack.UpCast1024<Bit, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 16);
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreBit24<T>(void* basePtr, int scalarIndex, int length, bit24 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 23, length);
            
            if (default(T).Bits == 8)
            {
                bool32 result = tobool32(value.Bits);

                *(bool16*)((bool*)basePtr + scalarIndex)     = result.v16_0;
                *(bool8*)((bool*)basePtr + 16 + scalarIndex) = result.v8_16;
            }

            if (default(T).Bits * 24 <= 64)
            {
                ulong cast = PackUnpack.UpCast64<Bit, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 24);
            }
            else if (default(T).Bits * 24 <= 128)
            {
                UInt128 cast = PackUnpack.UpCast128<Bit, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 24);
            }
            else if (default(T).Bits * 24 <= 256)
            {
                __UInt256__ cast = PackUnpack.UpCast256<Bit, T>((ulong)value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 24);
            }
            else if (default(T).Bits * 24 <= 512)
            {
                __UInt512__ cast = PackUnpack.UpCast512<Bit, T>((ulong)value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 24);
            }
            else if (default(T).Bits * 24 <= 1024)
            {
                __UInt1024__ cast = PackUnpack.UpCast1024<Bit, T>((ulong)value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 24);
            }
            else
            {
                __UInt2048__ cast = PackUnpack.UpCast2048<Bit, T>((ulong)value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 24);
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreBit32<T>(void* basePtr, int scalarIndex, int length, bit32 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 31, length);
            
            if (default(T).Bits == 8)
            {
                *(bool32*)((bool*)basePtr + scalarIndex) = tobool32((int)value.Bits);
            }

            if (default(T).Bits * 32 <= 64)
            {
                ulong cast = PackUnpack.UpCast64<Bit, T>((ulong)value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 32);
            }
            else if (default(T).Bits * 32 <= 128)
            {
                UInt128 cast = PackUnpack.UpCast128<Bit, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 32);
            }
            else if (default(T).Bits * 32 <= 256)
            {
                __UInt256__ cast = PackUnpack.UpCast256<Bit, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 32);
            }
            else if (default(T).Bits * 32 <= 512)
            {
                __UInt512__ cast = PackUnpack.UpCast512<Bit, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 32);
            }
            else if (default(T).Bits * 32 <= 1024)
            {
                __UInt1024__ cast = PackUnpack.UpCast1024<Bit, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 32);
            }
            else
            {
                __UInt2048__ cast = PackUnpack.UpCast2048<Bit, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 32);
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreBit40<T>(void* basePtr, int scalarIndex, int length, bit40 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 39, length);
            
            if (default(T).Bits == 8)
            {
                bool32 resultLo = tobool32((int)value.Bits);
                bool8 resultHi = tobool8((int)(value.Bits >> 32));

                *(bool32*)((bool*)basePtr + scalarIndex)     = resultLo;
                *(bool8*)((bool*)basePtr + 32 + scalarIndex) = resultHi;
            }

            if (default(T).Bits * 40 <= 40)
            {
                ulong cast = PackUnpack.UpCast64<Bit, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 40);
            }
            else if (default(T).Bits * 40 <= 128)
            {
                UInt128 cast = PackUnpack.UpCast128<Bit, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 40);
            }
            else if (default(T).Bits * 40 <= 256)
            {
                __UInt256__ cast = PackUnpack.UpCast256<Bit, T>((ulong)value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 40);
            }
            else if (default(T).Bits * 40 <= 512)
            {
                __UInt512__ cast = PackUnpack.UpCast512<Bit, T>((ulong)value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 40);
            }
            else if (default(T).Bits * 40 <= 1024)
            {
                __UInt1024__ cast = PackUnpack.UpCast1024<Bit, T>((ulong)value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 40);
            }
            else if (default(T).Bits * 40 <= 2048)
            {
                __UInt2048__ cast = PackUnpack.UpCast2048<Bit, T>((ulong)value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 40);
            }
            else
            {
                __UInt4096__ cast = PackUnpack.UpCast4096<Bit, T>((ulong)value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 40);
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreBit48<T>(void* basePtr, int scalarIndex, int length, bit48 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 47, length);
            
            if (default(T).Bits == 8)
            {
                bool32 resultLo = tobool32((int)value.Bits);
                bool16 resultHi = tobool16((int)(value.Bits >> 32));

                *(bool32*)((bool*)basePtr + scalarIndex)      = resultLo;
                *(bool16*)((bool*)basePtr + 32 + scalarIndex) = resultHi;
            }

            if (default(T).Bits * 48 <= 48)
            {
                ulong cast = PackUnpack.UpCast64<Bit, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 48);
            }
            else if (default(T).Bits * 48 <= 128)
            {
                UInt128 cast = PackUnpack.UpCast128<Bit, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 48);
            }
            else if (default(T).Bits * 48 <= 256)
            {
                __UInt256__ cast = PackUnpack.UpCast256<Bit, T>((ulong)value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 48);
            }
            else if (default(T).Bits * 48 <= 512)
            {
                __UInt512__ cast = PackUnpack.UpCast512<Bit, T>((ulong)value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 48);
            }
            else if (default(T).Bits * 48 <= 1024)
            {
                __UInt1024__ cast = PackUnpack.UpCast1024<Bit, T>((ulong)value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 48);
            }
            else if (default(T).Bits * 48 <= 2048)
            {
                __UInt2048__ cast = PackUnpack.UpCast2048<Bit, T>((ulong)value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 48);
            }
            else
            {
                __UInt4096__ cast = PackUnpack.UpCast4096<Bit, T>((ulong)value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 48);
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreBit56<T>(void* basePtr, int scalarIndex, int length, bit56 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 55, length);
            
            if (default(T).Bits == 8)
            {
                bool32 resultLo = tobool32((int)value.Bits);
                bool32 resultHi = tobool32((int)(value.Bits >> 32));

                *(bool32*)((bool*)basePtr + scalarIndex)      = resultLo;
                *(bool16*)((bool*)basePtr + 32 + scalarIndex) = resultHi.v16_0;
                *(bool8*)((bool*)basePtr + 48 + scalarIndex)  = resultHi.v8_16;
            }

            if (default(T).Bits * 56 <= 56)
            {
                ulong cast = PackUnpack.UpCast64<Bit, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 56);
            }
            else if (default(T).Bits * 56 <= 128)
            {
                UInt128 cast = PackUnpack.UpCast128<Bit, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 56);
            }
            else if (default(T).Bits * 56 <= 256)
            {
                __UInt256__ cast = PackUnpack.UpCast256<Bit, T>((ulong)value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 56);
            }
            else if (default(T).Bits * 56 <= 512)
            {
                __UInt512__ cast = PackUnpack.UpCast512<Bit, T>((ulong)value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 56);
            }
            else if (default(T).Bits * 56 <= 1024)
            {
                __UInt1024__ cast = PackUnpack.UpCast1024<Bit, T>((ulong)value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 56);
            }
            else if (default(T).Bits * 56 <= 2048)
            {
                __UInt2048__ cast = PackUnpack.UpCast2048<Bit, T>((ulong)value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 56);
            }
            else
            {
                __UInt4096__ cast = PackUnpack.UpCast4096<Bit, T>((ulong)value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 56);
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreBit64<T>(void* basePtr, int scalarIndex, int length, bit64 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 63, length);
            
            if (default(T).Bits == 8)
            {
                *(bool32*)((bool*)basePtr + scalarIndex)       = tobool32((int)value.Bits);
                *(bool32*)((bool*)basePtr + 32 + scalarIndex) = tobool32((int)(value.Bits >> 32));
            }

            if (default(T).Bits * 64 <= 64)
            {
                ulong cast = PackUnpack.UpCast64<Bit, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 64);
            }
            else if (default(T).Bits * 64 <= 128)
            {
                UInt128 cast = PackUnpack.UpCast128<Bit, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 64);
            }
            else if (default(T).Bits * 64 <= 256)
            {
                __UInt256__ cast = PackUnpack.UpCast256<Bit, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 64);
            }
            else if (default(T).Bits * 64 <= 512)
            {
                __UInt512__ cast = PackUnpack.UpCast512<Bit, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 64);
            }
            else if (default(T).Bits * 64 <= 1024)
            {
                __UInt1024__ cast = PackUnpack.UpCast1024<Bit, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 64);
            }
            else if (default(T).Bits * 64 <= 2048)
            {
                __UInt2048__ cast = PackUnpack.UpCast2048<Bit, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 64);
            }
            else
            {
                __UInt4096__ cast = PackUnpack.UpCast4096<Bit, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 64);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreInt2x4<T>(void* basePtr, int scalarIndex, int length, Int2x4 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 3, length);
            
            if (default(T).Bits == 2)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 4);
            }
            else if (default(T).Bits < 2)
            {
                ulong cast = PackUnpack.DownCast<Int2, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 4);
            }
            else
            {
                if (default(T).Bits <= 16)
                {
                    short4 cast = (short4)PackUnpack.BitIntArrayToUShort4<Int2>(value.Bits);
                    cast = signextend(cast, default(Int2).Bits);
                    ulong cast64 = PackUnpack.DownCast<T>(cast);

                    CopyAscending<T>(&cast64, 0, basePtr, scalarIndex, 4);
                }
                else if (default(T).Bits <= 32)
                {
                    int4 cast = (int4)PackUnpack.BitIntArrayToUInt4<Int2>(value.Bits);
                    cast = signextend(cast, default(Int2).Bits);
                    UInt128 cast128 = PackUnpack.DownCast128<T>(cast);

                    CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 4);
                }
                else
                {
                    long4 cast = (long4)PackUnpack.BitIntArrayToULong4<Int2>(value.Bits);
                    cast = signextend(cast, default(Int2).Bits);
                    __UInt256__ cast256 = PackUnpack.DownCast256<T>(cast);

                    CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 4);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreInt2x8<T>(void* basePtr, int scalarIndex, int length, Int2x8 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 7, length);
            
            if (default(T).Bits == 2)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 8);
            }
            else if (default(T).Bits < 2)
            {
                ulong cast = PackUnpack.DownCast<Int2, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
            }
            else
            {
                if (default(T).Bits <= 8)
                {
                    sbyte8 cast = (sbyte8)PackUnpack.BitIntArrayToByte8<Int2>(value.Bits);
                    cast = signextend(cast, default(Int2).Bits);
                    ulong cast64 = PackUnpack.DownCast<T>(cast);

                    CopyAscending<T>(&cast64, 0, basePtr, scalarIndex, 8);
                }
                if (default(T).Bits <= 16)
                {
                    short8 cast = (short8)PackUnpack.BitIntArrayToUShort8<Int2>(value.Bits);
                    cast = signextend(cast, default(Int2).Bits);
                    UInt128 cast128 = PackUnpack.DownCast128<T>(cast);

                    CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 8);
                }
                else if (default(T).Bits <= 32)
                {
                    int8 cast = (int8)PackUnpack.BitIntArrayToUInt8<Int2>(value.Bits);
                    cast = signextend(cast, default(Int2).Bits);
                    __UInt256__ cast256 = PackUnpack.DownCast256<T>(cast);

                    CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 8);
                }
                else
                {
                    long4 lo = (long4)PackUnpack.BitIntArrayToULong4<Int2>(value.Bits);
                    long4 hi = (long4)PackUnpack.BitIntArrayToULong4<Int2>((ulong)(value.Bits >> (4 * default(Int2).Bits)));
                    lo = signextend(lo, default(Int2).Bits);
                    hi = signextend(hi, default(Int2).Bits);
                    __UInt256__ lo256 = PackUnpack.DownCast256<T>(lo);
                    __UInt256__ hi256 = PackUnpack.DownCast256<T>(hi);
                    __UInt512__ cast512 = (__UInt512__)lo256 | ((__UInt512__)hi256 << (4 * default(T).Bits));

                    CopyAscending<T>(&cast512, 0, basePtr, scalarIndex, 8);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreInt2x12<T>(void* basePtr, int scalarIndex, int length, Int2x12 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 11, length);

            if (default(T).Bits == 2)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 12);
            }
            else if (default(T).Bits < 2)
            {
                ulong cast = PackUnpack.DownCast<Int2, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 12);
            }
            else
            {
                if (default(T).Bits <= 8)
                {
                    sbyte8 cast0 = (sbyte8)PackUnpack.BitIntArrayToByte8<Int2>(value.Bits);
                    sbyte4 cast1 = (sbyte4)PackUnpack.BitIntArrayToByte4<Int2>(value.Bits >> (8 * default(Int2).Bits));
                    cast0 = signextend(cast0, default(Int2).Bits);
                    cast1 = signextend(cast1, default(Int2).Bits);
                    UInt128 lo = PackUnpack.DownCast128<T>(cast0);
                    ulong   hi = PackUnpack.DownCast<T>(cast1);
                    
                    UInt128 cast128 = lo | ((UInt128)hi << (8 * default(T).Bits));
                    CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 12);
                }
                if (default(T).Bits <= 16)
                {
                    short8 cast0 = (short8)PackUnpack.BitIntArrayToUShort8<Int2>(value.Bits);
                    short4 cast1 = (short4)PackUnpack.BitIntArrayToUShort4<Int2>(value.Bits >> (8 * default(Int2).Bits));
                    cast0 = signextend(cast0, default(Int2).Bits);
                    cast1 = signextend(cast1, default(Int2).Bits);
                    UInt128 lo = PackUnpack.DownCast128<T>(cast0);
                    ulong   hi = PackUnpack.DownCast<T>(cast1);

                    if (default(T).Bits * 12 <= 128)
                    {
                        UInt128 cast128 = lo | ((UInt128)hi << (8 * default(T).Bits));
                        CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 12);
                    }
                    else
                    {
                        __UInt256__ cast256 = (__UInt256__)lo | ((__UInt256__)hi << (8 * default(T).Bits));
                        CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 12);
                    }
                }
                else if (default(T).Bits <= 32)
                {
                    int8 cast0 = (int8)PackUnpack.BitIntArrayToUInt8<Int2>(value.Bits);
                    int4 cast1 = (int4)PackUnpack.BitIntArrayToUInt4<Int2>(value.Bits >> (8 * default(Int2).Bits));
                    cast0 = signextend(cast0, default(Int2).Bits);
                    cast1 = signextend(cast1, default(Int2).Bits);
                    __UInt256__ lo = PackUnpack.DownCast256<T>(cast0);
                    UInt128     hi = PackUnpack.DownCast128<T>(cast1);

                    if (default(T).Bits * 12 <= 256)
                    {
                        __UInt256__ cast256 = (__UInt256__)lo | ((__UInt256__)hi << (8 * default(T).Bits));
                        CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 12);
                    }
                    else
                    {
                        __UInt512__ cast256 = (__UInt512__)lo | ((__UInt512__)hi << (8 * default(T).Bits));
                        CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 12);
                    }
                }
                else
                {
                    long4 _0 = (long4)PackUnpack.BitIntArrayToULong4<Int2>(value.Bits);
                    long4 _1 = (long4)PackUnpack.BitIntArrayToULong4<Int2>((ulong)(value.Bits >> (4 * default(Int2).Bits)));
                    long4 _2 = (long4)PackUnpack.BitIntArrayToULong4<Int2>((ulong)(value.Bits >> (8 * default(Int2).Bits)));
                    _0 = signextend(_0, default(Int2).Bits);
                    _1 = signextend(_1, default(Int2).Bits);
                    _2 = signextend(_2, default(Int2).Bits);
                    __UInt256__ _0_256 = PackUnpack.DownCast256<T>(_0);
                    __UInt256__ _1_256 = PackUnpack.DownCast256<T>(_1);
                    __UInt256__ _2_256 = PackUnpack.DownCast256<T>(_2);

                    if (default(T).Bits * 12 <= 512)
                    {
                        __UInt512__ cast512 = (__UInt512__)_0_256 | ((__UInt512__)_1_256 << (4 * default(T).Bits)) | ((__UInt512__)_2_256 << (8 * default(T).Bits));
                        CopyAscending<T>(&cast512, 0, basePtr, scalarIndex, 12);
                    }
                    else
                    {
                        __UInt1024__ cast1024 = (__UInt1024__)_0_256 | ((__UInt1024__)_1_256 << (4 * default(T).Bits)) | ((__UInt1024__)_2_256 << (8 * default(T).Bits));
                        CopyAscending<T>(&cast1024, 0, basePtr, scalarIndex, 12);
                    }
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreInt2x16<T>(void* basePtr, int scalarIndex, int length, Int2x16 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 15, length);
            
            if (default(T).Bits == 2)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 16);
            }
            else if (default(T).Bits < 2)
            {
                ulong cast = PackUnpack.DownCast<UInt2, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 16);
            }
            else
            {
                if (default(T).Bits <= 8)
                {
                    sbyte8 cast0 = (sbyte8)PackUnpack.BitIntArrayToByte8<Int2>(value.Bits);
                    sbyte8 cast1 = (sbyte8)PackUnpack.BitIntArrayToByte8<Int2>(value.Bits >> (8 * default(Int2).Bits));
                    cast0 = signextend(cast0, default(Int2).Bits);
                    cast1 = signextend(cast1, default(Int2).Bits);
                    ulong lo = PackUnpack.DownCast<T>(cast0);
                    ulong hi = PackUnpack.DownCast<T>(cast1);

                    UInt128 cast128 = (UInt128)lo | ((UInt128)hi << (8 * default(T).Bits));
                    CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 16);
                }
                if (default(T).Bits <= 16)
                {
                    short8 cast0 = (short8)PackUnpack.BitIntArrayToUShort8<Int2>(value.Bits);
                    short8 cast1 = (short8)PackUnpack.BitIntArrayToUShort8<Int2>(value.Bits >> (8 * default(Int2).Bits));
                    cast0 = signextend(cast0, default(Int2).Bits);
                    cast1 = signextend(cast1, default(Int2).Bits);
                    UInt128 lo = PackUnpack.DownCast128<T>(cast0);
                    UInt128 hi = PackUnpack.DownCast128<T>(cast1);

                    if (default(T).Bits * 16 <= 128)
                    {
                        UInt128 cast128 = lo | (hi << (8 * default(T).Bits));
                        CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 16);
                    }
                    else
                    {
                        __UInt256__ cast256 = (__UInt256__)lo | ((__UInt256__)hi << (8 * default(T).Bits));
                        CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 16);
                    }
                }
                else if (default(T).Bits <= 32)
                {
                    int8 cast0 = (int8)PackUnpack.BitIntArrayToUInt8<Int2>(value.Bits);
                    int8 cast1 = (int8)PackUnpack.BitIntArrayToUInt8<Int2>(value.Bits >> (8 * default(Int2).Bits));
                    cast0 = signextend(cast0, default(Int2).Bits);
                    cast1 = signextend(cast1, default(Int2).Bits);
                    __UInt256__ lo = PackUnpack.DownCast256<T>(cast0);
                    __UInt256__ hi = PackUnpack.DownCast256<T>(cast1);

                    if (default(T).Bits * 16 <= 256)
                    {
                        __UInt256__ cast256 = lo | (hi << (8 * default(T).Bits));
                        CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 16);
                    }
                    else
                    {
                        __UInt512__ cast256 = (__UInt512__)lo | ((__UInt512__)hi << (8 * default(T).Bits));
                        CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 16);
                    }
                }
                else
                {
                    long4 _0 = (long4)PackUnpack.BitIntArrayToULong4<Int2>(value.Bits);
                    long4 _1 = (long4)PackUnpack.BitIntArrayToULong4<Int2>((ulong)(value.Bits >> (4  * default(Int2).Bits)));
                    long4 _2 = (long4)PackUnpack.BitIntArrayToULong4<Int2>((ulong)(value.Bits >> (8  * default(Int2).Bits)));
                    long4 _3 = (long4)PackUnpack.BitIntArrayToULong4<Int2>((ulong)(value.Bits >> (12 * default(Int2).Bits)));
                    _0 = signextend(_0, default(Int2).Bits);
                    _1 = signextend(_1, default(Int2).Bits);
                    _2 = signextend(_2, default(Int2).Bits);
                    _3 = signextend(_3, default(Int2).Bits);
                    __UInt256__ _0_256 = PackUnpack.DownCast256<T>(_0);
                    __UInt256__ _1_256 = PackUnpack.DownCast256<T>(_1);
                    __UInt256__ _2_256 = PackUnpack.DownCast256<T>(_2);
                    __UInt256__ _3_256 = PackUnpack.DownCast256<T>(_3);

                    __UInt1024__ cast1024 = (__UInt1024__)_0_256 | ((__UInt1024__)_1_256 << (4 * default(T).Bits)) | ((__UInt1024__)_2_256 << (8 * default(T).Bits)) | ((__UInt1024__)_3_256 << (12 * default(T).Bits));
                    CopyAscending<T>(&cast1024, 0, basePtr, scalarIndex, 16);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreInt2x20<T>(void* basePtr, int scalarIndex, int length, Int2x20 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 19, length);
            
            if (default(T).Bits == 2)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 20);
            }
            else if (default(T).Bits < 2)
            {
                ulong cast = PackUnpack.DownCast<UInt2, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 20);
            }
            else
            {
                if (default(T).Bits <= 8)
                {
                    sbyte8 cast0 = (sbyte8)PackUnpack.BitIntArrayToByte8<Int2>(value.Bits);
                    sbyte8 cast1 = (sbyte8)PackUnpack.BitIntArrayToByte8<Int2>(value.Bits >> (8 * default(Int2).Bits));
                    sbyte4 cast2 = (sbyte4)PackUnpack.BitIntArrayToByte4<Int2>((uint)(value.Bits >> (16 * default(Int2).Bits)));
                    cast0 = signextend(cast0, default(Int2).Bits);
                    cast1 = signextend(cast1, default(Int2).Bits);
                    cast2 = signextend(cast2, default(Int2).Bits);
                    UInt128 _0_128 = PackUnpack.DownCast128<T>(cast0);
                    UInt128 _1_128 = PackUnpack.DownCast128<T>(cast1);
                    UInt128 _2_128 = PackUnpack.DownCast<T>(cast2);

                    if (default(T).Bits * 20 <= 128)
                    {
                        UInt128 cast128 = _0_128 | (_1_128 << (8 * default(T).Bits)) | (_2_128 << (16 * default(T).Bits));
                        CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 20);
                    }
                    else
                    {
                        __UInt256__ cast256 = (__UInt256__)_0_128 | ((__UInt256__)_1_128 << (8 * default(T).Bits)) | ((__UInt256__)_2_128 << (16 * default(T).Bits));
                        CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 20);
                    }
                }
                if (default(T).Bits <= 16)
                {
                    short8 cast0 = (short8)PackUnpack.BitIntArrayToUShort8<Int2>(value.Bits);
                    short8 cast1 = (short8)PackUnpack.BitIntArrayToUShort8<Int2>(value.Bits >> (8 * default(Int2).Bits));
                    short4 cast2 = (short4)PackUnpack.BitIntArrayToUShort4<Int2>(value.Bits >> (16 * default(Int2).Bits));
                    cast0 = signextend(cast0, default(Int2).Bits);
                    cast1 = signextend(cast1, default(Int2).Bits);
                    cast2 = signextend(cast2, default(Int2).Bits);
                    UInt128 _0_128 = PackUnpack.DownCast128<T>(cast0);
                    UInt128 _1_128 = PackUnpack.DownCast128<T>(cast1);
                    UInt128 _2_128 = PackUnpack.DownCast<T>(cast2);

                    if (default(T).Bits * 20 <= 128)
                    {
                        UInt128 cast128 = _0_128 | (_1_128 << (8 * default(T).Bits)) | (_2_128 << (16 * default(T).Bits));
                        CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 20);
                    }
                    else if (default(T).Bits * 20 <= 256)
                    {
                        __UInt256__ cast256 = (__UInt256__)_0_128 | ((__UInt256__)_1_128 << (8 * default(T).Bits)) | ((__UInt256__)_2_128 << (16 * default(T).Bits));
                        CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 20);
                    }
                    else
                    {
                        __UInt512__ cast512 = (__UInt512__)_0_128 | ((__UInt512__)_1_128 << (8 * default(T).Bits)) | ((__UInt512__)_2_128 << (16 * default(T).Bits));
                        CopyAscending<T>(&cast512, 0, basePtr, scalarIndex, 20);
                    }
                }
                else if (default(T).Bits <= 32)
                {
                    int8 cast0 = (int8)PackUnpack.BitIntArrayToUInt8<Int2>(value.Bits);
                    int8 cast1 = (int8)PackUnpack.BitIntArrayToUInt8<Int2>(value.Bits >> (8 * default(Int2).Bits));
                    int4 cast2 = (int4)PackUnpack.BitIntArrayToUInt4<Int2>(value.Bits >> (16 * default(Int2).Bits));
                    cast0 = signextend(cast0, default(Int2).Bits);
                    cast1 = signextend(cast1, default(Int2).Bits);
                    cast2 = signextend(cast2, default(Int2).Bits);
                    __UInt256__ _0_256 = PackUnpack.DownCast256<T>(cast0);
                    __UInt256__ _1_256 = PackUnpack.DownCast256<T>(cast1);
                    __UInt256__ _2_256 = PackUnpack.DownCast128<T>(cast2);

                    if (default(T).Bits * 20 <= 512)
                    {
                        __UInt512__ cast512 = (__UInt512__)_0_256 | ((__UInt512__)_1_256 << (8 * default(T).Bits)) | ((__UInt512__)_2_256 << (16 * default(T).Bits));
                        CopyAscending<T>(&cast512, 0, basePtr, scalarIndex, 20);
                    }
                    else
                    {
                        __UInt1024__ cast1024 = (__UInt1024__)_0_256 | ((__UInt1024__)_1_256 << (8 * default(T).Bits)) | ((__UInt1024__)_2_256 << (16 * default(T).Bits));
                        CopyAscending<T>(&cast1024, 0, basePtr, scalarIndex, 20);
                    }
                }
                else
                {
                    long4 _0 = (long4)PackUnpack.BitIntArrayToULong4<Int2>(value.Bits);
                    long4 _1 = (long4)PackUnpack.BitIntArrayToULong4<Int2>((ulong)(value.Bits >> (4  * default(Int2).Bits)));
                    long4 _2 = (long4)PackUnpack.BitIntArrayToULong4<Int2>((ulong)(value.Bits >> (8  * default(Int2).Bits)));
                    long4 _3 = (long4)PackUnpack.BitIntArrayToULong4<Int2>((ulong)(value.Bits >> (12 * default(Int2).Bits)));
                    long4 _4 = (long4)PackUnpack.BitIntArrayToULong4<Int2>((ulong)(value.Bits >> (16 * default(Int2).Bits)));
                    _0 = signextend(_0, default(Int2).Bits);
                    _1 = signextend(_1, default(Int2).Bits);
                    _2 = signextend(_2, default(Int2).Bits);
                    _3 = signextend(_3, default(Int2).Bits);
                    _4 = signextend(_4, default(Int2).Bits);
                    __UInt256__ _0_256 = PackUnpack.DownCast256<T>(_0);
                    __UInt256__ _1_256 = PackUnpack.DownCast256<T>(_1);
                    __UInt256__ _2_256 = PackUnpack.DownCast256<T>(_2);
                    __UInt256__ _3_256 = PackUnpack.DownCast256<T>(_3);
                    __UInt256__ _4_256 = PackUnpack.DownCast256<T>(_4);
                    
                    if (default(T).Bits * 20 <= 1024)
                    {
                        __UInt1024__ cast1024 = (__UInt1024__)_0_256 | ((__UInt1024__)_1_256 << (4 * default(T).Bits)) | ((__UInt1024__)_2_256 << (8 * default(T).Bits)) | ((__UInt1024__)_3_256 << (12 * default(T).Bits)) | ((__UInt1024__)_4_256 << (16 * default(T).Bits));
                        CopyAscending<T>(&cast1024, 0, basePtr, scalarIndex, 20);
                    }
                    else
                    {
                        __UInt2048__ cast2048 = (__UInt2048__)_0_256 | ((__UInt2048__)_1_256 << (4 * default(T).Bits)) | ((__UInt2048__)_2_256 << (8 * default(T).Bits)) | ((__UInt2048__)_3_256 << (12 * default(T).Bits)) | ((__UInt2048__)_4_256 << (16 * default(T).Bits));
                        CopyAscending<T>(&cast2048, 0, basePtr, scalarIndex, 20);
                    }
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreInt2x24<T>(void* basePtr, int scalarIndex, int length, Int2x24 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 23, length);
            
            if (default(T).Bits == 2)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 24);
            }
            else if (default(T).Bits < 2)
            {
                ulong cast = PackUnpack.DownCast<UInt2, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 24);
            }
            else
            {
                if (default(T).Bits <= 8)
                {
                    sbyte8 cast0 = (sbyte8)PackUnpack.BitIntArrayToByte8<Int2>(value.Bits);
                    sbyte8 cast1 = (sbyte8)PackUnpack.BitIntArrayToByte8<Int2>(value.Bits >> (8 * default(Int2).Bits));
                    sbyte8 cast2 = (sbyte8)PackUnpack.BitIntArrayToByte8<Int2>(value.Bits >> (16 * default(Int2).Bits));
                    cast0 = signextend(cast0, default(Int2).Bits);
                    cast1 = signextend(cast1, default(Int2).Bits);
                    cast2 = signextend(cast2, default(Int2).Bits);
                    UInt128 _0_128 = PackUnpack.DownCast128<T>(cast0);
                    UInt128 _1_128 = PackUnpack.DownCast128<T>(cast1);
                    UInt128 _2_128 = PackUnpack.DownCast128<T>(cast2);

                    if (default(T).Bits * 24 <= 128)
                    {
                        UInt128 cast128 = _0_128 | (_1_128 << (8 * default(T).Bits)) | (_2_128 << (16 * default(T).Bits));
                        CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 24);
                    }
                    else
                    {
                        __UInt256__ cast256 = (__UInt256__)_0_128 | ((__UInt256__)_1_128 << (8 * default(T).Bits)) | ((__UInt256__)_2_128 << (16 * default(T).Bits));
                        CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 24);
                    }
                }
                if (default(T).Bits <= 16)
                {
                    short8 cast0 = (short8)PackUnpack.BitIntArrayToUShort8<Int2>(value.Bits);
                    short8 cast1 = (short8)PackUnpack.BitIntArrayToUShort8<Int2>(value.Bits >> (8 * default(Int2).Bits));
                    short8 cast2 = (short8)PackUnpack.BitIntArrayToUShort8<Int2>(value.Bits >> (16 * default(Int2).Bits));
                    cast0 = signextend(cast0, default(Int2).Bits);
                    cast1 = signextend(cast1, default(Int2).Bits);
                    cast2 = signextend(cast2, default(Int2).Bits);
                    UInt128 _0_128 = PackUnpack.DownCast128<T>(cast0);
                    UInt128 _1_128 = PackUnpack.DownCast128<T>(cast1);
                    UInt128 _2_128 = PackUnpack.DownCast128<T>(cast2);

                    if (default(T).Bits * 24 <= 128)
                    {
                        UInt128 cast128 = _0_128 | (_1_128 << (8 * default(T).Bits)) | (_2_128 << (16 * default(T).Bits));
                        CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 24);
                    }
                    else if (default(T).Bits * 24 <= 256)
                    {
                        __UInt256__ cast256 = (__UInt256__)_0_128 | ((__UInt256__)_1_128 << (8 * default(T).Bits)) | ((__UInt256__)_2_128 << (16 * default(T).Bits));
                        CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 24);
                    }
                    else
                    {
                        __UInt512__ cast512 = (__UInt512__)_0_128 | ((__UInt512__)_1_128 << (8 * default(T).Bits)) | ((__UInt512__)_2_128 << (16 * default(T).Bits));
                        CopyAscending<T>(&cast512, 0, basePtr, scalarIndex, 24);
                    }
                }
                else if (default(T).Bits <= 32)
                {
                    int8 cast0 = (int8)PackUnpack.BitIntArrayToUInt8<Int2>(value.Bits);
                    int8 cast1 = (int8)PackUnpack.BitIntArrayToUInt8<Int2>(value.Bits >> (8 * default(Int2).Bits));
                    int8 cast2 = (int8)PackUnpack.BitIntArrayToUInt8<Int2>(value.Bits >> (16 * default(Int2).Bits));
                    cast0 = signextend(cast0, default(Int2).Bits);
                    cast1 = signextend(cast1, default(Int2).Bits);
                    cast2 = signextend(cast2, default(Int2).Bits);
                    __UInt256__ _0_256 = PackUnpack.DownCast256<T>(cast0);
                    __UInt256__ _1_256 = PackUnpack.DownCast256<T>(cast1);
                    __UInt256__ _2_256 = PackUnpack.DownCast256<T>(cast2);

                    if (default(T).Bits * 24 <= 512)
                    {
                        __UInt512__ cast512 = (__UInt512__)_0_256 | ((__UInt512__)_1_256 << (8 * default(T).Bits)) | ((__UInt512__)_2_256 << (16 * default(T).Bits));
                        CopyAscending<T>(&cast512, 0, basePtr, scalarIndex, 24);
                    }
                    else
                    {
                        __UInt1024__ cast1024 = (__UInt1024__)_0_256 | ((__UInt1024__)_1_256 << (8 * default(T).Bits)) | ((__UInt1024__)_2_256 << (16 * default(T).Bits));
                        CopyAscending<T>(&cast1024, 0, basePtr, scalarIndex, 24);
                    }
                }
                else
                {
                    long4 _0 = (long4)PackUnpack.BitIntArrayToULong4<Int2>(value.Bits);
                    long4 _1 = (long4)PackUnpack.BitIntArrayToULong4<Int2>((ulong)(value.Bits >> (4  * default(Int2).Bits)));
                    long4 _2 = (long4)PackUnpack.BitIntArrayToULong4<Int2>((ulong)(value.Bits >> (8  * default(Int2).Bits)));
                    long4 _3 = (long4)PackUnpack.BitIntArrayToULong4<Int2>((ulong)(value.Bits >> (12 * default(Int2).Bits)));
                    long4 _4 = (long4)PackUnpack.BitIntArrayToULong4<Int2>((ulong)(value.Bits >> (16 * default(Int2).Bits)));
                    long4 _5 = (long4)PackUnpack.BitIntArrayToULong4<Int2>((ulong)(value.Bits >> (20 * default(Int2).Bits)));
                    _0 = signextend(_0, default(Int2).Bits);
                    _1 = signextend(_1, default(Int2).Bits);
                    _2 = signextend(_2, default(Int2).Bits);
                    _3 = signextend(_3, default(Int2).Bits);
                    _4 = signextend(_4, default(Int2).Bits);
                    _5 = signextend(_5, default(Int2).Bits);
                    __UInt256__ _0_256 = PackUnpack.DownCast256<T>(_0);
                    __UInt256__ _1_256 = PackUnpack.DownCast256<T>(_1);
                    __UInt256__ _2_256 = PackUnpack.DownCast256<T>(_2);
                    __UInt256__ _3_256 = PackUnpack.DownCast256<T>(_3);
                    __UInt256__ _4_256 = PackUnpack.DownCast256<T>(_4);
                    __UInt256__ _5_256 = PackUnpack.DownCast256<T>(_5);
                    
                    if (default(T).Bits * 24 <= 1024)
                    {
                        __UInt1024__ cast1024 = (__UInt1024__)_0_256 | ((__UInt1024__)_1_256 << (4 * default(T).Bits)) | ((__UInt1024__)_2_256 << (8 * default(T).Bits)) | ((__UInt1024__)_3_256 << (12 * default(T).Bits)) | ((__UInt1024__)_4_256 << (16 * default(T).Bits)) | ((__UInt1024__)_5_256 << (20 * default(T).Bits));
                        CopyAscending<T>(&cast1024, 0, basePtr, scalarIndex, 24);
                    }
                    else
                    {
                        __UInt2048__ cast2048 = (__UInt2048__)_0_256 | ((__UInt2048__)_1_256 << (4 * default(T).Bits)) | ((__UInt2048__)_2_256 << (8 * default(T).Bits)) | ((__UInt2048__)_3_256 << (12 * default(T).Bits)) | ((__UInt2048__)_4_256 << (16 * default(T).Bits)) | ((__UInt2048__)_5_256 << (20 * default(T).Bits));
                        CopyAscending<T>(&cast2048, 0, basePtr, scalarIndex, 24);
                    }
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreInt2x28<T>(void* basePtr, int scalarIndex, int length, Int2x28 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 27, length);
            
            if (default(T).Bits == 2)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 28);
            }
            else if (default(T).Bits < 2)
            {
                ulong cast = PackUnpack.DownCast<UInt2, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 28);
            }
            else
            {
                if (default(T).Bits <= 8)
                {
                    sbyte8 cast0 = (sbyte8)PackUnpack.BitIntArrayToByte8<Int2>(value.Bits);
                    sbyte8 cast1 = (sbyte8)PackUnpack.BitIntArrayToByte8<Int2>(value.Bits >> (8 * default(Int2).Bits));
                    sbyte8 cast2 = (sbyte8)PackUnpack.BitIntArrayToByte8<Int2>(value.Bits >> (16 * default(Int2).Bits));
                    sbyte4 cast3 = (sbyte4)PackUnpack.BitIntArrayToByte4<Int2>((uint)(value.Bits >> (24 * default(Int2).Bits)));
                    cast0 = signextend(cast0, default(Int2).Bits);
                    cast1 = signextend(cast1, default(Int2).Bits);
                    cast2 = signextend(cast2, default(Int2).Bits);
                    cast3 = signextend(cast3, default(Int2).Bits);
                    UInt128 _0_128 = PackUnpack.DownCast128<T>(cast0);
                    UInt128 _1_128 = PackUnpack.DownCast128<T>(cast1);
                    UInt128 _2_128 = PackUnpack.DownCast128<T>(cast2);
                    UInt128 _3_128 = PackUnpack.DownCast<T>(cast3);

                    if (default(T).Bits * 28 <= 128)
                    {
                        UInt128 cast128 = _0_128 | (_1_128 << (8 * default(T).Bits)) | (_2_128 << (16 * default(T).Bits)) | (_3_128 << (24 * default(T).Bits));
                        CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 28);
                    }
                    else 
                    {
                        __UInt256__ cast256 = (__UInt256__)_0_128 | ((__UInt256__)_1_128 << (8 * default(T).Bits)) | ((__UInt256__)_2_128 << (16 * default(T).Bits)) | ((__UInt256__)_3_128 << (24 * default(T).Bits));
                        CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 28);
                    }
                }
                if (default(T).Bits <= 16)
                {
                    short8 cast0 = (short8)PackUnpack.BitIntArrayToUShort8<Int2>(value.Bits);
                    short8 cast1 = (short8)PackUnpack.BitIntArrayToUShort8<Int2>(value.Bits >> (8 * default(Int2).Bits));
                    short8 cast2 = (short8)PackUnpack.BitIntArrayToUShort8<Int2>(value.Bits >> (16 * default(Int2).Bits));
                    short4 cast3 = (short4)PackUnpack.BitIntArrayToUShort4<Int2>(value.Bits >> (24 * default(Int2).Bits));
                    cast0 = signextend(cast0, default(Int2).Bits);
                    cast1 = signextend(cast1, default(Int2).Bits);
                    cast2 = signextend(cast2, default(Int2).Bits);
                    cast3 = signextend(cast3, default(Int2).Bits);
                    UInt128 _0_128 = PackUnpack.DownCast128<T>(cast0);
                    UInt128 _1_128 = PackUnpack.DownCast128<T>(cast1);
                    UInt128 _2_128 = PackUnpack.DownCast128<T>(cast2);
                    UInt128 _3_128 = PackUnpack.DownCast<T>(cast3);

                    if (default(T).Bits * 28 <= 128)
                    {
                        UInt128 cast128 = _0_128 | (_1_128 << (8 * default(T).Bits)) | (_2_128 << (16 * default(T).Bits)) | (_3_128 << (24 * default(T).Bits));
                        CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 28);
                    }
                    else if (default(T).Bits * 28 <= 256)
                    {
                        __UInt256__ cast256 = (__UInt256__)_0_128 | ((__UInt256__)_1_128 << (8 * default(T).Bits)) | ((__UInt256__)_2_128 << (16 * default(T).Bits)) | ((__UInt256__)_3_128 << (24 * default(T).Bits));
                        CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 28);
                    }
                    else
                    {
                        __UInt512__ cast512 = (__UInt512__)_0_128 | ((__UInt512__)_1_128 << (8 * default(T).Bits)) | ((__UInt512__)_2_128 << (16 * default(T).Bits)) | ((__UInt512__)_3_128 << (24 * default(T).Bits));
                        CopyAscending<T>(&cast512, 0, basePtr, scalarIndex, 28);
                    }
                }
                else if (default(T).Bits <= 32)
                {
                    int8 cast0 = (int8)PackUnpack.BitIntArrayToUInt8<Int2>(value.Bits);
                    int8 cast1 = (int8)PackUnpack.BitIntArrayToUInt8<Int2>(value.Bits >> (8 * default(Int2).Bits));
                    int8 cast2 = (int8)PackUnpack.BitIntArrayToUInt8<Int2>(value.Bits >> (16 * default(Int2).Bits));
                    int4 cast3 = (int4)PackUnpack.BitIntArrayToUInt4<Int2>(value.Bits >> (24 * default(Int2).Bits));
                    cast0 = signextend(cast0, default(Int2).Bits);
                    cast1 = signextend(cast1, default(Int2).Bits);
                    cast2 = signextend(cast2, default(Int2).Bits);
                    cast3 = signextend(cast3, default(Int2).Bits);
                    __UInt256__ _0_256 = PackUnpack.DownCast256<T>(cast0);
                    __UInt256__ _1_256 = PackUnpack.DownCast256<T>(cast1);
                    __UInt256__ _2_256 = PackUnpack.DownCast256<T>(cast2);
                    __UInt256__ _3_256 = PackUnpack.DownCast128<T>(cast3);

                    if (default(T).Bits * 28 <= 512)
                    {
                        __UInt512__ cast512 = (__UInt512__)_0_256 | ((__UInt512__)_1_256 << (8 * default(T).Bits)) | ((__UInt512__)_2_256 << (16 * default(T).Bits)) | ((__UInt512__)_3_256 << (24 * default(T).Bits));
                        CopyAscending<T>(&cast512, 0, basePtr, scalarIndex, 28);
                    }
                    else
                    {
                        __UInt1024__ cast1024 = (__UInt1024__)_0_256 | ((__UInt1024__)_1_256 << (8 * default(T).Bits)) | ((__UInt1024__)_2_256 << (16 * default(T).Bits)) | ((__UInt1024__)_3_256 << (24 * default(T).Bits));
                        CopyAscending<T>(&cast1024, 0, basePtr, scalarIndex, 28);
                    }
                }
                else
                {
                    long4 _0 = (long4)PackUnpack.BitIntArrayToULong4<Int2>(value.Bits);
                    long4 _1 = (long4)PackUnpack.BitIntArrayToULong4<Int2>((ulong)(value.Bits >> (4  * default(Int2).Bits)));
                    long4 _2 = (long4)PackUnpack.BitIntArrayToULong4<Int2>((ulong)(value.Bits >> (8  * default(Int2).Bits)));
                    long4 _3 = (long4)PackUnpack.BitIntArrayToULong4<Int2>((ulong)(value.Bits >> (12 * default(Int2).Bits)));
                    long4 _4 = (long4)PackUnpack.BitIntArrayToULong4<Int2>((ulong)(value.Bits >> (16 * default(Int2).Bits)));
                    long4 _5 = (long4)PackUnpack.BitIntArrayToULong4<Int2>((ulong)(value.Bits >> (20 * default(Int2).Bits)));
                    long4 _6 = (long4)PackUnpack.BitIntArrayToULong4<Int2>((ulong)(value.Bits >> (24 * default(Int2).Bits)));
                    _0 = signextend(_0, default(Int2).Bits);
                    _1 = signextend(_1, default(Int2).Bits);
                    _2 = signextend(_2, default(Int2).Bits);
                    _3 = signextend(_3, default(Int2).Bits);
                    _4 = signextend(_4, default(Int2).Bits);
                    _5 = signextend(_5, default(Int2).Bits);
                    _6 = signextend(_6, default(Int2).Bits);
                    __UInt256__ _0_256 = PackUnpack.DownCast256<T>(_0);
                    __UInt256__ _1_256 = PackUnpack.DownCast256<T>(_1);
                    __UInt256__ _2_256 = PackUnpack.DownCast256<T>(_2);
                    __UInt256__ _3_256 = PackUnpack.DownCast256<T>(_3);
                    __UInt256__ _4_256 = PackUnpack.DownCast256<T>(_4);
                    __UInt256__ _5_256 = PackUnpack.DownCast256<T>(_5);
                    __UInt256__ _6_256 = PackUnpack.DownCast256<T>(_6);
                    
                    if (default(T).Bits * 28 <= 1024)
                    {
                        __UInt1024__ cast1024 = (__UInt1024__)_0_256 | ((__UInt1024__)_1_256 << (4 * default(T).Bits)) | ((__UInt1024__)_2_256 << (8 * default(T).Bits)) | ((__UInt1024__)_3_256 << (12 * default(T).Bits)) | ((__UInt1024__)_4_256 << (16 * default(T).Bits)) | ((__UInt1024__)_5_256 << (20 * default(T).Bits)) | ((__UInt1024__)_6_256 << (24 * default(T).Bits));
                        CopyAscending<T>(&cast1024, 0, basePtr, scalarIndex, 28);
                    }
                    else
                    {
                        __UInt2048__ cast2048 = (__UInt2048__)_0_256 | ((__UInt2048__)_1_256 << (4 * default(T).Bits)) | ((__UInt2048__)_2_256 << (8 * default(T).Bits)) | ((__UInt2048__)_3_256 << (12 * default(T).Bits)) | ((__UInt2048__)_4_256 << (16 * default(T).Bits)) | ((__UInt2048__)_5_256 << (20 * default(T).Bits)) | ((__UInt2048__)_6_256 << (24 * default(T).Bits));
                        CopyAscending<T>(&cast2048, 0, basePtr, scalarIndex, 28);
                    }
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreInt2x32<T>(void* basePtr, int scalarIndex, int length, Int2x32 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 31, length);
            
            if (default(T).Bits == 2)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 32);
            }
            else if (default(T).Bits < 2)
            {
                ulong cast = PackUnpack.DownCast<UInt2, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 32);
            }
            else
            {
                if (default(T).Bits <= 8)
                {
                    sbyte8 cast0 = (sbyte8)PackUnpack.BitIntArrayToByte8<Int2>(value.Bits);
                    sbyte8 cast1 = (sbyte8)PackUnpack.BitIntArrayToByte8<Int2>(value.Bits >> (8 * default(Int2).Bits));
                    sbyte8 cast2 = (sbyte8)PackUnpack.BitIntArrayToByte8<Int2>(value.Bits >> (16 * default(Int2).Bits));
                    sbyte8 cast3 = (sbyte8)PackUnpack.BitIntArrayToByte8<Int2>(value.Bits >> (24 * default(Int2).Bits));
                    cast0 = signextend(cast0, default(Int2).Bits);
                    cast1 = signextend(cast1, default(Int2).Bits);
                    cast2 = signextend(cast2, default(Int2).Bits);
                    cast3 = signextend(cast3, default(Int2).Bits);
                    UInt128 _0_128 = PackUnpack.DownCast128<T>(cast0);
                    UInt128 _1_128 = PackUnpack.DownCast128<T>(cast1);
                    UInt128 _2_128 = PackUnpack.DownCast128<T>(cast2);
                    UInt128 _3_128 = PackUnpack.DownCast128<T>(cast3);

                    if (default(T).Bits * 32 <= 128)
                    {
                        UInt128 cast128 = _0_128 | (_1_128 << (8 * default(T).Bits)) | (_2_128 << (16 * default(T).Bits)) | (_3_128 << (24 * default(T).Bits));
                        CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 32);
                    }
                    else
                    {
                        __UInt256__ cast256 = (__UInt256__)_0_128 | ((__UInt256__)_1_128 << (8 * default(T).Bits)) | ((__UInt256__)_2_128 << (16 * default(T).Bits)) | ((__UInt256__)_3_128 << (24 * default(T).Bits));
                        CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 32);
                    }
                }
                if (default(T).Bits <= 16)
                {
                    short8 cast0 = (short8)PackUnpack.BitIntArrayToUShort8<Int2>(value.Bits);
                    short8 cast1 = (short8)PackUnpack.BitIntArrayToUShort8<Int2>(value.Bits >> (8 * default(Int2).Bits));
                    short8 cast2 = (short8)PackUnpack.BitIntArrayToUShort8<Int2>(value.Bits >> (16 * default(Int2).Bits));
                    short8 cast3 = (short8)PackUnpack.BitIntArrayToUShort8<Int2>(value.Bits >> (24 * default(Int2).Bits));
                    cast0 = signextend(cast0, default(Int2).Bits);
                    cast1 = signextend(cast1, default(Int2).Bits);
                    cast2 = signextend(cast2, default(Int2).Bits);
                    cast3 = signextend(cast3, default(Int2).Bits);
                    UInt128 _0_128 = PackUnpack.DownCast128<T>(cast0);
                    UInt128 _1_128 = PackUnpack.DownCast128<T>(cast1);
                    UInt128 _2_128 = PackUnpack.DownCast128<T>(cast2);
                    UInt128 _3_128 = PackUnpack.DownCast128<T>(cast3);

                    if (default(T).Bits * 32 <= 128)
                    {
                        UInt128 cast128 = _0_128 | (_1_128 << (8 * default(T).Bits)) | (_2_128 << (16 * default(T).Bits)) | (_3_128 << (24 * default(T).Bits));
                        CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 32);
                    }
                    else if (default(T).Bits * 32 <= 256)
                    {
                        __UInt256__ cast256 = (__UInt256__)_0_128 | ((__UInt256__)_1_128 << (8 * default(T).Bits)) | ((__UInt256__)_2_128 << (16 * default(T).Bits)) | ((__UInt256__)_3_128 << (24 * default(T).Bits));
                        CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 32);
                    }
                    else
                    {
                        __UInt512__ cast512 = (__UInt512__)_0_128 | ((__UInt512__)_1_128 << (8 * default(T).Bits)) | ((__UInt512__)_2_128 << (16 * default(T).Bits)) | ((__UInt512__)_3_128 << (24 * default(T).Bits));
                        CopyAscending<T>(&cast512, 0, basePtr, scalarIndex, 32);
                    }
                }
                else if (default(T).Bits <= 32)
                {
                    int8 cast0 = (int8)PackUnpack.BitIntArrayToUInt8<Int2>(value.Bits);
                    int8 cast1 = (int8)PackUnpack.BitIntArrayToUInt8<Int2>(value.Bits >> (8 * default(Int2).Bits));
                    int8 cast2 = (int8)PackUnpack.BitIntArrayToUInt8<Int2>(value.Bits >> (16 * default(Int2).Bits));
                    int8 cast3 = (int8)PackUnpack.BitIntArrayToUInt8<Int2>(value.Bits >> (24 * default(Int2).Bits));
                    cast0 = signextend(cast0, default(Int2).Bits);
                    cast1 = signextend(cast1, default(Int2).Bits);
                    cast2 = signextend(cast2, default(Int2).Bits);
                    cast3 = signextend(cast3, default(Int2).Bits);
                    __UInt256__ _0_256 = PackUnpack.DownCast256<T>(cast0);
                    __UInt256__ _1_256 = PackUnpack.DownCast256<T>(cast1);
                    __UInt256__ _2_256 = PackUnpack.DownCast256<T>(cast2);
                    __UInt256__ _3_256 = PackUnpack.DownCast256<T>(cast3);

                    __UInt1024__ cast1024 = (__UInt1024__)_0_256 | ((__UInt1024__)_1_256 << (8 * default(T).Bits)) | ((__UInt1024__)_2_256 << (16 * default(T).Bits)) | ((__UInt1024__)_3_256 << (24 * default(T).Bits));
                    CopyAscending<T>(&cast1024, 0, basePtr, scalarIndex, 32);
                }
                else
                {
                    long4 _0 = (long4)PackUnpack.BitIntArrayToULong4<Int2>(value.Bits);
                    long4 _1 = (long4)PackUnpack.BitIntArrayToULong4<Int2>((ulong)(value.Bits >> (4  * default(Int2).Bits)));
                    long4 _2 = (long4)PackUnpack.BitIntArrayToULong4<Int2>((ulong)(value.Bits >> (8  * default(Int2).Bits)));
                    long4 _3 = (long4)PackUnpack.BitIntArrayToULong4<Int2>((ulong)(value.Bits >> (12 * default(Int2).Bits)));
                    long4 _4 = (long4)PackUnpack.BitIntArrayToULong4<Int2>((ulong)(value.Bits >> (16 * default(Int2).Bits)));
                    long4 _5 = (long4)PackUnpack.BitIntArrayToULong4<Int2>((ulong)(value.Bits >> (20 * default(Int2).Bits)));
                    long4 _6 = (long4)PackUnpack.BitIntArrayToULong4<Int2>((ulong)(value.Bits >> (24 * default(Int2).Bits)));
                    long4 _7 = (long4)PackUnpack.BitIntArrayToULong4<Int2>((ulong)(value.Bits >> (28 * default(Int2).Bits)));
                    _0 = signextend(_0, default(Int2).Bits);
                    _1 = signextend(_1, default(Int2).Bits);
                    _2 = signextend(_2, default(Int2).Bits);
                    _3 = signextend(_3, default(Int2).Bits);
                    _4 = signextend(_4, default(Int2).Bits);
                    _5 = signextend(_5, default(Int2).Bits);
                    _6 = signextend(_6, default(Int2).Bits);
                    _7 = signextend(_7, default(Int2).Bits);
                    __UInt256__ _0_256 = PackUnpack.DownCast256<T>(_0);
                    __UInt256__ _1_256 = PackUnpack.DownCast256<T>(_1);
                    __UInt256__ _2_256 = PackUnpack.DownCast256<T>(_2);
                    __UInt256__ _3_256 = PackUnpack.DownCast256<T>(_3);
                    __UInt256__ _4_256 = PackUnpack.DownCast256<T>(_4);
                    __UInt256__ _5_256 = PackUnpack.DownCast256<T>(_5);
                    __UInt256__ _6_256 = PackUnpack.DownCast256<T>(_6);
                    __UInt256__ _7_256 = PackUnpack.DownCast256<T>(_7);
                    
                    __UInt2048__ cast2048 = (__UInt2048__)_0_256 | ((__UInt2048__)_1_256 << (4 * default(T).Bits)) | ((__UInt2048__)_2_256 << (8 * default(T).Bits)) | ((__UInt2048__)_3_256 << (12 * default(T).Bits)) | ((__UInt2048__)_4_256 << (16 * default(T).Bits)) | ((__UInt2048__)_5_256 << (20 * default(T).Bits)) | ((__UInt2048__)_6_256 << (24 * default(T).Bits)) | ((__UInt2048__)_7_256 << (28 * default(T).Bits));
                    CopyAscending<T>(&cast2048, 0, basePtr, scalarIndex, 32);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreInt3x8<T>(void* basePtr, int scalarIndex, int length, Int3x8 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 7, length);
            
            if (default(T).Bits == 3)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 8);
            }
            else if (default(T).Bits < 3)
            {
                ulong cast = PackUnpack.DownCast<Int3, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
            }
            else
            {
                if (default(T).Bits <= 8)
                {
                    sbyte8 cast = (sbyte8)PackUnpack.BitIntArrayToByte8<Int3>(value.Bits);
                    cast = signextend(cast, default(Int3).Bits);
                    ulong cast64 = PackUnpack.DownCast<T>(cast);

                    CopyAscending<T>(&cast64, 0, basePtr, scalarIndex, 8);
                }
                if (default(T).Bits <= 16)
                {
                    short8 cast = (short8)PackUnpack.BitIntArrayToUShort8<Int3>(value.Bits);
                    cast = signextend(cast, default(Int3).Bits);
                    UInt128 cast128 = PackUnpack.DownCast128<T>(cast);

                    CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 8);
                }
                else if (default(T).Bits <= 32)
                {
                    int8 cast = (int8)PackUnpack.BitIntArrayToUInt8<Int3>(value.Bits);
                    cast = signextend(cast, default(Int3).Bits);
                    __UInt256__ cast256 = PackUnpack.DownCast256<T>(cast);

                    CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 8);
                }
                else
                {
                    long4 lo = (long4)PackUnpack.BitIntArrayToULong4<Int3>(value.Bits);
                    long4 hi = (long4)PackUnpack.BitIntArrayToULong4<Int3>((ulong)(value.Bits >> (4 * default(Int3).Bits)));
                    lo = signextend(lo, default(Int3).Bits);
                    hi = signextend(hi, default(Int3).Bits);
                    __UInt256__ lo256 = PackUnpack.DownCast256<T>(lo);
                    __UInt256__ hi256 = PackUnpack.DownCast256<T>(hi);
                    __UInt512__ cast512 = (__UInt512__)lo256 | ((__UInt512__)hi256 << (4 * default(T).Bits));

                    CopyAscending<T>(&cast512, 0, basePtr, scalarIndex, 8);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreInt3x16<T>(void* basePtr, int scalarIndex, int length, Int3x16 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 15, length);
            
            if (default(T).Bits == 3)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 16);
            }
            else if (default(T).Bits < 3)
            {
                ulong cast = PackUnpack.DownCast<UInt3, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 16);
            }
            else
            {
                if (default(T).Bits <= 8)
                {
                    sbyte8 cast0 = (sbyte8)PackUnpack.BitIntArrayToByte8<Int3>(value.Bits);
                    sbyte8 cast1 = (sbyte8)PackUnpack.BitIntArrayToByte8<Int3>(value.Bits >> (8 * default(Int3).Bits));
                    cast0 = signextend(cast0, default(Int3).Bits);
                    cast1 = signextend(cast1, default(Int3).Bits);
                    ulong lo = PackUnpack.DownCast<T>(cast0);
                    ulong hi = PackUnpack.DownCast<T>(cast1);

                    UInt128 cast128 = (UInt128)lo | ((UInt128)hi << (8 * default(T).Bits));
                    CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 16);
                }
                if (default(T).Bits <= 16)
                {
                    short8 cast0 = (short8)PackUnpack.BitIntArrayToUShort8<Int3>(value.Bits);
                    short8 cast1 = (short8)PackUnpack.BitIntArrayToUShort8<Int3>(value.Bits >> (8 * default(Int3).Bits));
                    cast0 = signextend(cast0, default(Int3).Bits);
                    cast1 = signextend(cast1, default(Int3).Bits);
                    UInt128 lo = PackUnpack.DownCast128<T>(cast0);
                    UInt128 hi = PackUnpack.DownCast128<T>(cast1);

                    if (default(T).Bits * 16 <= 128)
                    {
                        UInt128 cast128 = lo | (hi << (8 * default(T).Bits));
                        CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 16);
                    }
                    else
                    {
                        __UInt256__ cast256 = (__UInt256__)lo | ((__UInt256__)hi << (8 * default(T).Bits));
                        CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 16);
                    }
                }
                else if (default(T).Bits <= 32)
                {
                    int8 cast0 = (int8)PackUnpack.BitIntArrayToUInt8<Int3>(value.Bits);
                    int8 cast1 = (int8)PackUnpack.BitIntArrayToUInt8<Int3>(value.Bits >> (8 * default(Int3).Bits));
                    cast0 = signextend(cast0, default(Int3).Bits);
                    cast1 = signextend(cast1, default(Int3).Bits);
                    __UInt256__ lo = PackUnpack.DownCast256<T>(cast0);
                    __UInt256__ hi = PackUnpack.DownCast256<T>(cast1);

                    if (default(T).Bits * 16 <= 256)
                    {
                        __UInt256__ cast256 = lo | (hi << (8 * default(T).Bits));
                        CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 16);
                    }
                    else
                    {
                        __UInt512__ cast256 = (__UInt512__)lo | ((__UInt512__)hi << (8 * default(T).Bits));
                        CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 16);
                    }
                }
                else
                {
                    long4 _0 = (long4)PackUnpack.BitIntArrayToULong4<Int3>(value.Bits);
                    long4 _1 = (long4)PackUnpack.BitIntArrayToULong4<Int3>((ulong)(value.Bits >> (4  * default(Int3).Bits)));
                    long4 _2 = (long4)PackUnpack.BitIntArrayToULong4<Int3>((ulong)(value.Bits >> (8  * default(Int3).Bits)));
                    long4 _3 = (long4)PackUnpack.BitIntArrayToULong4<Int3>((ulong)(value.Bits >> (12 * default(Int3).Bits)));
                    _0 = signextend(_0, default(Int3).Bits);
                    _1 = signextend(_1, default(Int3).Bits);
                    _2 = signextend(_2, default(Int3).Bits);
                    _3 = signextend(_3, default(Int3).Bits);
                    __UInt256__ _0_256 = PackUnpack.DownCast256<T>(_0);
                    __UInt256__ _1_256 = PackUnpack.DownCast256<T>(_1);
                    __UInt256__ _2_256 = PackUnpack.DownCast256<T>(_2);
                    __UInt256__ _3_256 = PackUnpack.DownCast256<T>(_3);

                    __UInt1024__ cast1024 = (__UInt1024__)_0_256 | ((__UInt1024__)_1_256 << (4 * default(T).Bits)) | ((__UInt1024__)_2_256 << (8 * default(T).Bits)) | ((__UInt1024__)_3_256 << (12 * default(T).Bits));
                    CopyAscending<T>(&cast1024, 0, basePtr, scalarIndex, 16);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreInt4x2<T>(void* basePtr, int scalarIndex, int length, Int4x2 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 1, length);
            
            if (default(T).Bits == 4)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 2);
            }
            else if (default(T).Bits < 4)
            {
                ulong cast = PackUnpack.DownCast<Int4, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 2);
            }
            else
            {
                if (default(T).Bits <= 32)
                {
                    int2 cast = (int2)PackUnpack.BitIntArrayToUInt2<Int4>(value.Bits);
                    cast = signextend(cast, default(Int4).Bits);
                    ulong cast64 = PackUnpack.DownCast<T>(cast);

                    CopyAscending<T>(&cast64, 0, basePtr, scalarIndex, 2);
                }
                else
                {
                    long2 cast = (long2)PackUnpack.BitIntArrayToULong2<Int4>(value.Bits);
                    cast = signextend(cast, default(Int4).Bits);
                    UInt128 cast128 = PackUnpack.DownCast128<T>(cast);

                    CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 2);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreInt4x4<T>(void* basePtr, int scalarIndex, int length, Int4x4 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 3, length);
            
            if (default(T).Bits == 4)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 4);
            }
            else if (default(T).Bits < 4)
            {
                ulong cast = PackUnpack.DownCast<Int4, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 4);
            }
            else
            {
                if (default(T).Bits <= 16)
                {
                    short4 cast = (short4)PackUnpack.BitIntArrayToUShort4<Int4>(value.Bits);
                    cast = signextend(cast, default(Int4).Bits);
                    ulong cast64 = PackUnpack.DownCast<T>(cast);

                    CopyAscending<T>(&cast64, 0, basePtr, scalarIndex, 4);
                }
                else if (default(T).Bits <= 32)
                {
                    int4 cast = (int4)PackUnpack.BitIntArrayToUInt4<Int4>(value.Bits);
                    cast = signextend(cast, default(Int4).Bits);
                    UInt128 cast128 = PackUnpack.DownCast128<T>(cast);

                    CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 4);
                }
                else
                {
                    long4 cast = (long4)PackUnpack.BitIntArrayToULong4<Int4>(value.Bits);
                    cast = signextend(cast, default(Int4).Bits);
                    __UInt256__ cast256 = PackUnpack.DownCast256<T>(cast);

                    CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 4);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreInt4x6<T>(void* basePtr, int scalarIndex, int length, Int4x6 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 5, length);
            
            if (default(T).Bits == 4)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 6);
            }
            else if (default(T).Bits < 4)
            {
                ulong cast = PackUnpack.DownCast<Int4, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 6);
            }
            else
            {
                if (default(T).Bits <= 8)
                {
                    sbyte8 cast = (sbyte8)PackUnpack.BitIntArrayToByte8<Int4>(value.Bits);
                    cast = signextend(cast, default(Int4).Bits);
                    ulong cast64 = PackUnpack.DownCast<T>(cast);

                    CopyAscending<T>(&cast64, 0, basePtr, scalarIndex, 6);
                }
                if (default(T).Bits <= 16)
                {
                    short8 cast = (short8)PackUnpack.BitIntArrayToUShort8<Int4>(value.Bits);
                    cast = signextend(cast, default(Int4).Bits);
                    UInt128 cast128 = PackUnpack.DownCast128<T>(cast);

                    CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 6);
                }
                else if (default(T).Bits <= 32)
                {
                    int8 cast = (int8)PackUnpack.BitIntArrayToUInt8<Int4>(value.Bits);
                    cast = signextend(cast, default(Int4).Bits);
                    __UInt256__ cast256 = PackUnpack.DownCast256<T>(cast);

                    CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 6);
                }
                else
                {
                    long4 lo = (long4)PackUnpack.BitIntArrayToULong4<Int4>(value.Bits);
                    long2 hi = (long2)PackUnpack.BitIntArrayToULong2<Int4>((ulong)(value.Bits >> (4 * default(Int4).Bits)));
                    lo = signextend(lo, default(Int4).Bits);
                    hi = signextend(hi, default(Int4).Bits);
                    __UInt256__ lo256 = PackUnpack.DownCast256<T>(lo);
                    UInt128 hi256 = PackUnpack.DownCast128<T>(hi);

                    if (default(T).Bits * 6 <= 256)
                    {
                        __UInt256__ cast256 = (__UInt256__)lo256 | ((__UInt256__)hi256 << (4 * default(T).Bits));

                        CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 6);
                    }
                    else
                    {
                        __UInt512__ cast512 = (__UInt512__)lo256 | ((__UInt512__)hi256 << (4 * default(T).Bits));

                        CopyAscending<T>(&cast512, 0, basePtr, scalarIndex, 6);
                    }
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreInt4x8<T>(void* basePtr, int scalarIndex, int length, Int4x8 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 7, length);
            
            if (default(T).Bits == 4)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 8);
            }
            else if (default(T).Bits < 4)
            {
                ulong cast = PackUnpack.DownCast<Int4, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
            }
            else
            {
                if (default(T).Bits <= 8)
                {
                    sbyte8 cast = (sbyte8)PackUnpack.BitIntArrayToByte8<Int4>(value.Bits);
                    cast = signextend(cast, default(Int4).Bits);
                    ulong cast64 = PackUnpack.DownCast<T>(cast);

                    CopyAscending<T>(&cast64, 0, basePtr, scalarIndex, 8);
                }
                if (default(T).Bits <= 16)
                {
                    short8 cast = (short8)PackUnpack.BitIntArrayToUShort8<Int4>(value.Bits);
                    cast = signextend(cast, default(Int4).Bits);
                    UInt128 cast128 = PackUnpack.DownCast128<T>(cast);

                    CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 8);
                }
                else if (default(T).Bits <= 32)
                {
                    int8 cast = (int8)PackUnpack.BitIntArrayToUInt8<Int4>(value.Bits);
                    cast = signextend(cast, default(Int4).Bits);
                    __UInt256__ cast256 = PackUnpack.DownCast256<T>(cast);

                    CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 8);
                }
                else
                {
                    long4 lo = (long4)PackUnpack.BitIntArrayToULong4<Int4>(value.Bits);
                    long4 hi = (long4)PackUnpack.BitIntArrayToULong4<Int4>((ulong)(value.Bits >> (4 * default(Int4).Bits)));
                    lo = signextend(lo, default(Int4).Bits);
                    hi = signextend(hi, default(Int4).Bits);
                    __UInt256__ lo256 = PackUnpack.DownCast256<T>(lo);
                    __UInt256__ hi256 = PackUnpack.DownCast256<T>(hi);
                    __UInt512__ cast512 = (__UInt512__)lo256 | ((__UInt512__)hi256 << (4 * default(T).Bits));

                    CopyAscending<T>(&cast512, 0, basePtr, scalarIndex, 8);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreInt4x10<T>(void* basePtr, int scalarIndex, int length, Int4x10 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 9, length);
            
            if (default(T).Bits == 4)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 10);
            }
            else if (default(T).Bits < 4)
            {
                ulong cast = PackUnpack.DownCast<Int4, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 10);
            }
            else
            {
                if (default(T).Bits <= 8)
                {
                    sbyte8 cast0 = (sbyte8)PackUnpack.BitIntArrayToByte8<Int4>(value.Bits);
                    sbyte4 cast1 = (sbyte4)PackUnpack.BitIntArrayToByte4<Int4>((uint)(value.Bits >> (8 * default(Int4).Bits)));
                    cast0 = signextend(cast0, default(Int4).Bits);
                    cast1 = signextend(cast1, default(Int4).Bits);
                    UInt128 lo = PackUnpack.DownCast128<T>(cast0);
                    ulong   hi = PackUnpack.DownCast<T>(cast1);
                    
                    UInt128 cast128 = lo | ((UInt128)hi << (8 * default(T).Bits));
                    CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 10);
                }
                if (default(T).Bits <= 16)
                {
                    short8 cast0 = (short8)PackUnpack.BitIntArrayToUShort8<Int4>(value.Bits);
                    short4 cast1 = (short4)PackUnpack.BitIntArrayToUShort4<Int4>(value.Bits >> (8 * default(Int4).Bits));
                    cast0 = signextend(cast0, default(Int4).Bits);
                    cast1 = signextend(cast1, default(Int4).Bits);
                    UInt128 lo = PackUnpack.DownCast128<T>(cast0);
                    ulong   hi = PackUnpack.DownCast<T>(cast1);

                    if (default(T).Bits * 10 <= 128)
                    {
                        UInt128 cast128 = lo | ((UInt128)hi << (8 * default(T).Bits));
                        CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 10);
                    }
                    else
                    {
                        __UInt256__ cast256 = (__UInt256__)lo | ((__UInt256__)hi << (8 * default(T).Bits));
                        CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 10);
                    }
                }
                else if (default(T).Bits <= 32)
                {
                    int8 cast0 = (int8)PackUnpack.BitIntArrayToUInt8<Int4>(value.Bits);
                    int4 cast1 = (int4)PackUnpack.BitIntArrayToUInt4<Int4>(value.Bits >> (8 * default(Int4).Bits));
                    cast0 = signextend(cast0, default(Int4).Bits);
                    cast1 = signextend(cast1, default(Int4).Bits);
                    __UInt256__ lo = PackUnpack.DownCast256<T>(cast0);
                    UInt128     hi = PackUnpack.DownCast128<T>(cast1);

                    if (default(T).Bits * 10 <= 256)
                    {
                        __UInt256__ cast256 = (__UInt256__)lo | ((__UInt256__)hi << (8 * default(T).Bits));
                        CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 10);
                    }
                    else
                    {
                        __UInt512__ cast256 = (__UInt512__)lo | ((__UInt512__)hi << (8 * default(T).Bits));
                        CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 10);
                    }
                }
                else
                {
                    long4 _0 = (long4)PackUnpack.BitIntArrayToULong4<Int4>(value.Bits);
                    long4 _1 = (long4)PackUnpack.BitIntArrayToULong4<Int4>((ulong)(value.Bits >> (4 * default(Int4).Bits)));
                    long4 _2 = (long4)PackUnpack.BitIntArrayToULong4<Int4>((ulong)(value.Bits >> (8 * default(Int4).Bits)));
                    _0 = signextend(_0, default(Int4).Bits);
                    _1 = signextend(_1, default(Int4).Bits);
                    _2 = signextend(_2, default(Int4).Bits);
                    __UInt256__ _0_256 = PackUnpack.DownCast256<T>(_0);
                    __UInt256__ _1_256 = PackUnpack.DownCast256<T>(_1);
                    __UInt256__ _2_256 = PackUnpack.DownCast256<T>(_2);

                    if (default(T).Bits * 10 <= 512)
                    {
                        __UInt512__ cast512 = (__UInt512__)_0_256 | ((__UInt512__)_1_256 << (4 * default(T).Bits)) | ((__UInt512__)_2_256 << (8 * default(T).Bits));
                        CopyAscending<T>(&cast512, 0, basePtr, scalarIndex, 10);
                    }
                    else
                    {
                        __UInt1024__ cast1024 = (__UInt1024__)_0_256 | ((__UInt1024__)_1_256 << (4 * default(T).Bits)) | ((__UInt1024__)_2_256 << (8 * default(T).Bits));
                        CopyAscending<T>(&cast1024, 0, basePtr, scalarIndex, 10);
                    }
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreInt4x12<T>(void* basePtr, int scalarIndex, int length, Int4x12 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 11, length);
            
            if (default(T).Bits == 4)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 12);
            }
            else if (default(T).Bits < 4)
            {
                ulong cast = PackUnpack.DownCast<Int4, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 12);
            }
            else
            {
                if (default(T).Bits <= 8)
                {
                    sbyte8 cast0 = (sbyte8)PackUnpack.BitIntArrayToByte8<Int4>(value.Bits);
                    sbyte4 cast1 = (sbyte4)PackUnpack.BitIntArrayToByte4<Int4>((uint)(value.Bits >> (8 * default(Int4).Bits)));
                    cast0 = signextend(cast0, default(Int4).Bits);
                    cast1 = signextend(cast1, default(Int4).Bits);
                    UInt128 lo = PackUnpack.DownCast128<T>(cast0);
                    ulong   hi = PackUnpack.DownCast<T>(cast1);
                    
                    UInt128 cast128 = lo | ((UInt128)hi << (8 * default(T).Bits));
                    CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 12);
                }
                if (default(T).Bits <= 16)
                {
                    short8 cast0 = (short8)PackUnpack.BitIntArrayToUShort8<Int4>(value.Bits);
                    short4 cast1 = (short4)PackUnpack.BitIntArrayToUShort4<Int4>(value.Bits >> (8 * default(Int4).Bits));
                    cast0 = signextend(cast0, default(Int4).Bits);
                    cast1 = signextend(cast1, default(Int4).Bits);
                    UInt128 lo = PackUnpack.DownCast128<T>(cast0);
                    ulong   hi = PackUnpack.DownCast<T>(cast1);

                    if (default(T).Bits * 12 <= 128)
                    {
                        UInt128 cast128 = lo | ((UInt128)hi << (8 * default(T).Bits));
                        CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 12);
                    }
                    else
                    {
                        __UInt256__ cast256 = (__UInt256__)lo | ((__UInt256__)hi << (8 * default(T).Bits));
                        CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 12);
                    }
                }
                else if (default(T).Bits <= 32)
                {
                    int8 cast0 = (int8)PackUnpack.BitIntArrayToUInt8<Int4>(value.Bits);
                    int4 cast1 = (int4)PackUnpack.BitIntArrayToUInt4<Int4>(value.Bits >> (8 * default(Int4).Bits));
                    cast0 = signextend(cast0, default(Int4).Bits);
                    cast1 = signextend(cast1, default(Int4).Bits);
                    __UInt256__ lo = PackUnpack.DownCast256<T>(cast0);
                    UInt128     hi = PackUnpack.DownCast128<T>(cast1);

                    if (default(T).Bits * 12 <= 256)
                    {
                        __UInt256__ cast256 = (__UInt256__)lo | ((__UInt256__)hi << (8 * default(T).Bits));
                        CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 12);
                    }
                    else
                    {
                        __UInt512__ cast256 = (__UInt512__)lo | ((__UInt512__)hi << (8 * default(T).Bits));
                        CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 12);
                    }
                }
                else
                {
                    long4 _0 = (long4)PackUnpack.BitIntArrayToULong4<Int4>(value.Bits);
                    long4 _1 = (long4)PackUnpack.BitIntArrayToULong4<Int4>((ulong)(value.Bits >> (4 * default(Int4).Bits)));
                    long4 _2 = (long4)PackUnpack.BitIntArrayToULong4<Int4>((ulong)(value.Bits >> (8 * default(Int4).Bits)));
                    _0 = signextend(_0, default(Int4).Bits);
                    _1 = signextend(_1, default(Int4).Bits);
                    _2 = signextend(_2, default(Int4).Bits);
                    __UInt256__ _0_256 = PackUnpack.DownCast256<T>(_0);
                    __UInt256__ _1_256 = PackUnpack.DownCast256<T>(_1);
                    __UInt256__ _2_256 = PackUnpack.DownCast256<T>(_2);

                    if (default(T).Bits * 12 <= 512)
                    {
                        __UInt512__ cast512 = (__UInt512__)_0_256 | ((__UInt512__)_1_256 << (4 * default(T).Bits)) | ((__UInt512__)_2_256 << (8 * default(T).Bits));
                        CopyAscending<T>(&cast512, 0, basePtr, scalarIndex, 12);
                    }
                    else
                    {
                        __UInt1024__ cast1024 = (__UInt1024__)_0_256 | ((__UInt1024__)_1_256 << (4 * default(T).Bits)) | ((__UInt1024__)_2_256 << (8 * default(T).Bits));
                        CopyAscending<T>(&cast1024, 0, basePtr, scalarIndex, 12);
                    }
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreInt4x14<T>(void* basePtr, int scalarIndex, int length, Int4x14 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 13, length);
            
            if (default(T).Bits == 4)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 14);
            }
            else if (default(T).Bits < 4)
            {
                ulong cast = PackUnpack.DownCast<UInt4, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 14);
            }
            else
            {
                if (default(T).Bits <= 8)
                {
                    sbyte8 cast0 = (sbyte8)PackUnpack.BitIntArrayToByte8<Int4>(value.Bits);
                    sbyte8 cast1 = (sbyte8)PackUnpack.BitIntArrayToByte8<Int4>(value.Bits >> (8 * default(Int4).Bits));
                    cast0 = signextend(cast0, default(Int4).Bits);
                    cast1 = signextend(cast1, default(Int4).Bits);
                    ulong lo = PackUnpack.DownCast<T>(cast0);
                    ulong hi = PackUnpack.DownCast<T>(cast1);

                    UInt128 cast128 = (UInt128)lo | ((UInt128)hi << (8 * default(T).Bits));
                    CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 14);
                }
                if (default(T).Bits <= 16)
                {
                    short8 cast0 = (short8)PackUnpack.BitIntArrayToUShort8<Int4>(value.Bits);
                    short8 cast1 = (short8)PackUnpack.BitIntArrayToUShort8<Int4>(value.Bits >> (8 * default(Int4).Bits));
                    cast0 = signextend(cast0, default(Int4).Bits);
                    cast1 = signextend(cast1, default(Int4).Bits);
                    UInt128 lo = PackUnpack.DownCast128<T>(cast0);
                    UInt128 hi = PackUnpack.DownCast128<T>(cast1);

                    if (default(T).Bits * 14 <= 128)
                    {
                        UInt128 cast128 = lo | (hi << (8 * default(T).Bits));
                        CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 14);
                    }
                    else
                    {
                        __UInt256__ cast256 = (__UInt256__)lo | ((__UInt256__)hi << (8 * default(T).Bits));
                        CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 14);
                    }
                }
                else if (default(T).Bits <= 32)
                {
                    int8 cast0 = (int8)PackUnpack.BitIntArrayToUInt8<Int4>(value.Bits);
                    int8 cast1 = (int8)PackUnpack.BitIntArrayToUInt8<Int4>(value.Bits >> (8 * default(Int4).Bits));
                    cast0 = signextend(cast0, default(Int4).Bits);
                    cast1 = signextend(cast1, default(Int4).Bits);
                    __UInt256__ lo = PackUnpack.DownCast256<T>(cast0);
                    __UInt256__ hi = PackUnpack.DownCast256<T>(cast1);

                    if (default(T).Bits * 14 <= 256)
                    {
                        __UInt256__ cast256 = lo | (hi << (8 * default(T).Bits));
                        CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 14);
                    }
                    else
                    {
                        __UInt512__ cast256 = (__UInt512__)lo | ((__UInt512__)hi << (8 * default(T).Bits));
                        CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 14);
                    }
                }
                else
                {
                    long4 _0 = (long4)PackUnpack.BitIntArrayToULong4<Int4>(value.Bits);
                    long4 _1 = (long4)PackUnpack.BitIntArrayToULong4<Int4>((ulong)(value.Bits >> (4  * default(Int4).Bits)));
                    long4 _2 = (long4)PackUnpack.BitIntArrayToULong4<Int4>((ulong)(value.Bits >> (8  * default(Int4).Bits)));
                    long2 _3 = (long2)PackUnpack.BitIntArrayToULong2<Int4>((ulong)(value.Bits >> (12 * default(Int4).Bits)));
                    _0 = signextend(_0, default(Int4).Bits);
                    _1 = signextend(_1, default(Int4).Bits);
                    _2 = signextend(_2, default(Int4).Bits);
                    _3 = signextend(_3, default(Int4).Bits);
                    __UInt256__ _0_256 = PackUnpack.DownCast256<T>(_0);
                    __UInt256__ _1_256 = PackUnpack.DownCast256<T>(_1);
                    __UInt256__ _2_256 = PackUnpack.DownCast256<T>(_2);
                    UInt128 _3_256 = PackUnpack.DownCast128<T>(_3);

                    __UInt1024__ cast1024 = (__UInt1024__)_0_256 | ((__UInt1024__)_1_256 << (4 * default(T).Bits)) | ((__UInt1024__)_2_256 << (8 * default(T).Bits)) | ((__UInt1024__)_3_256 << (12 * default(T).Bits));
                    CopyAscending<T>(&cast1024, 0, basePtr, scalarIndex, 14);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreInt4x16<T>(void* basePtr, int scalarIndex, int length, Int4x16 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 15, length);
            
            if (default(T).Bits == 4)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 16);
            }
            else if (default(T).Bits < 4)
            {
                ulong cast = PackUnpack.DownCast<UInt4, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 16);
            }
            else
            {
                if (default(T).Bits <= 8)
                {
                    sbyte8 cast0 = (sbyte8)PackUnpack.BitIntArrayToByte8<Int4>(value.Bits);
                    sbyte8 cast1 = (sbyte8)PackUnpack.BitIntArrayToByte8<Int4>(value.Bits >> (8 * default(Int4).Bits));
                    cast0 = signextend(cast0, default(Int4).Bits);
                    cast1 = signextend(cast1, default(Int4).Bits);
                    ulong lo = PackUnpack.DownCast<T>(cast0);
                    ulong hi = PackUnpack.DownCast<T>(cast1);

                    UInt128 cast128 = (UInt128)lo | ((UInt128)hi << (8 * default(T).Bits));
                    CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 16);
                }
                if (default(T).Bits <= 16)
                {
                    short8 cast0 = (short8)PackUnpack.BitIntArrayToUShort8<Int4>(value.Bits);
                    short8 cast1 = (short8)PackUnpack.BitIntArrayToUShort8<Int4>(value.Bits >> (8 * default(Int4).Bits));
                    cast0 = signextend(cast0, default(Int4).Bits);
                    cast1 = signextend(cast1, default(Int4).Bits);
                    UInt128 lo = PackUnpack.DownCast128<T>(cast0);
                    UInt128 hi = PackUnpack.DownCast128<T>(cast1);

                    if (default(T).Bits * 16 <= 128)
                    {
                        UInt128 cast128 = lo | (hi << (8 * default(T).Bits));
                        CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 16);
                    }
                    else
                    {
                        __UInt256__ cast256 = (__UInt256__)lo | ((__UInt256__)hi << (8 * default(T).Bits));
                        CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 16);
                    }
                }
                else if (default(T).Bits <= 32)
                {
                    int8 cast0 = (int8)PackUnpack.BitIntArrayToUInt8<Int4>(value.Bits);
                    int8 cast1 = (int8)PackUnpack.BitIntArrayToUInt8<Int4>(value.Bits >> (8 * default(Int4).Bits));
                    cast0 = signextend(cast0, default(Int4).Bits);
                    cast1 = signextend(cast1, default(Int4).Bits);
                    __UInt256__ lo = PackUnpack.DownCast256<T>(cast0);
                    __UInt256__ hi = PackUnpack.DownCast256<T>(cast1);

                    if (default(T).Bits * 16 <= 256)
                    {
                        __UInt256__ cast256 = lo | (hi << (8 * default(T).Bits));
                        CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 16);
                    }
                    else
                    {
                        __UInt512__ cast256 = (__UInt512__)lo | ((__UInt512__)hi << (8 * default(T).Bits));
                        CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 16);
                    }
                }
                else
                {
                    long4 _0 = (long4)PackUnpack.BitIntArrayToULong4<Int4>(value.Bits);
                    long4 _1 = (long4)PackUnpack.BitIntArrayToULong4<Int4>((ulong)(value.Bits >> (4  * default(Int4).Bits)));
                    long4 _2 = (long4)PackUnpack.BitIntArrayToULong4<Int4>((ulong)(value.Bits >> (8  * default(Int4).Bits)));
                    long4 _3 = (long4)PackUnpack.BitIntArrayToULong4<Int4>((ulong)(value.Bits >> (12 * default(Int4).Bits)));
                    _0 = signextend(_0, default(Int4).Bits);
                    _1 = signextend(_1, default(Int4).Bits);
                    _2 = signextend(_2, default(Int4).Bits);
                    _3 = signextend(_3, default(Int4).Bits);
                    __UInt256__ _0_256 = PackUnpack.DownCast256<T>(_0);
                    __UInt256__ _1_256 = PackUnpack.DownCast256<T>(_1);
                    __UInt256__ _2_256 = PackUnpack.DownCast256<T>(_2);
                    __UInt256__ _3_256 = PackUnpack.DownCast256<T>(_3);

                    __UInt1024__ cast1024 = (__UInt1024__)_0_256 | ((__UInt1024__)_1_256 << (4 * default(T).Bits)) | ((__UInt1024__)_2_256 << (8 * default(T).Bits)) | ((__UInt1024__)_3_256 << (12 * default(T).Bits));
                    CopyAscending<T>(&cast1024, 0, basePtr, scalarIndex, 16);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreInt5x8<T>(void* basePtr, int scalarIndex, int length, Int5x8 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 7, length);
            
            if (default(T).Bits == 5)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 8);
            }
            else if (default(T).Bits < 5)
            {
                ulong cast = PackUnpack.DownCast<Int5, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
            }
            else
            {
                if (default(T).Bits <= 8)
                {
                    sbyte8 cast = (sbyte8)PackUnpack.BitIntArrayToByte8<Int5>(value.Bits);
                    cast = signextend(cast, default(Int5).Bits);
                    ulong cast64 = PackUnpack.DownCast<T>(cast);

                    CopyAscending<T>(&cast64, 0, basePtr, scalarIndex, 8);
                }
                if (default(T).Bits <= 16)
                {
                    short8 cast = (short8)PackUnpack.BitIntArrayToUShort8<Int5>(value.Bits);
                    cast = signextend(cast, default(Int5).Bits);
                    UInt128 cast128 = PackUnpack.DownCast128<T>(cast);

                    CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 8);
                }
                else if (default(T).Bits <= 32)
                {
                    int8 cast = (int8)PackUnpack.BitIntArrayToUInt8<Int5>(value.Bits);
                    cast = signextend(cast, default(Int5).Bits);
                    __UInt256__ cast256 = PackUnpack.DownCast256<T>(cast);

                    CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 8);
                }
                else
                {
                    long4 lo = (long4)PackUnpack.BitIntArrayToULong4<Int5>(value.Bits);
                    long4 hi = (long4)PackUnpack.BitIntArrayToULong4<Int5>((ulong)(value.Bits >> (4 * default(Int5).Bits)));
                    lo = signextend(lo, default(Int5).Bits);
                    hi = signextend(hi, default(Int5).Bits);
                    __UInt256__ lo256 = PackUnpack.DownCast256<T>(lo);
                    __UInt256__ hi256 = PackUnpack.DownCast256<T>(hi);
                    __UInt512__ cast512 = (__UInt512__)lo256 | ((__UInt512__)hi256 << (4 * default(T).Bits));

                    CopyAscending<T>(&cast512, 0, basePtr, scalarIndex, 8);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreInt6x4<T>(void* basePtr, int scalarIndex, int length, Int6x4 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 3, length);
            
            if (default(T).Bits == 6)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 4);
            }
            else if (default(T).Bits < 6)
            {
                ulong cast = PackUnpack.DownCast<Int6, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 4);
            }
            else
            {
                if (default(T).Bits <= 16)
                {
                    short4 cast = (short4)PackUnpack.BitIntArrayToUShort4<Int6>(value.Bits);
                    cast = signextend(cast, default(Int6).Bits);
                    ulong cast64 = PackUnpack.DownCast<T>(cast);

                    CopyAscending<T>(&cast64, 0, basePtr, scalarIndex, 4);
                }
                else if (default(T).Bits <= 32)
                {
                    int4 cast = (int4)PackUnpack.BitIntArrayToUInt4<Int6>(value.Bits);
                    cast = signextend(cast, default(Int6).Bits);
                    UInt128 cast128 = PackUnpack.DownCast128<T>(cast);

                    CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 4);
                }
                else
                {
                    long4 cast = (long4)PackUnpack.BitIntArrayToULong4<Int6>(value.Bits);
                    cast = signextend(cast, default(Int6).Bits);
                    __UInt256__ cast256 = PackUnpack.DownCast256<T>(cast);

                    CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 4);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreInt6x8<T>(void* basePtr, int scalarIndex, int length, Int6x8 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 7, length);
            
            if (default(T).Bits == 6)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 8);
            }
            else if (default(T).Bits < 6)
            {
                ulong cast = PackUnpack.DownCast<Int6, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
            }
            else
            {
                if (default(T).Bits <= 8)
                {
                    sbyte8 cast = (sbyte8)PackUnpack.BitIntArrayToByte8<Int6>(value.Bits);
                    cast = signextend(cast, default(Int6).Bits);
                    ulong cast64 = PackUnpack.DownCast<T>(cast);

                    CopyAscending<T>(&cast64, 0, basePtr, scalarIndex, 8);
                }
                if (default(T).Bits <= 16)
                {
                    short8 cast = (short8)PackUnpack.BitIntArrayToUShort8<Int6>(value.Bits);
                    cast = signextend(cast, default(Int6).Bits);
                    UInt128 cast128 = PackUnpack.DownCast128<T>(cast);

                    CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 8);
                }
                else if (default(T).Bits <= 32)
                {
                    int8 cast = (int8)PackUnpack.BitIntArrayToUInt8<Int6>(value.Bits);
                    cast = signextend(cast, default(Int6).Bits);
                    __UInt256__ cast256 = PackUnpack.DownCast256<T>(cast);

                    CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 8);
                }
                else
                {
                    long4 lo = (long4)PackUnpack.BitIntArrayToULong4<Int6>(value.Bits);
                    long4 hi = (long4)PackUnpack.BitIntArrayToULong4<Int6>((ulong)(value.Bits >> (4 * default(Int6).Bits)));
                    lo = signextend(lo, default(Int6).Bits);
                    hi = signextend(hi, default(Int6).Bits);
                    __UInt256__ lo256 = PackUnpack.DownCast256<T>(lo);
                    __UInt256__ hi256 = PackUnpack.DownCast256<T>(hi);
                    __UInt512__ cast512 = (__UInt512__)lo256 | ((__UInt512__)hi256 << (4 * default(T).Bits));

                    CopyAscending<T>(&cast512, 0, basePtr, scalarIndex, 8);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreInt7x8<T>(void* basePtr, int scalarIndex, int length, Int7x8 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 7, length);
            
            if (default(T).Bits == 7)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 8);
            }
            else if (default(T).Bits < 7)
            {
                ulong cast = PackUnpack.DownCast<Int7, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
            }
            else
            {
                if (default(T).Bits <= 8)
                {
                    sbyte8 cast = (sbyte8)PackUnpack.BitIntArrayToByte8<Int7>(value.Bits);
                    cast = signextend(cast, default(Int7).Bits);
                    ulong cast64 = PackUnpack.DownCast<T>(cast);

                    CopyAscending<T>(&cast64, 0, basePtr, scalarIndex, 8);
                }
                if (default(T).Bits <= 16)
                {
                    short8 cast = (short8)PackUnpack.BitIntArrayToUShort8<Int7>(value.Bits);
                    cast = signextend(cast, default(Int7).Bits);
                    UInt128 cast128 = PackUnpack.DownCast128<T>(cast);

                    CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 8);
                }
                else if (default(T).Bits <= 32)
                {
                    int8 cast = (int8)PackUnpack.BitIntArrayToUInt8<Int7>(value.Bits);
                    cast = signextend(cast, default(Int7).Bits);
                    __UInt256__ cast256 = PackUnpack.DownCast256<T>(cast);

                    CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 8);
                }
                else
                {
                    long4 lo = (long4)PackUnpack.BitIntArrayToULong4<Int7>(value.Bits);
                    long4 hi = (long4)PackUnpack.BitIntArrayToULong4<Int7>((ulong)(value.Bits >> (4 * default(Int7).Bits)));
                    lo = signextend(lo, default(Int7).Bits);
                    hi = signextend(hi, default(Int7).Bits);
                    __UInt256__ lo256 = PackUnpack.DownCast256<T>(lo);
                    __UInt256__ hi256 = PackUnpack.DownCast256<T>(hi);
                    __UInt512__ cast512 = (__UInt512__)lo256 | ((__UInt512__)hi256 << (4 * default(T).Bits));

                    CopyAscending<T>(&cast512, 0, basePtr, scalarIndex, 8);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreInt10x4<T>(void* basePtr, int scalarIndex, int length, Int10x4 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 3, length);
            
            if (default(T).Bits == 10)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 4);
            }
            else if (default(T).Bits < 10)
            {
                ulong cast = PackUnpack.DownCast<Int10, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 4);
            }
            else
            {
                if (default(T).Bits <= 16)
                {
                    short4 cast = (short4)PackUnpack.BitIntArrayToUShort4<Int10>(value.Bits);
                    cast = signextend(cast, default(Int10).Bits);
                    ulong cast64 = PackUnpack.DownCast<T>(cast);

                    CopyAscending<T>(&cast64, 0, basePtr, scalarIndex, 4);
                }
                else if (default(T).Bits <= 32)
                {
                    int4 cast = (int4)PackUnpack.BitIntArrayToUInt4<Int10>(value.Bits);
                    cast = signextend(cast, default(Int10).Bits);
                    UInt128 cast128 = PackUnpack.DownCast128<T>(cast);

                    CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 4);
                }
                else
                {
                    long4 cast = (long4)PackUnpack.BitIntArrayToULong4<Int10>(value.Bits);
                    cast = signextend(cast, default(Int10).Bits);
                    __UInt256__ cast256 = PackUnpack.DownCast256<T>(cast);

                    CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 4);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreInt12x2<T>(void* basePtr, int scalarIndex, int length, Int12x2 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 1, length);
            
            if (default(T).Bits == 12)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 2);
            }
            else if (default(T).Bits < 12)
            {
                ulong cast = PackUnpack.DownCast<Int12, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 2);
            }
            else
            {
                if (default(T).Bits <= 32)
                {
                    int2 cast = (int2)PackUnpack.BitIntArrayToUInt2<Int12>(value.Bits);
                    cast = signextend(cast, default(Int12).Bits);
                    ulong cast64 = PackUnpack.DownCast<T>(cast);

                    CopyAscending<T>(&cast64, 0, basePtr, scalarIndex, 2);
                }
                else
                {
                    long2 cast = (long2)PackUnpack.BitIntArrayToULong2<Int12>(value.Bits);
                    cast = signextend(cast, default(Int12).Bits);
                    UInt128 cast128 = PackUnpack.DownCast128<T>(cast);

                    CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 2);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreInt12x4<T>(void* basePtr, int scalarIndex, int length, Int12x4 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 3, length);
            
            if (default(T).Bits == 12)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 4);
            }
            else if (default(T).Bits < 12)
            {
                ulong cast = PackUnpack.DownCast<Int12, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 4);
            }
            else
            {
                if (default(T).Bits <= 16)
                {
                    short4 cast = (short4)PackUnpack.BitIntArrayToUShort4<Int12>(value.Bits);
                    cast = signextend(cast, default(Int12).Bits);
                    ulong cast64 = PackUnpack.DownCast<T>(cast);

                    CopyAscending<T>(&cast64, 0, basePtr, scalarIndex, 4);
                }
                else if (default(T).Bits <= 32)
                {
                    int4 cast = (int4)PackUnpack.BitIntArrayToUInt4<Int12>(value.Bits);
                    cast = signextend(cast, default(Int12).Bits);
                    UInt128 cast128 = PackUnpack.DownCast128<T>(cast);

                    CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 4);
                }
                else
                {
                    long4 cast = (long4)PackUnpack.BitIntArrayToULong4<Int12>(value.Bits);
                    cast = signextend(cast, default(Int12).Bits);
                    __UInt256__ cast256 = PackUnpack.DownCast256<T>(cast);

                    CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 4);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreInt14x4<T>(void* basePtr, int scalarIndex, int length, Int14x4 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 3, length);
            
            if (default(T).Bits == 14)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 4);
            }
            else if (default(T).Bits < 14)
            {
                ulong cast = PackUnpack.DownCast<Int14, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 4);
            }
            else
            {
                if (default(T).Bits <= 16)
                {
                    short4 cast = (short4)PackUnpack.BitIntArrayToUShort4<Int14>(value.Bits);
                    cast = signextend(cast, default(Int14).Bits);
                    ulong cast64 = PackUnpack.DownCast<T>(cast);

                    CopyAscending<T>(&cast64, 0, basePtr, scalarIndex, 4);
                }
                else if (default(T).Bits <= 32)
                {
                    int4 cast = (int4)PackUnpack.BitIntArrayToUInt4<Int14>(value.Bits);
                    cast = signextend(cast, default(Int14).Bits);
                    UInt128 cast128 = PackUnpack.DownCast128<T>(cast);

                    CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 4);
                }
                else
                {
                    long4 cast = (long4)PackUnpack.BitIntArrayToULong4<Int14>(value.Bits);
                    cast = signextend(cast, default(Int14).Bits);
                    __UInt256__ cast256 = PackUnpack.DownCast256<T>(cast);

                    CopyAscending<T>(&cast256, 0, basePtr, scalarIndex, 4);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreInt20x2<T>(void* basePtr, int scalarIndex, int length, Int20x2 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 1, length);
            
            if (default(T).Bits == 20)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 2);
            }
            else if (default(T).Bits < 20)
            {
                ulong cast = PackUnpack.DownCast<Int20, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 2);
            }
            else
            {
                if (default(T).Bits <= 32)
                {
                    int2 cast = (int2)PackUnpack.BitIntArrayToUInt2<Int20>(value.Bits);
                    cast = signextend(cast, default(Int20).Bits);
                    ulong cast64 = PackUnpack.DownCast<T>(cast);

                    CopyAscending<T>(&cast64, 0, basePtr, scalarIndex, 2);
                }
                else
                {
                    long2 cast = (long2)PackUnpack.BitIntArrayToULong2<Int20>(value.Bits);
                    cast = signextend(cast, default(Int20).Bits);
                    UInt128 cast128 = PackUnpack.DownCast128<T>(cast);

                    CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 2);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreInt28x2<T>(void* basePtr, int scalarIndex, int length, Int28x2 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 1, length);
            
            if (default(T).Bits == 28)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 2);
            }
            else if (default(T).Bits < 28)
            {
                ulong cast = PackUnpack.DownCast<Int28, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 2);
            }
            else
            {
                if (default(T).Bits <= 32)
                {
                    int2 cast = (int2)PackUnpack.BitIntArrayToUInt2<Int28>(value.Bits);
                    cast = signextend(cast, default(Int28).Bits);
                    ulong cast64 = PackUnpack.DownCast<T>(cast);

                    CopyAscending<T>(&cast64, 0, basePtr, scalarIndex, 2);
                }
                else
                {
                    long2 cast = (long2)PackUnpack.BitIntArrayToULong2<Int28>(value.Bits);
                    cast = signextend(cast, default(Int28).Bits);
                    UInt128 cast128 = PackUnpack.DownCast128<T>(cast);

                    CopyAscending<T>(&cast128, 0, basePtr, scalarIndex, 2);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUInt2x4<T>(void* basePtr, int scalarIndex, int length, UInt2x4 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 3, length);

            if (default(T).Bits == 2)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 4);
            }
            else if (default(T).Bits < 2)
            {
                ulong cast = PackUnpack.DownCast<UInt2, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 4);
            }
            else
            {
                if (default(T).Bits * 4 <= 64)
                {
                    ulong cast = PackUnpack.UpCast64<UInt2, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 4);
                }
                else if (default(T).Bits * 4 <= 128)
                {
                    UInt128 cast = PackUnpack.UpCast128<UInt2, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 4);
                }
                else
                {
                    __UInt256__ cast = PackUnpack.UpCast256<UInt2, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 4);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUInt2x8<T>(void* basePtr, int scalarIndex, int length, UInt2x8 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 7, length);
            
            if (default(T).Bits == 2)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 8);
            }
            else if (default(T).Bits < 2)
            {
                ulong cast = PackUnpack.DownCast<UInt2, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
            }
            else
            {
                if (default(T).Bits * 8 <= 64)
                {
                    ulong cast = PackUnpack.UpCast64<UInt2, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
                }
                else if (default(T).Bits * 8 <= 128)
                {
                    UInt128 cast = PackUnpack.UpCast128<UInt2, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
                }
                else if (default(T).Bits * 8 <= 256)
                {
                    __UInt256__ cast = PackUnpack.UpCast256<UInt2, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
                }
                else
                {
                    __UInt512__ cast = PackUnpack.UpCast512<UInt2, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUInt2x12<T>(void* basePtr, int scalarIndex, int length, UInt2x12 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 11, length);
            
            if (default(T).Bits == 2)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 12);
            }
            else if (default(T).Bits < 2)
            {
                ulong cast = PackUnpack.DownCast<UInt2, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 12);
            }
            else
            {
                if (default(T).Bits * 12 <= 64)
                {
                    ulong cast = PackUnpack.UpCast64<UInt2, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 12);
                }
                else if (default(T).Bits * 12 <= 128)
                {
                    UInt128 cast = PackUnpack.UpCast128<UInt2, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 12);
                }
                else if (default(T).Bits * 12 <= 256)
                {
                    __UInt256__ cast = PackUnpack.UpCast256<UInt2, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 12);
                }
                else if (default(T).Bits * 12 <= 512)
                {
                    __UInt512__ cast = PackUnpack.UpCast512<UInt2, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 12);
                }
                else
                {
                    __UInt1024__ cast = PackUnpack.UpCast1024<UInt2, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 12);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUInt2x16<T>(void* basePtr, int scalarIndex, int length, UInt2x16 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 15, length);
            
            if (default(T).Bits == 2)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 16);
            }
            else if (default(T).Bits < 2)
            {
                ulong cast = PackUnpack.DownCast<UInt2, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 16);
            }
            else
            {
                if (default(T).Bits * 16 <= 64)
                {
                    ulong cast = PackUnpack.UpCast64<UInt2, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 16);
                }
                else if (default(T).Bits * 16 <= 128)
                {
                    UInt128 cast = PackUnpack.UpCast128<UInt2, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 16);
                }
                else if (default(T).Bits * 16 <= 256)
                {
                    __UInt256__ cast = PackUnpack.UpCast256<UInt2, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 16);
                }
                else if (default(T).Bits * 16 <= 512)
                {
                    __UInt512__ cast = PackUnpack.UpCast512<UInt2, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 16);
                }
                else
                {
                    __UInt1024__ cast = PackUnpack.UpCast1024<UInt2, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 16);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUInt2x20<T>(void* basePtr, int scalarIndex, int length, UInt2x20 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 19, length);
            
            if (default(T).Bits == 2)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 20);
            }
            else if (default(T).Bits < 2)
            {
                ulong cast = PackUnpack.DownCast<UInt2, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 20);
            }
            else
            {
                if (default(T).Bits * 20 <= 64)
                {
                    ulong cast = PackUnpack.UpCast64<UInt2, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 20);
                }
                else if (default(T).Bits * 20 <= 128)
                {
                    UInt128 cast = PackUnpack.UpCast128<UInt2, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 20);
                }
                else if (default(T).Bits * 20 <= 256)
                {
                    __UInt256__ cast = PackUnpack.UpCast256<UInt2, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 20);
                }
                else if (default(T).Bits * 20 <= 512)
                {
                    __UInt512__ cast = PackUnpack.UpCast512<UInt2, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 20);
                }
                else if (default(T).Bits * 20 <= 1024)
                {
                    __UInt1024__ cast = PackUnpack.UpCast1024<UInt2, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 20);
                }
                else
                {
                    __UInt2048__ cast = PackUnpack.UpCast2048<UInt2, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 20);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUInt2x24<T>(void* basePtr, int scalarIndex, int length, UInt2x24 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 23, length);
            
            if (default(T).Bits == 2)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 24);
            }
            else if (default(T).Bits < 2)
            {
                ulong cast = PackUnpack.DownCast<UInt2, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 24);
            }
            else
            {
                if (default(T).Bits * 24 <= 128)
                {
                    UInt128 cast = PackUnpack.UpCast128<UInt2, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 24);
                }
                else if (default(T).Bits * 24 <= 256)
                {
                    __UInt256__ cast = PackUnpack.UpCast256<UInt2, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 24);
                }
                else if (default(T).Bits * 24 <= 512)
                {
                    __UInt512__ cast = PackUnpack.UpCast512<UInt2, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 24);
                }
                else if (default(T).Bits * 32 <= 1024)
                {
                    __UInt1024__ cast = PackUnpack.UpCast1024<UInt2, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 24);
                }
                else
                {
                    __UInt2048__ cast = PackUnpack.UpCast2048<UInt2, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 24);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUInt2x28<T>(void* basePtr, int scalarIndex, int length, UInt2x28 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 27, length);
            
            if (default(T).Bits == 2)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 28);
            }
            else if (default(T).Bits < 2)
            {
                ulong cast = PackUnpack.DownCast<UInt2, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 28);
            }
            else
            {
                if (default(T).Bits * 28 <= 128)
                {
                    UInt128 cast = PackUnpack.UpCast128<UInt2, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 28);
                }
                else if (default(T).Bits * 28 <= 256)
                {
                    __UInt256__ cast = PackUnpack.UpCast256<UInt2, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 28);
                }
                else if (default(T).Bits * 28 <= 512)
                {
                    __UInt512__ cast = PackUnpack.UpCast512<UInt2, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 28);
                }
                else if (default(T).Bits * 32 <= 1024)
                {
                    __UInt1024__ cast = PackUnpack.UpCast1024<UInt2, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 28);
                }
                else
                {
                    __UInt2048__ cast = PackUnpack.UpCast2048<UInt2, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 28);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUInt2x32<T>(void* basePtr, int scalarIndex, int length, UInt2x32 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 31, length);
            
            if (default(T).Bits == 2)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 32);
            }
            else if (default(T).Bits < 2)
            {
                ulong cast = PackUnpack.DownCast<UInt2, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 32);
            }
            else
            {
                if (default(T).Bits * 32 <= 128)
                {
                    UInt128 cast = PackUnpack.UpCast128<UInt2, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 32);
                }
                else if (default(T).Bits * 32 <= 256)
                {
                    __UInt256__ cast = PackUnpack.UpCast256<UInt2, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 32);
                }
                else if (default(T).Bits * 32 <= 512)
                {
                    __UInt512__ cast = PackUnpack.UpCast512<UInt2, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 32);
                }
                else if (default(T).Bits * 32 <= 1024)
                {
                    __UInt1024__ cast = PackUnpack.UpCast1024<UInt2, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 32);
                }
                else
                {
                    __UInt2048__ cast = PackUnpack.UpCast2048<UInt2, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 32);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUInt3x8<T>(void* basePtr, int scalarIndex, int length, UInt3x8 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 7, length);
            
            if (default(T).Bits == 3)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 8);
            }
            else if (default(T).Bits < 3)
            {
                ulong cast = PackUnpack.DownCast<UInt3, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
            }
            else
            {
                if (default(T).Bits * 8 <= 64)
                {
                    ulong cast = PackUnpack.UpCast64<UInt3, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
                }
                else if (default(T).Bits * 8 <= 128)
                {
                    UInt128 cast = PackUnpack.UpCast128<UInt3, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
                }
                else if (default(T).Bits * 8 <= 256)
                {
                    __UInt256__ cast = PackUnpack.UpCast256<UInt3, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
                }
                else
                {
                    __UInt512__ cast = PackUnpack.UpCast512<UInt3, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUInt3x16<T>(void* basePtr, int scalarIndex, int length, UInt3x16 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 15, length);
            
            if (default(T).Bits == 3)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 16);
            }
            else if (default(T).Bits < 3)
            {
                ulong cast = PackUnpack.DownCast<UInt3, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 16);
            }
            else
            {
                if (default(T).Bits * 16 <= 64)
                {
                    ulong cast = PackUnpack.UpCast64<UInt3, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 16);
                }
                else if (default(T).Bits * 16 <= 128)
                {
                    UInt128 cast = PackUnpack.UpCast128<UInt3, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 16);
                }
                else if (default(T).Bits * 16 <= 256)
                {
                    __UInt256__ cast = PackUnpack.UpCast256<UInt3, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 16);
                }
                else if (default(T).Bits * 16 <= 512)
                {
                    __UInt512__ cast = PackUnpack.UpCast512<UInt3, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 16);
                }
                else
                {
                    __UInt1024__ cast = PackUnpack.UpCast1024<UInt3, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 16);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUInt4x2<T>(void* basePtr, int scalarIndex, int length, UInt4x2 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 1, length);
            
            if (default(T).Bits == 4)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 2);
            }
            else if (default(T).Bits < 4)
            {
                ulong cast = PackUnpack.DownCast<UInt4, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 2);
            }
            else
            {
                if (default(T).Bits * 2 <= 64)
                {
                    ulong cast = PackUnpack.UpCast64<UInt4, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 2);
                }
                else
                {
                    UInt128 cast = PackUnpack.UpCast128<UInt4, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 2);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUInt4x4<T>(void* basePtr, int scalarIndex, int length, UInt4x4 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 3, length);
            
            if (default(T).Bits == 4)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 4);
            }
            else if (default(T).Bits < 4)
            {
                ulong cast = PackUnpack.DownCast<UInt4, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 4);
            }
            else
            {
                if (default(T).Bits * 4 <= 64)
                {
                    ulong cast = PackUnpack.UpCast64<UInt4, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 4);
                }
                else if (default(T).Bits * 4 <= 128)
                {
                    UInt128 cast = PackUnpack.UpCast128<UInt4, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 4);
                }
                else
                {
                    __UInt256__ cast = PackUnpack.UpCast256<UInt4, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 4);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUInt4x6<T>(void* basePtr, int scalarIndex, int length, UInt4x6 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 5, length);
            
            if (default(T).Bits == 4)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 6);
            }
            else if (default(T).Bits < 4)
            {
                ulong cast = PackUnpack.DownCast<UInt4, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 6);
            }
            else
            {
                if (default(T).Bits * 8 <= 64)
                {
                    ulong cast = PackUnpack.UpCast64<UInt4, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 6);
                }
                else if (default(T).Bits * 8 <= 128)
                {
                    UInt128 cast = PackUnpack.UpCast128<UInt4, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 6);
                }
                else if (default(T).Bits * 8 <= 256)
                {
                    __UInt256__ cast = PackUnpack.UpCast256<UInt4, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 6);
                }
                else
                {
                    __UInt512__ cast = PackUnpack.UpCast512<UInt4, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 6);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUInt4x8<T>(void* basePtr, int scalarIndex, int length, UInt4x8 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 7, length);
            
            if (default(T).Bits == 4)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 8);
            }
            else if (default(T).Bits < 4)
            {
                ulong cast = PackUnpack.DownCast<UInt4, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
            }
            else
            {
                if (default(T).Bits * 8 <= 64)
                {
                    ulong cast = PackUnpack.UpCast64<UInt4, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
                }
                else if (default(T).Bits * 8 <= 128)
                {
                    UInt128 cast = PackUnpack.UpCast128<UInt4, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
                }
                else if (default(T).Bits * 8 <= 256)
                {
                    __UInt256__ cast = PackUnpack.UpCast256<UInt4, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
                }
                else
                {
                    __UInt512__ cast = PackUnpack.UpCast512<UInt4, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUInt4x10<T>(void* basePtr, int scalarIndex, int length, UInt4x10 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 9, length);
            
            if (default(T).Bits == 4)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 10);
            }
            else if (default(T).Bits < 4)
            {
                ulong cast = PackUnpack.DownCast<UInt4, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 10);
            }
            else
            {
                if (default(T).Bits * 10 <= 64)
                {
                    ulong cast = PackUnpack.UpCast64<UInt4, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 10);
                }
                else if (default(T).Bits * 10 <= 128)
                {
                    UInt128 cast = PackUnpack.UpCast128<UInt4, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 10);
                }
                else if (default(T).Bits * 10 <= 256)
                {
                    __UInt256__ cast = PackUnpack.UpCast256<UInt4, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 10);
                }
                else if (default(T).Bits * 10 <= 512)
                {
                    __UInt512__ cast = PackUnpack.UpCast512<UInt4, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 10);
                }
                else
                {
                    __UInt1024__ cast = PackUnpack.UpCast1024<UInt4, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 10);
                }
            }
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUInt4x12<T>(void* basePtr, int scalarIndex, int length, UInt4x12 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 11, length);
            
            if (default(T).Bits == 4)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 12);
            }
            else if (default(T).Bits < 4)
            {
                ulong cast = PackUnpack.DownCast<UInt4, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 12);
            }
            else
            {
                if (default(T).Bits * 12 <= 64)
                {
                    ulong cast = PackUnpack.UpCast64<UInt4, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 12);
                }
                else if (default(T).Bits * 12 <= 128)
                {
                    UInt128 cast = PackUnpack.UpCast128<UInt4, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 12);
                }
                else if (default(T).Bits * 12 <= 256)
                {
                    __UInt256__ cast = PackUnpack.UpCast256<UInt4, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 12);
                }
                else if (default(T).Bits * 12 <= 512)
                {
                    __UInt512__ cast = PackUnpack.UpCast512<UInt4, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 12);
                }
                else
                {
                    __UInt1024__ cast = PackUnpack.UpCast1024<UInt4, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 12);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUInt4x14<T>(void* basePtr, int scalarIndex, int length, UInt4x14 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 13, length);
            
            if (default(T).Bits == 4)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 14);
            }
            else if (default(T).Bits < 4)
            {
                ulong cast = PackUnpack.DownCast<UInt4, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 14);
            }
            else
            {
                if (default(T).Bits * 14 <= 128)
                {
                    UInt128 cast = PackUnpack.UpCast128<UInt4, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 14);
                }
                else if (default(T).Bits * 14 <= 256)
                {
                    __UInt256__ cast = PackUnpack.UpCast256<UInt4, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 14);
                }
                else if (default(T).Bits * 14 <= 512)
                {
                    __UInt512__ cast = PackUnpack.UpCast512<UInt4, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 14);
                }
                else
                {
                    __UInt1024__ cast = PackUnpack.UpCast1024<UInt4, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 14);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUInt4x16<T>(void* basePtr, int scalarIndex, int length, UInt4x16 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 15, length);
            
            if (default(T).Bits == 4)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 16);
            }
            else if (default(T).Bits < 4)
            {
                ulong cast = PackUnpack.DownCast<UInt4, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 16);
            }
            else
            {
                if (default(T).Bits * 16 <= 128)
                {
                    UInt128 cast = PackUnpack.UpCast128<UInt4, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 16);
                }
                else if (default(T).Bits * 16 <= 256)
                {
                    __UInt256__ cast = PackUnpack.UpCast256<UInt4, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 16);
                }
                else if (default(T).Bits * 16 <= 512)
                {
                    __UInt512__ cast = PackUnpack.UpCast512<UInt4, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 16);
                }
                else
                {
                    __UInt1024__ cast = PackUnpack.UpCast1024<UInt4, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 16);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUInt5x8<T>(void* basePtr, int scalarIndex, int length, UInt5x8 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 7, length);
            
            if (default(T).Bits == 5)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 8);
            }
            else if (default(T).Bits < 5)
            {
                ulong cast = PackUnpack.DownCast<UInt5, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
            }
            else
            {
                if (default(T).Bits * 8 <= 64)
                {
                    ulong cast = PackUnpack.UpCast64<UInt5, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
                }
                else if (default(T).Bits * 8 <= 128)
                {
                    UInt128 cast = PackUnpack.UpCast128<UInt5, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
                }
                else if (default(T).Bits * 8 <= 256)
                {
                    __UInt256__ cast = PackUnpack.UpCast256<UInt5, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
                }
                else
                {
                    __UInt512__ cast = PackUnpack.UpCast512<UInt5, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUInt6x4<T>(void* basePtr, int scalarIndex, int length, UInt6x4 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 3, length);
            
            if (default(T).Bits == 6)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 4);
            }
            else if (default(T).Bits < 6)
            {
                ulong cast = PackUnpack.DownCast<UInt6, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 4);
            }
            else
            {
                if (default(T).Bits * 4 <= 64)
                {
                    ulong cast = PackUnpack.UpCast64<UInt6, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 4);
                }
                else if (default(T).Bits * 4 <= 128)
                {
                    UInt128 cast = PackUnpack.UpCast128<UInt6, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 4);
                }
                else
                {
                    __UInt256__ cast = PackUnpack.UpCast256<UInt6, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 4);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUInt6x8<T>(void* basePtr, int scalarIndex, int length, UInt6x8 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 7, length);
            
            if (default(T).Bits == 6)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 8);
            }
            else if (default(T).Bits < 6)
            {
                ulong cast = PackUnpack.DownCast<UInt6, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
            }
            else
            {
                if (default(T).Bits * 8 <= 64)
                {
                    ulong cast = PackUnpack.UpCast64<UInt6, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
                }
                else if (default(T).Bits * 8 <= 128)
                {
                    UInt128 cast = PackUnpack.UpCast128<UInt6, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
                }
                else if (default(T).Bits * 8 <= 256)
                {
                    __UInt256__ cast = PackUnpack.UpCast256<UInt6, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
                }
                else
                {
                    __UInt512__ cast = PackUnpack.UpCast512<UInt6, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUInt7x8<T>(void* basePtr, int scalarIndex, int length, UInt7x8 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 7, length);
            
            if (default(T).Bits == 7)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 8);
            }
            else if (default(T).Bits < 7)
            {
                ulong cast = PackUnpack.DownCast<UInt7, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
            }
            else
            {
                if (default(T).Bits * 8 <= 64)
                {
                    ulong cast = PackUnpack.UpCast64<UInt7, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
                }
                else if (default(T).Bits * 8 <= 128)
                {
                    UInt128 cast = PackUnpack.UpCast128<UInt7, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
                }
                else if (default(T).Bits * 8 <= 256)
                {
                    __UInt256__ cast = PackUnpack.UpCast256<UInt7, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
                }
                else
                {
                    __UInt512__ cast = PackUnpack.UpCast512<UInt7, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 8);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUInt10x4<T>(void* basePtr, int scalarIndex, int length, UInt10x4 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 3, length);
            
            if (default(T).Bits == 10)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 4);
            }
            else if (default(T).Bits < 10)
            {
                ulong cast = PackUnpack.DownCast<UInt10, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 4);
            }
            else
            {
                if (default(T).Bits * 4 <= 64)
                {
                    ulong cast = PackUnpack.UpCast64<UInt10, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 4);
                }
                else if (default(T).Bits * 4 <= 128)
                {
                    UInt128 cast = PackUnpack.UpCast128<UInt10, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 4);
                }
                else
                {
                    __UInt256__ cast = PackUnpack.UpCast256<UInt10, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 4);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUInt12x2<T>(void* basePtr, int scalarIndex, int length, UInt12x2 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 1, length);
            
            if (default(T).Bits == 12)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 2);
            }
            else if (default(T).Bits < 12)
            {
                ulong cast = PackUnpack.DownCast<UInt12, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 2);
            }
            else
            {
                if (default(T).Bits * 2 <= 64)
                {
                    ulong cast = PackUnpack.UpCast64<UInt12, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 2);
                }
                else
                {
                    UInt128 cast = PackUnpack.UpCast128<UInt12, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 2);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUInt12x4<T>(void* basePtr, int scalarIndex, int length, UInt12x4 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 3, length);
            
            if (default(T).Bits == 12)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 4);
            }
            else if (default(T).Bits < 12)
            {
                ulong cast = PackUnpack.DownCast<UInt12, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 4);
            }
            else
            {
                if (default(T).Bits * 4 <= 64)
                {
                    ulong cast = PackUnpack.UpCast64<UInt12, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 4);
                }
                else if (default(T).Bits * 4 <= 128)
                {
                    UInt128 cast = PackUnpack.UpCast128<UInt12, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 4);
                }
                else
                {
                    __UInt256__ cast = PackUnpack.UpCast256<UInt12, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 4);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUInt14x4<T>(void* basePtr, int scalarIndex, int length, UInt14x4 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 3, length);
            
            if (default(T).Bits == 14)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 4);
            }
            else if (default(T).Bits < 14)
            {
                ulong cast = PackUnpack.DownCast<UInt14, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 4);
            }
            else
            {
                if (default(T).Bits * 4 <= 64)
                {
                    ulong cast = PackUnpack.UpCast64<UInt14, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 4);
                }
                else if (default(T).Bits * 4 <= 128)
                {
                    UInt128 cast = PackUnpack.UpCast128<UInt14, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 4);
                }
                else
                {
                    __UInt256__ cast = PackUnpack.UpCast256<UInt14, T>((ulong)value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 4);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUInt20x2<T>(void* basePtr, int scalarIndex, int length, UInt20x2 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 1, length);
            
            if (default(T).Bits == 20)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 2);
            }
            else if (default(T).Bits < 20)
            {
                ulong cast = PackUnpack.DownCast<UInt20, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 2);
            }
            else
            {
                if (default(T).Bits * 2 <= 64)
                {
                    ulong cast = PackUnpack.UpCast64<UInt20, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 2);
                }
                else
                {
                    UInt128 cast = PackUnpack.UpCast128<UInt20, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 2);
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUInt28x2<T>(void* basePtr, int scalarIndex, int length, UInt28x2 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 1, length);
            
            if (default(T).Bits == 28)
            {
                CopyAscending<T>(&value, 0, basePtr, scalarIndex, 2);
            }
            else if (default(T).Bits < 28)
            {
                ulong cast = PackUnpack.DownCast<UInt28, T>(value.Bits);
                CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 2);
            }
            else
            {
                if (default(T).Bits * 2 <= 64)
                {
                    ulong cast = PackUnpack.UpCast64<UInt28, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 2);
                }
                else
                {
                    UInt128 cast = PackUnpack.UpCast128<UInt28, T>(value.Bits);
                    CopyAscending<T>(&cast, 0, basePtr, scalarIndex, 2);
                }
            }
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreByte2<T>(void* basePtr, int scalarIndex, int length, byte2 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 1, length);

            if (default(T).Bits == 8)
            {
                *(byte2*)((byte*)basePtr + scalarIndex) = value;
                return;
            }

            if (default(T).Bits == 24)
            {
                Store_u8_to24((UInt24*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 40)
            {
                Store_u8_to40((UInt40*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 48)
            {
                Store_u8_to48((UInt48*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 56)
            {
                Store_u8_to56((UInt56*)basePtr + scalarIndex, value);
                return;
            }
            
            if (default(T).Bits <= 8)
            {
                ulong packed = PackUnpack.DownCast<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 2);
            }
            else if (default(T).Bits <= 32)
            {
                ulong packed = PackUnpack.UpCast<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 2);
            }      
            else
            {
                UInt128 packed = PackUnpack.UpCast128<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 2);
            }
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreByte3<T>(void* basePtr, int scalarIndex, int length, byte3 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 2, length);

            if (default(T).Bits == 8)
            {
                *(byte3*)((byte*)basePtr + scalarIndex) = value;
                return;
            }

            if (default(T).Bits == 24)
            {
                Store_u8_to24((UInt24*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 40)
            {
                Store_u8_to40((UInt40*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 48)
            {
                Store_u8_to48((UInt48*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 56)
            {
                Store_u8_to56((UInt56*)basePtr + scalarIndex, value);
                return;
            }
            
            if (default(T).Bits <= 8)
            {
                ulong packed = PackUnpack.DownCast<T>(new byte4(value, Uninitialized<byte>.Create()));

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 3);
            }
            else if (default(T).Bits <= 16)
            {
                ulong packed = PackUnpack.UpCast<T>(new byte4(value, Uninitialized<byte>.Create()));

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 3);
            }
            else if (default(T).Bits <= 32)
            {
                UInt128 packed = PackUnpack.DownCast128<T>((uint4)new byte4(value, Uninitialized<byte>.Create()));

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 3);
            }
            else if (default(T).Bits <= 128 / 3)
            {
                UInt128 lo = PackUnpack.UpCast128<T>(value.xy);
                UInt128 hi = (UInt128)value.z << (2 * default(T).Bits);
                UInt128 packed = lo | hi;

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 3);
            }
            else
            {
                UInt128* packed = stackalloc UInt128[]
                {
                    PackUnpack.UpCast128<T>(value.xy),
                    value.z
                };        
                
                packed[0] |= packed[1] << (2 * default(T).Bits);
                packed[1] >>= 128 - (2 * default(T).Bits);

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 3);
            }
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreByte4<T>(void* basePtr, int scalarIndex, int length, byte4 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 3, length);

            if (default(T).Bits == 8)
            {
                *(byte4*)((byte*)basePtr + scalarIndex) = value;
                return;
            }

            if (default(T).Bits == 24)
            {
                Store_u8_to24((UInt24*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 40)
            {
                Store_u8_to40((UInt40*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 48)
            {
                Store_u8_to48((UInt48*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 56)
            {
                Store_u8_to56((UInt56*)basePtr + scalarIndex, value);
                return;
            }
            
            if (default(T).Bits <= 8)
            {
                ulong packed = PackUnpack.DownCast<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 4);
            }
            else if (default(T).Bits <= 16)
            {
                ulong packed = PackUnpack.UpCast<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 4);
            }
            else if (default(T).Bits <= 32)
            {
                UInt128 packed = PackUnpack.DownCast128<T>((uint4)value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 4);
            }
            else
            {
                UInt128* packed = stackalloc UInt128[]
                {
                    PackUnpack.UpCast128<T>(value.xy),
                    PackUnpack.UpCast128<T>(value.zw)
                };        
                
                packed[0] |= packed[1] << (2 * default(T).Bits);
                packed[1] >>= 128 - (2 * default(T).Bits);

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 4);
            }
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreByte8<T>(void* basePtr, int scalarIndex, int length, byte8 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 7, length);

            if (default(T).Bits == 8)
            {
                *(byte8*)((byte*)basePtr + scalarIndex) = value;
                return;
            }

            if (default(T).Bits == 24)
            {
                Store_u8_to24((UInt24*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 40)
            {
                Store_u8_to40((UInt40*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 48)
            {
                Store_u8_to48((UInt48*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 56)
            {
                Store_u8_to56((UInt56*)basePtr + scalarIndex, value);
                return;
            }
            
            if (default(T).Bits <= 8)
            {
                ulong packed = PackUnpack.DownCast<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 8);
            }
            else if (default(T).Bits <= 16)
            {
                UInt128 packed = PackUnpack.UpCast128<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 8);
            }
            else if (default(T).Bits <= 32)
            {
                UInt128* packed = stackalloc UInt128[]
                {
                    PackUnpack.UpCast128<T>(value.v4_0),
                    PackUnpack.UpCast128<T>(value.v4_4)
                };

                if (default(T).Bits != 32)
                {
                    packed[0] |= packed[1] << (4 * default(T).Bits);
                    packed[1] >>= 128 - (4 * default(T).Bits);
                }

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 8);
            }
            else
            {
                __UInt256__* packed = stackalloc __UInt256__[]
                {
                    PackUnpack.UpCast256<T>(value.v4_0),
                    PackUnpack.UpCast256<T>(value.v4_4)
                };

                packed[0] |= packed[1] << (4 * default(T).Bits);
                packed[1] >>= 256 - (4 * default(T).Bits);

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 8);
            }
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreByte16<T>(void* basePtr, int scalarIndex, int length, byte16 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 15, length);

            if (default(T).Bits == 8)
            {
                *(byte16*)((byte*)basePtr + scalarIndex) = value;
                return;
            }

            if (default(T).Bits == 24)
            {
                Store_u8_to24((UInt24*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 40)
            {
                Store_u8_to40((UInt40*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 48)
            {
                Store_u8_to48((UInt48*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 56)
            {
                Store_u8_to56((UInt56*)basePtr + scalarIndex, value);
                return;
            }
            
            if (default(T).Bits <= 4)
            {
                ulong packed = PackUnpack.DownCast<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 16);
            }
            else if (default(T).Bits <= 8)
            {
                UInt128 packed = PackUnpack.DownCast128<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 16);
            }
            else if (default(T).Bits <= 16)
            {
                UInt128* packed = stackalloc UInt128[]
                {
                    PackUnpack.UpCast128<T>(value.v8_0),
                    PackUnpack.UpCast128<T>(value.v8_8)
                };

                if (default(T).Bits != 16)
                {
                    packed[0] |= packed[1] << (8 * default(T).Bits);
                    packed[1] >>= 128 - (8 * default(T).Bits);
                }

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 16);
            }
            else if (default(T).Bits <= 32)
            {
                __UInt256__* packed = stackalloc __UInt256__[]
                {
                    PackUnpack.UpCast256<T>(value.v8_0),
                    PackUnpack.UpCast256<T>(value.v8_8)
                };

                if (default(T).Bits != 32)
                {
                    packed[0] |= packed[1] << (8 * default(T).Bits);
                    packed[1] >>= 256 - (8 * default(T).Bits);
                }

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 16);
            }
            else
            {
                __UInt512__* packed = stackalloc __UInt512__[]
                {
                    PackUnpack.UpCast512<T>(value.v8_0),
                    PackUnpack.UpCast512<T>(value.v8_8)
                };

                packed[0] |= packed[1] << (8 * default(T).Bits);
                packed[1] >>= 512 - (8 * default(T).Bits);

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 16);
            }
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreByte32<T>(void* basePtr, int scalarIndex, int length, byte32 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 31, length);

            if (default(T).Bits == 8)
            {
                *(byte32*)((byte*)basePtr + scalarIndex) = value;
                return;
            }

            if (default(T).Bits == 24)
            {
                Store_u8_to24((UInt24*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 40)
            {
                Store_u8_to40((UInt40*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 48)
            {
                Store_u8_to48((UInt48*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 56)
            {
                Store_u8_to56((UInt56*)basePtr + scalarIndex, value);
                return;
            }
            
            if (default(T).Bits <= 2)
            {
                ulong packed = PackUnpack.DownCast<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 32);
            }
            else if (default(T).Bits <= 4)
            {
                UInt128 lo = PackUnpack.DownCast128<T>(value.v16_0);
                UInt128 hi = PackUnpack.DownCast128<T>(value.v16_16);
                UInt128 packed = lo | (hi << (16 * default(T).Bits));

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 32);
            }
            else if (default(T).Bits <= 8)
            {
                UInt128* packed = stackalloc UInt128[]
                {
                    PackUnpack.DownCast128<T>(value.v16_0),
                    PackUnpack.DownCast128<T>(value.v16_16)
                };

                if (default(T).Bits != 8)
                {
                    packed[0] |= packed[1] << (16 * default(T).Bits);
                    packed[1] >>= 128 - (16 * default(T).Bits);
                }

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 32);
            }
            else if (default(T).Bits <= 16)
            {
                __UInt256__* packed = stackalloc __UInt256__[]
                {
                    PackUnpack.UpCast256<T>(value.v16_0),
                    PackUnpack.UpCast256<T>(value.v16_16)
                };

                if (default(T).Bits != 16)
                {
                    packed[0] |= packed[1] << (16 * default(T).Bits);
                    packed[1] >>= 256 - (16 * default(T).Bits);
                }

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 32);
            }
            else if (default(T).Bits <= 32)
            {
                __UInt512__* packed = stackalloc __UInt512__[]
                {
                    PackUnpack.UpCast512<T>(value.v16_0),
                    PackUnpack.UpCast512<T>(value.v16_16)
                };
                
                if (default(T).Bits != 32)
                {
                    packed[0] |= packed[1] << (16 * default(T).Bits);
                    packed[1] >>= 512 - (16 * default(T).Bits);
                }

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 32);
            }
            else
            {
                __UInt1024__* packed = stackalloc __UInt1024__[]
                {
                    PackUnpack.UpCast1024<T>(value.v16_0),
                    PackUnpack.UpCast1024<T>(value.v16_16)
                };

                packed[0] |= packed[1] << (16 * default(T).Bits);
                packed[1] >>= 1024 - (16 * default(T).Bits);

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 32);
            }
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreSByte2<T>(void* basePtr, int scalarIndex, int length, sbyte2 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 1, length);

            if (default(T).Bits == 8)
            {
                *(sbyte2*)((sbyte*)basePtr + scalarIndex) = value;
                return;
            }

            if (default(T).Bits == 24)
            {
                Store_i8_to24((UInt24*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 40)
            {
                Store_i8_to40((UInt40*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 48)
            {
                Store_i8_to48((UInt48*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 56)
            {
                Store_i8_to56((UInt56*)basePtr + scalarIndex, value);
                return;
            }
            
            if (default(T).Bits <= 8)
            {
                ulong packed = PackUnpack.DownCast<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 2);
            }
            else if (default(T).Bits <= 16)
            {
                ulong packed = PackUnpack.DownCast<T>((short2)value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 2);
            }      
            else if (default(T).Bits <= 32)
            {
                ulong packed = PackUnpack.DownCast<T>((int2)value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 2);
            }      
            else
            {
                UInt128 packed = PackUnpack.DownCast128<T>((long2)value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 2);
            }
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreSByte3<T>(void* basePtr, int scalarIndex, int length, sbyte3 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 2, length);

            if (default(T).Bits == 8)
            {
                *(sbyte3*)((sbyte*)basePtr + scalarIndex) = value;
                return;
            }

            if (default(T).Bits == 24)
            {
                Store_i8_to24((UInt24*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 40)
            {
                Store_i8_to40((UInt40*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 48)
            {
                Store_i8_to48((UInt48*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 56)
            {
                Store_i8_to56((UInt56*)basePtr + scalarIndex, value);
                return;
            }
            
            if (default(T).Bits <= 8)
            {
                ulong packed = PackUnpack.DownCast<T>(new sbyte4(value, Uninitialized<sbyte>.Create()));

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 3);
            }
            else if (default(T).Bits <= 16)
            {
                ulong packed = PackUnpack.DownCast<T>((short4)new sbyte4(value, Uninitialized<sbyte>.Create()));

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 3);
            }
            else if (default(T).Bits <= 32)
            {
                UInt128 packed = PackUnpack.DownCast128<T>((int4)new sbyte4(value, Uninitialized<sbyte>.Create()));

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 3);
            }
            else if (default(T).Bits <= 128 / 3)
            {
                UInt128 lo = PackUnpack.DownCast128<T>((long2)value.xy);
                UInt128 hi = (UInt128)value.z << (2 * default(T).Bits);
                UInt128 packed = lo | hi;

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 3);
            }
            else
            {
                UInt128* packed = stackalloc UInt128[]
                {
                    PackUnpack.DownCast128<T>((long2)value.xy),
                    (UInt128)value.z
                };        
                
                packed[0] |= packed[1] << (2 * default(T).Bits);
                packed[1] >>= 128 - (2 * default(T).Bits);

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 3);
            }
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreSByte4<T>(void* basePtr, int scalarIndex, int length, sbyte4 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 3, length);

            if (default(T).Bits == 8)
            {
                *(sbyte4*)((sbyte*)basePtr + scalarIndex) = value;
                return;
            }

            if (default(T).Bits == 24)
            {
                Store_i8_to24((UInt24*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 40)
            {
                Store_i8_to40((UInt40*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 48)
            {
                Store_i8_to48((UInt48*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 56)
            {
                Store_i8_to56((UInt56*)basePtr + scalarIndex, value);
                return;
            }
            
            if (default(T).Bits <= 8)
            {
                ulong packed = PackUnpack.DownCast<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 4);
            }
            else if (default(T).Bits <= 16)
            {
                ulong packed = PackUnpack.DownCast<T>((short4)value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 4);
            }
            else if (default(T).Bits <= 32)
            {
                UInt128 packed = PackUnpack.DownCast128<T>((int4)value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 4);
            }
            else
            {
                UInt128* packed = stackalloc UInt128[]
                {
                    PackUnpack.DownCast128<T>((long2)value.xy),
                    PackUnpack.DownCast128<T>((long2)value.zw),
                };        
                
                packed[0] |= packed[1] << (2 * default(T).Bits);
                packed[1] >>= 128 - (2 * default(T).Bits);

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 4);
            }
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreSByte8<T>(void* basePtr, int scalarIndex, int length, sbyte8 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 7, length);

            if (default(T).Bits == 8)
            {
                *(sbyte8*)((sbyte*)basePtr + scalarIndex) = value;
                return;
            }

            if (default(T).Bits == 24)
            {
                Store_i8_to24((UInt24*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 40)
            {
                Store_i8_to40((UInt40*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 48)
            {
                Store_i8_to48((UInt48*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 56)
            {
                Store_i8_to56((UInt56*)basePtr + scalarIndex, value);
                return;
            }
            
            if (default(T).Bits <= 8)
            {
                ulong packed = PackUnpack.DownCast<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 8);
            }
            else if (default(T).Bits <= 16)
            {
                UInt128 packed = PackUnpack.DownCast128<T>((short8)value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 8);
            }
            else if (default(T).Bits <= 32)
            {
                UInt128* packed = stackalloc UInt128[]
                {
                    PackUnpack.DownCast128<T>((int4)value.v4_0),
                    PackUnpack.DownCast128<T>((int4)value.v4_4)
                };

                if (default(T).Bits != 32)
                {
                    packed[0] |= packed[1] << (4 * default(T).Bits);
                    packed[1] >>= 128 - (4 * default(T).Bits);
                }

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 8);
            }
            else
            {
                __UInt256__* packed = stackalloc __UInt256__[]
                {
                    PackUnpack.DownCast256<T>((long4)value.v4_0),
                    PackUnpack.DownCast256<T>((long4)value.v4_4)
                };

                packed[0] |= packed[1] << (4 * default(T).Bits);
                packed[1] >>= 256 - (4 * default(T).Bits);

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 8);
            }
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreSByte16<T>(void* basePtr, int scalarIndex, int length, sbyte16 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 15, length);

            if (default(T).Bits == 8)
            {
                *(sbyte16*)((sbyte*)basePtr + scalarIndex) = value;
                return;
            }

            if (default(T).Bits == 24)
            {
                Store_i8_to24((UInt24*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 40)
            {
                Store_i8_to40((UInt40*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 48)
            {
                Store_i8_to48((UInt48*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 56)
            {
                Store_i8_to56((UInt56*)basePtr + scalarIndex, value);
                return;
            }
            
            if (default(T).Bits <= 4)
            {
                ulong packed = PackUnpack.DownCast<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 16);
            }
            else if (default(T).Bits <= 8)
            {
                UInt128 packed = PackUnpack.DownCast128<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 16);
            }
            else if (default(T).Bits <= 16)
            {
                UInt128* packed = stackalloc UInt128[]
                {
                    PackUnpack.DownCast128<T>((short8)value.v8_0),
                    PackUnpack.DownCast128<T>((short8)value.v8_8)
                };

                if (default(T).Bits != 16)
                {
                    packed[0] |= packed[1] << (8 * default(T).Bits);
                    packed[1] >>= 128 - (8 * default(T).Bits);
                }

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 16);
            }
            else if (default(T).Bits <= 32)
            {
                __UInt256__* packed = stackalloc __UInt256__[]
                {
                    PackUnpack.DownCast256<T>((int8)value.v8_0),
                    PackUnpack.DownCast256<T>((int8)value.v8_8)
                };

                if (default(T).Bits != 32)
                {
                    packed[0] |= packed[1] << (8 * default(T).Bits);
                    packed[1] >>= 256 - (8 * default(T).Bits);
                }

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 16);
            }
            else
            {
                __UInt512__* packed = stackalloc __UInt512__[]
                {
                    PackUnpack.DownCast512<T>((long4)value.v4_0, (long4)value.v4_4),
                    PackUnpack.DownCast512<T>((long4)value.v4_8, (long4)value.v4_12)
                };

                packed[0] |= packed[1] << (8 * default(T).Bits);
                packed[1] >>= 512 - (8 * default(T).Bits);

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 16);
            }
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreSByte32<T>(void* basePtr, int scalarIndex, int length, sbyte32 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 31, length);

            if (default(T).Bits == 8)
            {
                *(sbyte32*)((sbyte*)basePtr + scalarIndex) = value;
                return;
            }

            if (default(T).Bits == 24)
            {
                Store_i8_to24((UInt24*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 40)
            {
                Store_i8_to40((UInt40*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 48)
            {
                Store_i8_to48((UInt48*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 56)
            {
                Store_i8_to56((UInt56*)basePtr + scalarIndex, value);
                return;
            }
            
            if (default(T).Bits <= 2)
            {
                ulong packed = PackUnpack.DownCast<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 32);
            }
            else if (default(T).Bits <= 4)
            {
                UInt128 lo = PackUnpack.DownCast128<T>(value.v16_0);
                UInt128 hi = PackUnpack.DownCast128<T>(value.v16_16);
                UInt128 packed = lo | (hi << (16 * default(T).Bits));

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 32);
            }
            else if (default(T).Bits <= 8)
            {
                UInt128* packed = stackalloc UInt128[]
                {
                    PackUnpack.DownCast128<T>(value.v16_0),
                    PackUnpack.DownCast128<T>(value.v16_16)
                };

                if (default(T).Bits != 8)
                {
                    packed[0] |= packed[1] << (16 * default(T).Bits);
                    packed[1] >>= 128 - (16 * default(T).Bits);
                }

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 32);
            }
            else if (default(T).Bits <= 16)
            {
                __UInt256__* packed = stackalloc __UInt256__[]
                {
                    PackUnpack.DownCast256<T>((short16)value.v16_0),
                    PackUnpack.DownCast256<T>((short16)value.v16_16)
                };

                if (default(T).Bits != 16)
                {
                    packed[0] |= packed[1] << (16 * default(T).Bits);
                    packed[1] >>= 256 - (16 * default(T).Bits);
                }

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 32);
            }
            else if (default(T).Bits <= 32)
            {
                __UInt512__* packed = stackalloc __UInt512__[]
                {
                    PackUnpack.DownCast512<T>((int8)value.v8_0, (int8)value.v8_8),
                    PackUnpack.DownCast512<T>((int8)value.v8_16, (int8)value.v8_24)
                };
                
                if (default(T).Bits != 32)
                {
                    packed[0] |= packed[1] << (16 * default(T).Bits);
                    packed[1] >>= 512 - (16 * default(T).Bits);
                }

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 32);
            }
            else
            {
                __UInt1024__* packed = stackalloc __UInt1024__[]
                {
                    PackUnpack.DownCast1024<T>((long4)value.v4_0, (long4)value.v4_4, (long4)value.v4_8, (long4)value.v4_12),
                    PackUnpack.DownCast1024<T>((long4)value.v4_16, (long4)value.v4_20, (long4)value.v4_24, (long4)value.v4_28)
                };

                packed[0] |= packed[1] << (16 * default(T).Bits);
                packed[1] >>= 1024 - (16 * default(T).Bits);

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 32);
            }
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUShort2<T>(void* basePtr, int scalarIndex, int length, ushort2 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 1, length);

            if (default(T).Bits == 16)
            {
                *(ushort2*)((ushort*)basePtr + scalarIndex) = value;
                return;
            }

            if (default(T).Bits == 24)
            {
                Store_u16_to24((UInt24*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 40)
            {
                Store_u16_to40((UInt40*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 48)
            {
                Store_u16_to48((UInt48*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 56)
            {
                Store_u16_to56((UInt56*)basePtr + scalarIndex, value);
                return;
            }
            
            if (default(T).Bits <= 16)
            {
                ulong packed = PackUnpack.DownCast<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 2);
            }
            else if (default(T).Bits <= 32)
            {
                ulong packed = PackUnpack.UpCast<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 2);
            }      
            else
            {
                UInt128 packed = PackUnpack.UpCast128<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 2);
            }
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUShort3<T>(void* basePtr, int scalarIndex, int length, ushort3 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 2, length);

            if (default(T).Bits == 16)
            {
                *(ushort3*)((ushort*)basePtr + scalarIndex) = value;
                return;
            }

            if (default(T).Bits == 24)
            {
                Store_u16_to24((UInt24*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 40)
            {
                Store_u16_to40((UInt40*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 48)
            {
                Store_u16_to48((UInt48*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 56)
            {
                Store_u16_to56((UInt56*)basePtr + scalarIndex, value);
                return;
            }
            
            if (default(T).Bits <= 16)
            {
                ulong packed = PackUnpack.DownCast<T>(new ushort4(value, Uninitialized<ushort>.Create()));

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 3);
            }
            else if (default(T).Bits <= 32)
            {
                UInt128 packed = PackUnpack.DownCast128<T>((uint4)new ushort4(value, Uninitialized<ushort>.Create()));

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 3);
            }
            else if (default(T).Bits <= 128 / 3)
            {
                UInt128 lo = PackUnpack.UpCast128<T>(value.xy);
                UInt128 hi = (UInt128)value.z << (2 * default(T).Bits);
                UInt128 packed = lo | hi;

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 3);
            }
            else
            {
                UInt128* packed = stackalloc UInt128[]
                {
                    PackUnpack.UpCast128<T>(value.xy),
                    value.z
                };        
                
                packed[0] |= packed[1] << (2 * default(T).Bits);
                packed[1] >>= 128 - (2 * default(T).Bits);

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 3);
            }
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUShort4<T>(void* basePtr, int scalarIndex, int length, ushort4 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 3, length);

            if (default(T).Bits == 16)
            {
                *(ushort4*)((ushort*)basePtr + scalarIndex) = value;
                return;
            }

            if (default(T).Bits == 24)
            {
                Store_u16_to24((UInt24*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 40)
            {
                Store_u16_to40((UInt40*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 48)
            {
                Store_u16_to48((UInt48*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 56)
            {
                Store_u16_to56((UInt56*)basePtr + scalarIndex, value);
                return;
            }
            
            if (default(T).Bits <= 16)
            {
                ulong packed = PackUnpack.DownCast<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 4);
            }
            else if (default(T).Bits <= 32)
            {
                UInt128 packed = PackUnpack.DownCast128<T>((uint4)value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 4);
            }
            else
            {
                UInt128* packed = stackalloc UInt128[]
                {
                    PackUnpack.UpCast128<T>(value.xy),
                    PackUnpack.UpCast128<T>(value.zw)
                };        
                
                packed[0] |= packed[1] << (2 * default(T).Bits);
                packed[1] >>= 128 - (2 * default(T).Bits);

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 4);
            }
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUShort8<T>(void* basePtr, int scalarIndex, int length, ushort8 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 7, length);

            if (default(T).Bits == 16)
            {
                *(ushort8*)((ushort*)basePtr + scalarIndex) = value;
                return;
            }

            if (default(T).Bits == 24)
            {
                Store_u16_to24((UInt24*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 40)
            {
                Store_u16_to40((UInt40*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 48)
            {
                Store_u16_to48((UInt48*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 56)
            {
                Store_u16_to56((UInt56*)basePtr + scalarIndex, value);
                return;
            }
            
            if (default(T).Bits <= 8)
            {
                ulong packed = PackUnpack.DownCast<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 8);
            }
            else if (default(T).Bits <= 16)
            {
                UInt128 packed = PackUnpack.DownCast128<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 8);
            }
            else if (default(T).Bits <= 32)
            {
                UInt128* packed = stackalloc UInt128[]
                {
                    PackUnpack.UpCast128<T>(value.v4_0),
                    PackUnpack.UpCast128<T>(value.v4_4)
                };

                if (default(T).Bits != 32)
                {
                    packed[0] |= packed[1] << (4 * default(T).Bits);
                    packed[1] >>= 128 - (4 * default(T).Bits);
                }

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 8);
            }
            else
            {
                __UInt256__* packed = stackalloc __UInt256__[]
                {
                    PackUnpack.UpCast256<T>(value.v4_0),
                    PackUnpack.UpCast256<T>(value.v4_4)
                };

                packed[0] |= packed[1] << (4 * default(T).Bits);
                packed[1] >>= 256 - (4 * default(T).Bits);

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 8);
            }
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUShort16<T>(void* basePtr, int scalarIndex, int length, ushort16 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 15, length);

            if (default(T).Bits == 16)
            {
                *(ushort16*)((ushort*)basePtr + scalarIndex) = value;
                return;
            }

            if (default(T).Bits == 24)
            {
                Store_u16_to24((UInt24*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 40)
            {
                Store_u16_to40((UInt40*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 48)
            {
                Store_u16_to48((UInt48*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 56)
            {
                Store_u16_to56((UInt56*)basePtr + scalarIndex, value);
                return;
            }
            
            if (default(T).Bits <= 4)
            {
                ulong packed = PackUnpack.DownCast<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 16);
            }
            else if (default(T).Bits <= 8)
            {
                UInt128 lo = PackUnpack.DownCast128<T>(value.v8_0);
                UInt128 hi = PackUnpack.DownCast128<T>(value.v8_8);

                lo |= hi << (8 * default(T).Bits);

                CopyAscending<T>(&lo, 0, basePtr, scalarIndex, 16);
            }
            else if (default(T).Bits <= 16)
            {
                UInt128* packed = stackalloc UInt128[]
                {
                    PackUnpack.DownCast128<T>(value.v8_0),
                    PackUnpack.DownCast128<T>(value.v8_8)
                };

                if (default(T).Bits != 16)
                {
                    packed[0] |= packed[1] << (8 * default(T).Bits);
                    packed[1] >>= 128 - (8 * default(T).Bits);
                }

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 16);
            }
            else if (default(T).Bits <= 32)
            {
                __UInt256__* packed = stackalloc __UInt256__[]
                {
                    PackUnpack.UpCast256<T>(value.v8_0),
                    PackUnpack.UpCast256<T>(value.v8_8)
                };

                if (default(T).Bits != 32)
                {
                    packed[0] |= packed[1] << (8 * default(T).Bits);
                    packed[1] >>= 256 - (8 * default(T).Bits);
                }

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 16);
            }
            else
            {
                __UInt512__* packed = stackalloc __UInt512__[]
                {
                    PackUnpack.UpCast512<T>(value.v8_0),
                    PackUnpack.UpCast512<T>(value.v8_8)
                };

                packed[0] |= packed[1] << (8 * default(T).Bits);
                packed[1] >>= 512 - (8 * default(T).Bits);

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 16);
            }
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreShort2<T>(void* basePtr, int scalarIndex, int length, short2 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 1, length);

            if (default(T).Bits == 16)
            {
                *(short2*)((short*)basePtr + scalarIndex) = value;
                return;
            }

            if (default(T).Bits == 24)
            {
                Store_i16_to24((UInt24*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 40)
            {
                Store_i16_to40((UInt40*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 48)
            {
                Store_i16_to48((UInt48*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 56)
            {
                Store_i16_to56((UInt56*)basePtr + scalarIndex, value);
                return;
            }
            
            
            if (default(T).Bits <= 16)
            {
                ulong packed = PackUnpack.DownCast<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 2);
            }
            else if (default(T).Bits <= 32)
            {
                ulong packed = PackUnpack.DownCast<T>((int2)value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 2);
            }      
            else
            {
                UInt128 packed = PackUnpack.DownCast128<T>((long2)value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 2);
            }      
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreShort3<T>(void* basePtr, int scalarIndex, int length, short3 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 2, length);

            if (default(T).Bits == 16)
            {
                *(short3*)((short*)basePtr + scalarIndex) = value;
                return;
            }

            if (default(T).Bits == 24)
            {
                Store_i16_to24((UInt24*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 40)
            {
                Store_i16_to40((UInt40*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 48)
            {
                Store_i16_to48((UInt48*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 56)
            {
                Store_i16_to56((UInt56*)basePtr + scalarIndex, value);
                return;
            }
            
            if (default(T).Bits <= 16)
            {
                ulong packed = PackUnpack.DownCast<T>(new short4(value, Uninitialized<short>.Create()));

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 3);
            }
            else if (default(T).Bits <= 32)
            {
                UInt128 packed = PackUnpack.DownCast128<T>((int4)new short4(value, Uninitialized<short>.Create()));

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 3);
            }
            else if (default(T).Bits <= 128 / 3)
            {
                UInt128 lo = PackUnpack.DownCast128<T>((long2)value.xy);
                UInt128 hi = (UInt128)value.z << (2 * default(T).Bits);
                UInt128 packed = lo | hi;

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 3);
            }
            else
            {
                UInt128* packed = stackalloc UInt128[]
                {
                    PackUnpack.DownCast128<T>((long2)value.xy),
                    (UInt128)value.z
                };        
                
                packed[0] |= packed[1] << (2 * default(T).Bits);
                packed[1] >>= 128 - (2 * default(T).Bits);

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 3);
            }
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreShort4<T>(void* basePtr, int scalarIndex, int length, short4 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 3, length);

            if (default(T).Bits == 16)
            {
                *(short4*)((short*)basePtr + scalarIndex) = value;
                return;
            }

            if (default(T).Bits == 24)
            {
                Store_i16_to24((UInt24*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 40)
            {
                Store_i16_to40((UInt40*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 48)
            {
                Store_i16_to48((UInt48*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 56)
            {
                Store_i16_to56((UInt56*)basePtr + scalarIndex, value);
                return;
            }
            
            if (default(T).Bits <= 16)
            {
                ulong packed = PackUnpack.DownCast<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 4);
            }
            else if (default(T).Bits <= 32)
            {
                UInt128 packed = PackUnpack.DownCast128<T>((int4)value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 4);
            }
            else
            {
                UInt128* packed = stackalloc UInt128[]
                {
                    PackUnpack.DownCast128<T>((long2)value.xy),
                    PackUnpack.DownCast128<T>((long2)value.zw)
                };        
                
                packed[0] |= packed[1] << (2 * default(T).Bits);
                packed[1] >>= 128 - (2 * default(T).Bits);

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 4);
            }
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreShort8<T>(void* basePtr, int scalarIndex, int length, short8 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 7, length);

            if (default(T).Bits == 16)
            {
                *(short8*)((short*)basePtr + scalarIndex) = value;
                return;
            }

            if (default(T).Bits == 24)
            {
                Store_i16_to24((UInt24*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 40)
            {
                Store_i16_to40((UInt40*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 48)
            {
                Store_i16_to48((UInt48*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 56)
            {
                Store_i16_to56((UInt56*)basePtr + scalarIndex, value);
                return;
            }
            
            if (default(T).Bits <= 8)
            {
                ulong packed = PackUnpack.DownCast<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 8);
            }
            else if (default(T).Bits <= 16)
            {
                UInt128 packed = PackUnpack.DownCast128<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 8);
            }
            else if (default(T).Bits <= 32)
            {
                UInt128* packed = stackalloc UInt128[]
                {
                    PackUnpack.DownCast128<T>((int4)value.v4_0),
                    PackUnpack.DownCast128<T>((int4)value.v4_4)
                };

                if (default(T).Bits != 32)
                {
                    packed[0] |= packed[1] << (4 * default(T).Bits);
                    packed[1] >>= 128 - (4 * default(T).Bits);
                }

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 8);
            }
            else
            {
                __UInt256__* packed = stackalloc __UInt256__[]
                {
                    PackUnpack.DownCast256<T>((long4)value.v4_0),
                    PackUnpack.DownCast256<T>((long4)value.v4_4)
                };

                packed[0] |= packed[1] << (4 * default(T).Bits);
                packed[1] >>= 256 - (4 * default(T).Bits);

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 8);
            }
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreShort16<T>(void* basePtr, int scalarIndex, int length, short16 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 15, length);

            if (default(T).Bits == 16)
            {
                *(short16*)((short*)basePtr + scalarIndex) = value;
                return;
            }

            if (default(T).Bits == 24)
            {
                Store_i16_to24((UInt24*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 40)
            {
                Store_i16_to40((UInt40*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 48)
            {
                Store_i16_to48((UInt48*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 56)
            {
                Store_i16_to56((UInt56*)basePtr + scalarIndex, value);
                return;
            }
            
            if (default(T).Bits <= 4)
            {
                ulong packed = PackUnpack.DownCast<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 16);
            }
            else if (default(T).Bits <= 8)
            {
                UInt128 lo = PackUnpack.DownCast128<T>(value.v8_0);
                UInt128 hi = PackUnpack.DownCast128<T>(value.v8_8);

                lo |= hi << (8 * default(T).Bits);

                CopyAscending<T>(&lo, 0, basePtr, scalarIndex, 16);
            }
            else if (default(T).Bits <= 16)
            {
                UInt128* packed = stackalloc UInt128[]
                {
                    PackUnpack.DownCast128<T>(value.v8_0),
                    PackUnpack.DownCast128<T>(value.v8_8)
                };

                if (default(T).Bits != 16)
                {
                    packed[0] |= packed[1] << (8 * default(T).Bits);
                    packed[1] >>= 128 - (8 * default(T).Bits);
                }

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 16);
            }
            else if (default(T).Bits <= 32)
            {
                __UInt256__* packed = stackalloc __UInt256__[]
                {
                    PackUnpack.DownCast256<T>((int8)value.v8_0),
                    PackUnpack.DownCast256<T>((int8)value.v8_8)
                };

                if (default(T).Bits != 32)
                {
                    packed[0] |= packed[1] << (8 * default(T).Bits);
                    packed[1] >>= 256 - (8 * default(T).Bits);
                }

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 16);
            }
            else
            {
                __UInt512__* packed = stackalloc __UInt512__[]
                {
                    PackUnpack.DownCast512<T>((long4)value.v4_0, (long4)value.v4_4),
                    PackUnpack.DownCast512<T>((long4)value.v4_8, (long4)value.v4_12)
                };

                packed[0] |= packed[1] << (8 * default(T).Bits);
                packed[1] >>= 512 - (8 * default(T).Bits);

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 16);
            }
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUInt2<T>(void* basePtr, int scalarIndex, int length, uint2 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 1, length);

            if (default(T).Bits == 32)
            {
                *(uint2*)((uint*)basePtr + scalarIndex) = value;
                return;
            }

            if (default(T).Bits == 24)
            {
                Store_u32_to24((UInt24*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 40)
            {
                Store_u32_to40((UInt40*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 48)
            {
                Store_u32_to48((UInt48*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 56)
            {
                Store_u32_to56((UInt56*)basePtr + scalarIndex, value);
                return;
            }
            
            if (default(T).Bits <= 32)
            {
                ulong packed = PackUnpack.DownCast<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 2);
            }
            else
            {
                UInt128 packed = PackUnpack.UpCast128<T>(value);
                
                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 2);
            }
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUInt3<T>(void* basePtr, int scalarIndex, int length, uint3 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 2, length);

            if (default(T).Bits == 32)
            {
                *(uint3*)((uint*)basePtr + scalarIndex) = value;
                return;
            }

            if (default(T).Bits == 24)
            {
                Store_u32_to24((UInt24*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 40)
            {
                Store_u32_to40((UInt40*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 48)
            {
                Store_u32_to48((UInt48*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 56)
            {
                Store_u32_to56((UInt56*)basePtr + scalarIndex, value);
                return;
            }
            
            if (default(T).Bits <= 16)
            {
                ulong packed = PackUnpack.DownCast<T>(new uint4(value, Uninitialized<uint>.Create()));

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 3);
            }
            else if (default(T).Bits <= 32)
            {
                UInt128 packed = PackUnpack.DownCast128<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 3);
            }
            else if (default(T).Bits <= 128 / 3)
            {
                UInt128 packed = PackUnpack.UpCast128<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 3);
            }
            else
            {
                UInt128* packed = stackalloc UInt128[2];

                UInt128 lo = PackUnpack.UpCast128<T>(value.xy);
                UInt128 hi = (UInt128)value.z;
                packed[0] = lo | (hi << (2 * default(T).Bits));
                packed[1] = hi >> (128 - (2 * default(T).Bits));

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 3);
            }
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUInt4<T>(void* basePtr, int scalarIndex, int length, uint4 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 3, length);

            if (default(T).Bits == 32)
            {
                *(uint4*)((uint*)basePtr + scalarIndex) = value;
                return;
            }

            if (default(T).Bits == 24)
            {
                Store_u32_to24((UInt24*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 40)
            {
                Store_u32_to40((UInt40*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 48)
            {
                Store_u32_to48((UInt48*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 56)
            {
                Store_u32_to56((UInt56*)basePtr + scalarIndex, value);
                return;
            }
            
            if (default(T).Bits <= 16)
            {
                ulong packed = PackUnpack.DownCast<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 4);
            }
            else if (default(T).Bits <= 32)
            {
                UInt128 packed = PackUnpack.DownCast128<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 4);
            }
            else
            {
                UInt128* packed = stackalloc UInt128[2];

                UInt128 lo = PackUnpack.UpCast128<T>(value.xy);
                UInt128 hi = PackUnpack.UpCast128<T>(value.zw);
                packed[0] = lo | (hi << (2 * default(T).Bits));
                packed[1] = hi >> (128 - (2 * default(T).Bits));

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 4);
            }
        }

        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreUInt8<T>(void* basePtr, int scalarIndex, int length, uint8 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 7, length);

            if (default(T).Bits == 32)
            {
                *(uint8*)((uint*)basePtr + scalarIndex) = value;
                return;
            }

            if (default(T).Bits == 24)
            {
                Store_u32_to24((UInt24*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 40)
            {
                Store_u32_to40((UInt40*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 48)
            {
                Store_u32_to48((UInt48*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 56)
            {
                Store_u32_to56((UInt56*)basePtr + scalarIndex, value);
                return;
            }
            
            if (default(T).Bits <= 8)
            {
                ulong packed = PackUnpack.DownCast<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 8);
            }
            else if (default(T).Bits <= 16)
            {
                ulong* packed = stackalloc ulong[]
                {
                    PackUnpack.DownCast<T>(value.v4_0),
                    PackUnpack.DownCast<T>(value.v4_4)
                };
                
                if (default(T).Bits != 16)
                {
                    packed[0] |= packed[1] << (4 * default(T).Bits);
                    packed[1] >>= 64 - (4 * default(T).Bits);
                }                

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 8);
            }
            else if (default(T).Bits <= 32)
            {
                UInt128* packed = stackalloc UInt128[]
                {
                    PackUnpack.DownCast128<T>(value.v4_0),
                    PackUnpack.DownCast128<T>(value.v4_4)
                };

                if (default(T).Bits != 32)
                {
                    packed[0] |= packed[1] << (4 * default(T).Bits);
                    packed[1] >>= 128 - (4 * default(T).Bits);
                }               

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 8);
            }
            else
            {
                __UInt256__* packed = stackalloc __UInt256__[]
                {
                    PackUnpack.DownCast256<T>((ulong4)value.v4_0),
                    PackUnpack.DownCast256<T>((ulong4)value.v4_4),
                };
                
                packed[0] |= packed[1] << (4 * default(T).Bits);
                packed[1] >>= 256 - (4 * default(T).Bits);
                
                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 8);
            }
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreInt2<T>(void* basePtr, int scalarIndex, int length, int2 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 1, length);

            if (default(T).Bits == 32)
            {
                *(int2*)((int*)basePtr + scalarIndex) = value;
                return;
            }

            if (default(T).Bits == 24)
            {
                Store_i32_to24((UInt24*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 40)
            {
                Store_i32_to40((UInt40*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 48)
            {
                Store_i32_to48((UInt48*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 56)
            {
                Store_i32_to56((UInt56*)basePtr + scalarIndex, value);
                return;
            }
            
            if (default(T).Bits <= 32)
            {
                ulong packed = PackUnpack.DownCast<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 2);
            }
            else
            { 
                UInt128 packed = PackUnpack.DownCast128<T>((long2)value);
                
                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 2);
            }
        }

        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreInt3<T>(void* basePtr, int scalarIndex, int length, int3 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 2, length);

            if (default(T).Bits == 32)
            {
                *(int3*)((int*)basePtr + scalarIndex) = value;
                return;
            }

            if (default(T).Bits == 24)
            {
                Store_i32_to24((UInt24*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 40)
            {
                Store_i32_to40((UInt40*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 48)
            {
                Store_i32_to48((UInt48*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 56)
            {
                Store_i32_to56((UInt56*)basePtr + scalarIndex, value);
                return;
            }
            
            if (default(T).Bits <= 16)
            {
                ulong packed = PackUnpack.DownCast<T>(new int4(value, Uninitialized<int>.Create()));

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 3);
            }
            else if (default(T).Bits <= 32)
            {
                UInt128 packed = PackUnpack.DownCast128<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 3);
            }
            else if (default(T).Bits <= 128 / 3)
            {
                UInt128 lo = PackUnpack.DownCast128<T>((long2)value.xy);
                UInt128 hi = (UInt128)(Int128)value.z << (2 * default(T).Bits);
                UInt128 packed = lo | hi;

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 3);
            }
            else
            {
                UInt128* packed = stackalloc UInt128[2];

                UInt128 lo = PackUnpack.DownCast128<T>((long2)value.xy);
                UInt128 hi = (UInt128)(Int128)value.z;
                packed[0] = lo | (hi << (2 * default(T).Bits));
                packed[1] = hi >> (128 - (2 * default(T).Bits));

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 3);
            }
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreInt4<T>(void* basePtr, int scalarIndex, int length, int4 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 3, length);

            if (default(T).Bits == 32)
            {
                *(int4*)((int*)basePtr + scalarIndex) = value;
                return;
            }

            if (default(T).Bits == 24)
            {
                Store_i32_to24((UInt24*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 40)
            {
                Store_i32_to40((UInt40*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 48)
            {
                Store_i32_to48((UInt48*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 56)
            {
                Store_i32_to56((UInt56*)basePtr + scalarIndex, value);
                return;
            }
            
            if (default(T).Bits <= 16)
            {
                ulong packed = PackUnpack.DownCast<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 4);
            }
            else if (default(T).Bits <= 32)
            {
                UInt128 lo = PackUnpack.DownCast128<T>((long2)value.xy);
                UInt128 hi = PackUnpack.DownCast128<T>((long2)value.zw);
                UInt128 packed = lo | (hi << (2 * default(T).Bits));

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 4);
            }
            else
            {
                UInt128* packed = stackalloc UInt128[2];

                UInt128 lo = PackUnpack.DownCast128<T>((long2)value.xy);
                UInt128 hi = PackUnpack.DownCast128<T>((long2)value.zw);
                packed[0] = lo | (hi << (2 * default(T).Bits));
                packed[1] = hi >> (128 - (2 * default(T).Bits));

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 4);
            }
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreInt8<T>(void* basePtr, int scalarIndex, int length, int8 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 7, length);

            if (default(T).Bits == 32)
            {
                *(int8*)((int*)basePtr + scalarIndex) = value;
                return;
            }

            if (default(T).Bits == 24)
            {
                Store_i32_to24((UInt24*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 40)
            {
                Store_i32_to40((UInt40*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 48)
            {
                Store_i32_to48((UInt48*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 56)
            {
                Store_i32_to56((UInt56*)basePtr + scalarIndex, value);
                return;
            }

            
            if (default(T).Bits <= 8)
            {
                ulong packed = PackUnpack.DownCast<T>(value);

                CopyAscending<T>(&packed, 0, basePtr, scalarIndex, 8);
            }
            else if (default(T).Bits <= 16)
            {
                ulong* packed = stackalloc ulong[]
                {
                    PackUnpack.DownCast<T>(value.v4_0),
                    PackUnpack.DownCast<T>(value.v4_4)
                };

                if (default(T).Bits != 16)
                {
                    packed[0] |= packed[1] << (4 * default(T).Bits);
                    packed[1] >>= 64 - (4 * default(T).Bits);
                }                

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 8);
            }
            else if (default(T).Bits <= 32)
            {
                UInt128* packed = stackalloc UInt128[]
                {
                    PackUnpack.DownCast128<T>(value.v4_0),
                    PackUnpack.DownCast128<T>(value.v4_4)
                };

                if (default(T).Bits != 32)
                {
                    packed[0] |= packed[1] << (4 * default(T).Bits);
                    packed[1] >>= 128 - (4 * default(T).Bits);
                }                

                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 8);
            }
            else
            {
                __UInt256__* packed = stackalloc __UInt256__[]
                {
                    PackUnpack.DownCast256<T>((ulong4)value.v4_0),
                    PackUnpack.DownCast256<T>((ulong4)value.v4_4),
                };
                
                packed[0] |= packed[1] << (4 * default(T).Bits);
                packed[1] >>= 256 - (4 * default(T).Bits);
                
                CopyAscending<T>(packed, 0, basePtr, scalarIndex, 8);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreULong2<T>(void* basePtr, int scalarIndex, int length, ulong2 value)
            where T: BitInt
        {
            StoreLong2<T>(basePtr, scalarIndex, length, (long2)value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreULong3<T>(void* basePtr, int scalarIndex, int length, ulong3 value)
            where T: BitInt
        {
            StoreLong3<T>(basePtr, scalarIndex, length, (long3)value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreULong4<T>(void* basePtr, int scalarIndex, int length, ulong4 value)
            where T: BitInt
        {
            StoreLong4<T>(basePtr, scalarIndex, length, (long4)value);
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreLong2<T>(void* basePtr, int scalarIndex, int length, long2 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 1, length);
            
            if (default(T).Bits == 64)
            {
                *(long2*)((long*)basePtr + scalarIndex) = value;
                return;
            }

            if (default(T).Bits == 24)
            {
                Store_i64_to24((UInt24*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 40)
            {
                Store_i64_to40((UInt40*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 48)
            {
                Store_i64_to48((UInt48*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 56)
            {
                Store_i64_to56((UInt56*)basePtr + scalarIndex, value);
                return;
            }

            
            void* packed;

            if (default(T).Bits <= 32)
            {
                ulong packed64 = PackUnpack.DownCast<T>(value);
                packed = &packed64;
            }
            else
            {
                UInt128 packed128 = PackUnpack.DownCast128<T>(value);
                packed = &packed128;
            }
                
            CopyAscending<T>(packed, 0, basePtr, scalarIndex, 2);
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreLong3<T>(void* basePtr, int scalarIndex, int length, long3 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 2, length);
            
            if (default(T).Bits == 64)
            {
                *(long3*)((long*)basePtr + scalarIndex) = value;
                return;
            }

            if (default(T).Bits == 24)
            {
                Store_i64_to24((UInt24*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 40)
            {
                Store_i64_to40((UInt40*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 48)
            {
                Store_i64_to48((UInt48*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 56)
            {
                Store_i64_to56((UInt56*)basePtr + scalarIndex, value);
                return;
            }
            
            void* packed;
            
            if (default(T).Bits <= 16)
            {
                ulong packed64 = PackUnpack.DownCast<T>(new long4(value, Uninitialized<long>.Create()));
                packed = &packed64;
            }
            else if (default(T).Bits <= 32)
            {
                ulong* packed64 = stackalloc ulong[]
                {
                    PackUnpack.DownCast<T>(value.xy),
                    (ulong)value.z
                };

                if (default(T).Bits != 32)
                {
                    packed64[0] |= packed64[1] << (2 * default(T).Bits);
                    packed64[1] >>= 64 - (2 * default(T).Bits);
                }                

                packed = packed64;
            }
            else
            {
                UInt128* packed128 = stackalloc UInt128[]
                {
                    PackUnpack.DownCast128<T>(value.xy),
                    (UInt128)value.z
                };

                if (default(T).Bits != 32)
                {
                    packed128[0] |= packed128[1] << (2 * default(T).Bits);
                    packed128[1] >>= 128 - (2 * default(T).Bits);
                }              
                
                packed = packed128;
            }

            CopyAscending<T>(packed, 0, basePtr, scalarIndex, 3);
        }
        
        [SkipLocalsInit]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void StoreLong4<T>(void* basePtr, int scalarIndex, int length, long4 value)
            where T: BitInt
        {
Assert.IsWithinArrayBounds(scalarIndex, length);
Assert.IsWithinArrayBounds(scalarIndex + 3, length);
            
            if (default(T).Bits == 64)
            {
                *(long4*)((long*)basePtr + scalarIndex) = value;
                return;
            }

            if (default(T).Bits == 24)
            {
                Store_i64_to24((UInt24*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 40)
            {
                Store_i64_to40((UInt40*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 48)
            {
                Store_i64_to48((UInt48*)basePtr + scalarIndex, value);
                return;
            }
            if (default(T).Bits == 56)
            {
                Store_i64_to56((UInt56*)basePtr + scalarIndex, value);
                return;
            }

            void* packed;

            if (default(T).Bits <= 16)
            {
                ulong packed64 = PackUnpack.DownCast<T>(value);
                packed = &packed64;
            }
            else if (default(T).Bits <= 32)
            {
                ulong* packed64 = stackalloc ulong[]
                {
                    PackUnpack.DownCast<T>(value.xy),
                    PackUnpack.DownCast<T>(value.zw)
                };

                if (default(T).Bits != 32)
                {
                    packed64[0] |= packed64[1] << (2 * default(T).Bits);
                    packed64[1] >>= 64 - (2 * default(T).Bits);
                }                

                packed = packed64;
            }
            else
            {
                UInt128* packed128 = stackalloc UInt128[]
                {
                    PackUnpack.DownCast128<T>(value.xy),
                    PackUnpack.DownCast128<T>(value.zw)
                };

                if (default(T).Bits != 32)
                {
                    packed128[0] |= packed128[1] << (2 * default(T).Bits);
                    packed128[1] >>= 128 - (2 * default(T).Bits);
                }              
                
                packed = packed128;
            }
                
            CopyAscending<T>(packed, 0, basePtr, scalarIndex, 4);
        }
    }
}
