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
    unsafe public struct UInt20x2 : IBitNumberArray<uint>, IEquatable<UInt20x2>
    {
        internal UInt40 intern;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt20x2(ulong xy)
        {
Assert.IsNotGreater(xy, UInt20.MaxValue);

            intern = (UInt40)((xy << new UInt20x2().BitsPerNumber) | xy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt20x2(ulong x, ulong y)
        {
Assert.IsNotGreater(x, UInt20.MaxValue);
Assert.IsNotGreater(y, UInt20.MaxValue);

            intern = (UInt40)((y << new UInt20x2().BitsPerNumber) | x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt20x2(ulong2 xy) : this(xy.x, xy.y)
        { }


        public readonly uint MinValue => UInt20.MinValue;
        public readonly uint MaxValue => UInt20.MaxValue;
        public readonly int Length => 2;
        public readonly int BitsPerNumber => 20;


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
                UInt40 x = intern;

                ulong deref = *(ulong*)&x;

                return MaxValue & new ulong2(deref, deref >> BitsPerNumber);
            }
    
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                this = new UInt20x2(value);
            }
        }
    
    
        public uint this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange((ulong)UInt20.MinValue, (ulong)UInt20.MaxValue)]
            readonly get
            {
Assert.IsWithinArrayBounds(index, Length);

                UInt40 x = intern;

                return MaxValue & (uint)(*(ulong*)&x >> (index * BitsPerNumber));
            }
    
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsNotGreater(value, MaxValue);
Assert.IsWithinArrayBounds(index, Length);

                UInt40 x = intern;

                int shiftValue = index * BitsPerNumber;
                ulong newValue = (ulong)value << shiftValue;
                ulong mask = math.rol(~(ulong)MaxValue, shiftValue);

                intern = (UInt40)((*(ulong*)&x & mask) | newValue);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(UInt20x2 other)
        {
            return this.intern == other.intern;
        }

        public override readonly bool Equals(object obj)
        {
            return Equals((UInt20x2)obj);
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