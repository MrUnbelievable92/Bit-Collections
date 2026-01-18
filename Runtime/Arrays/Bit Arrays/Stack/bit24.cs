using DevTools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;
using MaxMath;

using static MaxMath.maxmath;
using static Unity.Mathematics.math;

namespace BitCollections
{
    [Serializable]
    unsafe public struct bit24 : IArray<bool>, IEquatable<bit24>
    {
        public UInt24 Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit24(uint value)
        {
            Bits = value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit24(int value)
        {
            Bits = (uint)value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit24(bool value)
        {
            Bits = (uint)(-tosbyte(value));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit24(bool x0, bool x1, bool x2, bool x3, bool x4, bool x5, bool x6, bool x7, bool x8, bool x9, bool x10, bool x11, bool x12, bool x13, bool x14, bool x15, bool x16, bool x17, bool x18, bool x19, bool x20, bool x21, bool x22, bool x23)
        {
            Bits = (uint)bitmask(new bool32(x0, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16, x17, x18, x19, x20, x21, x22, x23, false, false, false, false, false, false, false, false));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit24(bit8 x0_7, bit8 x8_15, bit8 x16_23)
        {
            Bits = ((uint)x0_7.Bits 
                  | ((uint)x8_15.Bits << 8)) 
                  | (((uint)x16_23.Bits << 16));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit24(bit16 x0_15, bit8 x16_23)
        {
            Bits = ((uint)x0_15.Bits | ((uint)x16_23.Bits << 16));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit24(bit8 x0_7, bit16 x8_23)
        {
            Bits = ((uint)x0_7.Bits | ((uint)x8_23.Bits << 8));
        }


        public readonly int Length => 24;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator bit24(bool input)
        {
            return new bit24(input);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt24(bit24 input)
        {
            return input.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int24(bit24 input)
        {
            return (Int24)input.Bits;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit24(UInt24 input)
        {
            return new bit24 { Bits = input };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit24(Int24 input)
        {
            return new bit24 { Bits = (UInt24)input };
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit24 operator ! (bit24 value)
        {
            value.Bits = ~value.Bits;

            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit24 operator == (bit24 left, bit24 right)
        {
            return !(left != right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit24 operator != (bit24 left, bit24 right)
        {
            return left ^ right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit24 operator & (bit24 left, bit24 right)
        {
            left.Bits &= right.Bits;

            return left;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit24 operator | (bit24 left, bit24 right)
        {
            left.Bits |= right.Bits;

            return left;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit24 operator ^ (bit24 left, bit24 right)
        {
            left.Bits ^= right.Bits;

            return left;
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit32(bit24 value)
        {
            return new bit32{ Bits = value.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit40(bit24 value)
        {
            return new bit40{ Bits = value.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit48(bit24 value)
        {
            return new bit48{ Bits = value.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit56(bit24 value)
        {
            return new bit56{ Bits = value.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit64(bit24 value)
        {
            return new bit64{ Bits = value.Bits };
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit24(bit32 value)
        {
            return new bit24{ Bits = (uint)value.Bits };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit24(bit40 value)
        {
            return new bit24{ Bits = (uint)value.Bits };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit24(bit48 value)
        {
            return new bit24{ Bits = (uint)value.Bits };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit24(bit56 value)
        {
            return new bit24{ Bits = (uint)value.Bits };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit24(bit64 value)
        {
            return new bit24{ Bits = (uint)value.Bits };
        }


        public bool this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return tobool(BitFieldHelper.Get<Bit>(Bits, index, 24));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Bits = (uint)BitFieldHelper.Set<Bit>(Bits, tobyte(value), index, 24);
            }
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit24 SetReplicate(bool value)
        {
            return new bit24(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit24 SetReplicate(int index, int numBits, bool value)
        {
            return new bit24 { Bits = BitFieldHelper.SetReplicate<Bit>(Bits, toint(value), numBits, index, Length) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit24 ResetFirst()
        {
            return new bit24 { Bits = bits_resetlowest((uint)Bits) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit24 ResetFirst(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = bitmask32((uint)numBits, (uint)index);
            uint reset = bits_resetlowest(Bits & mask);
            uint remaining = andnot(Bits, mask);

            return new bit24 { Bits = reset | remaining };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit24 SetFirst()
        {
            return new bit24 { Bits = bits_setlowest((uint)Bits) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit24 SetFirst(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = bitmask32((uint)numBits, (uint)index);
            uint set = bits_setlowest(~mask | Bits);

            return new bit24 { Bits = bits_select(Bits, set, mask) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit24 ResetLast()
        {
            return new bit24 { Bits = Bits & ((uint.MaxValue >> 1) >> lzcnt((uint)Bits)) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit24 ResetLast(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = bitmask32((uint)numBits, (uint)index);
            
            return new bit24 { Bits = andnot(Bits, touint((Bits & mask) != 0) << (31 - lzcnt(mask & Bits))) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit24 SetLast()
        {
            int leadingOnesCount = lzcnt(andnot(bitmask32(24), Bits));
            return new bit24 { Bits = Bits | (1u << ((32 - 1) - leadingOnesCount)) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit24 SetLast(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = bitmask32((uint)numBits, (uint)index);
            
            return new bit24 { Bits = Bits | (touint((Bits & mask) != mask) << (31 - lzcnt(andnot(mask, Bits)))) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit24 ShiftLeft(int amount)
        {
            return new bit24 { Bits = Bits << amount };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit24 ShiftLeft(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = bitmask32((uint)numBits, (uint)index);
            uint maskED = mask & Bits;

            return new bit24 { Bits = bits_select(Bits, maskED << amount, mask) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit24 ShiftRight(int amount)
        {
            return new bit24 { Bits = Bits >> amount };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit24 ShiftRight(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)bitmask32(numBits, index);
            uint maskED = mask & Bits;

            return new bit24 { Bits = bits_select(Bits, maskED >> amount, mask) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit24 RotateLeft(int amount)
        {
            return new bit24 { Bits = (Bits << amount) | (Bits >> (24 - amount)) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit24 RotateLeft(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)bitmask32(numBits, index);
            uint maskED = mask & Bits;

            int remainder = (int)((uint)amount % (uint)numBits);

            maskED = (maskED << remainder) | (maskED >> (numBits - remainder));
            
            return new bit24 { Bits = bits_select(Bits, maskED, mask) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit24 RotateRight(int amount)
        {
            return new bit24 { Bits = (Bits >> amount) | (Bits << (24 - amount)) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit24 RotateRight(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)bitmask32(numBits, index);
            uint maskED = mask & Bits;
            
            int remainder = (int)((uint)amount % (uint)numBits);

            maskED = (maskED >> remainder) | (maskED << (numBits - remainder));
            
            return new bit24 { Bits = bits_select(Bits, maskED, mask) };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit24 Reverse()
        {
            return new bit24 { Bits = reversebits((uint)Bits) >> (32 - 24) };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit24 Reverse(int index, int numBits)
        {
            uint rev = reversebits((uint)Bits);
            int shift = (int)((uint)(2 * index + numBits - 32) % 32u); 
            rev = rol(rev, shift); 

            return new bit24 { Bits = bits_select(Bits, rev, bitmask32((uint)numBits, (uint)index)) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit24 Swap(int index0, int index1)
        {
Assert.IsWithinArrayBounds(index0, Length);
Assert.IsWithinArrayBounds(index1, Length);

            uint bit1 = bits_extract((uint)Bits, index0, 1);
            uint bit2 = bits_extract((uint)Bits, index1, 1);

            uint swap = bit1 ^ bit2;
            uint shifted = (swap << index0) | (swap << index1);

            return new bit24 { Bits = Bits ^ shifted };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit24 Swap(int index0, int index1, int numBits)
        {
Assert.IsValidSubarray(index0, numBits, Length);
Assert.IsValidSubarray(index1, numBits, Length);
Assert.SubarraysDoNotOverlap(index0, index1, numBits, numBits);

            uint bits1 = bits_extract((uint)Bits, index0, numBits);
            uint bits2 = bits_extract((uint)Bits, index1, numBits);

            uint swap = bits1 ^ bits2;
            uint shifted = (swap << index0) | (swap << index1);

            return new bit24 { Bits = Bits ^ shifted };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit24 Flip()
        {
            return !this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit24 Flip(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return new bit24 { Bits = Bits ^ bitmask32((uint)numBits, (uint)index) };
        }

        

        [return: AssumeRange(0, 32)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int IndexOfFirst()
        {
            return tzcnt((uint)Bits);
        }

        [return: AssumeRange(0, 32)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int IndexOfFirst(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return tzcnt(Bits & bitmask32((uint)numBits, (uint)index));
        }

        [return: AssumeRange(-1, 31)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int IndexOfLast()
        {
            return 31 - lzcnt((uint)Bits);
        }

        [return: AssumeRange(-1, 31)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int IndexOfLast(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return 31 - lzcnt(Bits & bitmask32((uint)numBits, (uint)index));
        }

        [return: AssumeRange(0ul, 24ul)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint CountBits()
        {
            return (uint)countbits((uint)Bits);
        }

        [return: AssumeRange(0ul, 24ul)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint CountBits(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return (uint)countbits(Bits & bitmask32(numBits, index));
        }

        [return: AssumeRange(0ul, 32ul)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int FindString(bool value, int amount)
        {
            return BitAlgorithms.Find1String(value ? Bits : andnot(bitmask32(24u), Bits), amount);
        }

        [return: AssumeRange(0ul, 32ul)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int FindString(int index, int numBits, bool value, int amount)
        {
Assert.IsValidSubarray(index, numBits, Length);
            
            uint mask = bitmask32((uint)numBits, (uint)index);

            return BitAlgorithms.Find1String(value ? (mask & Bits) : andnot(mask, Bits), amount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAll()
        {
            return Bits == UInt24.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAll(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)bitmask32(numBits, index);

            return (Bits & mask) == mask;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAny()
        {
            return Bits != 0u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAny(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return (Bits & bitmask32(numBits, index)) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestNone()
        {
            return Bits == 0u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestNone(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return (Bits & bitmask32(numBits, index)) == 0u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestNotAll()
        {
            return Bits != UInt24.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestNotAll(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)bitmask32(numBits, index);

            return (Bits & mask) != mask;
        }


        public override readonly string ToString()
        {
            return Dump.Bits(this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
            return (int)Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(bit24 other)
        {
            return this.Bits == other.Bits;
        }
        public override readonly bool Equals(object obj)
        {
            return obj is bit24 converted && this.Equals(converted);
        }

        public readonly IEnumerator<bool> GetEnumerator()
        {
            return new ArrayEnumerator<bit24, bool>(this);
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<bit24, bool>(this);
        }
    }
}