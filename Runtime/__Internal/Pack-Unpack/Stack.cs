using System;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using DevTools;
using MaxMath;
using MaxMath.Intrinsics;

using static MaxMath.maxmath;

namespace BitCollections
{
    unsafe internal static partial class PackUnpack
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong ArrayCastMask<TFrom, TTo>()
			where TFrom : BitInt
			where TTo   : BitInt
		{
Assert.IsNotSmaller(default(TTo).Bits, default(TFrom).Bits);

			return BitFieldHelper.Replicate<TTo>(bitmask64((ulong)default(TFrom).Bits));
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static UInt128 ArrayCastMask128<TFrom, TTo>()
			where TFrom : BitInt
			where TTo   : BitInt
		{
Assert.IsNotSmaller(default(TTo).Bits, default(TFrom).Bits);
			
			return BitFieldHelper.Replicate<TTo>((UInt128)bitmask64((ulong)default(TFrom).Bits));
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt256__ ArrayCastMask256<TFrom, TTo>()
			where TFrom : BitInt
			where TTo   : BitInt
		{
Assert.IsNotSmaller(default(TTo).Bits, default(TFrom).Bits);
			
			return BitFieldHelper.Replicate<TTo>((__UInt256__)bitmask64((ulong)default(TFrom).Bits));
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt512__ ArrayCastMask512<TFrom, TTo>()
			where TFrom : BitInt
			where TTo   : BitInt
		{
Assert.IsNotSmaller(default(TTo).Bits, default(TFrom).Bits);
			
			return BitFieldHelper.Replicate<TTo>((__UInt512__)bitmask64((ulong)default(TFrom).Bits));
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt1024__ ArrayCastMask1024<TFrom, TTo>()
			where TFrom : BitInt
			where TTo   : BitInt
		{
Assert.IsNotSmaller(default(TTo).Bits, default(TFrom).Bits);
			
			return BitFieldHelper.Replicate<TTo>((__UInt1024__)bitmask64((ulong)default(TFrom).Bits));
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt2048__ ArrayCastMask2048<TFrom, TTo>()
			where TFrom : BitInt
			where TTo   : BitInt
		{
Assert.IsNotSmaller(default(TTo).Bits, default(TFrom).Bits);
			
			return BitFieldHelper.Replicate<TTo>((__UInt2048__)bitmask64((ulong)default(TFrom).Bits));
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt4096__ ArrayCastMask4096<TFrom, TTo>()
			where TFrom : BitInt
			where TTo   : BitInt
		{
Assert.IsNotSmaller(default(TTo).Bits, default(TFrom).Bits);
			
			return BitFieldHelper.Replicate<TTo>((__UInt4096__)bitmask64((ulong)default(TFrom).Bits));
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte UpCast8<TFrom, TTo>(byte array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return bits_depositparallel(array, (byte)ArrayCastMask<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ushort UpCast16<TFrom, TTo>(byte array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return bits_depositparallel(array, (ushort)ArrayCastMask<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint UpCast32<TFrom, TTo>(byte array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return bits_depositparallel(array, (uint)ArrayCastMask<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong UpCast64<TFrom, TTo>(byte array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return bits_depositparallel(array, ArrayCastMask<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static UInt128 UpCast128<TFrom, TTo>(byte array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return bits_depositparallel(array, ArrayCastMask128<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt256__ UpCast256<TFrom, TTo>(byte array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt256__.bits_depositparallel(array, ArrayCastMask256<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt512__ UpCast512<TFrom, TTo>(byte array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt512__.bits_depositparallel(array, ArrayCastMask512<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt1024__ UpCast1024<TFrom, TTo>(byte array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt1024__.bits_depositparallel(array, ArrayCastMask1024<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt2048__ UpCast2048<TFrom, TTo>(byte array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt2048__.bits_depositparallel(array, ArrayCastMask2048<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt4096__ UpCast4096<TFrom, TTo>(byte array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt4096__.bits_depositparallel(array, ArrayCastMask4096<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ushort UpCast16<TFrom, TTo>(ushort array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return bits_depositparallel(array, (ushort)ArrayCastMask<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint UpCast32<TFrom, TTo>(ushort array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return bits_depositparallel(array, (uint)ArrayCastMask<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong UpCast64<TFrom, TTo>(ushort array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return bits_depositparallel(array, ArrayCastMask<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static UInt128 UpCast128<TFrom, TTo>(ushort array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return bits_depositparallel(array, ArrayCastMask128<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt256__ UpCast256<TFrom, TTo>(ushort array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt256__.bits_depositparallel(array, ArrayCastMask256<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt512__ UpCast512<TFrom, TTo>(ushort array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt512__.bits_depositparallel(array, ArrayCastMask512<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt1024__ UpCast1024<TFrom, TTo>(ushort array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt1024__.bits_depositparallel(array, ArrayCastMask1024<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt2048__ UpCast2048<TFrom, TTo>(ushort array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt2048__.bits_depositparallel(array, ArrayCastMask2048<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt4096__ UpCast4096<TFrom, TTo>(ushort array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt4096__.bits_depositparallel(array, ArrayCastMask4096<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint UpCast32<TFrom, TTo>(uint array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return bits_depositparallel(array, (uint)ArrayCastMask<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong UpCast64<TFrom, TTo>(uint array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return bits_depositparallel(array, ArrayCastMask<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static UInt128 UpCast128<TFrom, TTo>(uint array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return bits_depositparallel(array, ArrayCastMask128<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt256__ UpCast256<TFrom, TTo>(uint array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt256__.bits_depositparallel(array, ArrayCastMask256<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt512__ UpCast512<TFrom, TTo>(uint array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt512__.bits_depositparallel(array, ArrayCastMask512<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt1024__ UpCast1024<TFrom, TTo>(uint array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt1024__.bits_depositparallel(array, ArrayCastMask1024<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt2048__ UpCast2048<TFrom, TTo>(uint array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt2048__.bits_depositparallel(array, ArrayCastMask2048<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt4096__ UpCast4096<TFrom, TTo>(uint array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt4096__.bits_depositparallel(array, ArrayCastMask4096<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong UpCast64<TFrom, TTo>(ulong array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return bits_depositparallel(array, ArrayCastMask<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static UInt128 UpCast128<TFrom, TTo>(ulong array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return bits_depositparallel(array, ArrayCastMask128<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt256__ UpCast256<TFrom, TTo>(ulong array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt256__.bits_depositparallel(array, ArrayCastMask256<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt512__ UpCast512<TFrom, TTo>(ulong array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt512__.bits_depositparallel(array, ArrayCastMask512<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt1024__ UpCast1024<TFrom, TTo>(ulong array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt1024__.bits_depositparallel(array, ArrayCastMask1024<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt2048__ UpCast2048<TFrom, TTo>(ulong array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt2048__.bits_depositparallel(array, ArrayCastMask2048<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt4096__ UpCast4096<TFrom, TTo>(ulong array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt4096__.bits_depositparallel(array, ArrayCastMask4096<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static UInt128 UpCast128<TFrom, TTo>(UInt128 array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return bits_depositparallel(array, ArrayCastMask128<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt256__ UpCast256<TFrom, TTo>(UInt128 array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt256__.bits_depositparallel(array, ArrayCastMask256<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt512__ UpCast512<TFrom, TTo>(UInt128 array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt512__.bits_depositparallel(array, ArrayCastMask512<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt1024__ UpCast1024<TFrom, TTo>(UInt128 array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt1024__.bits_depositparallel(array, ArrayCastMask1024<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt2048__ UpCast2048<TFrom, TTo>(UInt128 array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt2048__.bits_depositparallel(array, ArrayCastMask2048<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt4096__ UpCast4096<TFrom, TTo>(UInt128 array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt4096__.bits_depositparallel(array, ArrayCastMask4096<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt256__ UpCast256<TFrom, TTo>(__UInt256__ array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt256__.bits_depositparallel(array, ArrayCastMask256<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt512__ UpCast512<TFrom, TTo>(__UInt256__ array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt512__.bits_depositparallel(array, ArrayCastMask512<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt1024__ UpCast1024<TFrom, TTo>(__UInt256__ array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt1024__.bits_depositparallel(array, ArrayCastMask1024<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt2048__ UpCast2048<TFrom, TTo>(__UInt256__ array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt2048__.bits_depositparallel(array, ArrayCastMask2048<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt4096__ UpCast4096<TFrom, TTo>(__UInt256__ array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt4096__.bits_depositparallel(array, ArrayCastMask4096<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt512__ UpCast512<TFrom, TTo>(__UInt512__ array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt512__.bits_depositparallel(array, ArrayCastMask512<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt1024__ UpCast1024<TFrom, TTo>(__UInt512__ array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt1024__.bits_depositparallel(array, ArrayCastMask1024<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt2048__ UpCast2048<TFrom, TTo>(__UInt512__ array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt2048__.bits_depositparallel(array, ArrayCastMask2048<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt4096__ UpCast4096<TFrom, TTo>(__UInt512__ array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt4096__.bits_depositparallel(array, ArrayCastMask4096<TFrom, TTo>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt512__ DownCast<TFrom, TTo>(__UInt512__ array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt512__.bits_extractparallel(array, ArrayCastMask512<TTo, TFrom>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt1024__ DownCast<TFrom, TTo>(__UInt1024__ array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt1024__.bits_extractparallel(array, ArrayCastMask1024<TTo, TFrom>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt2048__ DownCast<TFrom, TTo>(__UInt2048__ array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt2048__.bits_extractparallel(array, ArrayCastMask2048<TTo, TFrom>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt4096__ DownCast<TFrom, TTo>(__UInt4096__ array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt4096__.bits_extractparallel(array, ArrayCastMask4096<TTo, TFrom>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt256__ DownCast<TFrom, TTo>(__UInt256__ array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return __UInt256__.bits_extractparallel(array, ArrayCastMask256<TTo, TFrom>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static UInt128 DownCast<TFrom, TTo>(UInt128 array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return bits_extractparallel(array, ArrayCastMask128<TTo, TFrom>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong DownCast<TFrom, TTo>(ulong array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return bits_extractparallel(array, ArrayCastMask<TTo, TFrom>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint DownCast<TFrom, TTo>(uint array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return bits_extractparallel(array, (uint)ArrayCastMask<TTo, TFrom>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ushort DownCast<TFrom, TTo>(ushort array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return bits_extractparallel(array, (ushort)ArrayCastMask<TTo, TFrom>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte DownCast<TFrom, TTo>(byte array)
			where TFrom : BitInt
			where TTo   : BitInt
		{
			return bits_extractparallel(array, (byte)ArrayCastMask<TTo, TFrom>());
		}


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte2 BitIntArrayToByte2<T>(ushort array)
			where T : BitInt
		{
            return bits_depositparallel(array, (ushort)ArrayCastMask<T, UInt8>()).Reinterpret<ushort, byte2>();
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte4 BitIntArrayToByte4<T>(uint array)
			where T : BitInt
		{
            return bits_depositparallel(array, (uint)ArrayCastMask<T, UInt8>()).Reinterpret<uint, byte4>();
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte8 BitIntArrayToByte8<T>(ulong array)
			where T : BitInt
		{
            return bits_depositparallel(array, ArrayCastMask<T, UInt8>()).Reinterpret<ulong, byte8>();
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte16 BitIntArrayToByte16<T>(ulong array)
			where T : BitInt
		{
			return bits_depositparallel((UInt128)array, ArrayCastMask128<T, UInt8>()).Reinterpret<UInt128, byte16>();
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte32 BitIntArrayToByte32<T>(ulong array)
			where T : BitInt
		{
			return __UInt256__.bits_depositparallel(array, ArrayCastMask256<T, UInt8>()).Reinterpret<__UInt256__, byte32>();
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ushort2 BitIntArrayToUShort2<T>(uint array)
			where T : BitInt
		{
            return bits_depositparallel(array, (uint)ArrayCastMask<T, UInt16>()).Reinterpret<uint, ushort2>();
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ushort4 BitIntArrayToUShort4<T>(ulong array)
			where T : BitInt
		{
            return bits_depositparallel(array, ArrayCastMask<T, UInt16>()).Reinterpret<ulong, ushort4>();
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint8 BitIntArrayToUShort8<T>(ushort array)
			where T : BitInt
		{
			return bitmask16((uint)default(T).Bits) & shrl(array, default(T).Bits * new ushort8(0, 1, 2, 3, 4, 5, 6, 7));
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ushort8 BitIntArrayToUShort8<T>(ulong array)
			where T : BitInt
		{
			if (default(T).Bits <= 8)
			{
				return BitIntArrayToByte8<T>(array);
			}
			else
			{
				return bits_depositparallel((UInt128)array, ArrayCastMask128<T, UInt16>()).Reinterpret<UInt128, ushort8>();
			}
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint2 BitIntArrayToUInt2<T>(ulong array)
			where T : BitInt
		{
            return bits_depositparallel(array, ArrayCastMask<T, UInt32>()).Reinterpret<ulong, uint2>();
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint4 BitIntArrayToUInt4<T>(uint array)
			where T : BitInt
		{
			if (BurstArchitecture.IsVectorShiftSupported)
			{
				return bitmask32((uint)default(T).Bits) & shrl(array, default(T).Bits * new uint4(0, 1, 2, 3));
			}
			else
			{
				return BitIntArrayToUShort4<T>(array);
			}
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint4 BitIntArrayToUInt4<T>(ulong array)
			where T : BitInt
		{
            return bits_depositparallel((UInt128)array, ArrayCastMask128<T, UInt32>()).Reinterpret<UInt128, uint4>();
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint8 BitIntArrayToUInt8<T>(uint array)
			where T : BitInt
		{
			return bitmask32((uint)default(T).Bits) & shrl(array, default(T).Bits * new uint8(0, 1, 2, 3, 4, 5, 6, 7));
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint8 BitIntArrayToUInt8<T>(ulong array)
			where T : BitInt
		{
			if (default(T).Bits <= 8)
			{
				return BitIntArrayToByte8<T>(array);
			}
			else
			{
				return __UInt256__.bits_depositparallel(array, ArrayCastMask256<T, UInt32>()).Reinterpret<__UInt256__, uint8>();
			}
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong2 BitIntArrayToULong2<T>(ulong array)
			where T : BitInt
		{
            return new ulong2(array & bitmask64((ulong)default(T).Bits), array >> default(T).Bits);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong4 BitIntArrayToULong4<T>(ulong array)
			where T : BitInt
		{
			if (BurstArchitecture.IsVectorShiftSupported)
			{
				return bitmask64((ulong)default(T).Bits) & shrl(array, (ulong)default(T).Bits * new ulong4(0, 1, 2, 3));
			}
			else
			{
				return BitIntArrayToUShort4<T>(array);
			}
		}


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong DownCast<T>(byte32 array)
			where T : BitInt
		{
			return (ulong)__UInt256__.bits_extractparallel(array.Reinterpret<byte32, __UInt256__>(), ArrayCastMask256<T, UInt8>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong DownCast<T>(byte16 array)
			where T : BitInt
		{
			return (ulong)bits_extractparallel(array.Reinterpret<byte16, UInt128>(), ArrayCastMask128<T, UInt8>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong DownCast<T>(byte8 array)
			where T : BitInt
		{
            return bits_extractparallel(array.Reinterpret<byte8, ulong>(), ArrayCastMask<T, UInt8>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong DownCast<T>(byte4 array)
			where T : BitInt
		{
            return bits_extractparallel(array.Reinterpret<byte4, uint>(), (uint)ArrayCastMask<T, UInt8>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint DownCast<T>(byte2 array)
			where T : BitInt
		{
            return bits_extractparallel(array.Reinterpret<byte2, ushort>(), (ushort)ArrayCastMask<T, UInt8>());
		}


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong DownCast<T>(sbyte32 array)
			where T : BitInt
		{
			return DownCast<T>((byte32)array);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong DownCast<T>(sbyte16 array)
			where T : BitInt
		{
			return DownCast<T>((byte16)array);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong DownCast<T>(sbyte8 array)
			where T : BitInt
		{
			return DownCast<T>((byte8)array);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong DownCast<T>(sbyte4 array)
			where T : BitInt
		{
			return DownCast<T>((byte4)array);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint DownCast<T>(sbyte2 array)
			where T : BitInt
		{
			return DownCast<T>((byte2)array);
		}
		

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong DownCast<T>(ushort16 array)
			where T : BitInt
		{
			return (ulong)__UInt256__.bits_extractparallel(array.Reinterpret<ushort16, __UInt256__>(), ArrayCastMask256<T, UInt16>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong DownCast<T>(ushort8 array)
			where T : BitInt
		{
			return (ulong)bits_extractparallel(array.Reinterpret<ushort8, UInt128>(), ArrayCastMask128<T, UInt16>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong DownCast<T>(ushort4 array)
			where T : BitInt
		{
            return bits_extractparallel(array.Reinterpret<ushort4, ulong>(), ArrayCastMask<T, UInt16>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint DownCast<T>(ushort2 array)
			where T : BitInt
		{
            return bits_extractparallel(array.Reinterpret<ushort2, uint>(), (uint)ArrayCastMask<T, UInt16>());
		}
		

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong DownCast<T>(short16 array)
			where T : BitInt
		{
			return DownCast<T>((ushort16)array);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong DownCast<T>(short8 array)
			where T : BitInt
		{
			return DownCast<T>((ushort8)array);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong DownCast<T>(short4 array)
			where T : BitInt
		{
			return DownCast<T>((ushort4)array);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong DownCast<T>(short2 array)
			where T : BitInt
		{
			return DownCast<T>((ushort2)array);
		}

		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong DownCast<T>(uint8 array)
			where T : BitInt
		{
			return (ulong)__UInt256__.bits_extractparallel(array.Reinterpret<uint8, __UInt256__>(), ArrayCastMask256<T, UInt32>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static UInt128 DownCast128<T>(uint3 array)
			where T : BitInt
		{
			uint4 cvt = Uninitialized<uint4>.Create();
			cvt.xyz = array;

			return bits_extractparallel(cvt.Reinterpret<uint4, UInt128>(), ArrayCastMask128<T, UInt32>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong DownCast<T>(uint4 array)
			where T : BitInt
		{
			return (ulong)bits_extractparallel(array.Reinterpret<uint4, UInt128>(), ArrayCastMask128<T, UInt32>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static UInt128 DownCast128<T>(uint4 array)
			where T : BitInt
		{
            return bits_extractparallel(array.Reinterpret<uint4, UInt128>(), ArrayCastMask128<T, UInt32>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong DownCast<T>(uint2 array)
			where T : BitInt
		{
            return bits_extractparallel(array.Reinterpret<uint2, ulong>(), ArrayCastMask<T, UInt32>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static UInt128 DownCast128<T>(byte16 array)
			where T : BitInt
		{
            return bits_extractparallel(array.Reinterpret<byte16, UInt128>(), ArrayCastMask128<T, UInt8>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static UInt128 DownCast128<T>(sbyte16 array)
			where T : BitInt
		{
            return DownCast128<T>((byte16)array);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static UInt128 DownCast128<T>(ushort8 array)
			where T : BitInt
		{
            return bits_extractparallel(array.Reinterpret<ushort8, UInt128>(), ArrayCastMask128<T, UInt16>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static UInt128 DownCast128<T>(short8 array)
			where T : BitInt
		{
            return DownCast128<T>((ushort8)array);
		}


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong UpCast<T>(byte2 array)
			where T : BitInt
		{
            return bits_depositparallel(array.Reinterpret<byte2, ushort>(), ArrayCastMask<UInt8, T>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong UpCast<T>(byte4 array)
			where T : BitInt
		{
            return bits_depositparallel(array.Reinterpret<byte4, uint>(), ArrayCastMask<UInt8, T>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong UpCast<T>(ushort2 array)
			where T : BitInt
		{
            return bits_depositparallel(array.Reinterpret<ushort2, uint>(), ArrayCastMask<UInt16, T>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static UInt128 UpCast128<T>(ushort2 array)
			where T : BitInt
		{
            return bits_depositparallel(array.Reinterpret<ushort2, uint>(), ArrayCastMask128<UInt16, T>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static UInt128 UpCast128<T>(byte2 array)
			where T : BitInt
		{
            return bits_depositparallel(array.Reinterpret<byte2, ushort>(), ArrayCastMask128<UInt8, T>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static UInt128 UpCast128<T>(byte4 array)
			where T : BitInt
		{
            return bits_depositparallel(array.Reinterpret<byte4, uint>(), ArrayCastMask128<UInt8, T>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static UInt128 UpCast128<T>(ushort4 array)
			where T : BitInt
		{
            return bits_depositparallel(array.Reinterpret<ushort4, ulong>(), ArrayCastMask128<UInt16, T>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static UInt128 UpCast128<T>(byte8 array)
			where T : BitInt
		{
            return bits_depositparallel(array.Reinterpret<byte8, ulong>(), ArrayCastMask128<UInt8, T>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt256__ UpCast256<T>(byte4 array)
			where T : BitInt
		{
            return __UInt256__.bits_depositparallel(array.Reinterpret<byte4, uint>(), ArrayCastMask256<UInt8, T>());
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt256__ UpCast256<T>(byte8 array)
			where T : BitInt
		{
            return __UInt256__.bits_depositparallel(array.Reinterpret<byte8, ulong>(), ArrayCastMask256<UInt8, T>());
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt256__ UpCast256<T>(byte16 array)
			where T : BitInt
		{
            return __UInt256__.bits_depositparallel(array.Reinterpret<byte16, UInt128>(), ArrayCastMask256<UInt8, T>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt256__ UpCast256<T>(ushort4 array)
			where T : BitInt
		{
            return __UInt256__.bits_depositparallel(array.Reinterpret<ushort4, ulong>(), ArrayCastMask256<UInt16, T>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt256__ UpCast256<T>(ushort8 array)
			where T : BitInt
		{
            return __UInt256__.bits_depositparallel(array.Reinterpret<ushort8, UInt128>(), ArrayCastMask256<UInt16, T>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt512__ UpCast512<T>(byte8 array)
			where T : BitInt
		{
            return __UInt512__.bits_depositparallel(array.Reinterpret<byte8, ulong>(), ArrayCastMask512<UInt8, T>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt512__ UpCast512<T>(byte16 array)
			where T : BitInt
		{
            return __UInt512__.bits_depositparallel(array.Reinterpret<byte16, UInt128>(), ArrayCastMask512<UInt8, T>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt512__ UpCast512<T>(ushort8 array)
			where T : BitInt
		{
            return __UInt512__.bits_depositparallel(array.Reinterpret<ushort8, UInt128>(), ArrayCastMask512<UInt16, T>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt1024__ UpCast1024<T>(byte16 array)
			where T : BitInt
		{
            return __UInt1024__.bits_depositparallel(array.Reinterpret<byte16, UInt128>(), ArrayCastMask1024<UInt8, T>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static UInt128 UpCast128<T>(uint2 array)
			where T : BitInt
		{
            return bits_depositparallel(array.Reinterpret<uint2, ulong>(), ArrayCastMask128<UInt32, T>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static UInt128 UpCast128<T>(uint3 array)
			where T : BitInt
		{
			uint4 cvt = Uninitialized<uint4>.Create();
			cvt.xyz = array;
			
            return bits_depositparallel(cvt.Reinterpret<uint4, UInt128>(), ArrayCastMask128<UInt32, T>());
		}


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong DownCast<T>(int8 array)
			where T : BitInt
		{
			return DownCast<T>((uint8)array);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong DownCast<T>(int4 array)
			where T : BitInt
		{
			return DownCast<T>((uint4)array);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static UInt128 DownCast128<T>(int3 array)
			where T : BitInt
		{
			return DownCast128<T>((uint3)array);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static UInt128 DownCast128<T>(int4 array)
			where T : BitInt
		{
			return DownCast128<T>((uint4)array);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong DownCast<T>(int2 array)
			where T : BitInt
		{
			return DownCast<T>((uint2)array);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static UInt128 UpCast128<T>(int2 array)
			where T : BitInt
		{
			return UpCast128<T>((uint2)array);
		}
		

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong DownCast<T>(ulong4 array)
			where T : BitInt
		{
			return (ulong)__UInt256__.bits_extractparallel(array.Reinterpret<ulong4, __UInt256__>(), ArrayCastMask256<T, UInt64>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong DownCast<T>(ulong2 array)
			where T : BitInt
		{
			return (ulong)bits_extractparallel(array.Reinterpret<ulong2, UInt128>(), ArrayCastMask128<T, UInt64>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static UInt128 DownCast128<T>(ulong2 array)
			where T : BitInt
		{
            return bits_extractparallel(array.Reinterpret<ulong2, UInt128>(), ArrayCastMask128<T, UInt64>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt256__ DownCast256<T>(short16 array)
			where T : BitInt
		{
            return DownCast256<T>((ushort16)array);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt256__ DownCast256<T>(int8 array)
			where T : BitInt
		{
            return __UInt256__.bits_extractparallel(array.Reinterpret<int8, __UInt256__>(), ArrayCastMask256<T, UInt32>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt256__ DownCast256<T>(ushort16 array)
			where T : BitInt
		{
            return __UInt256__.bits_extractparallel(array.Reinterpret<ushort16, __UInt256__>(), ArrayCastMask256<T, UInt16>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt256__ DownCast256<T>(ulong4 array)
			where T : BitInt
		{
            return __UInt256__.bits_extractparallel(array.Reinterpret<ulong4, __UInt256__>(), ArrayCastMask256<T, UInt64>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt256__ DownCast256<T>(long4 array)
			where T : BitInt
		{
            return DownCast256<T>((ulong4)array);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt512__ DownCast512<T>(int8 array0, int8 array1)
			where T : BitInt
		{
            return __UInt512__.bits_extractparallel(new __UInt512__(array0.Reinterpret<int8, __UInt256__>(), array1.Reinterpret<int8, __UInt256__>()), ArrayCastMask512<T, UInt32>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt512__ DownCast512<T>(long4 array0, long4 array1)
			where T : BitInt
		{
            return __UInt512__.bits_extractparallel(new __UInt512__(array0.Reinterpret<long4, __UInt256__>(), array1.Reinterpret<long4, __UInt256__>()), ArrayCastMask512<T, UInt64>());
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt1024__ DownCast1024<T>(long4 array0, long4 array1, long4 array2, long4 array3)
			where T : BitInt
		{
            return __UInt1024__.bits_extractparallel(new __UInt1024__(array0.Reinterpret<long4, __UInt256__>(), array1.Reinterpret<long4, __UInt256__>(), array2.Reinterpret<long4, __UInt256__>(), array3.Reinterpret<long4, __UInt256__>()), ArrayCastMask1024<T, UInt64>());
		}


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong DownCast<T>(long4 array)
			where T : BitInt
		{
			return DownCast<T>((ulong4)array);
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong DownCast<T>(long2 array)
			where T : BitInt
		{
			return DownCast<T>((ulong2)array);
		}
		
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static UInt128 DownCast128<T>(long2 array)
			where T : BitInt
		{
			return DownCast128<T>((ulong2)array);
		}
    }
}
