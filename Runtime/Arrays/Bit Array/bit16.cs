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
    unsafe public struct bit16 : IArray<bool>, IEquatable<bit16>
    {
        internal ushort intern;
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit16(ushort value)
        {
            intern = value;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit16(bool value)
        {
            intern = (ushort)(-(short)maxmath.touint16(value));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit16(bool x0, bool x1, bool x2, bool x3, bool x4, bool x5, bool x6, bool x7, bool x8, bool x9, bool x10, bool x11, bool x12, bool x13, bool x14, bool x15)
        {
            intern = (ushort)maxmath.bitmask(new bool16(x0, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit16(bit8 x0_7, bit8 x8_15)
        {
            intern = (ushort)(x0_7.intern | (x8_15.intern << 8));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit16(bool[] values, int index = 0)
        {
Assert.IsWithinArrayBounds(index + 15, values.Length);

            fixed (void* ptr = &values[index])
            {
                intern = (ushort)maxmath.bitmask(*(bool16*)ptr);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit16(NativeArray<bool> values, int index = 0)
        {
Assert.IsWithinArrayBounds(index + 15, values.Length);

            intern = (ushort)maxmath.bitmask(*(bool16*)((bool*)values.GetUnsafePtr() + index));
        }


        public readonly int Length => 16;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort(bit16 input)
        {
            return input.intern;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short(bit16 input)
        {
            return (short)input.intern;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half(bit16 input)
        {
            return *(half*)&input;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit16(ushort input)
        {
            return *(bit16*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit16(short input)
        {
            return *(bit16*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit16(half input)
        {
            return *(bit16*)&input;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit16 operator ! (bit16 value)
        {
            value.intern = (ushort)(~value.intern);

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
            left.intern = (ushort)(left.intern & right.intern);
    
            return left;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit16 operator | (bit16 left, bit16 right)
        {
            left.intern = (ushort)(left.intern | right.intern);
    
            return left;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit16 operator ^ (bit16 left, bit16 right)
        {
            left.intern = (ushort)(left.intern ^ right.intern);
    
            return left;
        }
    
    
        public bool this[[AssumeRange(0, 15)] int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
Assert.IsWithinArrayBounds(index, Length);
    
                uint result = ((uint)intern >> index) & 1u;
    
                return *(bool*)&result;
            }
    
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            { 
Assert.IsWithinArrayBounds(index, Length);
    
                uint mask = 1u << index;
    
                intern = (ushort)(value ? intern | mask : maxmath.andnot(intern, mask));
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(0, 1)] 
        public readonly int ToInt32([AssumeRange(0, 15)] int index)
        {
Assert.IsWithinArrayBounds(index, Length);
    
            return (int)(((uint)intern >> index) & 1u);
        }


        public readonly bool[] ToArray()
        {
            bool[] result = new bool[Length];

            fixed (void* ptr = &result[0])
            {
                ((bool16*)ptr)[0] = maxmath.tobool16(intern);
            }

            return result;
        }

        public readonly NativeArray<bool> ToArray(Allocator allocator)
        {
            NativeArray<bool> result = new NativeArray<bool>(Length, allocator, NativeArrayOptions.UninitializedMemory);

            *(bool16*)result.GetUnsafePtr() = maxmath.tobool16(intern);

            return result;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit8 Getbit8SubArray([AssumeRange(0, 8)] int index)
        {
Assert.IsValidSubarray(index, new bit8().Length, Length);

            uint temp = (uint)intern >> index;

            return *(bit8*) & temp;
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(0, 32)] 
        public readonly int IndexOfFirst()
        {
            return math.tzcnt((uint)intern);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(0, 32)] 
        public readonly int IndexOfFirst([AssumeRange(0, 15)] int index, [AssumeRange(0, 16)] int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return math.tzcnt(intern & maxmath.bitmask32((uint)numBits, (uint)index));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(-1, 15)] 
        public readonly int IndexOfLast()
        {
            return 31 - math.lzcnt((uint)intern);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(-1, 15)] 
        public readonly int IndexOfLast([AssumeRange(0, 15)] int index, [AssumeRange(0, 16)] int numBits)
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
        public void ShiftLeft([AssumeRange(0, 15)] int index, [AssumeRange(0, 16)] int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)maxmath.bitmask32(numBits, index);
            uint maskED = mask & intern;

            intern = (ushort)(maxmath.andnot(intern, mask) | (mask & (maskED << amount)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ShiftRight(int amount)
        {
            intern >>= amount; 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ShiftRight([AssumeRange(0, 15)] int index, [AssumeRange(0, 16)] int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)maxmath.bitmask32(numBits, index);
            uint maskED = mask & intern;

            intern = (ushort)(maxmath.andnot(intern, mask) | (mask & (maskED >> amount)));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RotateLeft(int amount)
        {
            intern = maxmath.rol(intern, amount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RotateLeft([AssumeRange(0, 15)] int index, [AssumeRange(0, 16)] int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)maxmath.bitmask32(numBits, index);
            uint maskED = mask & intern;

            int remainder = amount % numBits;

            maskED = (mask & (maskED << remainder))   |   (mask & (maskED >> (numBits - remainder)));

            intern = (ushort)(maxmath.andnot(intern, mask) | maskED);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RotateRight(int amount)
        {
            intern = maxmath.ror(intern, amount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RotateRight([AssumeRange(0, 15)] int index, [AssumeRange(0, 16)] int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)maxmath.bitmask32(numBits, index);
            uint maskED = mask & intern;

            int remainder = amount % numBits;

            maskED = (mask & (maskED >> remainder))   |   (mask & (maskED << (numBits - remainder)));

            intern = (ushort)(maxmath.andnot(intern, mask) | maskED);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Swap([AssumeRange(0, 15)] int smallerIndex, [AssumeRange(0, 15)] int largerIndex)
        {
Assert.IsWithinArrayBounds(smallerIndex, Length);
Assert.IsWithinArrayBounds(largerIndex, Length);

            uint2 field = intern;
            uint2 packed = (uint2)new int2(smallerIndex, largerIndex);

            uint2 result = 1 & maxmath.shrl(field, packed);
            result ^= result.yx;
            result = maxmath.shl(result, packed);

            intern = (ushort)((field ^ (result | result.yx)).x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Swap([AssumeRange(0, 15)] int smallerIndex, [AssumeRange(0, 15)] int largerIndex, [AssumeRange(0, 16)] int numBits)
        {
Assert.IsGreater(largerIndex, smallerIndex);
Assert.IsValidSubarray(smallerIndex, numBits, Length);
Assert.IsValidSubarray(largerIndex, numBits, Length);
Assert.SubarraysDoNotOverlap(smallerIndex, largerIndex, numBits, numBits);

            // inlined bitmask
            // x: mask for lower subarray, y: mask for upper subarray, 
            uint3 masks = maxmath.shl((uint)ushort.MaxValue, (uint3)new int3(smallerIndex, largerIndex, 0));
            masks = maxmath.andnot(masks, masks << numBits);
            // z: mask for deleting elements in the array
            masks.z = ~(masks.x | masks.y);

            // delete in z, grab values in x & y
            masks &= intern;

            // swap positions; blend together
            int indexDelta = largerIndex - smallerIndex;
            intern = (ushort)((masks.z | (masks.x << indexDelta)) | (masks.y >> indexDelta));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Flip()
        {
            this = !this;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Flip([AssumeRange(0, 15)] int index, [AssumeRange(0, 16)] int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            ushort2 invert = new ushort2((ushort)maxmath.bitmask32(numBits, index),   intern);
    
            invert = maxmath.andnot(invert, invert.yx);
    
            intern = (ushort)((invert | invert.yx).x);
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reverse()
        {
            intern = maxmath.reversebits(intern);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reverse([AssumeRange(0, 15)] int index, [AssumeRange(0, 16)] int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)maxmath.bitmask32(numBits, index);
            int shiftValue = math.mad(2, index, numBits - Length);

            intern = (ushort)((mask & ((shiftValue < 0)
                                       ? maxmath.reversebits(intern) >> math.abs(shiftValue)
                                       : maxmath.reversebits(intern) << shiftValue))
                              |
                              maxmath.andnot(intern, mask));
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Shuffle(ref Random32 rngenerator)
        {
            for (int2 i = new int2(15, Length);     (i > 0).x;      i--)
            {
                Swap(i.x, rngenerator.NextInt(0, i.y));
            }
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Shuffle([AssumeRange(0, 15)] int index, [AssumeRange(0, 16)] int numBits, ref Random32 rngenerator)
        {
Assert.IsValidSubarray(index, numBits, Length);
    
            int startingIndex = index + numBits;/* - 1 is actual starting index*/
    
            for (int2 i = new int2(startingIndex - 1, startingIndex);       (i > 0).x;      i--)
            {
                Swap(i.x, rngenerator.NextInt(0, i.y));
            }
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Randomize(ref Random32 rngenerator)
        { 
            intern = (ushort)rngenerator.NextUInt(0u,    ushort.MaxValue + 1u);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Randomize([AssumeRange(0, 15)] int index, [AssumeRange(0, 16)] int numBits, ref Random32 rngenerator)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint maskTRUE = (uint)maxmath.bitmask32(numBits, index);
    
            intern = (ushort)((rngenerator.NextUInt(0u, ushort.MaxValue + 1u) & maskTRUE)    |    maxmath.andnot(intern, maskTRUE));
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetBits(bool value)
        {
            this = new bit16(value);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetBits([AssumeRange(0, 15)] int index, [AssumeRange(0, 16)] int numBits, bool value)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)maxmath.bitmask32(numBits, index);
    
            intern = (ushort)(value ? intern | mask : maxmath.andnot(intern, mask));
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(0, 16)] 
        public readonly int CountBits()
        {
            return math.countbits((uint)intern);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(0, 16)] 
        public readonly int CountBits([AssumeRange(0, 15)] int index, [AssumeRange(0, 16)] int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return math.countbits(intern & maxmath.bitmask32(numBits, index));
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAll()
        {
            return intern == (uint)ushort.MaxValue;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAll([AssumeRange(0, 15)] int index, [AssumeRange(0, 16)] int numBits)
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
        public readonly bool TestAny([AssumeRange(0, 15)] int index, [AssumeRange(0, 16)] int numBits)
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
        public readonly bool TestNone([AssumeRange(0, 15)] int index, [AssumeRange(0, 16)] int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return (intern & maxmath.bitmask32(numBits, index)) == 0u;
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Overwrite([AssumeRange(0, 15)] int index, [AssumeRange(0, 8)] int numBits, bit8 source, [AssumeRange(0, 7)] int sourceIndex)
        {
            OverwriteHelper((uint)source.intern, source.Length, index, numBits, sourceIndex);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Overwrite([AssumeRange(0, 15)] int index, [AssumeRange(0, 16)] int numBits, bit16 source, [AssumeRange(0, 15)] int sourceIndex)
        {
            OverwriteHelper((uint)source.intern, source.Length, index, numBits, sourceIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Overwrite([AssumeRange(0, 15)] int index, [AssumeRange(0, 16)] int numBits, bit32 source, [AssumeRange(0, 31)] int sourceIndex)
        {
            OverwriteHelper(source.intern, source.Length, index, numBits, sourceIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Overwrite([AssumeRange(0, 15)] int index, [AssumeRange(0, 16)] int numBits, bit64 source, [AssumeRange(0, 63)] int sourceIndex)
        {
            OverwriteHelper(source.intern, source.Length, index, numBits, sourceIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Overwrite<T>([AssumeRange(0, 15)] int index, [AssumeRange(0, 16)] int numBits, bits<T> source, [AssumeRange(0, 63)] int sourceIndex)
            where T : unmanaged
        {
            OverwriteHelper(*(ulong*)&source, source.Length, index, numBits, sourceIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void OverwriteHelper(ulong backingField, [AssumeRange(0, 64)] int sourceLength, [AssumeRange(0, 15)] int index, [AssumeRange(0, 16)] int numBits, [AssumeRange(0, 63)] int sourceIndex)
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
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(0, ushort.MaxValue)] 
        public override readonly int GetHashCode()
        {
            return (int)intern;
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(bit16 other)
        {
            return this.intern == other.intern;
        }
    
        public override readonly bool Equals(object obj)
        {
            return Equals((bit16)obj); ;
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