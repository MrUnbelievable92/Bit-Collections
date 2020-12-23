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
    unsafe public struct UInt2x4 : IBitNumberArray<uint>, IEquatable<UInt2x4>
    {
        internal byte intern;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x4(uint x, uint y, uint z, uint w)
        {
Assert.IsNotGreater(x, UInt2.MaxValue);
Assert.IsNotGreater(y, UInt2.MaxValue);
Assert.IsNotGreater(z, UInt2.MaxValue);
Assert.IsNotGreater(w, UInt2.MaxValue);

            intern = (byte)((x
                            |
                            (y << new UInt2x4().BitsPerNumber))
                            |
                            ((z << (2 * new UInt2x4().BitsPerNumber))
                            |
                            (w << (3 * new UInt2x4().BitsPerNumber))));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x4(uint xyzw)
        {
Assert.IsNotGreater(xyzw, UInt2.MaxValue);

            intern = (byte)((xyzw
                            |
                            (xyzw << new UInt2x4().BitsPerNumber))
                            |
                            ((xyzw << (2 * new UInt2x4().BitsPerNumber))
                            |
                            (xyzw << (3 * new UInt2x4().BitsPerNumber))));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x4(uint4 xyzw)
        {
Assert.IsNotGreater(xyzw.x, UInt2.MaxValue);
Assert.IsNotGreater(xyzw.y, UInt2.MaxValue);
Assert.IsNotGreater(xyzw.z, UInt2.MaxValue);
Assert.IsNotGreater(xyzw.w, UInt2.MaxValue);

            intern = (byte)math.csum(maxmath.shl(xyzw, (uint)new UInt2x4().BitsPerNumber * new uint4(0u, 1u, 2u, 3u)));
        }


        public readonly uint MinValue => UInt2.MinValue;
        public readonly uint MaxValue => UInt2.MaxValue;
        public readonly int BitsPerNumber => 2;
        public readonly int Length => 4;


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
        public uint z 
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[2];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[2] = value;
        }
        public uint w 
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[3];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[3] = value;
        }

        public uint4 xyzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return MaxValue & maxmath.shrl(intern, (uint)BitsPerNumber * new uint4(0u, 1u, 2u, 3u));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                this = new UInt2x4(value);
            }
        }


        public uint this[[AssumeRange(0, 3)] int index]
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
Assert.IsNotGreater(value, UInt2.MaxValue);
Assert.IsWithinArrayBounds(index, Length);

                int shiftValue = index * BitsPerNumber;
                uint newValue = value << shiftValue;
                uint mask = math.rol(~MaxValue, shiftValue);

                intern = (byte)((intern & mask) | newValue);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(UInt2x4 other)
        {
            return this.intern == other.intern;
        }

        public override readonly bool Equals(object obj)
        {
            return Equals((UInt2x4)obj);
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