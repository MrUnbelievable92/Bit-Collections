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
    unsafe public struct bit8 : IArray<bool>, IEquatable<bit8>
    {
        internal byte intern;
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit8(byte value)
        {
            intern = value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit8(sbyte value)
        {
            intern = (byte)value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit8(bool value)
        {
            intern = (byte)(-maxmath.toint8(value));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit8(bool x0, bool x1, bool x2, bool x3, bool x4, bool x5, bool x6, bool x7)
        {
            intern = (byte)maxmath.bitmask(new bool8(x0, x1, x2, x3, x4, x5, x6, x7));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit8(bool[] values, int index = 0)
        {
Assert.IsWithinArrayBounds(index + 7, values.Length);

            fixed (void* ptr = &values[index])
            {
                intern = (byte)maxmath.bitmask(*(bool8*)ptr);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit8(NativeArray<bool> values, int index = 0)
        {
Assert.IsWithinArrayBounds(index + 7, values.Length);

            intern = (byte)maxmath.bitmask(*(bool8*)((bool*)values.GetUnsafePtr() + index));
        }


        public readonly int Length => 8;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte(bit8 input)
        {
            return input.intern;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte(bit8 input)
        {
            return (sbyte)input.intern;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit8(byte input)
        {
            return *(bit8*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit8(sbyte input)
        {
            return *(bit8*)&input;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit8 operator ! (bit8 value)
        {
            value.intern = (byte)(~value.intern);

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
            left.intern = (byte)(left.intern & right.intern);
    
            return left;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit8 operator | (bit8 left, bit8 right)
        {
            left.intern = (byte)(left.intern | right.intern);
    
            return left;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit8 operator ^ (bit8 left, bit8 right)
        {
            left.intern = (byte)(left.intern ^ right.intern);
    
            return left;
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bits<T> Reinterpret<T>()
            where T : unmanaged
        {
Assert.AreEqual(sizeof(bit8), sizeof(T));

            byte temp = intern;

            return *(bits<T>*)&temp;
        }


        public bool this[int index]
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
Assert.IsSafeBoolean(value);
Assert.IsWithinArrayBounds(index, Length);
    
                uint mask = 1u << index;

                intern = (byte)(maxmath.andnot(intern, mask) | ((uint)-*(byte*)&value & mask));
            }
        }


        public readonly bool[] ToArray()
        {
            bool[] result = new bool[Length];

            fixed(void* ptr = &result[0])
            {
                ((bool8*)ptr)[0] = maxmath.tobool8(intern);
            }

            return result;
        }

        public readonly NativeArray<bool> ToArray(Allocator allocator)
        {
            NativeArray<bool> result = new NativeArray<bool>(Length, allocator, NativeArrayOptions.UninitializedMemory);

            *(bool8*)result.GetUnsafePtr() = maxmath.tobool8(intern);

            return result;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(0, 32)] 
        public readonly int IndexOfFirst()
        {
            return math.tzcnt((uint)intern);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(0, 32)] 
        public readonly int IndexOfFirst(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return math.tzcnt(intern & maxmath.bitmask32(numBits, index));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(-1, 7)] 
        public readonly int IndexOfLast()
        {
            return 31 - math.lzcnt((uint)intern);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(-1, 7)] 
        public readonly int IndexOfLast(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return 31 - math.lzcnt((uint)intern & maxmath.bitmask32((uint)numBits, (uint)index));
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

            uint mask = (uint)maxmath.bitmask32((uint)numBits, (uint)index);
            uint maskED = mask & intern;

            intern = (byte)(maxmath.andnot(intern, mask) | (mask & (maskED << amount)));
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

            intern = (byte)(maxmath.andnot(intern, mask) | (mask & (maskED >> amount)));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RotateLeft(int amount)
        {
            intern = maxmath.rol(intern, amount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RotateLeft(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)maxmath.bitmask32(numBits, index);
            uint maskED = mask & intern;

            int remainder = amount % numBits;

            maskED = (mask & (maskED << remainder))   |   (mask & (maskED >> (numBits - remainder)));

            intern = (byte)(maxmath.andnot(intern, mask) | maskED);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RotateRight(int amount)
        {
            intern = maxmath.ror(intern, amount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RotateRight(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)maxmath.bitmask32(numBits, index);
            uint maskED = mask & intern;

            int remainder = amount % numBits;

            maskED = (mask & (maskED >> remainder))   |   (mask & (maskED << (numBits - remainder)));

            intern = (byte)(maxmath.andnot(intern, mask) | maskED);
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

            intern = (byte)((field ^ (result | result.yx)).x);
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
            uint3 masks = maxmath.shl((uint)byte.MaxValue, (uint3)new int3(smallerIndex, largerIndex, 0));
            masks = maxmath.andnot(masks, masks << numBits);
            // z: mask for deleting elements in the array
            masks.z = ~(masks.x | masks.y);

            masks &= intern;


            int indexDelta = largerIndex - smallerIndex;
            masks = maxmath.shl(masks, new uint3((uint)indexDelta, 0, 0));
            masks = maxmath.shrl(masks, new uint3(0, (uint)indexDelta, 0));
            // blend everything together - csum replaces 2x bitwise OR
            intern = (byte)math.csum(masks);
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

            byte2 invert = new byte2((byte)maxmath.bitmask32(numBits, index),   intern);
    
            invert = maxmath.andnot(invert, invert.yx);
    
            intern = (byte)((invert | invert.yx).x);
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reverse()
        {
            intern = maxmath.reversebits(intern);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reverse(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)maxmath.bitmask32(numBits, index);
            int shiftValue = math.mad(2, index,      numBits - Length);

            intern = (byte)((mask & ((shiftValue < 0)
                                     ? maxmath.reversebits(intern) >> math.abs(shiftValue)
                                     : maxmath.reversebits(intern) << shiftValue))
                            |
                            maxmath.andnot(intern, mask));
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Shuffle(ref Random32 rngenerator)
        {
            for (int2 i = new int2(7, Length);      (i > 0).x;      i--)
            {
                Swap(i.x, rngenerator.NextInt(0, i.y));
            }
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Shuffle(int index, int numBits, ref Random32 rngenerator)
        {
Assert.IsValidSubarray(index, numBits, Length);
    
            int startingIndex = index + numBits;/* - 1 is actual starting index*/
    
            for (int2 i = new int2(startingIndex - 1, startingIndex);    (i > 0).x;      i--)
            {
                Swap(i.x, rngenerator.NextInt(0, i.y));
            }
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Randomize(ref Random32 rngenerator)
        {
            intern = (byte)rngenerator.NextUInt(0u,    byte.MaxValue + 1u);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Randomize(int index, int numBits, ref Random32 rngenerator)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)maxmath.bitmask32(numBits, index);
    
            intern = (byte)((rngenerator.NextUInt(0u, byte.MaxValue + 1u) & mask)    |    maxmath.andnot(intern, mask));
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetBits(bool value)
        {
            this = new bit8(value);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetBits(int index, int numBits, bool value)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)maxmath.bitmask32(numBits, index);

            intern = (byte)(maxmath.andnot(intern, mask) | ((uint)-*(byte*)&value & mask));
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(0, 8)] 
        public readonly uint CountBits()
        {
            return (uint)math.countbits((uint)intern);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(0, 8)] 
        public readonly uint CountBits(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return (uint)math.countbits(intern & maxmath.bitmask32(numBits, index));
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAll()
        {
            return intern == (uint)byte.MaxValue;
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
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(0, byte.MaxValue)] 
        public override readonly int GetHashCode()
        {
            return (int)intern;
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(bit8 other)
        {
            return (uint)this.intern == (uint)other.intern;
        }
        public override readonly bool Equals(object obj)
        {
            return Equals((bit8)obj);
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