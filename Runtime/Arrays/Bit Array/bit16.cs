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
    unsafe public struct bit16 : IArray<bool>, IEquatable<bit16>
    {
        internal ushort intern;
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit16(ushort value)
        {
            intern = value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit16(short value)
        {
            intern = (ushort)value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit16(bool value)
        {
            intern = (ushort)(-maxmath.tosbyte(value));
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
Assert.IsValidSubarray(index, new bit16().Length, values.Length);

            intern = 0;

            for (int i = 0; i < 16; i++, index++)
            {
                this[i] = values[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit16(NativeArray<bool> values, int index = 0)
        {
Assert.IsValidSubarray(index, new bit16().Length, values.Length);

            intern = (ushort)maxmath.bitmask(*(bool16*)((bool*)values.GetUnsafeReadOnlyPtr() + index));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit16(NativeList<bool> values, int index = 0)
        {
Assert.IsValidSubarray(index, new bit16().Length, values.Length);
            
            intern = (ushort)maxmath.bitmask(*(bool16*)((bool*)values.GetUnsafeReadOnlyPtr() + index));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit16(NativeSlice<bool> values, int index = 0)
        {
Assert.IsValidSubarray(index, new bit16().Length, values.Length);
            
            intern = (ushort)maxmath.bitmask(*(bool16*)((bool*)values.GetUnsafeReadOnlyPtr() + index));
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit16(BitArray values, int index = 0)
        {
Assert.IsValidSubarray(index, new bit16().Length, values.Length);

            bit16 result = default(bit16);

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = values[i + index];
            }

            this = result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit16(NativeBitArray values, int index = 0)
        {
Assert.IsValidSubarray(index, new bit16().Length, values.Length);

            int bytes = maxmath.divrem(index, 8, out int bits);
            void* ptr = (byte*)values.GetUnsafePtr() + bytes;

            uint wider = *(uint*)ptr;
            wider >>= bits;

            intern = (ushort)wider;
        }


        public readonly int Length => 16;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator bit16(bool input)
        {
            return new bit16(input);
        }


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
            return new half { value = input.intern };
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit16(ushort input)
        {
            return new bit16 { intern = input };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit16(short input)
        {
            return new bit16 { intern = (ushort)input };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit16(half input)
        {
            return new bit16 { intern = input.value };
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
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit32(bit16 value)
        {
            return new bit32{ intern = value.intern };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit64(bit16 value)
        {
            return new bit64{ intern = value.intern };
        }


        public static explicit operator bit16(bit32 value)
        {
            return new bit16{ intern = (ushort)value.intern };
        }

        public static explicit operator bit16(bit64 value)
        {
            return new bit16{ intern = (ushort)value.intern };
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

                intern = (ushort)(maxmath.andnot(intern, mask) | ((uint)-*(byte*)&value & mask));
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

            *(bool16*)result.GetUnsafePtr() = maxmath.tobool16(intern);

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

            *(bit16*)result.GetUnsafePtr() = this;

            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyTo(bool[] array, int dstIndex, int numValues = 16, int srcIndex = 0)
        {
Assert.IsValidSubarray(dstIndex, numValues, array.Length);
Assert.IsValidSubarray(srcIndex, numValues, this.Length);

            while (srcIndex < numValues)
            {
                array[dstIndex++] = this[srcIndex++];
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyTo(NativeBitArray array, int dstIndex, int numValues = 16, int srcIndex = 0)
        {
Assert.IsValidSubarray(dstIndex, numValues, array.Length);
Assert.IsValidSubarray(srcIndex, numValues, this.Length);
            
            uint bytes = maxmath.divrem((uint)dstIndex, 8, out uint bits);
            ushort* ptr = (ushort*)((byte*)array.GetUnsafePtr() + bytes);
            
            if (Constant.IsConstantExpression(bits) && Constant.IsConstantExpression(numValues) && bits == 0)
            {
                switch (numValues)
                {
                    case 8:
                    {
                        *(byte*)ptr = (byte)(intern >> srcIndex);

                        return;
                    }
                    case 16:
                    {
                        *ptr = intern;

                        return;
                    }
                
                    default:
                    {
                        uint mask = (1u << numValues) - 1;

                        ushort _this = (ushort)((intern >> srcIndex) & mask);
                        ushort _array = (ushort)maxmath.andnot(*ptr, mask);

                        *ptr = (ushort)(_this | _array);
                        
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

                    *ptr = (ushort)(_array | _this);
                }
                else
                {
                    uint mask = maxmath.bitmask32((uint)numValues, bits);

                    uint _this = ((uint)intern >> srcIndex) << (int)bits;
                    uint _array = *(uint*)ptr;

                    _this = _this & mask;
                    _array = maxmath.andnot(_array, mask);

                    *(uint*)ptr = _array | _this;
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyTo(NativeArray<bool> array, int dstIndex, int numValues = 16, int srcIndex = 0)
        {
            CopyToArrayBase((bool*)array.GetUnsafePtr(), array.Length, dstIndex, numValues, srcIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyTo(NativeList<bool> array, int dstIndex, int numValues = 16, int srcIndex = 0)
        {
            CopyToArrayBase((bool*)array.GetUnsafePtr(), array.Length, dstIndex, numValues, srcIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyTo(NativeSlice<bool> array, int dstIndex, int numValues = 16, int srcIndex = 0)
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
                    case 16:
                    {
                        *(bool16*)ptr = maxmath.tobool16(intern); 
                        return;
                    }
                    case 15:
                    {
                        bool16 vector = maxmath.tobool16(intern >> srcIndex);

                        *(bool8*)ptr = vector.v8_0;
                        *(bool4*)(ptr +  8) = vector.v4_8;
                        *(bool3*)(ptr + 12) = vector.v3_12;

                        return;
                    }
                    case 14:
                    {
                        bool16 vector = maxmath.tobool16(intern >> srcIndex);

                        *(bool8*)ptr = vector.v8_0;
                        *(bool4*)(ptr +  8) = vector.v4_8;
                        *(bool2*)(ptr + 12) = vector.v2_12;

                        return;
                    }
                    case 13:
                    {
                        bool16 vector = maxmath.tobool16(intern >> srcIndex);

                        *(bool8*)ptr = vector.v8_0;
                        *(bool4*)(ptr +  8) = vector.v4_8;
                        *(bool*) (ptr + 12) = vector.x12;

                        return;
                    }
                    case 12:
                    {
                        bool16 vector = maxmath.tobool16(intern >> srcIndex);

                        *(bool8*)ptr = vector.v8_0;
                        *(bool4*)(ptr + 8) = vector.v4_8;

                        return;
                    }
                    case 11:
                    {
                        bool16 vector = maxmath.tobool16(intern >> srcIndex);

                        *(bool8*)ptr = vector.v8_0;
                        *(bool3*)(ptr + 8) = vector.v3_8;

                        return;
                    }
                    case 10:
                    {
                        bool16 vector = maxmath.tobool16(intern >> srcIndex);

                        *(bool8*)ptr = vector.v8_0;
                        *(bool2*)(ptr + 8) = vector.v2_8;

                        return;
                    }
                    case 9:
                    {
                        bool16 vector = maxmath.tobool16(intern >> srcIndex);

                        *(bool8*)ptr = vector.v8_0;
                        *(bool*)(ptr + 8) = vector.x8;

                        return;
                    }
                    case 8:
                    {
                        *(bool8*)ptr = maxmath.tobool8(intern >> srcIndex); 
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

                if (numValues == 16)
                {
                    *(bool16*)ptr = maxmath.tobool16((int)shifted);

                    return;
                }

                if (numValues >= 8)
                {
                    bool8* ptr8 = (bool8*)ptr;
                    
                    *ptr8 = maxmath.tobool8((int)shifted);
                    numValues -= 8;
                    shifted >>= 8;
                    ptr8++;

                    ptr = (bool*)ptr8;
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
                        *ptr = ((bit16)shifted)[0];

                        return;
                    }
                    default: return;
                }
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit8 Getbit8SubArray(int index)
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
        public readonly int IndexOfFirst(int index, int numBits)
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
        public readonly int IndexOfLast(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return 31 - math.lzcnt(intern & maxmath.bitmask32((uint)numBits, (uint)index));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ResetFirst()
        {
            intern = (ushort)maxmath.bits_resetlowest((uint)intern);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ResetFirst(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = maxmath.bitmask32((uint)numBits, (uint)index);
            uint reset = maxmath.bits_resetlowest((uint)intern & mask);
            uint remaining = maxmath.andnot(intern, mask);

            intern = (ushort)(reset | remaining);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetFirst()
        {
            // for X86, modulo 32/AND 31 is omitted, since it is performed in hardware when shifting anyway
            intern = (ushort)((uint)intern | (1u << (math.tzcnt(~(uint)intern) % 32)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetFirst(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            // for X86, modulo 32/AND 31 is omitted, since it is performed in hardware when shifting anyway
            uint mask = maxmath.bitmask32((uint)numBits, (uint)index);
            uint set = (uint)intern | (1u << (math.tzcnt(maxmath.andnot(mask, (uint)intern)) % 32));

            intern = (ushort)(maxmath.andnot((uint)intern, mask) | (set & mask));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ResetLast()
        {
            intern = (ushort)((uint)intern & (((uint)ushort.MaxValue >> 1) >> maxmath.lzcnt(intern)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ResetLast(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = maxmath.bitmask32((uint)numBits, (uint)index);
            uint reset = (uint)intern & (((uint)ushort.MaxValue >> 1) >> maxmath.lzcnt((ushort)(mask & intern)));
            uint remaining = maxmath.andnot(intern, mask);

            intern = (ushort)(reset | remaining);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetLast()
        {
            int leadingOnesCount = maxmath.lzcnt((ushort)(~(uint)intern));
            intern = (ushort)((uint)intern | (1u << ((Length - 1) - leadingOnesCount)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetLast(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = maxmath.bitmask32((uint)numBits, (uint)index);
            int leadingOnesCount = maxmath.lzcnt((ushort)maxmath.andnot(mask, (uint)intern));
            uint set = (uint)intern | (1u << ((Length - 1) - leadingOnesCount));

            intern = (ushort)(maxmath.andnot((uint)intern, mask) | (set & mask));
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

            intern = (ushort)(maxmath.andnot(intern, mask) | (mask & (maskED << amount)));
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

            intern = (ushort)(maxmath.andnot(intern, mask) | (mask & (maskED >> amount)));
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

            intern = (ushort)(maxmath.andnot(intern, mask) | maskED);
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

            maskED = mask & ((maskED >> remainder)   |   (maskED << (numBits - remainder)));

            intern = (ushort)(maxmath.andnot(intern, mask) | maskED);
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
 
            intern = (ushort)(intern ^ shifted);
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
 
            intern = (ushort)(intern ^ shifted);
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

            intern = (ushort)(intern ^ maxmath.bitmask32(numBits, index));
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
            int shiftValue = math.mad(2, index, numBits - Length);

            intern = (ushort)((mask & ((shiftValue < 0)
                                       ? maxmath.reversebits(intern) >> math.abs(shiftValue)
                                       : maxmath.reversebits(intern) << shiftValue))
                              |
                              maxmath.andnot(intern, mask));
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Shuffle(ref Random16 rngenerator)
        {
            if (X86.Bmi2.IsBmi2Supported)
            {
                uint mask = rngenerator.NextUShort();
                uint notMask = ~mask;

                uint lo = maxmath.bits_extractparallel(intern, mask);
                uint hi = maxmath.bits_extractparallel(intern, notMask);

                intern = (ushort)(lo | (hi << math.countbits(mask)));
            }
            else
            {
                for (int i = Length - 1, j = Length;     i > 0;     i--, j--)
                {
                    Swap(i, rngenerator.NextUShort((ushort)j));
                }
            }
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Shuffle(int index, int numBits, ref Random16 rngenerator)
        {
Assert.IsValidSubarray(index, numBits, Length);

            if (X86.Bmi2.IsBmi2Supported)
            {
                uint extractMask = rngenerator.NextUShort();
                uint shuffleMask = maxmath.bitmask32((uint)numBits, (uint)index);
                extractMask &= shuffleMask;
                uint notExtractMask = maxmath.andnot(shuffleMask, extractMask);

                uint lo = maxmath.bits_extractparallel(intern, extractMask);
                uint hi = maxmath.bits_extractparallel(intern, notExtractMask);

                intern = (ushort)(((lo | (hi << math.countbits(extractMask))) << index) | maxmath.andnot((uint)intern, shuffleMask));
            }
            else
            {
                int startingIndex = index + numBits;/* - 1 is actual starting index*/

                for (int i = startingIndex - 1; i > index; i--, startingIndex--)
                {
                    Swap(i, rngenerator.NextUShort((ushort)index, (ushort)startingIndex));
                }
            }
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Randomize(ref Random16 rngenerator)
        { 
            intern = (ushort)(rngenerator.NextUShort());
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Randomize(int index, int numBits, ref Random16 rngenerator)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)maxmath.bitmask32(numBits, index);
    
            intern = (ushort)((rngenerator.NextUShort() & mask)    |    maxmath.andnot(intern, mask));
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetBits(bool value)
        {
            this = new bit16(value);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetBits(int index, int numBits, bool value)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = (uint)maxmath.bitmask32(numBits, index);

            intern = (ushort)(maxmath.andnot(intern, mask) | ((uint)-*(byte*)&value & mask));
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(0, 16)] 
        public readonly uint CountBits()
        {
            return (uint)math.countbits((uint)intern);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(0, 16)] 
        public readonly uint CountBits(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return (uint)math.countbits(intern & maxmath.bitmask32(numBits, index));
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAll()
        {
            return intern == (uint)ushort.MaxValue;
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
            return intern != ushort.MaxValue;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestNotAll(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return (intern & maxmath.bitmask32(numBits, index)) != ushort.MaxValue;
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
            return Equals((bit16)obj);
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