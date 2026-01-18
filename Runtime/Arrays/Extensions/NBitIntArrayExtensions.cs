using System.Runtime.CompilerServices;
using System.Collections.Generic;
using Unity.Collections;
using MaxMath;
using DevTools;

namespace BitCollections
{
    // TODO optimize
	public static class BitIntArrayExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeArray<byte> array, NativeBitIntArray<T> src)
            where T : BitInt
        {
Assert.AreEqual(array.Length, src.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (byte)src[i];
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeArray<sbyte> array, NativeBitIntArray<T> src)
            where T : BitInt
        {
Assert.AreEqual(array.Length, src.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (sbyte)src[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeArray<ushort> array, NativeBitIntArray<T> src)
            where T : BitInt
        {
Assert.AreEqual(array.Length, src.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (ushort)src[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeArray<short> array, NativeBitIntArray<T> src)
            where T : BitInt
        {
Assert.AreEqual(array.Length, src.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (short)src[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeArray<UInt24> array, NativeBitIntArray<T> src)
            where T : BitInt
        {
Assert.AreEqual(array.Length, src.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (UInt24)src[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeArray<Int24> array, NativeBitIntArray<T> src)
            where T : BitInt
        {
Assert.AreEqual(array.Length, src.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (Int24)src[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeArray<uint> array, NativeBitIntArray<T> src)
            where T : BitInt
        {
Assert.AreEqual(array.Length, src.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (uint)src[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeArray<int> array, NativeBitIntArray<T> src)
            where T : BitInt
        {
Assert.AreEqual(array.Length, src.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (int)src[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeArray<UInt40> array, NativeBitIntArray<T> src)
            where T : BitInt
        {
Assert.AreEqual(array.Length, src.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (UInt40)src[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeArray<Int40> array, NativeBitIntArray<T> src)
            where T : BitInt
        {
Assert.AreEqual(array.Length, src.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (Int40)src[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeArray<UInt48> array, NativeBitIntArray<T> src)
            where T : BitInt
        {
Assert.AreEqual(array.Length, src.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (UInt48)src[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeArray<Int48> array, NativeBitIntArray<T> src)
            where T : BitInt
        {
Assert.AreEqual(array.Length, src.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (Int48)src[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeArray<UInt56> array, NativeBitIntArray<T> src)
            where T : BitInt
        {
Assert.AreEqual(array.Length, src.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (UInt56)src[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeArray<Int56> array, NativeBitIntArray<T> src)
            where T : BitInt
        {
Assert.AreEqual(array.Length, src.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (Int56)src[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeArray<ulong> array, NativeBitIntArray<T> src)
            where T : BitInt
        {
Assert.AreEqual(array.Length, src.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (ulong)src[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeArray<long> array, NativeBitIntArray<T> src)
            where T : BitInt
        {
Assert.AreEqual(array.Length, src.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = src[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeArray<UInt128> array, NativeBitIntArray<T> src)
            where T : BitInt
        {
Assert.AreEqual(array.Length, src.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (UInt128)src[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeArray<Int128> array, NativeBitIntArray<T> src)
            where T : BitInt
        {
Assert.AreEqual(array.Length, src.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = src[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeArray<byte> array, NativeBitIntList<T> src)
            where T : BitInt
        {
Assert.AreEqual(array.Length, src.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (byte)src[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeArray<sbyte> array, NativeBitIntList<T> src)
            where T : BitInt
        {
Assert.AreEqual(array.Length, src.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (sbyte)src[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeArray<ushort> array, NativeBitIntList<T> src)
            where T : BitInt
        {
Assert.AreEqual(array.Length, src.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (ushort)src[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeArray<short> array, NativeBitIntList<T> src)
            where T : BitInt
        {
Assert.AreEqual(array.Length, src.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (short)src[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeArray<UInt24> array, NativeBitIntList<T> src)
            where T : BitInt
        {
Assert.AreEqual(array.Length, src.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (UInt24)src[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeArray<Int24> array, NativeBitIntList<T> src)
            where T : BitInt
        {
Assert.AreEqual(array.Length, src.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (Int24)src[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeArray<uint> array, NativeBitIntList<T> src)
            where T : BitInt
        {
Assert.AreEqual(array.Length, src.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (uint)src[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeArray<int> array, NativeBitIntList<T> src)
            where T : BitInt
        {
Assert.AreEqual(array.Length, src.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (int)src[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeArray<UInt40> array, NativeBitIntList<T> src)
            where T : BitInt
        {
Assert.AreEqual(array.Length, src.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (UInt40)src[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeArray<Int40> array, NativeBitIntList<T> src)
            where T : BitInt
        {
Assert.AreEqual(array.Length, src.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (Int40)src[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeArray<UInt48> array, NativeBitIntList<T> src)
            where T : BitInt
        {
Assert.AreEqual(array.Length, src.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (UInt48)src[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeArray<Int48> array, NativeBitIntList<T> src)
            where T : BitInt
        {
Assert.AreEqual(array.Length, src.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (Int48)src[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeArray<UInt56> array, NativeBitIntList<T> src)
            where T : BitInt
        {
Assert.AreEqual(array.Length, src.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (UInt56)src[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeArray<Int56> array, NativeBitIntList<T> src)
            where T : BitInt
        {
Assert.AreEqual(array.Length, src.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (Int56)src[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeArray<ulong> array, NativeBitIntList<T> src)
            where T : BitInt
        {
Assert.AreEqual(array.Length, src.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (ulong)src[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeArray<long> array, NativeBitIntList<T> src)
            where T : BitInt
        {
Assert.AreEqual(array.Length, src.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = src[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeArray<UInt128> array, NativeBitIntList<T> src)
            where T : BitInt
        {
Assert.AreEqual(array.Length, src.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (UInt128)src[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeArray<Int128> array, NativeBitIntList<T> src)
            where T : BitInt
        {
Assert.AreEqual(array.Length, src.Length);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = src[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeList<byte> list, NativeBitIntArray<T> src)
            where T : BitInt
        {
            list.Clear();
            list.AddRange(src);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeList<sbyte> list, NativeBitIntArray<T> src)
            where T : BitInt
        {
            list.Clear();
            list.AddRange(src);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeList<ushort> list, NativeBitIntArray<T> src)
            where T : BitInt
        {
            list.Clear();
            list.AddRange(src);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeList<short> list, NativeBitIntArray<T> src)
            where T : BitInt
        {
            list.Clear();
            list.AddRange(src);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeList<UInt24> list, NativeBitIntArray<T> src)
            where T : BitInt
        {
            list.Clear();
            list.AddRange(src);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeList<Int24> list, NativeBitIntArray<T> src)
            where T : BitInt
        {
            list.Clear();
            list.AddRange(src);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeList<uint> list, NativeBitIntArray<T> src)
            where T : BitInt
        {
            list.Clear();
            list.AddRange(src);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeList<int> list, NativeBitIntArray<T> src)
            where T : BitInt
        {
            list.Clear();
            list.AddRange(src);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeList<UInt40> list, NativeBitIntArray<T> src)
            where T : BitInt
        {
            list.Clear();
            list.AddRange(src);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeList<Int40> list, NativeBitIntArray<T> src)
            where T : BitInt
        {
            list.Clear();
            list.AddRange(src);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeList<UInt48> list, NativeBitIntArray<T> src)
            where T : BitInt
        {
            list.Clear();
            list.AddRange(src);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeList<Int48> list, NativeBitIntArray<T> src)
            where T : BitInt
        {
            list.Clear();
            list.AddRange(src);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeList<UInt56> list, NativeBitIntArray<T> src)
            where T : BitInt
        {
            list.Clear();
            list.AddRange(src);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeList<Int56> list, NativeBitIntArray<T> src)
            where T : BitInt
        {
            list.Clear();
            list.AddRange(src);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeList<ulong> list, NativeBitIntArray<T> src)
            where T : BitInt
        {
            list.Clear();
            list.AddRange(src);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeList<long> list, NativeBitIntArray<T> src)
            where T : BitInt
        {
            list.Clear();
            list.AddRange(src);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeList<UInt128> list, NativeBitIntArray<T> src)
            where T : BitInt
        {
            list.Clear();
            list.AddRange(src);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeList<Int128> list, NativeBitIntArray<T> src)
            where T : BitInt
        {
            list.Clear();
            list.AddRange(src);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeList<byte> list, NativeBitIntList<T> src)
            where T : BitInt
        {
            list.Clear();
            list.AddRange(src);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeList<sbyte> list, NativeBitIntList<T> src)
            where T : BitInt
        {
            list.Clear();
            list.AddRange(src);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeList<ushort> list, NativeBitIntList<T> src)
            where T : BitInt
        {
            list.Clear();
            list.AddRange(src);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeList<short> list, NativeBitIntList<T> src)
            where T : BitInt
        {
            list.Clear();
            list.AddRange(src);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeList<UInt24> list, NativeBitIntList<T> src)
            where T : BitInt
        {
            list.Clear();
            list.AddRange(src);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeList<Int24> list, NativeBitIntList<T> src)
            where T : BitInt
        {
            list.Clear();
            list.AddRange(src);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeList<uint> list, NativeBitIntList<T> src)
            where T : BitInt
        {
            list.Clear();
            list.AddRange(src);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeList<int> list, NativeBitIntList<T> src)
            where T : BitInt
        {
            list.Clear();
            list.AddRange(src);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeList<UInt40> list, NativeBitIntList<T> src)
            where T : BitInt
        {
            list.Clear();
            list.AddRange(src);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeList<Int40> list, NativeBitIntList<T> src)
            where T : BitInt
        {
            list.Clear();
            list.AddRange(src);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeList<UInt48> list, NativeBitIntList<T> src)
            where T : BitInt
        {
            list.Clear();
            list.AddRange(src);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeList<Int48> list, NativeBitIntList<T> src)
            where T : BitInt
        {
            list.Clear();
            list.AddRange(src);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeList<UInt56> list, NativeBitIntList<T> src)
            where T : BitInt
        {
            list.Clear();
            list.AddRange(src);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeList<Int56> list, NativeBitIntList<T> src)
            where T : BitInt
        {
            list.Clear();
            list.AddRange(src);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeList<ulong> list, NativeBitIntList<T> src)
            where T : BitInt
        {
            list.Clear();
            list.AddRange(src);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeList<long> list, NativeBitIntList<T> src)
            where T : BitInt
        {
            list.Clear();
            list.AddRange(src);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeList<UInt128> list, NativeBitIntList<T> src)
            where T : BitInt
        {
            list.Clear();
            list.AddRange(src);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyFrom<T>(this NativeList<Int128> list, NativeBitIntList<T> src)
            where T : BitInt
        {
            list.Clear();
            list.AddRange(src);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<byte> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((byte)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<sbyte> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((sbyte)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<short> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((short)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<ushort> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((ushort)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<Int24> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((Int24)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<UInt24> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((UInt24)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<int> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((int)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<uint> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((uint)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<Int40> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((Int40)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<UInt40> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((UInt40)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<Int48> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((Int48)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<UInt48> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((UInt48)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<Int56> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((Int56)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<UInt56> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((UInt56)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<long> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((long)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<ulong> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((ulong)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<Int128> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((Int128)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<UInt128> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((UInt128)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<byte> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((byte)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<sbyte> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((sbyte)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<short> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((short)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<ushort> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((ushort)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<Int24> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((Int24)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<UInt24> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((UInt24)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<int> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((int)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<uint> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((uint)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<Int40> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((Int40)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<UInt40> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((UInt40)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<Int48> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((Int48)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<UInt48> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((UInt48)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<Int56> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((Int56)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<UInt56> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((UInt56)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<long> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((long)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<ulong> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((ulong)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<Int128> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((Int128)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<UInt128> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((UInt128)array[startIndex + i]);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<byte> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((byte)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<sbyte> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((sbyte)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<short> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((short)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<ushort> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((ushort)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<Int24> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((Int24)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<UInt24> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((UInt24)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<int> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((int)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<uint> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((uint)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<Int40> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((Int40)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<UInt40> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((UInt40)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<Int48> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((Int48)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<UInt48> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((UInt48)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<Int56> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((Int56)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<UInt56> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((UInt56)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<long> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((long)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<ulong> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((ulong)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<Int128> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((Int128)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<UInt128> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((UInt128)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<byte> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((byte)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<sbyte> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((sbyte)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<short> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((short)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<ushort> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((ushort)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<Int24> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((Int24)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<UInt24> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((UInt24)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<int> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((int)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<uint> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((uint)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<Int40> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((Int40)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<UInt40> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((UInt40)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<Int48> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((Int48)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<UInt48> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((UInt48)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<Int56> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((Int56)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<UInt56> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((UInt56)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<long> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((long)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<ulong> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((ulong)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<Int128> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((Int128)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<UInt128> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Add((UInt128)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<byte> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.AddNoResize((byte)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<sbyte> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.AddNoResize((sbyte)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<short> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.AddNoResize((short)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<ushort> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.AddNoResize((ushort)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<Int24> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.AddNoResize((Int24)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<UInt24> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.AddNoResize((UInt24)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<int> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.AddNoResize((int)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<uint> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.AddNoResize((uint)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<Int40> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.AddNoResize((Int40)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<UInt40> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.AddNoResize((UInt40)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<Int48> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.AddNoResize((Int48)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<UInt48> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.AddNoResize((UInt48)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<Int56> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.AddNoResize((Int56)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<UInt56> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.AddNoResize((UInt56)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<long> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.AddNoResize((long)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<ulong> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.AddNoResize((ulong)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<Int128> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.AddNoResize((Int128)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<UInt128> list, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.AddNoResize((UInt128)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<byte> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.AddNoResize((byte)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<sbyte> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.AddNoResize((sbyte)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<short> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.AddNoResize((short)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<ushort> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.AddNoResize((ushort)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<Int24> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.AddNoResize((Int24)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<UInt24> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.AddNoResize((UInt24)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<int> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.AddNoResize((int)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<uint> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.AddNoResize((uint)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<Int40> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.AddNoResize((Int40)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<UInt40> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.AddNoResize((UInt40)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<Int48> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.AddNoResize((Int48)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<UInt48> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.AddNoResize((UInt48)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<Int56> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.AddNoResize((Int56)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<UInt56> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.AddNoResize((UInt56)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<long> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.AddNoResize((long)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<ulong> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.AddNoResize((ulong)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<Int128> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.AddNoResize((Int128)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<UInt128> list, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.AddNoResize((UInt128)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<byte> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<sbyte> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<short> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<ushort> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<Int24> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<UInt24> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<int> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<uint> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<Int40> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<UInt40> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<Int48> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<UInt48> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<Int56> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<UInt56> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<long> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<ulong> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<Int128> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<UInt128> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<byte> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<sbyte> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<short> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<ushort> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<Int24> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<UInt24> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<int> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<uint> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<Int40> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<UInt40> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<Int48> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<UInt48> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<Int56> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<UInt56> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<long> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<ulong> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<Int128> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this IList<UInt128> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<byte> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<sbyte> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<short> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<ushort> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<Int24> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<UInt24> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<int> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<uint> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<Int40> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<UInt40> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<Int48> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<UInt48> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<Int56> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<UInt56> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<long> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<ulong> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<Int128> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<UInt128> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<byte> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<sbyte> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<short> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<ushort> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<Int24> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<UInt24> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<int> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<uint> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<Int40> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<UInt40> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<Int48> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<UInt48> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<Int56> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<UInt56> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<long> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<ulong> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<Int128> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRange<T>(this NativeList<UInt128> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRange<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<byte> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRangeNoResize<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<sbyte> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRangeNoResize<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<short> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRangeNoResize<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<ushort> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRangeNoResize<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<Int24> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRangeNoResize<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<UInt24> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRangeNoResize<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<int> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRangeNoResize<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<uint> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRangeNoResize<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<Int40> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRangeNoResize<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<UInt40> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRangeNoResize<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<Int48> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRangeNoResize<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<UInt48> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRangeNoResize<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<Int56> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRangeNoResize<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<UInt56> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRangeNoResize<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<long> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRangeNoResize<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<ulong> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRangeNoResize<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<Int128> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRangeNoResize<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<UInt128> list, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.AddRangeNoResize<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<byte> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRangeNoResize<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<sbyte> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRangeNoResize<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<short> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRangeNoResize<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<ushort> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRangeNoResize<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<Int24> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRangeNoResize<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<UInt24> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRangeNoResize<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<int> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRangeNoResize<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<uint> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRangeNoResize<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<Int40> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRangeNoResize<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<UInt40> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRangeNoResize<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<Int48> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRangeNoResize<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<UInt48> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRangeNoResize<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<Int56> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRangeNoResize<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<UInt56> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRangeNoResize<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<long> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRangeNoResize<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<ulong> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRangeNoResize<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<Int128> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRangeNoResize<T>(array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRangeNoResize<T>(this NativeList<UInt128> list, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.AddRangeNoResize<T>(array, array.Length, 0);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<byte> list, int index, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(index + i, (byte)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<sbyte> list, int index, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(index + i, (sbyte)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<short> list, int index, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(index + i, (short)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<ushort> list, int index, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(index + i, (ushort)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<Int24> list, int index, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(index + i, (Int24)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<UInt24> list, int index, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(index + i, (UInt24)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<int> list, int index, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(index + i, (int)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<uint> list, int index, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(index + i, (uint)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<Int40> list, int index, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(index + i, (Int40)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<UInt40> list, int index, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(index + i, (UInt40)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<Int48> list, int index, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(index + i, (Int48)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<UInt48> list, int index, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(index + i, (UInt48)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<Int56> list, int index, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(index + i, (Int56)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<UInt56> list, int index, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(index + i, (UInt56)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<long> list, int index, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(index + i, (long)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<ulong> list, int index, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(index + i, (ulong)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<Int128> list, int index, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(index + i, (Int128)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<UInt128> list, int index, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(index + i, (UInt128)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<byte> list, int index, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(index + i, (byte)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<sbyte> list, int index, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(index + i, (sbyte)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<short> list, int index, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(index + i, (short)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<ushort> list, int index, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(index + i, (ushort)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<Int24> list, int index, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(index + i, (Int24)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<UInt24> list, int index, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(index + i, (UInt24)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<int> list, int index, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(index + i, (int)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<uint> list, int index, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(index + i, (uint)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<Int40> list, int index, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(index + i, (Int40)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<UInt40> list, int index, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(index + i, (UInt40)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<Int48> list, int index, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(index + i, (Int48)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<UInt48> list, int index, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(index + i, (UInt48)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<Int56> list, int index, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(index + i, (Int56)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<UInt56> list, int index, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(index + i, (UInt56)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<long> list, int index, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(index + i, (long)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<ulong> list, int index, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(index + i, (ulong)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<Int128> list, int index, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(index + i, (Int128)array[startIndex + i]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<UInt128> list, int index, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            for (int i = 0; i < count; i++)
            {
                list.Insert(index + i, (UInt128)array[startIndex + i]);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<byte> list, int index, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            list.InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                list[index + i] = (byte)array[startIndex + i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<sbyte> list, int index, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            list.InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                list[index + i] = (sbyte)array[startIndex + i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<short> list, int index, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            list.InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                list[index + i] = (short)array[startIndex + i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<ushort> list, int index, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            list.InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                list[index + i] = (ushort)array[startIndex + i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<Int24> list, int index, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            list.InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                list[index + i] = (Int24)array[startIndex + i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<UInt24> list, int index, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            list.InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                list[index + i] = (UInt24)array[startIndex + i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<int> list, int index, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            list.InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                list[index + i] = (int)array[startIndex + i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<uint> list, int index, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            list.InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                list[index + i] = (uint)array[startIndex + i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<Int40> list, int index, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            list.InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                list[index + i] = (Int40)array[startIndex + i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<UInt40> list, int index, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            list.InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                list[index + i] = (UInt40)array[startIndex + i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<Int48> list, int index, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            list.InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                list[index + i] = (Int48)array[startIndex + i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<UInt48> list, int index, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            list.InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                list[index + i] = (UInt48)array[startIndex + i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<Int56> list, int index, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            list.InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                list[index + i] = (Int56)array[startIndex + i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<UInt56> list, int index, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            list.InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                list[index + i] = (UInt56)array[startIndex + i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<long> list, int index, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            list.InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                list[index + i] = (long)array[startIndex + i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<ulong> list, int index, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            list.InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                list[index + i] = (ulong)array[startIndex + i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<Int128> list, int index, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            list.InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                list[index + i] = (Int128)array[startIndex + i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<UInt128> list, int index, NativeBitIntArray<T> array, int count, int startIndex)
            where T : BitInt
        {
            list.InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                list[index + i] = (UInt128)array[startIndex + i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<byte> list, int index, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            list.InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                list[index + i] = (byte)array[startIndex + i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<sbyte> list, int index, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            list.InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                list[index + i] = (sbyte)array[startIndex + i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<short> list, int index, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            list.InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                list[index + i] = (short)array[startIndex + i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<ushort> list, int index, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            list.InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                list[index + i] = (ushort)array[startIndex + i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<Int24> list, int index, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            list.InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                list[index + i] = (Int24)array[startIndex + i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<UInt24> list, int index, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            list.InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                list[index + i] = (UInt24)array[startIndex + i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<int> list, int index, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            list.InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                list[index + i] = (int)array[startIndex + i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<uint> list, int index, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            list.InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                list[index + i] = (uint)array[startIndex + i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<Int40> list, int index, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            list.InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                list[index + i] = (Int40)array[startIndex + i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<UInt40> list, int index, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            list.InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                list[index + i] = (UInt40)array[startIndex + i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<Int48> list, int index, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            list.InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                list[index + i] = (Int48)array[startIndex + i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<UInt48> list, int index, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            list.InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                list[index + i] = (UInt48)array[startIndex + i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<Int56> list, int index, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            list.InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                list[index + i] = (Int56)array[startIndex + i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<UInt56> list, int index, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            list.InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                list[index + i] = (UInt56)array[startIndex + i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<long> list, int index, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            list.InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                list[index + i] = (long)array[startIndex + i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<ulong> list, int index, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            list.InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                list[index + i] = (ulong)array[startIndex + i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<Int128> list, int index, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            list.InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                list[index + i] = (Int128)array[startIndex + i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<UInt128> list, int index, NativeBitIntList<T> array, int count, int startIndex)
            where T : BitInt
        {
            list.InsertRange(index, count);
            for (int i = 0; i < count; i++)
            {
                list[index + i] = (UInt128)array[startIndex + i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<byte> list, int index, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<sbyte> list, int index, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<short> list, int index, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<ushort> list, int index, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<Int24> list, int index, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<UInt24> list, int index, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<int> list, int index, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<uint> list, int index, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<Int40> list, int index, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<UInt40> list, int index, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<Int48> list, int index, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<UInt48> list, int index, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<Int56> list, int index, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<UInt56> list, int index, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<long> list, int index, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<ulong> list, int index, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<Int128> list, int index, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<UInt128> list, int index, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<byte> list, int index, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<sbyte> list, int index, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<short> list, int index, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<ushort> list, int index, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<Int24> list, int index, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<UInt24> list, int index, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<int> list, int index, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<uint> list, int index, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<Int40> list, int index, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<UInt40> list, int index, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<Int48> list, int index, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<UInt48> list, int index, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<Int56> list, int index, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<UInt56> list, int index, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<long> list, int index, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<ulong> list, int index, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<Int128> list, int index, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this IList<UInt128> list, int index, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<byte> list, int index, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<sbyte> list, int index, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<short> list, int index, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<ushort> list, int index, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<Int24> list, int index, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<UInt24> list, int index, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<int> list, int index, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<uint> list, int index, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<Int40> list, int index, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<UInt40> list, int index, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<Int48> list, int index, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<UInt48> list, int index, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<Int56> list, int index, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<UInt56> list, int index, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<long> list, int index, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<ulong> list, int index, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<Int128> list, int index, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<UInt128> list, int index, NativeBitIntArray<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<byte> list, int index, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<sbyte> list, int index, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<short> list, int index, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<ushort> list, int index, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<Int24> list, int index, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<UInt24> list, int index, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<int> list, int index, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<uint> list, int index, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<Int40> list, int index, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<UInt40> list, int index, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<Int48> list, int index, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<UInt48> list, int index, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<Int56> list, int index, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<UInt56> list, int index, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<long> list, int index, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<ulong> list, int index, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<Int128> list, int index, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InsertRange<T>(this NativeList<UInt128> list, int index, NativeBitIntList<T> array)
            where T : BitInt
        {
            list.InsertRange<T>(index, array, array.Length, 0);
        }
    }
}
