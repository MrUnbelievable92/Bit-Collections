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
    unsafe public struct UInt3x8 : IBitNumberArray<uint>, IEquatable<UInt3x8>
    {
        internal UInt24 intern;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt3x8(uint x0, uint x1, uint x2, uint x3, uint x4, uint x5, uint x6, uint x7) : this(new uint8(x0, x1, x2, x3, x4, x5, x6, x7))
        { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt3x8(uint x0_7) : this(new uint8(x0_7))
        { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt3x8(uint8 x0_7)
        {
Assert.IsNotGreater(x0_7.x0, UInt3.MaxValue);
Assert.IsNotGreater(x0_7.x1, UInt3.MaxValue);
Assert.IsNotGreater(x0_7.x2, UInt3.MaxValue);
Assert.IsNotGreater(x0_7.x3, UInt3.MaxValue);
Assert.IsNotGreater(x0_7.x4, UInt3.MaxValue);
Assert.IsNotGreater(x0_7.x5, UInt3.MaxValue);
Assert.IsNotGreater(x0_7.x6, UInt3.MaxValue);
Assert.IsNotGreater(x0_7.x7, UInt3.MaxValue);

            intern = (UInt24)maxmath.csum(maxmath.shl(x0_7, (uint)new UInt3x8().BitsPerNumber * new uint8(0u, 1u, 2u, 3u, 4u, 5u, 6u, 7u)));
        }


        public readonly uint MinValue => UInt3.MinValue;
        public readonly uint MaxValue => UInt3.MaxValue;
        public readonly int Length => 8;
        public readonly int BitsPerNumber => 3;
    
    
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

        public uint8 x0_7
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return MaxValue & maxmath.shrl(intern, (uint)BitsPerNumber * new uint8(0u, 1u, 2u, 3u, 4u, 5u, 6u, 7u));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                this = new UInt3x8(value);
            }
        }


        public uint this[[AssumeRange(0, 7)] int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
Assert.IsWithinArrayBounds(index, Length);

                fixed (void* ptr = &this)
                {
                    return MaxValue & (*(uint*)ptr >> (index * BitsPerNumber));
                }
            }
    
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsNotGreater(value, UInt3.MaxValue);
Assert.IsWithinArrayBounds(index, Length);

                fixed (void* ptr = &this)
                {
                    int shiftValue = index * BitsPerNumber;
                    uint newValue = value << shiftValue;
                    uint mask = math.rol(~MaxValue, shiftValue);

                    intern = (UInt24)((*(uint*)ptr & mask) | newValue);
                }
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(UInt3x8 other)
        {
            return this.intern == other.intern;
        }

        public override readonly bool Equals(object obj)
        {
            return Equals((UInt3x8)obj);
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