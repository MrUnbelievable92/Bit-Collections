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
            intern = (uint)(-maxmath.tosbyte(value));
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
Assert.IsValidSubarray(index, new bit32().Length, values.Length);

            intern = 0;

            for (int i = 0; i < 32; i++, index++)
            {
                this[i] = values[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit32(NativeArray<bool> values, int index = 0)
        {
Assert.IsValidSubarray(index, new bit32().Length, values.Length);

            intern = (uint)maxmath.bitmask(*(bool32*)((bool*)values.GetUnsafeReadOnlyPtr() + index));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit32(NativeList<bool> values, int index = 0)
        {
Assert.IsValidSubarray(index, new bit32().Length, values.Length);
            
            intern = (uint)maxmath.bitmask(*(bool32*)((bool*)values.GetUnsafeReadOnlyPtr() + index));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit32(NativeSlice<bool> values, int index = 0)
        {
Assert.IsValidSubarray(index, new bit32().Length, values.Length);
            
            intern = (uint)maxmath.bitmask(*(bool32*)((bool*)values.GetUnsafeReadOnlyPtr() + index));
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit32(BitArray values, int index = 0)
        {
Assert.IsValidSubarray(index, new bit32().Length, values.Length);

            bit32 result = default(bit32);

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = values[i + index];
            }

            this = result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit32(NativeBitArray values, int index = 0)
        {
Assert.IsValidSubarray(index, new bit32().Length, values.Length);

            int bytes = maxmath.divrem(index, 8, out int bits);
            void* ptr = (byte*)values.GetUnsafePtr() + bytes;

            ulong wider = *(ulong*)ptr;
            wider >>= bits;

            intern = (uint)wider;
        }


        public readonly int Length => 32;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator bit32(bool input)
        {
            return new bit32(input);
        }


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

            *(bool32*)result.GetUnsafePtr() = maxmath.tobool32((int)intern);

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

            *(bit32*)result.GetUnsafePtr() = this;

            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyTo(bool[] array, int dstIndex, int numValues = 32, int srcIndex = 0)
        {
Assert.IsValidSubarray(dstIndex, numValues, array.Length);
Assert.IsValidSubarray(srcIndex, numValues, this.Length);

            while (srcIndex < numValues)
            {
                array[dstIndex++] = this[srcIndex++];
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyTo(NativeBitArray array, int dstIndex, int numValues = 32, int srcIndex = 0)
        {
Assert.IsValidSubarray(dstIndex, numValues, array.Length);
Assert.IsValidSubarray(srcIndex, numValues, this.Length);
            
            uint bytes = maxmath.divrem((uint)dstIndex, 8, out uint bits);
            uint* ptr = (uint*)((byte*)array.GetUnsafePtr() + bytes);
            
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
                        *(ushort*)ptr = (ushort)(intern >> srcIndex);

                        return;
                    }
                    case 24:
                    {
                        *(UInt24*)ptr = (UInt24)(intern >> srcIndex);
            
                        return;
                    }
                    case 32:
                    {
                        *ptr = intern;

                        return;
                    }
                
                    default:
                    {
                        uint mask = (1u << numValues) - 1;

                        uint _this = (intern >> srcIndex) & mask;
                        uint _array = maxmath.andnot(*ptr, mask);

                        *ptr = _this | _array;
                        
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

                    uint _this = (intern >> srcIndex) << (int)bits;
                    uint _array = *ptr;

                    _this = _this & mask;
                    _array = maxmath.andnot(_array, mask);

                    *ptr = _array | _this;
                }
                else
                {
                    ulong mask = maxmath.bitmask64((ulong)(uint)numValues, bits);

                    ulong _this = (ulong)(intern >> srcIndex) << (int)bits;
                    ulong _array = *(ulong*)ptr;

                    _this = _this & mask;
                    _array = maxmath.andnot(_array, mask);

                    *(ulong*)ptr = _array | _this;
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyTo(NativeArray<bool> array, int dstIndex, int numValues = 32, int srcIndex = 0)
        {
            CopyToArrayBase((bool*)array.GetUnsafePtr(), array.Length, dstIndex, numValues, srcIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyTo(NativeList<bool> array, int dstIndex, int numValues = 32, int srcIndex = 0)
        {
            CopyToArrayBase((bool*)array.GetUnsafePtr(), array.Length, dstIndex, numValues, srcIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyTo(NativeSlice<bool> array, int dstIndex, int numValues = 32, int srcIndex = 0)
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
                    case 32:
                    {
                        *(bool32*)ptr = maxmath.tobool32((int)intern); 
                        return;
                    }
                    case 31:
                    {
                        bool32 vector = maxmath.tobool32((int)(intern >> srcIndex));

                        *(bool16*)ptr = vector.v16_0;
                        *(bool8*)(ptr + 16) = vector.v8_16;
                        *(bool4*)(ptr + 24) = vector.v4_24;
                        *(bool3*)(ptr + 28) = vector.v3_28;

                        return;
                    }
                    case 30:
                    {
                        bool32 vector = maxmath.tobool32((int)(intern >> srcIndex));

                        *(bool16*)ptr = vector.v16_0;
                        *(bool8*)(ptr + 16) = vector.v8_16;
                        *(bool4*)(ptr + 24) = vector.v4_24;
                        *(bool2*)(ptr + 28) = vector.v2_28;

                        return;
                    }
                    case 29:
                    {
                        bool32 vector = maxmath.tobool32((int)(intern >> srcIndex));

                        *(bool16*)ptr = vector.v16_0;
                        *(bool8*)(ptr + 16) = vector.v8_16;
                        *(bool4*)(ptr + 24) = vector.v4_24;
                        *(bool*) (ptr + 28) = vector.x28;

                        return;
                    }
                    case 28:
                    {
                        bool32 vector = maxmath.tobool32((int)(intern >> srcIndex));

                        *(bool16*)ptr = vector.v16_0;
                        *(bool8*)(ptr + 16) = vector.v8_16;
                        *(bool4*)(ptr + 24) = vector.v4_24;

                        return;
                    }
                    case 27:
                    {
                        bool32 vector = maxmath.tobool32((int)(intern >> srcIndex));

                        *(bool16*)ptr = vector.v16_0;
                        *(bool8*)(ptr + 16) = vector.v8_16;
                        *(bool3*)(ptr + 24) = vector.v3_24;

                        return;
                    }
                    case 26:
                    {
                        bool32 vector = maxmath.tobool32((int)(intern >> srcIndex));

                        *(bool16*)ptr = vector.v16_0;
                        *(bool8*)(ptr + 16) = vector.v8_16;
                        *(bool2*)(ptr + 24) = vector.v2_24;

                        return;
                    }
                    case 25:
                    {
                        bool32 vector = maxmath.tobool32((int)(intern >> srcIndex));

                        *(bool16*)ptr = vector.v16_0;
                        *(bool8*)(ptr + 16) = vector.v8_16;
                        *(bool*) (ptr + 24) = vector.x24;

                        return;
                    }
                    case 24:
                    {
                        bool32 vector = maxmath.tobool32((int)(intern >> srcIndex));

                        *(bool16*)ptr = vector.v16_0;
                        *(bool8*)(ptr + 16) = vector.v8_16;

                        return;
                    }
                    case 23:
                    {
                        bool32 vector = maxmath.tobool32((int)(intern >> srcIndex));

                        *(bool16*)ptr = vector.v16_0;
                        *(bool4*)(ptr + 16) = vector.v4_16;
                        *(bool3*)(ptr + 20) = vector.v3_20;

                        return;
                    }
                    case 22:
                    {
                        bool32 vector = maxmath.tobool32((int)(intern >> srcIndex));

                        *(bool16*)ptr = vector.v16_0;
                        *(bool4*)(ptr + 16) = vector.v4_16;
                        *(bool2*)(ptr + 20) = vector.v2_20;

                        return;
                    }
                    case 21:
                    {
                        bool32 vector = maxmath.tobool32((int)(intern >> srcIndex));

                        *(bool16*)ptr = vector.v16_0;
                        *(bool4*)(ptr + 16) = vector.v4_16;
                        *(bool*) (ptr + 20) = vector.x20;

                        return;
                    }
                    case 20:
                    {
                        bool32 vector = maxmath.tobool32((int)(intern >> srcIndex));

                        *(bool16*)ptr = vector.v16_0;
                        *(bool4*)(ptr + 16) = vector.v4_16;

                        return;
                    }
                    case 19:
                    {
                        bool32 vector = maxmath.tobool32((int)(intern >> srcIndex));

                        *(bool16*)ptr = vector.v16_0;
                        *(bool3*)(ptr + 16) = vector.v3_16;

                        return;
                    }
                    case 18:
                    {
                        bool32 vector = maxmath.tobool32((int)(intern >> srcIndex));

                        *(bool16*)ptr = vector.v16_0;
                        *(bool2*)(ptr + 16) = vector.v2_16;

                        return;
                    }
                    case 17:
                    {
                        bool16 vector = maxmath.tobool16((int)(intern >> srcIndex));

                        *(bool16*)ptr = vector;
                        *(bool*)(ptr + 16) = this[16 + srcIndex];

                        return;
                    }
                    case 16:
                    {
                        *(bool16*)ptr = maxmath.tobool16((int)intern >> srcIndex); 
                        return;
                    }
                    case 15:
                    {
                        bool16 vector = maxmath.tobool16((int)(intern >> srcIndex));

                        *(bool8*)ptr = vector.v8_0;
                        *(bool4*)(ptr +  8) = vector.v4_8;
                        *(bool3*)(ptr + 12) = vector.v3_12;

                        return;
                    }
                    case 14:
                    {
                        bool16 vector = maxmath.tobool16((int)(intern >> srcIndex));

                        *(bool8*)ptr = vector.v8_0;
                        *(bool4*)(ptr +  8) = vector.v4_8;
                        *(bool2*)(ptr + 12) = vector.v2_12;

                        return;
                    }
                    case 13:
                    {
                        bool16 vector = maxmath.tobool16((int)(intern >> srcIndex));

                        *(bool8*)ptr = vector.v8_0;
                        *(bool4*)(ptr +  8) = vector.v4_8;
                        *(bool*) (ptr + 12) = vector.x12;

                        return;
                    }
                    case 12:
                    {
                        bool16 vector = maxmath.tobool16((int)(intern >> srcIndex));

                        *(bool8*)ptr = vector.v8_0;
                        *(bool4*)(ptr + 8) = vector.v4_8;

                        return;
                    }
                    case 11:
                    {
                        bool16 vector = maxmath.tobool16((int)(intern >> srcIndex));

                        *(bool8*)ptr = vector.v8_0;
                        *(bool3*)(ptr + 8) = vector.v3_8;

                        return;
                    }
                    case 10:
                    {
                        bool16 vector = maxmath.tobool16((int)(intern >> srcIndex));

                        *(bool8*)ptr = vector.v8_0;
                        *(bool2*)(ptr + 8) = vector.v2_8;

                        return;
                    }
                    case 9:
                    {
                        bool16 vector = maxmath.tobool16((int)(intern >> srcIndex));

                        *(bool8*)ptr = vector.v8_0;
                        *(bool*)(ptr + 8) = vector.x8;

                        return;
                    }
                    case 8:
                    {
                        *(bool8*)ptr = maxmath.tobool8((int)intern >> srcIndex); 
                        return;
                    }
                    case 7:
                    {
                        bool8 vector = maxmath.tobool8((int)(intern >> srcIndex));

                        *(bool4*)ptr = vector.v4_0;
                        *(bool3*)(ptr + 4) = vector.v3_4;

                        return;
                    }
                    case 6:
                    {
                        bool8 vector = maxmath.tobool8((int)(intern >> srcIndex));

                        *(bool4*)ptr = vector.v4_0;
                        *(bool2*)(ptr + 4) = vector.v2_4;

                        return;
                    }
                    case 5:
                    {
                        bool8 vector = maxmath.tobool8((int)(intern >> srcIndex));

                        *(bool4*)ptr = vector.v4_0;
                        *(bool*)(ptr + 4) = vector.x4;

                        return;
                    }
                    case 4:
                    {
                        *(bool4*)ptr = maxmath.tobool4((int)(intern >> srcIndex)); 
                        return;
                    }
                    case 3:
                    {
                        *(bool3*)ptr = maxmath.tobool3((int)(intern >> srcIndex)); 
                        return;
                    }
                    case 2:
                    {
                        *(bool2*)ptr = maxmath.tobool2((int)(intern >> srcIndex)); 
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
                uint shifted = intern >> srcIndex;

                if (numValues == 32)
                {
                    *(bool32*)ptr = maxmath.tobool32((int)shifted);

                    return;
                }

                if (numValues >= 16)
                {
                    bool16* ptr16 = (bool16*)ptr;
                    
                    *ptr16 = maxmath.tobool16((int)shifted);
                    numValues -= 16;
                    shifted >>= 16;
                    ptr16++;

                    ptr = (bool*)ptr16;
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
                        *ptr = ((bit32)shifted)[0];

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
        public void ResetFirst()
        {
            intern = maxmath.bits_resetlowest(intern);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ResetFirst(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = maxmath.bitmask32((uint)numBits, (uint)index);
            uint reset = maxmath.bits_resetlowest(intern & mask);
            uint remaining = maxmath.andnot(intern, mask);

            intern = reset | remaining;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetFirst()
        {
            // for X86, modulo 32/AND 31 is omitted, since it is performed in hardware when shifting anyway
            intern = intern | (1u << (math.tzcnt(~intern) % 32));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetFirst(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            // for X86, modulo 32/AND 31 is omitted, since it is performed in hardware when shifting anyway
            uint mask = maxmath.bitmask32((uint)numBits, (uint)index);
            uint set = intern | (1u << (math.tzcnt(maxmath.andnot(mask, intern)) % 32));

            intern = maxmath.andnot(intern, mask) | (set & mask);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ResetLast()
        {
            intern = intern & ((uint.MaxValue >> 1) >> math.lzcnt(intern));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ResetLast(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = maxmath.bitmask32((uint)numBits, (uint)index);
            uint reset = (intern & ((uint.MaxValue >> 1) >> math.lzcnt(mask & intern)));
            uint remaining = maxmath.andnot(intern, mask);

            intern = reset | remaining;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetLast()
        {
            int leadingOnesCount = math.lzcnt(~intern);
            intern = intern | (1u << ((Length - 1) - leadingOnesCount));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetLast(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            uint mask = maxmath.bitmask32((uint)numBits, (uint)index);
            int leadingOnesCount = math.lzcnt(maxmath.andnot(mask, intern));
            uint set = intern | (1u << ((Length - 1) - leadingOnesCount));

            intern = maxmath.andnot(intern, mask) | (set & mask);
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
            
            uint bit1 = maxmath.bits_extract(intern, smallerIndex, 1);
            uint bit2 = maxmath.bits_extract(intern, largerIndex, 1);
           
            uint swap = bit1 ^ bit2;
            uint shifted = (swap << smallerIndex) | (swap << largerIndex);
 
            intern ^= shifted;
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
 
            intern ^= shifted;
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

            intern ^= (uint)maxmath.bitmask32(numBits, index);
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
        public readonly bool TestNotAll()
        {
            return intern != uint.MaxValue;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestNotAll(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return (intern & (uint)maxmath.bitmask32(numBits, index)) != uint.MaxValue;
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