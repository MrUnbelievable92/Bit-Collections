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
    unsafe public struct UInt12x4 : IBitNumberArray<uint>, IEquatable<UInt12x4>
    {
        internal UInt48 intern;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt12x4(ulong x, ulong y, ulong z, ulong w)
        {
Assert.IsNotGreater(x, UInt12.MaxValue);
Assert.IsNotGreater(y, UInt12.MaxValue);
Assert.IsNotGreater(z, UInt12.MaxValue);
Assert.IsNotGreater(w, UInt12.MaxValue);

            intern = (UInt48)((x
                               |
                               (y << new UInt12x4().BitsPerNumber))
                               |
                               ((z << (2 * new UInt12x4().BitsPerNumber))
                               |
                               (w << (3 * new UInt12x4().BitsPerNumber))));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt12x4(ulong xyzw)
        {
Assert.IsNotGreater(xyzw, UInt12.MaxValue);

            intern = (UInt48)((xyzw
                               |
                               (xyzw << new UInt12x4().BitsPerNumber))
                               |
                               ((xyzw << (2 * new UInt12x4().BitsPerNumber))
                               |
                               (xyzw << (3 * new UInt12x4().BitsPerNumber))));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt12x4(ulong4 xyzw)
        {
Assert.IsNotGreater(xyzw.x, UInt12.MaxValue);
Assert.IsNotGreater(xyzw.y, UInt12.MaxValue);
Assert.IsNotGreater(xyzw.z, UInt12.MaxValue);
Assert.IsNotGreater(xyzw.w, UInt12.MaxValue);

            ulong4 csum = maxmath.shl(xyzw, (ulong)new UInt12x4().BitsPerNumber * new ulong4(0ul, 1ul, 2ul, 3ul));

            intern = (UInt48)maxmath.csum(csum);
        }


        public readonly uint MinValue => UInt12.MinValue;
        public readonly uint MaxValue => UInt12.MaxValue;
        public readonly int Length => 4;
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

        public ulong4 xyzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                fixed (void* ptr = &this)
                {
                    return MaxValue & maxmath.shrl(*(ulong*)ptr, (ulong)BitsPerNumber * new ulong4(0ul, 1ul, 2ul, 3ul));
                }
            }
        
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                this = new UInt12x4(value);
            }
        }
    
    
        public uint this[[AssumeRange(0, 3)] int index]
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
Assert.IsNotGreater(value, UInt12.MaxValue);
Assert.IsWithinArrayBounds(index, Length);
    
                fixed (void* ptr = &this)
                {
                    int shiftValue = index * BitsPerNumber;
                    ulong newValue = (ulong)value << shiftValue;
                    ulong mask = math.rol(~(ulong)MaxValue, shiftValue);

                    intern = (UInt48)((*(ulong*)ptr & mask) | newValue);
                }
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(UInt12x4 other)
        {
            return this.intern == other.intern;
        }

        public override readonly bool Equals(object obj)
        {
            return Equals((UInt12x4)obj);
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