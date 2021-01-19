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
            ulong temp = (ulong)(-maxmath.toint64(value));

            intern = *(T*)&temp;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bits(bool[] values, int index = 0)
        {
Assert.IsWithinArrayBounds(index + 7, values.Length);

            fixed (void* ptr = &values[index])
            {
                T field = default(T);

                for (int i = 0; i < sizeof(T); i++)
                {
                    ((byte*)&field)[i] = (byte)maxmath.bitmask(*((bool8*)ptr + i));
                }

                intern = field;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bits(NativeArray<bool> values, int index = 0)
        {
Assert.IsWithinArrayBounds(index + 7, values.Length);

            T field = default(T);
            byte* ptr = index + (byte*)values.GetUnsafePtr();

            for (int i = 0; i < sizeof(T); i++)
            {
                ((byte*)&field)[i] = (byte)maxmath.bitmask(*((bool8*)ptr + i));
            }

            intern = field;
        }


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


        public readonly int Length
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(0, 64)]
            get
            {
                return 8 * sizeof(T);
            }
        }

        private readonly ulong AsULong
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                T temp = intern;

                return *(ulong*)&temp;
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bits<U> Reinterpret<U>()
            where U : unmanaged
        {
Assert.AreEqual(sizeof(T), sizeof(U));

            T temp = intern;

            return *(bits<U>*)&temp;
        }


        public bool this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
