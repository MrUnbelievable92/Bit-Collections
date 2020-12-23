using DevTools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
        public bit32(bool value)
        {
            intern = (uint)maxmath.touint8(value) * uint.MaxValue;
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

            intern = (uint)maxmath.bitmask(*(bool32*)((bool*)values.GetUnsafePtr() + index));
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
            return *(bit32*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit32(int input)
        {
            return *(bit32*)&input;
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
        public static bit32 operator == (bit32 lhs, bit32 rhs)
        {
            return !(lhs != rhs);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit32 operator != (bit32 lhs, bit32 rhs)
        {
            return lhs ^ rhs;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit32 operator & (bit32 lhs, bit32 rhs)
        {
            lhs.intern &= rhs.intern;
    
            return lhs;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit32 operator | (bit32 lhs, bit32 rhs)
        {
            lhs.intern |= rhs.intern;
    
            return lhs;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit32 operator ^ (bit32 lhs, bit32 rhs)
        {
            lhs.intern ^= rhs.intern;
    
            return lhs;
        }
    
    
        public bool this[[AssumeRange(0, 31)] int index]
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
Assert.IsWithinArrayBounds(index, Length);
    
                uint mask = 1u << index;
    
                intern = value ? intern | mask : maxmath.andnot(intern, mask);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(0, 1)] 
        public readonly int ToInt32([AssumeRange(0, 31)] int index)
        {
            Assert.IsWithinArrayBounds(index, Length);

            return (int)((intern >> index) & 1u);
        }


        public readonly bool[] ToArray()
        {
            bool[] result = new bool[32];

            fixed (void* ptr = &result[0])
            {
                ((bool32*)ptr)[0] = maxmath.tobool32((int)intern);
            }

            return result;
        }

        public readonly NativeArray<bool> ToArray(Allocator allocator)
        {
            NativeArray<bool> result = new NativeArray<bool>(32, allocator);

            *(bool32*)result.GetUnsafePtr() = maxmath.tobool32((int)intern);

            return result;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit8 Getbit8SubArray([AssumeRange(0, 24)] int index)
        {
Assert.IsValidSubarray(index, new bit8().Length, Length);

            uint temp = intern >> index;

            return *(bit8*)&temp;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit16 Getbit16SubArray([AssumeRange(0, 16)] int index)
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
        public readonly int IndexOfFirst([AssumeRange(0, 31)] int index, [AssumeRange(0, 32)] int numBits)
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
        public readonly int IndexOfLast([AssumeRange(0, 31)] int index, [AssumeRange(0, 32)] int numBits)
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
        public void ShiftLeft([AssumeRange(0, 31)] int index, [AssumeRange(0, 32)] int numBits, int amount)
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
        public void ShiftRight([AssumeRange(0, 31)] int index, [AssumeRange(0, 32)] int numBits, int amount)
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
        public void RotateLeft([AssumeRange(0, 31)] int index, [AssumeRange(0, 32)] int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)maxmath.bitmask32(numBits, index);
            uint maskED = mask & intern;

            int remainder = amount % numBits;

            maskED = (mask & (maskED << remainder))   |   (mask & (maskED >> (numBits - remainder)));

            intern = maxmath.andnot(intern, mask) | maskED;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RotateRight(int amount)
        {
            intern = math.ror(intern, amount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RotateRight([AssumeRange(0, 31)] int index, [AssumeRange(0, 32)] int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)maxmath.bitmask32(numBits, index);
            uint maskED = mask & intern;

            int remainder = amount % numBits;

            maskED = (mask & (maskED >> remainder))   |   (mask & (maskED << (numBits - remainder)));

            intern = maxmath.andnot(intern, mask) | maskED;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Swap(int smallerIndex, int largerIndex)
        {
Assert.IsNotSmaller(largerIndex, smallerIndex);
Assert.IsWithinArrayBounds(smallerIndex, Length);
Assert.IsWithinArrayBounds(largerIndex, Length);

            // x: mask for smallerIndex, y: mask for largerIndex, 
            uint3 masks = maxmath.shl(1u, (uint3)new int3(smallerIndex, largerIndex, 0));
            // z: mask for deleting elements in the array
            masks.z = ~(masks.x | masks.y);

            // delete in z, grab values in x & y
            masks &= intern;

            // swap positions; blend together
            int indexDelta = largerIndex - smallerIndex;
            intern = (masks.z | (masks.x << indexDelta)) | (masks.y >> indexDelta);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Swap(int smallerIndex, int largerIndex, [AssumeRange(0, 32)] int numBits)
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
            masks.z =  ~(masks.x | masks.y);

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
        public void Flip([AssumeRange(0, 31)] int index, [AssumeRange(0, 32)] int numBits)
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
        public void Reverse([AssumeRange(0, 31)] int index, [AssumeRange(0, 32)] int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)maxmath.bitmask32(numBits, index);
            int shiftValue = math.mad(2, index,      numBits - Length);
    
Assert.IsDefinedBitShift<uint>(math.abs(shiftValue));
    
            intern = (mask & ((shiftValue < 0) 
                              ? math.reversebits(intern) >> math.abs(shiftValue)
                              : math.reversebits(intern) << shiftValue))
                      |
                      maxmath.andnot(intern, mask);
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Shuffle(ref Random32 rngenerator)
        {
            for (int2 i = new int2(31, Length); i.x > 0; i--)
            {
                int randomIndex = rngenerator.NextInt(0, i.y);

                if (i.x > randomIndex)
                {
                    Swap(randomIndex, i.x);
                }
                else
                {
                    Swap(i.x, randomIndex);
                }
            }
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Shuffle([AssumeRange(0, 31)] int index, [AssumeRange(0, 32)] int numBits, ref Random32 rngenerator)
        {
Assert.IsValidSubarray(index, numBits, Length);
    
            int startingIndex = index + numBits;/* - 1 is actual starting index*/
    
            for (int2 i = new int2(startingIndex - 1, startingIndex); i.x > 0; i--)
            {
                int randomIndex = rngenerator.NextInt(0, i.y);

                if (i.x > randomIndex)
                {
                    Swap(randomIndex, i.x);
                }
                else
                {
                    Swap(i.x, randomIndex);
                }
            }
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Randomize(ref Random32 rngenerator)
        {
            intern = rngenerator.NextUInt();
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Randomize([AssumeRange(0, 31)] int index, [AssumeRange(0, 32)] int numBits, ref Random32 rngenerator)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint maskTRUE = (uint)maxmath.bitmask32(numBits, index);
    
            intern = (rngenerator.NextUInt() & maskTRUE)    |    maxmath.andnot(intern, maskTRUE);
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetBits(bool value)
        {
            intern = value ? uint.MaxValue : uint.MinValue;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetBits([AssumeRange(0, 31)] int index, [AssumeRange(0, 32)] int numBits, bool value)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)maxmath.bitmask32(numBits, index);
    
            intern = value ? intern | mask : maxmath.andnot(intern, mask);
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int CountBits()
        {
            return math.countbits(intern);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int CountBits([AssumeRange(0, 31)] int index, [AssumeRange(0, 32)] int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return math.countbits(intern & maxmath.bitmask32(numBits, index));
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAll()
        {
            return intern == uint.MaxValue;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAll([AssumeRange(0, 31)] int index, [AssumeRange(0, 32)] int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint trueMask = (uint)maxmath.bitmask32(numBits, index);
    
            return (intern & trueMask) == trueMask;
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAny()
        {
            return intern != 0;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAny([AssumeRange(0, 31)] int index, [AssumeRange(0, 32)] int numBits)
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
        public readonly bool TestNone([AssumeRange(0, 31)] int index, [AssumeRange(0, 32)] int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return (intern & maxmath.bitmask32(numBits, index)) == 0u;
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Overwrite([AssumeRange(0, 31)] int index, [AssumeRange(0, 8)] int numBits, bit8 source, [AssumeRange(0, 7)] int sourceIndex)
        {
            OverwriteHelper((uint)source.intern, new bit8().Length, index, numBits, sourceIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Overwrite([AssumeRange(0, 31)] int index, [AssumeRange(0, 16)] int numBits, bit16 source, [AssumeRange(0, 15)] int sourceIndex)
        {
            OverwriteHelper((uint)source.intern, new bit16().Length, index, numBits, sourceIndex);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Overwrite([AssumeRange(0, 31)] int index, [AssumeRange(0, 32)] int numBits, bit32 source, [AssumeRange(0, 31)] int sourceIndex)
        {
            OverwriteHelper(source.intern, new bit32().Length, index, numBits, sourceIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Overwrite([AssumeRange(0, 31)] int index, [AssumeRange(0, 32)] int numBits, bit64 source, [AssumeRange(0, 63)] int sourceIndex)
        {
            OverwriteHelper(source.intern, new bit64().Length, index, numBits, sourceIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Overwrite<T>([AssumeRange(0, 31)] int index, [AssumeRange(0, 32)] int numBits, bits<T> source, [AssumeRange(0, 63)] int sourceIndex)
            where T : unmanaged
        {
            OverwriteHelper(*(ulong*)&source, new bits<T>().Length, index, numBits, sourceIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void OverwriteHelper(ulong backingField, [AssumeRange(0, 64)] int sourceLength, [AssumeRange(0, 31)] int index, [AssumeRange(0, 32)] int numBits, [AssumeRange(0, 63)] int sourceIndex)
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