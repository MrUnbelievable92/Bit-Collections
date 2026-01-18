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
    unsafe public struct bit32 : IArray<bool>, IEquatable<bit32>
    {
        public uint Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit32(uint value)
        {
            Bits = value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit32(int value)
        {
            Bits = (uint)value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit32(bool value)
        {
            Bits = (uint)(-tosbyte(value));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit32(bool x0, bool x1, bool x2, bool x3, bool x4, bool x5, bool x6, bool x7, bool x8, bool x9, bool x10, bool x11, bool x12, bool x13, bool x14, bool x15, bool x16, bool x17, bool x18, bool x19, bool x20, bool x21, bool x22, bool x23, bool x24, bool x25, bool x26, bool x27, bool x28, bool x29, bool x30, bool x31)
        {
            Bits = (uint)bitmask(new bool32(x0, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16, x17, x18, x19, x20, x21, x22, x23, x24, x25, x26, x27, x28, x29, x30, x31));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit32(bit8 x0_7, bit8 x8_15, bit8 x16_23, bit8 x24_31)
        {
            Bits = ((uint)x0_7.Bits | ((uint)x8_15.Bits << 8)) | (((uint)x16_23.Bits << 16) | ((uint)x24_31.Bits << 24));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit32(bit16 x0_15, bit8 x16_23, bit8 x24_31)
        {
            Bits = ((uint)x0_15.Bits | ((uint)x16_23.Bits << 16)) | ((uint)x24_31.Bits << 24);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit32(bit8 x0_7, bit16 x8_23, bit8 x24_31)
        {
            Bits = ((uint)x0_7.Bits | ((uint)x8_23.Bits << 8)) | ((uint)x24_31.Bits << 24);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit32(bit8 x0_7, bit8 x8_15, bit16 x16_31)
        {
            Bits = ((uint)x0_7.Bits | ((uint)x8_15.Bits << 8)) | ((uint)x16_31.Bits << 16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit32(bit16 x0_15, bit16 x16_31)
        {
            Bits = (uint)x0_15.Bits | ((uint)x16_31.Bits << 16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit32(bit24 x0_23, bit8 x24_31)
        {
            Bits = (uint)x0_23.Bits | ((uint)x24_31.Bits << 24);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit32(bit8 x0_7, bit24 x8_31)
        {
            Bits = (uint)x0_7.Bits | ((uint)x8_31.Bits << 8);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit32(bool[] values, int index = 0)
        {
Assert.IsValidSubarray(index, new bit32().Length, values.Length);

            Bits = 0;

            for (int i = 0; i < 32; i++, index++)
            {
                this[i] = values[index];
            }
        }


        public readonly int Length => 32;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator bit32(bool input)
        {
            return new bit32(input);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint(bit32 input)
        {
            return input.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int(bit32 input)
        {
            return (int)input.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(bit32 input)
        {
            return *(float*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator bool32(bit32 input)
        {
            return tobool32((int)input.Bits);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit32(uint input)
        {
            return new bit32 { Bits = input };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit32(int input)
        {
            return new bit32 { Bits = (uint)input };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit32(float input)
        {
            return *(bit32*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit32(bool32 input)
        {
            return (bit32)bitmask(input);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit32 operator ! (bit32 value)
        {
            value.Bits = ~value.Bits;

            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit32 operator == (bit32 left, bit32 right)
        {
            return !(left != right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit32 operator != (bit32 left, bit32 right)
        {
            return left ^ right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit32 operator & (bit32 left, bit32 right)
        {
            left.Bits &= right.Bits;

            return left;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit32 operator | (bit32 left, bit32 right)
        {
            left.Bits |= right.Bits;

            return left;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit32 operator ^ (bit32 left, bit32 right)
        {
            left.Bits ^= right.Bits;

            return left;
        }
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit40(bit32 value)
        {
            return new bit40{ Bits = value.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit48(bit32 value)
        {
            return new bit48{ Bits = value.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit56(bit32 value)
        {
            return new bit56{ Bits = value.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit64(bit32 value)
        {
            return new bit64{ Bits = value.Bits };
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit32(bit40 value)
        {
            return new bit32{ Bits = (uint)value.Bits };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit32(bit48 value)
        {
            return new bit32{ Bits = (uint)value.Bits };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit32(bit56 value)
        {
            return new bit32{ Bits = (uint)value.Bits };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit32(bit64 value)
        {
            return new bit32{ Bits = (uint)value.Bits };
        }


        public bool this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return tobool(BitFieldHelper.Get<Bit>(Bits, index, 32));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Bits = (uint)BitFieldHelper.Set<Bit>(Bits, tobyte(value), index, 32);
            }
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit32 SetReplicate(bool value)
        {
            return new bit32(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit32 SetReplicate(int index, int numBits, bool value)
        {
            return new bit32 { Bits = BitFieldHelper.SetReplicate<Bit>(Bits, toint(value), numBits, index, Length) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit32 ResetFirst()
        {
            return new bit32 { Bits = bits_resetlowest(Bits) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit32 ResetFirst(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = bitmask32((uint)numBits, (uint)index);
            uint reset = bits_resetlowest(Bits & mask);
            uint remaining = andnot(Bits, mask);

            return new bit32 { Bits = reset | remaining };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit32 SetFirst()
        {
            return new bit32 { Bits = bits_setlowest(Bits) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit32 SetFirst(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = bitmask32((uint)numBits, (uint)index);
            uint set = bits_setlowest(~mask | Bits);

            return new bit32 { Bits = bits_select(Bits, set, mask) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit32 ResetLast()
        {
            return new bit32 { Bits = Bits & ((uint.MaxValue >> 1) >> lzcnt(Bits)) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit32 ResetLast(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = bitmask32((uint)numBits, (uint)index);
            
            return new bit32 { Bits = andnot(Bits, touint((Bits & mask) != 0) << (31 - lzcnt(mask & Bits))) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit32 SetLast()
        {
            int leadingOnesCount = lzcnt(~Bits);
            return new bit32 { Bits = Bits | (1u << ((Length - 1) - leadingOnesCount)) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit32 SetLast(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = bitmask32((uint)numBits, (uint)index);
            
            return new bit32 { Bits = Bits | (touint((Bits & mask) != mask) << (31 - lzcnt(andnot(mask, Bits)))) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit32 ShiftLeft(int amount)
        {
            return new bit32 { Bits = Bits << amount };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit32 ShiftLeft(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = bitmask32((uint)numBits, (uint)index);
            uint maskED = mask & Bits;

            return new bit32 { Bits = bits_select(Bits, maskED << amount, mask) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit32 ShiftRight(int amount)
        {
            return new bit32 { Bits = Bits >> amount };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit32 ShiftRight(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)bitmask32(numBits, index);
            uint maskED = mask & Bits;

            return new bit32 { Bits = bits_select(Bits, maskED >> amount, mask) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit32 RotateLeft(int amount)
        {
            return new bit32 { Bits = rol(Bits, amount) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit32 RotateLeft(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)bitmask32(numBits, index);
            uint maskED = mask & Bits;

            int remainder = (int)((uint)amount % (uint)numBits);

            maskED = (maskED << remainder) | (maskED >> (numBits - remainder));
            
            return new bit32 { Bits = bits_select(Bits, maskED, mask) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit32 RotateRight(int amount)
        {
            return new bit32 { Bits = ror(Bits, amount) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit32 RotateRight(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)bitmask32(numBits, index);
            uint maskED = mask & Bits;
            
            int remainder = (int)((uint)amount % (uint)numBits);

            maskED = (maskED >> remainder) | (maskED << (numBits - remainder));
            
            return new bit32 { Bits = bits_select(Bits, maskED, mask) };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit32 Reverse()
        {
            return new bit32 { Bits = reversebits(Bits) };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit32 Reverse(int index, int numBits)
        {
            uint rev = reversebits(Bits);
            int shift = (int)((uint)(2 * index + numBits - 32) % 32u); 
            rev = rol(rev, shift); 

            return new bit32 { Bits = bits_select(Bits, rev, bitmask32((uint)numBits, (uint)index)) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit32 Swap(int index0, int index1)
        {
Assert.IsWithinArrayBounds(index0, Length);
Assert.IsWithinArrayBounds(index1, Length);

            uint bit1 = bits_extract(Bits, index0, 1);
            uint bit2 = bits_extract(Bits, index1, 1);

            uint swap = bit1 ^ bit2;
            uint shifted = (swap << index0) | (swap << index1);

            return new bit32 { Bits = Bits ^ shifted };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit32 Swap(int index0, int index1, int numBits)
        {
Assert.IsValidSubarray(index0, numBits, Length);
Assert.IsValidSubarray(index1, numBits, Length);
Assert.SubarraysDoNotOverlap(index0, index1, numBits, numBits);

            uint bits1 = bits_extract(Bits, index0, numBits);
            uint bits2 = bits_extract(Bits, index1, numBits);

            uint swap = bits1 ^ bits2;
            uint shifted = (swap << index0) | (swap << index1);

            return new bit32 { Bits = Bits ^ shifted };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit32 Flip()
        {
            return !this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit32 Flip(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return new bit32 { Bits = Bits ^ bitmask32((uint)numBits, (uint)index) };
        }

        
        [return: AssumeRange(0, 32)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int IndexOfFirst()
        {
            return tzcnt(Bits);
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
            return 31 - lzcnt(Bits);
        }

        [return: AssumeRange(-1, 31)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int IndexOfLast(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return 31 - lzcnt(Bits & bitmask32((uint)numBits, (uint)index));
        }

        [return: AssumeRange(0ul, 32ul)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint CountBits()
        {
            return (uint)countbits(Bits);
        }

        [return: AssumeRange(0ul, 32ul)]
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
            return BitAlgorithms.Find1String(value ? Bits : ~Bits, amount);
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
            return Bits == uint.MaxValue;
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
            return Bits != uint.MaxValue;
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
        public readonly bool Equals(bit32 other)
        {
            return this.Bits == other.Bits;
        }
        public override readonly bool Equals(object obj)
        {
            return obj is bit32 converted && this.Equals(converted);
        }

        public readonly IEnumerator<bool> GetEnumerator()
        {
            return new ArrayEnumerator<bit32, bool>(this);
        }

        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<bit32, bool>(this);
        }
    }
}