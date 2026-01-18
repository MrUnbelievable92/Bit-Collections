using System.Collections.Generic;
using NUnit.Framework;
using Unity.Collections;
using Unity.Mathematics;
using MaxMath;
using Unity.Jobs;
using System;
using System.Collections;

namespace BitCollections.Tests
{
    public static class _NativeBitList
    {
        private const int MAX_TEST_LENGTH = 400;


        private static void Shrink(ref NativeList<bool> list, int startIndex)
        {
            NativeList<bool> newList = new NativeList<bool>(Allocator.Persistent);

            while (startIndex < list.Length)
            {
                newList.Add(list[startIndex++]);
            }

            list.Dispose(default(JobHandle));
            list = newList;
        }

        private static int GenerateEvenlyDivisibleBy8(ref Random32 rng, int max = MAX_TEST_LENGTH)
        {
            return maxmath.ceilmultiple(rng.NextInt(1, max), 8);
        }

        private static int GenerateNotEvenlyDivisibleBy8(ref Random32 rng, int max = MAX_TEST_LENGTH)
        {
            int result = rng.NextInt(1, max);
            result -= (result % 8 == 0) ? rng.NextInt(1, 8) : 0;

            return result;
        }

        private static void CreateSyncedLists(int length, out NativeBitList native, out NativeList<bool> managed)
        {
            native = new NativeBitList(length, Allocator.Persistent);
            managed = new NativeList<bool>(length, Allocator.Persistent);

            Random32 rng = Random32.New;

            for (int j = 0; j < length; j++)
            {
                bool next = rng.NextBool();
                native.Add(next);
                managed.Add(next);
            }
        }

        private static void CreateSyncedLists(int length, out NativeBitList native, out List<bool> managed)
        {
            native = new NativeBitList(length, Allocator.Persistent);
            managed = new List<bool>(length);

            Random32 rng = Random32.New;

            for (int j = 0; j < length; j++)
            {
                bool next = rng.NextBool();
                native.Add(next);
                managed.Add(next);
            }
        }

        private static bool[] RandomBoolArray(int length)
        {
            bool[] result = new bool[length];

            Random32 rng = Random32.New;

            for (int j = 0; j < length; j++)
            {
                result[j] = rng.NextBool();
            }

            return result;
        }

        private static List<bool> RandomBoolList(int length)
        {
            List<bool> result = new List<bool>(length);

            Random32 rng = Random32.New;

            for (int j = 0; j < length; j++)
            {
                result.Add(rng.NextBool());
            }

            return result;
        }

        private static BitArray RandomBitArray(int length)
        {
            BitArray result = new BitArray(length);

            Random32 rng = Random32.New;

            for (int j = 0; j < length; j++)
            {
                result[j] = rng.NextBool();
            }

            return result;
        }

        private static NativeArray<bool> RandomNativeArray(int length)
        {
            NativeArray<bool> result = new NativeArray<bool>(length, Allocator.Persistent);

            Random32 rng = Random32.New;

            for (int j = 0; j < length; j++)
            {
                result[j] = rng.NextBool();
            }

            return result;
        }

        private static NativeBitArray RandomNativeBitArray(int length)
        {
            NativeBitArray result = new NativeBitArray(length, Allocator.Persistent);

            Random32 rng = Random32.New;

            for (int j = 0; j < length; j++)
            {
                result[j] = rng.NextBool();
            }

            return result;
        }

        private static NativeBitList RandomNativeBitList(int length)
        {
            NativeBitList result = new NativeBitList(length, Allocator.Persistent);

            Random32 rng = Random32.New;

            for (int j = 0; j < length; j++)
            {
                result.Add(rng.NextBool());
            }

            return result;
        }

        private static void CreateSyncedLists(int length, out NativeList<bool> native, out NativeList<bool> managed)
        {
            native = new NativeList<bool>(length, Allocator.Persistent);
            managed = new NativeList<bool>(length, Allocator.Persistent);

            Random32 rng = Random32.New;

            for (int j = 0; j < length; j++)
            {
                bool next = rng.NextBool();
                native.Add(next);
                managed.Add(next);
            }
        }

