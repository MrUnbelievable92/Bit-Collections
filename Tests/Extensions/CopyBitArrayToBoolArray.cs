using Unity.Collections;
using NUnit.Framework;
using MaxMath;

namespace BitCollections.Tests
{
    public static class CopyBitArrayToBoolArray
    {
        [Test]
        public static void Copy2Array_All()
        {
            for (int k = 0; k < 16; k++)
            {
                Random32 random = Random32.New;
                int length = random.NextInt(0, 1000);

                NativeArray<bool> array = new NativeArray<bool>(length, Allocator.Persistent);
                BitCollections.NativeBitArray bitArray = new BitCollections.NativeBitArray(length, Allocator.Persistent);

                for (int i = 0; i < length; i++)
                {
                    array[i] = random.NextBool();
                    bitArray[i] = random.NextBool();
                }

                array.CopyFrom(bitArray);

                for (int i = 0; i < length; i++)
                {
                    Assert.AreEqual(array[i], bitArray[i]);
                }

                array.Dispose(default);
                bitArray.Dispose(default);
            }
        }

        [Test]
        public static void Copy2Array_DstOffset()
        {
            for (int k = 0; k < 16; k++)
            {
                Random32 random = Random32.New;
                int length = random.NextInt(0, 1000);
                int dstOffset = random.NextInt(1, length);

                NativeArray<bool> array = new NativeArray<bool>(length, Allocator.Persistent);
                BitCollections.NativeBitArray bitArray = new BitCollections.NativeBitArray(length, Allocator.Persistent);

                for (int i = 0; i < length; i++)
                {
                    array[i] = random.NextBool();
                    bitArray[i] = random.NextBool();
                }

                array.CopyFrom(bitArray, index: dstOffset);

                for (int i = dstOffset; i < length; i++)
                {
                    Assert.AreEqual(array[i], bitArray[i - dstOffset]);
                }

                array.Dispose(default);
                bitArray.Dispose(default);
            }
        }

        [Test]
        public static void Copy2Array_SrcOffset()
        {
            for (int k = 0; k < 16; k++)
            {
                Random32 random = Random32.New;
                int length = random.NextInt(0, 1000);
                int srcOffset = random.NextInt(1, length);

                NativeArray<bool> array = new NativeArray<bool>(length, Allocator.Persistent);
                BitCollections.NativeBitArray bitArray = new BitCollections.NativeBitArray(length, Allocator.Persistent);

                for (int i = 0; i < length; i++)
                {
                    array[i] = random.NextBool();
                    bitArray[i] = random.NextBool();
                }

                array.CopyFrom(bitArray, srcIndex: srcOffset);

                for (int i = 0; i < length - srcOffset; i++)
                {
                    Assert.AreEqual(array[i], bitArray[i + srcOffset]);
                }

                array.Dispose(default);
                bitArray.Dispose(default);
            }
        }

        [Test]
        public static void Copy2List_All()
        {
            for (int k = 0; k < 16; k++)
            {
                Random32 random = Random32.New;
                int length = random.NextInt(0, 1000);

                NativeList<bool> list = new NativeList<bool>(length, Allocator.Persistent);
                BitCollections.NativeBitArray bitList = new BitCollections.NativeBitArray(length, Allocator.Persistent);

                for (int i = 0; i < length; i++)
                {
                    list.Add(random.NextBool());
                    bitList[i] = random.NextBool();
                }

                list.CopyFrom(bitList);

                for (int i = 0; i < length; i++)
                {
                    Assert.AreEqual(list[i], bitList[i]);
                }

                list.Dispose(default);
                bitList.Dispose(default);
            }
        }

        [Test]
        public static void Copy2List_DstOffset()
        {
            for (int k = 0; k < 16; k++)
            {
                Random32 random = Random32.New;
                int length = random.NextInt(0, 1000);
                int dstOffset = random.NextInt(1, length);

                NativeList<bool> list = new NativeList<bool>(length, Allocator.Persistent);
                BitCollections.NativeBitArray bitList = new BitCollections.NativeBitArray(length, Allocator.Persistent);

                for (int i = 0; i < length; i++)
                {
                    list.Add(random.NextBool());
                    bitList[i] = random.NextBool();
                }

                list.CopyFrom(bitList, index: dstOffset);

                for (int i = dstOffset; i < length; i++)
                {
                    Assert.AreEqual(list[i], bitList[i - dstOffset]);
                }

                list.Dispose(default);
                bitList.Dispose(default);
            }
        }

        [Test]
        public static void Copy2List_SrcOffset()
        {
            for (int k = 0; k < 16; k++)
            {
                Random32 random = Random32.New;
                int length = random.NextInt(0, 1000);
                int srcOffset = random.NextInt(1, length);

                NativeList<bool> list = new NativeList<bool>(length, Allocator.Persistent);
                BitCollections.NativeBitArray bitList = new BitCollections.NativeBitArray(length, Allocator.Persistent);

                for (int i = 0; i < length; i++)
                {
                    list.Add(random.NextBool());
                    bitList[i] = random.NextBool();
                }

                list.CopyFrom(bitList, srcIndex: srcOffset);

                for (int i = 0; i < length - srcOffset; i++)
                {
                    Assert.AreEqual(list[i], bitList[i + srcOffset]);
                }

                list.Dispose(default);
                bitList.Dispose(default);
            }
        }

