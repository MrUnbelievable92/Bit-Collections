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
Assert.IsNotGreater(sizeof(T), 8);

            ulong temp = (ulong)(-maxmath.toint64(value));

            intern = *(T*)&temp;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bits(bool[] values, int index = 0)
        {
Assert.IsNotGreater(sizeof(T), 8);
Assert.IsWithinArrayBounds(index + (8 * sizeof(T) - 1), values.Length);

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
Assert.IsNotGreater(sizeof(T), 8);
Assert.IsWithinArrayBounds(index + (8 * sizeof(T) - 1), values.Length);

            T field = default(T);
            byte* ptr = index + (byte*)values.GetUnsafeReadOnlyPtr();

            for (int i = 0; i < sizeof(T); i++)
            {
                ((byte*)&field)[i] = (byte)maxmath.bitmask(*((bool8*)ptr + i));
            }

            intern = field;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator T(bits<T> input)
        {
Assert.IsNotGreater(sizeof(T), 8);

            return input.intern;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator bits<T>(T input)
        {
Assert.IsNotGreater(sizeof(T), 8);

            return new bits<T>(input);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bits<T> operator ! (bits<T> value)
        {
Assert.IsNotGreater(sizeof(T), 8);

            ulong temp = ~(value.AsULong);

            return *(bits<T>*)&temp;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bits<T> operator == (bits<T> left, bits<T> right)
        {
Assert.IsNotGreater(sizeof(T), 8);

            ulong temp = ~(left.AsULong ^ right.AsULong);

            return *(bits<T>*)&temp;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bits<T> operator != (bits<T> left, bits<T> right)
        {
Assert.IsNotGreater(sizeof(T), 8);

            ulong temp = left.AsULong ^ right.AsULong;

            return *(bits<T>*)&temp;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bits<T> operator & (bits<T> left, bits<T> right)
        {
Assert.IsNotGreater(sizeof(T), 8);

            ulong temp = left.AsULong & right.AsULong;

            return *(bits<T>*)&temp;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bits<T> operator | (bits<T> left, bits<T> right)
        {
Assert.IsNotGreater(sizeof(T), 8);

            ulong temp = left.AsULong | right.AsULong;

            return *(bits<T>*)&temp;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bits<T> operator ^ (bits<T> left, bits<T> right)
        {
Assert.IsNotGreater(sizeof(T), 8);

            ulong temp = left.AsULong ^ right.AsULong;

            return *(bits<T>*)&temp;
        }


        public readonly int Length
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(0, 64)]
            get
            {
Assert.IsNotGreater(sizeof(T), 8);

                return 8 * sizeof(T);
            }
        }

        private readonly ulong AsULong
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                T temp = intern;

                switch (sizeof(T))
                {
                    case 1:  return *(byte*)&temp;
                    case 2:  return *(ushort*)&temp;
                    case 3:  return *(UInt24*)&temp;
                    case 4:  return *(ushort*)&temp;
                    case 5:  return *(UInt40*)&temp;
                    case 6:  return *(UInt48*)&temp;
                    case 7:  return *(UInt56*)&temp;
                    default: return *(ulong*)&temp;
                }
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bits<U> Reinterpret<U>()
            where U : unmanaged
        {
Assert.IsNotGreater(sizeof(T), 8);
Assert.AreEqual(sizeof(T), sizeof(U));

            T temp = intern;

            return *(bits<U>*)&temp;
        }


        public bool this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
Assert.IsNotGreater(sizeof(T), 8);
Assert.IsWithinArrayBounds(index, Length);

                ulong result = (AsULong >> index) & 1ul;

                return *(bool*)&result;
            }
    
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsNotGreater(sizeof(T), 8);
Assert.IsSafeBoolean(value);
Assert.IsWithinArrayBounds(index, Length);

                ulong mask = 1ul << index;
                ulong result = maxmath.andnot(AsULong, mask) | ((ulong)-*(byte*)&value & mask);

                intern = *(T*)&result;
            }
        }


        public readonly bool[] ToArray()
        {
Assert.IsNotGreater(sizeof(T), 8);

            bool[] result = new bool[Length];
            T temp = intern;
            byte* internAddress = (byte*)&temp;

            fixed (void* ptr = &result[0])
            {
                switch (sizeof(T))
                {
                    case 1:
                    {
                        *(bool8*)ptr = maxmath.tobool8(*internAddress);
                        
                        return result;
                    }
                    case 2:
                    {
                        *(bool16*)ptr = maxmath.tobool16(*((ushort*)internAddress));
                        
                        return result;
                    }
                    case 3:
                    {
                        *(bool16*)ptr      = maxmath.tobool16(*((ushort*)internAddress));
                        *((bool8*)ptr + 2) = maxmath.tobool8(*(internAddress + 2));

                        return result;
                    }
                    case 4:
                    {
                        *(bool32*)ptr = maxmath.tobool32(*((int*)internAddress));

                        return result;
                    }
                    case 5:
                    {
                        *(bool32*)ptr      = maxmath.tobool32(*((int*)internAddress));
                        *((bool8*)ptr + 4) = maxmath.tobool8(*(internAddress + 4));
                        
                        return result;
                    }
                    case 6:
                    {
                        *(bool32*)ptr       = maxmath.tobool32(*((int*)internAddress));
                        *((bool16*)ptr + 2) = maxmath.tobool16(*((ushort*)internAddress + 2));
                        
                        return result;
                    }
                    case 7:
                    {
                        *(bool32*)ptr       = maxmath.tobool32(*((int*)internAddress));
                        *((bool16*)ptr + 2) = maxmath.tobool16(*((ushort*)internAddress + 2));
                        *((bool8*)ptr + 7)  = maxmath.tobool8(*(internAddress + 7));

                        return result;
                    }
                    case 8:
                    {
                        *(bool32*)ptr       = maxmath.tobool32(*((int*)internAddress));
                        *((bool32*)ptr + 1) = maxmath.tobool32(*((int*)internAddress + 1));

                        return result;
                    }
                    default: return result;
                }
            }
        }

        public readonly NativeArray<bool> ToArray(Allocator allocator)
        {
Assert.IsNotGreater(sizeof(T), 8);

            NativeArray<bool> result = new NativeArray<bool>(Length, allocator, NativeArrayOptions.UninitializedMemory);

            void* ptr = result.GetUnsafePtr();
            T temp = intern;
            byte* internAddress = (byte*)&temp;

            switch (sizeof(T))
            {
                case 1:
                {
                    *(bool8*)ptr = maxmath.tobool8(*internAddress);
                    
                    return result;
                }
                case 2:
                {
                    *(bool16*)ptr = maxmath.tobool16(*((ushort*)internAddress));
                    
                    return result;
                }
                case 3:
                {
                    *(bool16*)ptr      = maxmath.tobool16(*((ushort*)internAddress));
                    *((bool8*)ptr + 2) = maxmath.tobool8(*(internAddress + 2));

                    return result;
                }
                case 4:
                {
                    *(bool32*)ptr = maxmath.tobool32(*((int*)internAddress));

                    return result;
                }
                case 5:
                {
                    *(bool32*)ptr      = maxmath.tobool32(*((int*)internAddress));
                    *((bool8*)ptr + 4) = maxmath.tobool8(*(internAddress + 4));
                    
                    return result;
                }
                case 6:
                {
                    *(bool32*)ptr       = maxmath.tobool32(*((int*)internAddress));
                    *((bool16*)ptr + 2) = maxmath.tobool16(*((ushort*)internAddress + 2));
                    
                    return result;
                }
                case 7:
                {
                    *(bool32*)ptr       = maxmath.tobool32(*((int*)internAddress));
                    *((bool16*)ptr + 2) = maxmath.tobool16(*((ushort*)internAddress + 2));
                    *((bool8*)ptr + 7)  = maxmath.tobool8(*(internAddress + 7));

                    return result;
                }
                case 8:
                {
                    *(bool32*)ptr       = maxmath.tobool32(*((int*)internAddress));
                    *((bool32*)ptr + 1) = maxmath.tobool32(*((int*)internAddress + 1));

                    return result;
                }
                default: return result;
            }
        }


        /// <summary>       The return value is undefined in case none of the bits are set to 1 (apart from the fact that it will be larger than the largest index of the array)        </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(0, 64)] 
        public readonly int IndexOfFirst()
        {
Assert.IsNotGreater(sizeof(T), 8);

            return math.tzcnt(AsULong);
        }

        /// <summary>       The return value is undefined in case none of the bits are set to 1 (apart from the fact that it will be larger than the largest index of the array)        </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(0, 64)] 
        public readonly int IndexOfFirst(int index, int numBits)
        {
Assert.IsNotGreater(sizeof(T), 8);
Assert.IsValidSubarray(index, numBits, Length);

            return math.tzcnt(AsULong & (ulong)maxmath.bitmask64(numBits, index));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(-1, 63)] 
        public readonly int IndexOfLast()
        {
Assert.IsNotGreater(sizeof(T), 8);

            return Length - 1 - math.lzcnt(AsULong & (ulong)maxmath.bitmask64(Length));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(-1, 63)] 
        public readonly int IndexOfLast(int index, int numBits)
        {
Assert.IsNotGreater(sizeof(T), 8);
Assert.IsValidSubarray(index, numBits, Length);

            return Length - 1 - math.lzcnt(AsULong & (ulong)maxmath.bitmask64(numBits, index));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ShiftLeft(int amount)
        {
Assert.IsNotGreater(sizeof(T), 8);

            ulong shl = AsULong << amount;

            intern = *(T*)&shl;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ShiftLeft(int index, int numBits, int amount)
        {
Assert.IsNotGreater(sizeof(T), 8);
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
Assert.IsNotGreater(sizeof(T), 8);

            ulong shr = AsULong >> amount;

            intern = *(T*)&shr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ShiftRight(int index, int numBits, int amount)
        {
Assert.IsNotGreater(sizeof(T), 8);
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
Assert.IsNotGreater(sizeof(T), 8);

            amount &= Length - 1;

            ulong masked = AsULong & (ulong)maxmath.bitmask64(Length);
            ulong rol = (masked << amount) | (masked >> (-amount & (Length - 1)));

            intern = *(T*)&rol;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RotateLeft(int index, int numBits, int amount)
        {
Assert.IsNotGreater(sizeof(T), 8);
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            ulong temp = AsULong;

            ulong mask = (ulong)maxmath.bitmask64(numBits, index);
            ulong maskED = mask & temp;

            int remainder = amount % numBits;

            maskED = mask & ((maskED << remainder) | (maskED >> (numBits - remainder)));

            maskED = maxmath.andnot(temp, mask) | maskED;


            intern = *(T*)&maskED;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RotateRight(int amount)
        {
Assert.IsNotGreater(sizeof(T), 8);

            amount &= Length - 1;

            ulong masked = AsULong & (ulong)maxmath.bitmask64(Length);
            ulong ror = (masked >> amount) | (masked << (-amount & (Length - 1)));

            intern = *(T*)&ror;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RotateRight(int index, int numBits, int amount)
        {
Assert.IsNotGreater(sizeof(T), 8);
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            ulong temp = AsULong;

            ulong mask = (ulong)maxmath.bitmask64(numBits, index);
            ulong maskED = mask & temp;

            int remainder = amount % numBits;

            maskED = mask & ((maskED >> remainder) | (maskED << (numBits - remainder)));

            maskED = maxmath.andnot(temp, mask) | maskED;


            intern = *(T*)&maskED;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Swap(int smallerIndex, int largerIndex)
        {
Assert.IsNotGreater(sizeof(T), 8);
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
Assert.IsNotGreater(sizeof(T), 8);
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
            masks = maxmath.select(masks, ~(masks.xxx | masks.yyy), new bool3(false, false, true));

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
Assert.IsNotGreater(sizeof(T), 8);

            this = !this;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Flip(int index, int numBits)
        {
Assert.IsNotGreater(sizeof(T), 8);
Assert.IsValidSubarray(index, numBits, Length);

            ulong2 invert = new ulong2((ulong)maxmath.bitmask64(numBits, index), AsULong);

            invert = maxmath.andnot(invert, invert.yx);

            invert = invert | invert.yx;

            intern = *(T*)&invert;
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reverse()
        {
Assert.IsNotGreater(sizeof(T), 8);

            ulong reversed = math.reversebits(AsULong) >> (64 - Length);

            intern = *(T*)&reversed;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reverse(int index, int numBits)
        {
Assert.IsNotGreater(sizeof(T), 8);
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
        public void Shuffle(ref Random64 rngenerator)
        {
Assert.IsNotGreater(sizeof(T), 8);

            if (X86.Bmi2.IsBmi2Supported)
            {
                ulong mask = rngenerator.NextULong();
                ulong notMask = ~mask;
                ulong _intern = AsULong;

                ulong lo = maxmath.bits_extractparallel(_intern, mask);
                ulong hi = maxmath.bits_extractparallel(_intern, notMask);

                _intern = lo | (hi << math.countbits(mask));
                intern = *(T*)&_intern;
            }
            else
            {
                for (int i = Length - 1, j = Length;        i > 0;      i--, j--)
                {
                    Swap(i, (int)rngenerator.NextULong((uint)j));
                }
            }
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)] 
        public void Shuffle(int index, int numBits, ref Random64 rngenerator)
        {
Assert.IsNotGreater(sizeof(T), 8);
Assert.IsValidSubarray(index, numBits, Length);

            if (X86.Bmi2.IsBmi2Supported)
            {
                ulong extractMask = rngenerator.NextULong();
                ulong shuffleMask = maxmath.bitmask64((ulong)(uint)numBits, (ulong)(uint)index);
                extractMask &= shuffleMask;
                ulong notExtractMask = maxmath.andnot(shuffleMask, extractMask);

                ulong _intern = AsULong;

                ulong lo = maxmath.bits_extractparallel(_intern, extractMask);
                ulong hi = maxmath.bits_extractparallel(_intern, notExtractMask);

                _intern = ((lo | (hi << math.countbits(extractMask))) << index) | maxmath.andnot(_intern, shuffleMask);
                intern = *(T*)&_intern;
            }
            else
            {
                int startingIndex = index + numBits;/* - 1 is actual starting index*/

                for (int i = startingIndex - 1; i > index; i--, startingIndex--)
                {
                    Swap(i, (int)rngenerator.NextLong(index, startingIndex));
                }
            }
        }
    
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)] 
        public void Randomize(ref Random64 rngenerator)
        {
Assert.IsNotGreater(sizeof(T), 8);

            ulong newOne = rngenerator.NextULong();

            intern = *(T*)&newOne;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)] 
        public void Randomize(int index, int numBits, ref Random64 rngenerator)
        {
Assert.IsNotGreater(sizeof(T), 8);
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = (ulong)maxmath.bitmask64(numBits, index);

            mask = (rngenerator.NextULong() & mask) | maxmath.andnot(AsULong, mask);

            intern = *(T*)&mask;
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)] 
        public void SetBits(bool value)
        {
Assert.IsNotGreater(sizeof(T), 8);

            this = new bits<T>(value);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)] 
        public void SetBits(int index, int numBits, bool value)
        {
Assert.IsNotGreater(sizeof(T), 8);
Assert.IsValidSubarray(index, numBits, Length);

            if (Constant.IsConstantExpression(value) && Constant.IsConstantExpression(numBits) && Constant.IsConstantExpression(index) && value == false && index + numBits == Length)
            {
                ulong _intern = maxmath.bits_zerohigh(AsULong, index);

                intern = *(T*)&_intern;
            }
            else
            {
                ulong mask = (ulong)maxmath.bitmask64(numBits, index);

                mask = maxmath.andnot(AsULong, mask) | ((uint)-*(byte*)&value & mask);

                intern = *(T*)&mask;
            }
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(0, 64)] 
        public readonly uint CountBits()
        {
            return (uint)math.countbits(AsULong & (ulong)maxmath.bitmask64(Length));
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(0, 64)] 
        public readonly uint CountBits(int index, int numBits)
        {
Assert.IsNotGreater(sizeof(T), 8);
Assert.IsValidSubarray(index, numBits, Length);

            return (uint)math.countbits(AsULong & (ulong)maxmath.bitmask64(numBits, index));
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAll()
        {
Assert.IsNotGreater(sizeof(T), 8);

            ulong mask = (ulong)maxmath.bitmask64(Length);

            return mask == (AsULong & mask);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAll(int index, int numBits)
        {
Assert.IsNotGreater(sizeof(T), 8);
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = (ulong)maxmath.bitmask64(numBits, index);

            return mask == (AsULong & mask);
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAny()
        {
Assert.IsNotGreater(sizeof(T), 8);

            return 0ul != (AsULong & (ulong)maxmath.bitmask64(Length));
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAny(int index, int numBits)
        {
Assert.IsNotGreater(sizeof(T), 8);
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
Assert.IsNotGreater(sizeof(T), 8);
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
            OverwriteHelper(source.AsULong, source.Length, index, numBits, sourceIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void OverwriteHelper(ulong backingField, int sourceLength, int index, int numBits, int sourceIndex)
        {
Assert.IsNotGreater(sizeof(T), 8);
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
Assert.IsNotGreater(sizeof(T), 8);

            return Log.Bits(this);
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
Assert.IsNotGreater(sizeof(T), 8);

            if (sizeof(T) > 4)
            {
                ulong masked = AsULong & (ulong)maxmath.bitmask64(Length);

                return (int)(masked ^ (masked >> 32));
            }
            else
            {
                return (int)AsULong;
            }
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(bits<T> other)
        {
Assert.IsNotGreater(sizeof(T), 8);

            ulong mask = (ulong)maxmath.bitmask64(Length);

            return (AsULong & mask) == (other.AsULong & mask);
        }
        public override readonly bool Equals(object obj)
        {
            return Equals((bits<T>)obj);
        }
    
        public IEnumerator<bool> GetEnumerator()
        {
Assert.IsNotGreater(sizeof(T), 8);

            return new Enumerator<bool>(this);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
Assert.IsNotGreater(sizeof(T), 8);

            return new Enumerator<bool>(this);
        }
    }
}