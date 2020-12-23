using DevTools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;
using Unity.Mathematics;

namespace BitCollections
{
    [Serializable]
    unsafe public struct UInt4x2 : IBitNumberArray<uint>, IEquatable<UInt4x2>
    {
        internal byte intern;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x2(uint xy)
        {
Assert.IsNotGreater(xy, UInt4.MaxValue);

            intern = (byte)((xy << new UInt4x2().BitsPerNumber) | xy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x2(uint x, uint y)
        {
Assert.IsNotGreater(x, UInt4.MaxValue);
Assert.IsNotGreater(y, UInt4.MaxValue);

            intern = (byte)((y << new UInt4x2().BitsPerNumber) | x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x2(uint2 xy) : this(xy.x, xy.y)
        { }


        public readonly uint MinValue => UInt4.MinValue;
        public readonly uint MaxValue => UInt4.MaxValue;
        public readonly int BitsPerNumber => 4;
        public readonly int Length => 2;


        public uint x
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[0];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[0] = value;
        }
        public uint y
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[1];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[1] = value;
        }

        public uint2 xy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return new uint2(intern & MaxValue, (uint)intern >> BitsPerNumber);
            }
    
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                this = new UInt4x2(value);
            }
        }


        public uint this[[AssumeRange(0, 1)] int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
Assert.IsWithinArrayBounds(index, Length);

                return MaxValue & ((uint)intern >> (index * BitsPerNumber));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsNotGreater(value, UInt4.MaxValue);
Assert.IsWithinArrayBounds(index, Length);

                int shiftValue = index * BitsPerNumber;
                uint newValue = value << shiftValue;
                uint mask = math.rol(~MaxValue, shiftValue);

                intern = (byte)((intern & mask) | newValue);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(UInt4x2 other)
        {
            return this.intern == other.intern;
        }

        public override readonly bool Equals(object obj)
        {
            return Equals((UInt4x2)obj);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
            return intern;
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