        private static void AssertEquality(NativeBitList native, NativeList<bool> managed)
        {
            Assert.AreEqual(native.Length, managed.Length);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual(native[i], managed[i]);
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

        private static void AssertEquality(NativeBitList native, List<bool> managed)
        {
            Assert.AreEqual(native.Length, managed.Count);

            for (int i = 0; i < native.Length; i++)
            {
                try
                {
                    Assert.AreEqual(native[i], managed[i]);
                }
                catch
                {
                    UnityEngine.Debug.Log($"Length: {native.Length}, i: {i}");
                    native.Dispose(default);
                    throw;
                }
            }
        }


        [Test]
        public static void CapacityIsMultipleOf8()
        {
            Random32 rng = Random32.New;

            for (int i = 0; i < 16; i++)
            {
                NativeBitList arr = new NativeBitList(rng.NextInt(1, MAX_TEST_LENGTH), Allocator.Persistent);

                for (int j = 0; j < 7; j++)
                {
                    Assert.IsTrue(arr.Capacity % 8 == 0);
                    arr.Capacity++;
                    Assert.IsTrue(arr.Capacity % 8 == 0);
                    arr.Capacity += 3;
                    Assert.IsTrue(arr.Capacity % 8 == 0);
                    arr.Capacity += rng.NextInt(1, MAX_TEST_LENGTH);
                    Assert.IsTrue(arr.Capacity % 8 == 0);
                    arr.Capacity--;
                    Assert.IsTrue(arr.Capacity % 8 == 0);
                    arr.Capacity -= 5;
                    Assert.IsTrue(arr.Capacity % 8 == 0);
                    arr.Capacity -= rng.NextInt(1, arr.Capacity / 2);
                    Assert.IsTrue(arr.Capacity % 8 == 0);
                }

                arr.Dispose(default(JobHandle));
            }
        }

        [Test]
        public static void GetSet()
        {
            Random32 rng = Random32.New;

            for (int i = 0; i < 4; i++)
            {
                int length = rng.NextInt(1, MAX_TEST_LENGTH);

                using NativeBitList arr = new NativeBitList(length, Allocator.Persistent);

                for (int j = 0; j < length; j++)
                {
                    arr.Add(false);
                    Assert.IsFalse(arr[j]);
                    arr[j] = true;
                    Assert.IsTrue(arr[j]);
                }

                using NativeList<bool> cmp = new NativeList<bool>(length, Allocator.Persistent);

                for (int j = 0; j < length; j++)
                {
                    arr[j] = rng.NextBool();
                    cmp.Add(arr[j]);
                    Assert.AreEqual(arr[j], cmp[j]);
                }

                Assert.AreEqual(arr.Length, cmp.Length);

                for (int j = 0; j < length; j++)
                {
                    Assert.AreEqual(arr[j], cmp[j]);
                }
            }
        }

        [Test]
        public static void Add()
        {
            Random32 rng = Random32.New;

            for (int i = 0; i < 4; i++)
            {
                CreateSyncedLists(rng.NextInt(1, MAX_TEST_LENGTH), out NativeBitList arr, out NativeList<bool> cmp);

                AssertEquality(arr, cmp);

                arr.Dispose(default(JobHandle));
                cmp.Dispose(default(JobHandle));
            }
        }

        [Test]
        public static void Bits_AddRange_DestinationEven8_SourceEven8()
        {
            Random32 rng = Random32.New;

            for (int i = 0; i < 16; i++)
            {
                int destinationLength = GenerateEvenlyDivisibleBy8(ref rng);
                int sourceLength      = GenerateEvenlyDivisibleBy8(ref rng);
                CreateSyncedLists(destinationLength, out NativeBitList destination, out NativeList<bool> cmpDestination);
                CreateSyncedLists(sourceLength,      out NativeBitList source,      out NativeList<bool> cmpSource);

                destination.AddRange(source);
                cmpDestination.AddRange(cmpSource.AsArray());
                AssertEquality(destination, cmpDestination);

                destination.Dispose(default(JobHandle));
                cmpDestination.Dispose(default(JobHandle));
                source.Dispose(default(JobHandle));
                cmpSource.Dispose(default(JobHandle));
            }
        }

        [Test]
        public static void Bits_AddRange_DestinationNotEven8_SourceEven8()
        {
            Random32 rng = Random32.New;

            for (int i = 0; i < 16; i++)
            {
                int destinationLength = GenerateNotEvenlyDivisibleBy8(ref rng);
                int sourceLength      = GenerateEvenlyDivisibleBy8(ref rng);
                CreateSyncedLists(destinationLength, out NativeBitList destination, out NativeList<bool> cmpDestination);
                CreateSyncedLists(sourceLength,      out NativeBitList source,      out NativeList<bool> cmpSource);

                destination.AddRange(source);
                cmpDestination.AddRange(cmpSource.AsArray());
                AssertEquality(destination, cmpDestination);

                destination.Dispose(default(JobHandle));
                cmpDestination.Dispose(default(JobHandle));
                source.Dispose(default(JobHandle));
                cmpSource.Dispose(default(JobHandle));
            }
        }

        [Test]
        public static void Bits_AddRange_DestinationEven8_SourceNotEven8()
        {
            Random32 rng = Random32.New;

            for (int i = 0; i < 16; i++)
            {
                int destinationLength = GenerateEvenlyDivisibleBy8(ref rng);
                int sourceLength      = GenerateNotEvenlyDivisibleBy8(ref rng);
                CreateSyncedLists(destinationLength, out NativeBitList destination, out NativeList<bool> cmpDestination);
                CreateSyncedLists(sourceLength,      out NativeBitList source,      out NativeList<bool> cmpSource);

                destination.AddRange(source);
                cmpDestination.AddRange(cmpSource.AsArray());
                AssertEquality(destination, cmpDestination);

                destination.Dispose(default(JobHandle));
                cmpDestination.Dispose(default(JobHandle));
                source.Dispose(default(JobHandle));
                cmpSource.Dispose(default(JobHandle));
            }
        }

        [Test]
        public static void Bits_AddRange_DestinationNotEven8_SourceNotEven8()
        {
            Random32 rng = Random32.New;

            for (int i = 0; i < 16; i++)
            {
                int destinationLength = GenerateNotEvenlyDivisibleBy8(ref rng);
                int sourceLength      = GenerateNotEvenlyDivisibleBy8(ref rng);
                CreateSyncedLists(destinationLength, out NativeBitList destination, out NativeList<bool> cmpDestination);
                CreateSyncedLists(sourceLength,      out NativeBitList source,      out NativeList<bool> cmpSource);

                destination.AddRange(source);
                cmpDestination.AddRange(cmpSource.AsArray());
                AssertEquality(destination, cmpDestination);

                destination.Dispose(default(JobHandle));
                cmpDestination.Dispose(default(JobHandle));
                source.Dispose(default(JobHandle));
                cmpSource.Dispose(default(JobHandle));
            }
        }

        [Test]
        public static void Bits_AddRangeOffsetSource_DestinationEven8_SourceEven8()
        {
            Random32 rng = Random32.New;

            for (int i = 0; i < 16; i++)
            {
                int destinationLength = GenerateEvenlyDivisibleBy8(ref rng);
                int sourceLength      = GenerateEvenlyDivisibleBy8(ref rng);
                CreateSyncedLists(destinationLength, out NativeBitList destination, out NativeList<bool> cmpDestination);
                CreateSyncedLists(sourceLength,      out NativeBitList source,      out NativeList<bool> cmpSource);

                int startIndexSource = math.min(GenerateNotEvenlyDivisibleBy8(ref rng, sourceLength), sourceLength - 1);
                destination.AddRange(source, source.Length - startIndexSource, startIndexSource);
                Shrink(ref cmpSource, startIndexSource);
                cmpDestination.AddRange(cmpSource.AsArray());
                AssertEquality(destination, cmpDestination);

                destination.Dispose(default(JobHandle));
                cmpDestination.Dispose(default(JobHandle));
                source.Dispose(default(JobHandle));
                cmpSource.Dispose(default(JobHandle));
            }
        }

        [Test]
        public static void Bits_AddRangeOffsetSource_DestinationNotEven8_SourceEven8()
        {
            Random32 rng = Random32.New;

            for (int i = 0; i < 16; i++)
            {
                int destinationLength = GenerateNotEvenlyDivisibleBy8(ref rng);
                int sourceLength      = GenerateEvenlyDivisibleBy8(ref rng);
                CreateSyncedLists(destinationLength, out NativeBitList destination, out NativeList<bool> cmpDestination);
                CreateSyncedLists(sourceLength,      out NativeBitList source,      out NativeList<bool> cmpSource);

                int startIndexSource = math.min(GenerateNotEvenlyDivisibleBy8(ref rng, sourceLength), sourceLength - 1);
                destination.AddRange(source, source.Length - startIndexSource, startIndexSource);
                Shrink(ref cmpSource, startIndexSource);
                cmpDestination.AddRange(cmpSource.AsArray());
                AssertEquality(destination, cmpDestination);

                destination.Dispose(default(JobHandle));
                cmpDestination.Dispose(default(JobHandle));
                source.Dispose(default(JobHandle));
                cmpSource.Dispose(default(JobHandle));
            }
        }

        [Test]
        public static void Bits_AddRangeOffsetSource_DestinationEven8_SourceNotEven8()
        {
            Random32 rng = Random32.New;

            for (int i = 0; i < 16; i++)
            {
                int destinationLength = GenerateEvenlyDivisibleBy8(ref rng);
                int sourceLength      = GenerateNotEvenlyDivisibleBy8(ref rng);
                CreateSyncedLists(destinationLength, out NativeBitList destination, out NativeList<bool> cmpDestination);
                CreateSyncedLists(sourceLength,      out NativeBitList source,      out NativeList<bool> cmpSource);

                int startIndexSource = math.min(GenerateNotEvenlyDivisibleBy8(ref rng, sourceLength), sourceLength - 1);
                destination.AddRange(source, source.Length - startIndexSource, startIndexSource);
                Shrink(ref cmpSource, startIndexSource);
                cmpDestination.AddRange(cmpSource.AsArray());

                AssertEquality(destination, cmpDestination);

                destination.Dispose(default(JobHandle));
                cmpDestination.Dispose(default(JobHandle));
                source.Dispose(default(JobHandle));
                cmpSource.Dispose(default(JobHandle));
            }
        }

        [Test]
        public static void Bits_AddRangeOffsetSource_DestinationNotEven8_SourceNotEven8()
        {
            Random32 rng = Random32.New;

            for (int i = 0; i < 16; i++)
            {
                int destinationLength = GenerateNotEvenlyDivisibleBy8(ref rng);
                int sourceLength      = GenerateNotEvenlyDivisibleBy8(ref rng);
                CreateSyncedLists(destinationLength, out NativeBitList destination, out NativeList<bool> cmpDestination);
                CreateSyncedLists(sourceLength,      out NativeBitList source,      out NativeList<bool> cmpSource);

                int startIndexSource = math.min(GenerateNotEvenlyDivisibleBy8(ref rng, sourceLength), sourceLength - 1);
                destination.AddRange(source, source.Length - startIndexSource, startIndexSource);
                Shrink(ref cmpSource, startIndexSource);
                cmpDestination.AddRange(cmpSource.AsArray());
                AssertEquality(destination, cmpDestination);

                destination.Dispose(default(JobHandle));
                cmpDestination.Dispose(default(JobHandle));
                source.Dispose(default(JobHandle));
                cmpSource.Dispose(default(JobHandle));
            }
        }

        [Test]
        public static void Bits_AddRangeOffsetSourceSmallRange_DestinationNotEven8()
        {
            Random32 rng = Random32.New;

            for (int i = 0; i < 16; i++)
            {
                int destinationLength = GenerateNotEvenlyDivisibleBy8(ref rng);
                int sourceLength      = rng.NextInt(1, 8);
                CreateSyncedLists(destinationLength, out NativeBitList destination, out NativeList<bool> cmpDestination);
                CreateSyncedLists(sourceLength,      out NativeBitList source,      out NativeList<bool> cmpSource);

                int startIndexSource = rng.NextInt(0, sourceLength);
                destination.AddRange(source, source.Length - startIndexSource, startIndexSource);
                Shrink(ref cmpSource, startIndexSource);
                cmpDestination.AddRange(cmpSource.AsArray());
                AssertEquality(destination, cmpDestination);

                destination.Dispose(default(JobHandle));
                cmpDestination.Dispose(default(JobHandle));
                source.Dispose(default(JobHandle));
                cmpSource.Dispose(default(JobHandle));
            }
        }

        [Test]
        public static void Bools_AddRange_DestinationEven8()
        {
            Random32 rng = Random32.New;

            for (int i = 0; i < 16; i++)
            {
                int destinationLength = GenerateEvenlyDivisibleBy8(ref rng);
                int sourceLength      = rng.NextInt(1, MAX_TEST_LENGTH);
                CreateSyncedLists(destinationLength, out NativeBitList destination, out NativeList<bool> cmpDestination);
                CreateSyncedLists(sourceLength,      out NativeList<bool> source,   out NativeList<bool> cmpSource);

                destination.AddRange(source);
                cmpDestination.AddRange(cmpSource.AsArray());
                AssertEquality(destination, cmpDestination);

                destination.Dispose(default(JobHandle));
                cmpDestination.Dispose(default(JobHandle));
                source.Dispose(default(JobHandle));
                cmpSource.Dispose(default(JobHandle));
            }
        }

        [Test]
        public static void Bools_AddRange_DestinationNotEven8()
        {
            Random32 rng = Random32.New;

            for (int i = 0; i < 16; i++)
            {
                int destinationLength = GenerateNotEvenlyDivisibleBy8(ref rng);
                int sourceLength      = rng.NextInt(1, MAX_TEST_LENGTH);
                CreateSyncedLists(destinationLength, out NativeBitList destination, out NativeList<bool> cmpDestination);
                CreateSyncedLists(sourceLength,      out NativeList<bool> source,   out NativeList<bool> cmpSource);

                destination.AddRange(source);
                cmpDestination.AddRange(cmpSource.AsArray());
                AssertEquality(destination, cmpDestination);

                destination.Dispose(default(JobHandle));
                cmpDestination.Dispose(default(JobHandle));
                source.Dispose(default(JobHandle));
                cmpSource.Dispose(default(JobHandle));
            }
        }

        [Test]
        public static void RemoveAt()
        {
            Random32 rng = Random32.New;

            for (int i = 0; i < 16; i++)
            {
                int length = i % 2 == 0 ? GenerateNotEvenlyDivisibleBy8(ref rng) : GenerateEvenlyDivisibleBy8(ref rng);
                CreateSyncedLists(length, out NativeBitList native, out NativeList<bool> managed);

                for (int j = 0; j < length / (MAX_TEST_LENGTH / (MAX_TEST_LENGTH / 10)); j++)
                {
                    int index = rng.NextInt(0, native.Length);

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

                native.Dispose(default(JobHandle));
                managed.Dispose(default(JobHandle));
            }
        }

        [Test]
        public static void RemoveAtSwapBack()
        {
            Random32 rng = Random32.New;

            for (int i = 0; i < 16; i++)
            {
                int length = i % 2 == 0 ? GenerateNotEvenlyDivisibleBy8(ref rng) : GenerateEvenlyDivisibleBy8(ref rng);
                CreateSyncedLists(length, out NativeBitList native, out NativeList<bool> managed);

                for (int j = 0; j < length / (MAX_TEST_LENGTH / (MAX_TEST_LENGTH / 10)); j++)
                {
                    int index = rng.NextInt(0, native.Length);

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

                native.Dispose(default(JobHandle));
                managed.Dispose(default(JobHandle));
            }
        }

        [Test]
        public static void RemoveRange()
        {
            Random32 rng = Random32.New;

            for (int i = 0; i < 32; i++)
            {
                int length = i % 2 == 0 ? GenerateNotEvenlyDivisibleBy8(ref rng) : GenerateEvenlyDivisibleBy8(ref rng);
                CreateSyncedLists(length, out NativeBitList native, out NativeList<bool> managed);

                for (int j = 0; j < length / (MAX_TEST_LENGTH / (MAX_TEST_LENGTH / 10)); j++)
                {
                    int index = rng.NextInt(0, native.Length);
                    int count = rng.NextInt(0, native.Length - index);

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

                    int index = rng.NextInt(0, native.Length);
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

                native.Dispose(default(JobHandle));
                managed.Dispose(default(JobHandle));
            }
        }

        [Test]
        public static void AddReplicate()
        {
            Random32 rng = Random32.New;

            for (int i = 0; i < 32; i++)
            {
                int length = i % 2 == 0 ? GenerateNotEvenlyDivisibleBy8(ref rng) : GenerateEvenlyDivisibleBy8(ref rng);
                CreateSyncedLists(length, out NativeBitList native, out NativeList<bool> managed);

                bool value = rng.NextBool();
                int count = rng.NextInt(0, 1000);

                managed.AddReplicate(value, count);
                native.AddReplicate(value, count);

                AssertEquality(native, managed);

                native.Dispose(default(JobHandle));
                managed.Dispose(default(JobHandle));
            }
        }

        [Test]
        public static void RemoveRangeSwapBack()
        {
            Random32 rng = Random32.New;

            for (int i = 0; i < 32; i++)
            {
                int length = i % 2 == 0 ? GenerateNotEvenlyDivisibleBy8(ref rng) : GenerateEvenlyDivisibleBy8(ref rng);
                CreateSyncedLists(length, out NativeBitList native, out NativeList<bool> managed);

                for (int j = 0; j < length / (MAX_TEST_LENGTH / (MAX_TEST_LENGTH / 10)); j++)
                {
                    int index = rng.NextInt(0, native.Length);
                    int count = rng.NextInt(0, native.Length - index);

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

                    int index = rng.NextInt(0, native.Length);
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

                native.Dispose(default(JobHandle));
                managed.Dispose(default(JobHandle));
            }
        }

        [Test]
        public static void Insert()
        {
            Random32 rng = Random32.New;

            for (int i = 0; i < 32; i++)
            {
                int length = i % 2 == 0 ? GenerateNotEvenlyDivisibleBy8(ref rng) : GenerateEvenlyDivisibleBy8(ref rng);
                int randomIndex = rng.NextInt(0, length);
                CreateSyncedLists(length, out NativeBitList native, out List<bool> managed);

                bool randomBool = rng.NextBool();

                native.Insert(randomIndex, randomBool);
                managed.Insert(randomIndex, randomBool);

                AssertEquality(native, managed);

                native.Dispose(default(JobHandle));
            }
        }

        [Test]
        public static void InsertRange()
        {
            Random32 rng = Random32.New;

            for (int i = 0; i < 32; i++)
            {
                int length = i % 2 == 0 ? GenerateNotEvenlyDivisibleBy8(ref rng) : GenerateEvenlyDivisibleBy8(ref rng);
                int randomIndex = rng.NextInt(0, length);
                int randomCount = rng.NextInt(0, length - randomIndex + 1);
                CreateSyncedLists(length, out NativeBitList native, out NativeList<bool> managed);

                managed.InsertRange(randomIndex, randomCount);
                native.InsertRange(randomIndex, randomCount);

                AssertEquality(native, managed);

                native.Dispose(default(JobHandle));
                managed.Dispose(default(JobHandle));
            }
        }

        [Test]
        public static void InsertRangeWithBeginEnd()
        {
            Random32 rng = Random32.New;

            for (int i = 0; i < 32; i++)
            {
                int length = i % 2 == 0 ? GenerateNotEvenlyDivisibleBy8(ref rng) : GenerateEvenlyDivisibleBy8(ref rng);
                int randomIndex = rng.NextInt(0, length);
                int randomEnd = rng.NextInt(randomIndex, length);
                CreateSyncedLists(length, out NativeBitList native, out NativeList<bool> managed);

                managed.InsertRangeWithBeginEnd(randomIndex, randomEnd);
                native.InsertRangeWithBeginEnd(randomIndex, randomEnd);

                AssertEquality(native, managed);

                native.Dispose(default(JobHandle));
                managed.Dispose(default(JobHandle));
            }
        }

        [Test]
        public static void InsertRangeArray()
        {
            Random32 rng = Random32.New;

            for (int i = 0; i < 32; i++)
            {
                int length = i % 2 == 0 ? GenerateNotEvenlyDivisibleBy8(ref rng) : GenerateEvenlyDivisibleBy8(ref rng);
                int randomIndex = rng.NextInt(0, length);
                CreateSyncedLists(length, out NativeBitList native, out List<bool> managed);
                bool[] managedArray = RandomBoolArray(rng.NextInt(0, 250));
                List<bool> managedList = RandomBoolList(rng.NextInt(0, 250));
                NativeArray<bool> nativeArray = RandomNativeArray(rng.NextInt(0, 250));

                managed.InsertRange(randomIndex, managedArray);
                native.InsertRange(randomIndex, managedArray);
                AssertEquality(native, managed);
                managed.InsertRange(randomIndex, nativeArray);
                native.InsertRange(randomIndex, nativeArray);
                AssertEquality(native, managed);
                managed.InsertRange(randomIndex, managedList);
                native.InsertRange(randomIndex, managedList);
                AssertEquality(native, managed);

                native.Dispose(default(JobHandle));
                nativeArray.Dispose(default(JobHandle));
            }
        }

        [Test]
        public static void InsertRangeBitArray()
        {
            Random32 rng = Random32.New;

            for (int i = 0; i < 32; i++)
            {
                int length = i % 2 == 0 ? GenerateNotEvenlyDivisibleBy8(ref rng) : GenerateEvenlyDivisibleBy8(ref rng);
                int randomIndex = rng.NextInt(0, length);
                CreateSyncedLists(length, out NativeBitList native, out List<bool> managed);
                BitArray managedArray = RandomBitArray(rng.NextInt(0, 250));
                NativeBitArray nativeArray = RandomNativeBitArray(rng.NextInt(0, 250));
                bool[] copyManaged = new bool[managedArray.Length];
                for (int j = 0; j < copyManaged.Length; j++)
                {
                    copyManaged[j] = managedArray[j];
                }

                managed.InsertRange(randomIndex, copyManaged);
                native.InsertRange(randomIndex, managedArray);
                AssertEquality(native, managed);
                managed.InsertRange(randomIndex, nativeArray);
                native.InsertRange(randomIndex, nativeArray);
                AssertEquality(native, managed);

                native.Dispose(default(JobHandle));
                nativeArray.Dispose(default(JobHandle));
            }
        }

        [Test]
        public static void InsertRangeArraySlice()
        {
            Random32 rng = Random32.New;

            for (int i = 0; i < 32; i++)
            {
                int length = i % 2 == 0 ? GenerateNotEvenlyDivisibleBy8(ref rng) : GenerateEvenlyDivisibleBy8(ref rng);
                int randomIndex = rng.NextInt(0, length);
                CreateSyncedLists(length, out NativeBitList native, out List<bool> managed);
                bool[] managedArray = RandomBoolArray(rng.NextInt(0, 250));
                List<bool> managedList = RandomBoolList(rng.NextInt(0, 250));
                NativeArray<bool> nativeArray = RandomNativeArray(rng.NextInt(0, 250));

                int randomSrcIndex = rng.NextInt(0, managedArray.Length);
                int randomSrcCount = rng.NextInt(0, managedArray.Length - randomSrcIndex + 1);
                bool[] slice = new bool[randomSrcCount];
                for (int j = 0; j < slice.Length; j++)
                {
                    slice[j] = managedArray[randomSrcIndex + j];
                }

                managed.InsertRange(randomIndex, slice);
                native.InsertRange(randomIndex, managedArray, randomSrcCount, randomSrcIndex);
                AssertEquality(native, managed);

                randomSrcIndex = rng.NextInt(0, managedList.Count);
                randomSrcCount = rng.NextInt(0, managedList.Count - randomSrcIndex + 1);
                slice = new bool[randomSrcCount];
                for (int j = 0; j < slice.Length; j++)
                {
                    slice[j] = managedList[randomSrcIndex + j];
                }

                managed.InsertRange(randomIndex, slice);
                native.InsertRange(randomIndex, managedList, randomSrcCount, randomSrcIndex);
                AssertEquality(native, managed);

                randomSrcIndex = rng.NextInt(0, nativeArray.Length);
                randomSrcCount = rng.NextInt(0, nativeArray.Length - randomSrcIndex + 1);

                managed.InsertRange(randomIndex, nativeArray.Slice(randomSrcIndex, randomSrcCount));
                native.InsertRange(randomIndex, nativeArray, randomSrcCount, randomSrcIndex);
                AssertEquality(native, managed);

                native.Dispose(default(JobHandle));
                nativeArray.Dispose(default(JobHandle));
            }
        }

        [Test]
        public static void InsertRangeBitArraySlice()
        {
            Random32 rng = Random32.New;

            for (int i = 0; i < 32; i++)
            {
                int length = i % 2 == 0 ? GenerateNotEvenlyDivisibleBy8(ref rng) : GenerateEvenlyDivisibleBy8(ref rng);
                int randomIndex = rng.NextInt(0, length);
                CreateSyncedLists(length, out NativeBitList native, out List<bool> managed);
                BitArray managedArray = RandomBitArray(rng.NextInt(0, 250));
                NativeBitArray nativeArray = RandomNativeBitArray(rng.NextInt(0, 250));

                int randomSrcIndex = rng.NextInt(0, managedArray.Length);
                int randomSrcCount = rng.NextInt(0, managedArray.Length - randomSrcIndex + 1);
                bool[] slice = new bool[randomSrcCount];
                for (int j = 0; j < slice.Length; j++)
                {
                    slice[j] = managedArray[randomSrcIndex + j];
                }

                managed.InsertRange(randomIndex, slice);
                native.InsertRange(randomIndex, managedArray, randomSrcCount, randomSrcIndex);
                AssertEquality(native, managed);

                randomSrcIndex = rng.NextInt(0, nativeArray.Length);
                randomSrcCount = rng.NextInt(0, nativeArray.Length - randomSrcIndex + 1);
                NativeBitArray nativeSlice = new NativeBitArray(randomSrcCount, Allocator.Persistent);
                for (int j = 0; j < nativeSlice.Length; j++)
                {
                    nativeSlice[j] = nativeArray[randomSrcIndex + j];
                }

                managed.InsertRange(randomIndex, nativeSlice);
                native.InsertRange(randomIndex, nativeArray, randomSrcCount, randomSrcIndex);
                AssertEquality(native, managed);

                native.Dispose(default(JobHandle));
                nativeArray.Dispose(default(JobHandle));
                nativeSlice.Dispose(default(JobHandle));
            }
        }

        [Test]
        public static void CountBits()
        {
            Random32 rng = Random32.New;

            for (int i = 0; i < 4; i++)
            {
                using NativeBitList arr = new NativeBitList(rng.NextInt(1, MAX_TEST_LENGTH), Allocator.Persistent);

                int std = 0;

                for (int j = 0; j < arr.Capacity; j++)
                {
                    arr.Add(rng.NextBool());
                    std += maxmath.toint(arr[j]);
                }

                Assert.AreEqual(std, arr.CountBits());
                Assert.AreEqual(std, arr.CountBits(0, arr.Length));

                std = 0;
                int start = rng.NextInt(0, arr.Length / 2);
                int end = rng.NextInt(start, arr.Length);
                int numBits = 1 + (end - start);

                for (int j = start; j <= end; j++)
                {
                    std += maxmath.toint(arr[j]);
                }

                Assert.AreEqual(std, arr.CountBits(start, numBits));
            }

            using NativeBitList staticSize1 = new NativeBitList(6, Allocator.Temp);
            int stdStatic = 0;

            for (int i = 0; i < 6; i++)
            {
                staticSize1.Add(rng.NextBool());
                stdStatic += maxmath.toint(staticSize1[i]);
            }

            Assert.AreEqual(stdStatic, staticSize1.CountBits());
            Assert.AreEqual(stdStatic, staticSize1.CountBits(0, 6));

            using NativeBitList staticSize2 = new NativeBitList(13, Allocator.Temp);
            stdStatic = 0;

            for (int i = 0; i < 13; i++)
            {
                staticSize2.Add(rng.NextBool());
                stdStatic += maxmath.toint(staticSize2[i]);
            }

            Assert.AreEqual(stdStatic, staticSize2.CountBits());
            Assert.AreEqual(stdStatic, staticSize2.CountBits(0, 13));

            stdStatic = 0;

            for (int i = 8; i < 11; i++)
            {
                stdStatic += maxmath.toint(staticSize2[i]);
            }

            Assert.AreEqual(stdStatic, staticSize2.CountBits(8, 3));

            stdStatic = 0;

            for (int i = 7; i < staticSize2.Length; i++)
            {
                stdStatic += maxmath.toint(staticSize2[i]);
            }

            Assert.AreEqual(stdStatic, staticSize2.CountBits(7, 6));

            stdStatic = maxmath.toint(staticSize2[9]);
            Assert.AreEqual(stdStatic, staticSize2.CountBits(9, 1));
        }

        [Test]
        public static void Contains()
        {
            Random32 rng = Random32.New;

            for (int i = 0; i < 128; i++)
            {
                int length = i % 2 == 0 ? GenerateNotEvenlyDivisibleBy8(ref rng) : GenerateEvenlyDivisibleBy8(ref rng);
                int randomIndex = rng.NextInt(0, length);
                NativeBitList native = new NativeBitList(length, Allocator.Persistent, NativeArrayOptions.UninitializedMemory);

                for (int j = 0; j < length; j++)
                {
                    native.Add(false);
                }

                Assert.IsFalse(native.Contains(true));
                Assert.IsTrue(native.Contains(false));
                native[randomIndex] = true;
                Assert.IsTrue(native.Contains(true));

                for (int j = 0; j < length; j++)
                {
                    native[j] = true;
                }

                Assert.IsTrue(native.Contains(true));
                Assert.IsFalse(native.Contains(false));
                native[randomIndex] = false;
                Assert.IsTrue(native.Contains(false));

                native.Dispose(default(JobHandle));
            }
        }

        [Test]
        public static void Contains_WithIndexCount()
        {
            Random32 rng = Random32.New;

            for (int i = 0; i < 128; i++)
            {
                int length = i % 2 == 0 ? GenerateNotEvenlyDivisibleBy8(ref rng) : GenerateEvenlyDivisibleBy8(ref rng);
                if (length == 1)
                {
                    continue;
                }

                int randomStartIndex = rng.NextInt(0, length);
                int randomCount = rng.NextInt(1, length - randomStartIndex);
                int randomIndex = rng.NextInt(randomStartIndex, randomStartIndex + randomCount);
                NativeBitList native = new NativeBitList(length, Allocator.Persistent, NativeArrayOptions.UninitializedMemory);

                for (int j = 0; j < length; j++)
                {
                    native.Add(false);
                }

                Assert.IsFalse(native.Contains(true, randomStartIndex, randomCount));
                Assert.IsTrue(native.Contains(false, randomStartIndex, randomCount));
                native[randomIndex] = true;
                Assert.IsTrue(native.Contains(true, randomStartIndex, randomCount));

                for (int j = 0; j < length; j++)
                {
                    native[j] = true;
                }

                Assert.IsTrue(native.Contains(true, randomStartIndex, randomCount));
                Assert.IsFalse(native.Contains(false, randomStartIndex, randomCount));
                native[randomIndex] = false;
                Assert.IsTrue(native.Contains(false, randomStartIndex, randomCount));

                native.Dispose(default(JobHandle));
            }
        }

        [Test]
        public static void IndexOf()
        {
            Random32 rng = Random32.New;

            for (int i = 0; i < 128; i++)
            {
                int length = i % 2 == 0 ? GenerateNotEvenlyDivisibleBy8(ref rng) : GenerateEvenlyDivisibleBy8(ref rng);
                int randomIndex = rng.NextInt(0, length);
                CreateSyncedLists(length, out NativeBitList native, out NativeList<bool> managed);

                Assert.AreEqual(native.IndexOf(true), managed.IndexOf(true));
                Assert.AreEqual(native.IndexOf(false), managed.IndexOf(false));

                for (int j = 0; j < length; j++)
                {
                    native[j] = managed[j] = false;
                }

                Assert.AreEqual(native.IndexOf(true), managed.IndexOf(true));
                Assert.AreEqual(native.IndexOf(false), managed.IndexOf(false));

                native[randomIndex] = managed[randomIndex] = true;

                Assert.AreEqual(native.IndexOf(true), managed.IndexOf(true));
                Assert.AreEqual(native.IndexOf(false), managed.IndexOf(false));

                for (int j = 0; j < length; j++)
                {
                    native[j] = managed[j] = true;
                }

                Assert.AreEqual(native.IndexOf(true), managed.IndexOf(true));
                Assert.AreEqual(native.IndexOf(false), managed.IndexOf(false));

                native[randomIndex] = managed[randomIndex] = false;

                Assert.AreEqual(native.IndexOf(true), managed.IndexOf(true));
                Assert.AreEqual(native.IndexOf(false), managed.IndexOf(false));

                native.Dispose(default(JobHandle));
                managed.Dispose(default(JobHandle));
            }
        }

        [Test]
        public static void Sort()
        {
            Random32 rng = Random32.New;

            for (int i = 0; i < 32; i++)
            {
                int length = i % 2 == 0 ? GenerateNotEvenlyDivisibleBy8(ref rng) : GenerateEvenlyDivisibleBy8(ref rng);
                CreateSyncedLists(length, out NativeBitList native, out NativeList<bool> managed);

                for (int j = 0; j < length; j++)
                {
                    bool value = rng.NextBool();
                    native.Add(value);
                    managed.Add(value);
                }

                native.Sort();
                managed.Sort();

                AssertEquality(native, managed);

                native.Dispose();
                managed.Dispose();
            }
        }
    }
}