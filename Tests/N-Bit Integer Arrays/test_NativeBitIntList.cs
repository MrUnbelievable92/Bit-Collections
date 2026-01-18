using System.Collections.Generic;
using NUnit.Framework;
using Unity.Collections;
using Unity.Mathematics;
using MaxMath;
using SIMDAlgorithms;
using System;
using System.Numerics;

namespace BitCollections.Tests
{
    public static class _NativeBitIntList
    {
        private const int MAX_TEST_LENGTH = 100;
        
        private static NativeBitIntList<T> CreateRandomBitIntMockList<T>(int length, ref Random64 rng, long min = long.MinValue, long max = long.MaxValue)
            where T : unmanaged, BitInt
        {
            min = (min == long.MinValue) ? default(T).MinValueAsLong : maxmath.minmag(default(T).MinValueAsLong, min);
            max = (max == long.MaxValue) ? default(T).MaxValueAsLong : maxmath.minmag(default(T).MaxValueAsLong, max);

            NativeBitIntList<T> result = new NativeBitIntList<T>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                long next = rng.NextLong(min, max + (default(T).Bits == 63 ? 0 : 1));
                result.Add(next);
            }

            return result;
        }

        private static NativeList<byte> CreateRandomByteList(int length, ref Random64 rng)
        {
            NativeList<byte> result = new NativeList<byte>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                byte next = (byte)BitIntMock.Random(ref rng);
                result.Add(next);
            }

