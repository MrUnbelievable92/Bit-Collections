using DevTools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;
using Unity.Mathematics;
using MaxMath;

namespace BitCollections
{
    [Serializable]
    unsafe public struct UInt2x32 : IBitNumberArray<uint>, IEquatable<UInt2x32>
    {
        internal ulong intern;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x32(uint x0, uint x1, uint x2, uint x3, uint x4, uint x5, uint x6, uint x7, uint x8, uint x9, uint x10, uint x11, uint x12, uint x13, uint x14, uint x15, uint x16, uint x17, uint x18, uint x19, uint x20, uint x21, uint x22, uint x23, uint x24, uint x25, uint x26, uint x27, uint x28, uint x29, uint x30, uint x31) : this(new uint8(x0, x1, x2, x3, x4, x5, x6, x7), new uint8(x8, x9, x10, x11, x12, x13, x14, x15), new uint8(x16, x17, x18, x19, x20, x21, x22, x23), new uint8(x24, x25, x26, x27, x28, x29, x30, x31))
        { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x32(uint x0_31)
        {
            uint8 vector = x0_31;

            this = new UInt2x32(vector, vector, vector, vector);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x32(uint8 x0_7, uint8 x8_15, uint8 x16_23, uint8 x24_31)
        {
Assert.IsNotGreater(x0_7.x0,   UInt2.MaxValue);
Assert.IsNotGreater(x0_7.x1,   UInt2.MaxValue);
Assert.IsNotGreater(x0_7.x2,   UInt2.MaxValue);
Assert.IsNotGreater(x0_7.x3,   UInt2.MaxValue);
Assert.IsNotGreater(x0_7.x4,   UInt2.MaxValue);
Assert.IsNotGreater(x0_7.x5,   UInt2.MaxValue);
Assert.IsNotGreater(x0_7.x6,   UInt2.MaxValue);
Assert.IsNotGreater(x0_7.x7,   UInt2.MaxValue);
Assert.IsNotGreater(x8_15.x0,  UInt2.MaxValue);
Assert.IsNotGreater(x8_15.x1,  UInt2.MaxValue);
Assert.IsNotGreater(x8_15.x2,  UInt2.MaxValue);
Assert.IsNotGreater(x8_15.x3,  UInt2.MaxValue);
Assert.IsNotGreater(x8_15.x4,  UInt2.MaxValue);
Assert.IsNotGreater(x8_15.x5,  UInt2.MaxValue);
Assert.IsNotGreater(x8_15.x6,  UInt2.MaxValue);
Assert.IsNotGreater(x8_15.x7,  UInt2.MaxValue);
Assert.IsNotGreater(x16_23.x0, UInt2.MaxValue);
Assert.IsNotGreater(x16_23.x1, UInt2.MaxValue);
Assert.IsNotGreater(x16_23.x2, UInt2.MaxValue);
Assert.IsNotGreater(x16_23.x3, UInt2.MaxValue);
Assert.IsNotGreater(x16_23.x4, UInt2.MaxValue);
Assert.IsNotGreater(x16_23.x5, UInt2.MaxValue);
Assert.IsNotGreater(x16_23.x6, UInt2.MaxValue);
Assert.IsNotGreater(x16_23.x7, UInt2.MaxValue);
Assert.IsNotGreater(x24_31.x0, UInt2.MaxValue);
Assert.IsNotGreater(x24_31.x1, UInt2.MaxValue);
Assert.IsNotGreater(x24_31.x2, UInt2.MaxValue);
Assert.IsNotGreater(x24_31.x3, UInt2.MaxValue);
Assert.IsNotGreater(x24_31.x4, UInt2.MaxValue);
Assert.IsNotGreater(x24_31.x5, UInt2.MaxValue);
Assert.IsNotGreater(x24_31.x6, UInt2.MaxValue);
Assert.IsNotGreater(x24_31.x7, UInt2.MaxValue);

            intern = (ulong)maxmath.csum(maxmath.shl(x0_7, (uint)new UInt2x32().BitsPerNumber * new uint8(0u, 1u, 2u, 3u, 4u, 5u, 6u, 7u))
                                         |
                                         maxmath.shl(x8_15, (uint)new UInt2x32().BitsPerNumber * new uint8(8u, 9u, 10u, 11u, 12u, 13u, 14u, 15u)))
                     |
                     ((ulong)maxmath.csum(maxmath.shl(x16_23, (uint)new UInt2x32().BitsPerNumber * new uint8(0u, 1u, 2u, 3u, 4u, 5u, 6u, 7u))
                                          |
                                          maxmath.shl(x24_31, (uint)new UInt2x32().BitsPerNumber * new uint8(8u, 9u, 10u, 11u, 12u, 13u, 14u, 15u))) << (new UInt2x32().BitsPerNumber * 16));
        }

        public readonly uint MinValue => UInt2.MinValue;
        public readonly uint MaxValue => UInt2.MaxValue;
        public readonly int BitsPerNumber => 2;
        public readonly int Length => 32;


        public uint x0
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[0];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[0] = value;
        }
        public uint x1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[1];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[1] = value;
        }
        public uint x2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[2];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[2] = value;
        }
        public uint x3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[3];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[3] = value;
        }
        public uint x4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[4];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[4] = value;
        }
        public uint x5
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[5];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[5] = value;
        }
        public uint x6
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[6];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[6] = value;
        }
        public uint x7
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[7];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[7] = value;
        }
        public uint x8
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[8];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[8] = value;
        }
        public uint x9
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[9];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[9] = value;
        }
        public uint x10
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[10];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[10] = value;
        }
        public uint x11
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[11];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[11] = value;
        }
        public uint x12
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[12];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[12] = value;
        }
        public uint x13
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[13];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[13] = value;
        }
        public uint x14
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[14];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[14] = value;
        }
        public uint x15
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[15];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[15] = value;
        }
        public uint x16
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[16];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[16] = value;
        }
        public uint x17
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[17];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[17] = value;
        }
        public uint x18
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[18];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[18] = value;
        }
        public uint x19
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[19];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[19] = value;
        }
        public uint x20
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[20];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[20] = value;
        }
        public uint x21
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[21];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[21] = value;
        }
        public uint x22
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[22];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[22] = value;
        }
        public uint x23
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[23];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[23] = value;
        }
        public uint x24
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[24];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[24] = value;
        }
        public uint x25
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[25];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[25] = value;
        }
        public uint x26
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[26];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[26] = value;
        }
        public uint x27
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[27];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[27] = value;
        }
        public uint x28
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[28];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[28] = value;
        }
        public uint x29
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[29];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[29] = value;
        }
        public uint x30
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[30];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[30] = value;
        }
        public uint x31
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[31];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[31] = value;
        }


        public uint this[[AssumeRange(0, 31)] int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
Assert.IsWithinArrayBounds(index, Length);

                return MaxValue & (uint)(intern >> (index * BitsPerNumber));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsNotGreater(value, UInt2.MaxValue);
Assert.IsWithinArrayBounds(index, Length);

                int shiftValue = index * BitsPerNumber;
                ulong newValue = (ulong)value << shiftValue;
                ulong mask = math.rol(~(ulong)MaxValue, shiftValue);

                intern = (intern & mask) | newValue;
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong4 GetSubArray([AssumeRange(0, 28)] int index)
        {
Assert.IsValidSubarray(index, 4, Length);

            return MaxValue & maxmath.shrl(intern, (ulong4)((uint)BitsPerNumber * ((uint)index + new uint4(0u, 1u, 2u, 3u))));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetSubArray([AssumeRange(0, 28)] int index, ulong4 value)
        {
Assert.IsValidSubarray(index, 4, Length);
Assert.IsNotGreater(value.x, UInt2.MaxValue);
Assert.IsNotGreater(value.y, UInt2.MaxValue);
Assert.IsNotGreater(value.z, UInt2.MaxValue);
Assert.IsNotGreater(value.w, UInt2.MaxValue);

            intern = (maxmath.andnot(intern,     (ulong)maxmath.bitmask64(4 * BitsPerNumber,   index * BitsPerNumber))
                      |
                      maxmath.csum(maxmath.shl(value,      (ulong4)((uint)BitsPerNumber * ((uint)index + new uint4(0u, 1u, 2u, 3u))))));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(UInt2x32 other)
        {
            return this.intern == other.intern;
        }

        public override readonly bool Equals(object obj)
        {
            return Equals((UInt2x32)obj);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
            return intern.GetHashCode();
        }


        public override string ToString()
        {
            return new Enumerator<uint>(this).ToString();
        }


        public IEnumerator<uint> GetEnumerator()
        {
            return new Enumerator<uint>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumerator<uint>(this);
        }
    }
}