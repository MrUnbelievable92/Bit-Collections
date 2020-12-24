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
    unsafe public struct bits<T> : IArray<bool>, IEquatable<bits<T>>
        where T : unmanaged
    {
        internal T intern;
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bits(T value)
        {
Assert.IsNotGreater(sizeof(T), 8);

            intern = value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bits(bool value)
        {
            ulong temp = (ulong)(-(long)maxmath.touint64(value));

            intern = *(T*)&temp;
        }


        public readonly int Length => 8 * sizeof(T);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator T(bits<T> input)
        {
            return input.intern;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator bits<T>(T input)
        {
            return new bits<T>(input);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bits<T> operator ! (bits<T> value)
        {
            ulong temp = ~(*(ulong*)&value);

            return *(bits<T>*)&temp;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bits<T> operator == (bits<T> left, bits<T> right)
        {
            ulong temp = ~(*(ulong*)&left ^ *(ulong*)&right);

            return *(bits<T>*)&temp;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bits<T> operator != (bits<T> left, bits<T> right)
        {
            ulong temp = *(ulong*)&left ^ *(ulong*)&right;

            return *(bits<T>*)&temp;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bits<T> operator & (bits<T> left, bits<T> right)
        {
            ulong temp = *(ulong*)&left & *(ulong*)&right;

            return *(bits<T>*)&temp;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bits<T> operator | (bits<T> left, bits<T> right)
        {
            ulong temp = *(ulong*)&left | *(ulong*)&right;

            return *(bits<T>*)&temp;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bits<T> operator ^ (bits<T> left, bits<T> right)
        {
            ulong temp = *(ulong*)&left ^ *(ulong*)&right;

            return *(bits<T>*)&temp;
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bits<U> Reinterpret<U>()
            where U : unmanaged
        {
Assert.AreEqual(sizeof(T), sizeof(U));

            fixed (void* ptr = &this)
            {
                return *(bits<U>*)ptr;
            }
        }


        public bool this[[AssumeRange(0, 63)] int index] 
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
Assert.IsWithinArrayBounds(index, Length);

                fixed (void* ptr = &this)
                {
                    ulong result = (*(ulong*)ptr >> index) & 1ul;

                    return *(bool*)&result;
                }
            }
    
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsWithinArrayBounds(index, Length);

                fixed (void* ptr = &this)
                {
                    ulong mask = 1ul << index;

                    ulong result = value ? *(ulong*)ptr | mask : maxmath.andnot(*(ulong*)ptr, mask);

                    intern = *(T*)&result;
                }
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(0, 1)] 
        public readonly int ToInt32([AssumeRange(0, 63)] int index)
        {
Assert.IsWithinArrayBounds(index, Length);

            fixed (void* ptr = &this)
            {
                return (int)((*(ulong*)ptr >> index) & 1ul);
            }
        }


        public readonly bool[] ToArray()
        {
            bool[] result = new bool[Length];

            fixed (void* ptr = &result[0], internAddress = &this)
            {
                for (int i = 0; i < sizeof(T); i++)
                {
                    *((bool8*)ptr + i) = maxmath.tobool8(*((byte*)internAddress + i));
                }
            }

            return result;
        }

        public readonly NativeArray<bool> ToArray(Allocator allocator)
        {
            NativeArray<bool> result = new NativeArray<bool>(Length, allocator, NativeArrayOptions.UninitializedMemory);

            void* ptr = result.GetUnsafePtr();

            fixed (void* internAddress = &this)
            {
                for (int i = 0; i < sizeof(T); i++)
                {
                    *((bool8*)ptr + i) = maxmath.tobool8(*((byte*)internAddress + i));
                }
            }

            return result;
        }


        /// <summary>       The return value is undefined in case none of the bits are set to 1 (apart from the fact that it will be larger than the largest index of the array)        </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(0, 64)] 
        public readonly int IndexOfFirst()
        {
            fixed (void* ptr = &this)
            {
                return math.tzcnt(*(ulong*)ptr);
            }
        }

        /// <summary>       The return value is undefined in case none of the bits are set to 1 (apart from the fact that it will be larger than the largest index of the array)        </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(0, 64)] 
        public readonly int IndexOfFirst([AssumeRange(0, 63)] int index, [AssumeRange(0, 64)] int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            fixed (void* ptr = &this)
            {
                return math.tzcnt(*(ulong*)ptr & (ulong)maxmath.bitmask64(numBits, index));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(-1, 63)] 
        public readonly int IndexOfLast()
        {
            fixed (void* ptr = &this)
            {
                return Length - 1 - math.lzcnt(*(ulong*)ptr & (ulong)maxmath.bitmask64(Length));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(-1, 63)] 
        public readonly int IndexOfLast([AssumeRange(0, 63)] int index, [AssumeRange(0, 64)] int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            fixed (void* ptr = &this)
            {
                return Length - 1 - math.lzcnt(*(ulong*)ptr & (ulong)maxmath.bitmask64(numBits, index));
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ShiftLeft(int amount)
        {
            fixed (void* ptr = &this)
            {
                ulong shl = *(ulong*)ptr << amount;

                intern = *(T*)&shl;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ShiftLeft([AssumeRange(0, 63)] int index, [AssumeRange(0, 64)] int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            fixed (void* ptr = &this)
            {
                ulong mask = (ulong)maxmath.bitmask64(numBits, index);
                ulong maskED = mask & *(ulong*)ptr;

                maskED = maxmath.andnot(*(ulong*)ptr, mask) | (mask & (maskED << amount));

                intern = *(T*)&maskED;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ShiftRight(int amount)
        {
            fixed (void* ptr = &this)
            {
                ulong shr = *(ulong*)ptr >> amount;

                intern = *(T*)&shr;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ShiftRight([AssumeRange(0, 63)] int index, [AssumeRange(0, 64)] int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            fixed (void* ptr = &this)
            {
                ulong mask = (ulong)maxmath.bitmask64(numBits, index);
                ulong maskED = mask & *(ulong*)ptr;

                maskED = maxmath.andnot(*(ulong*)ptr, mask) | (mask & (maskED >> amount));

                intern = *(T*)&maskED;
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RotateLeft(int amount)
        {
            amount &= Length - 1;

            fixed (void* ptr = &this)
            {
                ulong masked = *(ulong*)ptr & (ulong)maxmath.bitmask64(Length);

                ulong rol = (masked << amount) | (masked >> (-amount & (Length - 1)));

                intern = *(T*)&rol;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RotateLeft([AssumeRange(0, 63)] int index, [AssumeRange(0, 64)] int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            fixed (void* ptr = &this)
            {
                ulong val = *(ulong*)ptr;

                ulong mask = (ulong)maxmath.bitmask64(numBits, index);
                ulong maskED = mask & val;

                int remainder = amount % numBits;

                maskED = (mask & (maskED << remainder)) | (mask & (maskED >> (numBits - remainder)));

                maskED = maxmath.andnot(val, mask) | maskED;


                intern = *(T*)&maskED;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RotateRight(int amount)
        {
            amount &= Length - 1;

            fixed (void* ptr = &this)
            {
                ulong masked = *(ulong*)ptr & (ulong)maxmath.bitmask64(Length);

                ulong ror = (masked >> amount) | (masked << (-amount & (Length - 1)));

                intern = *(T*)&ror;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RotateRight([AssumeRange(0, 63)] int index, [AssumeRange(0, 64)] int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            fixed (void* ptr = &this)
            {
                ulong val = *(ulong*)ptr;

                ulong mask = (ulong)maxmath.bitmask64(numBits, index);
                ulong maskED = mask & val;

                int remainder = amount % numBits;

                maskED = (mask & (maskED >> remainder)) | (mask & (maskED << (numBits - remainder)));

                maskED = maxmath.andnot(val, mask) | maskED;


                intern = *(T*)&maskED;
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Swap([AssumeRange(0, 63)] int smallerIndex, [AssumeRange(0, 63)] int largerIndex)
        {
Assert.IsWithinArrayBounds(smallerIndex, Length);
Assert.IsWithinArrayBounds(largerIndex, Length);

            fixed (void* ptr = &this)
            {
                ulong2 field = *(ulong*)ptr;
                ulong2 packed = (ulong2)new long2(smallerIndex, largerIndex);

                ulong2 result = 1 & maxmath.shrl(field, packed);
                result ^= result.yx;
                result = maxmath.shl(result, packed);

                result = field ^ (result | result.yx);


                intern = *(T*)&result;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Swap([AssumeRange(0, 63)] int smallerIndex, [AssumeRange(0, 63)] int largerIndex, [AssumeRange(0, 64)] int numBits)
        {
Assert.IsGreater(largerIndex, smallerIndex);
Assert.IsValidSubarray(smallerIndex, numBits, Length);
Assert.IsValidSubarray(largerIndex, numBits, Length);
Assert.SubarraysDoNotOverlap(smallerIndex, largerIndex, numBits, numBits);

            fixed (void* ptr = &this)
            {
                ulong val = *(ulong*)ptr;

                // inlined bitmask
                // x: mask for lower subarray, y: mask for upper subarray, 
                ulong3 masks = maxmath.shl(ulong.MaxValue, new ulong3((ulong)smallerIndex, (ulong)largerIndex, 0ul));
                masks = maxmath.andnot(masks, masks << numBits);
                // z: mask for deleting elements in the array
                masks.z = ~(masks.x | masks.y);

                // delete in z, grab values in x & y
                masks &= val;

                // swap positions; blend together
                int indexDelta = largerIndex - smallerIndex;
                val = ((masks.z | (masks.x << indexDelta)) | (masks.y >> indexDelta));


                intern = *(T*)&val;
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Flip()
        {
            this = !this;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Flip([AssumeRange(0, 63)] int index, [AssumeRange(0, 64)] int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            fixed (void* ptr = &this)
            {
                ulong2 invert = new ulong2((ulong)maxmath.bitmask64(numBits, index), *(ulong*)ptr);

                invert = maxmath.andnot(invert, invert.yx);

                invert = invert | invert.yx;

                intern = *(T*)&invert;
            }
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reverse()
        {
            fixed (void* ptr = &this)
            {
                ulong reversed = math.reversebits(*(ulong*)ptr) >> (64 - Length);

                intern = *(T*)&reversed;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reverse([AssumeRange(0, 63)] int index, [AssumeRange(0, 64)] int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = (ulong)maxmath.bitmask64(numBits, index);
            int shiftValue = math.mad(2, index,      numBits - Length);
    
Assert.IsDefinedBitShift<ulong>(math.abs(shiftValue));

            fixed (void* ptr = &this)
            {
                ulong val = *(ulong*)ptr;

                val = (mask & ((shiftValue < 0)
                              ? (math.reversebits(val) >> (64 - Length)) >> math.abs(shiftValue)
                              : (math.reversebits(val) >> (64 - Length)) << shiftValue))
                      |
                      maxmath.andnot(val, mask);

                intern = *(T*)&val;
            }
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)] 
        public void Shuffle(ref Random32 rngenerator)
        {
            for (int2 i = new int2(63, Length);     (i > 0).x;    i--)
            {
                Swap(i.x, rngenerator.NextInt(0, i.y));
            }
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)] 
        public void Shuffle([AssumeRange(0, 63)] int index, [AssumeRange(0, 64)] int numBits, ref Random32 rngenerator)
        {
Assert.IsValidSubarray(index, numBits, Length);
    
            int startingIndex = index + numBits;/* - 1 is actual starting index*/
    
            for (int2 i = new int2(startingIndex - 1, startingIndex);     (i > 0).x;      i--)  
            {
                Swap(i.x, rngenerator.NextInt(0, i.y));
            } 
        }
    
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)] 
        public void Randomize(ref Random64 rngenerator)
        {
            ulong newOne = rngenerator.NextULong();

            intern = *(T*)&newOne;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)] 
        public void Randomize([AssumeRange(0, 63)] int index, [AssumeRange(0, 64)] int numBits, ref Random64 rngenerator)
        {
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = (ulong)maxmath.bitmask64(numBits, index);

            fixed (void* ptr = &this)
            {
                mask = (rngenerator.NextULong() & mask) | maxmath.andnot(*(ulong*)ptr, mask);

                intern = *(T*)&mask;
            }
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)] 
        public void SetBits(bool value)
        {
            this = new bits<T>(value);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)] 
        public void SetBits([AssumeRange(0, 63)] int index, [AssumeRange(0, 64)] int numBits, bool value)
        {
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = (ulong)maxmath.bitmask64(numBits, index);
    
            fixed (void* ptr = &this)
            {
                mask = value ? *(ulong*)ptr | mask : maxmath.andnot(*(ulong*)ptr, mask);

                intern = *(T*)&mask;
            }
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(0, 64)] 
        public readonly int CountBits()
        {
            ulong mask = (ulong)maxmath.bitmask64(Length);

            fixed (void* ptr = &this)
            {
                return math.countbits(*(ulong*)ptr & mask);
            }
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(0, 64)] 
        public readonly int CountBits([AssumeRange(0, 63)] int index, [AssumeRange(0, 64)] int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = (ulong)maxmath.bitmask64(numBits, index);

            fixed (void* ptr = &this)
            {
                return math.countbits(*(ulong*)ptr & mask);
            }
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAll()
        {
            ulong trueMask = (ulong)maxmath.bitmask64(Length);

            fixed (void* ptr = &this)
            {
                return trueMask == (*(ulong*)ptr & trueMask);
            }
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAll([AssumeRange(0, 63)] int index, [AssumeRange(0, 64)] int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            ulong trueMask = (ulong)maxmath.bitmask64(numBits, index);

            fixed (void* ptr = &this)
            {
                return trueMask == (*(ulong*)ptr & trueMask);
            }
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAny()
        {
            fixed (void* ptr = &this)
            {
                return 0ul != (*(ulong*)ptr & (ulong)maxmath.bitmask64(Length));
            }
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAny([AssumeRange(0, 63)] int index, [AssumeRange(0, 64)] int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            fixed (void* ptr = &this)
            {
                return 0ul != (*(ulong*)ptr & (ulong)maxmath.bitmask64(numBits, index));
            }
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestNone()
        {
            fixed (void* ptr = &this)
            {
                return 0ul == (*(ulong*)ptr & (ulong)maxmath.bitmask64(Length));
            }
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestNone([AssumeRange(0, 63)] int index, [AssumeRange(0, 64)] int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            fixed (void* ptr = &this)
            {
                return 0ul == (*(ulong*)ptr & (ulong)maxmath.bitmask64(numBits, index));
            }
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Overwrite([AssumeRange(0, 63)] int index, [AssumeRange(0, 64)] int numBits, bit8 source, [AssumeRange(0, 7)] int sourceIndex)
        {
            OverwriteHelper((ulong)source.intern, source.Length, index, numBits, sourceIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Overwrite([AssumeRange(0, 63)] int index, [AssumeRange(0, 64)] int numBits, bit16 source, [AssumeRange(0, 15)] int sourceIndex)
        {
            OverwriteHelper((ulong)source.intern, source.Length, index, numBits, sourceIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Overwrite([AssumeRange(0, 63)] int index, [AssumeRange(0, 64)] int numBits, bit32 source, [AssumeRange(0, 31)] int sourceIndex)
        {
            OverwriteHelper((ulong)source.intern, source.Length, index, numBits, sourceIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Overwrite([AssumeRange(0, 63)] int index, [AssumeRange(0, 64)] int numBits, bit64 source, [AssumeRange(0, 63)] int sourceIndex)
        {
            OverwriteHelper(source.intern, source.Length, index, numBits, sourceIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Overwrite<U>([AssumeRange(0, 63)] int index, [AssumeRange(0, 64)] int numBits, bits<U> source, [AssumeRange(0, 63)] int sourceIndex)
            where U : unmanaged
        {
            OverwriteHelper(*(ulong*)&source, source.Length, index, numBits, sourceIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void OverwriteHelper(ulong backingField, [AssumeRange(0, 63)] int sourceLength, [AssumeRange(0, 63)] int index, [AssumeRange(0, 64)] int numBits, [AssumeRange(0, 63)] int sourceIndex)
        {
Assert.IsValidSubarray(index, numBits, Length);
Assert.IsValidSubarray(sourceIndex, numBits, sourceLength);

            ulong mask = (ulong)maxmath.bitmask64(numBits, index);

            ulong shiftedSource = (index < sourceIndex)
                                  ? backingField >> sourceIndex - index
                                  : backingField << index - sourceIndex;

            fixed (void* ptr = &this)
            {
                ulong val = *(ulong*)ptr;

                val = (shiftedSource & mask) | maxmath.andnot(val, mask);

                intern = *(T*)&val;
            }
        }


        public override string ToString()
        {
            return Log.Bits(this);
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
            fixed (void* ptr = &this)
            {
                ulong masked = *(ulong*)ptr & (ulong)maxmath.bitmask64(Length);

                return (int)(masked ^ (masked >> 32));
            }
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(bits<T> other)
        {
            ulong mask = (ulong)maxmath.bitmask64(Length);

            fixed (void* ptr = &this)
            {
                return (*(ulong*)ptr & mask) == (*(ulong*)&other & mask);
            }
        }
        public override readonly bool Equals(object obj)
        {
            return Equals((bits<T>)obj);
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