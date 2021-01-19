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
    unsafe public struct UInt12x2 : IBitNumberArray<uint>, IEquatable<UInt12x2>
    {
        internal UInt24 intern;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt12x2(uint xy)
        {
Assert.IsNotGreater(xy, UInt12.MaxValue);

            intern = (UInt24)((xy << new UInt12x2().BitsPerNumber) | xy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt12x2(uint x, uint y)
        {
Assert.IsNotGreater(x, UInt12.MaxValue);
Assert.IsNotGreater(y, UInt12.MaxValue);

            intern = (UInt24)((y << new UInt12x2().BitsPerNumber) | x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt12x2(uint2 xy) : this(xy.x, xy.y)
        { }


        public readonly uint MinValue => UInt12.MinValue;
        public readonly uint MaxValue => UInt12.MaxValue;
        public readonly int Length => 2;
        public readonly int BitsPerNumber => 12;


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
                UInt24 x = intern;

                uint deref = *(uint*)&x;

                return MaxValue & new uint2(deref, deref >> BitsPerNumber);
            }
    
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                this = new UInt12x2(value);
            }
        }


        public uint this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange((ulong)UInt12.MinValue, (ulong)UInt12.MaxValue)]
            readonly get
            {
Assert.IsWithinArrayBounds(index, Length);

                UInt24 x = intern;

                return MaxValue & (*(uint*)&x >> (index * BitsPerNumber));
            }
    
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsNotGreater(value, UInt12.MaxValue);
Assert.IsWithinArrayBounds(index, Length);

                UInt24 x = intern;

                int shiftValue = index * BitsPerNumber;
                uint newValue = value << shiftValue;
                uint mask = math.rol(~MaxValue, shiftValue);

                intern = (UInt24)((*(uint*)&x & mask) | newValue);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(UInt12x2 other)
        {
            return this.intern == other.intern;
        }

        public override readonly bool Equals(object obj)
        {
            return Equals((UInt12x2)obj);
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