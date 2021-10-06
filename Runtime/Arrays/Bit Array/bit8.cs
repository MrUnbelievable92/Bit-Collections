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
            intern = (byte)(-maxmath.tosbyte(value));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit8(bool x0, bool x1, bool x2, bool x3, bool x4, bool x5, bool x6, bool x7)
        {
            intern = (byte)maxmath.bitmask(new bool8(x0, x1, x2, x3, x4, x5, x6, x7));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit8(bool[] values, int index = 0)
        {
Assert.IsValidSubarray(index, new bit8().Length, values.Length);

            intern = 0;

            for (int i = 0; i < 8; i++, index++)
            {
                this[i] = values[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit8(NativeArray<bool> values, int index = 0)
        {
Assert.IsValidSubarray(index, new bit8().Length, values.Length);

            intern = (byte)maxmath.bitmask(*(bool8*)((bool*)values.GetUnsafeReadOnlyPtr() + index));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit8(NativeList<bool> values, int index = 0)
        {
Assert.IsValidSubarray(index, new bit8().Length, values.Length);

            intern = (byte)maxmath.bitmask(*(bool8*)((bool*)values.GetUnsafeReadOnlyPtr() + index));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit8(NativeSlice<bool> values, int index = 0)
        {
Assert.IsValidSubarray(index, new bit8().Length, values.Length);

            intern = (byte)maxmath.bitmask(*(bool8*)((bool*)values.GetUnsafeReadOnlyPtr() + index));
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit8(BitArray values, int index = 0)
        {
Assert.IsValidSubarray(index, new bit8().Length, values.Length);

            bit8 result = default(bit8);

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = values[i + index];
            }

            this = result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit8(NativeBitArray values, int index = 0)
        {
Assert.IsValidSubarray(index, new bit8().Length, values.Length);

            int bytes = maxmath.divrem(index, 8, out int bits);
            void* ptr = (byte*)values.GetUnsafePtr() + bytes;

            ushort wider = *(ushort*)ptr;
            wider >>= bits;

            intern = (byte)wider;
        }


        public readonly int Length => 8;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator bit8(bool input)
        {
            return new bit8(input);
        }


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
        public static explicit operator quarter(bit8 input)
        {
            return *(quarter*)&input;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit8(byte input)
        {
            return new bit8 { intern = input };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit8(sbyte input)
        {
            return new bit8 { intern = (byte)input };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit8(quarter input)
        {
            return new bit8 { intern = input.value };
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
        public static explicit operator bit16(bit8 value)
        {
            return new bit16{ intern = value.intern };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit32(bit8 value)
        {
            return new bit32{ intern = value.intern };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit64(bit8 value)
        {
            return new bit64{ intern = value.intern };
        }


        public static explicit operator bit8(bit16 value)
        {
            return new bit8{ intern = (byte)value.intern };
        }

        public static explicit operator bit8(bit32 value)
        {
            return new bit8{ intern = (byte)value.intern };
        }

        public static explicit operator bit8(bit64 value)
        {
            return new bit8{ intern = (byte)value.intern };
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

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool[] ToArray()
        {
            bool[] result = new bool[Length];

            for (int i = 0; i < Length; i++)
            {
                result[i] = this[i];
            }

            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly NativeArray<bool> ToArray(Allocator allocator)
        {
            NativeArray<bool> result = new NativeArray<bool>(Length, allocator, NativeArrayOptions.UninitializedMemory);

            *(bool8*)result.GetUnsafePtr() = maxmath.tobool8(intern);

            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly BitArray ToBitArray()
        {
            BitArray result = new BitArray(Length);

            for (int i = 0; i < Length; i++)
            {
                result[i] = this[i];
            }

            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly NativeBitArray ToBitArray(Allocator allocator)
        {
            NativeBitArray result = new NativeBitArray(Length, allocator, NativeArrayOptions.UninitializedMemory);

            *(bit8*)result.GetUnsafePtr() = this;

            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyTo(bool[] array, int dstIndex, int numValues = 8, int srcIndex = 0)
        {
Assert.IsValidSubarray(dstIndex, numValues, array.Length);
Assert.IsValidSubarray(srcIndex, numValues, this.Length);

            while (srcIndex < numValues)
            {
                array[dstIndex++] = this[srcIndex++];
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyTo(NativeBitArray array, int dstIndex, int numValues = 8, int srcIndex = 0)
        {
Assert.IsValidSubarray(dstIndex, numValues, array.Length);
Assert.IsValidSubarray(srcIndex, numValues, this.Length);
            
            uint bytes = maxmath.divrem((uint)dstIndex, 8, out uint bits);
            byte* ptr = (byte*)array.GetUnsafePtr() + bytes;

            if (Constant.IsConstantExpression(bits) && Constant.IsConstantExpression(numValues) && bits == 0)
            {
                switch (numValues)
                {
                    case 8:
                    {
                        *ptr = intern;

                        return;
                    }
                
                    default:
                    {
                        uint mask = (1u << numValues) - 1;

                        byte _this = (byte)((intern >> srcIndex) & mask);
                        byte _array = (byte)maxmath.andnot(*ptr, mask);

                        *ptr = (byte)(_this | _array);
                        
                        return;
                    }
                }
            }
            else
            {
                if (Constant.IsConstantExpression(numValues) && 
                    Constant.IsConstantExpression(bits)      && 
                    numValues - (Length - (int)bits) <= 0)
                {
                    uint mask = maxmath.bitmask32((uint)numValues, bits);

                    uint _this = ((uint)intern >> srcIndex) << (int)bits;
                    uint _array = *ptr;

                    _this = _this & mask;
                    _array = maxmath.andnot(_array, mask);

                    *ptr = (byte)(_array | _this);
                }
                else
                {
                    uint mask = maxmath.bitmask32((uint)numValues, bits);
                    
                    uint _this = ((uint)intern >> srcIndex) << (int)bits;
                    uint _array = *(ushort*)ptr;

                    _this = _this & mask;
                    _array = maxmath.andnot(_array, mask);

                    *(ushort*)ptr = (ushort)(_array | _this);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyTo(NativeArray<bool> array, int dstIndex, int numValues = 8, int srcIndex = 0)
        {
            CopyToArrayBase((bool*)array.GetUnsafePtr(), array.Length, dstIndex, numValues, srcIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyTo(NativeList<bool> array, int dstIndex, int numValues = 8, int srcIndex = 0)
        {
            CopyToArrayBase((bool*)array.GetUnsafePtr(), array.Length, dstIndex, numValues, srcIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyTo(NativeSlice<bool> array, int dstIndex, int numValues = 8, int srcIndex = 0)
        {
            CopyToArrayBase((bool*)array.GetUnsafePtr(), array.Length, dstIndex, numValues, srcIndex);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private readonly void CopyToArrayBase(bool* array, int arrayLength, int dstIndex, int numValues, int srcIndex)
        {
Assert.IsValidSubarray(dstIndex, numValues, arrayLength);
Assert.IsValidSubarray(srcIndex, numValues, this.Length);
            
            bool* ptr = array + dstIndex; 

            if (Constant.IsConstantExpression(numValues))
            {
                switch (numValues)
                {
                    case 8:
                    {
                        *(bool8*)ptr = maxmath.tobool8(intern); 
                        return;
                    }
                    case 7:
                    {
                        bool8 vector = maxmath.tobool8(intern >> srcIndex);

                        *(bool4*)ptr = vector.v4_0;
                        *(bool3*)(ptr + 4) = vector.v3_4;

                        return;
                    }
                    case 6:
                    {
                        bool8 vector = maxmath.tobool8(intern >> srcIndex);

                        *(bool4*)ptr = vector.v4_0;
                        *(bool2*)(ptr + 4) = vector.v2_4;

                        return;
                    }
                    case 5:
                    {
                        bool8 vector = maxmath.tobool8(intern >> srcIndex);

                        *(bool4*)ptr = vector.v4_0;
                        *(bool*)(ptr + 4) = vector.x4;

                        return;
                    }
                    case 4:
                    {
                        *(bool4*)ptr = maxmath.tobool4(intern >> srcIndex); 
                        return;
                    }
                    case 3:
                    {
                        *(bool3*)ptr = maxmath.tobool3(intern >> srcIndex); 
                        return;
                    }
                    case 2:
                    {
                        *(bool2*)ptr = maxmath.tobool2(intern >> srcIndex); 
                        return;
                    }
                    case 1:
                    {
                        array[dstIndex] = this[srcIndex];
                        return;
                    }
                    default: return;
                }
            }
            else
            {
                uint shifted = (uint)(intern >> srcIndex);

                if (numValues == 8)
                {
                    *(bool8*)ptr = maxmath.tobool8((int)shifted);

                    return;
                }

                if (numValues >= 4)
                {
                    bool4* ptr4 = (bool4*)ptr;
                    
                    *ptr4 = maxmath.tobool4((int)shifted);
                    numValues -= 4;
                    shifted >>= 4;
                    ptr4++;

                    ptr = (bool*)ptr4;
                }
                
                switch (numValues)
                {
                    case 3:
                    {
                        *(bool3*)ptr = maxmath.tobool3((int)shifted);

                        return;
                    }
                    case 2:
                    {
                        *(bool2*)ptr = maxmath.tobool2((int)shifted);

                        return;
                    }
                    case 1:
                    {
                        *ptr = ((bit8)shifted)[0];

                        return;
                    }
                    default: return;
                }
            }
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
        public void ResetFirst()
        {
            intern = (byte)maxmath.bits_resetlowest((uint)intern);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ResetFirst(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = maxmath.bitmask32((uint)numBits, (uint)index);
            uint reset = maxmath.bits_resetlowest((uint)intern & mask);
            uint remaining = maxmath.andnot(intern, mask);

            intern = (byte)(reset | remaining);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetFirst()
        {
            // for X86, modulo 32/AND 31 is omitted, since it is performed in hardware when shifting anyway
            intern = (byte)((uint)intern | (1u << (math.tzcnt(~(uint)intern) % 32)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetFirst(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            // for X86, modulo 32/AND 31 is omitted, since it is performed in hardware when shifting anyway
            uint mask = maxmath.bitmask32((uint)numBits, (uint)index);
            uint set = (uint)intern | (1u << (math.tzcnt(maxmath.andnot(mask, (uint)intern)) % 32));

            intern = (byte)(maxmath.andnot((uint)intern, mask) | (set & mask));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ResetLast()
        {
            intern = (byte)((uint)intern & (((uint)byte.MaxValue >> 1) >> maxmath.lzcnt(intern)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ResetLast(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = maxmath.bitmask32((uint)numBits, (uint)index);
            uint reset = (uint)intern & (((uint)byte.MaxValue >> 1) >> maxmath.lzcnt((byte)(mask & intern)));
            uint remaining = maxmath.andnot(intern, mask);

            intern = (byte)(reset | remaining);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetLast()
        {
            int leadingOnesCount = maxmath.lzcnt((byte)(~(uint)intern));
            intern = (byte)((uint)intern | (1u << ((Length - 1) - leadingOnesCount)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetLast(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = maxmath.bitmask32((uint)numBits, (uint)index);
            int leadingOnesCount = maxmath.lzcnt((byte)maxmath.andnot(mask, (uint)intern));
            uint set = (uint)intern | (1u << ((Length - 1) - leadingOnesCount));

            intern = (byte)(maxmath.andnot((uint)intern, mask) | (set & mask));
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

            maskED = mask & ((maskED << remainder) | (maskED >> (numBits - remainder)));

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

            maskED = mask & ((maskED >> remainder) | (maskED << (numBits - remainder)));

            intern = (byte)(maxmath.andnot(intern, mask) | maskED);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Swap(int smallerIndex, int largerIndex)
        {
Assert.IsWithinArrayBounds(smallerIndex, Length);
Assert.IsWithinArrayBounds(largerIndex, Length);
            
            uint bit1 = maxmath.bits_extract((uint)intern, smallerIndex, 1);
            uint bit2 = maxmath.bits_extract((uint)intern, largerIndex, 1);
           
            uint swap = bit1 ^ bit2;
            uint shifted = (swap << smallerIndex) | (swap << largerIndex);
 
            intern = (byte)(intern ^ shifted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Swap(int smallerIndex, int largerIndex, int numBits)
        {
Assert.IsGreater(largerIndex, smallerIndex);
Assert.IsValidSubarray(smallerIndex, numBits, Length);
Assert.IsValidSubarray(largerIndex, numBits, Length);
Assert.SubarraysDoNotOverlap(smallerIndex, largerIndex, numBits, numBits);

            uint bits1 = (uint)maxmath.bits_extract(intern, smallerIndex, numBits);
            uint bits2 = (uint)maxmath.bits_extract(intern, largerIndex, numBits);
           
            uint swap = bits1 ^ bits2;
            uint shifted = (swap << smallerIndex) | (swap << largerIndex);
 
            intern = (byte)(intern ^ shifted);
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

            intern = (byte)(intern ^ maxmath.bitmask32(numBits, index));
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
        public void Shuffle(ref Random8 rngenerator)
        {
            if (X86.Bmi2.IsBmi2Supported)
            {
                uint mask = rngenerator.NextByte();
                uint notMask = ~mask;

                uint lo = maxmath.bits_extractparallel(intern, mask);
                uint hi = maxmath.bits_extractparallel(intern, notMask);

                intern = (byte)(lo | (hi << math.countbits(mask)));
            }
            else
            {
                for (int i = Length - 1, j = Length;    i > 0;      i--, j--)
                {
                    Swap(i, rngenerator.NextByte((byte)j));
                }
            }
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Shuffle(int index, int numBits, ref Random8 rngenerator)
        {
Assert.IsValidSubarray(index, numBits, Length);

            if (X86.Bmi2.IsBmi2Supported)
            {
                uint extractMask = rngenerator.NextByte();
                uint shuffleMask = maxmath.bitmask32((uint)numBits, (uint)index);
                extractMask &= shuffleMask;
                uint notExtractMask = maxmath.andnot(shuffleMask, extractMask);

                uint lo = maxmath.bits_extractparallel(intern, extractMask);
                uint hi = maxmath.bits_extractparallel(intern, notExtractMask);

                intern = (byte)(((lo | (hi << math.countbits(extractMask))) << index) | maxmath.andnot((uint)intern, shuffleMask));
            }
            else
            {
                int startingIndex = index + numBits;/* - 1 is actual starting index*/

                for (int i = startingIndex - 1;     i > index;      i--, startingIndex--)
                {
                    Swap(i, rngenerator.NextByte((byte)index, (byte)startingIndex));
                }
            }
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Randomize(ref Random8 rngenerator)
        {
            intern = (byte)(rngenerator.NextByte());
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Randomize(int index, int numBits, ref Random8 rngenerator)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)maxmath.bitmask32(numBits, index);
    
            intern = (byte)((rngenerator.NextByte() & mask)    |    maxmath.andnot(intern, mask));
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
        public readonly bool TestNotAll()
        {
            return intern != byte.MaxValue;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestNotAll(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return (intern & maxmath.bitmask32(numBits, index)) != byte.MaxValue;
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
            OverwriteHelper(source.AsULong, source.Length, index, numBits, sourceIndex);
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
    

        public override readonly string ToString()
        {
            return Dump.Bits(this);
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
    
        public readonly IEnumerator<bool> GetEnumerator()
        {
            return new ArrayEnumerator<bool>(this);
        }
        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<bool>(this);
        }
    }
}