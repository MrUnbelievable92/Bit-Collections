using MaxMath;
using Unity.Mathematics;

namespace BitCollections.Tests
{
    internal struct Vector
    {
        internal string Name;
        internal int Bits;
        internal int Elements;
        internal bool Signed;

        internal Vector(string name, int bits, int elements, bool signed)
        {
            Name = name;
            Bits = bits;
            Elements = elements;
            Signed = signed;
        }

        internal static Vector[] AllVectorTypes
        {
            get => new Vector[]
            {
                new Vector("bit8", 1, 8, false),
                new Vector("bit16", 1, 16, false),
                new Vector("bit24", 1, 24, false),
                new Vector("bit32", 1, 32, false),
                new Vector("bit40", 1, 40, false),
                new Vector("bit48", 1, 48, false),
                new Vector("bit56", 1, 56, false),
                new Vector("bit64", 1, 64, false),
                new Vector("Int2x4", 2, 4, true),
                new Vector("Int2x8", 2, 8, true),
                new Vector("Int2x12", 2, 12, true),
                new Vector("Int2x16", 2, 16, true),
                new Vector("Int2x20", 2, 20, true),
                new Vector("Int2x24", 2, 24, true),
                new Vector("Int2x28", 2, 28, true),
                new Vector("Int2x32", 2, 32, true),
                new Vector("UInt2x4", 2, 4, false),
                new Vector("UInt2x8", 2, 8, false),
                new Vector("UInt2x12", 2, 12, false),
                new Vector("UInt2x16", 2, 16, false),
                new Vector("UInt2x20", 2, 20, false),
                new Vector("UInt2x24", 2, 24, false),
                new Vector("UInt2x28", 2, 28, false),
                new Vector("UInt2x32", 2, 32, false),
                new Vector("Int3x8", 3, 8, true),
                new Vector("Int3x16", 3, 16, true),
                new Vector("UInt3x8", 3, 8, false),
                new Vector("UInt3x16", 3, 16, false),
                new Vector("Int4x2", 4, 2, true),
                new Vector("Int4x4", 4, 4, true),
                new Vector("Int4x6", 4, 6, true),
                new Vector("Int4x8", 4, 8, true),
                new Vector("Int4x10", 4, 10, true),
                new Vector("Int4x12", 4, 12, true),
                new Vector("Int4x14", 4, 14, true),
                new Vector("Int4x16", 4, 16, true),
                new Vector("UInt4x2", 4, 2, false),
                new Vector("UInt4x4", 4, 4, false),
                new Vector("UInt4x6", 4, 6, false),
                new Vector("UInt4x8", 4, 8, false),
                new Vector("UInt4x10", 4, 10, false),
                new Vector("UInt4x12", 4, 12, false),
                new Vector("UInt4x14", 4, 14, false),
                new Vector("UInt4x16", 4, 16, false),
                new Vector("Int5x8", 5, 8, true),
                new Vector("UInt5x8", 5, 8, false),
                new Vector("Int6x4", 6, 4, true),
                new Vector("Int6x8", 6, 8, true),
                new Vector("UInt6x4", 6, 4, false),
                new Vector("UInt6x8", 6, 8, false),
                new Vector("Int7x8", 7, 8, true),
                new Vector("UInt7x8", 7, 8, false),
                new Vector("Int10x4", 10, 4, true),
                new Vector("UInt10x4", 10, 4, false),
                new Vector("Int12x2", 12, 2, true),
                new Vector("Int12x4", 12, 4, true),
                new Vector("UInt12x2", 12, 2, false),
                new Vector("UInt12x4", 12, 4, false),
                new Vector("Int14x4", 14, 4, true),
                new Vector("UInt14x4", 14, 4, false),
                new Vector("Int20x2", 20, 2, true),
                new Vector("UInt20x2", 20, 2, false),
                new Vector("Int28x2", 28, 2, true),
                new Vector("UInt28x2", 28, 2, false),
                new Vector("sbyte2", 8, 2, true),
                new Vector("sbyte3", 8, 3, true),
                new Vector("sbyte4", 8, 4, true),
                new Vector("sbyte8", 8, 8, true),
                new Vector("sbyte16", 8, 16, true),
                new Vector("sbyte32", 8, 32, true),
                new Vector("byte2", 8, 2, false),
                new Vector("byte3", 8, 3, false),
                new Vector("byte4", 8, 4, false),
                new Vector("byte8", 8, 8, false),
                new Vector("byte16", 8, 16, false),
                new Vector("byte32", 8, 32, false),
                new Vector("short2", 16, 2, true),
                new Vector("short3", 16, 3, true),
                new Vector("short4", 16, 4, true),
                new Vector("short8", 16, 8, true),
                new Vector("short16", 16, 16, true),
                new Vector("ushort2", 16, 2, false),
                new Vector("ushort3", 16, 3, false),
                new Vector("ushort4", 16, 4, false),
                new Vector("ushort8", 16, 8, false),
                new Vector("ushort16", 16, 16, false),
                new Vector("int2", 32, 2, true),
                new Vector("int3", 32, 3, true),
                new Vector("int4", 32, 4, true),
                new Vector("int8", 32, 8, true),
                new Vector("uint2", 32, 2, false),
                new Vector("uint3", 32, 3, false),
                new Vector("uint4", 32, 4, false),
                new Vector("uint8", 32, 8, false),
                new Vector("long2", 64, 2, true),
                new Vector("long3", 64, 3, true),
                new Vector("long4", 64, 4, true),
                new Vector("ulong2", 64, 2, false),
                new Vector("ulong3", 64, 3, false),
                new Vector("ulong4", 64, 4, false)
            };
        }
    }
}
