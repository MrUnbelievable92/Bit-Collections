using DevTools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst.Intrinsics;
using Unity.Burst.CompilerServices;
using Unity.Mathematics;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using MaxMath;

namespace BitCollections
{
    [Serializable]
    unsafe public struct bit32 : IArray<bool>, IEquatable<bit32>
    {
        internal uint intern;
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit32(uint value)
        {
            intern = value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit32(int value)
        {
            intern = (uint)value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit32(bool value)
        {
            intern = (uint)(-maxmath.toint8(value));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit32(bool x0, bool x1, bool x2, bool x3, bool x4, bool x5, bool x6, bool x7, bool x8, bool x9, bool x10, bool x11, bool x12, bool x13, bool x14, bool x15, bool x16, bool x17, bool x18, bool x19, bool x20, bool x21, bool x22, bool x23, bool x24, bool x25, bool x26, bool x27, bool x28, bool x29, bool x30, bool x31)
        {
            intern = (uint)maxmath.bitmask(new bool32(x0, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16, x17, x18, x19, x20, x21, x22, x23, x24, x25, x26, x27, x28, x29, x30, x31));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit32(bit8 x0_7, bit8 x8_15, bit8 x16_23, bit8 x24_31)
        {
            intern = ((uint)x0_7.intern | ((uint)x8_15.intern << 8)) | (((uint)x16_23.intern << 16) | ((uint)x24_31.intern << 24));
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit32(bit16 x0_15, bit8 x16_23, bit8 x24_31)
        {
            intern = ((uint)x0_15.intern | ((uint)x16_23.intern << 16)) | ((uint)x24_31.intern << 24);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit32(bit8 x0_7, bit16 x8_23, bit8 x24_31)
        {
            intern = ((uint)x0_7.intern | ((uint)x8_23.intern << 8)) | ((uint)x24_31.intern << 24);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit32(bit8 x0_7, bit8 x8_15, bit16 x16_31)
        {
            intern = ((uint)x0_7.intern | ((uint)x8_15.intern << 8)) | ((uint)x16_31.intern << 16);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit32(bit16 x0_15, bit16 x16_31)
        {
            intern = (uint)x0_15.intern | ((uint)x16_31.intern << 16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit32(bool[] values, int index = 0)
        {
Assert.IsWithinArrayBounds(index + 31, values.Length);

            fixed (void* ptr = &values[index])
            {
                intern = (uint)maxmath.bitmask(*(bool32*)ptr);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit32(NativeArray<bool> values, int index = 0)
        {
Assert.IsWithinArrayBounds(index + 31, values.Length);

            intern = (uint)maxmath.bitmask(*(bool32*)((bool*)values.GetUnsafeReadOnlyPtr() + index));
        }


        public readonly int Length => 32;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint(bit32 input)
        {
            return input.intern;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int(bit32 input)
        {
            return (int)input.intern;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(bit32 input)
        {
            return *(float*)&input;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit32(uint input)
        {
            return new bit32 { intern = input };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit32(int input)
        {
            return new bit32 { intern = (uint)input };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit32(float input)
        {
            return *(bit32*)&input;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit32 operator ! (bit32 value)
        {
            value.intern = ~value.intern;

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
            left.intern &= right.intern;
    
            return left;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit32 operator | (bit32 left, bit32 right)
        {
            left.intern |= right.intern;
    
            return left;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit32 operator ^ (bit32 left, bit32 right)
        {
            left.intern ^= right.intern;
    
            return left;
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bits<T> Reinterpret<T>()
            where T : unmanaged
        {
Assert.AreEqual(sizeof(bit32), sizeof(T));

            uint temp = intern;

            return *(bits<T>*)&temp;
        }


        public bool this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
Assert.IsWithinArrayBounds(index, Length);
    
                uint result = (intern >> index) & 1u;
    
                return *(bool*)&result;
            }
    
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsSafeBoolean(value);
Assert.IsWithinArrayBounds(index, Length);
    
                uint mask = 1u << index;

                intern = maxmath.andnot(intern, mask) | ((uint)-*(byte*)&value & mask);
            }
        }


        public readonly bool[] ToArray()
        {
            bool[] result = new bool[Length];

            fixed (void* ptr = &result[0])
            {
                ((bool32*)ptr)[0] = maxmath.tobool32((int)intern);
            }

            return result;
        }

        public readonly NativeArray<bool> ToArray(Allocator allocator)
        {
            NativeArray<bool> result = new NativeArray<bool>(Length, allocator, NativeArrayOptions.UninitializedMemory);

            *(bool32*)result.GetUnsafePtr() = maxmath.tobool32((int)intern);

            return result;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit8 Getbit8SubArray(int index)
        {
Assert.IsValidSubarray(index, new bit8().Length, Length);

            uint temp = intern >> index;

            return *(bit8*)&temp;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit16 Getbit16SubArray(int index)
        {
Assert.IsValidSubarray(index, new bit16().Length, Length);

            uint temp = intern >> index;

            return *(bit16*)&temp;
        }

    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(0, 32)] 
        public readonly int IndexOfFirst()
        {
            return math.tzcnt(intern);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(0, 32)] 
        public readonly int IndexOfFirst(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return math.tzcnt(intern & maxmath.bitmask32((uint)numBits, (uint)index));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(-1, 31)] 
        public readonly int IndexOfLast()
        {
            return 31 - math.lzcnt(intern);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(-1, 31)] 
        public readonly int IndexOfLast(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return 31 - math.lzcnt(intern & maxmath.bitmask32((uint)numBits, (uint)index));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ShiftLeft(int amount)
        {
            intern <<= amount; 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ShiftLeft(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)maxmath.bitmask32(numBits, index);
            uint maskED = mask & intern;

            intern = maxmath.andnot(intern, mask) | (mask & (maskED << amount));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ShiftRight(int amount)
        {
            intern >>= amount; 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ShiftRight(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)maxmath.bitmask32(numBits, index);
            uint maskED = mask & intern;

            intern = maxmath.andnot(intern, mask) | (mask & (maskED >> amount));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RotateLeft(int amount)
        {
            intern = math.rol(intern, amount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RotateLeft(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)maxmath.bitmask32(numBits, index);
            uint maskED = mask & intern;

            int remainder = amount % numBits;

            maskED = mask & ((maskED << remainder) | (maskED >> (numBits - remainder)));

            intern = maxmath.andnot(intern, mask) | maskED;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RotateRight(int amount)
        {
            intern = math.ror(intern, amount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RotateRight(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)maxmath.bitmask32(numBits, index);
            uint maskED = mask & intern;

            int remainder = amount % numBits;

            maskED = mask & ((maskED >> remainder) | (maskED << (numBits - remainder)));

            intern = maxmath.andnot(intern, mask) | maskED;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Swap(int smallerIndex, int largerIndex)
        {
Assert.IsWithinArrayBounds(smallerIndex, Length);
Assert.IsWithinArrayBounds(largerIndex, Length);

            uint2 field = intern;
            uint2 packed = (uint2)new int2(smallerIndex, largerIndex);

            uint2 result = 1 & maxmath.shrl(field, packed);
            result ^= result.yx;
            result = maxmath.shl(result, packed);

            intern = (field ^ (result | result.yx)).x;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Swap(int smallerIndex, int largerIndex, int numBits)
        {
Assert.IsGreater(largerIndex, smallerIndex);
Assert.IsValidSubarray(smallerIndex, numBits, Length);
Assert.IsValidSubarray(largerIndex, numBits, Length);
Assert.SubarraysDoNotOverlap(smallerIndex, largerIndex, numBits, numBits);

            // inlined bitmask
            // x: mask for lower subarray, y: mask for upper subarray, 
            uint3 masks = maxmath.shl(uint.MaxValue, (uint3)new int3(smallerIndex, largerIndex, 0));
            masks = maxmath.andnot(masks, masks << numBits);
            // z: mask for deleting elements in the array
            // masks.z = ~(masks.x | masks.y);
            masks = math.select(masks, ~(masks.xxx | masks.yyy), new bool3(false, false, true));

            // delete in z, grab values in x & y
            masks &= intern;

            // swap positions; blend together
            int indexDelta = largerIndex - smallerIndex;
            intern = ((masks.z | (masks.x << indexDelta)) | (masks.y >> indexDelta));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Flip()
        {
            this = !this;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Flip(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint2 invert = new uint2((uint)maxmath.bitmask32(numBits, index), intern);
    
            invert = maxmath.andnot(invert, invert.yx);
    
            intern = (invert | invert.yx).x;
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reverse()
        {
            intern = math.reversebits(intern);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reverse(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)maxmath.bitmask32(numBits, index);
            int shiftValue = math.mad(2, index,      numBits - Length);
    
            intern = (mask & ((shiftValue < 0) 
                              ? math.reversebits(intern) >> math.abs(shiftValue)
                              : math.reversebits(intern) << shiftValue))
                      |
                      maxmath.andnot(intern, mask);
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Shuffle(ref Random32 rngenerator)
        {
            if (X86.Bmi2.IsBmi2Supported)
            {
                uint mask = rngenerator.NextUInt();
                uint notMask = ~mask;

                uint lo = maxmath.bits_extractparallel(intern, mask);
                uint hi = maxmath.bits_extractparallel(intern, notMask);

                intern = lo | (hi << math.countbits(mask));
            }
            else
            {
                for (int i = Length - 1, j = Length;    i > 0;      i--, j--)
                {
                    Swap(i, (int)rngenerator.NextUInt((uint)j));
                }
            }
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Shuffle(int index, int numBits, ref Random32 rngenerator)
        {
Assert.IsValidSubarray(index, numBits, Length);

            if (X86.Bmi2.IsBmi2Supported)
            {
                uint extractMask = rngenerator.NextUInt();
                uint shuffleMask = maxmath.bitmask32((uint)numBits, (uint)index);
                extractMask &= shuffleMask;
                uint notExtractMask = maxmath.andnot(shuffleMask, extractMask);

                uint lo = maxmath.bits_extractparallel(intern, extractMask);
                uint hi = maxmath.bits_extractparallel(intern, notExtractMask);

                intern = ((lo | (hi << math.countbits(extractMask))) << index) | maxmath.andnot(intern, shuffleMask);
            }
            else
            {
                int startingIndex = index + numBits;/* - 1 is actual starting index*/

                for (int i = startingIndex - 1; i > index; i--, startingIndex--)
                {
                    Swap(i, rngenerator.NextInt(index, startingIndex));
                }
            }
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Randomize(ref Random32 rngenerator)
        {
            intern = rngenerator.NextUInt();
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Randomize(int index, int numBits, ref Random32 rngenerator)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)maxmath.bitmask32(numBits, index);
    
            intern = (rngenerator.NextUInt() & mask)    |    maxmath.andnot(intern, mask);
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetBits(bool value)
        {
            this = new bit32(value);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetBits(int index, int numBits, bool value)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)maxmath.bitmask32(numBits, index);

            intern = maxmath.andnot(intern, mask) | ((uint)-*(byte*)&value & mask);
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint CountBits()
        {
            return (uint)math.countbits(intern);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint CountBits(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return (uint)math.countbits(intern & maxmath.bitmask32(numBits, index));
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAll()
        {
            return intern == uint.MaxValue;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAll(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)maxmath.bitmask32(numBits, index);
    
            return (intern & mask) == mask;
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAny()
        {
            return intern != 0;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAny(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return (intern & maxmath.bitmask32(numBits, index)) != 0;
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestNone()
        {
            return intern == 0u;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestNone(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return (intern & maxmath.bitmask32(numBits, index)) == 0u;
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Overwrite(int index, int numBits, bit8 source, int sourceIndex)
        {
            OverwriteHelper((uint)source.intern, source.Length, index, numBits, sourceIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Overwrite(int index, int numBits, bit16 source, int sourceIndex)
        {
            OverwriteHelper((uint)source.intern, source.Length, index, numBits, sourceIndex);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Overwrite(int index, int numBits, bit32 source, int sourceIndex)
        {
            OverwriteHelper(source.intern, source.Length, index, numBits, sourceIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Overwrite(int index, int numBits, bit64 source, int sourceIndex)
        {
            OverwriteHelper(source.intern, source.Length, index, numBits, sourceIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Overwrite<T>(int index, int numBits, bits<T> source, int sourceIndex)
            where T : unmanaged
        {
            OverwriteHelper(*(ulong*)&source, source.Length, index, numBits, sourceIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void OverwriteHelper(ulong backingField, int sourceLength, int index, int numBits, int sourceIndex)
        {
Assert.IsValidSubarray(index, numBits, Length);
Assert.IsValidSubarray(sourceIndex, numBits, sourceLength);

            ulong mask = (ulong)maxmath.bitmask64(numBits, index);

            ulong shiftedSource = (index < sourceIndex) 
                                  ? backingField >> sourceIndex - index
                                  : backingField << index - sourceIndex;

            intern = (byte)((shiftedSource & mask) | maxmath.andnot(intern, mask));
        }


        public override string ToString()
        {
            return Log.Bits(this);
        }

    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
            return (int)intern;
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(bit32 other)
        {
            return this.intern == other.intern;
        }
    
        public override readonly bool Equals(object obj)
        {
            return Equals((bit32)obj);
        }
    
    
        public IEnumerator<bool> GetEnumerator()
        {
            return new Enumerator<bool>(this);
        }
    
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumerator<bool>(this);
        }
    }
}