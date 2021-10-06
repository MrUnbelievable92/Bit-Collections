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

            ulong temp = (ulong)(-maxmath.tolong(value));

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
        private static bits<T> FromNativeArrayBase(void* ptr, int index, int length)
        {
Assert.IsNotGreater(sizeof(T), 8);
Assert.IsWithinArrayBounds(index + (8 * sizeof(T) - 1), length);

            T field = default(T);
            int bytes = sizeof(T);
            byte* fieldPtr = (byte*)&field;

            while (bytes >= 4)
            {
                *(int*)fieldPtr = maxmath.bitmask(*(bool32*)ptr);

                ptr = (byte*)ptr + 32;
                fieldPtr += 4;
                bytes -= 4;
            }

            if (bytes >= 2)
            {
                *(ushort*)fieldPtr = (ushort)maxmath.bitmask(*(bool16*)ptr);

                ptr = (byte*)ptr + 16;
                fieldPtr += 2;
                bytes -= 2;
            }

            if (bytes != 0)
            {
                *fieldPtr = (byte)maxmath.bitmask(*(bool8*)ptr);
            }


            return new bits<T>(field);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bits(NativeArray<bool> values, int index = 0)
        {
            this = FromNativeArrayBase(values.GetUnsafePtr(), index, values.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bits(NativeList<bool> values, int index = 0)
        {
            this = FromNativeArrayBase(values.GetUnsafePtr(), index, values.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bits(NativeSlice<bool> values, int index = 0)
        {
            this = FromNativeArrayBase(values.GetUnsafePtr(), index, values.Length);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bits(BitArray values, int index = 0)
        {
Assert.IsNotGreater(sizeof(T), 8);
Assert.IsValidSubarray(index, new bits<T>().Length, values.Length);

            bits<T> result = default(bits<T>);

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = values[i + index];
            }

            this = result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bits(NativeBitArray values, int index = 0)
        {
Assert.IsNotGreater(sizeof(T), 8);
Assert.IsValidSubarray(index, new bits<T>().Length, values.Length);

            switch (sizeof(T))
            {
                case 1:
                {
                    this = (bits<T>)new bit8(values, index);

                    return;
                }
                case 2:
                {
                    this = (bits<T>)new bit16(values, index);

                    return;
                }
                case 3:
                {
                    if (Constant.IsConstantExpression(index) && index % 8 == 0)
                    {
                        this = *(bits<T>*)((byte*)values.GetUnsafePtr() + (index / 8));
                    }
                    else
                    {
                        ushort lo = new bit16(values, index).intern;
                        byte hi = new bit8(values, index + 16).intern;
                        UInt24 combi = (UInt24)(lo | (hi << 16));

                        this = *(bits<T>*)&combi;
                    }

                    return;
                }
                case 4:
                {
                    this = (bits<T>)new bit32(values, index);

                    return;
                }
                case 5:
                {
                    if (Constant.IsConstantExpression(index) && index % 8 == 0)
                    {
                        this = *(bits<T>*)((byte*)values.GetUnsafePtr() + (index / 8));
                    }
                    else
                    {
                        uint lo = new bit32(values, index).intern;
                        byte hi = new bit8(values, index + 32).intern;
                        UInt40 combi = (UInt40)(lo | ((ulong)hi << 32));

                        this = *(bits<T>*)&combi;
                    }

                    return;
                }
                case 6:
                {
                    if (Constant.IsConstantExpression(index) && index % 8 == 0)
                    {
                        this = *(bits<T>*)((byte*)values.GetUnsafePtr() + (index / 8));
                    }
                    else
                    {
                        uint lo = new bit32(values, index).intern;
                        ushort hi = new bit16(values, index + 32).intern;
                        UInt48 combi = (UInt48)(lo | ((ulong)hi << 32));

                        this = *(bits<T>*)&combi;
                    }

                    return;
                }
                case 7:
                {
                    if (Constant.IsConstantExpression(index) && index % 8 == 0)
                    {
                        this = *(bits<T>*)((byte*)values.GetUnsafePtr() + (index / 8));
                    }
                    else
                    {
                        uint lo = new bit32(values, index).intern;
                        ushort mid = new bit16(values, index + 32).intern;
                        byte hi = new bit8(values, index + 48).intern;
                        UInt56 combi = (UInt56)(lo | ((ulong)mid << 32) | ((ulong)hi << 48));

                        this = *(bits<T>*)&combi;
                    }

                    return;
                }
                case 8:
                {
                    this = (bits<T>)new bit64(values, index);

                    return;
                }

                default: 
                { 
                    this = default(bits<T>); 

                    return;
                }
            }
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

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit8(bits<T> value)
        {
Assert.IsNotGreater(sizeof(T), 8);

            return *(bit8*)&value; 
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit16(bits<T> value)
        {
Assert.IsNotGreater(sizeof(T), 8);

            return sizeof(T) switch
            {
                1 => new bit16{ intern = *(byte*)&value},
                2 => *(bit16*)&value,

                _ => default(bit16)
            };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit32(bits<T> value)
        {
Assert.IsNotGreater(sizeof(T), 8);

            return sizeof(T) switch
            {
                1 => new bit32{ intern = *(byte*)&value},
                2 => new bit32{ intern = *(ushort*)&value},
                3 => new bit32{ intern = *(UInt24*)&value},
                4 => *(bit32*)&value,

                _ => default(bit32)
            }; 
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit64(bits<T> value)
        {
Assert.IsNotGreater(sizeof(T), 8);
            
            return sizeof(T) switch
            {
                1 => new bit64{ intern = *(byte*)&value},
                2 => new bit64{ intern = *(ushort*)&value},
                3 => new bit64{ intern = *(UInt24*)&value},
                4 => new bit64{ intern = *(uint*)&value},
                5 => new bit64{ intern = *(UInt40*)&value},
                6 => new bit64{ intern = *(UInt48*)&value},
                7 => new bit64{ intern = *(UInt56*)&value},
                8 => *(bit64*)&value,

                _ => default(bit64)
            }; 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bits<T>(bit8 value)
        {
Assert.IsNotGreater(sizeof(T), 8);

            ulong field = value.intern;

            return *(bits<T>*)&field;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bits<T>(bit16 value)
        {
Assert.IsNotGreater(sizeof(T), 8);

            ulong field = value.intern;

            return *(bits<T>*)&field;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bits<T>(bit32 value)
        {
Assert.IsNotGreater(sizeof(T), 8);

            ulong field = value.intern;

            return *(bits<T>*)&field;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bits<T>(bit64 value)
        {
Assert.IsNotGreater(sizeof(T), 8);

            ulong field = value.intern;

            return *(bits<T>*)&field;
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

        internal readonly ulong AsULong
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
                    *((bool8*)ptr + 6)  = maxmath.tobool8(*(internAddress + 6));

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

            *(bits<T>*)result.GetUnsafePtr() = this;

            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyTo(bool[] array, int dstIndex, int numValues = 64, int srcIndex = 0)
        {
Assert.IsValidSubarray(dstIndex, numValues, array.Length);
Assert.IsValidSubarray(srcIndex, numValues, this.Length);
            
            numValues = numValues == 64 ? Length : numValues;

            while (srcIndex < numValues)
            {
                array[dstIndex++] = this[srcIndex++];
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyTo(NativeBitArray array, int dstIndex, int numValues = 64, int srcIndex = 0)
        {
Assert.IsValidSubarray(dstIndex, numValues, array.Length);
Assert.IsValidSubarray(srcIndex, numValues, this.Length);

            numValues = numValues == 64 ? Length : numValues;

            uint bytes = maxmath.divrem((uint)dstIndex, 8, out uint bits);
            ulong* ptr = (ulong*)((byte*)array.GetUnsafePtr() + bytes);
            
            if (Constant.IsConstantExpression(bits) && Constant.IsConstantExpression(numValues) && bits == 0)
            {
                switch (numValues)
                {
                    case 8:
                    {
                        *(byte*)ptr = (byte)(AsULong >> srcIndex);
            
                        return;
                    }
                    case 16:
                    {
                        *(ushort*)ptr = (ushort)(AsULong >> srcIndex);
            
                        return;
                    }
                    case 24:
                    {
                        *(UInt24*)ptr = (UInt24)(AsULong >> srcIndex);
            
                        return;
                    }
                    case 32:
                    {
                        *(uint*)ptr = (uint)(AsULong >> srcIndex);
            
                        return;
                    }
                    case 40:
                    {
                        *(UInt40*)ptr = (UInt40)(AsULong >> srcIndex);
            
                        return;
                    }
                    case 48:
                    {
                        *(UInt48*)ptr = (UInt48)(AsULong >> srcIndex);
            
                        return;
                    }
                    case 56:
                    {
                        *(UInt56*)ptr = (UInt56)(AsULong >> srcIndex);
            
                        return;
                    }
                    case 64:
                    {
                        *ptr = AsULong;
            
                        return;
                    }
                
                    default:
                    {
                        ulong mask = (1ul << numValues) - 1;
            
                        ulong _this = (AsULong >> srcIndex) & mask;
                        ulong _array = maxmath.andnot(*ptr, mask);
            
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
                    ulong mask = maxmath.bitmask64((ulong)(uint)numValues, bits);

                    ulong _this = (AsULong >> srcIndex) << (int)bits;
                    ulong _array = *ptr;

                    _this = _this & mask;
                    _array = maxmath.andnot(_array, mask);

                    *ptr = _array | _this;
                }
                else
                {
                    ulong mask_lo = maxmath.bitmask64((ulong)(uint)numValues);
                    ulong2 mask = (bits == 0) ? new ulong2(mask_lo, 0) : new ulong2(mask_lo << (int)bits, mask_lo >> (64 - (int)bits));  
                    
                    ulong _this_lo = AsULong >> srcIndex;
                    ulong2 _this = (bits == 0) ? new ulong2(_this_lo, 0) : new ulong2(_this_lo << (int)bits, _this_lo >> (64 - (int)bits));

                    ulong2 _array = *(ulong2*)ptr;
                    
                    _this = _this & mask;
                    _array = maxmath.andnot(_array, mask);
                    
                    *(ulong2*)ptr = _array | _this;
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyTo(NativeArray<bool> array, int dstIndex, int numValues = int.MaxValue, int srcIndex = 0)
        {
            CopyToArrayBase((bool*)array.GetUnsafePtr(), array.Length, dstIndex, numValues, srcIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyTo(NativeList<bool> array, int dstIndex, int numValues = int.MaxValue, int srcIndex = 0)
        {
            CopyToArrayBase((bool*)array.GetUnsafePtr(), array.Length, dstIndex, numValues, srcIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyTo(NativeSlice<bool> array, int dstIndex, int numValues = int.MaxValue, int srcIndex = 0)
        {
            CopyToArrayBase((bool*)array.GetUnsafePtr(), array.Length, dstIndex, numValues, srcIndex);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private readonly void CopyToArrayBase(bool* array, int arrayLength, int dstIndex, int numValues, int srcIndex)
        {
            numValues = (numValues == int.MaxValue) ? Length : numValues;
            
Assert.IsNotGreater(sizeof(T), 8);
Assert.IsValidSubarray(dstIndex, numValues, arrayLength);
Assert.IsValidSubarray(srcIndex, numValues, this.Length);
            
            ulong temp = AsULong;
            bool* ptr = array + dstIndex; 

            if (Constant.IsConstantExpression(numValues))
            {
                switch (numValues)
                {
                    case 64:
                    {
                        *(bool32*)(ptr)      = maxmath.tobool32((int)temp);
                        *(bool32*)(ptr + 32) = maxmath.tobool32((int)(temp >> 32)); 
                        return;
                    }
                    case 63:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(temp >> srcIndex));
                        bool32 vector_hi = maxmath.tobool32((int)(temp >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool16*)(ptr + 32) = vector_hi.v16_0;
                        *(bool8*)(ptr + 48) = vector_hi.v8_16;
                        *(bool4*)(ptr + 56) = vector_hi.v4_24;
                        *(bool3*)(ptr + 60) = vector_hi.v3_28;

                        return;
                    }
                    case 62:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(temp >> srcIndex));
                        bool32 vector_hi = maxmath.tobool32((int)(temp >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool16*)(ptr + 32) = vector_hi.v16_0;
                        *(bool8*)(ptr + 48) = vector_hi.v8_16;
                        *(bool4*)(ptr + 56) = vector_hi.v4_24;
                        *(bool2*)(ptr + 60) = vector_hi.v2_28;

                        return;
                    }
                    case 61:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(temp >> srcIndex));
                        bool32 vector_hi = maxmath.tobool32((int)(temp >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool16*)(ptr + 32) = vector_hi.v16_0;
                        *(bool8*)(ptr + 48) = vector_hi.v8_16;
                        *(bool4*)(ptr + 56) = vector_hi.v4_24;
                        *(bool*) (ptr + 60) = vector_hi.x28;

                        return;
                    }
                    case 60:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(temp >> srcIndex));
                        bool32 vector_hi = maxmath.tobool32((int)(temp >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool16*)(ptr + 32) = vector_hi.v16_0;
                        *(bool8*)(ptr + 48) = vector_hi.v8_16;
                        *(bool4*)(ptr + 56) = vector_hi.v4_24;

                        return;
                    }
                    case 59:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(temp >> srcIndex));
                        bool32 vector_hi = maxmath.tobool32((int)(temp >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool16*)(ptr + 32) = vector_hi.v16_0;
                        *(bool8*)(ptr + 48) = vector_hi.v8_16;
                        *(bool3*)(ptr + 56) = vector_hi.v3_24;

                        return;
                    }
                    case 58:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(temp >> srcIndex));
                        bool32 vector_hi = maxmath.tobool32((int)(temp >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool16*)(ptr + 32) = vector_hi.v16_0;
                        *(bool8*)(ptr + 48) = vector_hi.v8_16;
                        *(bool2*)(ptr + 56) = vector_hi.v2_24;

                        return;
                    }
                    case 57:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(temp >> srcIndex));
                        bool32 vector_hi = maxmath.tobool32((int)(temp >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool16*)(ptr + 32) = vector_hi.v16_0;
                        *(bool8*)(ptr + 48) = vector_hi.v8_16;
                        *(bool*) (ptr + 56) = vector_hi.x24;

                        return;
                    }
                    case 56:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(temp >> srcIndex));
                        bool32 vector_hi = maxmath.tobool32((int)(temp >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool16*)(ptr + 32) = vector_hi.v16_0;
                        *(bool8*)(ptr + 48) = vector_hi.v8_16;

                        return;
                    }
                    case 55:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(temp >> srcIndex));
                        bool32 vector_hi = maxmath.tobool32((int)(temp >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool16*)(ptr + 32) = vector_hi.v16_0;
                        *(bool4*)(ptr + 48) = vector_hi.v4_16;
                        *(bool3*)(ptr + 52) = vector_hi.v3_20;

                        return;
                    }
                    case 54:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(temp >> srcIndex));
                        bool32 vector_hi = maxmath.tobool32((int)(temp >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool16*)(ptr + 32) = vector_hi.v16_0;
                        *(bool4*)(ptr + 48) = vector_hi.v4_16;
                        *(bool2*)(ptr + 52) = vector_hi.v2_20;

                        return;
                    }
                    case 53:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(temp >> srcIndex));
                        bool32 vector_hi = maxmath.tobool32((int)(temp >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool16*)(ptr + 32) = vector_hi.v16_0;
                        *(bool4*)(ptr + 48) = vector_hi.v4_16;
                        *(bool*) (ptr + 52) = vector_hi.x20;

                        return;
                    }
                    case 52:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(temp >> srcIndex));
                        bool32 vector_hi = maxmath.tobool32((int)(temp >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool16*)(ptr + 32) = vector_hi.v16_0;
                        *(bool4*)(ptr + 48) = vector_hi.v4_16;

                        return;
                    }
                    case 51:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(temp >> srcIndex));
                        bool32 vector_hi = maxmath.tobool32((int)(temp >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool16*)(ptr + 32) = vector_hi.v16_0;
                        *(bool3*)(ptr + 48) = vector_hi.v3_16;

                        return;
                    }
                    case 50:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(temp >> srcIndex));
                        bool32 vector_hi = maxmath.tobool32((int)(temp >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool16*)(ptr + 32) = vector_hi.v16_0;
                        *(bool2*)(ptr + 48) = vector_hi.v2_16;

                        return;
                    }
                    case 49:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(temp >> srcIndex));
                        bool16 vector_hi = maxmath.tobool16((int)(temp >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool16*)(ptr + 32) = vector_hi;
                        *(bool*)(ptr + 48) = this[48 + srcIndex];

                        return;
                    }
                    case 48:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(temp >> srcIndex));
                        bool16 vector_hi = maxmath.tobool16((int)(temp >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool16*)(ptr + 32) = vector_hi;

                        return;
                    }
                    case 47:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(temp >> srcIndex));
                        bool16 vector_hi = maxmath.tobool16((int)(temp >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool8*)(ptr + 32) = vector_hi.v8_0;
                        *(bool4*)(ptr + 40) = vector_hi.v4_8;
                        *(bool3*)(ptr + 44) = vector_hi.v3_12;

                        return;
                    }
                    case 46:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(temp >> srcIndex));
                        bool16 vector_hi = maxmath.tobool16((int)(temp >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool8*)(ptr + 32) = vector_hi.v8_0;
                        *(bool4*)(ptr + 40) = vector_hi.v4_8;
                        *(bool2*)(ptr + 44) = vector_hi.v2_12;

                        return;
                    }
                    case 45:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(temp >> srcIndex));
                        bool16 vector_hi = maxmath.tobool16((int)(temp >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool8*)(ptr + 32) = vector_hi.v8_0;
                        *(bool4*)(ptr + 40) = vector_hi.v4_8;
                        *(bool*) (ptr + 44) = vector_hi.x12;

                        return;
                    }
                    case 44:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(temp >> srcIndex));
                        bool16 vector_hi = maxmath.tobool16((int)(temp >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool8*)(ptr + 32) = vector_hi.v8_0;
                        *(bool4*)(ptr + 40) = vector_hi.v4_8;

                        return;
                    }
                    case 43:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(temp >> srcIndex));
                        bool16 vector_hi = maxmath.tobool16((int)(temp >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool8*)(ptr + 32) = vector_hi.v8_0;
                        *(bool3*)(ptr + 40) = vector_hi.v3_8;

                        return;
                    }
                    case 42:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(temp >> srcIndex));
                        bool16 vector_hi = maxmath.tobool16((int)(temp >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool8*)(ptr + 32) = vector_hi.v8_0;
                        *(bool2*)(ptr + 40) = vector_hi.v2_8;

                        return;
                    }
                    case 41:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(temp >> srcIndex));
                        bool16 vector_hi = maxmath.tobool16((int)(temp >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool8*)(ptr + 32) = vector_hi.v8_0;
                        *(bool*) (ptr + 40) = vector_hi.x8;

                        return;
                    }
                    case 40:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(temp >> srcIndex));
                        bool8 vector_hi = maxmath.tobool8((int)(temp >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool8*)(ptr + 32) = vector_hi;

                        return;
                    }
                    case 39:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(temp >> srcIndex));
                        bool8 vector_hi = maxmath.tobool8((int)(temp >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool4*)(ptr + 32) = vector_hi.v4_0;
                        *(bool3*)(ptr + 36) = vector_hi.v3_4;

                        return;
                    }
                    case 38:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(temp >> srcIndex));
                        bool8 vector_hi = maxmath.tobool8((int)(temp >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool4*)(ptr + 32) = vector_hi.v4_0;
                        *(bool2*)(ptr + 36) = vector_hi.v2_4;

                        return;
                    }
                    case 37:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(temp >> srcIndex));
                        bool8 vector_hi = maxmath.tobool8((int)(temp >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool4*)(ptr + 32) = vector_hi.v4_0;
                        *(bool*) (ptr + 36) = vector_hi.x4;

                        return;
                    }
                    case 36:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(temp >> srcIndex));
                        bool4 vector_hi = maxmath.tobool4((int)(temp >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool4*)(ptr + 32) = vector_hi;

                        return;
                    }
                    case 35:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(temp >> srcIndex));
                        bool3 vector_hi = maxmath.tobool3((int)(temp >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool3*)(ptr + 32) = vector_hi;

                        return;
                    }
                    case 34:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(temp >> srcIndex));
                        bool2 vector_hi = maxmath.tobool2((int)(temp >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool2*)(ptr + 32) = vector_hi;

                        return;
                    }
                    case 33:
                    {
                        *(bool32*)(ptr)      = maxmath.tobool32((int)(temp >> srcIndex));
                        *(bool*)  (ptr + 32) = this[32 + srcIndex];

                        return;
                    }
                    case 32:
                    {
                        *(bool32*)ptr = maxmath.tobool32((int)(temp >> srcIndex)); 
                        return;
                    }
                    case 31:
                    {
                        bool32 vector = maxmath.tobool32((int)(temp >> srcIndex));

                        *(bool16*)ptr = vector.v16_0;
                        *(bool8*)(ptr + 16) = vector.v8_16;
                        *(bool4*)(ptr + 24) = vector.v4_24;
                        *(bool3*)(ptr + 28) = vector.v3_28;

                        return;
                    }
                    case 30:
                    {
                        bool32 vector = maxmath.tobool32((int)(temp >> srcIndex));

                        *(bool16*)ptr = vector.v16_0;
                        *(bool8*)(ptr + 16) = vector.v8_16;
                        *(bool4*)(ptr + 24) = vector.v4_24;
                        *(bool2*)(ptr + 28) = vector.v2_28;

                        return;
                    }
                    case 29:
                    {
                        bool32 vector = maxmath.tobool32((int)(temp >> srcIndex));

                        *(bool16*)ptr = vector.v16_0;
                        *(bool8*)(ptr + 16) = vector.v8_16;
                        *(bool4*)(ptr + 24) = vector.v4_24;
                        *(bool*) (ptr + 28) = vector.x28;

                        return;
                    }
                    case 28:
                    {
                        bool32 vector = maxmath.tobool32((int)(temp >> srcIndex));

                        *(bool16*)ptr = vector.v16_0;
                        *(bool8*)(ptr + 16) = vector.v8_16;
                        *(bool4*)(ptr + 24) = vector.v4_24;

                        return;
                    }
                    case 27:
                    {
                        bool32 vector = maxmath.tobool32((int)(temp >> srcIndex));

                        *(bool16*)ptr = vector.v16_0;
                        *(bool8*)(ptr + 16) = vector.v8_16;
                        *(bool3*)(ptr + 24) = vector.v3_24;

                        return;
                    }
                    case 26:
                    {
                        bool32 vector = maxmath.tobool32((int)(temp >> srcIndex));

                        *(bool16*)ptr = vector.v16_0;
                        *(bool8*)(ptr + 16) = vector.v8_16;
                        *(bool2*)(ptr + 24) = vector.v2_24;

                        return;
                    }
                    case 25:
                    {
                        bool32 vector = maxmath.tobool32((int)(temp >> srcIndex));

                        *(bool16*)ptr = vector.v16_0;
                        *(bool8*)(ptr + 16) = vector.v8_16;
                        *(bool*) (ptr + 24) = vector.x24;

                        return;
                    }
                    case 24:
                    {
                        bool32 vector = maxmath.tobool32((int)(temp >> srcIndex));

                        *(bool16*)ptr = vector.v16_0;
                        *(bool8*)(ptr + 16) = vector.v8_16;

                        return;
                    }
                    case 23:
                    {
                        bool32 vector = maxmath.tobool32((int)(temp >> srcIndex));

                        *(bool16*)ptr = vector.v16_0;
                        *(bool4*)(ptr + 16) = vector.v4_16;
                        *(bool3*)(ptr + 20) = vector.v3_20;

                        return;
                    }
                    case 22:
                    {
                        bool32 vector = maxmath.tobool32((int)(temp >> srcIndex));

                        *(bool16*)ptr = vector.v16_0;
                        *(bool4*)(ptr + 16) = vector.v4_16;
                        *(bool2*)(ptr + 20) = vector.v2_20;

                        return;
                    }
                    case 21:
                    {
                        bool32 vector = maxmath.tobool32((int)(temp >> srcIndex));

                        *(bool16*)ptr = vector.v16_0;
                        *(bool4*)(ptr + 16) = vector.v4_16;
                        *(bool*) (ptr + 20) = vector.x20;

                        return;
                    }
                    case 20:
                    {
                        bool32 vector = maxmath.tobool32((int)(temp >> srcIndex));

                        *(bool16*)ptr = vector.v16_0;
                        *(bool4*)(ptr + 16) = vector.v4_16;

                        return;
                    }
                    case 19:
                    {
                        bool32 vector = maxmath.tobool32((int)(temp >> srcIndex));

                        *(bool16*)ptr = vector.v16_0;
                        *(bool3*)(ptr + 16) = vector.v3_16;

                        return;
                    }
                    case 18:
                    {
                        bool32 vector = maxmath.tobool32((int)(temp >> srcIndex));

                        *(bool16*)ptr = vector.v16_0;
                        *(bool2*)(ptr + 16) = vector.v2_16;

                        return;
                    }
                    case 17:
                    {
                        bool16 vector = maxmath.tobool16((int)(temp >> srcIndex));

                        *(bool16*)ptr = vector;
                        *(bool*)(ptr + 16) = this[16 + srcIndex];

                        return;
                    }
                    case 16:
                    {
                        *(bool16*)ptr = maxmath.tobool16((int)(temp >> srcIndex)); 
                        return;
                    }
                    case 15:
                    {
                        bool16 vector = maxmath.tobool16((int)(temp >> srcIndex));

                        *(bool8*)ptr = vector.v8_0;
                        *(bool4*)(ptr +  8) = vector.v4_8;
                        *(bool3*)(ptr + 12) = vector.v3_12;

                        return;
                    }
                    case 14:
                    {
                        bool16 vector = maxmath.tobool16((int)(temp >> srcIndex));

                        *(bool8*)ptr = vector.v8_0;
                        *(bool4*)(ptr +  8) = vector.v4_8;
                        *(bool2*)(ptr + 12) = vector.v2_12;

                        return;
                    }
                    case 13:
                    {
                        bool16 vector = maxmath.tobool16((int)(temp >> srcIndex));

                        *(bool8*)ptr = vector.v8_0;
                        *(bool4*)(ptr +  8) = vector.v4_8;
                        *(bool*) (ptr + 12) = vector.x12;

                        return;
                    }
                    case 12:
                    {
                        bool16 vector = maxmath.tobool16((int)(temp >> srcIndex));

                        *(bool8*)ptr = vector.v8_0;
                        *(bool4*)(ptr + 8) = vector.v4_8;

                        return;
                    }
                    case 11:
                    {
                        bool16 vector = maxmath.tobool16((int)(temp >> srcIndex));

                        *(bool8*)ptr = vector.v8_0;
                        *(bool3*)(ptr + 8) = vector.v3_8;

                        return;
                    }
                    case 10:
                    {
                        bool16 vector = maxmath.tobool16((int)(temp >> srcIndex));

                        *(bool8*)ptr = vector.v8_0;
                        *(bool2*)(ptr + 8) = vector.v2_8;

                        return;
                    }
                    case 9:
                    {
                        bool16 vector = maxmath.tobool16((int)(temp >> srcIndex));

                        *(bool8*)ptr = vector.v8_0;
                        *(bool*)(ptr + 8) = vector.x8;

                        return;
                    }
                    case 8:
                    {
                        *(bool8*)ptr = maxmath.tobool8((int)(temp >> srcIndex)); 
                        return;
                    }
                    case 7:
                    {
                        bool8 vector = maxmath.tobool8((int)(temp >> srcIndex));

                        *(bool4*)ptr = vector.v4_0;
                        *(bool3*)(ptr + 4) = vector.v3_4;

                        return;
                    }
                    case 6:
                    {
                        bool8 vector = maxmath.tobool8((int)(temp >> srcIndex));

                        *(bool4*)ptr = vector.v4_0;
                        *(bool2*)(ptr + 4) = vector.v2_4;

                        return;
                    }
                    case 5:
                    {
                        bool8 vector = maxmath.tobool8((int)(temp >> srcIndex));

                        *(bool4*)ptr = vector.v4_0;
                        *(bool*)(ptr + 4) = vector.x4;

                        return;
                    }
                    case 4:
                    {
                        *(bool4*)ptr = maxmath.tobool4((int)(temp >> srcIndex));  
                        return;
                    }
                    case 3:
                    {
                        *(bool3*)ptr = maxmath.tobool3((int)(temp >> srcIndex)); 
                        return;
                    }
                    case 2:
                    {
                        *(bool2*)ptr = maxmath.tobool2((int)(temp >> srcIndex)); 
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
                ulong shifted = temp >> srcIndex;

                if (numValues >= 32)
                {
                    bool32* ptr32 = (bool32*)ptr;
                    
                    *ptr32 = maxmath.tobool32((int)shifted);
                    numValues -= 32;
                    shifted >>= 32;
                    ptr32++;

                    ptr = (bool*)ptr32;

                    if (numValues == 32)
                    {
                        *(bool32*)ptr = maxmath.tobool32((int)shifted);

                        return;
                    }
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
                        *ptr = ((bit64)shifted)[0];

                        return;
                    }
                    default: return;
                }
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

            return Length - 1 - math.lzcnt(AsULong);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(-1, 63)] 
        public readonly int IndexOfLast(int index, int numBits)
        {
Assert.IsNotGreater(sizeof(T), 8);
Assert.IsValidSubarray(index, numBits, Length);

            return Length - 1 - math.lzcnt(AsULong & (ulong)maxmath.bitmask64(numBits, index));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ResetFirst()
        {
            ulong temp = AsULong;

            temp = maxmath.bits_resetlowest(temp);

            intern = *(T*)&temp;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ResetFirst(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            ulong temp = AsULong;

            ulong mask = maxmath.bitmask64((ulong)(uint)numBits, (ulong)(uint)index);
            ulong reset = maxmath.bits_resetlowest(temp & mask);
            ulong remaining = maxmath.andnot(temp, mask);

            temp = reset | remaining;

            intern = *(T*)&temp;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetFirst()
        {
            ulong temp = AsULong;

            // for X86, modulo 64/AND 63 is omitted, since it is performed in hardware when shifting anyway
            temp = temp | (1ul << (math.tzcnt(~temp) % 64));

            intern = *(T*)&temp;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetFirst(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            ulong temp = AsULong;

            // for X86, modulo 64/AND 63 is omitted, since it is performed in hardware when shifting anyway
            ulong mask = maxmath.bitmask64((ulong)(uint)numBits, (ulong)(uint)index);
            ulong set = temp | (1ul << (math.tzcnt(maxmath.andnot(mask, temp)) % 64));

            temp  = maxmath.andnot(temp, mask) | (set & mask);

            intern = *(T*)&temp;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ResetLast()
        {
            ulong temp = AsULong;

            temp = temp & ((ulong.MaxValue >> 1) >> math.lzcnt(temp));

            intern = *(T*)&temp;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ResetLast(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            ulong temp = AsULong;

            ulong mask = maxmath.bitmask64((ulong)(uint)numBits, (ulong)(uint)index);
            ulong reset = (temp & ((ulong.MaxValue >> 1) >> math.lzcnt(mask & temp)));
            ulong remaining = maxmath.andnot(temp, mask);

            temp = reset | remaining;

            intern = *(T*)&temp;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetLast()
        {
            ulong temp = AsULong;

            int leadingOnesCount = math.lzcnt(maxmath.andnot(maxmath.bitmask64((ulong)Length), temp));
            temp = temp | (1ul << (63 - leadingOnesCount));

            intern = *(T*)&temp;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetLast(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            ulong temp = AsULong;

            ulong mask = maxmath.bitmask64((ulong)(uint)numBits, (ulong)(uint)index);
            int leadingOnesCount = math.lzcnt(maxmath.andnot(mask, temp));
            ulong set = temp  | (1ul << (63 - leadingOnesCount));

            temp = maxmath.andnot(temp, mask) | (set & mask);

            intern = *(T*)&temp;
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

            ulong masked = AsULong;
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

            ulong masked = AsULong;
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
            
            ulong temp = AsULong;

            uint bit1 = (uint)maxmath.bits_extract(temp, smallerIndex, 1);
            uint bit2 = (uint)maxmath.bits_extract(temp, largerIndex, 1);
           
            uint swap = bit1 ^ bit2;
            ulong shifted = ((ulong)swap << smallerIndex) | ((ulong)swap << largerIndex);
 
            temp ^= shifted;

            intern = *(T*)&temp;
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

            uint bits1 = (uint)maxmath.bits_extract(temp, smallerIndex, numBits);
            uint bits2 = (uint)maxmath.bits_extract(temp, largerIndex, numBits);
           
            uint swap = bits1 ^ bits2;
            ulong shifted = ((ulong)swap << smallerIndex) | ((ulong)swap << largerIndex);
 
            temp ^= shifted;

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
            return (uint)math.countbits(AsULong);
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

            return mask == AsULong;
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

            return 0ul != AsULong;
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
            return 0ul == AsULong;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestNone(int index, int numBits)
        {
Assert.IsNotGreater(sizeof(T), 8);
Assert.IsValidSubarray(index, numBits, Length);

            return 0ul == (AsULong & (ulong)maxmath.bitmask64(numBits, index));
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestNotAll()
        {
            return AsULong != (ulong)maxmath.bitmask64(Length);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestNotAll(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = (ulong)maxmath.bitmask64(numBits, index);

            return (AsULong & mask) != mask;
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


        public override readonly string ToString()
        {
Assert.IsNotGreater(sizeof(T), 8);

            return Dump.Bits(this);
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
Assert.IsNotGreater(sizeof(T), 8);

            if (sizeof(T) > 4)
            {
                ulong masked = AsULong;

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

            return this.AsULong == other.AsULong;
        }
        public override readonly bool Equals(object obj)
        {
            return Equals((bits<T>)obj);
        }
    
        public readonly IEnumerator<bool> GetEnumerator()
        {
Assert.IsNotGreater(sizeof(T), 8);

            return new ArrayEnumerator<bool>(this);
        }
        readonly IEnumerator IEnumerable.GetEnumerator()
        {
Assert.IsNotGreater(sizeof(T), 8);

            return new ArrayEnumerator<bool>(this);
        }
    }
}