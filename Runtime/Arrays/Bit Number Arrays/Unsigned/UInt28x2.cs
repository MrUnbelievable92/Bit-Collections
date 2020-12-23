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
    unsafe public struct UInt28x2 : IBitNumberArray<uint>, IEquatable<UInt28x2>
    {
        internal UInt56 intern;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt28x2(ulong xy)
        {
Assert.IsNotGreater(xy, UInt28.MaxValue);

            intern = (UInt56)((xy << new UInt28x2().BitsPerNumber) | xy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt28x2(ulong x, ulong y)
        {
Assert.IsNotGreater(x, UInt28.MaxValue);
Assert.IsNotGreater(y, UInt28.MaxValue);

            intern = (UInt56)((y << new UInt28x2().BitsPerNumber) | x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt28x2(ulong2 xy) : this(xy.x, xy.y)
        { }


        public readonly uint MinValue => UInt28.MinValue;
        public readonly uint MaxValue => UInt28.MaxValue;
        public readonly int Length => 2;
        public readonly int BitsPerNumber => 28;


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

        public ulong2 xy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                fixed (void* ptr = &this)
                {
                    ulong deref = *(ulong*)ptr;

                    return MaxValue & new ulong2(deref, deref >> BitsPerNumber);
                }
            }
    
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                this = new UInt28x2(value);
            }
        }
    
    
        public uint this[[AssumeRange(0, 1)] int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
Assert.IsWithinArrayBounds(index, Length);

                fixed (void* ptr = &this)
                {
                    return MaxValue & (uint)(*(ulong*)ptr >> (index * BitsPerNumber));
                }
            }
    
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsNotGreater(value, MaxValue);
Assert.IsWithinArrayBounds(index, Length);

                fixed (void* ptr = &this)
                {
                    int shiftValue = index * BitsPerNumber;
                    ulong newValue = (ulong)value << shiftValue;
                    ulong mask = math.rol(~(ulong)MaxValue, shiftValue);

                    intern = (UInt56)((*(ulong*)ptr & mask) | newValue);
                }
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(UInt28x2 other)
        {
            return this.intern == other.intern;
        }

        public override readonly bool Equals(object obj)
        {
            return Equals((UInt28x2)obj);
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