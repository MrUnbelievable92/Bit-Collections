using DevTools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;
using Unity.Mathematics;
using MaxMath;

using static MaxMath.maxmath;
using static Unity.Mathematics.math;

namespace BitCollections
{
    [Serializable]
    unsafe public struct bit16 : IArray<bool>, IEquatable<bit16>
    {
        public ushort Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit16(ushort value)
        {
            Bits = value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit16(short value)
        {
            Bits = (ushort)value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit16(bool value)
        {
            Bits = (ushort)(-tosbyte(value));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit16(bool x0, bool x1, bool x2, bool x3, bool x4, bool x5, bool x6, bool x7, bool x8, bool x9, bool x10, bool x11, bool x12, bool x13, bool x14, bool x15)
        {
            Bits = (ushort)bitmask(new bool16(x0, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit16(bit8 x0_7, bit8 x8_15)
        {
            Bits = (ushort)(x0_7.Bits | (x8_15.Bits << 8));
        }

        public readonly int Length => 16;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator bit16(bool input)
        {
            return new bit16(input);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort(bit16 input)
        {
            return input.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short(bit16 input)
        {
            return (short)input.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half(bit16 input)
        {
            return new half { value = input.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator bool16(bit16 input)
        {
            return tobool16(input.Bits);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit16(ushort input)
        {
            return new bit16 { Bits = input };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit16(short input)
        {
            return new bit16 { Bits = (ushort)input };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit16(half input)
        {
            return new bit16 { Bits = input.value };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit16(bool16 input)
        {
            return (bit16)(ushort)bitmask(input);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit16 operator ! (bit16 value)
        {
            value.Bits = (ushort)(~value.Bits);

            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit16 operator == (bit16 left, bit16 right)
        {
            return !(left != right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit16 operator != (bit16 left, bit16 right)
        {
            return left ^ right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit16 operator & (bit16 left, bit16 right)
        {
            left.Bits = (ushort)(left.Bits & right.Bits);

            return left;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit16 operator | (bit16 left, bit16 right)
        {
            left.Bits = (ushort)(left.Bits | right.Bits);

            return left;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit16 operator ^ (bit16 left, bit16 right)
        {
            left.Bits = (ushort)(left.Bits ^ right.Bits);

            return left;
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit24(bit16 value)
        {
            return new bit24{ Bits = value.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit32(bit16 value)
        {
            return new bit32{ Bits = value.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit40(bit16 value)
        {
            return new bit40{ Bits = value.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit48(bit16 value)
        {
            return new bit48{ Bits = value.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit56(bit16 value)
        {
            return new bit56{ Bits = value.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit64(bit16 value)
        {
            return new bit64{ Bits = value.Bits };
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit16(bit32 value)
        {
            return new bit16{ Bits = (ushort)value.Bits };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit16(bit24 value)
        {
            return new bit16{ Bits = (ushort)value.Bits };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit16(bit40 value)
        {
            return new bit16{ Bits = (ushort)value.Bits };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit16(bit48 value)
        {
            return new bit16{ Bits = (ushort)value.Bits };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit16(bit56 value)
        {
            return new bit16{ Bits = (ushort)value.Bits };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit16(bit64 value)
        {
            return new bit16{ Bits = (ushort)value.Bits };
        }


        public bool this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return tobool(BitFieldHelper.Get<Bit>(Bits, index, 16));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Bits = (ushort)BitFieldHelper.Set<Bit>(Bits, tobyte(value), index, 16);
            }
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit16 SetReplicate(bool value)
        {
            return new bit16(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit16 SetReplicate(int index, int numBits, bool value)
        {
            return new bit16 { Bits = (ushort)BitFieldHelper.SetReplicate<Bit>(Bits, toint(value), numBits, index, Length) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit16 ResetFirst()
        {
            return new bit16 { Bits = (ushort)bits_resetlowest((uint)Bits) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit16 ResetFirst(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = bitmask32((uint)numBits, (uint)index);
            uint reset = bits_resetlowest((uint)Bits & mask);
            uint remaining = andnot(Bits, mask);

            return new bit16 { Bits = (ushort)(reset | remaining) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit16 SetFirst()
        {
            return new bit16 { Bits = (ushort)bits_setlowest(Bits) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit16 SetFirst(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = bitmask32((uint)numBits, (uint)index);
            uint set = bits_setlowest(~mask | Bits);

            return new bit16 { Bits = (ushort)bits_select(Bits, set, mask) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit16 ResetLast()
        {
            return new bit16 { Bits = (ushort)((uint)Bits & (((uint)ushort.MaxValue >> 1) >> lzcnt(Bits))) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit16 ResetLast(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);
            
            uint mask = bitmask32((uint)numBits, (uint)index);
            
            return new bit16 { Bits = andnot(Bits, (ushort)(touint((Bits & mask) != 0) << (31 - lzcnt(mask & Bits)))) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit16 SetLast()
        {
            int leadingOnesCount = lzcnt((ushort)(~(uint)Bits));
            return new bit16 { Bits = (ushort)((uint)Bits | (1u << ((Length - 1) - leadingOnesCount))) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit16 SetLast(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = bitmask32((uint)numBits, (uint)index);
            
            return new bit16 { Bits = (ushort)(Bits | (touint((Bits & mask) != mask) << (31 - lzcnt(andnot(mask, Bits))))) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit16 ShiftLeft(int amount)
        {
            return new bit16 { Bits = (ushort)(Bits << amount) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit16 ShiftLeft(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)bitmask32((uint)numBits, (uint)index);
            uint maskED = mask & Bits;

            return new bit16 { Bits = (ushort)(bits_select(Bits, maskED << amount, mask)) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit16 ShiftRight(int amount)
        {
            return new bit16 { Bits = (ushort)(Bits >> amount) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit16 ShiftRight(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)bitmask32(numBits, index);
            uint maskED = mask & Bits;

            return new bit16 { Bits = (ushort)(bits_select(Bits, maskED >> amount, mask)) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit16 RotateLeft(int amount)
        {
            return new bit16 { Bits = rol(Bits, amount) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit16 RotateLeft(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)bitmask32(numBits, index);
            uint maskED = mask & Bits;

            int remainder = (int)((uint)amount % (uint)numBits);

            maskED = (maskED << remainder) | (maskED >> (numBits - remainder));
            
            return new bit16 { Bits = bits_select(Bits, (ushort)maskED, (ushort)mask) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit16 RotateRight(int amount)
        {
            return new bit16 { Bits = ror(Bits, amount) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit16 RotateRight(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)bitmask32(numBits, index);
            uint maskED = mask & Bits;
            
            int remainder = (int)((uint)amount % (uint)numBits);

            maskED = (maskED >> remainder) | (maskED << (numBits - remainder));
            
            return new bit16 { Bits = bits_select(Bits, (ushort)maskED, (ushort)mask) };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit16 Reverse()
        {
            return new bit16 { Bits = reversebits(Bits) };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit16 Reverse(int index, int numBits)
        {
            ushort rev = reversebits(Bits);
            int shift = (int)((uint)(2 * index + numBits - 16) % 16u); 
            rev = rol(rev, shift); 

            return new bit16 { Bits = bits_select(Bits, rev, bitmask16((uint)numBits, (uint)index)) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit16 Swap(int index0, int index1)
        {
Assert.IsWithinArrayBounds(index0, Length);
Assert.IsWithinArrayBounds(index1, Length);

            uint bit1 = bits_extract((uint)Bits, index0, 1);
            uint bit2 = bits_extract((uint)Bits, index1, 1);

            uint swap = bit1 ^ bit2;
            uint shifted = (swap << index0) | (swap << index1);

            return new bit16 { Bits = (ushort)(Bits ^ shifted) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit16 Swap(int index0, int index1, int numBits)
        {
Assert.IsValidSubarray(index0, numBits, Length);
Assert.IsValidSubarray(index1, numBits, Length);
Assert.SubarraysDoNotOverlap(index0, index1, numBits, numBits);

            uint bits1 = (uint)bits_extract(Bits, index0, numBits);
            uint bits2 = (uint)bits_extract(Bits, index1, numBits);

            uint swap = bits1 ^ bits2;
            uint shifted = (swap << index0) | (swap << index1);

            return new bit16 { Bits = (ushort)(Bits ^ shifted) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit16 Flip()
        {
            return !this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit16 Flip(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return new bit16 { Bits = (ushort)(Bits ^ bitmask32(numBits, index)) };
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

        [return: AssumeRange(-1, 15)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int IndexOfLast()
        {
            return 15 - lzcnt(Bits);
        }

        [return: AssumeRange(-1, 15)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int IndexOfLast(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return 15 - lzcnt((ushort)(Bits & bitmask16((uint)numBits, (uint)index)));
        }

        [return: AssumeRange(0ul, 16ul)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint CountBits()
        {
            return (uint)countbits((uint)Bits);
        }

        [return: AssumeRange(0ul, 16ul)]
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
            return BitAlgorithms.Find1String(value ? Bits : (ushort)~Bits, amount);
        }

        [return: AssumeRange(0ul, 32ul)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int FindString(int index, int numBits, bool value, int amount)
        {
Assert.IsValidSubarray(index, numBits, Length);
            
            ushort mask = bitmask16((uint)numBits, (uint)index);

            return BitAlgorithms.Find1String(value ? (ushort)(mask & Bits) : andnot(mask, Bits), amount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAll()
        {
            return Bits == (uint)ushort.MaxValue;
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
            return Bits != 0;
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
            return Bits != ushort.MaxValue;
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

        [return: AssumeRange(0, ushort.MaxValue)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
            return (int)Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(bit16 other)
        {
            return this.Bits == other.Bits;
        }

        public override readonly bool Equals(object obj)
        {
            return obj is bit16 converted && this.Equals(converted);
        }

        public readonly IEnumerator<bool> GetEnumerator()
        {
            return new ArrayEnumerator<bit16, bool>(this);
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<bit16, bool>(this);
        }
    }
}