        [Test]
        public static void Add2List_All()
        {
            for (int k = 0; k < 16; k++)
            {
                Random32 random = Random32.New;
                int length0 = random.NextInt(0, 1000);
                int length1 = random.NextInt(0, 1000);

                NativeList<bool> list = new NativeList<bool>(length0, Allocator.Persistent);
                NativeList<bool> listCpy = new NativeList<bool>(length0, Allocator.Persistent);
                BitCollections.NativeBitArray bitList = new BitCollections.NativeBitArray(length1, Allocator.Persistent);

                for (int i = 0; i < length0; i++)
                {
                    list.Add(random.NextBool());
                    listCpy.Add(list[i]);
                }

                for (int i = 0; i < length1; i++)
                {
                    bitList[i] = random.NextBool();
                }

                list.AddRange(bitList);

                for (int i = 0; i < length0; i++)
                {
                    Assert.AreEqual(list[i], listCpy[i]);
                }

                for (int i = length0; i < length0 + length1; i++)
                {
                    Assert.AreEqual(list[i], bitList[i - length0]);
                }

                list.Dispose(default);
                listCpy.Dispose(default);
                bitList.Dispose(default);
            }
        }

        [Test]
        public static void Add2List_SrcOffset()
        {
            for (int k = 0; k < 16; k++)
            {
                Random32 random = Random32.New;
                int length0 = random.NextInt(0, 1000);
                int length1 = random.NextInt(0, 1000);
                int srcIndex = random.NextInt(1, length1);

                NativeList<bool> list = new NativeList<bool>(length0, Allocator.Persistent);
                NativeList<bool> listCpy = new NativeList<bool>(length0, Allocator.Persistent);
                BitCollections.NativeBitArray bitList = new BitCollections.NativeBitArray(length1, Allocator.Persistent);

                for (int i = 0; i < length0; i++)
                {
                    list.Add(random.NextBool());
                    listCpy.Add(list[i]);
                }

                for (int i = 0; i < length1; i++)
                {
                    bitList[i] = random.NextBool();
                }

                list.AddRange(bitList, srcIndex: srcIndex);
                
                for (int i = 0; i < length0; i++)
                {
                    Assert.AreEqual(list[i], listCpy[i]);
                }

                for (int i = length0; i < length0 + length1 - srcIndex; i++)
                {
                    Assert.AreEqual(list[i], bitList[i - (length0 - srcIndex)]);
                }

                list.Dispose(default);
                listCpy.Dispose(default);
                bitList.Dispose(default);
            }
        }

        [Test]
        public static void Insert2List_All()
        {
            for (int k = 0; k < 16; k++)
            {
                Random32 random = Random32.New;
                int length0 = random.NextInt(0, 1000);
                int length1 = random.NextInt(0, 1000);

                NativeList<bool> list = new NativeList<bool>(length0, Allocator.Persistent);
                NativeList<bool> listCpy = new NativeList<bool>(length0, Allocator.Persistent);
                BitCollections.NativeBitArray bitList = new BitCollections.NativeBitArray(length1, Allocator.Persistent);

                for (int i = 0; i < length0; i++)
                {
                    list.Add(random.NextBool());
                    listCpy.Add(list[i]);
                }

                for (int i = 0; i < length1; i++)
                {
                    bitList[i] = random.NextBool();
                }

                list.InsertRange(bitList);

                for (int i = 0; i < length1; i++)
                {
                    Assert.AreEqual(list[i], bitList[i]);
                }

                for (int i = length1; i < length0 + length1; i++)
                {
                    Assert.AreEqual(list[i], listCpy[i - length1]);
                }

                list.Dispose(default);
                listCpy.Dispose(default);
                bitList.Dispose(default);
            }
        }

        [Test]
        public static void Insert2List_SrcOffset()
        {
            for (int k = 0; k < 16; k++)
            {
                Random32 random = Random32.New;
                int length0 = random.NextInt(0, 1000);
                int length1 = random.NextInt(0, 1000);
                int srcIndex = random.NextInt(1, length1);

                NativeList<bool> list = new NativeList<bool>(length0, Allocator.Persistent);
                NativeList<bool> listCpy = new NativeList<bool>(length0, Allocator.Persistent);
                BitCollections.NativeBitArray bitList = new BitCollections.NativeBitArray(length1, Allocator.Persistent);

                for (int i = 0; i < length0; i++)
                {
                    list.Add(random.NextBool());
                    listCpy.Add(list[i]);
                }

                for (int i = 0; i < length1; i++)
                {
                    bitList[i] = random.NextBool();
                }

                list.InsertRange(bitList, srcIndex: srcIndex);
                
                for (int i = 0; i < length1 - srcIndex; i++)
                {
                    Assert.AreEqual(list[i], bitList[i + srcIndex]);
                }

                for (int i = length1 - srcIndex; i < length0 + length1 - srcIndex; i++)
                {
                    Assert.AreEqual(list[i], listCpy[i - (length1 - srcIndex)]);
                }

                list.Dispose(default);
                listCpy.Dispose(default);
                bitList.Dispose(default);
            }
        }
    }
}
