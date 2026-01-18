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
    unsafe public struct bit48 : IArray<bool>, IEquatable<bit48>
    {
        public UInt48 Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit48(UInt48 value)
        {
            Bits = value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit48(long value)
        {
            Bits = (UInt48)value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit48(bool value)
        {
            Bits = (UInt48)(-tolong(value));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit48(bool x0, bool x1, bool x2, bool x3, bool x4, bool x5, bool x6, bool x7, bool x8, bool x9, bool x10, bool x11, bool x12, bool x13, bool x14, bool x15, bool x16, bool x17, bool x18, bool x19, bool x20, bool x21, bool x22, bool x23, bool x24, bool x25, bool x26, bool x27, bool x28, bool x29, bool x30, bool x31, bool x32, bool x33, bool x34, bool x35, bool x36, bool x37, bool x38, bool x39, bool x40, bool x41, bool x42, bool x43, bool x44, bool x45, bool x46, bool x47)
        {
            Bits = (ulong)new bit32(x0, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16, x17, x18, x19, x20, x21, x22, x23, x24, x25, x26, x27, x28, x29, x30, x31).Bits
                     |
                     ((ulong)new bit16(x32, x33, x34, x35, x36, x37, x38, x39, x40, x41, x42, x43, x44, x45, x46, x47).Bits << 32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit48(bit8 x0_7, bit8 x8_15, bit8 x16_23, bit8 x24_31, bit8 x32_39, bit8 x40_47)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_31.Bits << 24) 
                  | ((ulong)x32_39.Bits << 32) 
                  | ((ulong)x40_47.Bits << 40);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit48(bit16 x0_15, bit8 x16_23, bit8 x24_31, bit8 x32_39, bit8 x40_47)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_31.Bits << 24) 
                  | ((ulong)x32_39.Bits << 32) 
                  | ((ulong)x40_47.Bits << 40);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit48(bit8 x0_7, bit16 x8_23, bit8 x24_31, bit8 x32_39, bit8 x40_47)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_23.Bits << 8) 
                  | ((ulong)x24_31.Bits << 24) 
                  | ((ulong)x32_39.Bits << 32) 
                  | ((ulong)x40_47.Bits << 40);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit48(bit8 x0_7, bit8 x8_15, bit16 x16_31, bit8 x32_39, bit8 x40_47)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_31.Bits << 16) 
                  | ((ulong)x32_39.Bits << 32) 
                  | ((ulong)x40_47.Bits << 40);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit48(bit8 x0_7, bit8 x8_15, bit8 x16_23, bit16 x24_39, bit8 x40_47)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_39.Bits << 24) 
                  | ((ulong)x40_47.Bits << 40);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit48(bit8 x0_7, bit8 x8_15, bit8 x16_23, bit8 x24_31, bit16 x32_47)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_31.Bits << 24) 
                  | ((ulong)x32_47.Bits << 32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit48(bit16 x0_15, bit16 x16_31, bit8 x32_39, bit8 x40_47)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_31.Bits << 16) 
                  | ((ulong)x32_39.Bits << 32) 
                  | ((ulong)x40_47.Bits << 40);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit48(bit16 x0_15, bit8 x16_23, bit16 x24_39, bit8 x40_47)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_39.Bits << 24) 
                  | ((ulong)x40_47.Bits << 40);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit48(bit16 x0_15, bit8 x16_23, bit8 x24_31, bit16 x32_47)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_31.Bits << 24) 
                  | ((ulong)x32_47.Bits << 32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit48(bit8 x0_7, bit16 x8_23, bit16 x24_39, bit8 x40_47)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_23.Bits << 8) 
                  | ((ulong)x24_39.Bits << 24) 
                  | ((ulong)x40_47.Bits << 40);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit48(bit8 x0_7, bit16 x8_23, bit8 x24_31, bit16 x32_47)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_23.Bits << 8) 
                  | ((ulong)x24_31.Bits << 24) 
                  | ((ulong)x32_47.Bits << 32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit48(bit8 x0_7, bit8 x8_15, bit16 x16_31, bit16 x32_47)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_31.Bits << 16) 
                  | ((ulong)x32_47.Bits << 32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit48(bit16 x0_15, bit16 x16_31, bit16 x32_47)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_31.Bits << 16) 
                  | ((ulong)x32_47.Bits << 32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit48(bit24 x0_23, bit8 x24_31, bit8 x32_39, bit8 x40_47)
        {
            Bits = ((ulong)x0_23.Bits << 0) 
                  | ((ulong)x24_31.Bits << 24) 
                  | ((ulong)x32_39.Bits << 32) 
                  | ((ulong)x40_47.Bits << 40);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit48(bit8 x0_7, bit24 x8_31, bit8 x32_39, bit8 x40_47)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_31.Bits << 8) 
                  | ((ulong)x32_39.Bits << 32) 
                  | ((ulong)x40_47.Bits << 40);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit48(bit8 x0_7, bit8 x8_15, bit24 x16_39, bit8 x40_47)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_39.Bits << 16) 
                  | ((ulong)x40_47.Bits << 40);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit48(bit8 x0_7, bit8 x8_15, bit8 x16_23, bit24 x24_47)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_47.Bits << 24);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit48(bit24 x0_23, bit16 x24_39, bit8 x40_47)
        {
            Bits = ((ulong)x0_23.Bits << 0) 
                  | ((ulong)x24_39.Bits << 24)  
                  | ((ulong)x40_47.Bits << 40);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit48(bit24 x0_23, bit8 x24_31, bit16 x32_47)
        {
            Bits = ((ulong)x0_23.Bits << 0) 
                  | ((ulong)x24_31.Bits << 24)  
                  | ((ulong)x32_47.Bits << 32);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit48(bit8 x0_7, bit24 x8_31, bit16 x32_47)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_31.Bits << 8)  
                  | ((ulong)x32_47.Bits << 32);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit48(bit16 x0_15, bit24 x16_39, bit8 x40_47)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_39.Bits << 16)  
                  | ((ulong)x40_47.Bits << 40);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit48(bit8 x0_7, bit16 x8_23, bit24 x24_47)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_23.Bits << 8)  
                  | ((ulong)x24_47.Bits << 24);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit48(bit16 x0_15, bit8 x16_23, bit24 x24_47)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_23.Bits << 16)  
                  | ((ulong)x24_47.Bits << 24);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit48(bit24 x0_23, bit24 x24_47)
        {
            Bits = ((ulong)x0_23.Bits << 0)  
                  | ((ulong)x24_47.Bits << 24);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit48(bit32 x0_31, bit8 x32_39, bit8 x40_47)
        {
            Bits = ((ulong)x0_31.Bits << 0)  
                  | ((ulong)x32_39.Bits << 32) 
                  | ((ulong)x40_47.Bits << 40);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit48(bit8 x0_7, bit32 x8_39, bit8 x40_47)
        {
            Bits = ((ulong)x0_7.Bits << 0)  
                  | ((ulong)x8_39.Bits << 8) 
                  | ((ulong)x40_47.Bits << 40);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit48(bit8 x0_7, bit8 x8_15, bit32 x16_47)
        {
            Bits = ((ulong)x0_7.Bits << 0)  
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_47.Bits << 16);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit48(bit32 x0_31, bit16 x32_47)
        {
            Bits = ((ulong)x0_31.Bits << 0)  
                  | ((ulong)x32_47.Bits << 32);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit48(bit16 x0_15, bit32 x16_47)
        {
            Bits = ((ulong)x0_15.Bits << 0)  
                  | ((ulong)x16_47.Bits << 16);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit48(bit40 x0_39, bit8 x40_47)
        {
            Bits = ((ulong)x0_39.Bits << 0)  
                  | ((ulong)x40_47.Bits << 40);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit48(bit8 x0_7, bit40 x8_47)
        {
            Bits = ((ulong)x0_7.Bits << 0)  
                  | ((ulong)x8_47.Bits << 8);
        }


        public readonly int Length => 64;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator bit48(bool input)
        {
            return new bit48(input);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt48(bit48 input)
        {
            return input.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator long(bit48 input)
        {
            return (long)input.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(bit48 input)
        {
            return *(double*)&input;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit48(UInt48 input)
        {
            return new bit48 { Bits = input };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit48(long input)
        {
            return new bit48 { Bits = (UInt48)input };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit48(double input)
        {
            return *(bit48*)&input;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit48 operator ! (bit48 value)
        {
            value.Bits = ~value.Bits;

            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit48 operator == (bit48 left, bit48 right)
        {
            return !(left != right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit48 operator != (bit48 left, bit48 right)
        {
            return left ^ right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit48 operator & (bit48 left, bit48 right)
        {
            left.Bits &= right.Bits;

            return left;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit48 operator | (bit48 left, bit48 right)
        {
            left.Bits |= right.Bits;

            return left;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit48 operator ^ (bit48 left, bit48 right)
        {
            left.Bits ^= right.Bits;

            return left;
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit56(bit48 value)
        {
            return new bit56{ Bits = value.Bits };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit64(bit48 value)
        {
            return new bit64{ Bits = value.Bits };
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit48(bit56 value)
        {
            return new bit48{ Bits = (UInt48)value.Bits };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit48(bit64 value)
        {
            return new bit48{ Bits = value.Bits };
        }


        public bool this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return tobool(BitFieldHelper.Get<Bit>(Bits, index, 48));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Bits = BitFieldHelper.Set<Bit>(Bits, tobyte(value), index, 48);
            }
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit48 SetReplicate(bool value)
        {
            return new bit48(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit48 SetReplicate(int index, int numBits, bool value)
        {
            return new bit48 { Bits = BitFieldHelper.SetReplicate<Bit>(Bits, toint(value), numBits, index, Length) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit48 ResetFirst()
        {
            return new bit48 { Bits = bits_resetlowest((ulong)Bits) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit48 ResetFirst(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = bitmask64((ulong)numBits, (ulong)index);
            ulong reset = bits_resetlowest(Bits & mask);
            ulong remaining = andnot(Bits, mask);

            return new bit48 { Bits = reset | remaining };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit48 SetFirst()
        {
            return new bit48 { Bits = bits_setlowest((ulong)Bits) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit48 SetFirst(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = bitmask64((ulong)numBits, (ulong)index);
            ulong set = bits_setlowest(~mask | Bits);

            return new bit48 { Bits = bits_select(Bits, set, mask) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit48 ResetLast()
        {
            return new bit48 { Bits = Bits & ((ulong.MaxValue >> 1) >> lzcnt((ulong)Bits)) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit48 ResetLast(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);
            
            ulong mask = bitmask64((ulong)numBits, (ulong)index);
            
            return new bit48 { Bits = andnot(Bits, toulong((Bits & mask) != 0) << (63 - lzcnt(mask & Bits))) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit48 SetLast()
        {
            int leadingOnesCount = lzcnt(andnot(bitmask64(48ul), Bits));
            return new bit48 { Bits = Bits | (1ul << ((64 - 1) - leadingOnesCount)) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit48 SetLast(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = bitmask64((ulong)numBits, (ulong)index);
            
            return new bit48 { Bits = Bits | (toulong((Bits & mask) != mask) << (63 - lzcnt(andnot(mask, Bits)))) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit48 ShiftLeft(int amount)
        {
            return new bit48 { Bits = Bits << amount };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit48 ShiftLeft(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = bitmask64((ulong)numBits, (ulong)index);
            ulong maskED = mask & Bits;

            return new bit48 { Bits = bits_select(Bits, maskED << amount, mask) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit48 ShiftRight(int amount)
        {
            return new bit48 { Bits = Bits >> amount };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit48 ShiftRight(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = (ulong)bitmask64(numBits, index);
            ulong maskED = mask & Bits;

            return new bit48 { Bits = bits_select(Bits, maskED >> amount, mask) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit48 RotateLeft(int amount)
        {
            return new bit48 { Bits = (Bits << amount) | (Bits >> (48 - amount)) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit48 RotateLeft(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = (ulong)bitmask64(numBits, index);
            ulong maskED = mask & Bits;

            int remainder = (int)((uint)amount % (uint)numBits);

            maskED = (maskED << remainder) | (maskED >> (numBits - remainder));
            
            return new bit48 { Bits = bits_select(Bits, maskED, mask) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit48 RotateRight(int amount)
        {
            return new bit48 { Bits = (Bits >> amount) | (Bits << (48 - amount)) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit48 RotateRight(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = (ulong)bitmask64(numBits, index);
            ulong maskED = mask & Bits;
            
            int remainder = (int)((uint)amount % (uint)numBits);

            maskED = (maskED >> remainder) | (maskED << (numBits - remainder));
            
            return new bit48 { Bits = bits_select(Bits, maskED, mask) };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit48 Reverse()
        {
            return new bit48 { Bits = reversebits((ulong)Bits) >> (64 - 48) };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit48 Reverse(int index, int numBits)
        {
            ulong rev = reversebits((ulong)Bits);
            int shift = (int)((ulong)(2 * index + numBits - 64) % 64u); 
            rev = rol(rev, shift); 

            return new bit48 { Bits = bits_select(Bits, rev, bitmask64((ulong)numBits, (ulong)index)) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit48 Swap(int index0, int index1)
        {
Assert.IsWithinArrayBounds(index0, Length);
Assert.IsWithinArrayBounds(index1, Length);

            ulong bit1 = bits_extract((ulong)Bits, index0, 1);
            ulong bit2 = bits_extract((ulong)Bits, index1, 1);

            ulong swap = bit1 ^ bit2;
            ulong shifted = (swap << index0) | (swap << index1);

            return new bit48 { Bits = Bits ^ shifted };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit48 Swap(int index0, int index1, int numBits)
        {
Assert.IsValidSubarray(index0, numBits, Length);
Assert.IsValidSubarray(index1, numBits, Length);
Assert.SubarraysDoNotOverlap(index0, index1, numBits, numBits);

            ulong bits1 = bits_extract((ulong)Bits, index0, numBits);
            ulong bits2 = bits_extract((ulong)Bits, index1, numBits);

            ulong swap = bits1 ^ bits2;
            ulong shifted = (swap << index0) | (swap << index1);

            return new bit48 { Bits = Bits ^ shifted };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit48 Flip()
        {
            return !this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit48 Flip(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return new bit48 { Bits = Bits ^ bitmask64((ulong)numBits, (ulong)index) };
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

            return tzcnt(Bits & bitmask64((ulong)numBits, (ulong)index));
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

            return 63 - lzcnt(Bits & bitmask64((ulong)numBits, (ulong)index));
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
            return BitAlgorithms.Find1String(value ? Bits : andnot(bitmask64(48ul), Bits), amount);
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
            return Bits == UInt48.MaxValue;
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
            return Bits != UInt48.MaxValue;
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
        public readonly bool Equals(bit48 other)
        {
            return this.Bits == other.Bits;
        }
        public override readonly bool Equals(object obj)
        {
            return obj is bit48 converted && this.Equals(converted);
        }
        public readonly IEnumerator<bool> GetEnumerator()
        {
            return new ArrayEnumerator<bit48, bool>(this);
        }
        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<bit48, bool>(this);
        }
    }
}