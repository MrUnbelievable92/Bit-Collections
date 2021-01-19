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
    unsafe public struct UInt4x6 : IBitNumberArray<uint>, IEquatable<UInt4x6>
    {
        internal UInt24 intern;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x6(uint x0, uint x1, uint x2, uint x3, uint x4, uint x5) : this(new uint8(x0, x1, x2, x3, x4, x5, 0, 0))
        { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x6(uint x0_5) : this(Unity.Burst.Intrinsics.X86.Avx.mm256_insert_epi64((uint8)x0_5, 0L, 3))
        { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x6(uint8 x0_5)
        {
Assert.IsNotGreater(x0_5.x0, UInt4.MaxValue);
Assert.IsNotGreater(x0_5.x1, UInt4.MaxValue);
Assert.IsNotGreater(x0_5.x2, UInt4.MaxValue);
Assert.IsNotGreater(x0_5.x3, UInt4.MaxValue);
Assert.IsNotGreater(x0_5.x4, UInt4.MaxValue);
Assert.IsNotGreater(x0_5.x5, UInt4.MaxValue);
Assert.IsNotGreater(x0_5.x6, 0u);
Assert.IsNotGreater(x0_5.x7, 0u);

            intern = (UInt24)maxmath.csum(maxmath.shl(x0_5, (uint)new UInt4x6().BitsPerNumber * new uint8(0u, 1u, 2u, 3u, 4u, 5u, 6u, 7u)));
        }


        public readonly uint MinValue => UInt4.MinValue;
        public readonly uint MaxValue => UInt4.MaxValue;
        public readonly int BitsPerNumber => 4;
        public readonly int Length => 6;


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


        public uint8 x0_5
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                UInt24 x = intern;

                return Unity.Burst.Intrinsics.X86.Avx.mm256_insert_epi64(MaxValue & maxmath.shrl(*(uint*)&x, (uint)BitsPerNumber * new uint8(0u, 1u, 2u, 3u, 4u, 5u, 6u, 7u)), 0L, 3);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                this = new UInt4x6(value);
            }
        }


        public uint this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange((ulong)UInt4.MinValue, (ulong)UInt4.MaxValue)]
            readonly get
            {
Assert.IsWithinArrayBounds(index, Length);

                UInt24 x = intern;

                return MaxValue & ((*(uint*)&x) >> (index * BitsPerNumber));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsNotGreater(value, UInt4.MaxValue);
Assert.IsWithinArrayBounds(index, Length);

                UInt24 x = intern;

                int shiftValue = index * BitsPerNumber;
                uint newValue = value << shiftValue;
                uint mask = math.rol(~MaxValue, shiftValue);

                intern = (UInt24)(((*(uint*)&x) & mask) | newValue);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(UInt4x6 other)
        {
            return this.intern == other.intern;
        }

        public override readonly bool Equals(object obj)
        {
            return Equals((UInt4x6)obj);
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