Assert.IsWithinArrayBounds(index, Length);

                ulong result = (AsULong >> index) & 1ul;

                return *(bool*)&result;
            }
    
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsSafeBoolean(value);
Assert.IsWithinArrayBounds(index, Length);

                ulong mask = 1ul << index;
                ulong result = maxmath.andnot(AsULong, mask) | ((ulong)-*(byte*)&value & mask);

                intern = *(T*)&result;
            }
        }


        public readonly bool[] ToArray()
        {
            bool[] result = new bool[Length];
            T temp = intern;
            byte* internAddress = (byte*)&temp;

            fixed (void* ptr = &result[0])
            {
                for (int i = 0; i < sizeof(T); i++)
                {
                    *((bool8*)&temp + i) = maxmath.tobool8(*(internAddress + i));
                }
            }

            return result;
        }

        public readonly NativeArray<bool> ToArray(Allocator allocator)
        {
            NativeArray<bool> result = new NativeArray<bool>(Length, allocator, NativeArrayOptions.UninitializedMemory);

            void* ptr = result.GetUnsafePtr();
            T temp = intern;
            byte* internAddress = (byte*)&temp;

            for (int i = 0; i < sizeof(T); i++)
            {
                *((bool8*)&temp + i) = maxmath.tobool8(*((byte*)internAddress + i));
            }

            return result;
        }


        /// <summary>       The return value is undefined in case none of the bits are set to 1 (apart from the fact that it will be larger than the largest index of the array)        </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(0, 64)] 
        public readonly int IndexOfFirst()
        {
            return math.tzcnt(AsULong);
        }

        /// <summary>       The return value is undefined in case none of the bits are set to 1 (apart from the fact that it will be larger than the largest index of the array)        </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(0, 64)] 
        public readonly int IndexOfFirst(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return math.tzcnt(AsULong & (ulong)maxmath.bitmask64(numBits, index));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(-1, 63)] 
        public readonly int IndexOfLast()
        {
            return Length - 1 - math.lzcnt(AsULong & (ulong)maxmath.bitmask64(Length));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(-1, 63)] 
        public readonly int IndexOfLast(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return Length - 1 - math.lzcnt(AsULong & (ulong)maxmath.bitmask64(numBits, index));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ShiftLeft(int amount)
        {
            ulong shl = AsULong << amount;

            intern = *(T*)&shl;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ShiftLeft(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            ulong temp = AsULong;

            ulong mask = (ulong)maxmath.bitmask64(numBits, index);
            ulong maskED = mask & temp;

            maskED = maxmath.andnot(temp, mask) | (mask & (maskED << amount));

            intern = *(T*)&maskED;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ShiftRight(int amount)
        {
            ulong shr = AsULong >> amount;

            intern = *(T*)&shr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ShiftRight(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            ulong temp = AsULong;

            ulong mask = (ulong)maxmath.bitmask64(numBits, index);
            ulong maskED = mask & temp;

            maskED = maxmath.andnot(temp, mask) | (mask & (maskED >> amount));

            intern = *(T*)&maskED;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RotateLeft(int amount)
        {
            amount &= Length - 1;

            ulong masked = AsULong & (ulong)maxmath.bitmask64(Length);
            ulong rol = (masked << amount) | (masked >> (-amount & (Length - 1)));

            intern = *(T*)&rol;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RotateLeft(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            ulong temp = AsULong;

            ulong mask = (ulong)maxmath.bitmask64(numBits, index);
            ulong maskED = mask & temp;

            int remainder = amount % numBits;

            maskED = (mask & (maskED << remainder)) | (mask & (maskED >> (numBits - remainder)));

            maskED = maxmath.andnot(temp, mask) | maskED;


            intern = *(T*)&maskED;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RotateRight(int amount)
        {
            amount &= Length - 1;

            ulong masked = AsULong & (ulong)maxmath.bitmask64(Length);
            ulong ror = (masked >> amount) | (masked << (-amount & (Length - 1)));

            intern = *(T*)&ror;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RotateRight(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            ulong temp = AsULong;

            ulong mask = (ulong)maxmath.bitmask64(numBits, index);
            ulong maskED = mask & temp;

            int remainder = amount % numBits;

            maskED = (mask & (maskED >> remainder)) | (mask & (maskED << (numBits - remainder)));

            maskED = maxmath.andnot(temp, mask) | maskED;


            intern = *(T*)&maskED;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Swap(int smallerIndex, int largerIndex)
        {
Assert.IsWithinArrayBounds(smallerIndex, Length);
Assert.IsWithinArrayBounds(largerIndex, Length);

            ulong2 field = AsULong;
            ulong2 packed = (ulong2)new long2(smallerIndex, largerIndex);

            ulong2 result = 1 & maxmath.shrl(field, packed);
            result ^= result.yx;
            result = maxmath.shl(result, packed);

            result = field ^ (result | result.yx);


            intern = *(T*)&result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Swap(int smallerIndex, int largerIndex, int numBits)
        {
Assert.IsGreater(largerIndex, smallerIndex);
Assert.IsValidSubarray(smallerIndex, numBits, Length);
Assert.IsValidSubarray(largerIndex, numBits, Length);
Assert.SubarraysDoNotOverlap(smallerIndex, largerIndex, numBits, numBits);

            ulong temp = AsULong;

            // inlined bitmask
            // x: mask for lower subarray, y: mask for upper subarray, 
            ulong3 masks = maxmath.shl(ulong.MaxValue, new ulong3((ulong)smallerIndex, (ulong)largerIndex, 0ul));
            masks = maxmath.andnot(masks, masks << numBits);
            // z: mask for deleting elements in the array
            masks.z = ~(masks.x | masks.y);

            // delete in z, grab values in x & y
            masks &= temp;

            // swap positions; blend together
            int indexDelta = largerIndex - smallerIndex;
            temp = ((masks.z | (masks.x << indexDelta)) | (masks.y >> indexDelta));


            intern = *(T*)&temp;
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

            ulong2 invert = new ulong2((ulong)maxmath.bitmask64(numBits, index), AsULong);

            invert = maxmath.andnot(invert, invert.yx);

            invert = invert | invert.yx;

            intern = *(T*)&invert;
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reverse()
        {
            ulong reversed = math.reversebits(AsULong) >> (64 - Length);

            intern = *(T*)&reversed;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reverse(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = (ulong)maxmath.bitmask64(numBits, index);
            int shiftValue = math.mad(2, index,      numBits - Length);

            ulong temp = AsULong;

            temp = (mask & ((shiftValue < 0)
                           ? (math.reversebits(temp) >> (64 - Length)) >> math.abs(shiftValue)
                           : (math.reversebits(temp) >> (64 - Length)) << shiftValue))
                   |
                   maxmath.andnot(temp, mask);

            intern = *(T*)&temp;
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
        public void Shuffle(int index, int numBits, ref Random32 rngenerator)
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
        public void Randomize(int index, int numBits, ref Random64 rngenerator)
        {
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = (ulong)maxmath.bitmask64(numBits, index);

            mask = (rngenerator.NextULong() & mask) | maxmath.andnot(AsULong, mask);

            intern = *(T*)&mask;
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)] 
        public void SetBits(bool value)
        {
            this = new bits<T>(value);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)] 
        public void SetBits(int index, int numBits, bool value)
        {
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = (ulong)maxmath.bitmask64(numBits, index);

            mask = maxmath.andnot(AsULong, mask) | ((uint)-*(byte*)&value & mask);

            intern = *(T*)&mask;
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(0, 64)] 
        public readonly uint CountBits()
        {
            return (uint)math.countbits(AsULong & (ulong)maxmath.bitmask64(Length));
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(0, 64)] 
        public readonly uint CountBits(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return (uint)math.countbits(AsULong & (ulong)maxmath.bitmask64(numBits, index));
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAll()
        {
            ulong mask = (ulong)maxmath.bitmask64(Length);

            return mask == (AsULong & mask);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAll(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = (ulong)maxmath.bitmask64(numBits, index);

            return mask == (AsULong & mask);
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAny()
        {
            return 0ul != (AsULong & (ulong)maxmath.bitmask64(Length));
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAny(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return 0ul != (AsULong & (ulong)maxmath.bitmask64(numBits, index));
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestNone()
        {
            return 0ul == (AsULong & (ulong)maxmath.bitmask64(Length));
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestNone(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return 0ul == (AsULong & (ulong)maxmath.bitmask64(numBits, index));
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Overwrite(int index, int numBits, bit8 source, int sourceIndex)
        {
            OverwriteHelper((ulong)source.intern, source.Length, index, numBits, sourceIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Overwrite(int index, int numBits, bit16 source, int sourceIndex)
        {
            OverwriteHelper((ulong)source.intern, source.Length, index, numBits, sourceIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Overwrite(int index, int numBits, bit32 source, int sourceIndex)
        {
            OverwriteHelper((ulong)source.intern, source.Length, index, numBits, sourceIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Overwrite(int index, int numBits, bit64 source, int sourceIndex)
        {
            OverwriteHelper(source.intern, source.Length, index, numBits, sourceIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Overwrite<U>(int index, int numBits, bits<U> source, int sourceIndex)
            where U : unmanaged
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

            ulong temp = AsULong;

            temp = (shiftedSource & mask) | maxmath.andnot(temp, mask);

            intern = *(T*)&temp;
        }


        public override string ToString()
        {
            return Log.Bits(this);
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
            ulong masked = AsULong & (ulong)maxmath.bitmask64(Length);

            return (int)(masked ^ (masked >> 32));
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(bits<T> other)
        {
            ulong mask = (ulong)maxmath.bitmask64(Length);

            return (AsULong & mask) == (*(ulong*)&other & mask);
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