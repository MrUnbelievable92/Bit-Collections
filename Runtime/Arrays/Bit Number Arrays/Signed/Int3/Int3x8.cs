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
    unsafe public struct Int3x8 : IBitNumberArray<int>, IEquatable<Int3x8>
    {
        internal Int24 intern;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int3x8(int x0, int x1, int x2, int x3, int x4, int x5, int x6, int x7) : this(new int8(x0, x1, x2, x3, x4, x5, x6, x7))
        { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int3x8(int x0_7) : this(new int8(x0_7))
        { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int3x8(int8 x0_7)
        {
Assert.IsBetween(x0_7.x0, Int3.MinValue, Int3.MaxValue);
Assert.IsBetween(x0_7.x1, Int3.MinValue, Int3.MaxValue);
Assert.IsBetween(x0_7.x2, Int3.MinValue, Int3.MaxValue);
Assert.IsBetween(x0_7.x3, Int3.MinValue, Int3.MaxValue);
Assert.IsBetween(x0_7.x4, Int3.MinValue, Int3.MaxValue);
Assert.IsBetween(x0_7.x5, Int3.MinValue, Int3.MaxValue);
Assert.IsBetween(x0_7.x6, Int3.MinValue, Int3.MaxValue);
Assert.IsBetween(x0_7.x7, Int3.MinValue, Int3.MaxValue);

            int8 mask = (int)maxmath.bitmask32(new Int3x8().BitsPerNumber);

            intern = (Int24)maxmath.csum(maxmath.shl(mask & x0_7, new Int3x8().BitsPerNumber * new int8(0, 1, 2, 3, 4, 5, 6, 7)));
        }


        public readonly int MinValue => Int3.MinValue;
        public readonly int MaxValue => Int3.MaxValue;
        public readonly int Length => 8;
        public readonly int BitsPerNumber => 3;


        public int x0
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[0];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[0] = value;
        }
        public int x1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[1];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[1] = value;
        }
        public int x2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[2];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[2] = value;
        }
        public int x3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[3];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[3] = value;
        }
        public int x4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[4];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[4] = value;
        }
        public int x5
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[5];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[5] = value;
        }
        public int x6
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[6];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[6] = value;
        }
        public int x7
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => this[7];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[7] = value;
        }


        public int8 x0_7
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                Int24 x = intern;

                // manual maxmath.signextend, saving 1 shift
                int8 temp = maxmath.shl((int8)(*(int*)&x), 32 - (BitsPerNumber * new int8(1, 2, 3, 4, 5, 6, 7, 8)));

                return temp >> (32 - BitsPerNumber);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                this = new Int3x8(value);
            }
        }


        public int this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(Int3.MinValue, Int3.MaxValue)]
            readonly get
            {
Assert.IsWithinArrayBounds(index, Length);

                Int24 x = intern;

                // manual sign extend => 1 bitshift less; same if 'index' is not a compile time constant
                return (*(int*)&x << (32 - ((1 + index) * BitsPerNumber))) >> (32 - BitsPerNumber);
            }
    
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsBetween(value, MinValue, MaxValue);
Assert.IsWithinArrayBounds(index, Length);

                Int24 x = intern;

                int shiftValue = index * BitsPerNumber;
                int newValue = (value & (int)maxmath.bitmask32(BitsPerNumber)) << shiftValue;
                int mask = math.rol(~(int)maxmath.bitmask32(BitsPerNumber), shiftValue);

                intern = (Int24)((*(int*)&x & mask) | newValue);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Int3x8 other)
        {
            return this.intern == other.intern;
        }

        public override readonly bool Equals(object obj)
        {
            return Equals((Int3x8)obj);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
            return intern.GetHashCode();
        }
    
    
        public override string ToString()
        {
            return new Enumerator<int>(this).ToString();
        }
    
    
        public IEnumerator<int> GetEnumerator()
        {
            return new Enumerator<int>(this);
        }
    
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumerator<int>(this);
        }
    }
}