            return result;
        }

        private static NativeList<sbyte> CreateRandomSByteList(int length, ref Random64 rng)
        {
            NativeList<sbyte> result = new NativeList<sbyte>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                sbyte next = (sbyte)BitIntMock.Random(ref rng);
                result.Add(next);
            }

            return result;
        }

        private static NativeList<ushort> CreateRandomUShortList(int length, ref Random64 rng)
        {
            NativeList<ushort> result = new NativeList<ushort>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                ushort next = (ushort)BitIntMock.Random(ref rng);
                result.Add(next);
            }

            return result;
        }

        private static NativeList<short> CreateRandomShortList(int length, ref Random64 rng)
        {
            NativeList<short> result = new NativeList<short>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                short next = (short)BitIntMock.Random(ref rng);
                result.Add(next);
            }

            return result;
        }

        private static NativeList<UInt24> CreateRandomUInt24List(int length, ref Random64 rng)
        {
            NativeList<UInt24> result = new NativeList<UInt24>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                UInt24 next = (UInt24)BitIntMock.Random(ref rng);
                result.Add(next);
            }

            return result;
        }

        private static NativeList<Int24> CreateRandomInt24List(int length, ref Random64 rng)
        {
            NativeList<Int24> result = new NativeList<Int24>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                Int24 next = (Int24)BitIntMock.Random(ref rng);
                result.Add(next);
            }

            return result;
        }

        private static NativeList<uint> CreateRandomUIntList(int length, ref Random64 rng)
        {
            NativeList<uint> result = new NativeList<uint>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                uint next = (uint)BitIntMock.Random(ref rng);
                result.Add(next);
            }

            return result;
        }

        private static NativeList<int> CreateRandomIntList(int length, ref Random64 rng)
        {
            NativeList<int> result = new NativeList<int>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                int next = (int)BitIntMock.Random(ref rng);
                result.Add(next);
            }

            return result;
        }

        private static NativeList<UInt40> CreateRandomUInt40List(int length, ref Random64 rng)
        {
            NativeList<UInt40> result = new NativeList<UInt40>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                UInt40 next = (UInt40)BitIntMock.Random(ref rng);
                result.Add(next);
            }

            return result;
        }

        private static NativeList<Int40> CreateRandomInt40List(int length, ref Random64 rng)
        {
            NativeList<Int40> result = new NativeList<Int40>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                Int40 next = (Int40)BitIntMock.Random(ref rng);
                result.Add(next);
            }

            return result;
        }

        private static NativeList<UInt48> CreateRandomUInt48List(int length, ref Random64 rng)
        {
            NativeList<UInt48> result = new NativeList<UInt48>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                UInt48 next = (UInt48)BitIntMock.Random(ref rng);
                result.Add(next);
            }

            return result;
        }

        private static NativeList<Int48> CreateRandomInt48List(int length, ref Random64 rng)
        {
            NativeList<Int48> result = new NativeList<Int48>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                Int48 next = (Int48)BitIntMock.Random(ref rng);
                result.Add(next);
            }

            return result;
        }

        private static NativeList<UInt56> CreateRandomUInt56List(int length, ref Random64 rng)
        {
            NativeList<UInt56> result = new NativeList<UInt56>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                UInt56 next = (UInt56)BitIntMock.Random(ref rng);
                result.Add(next);
            }

            return result;
        }

        private static NativeList<Int56> CreateRandomInt56List(int length, ref Random64 rng)
        {
            NativeList<Int56> result = new NativeList<Int56>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                Int56 next = (Int56)BitIntMock.Random(ref rng);
                result.Add(next);
            }

            return result;
        }

        private static NativeList<ulong> CreateRandomULongList(int length, ref Random64 rng)
        {
            NativeList<ulong> result = new NativeList<ulong>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                ulong next = (ulong)BitIntMock.Random(ref rng);
                result.Add(next);
            }

            return result;
        }

        private static NativeList<long> CreateRandomLongList(int length, ref Random64 rng)
        {
            NativeList<long> result = new NativeList<long>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                long next = (long)BitIntMock.Random(ref rng);
                result.Add(next);
            }

            return result;
        }

        private static NativeList<UInt128> CreateRandomUInt128List(int length, ref Random64 rng)
        {
            NativeList<UInt128> result = new NativeList<UInt128>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                UInt128 next = (UInt128)BitIntMock.Random(ref rng);
                result.Add(next);
            }

            return result;
        }

        private static NativeList<Int128> CreateRandomInt128List(int length, ref Random64 rng)
        {
            NativeList<Int128> result = new NativeList<Int128>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                Int128 next = (Int128)BitIntMock.Random(ref rng);
                result.Add(next);
            }

            return result;
        }

        private static void CreateSyncedLists(int length, out NativeBitIntList<BitIntMock> a, out NativeBitIntList<BitIntMock> b, ref Random64 rng, long min = long.MinValue, long max = long.MaxValue)
        {
            a = new NativeBitIntList<BitIntMock>(length, Allocator.Persistent);
            b = new NativeBitIntList<BitIntMock>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                long next;
                if (min == long.MinValue && max == long.MaxValue)
                {
                    next = BitIntMock.Random(ref rng);
                }
                else
                {
                    next = rng.NextLong(min, max + (default(BitIntMock).Bits == 63 ? 0 : 1));
                }
                
                b.Add(next);
                a.Add(next);
            }
        }

        private static void CreateSyncedLists(int length, out NativeBitIntList<BitIntMock> max, out NativeBitIntList<BitIntMock2> min, ref Random64 rng)
        {
            max = new NativeBitIntList<BitIntMock>(length, Allocator.Persistent);
            min = new NativeBitIntList<BitIntMock2>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                long next = BitIntMock2.Random(ref rng);
                min.Add(next);
                max.Add(next);
            }
        }

        private static void CreateSyncedLists(int length, out NativeBitIntList<BitIntMock> native, out NativeList<byte> managed, ref Random64 rng)
        {
            native = new NativeBitIntList<BitIntMock>(length, Allocator.Persistent);
            managed = new NativeList<byte>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                long next = BitIntMock.Random(ref rng);
                native.Add(next);
                managed.Add((byte)next);
            }
        }

        private static void CreateSyncedLists(int length, out NativeBitIntList<BitIntMock> native, out NativeList<sbyte> managed, ref Random64 rng)
        {
            native = new NativeBitIntList<BitIntMock>(length, Allocator.Persistent);
            managed = new NativeList<sbyte>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                long next = BitIntMock.Random(ref rng);
                native.Add(next);
                managed.Add((sbyte)next);
            }
        }

        private static void CreateSyncedLists(int length, out NativeBitIntList<BitIntMock> native, out NativeList<ushort> managed, ref Random64 rng)
        {
            native = new NativeBitIntList<BitIntMock>(length, Allocator.Persistent);
            managed = new NativeList<ushort>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                long next = BitIntMock.Random(ref rng);
                native.Add(next);
                managed.Add((ushort)next);
            }
        }

        private static void CreateSyncedLists(int length, out NativeBitIntList<BitIntMock> native, out NativeList<short> managed, ref Random64 rng)
        {
            native = new NativeBitIntList<BitIntMock>(length, Allocator.Persistent);
            managed = new NativeList<short>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                long next = BitIntMock.Random(ref rng);
                native.Add(next);
                managed.Add((short)next);
            }
        }

        private static void CreateSyncedLists(int length, out NativeBitIntList<BitIntMock> native, out NativeList<UInt24> managed, ref Random64 rng)
        {
            native = new NativeBitIntList<BitIntMock>(length, Allocator.Persistent);
            managed = new NativeList<UInt24>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                long next = BitIntMock.Random(ref rng);
                native.Add(next);
                managed.Add((UInt24)next);
            }
        }

        private static void CreateSyncedLists(int length, out NativeBitIntList<BitIntMock> native, out NativeList<Int24> managed, ref Random64 rng)
        {
            native = new NativeBitIntList<BitIntMock>(length, Allocator.Persistent);
            managed = new NativeList<Int24>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                long next = BitIntMock.Random(ref rng);
                native.Add(next);
                managed.Add((Int24)next);
            }
        }

        private static void CreateSyncedLists(int length, out NativeBitIntList<BitIntMock> native, out NativeList<uint> managed, ref Random64 rng)
        {
            native = new NativeBitIntList<BitIntMock>(length, Allocator.Persistent);
            managed = new NativeList<uint>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                long next = BitIntMock.Random(ref rng);
                native.Add(next);
                managed.Add((uint)next);
            }
        }

        private static void CreateSyncedLists(int length, out NativeBitIntList<BitIntMock> native, out NativeList<int> managed, ref Random64 rng)
        {
            native = new NativeBitIntList<BitIntMock>(length, Allocator.Persistent);
            managed = new NativeList<int>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                long next = BitIntMock.Random(ref rng);
                native.Add(next);
                managed.Add((int)next);
            }
        }

        private static void CreateSyncedLists(int length, out NativeBitIntList<BitIntMock> native, out NativeList<UInt40> managed, ref Random64 rng)
        {
            native = new NativeBitIntList<BitIntMock>(length, Allocator.Persistent);
            managed = new NativeList<UInt40>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                long next = BitIntMock.Random(ref rng);
                native.Add(next);
                managed.Add((UInt40)next);
            }
        }

        private static void CreateSyncedLists(int length, out NativeBitIntList<BitIntMock> native, out NativeList<Int40> managed, ref Random64 rng)
        {
            native = new NativeBitIntList<BitIntMock>(length, Allocator.Persistent);
            managed = new NativeList<Int40>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                long next = BitIntMock.Random(ref rng);
                native.Add(next);
                managed.Add((Int40)next);
            }
        }

        private static void CreateSyncedLists(int length, out NativeBitIntList<BitIntMock> native, out NativeList<UInt48> managed, ref Random64 rng)
        {
            native = new NativeBitIntList<BitIntMock>(length, Allocator.Persistent);
            managed = new NativeList<UInt48>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                long next = BitIntMock.Random(ref rng);
                native.Add(next);
                managed.Add((UInt48)next);
            }
        }

        private static void CreateSyncedLists(int length, out NativeBitIntList<BitIntMock> native, out NativeList<Int48> managed, ref Random64 rng)
        {
            native = new NativeBitIntList<BitIntMock>(length, Allocator.Persistent);
            managed = new NativeList<Int48>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                long next = BitIntMock.Random(ref rng);
                native.Add(next);
                managed.Add((Int48)next);
            }
        }

        private static void CreateSyncedLists(int length, out NativeBitIntList<BitIntMock> native, out NativeList<UInt56> managed, ref Random64 rng)
        {
            native = new NativeBitIntList<BitIntMock>(length, Allocator.Persistent);
            managed = new NativeList<UInt56>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                long next = BitIntMock.Random(ref rng);
                native.Add(next);
                managed.Add((UInt56)next);
            }
        }

        private static void CreateSyncedLists(int length, out NativeBitIntList<BitIntMock> native, out NativeList<Int56> managed, ref Random64 rng)
        {
            native = new NativeBitIntList<BitIntMock>(length, Allocator.Persistent);
            managed = new NativeList<Int56>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                long next = BitIntMock.Random(ref rng);
                native.Add(next);
                managed.Add((Int56)next);
            }
        }

        private static void CreateSyncedLists(int length, out NativeBitIntList<BitIntMock> native, out NativeList<ulong> managed, ref Random64 rng)
        {
            native = new NativeBitIntList<BitIntMock>(length, Allocator.Persistent);
            managed = new NativeList<ulong>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                long next = BitIntMock.Random(ref rng);
                native.Add(next);
                managed.Add((ulong)next);
            }
        }

        private static void CreateSyncedLists(int length, out NativeBitIntList<BitIntMock> native, out NativeList<long> managed, ref Random64 rng)
        {
            native = new NativeBitIntList<BitIntMock>(length, Allocator.Persistent);
            managed = new NativeList<long>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                long next = BitIntMock.Random(ref rng);
                native.Add(next);
                managed.Add(next);
            }
        }

        private static void CreateSyncedLists(int length, out NativeBitIntList<BitIntMock> native, out NativeList<UInt128> managed, ref Random64 rng)
        {
            native = new NativeBitIntList<BitIntMock>(length, Allocator.Persistent);
            managed = new NativeList<UInt128>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                long next = BitIntMock.Random(ref rng);
                native.Add(next);
                managed.Add((UInt128)next);
            }
        }

        private static void CreateSyncedLists(int length, out NativeBitIntList<BitIntMock> native, out NativeList<Int128> managed, ref Random64 rng)
        {
            native = new NativeBitIntList<BitIntMock>(length, Allocator.Persistent);
            managed = new NativeList<Int128>(length, Allocator.Persistent);

            for (int j = 0; j < length; j++)
            {
                long next = BitIntMock.Random(ref rng);
                native.Add(next);
                managed.Add(next);
            }
        }

        private static void CreateSyncedLists(int length, out NativeBitIntList<BitIntMock> native, out List<long> managed, ref Random64 rng)
        {
            native = new NativeBitIntList<BitIntMock>(length, Allocator.Persistent);
            managed = new List<long>(length);

            for (int j = 0; j < length; j++)
            {
                long next = BitIntMock.Random(ref rng);
                native.Add(next);
                managed.Add(next);
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, NativeBitIntList<BitIntMock2> managed)
        {
            Assert.AreEqual(native.Length, managed.Length);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual(native[i], (long)managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    managed.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, NativeList<sbyte> managed)
        {
            Assert.AreEqual(native.Length, managed.Length);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual(native[i], (long)managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    managed.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, NativeList<byte> managed)
        {
            Assert.AreEqual(native.Length, managed.Length);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual((byte)native[i], managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    managed.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, NativeList<short> managed)
        {
            Assert.AreEqual(native.Length, managed.Length);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual(native[i], (long)managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    managed.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, NativeList<ushort> managed)
        {
            Assert.AreEqual(native.Length, managed.Length);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual((ushort)native[i], managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    managed.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, NativeList<Int24> managed)
        {
            Assert.AreEqual(native.Length, managed.Length);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual(native[i], (long)managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    managed.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, NativeList<UInt24> managed)
        {
            Assert.AreEqual(native.Length, managed.Length);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual((UInt24)native[i], managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    managed.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, NativeList<int> managed)
        {
            Assert.AreEqual(native.Length, managed.Length);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual(native[i], (long)managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    managed.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, NativeList<uint> managed)
        {
            Assert.AreEqual(native.Length, managed.Length);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual((uint)native[i], managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    managed.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, NativeList<Int40> managed)
        {
            Assert.AreEqual(native.Length, managed.Length);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual(native[i], (long)managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    managed.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, NativeList<UInt40> managed)
        {
            Assert.AreEqual(native.Length, managed.Length);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual((UInt40)native[i], managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    managed.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, NativeList<Int48> managed)
        {
            Assert.AreEqual(native.Length, managed.Length);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual(native[i], (long)managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    managed.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, NativeList<UInt48> managed)
        {
            Assert.AreEqual(native.Length, managed.Length);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual((UInt48)native[i], managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    managed.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, NativeList<Int56> managed)
        {
            Assert.AreEqual(native.Length, managed.Length);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual(native[i], (long)managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    managed.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, NativeList<UInt56> managed)
        {
            Assert.AreEqual(native.Length, managed.Length);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual((UInt56)native[i], managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    managed.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, NativeList<long> managed)
        {
            Assert.AreEqual(native.Length, managed.Length);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual(native[i], (long)managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    managed.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, NativeList<ulong> managed)
        {
            Assert.AreEqual(native.Length, managed.Length);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual((ulong)native[i], managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    managed.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, NativeList<Int128> managed)
        {
            Assert.AreEqual(native.Length, managed.Length);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual(native[i], (long)managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    managed.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, NativeList<UInt128> managed)
        {
            Assert.AreEqual(native.Length, managed.Length);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual((UInt128)native[i], managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    managed.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, List<sbyte> managed)
        {
            Assert.AreEqual(native.Length, managed.Count);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual(native[i], (long)managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, List<byte> managed)
        {
            Assert.AreEqual(native.Length, managed.Count);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual((byte)native[i], managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, List<short> managed)
        {
            Assert.AreEqual(native.Length, managed.Count);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual(native[i], (long)managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, List<ushort> managed)
        {
            Assert.AreEqual(native.Length, managed.Count);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual((ushort)native[i], managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, List<Int24> managed)
        {
            Assert.AreEqual(native.Length, managed.Count);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual(native[i], (long)managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, List<UInt24> managed)
        {
            Assert.AreEqual(native.Length, managed.Count);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual((UInt24)native[i], managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, List<int> managed)
        {
            Assert.AreEqual(native.Length, managed.Count);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual(native[i], (long)managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, List<uint> managed)
        {
            Assert.AreEqual(native.Length, managed.Count);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual((uint)native[i], managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, List<Int40> managed)
        {
            Assert.AreEqual(native.Length, managed.Count);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual(native[i], (long)managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, List<UInt40> managed)
        {
            Assert.AreEqual(native.Length, managed.Count);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual((UInt40)native[i], managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, List<Int48> managed)
        {
            Assert.AreEqual(native.Length, managed.Count);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual(native[i], (long)managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, List<UInt48> managed)
        {
            Assert.AreEqual(native.Length, managed.Count);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual((UInt48)native[i], managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, List<Int56> managed)
        {
            Assert.AreEqual(native.Length, managed.Count);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual(native[i], (long)managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, List<UInt56> managed)
        {
            Assert.AreEqual(native.Length, managed.Count);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual((UInt56)native[i], managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, List<long> managed)
        {
            Assert.AreEqual(native.Length, managed.Count);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual(native[i], (long)managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, List<ulong> managed)
        {
            Assert.AreEqual(native.Length, managed.Count);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual((ulong)native[i], managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, List<Int128> managed)
        {
            Assert.AreEqual(native.Length, managed.Count);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual(native[i], (long)managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> native, List<UInt128> managed)
        {
            Assert.AreEqual(native.Length, managed.Count);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual((UInt128)native[i], managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality(NativeBitIntList<BitIntMock> list, NativeBitIntArray<BitIntMock> array)
        {
            Assert.AreEqual(list.Length, array.Length);

            for (int i = 0; i < list.Length; i++)
            {
                try
                {
                    Assert.AreEqual(list[i], array[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {list.Length}, i: {i}");
                    list.Dispose(default);
                    array.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality<T>(NativeList<T> a, NativeList<T> b)
            where T : unmanaged
        {
            Assert.AreEqual(a.Length, b.Length);

            for (int i = 0; i < a.Length; i++)
            {
                try
                {
                    Assert.AreEqual(a[i], b[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {a.Length}, i: {i}");
                    a.Dispose(default);
                    throw;
                }
            }
        }

        private static void AssertEquality<T>(List<T> a, List<T> b)
            where T : unmanaged
        {
            Assert.AreEqual(a.Count, b.Count);

            for (int i = 0; i < a.Count; i++)
            {
                try
                {
                    Assert.AreEqual(a[i], b[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {a.Count}, i: {i}");
                    throw;
                }
            }
        }

        [Test]
        public static void GetSet()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 2; i++)
                    {
                        int length = (int)rng.NextLong(1, MAX_TEST_LENGTH);

                        CreateSyncedLists(length, out NativeBitIntList<BitIntMock> native, out NativeList<long> managed, ref rng);
                        for (int j = 0; j < length; j++)
                        {
                            native[j] = managed[j];
                            AssertEquality(native, managed);
                        }

                        native.Dispose(default);
                        managed.Dispose(default);
                    }
                }
            );
        }

        [Test]
        public static void Add()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 2; i++)
                    {
                        int length = (int)rng.NextLong(1, MAX_TEST_LENGTH);

                        CreateSyncedLists(length, out NativeBitIntList<BitIntMock> native, out NativeList<long> managed, ref rng);
                        AssertEquality(native, managed);

                        native.Dispose(default);
                        managed.Dispose(default);
                    }
                }
            );
        }

        [Test]
        public static void RemoveAt()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 2; i++)
                    {
                        int length = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        CreateSyncedLists(length, out NativeBitIntList<BitIntMock> native, out NativeList<long> managed, ref rng);

                        for (int j = 0; j < length / (MAX_TEST_LENGTH / (MAX_TEST_LENGTH / 10)); j++)
                        {
                            int index = (int)rng.NextLong(0, native.Length);

                            native.RemoveAt(index);
                            managed.RemoveAt(index);

                            AssertEquality(native, managed);
                        }

                        for (int j = 0; j < 16; j++)
                        {
                            if (2 * j >= native.Length)
                            {
                                break;
                            }

                            native.RemoveAt(j);
                            managed.RemoveAt(j);

                            AssertEquality(native, managed);

                            if (j >= native.Length)
                            {
                                break;
                            }

                            native.RemoveAt(native.Length - (1 + j));
                            managed.RemoveAt(managed.Length - (1 + j));

                            AssertEquality(native, managed);
                        }

                        native.Dispose(default);
                        managed.Dispose(default);
                    }
                }
            );
        }

        [Test]
        public static void RemoveAtSwapBack()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 2; i++)
                    {
                        int length = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        CreateSyncedLists(length, out NativeBitIntList<BitIntMock> native, out NativeList<long> managed, ref rng);

                        for (int j = 0; j < length / (MAX_TEST_LENGTH / (MAX_TEST_LENGTH / 10)); j++)
                        {
                            int index = (int)rng.NextLong(0, native.Length);

                            native.RemoveAtSwapBack(index);
                            managed.RemoveAtSwapBack(index);

                            AssertEquality(native, managed);
                        }

                        for (int j = 0; j < 16; j++)
                        {
                            if (2 * j >= native.Length)
                            {
                                break;
                            }

                            native.RemoveAtSwapBack(j);
                            managed.RemoveAtSwapBack(j);

                            AssertEquality(native, managed);

                            if (j >= native.Length)
                            {
                                break;
                            }

                            native.RemoveAtSwapBack(native.Length - (1 + j));
                            managed.RemoveAtSwapBack(managed.Length - (1 + j));

                            AssertEquality(native, managed);
                        }

                        native.Dispose(default);
                        managed.Dispose(default);
                    }
                }
            );
        }

        [Test]
        public static void RemoveRange()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 2; i++)
                    {
                        int length = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        CreateSyncedLists(length, out NativeBitIntList<BitIntMock> native, out NativeList<long> managed, ref rng);

                        for (int j = 0; j < length / (MAX_TEST_LENGTH / (MAX_TEST_LENGTH / 10)); j++)
                        {
                            int index = (int)rng.NextLong(0, native.Length);
                            int count = (int)rng.NextLong(0, native.Length - index);

                            managed.RemoveRange(index, count);
                            native.RemoveRange(index, count);

                            AssertEquality(native, managed);
                        }


                        if (native.Length != 0)
                        {
                            managed.RemoveRange(0, 0);
                            native.RemoveRange(0, 0);

                            AssertEquality(native, managed);

                            if (native.Length > 1)
                            {
                                managed.RemoveRange(1, 0);
                                native.RemoveRange(1, 0);

                                AssertEquality(native, managed);
                            }

                            managed.RemoveRange(managed.Length- 1, 0);
                            native.RemoveRange(native.Length - 1, 0);

                            AssertEquality(native, managed);

                            if (native.Length > 1)
                            {
                                managed.RemoveRange(1, 0);
                                native.RemoveRange(1, 0);

                                AssertEquality(native, managed);
                            }

                            managed.RemoveRange(managed.Length- 1, 1);
                            native.RemoveRange(native.Length - 1, 1);

                            AssertEquality(native, managed);
                        }


                        for (int j = 0; j < 8; j++)
                        {
                            if (native.Length == 0)
                            {
                                break;
                            }

                            int index = (int)rng.NextLong(0, native.Length);
                            int count = native.Length - index;

                            managed.RemoveRange(index, count);
                            native.RemoveRange(index, count);

                            AssertEquality(native, managed);
                        }

                        if (native.Length != 0)
                        {
                            managed.RemoveRange(0, managed.Length);
                            native.RemoveRange(0, native.Length);

                            AssertEquality(native, managed);
                        }

                        native.Dispose(default);
                        managed.Dispose(default);
                    }
                }
            );
        }

        [Test]
        public static void AddReplicate()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 2; i++)
                    {
                        int length = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        CreateSyncedLists(length, out NativeBitIntList<BitIntMock> native, out NativeList<long> managed, ref rng);

                        long value = BitIntMock.Random(ref rng);
                        int count = (int)rng.NextLong(0, 100);

                        managed.AddReplicate(value, count);
                        native.AddReplicate(value, count);

                        AssertEquality(native, managed);

                        native.Dispose(default);
                        managed.Dispose(default);
                    }
                }
            );
        }

        [Test]
        public static void RemoveRangeSwapBack()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 2; i++)
                    {
                        int length = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        CreateSyncedLists(length, out NativeBitIntList<BitIntMock> native, out NativeList<long> managed, ref rng);

                        for (int j = 0; j < length / (MAX_TEST_LENGTH / (MAX_TEST_LENGTH / 10)); j++)
                        {
                            int index = (int)rng.NextLong(0, native.Length);
                            int count = (int)rng.NextLong(0, native.Length - index);

                            managed.RemoveRangeSwapBack(index, count);
                            native.RemoveRangeSwapBack(index, count);

                            AssertEquality(native, managed);
                        }


                        if (native.Length != 0)
                        {
                            managed.RemoveRangeSwapBack(0, 0);
                            native.RemoveRangeSwapBack(0, 0);

                            AssertEquality(native, managed);

                            if (native.Length > 1)
                            {
                                managed.RemoveRangeSwapBack(1, 0);
                                native.RemoveRangeSwapBack(1, 0);

                                AssertEquality(native, managed);
                            }

                            if (native.Length != 0)
                            {
                                managed.RemoveRangeSwapBack(managed.Length- 1, 0);
                                native.RemoveRangeSwapBack(native.Length - 1, 0);

                                AssertEquality(native, managed);
                            }

                            if (native.Length != 0)
                            {
                                managed.RemoveRangeSwapBack(managed.Length- 1, 1);
                                native.RemoveRangeSwapBack(native.Length - 1, 1);

                                AssertEquality(native, managed);
                            }

                        }


                        for (int j = 0; j < 8; j++)
                        {
                            if (native.Length == 0)
                            {
                                break;
                            }

                            int index = (int)rng.NextLong(0, native.Length);
                            int count = native.Length - index;

                            managed.RemoveRangeSwapBack(index, count);
                            native.RemoveRangeSwapBack(index, count);

                            AssertEquality(native, managed);
                        }

                        if (native.Length != 0)
                        {
                            managed.RemoveRangeSwapBack(0, managed.Length);
                            native.RemoveRangeSwapBack(0, native.Length);

                            AssertEquality(native, managed);
                        }

                        native.Dispose(default);
                        managed.Dispose(default);
                    }
                }
            );
        }

        [Test]
        public static void Insert()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 3; i++)
                    {
                        int length = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int randomIndex = (int)rng.NextLong(0, length);
                        CreateSyncedLists(length, out NativeBitIntList<BitIntMock> native, out List<long> managed, ref rng);

                        long random = BitIntMock.Random(ref rng);

                        native.Insert(randomIndex, random);
                        managed.Insert(randomIndex, random);

                        AssertEquality(native, managed);

                        native.Dispose(default);
                    }
                }
            );
        }

        [Test]
        public static void InsertRange()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int length = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int randomIndex = (int)rng.NextLong(0, length);
                        int randomCount = (int)rng.NextLong(0, length - randomIndex + 1);
                        CreateSyncedLists(length, out NativeBitIntList<BitIntMock> native, out NativeList<long> managed, ref rng);

                        managed.InsertRange(randomIndex, randomCount);
                        native.InsertRange(randomIndex, randomCount);

                        AssertEquality(native, managed);

                        native.Dispose(default);
                        managed.Dispose(default);
                    }
                }
            );
        }

        [Test]
        public static void InsertRangeWithBeginEnd()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int length = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int randomIndex = (int)rng.NextLong(0, length);
                        int randomEnd = (int)rng.NextLong(randomIndex, length);
                        CreateSyncedLists(length, out NativeBitIntList<BitIntMock> native, out NativeList<long> managed, ref rng);

                        managed.InsertRangeWithBeginEnd(randomIndex, randomEnd);
                        native.InsertRangeWithBeginEnd(randomIndex, randomEnd);

                        AssertEquality(native, managed);

                        native.Dispose(default);
                        managed.Dispose(default);
                    }
                }
            );
        }

        [Test]
        public static void InsertRange_ToFromX()
        {
            BitIntMock.ForEachBitInt
            (
                (_) => 
                {
                    BitIntMock2.ForEachBitInt
                    (
                        (rng) =>
                        {
                            for (int i = 0; i < 4; i++)
                            {
                                int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                                int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);

                                int dstIndex = (int)rng.NextLong(0, baseLength);
                                int srcIndex = (int)rng.NextLong(0, operandLength);
                                int srcCount = (int)rng.NextLong(0, operandLength - srcIndex);

                                long minValue = math.max(default(BitIntMock).MinValueAsLong, default(BitIntMock2).MinValueAsLong);
                                long maxValue = math.min(default(BitIntMock).MaxValueAsLong, default(BitIntMock2).MaxValueAsLong);

                                CreateSyncedLists(baseLength, out NativeBitIntList<BitIntMock> dst, out NativeBitIntList<BitIntMock> dstCMP, ref rng, minValue, maxValue);
                                NativeBitIntList<BitIntMock2> src = CreateRandomBitIntMockList<BitIntMock2>(operandLength, ref rng, minValue, maxValue);

                                dst.InsertRange(dstIndex, src, srcCount, srcIndex);

                                Assert.AreEqual(dst.Length, baseLength + srcCount);
                                for (int j = 0; j < dstIndex; j++)
                                {
                                    Assert.AreEqual(dst[j], dstCMP[j]);
                                }
                                for (int j = 0; j < srcCount; j++)
                                {
                                    Assert.AreEqual(dst[j + dstIndex], src[j + srcIndex]);
                                }
                                for (int j = dstIndex + srcCount; j < dst.Length; j++)
                                {
                                    Assert.AreEqual(dst[j], dstCMP[j - srcCount]);
                                }

                                dst.Dispose(default);
                                dstCMP.Dispose(default);
                                src.Dispose(default);
                            }
                        }
                    );
                }
            );
        }

        [Test]
        public static void Sort()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int length = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        CreateSyncedLists(length, out NativeBitIntList<BitIntMock> native, out NativeList<long> managed, ref rng);

                        managed.Sort();
                        native.Sort();

                        AssertEquality(native, managed);

                        native.Dispose(default);
                        managed.Dispose(default);
                    }
                }
            );
        }

        [Test]
        public static void IndexOf()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int length = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        CreateSyncedLists(length, out NativeBitIntList<BitIntMock> native, out NativeList<long> managed, ref rng);

                        for (int j = 0; j < 16; j++)
                        {
                            long randomValue = BitIntMock.Random(ref rng);
                            int m = managed.SIMD_IndexOf(randomValue);
                            int n = native.IndexOf(randomValue);

                            Assert.AreEqual(m, n);
                        }

                        native.Dispose(default);
                        managed.Dispose(default);
                    }
                }
            );
        }

        [Test]
        public static void Contains()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int length = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        CreateSyncedLists(length, out NativeBitIntList<BitIntMock> native, out NativeList<long> managed, ref rng);

                        for (int j = 0; j < 16; j++)
                        {
                            long randomValue = BitIntMock.Random(ref rng);
                            bool m = managed.SIMD_Contains(randomValue);
                            bool n = native.Contains(randomValue);

                            Assert.AreEqual(m, n);
                        }

                        native.Dispose(default);
                        managed.Dispose(default);
                    }
                }
            );
        }

        [Test]
        public static void Count()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int length = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        CreateSyncedLists(length, out NativeBitIntList<BitIntMock> native, out NativeList<long> managed, ref rng);

                        for (int j = 0; j < 16; j++)
                        {
                            long randomValue = BitIntMock.Random(ref rng);
                            int m = managed.SIMD_Count(randomValue);
                            int n = native.Count(randomValue);

                            Assert.AreEqual(m, n);
                        }

                        native.Dispose(default);
                        managed.Dispose(default);
                    }
                }
            );
        }

        [Test]
        public static void ToArray()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int length = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        NativeBitIntList<BitIntMock> src = CreateRandomBitIntMockList<BitIntMock>(length, ref rng);
                        NativeBitIntArray<BitIntMock> cpy = src.ToArray(Allocator.Persistent);

                        AssertEquality(src, cpy);

                        src.Dispose(default);
                        cpy.Dispose(default);
                    }
                }
            );
        }

        [Test]
        public static void AddRange_ToFromBitInt()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    BitIntMock2.ForEachBitInt
                    (
                        (rng2) =>
                        {
                            int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                            int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                            CreateSyncedLists(baseLength, out NativeBitIntList<BitIntMock> largerBitfield, out NativeBitIntList<BitIntMock2> smallerBitfield, ref rng);
                            NativeBitIntList<BitIntMock2> operand = CreateRandomBitIntMockList<BitIntMock2>(operandLength, ref rng);

                            largerBitfield.AddRange(operand);
                            smallerBitfield.AddRange(operand);

                            AssertEquality(largerBitfield, smallerBitfield);

                            largerBitfield.Dispose();
                            smallerBitfield.Dispose();
                            operand.Dispose();
                        },
                        maxBits: default(BitIntMock).Bits,
                        unsigned: !default(BitIntMock).IsSigned,
                        signed: default(BitIntMock).IsSigned
                    );
                }
            );
        }

        [Test]
        public static void AddRange_FromByte()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        CreateSyncedLists(baseLength, out NativeBitIntList<BitIntMock> bitfield, out NativeList<byte> register, ref rng);
                        NativeList<byte> operand = CreateRandomByteList(operandLength, ref rng);

                        bitfield.AddRange(operand);
                        register.AddRange(operand.AsArray());

                        AssertEquality(bitfield, register);

                        bitfield.Dispose(default);
                        register.Dispose(default);
                        operand.Dispose(default);
                    }
                },
                maxBits: 8,
                unsigned: true,
                signed: false
            );
        }

        [Test]
        public static void AddRange_FromSByte()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        CreateSyncedLists(baseLength, out NativeBitIntList<BitIntMock> bitfield, out NativeList<sbyte> register, ref rng);
                        NativeList<sbyte> operand = CreateRandomSByteList(operandLength, ref rng);

                        bitfield.AddRange(operand);
                        register.AddRange(operand.AsArray());

                        AssertEquality(bitfield, register);

                        bitfield.Dispose(default);
                        register.Dispose(default);
                        operand.Dispose(default);
                    }
                },
                maxBits: 8,
                unsigned: false,
                signed: true
            );
        }

        [Test]
        public static void AddRange_FromUShort()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        CreateSyncedLists(baseLength, out NativeBitIntList<BitIntMock> bitfield, out NativeList<ushort> register, ref rng);
                        NativeList<ushort> operand = CreateRandomUShortList(operandLength, ref rng);

                        bitfield.AddRange(operand);
                        register.AddRange(operand.AsArray());

                        AssertEquality(bitfield, register);

                        bitfield.Dispose(default);
                        register.Dispose(default);
                        operand.Dispose(default);
                    }
                },
                maxBits: 16,
                unsigned: true,
                signed: false
            );
        }

        [Test]
        public static void AddRange_FromShort()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        CreateSyncedLists(baseLength, out NativeBitIntList<BitIntMock> bitfield, out NativeList<short> register, ref rng);
                        NativeList<short> operand = CreateRandomShortList(operandLength, ref rng);

                        bitfield.AddRange(operand);
                        register.AddRange(operand.AsArray());

                        AssertEquality(bitfield, register);

                        bitfield.Dispose(default);
                        register.Dispose(default);
                        operand.Dispose(default);
                    }
                },
                maxBits: 16,
                unsigned: false,
                signed: true
            );
        }

        [Test]
        public static void AddRange_FromUInt24()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        CreateSyncedLists(baseLength, out NativeBitIntList<BitIntMock> bitfield, out NativeList<UInt24> register, ref rng);
                        NativeList<UInt24> operand = CreateRandomUInt24List(operandLength, ref rng);

                        bitfield.AddRange(operand);
                        register.AddRange(operand.AsArray());

                        AssertEquality(bitfield, register);

                        bitfield.Dispose(default);
                        register.Dispose(default);
                        operand.Dispose(default);
                    }
                },
                maxBits: 24,
                unsigned: true,
                signed: false
            );
        }

        [Test]
        public static void AddRange_FromInt24()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        CreateSyncedLists(baseLength, out NativeBitIntList<BitIntMock> bitfield, out NativeList<Int24> register, ref rng);
                        NativeList<Int24> operand = CreateRandomInt24List(operandLength, ref rng);

                        bitfield.AddRange(operand);
                        register.AddRange(operand.AsArray());

                        AssertEquality(bitfield, register);

                        bitfield.Dispose(default);
                        register.Dispose(default);
                        operand.Dispose(default);
                    }
                },
                maxBits: 24,
                unsigned: false,
                signed: true
            );
        }

        [Test]
        public static void AddRange_FromUInt()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        CreateSyncedLists(baseLength, out NativeBitIntList<BitIntMock> bitfield, out NativeList<uint> register, ref rng);
                        NativeList<uint> operand = CreateRandomUIntList(operandLength, ref rng);

                        bitfield.AddRange(operand);
                        register.AddRange(operand.AsArray());

                        AssertEquality(bitfield, register);

                        bitfield.Dispose(default);
                        register.Dispose(default);
                        operand.Dispose(default);
                    }
                },
                maxBits: 32,
                unsigned: true,
                signed: false
            );
        }

        [Test]
        public static void AddRange_FromInt()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        CreateSyncedLists(baseLength, out NativeBitIntList<BitIntMock> bitfield, out NativeList<int> register, ref rng);
                        NativeList<int> operand = CreateRandomIntList(operandLength, ref rng);

                        bitfield.AddRange(operand);
                        register.AddRange(operand.AsArray());

                        AssertEquality(bitfield, register);

                        bitfield.Dispose(default);
                        register.Dispose(default);
                        operand.Dispose(default);
                    }
                },
                maxBits: 32,
                unsigned: false,
                signed: true
            );
        }

        [Test]
        public static void AddRange_FromUInt40()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        CreateSyncedLists(baseLength, out NativeBitIntList<BitIntMock> bitfield, out NativeList<UInt40> register, ref rng);
                        NativeList<UInt40> operand = CreateRandomUInt40List(operandLength, ref rng);

                        bitfield.AddRange(operand);
                        register.AddRange(operand.AsArray());

                        AssertEquality(bitfield, register);

                        bitfield.Dispose(default);
                        register.Dispose(default);
                        operand.Dispose(default);
                    }
                },
                maxBits: 40,
                unsigned: true,
                signed: false
            );
        }

        [Test]
        public static void AddRange_FromInt40()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        CreateSyncedLists(baseLength, out NativeBitIntList<BitIntMock> bitfield, out NativeList<Int40> register, ref rng);
                        NativeList<Int40> operand = CreateRandomInt40List(operandLength, ref rng);

                        bitfield.AddRange(operand);
                        register.AddRange(operand.AsArray());

                        AssertEquality(bitfield, register);

                        bitfield.Dispose(default);
                        register.Dispose(default);
                        operand.Dispose(default);
                    }
                },
                maxBits: 40,
                unsigned: false,
                signed: true
            );
        }

        [Test]
        public static void AddRange_FromUInt48()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        CreateSyncedLists(baseLength, out NativeBitIntList<BitIntMock> bitfield, out NativeList<UInt48> register, ref rng);
                        NativeList<UInt48> operand = CreateRandomUInt48List(operandLength, ref rng);

                        bitfield.AddRange(operand);
                        register.AddRange(operand.AsArray());

                        AssertEquality(bitfield, register);

                        bitfield.Dispose(default);
                        register.Dispose(default);
                        operand.Dispose(default);
                    }
                },
                maxBits: 48,
                unsigned: true,
                signed: false
            );
        }

        [Test]
        public static void AddRange_FromInt48()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        CreateSyncedLists(baseLength, out NativeBitIntList<BitIntMock> bitfield, out NativeList<Int48> register, ref rng);
                        NativeList<Int48> operand = CreateRandomInt48List(operandLength, ref rng);

                        bitfield.AddRange(operand);
                        register.AddRange(operand.AsArray());

                        AssertEquality(bitfield, register);

                        bitfield.Dispose(default);
                        register.Dispose(default);
                        operand.Dispose(default);
                    }
                },
                maxBits: 48,
                unsigned: false,
                signed: true
            );
        }

        [Test]
        public static void AddRange_FromUInt56()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        CreateSyncedLists(baseLength, out NativeBitIntList<BitIntMock> bitfield, out NativeList<UInt56> register, ref rng);
                        NativeList<UInt56> operand = CreateRandomUInt56List(operandLength, ref rng);

                        bitfield.AddRange(operand);
                        register.AddRange(operand.AsArray());

                        AssertEquality(bitfield, register);

                        bitfield.Dispose(default);
                        register.Dispose(default);
                        operand.Dispose(default);
                    }
                },
                maxBits: 56,
                unsigned: true,
                signed: false
            );
        }

        [Test]
        public static void AddRange_FromInt56()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        CreateSyncedLists(baseLength, out NativeBitIntList<BitIntMock> bitfield, out NativeList<Int56> register, ref rng);
                        NativeList<Int56> operand = CreateRandomInt56List(operandLength, ref rng);

                        bitfield.AddRange(operand);
                        register.AddRange(operand.AsArray());

                        AssertEquality(bitfield, register);

                        bitfield.Dispose(default);
                        register.Dispose(default);
                        operand.Dispose(default);
                    }
                },
                maxBits: 56,
                unsigned: false,
                signed: true
            );
        }

        [Test]
        public static void AddRange_FromULong()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        CreateSyncedLists(baseLength, out NativeBitIntList<BitIntMock> bitfield, out NativeList<ulong> register, ref rng);
                        NativeList<ulong> operand = CreateRandomULongList(operandLength, ref rng);

                        bitfield.AddRange(operand);
                        register.AddRange(operand.AsArray());

                        AssertEquality(bitfield, register);

                        bitfield.Dispose(default);
                        register.Dispose(default);
                        operand.Dispose(default);
                    }
                },
                maxBits: 63,
                unsigned: true,
                signed: false
            );
        }

        [Test]
        public static void AddRange_FromLong()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        CreateSyncedLists(baseLength, out NativeBitIntList<BitIntMock> bitfield, out NativeList<long> register, ref rng);
                        NativeList<long> operand = CreateRandomLongList(operandLength, ref rng);

                        bitfield.AddRange(operand);
                        register.AddRange(operand.AsArray());

                        AssertEquality(bitfield, register);

                        bitfield.Dispose(default);
                        register.Dispose(default);
                        operand.Dispose(default);
                    }
                },
                maxBits: 63,
                unsigned: false,
                signed: true
            );
        }

        [Test]
        public static void AddRange_FromUInt128()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        CreateSyncedLists(baseLength, out NativeBitIntList<BitIntMock> bitfield, out NativeList<UInt128> register, ref rng);
                        NativeList<UInt128> operand = CreateRandomUInt128List(operandLength, ref rng);

                        bitfield.AddRange(operand);
                        register.AddRange(operand.AsArray());

                        AssertEquality(bitfield, register);

                        bitfield.Dispose(default);
                        register.Dispose(default);
                        operand.Dispose(default);
                    }
                },
                maxBits: 63,
                unsigned: true,
                signed: false
            );
        }

        [Test]
        public static void AddRange_FromInt128()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        CreateSyncedLists(baseLength, out NativeBitIntList<BitIntMock> bitfield, out NativeList<Int128> register, ref rng);
                        NativeList<Int128> operand = CreateRandomInt128List(operandLength, ref rng);

                        bitfield.AddRange(operand);
                        register.AddRange(operand.AsArray());

                        AssertEquality(bitfield, register);

                        bitfield.Dispose(default);
                        register.Dispose(default);
                        operand.Dispose(default);
                    }
                },
                maxBits: 63,
                unsigned: false,
                signed: true
            );
        }

        [Test]
        public static void AddRange_ToByte()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        NativeBitIntList<BitIntMock> bitfield = CreateRandomBitIntMockList<BitIntMock>(baseLength, ref rng, byte.MinValue, byte.MaxValue);
                        NativeBitIntList<BitIntMock> operandCmp = CreateRandomBitIntMockList<BitIntMock>(operandLength, ref rng, byte.MinValue, byte.MaxValue);
                        NativeList<byte> operand1 = new NativeList<byte>(operandLength, Allocator.Persistent);
                        List<byte> operand2 = new List<byte>(operandLength);
                        for (int j = 0; j < operandLength; j++)
                        {
                            operand1.Add((byte)operandCmp[j]);
                            operand2.Add((byte)operandCmp[j]);
                        }

                        operandCmp.AddRange(bitfield);
                        operand1.AddRange(bitfield);
                        operand2.AddRange(bitfield);

                        AssertEquality(operandCmp, operand1);
                        AssertEquality(operandCmp, operand2);

                        bitfield.Dispose(default);
                        operandCmp.Dispose(default);
                        operand1.Dispose(default);
                    }
                },
                maxBits: 63,
                unsigned: true,
                signed: true
            );
        }

        [Test]
        public static void AddRange_ToSByte()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        NativeBitIntList<BitIntMock> bitfield = CreateRandomBitIntMockList<BitIntMock>(baseLength, ref rng, sbyte.MinValue, sbyte.MaxValue);
                        NativeBitIntList<BitIntMock> operandCmp = CreateRandomBitIntMockList<BitIntMock>(operandLength, ref rng, sbyte.MinValue, sbyte.MaxValue);
                        NativeList<sbyte> operand1 = new NativeList<sbyte>(operandLength, Allocator.Persistent);
                        List<sbyte> operand2 = new List<sbyte>(operandLength);
                        for (int j = 0; j < operandLength; j++)
                        {
                            operand1.Add((sbyte)operandCmp[j]);
                            operand2.Add((sbyte)operandCmp[j]);
                        }

                        operandCmp.AddRange(bitfield);
                        operand1.AddRange(bitfield);
                        operand2.AddRange(bitfield);

                        AssertEquality(operandCmp, operand1);
                        AssertEquality(operandCmp, operand2);

                        bitfield.Dispose(default);
                        operandCmp.Dispose(default);
                        operand1.Dispose(default);
                    }
                },
                maxBits: 63,
                unsigned: true,
                signed: true
            );
        }

        [Test]
        public static void AddRange_ToUShort()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        NativeBitIntList<BitIntMock> bitfield = CreateRandomBitIntMockList<BitIntMock>(baseLength, ref rng, ushort.MinValue, ushort.MaxValue);
                        NativeBitIntList<BitIntMock> operandCmp = CreateRandomBitIntMockList<BitIntMock>(operandLength, ref rng, ushort.MinValue, ushort.MaxValue);
                        NativeList<ushort> operand1 = new NativeList<ushort>(operandLength, Allocator.Persistent);
                        List<ushort> operand2 = new List<ushort>(operandLength);
                        for (int j = 0; j < operandLength; j++)
                        {
                            operand1.Add((ushort)operandCmp[j]);
                            operand2.Add((ushort)operandCmp[j]);
                        }

                        operandCmp.AddRange(bitfield);
                        operand1.AddRange(bitfield);
                        operand2.AddRange(bitfield);

                        AssertEquality(operandCmp, operand1);
                        AssertEquality(operandCmp, operand2);

                        bitfield.Dispose(default);
                        operandCmp.Dispose(default);
                        operand1.Dispose(default);
                    }
                },
                maxBits: 63,
                unsigned: true,
                signed: true
            );
        }

        [Test]
        public static void AddRange_ToShort()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        NativeBitIntList<BitIntMock> bitfield = CreateRandomBitIntMockList<BitIntMock>(baseLength, ref rng, short.MinValue, short.MaxValue);
                        NativeBitIntList<BitIntMock> operandCmp = CreateRandomBitIntMockList<BitIntMock>(operandLength, ref rng, short.MinValue, short.MaxValue);
                        NativeList<short> operand1 = new NativeList<short>(operandLength, Allocator.Persistent);
                        List<short> operand2 = new List<short>(operandLength);
                        for (int j = 0; j < operandLength; j++)
                        {
                            operand1.Add((short)operandCmp[j]);
                            operand2.Add((short)operandCmp[j]);
                        }

                        operandCmp.AddRange(bitfield);
                        operand1.AddRange(bitfield);
                        operand2.AddRange(bitfield);

                        AssertEquality(operandCmp, operand1);
                        AssertEquality(operandCmp, operand2);

                        bitfield.Dispose(default);
                        operandCmp.Dispose(default);
                        operand1.Dispose(default);
                    }
                },
                maxBits: 63,
                unsigned: true,
                signed: true
            );
        }

        [Test]
        public static void AddRange_ToUInt24()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        NativeBitIntList<BitIntMock> bitfield = CreateRandomBitIntMockList<BitIntMock>(baseLength, ref rng, UInt24.MinValue, UInt24.MaxValue);
                        NativeBitIntList<BitIntMock> operandCmp = CreateRandomBitIntMockList<BitIntMock>(operandLength, ref rng, UInt24.MinValue, UInt24.MaxValue);
                        NativeList<UInt24> operand1 = new NativeList<UInt24>(operandLength, Allocator.Persistent);
                        List<UInt24> operand2 = new List<UInt24>(operandLength);
                        for (int j = 0; j < operandLength; j++)
                        {
                            operand1.Add((UInt24)operandCmp[j]);
                            operand2.Add((UInt24)operandCmp[j]);
                        }

                        operandCmp.AddRange(bitfield);
                        operand1.AddRange(bitfield);
                        operand2.AddRange(bitfield);

                        AssertEquality(operandCmp, operand1);
                        AssertEquality(operandCmp, operand2);

                        bitfield.Dispose(default);
                        operandCmp.Dispose(default);
                        operand1.Dispose(default);
                    }
                },
                maxBits: 63,
                unsigned: true,
                signed: true
            );
        }

        [Test]
        public static void AddRange_ToInt24()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        NativeBitIntList<BitIntMock> bitfield = CreateRandomBitIntMockList<BitIntMock>(baseLength, ref rng, Int24.MinValue, Int24.MaxValue);
                        NativeBitIntList<BitIntMock> operandCmp = CreateRandomBitIntMockList<BitIntMock>(operandLength, ref rng, Int24.MinValue, Int24.MaxValue);
                        NativeList<Int24> operand1 = new NativeList<Int24>(operandLength, Allocator.Persistent);
                        List<Int24> operand2 = new List<Int24>(operandLength);
                        for (int j = 0; j < operandLength; j++)
                        {
                            operand1.Add((Int24)operandCmp[j]);
                            operand2.Add((Int24)operandCmp[j]);
                        }

                        operandCmp.AddRange(bitfield);
                        operand1.AddRange(bitfield);
                        operand2.AddRange(bitfield);

                        AssertEquality(operandCmp, operand1);
                        AssertEquality(operandCmp, operand2);

                        bitfield.Dispose(default);
                        operandCmp.Dispose(default);
                        operand1.Dispose(default);
                    }
                },
                maxBits: 63,
                unsigned: true,
                signed: true
            );
        }

        [Test]
        public static void AddRange_ToUInt()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        NativeBitIntList<BitIntMock> bitfield = CreateRandomBitIntMockList<BitIntMock>(baseLength, ref rng, uint.MinValue, uint.MaxValue);
                        NativeBitIntList<BitIntMock> operandCmp = CreateRandomBitIntMockList<BitIntMock>(operandLength, ref rng, uint.MinValue, uint.MaxValue);
                        NativeList<uint> operand1 = new NativeList<uint>(operandLength, Allocator.Persistent);
                        List<uint> operand2 = new List<uint>(operandLength);
                        for (int j = 0; j < operandLength; j++)
                        {
                            operand1.Add((uint)operandCmp[j]);
                            operand2.Add((uint)operandCmp[j]);
                        }

                        operandCmp.AddRange(bitfield);
                        operand1.AddRange(bitfield);
                        operand2.AddRange(bitfield);

                        AssertEquality(operandCmp, operand1);
                        AssertEquality(operandCmp, operand2);

                        bitfield.Dispose(default);
                        operandCmp.Dispose(default);
                        operand1.Dispose(default);
                    }
                },
                maxBits: 63,
                unsigned: true,
                signed: true
            );
        }

        [Test]
        public static void AddRange_ToInt()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        NativeBitIntList<BitIntMock> bitfield = CreateRandomBitIntMockList<BitIntMock>(baseLength, ref rng, int.MinValue, int.MaxValue);
                        NativeBitIntList<BitIntMock> operandCmp = CreateRandomBitIntMockList<BitIntMock>(operandLength, ref rng, int.MinValue, int.MaxValue);
                        NativeList<int> operand1 = new NativeList<int>(operandLength, Allocator.Persistent);
                        List<int> operand2 = new List<int>(operandLength);
                        for (int j = 0; j < operandLength; j++)
                        {
                            operand1.Add((int)operandCmp[j]);
                            operand2.Add((int)operandCmp[j]);
                        }

                        operandCmp.AddRange(bitfield);
                        operand1.AddRange(bitfield);
                        operand2.AddRange(bitfield);

                        AssertEquality(operandCmp, operand1);
                        AssertEquality(operandCmp, operand2);

                        bitfield.Dispose(default);
                        operandCmp.Dispose(default);
                        operand1.Dispose(default);
                    }
                },
                maxBits: 63,
                unsigned: true,
                signed: true
            );
        }

        [Test]
        public static void AddRange_ToUInt40()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        NativeBitIntList<BitIntMock> bitfield = CreateRandomBitIntMockList<BitIntMock>(baseLength, ref rng, (long)UInt40.MinValue, (long)UInt40.MaxValue);
                        NativeBitIntList<BitIntMock> operandCmp = CreateRandomBitIntMockList<BitIntMock>(operandLength, ref rng, (long)UInt40.MinValue, (long)UInt40.MaxValue);
                        NativeList<UInt40> operand1 = new NativeList<UInt40>(operandLength, Allocator.Persistent);
                        List<UInt40> operand2 = new List<UInt40>(operandLength);
                        for (int j = 0; j < operandLength; j++)
                        {
                            operand1.Add((UInt40)operandCmp[j]);
                            operand2.Add((UInt40)operandCmp[j]);
                        }

                        operandCmp.AddRange(bitfield);
                        operand1.AddRange(bitfield);
                        operand2.AddRange(bitfield);

                        AssertEquality(operandCmp, operand1);
                        AssertEquality(operandCmp, operand2);

                        bitfield.Dispose(default);
                        operandCmp.Dispose(default);
                        operand1.Dispose(default);
                    }
                },
                maxBits: 63,
                unsigned: true,
                signed: true
            );
        }

        [Test]
        public static void AddRange_ToInt40()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        NativeBitIntList<BitIntMock> bitfield = CreateRandomBitIntMockList<BitIntMock>(baseLength, ref rng, Int40.MinValue, Int40.MaxValue);
                        NativeBitIntList<BitIntMock> operandCmp = CreateRandomBitIntMockList<BitIntMock>(operandLength, ref rng, Int40.MinValue, Int40.MaxValue);
                        NativeList<Int40> operand1 = new NativeList<Int40>(operandLength, Allocator.Persistent);
                        List<Int40> operand2 = new List<Int40>(operandLength);
                        for (int j = 0; j < operandLength; j++)
                        {
                            operand1.Add((Int40)operandCmp[j]);
                            operand2.Add((Int40)operandCmp[j]);
                        }

                        operandCmp.AddRange(bitfield);
                        operand1.AddRange(bitfield);
                        operand2.AddRange(bitfield);

                        AssertEquality(operandCmp, operand1);
                        AssertEquality(operandCmp, operand2);

                        bitfield.Dispose(default);
                        operandCmp.Dispose(default);
                        operand1.Dispose(default);
                    }
                },
                maxBits: 63,
                unsigned: true,
                signed: true
            );
        }

        [Test]
        public static void AddRange_ToUInt48()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        NativeBitIntList<BitIntMock> bitfield = CreateRandomBitIntMockList<BitIntMock>(baseLength, ref rng, (long)UInt48.MinValue, (long)UInt48.MaxValue);
                        NativeBitIntList<BitIntMock> operandCmp = CreateRandomBitIntMockList<BitIntMock>(operandLength, ref rng, (long)UInt48.MinValue, (long)UInt48.MaxValue);
                        NativeList<UInt48> operand1 = new NativeList<UInt48>(operandLength, Allocator.Persistent);
                        List<UInt48> operand2 = new List<UInt48>(operandLength);
                        for (int j = 0; j < operandLength; j++)
                        {
                            operand1.Add((UInt48)operandCmp[j]);
                            operand2.Add((UInt48)operandCmp[j]);
                        }

                        operandCmp.AddRange(bitfield);
                        operand1.AddRange(bitfield);
                        operand2.AddRange(bitfield);

                        AssertEquality(operandCmp, operand1);
                        AssertEquality(operandCmp, operand2);

                        bitfield.Dispose(default);
                        operandCmp.Dispose(default);
                        operand1.Dispose(default);
                    }
                },
                maxBits: 63,
                unsigned: true,
                signed: true
            );
        }

        [Test]
        public static void AddRange_ToInt48()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        NativeBitIntList<BitIntMock> bitfield = CreateRandomBitIntMockList<BitIntMock>(baseLength, ref rng, Int48.MinValue, Int48.MaxValue);
                        NativeBitIntList<BitIntMock> operandCmp = CreateRandomBitIntMockList<BitIntMock>(operandLength, ref rng, Int48.MinValue, Int48.MaxValue);
                        NativeList<Int48> operand1 = new NativeList<Int48>(operandLength, Allocator.Persistent);
                        List<Int48> operand2 = new List<Int48>(operandLength);
                        for (int j = 0; j < operandLength; j++)
                        {
                            operand1.Add((Int48)operandCmp[j]);
                            operand2.Add((Int48)operandCmp[j]);
                        }

                        operandCmp.AddRange(bitfield);
                        operand1.AddRange(bitfield);
                        operand2.AddRange(bitfield);

                        AssertEquality(operandCmp, operand1);
                        AssertEquality(operandCmp, operand2);

                        bitfield.Dispose(default);
                        operandCmp.Dispose(default);
                        operand1.Dispose(default);
                    }
                },
                maxBits: 63,
                unsigned: true,
                signed: true
            );
        }

        [Test]
        public static void AddRange_ToUInt56()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        NativeBitIntList<BitIntMock> bitfield = CreateRandomBitIntMockList<BitIntMock>(baseLength, ref rng, (long)UInt56.MinValue, (long)UInt56.MaxValue);
                        NativeBitIntList<BitIntMock> operandCmp = CreateRandomBitIntMockList<BitIntMock>(operandLength, ref rng, (long)UInt56.MinValue, (long)UInt56.MaxValue);
                        NativeList<UInt56> operand1 = new NativeList<UInt56>(operandLength, Allocator.Persistent);
                        List<UInt56> operand2 = new List<UInt56>(operandLength);
                        for (int j = 0; j < operandLength; j++)
                        {
                            operand1.Add((UInt56)operandCmp[j]);
                            operand2.Add((UInt56)operandCmp[j]);
                        }

                        operandCmp.AddRange(bitfield);
                        operand1.AddRange(bitfield);
                        operand2.AddRange(bitfield);

                        AssertEquality(operandCmp, operand1);
                        AssertEquality(operandCmp, operand2);

                        bitfield.Dispose(default);
                        operandCmp.Dispose(default);
                        operand1.Dispose(default);
                    }
                },
                maxBits: 63,
                unsigned: true,
                signed: true
            );
        }

        [Test]
        public static void AddRange_ToInt56()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        NativeBitIntList<BitIntMock> bitfield = CreateRandomBitIntMockList<BitIntMock>(baseLength, ref rng, Int56.MinValue, Int56.MaxValue);
                        NativeBitIntList<BitIntMock> operandCmp = CreateRandomBitIntMockList<BitIntMock>(operandLength, ref rng, Int56.MinValue, Int56.MaxValue);
                        NativeList<Int56> operand1 = new NativeList<Int56>(operandLength, Allocator.Persistent);
                        List<Int56> operand2 = new List<Int56>(operandLength);
                        for (int j = 0; j < operandLength; j++)
                        {
                            operand1.Add((Int56)operandCmp[j]);
                            operand2.Add((Int56)operandCmp[j]);
                        }

                        operandCmp.AddRange(bitfield);
                        operand1.AddRange(bitfield);
                        operand2.AddRange(bitfield);

                        AssertEquality(operandCmp, operand1);
                        AssertEquality(operandCmp, operand2);

                        bitfield.Dispose(default);
                        operandCmp.Dispose(default);
                        operand1.Dispose(default);
                    }
                },
                maxBits: 63,
                unsigned: true,
                signed: true
            );
        }

        [Test]
        public static void AddRange_ToULong()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        NativeBitIntList<BitIntMock> bitfield = CreateRandomBitIntMockList<BitIntMock>(baseLength, ref rng, 0);
                        NativeBitIntList<BitIntMock> operandCmp = CreateRandomBitIntMockList<BitIntMock>(operandLength, ref rng, 0);
                        NativeList<ulong> operand1 = new NativeList<ulong>(operandLength, Allocator.Persistent);
                        List<ulong> operand2 = new List<ulong>(operandLength);
                        for (int j = 0; j < operandLength; j++)
                        {
                            operand1.Add((ulong)operandCmp[j]);
                            operand2.Add((ulong)operandCmp[j]);
                        }

                        operandCmp.AddRange(bitfield);
                        operand1.AddRange(bitfield);
                        operand2.AddRange(bitfield);

                        AssertEquality(operandCmp, operand1);
                        AssertEquality(operandCmp, operand2);

                        bitfield.Dispose(default);
                        operandCmp.Dispose(default);
                        operand1.Dispose(default);
                    }
                },
                maxBits: 63,
                unsigned: true,
                signed: true
            );
        }

        [Test]
        public static void AddRange_ToLong()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        NativeBitIntList<BitIntMock> bitfield = CreateRandomBitIntMockList<BitIntMock>(baseLength, ref rng, long.MinValue, long.MaxValue);
                        NativeBitIntList<BitIntMock> operandCmp = CreateRandomBitIntMockList<BitIntMock>(operandLength, ref rng, long.MinValue, long.MaxValue);
                        NativeList<long> operand1 = new NativeList<long>(operandLength, Allocator.Persistent);
                        List<long> operand2 = new List<long>(operandLength);
                        for (int j = 0; j < operandLength; j++)
                        {
                            operand1.Add((long)operandCmp[j]);
                            operand2.Add((long)operandCmp[j]);
                        }

                        operandCmp.AddRange(bitfield);
                        operand1.AddRange(bitfield);
                        operand2.AddRange(bitfield);

                        AssertEquality(operandCmp, operand1);
                        AssertEquality(operandCmp, operand2);

                        bitfield.Dispose(default);
                        operandCmp.Dispose(default);
                        operand1.Dispose(default);
                    }
                },
                maxBits: 63,
                unsigned: true,
                signed: true
            );
        }

        [Test]
        public static void AddRange_ToUInt128()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        NativeBitIntList<BitIntMock> bitfield = CreateRandomBitIntMockList<BitIntMock>(baseLength, ref rng, 0);
                        NativeBitIntList<BitIntMock> operandCmp = CreateRandomBitIntMockList<BitIntMock>(operandLength, ref rng, 0);
                        NativeList<UInt128> operand1 = new NativeList<UInt128>(operandLength, Allocator.Persistent);
                        List<UInt128> operand2 = new List<UInt128>(operandLength);
                        for (int j = 0; j < operandLength; j++)
                        {
                            operand1.Add((UInt128)operandCmp[j]);
                            operand2.Add((UInt128)operandCmp[j]);
                        }

                        operandCmp.AddRange(bitfield);
                        operand1.AddRange(bitfield);
                        operand2.AddRange(bitfield);

                        AssertEquality(operandCmp, operand1);
                        AssertEquality(operandCmp, operand2);

                        bitfield.Dispose(default);
                        operandCmp.Dispose(default);
                        operand1.Dispose(default);
                    }
                },
                maxBits: 63,
                unsigned: true,
                signed: true
            );
        }

        [Test]
        public static void AddRange_ToInt128()
        {
            BitIntMock.ForEachBitInt
            (
                (rng) =>
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                        NativeBitIntList<BitIntMock> bitfield = CreateRandomBitIntMockList<BitIntMock>(baseLength, ref rng);
                        NativeBitIntList<BitIntMock> operandCmp = CreateRandomBitIntMockList<BitIntMock>(operandLength, ref rng);
                        NativeList<Int128> operand1 = new NativeList<Int128>(operandLength, Allocator.Persistent);
                        List<Int128> operand2 = new List<Int128>(operandLength);
                        for (int j = 0; j < operandLength; j++)
                        {
                            operand1.Add((Int128)operandCmp[j]);
                            operand2.Add((Int128)operandCmp[j]);
                        }

                        operandCmp.AddRange(bitfield);
                        operand1.AddRange(bitfield);
                        operand2.AddRange(bitfield);

                        AssertEquality(operandCmp, operand1);
                        AssertEquality(operandCmp, operand2);

                        bitfield.Dispose(default);
                        operandCmp.Dispose(default);
                        operand1.Dispose(default);
                    }
                },
                maxBits: 63,
                unsigned: true,
                signed: true
            );
        }

        [Test]
        public static void AddRange_ToFromX()
        {
            BitIntMock.ForEachBitInt
            (
                (_) => 
                {
                    BitIntMock2.ForEachBitInt
                    (
                        (rng) =>
                        {
                            for (int i = 0; i < 4; i++)
                            {
                                int baseLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);
                                int operandLength = (int)rng.NextLong(1, MAX_TEST_LENGTH + 1);

                                int srcIndex = (int)rng.NextLong(0, operandLength);
                                int srcCount = (int)rng.NextLong(0, operandLength - srcIndex);

                                long minValue = math.max(default(BitIntMock).MinValueAsLong, default(BitIntMock2).MinValueAsLong);
                                long maxValue = math.min(default(BitIntMock).MaxValueAsLong, default(BitIntMock2).MaxValueAsLong);

                                CreateSyncedLists(baseLength, out NativeBitIntList<BitIntMock> dst, out NativeBitIntList<BitIntMock> dstCMP, ref rng, minValue, maxValue);
                                NativeBitIntList<BitIntMock2> src = CreateRandomBitIntMockList<BitIntMock2>(operandLength, ref rng, minValue, maxValue);

                                dst.AddRange(src, srcCount, srcIndex);

                                Assert.AreEqual(dst.Length, baseLength + srcCount);
                                for (int j = 0; j < baseLength; j++)
                                {
                                    Assert.AreEqual(dst[j], dstCMP[j]);
                                }
                                for (int j = baseLength; j < baseLength + srcCount; j++)
                                {
                                    Assert.AreEqual(dst[j], src[j + srcIndex - baseLength]);
                                }

                                dst.Dispose(default);
                                dstCMP.Dispose(default);
                                src.Dispose(default);
                            }
                        }
                    );
                }
            );
        }

        [Test]
        public static void SetReplicate()
        {
            BitIntMock.ForEachBitInt(
            (rng) =>
            {
                for (int i = 0; i < 16; i++)
                {
                    int length = (int)rng.NextLong(1, 200);
                    int startIndex = (int)rng.NextLong(0, length);
                    int count = (int)rng.NextLong(0, length - startIndex);
                    long value = BitIntMock.Random(ref rng);

                    CreateSyncedLists(length, out NativeBitIntList<BitIntMock> native, out List<long> managed, ref rng);

                    native.SetReplicate(value, startIndex, count);
                    for (int j = 0; j < startIndex; j++)
                    {
                        Assert.AreEqual(native[j], managed[j]);
                    }
                    for (int j = 0; j < count; j++)
                    {
                        Assert.AreEqual(native[j + startIndex], value);
                    }
                    for (int j = startIndex + count; j < length; j++)
                    {
                        Assert.AreEqual(native[j], managed[j]);
                    }

                    native.Dispose(default);
                }
            }
            );
        }

        private static void IndexOf_Base(Comparison where)
        {
            BitIntMock.ForEachBitInt(
            (rng) =>
            {
                for (int i = 0; i < 16; i++)
                {
                    int length = (int)rng.NextLong(1, 200);
                    int startIndex = (int)rng.NextLong(0, length);
                    int count = (int)rng.NextLong(0, length - startIndex);
                    long cmp = BitIntMock.Random(ref rng);

                    CreateSyncedLists(length, out NativeBitIntList<BitIntMock> native, out List<long> managed, ref rng);

                    int nativeIndex = native.IndexOf(cmp, startIndex, count, where);
                    int managedIndex = -1;
                    for (int j = 0; j < count; j++)
                    {
                        if (where.Compare(managed[j + startIndex], cmp))
                        {
                            managedIndex = j + startIndex;
                            break;
                        }
                    }

                    Assert.AreEqual(nativeIndex, managedIndex);

                    native.Dispose(default);
                }
            }
            );
        }

        [Test]
        public static void IndexOf_Equal()
        {
            IndexOf_Base(Comparison.EqualTo);
        }

        [Test]
        public static void IndexOf_NotEqual()
        {
            IndexOf_Base(Comparison.NotEqualTo);
        }

        [Test]
        public static void IndexOf_Greater()
        {
            IndexOf_Base(Comparison.GreaterThan);
        }

        [Test]
        public static void IndexOf_Less()
        {
            IndexOf_Base(Comparison.LessThan);
        }

        [Test]
        public static void IndexOf_GreaterOrEqual()
        {
            IndexOf_Base(Comparison.GreaterThanOrEqualTo);
        }

        [Test]
        public static void IndexOf_LessOrEqual()
        {
            IndexOf_Base(Comparison.LessThanOrEqualTo);
        }

        private static void Contains_Base(Comparison where)
        {
            BitIntMock.ForEachBitInt(
            (rng) =>
            {
                for (int i = 0; i < 16; i++)
                {
                    int length = (int)rng.NextLong(1, 200);
                    int startIndex = (int)rng.NextLong(0, length);
                    int count = (int)rng.NextLong(0, length - startIndex);
                    long cmp = BitIntMock.Random(ref rng);

                    CreateSyncedLists(length, out NativeBitIntList<BitIntMock> native, out List<long> managed, ref rng);

                    bool nativeResult = native.Contains(cmp, startIndex, count, where);
                    bool managedResult = false;
                    for (int j = 0; j < count; j++)
                    {
                        if (where.Compare(managed[j + startIndex], cmp))
                        {
                            managedResult = true;
                            break;
                        }
                    }

                    Assert.AreEqual(nativeResult, managedResult);

                    native.Dispose(default);
                }
            }
            );
        }

        [Test]
        public static void Contains_Equal()
        {
            Contains_Base(Comparison.EqualTo);
        }

        [Test]
        public static void Contains_NotEqual()
        {
            Contains_Base(Comparison.NotEqualTo);
        }

        [Test]
        public static void Contains_Greater()
        {
            Contains_Base(Comparison.GreaterThan);
        }

        [Test]
        public static void Contains_Less()
        {
            Contains_Base(Comparison.LessThan);
        }

        [Test]
        public static void Contains_GreaterOrEqual()
        {
            Contains_Base(Comparison.GreaterThanOrEqualTo);
        }

        [Test]
        public static void Contains_LessOrEqual()
        {
            Contains_Base(Comparison.LessThanOrEqualTo);
        }

        private static void Count_Base(Comparison where)
        {
            BitIntMock.ForEachBitInt(
            (rng) =>
            {
                for (int i = 0; i < 16; i++)
                {
                    int length = (int)rng.NextLong(1, 200);
                    int startIndex = (int)rng.NextLong(0, length);
                    int count = (int)rng.NextLong(0, length - startIndex);
                    long cmp = BitIntMock.Random(ref rng);

                    CreateSyncedLists(length, out NativeBitIntList<BitIntMock> native, out List<long> managed, ref rng);

                    int nativeCount = native.Count(cmp, startIndex, count, where);
                    int managedCount = 0;
                    for (int j = 0; j < count; j++)
                    {
                        if (where.Compare(managed[j + startIndex], cmp))
                        {
                            managedCount++;
                        }
                    }

                    Assert.AreEqual(nativeCount, managedCount);

                    native.Dispose(default);
                }
            }
            );
        }

        [Test]
        public static void Count_Equal()
        {
            Count_Base(Comparison.EqualTo);
        }

        [Test]
        public static void Count_NotEqual()
        {
            Count_Base(Comparison.NotEqualTo);
        }

        [Test]
        public static void Count_Greater()
        {
            Count_Base(Comparison.GreaterThan);
        }

        [Test]
        public static void Count_Less()
        {
            Count_Base(Comparison.LessThan);
        }

        [Test]
        public static void Count_GreaterOrEqual()
        {
            Count_Base(Comparison.GreaterThanOrEqualTo);
        }

        [Test]
        public static void Count_LessOrEqual()
        {
            Count_Base(Comparison.LessThanOrEqualTo);
        }

        private static void Sum_Base(TypeCode range)
        {
            BitIntMock.ForEachBitInt(
            (rng) =>
            {
                int maxLengthToTest = 0;
                switch (range)
                {
                    case TypeCode.SByte:
                    case TypeCode.Byte:
                    {
                        maxLengthToTest = 100;
                        break;
                    }
                    case TypeCode.UInt16:
                    case TypeCode.Int16:
                    {
                        maxLengthToTest = 1000;
                        break;
                    }
                    case TypeCode.UInt32:
                    case TypeCode.Int32:
                    {
                        maxLengthToTest = 10000;
                        break;
                    }
                    case TypeCode.UInt64:
                    case TypeCode.Int64:
                    {
                        maxLengthToTest = 25000;
                        break;
                    }
                    default: throw new Exception();
                }

                for (int i = 0; i < 16; i++)
                {
                    int length = (int)rng.NextLong(1, maxLengthToTest);
                    int startIndex = (int)rng.NextLong(0, length);
                    int count = (int)rng.NextLong(0, length - startIndex);

                    CreateSyncedLists(length, out NativeBitIntList<BitIntMock> native, out List<long> managed, ref rng);

                    BigInteger managedSum = 0;
                    for (int j = 0; j < count; j++)
                    {
                        managedSum += managed[j + startIndex];
                    }

                    bool test;
                    switch (range)
                    {
                        case TypeCode.SByte:
                        case TypeCode.Byte:
                        {
                            test = default(BitIntMock).IsSigned ? managedSum >= sbyte.MinValue && managedSum <= sbyte.MaxValue
                                                                : managedSum >= byte.MinValue && managedSum <= byte.MaxValue;
                            break;
                        }
                        case TypeCode.UInt16:
                        case TypeCode.Int16:
                        {
                            test = default(BitIntMock).IsSigned ? managedSum >= short.MinValue && managedSum <= short.MaxValue
                                                                : managedSum >= ushort.MinValue && managedSum <= ushort.MaxValue;
                            break;
                        }
                        case TypeCode.UInt32:
                        case TypeCode.Int32:
                        {
                            test = default(BitIntMock).IsSigned ? managedSum >= int.MinValue && managedSum <= int.MaxValue
                                                                : managedSum >= uint.MinValue && managedSum <= uint.MaxValue;
                            break;
                        }
                        case TypeCode.UInt64:
                        case TypeCode.Int64:
                        {
                            test = default(BitIntMock).IsSigned ? managedSum >= long.MinValue && managedSum <= long.MaxValue
                                                                : managedSum >= ulong.MinValue && managedSum <= ulong.MaxValue;
                            break;
                        }
                        default: throw new Exception();
                    }

                    if (test)
                    {
                        if (default(BitIntMock).IsSigned)
                        {
                            Assert.AreEqual(native.Sum(startIndex, count, range), (long)managedSum); 
                        }
                        else
                        {
                            Assert.AreEqual((ulong)native.Sum(startIndex, count, range), (ulong)managedSum); 
                        }
                    }

                    native.Dispose(default);
                }
            }
            );
        }

        [Test]
        public static void Sum_8bit()
        {
            Sum_Base(TypeCode.Byte);
        }

        [Test]
        public static void Sum_16bit()
        {
            Sum_Base(TypeCode.UInt16);
        }

        [Test]
        public static void Sum_32bit()
        {
            Sum_Base(TypeCode.UInt32);
        }

        [Test]
        public static void Sum_64bit()
        {
            Sum_Base(TypeCode.UInt64);
        }
    }
}
