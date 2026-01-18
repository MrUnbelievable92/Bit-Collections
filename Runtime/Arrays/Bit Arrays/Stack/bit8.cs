using DevTools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;
using MaxMath;

using static Unity.Mathematics.math;
using static MaxMath.maxmath;

namespace BitCollections
{
    [Serializable]
    unsafe public struct bit8 : IArray<bool>, IEquatable<bit8>
    {
        public byte Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit8(byte value)
        {
            Bits = value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit8(sbyte value)
        {
            Bits = (byte)value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit8(bool value)
        {
            Bits = (byte)(-tosbyte(value));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit8(bool x0, bool x1, bool x2, bool x3, bool x4, bool x5, bool x6, bool x7)
        {
            Bits = (byte)bitmask(new bool8(x0, x1, x2, x3, x4, x5, x6, x7));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit8(bool[] values, int index = 0)
        {
Assert.IsValidSubarray(index, new bit8().Length, values.Length);

            Bits = 0;

            for (int i = 0; i < 8; i++, index++)
            {
                this[i] = values[index];
            }
        }


        public readonly int Length => 8;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator bit8(bool input)
        {
            return new bit8(input);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte(bit8 input)
        {
            return input.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte(bit8 input)
        {
            return (sbyte)input.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator quarter(bit8 input)
        {
            return *(quarter*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator bool8(bit8 input)
        {
            return tobool8(input.Bits);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit8(byte input)
        {
            return new bit8 { Bits = input };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit8(sbyte input)
        {
            return new bit8 { Bits = (byte)input };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit8(quarter input)
        {
            return new bit8 { Bits = input.value };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit8(bool8 input)
        {
            return (bit8)(byte)bitmask(input);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit8 operator ! (bit8 value)
        {
            value.Bits = (byte)(~value.Bits);

            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit8 operator == (bit8 left, bit8 right)
        {
            return !(left != right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit8 operator != (bit8 left, bit8 right)
        {
            return left ^ right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit8 operator & (bit8 left, bit8 right)
        {
            left.Bits = (byte)(left.Bits & right.Bits);

            return left;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit8 operator | (bit8 left, bit8 right)
        {
            left.Bits = (byte)(left.Bits | right.Bits);

            return left;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit8 operator ^ (bit8 left, bit8 right)
        {
            left.Bits = (byte)(left.Bits ^ right.Bits);

            return left;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit16(bit8 value)
        {
            return new bit16{ Bits = value.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit24(bit8 value)
        {
            return new bit24{ Bits = value.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit32(bit8 value)
        {
            return new bit32{ Bits = value.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit40(bit8 value)
        {
            return new bit40{ Bits = value.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit48(bit8 value)
        {
            return new bit48{ Bits = value.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit56(bit8 value)
        {
            return new bit56{ Bits = value.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit64(bit8 value)
        {
            return new bit64{ Bits = value.Bits };
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit8(bit16 value)
        {
            return new bit8{ Bits = (byte)value.Bits };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit8(bit32 value)
        {
            return new bit8{ Bits = (byte)value.Bits };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit8(bit24 value)
        {
            return new bit8{ Bits = (byte)value.Bits };
        }

        public static explicit operator bit8(bit40 value)
        {
            return new bit8{ Bits = (byte)value.Bits };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit8(bit48 value)
        {
            return new bit8{ Bits = (byte)value.Bits };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit8(bit56 value)
        {
            return new bit8{ Bits = (byte)value.Bits };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit8(bit64 value)
        {
            return new bit8{ Bits = (byte)value.Bits };
        }


        public bool this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return tobool(BitFieldHelper.Get<Bit>(Bits, index, 8));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Bits = (byte)BitFieldHelper.Set<Bit>(Bits, tobyte(value), index, 8);
            }
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit8 SetReplicate(bool value)
        {
            return new bit8(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit8 SetReplicate(int index, int numBits, bool value)
        {
            return new bit8 { Bits = (byte)BitFieldHelper.SetReplicate<Bit>(Bits, toint(value), numBits, index, Length) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit8 ResetFirst()
        {
            return new bit8 { Bits = (byte)bits_resetlowest((uint)Bits) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit8 ResetFirst(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = bitmask32((uint)numBits, (uint)index);
            uint reset = bits_resetlowest((uint)Bits & mask);
            uint remaining = andnot(Bits, mask);

            return new bit8 { Bits = (byte)(reset | remaining) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit8 SetFirst()
        {
            return new bit8 { Bits = (byte)bits_setlowest(Bits) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit8 SetFirst(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = bitmask32((uint)numBits, (uint)index);
            uint set = bits_setlowest(~mask | Bits);

            return new bit8 { Bits = (byte)bits_select(Bits, set, mask) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit8 ResetLast()
        {
            return new bit8 { Bits = (byte)((uint)Bits & (((uint)byte.MaxValue >> 1) >> lzcnt(Bits))) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit8 ResetLast(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = bitmask32((uint)numBits, (uint)index);
            
            return new bit8 { Bits = andnot(Bits, (byte)(touint((Bits & mask) != 0) << (31 - lzcnt(mask & Bits)))) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit8 SetLast()
        {
            int leadingOnesCount = lzcnt((byte)(~(uint)Bits));
            return new bit8 { Bits = (byte)((uint)Bits | (1u << ((Length - 1) - leadingOnesCount))) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit8 SetLast(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = bitmask32((uint)numBits, (uint)index);
            
            return new bit8 { Bits = (byte)(Bits | (touint((Bits & mask) != mask) << (31 - lzcnt(andnot(mask, Bits))))) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit8 ShiftLeft(int amount)
        {
            return new bit8 { Bits = (byte)(Bits << amount) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit8 ShiftLeft(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)bitmask32((uint)numBits, (uint)index);
            uint maskED = mask & Bits;

            return new bit8 { Bits = (byte)(bits_select(Bits, maskED << amount, mask)) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit8 ShiftRight(int amount)
        {
            return new bit8 { Bits = (byte)(Bits >> amount) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit8 ShiftRight(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)bitmask32(numBits, index);
            uint maskED = mask & Bits;

            return new bit8 { Bits = (byte)(bits_select(Bits, maskED >> amount, mask)) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit8 RotateLeft(int amount)
        {
            return new bit8 { Bits = rol(Bits, amount) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit8 RotateLeft(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)bitmask32(numBits, index);
            uint maskED = mask & Bits;

            int remainder = (int)((uint)amount % (uint)numBits);

            maskED = (maskED << remainder) | (maskED >> (numBits - remainder));
            
            return new bit8 { Bits = bits_select(Bits, (byte)maskED, (byte)mask) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit8 RotateRight(int amount)
        {
            return new bit8 { Bits = ror(Bits, amount) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit8 RotateRight(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)bitmask32(numBits, index);
            uint maskED = mask & Bits;
            
            int remainder = (int)((uint)amount % (uint)numBits);

            maskED = (maskED >> remainder) | (maskED << (numBits - remainder));
            
            return new bit8 { Bits = bits_select(Bits, (byte)maskED, (byte)mask) };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit8 Reverse()
        {
            return new bit8 { Bits = reversebits(Bits) };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit8 Reverse(int index, int numBits)
        {
            byte rev = reversebits(Bits);
            int shift = (int)((uint)(2 * index + numBits - 8) % 8u); 
            rev = rol(rev, shift); 

            return new bit8 { Bits = bits_select(Bits, rev, bitmask8((uint)numBits, (uint)index)) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit8 Swap(int index0, int index1)
        {
Assert.IsWithinArrayBounds(index0, Length);
Assert.IsWithinArrayBounds(index1, Length);

            uint bit1 = bits_extract((uint)Bits, index0, 1);
            uint bit2 = bits_extract((uint)Bits, index1, 1);

            uint swap = bit1 ^ bit2;
            uint shifted = (swap << index0) | (swap << index1);

            return new bit8 { Bits = (byte)(Bits ^ shifted) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit8 Swap(int index0, int index1, int numBits)
        {
Assert.IsValidSubarray(index0, numBits, Length);
Assert.IsValidSubarray(index1, numBits, Length);
Assert.SubarraysDoNotOverlap(index0, index1, numBits, numBits);

            uint bits1 = (uint)bits_extract(Bits, index0, numBits);
            uint bits2 = (uint)bits_extract(Bits, index1, numBits);

            uint swap = bits1 ^ bits2;
            uint shifted = (swap << index0) | (swap << index1);

            return new bit8 { Bits = (byte)(Bits ^ shifted) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit8 Flip()
        {
            return !this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit8 Flip(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return new bit8 { Bits = (byte)(Bits ^ bitmask32(numBits, index)) };
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

            return tzcnt(Bits & bitmask32(numBits, index));
        }

        [return: AssumeRange(-1, 7)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int IndexOfLast()
        {
            return 7 - lzcnt(Bits);
        }

        [return: AssumeRange(-1, 7)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int IndexOfLast(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return 7 - lzcnt((byte)(Bits & bitmask8((uint)numBits, (uint)index)));
        }

        [return: AssumeRange(0ul, 8ul)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint CountBits()
        {
            return (uint)countbits((uint)Bits);
        }

        [return: AssumeRange(0ul, 8ul)]
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
            return BitAlgorithms.Find1String(value ? Bits : (byte)~Bits, amount);
        }

        [return: AssumeRange(0ul, 32ul)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int FindString(int index, int numBits, bool value, int amount)
        {
Assert.IsValidSubarray(index, numBits, Length);
            
            byte mask = bitmask8((uint)numBits, (uint)index);

            return BitAlgorithms.Find1String(value ? (byte)(mask & Bits) : andnot(mask, Bits), amount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAll()
        {
            return Bits == (uint)byte.MaxValue;
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
            return Bits != byte.MaxValue;
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

        [return: AssumeRange(0, byte.MaxValue)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
            return (int)Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(bit8 other)
        {
            return (uint)this.Bits == (uint)other.Bits;
        }

        public override readonly bool Equals(object obj)
        {
            return obj is bit8 converted && this.Equals(converted);
        }

        public readonly IEnumerator<bool> GetEnumerator()
        {
            return new ArrayEnumerator<bit8, bool>(this);
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<bit8, bool>(this);
        }
    }
}