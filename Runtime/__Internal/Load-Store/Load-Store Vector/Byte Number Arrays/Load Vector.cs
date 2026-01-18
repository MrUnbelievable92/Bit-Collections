using System.Runtime.CompilerServices;
using Unity.Burst.Intrinsics;
using Unity.Mathematics;
using Unity.Collections;
using MaxMath;
using MaxMath.Intrinsics;
using SIMDAlgorithms;

using static MaxMath.maxmath;
using static MaxMath.Intrinsics.Xse;
using static Unity.Burst.Intrinsics.X86;

namespace BitCollections
{
    unsafe internal static partial class LoadStore
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong4 Load_u24_to64x4(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (Avx2.IsAvx2Supported)
            {
                if (memoryAccess >= MemoryAccess.Allow32ByteRead)
                {
                    return Avx2.mm256_and_si256(mm256_set1_epi64x(bitmask64(24L)), Avx2.mm256_i64gather_epi64(ptr, (ulong)sizeof(UInt24) * new ulong4(0, 1, 2, 3), 1));
                }
            }
            
            return new ulong4(Load_u24_to64x2(ptr,              memoryAccess), 
                              Load_u24_to64x2((UInt24*)ptr + 2, memoryAccess < MemoryAccess.Allow32ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong3 Load_u24_to64x3(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (Avx2.IsAvx2Supported)
            {
                if (memoryAccess >= MemoryAccess.Allow16ByteRead)
                {
                    return Avx2.mm256_and_si256(mm256_set1_epi64x(bitmask64(24L)), Avx2.mm256_i64gather_epi64(ptr, (ulong)sizeof(UInt24) * new ulong4(0, 1, 2, 0), 1));
                }
            }
            
            return new ulong3(Load_u24_to64x2(ptr,              memoryAccess), 
                              UInt24.To_ulong((UInt24*)ptr + 2, memoryAccess < MemoryAccess.Allow16ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong2 Load_u24_to64x2(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 result;
                if (memoryAccess >= MemoryAccess.Allow16ByteRead)
                {
                    result = loadu_si128(ptr);
                }
                else
                {
                    result = cvtsi32_si128(       *((int*)   ((byte*)ptr + 0)));
                    result = insert_epi16(result, *((ushort*)((byte*)ptr + 4)), 2);
                }

                result = shuffle_epi8(result, new v128(0, 1, 2, -1, -1, -1, -1, -1,    3, 4, 5, -1, -1, -1, -1, -1));

                return result;
            }
            else
            {
                return new ulong2(UInt24.To_ulong((UInt24*)ptr + 0, memoryAccess < MemoryAccess.Allow16ByteRead ? MemoryAccess.Strict : memoryAccess),
                                  UInt24.To_ulong((UInt24*)ptr + 1, memoryAccess < MemoryAccess.Allow16ByteRead ? MemoryAccess.Strict : memoryAccess));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong4 Load_u40_to64x4(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (Avx2.IsAvx2Supported)
            {
                if (memoryAccess >= MemoryAccess.Allow32ByteRead)
                {
                    return Avx2.mm256_and_si256(mm256_set1_epi64x(bitmask64(40L)), Avx2.mm256_i64gather_epi64(ptr, (ulong)sizeof(UInt40) * new ulong4(0, 1, 2, 3), 1));
                }
            }
            
            return new ulong4(Load_u40_to64x2(ptr,              MemoryAccess.Allow16ByteRead), 
                              Load_u40_to64x2((UInt40*)ptr + 2, memoryAccess < MemoryAccess.Allow32ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong3 Load_u40_to64x3(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (Avx2.IsAvx2Supported)
            {
                if (memoryAccess >= MemoryAccess.Allow32ByteRead)
                {
                    return Avx2.mm256_and_si256(mm256_set1_epi64x(bitmask64(40L)), Avx2.mm256_i64gather_epi64(ptr, (ulong)sizeof(UInt40) * new ulong4(0, 1, 2, 3), 1));
                }
            }
            
            return new ulong3(Load_u40_to64x2(ptr,              memoryAccess), 
                              UInt40.To_ulong((UInt40*)ptr + 2, memoryAccess < MemoryAccess.Allow32ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong2 Load_u40_to64x2(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 result;
                if (memoryAccess >= MemoryAccess.Allow16ByteRead)
                {
                    result = loadu_si128(ptr);
                }
                else
                {
                    result = cvtsi64x_si128(      *((long*)  ((byte*)ptr + 0)));
                    result = insert_epi16(result, *((ushort*)((byte*)ptr + 8)), 4);
                }

                result = shuffle_epi8(result, new v128(0, 1, 2, 3, 4, -1, -1, -1,    5, 6, 7, 8, 9, -1, -1, -1));

                return result;
            }
            else
            {
                return new ulong2(UInt40.To_ulong((UInt40*)ptr + 0, MemoryAccess.Allow8ByteRead), 
                                  UInt40.To_ulong((UInt40*)ptr + 1, memoryAccess < MemoryAccess.Allow16ByteRead ? MemoryAccess.Strict : memoryAccess));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong4 Load_u48_to64x4(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (Avx2.IsAvx2Supported)
            {
                if (memoryAccess >= MemoryAccess.Allow32ByteRead)
                {
                    return Avx2.mm256_and_si256(mm256_set1_epi64x(bitmask64(48L)), Avx2.mm256_i64gather_epi64(ptr, (ulong)sizeof(UInt48) * new ulong4(0, 1, 2, 3), 1));
                }
            }
            
            return new ulong4(Load_u48_to64x2(ptr,              MemoryAccess.Allow16ByteRead), 
                              Load_u48_to64x2((UInt48*)ptr + 2, memoryAccess < MemoryAccess.Allow32ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong3 Load_u48_to64x3(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (Avx2.IsAvx2Supported)
            {
                if (memoryAccess >= MemoryAccess.Allow32ByteRead)
                {
                    return Avx2.mm256_and_si256(mm256_set1_epi64x(bitmask64(48L)), Avx2.mm256_i64gather_epi64(ptr, (ulong)sizeof(UInt48) * new ulong4(0, 1, 2, 3), 1));
                }
            }
            
            return new ulong3(Load_u48_to64x2(ptr,              MemoryAccess.Allow16ByteRead), 
                              UInt48.To_ulong((UInt48*)ptr + 2, memoryAccess < MemoryAccess.Allow32ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong2 Load_u48_to64x2(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 result;
                if (memoryAccess >= MemoryAccess.Allow16ByteRead)
                {
                    result = loadu_si128(ptr);
                }
                else
                {
                    result = cvtsi64x_si128(      *((long*)((byte*)ptr + 0)));
                    result = insert_epi32(result, *((uint*)((byte*)ptr + 8)), 2);
                }

                result = shuffle_epi8(result, new v128(0, 1, 2, 3, 4, 5, -1, -1,    6, 7, 8, 9, 10, 11, -1, -1));

                return result;
            }
            else
            {
                return new ulong2(UInt48.To_ulong((UInt48*)ptr + 0, MemoryAccess.Allow8ByteRead), 
                                  UInt48.To_ulong((UInt48*)ptr + 1, memoryAccess < MemoryAccess.Allow16ByteRead ? MemoryAccess.Strict : memoryAccess));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong4 Load_u56_to64x4(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (Avx2.IsAvx2Supported)
            {
                if (memoryAccess >= MemoryAccess.Allow32ByteRead)
                {
                    return Avx2.mm256_and_si256(mm256_set1_epi64x(bitmask64(56L)), Avx2.mm256_i64gather_epi64(ptr, (ulong)sizeof(UInt56) * new ulong4(0, 1, 2, 3), 1));
                }
            }
            
            return new ulong4(Load_u56_to64x2(ptr,              MemoryAccess.Allow16ByteRead), 
                              Load_u56_to64x2((UInt56*)ptr + 2, memoryAccess < MemoryAccess.Allow32ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong3 Load_u56_to64x3(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (Avx2.IsAvx2Supported)
            {
                if (memoryAccess >= MemoryAccess.Allow32ByteRead)
                {
                    return Avx2.mm256_and_si256(mm256_set1_epi64x(bitmask64(56L)), Avx2.mm256_i64gather_epi64(ptr, (ulong)sizeof(UInt56) * new ulong4(0, 1, 2, 3), 1));
                }
            }
            
            return new ulong3(Load_u56_to64x2(ptr,              MemoryAccess.Allow16ByteRead),
                              UInt56.To_ulong((UInt56*)ptr + 2, memoryAccess < MemoryAccess.Allow32ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong2 Load_u56_to64x2(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 result;
                if (memoryAccess >= MemoryAccess.Allow16ByteRead)
                {
                    result = loadu_si128(ptr);
                }
                else
                {
                    result = cvtsi64x_si128(      *((long*)  ((byte*)ptr + 0)));
                    result = insert_epi32(result, *((uint*)  ((byte*)ptr + 8)),  2);
                    result = insert_epi16(result, *((ushort*)((byte*)ptr + 12)), 6);
                }

                result = shuffle_epi8(result, new v128(0, 1, 2, 3, 4, 5, 6, -1,    7, 8, 9, 10, 11, 12, 13, -1));

                return result;
            }
            else
            {
                return new ulong2(UInt56.To_ulong((UInt56*)ptr + 0, MemoryAccess.Allow8ByteRead), 
                                  UInt56.To_ulong((UInt56*)ptr + 1, memoryAccess < MemoryAccess.Allow16ByteRead ? MemoryAccess.Strict : memoryAccess));
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong4 Load_i24_to64x4(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (Avx2.IsAvx2Supported)
            {
                if (memoryAccess >= MemoryAccess.Allow32ByteRead)
                {
                    v256 load = Avx2.mm256_i64gather_epi64(ptr, (ulong)sizeof(UInt24) * new ulong4(0, 1, 2, 3), 1);

                    v256 sign = mm256_srai_epi8(load, 7);
                    sign = Avx2.mm256_shuffle_epi8(sign, new v256(2, 2, 2, 2, 2, 2, 2, 2,   5, 5, 5, 5, 5, 5, 5, 5,
                                                                  2, 2, 2, 2, 2, 2, 2, 2,   5, 5, 5, 5, 5, 5, 5, 5));

                    return Avx2.mm256_blendv_epi8(load, sign, new v256(0, 1, 2, -1, -1, -1, -1, -1,    3, 4, 5, -1, -1, -1, -1, -1,
                                                                       0, 1, 2, -1, -1, -1, -1, -1,    3, 4, 5, -1, -1, -1, -1, -1));
                }
            }
            
            return new ulong4(Load_i24_to64x2(ptr,             memoryAccess), 
                              Load_i24_to64x2((Int24*)ptr + 2, memoryAccess < MemoryAccess.Allow32ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong3 Load_i24_to64x3(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (Avx2.IsAvx2Supported)
            {
                if (memoryAccess >= MemoryAccess.Allow16ByteRead)
                {
                    v256 load = Avx2.mm256_i64gather_epi64(ptr, (ulong)sizeof(UInt24) * new ulong4(0, 1, 2, 0), 1);

                    v256 sign = mm256_srai_epi8(load, 7);
                    sign = Avx2.mm256_shuffle_epi8(sign, new v256(2, 2, 2, 2, 2, 2, 2, 2,   5, 5, 5, 5, 5, 5, 5, 5,
                                                                  2, 2, 2, 2, 2, 2, 2, 2,   5, 5, 5, 5, 5, 5, 5, 5));

                    return Avx2.mm256_blendv_epi8(load, sign, new v256(0, 1, 2, -1, -1, -1, -1, -1,    3, 4, 5, -1, -1, -1, -1, -1,
                                                                       0, 1, 2, -1, -1, -1, -1, -1,    3, 4, 5, -1, -1, -1, -1, -1));
                }
            }
            
            return new ulong3(Load_i24_to64x2(ptr,            memoryAccess), 
                              Int24.To_ulong((Int24*)ptr + 2, memoryAccess < MemoryAccess.Allow32ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong2 Load_i24_to64x2(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 result;
                if (memoryAccess >= MemoryAccess.Allow16ByteRead)
                {
                    result = loadu_si128(ptr);
                }
                else
                {
                    result = cvtsi32_si128(       *((int*)   ((byte*)ptr + 0)));
                    result = insert_epi16(result, *((ushort*)((byte*)ptr + 4)), 2);
                }
                
                v128 sign = srai_epi8(result, 7);
                sign = shuffle_epi8(sign, new v128(2, 2, 2, 2, 2, 2, 2, 2,   5, 5, 5, 5, 5, 5, 5, 5));

                result = shuffle_epi8(result, new v128(0, 1, 2, -1, -1, -1, -1, -1,    3, 4, 5, -1, -1, -1, -1, -1));

                result = blendv_epi8(result, sign, new v128(0, 1, 2, -1, -1, -1, -1, -1,    3, 4, 5, -1, -1, -1, -1, -1));

                return result;
            }
            else
            {
                return new ulong2(Int24.To_ulong((Int24*)ptr + 0, memoryAccess < MemoryAccess.Allow16ByteRead ? MemoryAccess.Strict : memoryAccess), 
                                  Int24.To_ulong((Int24*)ptr + 1, memoryAccess < MemoryAccess.Allow16ByteRead ? MemoryAccess.Strict : memoryAccess));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong4 Load_i40_to64x4(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (Avx2.IsAvx2Supported)
            {
                if (memoryAccess >= MemoryAccess.Allow32ByteRead)
                {
                    v256 load = Avx2.mm256_i64gather_epi64(ptr, (ulong)sizeof(UInt40) * new ulong4(0, 1, 2, 3), 1);

                    v256 sign = mm256_srai_epi8(load, 7);
                    sign = Avx2.mm256_shuffle_epi8(sign, new v256(4, 4, 4, 4, 4, 4, 4, 4,   9, 9, 9, 9, 9, 9, 9, 9,
                                                                  4, 4, 4, 4, 4, 4, 4, 4,   9, 9, 9, 9, 9, 9, 9, 9));

                    return Avx2.mm256_blendv_epi8(load, sign, new v256(0, 1, 2, 3, 4, -1, -1, -1,    5, 6, 7, 8, 9, -1, -1, -1,
                                                                       0, 1, 2, 3, 4, -1, -1, -1,    5, 6, 7, 8, 9, -1, -1, -1));
                }
            }
            
            return new ulong4(Load_i40_to64x2(ptr,             MemoryAccess.Allow16ByteRead), 
                              Load_i40_to64x2((Int40*)ptr + 2, memoryAccess < MemoryAccess.Allow32ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong3 Load_i40_to64x3(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (Avx2.IsAvx2Supported)
            {
                if (memoryAccess >= MemoryAccess.Allow32ByteRead)
                {
                    v256 load = Avx2.mm256_i64gather_epi64(ptr, (ulong)sizeof(UInt40) * new ulong4(0, 1, 2, 3), 1);

                    v256 sign = mm256_srai_epi8(load, 7);
                    sign = Avx2.mm256_shuffle_epi8(sign, new v256(4, 4, 4, 4, 4, 4, 4, 4,   9, 9, 9, 9, 9, 9, 9, 9,
                                                                  4, 4, 4, 4, 4, 4, 4, 4,   9, 9, 9, 9, 9, 9, 9, 9));

                    return Avx2.mm256_blendv_epi8(load, sign, new v256(0, 1, 2, 3, 4, -1, -1, -1,    5, 6, 7, 8, 9, -1, -1, -1,
                                                                       0, 1, 2, 3, 4, -1, -1, -1,    5, 6, 7, 8, 9, -1, -1, -1));
                }
            }
            
            return new ulong3(Load_i40_to64x2(ptr,            memoryAccess), 
                              Int40.To_ulong((Int40*)ptr + 2, memoryAccess < MemoryAccess.Allow32ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong2 Load_i40_to64x2(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 result;
                if (memoryAccess >= MemoryAccess.Allow16ByteRead)
                {
                    result = loadu_si128(ptr);
                }
                else
                {
                    result = cvtsi64x_si128(      *((long*)  ((byte*)ptr + 0)));
                    result = insert_epi16(result, *((ushort*)((byte*)ptr + 8)), 4);
                }
                
                v128 sign = srai_epi8(result, 7);
                sign = shuffle_epi8(sign, new v128(4, 4, 4, 4, 4, 4, 4, 4,   9, 9, 9, 9, 9, 9, 9, 9));

                result = shuffle_epi8(result, new v128(0, 1, 2, 3, 4, -1, -1, -1,    5, 6, 7, 8, 9, -1, -1, -1));

                result = blendv_epi8(result, sign, new v128(0, 1, 2, 3, 4, -1, -1, -1,    5, 6, 7, 8, 9, -1, -1, -1));

                return result;
            }
            else
            {
                return new ulong2(Int40.To_ulong((Int40*)ptr + 0, MemoryAccess.Allow8ByteRead), 
                                  Int40.To_ulong((Int40*)ptr + 1, memoryAccess < MemoryAccess.Allow16ByteRead ? MemoryAccess.Strict : memoryAccess));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong4 Load_i48_to64x4(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (Avx2.IsAvx2Supported)
            {
                if (memoryAccess >= MemoryAccess.Allow32ByteRead)
                {
                    v256 load = Avx2.mm256_i64gather_epi64(ptr, (ulong)sizeof(UInt48) * new ulong4(0, 1, 2, 3), 1);

                    v256 sign = mm256_srai_epi8(load, 7);
                    sign = Avx2.mm256_shuffle_epi8(sign, new v256(5, 5, 5, 5, 5, 5, 5, 5,   11, 11, 11, 11, 11, 11, 11, 11,
                                                                  5, 5, 5, 5, 5, 5, 5, 5,   11, 11, 11, 11, 11, 11, 11, 11));

                    return Avx2.mm256_blendv_epi8(load, sign, new v256(0, 1, 2, 3, 4, 5, -1, -1,    6, 7, 8, 9, 10, 11, -1, -1,
                                                                       0, 1, 2, 3, 4, 5, -1, -1,    6, 7, 8, 9, 10, 11, -1, -1));
                }
            }
            
            return new ulong4(Load_i48_to64x2(ptr,             MemoryAccess.Allow16ByteRead), 
                              Load_i48_to64x2((Int48*)ptr + 2, memoryAccess < MemoryAccess.Allow32ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong3 Load_i48_to64x3(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (Avx2.IsAvx2Supported)
            {
                if (memoryAccess >= MemoryAccess.Allow32ByteRead)
                {
                    v256 load = Avx2.mm256_i64gather_epi64(ptr, (ulong)sizeof(UInt48) * new ulong4(0, 1, 2, 3), 1);

                    v256 sign = mm256_srai_epi8(load, 7);
                    sign = Avx2.mm256_shuffle_epi8(sign, new v256(5, 5, 5, 5, 5, 5, 5, 5,   11, 11, 11, 11, 11, 11, 11, 11,
                                                                  5, 5, 5, 5, 5, 5, 5, 5,   11, 11, 11, 11, 11, 11, 11, 11));

                    return Avx2.mm256_blendv_epi8(load, sign, new v256(0, 1, 2, 3, 4, 5, -1, -1,    6, 7, 8, 9, 10, 11, -1, -1,
                                                                       0, 1, 2, 3, 4, 5, -1, -1,    6, 7, 8, 9, 10, 11, -1, -1));
                }
            }
            
            return new ulong3(Load_i48_to64x2(ptr,            MemoryAccess.Allow16ByteRead), 
                              Int48.To_ulong((Int48*)ptr + 2, memoryAccess < MemoryAccess.Allow32ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong2 Load_i48_to64x2(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 result;
                if (memoryAccess >= MemoryAccess.Allow16ByteRead)
                {
                    result = loadu_si128(ptr);
                }
                else
                {
                    result = cvtsi64x_si128(      *((long*)((byte*)ptr + 0)));
                    result = insert_epi32(result, *((uint*)((byte*)ptr + 8)), 2);
                }
                
                v128 sign = srai_epi8(result, 7);
                sign = shuffle_epi8(sign, new v128(5, 5, 5, 5, 5, 5, 5, 5,   11, 11, 11, 11, 11, 11, 11, 11));

                result = shuffle_epi8(result, new v128(0, 1, 2, 3, 4, 5, -1, -1,    6, 7, 8, 9, 10, 11, -1, -1));

                result = blendv_epi8(result, sign, new v128(0, 1, 2, 3, 4, 5, -1, -1,    6, 7, 8, 9, 10, 11, -1, -1));

                return result;
            }
            else
            {
                return new ulong2(Int48.To_ulong((Int48*)ptr + 0, MemoryAccess.Allow8ByteRead), 
                                  Int48.To_ulong((Int48*)ptr + 1, memoryAccess < MemoryAccess.Allow16ByteRead ? MemoryAccess.Strict : memoryAccess));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong4 Load_i56_to64x4(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (Avx2.IsAvx2Supported)
            {
                if (memoryAccess >= MemoryAccess.Allow32ByteRead)
                {
                    v256 load = Avx2.mm256_i64gather_epi64(ptr, (ulong)sizeof(UInt56) * new ulong4(0, 1, 2, 3), 1);

                    v256 sign = mm256_srai_epi8(load, 7);
                    sign = Avx2.mm256_shuffle_epi8(sign, new v256(6, 6, 6, 6, 6, 6, 6, 6,   13, 13, 13, 13, 13, 13, 13, 13,
                                                                  6, 6, 6, 6, 6, 6, 6, 6,   13, 13, 13, 13, 13, 13, 13, 13));

                    return Avx2.mm256_blendv_epi8(load, sign, new v256(0, 1, 2, 3, 4, 5, 6, -1,    7, 8, 9, 10, 11, 12, 13, -1,
                                                                       0, 1, 2, 3, 4, 5, 6, -1,    7, 8, 9, 10, 11, 12, 13, -1));
                }
            }
            
            return new ulong4(Load_i56_to64x2(ptr,             MemoryAccess.Allow16ByteRead), 
                              Load_i56_to64x2((Int56*)ptr + 2, memoryAccess < MemoryAccess.Allow32ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong3 Load_i56_to64x3(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (Avx2.IsAvx2Supported)
            {
                if (memoryAccess >= MemoryAccess.Allow32ByteRead)
                {
                    v256 load = Avx2.mm256_i64gather_epi64(ptr, (ulong)sizeof(UInt56) * new ulong4(0, 1, 2, 3), 1);

                    v256 sign = mm256_srai_epi8(load, 7);
                    sign = Avx2.mm256_shuffle_epi8(sign, new v256(6, 6, 6, 6, 6, 6, 6, 6,   13, 13, 13, 13, 13, 13, 13, 13,
                                                                  6, 6, 6, 6, 6, 6, 6, 6,   13, 13, 13, 13, 13, 13, 13, 13));

                    return Avx2.mm256_blendv_epi8(load, sign, new v256(0, 1, 2, 3, 4, 5, 6, -1,    7, 8, 9, 10, 11, 12, 13, -1,
                                                                       0, 1, 2, 3, 4, 5, 6, -1,    7, 8, 9, 10, 11, 12, 13, -1));
                }
            }
            
            return new ulong3(Load_i56_to64x2(ptr,            MemoryAccess.Allow16ByteRead), 
                              Int56.To_ulong((Int56*)ptr + 2, memoryAccess < MemoryAccess.Allow32ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong2 Load_i56_to64x2(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 result;
                if (memoryAccess >= MemoryAccess.Allow16ByteRead)
                {
                    result = loadu_si128(ptr);
                }
                else
                {
                    result = cvtsi64x_si128(      *((long*)  ((byte*)ptr + 0)));
                    result = insert_epi32(result, *((uint*)  ((byte*)ptr + 8)),  2);
                    result = insert_epi16(result, *((ushort*)((byte*)ptr + 12)), 6);
                }
                
                v128 sign = srai_epi8(result, 7);
                sign = shuffle_epi8(sign, new v128(6, 6, 6, 6, 6, 6, 6, 6,   13, 13, 13, 13, 13, 13, 13, 13));

                result = shuffle_epi8(result, new v128(0, 1, 2, 3, 4, 5, 6, -1,    7, 8, 9, 10, 11, 12, 13, -1));

                result = blendv_epi8(result, sign, new v128(0, 1, 2, 3, 4, 5, 6, -1,    7, 8, 9, 10, 11, 12, 13, -1));

                return result;
            }
            else
            {
                return new ulong2(Int56.To_ulong((Int56*)ptr + 0, MemoryAccess.Allow8ByteRead), 
                                  Int56.To_ulong((Int56*)ptr + 1, memoryAccess < MemoryAccess.Allow16ByteRead ? MemoryAccess.Strict : memoryAccess));
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint8 Load_u24_to32x8(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (Avx2.IsAvx2Supported)
            {
                if (memoryAccess >= MemoryAccess.Allow32ByteRead)
                {
                    return Avx2.mm256_and_si256(mm256_set1_epi32(bitmask32(24)), Avx2.mm256_i32gather_epi32(ptr, (uint)sizeof(UInt24) * new uint8(0, 1, 2, 3, 4, 5, 6, 7), 1));
                }
            }
            
            return new uint8(Load_u24_to32x4(ptr,              MemoryAccess.Allow16ByteRead), 
                             Load_u24_to32x4((UInt24*)ptr + 4, memoryAccess < MemoryAccess.Allow32ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint4 Load_u24_to32x4(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 result;
                if (memoryAccess >= MemoryAccess.Allow16ByteRead)
                { 
                    result = loadu_si128(ptr);
                }
                else
                {
                    result = cvtsi64x_si128(      *((long*)((byte*)ptr + 0)));
                    result = insert_epi32(result, *((uint*)((byte*)ptr + 8)), 2);
                }
                
                result = shuffle_epi8(result, new v128(0, 1, 2, -1,   3, 4, 5, -1,   6, 7, 8, -1,   9, 10, 11, -1));

                return result.Reinterpret<v128, uint4>();
            }
            else
            {
                return new uint4(UInt24.To_uint((UInt24*)ptr + 0, MemoryAccess.Allow4ByteRead), 
                                 UInt24.To_uint((UInt24*)ptr + 1, MemoryAccess.Allow4ByteRead), 
                                 UInt24.To_uint((UInt24*)ptr + 2, MemoryAccess.Allow4ByteRead), 
                                 UInt24.To_uint((UInt24*)ptr + 3, memoryAccess < MemoryAccess.Allow16ByteRead ? MemoryAccess.Strict : memoryAccess));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint3 Load_u24_to32x3(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 result;
                if (memoryAccess >= MemoryAccess.Allow16ByteRead)
                {
                    result = loadu_si128(ptr);
                }
                else
                {
                    result = cvtsi64x_si128(     *((long*)((byte*)ptr + 0)));
                    result = insert_epi8(result, *((byte*)((byte*)ptr + 8)), 8);
                }
                
                result = shuffle_epi8(result, new v128(0, 1, 2, -1,   3, 4, 5, -1,   6, 7, 8, -1,   9, 10, 11, -1));

                return result.Reinterpret<v128, uint4>().xyz;
            }
            else
            {
                return new uint3(UInt24.To_uint((UInt24*)ptr + 0, MemoryAccess.Allow4ByteRead), 
                                 UInt24.To_uint((UInt24*)ptr + 1, MemoryAccess.Allow4ByteRead), 
                                 UInt24.To_uint((UInt24*)ptr + 2, memoryAccess < MemoryAccess.Allow16ByteRead ? MemoryAccess.Strict : memoryAccess));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint2 Load_u24_to32x2(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 result;
                if (memoryAccess >= MemoryAccess.Allow16ByteRead)
                {
                    result = loadu_si128(ptr);
                }
                else
                {
                    result = cvtsi32_si128(       *((int*)   ((byte*)ptr + 0)));
                    result = insert_epi16(result, *((ushort*)((byte*)ptr + 4)), 2);
                }
                
                result = shuffle_epi8(result, new v128(0, 1, 2, -1,   3, 4, 5, -1,   6, 7, 8, -1,   9, 10, 11, -1));

                return result.Reinterpret<v128, uint4>().xy;
            }
            else
            {
                return new uint2(UInt24.To_uint((UInt24*)ptr + 0, MemoryAccess.Allow4ByteRead), 
                                 UInt24.To_uint((UInt24*)ptr + 1, memoryAccess < MemoryAccess.Allow8ByteRead ? MemoryAccess.Strict : memoryAccess));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint8 Load_u40_to32x8(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (Avx2.IsAvx2Supported)
            {
                if (memoryAccess >= MemoryAccess.Allow64ByteRead)
                {
                    return Avx2.mm256_i32gather_epi32(ptr, (uint)sizeof(UInt40) * new uint8(0, 1, 2, 3, 4, 5, 6, 7), 1);
                }
            }
            
            return new uint8(Load_u40_to32x4(ptr,              MemoryAccess.Allow32ByteRead), 
                             Load_u40_to32x4((UInt40*)ptr + 4, memoryAccess < MemoryAccess.Allow64ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint4 Load_u40_to32x4(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (Avx2.IsAvx2Supported)
            {
                if (memoryAccess >= MemoryAccess.Allow32ByteRead)
                {
                    return Avx2.i32gather_epi32(ptr, ((uint)sizeof(UInt40) * new uint4(0, 1, 2, 3)).Reinterpret<uint4, v128>(), 1).Reinterpret<v128, uint4>();
                }
            }
            
            return new uint4(Load_u40_to32x2(ptr,              MemoryAccess.Allow16ByteRead), 
                             Load_u40_to32x2((UInt40*)ptr + 2, memoryAccess < MemoryAccess.Allow32ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint3 Load_u40_to32x3(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                if (memoryAccess >= MemoryAccess.Allow16ByteRead)
                {
                    if (Avx2.IsAvx2Supported)
                    {
                        return Avx2.i32gather_epi32(ptr, ((uint)sizeof(UInt40) * new uint4(0, 1, 2, 0)).Reinterpret<uint4, v128>(), 1).Reinterpret<v128, uint4>().xyz;
                    }

                    v128 result = loadu_si128(ptr);

                    result = shuffle_epi8(result, new v128(0, 1, 2, 3,   5, 6, 7, 8,    10, 11, 12, 13,   0, 0, 0, 0));

                    return result.Reinterpret<v128, uint4>().xyz;
                }
            }
            
            return new uint3(Load_u40_to32x2(ptr, memoryAccess), 
                             *(uint*)((UInt40*)ptr + 2));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint2 Load_u40_to32x2(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                if (memoryAccess >= MemoryAccess.Allow16ByteRead)
                {
                    if (Avx2.IsAvx2Supported)
                    {
                        return Avx2.i32gather_epi32(ptr, ((uint)sizeof(UInt40) * new uint4(0, 1, 0, 0)).Reinterpret<uint4, v128>(), 1).Reinterpret<v128, uint4>().xy;
                    }

                    v128 result = loadu_si128(ptr);

                    result = shuffle_epi8(result, new v128(0, 1, 2, 3,   5, 6, 7, 8,    10, 11, 12, 13,   0, 0, 0, 0));

                    return result.Reinterpret<v128, uint4>().xy;
                }
            }
            
            return new uint2(*(uint*)((UInt40*)ptr + 0), 
                             *(uint*)((UInt40*)ptr + 1));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint8 Load_u48_to32x8(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (Avx2.IsAvx2Supported)
            {
                if (memoryAccess >= MemoryAccess.Allow64ByteRead)
                {
                    return Avx2.mm256_i32gather_epi32(ptr, (uint)sizeof(UInt48) * new uint8(0, 1, 2, 3, 4, 5, 6, 7), 1);
                }
            }
            
            return new uint8(Load_u48_to32x4(ptr,              MemoryAccess.Allow32ByteRead), 
                             Load_u48_to32x4((UInt48*)ptr + 4, memoryAccess < MemoryAccess.Allow64ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint4 Load_u48_to32x4(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (Avx2.IsAvx2Supported)
            {
                if (memoryAccess >= MemoryAccess.Allow32ByteRead)
                {
                    return Avx2.i32gather_epi32(ptr, ((uint)sizeof(UInt48) * new uint4(0, 1, 2, 3)).Reinterpret<uint4, v128>(), 1).Reinterpret<v128, uint4>();
                }
            }
            
            return new uint4(Load_u48_to32x3(ptr, memoryAccess), 
                             *(uint*)((UInt48*)ptr + 3));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint3 Load_u48_to32x3(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                if (memoryAccess >= MemoryAccess.Allow32ByteRead)
                {
                    if (Avx2.IsAvx2Supported)
                    {
                        return Avx2.i32gather_epi32(ptr, ((uint)sizeof(UInt48) * new uint4(0, 1, 2, 0)).Reinterpret<uint4, v128>(), 1).Reinterpret<v128, uint4>().xyz;
                    }
                }

                v128 result = loadu_si128(ptr);

                result = shuffle_epi8(result, new v128(0, 1, 2, 3,   6, 7, 8, 9,    12, 13, 14, 15,    0, 0, 0, 0));

                return result.Reinterpret<v128, uint4>().xyz;
            }
            else
            {
                return new uint3(Load_u48_to32x2(ptr, memoryAccess), 
                                 *(uint*)((UInt48*)ptr + 2));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint2 Load_u48_to32x2(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                if (memoryAccess >= MemoryAccess.Allow16ByteRead)
                {
                    if (Avx2.IsAvx2Supported)
                    {
                        return Avx2.i32gather_epi32(ptr, ((uint)sizeof(UInt48) * new uint4(0, 1, 0, 0)).Reinterpret<uint4, v128>(), 1).Reinterpret<v128, uint4>().xy;
                    }

                    v128 result = loadu_si128(ptr);

                    result = shuffle_epi8(result, new v128(0, 1, 2, 3,   6, 7, 8, 9,    12, 13, 14, 15,    0, 0, 0, 0));

                    return result.Reinterpret<v128, uint4>().xy;
                }
            }
            
            return new uint2(*(uint*)((UInt48*)ptr + 0), 
                             *(uint*)((UInt48*)ptr + 1));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint8 Load_u56_to32x8(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (Avx2.IsAvx2Supported)
            {
                if (memoryAccess >= MemoryAccess.Allow64ByteRead)
                {
                    return Avx2.mm256_i32gather_epi32(ptr, (uint)sizeof(UInt56) * new uint8(0, 1, 2, 3, 4, 5, 6, 7), 1);
                }
            }
            
            return new uint8(Load_u56_to32x4(ptr,              MemoryAccess.Allow32ByteRead), 
                             Load_u56_to32x4((UInt56*)ptr + 4, memoryAccess < MemoryAccess.Allow64ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint4 Load_u56_to32x4(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (Avx2.IsAvx2Supported)
            {
                if (memoryAccess >= MemoryAccess.Allow32ByteRead)
                {
                    return Avx2.i32gather_epi32(ptr, ((uint)sizeof(UInt56) * new uint4(0, 1, 2, 3)).Reinterpret<uint4, v128>(), 1).Reinterpret<v128, uint4>();
                }
            }
            
            return new uint4(Load_u56_to32x2(ptr,              MemoryAccess.Allow16ByteRead), 
                             Load_u56_to32x2((UInt56*)ptr + 2, memoryAccess < MemoryAccess.Allow32ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint3 Load_u56_to32x3(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (Avx2.IsAvx2Supported)
            {
                if (memoryAccess >= MemoryAccess.Allow32ByteRead)
                {
                    return Avx2.i32gather_epi32(ptr, ((uint)sizeof(UInt56) * new uint4(0, 1, 2, 0)).Reinterpret<uint4, v128>(), 1).Reinterpret<v128, uint4>().xyz;
                }
            }
            
            return new uint3(Load_u56_to32x2(ptr, memoryAccess), 
                             *(uint*)((UInt56*)ptr + 2));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint2 Load_u56_to32x2(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                if (memoryAccess >= MemoryAccess.Allow16ByteRead)
                {
                    if (Avx2.IsAvx2Supported)
                    {
                        return Avx2.i32gather_epi32(ptr, ((uint)sizeof(UInt56) * new uint4(0, 1, 0, 0)).Reinterpret<uint4, v128>(), 1).Reinterpret<v128, uint4>().xy;
                    }

                    v128 result = loadu_si128(ptr);

                    result = shuffle_epi8(result, new v128(0, 1, 2, 3,   7, 8, 9, 10,    0, 0, 0, 0, 0, 0, 0, 0));

                    return result.Reinterpret<v128, uint4>().xy;
                }
            }
            
            return new uint2(*(uint*)((UInt56*)ptr + 0), 
                             *(uint*)((UInt56*)ptr + 1));
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint8 Load_i24_to32x8(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (Avx2.IsAvx2Supported)
            {
                if (memoryAccess >= MemoryAccess.Allow32ByteRead)
                {
                    v256 result = Avx2.mm256_i32gather_epi32(ptr, (uint)sizeof(Int24) * new uint8(0, 1, 2, 3, 4, 5, 6, 7), 1);

                    v256 sign = mm256_srai_epi8(result, 7);
                    sign = Avx2.mm256_shuffle_epi8(sign, new v256(2, 2, 2, 2,   5, 5, 5, 5,   8, 8, 8, 8,   11, 11, 11, 11,
                                                                  2, 2, 2, 2,   5, 5, 5, 5,   8, 8, 8, 8,   11, 11, 11, 11));

                    return Avx2.mm256_blendv_epi8(result, sign, new v256(0, 1, 2, -1,   3, 4, 5, -1,   6, 7, 8, -1,   9, 10, 11, -1,
                                                                         0, 1, 2, -1,   3, 4, 5, -1,   6, 7, 8, -1,   9, 10, 11, -1));
                }
            }
            
            return new uint8(Load_i24_to32x4(ptr,             MemoryAccess.Allow16ByteRead), 
                             Load_i24_to32x4((Int24*)ptr + 4, memoryAccess < MemoryAccess.Allow32ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint4 Load_i24_to32x4(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 result;
                if (memoryAccess >= MemoryAccess.Allow16ByteRead)
                { 
                    result = loadu_si128(ptr);
                }
                else
                {
                    result = cvtsi64x_si128(      *((long*)((byte*)ptr + 0)));
                    result = insert_epi32(result, *((uint*)((byte*)ptr + 8)), 2);
                }
                
                v128 sign = srai_epi8(result, 7);
                sign = shuffle_epi8(sign, new v128(2, 2, 2, 2,   5, 5, 5, 5,   8, 8, 8, 8,   11, 11, 11, 11));

                result = shuffle_epi8(result, new v128(0, 1, 2, -1,   3, 4, 5, -1,   6, 7, 8, -1,   9, 10, 11, -1));

                result = blendv_epi8(result, sign, new v128(0, 1, 2, -1,   3, 4, 5, -1,   6, 7, 8, -1,   9, 10, 11, -1));

                return result.Reinterpret<v128, uint4>();
            }
            else
            {
                return new uint4(Int24.To_uint((Int24*)ptr + 0, MemoryAccess.Allow4ByteRead), 
                                 Int24.To_uint((Int24*)ptr + 1, MemoryAccess.Allow4ByteRead), 
                                 Int24.To_uint((Int24*)ptr + 2, MemoryAccess.Allow4ByteRead), 
                                 Int24.To_uint((Int24*)ptr + 3, memoryAccess < MemoryAccess.Allow16ByteRead ? MemoryAccess.Strict : memoryAccess));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint3 Load_i24_to32x3(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 result;
                if (memoryAccess >= MemoryAccess.Allow16ByteRead)
                {
                    result = loadu_si128(ptr);
                }
                else
                {
                    result = cvtsi64x_si128(     *((long*)((byte*)ptr + 0)));
                    result = insert_epi8(result, *((byte*)((byte*)ptr + 8)), 8);
                }
                
                v128 sign = srai_epi8(result, 7);
                sign = shuffle_epi8(sign, new v128(2, 2, 2, 2,   5, 5, 5, 5,   8, 8, 8, 8,   11, 11, 11, 11));

                result = shuffle_epi8(result, new v128(0, 1, 2, -1,   3, 4, 5, -1,   6, 7, 8, -1,   9, 10, 11, -1));

                result = blendv_epi8(result, sign, new v128(0, 1, 2, -1,   3, 4, 5, -1,   6, 7, 8, -1,   9, 10, 11, -1));

                return result.Reinterpret<v128, uint4>().xyz;
            }
            else
            {
                return new uint3(Int24.To_uint((Int24*)ptr + 0, MemoryAccess.Allow4ByteRead), 
                                 Int24.To_uint((Int24*)ptr + 1, MemoryAccess.Allow4ByteRead), 
                                 Int24.To_uint((Int24*)ptr + 2, memoryAccess < MemoryAccess.Allow16ByteRead ? MemoryAccess.Strict : memoryAccess));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint2 Load_i24_to32x2(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 result;
                if (memoryAccess >= MemoryAccess.Allow16ByteRead)
                {
                    result = loadu_si128(ptr);
                }
                else
                {
                    result = cvtsi32_si128(       *((int*)   ((byte*)ptr + 0)));
                    result = insert_epi16(result, *((ushort*)((byte*)ptr + 4)), 2);
                }
                
                v128 sign = srai_epi8(result, 7);
                sign = shuffle_epi8(sign, new v128(2, 2, 2, 2,   5, 5, 5, 5,   8, 8, 8, 8,   11, 11, 11, 11));

                result = shuffle_epi8(result, new v128(0, 1, 2, -1,   3, 4, 5, -1,   6, 7, 8, -1,   9, 10, 11, -1));

                result = blendv_epi8(result, sign, new v128(0, 1, 2, -1,   3, 4, 5, -1,   6, 7, 8, -1,   9, 10, 11, -1));

                return result.Reinterpret<v128, uint4>().xy;
            }
            else
            {
                return new uint2(Int24.To_uint((Int24*)ptr + 0, MemoryAccess.Allow4ByteRead), 
                                 Int24.To_uint((Int24*)ptr + 1, memoryAccess < MemoryAccess.Allow8ByteRead ? MemoryAccess.Strict : memoryAccess));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint8 Load_i40_to32x8(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u40_to32x8(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint4 Load_i40_to32x4(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u40_to32x4(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint3 Load_i40_to32x3(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u40_to32x3(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint2 Load_i40_to32x2(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u40_to32x2(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint8 Load_i48_to32x8(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u48_to32x8(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint4 Load_i48_to32x4(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u48_to32x4(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint3 Load_i48_to32x3(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u48_to32x3(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint2 Load_i48_to32x2(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u48_to32x2(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint8 Load_i56_to32x8(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u56_to32x8(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint4 Load_i56_to32x4(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u56_to32x4(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint3 Load_i56_to32x3(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u56_to32x3(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint2 Load_i56_to32x2(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u56_to32x2(ptr, memoryAccess);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort16 Load_u24_to16x16(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new ushort16(Load_u24_to16x8(ptr,              MemoryAccess.Allow32ByteRead), 
                                Load_u24_to16x8((UInt24*)ptr + 8, memoryAccess < MemoryAccess.Allow64ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort8 Load_u24_to16x8(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new ushort8(Load_u24_to16x4(ptr,              MemoryAccess.Allow16ByteRead), 
                               Load_u24_to16x4((UInt24*)ptr + 4, memoryAccess < MemoryAccess.Allow32ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort4 Load_u24_to16x4(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 result;
                if (memoryAccess >= MemoryAccess.Allow16ByteRead)
                { 
                    result = loadu_si128(ptr);
                }
                else
                {
                    result = cvtsi64x_si128(      *((long*)((byte*)ptr + 0)));
                    result = insert_epi32(result, *((uint*)((byte*)ptr + 8)), 2);
                }
                
                result = shuffle_epi8(result, new v128(0, 1,   3, 4,   6, 7,   9, 10,   0, 0, 0, 0, 0, 0, 0, 0));

                return result;
            }
            else
            {
                return new ushort4(*(ushort*)((UInt24*)ptr + 0),
                                   *(ushort*)((UInt24*)ptr + 1),
                                   *(ushort*)((UInt24*)ptr + 2),
                                   *(ushort*)((UInt24*)ptr + 3));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort3 Load_u24_to16x3(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 result;
                if (memoryAccess >= MemoryAccess.Allow16ByteRead)
                { 
                    result = loadu_si128(ptr);
                }
                else
                {
                    result = cvtsi64x_si128(     *((long*)((byte*)ptr + 0)));
                    result = insert_epi8(result, *((byte*)((byte*)ptr + 8)), 8);
                }
                
                result = shuffle_epi8(result, new v128(0, 1,   3, 4,   6, 7,   9, 10,   0, 0, 0, 0, 0, 0, 0, 0));

                return result;
            }
            else
            {
                return new ushort3(*(ushort*)((UInt24*)ptr + 0),
                                   *(ushort*)((UInt24*)ptr + 1),
                                   *(ushort*)((UInt24*)ptr + 2));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort2 Load_u24_to16x2(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 result;
                if (memoryAccess >= MemoryAccess.Allow16ByteRead)
                { 
                    result = loadu_si128(ptr);
                }
                else
                {
                    result = cvtsi32_si128(      *((int*) ((byte*)ptr + 0)));
                    result = insert_epi8(result, *((byte*)((byte*)ptr + 4)), 4);
                }
                
                result = shuffle_epi8(result, new v128(0, 1,   3, 4,   6, 7,   9, 10,   0, 0, 0, 0, 0, 0, 0, 0));

                return result;
            }
            else
            {
                return new ushort2(*(ushort*)((UInt24*)ptr + 0),
                                   *(ushort*)((UInt24*)ptr + 1));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort16 Load_u40_to16x16(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new ushort16(Load_u40_to16x8(ptr,              MemoryAccess.Allow64ByteRead), 
                                Load_u40_to16x8((UInt40*)ptr + 8, memoryAccess < MemoryAccess.Allow128ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort8 Load_u40_to16x8(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new ushort8(Load_u40_to16x4(ptr,              MemoryAccess.Allow32ByteRead), 
                               Load_u40_to16x4((UInt40*)ptr + 4, memoryAccess < MemoryAccess.Allow64ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort4 Load_u40_to16x4(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (Avx2.IsAvx2Supported)
            {
                if (memoryAccess >= MemoryAccess.Allow32ByteRead)
                {
                    return (ushort4)Load_u40_to32x4(ptr, memoryAccess);
                }
            }

            return new ushort4(Load_u40_to16x3((UInt40*)ptr + 0, MemoryAccess.Allow16ByteRead),
                               *(ushort*)     ((UInt40*)ptr + 3));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort3 Load_u40_to16x3(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 result;
                if (memoryAccess >= MemoryAccess.Allow16ByteRead)
                { 
                    result = loadu_si128(ptr);
                }
                else
                {
                    result = cvtsi64x_si128(      *((long*)  ((byte*)ptr + 0)));
                    result = insert_epi32(result, *((uint*)  ((byte*)ptr + 8)),  2);
                    result = insert_epi16(result, *((ushort*)((byte*)ptr + 12)), 6);
                    result = insert_epi8 (result, *((byte*)  ((byte*)ptr + 14)), 14);
                }
                
                result = shuffle_epi8(result, new v128(0, 1,   5, 6,   10, 11,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0));

                return result;
            }
            else
            {
                return new ushort3(*(ushort*)((UInt40*)ptr + 0),
                                   *(ushort*)((UInt40*)ptr + 1),
                                   *(ushort*)((UInt40*)ptr + 2));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort2 Load_u40_to16x2(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 result;
                if (memoryAccess >= MemoryAccess.Allow16ByteRead)
                { 
                    result = loadu_si128(ptr);
                }
                else
                {
                    result = cvtsi64x_si128(      *((long*)  ((byte*)ptr + 0)));
                    result = insert_epi16(result, *((ushort*)((byte*)ptr + 8)), 4);
                }
                
                result = shuffle_epi8(result, new v128(0, 1,   5, 6,   10, 11,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0));

                return result;
            }
            else
            {
                return new ushort2(*(ushort*)((UInt40*)ptr + 0),
                                   *(ushort*)((UInt40*)ptr + 1));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort16 Load_u48_to16x16(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new ushort16(Load_u48_to16x8(ptr,              MemoryAccess.Allow64ByteRead), 
                                Load_u48_to16x8((UInt48*)ptr + 8, memoryAccess < MemoryAccess.Allow128ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort8 Load_u48_to16x8(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new ushort8(Load_u48_to16x4(ptr,              MemoryAccess.Allow32ByteRead), 
                               Load_u48_to16x4((UInt48*)ptr + 4, memoryAccess < MemoryAccess.Allow64ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort4 Load_u48_to16x4(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (Avx2.IsAvx2Supported)
            {
                if (memoryAccess >= MemoryAccess.Allow32ByteRead)
                {
                    return (ushort4)Load_u48_to32x4(ptr, memoryAccess);
                }
            }

            return new ushort4(Load_u48_to16x3((UInt48*)ptr + 0),
                               *(ushort*)     ((UInt48*)ptr + 3));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort3 Load_u48_to16x3(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 result = loadu_si128(ptr);
                
                result = shuffle_epi8(result, new v128(0, 1,   6, 7,   12, 13,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0));

                return result;
            }
            else
            {
                return new ushort3(Load_u48_to16x2((UInt48*)ptr + 0, MemoryAccess.Allow16ByteRead),
                                   *(ushort*)     ((UInt48*)ptr + 2));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort2 Load_u48_to16x2(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 result;
                if (memoryAccess >= MemoryAccess.Allow16ByteRead)
                { 
                    result = loadu_si128(ptr);
                }
                else
                {
                    result = cvtsi64x_si128(      *((long*)((byte*)ptr + 0)));
                    result = insert_epi32(result, *((uint*)((byte*)ptr + 8)), 2);
                }
                
                result = shuffle_epi8(result, new v128(0, 1,   6, 7,   12, 13,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0));

                return result;
            }
            else
            {
                return new ushort2(*(ushort*)((UInt48*)ptr + 0),
                                   *(ushort*)((UInt48*)ptr + 1));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort16 Load_u56_to16x16(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new ushort16(Load_u56_to16x8(ptr,              MemoryAccess.Allow64ByteRead), 
                                Load_u56_to16x8((UInt56*)ptr + 8, memoryAccess < MemoryAccess.Allow128ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort8 Load_u56_to16x8(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new ushort8(Load_u56_to16x4(ptr,              MemoryAccess.Allow32ByteRead), 
                               Load_u56_to16x4((UInt56*)ptr + 4, memoryAccess < MemoryAccess.Allow64ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort4 Load_u56_to16x4(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (Avx2.IsAvx2Supported)
            {
                if (memoryAccess >= MemoryAccess.Allow32ByteRead)
                {
                    return (ushort4)Load_u56_to32x4(ptr, memoryAccess);
                }
            }

            return new ushort4(Load_u56_to16x3((UInt56*)ptr + 0),
                               *(ushort*)     ((UInt56*)ptr + 3));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort3 Load_u56_to16x3(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 result = loadu_si128(ptr);
                
                result = shuffle_epi8(result, new v128(0, 1,   7, 8,    14, 15,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0));

                return result;
            }
            else
            {
                return new ushort3(Load_u56_to16x2((UInt56*)ptr + 0, MemoryAccess.Allow16ByteRead),
                                   *(ushort*)     ((UInt56*)ptr + 2));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort2 Load_u56_to16x2(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                if (memoryAccess >= MemoryAccess.Allow16ByteRead)
                { 
                    v128 result = loadu_si128(ptr);
                    result = shuffle_epi8(result, new v128(0, 1,   7, 8,    14, 15,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0));

                    return result;
                }
            }
            
            return new ushort2(*(ushort*)((UInt56*)ptr + 0),
                               *(ushort*)((UInt56*)ptr + 1));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort16 Load_i24_to16x16(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u24_to16x16(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort8 Load_i24_to16x8(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u24_to16x8(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort4 Load_i24_to16x4(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u24_to16x4(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort3 Load_i24_to16x3(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u24_to16x3(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort2 Load_i24_to16x2(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u24_to16x2(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort16 Load_i40_to16x16(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u40_to16x16(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort8 Load_i40_to16x8(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u40_to16x8(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort4 Load_i40_to16x4(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u40_to16x4(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort3 Load_i40_to16x3(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u40_to16x3(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort2 Load_i40_to16x2(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u40_to16x2(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort16 Load_i48_to16x16(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u48_to16x16(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort8 Load_i48_to16x8(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u48_to16x8(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort4 Load_i48_to16x4(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u48_to16x4(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort3 Load_i48_to16x3(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u48_to16x3(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort2 Load_i48_to16x2(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u48_to16x2(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort16 Load_i56_to16x16(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u56_to16x16(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort8 Load_i56_to16x8(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u56_to16x8(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort4 Load_i56_to16x4(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u56_to16x4(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort3 Load_i56_to16x3(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u56_to16x3(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort2 Load_i56_to16x2(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u56_to16x2(ptr, memoryAccess);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte32 Load_u24_to8x32(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new byte32(Load_u24_to8x16(ptr,               MemoryAccess.Allow64ByteRead), 
                              Load_u24_to8x16((UInt24*)ptr + 16, memoryAccess < MemoryAccess.Allow128ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte16 Load_u24_to8x16(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new byte16(Load_u24_to8x8(ptr,              MemoryAccess.Allow32ByteRead), 
                              Load_u24_to8x8((UInt24*)ptr + 8, memoryAccess < MemoryAccess.Allow64ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte8 Load_u24_to8x8(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new byte8(Load_u24_to8x4(ptr,              MemoryAccess.Allow16ByteRead), 
                             Load_u24_to8x4((UInt24*)ptr + 4, memoryAccess < MemoryAccess.Allow32ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte4 Load_u24_to8x4(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 result;
                if (memoryAccess >= MemoryAccess.Allow16ByteRead)
                { 
                    result = loadu_si128(ptr);
                }
                else
                {
                    result = cvtsi64x_si128(      *((long*)((byte*)ptr + 0)));
                    result = insert_epi32(result, *((uint*)((byte*)ptr + 8)), 2);
                }
                
                result = shuffle_epi8(result, new v128(0,   3,   6,   9,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));

                return result;
            }
            else
            {
                return new byte4(*(byte*)((UInt24*)ptr + 0),
                                 *(byte*)((UInt24*)ptr + 1),
                                 *(byte*)((UInt24*)ptr + 2),
                                 *(byte*)((UInt24*)ptr + 3));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte3 Load_u24_to8x3(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 result;
                if (memoryAccess >= MemoryAccess.Allow16ByteRead)
                { 
                    result = loadu_si128(ptr);
                }
                else
                {
                    result = cvtsi64x_si128(     *((long*)((byte*)ptr + 0)));
                    result = insert_epi8(result, *((byte*)((byte*)ptr + 8)), 8);
                }
                
                result = shuffle_epi8(result, new v128(0,   3,   6,   9,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));

                return result;
            }
            else
            {
                return new byte3(*(byte*)((UInt24*)ptr + 0),
                                 *(byte*)((UInt24*)ptr + 1),
                                 *(byte*)((UInt24*)ptr + 2));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte2 Load_u24_to8x2(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 result;
                if (memoryAccess >= MemoryAccess.Allow16ByteRead)
                { 
                    result = loadu_si128(ptr);
                }
                else
                {
                    result = cvtsi32_si128(      *((int*) ((byte*)ptr + 0)));
                    result = insert_epi8(result, *((byte*)((byte*)ptr + 4)), 4);
                }
                
                result = shuffle_epi8(result, new v128(0,   3,   6,   9,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));

                return result;
            }
            else
            {
                return new byte2(*(byte*)((UInt24*)ptr + 0),
                                 *(byte*)((UInt24*)ptr + 1));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte32 Load_u40_to8x32(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new byte32(Load_u40_to8x16(ptr,               MemoryAccess.Allow128ByteRead), 
                              Load_u40_to8x16((UInt40*)ptr + 16, memoryAccess < MemoryAccess.Allow256ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte16 Load_u40_to8x16(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new byte16(Load_u40_to8x8(ptr,              MemoryAccess.Allow64ByteRead), 
                              Load_u40_to8x8((UInt40*)ptr + 8, memoryAccess < MemoryAccess.Allow128ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte8 Load_u40_to8x8(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new byte8(Load_u40_to8x4(ptr,              MemoryAccess.Allow32ByteRead), 
                             Load_u40_to8x4((UInt40*)ptr + 4, memoryAccess < MemoryAccess.Allow64ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte4 Load_u40_to8x4(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (Avx2.IsAvx2Supported)
            {
                if (memoryAccess >= MemoryAccess.Allow32ByteRead)
                {
                    return (byte4)Load_u40_to32x4(ptr, memoryAccess);
                }
            }

            return new byte4(Load_u40_to8x3((UInt40*)ptr + 0, MemoryAccess.Allow16ByteRead),
                             *(byte*)      ((UInt40*)ptr + 3));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte3 Load_u40_to8x3(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                if (memoryAccess >= MemoryAccess.Allow16ByteRead)
                { 
                    v128 result = loadu_si128(ptr);
                    result = shuffle_epi8(result, new v128(0,   5,   10,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));

                    return result;
                }
            }
            
            return new byte3(*(byte*)((UInt40*)ptr + 0),
                             *(byte*)((UInt40*)ptr + 1),
                             *(byte*)((UInt40*)ptr + 2));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte2 Load_u40_to8x2(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 result;
                if (memoryAccess >= MemoryAccess.Allow16ByteRead)
                { 
                    result = loadu_si128(ptr);
                }
                else
                {
                    result = cvtsi64x_si128(      *((long*)  ((byte*)ptr + 0)));
                    result = insert_epi16(result, *((ushort*)((byte*)ptr + 8)), 4);
                }
                
                result = shuffle_epi8(result, new v128(0,   5,   10,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));

                return result;
            }
            else
            {
                return new byte2(*(byte*)((UInt40*)ptr + 0),
                                 *(byte*)((UInt40*)ptr + 1));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte32 Load_u48_to8x32(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new byte32(Load_u48_to8x16(ptr,               MemoryAccess.Allow128ByteRead), 
                              Load_u48_to8x16((UInt48*)ptr + 16, memoryAccess < MemoryAccess.Allow256ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte16 Load_u48_to8x16(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new byte16(Load_u48_to8x8(ptr,              MemoryAccess.Allow64ByteRead), 
                              Load_u48_to8x8((UInt48*)ptr + 8, memoryAccess < MemoryAccess.Allow128ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte8 Load_u48_to8x8(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new byte8(Load_u48_to8x4(ptr,              MemoryAccess.Allow32ByteRead), 
                             Load_u48_to8x4((UInt48*)ptr + 4, memoryAccess < MemoryAccess.Allow64ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte4 Load_u48_to8x4(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (Avx2.IsAvx2Supported)
            {
                if (memoryAccess >= MemoryAccess.Allow32ByteRead)
                {
                    return (byte4)Load_u48_to32x4(ptr, memoryAccess);
                }
            }

            return new byte4(Load_u48_to8x3((UInt48*)ptr + 0),
                             *(byte*)      ((UInt48*)ptr + 3));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte3 Load_u48_to8x3(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 result = loadu_si128(ptr);
                
                result = shuffle_epi8(result, new v128(0,   6,   12,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));

                return result;
            }
            else
            {
                return new byte3(Load_u48_to8x2((UInt48*)ptr + 0, MemoryAccess.Allow16ByteRead),
                                 *(byte*)      ((UInt48*)ptr + 2));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte2 Load_u48_to8x2(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 result;
                if (memoryAccess >= MemoryAccess.Allow16ByteRead)
                { 
                    result = loadu_si128(ptr);
                }
                else
                {
                    result = cvtsi64x_si128(      *((long*)((byte*)ptr + 0)));
                    result = insert_epi32(result, *((uint*)((byte*)ptr + 8)), 2);
                }
                
                result = shuffle_epi8(result, new v128(0,   6,   12,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));

                return result;
            }
            else
            {
                return new byte2(*(byte*)((UInt48*)ptr + 0),
                                 *(byte*)((UInt48*)ptr + 1));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte32 Load_u56_to8x32(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new byte32(Load_u56_to8x16(ptr,               MemoryAccess.Allow128ByteRead), 
                              Load_u56_to8x16((UInt56*)ptr + 16, memoryAccess < MemoryAccess.Allow256ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte16 Load_u56_to8x16(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new byte16(Load_u56_to8x8(ptr,              MemoryAccess.Allow64ByteRead), 
                              Load_u56_to8x8((UInt56*)ptr + 8, memoryAccess < MemoryAccess.Allow128ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte8 Load_u56_to8x8(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return new byte8(Load_u56_to8x4(ptr,              MemoryAccess.Allow32ByteRead), 
                             Load_u56_to8x4((UInt56*)ptr + 4, memoryAccess < MemoryAccess.Allow64ByteRead ? MemoryAccess.Strict : memoryAccess));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte4 Load_u56_to8x4(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (Avx2.IsAvx2Supported)
            {
                if (memoryAccess >= MemoryAccess.Allow32ByteRead)
                {
                    return (byte4)Load_u56_to32x4(ptr, memoryAccess);
                }
            }

            return new byte4(Load_u56_to8x3((UInt56*)ptr + 0),
                             *(byte*)      ((UInt56*)ptr + 3));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte3 Load_u56_to8x3(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 result = loadu_si128(ptr);
                
                result = shuffle_epi8(result, new v128(0,   7,   14,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));

                return result;
            }
            else
            {
                return new byte3(Load_u56_to8x2((UInt56*)ptr + 0, MemoryAccess.Allow16ByteRead),
                                 *(byte*)      ((UInt56*)ptr + 2));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte2 Load_u56_to8x2(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                if (memoryAccess >= MemoryAccess.Allow16ByteRead)
                { 
                    v128 result = loadu_si128(ptr);
                    result = shuffle_epi8(result, new v128(0,   7,   14,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));

                    return result;
                }
                
            }
            
            return new byte2(*(byte*)((UInt56*)ptr + 0),
                             *(byte*)((UInt56*)ptr + 1));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte32 Load_i24_to8x32(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u24_to8x32(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte16 Load_i24_to8x16(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u24_to8x16(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte8 Load_i24_to8x8(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u24_to8x8(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte4 Load_i24_to8x4(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u24_to8x4(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte3 Load_i24_to8x3(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u24_to8x3(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte2 Load_i24_to8x2(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u24_to8x2(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte32 Load_i40_to8x32(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u40_to8x32(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte16 Load_i40_to8x16(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u40_to8x16(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte8 Load_i40_to8x8(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u40_to8x8(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte4 Load_i40_to8x4(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u40_to8x4(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte3 Load_i40_to8x3(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u40_to8x3(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte2 Load_i40_to8x2(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u40_to8x2(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte32 Load_i48_to8x32(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u48_to8x32(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte16 Load_i48_to8x16(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u48_to8x16(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte8 Load_i48_to8x8(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u48_to8x8(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte4 Load_i48_to8x4(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u48_to8x4(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte3 Load_i48_to8x3(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u48_to8x3(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte2 Load_i48_to8x2(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u48_to8x2(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte32 Load_i56_to8x32(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u56_to8x32(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte16 Load_i56_to8x16(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u56_to8x16(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte8 Load_i56_to8x8(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u56_to8x8(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte4 Load_i56_to8x4(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u56_to8x4(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte3 Load_i56_to8x3(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u56_to8x3(ptr, memoryAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte2 Load_i56_to8x2(void* ptr, MemoryAccess memoryAccess = MemoryAccess.Strict)
        {
            return Load_u56_to8x2(ptr, memoryAccess);
        }
    }
}
