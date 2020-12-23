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
    unsafe public struct UInt4x14 : IBitNumberArray<uint>, IEquatable<UInt4x14>
    {
        internal UInt56 intern;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x14(uint x0, uint x1, uint x2, uint x3, uint x4, uint x5, uint x6, uint x7, uint x8, uint x9, uint x10, uint x11, uint x12, uint x13) : this(new uint8(x0, x1, x2, x3, x4, x5, x6, x7), new uint8(x8, x9, x10, x11, x12, x13, 0, 0))
        { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x14(uint x0_13)
        {
            uint8 vector = x0_13;

            this = new UInt4x14(vector, Unity.Burst.Intrinsics.X86.Avx.mm256_insert_epi64(vector, 0L, 3));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x14(uint8 x0_7, uint8 x8_13)
        {
Assert.IsNotGreater(x0_7.x0,  UInt4.MaxValue);
Assert.IsNotGreater(x0_7.x1,  UInt4.MaxValue);
Assert.IsNotGreater(x0_7.x2,  UInt4.MaxValue);
Assert.IsNotGreater(x0_7.x3,  UInt4.MaxValue);
Assert.IsNotGreater(x0_7.x4,  UInt4.MaxValue);
Assert.IsNotGreater(x0_7.x5,  UInt4.MaxValue);
Assert.IsNotGreater(x0_7.x6,  UInt4.MaxValue);
Assert.IsNotGreater(x0_7.x7,  UInt4.MaxValue);
Assert.IsNotGreater(x8_13.x0, UInt4.MaxValue);
Assert.IsNotGreater(x8_13.x1, UInt4.MaxValue);
Assert.IsNotGreater(x8_13.x2, UInt4.MaxValue);
Assert.IsNotGreater(x8_13.x3, UInt4.MaxValue);
Assert.IsNotGreater(x8_13.x4, UInt4.MaxValue);
Assert.IsNotGreater(x8_13.x5, UInt4.MaxValue);
Assert.IsNotGreater(x8_13.x6, 0u);
Assert.IsNotGreater(x8_13.x7, 0u);

            intern = (UInt56)((ulong)maxmath.csum(maxmath.shl(x0_7, (uint)new UInt4x14().BitsPerNumber * new uint8(0u, 1u, 2u, 3u, 4u, 5u, 6u, 7u)))
                              |
                              ((ulong)maxmath.csum(maxmath.shl(x8_13, (uint)new UInt4x14().BitsPerNumber * new uint8(0u, 1u, 2u, 3u, 4u, 5u, 6u, 7u))) << (new UInt4x14().BitsPerNumber * 8)));
        }


        public readonly uint MinValue => UInt4.MinValue;
        public readonly uint MaxValue => UInt4.MaxValue;
        public readonly int BitsPerNumber => 4;
        public readonly int Length => 14;


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


        public uint this[[AssumeRange(0, 13)] int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
Assert.IsWithinArrayBounds(index, Length);

                fixed (void* ptr = &this)
                {
                    return MaxValue & (uint)((*(ulong*)ptr) >> (index * BitsPerNumber));
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsNotGreater(value, UInt4.MaxValue);
Assert.IsWithinArrayBounds(index, Length);

                fixed (void* ptr = &this)
                {
                    int shiftValue = index * BitsPerNumber;
                    ulong newValue = (ulong)value << shiftValue;
                    ulong mask = math.rol(~(ulong)MaxValue, shiftValue);

                    intern = (UInt56)(((*(ulong*)ptr) & mask) | newValue);
                }
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong4 GetSubArray([AssumeRange(0, 10)] int index)
        {
Assert.IsValidSubarray(index, 4, Length);

            fixed (void* ptr = &this)
            {
                return MaxValue & maxmath.shrl(*(ulong*)ptr, (ulong4)((uint)BitsPerNumber * ((uint)index + new uint4(0u, 1u, 2u, 3u))));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetSubArray([AssumeRange(0, 10)] int index, ulong4 value)
        {
Assert.IsValidSubarray(index, 4, Length);
Assert.IsNotGreater(value.x, UInt4.MaxValue);
Assert.IsNotGreater(value.y, UInt4.MaxValue);
Assert.IsNotGreater(value.z, UInt4.MaxValue);
Assert.IsNotGreater(value.w, UInt4.MaxValue);

            fixed (void* ptr = &this)
            {
                intern = (UInt56)(maxmath.andnot(*(ulong*)ptr,     (ulong)maxmath.bitmask64(4 * BitsPerNumber,   index * BitsPerNumber))
                                  |
                                  maxmath.csum(maxmath.shl(value, (ulong4)((uint)BitsPerNumber * ((uint)index + new uint4(0u, 1u, 2u, 3u))))));
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(UInt4x14 other)
        {
            return this.intern == other.intern;
        }

        public override readonly bool Equals(object obj)
        {
            return Equals((UInt4x14)obj);
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