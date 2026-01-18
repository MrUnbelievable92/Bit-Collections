using DevTools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;

using static MaxMath.maxmath;
using static Unity.Mathematics.math;

namespace BitCollections
{
    [Serializable]
    unsafe public struct bit40 : IArray<bool>, IEquatable<bit40>
    {
        public UInt40 Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit40(UInt40 value)
        {
            Bits = value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit40(long value)
        {
            Bits = (UInt40)value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit40(bool value)
        {
            Bits = (UInt40)(-(long)toulong(value));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit40(bool x0, bool x1, bool x2, bool x3, bool x4, bool x5, bool x6, bool x7, bool x8, bool x9, bool x10, bool x11, bool x12, bool x13, bool x14, bool x15, bool x16, bool x17, bool x18, bool x19, bool x20, bool x21, bool x22, bool x23, bool x24, bool x25, bool x26, bool x27, bool x28, bool x29, bool x30, bool x31, bool x32, bool x33, bool x34, bool x35, bool x36, bool x37, bool x38, bool x39)
        {
            Bits = (ulong)new bit32(x0, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16, x17, x18, x19, x20, x21, x22, x23, x24, x25, x26, x27, x28, x29, x30, x31).Bits
                     |
                     ((ulong)new bit8(x32, x33, x34, x35, x36, x37, x38, x39).Bits << 32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit40(bit8 x0_7, bit8 x8_15, bit8 x16_23, bit8 x24_31, bit8 x32_39)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_31.Bits << 24) 
                  | ((ulong)x32_39.Bits << 32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit40(bit16 x0_15, bit8 x16_23, bit8 x24_31, bit8 x32_39)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_31.Bits << 24) 
                  | ((ulong)x32_39.Bits << 32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit40(bit8 x0_7, bit16 x8_23, bit8 x24_31, bit8 x32_39)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_23.Bits << 8) 
                  | ((ulong)x24_31.Bits << 24) 
                  | ((ulong)x32_39.Bits << 32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit40(bit8 x0_7, bit8 x8_15, bit16 x16_31, bit8 x32_39)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_31.Bits << 16) 
                  | ((ulong)x32_39.Bits << 32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit40(bit8 x0_7, bit8 x8_15, bit8 x16_23, bit16 x24_39)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_39.Bits << 24);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit40(bit16 x0_15, bit16 x16_31, bit8 x32_39)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_31.Bits << 16) 
                  | ((ulong)x32_39.Bits << 32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit40(bit16 x0_15, bit8 x16_23, bit16 x24_39)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_39.Bits << 24);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit40(bit8 x0_7, bit16 x8_23, bit16 x24_39)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_23.Bits << 8) 
                  | ((ulong)x24_39.Bits << 24);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit40(bit24 x0_23, bit8 x24_31, bit8 x32_39)
        {
            Bits = ((ulong)x0_23.Bits << 0) 
                  | ((ulong)x24_31.Bits << 24) 
                  | ((ulong)x32_39.Bits << 32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit40(bit8 x0_7, bit24 x8_31, bit8 x32_39)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_31.Bits << 8) 
                  | ((ulong)x32_39.Bits << 32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit40(bit8 x0_7, bit8 x8_15, bit24 x16_39)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_39.Bits << 16);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit40(bit24 x0_23, bit16 x24_39)
        {
            Bits = ((ulong)x0_23.Bits << 0) 
                  | ((ulong)x24_39.Bits << 24);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit40(bit16 x0_15, bit24 x16_39)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_39.Bits << 16);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit40(bit32 x0_31, bit8 x32_39)
        {
            Bits = ((ulong)x0_31.Bits << 0) 
                  | ((ulong)x32_39.Bits << 32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit40(bit8 x0_7, bit32 x8_39)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_39.Bits << 8);
        }


        public readonly int Length => 64;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator bit40(bool input)
        {
            return new bit40(input);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt40(bit40 input)
        {
            return input.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator long(bit40 input)
        {
            return (long)input.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(bit40 input)
        {
            return *(double*)&input;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit40(UInt40 input)
        {
            return new bit40 { Bits = input };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit40(long input)
        {
            return new bit40 { Bits = (UInt40)input };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit40(double input)
        {
            return *(bit40*)&input;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit40 operator ! (bit40 value)
        {
            value.Bits = ~value.Bits;

            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit40 operator == (bit40 left, bit40 right)
        {
            return !(left != right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit40 operator != (bit40 left, bit40 right)
        {
            return left ^ right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit40 operator & (bit40 left, bit40 right)
        {
            left.Bits &= right.Bits;

            return left;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit40 operator | (bit40 left, bit40 right)
        {
            left.Bits |= right.Bits;

            return left;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit40 operator ^ (bit40 left, bit40 right)
        {
            left.Bits ^= right.Bits;

            return left;
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit48(bit40 value)
        {
            return new bit48{ Bits = value.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit56(bit40 value)
        {
            return new bit56{ Bits = value.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit64(bit40 value)
        {
            return new bit64{ Bits = value.Bits };
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit40(bit48 value)
        {
            return new bit40{ Bits = (UInt40)value.Bits };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit40(bit56 value)
        {
            return new bit40{ Bits = (UInt40)value.Bits };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit40(bit64 value)
        {
            return new bit40{ Bits = value.Bits };
        }


        public bool this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return tobool(BitFieldHelper.Get<Bit>(Bits, index, 40));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Bits = BitFieldHelper.Set<Bit>(Bits, tobyte(value), index, 40);
            }
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit40 SetReplicate(bool value)
        {
            return new bit40(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit40 SetReplicate(int index, int numBits, bool value)
        {
            return new bit40 { Bits = BitFieldHelper.SetReplicate<Bit>(Bits, toint(value), numBits, index, Length) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit40 ResetFirst()
        {
            return new bit40 { Bits = bits_resetlowest((ulong)Bits) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit40 ResetFirst(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = bitmask64((ulong)numBits, (ulong)index);
            ulong reset = bits_resetlowest(Bits & mask);
            ulong remaining = andnot(Bits, mask);

            return new bit40 { Bits = reset | remaining };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit40 SetFirst()
        {
            return new bit40 { Bits = bits_setlowest((ulong)Bits) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit40 SetFirst(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = bitmask64((ulong)numBits, (ulong)index);
            ulong set = bits_setlowest(~mask | Bits);

            return new bit40 { Bits = bits_select(Bits, set, mask) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit40 ResetLast()
        {
            return new bit40 { Bits = Bits & ((ulong.MaxValue >> 1) >> lzcnt((ulong)Bits)) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit40 ResetLast(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);
            
            ulong mask = bitmask64((ulong)numBits, (ulong)index);
            
            return new bit40 { Bits = andnot(Bits, toulong((Bits & mask) != 0) << (63 - lzcnt(mask & Bits))) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit40 SetLast()
        {
            int leadingOnesCount = lzcnt(andnot(bitmask64(40ul), Bits));
            return new bit40 { Bits = Bits | (1ul << ((64 - 1) - leadingOnesCount)) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit40 SetLast(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = bitmask64((ulong)numBits, (ulong)index);
            
            return new bit40 { Bits = Bits | (toulong((Bits & mask) != mask) << (63 - lzcnt(andnot(mask, Bits)))) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit40 ShiftLeft(int amount)
        {
            return new bit40 { Bits = Bits << amount };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit40 ShiftLeft(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = bitmask64((ulong)numBits, (ulong)index);
            ulong maskED = mask & Bits;

            return new bit40 { Bits = bits_select(Bits, maskED << amount, mask) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit40 ShiftRight(int amount)
        {
            return new bit40 { Bits = Bits >> amount };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit40 ShiftRight(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = (ulong)bitmask64(numBits, index);
            ulong maskED = mask & Bits;

            return new bit40 { Bits = bits_select(Bits, maskED >> amount, mask) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit40 RotateLeft(int amount)
        {
            return new bit40 { Bits = (Bits << amount) | (Bits >> (40 - amount)) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit40 RotateLeft(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = (ulong)bitmask64(numBits, index);
            ulong maskED = mask & Bits;

            int remainder = (int)((uint)amount % (uint)numBits);

            maskED = (maskED << remainder) | (maskED >> (numBits - remainder));
            
            return new bit40 { Bits = bits_select(Bits, maskED, mask) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit40 RotateRight(int amount)
        {
            return new bit40 { Bits = (Bits >> amount) | (Bits << (40 - amount)) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit40 RotateRight(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = (ulong)bitmask64(numBits, index);
            ulong maskED = mask & Bits;
            
            int remainder = (int)((uint)amount % (uint)numBits);

            maskED = (maskED >> remainder) | (maskED << (numBits - remainder));
            
            return new bit40 { Bits = bits_select(Bits, maskED, mask) };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit40 Reverse()
        {
            return new bit40 { Bits = reversebits((ulong)Bits) >> (64 - 40) };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit40 Reverse(int index, int numBits)
        {
            ulong rev = reversebits((ulong)Bits);
            int shift = (int)((ulong)(2 * index + numBits - 64) % 64u); 
            rev = rol(rev, shift); 

            return new bit40 { Bits = bits_select(Bits, rev, bitmask64((ulong)numBits, (ulong)index)) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit40 Swap(int index0, int index1)
        {
Assert.IsWithinArrayBounds(index0, Length);
Assert.IsWithinArrayBounds(index1, Length);

            ulong bit1 = bits_extract((ulong)Bits, index0, 1);
            ulong bit2 = bits_extract((ulong)Bits, index1, 1);

            ulong swap = bit1 ^ bit2;
            ulong shifted = (swap << index0) | (swap << index1);

            return new bit40 { Bits = Bits ^ shifted };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit40 Swap(int index0, int index1, int numBits)
        {
Assert.IsValidSubarray(index0, numBits, Length);
Assert.IsValidSubarray(index1, numBits, Length);
Assert.SubarraysDoNotOverlap(index0, index1, numBits, numBits);

            ulong bits1 = bits_extract((ulong)Bits, index0, numBits);
            ulong bits2 = bits_extract((ulong)Bits, index1, numBits);

            ulong swap = bits1 ^ bits2;
            ulong shifted = (swap << index0) | (swap << index1);

            return new bit40 { Bits = Bits ^ shifted };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit40 Flip()
        {
            return !this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit40 Flip(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return new bit40 { Bits = Bits ^ bitmask64((ulong)numBits, (ulong)index) };
        }

        
        [return: AssumeRange(0, 64)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int IndexOfFirst()
        {
            return tzcnt((ulong)Bits);
        }

        [return: AssumeRange(0, 64)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int IndexOfFirst(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return tzcnt(Bits & bitmask64(numBits, index));
        }

        [return: AssumeRange(-1, 63)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int IndexOfLast()
        {
            return 63 - lzcnt((ulong)Bits);
        }

        [return: AssumeRange(-1, 63)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int IndexOfLast(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return 63 - lzcnt(Bits & (UInt40)bitmask64(numBits, index));
        }

        [return: AssumeRange(0ul, 64ul)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint CountBits()
        {
            return (uint)countbits((ulong)Bits);
        }

        [return: AssumeRange(0ul, 64ul)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint CountBits(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return (uint)countbits(Bits & bitmask64((ulong)numBits, (ulong)index));
        }

        [return: AssumeRange(0ul, 64ul)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int FindString(bool value, int amount)
        {
            return BitAlgorithms.Find1String(value ? Bits : andnot(bitmask64(40ul), Bits), amount);
        }

        [return: AssumeRange(0ul, 64ul)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int FindString(int index, int numBits, bool value, int amount)
        {
Assert.IsValidSubarray(index, numBits, Length);
            
            ulong mask = bitmask64((ulong)numBits, (ulong)index);

            return BitAlgorithms.Find1String(value ? (mask & Bits) : andnot(mask, Bits), amount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAll()
        {
            return Bits == UInt40.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAll(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = bitmask64((ulong)numBits, (ulong)index);

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

            return (Bits & bitmask64((ulong)numBits, (ulong)index)) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestNone()
        {
            return Bits == 0ul;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestNone(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return (Bits & bitmask64((ulong)numBits, (ulong)index)) == 0ul;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestNotAll()
        {
            return Bits != UInt40.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestNotAll(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);
            
            ulong mask = bitmask64((ulong)numBits, (ulong)index);

            return (Bits & mask) != mask;
        }


        public override readonly string ToString()
        {
            return Dump.Bits(this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
            return Bits.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(bit40 other)
        {
            return this.Bits == other.Bits;
        }
        public override readonly bool Equals(object obj)
        {
            return obj is bit40 converted && this.Equals(converted);
        }
        public readonly IEnumerator<bool> GetEnumerator()
        {
            return new ArrayEnumerator<bit40, bool>(this);
        }
        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<bit40, bool>(this);
        }
    }
}