﻿using DevTools;
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
    unsafe public struct UInt2x16 : IBitNumberArray<uint>, IEquatable<UInt2x16>
    {
        internal uint intern;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x16(uint x0, uint x1, uint x2, uint x3, uint x4, uint x5, uint x6, uint x7, uint x8, uint x9, uint x10, uint x11, uint x12, uint x13, uint x14, uint x15) : this(new uint8(x0, x1, x2, x3, x4, x5, x6, x7), new uint8(x8, x9, x10, x11, x12, x13, x14, x15))
        { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x16(uint x0_15)
        {
            uint8 temp = x0_15;

            this = new UInt2x16(temp, temp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x16(uint8 x0_7, uint8 x8_15)
        {
Assert.IsNotGreater(x0_7.x0,  UInt2.MaxValue);
Assert.IsNotGreater(x0_7.x1,  UInt2.MaxValue);
Assert.IsNotGreater(x0_7.x2,  UInt2.MaxValue);
Assert.IsNotGreater(x0_7.x3,  UInt2.MaxValue);
Assert.IsNotGreater(x0_7.x4,  UInt2.MaxValue);
Assert.IsNotGreater(x0_7.x5,  UInt2.MaxValue);
Assert.IsNotGreater(x0_7.x6,  UInt2.MaxValue);
Assert.IsNotGreater(x0_7.x7,  UInt2.MaxValue);
Assert.IsNotGreater(x8_15.x0, UInt2.MaxValue);
Assert.IsNotGreater(x8_15.x1, UInt2.MaxValue);
Assert.IsNotGreater(x8_15.x2, UInt2.MaxValue);
Assert.IsNotGreater(x8_15.x3, UInt2.MaxValue);
Assert.IsNotGreater(x8_15.x4, UInt2.MaxValue);
Assert.IsNotGreater(x8_15.x5, UInt2.MaxValue);
Assert.IsNotGreater(x8_15.x6, UInt2.MaxValue);
Assert.IsNotGreater(x8_15.x7, UInt2.MaxValue);

            intern = maxmath.csum(maxmath.shl(x0_7, (uint)new UInt2x16().BitsPerNumber * new uint8(0u, 1u, 2u, 3u, 4u, 5u, 6u, 7u))
                                  |
                                  maxmath.shl(x8_15, (uint)new UInt2x16().BitsPerNumber * new uint8(8u, 9u, 10u, 11u, 12u, 13u, 14u, 15u)));
        }


        public readonly uint MinValue => UInt2.MinValue;
        public readonly uint MaxValue => UInt2.MaxValue;
        public readonly int BitsPerNumber => 2;
        public readonly int Length => 16;


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

        public uint this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange((ulong)UInt2.MinValue, (ulong)UInt2.MaxValue)]
            readonly get
            {
Assert.IsWithinArrayBounds(index, Length);

                return MaxValue & (intern >> (index * BitsPerNumber));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsNotGreater(value, UInt2.MaxValue);
Assert.IsWithinArrayBounds(index, Length);

                int shiftValue = index * BitsPerNumber;
                uint newValue = value << shiftValue;
                uint mask = math.rol(~MaxValue, shiftValue);

                intern = (intern & mask) | newValue;
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint8 GetSubArray(int index)
        {
Assert.IsValidSubarray(index, 8, Length);

            return MaxValue & maxmath.shrl(intern, (uint)BitsPerNumber * ((uint)index + new uint8(0u, 1u, 2u, 3u, 4u, 5u, 6u, 7u)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetSubArray(int index, uint8 value)
        {
Assert.IsValidSubarray(index, 8, Length);
Assert.IsNotGreater(value.x0, UInt2.MaxValue);
Assert.IsNotGreater(value.x1, UInt2.MaxValue);
Assert.IsNotGreater(value.x2, UInt2.MaxValue);
Assert.IsNotGreater(value.x3, UInt2.MaxValue);
Assert.IsNotGreater(value.x4, UInt2.MaxValue);
Assert.IsNotGreater(value.x5, UInt2.MaxValue);
Assert.IsNotGreater(value.x6, UInt2.MaxValue);
Assert.IsNotGreater(value.x7, UInt2.MaxValue);

            intern = maxmath.andnot(intern,     (uint)maxmath.bitmask32(8 * BitsPerNumber,   index * BitsPerNumber))
                     |
                     maxmath.csum(maxmath.shl(value,     (uint)BitsPerNumber * ((uint)index + new uint8(0u, 1u, 2u, 3u, 4u, 5u, 6u, 7u))));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(UInt2x16 other)
        {
            return this.intern == other.intern;
        }

        public override readonly bool Equals(object obj)
        {
            return Equals((UInt2x16)obj);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
            return (int)intern;
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