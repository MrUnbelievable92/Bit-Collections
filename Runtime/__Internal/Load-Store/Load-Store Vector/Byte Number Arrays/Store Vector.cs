using System.Runtime.CompilerServices;
using Unity.Burst.Intrinsics;
using Unity.Mathematics;
using Unity.Collections;
using MaxMath;
using MaxMath.Intrinsics;

using static MaxMath.Intrinsics.Xse;
using static Unity.Burst.Intrinsics.X86;

namespace BitCollections
{
    unsafe internal static partial class LoadStore
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u64_to24(void* ptr, ulong4 value)
        {
            Store_i64_to24(ptr, (long4)value);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u64_to40(void* ptr, ulong4 value)
        {
            Store_i64_to40(ptr, (long4)value);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u64_to48(void* ptr, ulong4 value)
        {
            Store_i64_to48(ptr, (long4)value);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u64_to56(void* ptr, ulong4 value)
        {
            Store_i64_to56(ptr, (long4)value);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u64_to24(void* ptr, ulong3 value)
        {
            Store_i64_to24(ptr, (long3)value);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u64_to40(void* ptr, ulong3 value)
        {
            Store_i64_to40(ptr, (long3)value);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u64_to48(void* ptr, ulong3 value)
        {
            Store_i64_to48(ptr, (long3)value);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u64_to56(void* ptr, ulong3 value)
        {
            Store_i64_to56(ptr, (long3)value);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u64_to24(void* ptr, ulong2 value)
        {
            Store_i64_to24(ptr, (long2)value);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u64_to40(void* ptr, ulong2 value)
        {
            Store_i64_to40(ptr, (long2)value);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u64_to48(void* ptr, ulong2 value)
        {
            Store_i64_to48(ptr, (long2)value);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u64_to56(void* ptr, ulong2 value)
        {
            Store_i64_to56(ptr, (long2)value);
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i64_to24(void* ptr, long4 value)
        {
            if (Avx2.IsAvx2Supported)
            {
                v256 shuf = Avx2.mm256_shuffle_epi8(value, new v256(0, 1, 2,  8, 9, 10,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                                                    0, 1, 2,  8, 9, 10,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0));

                *((int*)ptr) = shuf.SInt0;
                *((short*)ptr + 2) = shuf.SShort2;
                *((int*)((short*)ptr + 3)) = shuf.SInt4;
                *((short*)ptr + 5) = shuf.SShort10;
            }
            else if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shufLo = shuffle_epi8(value.xy, new v128(0, 1, 2,  8, 9, 10,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                v128 shufHi = shuffle_epi8(value.zw, new v128(0, 1, 2,  8, 9, 10,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                
                *((int*)ptr) = shufLo.SInt0;
                *((short*)ptr + 2) = shufLo.SShort2;
                *((int*)((short*)ptr + 3)) = shufHi.SInt0;
                *((short*)ptr + 5) = shufHi.SShort2;
            }
            else
            {
                *((UInt24*)ptr + 0) = (UInt24)value.x;
                *((UInt24*)ptr + 1) = (UInt24)value.y;
                *((UInt24*)ptr + 2) = (UInt24)value.z;
                *((UInt24*)ptr + 3) = (UInt24)value.w;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i64_to40(void* ptr, long4 value)
        {
            if (Avx2.IsAvx2Supported)
            {
                v256 shuf = Avx2.mm256_shuffle_epi8(value, new v256(0, 1, 2, 3, 4,  8, 9, 10, 11, 12,   0, 0, 0, 0, 0, 0,
                                                                    0, 1, 2, 3, 4,  8, 9, 10, 11, 12,   0, 0, 0, 0, 0, 0));

                *((long*)ptr) = shuf.SLong0;
                *((short*)ptr + 4) = shuf.SShort4;
                *((long*)((short*)ptr + 5)) = shuf.SLong2;
                *((short*)ptr + 9) = shuf.SShort12;
            }
            else if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shufLo = shuffle_epi8(value.xy, new v128(0, 1, 2, 3, 4,  8, 9, 10, 11, 12,   0, 0, 0, 0, 0, 0));
                v128 shufHi = shuffle_epi8(value.zw, new v128(0, 1, 2, 3, 4,  8, 9, 10, 11, 12,   0, 0, 0, 0, 0, 0));
                
                *((long*)ptr) = shufLo.SLong0;
                *((short*)ptr + 4) = shufLo.SShort4;
                *((long*)((short*)ptr + 5)) = shufHi.SLong0;
                *((short*)ptr + 9) = shufHi.SShort4;
            }
            else
            {
                *((UInt40*)ptr + 0) = (UInt40)value.x;
                *((UInt40*)ptr + 1) = (UInt40)value.y;
                *((UInt40*)ptr + 2) = (UInt40)value.z;
                *((UInt40*)ptr + 3) = (UInt40)value.w;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i64_to48(void* ptr, long4 value)
        {
            if (Avx2.IsAvx2Supported)
            {
                v256 shuf = Avx2.mm256_shuffle_epi8(value, new v256(0, 1, 2, 3, 4, 5,  8, 9, 10, 11, 12, 13,   0, 0, 0, 0,
                                                                    0, 1, 2, 3, 4, 5,  8, 9, 10, 11, 12, 13,   0, 0, 0, 0));

                *((long*)ptr) = shuf.SLong0;
                *((int*)ptr + 2) = shuf.SInt2;
                *((long*)((int*)ptr + 3)) = shuf.SLong2;
                *((int*)ptr + 5) = shuf.SInt6;
            }
            else if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shufLo = shuffle_epi8(value.xy, new v128(0, 1, 2, 3, 4, 5,  8, 9, 10, 11, 12, 13,   0, 0, 0, 0));
                v128 shufHi = shuffle_epi8(value.zw, new v128(0, 1, 2, 3, 4, 5,  8, 9, 10, 11, 12, 13,   0, 0, 0, 0));
                
                *((long*)ptr) = shufLo.SLong0;
                *((int*)ptr + 2) = shufLo.SInt2;
                *((long*)((int*)ptr + 3)) = shufHi.SLong0;
                *((int*)ptr + 5) = shufHi.SInt2;
            }
            else
            {
                *((UInt48*)ptr + 0) = (UInt48)value.x;
                *((UInt48*)ptr + 1) = (UInt48)value.y;
                *((UInt48*)ptr + 2) = (UInt48)value.z;
                *((UInt48*)ptr + 3) = (UInt48)value.w;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i64_to56(void* ptr, long4 value)
        {
            if (Avx2.IsAvx2Supported)
            {
                v256 shuf = Avx2.mm256_shuffle_epi8(value, new v256(0, 1, 2, 3, 4, 5, 6,  8, 9, 10, 11, 12, 13, 14,   0, 0,
                                                                    0, 1, 2, 3, 4, 5, 6,  8, 9, 10, 11, 12, 13, 14,   0, 0));

                *((long*)ptr) = shuf.SLong0;
                *((int*)ptr + 2) = shuf.SInt2;
                *((short*)ptr + 6) = shuf.SShort6;
                *((long*)((short*)ptr + 7)) = shuf.SLong2;
                *((int*)((short*)ptr + 11)) = shuf.SInt6;
                *((short*)ptr + 13) = shuf.SShort14;
            }
            else if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shufLo = shuffle_epi8(value.xy, new v128(0, 1, 2, 3, 4, 5, 6,  8, 9, 10, 11, 12, 13, 14,   0, 0));
                v128 shufHi = shuffle_epi8(value.zw, new v128(0, 1, 2, 3, 4, 5, 6,  8, 9, 10, 11, 12, 13, 14,   0, 0));

                *((long*)ptr) = shufLo.SLong0;
                *((int*)ptr + 2) = shufLo.SInt2;
                *((short*)ptr + 6) = shufLo.SShort6;
                *((long*)((short*)ptr + 7)) = shufHi.SLong0;
                *((int*)((short*)ptr + 11)) = shufHi.SInt2;
                *((short*)ptr + 13) = shufHi.SShort6;
            }
            else
            {
                *((UInt56*)ptr + 0) = (UInt56)value.x;
                *((UInt56*)ptr + 1) = (UInt56)value.y;
                *((UInt56*)ptr + 2) = (UInt56)value.z;
                *((UInt56*)ptr + 3) = (UInt56)value.w;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i64_to24(void* ptr, long3 value)
        {
            if (Avx2.IsAvx2Supported)
            {
                v128 shuf = shuffle_epi8(Avx.mm256_castsi256_si128(value), new v128(0, 1, 2,  8, 9, 10,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0));

                *((int*)ptr) = shuf.SInt0;
                *((short*)ptr + 2) = shuf.SShort2;
                *((UInt24*)((short*)ptr + 3)) = (UInt24)value.z;
            }
            else if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf = shuffle_epi8(value.xy, new v128(0, 1, 2,  8, 9, 10,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                
                *((int*)ptr) = shuf.SInt0;
                *((short*)ptr + 2) = shuf.SShort2;
                *((UInt24*)((short*)ptr + 3)) = (UInt24)value.z;
            }
            else
            {
                *((UInt24*)ptr + 0) = (UInt24)value.x;
                *((UInt24*)ptr + 1) = (UInt24)value.y;
                *((UInt24*)ptr + 2) = (UInt24)value.z;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i64_to40(void* ptr, long3 value)
        {
            if (Avx2.IsAvx2Supported)
            {
                v128 shuf = shuffle_epi8(Avx.mm256_castsi256_si128(value), new v128(0, 1, 2, 3, 4,  8, 9, 10, 11, 12,   0, 0, 0, 0, 0, 0));

                *((long*)ptr) = shuf.SLong0;
                *((short*)ptr + 4) = shuf.SShort4;
                *((UInt40*)((short*)ptr + 5)) = (UInt40)value.z;
            }
            else if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf = shuffle_epi8(value.xy, new v128(0, 1, 2, 3, 4,  8, 9, 10, 11, 12,   0, 0, 0, 0, 0, 0));
                
                *((long*)ptr) = shuf.SLong0;
                *((short*)ptr + 4) = shuf.SShort4;
                *((UInt40*)((short*)ptr + 5)) = (UInt40)value.z;
            }
            else
            {
                *((UInt40*)ptr + 0) = (UInt40)value.x;
                *((UInt40*)ptr + 1) = (UInt40)value.y;
                *((UInt40*)ptr + 2) = (UInt40)value.z;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i64_to48(void* ptr, long3 value)
        {
            if (Avx2.IsAvx2Supported)
            {
                v128 shuf = shuffle_epi8(Avx.mm256_castsi256_si128(value), new v128(0, 1, 2, 3, 4, 5,  8, 9, 10, 11, 12, 13,   0, 0, 0, 0));

                *((long*)ptr) = shuf.SLong0;
                *((int*)ptr + 2) = shuf.SInt2;
                *((UInt48*)((int*)ptr + 3)) = (UInt48)value.z;
            }
            else if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf = shuffle_epi8(value.xy, new v128(0, 1, 2, 3, 4, 5,  8, 9, 10, 11, 12, 13,   0, 0, 0, 0));
                
                *((long*)ptr) = shuf.SLong0;
                *((int*)ptr + 2) = shuf.SInt2;
                *((UInt48*)((int*)ptr + 3)) = (UInt48)value.z;
            }
            else
            {
                *((UInt48*)ptr + 0) = (UInt48)value.x;
                *((UInt48*)ptr + 1) = (UInt48)value.y;
                *((UInt48*)ptr + 2) = (UInt48)value.z;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i64_to56(void* ptr, long3 value)
        {
            if (Avx2.IsAvx2Supported)
            {
                v128 shuf = shuffle_epi8(Avx.mm256_castsi256_si128(value), new v128(0, 1, 2, 3, 4, 5, 6,  8, 9, 10, 11, 12, 13, 14,   0, 0));

                *((long*)ptr) = shuf.SLong0;
                *((int*)ptr + 2) = shuf.SInt2;
                *((short*)ptr + 6) = shuf.SShort6;
                *((UInt56*)((short*)ptr + 7)) = (UInt56)value.z;
            }
            else if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf = shuffle_epi8(value.xy, new v128(0, 1, 2, 3, 4, 5, 6,  8, 9, 10, 11, 12, 13, 14,   0, 0));

                *((long*)ptr) = shuf.SLong0;
                *((int*)ptr + 2) = shuf.SInt2;
                *((short*)ptr + 6) = shuf.SShort6;
                *((UInt56*)((short*)ptr + 7)) = (UInt56)value.z;
            }
            else
            {
                *((UInt56*)ptr + 0) = (UInt56)value.x;
                *((UInt56*)ptr + 1) = (UInt56)value.y;
                *((UInt56*)ptr + 2) = (UInt56)value.z;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i64_to24(void* ptr, long2 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf = shuffle_epi8(value, new v128(0, 1, 2,  8, 9, 10,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                
                *((int*)ptr) = shuf.SInt0;
                *((short*)ptr + 2) = shuf.SShort2;
            }
            else
            {
                *((UInt24*)ptr + 0) = (UInt24)value.x;
                *((UInt24*)ptr + 1) = (UInt24)value.y;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i64_to40(void* ptr, long2 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf = shuffle_epi8(value, new v128(0, 1, 2, 3, 4,  8, 9, 10, 11, 12,   0, 0, 0, 0, 0, 0));
                
                *((long*)ptr) = shuf.SLong0;
                *((short*)ptr + 4) = shuf.SShort4;
            }
            else
            {
                *((UInt40*)ptr + 0) = (UInt40)value.x;
                *((UInt40*)ptr + 1) = (UInt40)value.y;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i64_to48(void* ptr, long2 value)
        {if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf = shuffle_epi8(value, new v128(0, 1, 2, 3, 4, 5,  8, 9, 10, 11, 12, 13,   0, 0, 0, 0));
                
                *((long*)ptr) = shuf.SLong0;
                *((int*)ptr + 2) = shuf.SInt2;
            }
            else
            {
                *((UInt48*)ptr + 0) = (UInt48)value.x;
                *((UInt48*)ptr + 1) = (UInt48)value.y;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i64_to56(void* ptr, long2 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf = shuffle_epi8(value, new v128(0, 1, 2, 3, 4, 5, 6,  8, 9, 10, 11, 12, 13, 14,   0, 0));

                *((long*)ptr) = shuf.SLong0;
                *((int*)ptr + 2) = shuf.SInt2;
                *((short*)ptr + 6) = shuf.SShort6;
            }
            else
            {
                *((UInt56*)ptr + 0) = (UInt56)value.x;
                *((UInt56*)ptr + 1) = (UInt56)value.y;
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u32_to24(void* ptr, uint8 value)
        {
            Store_i32_to24(ptr, (int8)value);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u32_to40(void* ptr, uint8 value)
        {
            if (Avx2.IsAvx2Supported)
            {
                v256 shufLo = Avx2.mm256_shuffle_epi8(value, new v256(0, 1, 2, 3, -1,   4, 5, 6, 7, -1,   8, 9, 10, 11, -1,   12,
                                                                      0, 1, 2, 3, -1,   4, 5, 6, 7, -1,   8, 9, 10, 11, -1,   12));
                v256 shufHi = Avx2.mm256_shuffle_epi8(value, new v256(13, 14, 15, -1,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                                                      13, 14, 15, -1,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                
                *((v128*)((byte*)ptr + 0))  = shufLo.Lo128;
                *((int*) ((byte*)ptr + 16)) = shufHi.SInt0;
                *((v128*)((byte*)ptr + 20)) = shufLo.Hi128;
                *((int*) ((byte*)ptr + 36)) = shufHi.SInt4;
            }
            else if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shufLoLo = shuffle_epi8(value.v4_0.Reinterpret<uint4, v128>(), new v128(0, 1, 2, 3, -1,   4, 5, 6, 7, -1,   8, 9, 10, 11, -1,   12));
                v128 shufLoHi = shuffle_epi8(value.v4_0.Reinterpret<uint4, v128>(), new v128(13, 14, 15, -1,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                v128 shufHiLo = shuffle_epi8(value.v4_4.Reinterpret<uint4, v128>(), new v128(0, 1, 2, 3, -1,   4, 5, 6, 7, -1,   8, 9, 10, 11, -1,   12));
                v128 shufHiHi = shuffle_epi8(value.v4_4.Reinterpret<uint4, v128>(), new v128(13, 14, 15, -1,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                
                *((v128*)((byte*)ptr + 0))  = shufLoLo;
                *((int*) ((byte*)ptr + 16)) = shufLoHi.SInt0;
                *((v128*)((byte*)ptr + 20)) = shufHiLo;
                *((int*) ((byte*)ptr + 36)) = shufHiHi.SInt0;
            }
            else
            {
                *((UInt40*)ptr + 0) = (UInt40)value.x0;
                *((UInt40*)ptr + 1) = (UInt40)value.x1;
                *((UInt40*)ptr + 2) = (UInt40)value.x2;
                *((UInt40*)ptr + 3) = (UInt40)value.x3;
                *((UInt40*)ptr + 4) = (UInt40)value.x4;
                *((UInt40*)ptr + 5) = (UInt40)value.x5;
                *((UInt40*)ptr + 6) = (UInt40)value.x6;
                *((UInt40*)ptr + 7) = (UInt40)value.x7;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u32_to48(void* ptr, uint8 value)
        {
            if (Avx2.IsAvx2Supported)
            {
                v256 shufLo = Avx2.mm256_shuffle_epi8(value, new v256(0, 1, 2, 3, -1, -1,   4, 5, 6, 7, -1, -1,   8, 9, 10, 11,
                                                                      0, 1, 2, 3, -1, -1,   4, 5, 6, 7, -1, -1,   8, 9, 10, 11));
                v256 shufHi = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1,   12, 13, 14, 15, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0,
                                                                      -1, -1,   12, 13, 14, 15, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0));

                *((v128*)((byte*)ptr + 0))  = shufLo.Lo128;
                *((long*)((byte*)ptr + 16)) = shufHi.SLong0;
                *((v128*)((byte*)ptr + 24)) = shufLo.Hi128;
                *((long*)((byte*)ptr + 40)) = shufHi.SLong2;
            }
            else if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shufLoLo = shuffle_epi8(value.v4_0.Reinterpret<uint4, v128>(), new v128(0, 1, 2, 3, -1, -1,   4, 5, 6, 7, -1, -1,   8, 9, 10, 11));
                v128 shufLoHi = shuffle_epi8(value.v4_0.Reinterpret<uint4, v128>(), new v128(-1, -1,   12, 13, 14, 15, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0));
                v128 shufHiLo = shuffle_epi8(value.v4_4.Reinterpret<uint4, v128>(), new v128(0, 1, 2, 3, -1, -1,   4, 5, 6, 7, -1, -1,   8, 9, 10, 11));
                v128 shufHiHi = shuffle_epi8(value.v4_4.Reinterpret<uint4, v128>(), new v128(-1, -1,   12, 13, 14, 15, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0));
                
                *((v128*)((byte*)ptr + 0))  = shufLoLo;
                *((long*)((byte*)ptr + 16)) = shufLoHi.SLong0;
                *((v128*)((byte*)ptr + 24)) = shufHiLo;
                *((long*)((byte*)ptr + 40)) = shufHiHi.SLong0;
            }
            else
            {
                *((UInt48*)ptr + 0) = (UInt48)value.x0;
                *((UInt48*)ptr + 1) = (UInt48)value.x1;
                *((UInt48*)ptr + 2) = (UInt48)value.x2;
                *((UInt48*)ptr + 3) = (UInt48)value.x3;
                *((UInt48*)ptr + 4) = (UInt48)value.x4;
                *((UInt48*)ptr + 5) = (UInt48)value.x5;
                *((UInt48*)ptr + 6) = (UInt48)value.x6;
                *((UInt48*)ptr + 7) = (UInt48)value.x7;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u32_to56(void* ptr, uint8 value)
        {
            if (Avx2.IsAvx2Supported)
            {
                v256 shufLo = Avx2.mm256_shuffle_epi8(value, new v256(0, 1, 2, 3, -1, -1, -1,   4, 5, 6, 7, -1, -1, -1,   8, 9,
                                                                      0, 1, 2, 3, -1, -1, -1,   4, 5, 6, 7, -1, -1, -1,   8, 9));
                v256 shufHi = Avx2.mm256_shuffle_epi8(value, new v256(10, 11, -1, -1, -1,   12, 13, 14, 15, -1, -1, -1,   0, 0, 0, 0,
                                                                      10, 11, -1, -1, -1,   12, 13, 14, 15, -1, -1, -1,   0, 0, 0, 0));
                
                *((v128*)((byte*)ptr + 0))  = shufLo.Lo128;
                *((long*)((byte*)ptr + 16)) = shufHi.SLong0;
                *((int*) ((byte*)ptr + 24)) = shufHi.SInt2;
                *((v128*)((byte*)ptr + 28)) = shufLo.Hi128;
                *((long*)((byte*)ptr + 44)) = shufHi.SLong2;
                *((int*) ((byte*)ptr + 52)) = shufHi.SInt6;
            }
            else if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shufLoLo = shuffle_epi8(value.v4_0.Reinterpret<uint4, v128>(), new v128(0, 1, 2, 3, -1, -1, -1,   4, 5, 6, 7, -1, -1, -1,   8, 9));
                v128 shufLoHi = shuffle_epi8(value.v4_0.Reinterpret<uint4, v128>(), new v128(10, 11, -1, -1, -1,   12, 13, 14, 15, -1, -1, -1,   0, 0, 0, 0));
                v128 shufHiLo = shuffle_epi8(value.v4_4.Reinterpret<uint4, v128>(), new v128(0, 1, 2, 3, -1, -1, -1,   4, 5, 6, 7, -1, -1, -1,   8, 9));
                v128 shufHiHi = shuffle_epi8(value.v4_4.Reinterpret<uint4, v128>(), new v128(10, 11, -1, -1, -1,   12, 13, 14, 15, -1, -1, -1,   0, 0, 0, 0));
                
                *((v128*)((byte*)ptr + 0))  = shufLoLo;
                *((long*)((byte*)ptr + 16)) = shufLoHi.SLong0;
                *((int*) ((byte*)ptr + 24)) = shufLoHi.SInt2;
                *((v128*)((byte*)ptr + 28)) = shufHiLo;
                *((long*)((byte*)ptr + 44)) = shufHiHi.SLong0;
                *((int*) ((byte*)ptr + 52)) = shufHiHi.SInt2;
            }
            else
            {
                *((UInt56*)ptr + 0) = (UInt56)value.x0;
                *((UInt56*)ptr + 1) = (UInt56)value.x1;
                *((UInt56*)ptr + 2) = (UInt56)value.x2;
                *((UInt56*)ptr + 3) = (UInt56)value.x3;
                *((UInt56*)ptr + 4) = (UInt56)value.x4;
                *((UInt56*)ptr + 5) = (UInt56)value.x5;
                *((UInt56*)ptr + 6) = (UInt56)value.x6;
                *((UInt56*)ptr + 7) = (UInt56)value.x7;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u32_to24(void* ptr, uint4 value)
        {
            Store_i32_to24(ptr, (int4)value);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u32_to40(void* ptr, uint4 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf0 = shuffle_epi8(value.Reinterpret<uint4, v128>(), new v128(0, 1, 2, 3, -1,   4, 5, 6, 7, -1,   8, 9, 10, 11, -1,   12));
                v128 shuf1 = shuffle_epi8(value.Reinterpret<uint4, v128>(), new v128(13, 14, 15, -1,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                
                *((v128*)((byte*)ptr + 0))  = shuf0;
                *((int*) ((byte*)ptr + 16)) = shuf1.SInt0;
            }
            else
            {
                *((UInt40*)ptr + 0) = (UInt40)value.x;
                *((UInt40*)ptr + 1) = (UInt40)value.y;
                *((UInt40*)ptr + 2) = (UInt40)value.z;
                *((UInt40*)ptr + 3) = (UInt40)value.w;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u32_to48(void* ptr, uint4 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shufLo = shuffle_epi8(value.Reinterpret<uint4, v128>(), new v128(0, 1, 2, 3, -1, -1,   4, 5, 6, 7, -1, -1,   8, 9, 10, 11));
                v128 shufHi = shuffle_epi8(value.Reinterpret<uint4, v128>(), new v128(-1, -1,   12, 13, 14, 15, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0));
                
                *((v128*)((byte*)ptr + 0))  = shufLo;
                *((long*)((byte*)ptr + 16)) = shufHi.SLong0;
            }
            else
            {
                *((UInt48*)ptr + 0) = (UInt48)value.x;
                *((UInt48*)ptr + 1) = (UInt48)value.y;
                *((UInt48*)ptr + 2) = (UInt48)value.z;
                *((UInt48*)ptr + 3) = (UInt48)value.w;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u32_to56(void* ptr, uint4 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shufLo = shuffle_epi8(value.Reinterpret<uint4, v128>(), new v128(0, 1, 2, 3, -1, -1, -1,   4, 5, 6, 7, -1, -1, -1,   8, 9));
                v128 shufHi = shuffle_epi8(value.Reinterpret<uint4, v128>(), new v128(10, 11, -1, -1, -1,   12, 13, 14, 15, -1, -1, -1,   0, 0, 0, 0));
                
                *((v128*)((byte*)ptr + 0))  = shufLo;
                *((long*)((byte*)ptr + 16)) = shufHi.SLong0;
                *((int*) ((byte*)ptr + 24)) = shufHi.SInt2;
            }
            else
            {
                *((UInt56*)ptr + 0) = (UInt56)value.x;
                *((UInt56*)ptr + 1) = (UInt56)value.y;
                *((UInt56*)ptr + 2) = (UInt56)value.z;
                *((UInt56*)ptr + 3) = (UInt56)value.w;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u32_to24(void* ptr, uint3 value)
        {
            Store_i32_to24(ptr, (int3)value);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u32_to40(void* ptr, uint3 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf = shuffle_epi8(new v128(value.x, value.y, value.z, 0), new v128(0, 1, 2, 3, -1,   4, 5, 6, 7, -1,   8, 9, 10, 11, -1,   0));
                
                *((long*)  ((byte*)ptr + 0))  = shuf.SLong0;
                *((int*)   ((byte*)ptr + 8))  = shuf.SInt2;
                *((short*) ((byte*)ptr + 12)) = shuf.SShort6;
                *((sbyte*) ((byte*)ptr + 14)) = shuf.SByte14;
            }
            else
            {
                *((UInt40*)ptr + 0) = (UInt40)value.x;
                *((UInt40*)ptr + 1) = (UInt40)value.y;
                *((UInt40*)ptr + 2) = (UInt40)value.z;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u32_to48(void* ptr, uint3 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf = shuffle_epi8(new v128(value.x, value.y, value.z, 0), new v128(0, 1, 2, 3, -1, -1,   4, 5, 6, 7, -1, -1,   8, 9, 10, 11));
                
                *((v128*) ((byte*)ptr + 0))  = shuf;
                *((short*)((byte*)ptr + 16)) = 0;
            }
            else
            {
                *((UInt48*)ptr + 0) = (UInt48)value.x;
                *((UInt48*)ptr + 1) = (UInt48)value.y;
                *((UInt48*)ptr + 2) = (UInt48)value.z;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u32_to56(void* ptr, uint3 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf = shuffle_epi8(new v128(value.x, value.y, value.z, 0), new v128(0, 1, 2, 3, -1, -1, -1,   4, 5, 6, 7, -1, -1, -1,   8, 9));
                
                *((v128*) ((byte*)ptr + 0))  = shuf;
                *((short*)((byte*)ptr + 16)) = new v128(value.x, value.y, value.z, 0).SShort5;
                *((Int24*)((byte*)ptr + 18)) = 0;
            }
            else
            {
                *((UInt56*)ptr + 0) = (UInt56)value.x;
                *((UInt56*)ptr + 1) = (UInt56)value.y;
                *((UInt56*)ptr + 2) = (UInt56)value.z;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u32_to24(void* ptr, uint2 value)
        {
            Store_i32_to24(ptr, (int2)value);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u32_to40(void* ptr, uint2 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf = shuffle_epi8(new v128(value.x, value.y, 0, 0), new v128(0, 1, 2, 3, -1,   4, 5, 6, 7, -1,   8, 9, 10, 11, -1,   0));
                
                *((long*) ((byte*)ptr + 0)) = shuf.SLong0;
                *((short*)((byte*)ptr + 8)) = shuf.SShort4;
            }
            else
            {
                *((UInt40*)ptr + 0) = (UInt40)value.x;
                *((UInt40*)ptr + 1) = (UInt40)value.y;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u32_to48(void* ptr, uint2 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf = shuffle_epi8(new v128(value.x, value.y, 0, 0), new v128(0, 1, 2, 3, -1, -1,   4, 5, 6, 7, -1, -1,   8, 9, 10, 11));
                
                *((long*)((byte*)ptr + 0)) = shuf.SLong0;
                *((int*) ((byte*)ptr + 8)) = shuf.SInt2;
            }
            else
            {
                *((UInt48*)ptr + 0) = (UInt48)value.x;
                *((UInt48*)ptr + 1) = (UInt48)value.y;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u32_to56(void* ptr, uint2 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf = shuffle_epi8(new v128(value.x, value.y, 0, 0), new v128(0, 1, 2, 3, -1, -1, -1,   4, 5, 6, 7, -1, -1, -1,   8, 9));
                
                *((long*)((byte*)ptr + 0))   = shuf.SLong0;
                *((int*) ((byte*)ptr + 8))   = shuf.SInt2;
                *((short*)((byte*)ptr + 12)) = 0;
            }
            else
            {
                *((UInt56*)ptr + 0) = (UInt56)value.x;
                *((UInt56*)ptr + 1) = (UInt56)value.y;
            }
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i32_to24(void* ptr, int8 value)
        {
            if (Avx2.IsAvx2Supported)
            {
                v256 shuf = Avx2.mm256_shuffle_epi8(value, new v256(0, 1, 2,  4, 5, 6,   8, 9, 10,   12, 13, 14,   0, 0, 0, 0,
                                                                    0, 1, 2,  4, 5, 6,   8, 9, 10,   12, 13, 14,   0, 0, 0, 0));

                *((long*)ptr) = shuf.SLong0;
                *((int*)ptr + 2) = shuf.SInt2;
                *((long*)((int*)ptr + 3)) = shuf.SLong2;
                *((int*)ptr + 5) = shuf.SInt6;
            }
            else if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shufLo = shuffle_epi8(value.v4_0.Reinterpret<int4, v128>(), new v128(0, 1, 2,  4, 5, 6,   8, 9, 10,   12, 13, 14,   0, 0, 0, 0));
                v128 shufHi = shuffle_epi8(value.v4_4.Reinterpret<int4, v128>(), new v128(0, 1, 2,  4, 5, 6,   8, 9, 10,   12, 13, 14,   0, 0, 0, 0));
                
                *((long*)ptr) = shufLo.SLong0;
                *((int*)ptr + 2) = shufLo.SInt2;
                *((long*)((int*)ptr + 3)) = shufHi.SLong0;
                *((int*)ptr + 5) = shufHi.SInt2;
            }
            else
            {
                *((UInt24*)ptr + 0) = (UInt24)value.x0;
                *((UInt24*)ptr + 1) = (UInt24)value.x1;
                *((UInt24*)ptr + 2) = (UInt24)value.x2;
                *((UInt24*)ptr + 3) = (UInt24)value.x3;
                *((UInt24*)ptr + 4) = (UInt24)value.x4;
                *((UInt24*)ptr + 5) = (UInt24)value.x5;
                *((UInt24*)ptr + 6) = (UInt24)value.x6;
                *((UInt24*)ptr + 7) = (UInt24)value.x7;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i32_to40(void* ptr, int8 value)
        {
            if (Avx2.IsAvx2Supported)
            {
                v256 sign = Avx2.mm256_srai_epi32(value, 31);
                v256 signLo = Avx2.mm256_shuffle_epi8(sign, new v256(0, 0, 0, 0, 0,   4, 4, 4, 4, 4,   8, 8, 8, 8, 8,   12,
                                                                     0, 0, 0, 0, 0,   4, 4, 4, 4, 4,   8, 8, 8, 8, 8,   12));
                v256 signHi = Avx2.mm256_shuffle_epi8(sign, new v256(12, 12, 12, 12,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                                                     12, 12, 12, 12,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));

                v256 shufLo = Avx2.mm256_shuffle_epi8(value, new v256(0, 1, 2, 3, -1,   4, 5, 6, 7, -1,   8, 9, 10, 11, -1,   12,
                                                                      0, 1, 2, 3, -1,   4, 5, 6, 7, -1,   8, 9, 10, 11, -1,   12));
                v256 shufHi = Avx2.mm256_shuffle_epi8(value, new v256(13, 14, 15, -1,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                                                      13, 14, 15, -1,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                
                shufLo = Avx2.mm256_blendv_epi8(shufLo, signLo, new v256(0, 1, 2, 3, -1,   4, 5, 6, 7, -1,   8, 9, 10, 11, -1,   12,
                                                                         0, 1, 2, 3, -1,   4, 5, 6, 7, -1,   8, 9, 10, 11, -1,   12));
                shufHi = Avx2.mm256_blendv_epi8(shufHi, signHi, new v256(13, 14, 15, -1,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                                                         13, 14, 15, -1,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));

                *((v128*) ((byte*)ptr + 0))  = shufLo.Lo128;
                *((int*)  ((byte*)ptr + 16)) = shufHi.SInt0;
                *((v128*) ((byte*)ptr + 20)) = shufLo.Hi128;
                *((int*)  ((byte*)ptr + 36)) = shufHi.SInt4;
            }
            else if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 signLo = srai_epi32(value.v4_0.Reinterpret<int4, v128>(), 31);
                v128 signHi = srai_epi32(value.v4_4.Reinterpret<int4, v128>(), 31);
                v128 signLoLo = shuffle_epi8(signLo, new v128(0, 0, 0, 0, 0,   4, 4, 4, 4, 4,   8, 8, 8, 8, 8,   12));
                v128 signLoHi = shuffle_epi8(signLo, new v128(12, 12, 12, 12,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                v128 signHiLo = shuffle_epi8(signHi, new v128(0, 0, 0, 0, 0,   4, 4, 4, 4, 4,   8, 8, 8, 8, 8,   12));
                v128 signHiHi = shuffle_epi8(signHi, new v128(12, 12, 12, 12,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));

                v128 shufLoLo = shuffle_epi8(value.v4_0.Reinterpret<int4, v128>(), new v128(0, 1, 2, 3, -1,   4, 5, 6, 7, -1,   8, 9, 10, 11, -1,   12));
                v128 shufLoHi = shuffle_epi8(value.v4_0.Reinterpret<int4, v128>(), new v128(13, 14, 15, -1,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                v128 shufHiLo = shuffle_epi8(value.v4_4.Reinterpret<int4, v128>(), new v128(0, 1, 2, 3, -1,   4, 5, 6, 7, -1,   8, 9, 10, 11, -1,   12));
                v128 shufHiHi = shuffle_epi8(value.v4_4.Reinterpret<int4, v128>(), new v128(13, 14, 15, -1,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                
                shufLoLo = blendv_epi8(shufLoLo, signLoLo, new v128(0, 1, 2, 3, -1,   4, 5, 6, 7, -1,   8, 9, 10, 11, -1,   12));
                shufLoHi = blendv_epi8(shufLoHi, signLoHi, new v128(13, 14, 15, -1,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                shufHiLo = blendv_epi8(shufHiLo, signHiLo, new v128(0, 1, 2, 3, -1,   4, 5, 6, 7, -1,   8, 9, 10, 11, -1,   12));
                shufHiHi = blendv_epi8(shufHiHi, signHiHi, new v128(13, 14, 15, -1,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                
                *((v128*) ((byte*)ptr + 0))  = shufLoLo;
                *((int*)  ((byte*)ptr + 16)) = shufLoHi.SInt0;
                *((v128*) ((byte*)ptr + 20)) = shufHiLo;
                *((int*)  ((byte*)ptr + 36)) = shufHiHi.SInt0;
            }
            else
            {
                *((UInt40*)ptr + 0) = (UInt40)value.x0;
                *((UInt40*)ptr + 1) = (UInt40)value.x1;
                *((UInt40*)ptr + 2) = (UInt40)value.x2;
                *((UInt40*)ptr + 3) = (UInt40)value.x3;
                *((UInt40*)ptr + 4) = (UInt40)value.x4;
                *((UInt40*)ptr + 5) = (UInt40)value.x5;
                *((UInt40*)ptr + 6) = (UInt40)value.x6;
                *((UInt40*)ptr + 7) = (UInt40)value.x7;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i32_to48(void* ptr, int8 value)
        {
            if (Avx2.IsAvx2Supported)
            {
                v256 sign = Avx2.mm256_srai_epi32(value, 31);
                v256 signLo = Avx2.mm256_shuffle_epi8(sign, new v256(0, 0, 0, 0, 0, 0,   4, 4, 4, 4, 4, 4,   8, 8, 8, 8,
                                                                     0, 0, 0, 0, 0, 0,   4, 4, 4, 4, 4, 4,   8, 8, 8, 8));
                v256 signHi = Avx2.mm256_shuffle_epi8(sign, new v256(8, 8,   12, 12, 12, 12, 12, 12,   0, 0, 0, 0, 0, 0, 0, 0,
                                                                     8, 8,   12, 12, 12, 12, 12, 12,   0, 0, 0, 0, 0, 0, 0, 0));

                v256 shufLo = Avx2.mm256_shuffle_epi8(value, new v256(0, 1, 2, 3, -1, -1,   4, 5, 6, 7, -1, -1,   8, 9, 10, 11,
                                                                      0, 1, 2, 3, -1, -1,   4, 5, 6, 7, -1, -1,   8, 9, 10, 11));
                v256 shufHi = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1,   12, 13, 14, 15, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0,
                                                                      -1, -1,   12, 13, 14, 15, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0));
                
                shufLo = Avx2.mm256_blend_epi16(shufLo, signLo, 0b00100100);
                shufHi = Avx2.mm256_blend_epi16(shufHi, signHi, 0b00001001);

                *((v128*)((byte*)ptr + 0))  = shufLo.Lo128;
                *((long*)((byte*)ptr + 16)) = shufHi.SLong0;
                *((v128*)((byte*)ptr + 24)) = shufLo.Hi128;
                *((long*)((byte*)ptr + 40)) = shufHi.SLong2;
            }
            else if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 signLo = srai_epi32(value.v4_0.Reinterpret<int4, v128>(), 31);
                v128 signHi = srai_epi32(value.v4_4.Reinterpret<int4, v128>(), 31);
                v128 signLoLo = shuffle_epi8(signLo, new v128(0, 0, 0, 0, 0, 0,   4, 4, 4, 4, 4, 4,   8, 8, 8, 8));
                v128 signLoHi = shuffle_epi8(signLo, new v128(8, 8,   12, 12, 12, 12, 12, 12,   0, 0, 0, 0, 0, 0, 0, 0));
                v128 signHiLo = shuffle_epi8(signHi, new v128(0, 0, 0, 0, 0, 0,   4, 4, 4, 4, 4, 4,   8, 8, 8, 8));
                v128 signHiHi = shuffle_epi8(signHi, new v128(8, 8,   12, 12, 12, 12, 12, 12,   0, 0, 0, 0, 0, 0, 0, 0));

                v128 shufLoLo = shuffle_epi8(value.v4_0.Reinterpret<int4, v128>(), new v128(0, 1, 2, 3, -1, -1,   4, 5, 6, 7, -1, -1,   8, 9, 10, 11));
                v128 shufLoHi = shuffle_epi8(value.v4_0.Reinterpret<int4, v128>(), new v128(-1, -1,   12, 13, 14, 15, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0));
                v128 shufHiLo = shuffle_epi8(value.v4_4.Reinterpret<int4, v128>(), new v128(0, 1, 2, 3, -1, -1,   4, 5, 6, 7, -1, -1,   8, 9, 10, 11));
                v128 shufHiHi = shuffle_epi8(value.v4_4.Reinterpret<int4, v128>(), new v128(-1, -1,   12, 13, 14, 15, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0));
                
                shufLoLo = blend_epi16(shufLoLo, signLoLo, 0b00100100);
                shufLoHi = blend_epi16(shufLoHi, signLoHi, 0b00001001);
                shufHiLo = blend_epi16(shufHiLo, signHiLo, 0b00100100);
                shufHiHi = blend_epi16(shufHiHi, signHiHi, 0b00001001);
                
                *((v128*)((byte*)ptr + 0))  = shufLoLo;
                *((long*)((byte*)ptr + 16)) = shufLoHi.SLong0;
                *((v128*)((byte*)ptr + 24)) = shufHiLo;
                *((long*)((byte*)ptr + 40)) = shufHiHi.SLong0;
            }
            else
            {
                *((UInt48*)ptr + 0) = (UInt48)value.x0;
                *((UInt48*)ptr + 1) = (UInt48)value.x1;
                *((UInt48*)ptr + 2) = (UInt48)value.x2;
                *((UInt48*)ptr + 3) = (UInt48)value.x3;
                *((UInt48*)ptr + 4) = (UInt48)value.x4;
                *((UInt48*)ptr + 5) = (UInt48)value.x5;
                *((UInt48*)ptr + 6) = (UInt48)value.x6;
                *((UInt48*)ptr + 7) = (UInt48)value.x7;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i32_to56(void* ptr, int8 value)
        {
            if (Avx2.IsAvx2Supported)
            {
                v256 sign = Avx2.mm256_srai_epi32(value, 31);
                v256 signLo = Avx2.mm256_shuffle_epi8(sign, new v256(0, 0, 0, 0, 0, 0, 0,   4, 4, 4, 4, 4, 4, 4,   8, 8,
                                                                     0, 0, 0, 0, 0, 0, 0,   4, 4, 4, 4, 4, 4, 4,   8, 8));
                v256 signHi = Avx2.mm256_shuffle_epi8(sign, new v256(8, 8, 8, 8, 8,   12, 12, 12, 12, 12, 12, 12,   0, 0, 0, 0,
                                                                     8, 8, 8, 8, 8,   12, 12, 12, 12, 12, 12, 12,   0, 0, 0, 0));

                v256 shufLo = Avx2.mm256_shuffle_epi8(value, new v256(0, 1, 2, 3, -1, -1, -1,   4, 5, 6, 7, -1, -1, -1,   8, 9,
                                                                      0, 1, 2, 3, -1, -1, -1,   4, 5, 6, 7, -1, -1, -1,   8, 9));
                v256 shufHi = Avx2.mm256_shuffle_epi8(value, new v256(10, 11, -1, -1, -1,   12, 13, 14, 15, -1, -1, -1,   0, 0, 0, 0,
                                                                      10, 11, -1, -1, -1,   12, 13, 14, 15, -1, -1, -1,   0, 0, 0, 0));
                
                shufLo = Avx2.mm256_blendv_epi8(shufLo, signLo, new v256(0, 1, 2, 3, -1, -1, -1,   4, 5, 6, 7, -1, -1, -1,   8, 9,
                                                                         0, 1, 2, 3, -1, -1, -1,   4, 5, 6, 7, -1, -1, -1,   8, 9));
                shufHi = Avx2.mm256_blendv_epi8(shufHi, signHi, new v256(10, 11, -1, -1, -1,   12, 13, 14, 15, -1, -1, -1,   0, 0, 0, 0,
                                                                         10, 11, -1, -1, -1,   12, 13, 14, 15, -1, -1, -1,   0, 0, 0, 0));
                
                *((v128*)((byte*)ptr + 0))  = shufLo.Lo128;
                *((long*)((byte*)ptr + 16)) = shufHi.SLong0;
                *((int*) ((byte*)ptr + 24)) = shufHi.SInt2;
                *((v128*)((byte*)ptr + 28)) = shufLo.Hi128;
                *((long*)((byte*)ptr + 44)) = shufHi.SLong2;
                *((int*) ((byte*)ptr + 52)) = shufHi.SInt6;
            }
            else if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 signLo = srai_epi32(value.v4_0.Reinterpret<int4, v128>(), 31);
                v128 signHi = srai_epi32(value.v4_4.Reinterpret<int4, v128>(), 31);
                v128 signLoLo = shuffle_epi8(signLo, new v128(0, 0, 0, 0, 0, 0, 0,   4, 4, 4, 4, 4, 4, 4,   8, 8));
                v128 signLoHi = shuffle_epi8(signLo, new v128(8, 8, 8, 8, 8,   12, 12, 12, 12, 12, 12, 12,   0, 0, 0, 0));
                v128 signHiLo = shuffle_epi8(signHi, new v128(0, 0, 0, 0, 0, 0, 0,   4, 4, 4, 4, 4, 4, 4,   8, 8));
                v128 signHiHi = shuffle_epi8(signHi, new v128(8, 8, 8, 8, 8,   12, 12, 12, 12, 12, 12, 12,   0, 0, 0, 0));

                v128 shufLoLo = shuffle_epi8(value.v4_0.Reinterpret<int4, v128>(), new v128(0, 1, 2, 3, -1, -1, -1,   4, 5, 6, 7, -1, -1, -1,   8, 9));
                v128 shufLoHi = shuffle_epi8(value.v4_0.Reinterpret<int4, v128>(), new v128(10, 11, -1, -1, -1,   12, 13, 14, 15, -1, -1, -1,   0, 0, 0, 0));
                v128 shufHiLo = shuffle_epi8(value.v4_4.Reinterpret<int4, v128>(), new v128(0, 1, 2, 3, -1, -1, -1,   4, 5, 6, 7, -1, -1, -1,   8, 9));
                v128 shufHiHi = shuffle_epi8(value.v4_4.Reinterpret<int4, v128>(), new v128(10, 11, -1, -1, -1,   12, 13, 14, 15, -1, -1, -1,   0, 0, 0, 0));
                
                shufLoLo = blendv_epi8(shufLoLo, signLoLo, new v128(0, 1, 2, 3, -1, -1, -1,   4, 5, 6, 7, -1, -1, -1,   8, 9));
                shufLoHi = blendv_epi8(shufLoHi, signLoHi, new v128(10, 11, -1, -1, -1,   12, 13, 14, 15, -1, -1, -1,   0, 0, 0, 0));
                shufHiLo = blendv_epi8(shufHiLo, signHiLo, new v128(0, 1, 2, 3, -1, -1, -1,   4, 5, 6, 7, -1, -1, -1,   8, 9));
                shufHiHi = blendv_epi8(shufHiHi, signHiHi, new v128(10, 11, -1, -1, -1,   12, 13, 14, 15, -1, -1, -1,   0, 0, 0, 0));
                
                *((v128*)((byte*)ptr + 0))  = shufLoLo;
                *((long*)((byte*)ptr + 16)) = shufLoHi.SLong0;
                *((int*) ((byte*)ptr + 24)) = shufLoHi.SInt2;
                *((v128*)((byte*)ptr + 28)) = shufHiLo;
                *((long*)((byte*)ptr + 44)) = shufHiHi.SLong0;
                *((int*) ((byte*)ptr + 52)) = shufHiHi.SInt2;
            }
            else
            {
                *((UInt56*)ptr + 0) = (UInt56)value.x0;
                *((UInt56*)ptr + 1) = (UInt56)value.x1;
                *((UInt56*)ptr + 2) = (UInt56)value.x2;
                *((UInt56*)ptr + 3) = (UInt56)value.x3;
                *((UInt56*)ptr + 4) = (UInt56)value.x4;
                *((UInt56*)ptr + 5) = (UInt56)value.x5;
                *((UInt56*)ptr + 6) = (UInt56)value.x6;
                *((UInt56*)ptr + 7) = (UInt56)value.x7;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i32_to24(void* ptr, int4 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shufLo = shuffle_epi8(value.Reinterpret<int4, v128>(), new v128(0, 1, 2,  4, 5, 6,   8, 9, 10,   12, 13, 14,   0, 0, 0, 0));
                
                *((long*)ptr) = shufLo.SLong0;
                *((int*)ptr + 2) = shufLo.SInt2;
            }
            else
            {
                *((UInt24*)ptr + 0) = (UInt24)value.x;
                *((UInt24*)ptr + 1) = (UInt24)value.y;
                *((UInt24*)ptr + 2) = (UInt24)value.z;
                *((UInt24*)ptr + 3) = (UInt24)value.w;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i32_to40(void* ptr, int4 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi32(value.Reinterpret<int4, v128>(), 31);
                v128 sign0 = shuffle_epi8(sign, new v128(0, 0, 0, 0, 0,   4, 4, 4, 4, 4,   8, 8, 8, 8, 8,   0));
                v128 sign1 = shuffle_epi8(sign, new v128(12, 12, 12, 12,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));

                v128 shuf0 = shuffle_epi8(value.Reinterpret<int4, v128>(), new v128(0, 1, 2, 3, -1,   4, 5, 6, 7, -1,   8, 9, 10, 11, -1,   12));
                v128 shuf1 = shuffle_epi8(value.Reinterpret<int4, v128>(), new v128(13, 14, 15, -1,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                
                shuf0 = blendv_epi8(shuf0, sign0, new v128(0, 1, 2, 3, -1,   4, 5, 6, 7, -1,   8, 9, 10, 11, -1,   12));
                shuf1 = blendv_epi8(shuf1, sign1, new v128(13, 14, 15, -1,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                
                *((v128*)((byte*)ptr + 0))  = shuf0;
                *((int*) ((byte*)ptr + 16)) = shuf1.SInt0;
            }
            else
            {
                *((UInt40*)ptr + 0) = (UInt40)value.x;
                *((UInt40*)ptr + 1) = (UInt40)value.y;
                *((UInt40*)ptr + 2) = (UInt40)value.z;
                *((UInt40*)ptr + 3) = (UInt40)value.w;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i32_to48(void* ptr, int4 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi32(value.Reinterpret<int4, v128>(), 31);
                v128 signLo = shuffle_epi8(sign, new v128(0, 0, 0, 0, 0, 0,   4, 4, 4, 4, 4, 4,   0, 0, 0, 0));
                v128 signHi = shuffle_epi8(sign, new v128(8, 8,   12, 12, 12, 12, 12, 12,   0, 0, 0, 0, 0, 0, 0, 0));
                
                v128 shufLo = shuffle_epi8(value.Reinterpret<int4, v128>(), new v128(0, 1, 2, 3, -1, -1,   4, 5, 6, 7, -1, -1,   8, 9, 10, 11));
                v128 shufHi = shuffle_epi8(value.Reinterpret<int4, v128>(), new v128(-1, -1,   12, 13, 14, 15, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0));
                
                shufLo = blend_epi16(shufLo, signLo, 0b00100100);
                shufHi = blend_epi16(shufHi, signHi, 0b00001001);
                
                *((v128*)((byte*)ptr + 0))  = shufLo;
                *((long*)((byte*)ptr + 16)) = shufHi.SLong0;
            }
            else
            {
                *((UInt48*)ptr + 0) = (UInt48)value.x;
                *((UInt48*)ptr + 1) = (UInt48)value.y;
                *((UInt48*)ptr + 2) = (UInt48)value.z;
                *((UInt48*)ptr + 3) = (UInt48)value.w;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i32_to56(void* ptr, int4 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi32(value.Reinterpret<int4, v128>(), 31);
                v128 signLo = shuffle_epi8(sign, new v128(0, 0, 0, 0, 0, 0, 0,   4, 4, 4, 4, 4, 4, 4,   0, 0));
                v128 signHi = shuffle_epi8(sign, new v128(8, 8, 8, 8, 8,   12, 12, 12, 12, 12, 12, 12,   0, 0, 0, 0));
                
                v128 shufLo = shuffle_epi8(value.Reinterpret<int4, v128>(), new v128(0, 1, 2, 3, -1, -1, -1,   4, 5, 6, 7, -1, -1, -1,   8, 9));
                v128 shufHi = shuffle_epi8(value.Reinterpret<int4, v128>(), new v128(10, 11, -1, -1, -1,   12, 13, 14, 15, -1, -1, -1,   0, 0, 0, 0));
                
                shufLo = blendv_epi8(shufLo, signLo, new v128(0, 1, 2, 3, -1, -1, -1,   4, 5, 6, 7, -1, -1, -1,   8, 9));
                shufHi = blendv_epi8(shufHi, signHi, new v128(10, 11, -1, -1, -1,   12, 13, 14, 15, -1, -1, -1,   0, 0, 0, 0));
                
                *((v128*)((byte*)ptr + 0))  = shufLo;
                *((long*)((byte*)ptr + 16)) = shufHi.SLong0;
                *((int*) ((byte*)ptr + 24)) = shufHi.SInt2;
            }
            else
            {
                *((UInt56*)ptr + 0) = (UInt56)value.x;
                *((UInt56*)ptr + 1) = (UInt56)value.y;
                *((UInt56*)ptr + 2) = (UInt56)value.z;
                *((UInt56*)ptr + 3) = (UInt56)value.w;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i32_to24(void* ptr, int3 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf = shuffle_epi8(new v128(value.x, value.y, value.z, 0), new v128(0, 1, 2,  4, 5, 6,   8, 9, 10,   0, 0, 0, 0, 0, 0, 0));
                
                *((long*)((byte*)ptr + 0)) = shuf.SLong0;
                *((byte*)((byte*)ptr + 8)) = shuf.Byte8;
            }
            else
            {
                *((UInt24*)ptr + 0) = (UInt24)value.x;
                *((UInt24*)ptr + 1) = (UInt24)value.y;
                *((UInt24*)ptr + 2) = (UInt24)value.z;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i32_to40(void* ptr, int3 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi32(new v128(value.x, value.y, value.z, 0), 31);
                sign = shuffle_epi8(sign, new v128(0, 0, 0, 0, 0,   4, 4, 4, 4, 4,   8, 8, 8, 8, 8,   0));

                v128 shuf = shuffle_epi8(new v128(value.x, value.y, value.z, 0), new v128(0, 1, 2, 3, -1,   4, 5, 6, 7, -1,   8, 9, 10, 11, -1,   0));

                shuf = blendv_epi8(shuf, sign, new v128(0, 1, 2, 3, -1,   4, 5, 6, 7, -1,   8, 9, 10, 11, -1,   0));
                
                *((long*)  ((byte*)ptr + 0))  = shuf.SLong0;
                *((int*)   ((byte*)ptr + 8))  = shuf.SInt2;
                *((short*) ((byte*)ptr + 12)) = shuf.SShort6;
                *((sbyte*) ((byte*)ptr + 14)) = shuf.SByte14;
            }
            else
            {
                *((UInt40*)ptr + 0) = (UInt40)value.x;
                *((UInt40*)ptr + 1) = (UInt40)value.y;
                *((UInt40*)ptr + 2) = (UInt40)value.z;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i32_to48(void* ptr, int3 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi32(new v128(value.x, value.y, value.z, 0), 31);
                sign = shuffle_epi8(sign, new v128(0, 0, 0, 0, 0, 0,   4, 4, 4, 4, 4, 4,   8, 8, 8, 8));

                v128 shuf = shuffle_epi8(new v128(value.x, value.y, value.z, 0), new v128(0, 1, 2, 3, -1, -1,   4, 5, 6, 7, -1, -1,   8, 9, 10, 11));
                
                shuf = blend_epi16(shuf, sign, 0b00100100);

                *((v128*) ((byte*)ptr + 0))  = shuf;
                *((short*)((byte*)ptr + 16)) = (short)(value.z >> 31);
            }
            else
            {
                *((UInt48*)ptr + 0) = (UInt48)value.x;
                *((UInt48*)ptr + 1) = (UInt48)value.y;
                *((UInt48*)ptr + 2) = (UInt48)value.z;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i32_to56(void* ptr, int3 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi32(new v128(value.x, value.y, value.z, 0), 31);
                sign = shuffle_epi8(sign, new v128(0, 0, 0, 0, 0, 0, 0,   4, 4, 4, 4, 4, 4, 4,   0, 0));

                v128 shuf = shuffle_epi8(new v128(value.x, value.y, value.z, 0), new v128(0, 1, 2, 3, -1, -1, -1,   4, 5, 6, 7, -1, -1, -1,   8, 9));
                
                shuf = blendv_epi8(shuf, sign, new v128(0, 1, 2, 3, -1, -1, -1,   4, 5, 6, 7, -1, -1, -1,   8, 9));

                *((v128*) ((byte*)ptr + 0))  = shuf;
                *((short*)((byte*)ptr + 16)) = new v128(value.x, value.y, value.z, 0).SShort5;
                *((Int24*)((byte*)ptr + 18)) = (Int24)(value.z >> 31);
            }
            else
            {
                *((UInt56*)ptr + 0) = (UInt56)value.x;
                *((UInt56*)ptr + 1) = (UInt56)value.y;
                *((UInt56*)ptr + 2) = (UInt56)value.z;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i32_to24(void* ptr, int2 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf = shuffle_epi8(new v128(value.x, value.y, 0, 0), new v128(0, 1, 2,  4, 5, 6,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                
                *((int*)ptr) = shuf.SInt0;
                *((short*)ptr + 2) = shuf.SShort2;
            }
            else
            {
                *((UInt24*)ptr + 0) = (UInt24)value.x;
                *((UInt24*)ptr + 1) = (UInt24)value.y;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i32_to40(void* ptr, int2 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi32(new v128(value.x, value.y, 0, 0), 31);
                sign = shuffle_epi8(sign, new v128(0, 0, 0, 0, 0,   4, 4, 4, 4, 4,   8, 8, 8, 8, 8,   0));

                v128 shuf = shuffle_epi8(new v128(value.x, value.y, 0, 0), new v128(0, 1, 2, 3, -1,   4, 5, 6, 7, -1,   8, 9, 10, 11, -1,   0));

                shuf = blendv_epi8(shuf, sign, new v128(0, 1, 2, 3, -1,   4, 5, 6, 7, -1,   8, 9, 10, 11, -1,   0));
                
                *((long*) ((byte*)ptr + 0)) = shuf.SLong0;
                *((short*)((byte*)ptr + 8)) = shuf.SShort4;
            }
            else
            {
                *((UInt40*)ptr + 0) = (UInt40)value.x;
                *((UInt40*)ptr + 1) = (UInt40)value.y;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i32_to48(void* ptr, int2 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi32(new v128(value.x, value.y, 0, 0), 31);
                sign = shuffle_epi8(sign, new v128(0, 0, 0, 0, 0, 0,   4, 4, 4, 4, 4, 4,   8, 8, 8, 8));

                v128 shuf = shuffle_epi8(new v128(value.x, value.y, 0, 0), new v128(0, 1, 2, 3, -1, -1,   4, 5, 6, 7, -1, -1,   8, 9, 10, 11));
                
                shuf = blend_epi16(shuf, sign, 0b00100100);
                
                *((long*)((byte*)ptr + 0)) = shuf.SLong0;
                *((int*) ((byte*)ptr + 8)) = shuf.SInt2;
            }
            else
            {
                *((UInt48*)ptr + 0) = (UInt48)value.x;
                *((UInt48*)ptr + 1) = (UInt48)value.y;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i32_to56(void* ptr, int2 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi32(new v128(value.x, value.y, 0, 0), 31);
                sign = shuffle_epi8(sign, new v128(0, 0, 0, 0, 0, 0, 0,   4, 4, 4, 4, 4, 4, 4,   0, 0));

                v128 shuf = shuffle_epi8(new v128(value.x, value.y, 0, 0), new v128(0, 1, 2, 3, -1, -1, -1,   4, 5, 6, 7, -1, -1, -1,   8, 9));
                
                shuf = blendv_epi8(shuf, sign, new v128(0, 1, 2, 3, -1, -1, -1,   4, 5, 6, 7, -1, -1, -1,   8, 9));
                
                *((long*)((byte*)ptr + 0))   = shuf.SLong0;
                *((int*) ((byte*)ptr + 8))   = shuf.SInt2;
                *((short*)((byte*)ptr + 12)) = shuf.SShort6;
            }
            else
            {
                *((UInt56*)ptr + 0) = (UInt56)value.x;
                *((UInt56*)ptr + 1) = (UInt56)value.y;
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u16_to24(void* ptr, ushort16 value)
        {
            if (Avx2.IsAvx2Supported)
            {
                v256 shufLo = Avx2.mm256_shuffle_epi8(value, new v256(0, 1, -1,   2, 3, -1,   4, 5, -1,   6, 7, -1,   8, 9, -1,   10,
                                                                      0, 1, -1,   2, 3, -1,   4, 5, -1,   6, 7, -1,   8, 9, -1,   10));
                v256 shufHi = Avx2.mm256_shuffle_epi8(value, new v256(11, -1,   12, 13, -1,   14, 15, -1,   0, 0, 0, 0, 0, 0, 0, 0,
                                                                      11, -1,   12, 13, -1,   14, 15, -1,   0, 0, 0, 0, 0, 0, 0, 0));

                *((v128*)((byte*)ptr + 0))  = shufLo.Lo128;
                *((long*)((byte*)ptr + 16)) = shufHi.SLong0;
                *((v128*)((byte*)ptr + 24)) = shufLo.Hi128;
                *((long*)((byte*)ptr + 40)) = shufHi.SLong2;
            }
            else if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shufLoLo = shuffle_epi8(value.v8_0, new v128(0, 1, -1,   2, 3, -1,   4, 5, -1,   6, 7, -1,   8, 9, -1,   10));
                v128 shufLoHi = shuffle_epi8(value.v8_0, new v128(11, -1,   12, 13, -1,   14, 15, -1,   0, 0, 0, 0, 0, 0, 0, 0));
                v128 shufHiLo = shuffle_epi8(value.v8_8, new v128(0, 1, -1,   2, 3, -1,   4, 5, -1,   6, 7, -1,   8, 9, -1,   10));
                v128 shufHiHi = shuffle_epi8(value.v8_8, new v128(11, -1,   12, 13, -1,   14, 15, -1,   0, 0, 0, 0, 0, 0, 0, 0));
                
                *((v128*)((byte*)ptr + 0))  = shufLoLo;
                *((long*)((byte*)ptr + 16)) = shufLoHi.SLong0;
                *((v128*)((byte*)ptr + 24)) = shufHiLo;
                *((long*)((byte*)ptr + 40)) = shufHiHi.SLong0;
            }
            else
            {
                *((UInt24*)ptr + 0)  = (UInt24)value.x0;
                *((UInt24*)ptr + 1)  = (UInt24)value.x1;
                *((UInt24*)ptr + 2)  = (UInt24)value.x2;
                *((UInt24*)ptr + 3)  = (UInt24)value.x3;
                *((UInt24*)ptr + 4)  = (UInt24)value.x4;
                *((UInt24*)ptr + 5)  = (UInt24)value.x5;
                *((UInt24*)ptr + 6)  = (UInt24)value.x6;
                *((UInt24*)ptr + 7)  = (UInt24)value.x7;
                *((UInt24*)ptr + 8)  = (UInt24)value.x8;
                *((UInt24*)ptr + 9)  = (UInt24)value.x9;
                *((UInt24*)ptr + 10) = (UInt24)value.x10;
                *((UInt24*)ptr + 11) = (UInt24)value.x11;
                *((UInt24*)ptr + 12) = (UInt24)value.x12;
                *((UInt24*)ptr + 13) = (UInt24)value.x13;
                *((UInt24*)ptr + 14) = (UInt24)value.x14;
                *((UInt24*)ptr + 15) = (UInt24)value.x15;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u16_to40(void* ptr, ushort16 value)
        {
            if (Avx2.IsAvx2Supported)
            {
                v256 shuf0 = Avx2.mm256_shuffle_epi8(value, new v256(0, 1, -1, -1, -1,   2, 3, -1, -1, -1,   4, 5, -1, -1, -1,   6,
                                                                     0, 1, -1, -1, -1,   2, 3, -1, -1, -1,   4, 5, -1, -1, -1,   6));
                v256 shuf1 = Avx2.mm256_shuffle_epi8(value, new v256(7, -1, -1, -1,   8, 9, -1, -1, -1,   10, 11, -1, -1, -1,   12, 13,
                                                                     7, -1, -1, -1,   8, 9, -1, -1, -1,   10, 11, -1, -1, -1,   12, 13));
                v256 shuf2 = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1, -1,   14, 15, -1, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0,
                                                                     -1, -1, -1,   14, 15, -1, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0));

                *((v128*)((byte*)ptr + 0))  = shuf0.Lo128;
                *((v128*)((byte*)ptr + 16)) = shuf1.Lo128;
                *((long*)((byte*)ptr + 32)) = shuf2.SLong0;
                *((v128*)((byte*)ptr + 40)) = shuf0.Hi128;
                *((v128*)((byte*)ptr + 56)) = shuf1.Hi128;
                *((long*)((byte*)ptr + 72)) = shuf2.SLong2;
            }
            else if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shufLo0 = shuffle_epi8(value.v8_0, new v128(0, 1, -1, -1, -1,   2, 3, -1, -1, -1,   4, 5, -1, -1, -1,   6));
                v128 shufLo1 = shuffle_epi8(value.v8_0, new v128(7, -1, -1, -1,   8, 9, -1, -1, -1,   10, 11, -1, -1, -1,   12, 13));
                v128 shufLo2 = shuffle_epi8(value.v8_0, new v128(-1, -1, -1,   14, 15, -1, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0));
                v128 shufHi0 = shuffle_epi8(value.v8_8, new v128(0, 1, -1, -1, -1,   2, 3, -1, -1, -1,   4, 5, -1, -1, -1,   6));
                v128 shufHi1 = shuffle_epi8(value.v8_8, new v128(7, -1, -1, -1,   8, 9, -1, -1, -1,   10, 11, -1, -1, -1,   12, 13));
                v128 shufHi2 = shuffle_epi8(value.v8_8, new v128(-1, -1, -1,   14, 15, -1, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0));

                *((v128*)((byte*)ptr + 0))  = shufLo0;
                *((v128*)((byte*)ptr + 16)) = shufLo1;
                *((long*)((byte*)ptr + 32)) = shufLo2.SLong0;
                *((v128*)((byte*)ptr + 40)) = shufHi0;
                *((v128*)((byte*)ptr + 56)) = shufHi1;
                *((long*)((byte*)ptr + 72)) = shufHi2.SLong0;
            }
            else
            {
                *((UInt40*)ptr + 0)  = (UInt40)value.x0;
                *((UInt40*)ptr + 1)  = (UInt40)value.x1;
                *((UInt40*)ptr + 2)  = (UInt40)value.x2;
                *((UInt40*)ptr + 3)  = (UInt40)value.x3;
                *((UInt40*)ptr + 4)  = (UInt40)value.x4;
                *((UInt40*)ptr + 5)  = (UInt40)value.x5;
                *((UInt40*)ptr + 6)  = (UInt40)value.x6;
                *((UInt40*)ptr + 7)  = (UInt40)value.x7;
                *((UInt40*)ptr + 8)  = (UInt40)value.x8;
                *((UInt40*)ptr + 9)  = (UInt40)value.x9;
                *((UInt40*)ptr + 10) = (UInt40)value.x10;
                *((UInt40*)ptr + 11) = (UInt40)value.x11;
                *((UInt40*)ptr + 12) = (UInt40)value.x12;
                *((UInt40*)ptr + 13) = (UInt40)value.x13;
                *((UInt40*)ptr + 14) = (UInt40)value.x14;
                *((UInt40*)ptr + 15) = (UInt40)value.x15;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u16_to48(void* ptr, ushort16 value)
        {
            if (Avx2.IsAvx2Supported)
            {
                v256 shuf0 = Avx2.mm256_shuffle_epi8(value, new v256(0, 1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1,   4, 5, -1, -1,
                                                                     0, 1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1,   4, 5, -1, -1));
                v256 shuf1 = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1,   6, 7, -1, -1, -1, -1,   8, 9, -1, -1, -1, -1,   10, 11,
                                                                     -1, -1,   6, 7, -1, -1, -1, -1,   8, 9, -1, -1, -1, -1,   10, 11));
                v256 shuf2 = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1, -1, -1,   12, 13, -1, -1, -1, -1,   14, 15, -1, -1, -1, -1,
                                                                     -1, -1, -1, -1,   12, 13, -1, -1, -1, -1,   14, 15, -1, -1, -1, -1));
                
                *((v128*)((byte*)ptr + 0))  = shuf0.Lo128;
                *((v128*)((byte*)ptr + 16)) = shuf1.Lo128;
                *((v128*)((byte*)ptr + 32)) = shuf2.Lo128;
                *((v128*)((byte*)ptr + 48)) = shuf0.Hi128;
                *((v128*)((byte*)ptr + 64)) = shuf1.Hi128;
                *((v128*)((byte*)ptr + 80)) = shuf2.Hi128;
            }
            else if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shufLo0 = shuffle_epi8(value.v8_0, new v128(0, 1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1,   4, 5, -1, -1));
                v128 shufLo1 = shuffle_epi8(value.v8_0, new v128(-1, -1,   6, 7, -1, -1, -1, -1,   8, 9, -1, -1, -1, -1,   10, 11));
                v128 shufLo2 = shuffle_epi8(value.v8_0, new v128(-1, -1, -1, -1,   12, 13, -1, -1, -1, -1,   14, 15, -1, -1, -1, -1));
                v128 shufHi0 = shuffle_epi8(value.v8_8, new v128(0, 1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1,   4, 5, -1, -1));
                v128 shufHi1 = shuffle_epi8(value.v8_8, new v128(-1, -1,   6, 7, -1, -1, -1, -1,   8, 9, -1, -1, -1, -1,   10, 11));
                v128 shufHi2 = shuffle_epi8(value.v8_8, new v128(-1, -1, -1, -1,   12, 13, -1, -1, -1, -1,   14, 15, -1, -1, -1, -1));

                *((v128*)((byte*)ptr + 0))  = shufLo0;
                *((v128*)((byte*)ptr + 16)) = shufLo1;
                *((v128*)((byte*)ptr + 32)) = shufLo2;
                *((v128*)((byte*)ptr + 48)) = shufHi0;
                *((v128*)((byte*)ptr + 64)) = shufHi1;
                *((v128*)((byte*)ptr + 80)) = shufHi2;
            }
            else
            {
                *((UInt48*)ptr + 0)  = (UInt48)value.x0;
                *((UInt48*)ptr + 1)  = (UInt48)value.x1;
                *((UInt48*)ptr + 2)  = (UInt48)value.x2;
                *((UInt48*)ptr + 3)  = (UInt48)value.x3;
                *((UInt48*)ptr + 4)  = (UInt48)value.x4;
                *((UInt48*)ptr + 5)  = (UInt48)value.x5;
                *((UInt48*)ptr + 6)  = (UInt48)value.x6;
                *((UInt48*)ptr + 7)  = (UInt48)value.x7;
                *((UInt48*)ptr + 8)  = (UInt48)value.x8;
                *((UInt48*)ptr + 9)  = (UInt48)value.x9;
                *((UInt48*)ptr + 10) = (UInt48)value.x10;
                *((UInt48*)ptr + 11) = (UInt48)value.x11;
                *((UInt48*)ptr + 12) = (UInt48)value.x12;
                *((UInt48*)ptr + 13) = (UInt48)value.x13;
                *((UInt48*)ptr + 14) = (UInt48)value.x14;
                *((UInt48*)ptr + 15) = (UInt48)value.x15;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u16_to56(void* ptr, ushort16 value)
        {
            if (Avx2.IsAvx2Supported)
            {
                v256 shuf0 = Avx2.mm256_shuffle_epi8(value, new v256(0, 1, -1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1, -1,   4, 5,
                                                                     0, 1, -1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1, -1,   4, 5));
                v256 shuf1 = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1, -1, -1, -1,   6, 7, -1, -1, -1, -1, -1,   8, 9, -1, -1,
                                                                     -1, -1, -1, -1, -1,   6, 7, -1, -1, -1, -1, -1,   8, 9, -1, -1));
                v256 shuf2 = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1, -1,   10, 11, -1, -1, -1, -1, -1,   12, 13, -1, -1, -1, -1,
                                                                     -1, -1, -1,   10, 11, -1, -1, -1, -1, -1,   12, 13, -1, -1, -1, -1));
                v256 shuf3 = Avx2.mm256_shuffle_epi8(value, new v256(-1,   14, 15, -1, -1, -1, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0,
                                                                     -1,   14, 15, -1, -1, -1, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0));
                
                *((v128*)((byte*)ptr + 0))   = shuf0.Lo128;
                *((v128*)((byte*)ptr + 16))  = shuf1.Lo128;
                *((v128*)((byte*)ptr + 32))  = shuf2.Lo128;
                *((long*)((byte*)ptr + 48))  = shuf3.SLong0;
                *((v128*)((byte*)ptr + 56))  = shuf0.Hi128;
                *((v128*)((byte*)ptr + 72))  = shuf1.Hi128;
                *((v128*)((byte*)ptr + 88))  = shuf2.Hi128;
                *((long*)((byte*)ptr + 104)) = shuf3.SLong2;
            }
            else if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shufLo0 = shuffle_epi8(value.v8_0, new v128(0, 1, -1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1, -1,   4, 5));
                v128 shufLo1 = shuffle_epi8(value.v8_0, new v128(-1, -1, -1, -1, -1,   6, 7, -1, -1, -1, -1, -1,   8, 9, -1, -1));
                v128 shufLo2 = shuffle_epi8(value.v8_0, new v128(-1, -1, -1,   10, 11, -1, -1, -1, -1, -1,   12, 13, -1, -1, -1, -1));
                v128 shufLo3 = shuffle_epi8(value.v8_0, new v128(-1,   14, 15, -1, -1, -1, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0));
                v128 shufHi0 = shuffle_epi8(value.v8_8, new v128(0, 1, -1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1, -1,   4, 5));
                v128 shufHi1 = shuffle_epi8(value.v8_8, new v128(-1, -1, -1, -1, -1,   6, 7, -1, -1, -1, -1, -1,   8, 9, -1, -1));
                v128 shufHi2 = shuffle_epi8(value.v8_8, new v128(-1, -1, -1,   10, 11, -1, -1, -1, -1, -1,   12, 13, -1, -1, -1, -1));
                v128 shufHi3 = shuffle_epi8(value.v8_8, new v128(-1,   14, 15, -1, -1, -1, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0));
                
                
                *((v128*)((byte*)ptr + 0))   = shufLo0;
                *((v128*)((byte*)ptr + 16))  = shufLo1;
                *((v128*)((byte*)ptr + 32))  = shufLo2;
                *((long*)((byte*)ptr + 48))  = shufLo3.SLong0;
                *((v128*)((byte*)ptr + 56))  = shufHi0;
                *((v128*)((byte*)ptr + 72))  = shufHi1;
                *((v128*)((byte*)ptr + 88))  = shufHi2;
                *((long*)((byte*)ptr + 104)) = shufHi3.SLong0;
            }
            else
            {
                *((UInt56*)ptr + 0)  = (UInt56)value.x0;
                *((UInt56*)ptr + 1)  = (UInt56)value.x1;
                *((UInt56*)ptr + 2)  = (UInt56)value.x2;
                *((UInt56*)ptr + 3)  = (UInt56)value.x3;
                *((UInt56*)ptr + 4)  = (UInt56)value.x4;
                *((UInt56*)ptr + 5)  = (UInt56)value.x5;
                *((UInt56*)ptr + 6)  = (UInt56)value.x6;
                *((UInt56*)ptr + 7)  = (UInt56)value.x7;
                *((UInt56*)ptr + 8)  = (UInt56)value.x8;
                *((UInt56*)ptr + 9)  = (UInt56)value.x9;
                *((UInt56*)ptr + 10) = (UInt56)value.x10;
                *((UInt56*)ptr + 11) = (UInt56)value.x11;
                *((UInt56*)ptr + 12) = (UInt56)value.x12;
                *((UInt56*)ptr + 13) = (UInt56)value.x13;
                *((UInt56*)ptr + 14) = (UInt56)value.x14;
                *((UInt56*)ptr + 15) = (UInt56)value.x15;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u16_to24(void* ptr, ushort8 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shufLo = shuffle_epi8(value, new v128(0, 1, -1,   2, 3, -1,   4, 5, -1,   6, 7, -1,   8, 9, -1,   10));
                v128 shufHi = shuffle_epi8(value, new v128(11, -1,   12, 13, -1,   14, 15, -1,   0, 0, 0, 0, 0, 0, 0, 0));

                *((v128*)((byte*)ptr + 0))  = shufLo;
                *((long*)((byte*)ptr + 16)) = shufHi.SLong0;
            }
            else
            {
                *((UInt24*)ptr + 0) = (UInt24)value.x0;
                *((UInt24*)ptr + 1) = (UInt24)value.x1;
                *((UInt24*)ptr + 2) = (UInt24)value.x2;
                *((UInt24*)ptr + 3) = (UInt24)value.x3;
                *((UInt24*)ptr + 4) = (UInt24)value.x4;
                *((UInt24*)ptr + 5) = (UInt24)value.x5;
                *((UInt24*)ptr + 6) = (UInt24)value.x6;
                *((UInt24*)ptr + 7) = (UInt24)value.x7;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u16_to40(void* ptr, ushort8 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf0 = shuffle_epi8(value, new v128(0, 1, -1, -1, -1,   2, 3, -1, -1, -1,   4, 5, -1, -1, -1,   6));
                v128 shuf1 = shuffle_epi8(value, new v128(7, -1, -1, -1,   8, 9, -1, -1, -1,   10, 11, -1, -1, -1,   12, 13));
                v128 shuf2 = shuffle_epi8(value, new v128(-1, -1, -1,   14, 15, -1, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0));

                *((v128*)((byte*)ptr + 0))  = shuf0;
                *((v128*)((byte*)ptr + 16)) = shuf1;
                *((long*)((byte*)ptr + 32)) = shuf2.SLong0;
            }
            else
            {
                *((UInt40*)ptr + 0) = (UInt40)value.x0;
                *((UInt40*)ptr + 1) = (UInt40)value.x1;
                *((UInt40*)ptr + 2) = (UInt40)value.x2;
                *((UInt40*)ptr + 3) = (UInt40)value.x3;
                *((UInt40*)ptr + 4) = (UInt40)value.x4;
                *((UInt40*)ptr + 5) = (UInt40)value.x5;
                *((UInt40*)ptr + 6) = (UInt40)value.x6;
                *((UInt40*)ptr + 7) = (UInt40)value.x7;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u16_to48(void* ptr, ushort8 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf0 = shuffle_epi8(value, new v128(0, 1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1,   4, 5, -1, -1));
                v128 shuf1 = shuffle_epi8(value, new v128(-1, -1,   6, 7, -1, -1, -1, -1,   8, 9, -1, -1, -1, -1,   10, 11));
                v128 shuf2 = shuffle_epi8(value, new v128(-1, -1, -1, -1,   12, 13, -1, -1, -1, -1,   14, 15, -1, -1, -1, -1));

                *((v128*)((byte*)ptr + 0))  = shuf0;
                *((v128*)((byte*)ptr + 16)) = shuf1;
                *((v128*)((byte*)ptr + 32)) = shuf2;
            }
            else
            {
                *((UInt48*)ptr + 0) = (UInt48)value.x0;
                *((UInt48*)ptr + 1) = (UInt48)value.x1;
                *((UInt48*)ptr + 2) = (UInt48)value.x2;
                *((UInt48*)ptr + 3) = (UInt48)value.x3;
                *((UInt48*)ptr + 4) = (UInt48)value.x4;
                *((UInt48*)ptr + 5) = (UInt48)value.x5;
                *((UInt48*)ptr + 6) = (UInt48)value.x6;
                *((UInt48*)ptr + 7) = (UInt48)value.x7;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u16_to56(void* ptr, ushort8 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf0 = shuffle_epi8(value, new v128(0, 1, -1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1, -1,   4, 5));
                v128 shuf1 = shuffle_epi8(value, new v128(-1, -1, -1, -1, -1,   6, 7, -1, -1, -1, -1, -1,   8, 9, -1, -1));
                v128 shuf2 = shuffle_epi8(value, new v128(-1, -1, -1,   10, 11, -1, -1, -1, -1, -1,   12, 13, -1, -1, -1, -1));
                v128 shuf3 = shuffle_epi8(value, new v128(-1,   14, 15, -1, -1, -1, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0));

                *((v128*)((byte*)ptr + 0))  = shuf0;
                *((v128*)((byte*)ptr + 16)) = shuf1;
                *((v128*)((byte*)ptr + 32)) = shuf2;
                *((long*)((byte*)ptr + 48)) = shuf3.SLong0;
            }
            else
            {
                *((UInt56*)ptr + 0) = (UInt56)value.x0;
                *((UInt56*)ptr + 1) = (UInt56)value.x1;
                *((UInt56*)ptr + 2) = (UInt56)value.x2;
                *((UInt56*)ptr + 3) = (UInt56)value.x3;
                *((UInt56*)ptr + 4) = (UInt56)value.x4;
                *((UInt56*)ptr + 5) = (UInt56)value.x5;
                *((UInt56*)ptr + 6) = (UInt56)value.x6;
                *((UInt56*)ptr + 7) = (UInt56)value.x7;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u16_to24(void* ptr, ushort4 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf = shuffle_epi8(value, new v128(0, 1, -1,   2, 3, -1,   4, 5, -1,   6, 7, -1,   8, 9, -1,   10));

                *((long*)((byte*)ptr + 0)) = shuf.SLong0;
                *((int*) ((byte*)ptr + 8)) = shuf.SInt2;
            }
            else
            {
                *((UInt24*)ptr + 0) = (UInt24)value.x;
                *((UInt24*)ptr + 1) = (UInt24)value.y;
                *((UInt24*)ptr + 2) = (UInt24)value.z;
                *((UInt24*)ptr + 3) = (UInt24)value.w;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u16_to40(void* ptr, ushort4 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf = shuffle_epi8(value, new v128(0, 1, -1, -1, -1,   2, 3, -1, -1, -1,   4, 5, -1, -1, -1,   6));

                *((v128*)((byte*)ptr + 0))  = shuf;
                *((int*) ((byte*)ptr + 16)) = (int)(byte)extract_epi8(value, 7);
            }
            else
            {
                *((UInt40*)ptr + 0) = (UInt40)value.x;
                *((UInt40*)ptr + 1) = (UInt40)value.y;
                *((UInt40*)ptr + 2) = (UInt40)value.z;
                *((UInt40*)ptr + 3) = (UInt40)value.w;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u16_to48(void* ptr, ushort4 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf0 = shuffle_epi8(value, new v128(0, 1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1,   4, 5, -1, -1));
                v128 shuf1 = shuffle_epi8(value, new v128(-1, -1,   6, 7, -1, -1, -1, -1,   8, 9, -1, -1, -1, -1,   10, 11));

                *((v128*)((byte*)ptr + 0))  = shuf0;
                *((long*)((byte*)ptr + 16)) = shuf1.SLong0;
            }
            else
            {
                *((UInt48*)ptr + 0) = (UInt48)value.x;
                *((UInt48*)ptr + 1) = (UInt48)value.y;
                *((UInt48*)ptr + 2) = (UInt48)value.z;
                *((UInt48*)ptr + 3) = (UInt48)value.w;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u16_to56(void* ptr, ushort4 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf0 = shuffle_epi8(value, new v128(0, 1, -1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1, -1,   4, 5));
                v128 shuf1 = shuffle_epi8(value, new v128(-1, -1, -1, -1, -1,   6, 7, -1, -1, -1, -1, -1,   8, 9, -1, -1));

                *((v128*)((byte*)ptr + 0))  = shuf0;
                *((long*)((byte*)ptr + 16)) = shuf1.SLong0;
                *((int*) ((byte*)ptr + 24)) = 0;
            }
            else
            {
                *((UInt56*)ptr + 0) = (UInt56)value.x;
                *((UInt56*)ptr + 1) = (UInt56)value.y;
                *((UInt56*)ptr + 2) = (UInt56)value.z;
                *((UInt56*)ptr + 3) = (UInt56)value.w;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u16_to24(void* ptr, ushort3 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf = shuffle_epi8(value, new v128(0, 1, -1,   2, 3, -1,   4, 5, -1,   6, 7, -1,   8, 9, -1,   10));

                *((long*) ((byte*)ptr + 0)) = shuf.SLong0;
                *((sbyte*)((byte*)ptr + 8)) = 0;
            }
            else
            {
                *((UInt24*)ptr + 0) = (UInt24)value.x;
                *((UInt24*)ptr + 1) = (UInt24)value.y;
                *((UInt24*)ptr + 2) = (UInt24)value.z;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u16_to40(void* ptr, ushort3 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf = shuffle_epi8(value, new v128(0, 1, -1, -1, -1,   2, 3, -1, -1, -1,   4, 5, -1, -1, -1,   6));

                *((long*) ((byte*)ptr + 0))  = shuf.SLong0;
                *((int*)  ((byte*)ptr + 8))  = shuf.SInt2;
                *((short*)((byte*)ptr + 12)) = 0;
                *((sbyte*)((byte*)ptr + 14)) = 0;
            }
            else
            {
                *((UInt40*)ptr + 0) = (UInt40)value.x;
                *((UInt40*)ptr + 1) = (UInt40)value.y;
                *((UInt40*)ptr + 2) = (UInt40)value.z;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u16_to48(void* ptr, ushort3 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf0 = shuffle_epi8(value, new v128(0, 1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1,   4, 5, -1, -1));

                *((v128*) ((byte*)ptr + 0))  = shuf0;
                *((short*)((byte*)ptr + 16)) = 0;
            }
            else
            {
                *((UInt48*)ptr + 0) = (UInt48)value.x;
                *((UInt48*)ptr + 1) = (UInt48)value.y;
                *((UInt48*)ptr + 2) = (UInt48)value.z;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u16_to56(void* ptr, ushort3 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf0 = shuffle_epi8(value, new v128(0, 1, -1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1, -1,   4, 5));

                *((v128*) ((byte*)ptr + 0))  = shuf0;
                *((int*)  ((byte*)ptr + 16)) = 0;
                *((sbyte*)((byte*)ptr + 20)) = 0;
            }
            else
            {
                *((UInt56*)ptr + 0) = (UInt56)value.x;
                *((UInt56*)ptr + 1) = (UInt56)value.y;
                *((UInt56*)ptr + 2) = (UInt56)value.z;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u16_to24(void* ptr, ushort2 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf = shuffle_epi8(value, new v128(0, 1, -1,   2, 3, -1,   4, 5, -1,   6, 7, -1,   8, 9, -1,   10));

                *((int*)  ((byte*)ptr + 0)) = shuf.SInt0;
                *((short*)((byte*)ptr + 4)) = shuf.SShort2;
            }
            else
            {
                *((UInt24*)ptr + 0) = (UInt24)value.x;
                *((UInt24*)ptr + 1) = (UInt24)value.y;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u16_to40(void* ptr, ushort2 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf = shuffle_epi8(value, new v128(0, 1, -1, -1, -1,   2, 3, -1, -1, -1,   4, 5, -1, -1, -1,   6));

                *((long*) ((byte*)ptr + 0)) = shuf.SLong0;
                *((short*)((byte*)ptr + 8)) = 0;
            }
            else
            {
                *((UInt40*)ptr + 0) = (UInt40)value.x;
                *((UInt40*)ptr + 1) = (UInt40)value.y;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u16_to48(void* ptr, ushort2 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf0 = shuffle_epi8(value, new v128(0, 1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1,   4, 5, -1, -1));

                *((long*)((byte*)ptr + 0)) = shuf0.SLong0;
                *((int*) ((byte*)ptr + 8)) = 0;
            }
            else
            {
                *((UInt48*)ptr + 0) = (UInt48)value.x;
                *((UInt48*)ptr + 1) = (UInt48)value.y;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u16_to56(void* ptr, ushort2 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf0 = shuffle_epi8(value, new v128(0, 1, -1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1, -1,   4, 5));

                *((long*) ((byte*)ptr + 0))  = shuf0.SLong0;
                *((int*)  ((byte*)ptr + 8))  = shuf0.SInt2;
                *((short*)((byte*)ptr + 12)) = 0;
            }
            else
            {
                *((UInt56*)ptr + 0) = (UInt56)value.x;
                *((UInt56*)ptr + 1) = (UInt56)value.y;
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i16_to24(void* ptr, short16 value)
        {
            if (Avx2.IsAvx2Supported)
            {
                v256 sign = Avx2.mm256_srai_epi16(value, 15);
                v256 signLo = Avx2.mm256_shuffle_epi8(sign, new v256(0, 0, 0,   2, 2, 2,   4, 4, 4,   6, 6, 6,   8, 8, 8,   10,
                                                                     0, 0, 0,   2, 2, 2,   4, 4, 4,   6, 6, 6,   8, 8, 8,   10));
                v256 signHi = Avx2.mm256_shuffle_epi8(sign, new v256(10, 10,   12, 12, 12,   14, 14, 14,   0, 0, 0, 0, 0, 0, 0, 0,
                                                                     10, 10,   12, 12, 12,   14, 14, 14,   0, 0, 0, 0, 0, 0, 0, 0));

                v256 shufLo = Avx2.mm256_shuffle_epi8(value, new v256(0, 1, -1,   2, 3, -1,   4, 5, -1,   6, 7, -1,   8, 9, -1,   10,
                                                                      0, 1, -1,   2, 3, -1,   4, 5, -1,   6, 7, -1,   8, 9, -1,   10));
                v256 shufHi = Avx2.mm256_shuffle_epi8(value, new v256(11, -1,   12, 13, -1,   14, 15, -1,   0, 0, 0, 0, 0, 0, 0, 0,
                                                                      11, -1,   12, 13, -1,   14, 15, -1,   0, 0, 0, 0, 0, 0, 0, 0));

                shufLo = Avx2.mm256_blendv_epi8(shufLo, signLo, new v256(0, 1, -1,   2, 3, -1,   4, 5, -1,   6, 7, -1,   8, 9, -1,   10,
                                                                         0, 1, -1,   2, 3, -1,   4, 5, -1,   6, 7, -1,   8, 9, -1,   10));
                shufHi = Avx2.mm256_blendv_epi8(shufHi, signHi, new v256(11, -1,   12, 13, -1,   14, 15, -1,   0, 0, 0, 0, 0, 0, 0, 0,
                                                                         11, -1,   12, 13, -1,   14, 15, -1,   0, 0, 0, 0, 0, 0, 0, 0));

                *((v128*)((byte*)ptr + 0))  = shufLo.Lo128;
                *((long*)((byte*)ptr + 16)) = shufHi.SLong0;
                *((v128*)((byte*)ptr + 24)) = shufLo.Hi128;
                *((long*)((byte*)ptr + 40)) = shufHi.SLong2;
            }
            else if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 signLo = srai_epi16(value.v8_0, 15);
                v128 signHi = srai_epi16(value.v8_8, 15);
                v128 signLoLo = shuffle_epi8(signLo, new v128(0, 0, 0,   2, 2, 2,   4, 4, 4,   6, 6, 6,   8, 8, 8,   10));
                v128 signLoHi = shuffle_epi8(signLo, new v128(10, 10,   12, 12, 12,   14, 14, 14,   0, 0, 0, 0, 0, 0, 0, 0));
                v128 signHiLo = shuffle_epi8(signHi, new v128(0, 0, 0,   2, 2, 2,   4, 4, 4,   6, 6, 6,   8, 8, 8,   10));
                v128 signHiHi = shuffle_epi8(signHi, new v128(10, 10,   12, 12, 12,   14, 14, 14,   0, 0, 0, 0, 0, 0, 0, 0));

                v128 shufLoLo = shuffle_epi8(value.v8_0, new v128(0, 1, -1,   2, 3, -1,   4, 5, -1,   6, 7, -1,   8, 9, -1,   10));
                v128 shufLoHi = shuffle_epi8(value.v8_0, new v128(11, -1,   12, 13, -1,   14, 15, -1,   0, 0, 0, 0, 0, 0, 0, 0));
                v128 shufHiLo = shuffle_epi8(value.v8_8, new v128(0, 1, -1,   2, 3, -1,   4, 5, -1,   6, 7, -1,   8, 9, -1,   10));
                v128 shufHiHi = shuffle_epi8(value.v8_8, new v128(11, -1,   12, 13, -1,   14, 15, -1,   0, 0, 0, 0, 0, 0, 0, 0));

                shufLoLo = blendv_epi8(shufLoLo, signLoLo, new v128(0, 1, -1,   2, 3, -1,   4, 5, -1,   6, 7, -1,   8, 9, -1,   10));
                shufLoHi = blendv_epi8(shufLoHi, signLoHi, new v128(11, -1,   12, 13, -1,   14, 15, -1,   0, 0, 0, 0, 0, 0, 0, 0));
                shufHiLo = blendv_epi8(shufHiLo, signHiLo, new v128(0, 1, -1,   2, 3, -1,   4, 5, -1,   6, 7, -1,   8, 9, -1,   10));
                shufHiHi = blendv_epi8(shufHiHi, signHiHi, new v128(11, -1,   12, 13, -1,   14, 15, -1,   0, 0, 0, 0, 0, 0, 0, 0));
                
                *((v128*)((byte*)ptr + 0))  = shufLoLo;
                *((long*)((byte*)ptr + 16)) = shufLoHi.SLong0;
                *((v128*)((byte*)ptr + 24)) = shufHiLo;
                *((long*)((byte*)ptr + 40)) = shufHiHi.SLong0;
            }
            else
            {
                *((UInt24*)ptr + 0)  = (UInt24)value.x0;
                *((UInt24*)ptr + 1)  = (UInt24)value.x1;
                *((UInt24*)ptr + 2)  = (UInt24)value.x2;
                *((UInt24*)ptr + 3)  = (UInt24)value.x3;
                *((UInt24*)ptr + 4)  = (UInt24)value.x4;
                *((UInt24*)ptr + 5)  = (UInt24)value.x5;
                *((UInt24*)ptr + 6)  = (UInt24)value.x6;
                *((UInt24*)ptr + 7)  = (UInt24)value.x7;
                *((UInt24*)ptr + 8)  = (UInt24)value.x8;
                *((UInt24*)ptr + 9)  = (UInt24)value.x9;
                *((UInt24*)ptr + 10) = (UInt24)value.x10;
                *((UInt24*)ptr + 11) = (UInt24)value.x11;
                *((UInt24*)ptr + 12) = (UInt24)value.x12;
                *((UInt24*)ptr + 13) = (UInt24)value.x13;
                *((UInt24*)ptr + 14) = (UInt24)value.x14;
                *((UInt24*)ptr + 15) = (UInt24)value.x15;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i16_to40(void* ptr, short16 value)
        {
            if (Avx2.IsAvx2Supported)
            {
                v256 sign = Avx2.mm256_srai_epi16(value, 15);
                v256 sign0 = Avx2.mm256_shuffle_epi8(sign, new v256(0, 0, 0, 0, 0,   2, 2, 2, 2, 2,   4, 4, 4, 4, 4,   6,
                                                                    0, 0, 0, 0, 0,   2, 2, 2, 2, 2,   4, 4, 4, 4, 4,   6));
                v256 sign1 = Avx2.mm256_shuffle_epi8(sign, new v256(6, 6, 6, 6,   8, 8, 8, 8, 8,   10, 10, 10, 10, 10,   12, 12,
                                                                    6, 6, 6, 6,   8, 8, 8, 8, 8,   10, 10, 10, 10, 10,   12, 12));
                v256 sign2 = Avx2.mm256_shuffle_epi8(sign, new v256(12, 12, 12,   14, 14, 14, 14, 14,   0, 0, 0, 0, 0, 0, 0, 0,
                                                                    12, 12, 12,   14, 14, 14, 14, 14,   0, 0, 0, 0, 0, 0, 0, 0));

                v256 shuf0 = Avx2.mm256_shuffle_epi8(value, new v256(0, 1, -1, -1, -1,   2, 3, -1, -1, -1,   4, 5, -1, -1, -1,   6,
                                                                     0, 1, -1, -1, -1,   2, 3, -1, -1, -1,   4, 5, -1, -1, -1,   6));
                v256 shuf1 = Avx2.mm256_shuffle_epi8(value, new v256(7, -1, -1, -1,   8, 9, -1, -1, -1,   10, 11, -1, -1, -1,   12, 13,
                                                                     7, -1, -1, -1,   8, 9, -1, -1, -1,   10, 11, -1, -1, -1,   12, 13));
                v256 shuf2 = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1, -1,   14, 15, -1, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0,
                                                                     -1, -1, -1,   14, 15, -1, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0));
                
                shuf0 = Avx2.mm256_blendv_epi8(shuf0, sign0, new v256(0, 1, -1, -1, -1,   2, 3, -1, -1, -1,   4, 5, -1, -1, -1,   6,
                                                                      0, 1, -1, -1, -1,   2, 3, -1, -1, -1,   4, 5, -1, -1, -1,   6));
                shuf1 = Avx2.mm256_blendv_epi8(shuf1, sign1, new v256(7, -1, -1, -1,   8, 9, -1, -1, -1,   10, 11, -1, -1, -1,   12, 13,
                                                                      7, -1, -1, -1,   8, 9, -1, -1, -1,   10, 11, -1, -1, -1,   12, 13));
                shuf2 = Avx2.mm256_blendv_epi8(shuf2, sign2, new v256(-1, -1, -1,   14, 15, -1, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0,
                                                                      -1, -1, -1,   14, 15, -1, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0));

                *((v128*)((byte*)ptr + 0))  = shuf0.Lo128;
                *((v128*)((byte*)ptr + 16)) = shuf1.Lo128;
                *((long*)((byte*)ptr + 32)) = shuf2.SLong0;
                *((v128*)((byte*)ptr + 40)) = shuf0.Hi128;
                *((v128*)((byte*)ptr + 56)) = shuf1.Hi128;
                *((long*)((byte*)ptr + 72)) = shuf2.SLong2;
            }
            else if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 signLo = srai_epi16(value.v8_0, 15);
                v128 signHi = srai_epi16(value.v8_8, 15);
                v128 signLo0 = shuffle_epi8(signLo, new v128(0, 0, 0, 0, 0,   2, 2, 2, 2, 2,   4, 4, 4, 4, 4,   6));
                v128 signLo1 = shuffle_epi8(signLo, new v128(6, 6, 6, 6,   8, 8, 8, 8, 8,   10, 10, 10, 10, 10,   12, 12));
                v128 signLo2 = shuffle_epi8(signLo, new v128(12, 12, 12,   14, 14, 14, 14, 14,   0, 0, 0, 0, 0, 0, 0, 0));
                v128 signHi0 = shuffle_epi8(signHi, new v128(0, 0, 0, 0, 0,   2, 2, 2, 2, 2,   4, 4, 4, 4, 4,   6));
                v128 signHi1 = shuffle_epi8(signHi, new v128(6, 6, 6, 6,   8, 8, 8, 8, 8,   10, 10, 10, 10, 10,   12, 12));
                v128 signHi2 = shuffle_epi8(signHi, new v128(12, 12, 12,   14, 14, 14, 14, 14,   0, 0, 0, 0, 0, 0, 0, 0));
                
                v128 shufLo0 = shuffle_epi8(value.v8_0, new v128(0, 1, -1, -1, -1,   2, 3, -1, -1, -1,   4, 5, -1, -1, -1,   6));
                v128 shufLo1 = shuffle_epi8(value.v8_0, new v128(7, -1, -1, -1,   8, 9, -1, -1, -1,   10, 11, -1, -1, -1,   12, 13));
                v128 shufLo2 = shuffle_epi8(value.v8_0, new v128(-1, -1, -1,   14, 15, -1, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0));
                v128 shufHi0 = shuffle_epi8(value.v8_8, new v128(0, 1, -1, -1, -1,   2, 3, -1, -1, -1,   4, 5, -1, -1, -1,   6));
                v128 shufHi1 = shuffle_epi8(value.v8_8, new v128(7, -1, -1, -1,   8, 9, -1, -1, -1,   10, 11, -1, -1, -1,   12, 13));
                v128 shufHi2 = shuffle_epi8(value.v8_8, new v128(-1, -1, -1,   14, 15, -1, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0));
                
                shufLo0 = blendv_epi8(shufLo0, signLo0, new v128(0, 1, -1, -1, -1,   2, 3, -1, -1, -1,   4, 5, -1, -1, -1,   6));
                shufLo1 = blendv_epi8(shufLo1, signLo1, new v128(7, -1, -1, -1,   8, 9, -1, -1, -1,   10, 11, -1, -1, -1,   12, 13));
                shufLo2 = blendv_epi8(shufLo2, signLo2, new v128(-1, -1, -1,   14, 15, -1, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0));
                shufHi0 = blendv_epi8(shufHi0, signHi0, new v128(0, 1, -1, -1, -1,   2, 3, -1, -1, -1,   4, 5, -1, -1, -1,   6));
                shufHi1 = blendv_epi8(shufHi1, signHi1, new v128(7, -1, -1, -1,   8, 9, -1, -1, -1,   10, 11, -1, -1, -1,   12, 13));
                shufHi2 = blendv_epi8(shufHi2, signHi2, new v128(-1, -1, -1,   14, 15, -1, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0));

                *((v128*)((byte*)ptr + 0))  = shufLo0;
                *((v128*)((byte*)ptr + 16)) = shufLo1;
                *((long*)((byte*)ptr + 32)) = shufLo2.SLong0;
                *((v128*)((byte*)ptr + 40)) = shufHi0;
                *((v128*)((byte*)ptr + 56)) = shufHi1;
                *((long*)((byte*)ptr + 72)) = shufHi2.SLong0;
            }
            else
            {
                *((UInt40*)ptr + 0)  = (UInt40)value.x0;
                *((UInt40*)ptr + 1)  = (UInt40)value.x1;
                *((UInt40*)ptr + 2)  = (UInt40)value.x2;
                *((UInt40*)ptr + 3)  = (UInt40)value.x3;
                *((UInt40*)ptr + 4)  = (UInt40)value.x4;
                *((UInt40*)ptr + 5)  = (UInt40)value.x5;
                *((UInt40*)ptr + 6)  = (UInt40)value.x6;
                *((UInt40*)ptr + 7)  = (UInt40)value.x7;
                *((UInt40*)ptr + 8)  = (UInt40)value.x8;
                *((UInt40*)ptr + 9)  = (UInt40)value.x9;
                *((UInt40*)ptr + 10) = (UInt40)value.x10;
                *((UInt40*)ptr + 11) = (UInt40)value.x11;
                *((UInt40*)ptr + 12) = (UInt40)value.x12;
                *((UInt40*)ptr + 13) = (UInt40)value.x13;
                *((UInt40*)ptr + 14) = (UInt40)value.x14;
                *((UInt40*)ptr + 15) = (UInt40)value.x15;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i16_to48(void* ptr, short16 value)
        {
            if (Avx2.IsAvx2Supported)
            {
                v256 sign = Avx2.mm256_srai_epi16(value, 15);
                v256 sign0 = Avx2.mm256_shuffle_epi8(sign, new v256(0, 0, 0, 0, 0, 0,   2, 2, 2, 2, 2, 2,   4, 4, 4, 4,
                                                                    0, 0, 0, 0, 0, 0,   2, 2, 2, 2, 2, 2,   4, 4, 4, 4));
                v256 sign1 = Avx2.mm256_shuffle_epi8(sign, new v256(4, 4,   6, 6, 6, 6, 6, 6,   8, 8, 8, 8, 8, 8,   10, 10,
                                                                    4, 4,   6, 6, 6, 6, 6, 6,   8, 8, 8, 8, 8, 8,   10, 10));
                v256 sign2 = Avx2.mm256_shuffle_epi8(sign, new v256(10, 10, 10, 10,   12, 12, 12, 12, 12, 12,   14, 14, 14, 14, 14, 14,
                                                                    10, 10, 10, 10,   12, 12, 12, 12, 12, 12,   14, 14, 14, 14, 14, 14));
                
                v256 shuf0 = Avx2.mm256_shuffle_epi8(value, new v256(0, 1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1,   4, 5, -1, -1,
                                                                     0, 1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1,   4, 5, -1, -1));
                v256 shuf1 = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1,   6, 7, -1, -1, -1, -1,   8, 9, -1, -1, -1, -1,   10, 11,
                                                                     -1, -1,   6, 7, -1, -1, -1, -1,   8, 9, -1, -1, -1, -1,   10, 11));
                v256 shuf2 = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1, -1, -1,   12, 13, -1, -1, -1, -1,   14, 15, -1, -1, -1, -1,
                                                                     -1, -1, -1, -1,   12, 13, -1, -1, -1, -1,   14, 15, -1, -1, -1, -1));
                
                shuf0 = Avx2.mm256_blend_epi16(shuf0, sign0, 0b10110110);
                shuf1 = Avx2.mm256_blend_epi16(shuf1, sign1, 0b01101101);
                shuf2 = Avx2.mm256_blend_epi16(shuf2, sign2, 0b11011011);
                
                *((v128*)((byte*)ptr + 0))  = shuf0.Lo128;
                *((v128*)((byte*)ptr + 16)) = shuf1.Lo128;
                *((v128*)((byte*)ptr + 32)) = shuf2.Lo128;
                *((v128*)((byte*)ptr + 48)) = shuf0.Hi128;
                *((v128*)((byte*)ptr + 64)) = shuf1.Hi128;
                *((v128*)((byte*)ptr + 80)) = shuf2.Hi128;
            }
            else if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 signLo = srai_epi16(value.v8_0, 15);
                v128 signHi = srai_epi16(value.v8_8, 15);
                v128 signLo0 = shuffle_epi8(signLo, new v128(0, 0, 0, 0, 0, 0,   2, 2, 2, 2, 2, 2,   4, 4, 4, 4));
                v128 signLo1 = shuffle_epi8(signLo, new v128(4, 4,   6, 6, 6, 6, 6, 6,   8, 8, 8, 8, 8, 8,   10, 10));
                v128 signLo2 = shuffle_epi8(signLo, new v128(10, 10, 10, 10,   12, 12, 12, 12, 12, 12,   14, 14, 14, 14, 14, 14));
                v128 signHi0 = shuffle_epi8(signHi, new v128(0, 0, 0, 0, 0, 0,   2, 2, 2, 2, 2, 2,   4, 4, 4, 4));
                v128 signHi1 = shuffle_epi8(signHi, new v128(4, 4,   6, 6, 6, 6, 6, 6,   8, 8, 8, 8, 8, 8,   10, 10));
                v128 signHi2 = shuffle_epi8(signHi, new v128(10, 10, 10, 10,   12, 12, 12, 12, 12, 12,   14, 14, 14, 14, 14, 14));
                
                v128 shufLo0 = shuffle_epi8(value.v8_0, new v128(0, 1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1,   4, 5, -1, -1));
                v128 shufLo1 = shuffle_epi8(value.v8_0, new v128(-1, -1,   6, 7, -1, -1, -1, -1,   8, 9, -1, -1, -1, -1,   10, 11));
                v128 shufLo2 = shuffle_epi8(value.v8_0, new v128(-1, -1, -1, -1,   12, 13, -1, -1, -1, -1,   14, 15, -1, -1, -1, -1));
                v128 shufHi0 = shuffle_epi8(value.v8_8, new v128(0, 1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1,   4, 5, -1, -1));
                v128 shufHi1 = shuffle_epi8(value.v8_8, new v128(-1, -1,   6, 7, -1, -1, -1, -1,   8, 9, -1, -1, -1, -1,   10, 11));
                v128 shufHi2 = shuffle_epi8(value.v8_8, new v128(-1, -1, -1, -1,   12, 13, -1, -1, -1, -1,   14, 15, -1, -1, -1, -1));
                
                shufLo0 = blend_epi16(shufLo0, signLo0, 0b10110110);
                shufLo1 = blend_epi16(shufLo1, signLo1, 0b01101101);
                shufLo2 = blend_epi16(shufLo2, signLo2, 0b11011011);
                shufHi0 = blend_epi16(shufHi0, signHi0, 0b10110110);
                shufHi1 = blend_epi16(shufHi1, signHi1, 0b01101101);
                shufHi2 = blend_epi16(shufHi2, signHi2, 0b11011011);

                *((v128*)((byte*)ptr + 0))  = shufLo0;
                *((v128*)((byte*)ptr + 16)) = shufLo1;
                *((v128*)((byte*)ptr + 32)) = shufLo2;
                *((v128*)((byte*)ptr + 48)) = shufHi0;
                *((v128*)((byte*)ptr + 64)) = shufHi1;
                *((v128*)((byte*)ptr + 80)) = shufHi2;
            }
            else
            {
                *((UInt48*)ptr + 0)  = (UInt48)value.x0;
                *((UInt48*)ptr + 1)  = (UInt48)value.x1;
                *((UInt48*)ptr + 2)  = (UInt48)value.x2;
                *((UInt48*)ptr + 3)  = (UInt48)value.x3;
                *((UInt48*)ptr + 4)  = (UInt48)value.x4;
                *((UInt48*)ptr + 5)  = (UInt48)value.x5;
                *((UInt48*)ptr + 6)  = (UInt48)value.x6;
                *((UInt48*)ptr + 7)  = (UInt48)value.x7;
                *((UInt48*)ptr + 8)  = (UInt48)value.x8;
                *((UInt48*)ptr + 9)  = (UInt48)value.x9;
                *((UInt48*)ptr + 10) = (UInt48)value.x10;
                *((UInt48*)ptr + 11) = (UInt48)value.x11;
                *((UInt48*)ptr + 12) = (UInt48)value.x12;
                *((UInt48*)ptr + 13) = (UInt48)value.x13;
                *((UInt48*)ptr + 14) = (UInt48)value.x14;
                *((UInt48*)ptr + 15) = (UInt48)value.x15;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i16_to56(void* ptr, short16 value)
        {
            if (Avx2.IsAvx2Supported)
            {
                v256 sign = Avx2.mm256_srai_epi16(value, 15);
                v256 sign0 = Avx2.mm256_shuffle_epi8(sign, new v256(0, 0, 0, 0, 0, 0, 0,   2, 2, 2, 2, 2, 2, 2,   4, 4,
                                                                    0, 0, 0, 0, 0, 0, 0,   2, 2, 2, 2, 2, 2, 2,   4, 4));
                v256 sign1 = Avx2.mm256_shuffle_epi8(sign, new v256(4, 4, 4, 4, 4,   6, 6, 6, 6, 6, 6, 6,   8, 8, 8, 8,
                                                                    4, 4, 4, 4, 4,   6, 6, 6, 6, 6, 6, 6,   8, 8, 8, 8));
                v256 sign2 = Avx2.mm256_shuffle_epi8(sign, new v256(8, 8, 8,   10, 10, 10, 10, 10, 10, 10,   12, 12, 12, 12, 12, 12,
                                                                    8, 8, 8,   10, 10, 10, 10, 10, 10, 10,   12, 12, 12, 12, 12, 12));
                v256 sign3 = Avx2.mm256_shuffle_epi8(sign, new v256(12,   14, 14, 14, 14, 14, 14, 14,   0, 0, 0, 0, 0, 0, 0, 0,
                                                                    12,   14, 14, 14, 14, 14, 14, 14,   0, 0, 0, 0, 0, 0, 0, 0));
                
                v256 shuf0 = Avx2.mm256_shuffle_epi8(value, new v256(0, 1, -1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1, -1,   4, 5,
                                                                     0, 1, -1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1, -1,   4, 5));
                v256 shuf1 = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1, -1, -1, -1,   6, 7, -1, -1, -1, -1, -1,   8, 9, -1, -1,
                                                                     -1, -1, -1, -1, -1,   6, 7, -1, -1, -1, -1, -1,   8, 9, -1, -1));
                v256 shuf2 = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1, -1,   10, 11, -1, -1, -1, -1, -1,   12, 13, -1, -1, -1, -1,
                                                                     -1, -1, -1,   10, 11, -1, -1, -1, -1, -1,   12, 13, -1, -1, -1, -1));
                v256 shuf3 = Avx2.mm256_shuffle_epi8(value, new v256(-1,   14, 15, -1, -1, -1, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0,
                                                                     -1,   14, 15, -1, -1, -1, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0));
                
                shuf0 = Avx2.mm256_blendv_epi8(shuf0, sign0, new v256(0, 1, -1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1, -1,   4, 5,
                                                                      0, 1, -1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1, -1,   4, 5));
                shuf1 = Avx2.mm256_blendv_epi8(shuf1, sign1, new v256(-1, -1, -1, -1, -1,   6, 7, -1, -1, -1, -1, -1,   8, 9, -1, -1,
                                                                      -1, -1, -1, -1, -1,   6, 7, -1, -1, -1, -1, -1,   8, 9, -1, -1));
                shuf2 = Avx2.mm256_blendv_epi8(shuf2, sign2, new v256(-1, -1, -1,   10, 11, -1, -1, -1, -1, -1,   12, 13, -1, -1, -1, -1,
                                                                      -1, -1, -1,   10, 11, -1, -1, -1, -1, -1,   12, 13, -1, -1, -1, -1));
                shuf3 = Avx2.mm256_blendv_epi8(shuf3, sign3, new v256(-1,   14, 15, -1, -1, -1, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0,
                                                                      -1,   14, 15, -1, -1, -1, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0));

                *((v128*)((byte*)ptr + 0))   = shuf0.Lo128;
                *((v128*)((byte*)ptr + 16))  = shuf1.Lo128;
                *((v128*)((byte*)ptr + 32))  = shuf2.Lo128;
                *((long*)((byte*)ptr + 48))  = shuf3.SLong0;
                *((v128*)((byte*)ptr + 56))  = shuf0.Hi128;
                *((v128*)((byte*)ptr + 72))  = shuf1.Hi128;
                *((v128*)((byte*)ptr + 88))  = shuf2.Hi128;
                *((long*)((byte*)ptr + 104)) = shuf3.SLong2;
            }
            else if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 signLo = srai_epi16(value.v8_0, 15);
                v128 signHi = srai_epi16(value.v8_8, 15);
                v128 signLo0 = shuffle_epi8(signLo, new v128(0, 0, 0, 0, 0, 0, 0,   2, 2, 2, 2, 2, 2, 2,   4, 4));
                v128 signLo1 = shuffle_epi8(signLo, new v128(4, 4, 4, 4, 4,   6, 6, 6, 6, 6, 6, 6,   8, 8, 8, 8));
                v128 signLo2 = shuffle_epi8(signLo, new v128(8, 8, 8,   10, 10, 10, 10, 10, 10, 10,   12, 12, 12, 12, 12, 12));
                v128 signLo3 = shuffle_epi8(signLo, new v128(12,   14, 14, 14, 14, 14, 14, 14,   0, 0, 0, 0, 0, 0, 0, 0));
                v128 signHi0 = shuffle_epi8(signHi, new v128(0, 0, 0, 0, 0, 0, 0,   2, 2, 2, 2, 2, 2, 2,   4, 4));
                v128 signHi1 = shuffle_epi8(signHi, new v128(4, 4, 4, 4, 4,   6, 6, 6, 6, 6, 6, 6,   8, 8, 8, 8));
                v128 signHi2 = shuffle_epi8(signHi, new v128(8, 8, 8,   10, 10, 10, 10, 10, 10, 10,   12, 12, 12, 12, 12, 12));
                v128 signHi3 = shuffle_epi8(signHi, new v128(12,   14, 14, 14, 14, 14, 14, 14,   0, 0, 0, 0, 0, 0, 0, 0));

                v128 shufLo0 = shuffle_epi8(value.v8_0, new v128(0, 1, -1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1, -1,   4, 5));
                v128 shufLo1 = shuffle_epi8(value.v8_0, new v128(-1, -1, -1, -1, -1,   6, 7, -1, -1, -1, -1, -1,   8, 9, -1, -1));
                v128 shufLo2 = shuffle_epi8(value.v8_0, new v128(-1, -1, -1,   10, 11, -1, -1, -1, -1, -1,   12, 13, -1, -1, -1, -1));
                v128 shufLo3 = shuffle_epi8(value.v8_0, new v128(-1,   14, 15, -1, -1, -1, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0));
                v128 shufHi0 = shuffle_epi8(value.v8_8, new v128(0, 1, -1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1, -1,   4, 5));
                v128 shufHi1 = shuffle_epi8(value.v8_8, new v128(-1, -1, -1, -1, -1,   6, 7, -1, -1, -1, -1, -1,   8, 9, -1, -1));
                v128 shufHi2 = shuffle_epi8(value.v8_8, new v128(-1, -1, -1,   10, 11, -1, -1, -1, -1, -1,   12, 13, -1, -1, -1, -1));
                v128 shufHi3 = shuffle_epi8(value.v8_8, new v128(-1,   14, 15, -1, -1, -1, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0));

                shufLo0 = blendv_epi8(shufLo0, signLo0, new v128(0, 1, -1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1, -1,   4, 5));
                shufLo1 = blendv_epi8(shufLo1, signLo1, new v128(-1, -1, -1, -1, -1,   6, 7, -1, -1, -1, -1, -1,   8, 9, -1, -1));
                shufLo2 = blendv_epi8(shufLo2, signLo2, new v128(-1, -1, -1,   10, 11, -1, -1, -1, -1, -1,   12, 13, -1, -1, -1, -1));
                shufLo3 = blendv_epi8(shufLo3, signLo3, new v128(-1,   14, 15, -1, -1, -1, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0));
                shufHi0 = blendv_epi8(shufHi0, signHi0, new v128(0, 1, -1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1, -1,   4, 5));
                shufHi1 = blendv_epi8(shufHi1, signHi1, new v128(-1, -1, -1, -1, -1,   6, 7, -1, -1, -1, -1, -1,   8, 9, -1, -1));
                shufHi2 = blendv_epi8(shufHi2, signHi2, new v128(-1, -1, -1,   10, 11, -1, -1, -1, -1, -1,   12, 13, -1, -1, -1, -1));
                shufHi3 = blendv_epi8(shufHi3, signHi3, new v128(-1,   14, 15, -1, -1, -1, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0));
                
                *((v128*)((byte*)ptr + 0))   = shufLo0;
                *((v128*)((byte*)ptr + 16))  = shufLo1;
                *((v128*)((byte*)ptr + 32))  = shufLo2;
                *((long*)((byte*)ptr + 48))  = shufLo3.SLong0;
                *((v128*)((byte*)ptr + 56))  = shufHi0;
                *((v128*)((byte*)ptr + 72))  = shufHi1;
                *((v128*)((byte*)ptr + 88))  = shufHi2;
                *((long*)((byte*)ptr + 104)) = shufHi3.SLong0;
            }
            else
            {
                *((UInt56*)ptr + 0)  = (UInt56)value.x0;
                *((UInt56*)ptr + 1)  = (UInt56)value.x1;
                *((UInt56*)ptr + 2)  = (UInt56)value.x2;
                *((UInt56*)ptr + 3)  = (UInt56)value.x3;
                *((UInt56*)ptr + 4)  = (UInt56)value.x4;
                *((UInt56*)ptr + 5)  = (UInt56)value.x5;
                *((UInt56*)ptr + 6)  = (UInt56)value.x6;
                *((UInt56*)ptr + 7)  = (UInt56)value.x7;
                *((UInt56*)ptr + 8)  = (UInt56)value.x8;
                *((UInt56*)ptr + 9)  = (UInt56)value.x9;
                *((UInt56*)ptr + 10) = (UInt56)value.x10;
                *((UInt56*)ptr + 11) = (UInt56)value.x11;
                *((UInt56*)ptr + 12) = (UInt56)value.x12;
                *((UInt56*)ptr + 13) = (UInt56)value.x13;
                *((UInt56*)ptr + 14) = (UInt56)value.x14;
                *((UInt56*)ptr + 15) = (UInt56)value.x15;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i16_to24(void* ptr, short8 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi16(value, 15);
                v128 signLo = shuffle_epi8(sign, new v128(0, 0, 0,   2, 2, 2,   4, 4, 4,   6, 6, 6,   8, 8, 8,   10));
                v128 signHi = shuffle_epi8(sign, new v128(10, 10,   12, 12, 12,   14, 14, 14,   0, 0, 0, 0, 0, 0, 0, 0));

                v128 shufLo = shuffle_epi8(value, new v128(0, 1, -1,   2, 3, -1,   4, 5, -1,   6, 7, -1,   8, 9, -1,   10));
                v128 shufHi = shuffle_epi8(value, new v128(11, -1,   12, 13, -1,   14, 15, -1,   0, 0, 0, 0, 0, 0, 0, 0));

                shufLo = blendv_epi8(shufLo, signLo, new v128(0, 1, -1,   2, 3, -1,   4, 5, -1,   6, 7, -1,   8, 9, -1,   10));
                shufHi = blendv_epi8(shufHi, signHi, new v128(11, -1,   12, 13, -1,   14, 15, -1,   0, 0, 0, 0, 0, 0, 0, 0));

                *((v128*)((byte*)ptr + 0))  = shufLo;
                *((long*)((byte*)ptr + 16)) = shufHi.SLong0;
            }
            else
            {
                *((UInt24*)ptr + 0) = (UInt24)value.x0;
                *((UInt24*)ptr + 1) = (UInt24)value.x1;
                *((UInt24*)ptr + 2) = (UInt24)value.x2;
                *((UInt24*)ptr + 3) = (UInt24)value.x3;
                *((UInt24*)ptr + 4) = (UInt24)value.x4;
                *((UInt24*)ptr + 5) = (UInt24)value.x5;
                *((UInt24*)ptr + 6) = (UInt24)value.x6;
                *((UInt24*)ptr + 7) = (UInt24)value.x7;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i16_to40(void* ptr, short8 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi16(value, 15);
                v128 sign0 = shuffle_epi8(sign, new v128(0, 0, 0, 0, 0,   2, 2, 2, 2, 2,   4, 4, 4, 4, 4,   6));
                v128 sign1 = shuffle_epi8(sign, new v128(6, 6, 6, 6,   8, 8, 8, 8, 8,   10, 10, 10, 10, 10,   12, 12));
                v128 sign2 = shuffle_epi8(sign, new v128(12, 12, 12,   14, 14, 14, 14, 14,   0, 0, 0, 0, 0, 0, 0, 0));

                v128 shuf0 = shuffle_epi8(value, new v128(0, 1, -1, -1, -1,   2, 3, -1, -1, -1,   4, 5, -1, -1, -1,   6));
                v128 shuf1 = shuffle_epi8(value, new v128(7, -1, -1, -1,   8, 9, -1, -1, -1,   10, 11, -1, -1, -1,   12, 13));
                v128 shuf2 = shuffle_epi8(value, new v128(-1, -1, -1,   14, 15, -1, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0));

                shuf0 = blendv_epi8(shuf0, sign0, new v128(0, 1, -1, -1, -1,   2, 3, -1, -1, -1,   4, 5, -1, -1, -1,   6));
                shuf1 = blendv_epi8(shuf1, sign1, new v128(7, -1, -1, -1,   8, 9, -1, -1, -1,   10, 11, -1, -1, -1,   12, 13));
                shuf2 = blendv_epi8(shuf2, sign2, new v128(-1, -1, -1,   14, 15, -1, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0));

                *((v128*)((byte*)ptr + 0))  = shuf0;
                *((v128*)((byte*)ptr + 16)) = shuf1;
                *((long*)((byte*)ptr + 32)) = shuf2.SLong0;
            }
            else
            {
                *((UInt40*)ptr + 0) = (UInt40)value.x0;
                *((UInt40*)ptr + 1) = (UInt40)value.x1;
                *((UInt40*)ptr + 2) = (UInt40)value.x2;
                *((UInt40*)ptr + 3) = (UInt40)value.x3;
                *((UInt40*)ptr + 4) = (UInt40)value.x4;
                *((UInt40*)ptr + 5) = (UInt40)value.x5;
                *((UInt40*)ptr + 6) = (UInt40)value.x6;
                *((UInt40*)ptr + 7) = (UInt40)value.x7;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i16_to48(void* ptr, short8 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi16(value, 15);
                v128 sign0 = shuffle_epi8(sign, new v128(0, 0, 0, 0, 0, 0,   2, 2, 2, 2, 2, 2,   4, 4, 4, 4));
                v128 sign1 = shuffle_epi8(sign, new v128(4, 4,   6, 6, 6, 6, 6, 6,   8, 8, 8, 8, 8, 8,   10, 10));
                v128 sign2 = shuffle_epi8(sign, new v128(10, 10, 10, 10,   12, 12, 12, 12, 12, 12,   14, 14, 14, 14, 14, 14));

                v128 shuf0 = shuffle_epi8(value, new v128(0, 1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1,   4, 5, -1, -1));
                v128 shuf1 = shuffle_epi8(value, new v128(-1, -1,   6, 7, -1, -1, -1, -1,   8, 9, -1, -1, -1, -1,   10, 11));
                v128 shuf2 = shuffle_epi8(value, new v128(-1, -1, -1, -1,   12, 13, -1, -1, -1, -1,   14, 15, -1, -1, -1, -1));
                
                shuf0 = blend_epi16(shuf0, sign0, 0b10110110);
                shuf1 = blend_epi16(shuf1, sign1, 0b01101101);
                shuf2 = blend_epi16(shuf2, sign2, 0b11011011);

                *((v128*)((byte*)ptr + 0))  = shuf0;
                *((v128*)((byte*)ptr + 16)) = shuf1;
                *((v128*)((byte*)ptr + 32)) = shuf2;
            }
            else
            {
                *((UInt48*)ptr + 0) = (UInt48)value.x0;
                *((UInt48*)ptr + 1) = (UInt48)value.x1;
                *((UInt48*)ptr + 2) = (UInt48)value.x2;
                *((UInt48*)ptr + 3) = (UInt48)value.x3;
                *((UInt48*)ptr + 4) = (UInt48)value.x4;
                *((UInt48*)ptr + 5) = (UInt48)value.x5;
                *((UInt48*)ptr + 6) = (UInt48)value.x6;
                *((UInt48*)ptr + 7) = (UInt48)value.x7;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i16_to56(void* ptr, short8 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi16(value, 15);
                v128 sign0 = shuffle_epi8(sign, new v128(0, 0, 0, 0, 0, 0, 0,   2, 2, 2, 2, 2, 2, 2,   4, 4));
                v128 sign1 = shuffle_epi8(sign, new v128(4, 4, 4, 4, 4,   6, 6, 6, 6, 6, 6, 6,   8, 8, 8, 8));
                v128 sign2 = shuffle_epi8(sign, new v128(8, 8, 8,   10, 10, 10, 10, 10, 10, 10,   12, 12, 12, 12, 12, 12));
                v128 sign3 = shuffle_epi8(sign, new v128(12,   14, 14, 14, 14, 14, 14, 14,   0, 0, 0, 0, 0, 0, 0, 0));

                v128 shuf0 = shuffle_epi8(value, new v128(0, 1, -1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1, -1,   4, 5));
                v128 shuf1 = shuffle_epi8(value, new v128(-1, -1, -1, -1, -1,   6, 7, -1, -1, -1, -1, -1,   8, 9, -1, -1));
                v128 shuf2 = shuffle_epi8(value, new v128(-1, -1, -1,   10, 11, -1, -1, -1, -1, -1,   12, 13, -1, -1, -1, -1));
                v128 shuf3 = shuffle_epi8(value, new v128(-1,   14, 15, -1, -1, -1, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0));

                shuf0 = blendv_epi8(shuf0, sign0, new v128(0, 1, -1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1, -1,   4, 5));
                shuf1 = blendv_epi8(shuf1, sign1, new v128(-1, -1, -1, -1, -1,   6, 7, -1, -1, -1, -1, -1,   8, 9, -1, -1));
                shuf2 = blendv_epi8(shuf2, sign2, new v128(-1, -1, -1,   10, 11, -1, -1, -1, -1, -1,   12, 13, -1, -1, -1, -1));
                shuf3 = blendv_epi8(shuf3, sign3, new v128(-1,   14, 15, -1, -1, -1, -1, -1,   0, 0, 0, 0, 0, 0, 0, 0));

                *((v128*)((byte*)ptr + 0))  = shuf0;
                *((v128*)((byte*)ptr + 16)) = shuf1;
                *((v128*)((byte*)ptr + 32)) = shuf2;
                *((long*)((byte*)ptr + 48)) = shuf3.SLong0;
            }
            else
            {
                *((UInt56*)ptr + 0) = (UInt56)value.x0;
                *((UInt56*)ptr + 1) = (UInt56)value.x1;
                *((UInt56*)ptr + 2) = (UInt56)value.x2;
                *((UInt56*)ptr + 3) = (UInt56)value.x3;
                *((UInt56*)ptr + 4) = (UInt56)value.x4;
                *((UInt56*)ptr + 5) = (UInt56)value.x5;
                *((UInt56*)ptr + 6) = (UInt56)value.x6;
                *((UInt56*)ptr + 7) = (UInt56)value.x7;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i16_to24(void* ptr, short4 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi16(value, 15);
                sign = shuffle_epi8(sign, new v128(0, 0, 0,   2, 2, 2,   4, 4, 4,   6, 6, 6,   8, 8, 8,   10));

                v128 shuf = shuffle_epi8(value, new v128(0, 1, -1,   2, 3, -1,   4, 5, -1,   6, 7, -1,   8, 9, -1,   10));

                shuf = blendv_epi8(shuf, sign, new v128(0, 1, -1,   2, 3, -1,   4, 5, -1,   6, 7, -1,   8, 9, -1,   10));

                *((long*)((byte*)ptr + 0)) = shuf.SLong0;
                *((int*) ((byte*)ptr + 8)) = shuf.SInt2;
            }
            else
            {
                *((UInt24*)ptr + 0) = (UInt24)value.x;
                *((UInt24*)ptr + 1) = (UInt24)value.y;
                *((UInt24*)ptr + 2) = (UInt24)value.z;
                *((UInt24*)ptr + 3) = (UInt24)value.w;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i16_to40(void* ptr, short4 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi16(value, 15);
                v128 sign0 = shuffle_epi8(sign, new v128(0, 0, 0, 0, 0,   2, 2, 2, 2, 2,   4, 4, 4, 4, 4,   6));
                v128 sign1 = shuffle_epi8(sign, new v128(6, 6, 6, 6,   8, 8, 8, 8, 8,   10, 10, 10, 10, 10,   12, 12));

                v128 shuf0 = shuffle_epi8(value, new v128(0, 1, -1, -1, -1,   2, 3, -1, -1, -1,   4, 5, -1, -1, -1,   6));
                v128 shuf1 = shuffle_epi8(value, new v128(7, -1, -1, -1,   8, 9, -1, -1, -1,   10, 11, -1, -1, -1,   12, 13));

                shuf0 = blendv_epi8(shuf0, sign0, new v128(0, 1, -1, -1, -1,   2, 3, -1, -1, -1,   4, 5, -1, -1, -1,   6));
                shuf1 = blendv_epi8(shuf1, sign1, new v128(7, -1, -1, -1,   8, 9, -1, -1, -1,   10, 11, -1, -1, -1,   12, 13));

                *((v128*)((byte*)ptr + 0))  = shuf0;
                *((int*) ((byte*)ptr + 16)) = shuf1.SInt0;
            }
            else
            {
                *((UInt40*)ptr + 0) = (UInt40)value.x;
                *((UInt40*)ptr + 1) = (UInt40)value.y;
                *((UInt40*)ptr + 2) = (UInt40)value.z;
                *((UInt40*)ptr + 3) = (UInt40)value.w;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i16_to48(void* ptr, short4 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi16(value, 15);
                v128 sign0 = shuffle_epi8(sign, new v128(0, 0, 0, 0, 0, 0,   2, 2, 2, 2, 2, 2,   4, 4, 4, 4));
                v128 sign1 = shuffle_epi8(sign, new v128(4, 4,   6, 6, 6, 6, 6, 6,   8, 8, 8, 8, 8, 8,   10, 10));

                v128 shuf0 = shuffle_epi8(value, new v128(0, 1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1,   4, 5, -1, -1));
                v128 shuf1 = shuffle_epi8(value, new v128(-1, -1,   6, 7, -1, -1, -1, -1,   8, 9, -1, -1, -1, -1,   10, 11));
                
                shuf0 = blend_epi16(shuf0, sign0, 0b10110110);
                shuf1 = blend_epi16(shuf1, sign1, 0b01101101);

                *((v128*)((byte*)ptr + 0))  = shuf0;
                *((long*)((byte*)ptr + 16)) = shuf1.SLong0;
            }
            else
            {
                *((UInt48*)ptr + 0) = (UInt48)value.x;
                *((UInt48*)ptr + 1) = (UInt48)value.y;
                *((UInt48*)ptr + 2) = (UInt48)value.z;
                *((UInt48*)ptr + 3) = (UInt48)value.w;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i16_to56(void* ptr, short4 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi16(value, 15);
                v128 sign0 = shuffle_epi8(sign, new v128(0, 0, 0, 0, 0, 0, 0,   2, 2, 2, 2, 2, 2, 2,   4, 4));
                v128 sign1 = shuffle_epi8(sign, new v128(4, 4, 4, 4, 4,   6, 6, 6, 6, 6, 6, 6,   8, 8, 8, 8));

                v128 shuf0 = shuffle_epi8(value, new v128(0, 1, -1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1, -1,   4, 5));
                v128 shuf1 = shuffle_epi8(value, new v128(-1, -1, -1, -1, -1,   6, 7, -1, -1, -1, -1, -1,   8, 9, -1, -1));

                shuf0 = blendv_epi8(shuf0, sign0, new v128(0, 1, -1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1, -1,   4, 5));
                shuf1 = blendv_epi8(shuf1, sign1, new v128(-1, -1, -1, -1, -1,   6, 7, -1, -1, -1, -1, -1,   8, 9, -1, -1));

                *((v128*)((byte*)ptr + 0))  = shuf0;
                *((long*)((byte*)ptr + 16)) = shuf1.SLong0;
                *((int*) ((byte*)ptr + 24)) = sign1.SInt2;
            }
            else
            {
                *((UInt56*)ptr + 0) = (UInt56)value.x;
                *((UInt56*)ptr + 1) = (UInt56)value.y;
                *((UInt56*)ptr + 2) = (UInt56)value.z;
                *((UInt56*)ptr + 3) = (UInt56)value.w;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i16_to24(void* ptr, short3 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi16(value, 15);
                sign = shuffle_epi8(sign, new v128(0, 0, 0,   2, 2, 2,   4, 4, 4,   6, 6, 6,   8, 8, 8,   10));

                v128 shuf = shuffle_epi8(value, new v128(0, 1, -1,   2, 3, -1,   4, 5, -1,   6, 7, -1,   8, 9, -1,   10));

                shuf = blendv_epi8(shuf, sign, new v128(0, 1, -1,   2, 3, -1,   4, 5, -1,   6, 7, -1,   8, 9, -1,   10));

                *((long*) ((byte*)ptr + 0)) = shuf.SLong0;
                *((sbyte*)((byte*)ptr + 8)) = shuf.SByte8;
            }
            else
            {
                *((UInt24*)ptr + 0) = (UInt24)value.x;
                *((UInt24*)ptr + 1) = (UInt24)value.y;
                *((UInt24*)ptr + 2) = (UInt24)value.z;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i16_to40(void* ptr, short3 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi16(value, 15);
                sign = shuffle_epi8(sign, new v128(0, 0, 0, 0, 0,   2, 2, 2, 2, 2,   4, 4, 4, 4, 4,   6));

                v128 shuf = shuffle_epi8(value, new v128(0, 1, -1, -1, -1,   2, 3, -1, -1, -1,   4, 5, -1, -1, -1,   6));

                shuf = blendv_epi8(shuf, sign, new v128(0, 1, -1, -1, -1,   2, 3, -1, -1, -1,   4, 5, -1, -1, -1,   6));

                *((long*) ((byte*)ptr + 0))  = shuf.SLong0;
                *((int*)  ((byte*)ptr + 8))  = shuf.SInt2;
                *((short*)((byte*)ptr + 12)) = shuf.SShort6;
                *((sbyte*)((byte*)ptr + 14)) = shuf.SByte14;
            }
            else
            {
                *((UInt40*)ptr + 0) = (UInt40)value.x;
                *((UInt40*)ptr + 1) = (UInt40)value.y;
                *((UInt40*)ptr + 2) = (UInt40)value.z;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i16_to48(void* ptr, short3 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi16(value, 15);
                sign = shuffle_epi8(sign, new v128(0, 0, 0, 0, 0, 0,   2, 2, 2, 2, 2, 2,   4, 4, 4, 4));

                v128 shuf = shuffle_epi8(value, new v128(0, 1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1,   4, 5, -1, -1));
                
                shuf = blend_epi16(shuf, sign, 0b10110110);

                *((v128*) ((byte*)ptr + 0))  = shuf;
                *((short*)((byte*)ptr + 16)) = sign.SShort7;
            }
            else
            {
                *((UInt48*)ptr + 0) = (UInt48)value.x;
                *((UInt48*)ptr + 1) = (UInt48)value.y;
                *((UInt48*)ptr + 2) = (UInt48)value.z;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i16_to56(void* ptr, short3 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi16(value, 15);
                sign = shuffle_epi8(sign, new v128(0, 0, 0, 0, 0, 0, 0,   2, 2, 2, 2, 2, 2, 2,   4, 4));

                v128 shuf = shuffle_epi8(value, new v128(0, 1, -1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1, -1,   4, 5));

                shuf = blendv_epi8(shuf, sign, new v128(0, 1, -1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1, -1,   4, 5));

                *((v128*) ((byte*)ptr + 0))  = shuf;
                *((short*)((byte*)ptr + 16)) = sign.SShort7;
                *((short*)((byte*)ptr + 18)) = sign.SShort7;
                *((sbyte*)((byte*)ptr + 20)) = sign.SByte15;
            }
            else
            {
                *((UInt56*)ptr + 0) = (UInt56)value.x;
                *((UInt56*)ptr + 1) = (UInt56)value.y;
                *((UInt56*)ptr + 2) = (UInt56)value.z;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i16_to24(void* ptr, short2 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi16(value, 15);
                sign = shuffle_epi8(sign, new v128(0, 0, 0,   2, 2, 2,   4, 4, 4,   6, 6, 6,   8, 8, 8,   10));

                v128 shuf = shuffle_epi8(value, new v128(0, 1, -1,   2, 3, -1,   4, 5, -1,   6, 7, -1,   8, 9, -1,   10));

                shuf = blendv_epi8(shuf, sign, new v128(0, 1, -1,   2, 3, -1,   4, 5, -1,   6, 7, -1,   8, 9, -1,   10));

                *((int*)  ((byte*)ptr + 0)) = shuf.SInt0;
                *((short*)((byte*)ptr + 4)) = shuf.SShort2;
            }
            else
            {
                *((UInt24*)ptr + 0) = (UInt24)value.x;
                *((UInt24*)ptr + 1) = (UInt24)value.y;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i16_to40(void* ptr, short2 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi16(value, 15);
                sign = shuffle_epi8(sign, new v128(0, 0, 0, 0, 0,   2, 2, 2, 2, 2,   4, 4, 4, 4, 4,   6));

                v128 shuf = shuffle_epi8(value, new v128(0, 1, -1, -1, -1,   2, 3, -1, -1, -1,   4, 5, -1, -1, -1,   6));

                shuf = blendv_epi8(shuf, sign, new v128(0, 1, -1, -1, -1,   2, 3, -1, -1, -1,   4, 5, -1, -1, -1,   6));

                *((long*) ((byte*)ptr + 0)) = shuf.SLong0;
                *((short*)((byte*)ptr + 8)) = sign.SShort3;
            }
            else
            {
                *((UInt40*)ptr + 0) = (UInt40)value.x;
                *((UInt40*)ptr + 1) = (UInt40)value.y;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i16_to48(void* ptr, short2 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi16(value, 15);
                sign = shuffle_epi8(sign, new v128(0, 0, 0, 0, 0, 0,   2, 2, 2, 2, 2, 2,   4, 4, 4, 4));

                v128 shuf = shuffle_epi8(value, new v128(0, 1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1,   4, 5, -1, -1));
                
                shuf = blend_epi16(shuf, sign, 0b10110110);

                *((long*)((byte*)ptr + 0)) = shuf.SLong0;
                *((int*) ((byte*)ptr + 8)) = sign.SInt2;
            }
            else
            {
                *((UInt48*)ptr + 0) = (UInt48)value.x;
                *((UInt48*)ptr + 1) = (UInt48)value.y;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i16_to56(void* ptr, short2 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi16(value, 15);
                sign = shuffle_epi8(sign, new v128(0, 0, 0, 0, 0, 0, 0,   2, 2, 2, 2, 2, 2, 2,   4, 4));

                v128 shuf = shuffle_epi8(value, new v128(0, 1, -1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1, -1,   4, 5));

                shuf = blendv_epi8(shuf, sign, new v128(0, 1, -1, -1, -1, -1, -1,   2, 3, -1, -1, -1, -1, -1,   4, 5));

                *((long*) ((byte*)ptr + 0))  = shuf.SLong0;
                *((int*)  ((byte*)ptr + 8))  = shuf.SInt2;
                *((short*)((byte*)ptr + 12)) = sign.SShort6;
            }
            else
            {
                *((UInt56*)ptr + 0) = (UInt56)value.x;
                *((UInt56*)ptr + 1) = (UInt56)value.y;
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u8_to24(void* ptr, byte32 value)
        {
            if (Avx2.IsAvx2Supported)
            {
                v256 shuf0 = Avx2.mm256_shuffle_epi8(value, new v256(0, -1, -1,   1, -1, -1,   2, -1, -1,   3, -1, -1,   4, -1, -1,   5,
                                                                     0, -1, -1,   1, -1, -1,   2, -1, -1,   3, -1, -1,   4, -1, -1,   5));
                v256 shuf1 = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1,   6, -1, -1,   7, -1, -1,   8, -1, -1,   9, -1, -1,   10, -1,
                                                                     -1, -1,   6, -1, -1,   7, -1, -1,   8, -1, -1,   9, -1, -1,   10, -1));
                v256 shuf2 = Avx2.mm256_shuffle_epi8(value, new v256(-1,   11, -1, -1,   12, -1, -1,   13, -1, -1,   14, -1, -1,   15, -1, -1,
                                                                     -1,   11, -1, -1,   12, -1, -1,   13, -1, -1,   14, -1, -1,   15, -1, -1));

                *((v128*)((byte*)ptr + 0))  = shuf0.Lo128;
                *((v128*)((byte*)ptr + 16)) = shuf1.Lo128;
                *((v128*)((byte*)ptr + 32)) = shuf2.Lo128;
                *((v128*)((byte*)ptr + 48)) = shuf0.Hi128;
                *((v128*)((byte*)ptr + 64)) = shuf1.Hi128;
                *((v128*)((byte*)ptr + 80)) = shuf2.Hi128;
            }
            else if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shufLo0 = shuffle_epi8(value.v16_0,  new v128(0, -1, -1,   1, -1, -1,   2, -1, -1,   3, -1, -1,   4, -1, -1,   5));
                v128 shufLo1 = shuffle_epi8(value.v16_0,  new v128(-1, -1,   6, -1, -1,   7, -1, -1,   8, -1, -1,   9, -1, -1,   10, -1));
                v128 shufLo2 = shuffle_epi8(value.v16_0,  new v128(-1,   11, -1, -1,   12, -1, -1,   13, -1, -1,   14, -1, -1,   15, -1, -1));
                v128 shufHi0 = shuffle_epi8(value.v16_16, new v128(0, -1, -1,   1, -1, -1,   2, -1, -1,   3, -1, -1,   4, -1, -1,   5));
                v128 shufHi1 = shuffle_epi8(value.v16_16, new v128(-1, -1,   6, -1, -1,   7, -1, -1,   8, -1, -1,   9, -1, -1,   10, -1));
                v128 shufHi2 = shuffle_epi8(value.v16_16, new v128(-1,   11, -1, -1,   12, -1, -1,   13, -1, -1,   14, -1, -1,   15, -1, -1));

                *((v128*)((byte*)ptr + 0))  = shufLo0;
                *((v128*)((byte*)ptr + 16)) = shufLo1;
                *((v128*)((byte*)ptr + 32)) = shufLo2;
                *((v128*)((byte*)ptr + 48)) = shufHi0;
                *((v128*)((byte*)ptr + 64)) = shufHi1;
                *((v128*)((byte*)ptr + 80)) = shufHi2;
            }
            else
            {
                *((UInt24*)ptr + 0)  = (UInt24)value.x0;
                *((UInt24*)ptr + 1)  = (UInt24)value.x1;
                *((UInt24*)ptr + 2)  = (UInt24)value.x2;
                *((UInt24*)ptr + 3)  = (UInt24)value.x3;
                *((UInt24*)ptr + 4)  = (UInt24)value.x4;
                *((UInt24*)ptr + 5)  = (UInt24)value.x5;
                *((UInt24*)ptr + 6)  = (UInt24)value.x6;
                *((UInt24*)ptr + 7)  = (UInt24)value.x7;
                *((UInt24*)ptr + 8)  = (UInt24)value.x8;
                *((UInt24*)ptr + 9)  = (UInt24)value.x9;
                *((UInt24*)ptr + 10) = (UInt24)value.x10;
                *((UInt24*)ptr + 11) = (UInt24)value.x11;
                *((UInt24*)ptr + 12) = (UInt24)value.x12;
                *((UInt24*)ptr + 13) = (UInt24)value.x13;
                *((UInt24*)ptr + 14) = (UInt24)value.x14;
                *((UInt24*)ptr + 15) = (UInt24)value.x15;
                *((UInt24*)ptr + 16) = (UInt24)value.x16;
                *((UInt24*)ptr + 17) = (UInt24)value.x17;
                *((UInt24*)ptr + 18) = (UInt24)value.x18;
                *((UInt24*)ptr + 19) = (UInt24)value.x19;
                *((UInt24*)ptr + 20) = (UInt24)value.x20;
                *((UInt24*)ptr + 21) = (UInt24)value.x21;
                *((UInt24*)ptr + 22) = (UInt24)value.x22;
                *((UInt24*)ptr + 23) = (UInt24)value.x23;
                *((UInt24*)ptr + 24) = (UInt24)value.x24;
                *((UInt24*)ptr + 25) = (UInt24)value.x25;
                *((UInt24*)ptr + 26) = (UInt24)value.x26;
                *((UInt24*)ptr + 27) = (UInt24)value.x27;
                *((UInt24*)ptr + 28) = (UInt24)value.x28;
                *((UInt24*)ptr + 29) = (UInt24)value.x29;
                *((UInt24*)ptr + 30) = (UInt24)value.x30;
                *((UInt24*)ptr + 31) = (UInt24)value.x31;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u8_to40(void* ptr, byte32 value)
        {
            if (Avx2.IsAvx2Supported)
            {
                v256 shuf0 = Avx2.mm256_shuffle_epi8(value, new v256(0, -1, -1, -1, -1,   1, -1, -1, -1, -1,   2, -1, -1, -1, -1,   3,
                                                                     0, -1, -1, -1, -1,   1, -1, -1, -1, -1,   2, -1, -1, -1, -1,   3));
                v256 shuf1 = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1, -1, -1,   4, -1, -1, -1, -1,   5, -1, -1, -1, -1,   6, -1,
                                                                     -1, -1, -1, -1,   4, -1, -1, -1, -1,   5, -1, -1, -1, -1,   6, -1));
                v256 shuf2 = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1, -1,   7, -1, -1, -1, -1,   8, -1, -1, -1, -1,   9, -1, -1,
                                                                     -1, -1, -1,   7, -1, -1, -1, -1,   8, -1, -1, -1, -1,   9, -1, -1));
                v256 shuf3 = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1,   10, -1, -1, -1, -1,   11, -1, -1, -1, -1,   12, -1, -1, -1,
                                                                     -1, -1,   10, -1, -1, -1, -1,   11, -1, -1, -1, -1,   12, -1, -1, -1));
                v256 shuf4 = Avx2.mm256_shuffle_epi8(value, new v256(-1,   13, -1, -1, -1, -1,   14, -1, -1, -1, -1,   15, -1, -1, -1, -1,
                                                                     -1,   13, -1, -1, -1, -1,   14, -1, -1, -1, -1,   15, -1, -1, -1, -1));

                *((v128*)((byte*)ptr + 0))   = shuf0.Lo128;
                *((v128*)((byte*)ptr + 16))  = shuf1.Lo128;
                *((v128*)((byte*)ptr + 32))  = shuf2.Lo128;
                *((v128*)((byte*)ptr + 48))  = shuf3.Lo128;
                *((v128*)((byte*)ptr + 64))  = shuf4.Lo128;
                *((v128*)((byte*)ptr + 80))  = shuf0.Hi128;
                *((v128*)((byte*)ptr + 96))  = shuf1.Hi128;
                *((v128*)((byte*)ptr + 112)) = shuf2.Hi128;
                *((v128*)((byte*)ptr + 128)) = shuf3.Hi128;
                *((v128*)((byte*)ptr + 144)) = shuf4.Hi128;
            }
            else if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shufLo0 = shuffle_epi8(value.v16_0,  new v128(0, -1, -1, -1, -1,   1, -1, -1, -1, -1,   2, -1, -1, -1, -1,   3));
                v128 shufLo1 = shuffle_epi8(value.v16_0,  new v128(-1, -1, -1, -1,   4, -1, -1, -1, -1,   5, -1, -1, -1, -1,   6, -1));
                v128 shufLo2 = shuffle_epi8(value.v16_0,  new v128(-1, -1, -1,   7, -1, -1, -1, -1,   8, -1, -1, -1, -1,   9, -1, -1));
                v128 shufLo3 = shuffle_epi8(value.v16_0,  new v128(-1, -1,   10, -1, -1, -1, -1,   11, -1, -1, -1, -1,   12, -1, -1, -1));
                v128 shufLo4 = shuffle_epi8(value.v16_0,  new v128(-1,   13, -1, -1, -1, -1,   14, -1, -1, -1, -1,   15, -1, -1, -1, -1));
                v128 shufHi0 = shuffle_epi8(value.v16_16, new v128(0, -1, -1, -1, -1,   1, -1, -1, -1, -1,   2, -1, -1, -1, -1,   3));
                v128 shufHi1 = shuffle_epi8(value.v16_16, new v128(-1, -1, -1, -1,   4, -1, -1, -1, -1,   5, -1, -1, -1, -1,   6, -1));
                v128 shufHi2 = shuffle_epi8(value.v16_16, new v128(-1, -1, -1,   7, -1, -1, -1, -1,   8, -1, -1, -1, -1,   9, -1, -1));
                v128 shufHi3 = shuffle_epi8(value.v16_16, new v128(-1, -1,   10, -1, -1, -1, -1,   11, -1, -1, -1, -1,   12, -1, -1, -1));
                v128 shufHi4 = shuffle_epi8(value.v16_16, new v128(-1,   13, -1, -1, -1, -1,   14, -1, -1, -1, -1,   15, -1, -1, -1, -1));
                
                *((v128*)((byte*)ptr + 0))   = shufLo0;
                *((v128*)((byte*)ptr + 16))  = shufLo1;
                *((v128*)((byte*)ptr + 32))  = shufLo2;
                *((v128*)((byte*)ptr + 48))  = shufLo3;
                *((v128*)((byte*)ptr + 64))  = shufLo4;
                *((v128*)((byte*)ptr + 80))  = shufHi0;
                *((v128*)((byte*)ptr + 96))  = shufHi1;
                *((v128*)((byte*)ptr + 112)) = shufHi2;
                *((v128*)((byte*)ptr + 128)) = shufHi3;
                *((v128*)((byte*)ptr + 144)) = shufHi4;
            }
            else
            {
                *((UInt40*)ptr + 0)  = (UInt40)value.x0;
                *((UInt40*)ptr + 1)  = (UInt40)value.x1;
                *((UInt40*)ptr + 2)  = (UInt40)value.x2;
                *((UInt40*)ptr + 3)  = (UInt40)value.x3;
                *((UInt40*)ptr + 4)  = (UInt40)value.x4;
                *((UInt40*)ptr + 5)  = (UInt40)value.x5;
                *((UInt40*)ptr + 6)  = (UInt40)value.x6;
                *((UInt40*)ptr + 7)  = (UInt40)value.x7;
                *((UInt40*)ptr + 8)  = (UInt40)value.x8;
                *((UInt40*)ptr + 9)  = (UInt40)value.x9;
                *((UInt40*)ptr + 10) = (UInt40)value.x10;
                *((UInt40*)ptr + 11) = (UInt40)value.x11;
                *((UInt40*)ptr + 12) = (UInt40)value.x12;
                *((UInt40*)ptr + 13) = (UInt40)value.x13;
                *((UInt40*)ptr + 14) = (UInt40)value.x14;
                *((UInt40*)ptr + 15) = (UInt40)value.x15;
                *((UInt40*)ptr + 16) = (UInt40)value.x16;
                *((UInt40*)ptr + 17) = (UInt40)value.x17;
                *((UInt40*)ptr + 18) = (UInt40)value.x18;
                *((UInt40*)ptr + 19) = (UInt40)value.x19;
                *((UInt40*)ptr + 20) = (UInt40)value.x20;
                *((UInt40*)ptr + 21) = (UInt40)value.x21;
                *((UInt40*)ptr + 22) = (UInt40)value.x22;
                *((UInt40*)ptr + 23) = (UInt40)value.x23;
                *((UInt40*)ptr + 24) = (UInt40)value.x24;
                *((UInt40*)ptr + 25) = (UInt40)value.x25;
                *((UInt40*)ptr + 26) = (UInt40)value.x26;
                *((UInt40*)ptr + 27) = (UInt40)value.x27;
                *((UInt40*)ptr + 28) = (UInt40)value.x28;
                *((UInt40*)ptr + 29) = (UInt40)value.x29;
                *((UInt40*)ptr + 30) = (UInt40)value.x30;
                *((UInt40*)ptr + 31) = (UInt40)value.x31;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u8_to48(void* ptr, byte32 value)
        {
            if (Avx2.IsAvx2Supported)
            {
                v256 shuf0 = Avx2.mm256_shuffle_epi8(value, new v256(0, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1,   2, -1, -1, -1,
                                                                     0, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1,   2, -1, -1, -1));
                v256 shuf1 = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1,   3, -1, -1, -1, -1, -1,   4, -1, -1, -1, -1, -1,   5, -1,
                                                                     -1, -1,   3, -1, -1, -1, -1, -1,   4, -1, -1, -1, -1, -1,   5, -1));
                v256 shuf2 = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1, -1, -1,   6, -1, -1, -1, -1, -1,   7, -1, -1, -1, -1, -1,
                                                                     -1, -1, -1, -1,   6, -1, -1, -1, -1, -1,   7, -1, -1, -1, -1, -1));
                v256 shuf3 = Avx2.mm256_shuffle_epi8(value, new v256(8, -1, -1, -1, -1, -1,   9, -1, -1, -1, -1, -1,   10, -1, -1, -1,
                                                                     8, -1, -1, -1, -1, -1,   9, -1, -1, -1, -1, -1,   10, -1, -1, -1));
                v256 shuf4 = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1,   11, -1, -1, -1, -1, -1,   12, -1, -1, -1, -1, -1,   13, -1,
                                                                     -1, -1,   11, -1, -1, -1, -1, -1,   12, -1, -1, -1, -1, -1,   13, -1));
                v256 shuf5 = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1, -1, -1,   14, -1, -1, -1, -1, -1,   15, -1, -1, -1, -1, -1,
                                                                     -1, -1, -1, -1,   14, -1, -1, -1, -1, -1,   15, -1, -1, -1, -1, -1));
                
                *((v128*)((byte*)ptr + 0))   = shuf0.Lo128;
                *((v128*)((byte*)ptr + 16))  = shuf1.Lo128;
                *((v128*)((byte*)ptr + 32))  = shuf2.Lo128;
                *((v128*)((byte*)ptr + 48))  = shuf3.Lo128;
                *((v128*)((byte*)ptr + 64))  = shuf4.Lo128;
                *((v128*)((byte*)ptr + 80))  = shuf5.Lo128;
                *((v128*)((byte*)ptr + 96))  = shuf0.Hi128;
                *((v128*)((byte*)ptr + 112)) = shuf1.Hi128;
                *((v128*)((byte*)ptr + 128)) = shuf2.Hi128;
                *((v128*)((byte*)ptr + 144)) = shuf3.Hi128;
                *((v128*)((byte*)ptr + 160)) = shuf4.Hi128;
                *((v128*)((byte*)ptr + 176)) = shuf5.Hi128;
            }
            else if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shufLo0 = shuffle_epi8(value.v16_0,  new v128(0, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1,   2, -1, -1, -1));
                v128 shufLo1 = shuffle_epi8(value.v16_0,  new v128(-1, -1,   3, -1, -1, -1, -1, -1,   4, -1, -1, -1, -1, -1,   5, -1));
                v128 shufLo2 = shuffle_epi8(value.v16_0,  new v128(-1, -1, -1, -1,   6, -1, -1, -1, -1, -1,   7, -1, -1, -1, -1, -1));
                v128 shufLo3 = shuffle_epi8(value.v16_0,  new v128(8, -1, -1, -1, -1, -1,   9, -1, -1, -1, -1, -1,   10, -1, -1, -1));
                v128 shufLo4 = shuffle_epi8(value.v16_0,  new v128(-1, -1,   11, -1, -1, -1, -1, -1,   12, -1, -1, -1, -1, -1,   13, -1));
                v128 shufLo5 = shuffle_epi8(value.v16_0,  new v128(-1, -1, -1, -1,   14, -1, -1, -1, -1, -1,   15, -1, -1, -1, -1, -1));
                v128 shufHi0 = shuffle_epi8(value.v16_16, new v128(0, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1,   2, -1, -1, -1));
                v128 shufHi1 = shuffle_epi8(value.v16_16, new v128(-1, -1,   3, -1, -1, -1, -1, -1,   4, -1, -1, -1, -1, -1,   5, -1));
                v128 shufHi2 = shuffle_epi8(value.v16_16, new v128(-1, -1, -1, -1,   6, -1, -1, -1, -1, -1,   7, -1, -1, -1, -1, -1));
                v128 shufHi3 = shuffle_epi8(value.v16_16, new v128(8, -1, -1, -1, -1, -1,   9, -1, -1, -1, -1, -1,   10, -1, -1, -1));
                v128 shufHi4 = shuffle_epi8(value.v16_16, new v128(-1, -1,   11, -1, -1, -1, -1, -1,   12, -1, -1, -1, -1, -1,   13, -1));
                v128 shufHi5 = shuffle_epi8(value.v16_16, new v128(-1, -1, -1, -1,   14, -1, -1, -1, -1, -1,   15, -1, -1, -1, -1, -1));
                
                *((v128*)((byte*)ptr + 0))   = shufLo0;
                *((v128*)((byte*)ptr + 16))  = shufLo1;
                *((v128*)((byte*)ptr + 32))  = shufLo2;
                *((v128*)((byte*)ptr + 48))  = shufLo3;
                *((v128*)((byte*)ptr + 64))  = shufLo4;
                *((v128*)((byte*)ptr + 80))  = shufLo5;
                *((v128*)((byte*)ptr + 96))  = shufHi0;
                *((v128*)((byte*)ptr + 112)) = shufHi1;
                *((v128*)((byte*)ptr + 128)) = shufHi2;
                *((v128*)((byte*)ptr + 144)) = shufHi3;
                *((v128*)((byte*)ptr + 160)) = shufHi4;
                *((v128*)((byte*)ptr + 176)) = shufHi5;
            }
            else
            {
                *((UInt48*)ptr + 0)  = (UInt48)value.x0;
                *((UInt48*)ptr + 1)  = (UInt48)value.x1;
                *((UInt48*)ptr + 2)  = (UInt48)value.x2;
                *((UInt48*)ptr + 3)  = (UInt48)value.x3;
                *((UInt48*)ptr + 4)  = (UInt48)value.x4;
                *((UInt48*)ptr + 5)  = (UInt48)value.x5;
                *((UInt48*)ptr + 6)  = (UInt48)value.x6;
                *((UInt48*)ptr + 7)  = (UInt48)value.x7;
                *((UInt48*)ptr + 8)  = (UInt48)value.x8;
                *((UInt48*)ptr + 9)  = (UInt48)value.x9;
                *((UInt48*)ptr + 10) = (UInt48)value.x10;
                *((UInt48*)ptr + 11) = (UInt48)value.x11;
                *((UInt48*)ptr + 12) = (UInt48)value.x12;
                *((UInt48*)ptr + 13) = (UInt48)value.x13;
                *((UInt48*)ptr + 14) = (UInt48)value.x14;
                *((UInt48*)ptr + 15) = (UInt48)value.x15;
                *((UInt48*)ptr + 16) = (UInt48)value.x16;
                *((UInt48*)ptr + 17) = (UInt48)value.x17;
                *((UInt48*)ptr + 18) = (UInt48)value.x18;
                *((UInt48*)ptr + 19) = (UInt48)value.x19;
                *((UInt48*)ptr + 20) = (UInt48)value.x20;
                *((UInt48*)ptr + 21) = (UInt48)value.x21;
                *((UInt48*)ptr + 22) = (UInt48)value.x22;
                *((UInt48*)ptr + 23) = (UInt48)value.x23;
                *((UInt48*)ptr + 24) = (UInt48)value.x24;
                *((UInt48*)ptr + 25) = (UInt48)value.x25;
                *((UInt48*)ptr + 26) = (UInt48)value.x26;
                *((UInt48*)ptr + 27) = (UInt48)value.x27;
                *((UInt48*)ptr + 28) = (UInt48)value.x28;
                *((UInt48*)ptr + 29) = (UInt48)value.x29;
                *((UInt48*)ptr + 30) = (UInt48)value.x30;
                *((UInt48*)ptr + 31) = (UInt48)value.x31;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u8_to56(void* ptr, byte32 value)
        {
            if (Avx2.IsAvx2Supported)
            {
                v256 shuf0 = Avx2.mm256_shuffle_epi8(value, new v256(0, -1, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1, -1,   2, -1,
                                                                     0, -1, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1, -1,   2, -1));
                v256 shuf1 = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1, -1, -1, -1,   3, -1, -1, -1, -1, -1, -1,   4, -1, -1, -1,
                                                                     -1, -1, -1, -1, -1,   3, -1, -1, -1, -1, -1, -1,   4, -1, -1, -1));
                v256 shuf2 = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1, -1,   5, -1, -1, -1, -1, -1, -1,   6, -1, -1, -1, -1, -1,
                                                                     -1, -1, -1,   5, -1, -1, -1, -1, -1, -1,   6, -1, -1, -1, -1, -1));
                v256 shuf3 = Avx2.mm256_shuffle_epi8(value, new v256(-1,   7, -1, -1, -1, -1, -1, -1,   8, -1, -1, -1, -1, -1, -1,   9,
                                                                     -1,   7, -1, -1, -1, -1, -1, -1,   8, -1, -1, -1, -1, -1, -1,   9));
                v256 shuf4 = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1, -1, -1, -1, -1,   10, -1, -1, -1, -1, -1, -1,   11, -1, -1,
                                                                     -1, -1, -1, -1, -1, -1,   10, -1, -1, -1, -1, -1, -1,   11, -1, -1));
                v256 shuf5 = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1, -1, -1,   12, -1, -1, -1, -1, -1, -1,   13, -1, -1, -1, -1,
                                                                     -1, -1, -1, -1,   12, -1, -1, -1, -1, -1, -1,   13, -1, -1, -1, -1));
                v256 shuf6 = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1,   14, -1, -1, -1, -1, -1, -1,   15, -1, -1, -1, -1, -1, -1,
                                                                     -1, -1,   14, -1, -1, -1, -1, -1, -1,   15, -1, -1, -1, -1, -1, -1));
                
                *((v128*)((byte*)ptr + 0))   = shuf0.Lo128;
                *((v128*)((byte*)ptr + 16))  = shuf1.Lo128;
                *((v128*)((byte*)ptr + 32))  = shuf2.Lo128;
                *((v128*)((byte*)ptr + 48))  = shuf3.Lo128;
                *((v128*)((byte*)ptr + 64))  = shuf4.Lo128;
                *((v128*)((byte*)ptr + 80))  = shuf5.Lo128;
                *((v128*)((byte*)ptr + 96))  = shuf6.Lo128;
                *((v128*)((byte*)ptr + 112)) = shuf0.Hi128;
                *((v128*)((byte*)ptr + 128)) = shuf1.Hi128;
                *((v128*)((byte*)ptr + 144)) = shuf2.Hi128;
                *((v128*)((byte*)ptr + 160)) = shuf3.Hi128;
                *((v128*)((byte*)ptr + 176)) = shuf4.Hi128;
                *((v128*)((byte*)ptr + 192)) = shuf5.Hi128;
                *((v128*)((byte*)ptr + 208)) = shuf6.Hi128;
            }
            else if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shufLo0 = shuffle_epi8(value.v16_0,  new v128(0, -1, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1, -1,   2, -1));
                v128 shufLo1 = shuffle_epi8(value.v16_0,  new v128(-1, -1, -1, -1, -1,   3, -1, -1, -1, -1, -1, -1,   4, -1, -1, -1));
                v128 shufLo2 = shuffle_epi8(value.v16_0,  new v128(-1, -1, -1,   5, -1, -1, -1, -1, -1, -1,   6, -1, -1, -1, -1, -1));
                v128 shufLo3 = shuffle_epi8(value.v16_0,  new v128(-1,   7, -1, -1, -1, -1, -1, -1,   8, -1, -1, -1, -1, -1, -1,   9));
                v128 shufLo4 = shuffle_epi8(value.v16_0,  new v128(-1, -1, -1, -1, -1, -1,   10, -1, -1, -1, -1, -1, -1,   11, -1, -1));
                v128 shufLo5 = shuffle_epi8(value.v16_0,  new v128(-1, -1, -1, -1,   12, -1, -1, -1, -1, -1, -1,   13, -1, -1, -1, -1));
                v128 shufLo6 = shuffle_epi8(value.v16_0,  new v128(-1, -1,   14, -1, -1, -1, -1, -1, -1,   15, -1, -1, -1, -1, -1, -1));
                v128 shufHi0 = shuffle_epi8(value.v16_16, new v128(0, -1, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1, -1,   2, -1));
                v128 shufHi1 = shuffle_epi8(value.v16_16, new v128(-1, -1, -1, -1, -1,   3, -1, -1, -1, -1, -1, -1,   4, -1, -1, -1));
                v128 shufHi2 = shuffle_epi8(value.v16_16, new v128(-1, -1, -1,   5, -1, -1, -1, -1, -1, -1,   6, -1, -1, -1, -1, -1));
                v128 shufHi3 = shuffle_epi8(value.v16_16, new v128(-1,   7, -1, -1, -1, -1, -1, -1,   8, -1, -1, -1, -1, -1, -1,   9));
                v128 shufHi4 = shuffle_epi8(value.v16_16, new v128(-1, -1, -1, -1, -1, -1,   10, -1, -1, -1, -1, -1, -1,   11, -1, -1));
                v128 shufHi5 = shuffle_epi8(value.v16_16, new v128(-1, -1, -1, -1,   12, -1, -1, -1, -1, -1, -1,   13, -1, -1, -1, -1));
                v128 shufHi6 = shuffle_epi8(value.v16_16, new v128(-1, -1,   14, -1, -1, -1, -1, -1, -1,   15, -1, -1, -1, -1, -1, -1));
                
                *((v128*)((byte*)ptr + 0))   = shufLo0;
                *((v128*)((byte*)ptr + 16))  = shufLo1;
                *((v128*)((byte*)ptr + 32))  = shufLo2;
                *((v128*)((byte*)ptr + 48))  = shufLo3;
                *((v128*)((byte*)ptr + 64))  = shufLo4;
                *((v128*)((byte*)ptr + 80))  = shufLo5;
                *((v128*)((byte*)ptr + 96))  = shufLo6;
                *((v128*)((byte*)ptr + 112)) = shufHi0;
                *((v128*)((byte*)ptr + 128)) = shufHi1;
                *((v128*)((byte*)ptr + 144)) = shufHi2;
                *((v128*)((byte*)ptr + 160)) = shufHi3;
                *((v128*)((byte*)ptr + 176)) = shufHi4;
                *((v128*)((byte*)ptr + 192)) = shufHi5;
                *((v128*)((byte*)ptr + 208)) = shufHi6;
            }
            else
            {
                *((UInt56*)ptr + 0)  = (UInt56)value.x0;
                *((UInt56*)ptr + 1)  = (UInt56)value.x1;
                *((UInt56*)ptr + 2)  = (UInt56)value.x2;
                *((UInt56*)ptr + 3)  = (UInt56)value.x3;
                *((UInt56*)ptr + 4)  = (UInt56)value.x4;
                *((UInt56*)ptr + 5)  = (UInt56)value.x5;
                *((UInt56*)ptr + 6)  = (UInt56)value.x6;
                *((UInt56*)ptr + 7)  = (UInt56)value.x7;
                *((UInt56*)ptr + 8)  = (UInt56)value.x8;
                *((UInt56*)ptr + 9)  = (UInt56)value.x9;
                *((UInt56*)ptr + 10) = (UInt56)value.x10;
                *((UInt56*)ptr + 11) = (UInt56)value.x11;
                *((UInt56*)ptr + 12) = (UInt56)value.x12;
                *((UInt56*)ptr + 13) = (UInt56)value.x13;
                *((UInt56*)ptr + 14) = (UInt56)value.x14;
                *((UInt56*)ptr + 15) = (UInt56)value.x15;
                *((UInt56*)ptr + 16) = (UInt56)value.x16;
                *((UInt56*)ptr + 17) = (UInt56)value.x17;
                *((UInt56*)ptr + 18) = (UInt56)value.x18;
                *((UInt56*)ptr + 19) = (UInt56)value.x19;
                *((UInt56*)ptr + 20) = (UInt56)value.x20;
                *((UInt56*)ptr + 21) = (UInt56)value.x21;
                *((UInt56*)ptr + 22) = (UInt56)value.x22;
                *((UInt56*)ptr + 23) = (UInt56)value.x23;
                *((UInt56*)ptr + 24) = (UInt56)value.x24;
                *((UInt56*)ptr + 25) = (UInt56)value.x25;
                *((UInt56*)ptr + 26) = (UInt56)value.x26;
                *((UInt56*)ptr + 27) = (UInt56)value.x27;
                *((UInt56*)ptr + 28) = (UInt56)value.x28;
                *((UInt56*)ptr + 29) = (UInt56)value.x29;
                *((UInt56*)ptr + 30) = (UInt56)value.x30;
                *((UInt56*)ptr + 31) = (UInt56)value.x31;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u8_to24(void* ptr, byte16 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf0 = shuffle_epi8(value, new v128(0, -1, -1,   1, -1, -1,   2, -1, -1,   3, -1, -1,   4, -1, -1,   5));
                v128 shuf1 = shuffle_epi8(value, new v128(-1, -1,   6, -1, -1,   7, -1, -1,   8, -1, -1,   9, -1, -1,   10, -1));
                v128 shuf2 = shuffle_epi8(value, new v128(-1,   11, -1, -1,   12, -1, -1,   13, -1, -1,   14, -1, -1,   15, -1, -1));

                *((v128*)((byte*)ptr + 0))  = shuf0;
                *((v128*)((byte*)ptr + 16)) = shuf1;
                *((v128*)((byte*)ptr + 32)) = shuf2;
            }
            else
            {
                *((UInt24*)ptr + 0)  = (UInt24)value.x0;
                *((UInt24*)ptr + 1)  = (UInt24)value.x1;
                *((UInt24*)ptr + 2)  = (UInt24)value.x2;
                *((UInt24*)ptr + 3)  = (UInt24)value.x3;
                *((UInt24*)ptr + 4)  = (UInt24)value.x4;
                *((UInt24*)ptr + 5)  = (UInt24)value.x5;
                *((UInt24*)ptr + 6)  = (UInt24)value.x6;
                *((UInt24*)ptr + 7)  = (UInt24)value.x7;
                *((UInt24*)ptr + 8)  = (UInt24)value.x8;
                *((UInt24*)ptr + 9)  = (UInt24)value.x9;
                *((UInt24*)ptr + 10) = (UInt24)value.x10;
                *((UInt24*)ptr + 11) = (UInt24)value.x11;
                *((UInt24*)ptr + 12) = (UInt24)value.x12;
                *((UInt24*)ptr + 13) = (UInt24)value.x13;
                *((UInt24*)ptr + 14) = (UInt24)value.x14;
                *((UInt24*)ptr + 15) = (UInt24)value.x15;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u8_to40(void* ptr, byte16 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf0 = shuffle_epi8(value, new v128(0, -1, -1, -1, -1,   1, -1, -1, -1, -1,   2, -1, -1, -1, -1,   3));
                v128 shuf1 = shuffle_epi8(value, new v128(-1, -1, -1, -1,   4, -1, -1, -1, -1,   5, -1, -1, -1, -1,   6, -1));
                v128 shuf2 = shuffle_epi8(value, new v128(-1, -1, -1,   7, -1, -1, -1, -1,   8, -1, -1, -1, -1,   9, -1, -1));
                v128 shuf3 = shuffle_epi8(value, new v128(-1, -1,   10, -1, -1, -1, -1,   11, -1, -1, -1, -1,   12, -1, -1, -1));
                v128 shuf4 = shuffle_epi8(value, new v128(-1,   13, -1, -1, -1, -1,   14, -1, -1, -1, -1,   15, -1, -1, -1, -1));
                
                *((v128*)((byte*)ptr + 0))  = shuf0;
                *((v128*)((byte*)ptr + 16)) = shuf1;
                *((v128*)((byte*)ptr + 32)) = shuf2;
                *((v128*)((byte*)ptr + 48)) = shuf3;
                *((v128*)((byte*)ptr + 64)) = shuf4;
            }
            else
            {
                *((UInt40*)ptr + 0)  = (UInt40)value.x0;
                *((UInt40*)ptr + 1)  = (UInt40)value.x1;
                *((UInt40*)ptr + 2)  = (UInt40)value.x2;
                *((UInt40*)ptr + 3)  = (UInt40)value.x3;
                *((UInt40*)ptr + 4)  = (UInt40)value.x4;
                *((UInt40*)ptr + 5)  = (UInt40)value.x5;
                *((UInt40*)ptr + 6)  = (UInt40)value.x6;
                *((UInt40*)ptr + 7)  = (UInt40)value.x7;
                *((UInt40*)ptr + 8)  = (UInt40)value.x8;
                *((UInt40*)ptr + 9)  = (UInt40)value.x9;
                *((UInt40*)ptr + 10) = (UInt40)value.x10;
                *((UInt40*)ptr + 11) = (UInt40)value.x11;
                *((UInt40*)ptr + 12) = (UInt40)value.x12;
                *((UInt40*)ptr + 13) = (UInt40)value.x13;
                *((UInt40*)ptr + 14) = (UInt40)value.x14;
                *((UInt40*)ptr + 15) = (UInt40)value.x15;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u8_to48(void* ptr, byte16 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf0 = shuffle_epi8(value, new v128(0, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1,   2, -1, -1, -1));
                v128 shuf1 = shuffle_epi8(value, new v128(-1, -1,   3, -1, -1, -1, -1, -1,   4, -1, -1, -1, -1, -1,   5, -1));
                v128 shuf2 = shuffle_epi8(value, new v128(-1, -1, -1, -1,   6, -1, -1, -1, -1, -1,   7, -1, -1, -1, -1, -1));
                v128 shuf3 = shuffle_epi8(value, new v128(8, -1, -1, -1, -1, -1,   9, -1, -1, -1, -1, -1,   10, -1, -1, -1));
                v128 shuf4 = shuffle_epi8(value, new v128(-1, -1,   11, -1, -1, -1, -1, -1,   12, -1, -1, -1, -1, -1,   13, -1));
                v128 shuf5 = shuffle_epi8(value, new v128(-1, -1, -1, -1,   14, -1, -1, -1, -1, -1,   15, -1, -1, -1, -1, -1));
                
                *((v128*)((byte*)ptr + 0))  = shuf0;
                *((v128*)((byte*)ptr + 16)) = shuf1;
                *((v128*)((byte*)ptr + 32)) = shuf2;
                *((v128*)((byte*)ptr + 48)) = shuf3;
                *((v128*)((byte*)ptr + 64)) = shuf4;
                *((v128*)((byte*)ptr + 80)) = shuf5;
            }
            else
            {
                *((UInt48*)ptr + 0)  = (UInt48)value.x0;
                *((UInt48*)ptr + 1)  = (UInt48)value.x1;
                *((UInt48*)ptr + 2)  = (UInt48)value.x2;
                *((UInt48*)ptr + 3)  = (UInt48)value.x3;
                *((UInt48*)ptr + 4)  = (UInt48)value.x4;
                *((UInt48*)ptr + 5)  = (UInt48)value.x5;
                *((UInt48*)ptr + 6)  = (UInt48)value.x6;
                *((UInt48*)ptr + 7)  = (UInt48)value.x7;
                *((UInt48*)ptr + 8)  = (UInt48)value.x8;
                *((UInt48*)ptr + 9)  = (UInt48)value.x9;
                *((UInt48*)ptr + 10) = (UInt48)value.x10;
                *((UInt48*)ptr + 11) = (UInt48)value.x11;
                *((UInt48*)ptr + 12) = (UInt48)value.x12;
                *((UInt48*)ptr + 13) = (UInt48)value.x13;
                *((UInt48*)ptr + 14) = (UInt48)value.x14;
                *((UInt48*)ptr + 15) = (UInt48)value.x15;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u8_to56(void* ptr, byte16 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf0 = shuffle_epi8(value, new v128(0, -1, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1, -1,   2, -1));
                v128 shuf1 = shuffle_epi8(value, new v128(-1, -1, -1, -1, -1,   3, -1, -1, -1, -1, -1, -1,   4, -1, -1, -1));
                v128 shuf2 = shuffle_epi8(value, new v128(-1, -1, -1,   5, -1, -1, -1, -1, -1, -1,   6, -1, -1, -1, -1, -1));
                v128 shuf3 = shuffle_epi8(value, new v128(-1,   7, -1, -1, -1, -1, -1, -1,   8, -1, -1, -1, -1, -1, -1,   9));
                v128 shuf4 = shuffle_epi8(value, new v128(-1, -1, -1, -1, -1, -1,   10, -1, -1, -1, -1, -1, -1,   11, -1, -1));
                v128 shuf5 = shuffle_epi8(value, new v128(-1, -1, -1, -1,   12, -1, -1, -1, -1, -1, -1,   13, -1, -1, -1, -1));
                v128 shuf6 = shuffle_epi8(value, new v128(-1, -1,   14, -1, -1, -1, -1, -1, -1,   15, -1, -1, -1, -1, -1, -1));
                
                *((v128*)((byte*)ptr + 0))  = shuf0;
                *((v128*)((byte*)ptr + 16)) = shuf1;
                *((v128*)((byte*)ptr + 32)) = shuf2;
                *((v128*)((byte*)ptr + 48)) = shuf3;
                *((v128*)((byte*)ptr + 64)) = shuf4;
                *((v128*)((byte*)ptr + 80)) = shuf5;
                *((v128*)((byte*)ptr + 96)) = shuf6;
            }
            else
            {
                *((UInt56*)ptr + 0)  = (UInt56)value.x0;
                *((UInt56*)ptr + 1)  = (UInt56)value.x1;
                *((UInt56*)ptr + 2)  = (UInt56)value.x2;
                *((UInt56*)ptr + 3)  = (UInt56)value.x3;
                *((UInt56*)ptr + 4)  = (UInt56)value.x4;
                *((UInt56*)ptr + 5)  = (UInt56)value.x5;
                *((UInt56*)ptr + 6)  = (UInt56)value.x6;
                *((UInt56*)ptr + 7)  = (UInt56)value.x7;
                *((UInt56*)ptr + 8)  = (UInt56)value.x8;
                *((UInt56*)ptr + 9)  = (UInt56)value.x9;
                *((UInt56*)ptr + 10) = (UInt56)value.x10;
                *((UInt56*)ptr + 11) = (UInt56)value.x11;
                *((UInt56*)ptr + 12) = (UInt56)value.x12;
                *((UInt56*)ptr + 13) = (UInt56)value.x13;
                *((UInt56*)ptr + 14) = (UInt56)value.x14;
                *((UInt56*)ptr + 15) = (UInt56)value.x15;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u8_to24(void* ptr, byte8 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf0 = shuffle_epi8(value, new v128(0, -1, -1,   1, -1, -1,   2, -1, -1,   3, -1, -1,   4, -1, -1,   5));
                v128 shuf1 = shuffle_epi8(value, new v128(-1, -1,   6, -1, -1,   7, -1, -1,   8, -1, -1,   9, -1, -1,   10, -1));
                
                *((v128*)((byte*)ptr + 0))  = shuf0;
                *((long*)((byte*)ptr + 16)) = shuf1.SLong0;
            }
            else
            {
                *((UInt24*)ptr + 0)  = (UInt24)value.x0;
                *((UInt24*)ptr + 1)  = (UInt24)value.x1;
                *((UInt24*)ptr + 2)  = (UInt24)value.x2;
                *((UInt24*)ptr + 3)  = (UInt24)value.x3;
                *((UInt24*)ptr + 4)  = (UInt24)value.x4;
                *((UInt24*)ptr + 5)  = (UInt24)value.x5;
                *((UInt24*)ptr + 6)  = (UInt24)value.x6;
                *((UInt24*)ptr + 7)  = (UInt24)value.x7;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u8_to40(void* ptr, byte8 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf0 = shuffle_epi8(value, new v128(0, -1, -1, -1, -1,   1, -1, -1, -1, -1,   2, -1, -1, -1, -1,   3));
                v128 shuf1 = shuffle_epi8(value, new v128(-1, -1, -1, -1,   4, -1, -1, -1, -1,   5, -1, -1, -1, -1,   6, -1));
                v128 shuf2 = shuffle_epi8(value, new v128(-1, -1, -1,   7, -1, -1, -1, -1,   8, -1, -1, -1, -1,   9, -1, -1));
                

                *((v128*)((byte*)ptr + 0))  = shuf0;
                *((v128*)((byte*)ptr + 16)) = shuf1;
                *((long*)((byte*)ptr + 32)) = shuf2.SLong0;
            }
            else
            {
                *((UInt40*)ptr + 0)  = (UInt40)value.x0;
                *((UInt40*)ptr + 1)  = (UInt40)value.x1;
                *((UInt40*)ptr + 2)  = (UInt40)value.x2;
                *((UInt40*)ptr + 3)  = (UInt40)value.x3;
                *((UInt40*)ptr + 4)  = (UInt40)value.x4;
                *((UInt40*)ptr + 5)  = (UInt40)value.x5;
                *((UInt40*)ptr + 6)  = (UInt40)value.x6;
                *((UInt40*)ptr + 7)  = (UInt40)value.x7;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u8_to48(void* ptr, byte8 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf0 = shuffle_epi8(value, new v128(0, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1,   2, -1, -1, -1));
                v128 shuf1 = shuffle_epi8(value, new v128(-1, -1,   3, -1, -1, -1, -1, -1,   4, -1, -1, -1, -1, -1,   5, -1));
                v128 shuf2 = shuffle_epi8(value, new v128(-1, -1, -1, -1,   6, -1, -1, -1, -1, -1,   7, -1, -1, -1, -1, -1));
                

                *((v128*)((byte*)ptr + 0))  = shuf0;
                *((v128*)((byte*)ptr + 16)) = shuf1;
                *((v128*)((byte*)ptr + 32)) = shuf2;
            }
            else
            {
                *((UInt48*)ptr + 0)  = (UInt48)value.x0;
                *((UInt48*)ptr + 1)  = (UInt48)value.x1;
                *((UInt48*)ptr + 2)  = (UInt48)value.x2;
                *((UInt48*)ptr + 3)  = (UInt48)value.x3;
                *((UInt48*)ptr + 4)  = (UInt48)value.x4;
                *((UInt48*)ptr + 5)  = (UInt48)value.x5;
                *((UInt48*)ptr + 6)  = (UInt48)value.x6;
                *((UInt48*)ptr + 7)  = (UInt48)value.x7;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u8_to56(void* ptr, byte8 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf0 = shuffle_epi8(value, new v128(0, -1, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1, -1,   2, -1));
                v128 shuf1 = shuffle_epi8(value, new v128(-1, -1, -1, -1, -1,   3, -1, -1, -1, -1, -1, -1,   4, -1, -1, -1));
                v128 shuf2 = shuffle_epi8(value, new v128(-1, -1, -1,   5, -1, -1, -1, -1, -1, -1,   6, -1, -1, -1, -1, -1));
                v128 shuf3 = shuffle_epi8(value, new v128(-1,   7, -1, -1, -1, -1, -1, -1,   8, -1, -1, -1, -1, -1, -1,   9));
                
                *((v128*)((byte*)ptr + 0))  = shuf0;
                *((v128*)((byte*)ptr + 16)) = shuf1;
                *((v128*)((byte*)ptr + 32)) = shuf2;
                *((long*)((byte*)ptr + 48)) = shuf3.SLong0;
            }
            else
            {
                *((UInt56*)ptr + 0)  = (UInt56)value.x0;
                *((UInt56*)ptr + 1)  = (UInt56)value.x1;
                *((UInt56*)ptr + 2)  = (UInt56)value.x2;
                *((UInt56*)ptr + 3)  = (UInt56)value.x3;
                *((UInt56*)ptr + 4)  = (UInt56)value.x4;
                *((UInt56*)ptr + 5)  = (UInt56)value.x5;
                *((UInt56*)ptr + 6)  = (UInt56)value.x6;
                *((UInt56*)ptr + 7)  = (UInt56)value.x7;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u8_to24(void* ptr, byte4 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf = shuffle_epi8(value, new v128(0, -1, -1,   1, -1, -1,   2, -1, -1,   3, -1, -1,   4, -1, -1,   5));
                
                *((long*)((byte*)ptr + 0)) = shuf.SLong0;
                *((int*) ((byte*)ptr + 8)) = shuf.SInt2;
            }
            else
            {
                *((UInt24*)ptr + 0)  = (UInt24)value.x;
                *((UInt24*)ptr + 1)  = (UInt24)value.y;
                *((UInt24*)ptr + 2)  = (UInt24)value.z;
                *((UInt24*)ptr + 3)  = (UInt24)value.w;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u8_to40(void* ptr, byte4 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf = shuffle_epi8(value, new v128(0, -1, -1, -1, -1,   1, -1, -1, -1, -1,   2, -1, -1, -1, -1,   3));
                
                *((v128*)((byte*)ptr + 0))  = shuf;
                *((int*) ((byte*)ptr + 16)) = 0;
            }
            else
            {
                *((UInt40*)ptr + 0)  = (UInt40)value.x;
                *((UInt40*)ptr + 1)  = (UInt40)value.y;
                *((UInt40*)ptr + 2)  = (UInt40)value.z;
                *((UInt40*)ptr + 3)  = (UInt40)value.w;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u8_to48(void* ptr, byte4 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf0 = shuffle_epi8(value, new v128(0, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1,   2, -1, -1, -1));
                v128 shuf1 = shuffle_epi8(value, new v128(-1, -1,   3, -1, -1, -1, -1, -1,   4, -1, -1, -1, -1, -1,   5, -1));
                
                *((v128*)((byte*)ptr + 0))  = shuf0;
                *((long*)((byte*)ptr + 16)) = shuf1.SLong0;
            }
            else
            {
                *((UInt48*)ptr + 0)  = (UInt48)value.x;
                *((UInt48*)ptr + 1)  = (UInt48)value.y;
                *((UInt48*)ptr + 2)  = (UInt48)value.z;
                *((UInt48*)ptr + 3)  = (UInt48)value.w;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u8_to56(void* ptr, byte4 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf0 = shuffle_epi8(value, new v128(0, -1, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1, -1,   2, -1));
                v128 shuf1 = shuffle_epi8(value, new v128(-1, -1, -1, -1, -1,   3, -1, -1, -1, -1, -1, -1,   4, -1, -1, -1));
                
                *((v128*)((byte*)ptr + 0))  = shuf0;
                *((long*)((byte*)ptr + 16)) = shuf1.SLong0;
                *((int*) ((byte*)ptr + 24)) = 0;
            }
            else
            {
                *((UInt56*)ptr + 0)  = (UInt56)value.x;
                *((UInt56*)ptr + 1)  = (UInt56)value.y;
                *((UInt56*)ptr + 2)  = (UInt56)value.z;
                *((UInt56*)ptr + 3)  = (UInt56)value.w;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u8_to24(void* ptr, byte3 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf = shuffle_epi8(value, new v128(0, -1, -1,   1, -1, -1,   2, -1, -1,   3, -1, -1,   4, -1, -1,   5));
                
                *((long*) ((byte*)ptr + 0)) = shuf.SLong0;
                *((sbyte*)((byte*)ptr + 8)) = 0;
            }
            else
            {
                *((UInt24*)ptr + 0)  = (UInt24)value.x;
                *((UInt24*)ptr + 1)  = (UInt24)value.y;
                *((UInt24*)ptr + 2)  = (UInt24)value.z;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u8_to40(void* ptr, byte3 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf = shuffle_epi8(value, new v128(0, -1, -1, -1, -1,   1, -1, -1, -1, -1,   2, -1, -1, -1, -1,   3));
                
                *((long*) ((byte*)ptr + 0))  = shuf.SLong0;
                *((int*)  ((byte*)ptr + 8))  = shuf.SInt2;
                *((short*)((byte*)ptr + 12)) = 0;
                *((sbyte*)((byte*)ptr + 14)) = 0;
            }
            else
            {
                *((UInt40*)ptr + 0)  = (UInt40)value.x;
                *((UInt40*)ptr + 1)  = (UInt40)value.y;
                *((UInt40*)ptr + 2)  = (UInt40)value.z;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u8_to48(void* ptr, byte3 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf0 = shuffle_epi8(value, new v128(0, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1,   2, -1, -1, -1));
                
                *((v128*) ((byte*)ptr + 0))  = shuf0;
                *((short*)((byte*)ptr + 16)) = 0;
            }
            else
            {
                *((UInt48*)ptr + 0)  = (UInt48)value.x;
                *((UInt48*)ptr + 1)  = (UInt48)value.y;
                *((UInt48*)ptr + 2)  = (UInt48)value.z;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u8_to56(void* ptr, byte3 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf0 = shuffle_epi8(value, new v128(0, -1, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1, -1,   2, -1));
                
                *((v128*) ((byte*)ptr + 0))  = shuf0;
                *((int*)  ((byte*)ptr + 16)) = 0;
                *((sbyte*)((byte*)ptr + 20)) = 0;
            }
            else
            {
                *((UInt56*)ptr + 0)  = (UInt56)value.x;
                *((UInt56*)ptr + 1)  = (UInt56)value.y;
                *((UInt56*)ptr + 2)  = (UInt56)value.z;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u8_to24(void* ptr, byte2 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf = shuffle_epi8(value, new v128(0, -1, -1,   1, -1, -1,   2, -1, -1,   3, -1, -1,   4, -1, -1,   5));
                
                *((int*)  ((byte*)ptr + 0)) = shuf.SInt0;
                *((short*)((byte*)ptr + 4)) = shuf.SShort2;
            }
            else
            {
                *((UInt24*)ptr + 0)  = (UInt24)value.x;
                *((UInt24*)ptr + 1)  = (UInt24)value.y;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u8_to40(void* ptr, byte2 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf = shuffle_epi8(value, new v128(0, -1, -1, -1, -1,   1, -1, -1, -1, -1,   2, -1, -1, -1, -1,   3));
                
                *((long*) ((byte*)ptr + 0)) = shuf.SLong0;
                *((short*)((byte*)ptr + 8)) = 0;
            }
            else
            {
                *((UInt40*)ptr + 0)  = (UInt40)value.x;
                *((UInt40*)ptr + 1)  = (UInt40)value.y;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u8_to48(void* ptr, byte2 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf0 = shuffle_epi8(value, new v128(0, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1,   2, -1, -1, -1));
                
                *((long*)((byte*)ptr + 0)) = shuf0.SLong0;
                *((int*) ((byte*)ptr + 8)) = 0;
            }
            else
            {
                *((UInt48*)ptr + 0)  = (UInt48)value.x;
                *((UInt48*)ptr + 1)  = (UInt48)value.y;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_u8_to56(void* ptr, byte2 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 shuf0 = shuffle_epi8(value, new v128(0, -1, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1, -1,   2, -1));
                
                *((long*) ((byte*)ptr + 0))  = shuf0.SLong0;
                *((int*)  ((byte*)ptr + 8))  = shuf0.SInt2;
                *((short*)((byte*)ptr + 12)) = 0;
            }
            else
            {
                *((UInt56*)ptr + 0)  = (UInt56)value.x;
                *((UInt56*)ptr + 1)  = (UInt56)value.y;
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i8_to24(void* ptr, sbyte32 value)
        {
            if (Avx2.IsAvx2Supported)
            {
                v256 sign = mm256_srai_epi8(value, 7);
                v256 sign0 = Avx2.mm256_shuffle_epi8(sign, new v256(0, 0, 0,   1, 1, 1,   2, 2, 2,   3, 3, 3,   4, 4, 4,   5,
                                                                    0, 0, 0,   1, 1, 1,   2, 2, 2,   3, 3, 3,   4, 4, 4,   5));
                v256 sign1 = Avx2.mm256_shuffle_epi8(sign, new v256(5, 5,   6, 6, 6,   7, 7, 7,   8, 8, 8,   9, 9, 9,   10, 10,
                                                                    5, 5,   6, 6, 6,   7, 7, 7,   8, 8, 8,   9, 9, 9,   10, 10));
                v256 sign2 = Avx2.mm256_shuffle_epi8(sign, new v256(10,   11, 11, 11,   12, 12, 12,   13, 13, 13,   14, 14, 14,   15, 15, 15,
                                                                    10,   11, 11, 11,   12, 12, 12,   13, 13, 13,   14, 14, 14,   15, 15, 15));

                v256 shuf0 = Avx2.mm256_shuffle_epi8(value, new v256(0, -1, -1,   1, -1, -1,   2, -1, -1,   3, -1, -1,   4, -1, -1,   5,
                                                                     0, -1, -1,   1, -1, -1,   2, -1, -1,   3, -1, -1,   4, -1, -1,   5));
                v256 shuf1 = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1,   6, -1, -1,   7, -1, -1,   8, -1, -1,   9, -1, -1,   10, -1,
                                                                     -1, -1,   6, -1, -1,   7, -1, -1,   8, -1, -1,   9, -1, -1,   10, -1));
                v256 shuf2 = Avx2.mm256_shuffle_epi8(value, new v256(-1,   11, -1, -1,   12, -1, -1,   13, -1, -1,   14, -1, -1,   15, -1, -1,
                                                                     -1,   11, -1, -1,   12, -1, -1,   13, -1, -1,   14, -1, -1,   15, -1, -1));

                shuf0 = Avx2.mm256_blendv_epi8(shuf0, sign0, new v256(0, -1, -1,   1, -1, -1,   2, -1, -1,   3, -1, -1,   4, -1, -1,   5,
                                                                      0, -1, -1,   1, -1, -1,   2, -1, -1,   3, -1, -1,   4, -1, -1,   5));
                shuf1 = Avx2.mm256_blendv_epi8(shuf1, sign1, new v256(-1, -1,   6, -1, -1,   7, -1, -1,   8, -1, -1,   9, -1, -1,   10, -1,
                                                                      -1, -1,   6, -1, -1,   7, -1, -1,   8, -1, -1,   9, -1, -1,   10, -1));
                shuf2 = Avx2.mm256_blendv_epi8(shuf2, sign2, new v256(-1,   11, -1, -1,   12, -1, -1,   13, -1, -1,   14, -1, -1,   15, -1, -1,
                                                                      -1,   11, -1, -1,   12, -1, -1,   13, -1, -1,   14, -1, -1,   15, -1, -1));

                *((v128*)((sbyte*)ptr + 0))  = shuf0.Lo128;
                *((v128*)((sbyte*)ptr + 16)) = shuf1.Lo128;
                *((v128*)((sbyte*)ptr + 32)) = shuf2.Lo128;
                *((v128*)((sbyte*)ptr + 48)) = shuf0.Hi128;
                *((v128*)((sbyte*)ptr + 64)) = shuf1.Hi128;
                *((v128*)((sbyte*)ptr + 80)) = shuf2.Hi128;
            }
            else if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 signLo = srai_epi8(value.v16_0,  7);
                v128 signHi = srai_epi8(value.v16_16, 7);
                v128 signLo0 = shuffle_epi8(signLo, new v128(0, 0, 0,   1, 1, 1,   2, 2, 2,   3, 3, 3,   4, 4, 4,   5));
                v128 signLo1 = shuffle_epi8(signLo, new v128(5, 5,   6, 6, 6,   7, 7, 7,   8, 8, 8,   9, 9, 9,   10, 10));
                v128 signLo2 = shuffle_epi8(signLo, new v128(10,   11, 11, 11,   12, 12, 12,   13, 13, 13,   14, 14, 14,   15, 15, 15));
                v128 signHi0 = shuffle_epi8(signHi, new v128(0, 0, 0,   1, 1, 1,   2, 2, 2,   3, 3, 3,   4, 4, 4,   5));
                v128 signHi1 = shuffle_epi8(signHi, new v128(5, 5,   6, 6, 6,   7, 7, 7,   8, 8, 8,   9, 9, 9,   10, 10));
                v128 signHi2 = shuffle_epi8(signHi, new v128(10,   11, 11, 11,   12, 12, 12,   13, 13, 13,   14, 14, 14,   15, 15, 15));

                v128 shufLo0 = shuffle_epi8(value.v16_0,  new v128(0, -1, -1,   1, -1, -1,   2, -1, -1,   3, -1, -1,   4, -1, -1,   5));
                v128 shufLo1 = shuffle_epi8(value.v16_0,  new v128(-1, -1,   6, -1, -1,   7, -1, -1,   8, -1, -1,   9, -1, -1,   10, -1));
                v128 shufLo2 = shuffle_epi8(value.v16_0,  new v128(-1,   11, -1, -1,   12, -1, -1,   13, -1, -1,   14, -1, -1,   15, -1, -1));
                v128 shufHi0 = shuffle_epi8(value.v16_16, new v128(0, -1, -1,   1, -1, -1,   2, -1, -1,   3, -1, -1,   4, -1, -1,   5));
                v128 shufHi1 = shuffle_epi8(value.v16_16, new v128(-1, -1,   6, -1, -1,   7, -1, -1,   8, -1, -1,   9, -1, -1,   10, -1));
                v128 shufHi2 = shuffle_epi8(value.v16_16, new v128(-1,   11, -1, -1,   12, -1, -1,   13, -1, -1,   14, -1, -1,   15, -1, -1));

                shufLo0 = blendv_epi8(shufLo0, signLo0, new v128(0, -1, -1,   1, -1, -1,   2, -1, -1,   3, -1, -1,   4, -1, -1,   5));
                shufLo1 = blendv_epi8(shufLo1, signLo1, new v128(-1, -1,   6, -1, -1,   7, -1, -1,   8, -1, -1,   9, -1, -1,   10, -1));
                shufLo2 = blendv_epi8(shufLo2, signLo2, new v128(-1,   11, -1, -1,   12, -1, -1,   13, -1, -1,   14, -1, -1,   15, -1, -1));
                shufHi0 = blendv_epi8(shufHi0, signHi0, new v128(0, -1, -1,   1, -1, -1,   2, -1, -1,   3, -1, -1,   4, -1, -1,   5));
                shufHi1 = blendv_epi8(shufHi1, signHi1, new v128(-1, -1,   6, -1, -1,   7, -1, -1,   8, -1, -1,   9, -1, -1,   10, -1));
                shufHi2 = blendv_epi8(shufHi2, signHi2, new v128(-1,   11, -1, -1,   12, -1, -1,   13, -1, -1,   14, -1, -1,   15, -1, -1));

                *((v128*)((sbyte*)ptr + 0))  = shufLo0;
                *((v128*)((sbyte*)ptr + 16)) = shufLo1;
                *((v128*)((sbyte*)ptr + 32)) = shufLo2;
                *((v128*)((sbyte*)ptr + 48)) = shufHi0;
                *((v128*)((sbyte*)ptr + 64)) = shufHi1;
                *((v128*)((sbyte*)ptr + 80)) = shufHi2;
            }
            else
            {
                *((UInt24*)ptr + 0)  = (UInt24)value.x0;
                *((UInt24*)ptr + 1)  = (UInt24)value.x1;
                *((UInt24*)ptr + 2)  = (UInt24)value.x2;
                *((UInt24*)ptr + 3)  = (UInt24)value.x3;
                *((UInt24*)ptr + 4)  = (UInt24)value.x4;
                *((UInt24*)ptr + 5)  = (UInt24)value.x5;
                *((UInt24*)ptr + 6)  = (UInt24)value.x6;
                *((UInt24*)ptr + 7)  = (UInt24)value.x7;
                *((UInt24*)ptr + 8)  = (UInt24)value.x8;
                *((UInt24*)ptr + 9)  = (UInt24)value.x9;
                *((UInt24*)ptr + 10) = (UInt24)value.x10;
                *((UInt24*)ptr + 11) = (UInt24)value.x11;
                *((UInt24*)ptr + 12) = (UInt24)value.x12;
                *((UInt24*)ptr + 13) = (UInt24)value.x13;
                *((UInt24*)ptr + 14) = (UInt24)value.x14;
                *((UInt24*)ptr + 15) = (UInt24)value.x15;
                *((UInt24*)ptr + 16) = (UInt24)value.x16;
                *((UInt24*)ptr + 17) = (UInt24)value.x17;
                *((UInt24*)ptr + 18) = (UInt24)value.x18;
                *((UInt24*)ptr + 19) = (UInt24)value.x19;
                *((UInt24*)ptr + 20) = (UInt24)value.x20;
                *((UInt24*)ptr + 21) = (UInt24)value.x21;
                *((UInt24*)ptr + 22) = (UInt24)value.x22;
                *((UInt24*)ptr + 23) = (UInt24)value.x23;
                *((UInt24*)ptr + 24) = (UInt24)value.x24;
                *((UInt24*)ptr + 25) = (UInt24)value.x25;
                *((UInt24*)ptr + 26) = (UInt24)value.x26;
                *((UInt24*)ptr + 27) = (UInt24)value.x27;
                *((UInt24*)ptr + 28) = (UInt24)value.x28;
                *((UInt24*)ptr + 29) = (UInt24)value.x29;
                *((UInt24*)ptr + 30) = (UInt24)value.x30;
                *((UInt24*)ptr + 31) = (UInt24)value.x31;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i8_to40(void* ptr, sbyte32 value)
        {
            if (Avx2.IsAvx2Supported)
            {
                v256 sign = mm256_srai_epi8(value, 7);
                v256 sign0 = Avx2.mm256_shuffle_epi8(sign, new v256(0, 0, 0, 0, 0,   1, 1, 1, 1, 1,   2, 2, 2, 2, 2,   3,
                                                                    0, 0, 0, 0, 0,   1, 1, 1, 1, 1,   2, 2, 2, 2, 2,   3));
                v256 sign1 = Avx2.mm256_shuffle_epi8(sign, new v256(3, 3, 3, 3,   4, 4, 4, 4, 4,   5, 5, 5, 5, 5,   6, 6,
                                                                    3, 3, 3, 3,   4, 4, 4, 4, 4,   5, 5, 5, 5, 5,   6, 6));
                v256 sign2 = Avx2.mm256_shuffle_epi8(sign, new v256(6, 6, 6,   7, 7, 7, 7, 7,   8, 8, 8, 8, 8,   9, 9, 9,
                                                                    6, 6, 6,   7, 7, 7, 7, 7,   8, 8, 8, 8, 8,   9, 9, 9));
                v256 sign3 = Avx2.mm256_shuffle_epi8(sign, new v256(9, 9,   10, 10, 10, 10, 10,   11, 11, 11, 11, 11,   12, 12, 12, 12,
                                                                    9, 9,   10, 10, 10, 10, 10,   11, 11, 11, 11, 11,   12, 12, 12, 12));
                v256 sign4 = Avx2.mm256_shuffle_epi8(sign, new v256(12,   13, 13, 13, 13, 13,   14, 14, 14, 14, 14,   15, 15, 15, 15, 15,
                                                                    12,   13, 13, 13, 13, 13,   14, 14, 14, 14, 14,   15, 15, 15, 15, 15));

                v256 shuf0 = Avx2.mm256_shuffle_epi8(value, new v256(0, -1, -1, -1, -1,   1, -1, -1, -1, -1,   2, -1, -1, -1, -1,   3,
                                                                     0, -1, -1, -1, -1,   1, -1, -1, -1, -1,   2, -1, -1, -1, -1,   3));
                v256 shuf1 = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1, -1, -1,   4, -1, -1, -1, -1,   5, -1, -1, -1, -1,   6, -1,
                                                                     -1, -1, -1, -1,   4, -1, -1, -1, -1,   5, -1, -1, -1, -1,   6, -1));
                v256 shuf2 = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1, -1,   7, -1, -1, -1, -1,   8, -1, -1, -1, -1,   9, -1, -1,
                                                                     -1, -1, -1,   7, -1, -1, -1, -1,   8, -1, -1, -1, -1,   9, -1, -1));
                v256 shuf3 = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1,   10, -1, -1, -1, -1,   11, -1, -1, -1, -1,   12, -1, -1, -1,
                                                                     -1, -1,   10, -1, -1, -1, -1,   11, -1, -1, -1, -1,   12, -1, -1, -1));
                v256 shuf4 = Avx2.mm256_shuffle_epi8(value, new v256(-1,   13, -1, -1, -1, -1,   14, -1, -1, -1, -1,   15, -1, -1, -1, -1,
                                                                     -1,   13, -1, -1, -1, -1,   14, -1, -1, -1, -1,   15, -1, -1, -1, -1));

                shuf0 = Avx2.mm256_blendv_epi8(shuf0, sign0, new v256(0, -1, -1, -1, -1,   1, -1, -1, -1, -1,   2, -1, -1, -1, -1,   3,
                                                                      0, -1, -1, -1, -1,   1, -1, -1, -1, -1,   2, -1, -1, -1, -1,   3));
                shuf1 = Avx2.mm256_blendv_epi8(shuf1, sign1, new v256(-1, -1, -1, -1,   4, -1, -1, -1, -1,   5, -1, -1, -1, -1,   6, -1,
                                                                      -1, -1, -1, -1,   4, -1, -1, -1, -1,   5, -1, -1, -1, -1,   6, -1));
                shuf2 = Avx2.mm256_blendv_epi8(shuf2, sign2, new v256(-1, -1, -1,   7, -1, -1, -1, -1,   8, -1, -1, -1, -1,   9, -1, -1,
                                                                      -1, -1, -1,   7, -1, -1, -1, -1,   8, -1, -1, -1, -1,   9, -1, -1));
                shuf3 = Avx2.mm256_blendv_epi8(shuf3, sign3, new v256(-1, -1,   10, -1, -1, -1, -1,   11, -1, -1, -1, -1,   12, -1, -1, -1,
                                                                      -1, -1,   10, -1, -1, -1, -1,   11, -1, -1, -1, -1,   12, -1, -1, -1));
                shuf4 = Avx2.mm256_blendv_epi8(shuf4, sign4, new v256(-1,   13, -1, -1, -1, -1,   14, -1, -1, -1, -1,   15, -1, -1, -1, -1,
                                                                      -1,   13, -1, -1, -1, -1,   14, -1, -1, -1, -1,   15, -1, -1, -1, -1));

                *((v128*)((sbyte*)ptr + 0))   = shuf0.Lo128;
                *((v128*)((sbyte*)ptr + 16))  = shuf1.Lo128;
                *((v128*)((sbyte*)ptr + 32))  = shuf2.Lo128;
                *((v128*)((sbyte*)ptr + 48))  = shuf3.Lo128;
                *((v128*)((sbyte*)ptr + 64))  = shuf4.Lo128;
                *((v128*)((sbyte*)ptr + 80))  = shuf0.Hi128;
                *((v128*)((sbyte*)ptr + 96))  = shuf1.Hi128;
                *((v128*)((sbyte*)ptr + 112)) = shuf2.Hi128;
                *((v128*)((sbyte*)ptr + 128)) = shuf3.Hi128;
                *((v128*)((sbyte*)ptr + 144)) = shuf4.Hi128;
            }
            else if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 signLo = srai_epi8(value.v16_0,  7);
                v128 signHi = srai_epi8(value.v16_16, 7);
                v128 signLo0 = shuffle_epi8(signLo, new v128(0, 0, 0, 0, 0,   1, 1, 1, 1, 1,   2, 2, 2, 2, 2,   3));
                v128 signLo1 = shuffle_epi8(signLo, new v128(3, 3, 3, 3,   4, 4, 4, 4, 4,   5, 5, 5, 5, 5,   6, 6));
                v128 signLo2 = shuffle_epi8(signLo, new v128(6, 6, 6,   7, 7, 7, 7, 7,   8, 8, 8, 8, 8,   9, 9, 9));
                v128 signLo3 = shuffle_epi8(signLo, new v128(9, 9,   10, 10, 10, 10, 10,   11, 11, 11, 11, 11,   12, 12, 12, 12));
                v128 signLo4 = shuffle_epi8(signLo, new v128(12,   13, 13, 13, 13, 13,   14, 14, 14, 14, 14,   15, 15, 15, 15, 15));
                v128 signHi0 = shuffle_epi8(signHi, new v128(0, 0, 0, 0, 0,   1, 1, 1, 1, 1,   2, 2, 2, 2, 2,   3));
                v128 signHi1 = shuffle_epi8(signHi, new v128(3, 3, 3, 3,   4, 4, 4, 4, 4,   5, 5, 5, 5, 5,   6, 6));
                v128 signHi2 = shuffle_epi8(signHi, new v128(6, 6, 6,   7, 7, 7, 7, 7,   8, 8, 8, 8, 8,   9, 9, 9));
                v128 signHi3 = shuffle_epi8(signHi, new v128(9, 9,   10, 10, 10, 10, 10,   11, 11, 11, 11, 11,   12, 12, 12, 12));
                v128 signHi4 = shuffle_epi8(signHi, new v128(12,   13, 13, 13, 13, 13,   14, 14, 14, 14, 14,   15, 15, 15, 15, 15));

                v128 shufLo0 = shuffle_epi8(value.v16_0,  new v128(0, -1, -1, -1, -1,   1, -1, -1, -1, -1,   2, -1, -1, -1, -1,   3));
                v128 shufLo1 = shuffle_epi8(value.v16_0,  new v128(-1, -1, -1, -1,   4, -1, -1, -1, -1,   5, -1, -1, -1, -1,   6, -1));
                v128 shufLo2 = shuffle_epi8(value.v16_0,  new v128(-1, -1, -1,   7, -1, -1, -1, -1,   8, -1, -1, -1, -1,   9, -1, -1));
                v128 shufLo3 = shuffle_epi8(value.v16_0,  new v128(-1, -1,   10, -1, -1, -1, -1,   11, -1, -1, -1, -1,   12, -1, -1, -1));
                v128 shufLo4 = shuffle_epi8(value.v16_0,  new v128(-1,   13, -1, -1, -1, -1,   14, -1, -1, -1, -1,   15, -1, -1, -1, -1));
                v128 shufHi0 = shuffle_epi8(value.v16_16, new v128(0, -1, -1, -1, -1,   1, -1, -1, -1, -1,   2, -1, -1, -1, -1,   3));
                v128 shufHi1 = shuffle_epi8(value.v16_16, new v128(-1, -1, -1, -1,   4, -1, -1, -1, -1,   5, -1, -1, -1, -1,   6, -1));
                v128 shufHi2 = shuffle_epi8(value.v16_16, new v128(-1, -1, -1,   7, -1, -1, -1, -1,   8, -1, -1, -1, -1,   9, -1, -1));
                v128 shufHi3 = shuffle_epi8(value.v16_16, new v128(-1, -1,   10, -1, -1, -1, -1,   11, -1, -1, -1, -1,   12, -1, -1, -1));
                v128 shufHi4 = shuffle_epi8(value.v16_16, new v128(-1,   13, -1, -1, -1, -1,   14, -1, -1, -1, -1,   15, -1, -1, -1, -1));

                shufLo0 = blendv_epi8(shufLo0, signLo0, new v128(0, -1, -1, -1, -1,   1, -1, -1, -1, -1,   2, -1, -1, -1, -1,   3));
                shufLo1 = blendv_epi8(shufLo1, signLo1, new v128(-1, -1, -1, -1,   4, -1, -1, -1, -1,   5, -1, -1, -1, -1,   6, -1));
                shufLo2 = blendv_epi8(shufLo2, signLo2, new v128(-1, -1, -1,   7, -1, -1, -1, -1,   8, -1, -1, -1, -1,   9, -1, -1));
                shufLo3 = blendv_epi8(shufLo3, signLo3, new v128(-1, -1,   10, -1, -1, -1, -1,   11, -1, -1, -1, -1,   12, -1, -1, -1));
                shufLo4 = blendv_epi8(shufLo4, signLo4, new v128(-1,   13, -1, -1, -1, -1,   14, -1, -1, -1, -1,   15, -1, -1, -1, -1));
                shufHi0 = blendv_epi8(shufHi0, signHi0, new v128(0, -1, -1, -1, -1,   1, -1, -1, -1, -1,   2, -1, -1, -1, -1,   3));
                shufHi1 = blendv_epi8(shufHi1, signHi1, new v128(-1, -1, -1, -1,   4, -1, -1, -1, -1,   5, -1, -1, -1, -1,   6, -1));
                shufHi2 = blendv_epi8(shufHi2, signHi2, new v128(-1, -1, -1,   7, -1, -1, -1, -1,   8, -1, -1, -1, -1,   9, -1, -1));
                shufHi3 = blendv_epi8(shufHi3, signHi3, new v128(-1, -1,   10, -1, -1, -1, -1,   11, -1, -1, -1, -1,   12, -1, -1, -1));
                shufHi4 = blendv_epi8(shufHi4, signHi4, new v128(-1,   13, -1, -1, -1, -1,   14, -1, -1, -1, -1,   15, -1, -1, -1, -1));
                
                *((v128*)((sbyte*)ptr + 0))   = shufLo0;
                *((v128*)((sbyte*)ptr + 16))  = shufLo1;
                *((v128*)((sbyte*)ptr + 32))  = shufLo2;
                *((v128*)((sbyte*)ptr + 48))  = shufLo3;
                *((v128*)((sbyte*)ptr + 64))  = shufLo4;
                *((v128*)((sbyte*)ptr + 80))  = shufHi0;
                *((v128*)((sbyte*)ptr + 96))  = shufHi1;
                *((v128*)((sbyte*)ptr + 112)) = shufHi2;
                *((v128*)((sbyte*)ptr + 128)) = shufHi3;
                *((v128*)((sbyte*)ptr + 144)) = shufHi4;
            }
            else
            {
                *((UInt40*)ptr + 0)  = (UInt40)value.x0;
                *((UInt40*)ptr + 1)  = (UInt40)value.x1;
                *((UInt40*)ptr + 2)  = (UInt40)value.x2;
                *((UInt40*)ptr + 3)  = (UInt40)value.x3;
                *((UInt40*)ptr + 4)  = (UInt40)value.x4;
                *((UInt40*)ptr + 5)  = (UInt40)value.x5;
                *((UInt40*)ptr + 6)  = (UInt40)value.x6;
                *((UInt40*)ptr + 7)  = (UInt40)value.x7;
                *((UInt40*)ptr + 8)  = (UInt40)value.x8;
                *((UInt40*)ptr + 9)  = (UInt40)value.x9;
                *((UInt40*)ptr + 10) = (UInt40)value.x10;
                *((UInt40*)ptr + 11) = (UInt40)value.x11;
                *((UInt40*)ptr + 12) = (UInt40)value.x12;
                *((UInt40*)ptr + 13) = (UInt40)value.x13;
                *((UInt40*)ptr + 14) = (UInt40)value.x14;
                *((UInt40*)ptr + 15) = (UInt40)value.x15;
                *((UInt40*)ptr + 16) = (UInt40)value.x16;
                *((UInt40*)ptr + 17) = (UInt40)value.x17;
                *((UInt40*)ptr + 18) = (UInt40)value.x18;
                *((UInt40*)ptr + 19) = (UInt40)value.x19;
                *((UInt40*)ptr + 20) = (UInt40)value.x20;
                *((UInt40*)ptr + 21) = (UInt40)value.x21;
                *((UInt40*)ptr + 22) = (UInt40)value.x22;
                *((UInt40*)ptr + 23) = (UInt40)value.x23;
                *((UInt40*)ptr + 24) = (UInt40)value.x24;
                *((UInt40*)ptr + 25) = (UInt40)value.x25;
                *((UInt40*)ptr + 26) = (UInt40)value.x26;
                *((UInt40*)ptr + 27) = (UInt40)value.x27;
                *((UInt40*)ptr + 28) = (UInt40)value.x28;
                *((UInt40*)ptr + 29) = (UInt40)value.x29;
                *((UInt40*)ptr + 30) = (UInt40)value.x30;
                *((UInt40*)ptr + 31) = (UInt40)value.x31;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i8_to48(void* ptr, sbyte32 value)
        {
            if (Avx2.IsAvx2Supported)
            {
                v256 sign = mm256_srai_epi8(value, 7);

                v256 sign0 = Avx2.mm256_shuffle_epi8(sign, new v256(0, 0, 0, 0, 0, 0,   1, 1, 1, 1, 1, 1,   2, 2, 2, 2,
                                                                    0, 0, 0, 0, 0, 0,   1, 1, 1, 1, 1, 1,   2, 2, 2, 2));
                v256 sign1 = Avx2.mm256_shuffle_epi8(sign, new v256(2, 2,   3, 3, 3, 3, 3, 3,   4, 4, 4, 4, 4, 4,   5, 5,
                                                                    2, 2,   3, 3, 3, 3, 3, 3,   4, 4, 4, 4, 4, 4,   5, 5));
                v256 sign2 = Avx2.mm256_shuffle_epi8(sign, new v256(5, 5, 5, 5,   6, 6, 6, 6, 6, 6,   7, 7, 7, 7, 7, 7,
                                                                    5, 5, 5, 5,   6, 6, 6, 6, 6, 6,   7, 7, 7, 7, 7, 7));
                v256 sign3 = Avx2.mm256_shuffle_epi8(sign, new v256(8, 8, 8, 8, 8, 8,   9, 9, 9, 9, 9, 9,   10, 10, 10, 10,
                                                                    8, 8, 8, 8, 8, 8,   9, 9, 9, 9, 9, 9,   10, 10, 10, 10));
                v256 sign4 = Avx2.mm256_shuffle_epi8(sign, new v256(10, 10,   11, 11, 11, 11, 11, 11,   12, 12, 12, 12, 12, 12,   13, 13,
                                                                    10, 10,   11, 11, 11, 11, 11, 11,   12, 12, 12, 12, 12, 12,   13, 13));
                v256 sign5 = Avx2.mm256_shuffle_epi8(sign, new v256(13, 13, 13, 13,   14, 14, 14, 14, 14, 14,   15, 15, 15, 15, 15, 15,
                                                                    13, 13, 13, 13,   14, 14, 14, 14, 14, 14,   15, 15, 15, 15, 15, 15));

                v256 shuf0 = Avx2.mm256_shuffle_epi8(value, new v256(0, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1,   2, -1, -1, -1,
                                                                     0, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1,   2, -1, -1, -1));
                v256 shuf1 = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1,   3, -1, -1, -1, -1, -1,   4, -1, -1, -1, -1, -1,   5, -1,
                                                                     -1, -1,   3, -1, -1, -1, -1, -1,   4, -1, -1, -1, -1, -1,   5, -1));
                v256 shuf2 = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1, -1, -1,   6, -1, -1, -1, -1, -1,   7, -1, -1, -1, -1, -1,
                                                                     -1, -1, -1, -1,   6, -1, -1, -1, -1, -1,   7, -1, -1, -1, -1, -1));
                v256 shuf3 = Avx2.mm256_shuffle_epi8(value, new v256(8, -1, -1, -1, -1, -1,   9, -1, -1, -1, -1, -1,   10, -1, -1, -1,
                                                                     8, -1, -1, -1, -1, -1,   9, -1, -1, -1, -1, -1,   10, -1, -1, -1));
                v256 shuf4 = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1,   11, -1, -1, -1, -1, -1,   12, -1, -1, -1, -1, -1,   13, -1,
                                                                     -1, -1,   11, -1, -1, -1, -1, -1,   12, -1, -1, -1, -1, -1,   13, -1));
                v256 shuf5 = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1, -1, -1,   14, -1, -1, -1, -1, -1,   15, -1, -1, -1, -1, -1,
                                                                     -1, -1, -1, -1,   14, -1, -1, -1, -1, -1,   15, -1, -1, -1, -1, -1));

                shuf0 = Avx2.mm256_blendv_epi8(shuf0, sign0, new v256(0, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1,   2, -1, -1, -1,
                                                                      0, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1,   2, -1, -1, -1));
                shuf1 = Avx2.mm256_blendv_epi8(shuf1, sign1, new v256(-1, -1,   3, -1, -1, -1, -1, -1,   4, -1, -1, -1, -1, -1,   5, -1,
                                                                      -1, -1,   3, -1, -1, -1, -1, -1,   4, -1, -1, -1, -1, -1,   5, -1));
                shuf2 = Avx2.mm256_blendv_epi8(shuf2, sign2, new v256(-1, -1, -1, -1,   6, -1, -1, -1, -1, -1,   7, -1, -1, -1, -1, -1,
                                                                      -1, -1, -1, -1,   6, -1, -1, -1, -1, -1,   7, -1, -1, -1, -1, -1));
                shuf3 = Avx2.mm256_blendv_epi8(shuf3, sign3, new v256(8, -1, -1, -1, -1, -1,   9, -1, -1, -1, -1, -1,   10, -1, -1, -1,
                                                                      8, -1, -1, -1, -1, -1,   9, -1, -1, -1, -1, -1,   10, -1, -1, -1));
                shuf4 = Avx2.mm256_blendv_epi8(shuf4, sign4, new v256(-1, -1,   11, -1, -1, -1, -1, -1,   12, -1, -1, -1, -1, -1,   13, -1,
                                                                      -1, -1,   11, -1, -1, -1, -1, -1,   12, -1, -1, -1, -1, -1,   13, -1));
                shuf5 = Avx2.mm256_blendv_epi8(shuf5, sign5, new v256(-1, -1, -1, -1,   14, -1, -1, -1, -1, -1,   15, -1, -1, -1, -1, -1,
                                                                      -1, -1, -1, -1,   14, -1, -1, -1, -1, -1,   15, -1, -1, -1, -1, -1));
                
                *((v128*)((sbyte*)ptr + 0))   = shuf0.Lo128;
                *((v128*)((sbyte*)ptr + 16))  = shuf1.Lo128;
                *((v128*)((sbyte*)ptr + 32))  = shuf2.Lo128;
                *((v128*)((sbyte*)ptr + 48))  = shuf3.Lo128;
                *((v128*)((sbyte*)ptr + 64))  = shuf4.Lo128;
                *((v128*)((sbyte*)ptr + 80))  = shuf5.Lo128;
                *((v128*)((sbyte*)ptr + 96))  = shuf0.Hi128;
                *((v128*)((sbyte*)ptr + 112)) = shuf1.Hi128;
                *((v128*)((sbyte*)ptr + 128)) = shuf2.Hi128;
                *((v128*)((sbyte*)ptr + 144)) = shuf3.Hi128;
                *((v128*)((sbyte*)ptr + 160)) = shuf4.Hi128;
                *((v128*)((sbyte*)ptr + 176)) = shuf5.Hi128;
            }
            else if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 signLo = srai_epi8(value.v16_0,  7);
                v128 signHi = srai_epi8(value.v16_16, 7);
                v128 signLo0 = shuffle_epi8(signLo, new v128(0, 0, 0, 0, 0, 0,   1, 1, 1, 1, 1, 1,   2, 2, 2, 2));
                v128 signLo1 = shuffle_epi8(signLo, new v128(2, 2,   3, 3, 3, 3, 3, 3,   4, 4, 4, 4, 4, 4,   5, 5));
                v128 signLo2 = shuffle_epi8(signLo, new v128(5, 5, 5, 5,   6, 6, 6, 6, 6, 6,   7, 7, 7, 7, 7, 7));
                v128 signLo3 = shuffle_epi8(signLo, new v128(8, 8, 8, 8, 8, 8,   9, 9, 9, 9, 9, 9,   10, 10, 10, 10));
                v128 signLo4 = shuffle_epi8(signLo, new v128(10, 10,   11, 11, 11, 11, 11, 11,   12, 12, 12, 12, 12, 12,   13, 13));
                v128 signLo5 = shuffle_epi8(signLo, new v128(13, 13, 13, 13,   14, 14, 14, 14, 14, 14,   15, 15, 15, 15, 15, 15));
                v128 signHi0 = shuffle_epi8(signHi, new v128(0, 0, 0, 0, 0, 0,   1, 1, 1, 1, 1, 1,   2, 2, 2, 2));
                v128 signHi1 = shuffle_epi8(signHi, new v128(2, 2,   3, 3, 3, 3, 3, 3,   4, 4, 4, 4, 4, 4,   5, 5));
                v128 signHi2 = shuffle_epi8(signHi, new v128(5, 5, 5, 5,   6, 6, 6, 6, 6, 6,   7, 7, 7, 7, 7, 7));
                v128 signHi3 = shuffle_epi8(signHi, new v128(8, 8, 8, 8, 8, 8,   9, 9, 9, 9, 9, 9,   10, 10, 10, 10));
                v128 signHi4 = shuffle_epi8(signHi, new v128(10, 10,   11, 11, 11, 11, 11, 11,   12, 12, 12, 12, 12, 12,   13, 13));
                v128 signHi5 = shuffle_epi8(signHi, new v128(13, 13, 13, 13,   14, 14, 14, 14, 14, 14,   15, 15, 15, 15, 15, 15));

                v128 shufLo0 = shuffle_epi8(value.v16_0,  new v128(0, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1,   2, -1, -1, -1));
                v128 shufLo1 = shuffle_epi8(value.v16_0,  new v128(-1, -1,   3, -1, -1, -1, -1, -1,   4, -1, -1, -1, -1, -1,   5, -1));
                v128 shufLo2 = shuffle_epi8(value.v16_0,  new v128(-1, -1, -1, -1,   6, -1, -1, -1, -1, -1,   7, -1, -1, -1, -1, -1));
                v128 shufLo3 = shuffle_epi8(value.v16_0,  new v128(8, -1, -1, -1, -1, -1,   9, -1, -1, -1, -1, -1,   10, -1, -1, -1));
                v128 shufLo4 = shuffle_epi8(value.v16_0,  new v128(-1, -1,   11, -1, -1, -1, -1, -1,   12, -1, -1, -1, -1, -1,   13, -1));
                v128 shufLo5 = shuffle_epi8(value.v16_0,  new v128(-1, -1, -1, -1,   14, -1, -1, -1, -1, -1,   15, -1, -1, -1, -1, -1));
                v128 shufHi0 = shuffle_epi8(value.v16_16, new v128(0, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1,   2, -1, -1, -1));
                v128 shufHi1 = shuffle_epi8(value.v16_16, new v128(-1, -1,   3, -1, -1, -1, -1, -1,   4, -1, -1, -1, -1, -1,   5, -1));
                v128 shufHi2 = shuffle_epi8(value.v16_16, new v128(-1, -1, -1, -1,   6, -1, -1, -1, -1, -1,   7, -1, -1, -1, -1, -1));
                v128 shufHi3 = shuffle_epi8(value.v16_16, new v128(8, -1, -1, -1, -1, -1,   9, -1, -1, -1, -1, -1,   10, -1, -1, -1));
                v128 shufHi4 = shuffle_epi8(value.v16_16, new v128(-1, -1,   11, -1, -1, -1, -1, -1,   12, -1, -1, -1, -1, -1,   13, -1));
                v128 shufHi5 = shuffle_epi8(value.v16_16, new v128(-1, -1, -1, -1,   14, -1, -1, -1, -1, -1,   15, -1, -1, -1, -1, -1));

                shufLo0 = blendv_epi8(shufLo0, signLo0, new v128(0, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1,   2, -1, -1, -1));
                shufLo1 = blendv_epi8(shufLo1, signLo1, new v128(-1, -1,   3, -1, -1, -1, -1, -1,   4, -1, -1, -1, -1, -1,   5, -1));
                shufLo2 = blendv_epi8(shufLo2, signLo2, new v128(-1, -1, -1, -1,   6, -1, -1, -1, -1, -1,   7, -1, -1, -1, -1, -1));
                shufLo3 = blendv_epi8(shufLo3, signLo3, new v128(8, -1, -1, -1, -1, -1,   9, -1, -1, -1, -1, -1,   10, -1, -1, -1));
                shufLo4 = blendv_epi8(shufLo4, signLo4, new v128(-1, -1,   11, -1, -1, -1, -1, -1,   12, -1, -1, -1, -1, -1,   13, -1));
                shufLo5 = blendv_epi8(shufLo5, signLo5, new v128(-1, -1, -1, -1,   14, -1, -1, -1, -1, -1,   15, -1, -1, -1, -1, -1));
                shufHi0 = blendv_epi8(shufHi0, signHi0, new v128(0, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1,   2, -1, -1, -1));
                shufHi1 = blendv_epi8(shufHi1, signHi1, new v128(-1, -1,   3, -1, -1, -1, -1, -1,   4, -1, -1, -1, -1, -1,   5, -1));
                shufHi2 = blendv_epi8(shufHi2, signHi2, new v128(-1, -1, -1, -1,   6, -1, -1, -1, -1, -1,   7, -1, -1, -1, -1, -1));
                shufHi3 = blendv_epi8(shufHi3, signHi3, new v128(8, -1, -1, -1, -1, -1,   9, -1, -1, -1, -1, -1,   10, -1, -1, -1));
                shufHi4 = blendv_epi8(shufHi4, signHi4, new v128(-1, -1,   11, -1, -1, -1, -1, -1,   12, -1, -1, -1, -1, -1,   13, -1));
                shufHi5 = blendv_epi8(shufHi5, signHi5, new v128(-1, -1, -1, -1,   14, -1, -1, -1, -1, -1,   15, -1, -1, -1, -1, -1));
                
                *((v128*)((sbyte*)ptr + 0))   = shufLo0;
                *((v128*)((sbyte*)ptr + 16))  = shufLo1;
                *((v128*)((sbyte*)ptr + 32))  = shufLo2;
                *((v128*)((sbyte*)ptr + 48))  = shufLo3;
                *((v128*)((sbyte*)ptr + 64))  = shufLo4;
                *((v128*)((sbyte*)ptr + 80))  = shufLo5;
                *((v128*)((sbyte*)ptr + 96))  = shufHi0;
                *((v128*)((sbyte*)ptr + 112)) = shufHi1;
                *((v128*)((sbyte*)ptr + 128)) = shufHi2;
                *((v128*)((sbyte*)ptr + 144)) = shufHi3;
                *((v128*)((sbyte*)ptr + 160)) = shufHi4;
                *((v128*)((sbyte*)ptr + 176)) = shufHi5;
            }
            else
            {
                *((UInt48*)ptr + 0)  = (UInt48)value.x0;
                *((UInt48*)ptr + 1)  = (UInt48)value.x1;
                *((UInt48*)ptr + 2)  = (UInt48)value.x2;
                *((UInt48*)ptr + 3)  = (UInt48)value.x3;
                *((UInt48*)ptr + 4)  = (UInt48)value.x4;
                *((UInt48*)ptr + 5)  = (UInt48)value.x5;
                *((UInt48*)ptr + 6)  = (UInt48)value.x6;
                *((UInt48*)ptr + 7)  = (UInt48)value.x7;
                *((UInt48*)ptr + 8)  = (UInt48)value.x8;
                *((UInt48*)ptr + 9)  = (UInt48)value.x9;
                *((UInt48*)ptr + 10) = (UInt48)value.x10;
                *((UInt48*)ptr + 11) = (UInt48)value.x11;
                *((UInt48*)ptr + 12) = (UInt48)value.x12;
                *((UInt48*)ptr + 13) = (UInt48)value.x13;
                *((UInt48*)ptr + 14) = (UInt48)value.x14;
                *((UInt48*)ptr + 15) = (UInt48)value.x15;
                *((UInt48*)ptr + 16) = (UInt48)value.x16;
                *((UInt48*)ptr + 17) = (UInt48)value.x17;
                *((UInt48*)ptr + 18) = (UInt48)value.x18;
                *((UInt48*)ptr + 19) = (UInt48)value.x19;
                *((UInt48*)ptr + 20) = (UInt48)value.x20;
                *((UInt48*)ptr + 21) = (UInt48)value.x21;
                *((UInt48*)ptr + 22) = (UInt48)value.x22;
                *((UInt48*)ptr + 23) = (UInt48)value.x23;
                *((UInt48*)ptr + 24) = (UInt48)value.x24;
                *((UInt48*)ptr + 25) = (UInt48)value.x25;
                *((UInt48*)ptr + 26) = (UInt48)value.x26;
                *((UInt48*)ptr + 27) = (UInt48)value.x27;
                *((UInt48*)ptr + 28) = (UInt48)value.x28;
                *((UInt48*)ptr + 29) = (UInt48)value.x29;
                *((UInt48*)ptr + 30) = (UInt48)value.x30;
                *((UInt48*)ptr + 31) = (UInt48)value.x31;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i8_to56(void* ptr, sbyte32 value)
        {
            if (Avx2.IsAvx2Supported)
            {
                v256 sign = mm256_srai_epi8(value, 7);

                v256 sign0 = Avx2.mm256_shuffle_epi8(sign, new v256(0, 0, 0, 0, 0, 0, 0,   1, 1, 1, 1, 1, 1, 1,   2, 2,
                                                                    0, 0, 0, 0, 0, 0, 0,   1, 1, 1, 1, 1, 1, 1,   2, 2));
                v256 sign1 = Avx2.mm256_shuffle_epi8(sign, new v256(2, 2, 2, 2, 2,   3, 3, 3, 3, 3, 3, 3,   4, 4, 4, 4,
                                                                    2, 2, 2, 2, 2,   3, 3, 3, 3, 3, 3, 3,   4, 4, 4, 4));
                v256 sign2 = Avx2.mm256_shuffle_epi8(sign, new v256(4, 4, 4,   5, 5, 5, 5, 5, 5, 5,   6, 6, 6, 6, 6, 6,
                                                                    4, 4, 4,   5, 5, 5, 5, 5, 5, 5,   6, 6, 6, 6, 6, 6));
                v256 sign3 = Avx2.mm256_shuffle_epi8(sign, new v256(6,   7, 7, 7, 7, 7, 7, 7,   8, 8, 8, 8, 8, 8, 8,   9,
                                                                    6,   7, 7, 7, 7, 7, 7, 7,   8, 8, 8, 8, 8, 8, 8,   9));
                v256 sign4 = Avx2.mm256_shuffle_epi8(sign, new v256(9, 9, 9, 9, 9, 9,   10, 10, 10, 10, 10, 10, 10,   11, 11, 11,
                                                                    9, 9, 9, 9, 9, 9,   10, 10, 10, 10, 10, 10, 10,   11, 11, 11));
                v256 sign5 = Avx2.mm256_shuffle_epi8(sign, new v256(11, 11, 11, 11,   12, 12, 12, 12, 12, 12, 12,   13, 13, 13, 13, 13,
                                                                    11, 11, 11, 11,   12, 12, 12, 12, 12, 12, 12,   13, 13, 13, 13, 13));
                v256 sign6 = Avx2.mm256_shuffle_epi8(sign, new v256(13, 13,   14, 14, 14, 14, 14, 14, 14,   15, 15, 15, 15, 15, 15, 15,
                                                                    13, 13,   14, 14, 14, 14, 14, 14, 14,   15, 15, 15, 15, 15, 15, 15));

                v256 shuf0 = Avx2.mm256_shuffle_epi8(value, new v256(0, -1, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1, -1,   2, -1,
                                                                     0, -1, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1, -1,   2, -1));
                v256 shuf1 = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1, -1, -1, -1,   3, -1, -1, -1, -1, -1, -1,   4, -1, -1, -1,
                                                                     -1, -1, -1, -1, -1,   3, -1, -1, -1, -1, -1, -1,   4, -1, -1, -1));
                v256 shuf2 = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1, -1,   5, -1, -1, -1, -1, -1, -1,   6, -1, -1, -1, -1, -1,
                                                                     -1, -1, -1,   5, -1, -1, -1, -1, -1, -1,   6, -1, -1, -1, -1, -1));
                v256 shuf3 = Avx2.mm256_shuffle_epi8(value, new v256(-1,   7, -1, -1, -1, -1, -1, -1,   8, -1, -1, -1, -1, -1, -1,   9,
                                                                     -1,   7, -1, -1, -1, -1, -1, -1,   8, -1, -1, -1, -1, -1, -1,   9));
                v256 shuf4 = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1, -1, -1, -1, -1,   10, -1, -1, -1, -1, -1, -1,   11, -1, -1,
                                                                     -1, -1, -1, -1, -1, -1,   10, -1, -1, -1, -1, -1, -1,   11, -1, -1));
                v256 shuf5 = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1, -1, -1,   12, -1, -1, -1, -1, -1, -1,   13, -1, -1, -1, -1,
                                                                     -1, -1, -1, -1,   12, -1, -1, -1, -1, -1, -1,   13, -1, -1, -1, -1));
                v256 shuf6 = Avx2.mm256_shuffle_epi8(value, new v256(-1, -1,   14, -1, -1, -1, -1, -1, -1,   15, -1, -1, -1, -1, -1, -1,
                                                                     -1, -1,   14, -1, -1, -1, -1, -1, -1,   15, -1, -1, -1, -1, -1, -1));

                shuf0 = Avx2.mm256_blendv_epi8(shuf0, sign0, new v256(0, -1, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1, -1,   2, -1,
                                                                      0, -1, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1, -1,   2, -1));
                shuf1 = Avx2.mm256_blendv_epi8(shuf1, sign1, new v256(-1, -1, -1, -1, -1,   3, -1, -1, -1, -1, -1, -1,   4, -1, -1, -1,
                                                                      -1, -1, -1, -1, -1,   3, -1, -1, -1, -1, -1, -1,   4, -1, -1, -1));
                shuf2 = Avx2.mm256_blendv_epi8(shuf2, sign2, new v256(-1, -1, -1,   5, -1, -1, -1, -1, -1, -1,   6, -1, -1, -1, -1, -1,
                                                                      -1, -1, -1,   5, -1, -1, -1, -1, -1, -1,   6, -1, -1, -1, -1, -1));
                shuf3 = Avx2.mm256_blendv_epi8(shuf3, sign3, new v256(-1,   7, -1, -1, -1, -1, -1, -1,   8, -1, -1, -1, -1, -1, -1,   9,
                                                                      -1,   7, -1, -1, -1, -1, -1, -1,   8, -1, -1, -1, -1, -1, -1,   9));
                shuf4 = Avx2.mm256_blendv_epi8(shuf4, sign4, new v256(-1, -1, -1, -1, -1, -1,   10, -1, -1, -1, -1, -1, -1,   11, -1, -1,
                                                                      -1, -1, -1, -1, -1, -1,   10, -1, -1, -1, -1, -1, -1,   11, -1, -1));
                shuf5 = Avx2.mm256_blendv_epi8(shuf5, sign5, new v256(-1, -1, -1, -1,   12, -1, -1, -1, -1, -1, -1,   13, -1, -1, -1, -1,
                                                                      -1, -1, -1, -1,   12, -1, -1, -1, -1, -1, -1,   13, -1, -1, -1, -1));
                shuf6 = Avx2.mm256_blendv_epi8(shuf6, sign6, new v256(-1, -1,   14, -1, -1, -1, -1, -1, -1,   15, -1, -1, -1, -1, -1, -1,
                                                                      -1, -1,   14, -1, -1, -1, -1, -1, -1,   15, -1, -1, -1, -1, -1, -1));
                
                *((v128*)((sbyte*)ptr + 0))   = shuf0.Lo128;
                *((v128*)((sbyte*)ptr + 16))  = shuf1.Lo128;
                *((v128*)((sbyte*)ptr + 32))  = shuf2.Lo128;
                *((v128*)((sbyte*)ptr + 48))  = shuf3.Lo128;
                *((v128*)((sbyte*)ptr + 64))  = shuf4.Lo128;
                *((v128*)((sbyte*)ptr + 80))  = shuf5.Lo128;
                *((v128*)((sbyte*)ptr + 96))  = shuf6.Lo128;
                *((v128*)((sbyte*)ptr + 112)) = shuf0.Hi128;
                *((v128*)((sbyte*)ptr + 128)) = shuf1.Hi128;
                *((v128*)((sbyte*)ptr + 144)) = shuf2.Hi128;
                *((v128*)((sbyte*)ptr + 160)) = shuf3.Hi128;
                *((v128*)((sbyte*)ptr + 176)) = shuf4.Hi128;
                *((v128*)((sbyte*)ptr + 192)) = shuf5.Hi128;
                *((v128*)((sbyte*)ptr + 208)) = shuf6.Hi128;
            }
            else if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 signLo = srai_epi8(value.v16_0,  7);
                v128 signHi = srai_epi8(value.v16_16, 7);
                v128 signLo0 = shuffle_epi8(signLo, new v128(0, 0, 0, 0, 0, 0, 0,   1, 1, 1, 1, 1, 1, 1,   2, 2));
                v128 signLo1 = shuffle_epi8(signLo, new v128(2, 2, 2, 2, 2,   3, 3, 3, 3, 3, 3, 3,   4, 4, 4, 4));
                v128 signLo2 = shuffle_epi8(signLo, new v128(4, 4, 4,   5, 5, 5, 5, 5, 5, 5,   6, 6, 6, 6, 6, 6));
                v128 signLo3 = shuffle_epi8(signLo, new v128(6,   7, 7, 7, 7, 7, 7, 7,   8, 8, 8, 8, 8, 8, 8,   9));
                v128 signLo4 = shuffle_epi8(signLo, new v128(9, 9, 9, 9, 9, 9,   10, 10, 10, 10, 10, 10, 10,   11, 11, 11));
                v128 signLo5 = shuffle_epi8(signLo, new v128(11, 11, 11, 11,   12, 12, 12, 12, 12, 12, 12,   13, 13, 13, 13, 13));
                v128 signLo6 = shuffle_epi8(signLo, new v128(13, 13,   14, 14, 14, 14, 14, 14, 14,   15, 15, 15, 15, 15, 15, 15));
                v128 signHi0 = shuffle_epi8(signHi, new v128(0, 0, 0, 0, 0, 0, 0,   1, 1, 1, 1, 1, 1, 1,   2, 2));
                v128 signHi1 = shuffle_epi8(signHi, new v128(2, 2, 2, 2, 2,   3, 3, 3, 3, 3, 3, 3,   4, 4, 4, 4));
                v128 signHi2 = shuffle_epi8(signHi, new v128(4, 4, 4,   5, 5, 5, 5, 5, 5, 5,   6, 6, 6, 6, 6, 6));
                v128 signHi3 = shuffle_epi8(signHi, new v128(6,   7, 7, 7, 7, 7, 7, 7,   8, 8, 8, 8, 8, 8, 8,   9));
                v128 signHi4 = shuffle_epi8(signHi, new v128(9, 9, 9, 9, 9, 9,   10, 10, 10, 10, 10, 10, 10,   11, 11, 11));
                v128 signHi5 = shuffle_epi8(signHi, new v128(11, 11, 11, 11,   12, 12, 12, 12, 12, 12, 12,   13, 13, 13, 13, 13));
                v128 signHi6 = shuffle_epi8(signHi, new v128(13, 13,   14, 14, 14, 14, 14, 14, 14,   15, 15, 15, 15, 15, 15, 15));

                v128 shufLo0 = shuffle_epi8(value.v16_0,  new v128(0, -1, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1, -1,   2, -1));
                v128 shufLo1 = shuffle_epi8(value.v16_0,  new v128(-1, -1, -1, -1, -1,   3, -1, -1, -1, -1, -1, -1,   4, -1, -1, -1));
                v128 shufLo2 = shuffle_epi8(value.v16_0,  new v128(-1, -1, -1,   5, -1, -1, -1, -1, -1, -1,   6, -1, -1, -1, -1, -1));
                v128 shufLo3 = shuffle_epi8(value.v16_0,  new v128(-1,   7, -1, -1, -1, -1, -1, -1,   8, -1, -1, -1, -1, -1, -1,   9));
                v128 shufLo4 = shuffle_epi8(value.v16_0,  new v128(-1, -1, -1, -1, -1, -1,   10, -1, -1, -1, -1, -1, -1,   11, -1, -1));
                v128 shufLo5 = shuffle_epi8(value.v16_0,  new v128(-1, -1, -1, -1,   12, -1, -1, -1, -1, -1, -1,   13, -1, -1, -1, -1));
                v128 shufLo6 = shuffle_epi8(value.v16_0,  new v128(-1, -1,   14, -1, -1, -1, -1, -1, -1,   15, -1, -1, -1, -1, -1, -1));
                v128 shufHi0 = shuffle_epi8(value.v16_16, new v128(0, -1, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1, -1,   2, -1));
                v128 shufHi1 = shuffle_epi8(value.v16_16, new v128(-1, -1, -1, -1, -1,   3, -1, -1, -1, -1, -1, -1,   4, -1, -1, -1));
                v128 shufHi2 = shuffle_epi8(value.v16_16, new v128(-1, -1, -1,   5, -1, -1, -1, -1, -1, -1,   6, -1, -1, -1, -1, -1));
                v128 shufHi3 = shuffle_epi8(value.v16_16, new v128(-1,   7, -1, -1, -1, -1, -1, -1,   8, -1, -1, -1, -1, -1, -1,   9));
                v128 shufHi4 = shuffle_epi8(value.v16_16, new v128(-1, -1, -1, -1, -1, -1,   10, -1, -1, -1, -1, -1, -1,   11, -1, -1));
                v128 shufHi5 = shuffle_epi8(value.v16_16, new v128(-1, -1, -1, -1,   12, -1, -1, -1, -1, -1, -1,   13, -1, -1, -1, -1));
                v128 shufHi6 = shuffle_epi8(value.v16_16, new v128(-1, -1,   14, -1, -1, -1, -1, -1, -1,   15, -1, -1, -1, -1, -1, -1));

                shufLo0 = blendv_epi8(shufLo0, signLo0, new v128(0, -1, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1, -1,   2, -1));
                shufLo1 = blendv_epi8(shufLo1, signLo1, new v128(-1, -1, -1, -1, -1,   3, -1, -1, -1, -1, -1, -1,   4, -1, -1, -1));
                shufLo2 = blendv_epi8(shufLo2, signLo2, new v128(-1, -1, -1,   5, -1, -1, -1, -1, -1, -1,   6, -1, -1, -1, -1, -1));
                shufLo3 = blendv_epi8(shufLo3, signLo3, new v128(-1,   7, -1, -1, -1, -1, -1, -1,   8, -1, -1, -1, -1, -1, -1,   9));
                shufLo4 = blendv_epi8(shufLo4, signLo4, new v128(-1, -1, -1, -1, -1, -1,   10, -1, -1, -1, -1, -1, -1,   11, -1, -1));
                shufLo5 = blendv_epi8(shufLo5, signLo5, new v128(-1, -1, -1, -1,   12, -1, -1, -1, -1, -1, -1,   13, -1, -1, -1, -1));
                shufLo6 = blendv_epi8(shufLo6, signLo6, new v128(-1, -1,   14, -1, -1, -1, -1, -1, -1,   15, -1, -1, -1, -1, -1, -1));
                shufHi0 = blendv_epi8(shufHi0, signHi0, new v128(0, -1, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1, -1,   2, -1));
                shufHi1 = blendv_epi8(shufHi1, signHi1, new v128(-1, -1, -1, -1, -1,   3, -1, -1, -1, -1, -1, -1,   4, -1, -1, -1));
                shufHi2 = blendv_epi8(shufHi2, signHi2, new v128(-1, -1, -1,   5, -1, -1, -1, -1, -1, -1,   6, -1, -1, -1, -1, -1));
                shufHi3 = blendv_epi8(shufHi3, signHi3, new v128(-1,   7, -1, -1, -1, -1, -1, -1,   8, -1, -1, -1, -1, -1, -1,   9));
                shufHi4 = blendv_epi8(shufHi4, signHi4, new v128(-1, -1, -1, -1, -1, -1,   10, -1, -1, -1, -1, -1, -1,   11, -1, -1));
                shufHi5 = blendv_epi8(shufHi5, signHi5, new v128(-1, -1, -1, -1,   12, -1, -1, -1, -1, -1, -1,   13, -1, -1, -1, -1));
                shufHi6 = blendv_epi8(shufHi6, signHi6, new v128(-1, -1,   14, -1, -1, -1, -1, -1, -1,   15, -1, -1, -1, -1, -1, -1));
                
                *((v128*)((sbyte*)ptr + 0))   = shufLo0;
                *((v128*)((sbyte*)ptr + 16))  = shufLo1;
                *((v128*)((sbyte*)ptr + 32))  = shufLo2;
                *((v128*)((sbyte*)ptr + 48))  = shufLo3;
                *((v128*)((sbyte*)ptr + 64))  = shufLo4;
                *((v128*)((sbyte*)ptr + 80))  = shufLo5;
                *((v128*)((sbyte*)ptr + 96))  = shufLo6;
                *((v128*)((sbyte*)ptr + 112)) = shufHi0;
                *((v128*)((sbyte*)ptr + 128)) = shufHi1;
                *((v128*)((sbyte*)ptr + 144)) = shufHi2;
                *((v128*)((sbyte*)ptr + 160)) = shufHi3;
                *((v128*)((sbyte*)ptr + 176)) = shufHi4;
                *((v128*)((sbyte*)ptr + 192)) = shufHi5;
                *((v128*)((sbyte*)ptr + 208)) = shufHi6;
            }
            else
            {
                *((UInt56*)ptr + 0)  = (UInt56)value.x0;
                *((UInt56*)ptr + 1)  = (UInt56)value.x1;
                *((UInt56*)ptr + 2)  = (UInt56)value.x2;
                *((UInt56*)ptr + 3)  = (UInt56)value.x3;
                *((UInt56*)ptr + 4)  = (UInt56)value.x4;
                *((UInt56*)ptr + 5)  = (UInt56)value.x5;
                *((UInt56*)ptr + 6)  = (UInt56)value.x6;
                *((UInt56*)ptr + 7)  = (UInt56)value.x7;
                *((UInt56*)ptr + 8)  = (UInt56)value.x8;
                *((UInt56*)ptr + 9)  = (UInt56)value.x9;
                *((UInt56*)ptr + 10) = (UInt56)value.x10;
                *((UInt56*)ptr + 11) = (UInt56)value.x11;
                *((UInt56*)ptr + 12) = (UInt56)value.x12;
                *((UInt56*)ptr + 13) = (UInt56)value.x13;
                *((UInt56*)ptr + 14) = (UInt56)value.x14;
                *((UInt56*)ptr + 15) = (UInt56)value.x15;
                *((UInt56*)ptr + 16) = (UInt56)value.x16;
                *((UInt56*)ptr + 17) = (UInt56)value.x17;
                *((UInt56*)ptr + 18) = (UInt56)value.x18;
                *((UInt56*)ptr + 19) = (UInt56)value.x19;
                *((UInt56*)ptr + 20) = (UInt56)value.x20;
                *((UInt56*)ptr + 21) = (UInt56)value.x21;
                *((UInt56*)ptr + 22) = (UInt56)value.x22;
                *((UInt56*)ptr + 23) = (UInt56)value.x23;
                *((UInt56*)ptr + 24) = (UInt56)value.x24;
                *((UInt56*)ptr + 25) = (UInt56)value.x25;
                *((UInt56*)ptr + 26) = (UInt56)value.x26;
                *((UInt56*)ptr + 27) = (UInt56)value.x27;
                *((UInt56*)ptr + 28) = (UInt56)value.x28;
                *((UInt56*)ptr + 29) = (UInt56)value.x29;
                *((UInt56*)ptr + 30) = (UInt56)value.x30;
                *((UInt56*)ptr + 31) = (UInt56)value.x31;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i8_to24(void* ptr, sbyte16 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi8(value, 7);
                v128 sign0 = shuffle_epi8(sign, new v128(0, 0, 0,   1, 1, 1,   2, 2, 2,   3, 3, 3,   4, 4, 4,   5));
                v128 sign1 = shuffle_epi8(sign, new v128(5, 5,   6, 6, 6,   7, 7, 7,   8, 8, 8,   9, 9, 9,   10, 10));
                v128 sign2 = shuffle_epi8(sign, new v128(10,   11, 11, 11,   12, 12, 12,   13, 13, 13,   14, 14, 14,   15, 15, 15));

                v128 shuf0 = shuffle_epi8(value, new v128(0, -1, -1,   1, -1, -1,   2, -1, -1,   3, -1, -1,   4, -1, -1,   5));
                v128 shuf1 = shuffle_epi8(value, new v128(-1, -1,   6, -1, -1,   7, -1, -1,   8, -1, -1,   9, -1, -1,   10, -1));
                v128 shuf2 = shuffle_epi8(value, new v128(-1,   11, -1, -1,   12, -1, -1,   13, -1, -1,   14, -1, -1,   15, -1, -1));

                shuf0 = blendv_epi8(shuf0, sign0, new v128(0, -1, -1,   1, -1, -1,   2, -1, -1,   3, -1, -1,   4, -1, -1,   5));
                shuf1 = blendv_epi8(shuf1, sign1, new v128(-1, -1,   6, -1, -1,   7, -1, -1,   8, -1, -1,   9, -1, -1,   10, -1));
                shuf2 = blendv_epi8(shuf2, sign2, new v128(-1,   11, -1, -1,   12, -1, -1,   13, -1, -1,   14, -1, -1,   15, -1, -1));

                *((v128*)((sbyte*)ptr + 0))  = shuf0;
                *((v128*)((sbyte*)ptr + 16)) = shuf1;
                *((v128*)((sbyte*)ptr + 32)) = shuf2;
            }
            else
            {
                *((UInt24*)ptr + 0)  = (UInt24)value.x0;
                *((UInt24*)ptr + 1)  = (UInt24)value.x1;
                *((UInt24*)ptr + 2)  = (UInt24)value.x2;
                *((UInt24*)ptr + 3)  = (UInt24)value.x3;
                *((UInt24*)ptr + 4)  = (UInt24)value.x4;
                *((UInt24*)ptr + 5)  = (UInt24)value.x5;
                *((UInt24*)ptr + 6)  = (UInt24)value.x6;
                *((UInt24*)ptr + 7)  = (UInt24)value.x7;
                *((UInt24*)ptr + 8)  = (UInt24)value.x8;
                *((UInt24*)ptr + 9)  = (UInt24)value.x9;
                *((UInt24*)ptr + 10) = (UInt24)value.x10;
                *((UInt24*)ptr + 11) = (UInt24)value.x11;
                *((UInt24*)ptr + 12) = (UInt24)value.x12;
                *((UInt24*)ptr + 13) = (UInt24)value.x13;
                *((UInt24*)ptr + 14) = (UInt24)value.x14;
                *((UInt24*)ptr + 15) = (UInt24)value.x15;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i8_to40(void* ptr, sbyte16 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi8(value, 7);
                v128 sign0 = shuffle_epi8(sign, new v128(0, 0, 0, 0, 0,   1, 1, 1, 1, 1,   2, 2, 2, 2, 2,   3));
                v128 sign1 = shuffle_epi8(sign, new v128(3, 3, 3, 3,   4, 4, 4, 4, 4,   5, 5, 5, 5, 5,   6, 6));
                v128 sign2 = shuffle_epi8(sign, new v128(6, 6, 6,   7, 7, 7, 7, 7,   8, 8, 8, 8, 8,   9, 9, 9));
                v128 sign3 = shuffle_epi8(sign, new v128(9, 9,   10, 10, 10, 10, 10,   11, 11, 11, 11, 11,   12, 12, 12, 12));
                v128 sign4 = shuffle_epi8(sign, new v128(12,   13, 13, 13, 13, 13,   14, 14, 14, 14, 14,   15, 15, 15, 15, 15));

                v128 shuf0 = shuffle_epi8(value, new v128(0, -1, -1, -1, -1,   1, -1, -1, -1, -1,   2, -1, -1, -1, -1,   3));
                v128 shuf1 = shuffle_epi8(value, new v128(-1, -1, -1, -1,   4, -1, -1, -1, -1,   5, -1, -1, -1, -1,   6, -1));
                v128 shuf2 = shuffle_epi8(value, new v128(-1, -1, -1,   7, -1, -1, -1, -1,   8, -1, -1, -1, -1,   9, -1, -1));
                v128 shuf3 = shuffle_epi8(value, new v128(-1, -1,   10, -1, -1, -1, -1,   11, -1, -1, -1, -1,   12, -1, -1, -1));
                v128 shuf4 = shuffle_epi8(value, new v128(-1,   13, -1, -1, -1, -1,   14, -1, -1, -1, -1,   15, -1, -1, -1, -1));

                shuf0 = blendv_epi8(shuf0, sign0, new v128(0, -1, -1, -1, -1,   1, -1, -1, -1, -1,   2, -1, -1, -1, -1,   3));
                shuf1 = blendv_epi8(shuf1, sign1, new v128(-1, -1, -1, -1,   4, -1, -1, -1, -1,   5, -1, -1, -1, -1,   6, -1));
                shuf2 = blendv_epi8(shuf2, sign2, new v128(-1, -1, -1,   7, -1, -1, -1, -1,   8, -1, -1, -1, -1,   9, -1, -1));
                shuf3 = blendv_epi8(shuf3, sign3, new v128(-1, -1,   10, -1, -1, -1, -1,   11, -1, -1, -1, -1,   12, -1, -1, -1));
                shuf4 = blendv_epi8(shuf4, sign4, new v128(-1,   13, -1, -1, -1, -1,   14, -1, -1, -1, -1,   15, -1, -1, -1, -1));
                
                *((v128*)((sbyte*)ptr + 0))  = shuf0;
                *((v128*)((sbyte*)ptr + 16)) = shuf1;
                *((v128*)((sbyte*)ptr + 32)) = shuf2;
                *((v128*)((sbyte*)ptr + 48)) = shuf3;
                *((v128*)((sbyte*)ptr + 64)) = shuf4;
            }
            else
            {
                *((UInt40*)ptr + 0)  = (UInt40)value.x0;
                *((UInt40*)ptr + 1)  = (UInt40)value.x1;
                *((UInt40*)ptr + 2)  = (UInt40)value.x2;
                *((UInt40*)ptr + 3)  = (UInt40)value.x3;
                *((UInt40*)ptr + 4)  = (UInt40)value.x4;
                *((UInt40*)ptr + 5)  = (UInt40)value.x5;
                *((UInt40*)ptr + 6)  = (UInt40)value.x6;
                *((UInt40*)ptr + 7)  = (UInt40)value.x7;
                *((UInt40*)ptr + 8)  = (UInt40)value.x8;
                *((UInt40*)ptr + 9)  = (UInt40)value.x9;
                *((UInt40*)ptr + 10) = (UInt40)value.x10;
                *((UInt40*)ptr + 11) = (UInt40)value.x11;
                *((UInt40*)ptr + 12) = (UInt40)value.x12;
                *((UInt40*)ptr + 13) = (UInt40)value.x13;
                *((UInt40*)ptr + 14) = (UInt40)value.x14;
                *((UInt40*)ptr + 15) = (UInt40)value.x15;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i8_to48(void* ptr, sbyte16 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi8(value, 7);
                v128 sign0 = shuffle_epi8(sign, new v128(0, 0, 0, 0, 0, 0,   1, 1, 1, 1, 1, 1,   2, 2, 2, 2));
                v128 sign1 = shuffle_epi8(sign, new v128(2, 2,   3, 3, 3, 3, 3, 3,   4, 4, 4, 4, 4, 4,   5, 5));
                v128 sign2 = shuffle_epi8(sign, new v128(5, 5, 5, 5,   6, 6, 6, 6, 6, 6,   7, 7, 7, 7, 7, 7));
                v128 sign3 = shuffle_epi8(sign, new v128(8, 8, 8, 8, 8, 8,   9, 9, 9, 9, 9, 9,   10, 10, 10, 10));
                v128 sign4 = shuffle_epi8(sign, new v128(10, 10,   11, 11, 11, 11, 11, 11,   12, 12, 12, 12, 12, 12,   13, 13));
                v128 sign5 = shuffle_epi8(sign, new v128(13, 13, 13, 13,   14, 14, 14, 14, 14, 14,   15, 15, 15, 15, 15, 15));

                v128 shuf0 = shuffle_epi8(value, new v128(0, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1,   2, -1, -1, -1));
                v128 shuf1 = shuffle_epi8(value, new v128(-1, -1,   3, -1, -1, -1, -1, -1,   4, -1, -1, -1, -1, -1,   5, -1));
                v128 shuf2 = shuffle_epi8(value, new v128(-1, -1, -1, -1,   6, -1, -1, -1, -1, -1,   7, -1, -1, -1, -1, -1));
                v128 shuf3 = shuffle_epi8(value, new v128(8, -1, -1, -1, -1, -1,   9, -1, -1, -1, -1, -1,   10, -1, -1, -1));
                v128 shuf4 = shuffle_epi8(value, new v128(-1, -1,   11, -1, -1, -1, -1, -1,   12, -1, -1, -1, -1, -1,   13, -1));
                v128 shuf5 = shuffle_epi8(value, new v128(-1, -1, -1, -1,   14, -1, -1, -1, -1, -1,   15, -1, -1, -1, -1, -1));

                shuf0 = blendv_epi8(shuf0, sign0, new v128(0, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1,   2, -1, -1, -1));
                shuf1 = blendv_epi8(shuf1, sign1, new v128(-1, -1,   3, -1, -1, -1, -1, -1,   4, -1, -1, -1, -1, -1,   5, -1));
                shuf2 = blendv_epi8(shuf2, sign2, new v128(-1, -1, -1, -1,   6, -1, -1, -1, -1, -1,   7, -1, -1, -1, -1, -1));
                shuf3 = blendv_epi8(shuf3, sign3, new v128(8, -1, -1, -1, -1, -1,   9, -1, -1, -1, -1, -1,   10, -1, -1, -1));
                shuf4 = blendv_epi8(shuf4, sign4, new v128(-1, -1,   11, -1, -1, -1, -1, -1,   12, -1, -1, -1, -1, -1,   13, -1));
                shuf5 = blendv_epi8(shuf5, sign5, new v128(-1, -1, -1, -1,   14, -1, -1, -1, -1, -1,   15, -1, -1, -1, -1, -1));
                
                *((v128*)((sbyte*)ptr + 0))  = shuf0;
                *((v128*)((sbyte*)ptr + 16)) = shuf1;
                *((v128*)((sbyte*)ptr + 32)) = shuf2;
                *((v128*)((sbyte*)ptr + 48)) = shuf3;
                *((v128*)((sbyte*)ptr + 64)) = shuf4;
                *((v128*)((sbyte*)ptr + 80)) = shuf5;
            }
            else
            {
                *((UInt48*)ptr + 0)  = (UInt48)value.x0;
                *((UInt48*)ptr + 1)  = (UInt48)value.x1;
                *((UInt48*)ptr + 2)  = (UInt48)value.x2;
                *((UInt48*)ptr + 3)  = (UInt48)value.x3;
                *((UInt48*)ptr + 4)  = (UInt48)value.x4;
                *((UInt48*)ptr + 5)  = (UInt48)value.x5;
                *((UInt48*)ptr + 6)  = (UInt48)value.x6;
                *((UInt48*)ptr + 7)  = (UInt48)value.x7;
                *((UInt48*)ptr + 8)  = (UInt48)value.x8;
                *((UInt48*)ptr + 9)  = (UInt48)value.x9;
                *((UInt48*)ptr + 10) = (UInt48)value.x10;
                *((UInt48*)ptr + 11) = (UInt48)value.x11;
                *((UInt48*)ptr + 12) = (UInt48)value.x12;
                *((UInt48*)ptr + 13) = (UInt48)value.x13;
                *((UInt48*)ptr + 14) = (UInt48)value.x14;
                *((UInt48*)ptr + 15) = (UInt48)value.x15;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i8_to56(void* ptr, sbyte16 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi8(value, 7);
                v128 sign0 = shuffle_epi8(sign, new v128(0, 0, 0, 0, 0, 0, 0,   1, 1, 1, 1, 1, 1, 1,   2, 2));
                v128 sign1 = shuffle_epi8(sign, new v128(2, 2, 2, 2, 2,   3, 3, 3, 3, 3, 3, 3,   4, 4, 4, 4));
                v128 sign2 = shuffle_epi8(sign, new v128(4, 4, 4,   5, 5, 5, 5, 5, 5, 5,   6, 6, 6, 6, 6, 6));
                v128 sign3 = shuffle_epi8(sign, new v128(6,   7, 7, 7, 7, 7, 7, 7,   8, 8, 8, 8, 8, 8, 8,   9));
                v128 sign4 = shuffle_epi8(sign, new v128(9, 9, 9, 9, 9, 9,   10, 10, 10, 10, 10, 10, 10,   11, 11, 11));
                v128 sign5 = shuffle_epi8(sign, new v128(11, 11, 11, 11,   12, 12, 12, 12, 12, 12, 12,   13, 13, 13, 13, 13));
                v128 sign6 = shuffle_epi8(sign, new v128(13, 13,   14, 14, 14, 14, 14, 14, 14,   15, 15, 15, 15, 15, 15, 15));

                v128 shuf0 = shuffle_epi8(value, new v128(0, -1, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1, -1,   2, -1));
                v128 shuf1 = shuffle_epi8(value, new v128(-1, -1, -1, -1, -1,   3, -1, -1, -1, -1, -1, -1,   4, -1, -1, -1));
                v128 shuf2 = shuffle_epi8(value, new v128(-1, -1, -1,   5, -1, -1, -1, -1, -1, -1,   6, -1, -1, -1, -1, -1));
                v128 shuf3 = shuffle_epi8(value, new v128(-1,   7, -1, -1, -1, -1, -1, -1,   8, -1, -1, -1, -1, -1, -1,   9));
                v128 shuf4 = shuffle_epi8(value, new v128(-1, -1, -1, -1, -1, -1,   10, -1, -1, -1, -1, -1, -1,   11, -1, -1));
                v128 shuf5 = shuffle_epi8(value, new v128(-1, -1, -1, -1,   12, -1, -1, -1, -1, -1, -1,   13, -1, -1, -1, -1));
                v128 shuf6 = shuffle_epi8(value, new v128(-1, -1,   14, -1, -1, -1, -1, -1, -1,   15, -1, -1, -1, -1, -1, -1));

                shuf0 = blendv_epi8(shuf0, sign0, new v128(0, -1, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1, -1,   2, -1));
                shuf1 = blendv_epi8(shuf1, sign1, new v128(-1, -1, -1, -1, -1,   3, -1, -1, -1, -1, -1, -1,   4, -1, -1, -1));
                shuf2 = blendv_epi8(shuf2, sign2, new v128(-1, -1, -1,   5, -1, -1, -1, -1, -1, -1,   6, -1, -1, -1, -1, -1));
                shuf3 = blendv_epi8(shuf3, sign3, new v128(-1,   7, -1, -1, -1, -1, -1, -1,   8, -1, -1, -1, -1, -1, -1,   9));
                shuf4 = blendv_epi8(shuf4, sign4, new v128(-1, -1, -1, -1, -1, -1,   10, -1, -1, -1, -1, -1, -1,   11, -1, -1));
                shuf5 = blendv_epi8(shuf5, sign5, new v128(-1, -1, -1, -1,   12, -1, -1, -1, -1, -1, -1,   13, -1, -1, -1, -1));
                shuf6 = blendv_epi8(shuf6, sign6, new v128(-1, -1,   14, -1, -1, -1, -1, -1, -1,   15, -1, -1, -1, -1, -1, -1));
                
                *((v128*)((sbyte*)ptr + 0))  = shuf0;
                *((v128*)((sbyte*)ptr + 16)) = shuf1;
                *((v128*)((sbyte*)ptr + 32)) = shuf2;
                *((v128*)((sbyte*)ptr + 48)) = shuf3;
                *((v128*)((sbyte*)ptr + 64)) = shuf4;
                *((v128*)((sbyte*)ptr + 80)) = shuf5;
                *((v128*)((sbyte*)ptr + 96)) = shuf6;
            }
            else
            {
                *((UInt56*)ptr + 0)  = (UInt56)value.x0;
                *((UInt56*)ptr + 1)  = (UInt56)value.x1;
                *((UInt56*)ptr + 2)  = (UInt56)value.x2;
                *((UInt56*)ptr + 3)  = (UInt56)value.x3;
                *((UInt56*)ptr + 4)  = (UInt56)value.x4;
                *((UInt56*)ptr + 5)  = (UInt56)value.x5;
                *((UInt56*)ptr + 6)  = (UInt56)value.x6;
                *((UInt56*)ptr + 7)  = (UInt56)value.x7;
                *((UInt56*)ptr + 8)  = (UInt56)value.x8;
                *((UInt56*)ptr + 9)  = (UInt56)value.x9;
                *((UInt56*)ptr + 10) = (UInt56)value.x10;
                *((UInt56*)ptr + 11) = (UInt56)value.x11;
                *((UInt56*)ptr + 12) = (UInt56)value.x12;
                *((UInt56*)ptr + 13) = (UInt56)value.x13;
                *((UInt56*)ptr + 14) = (UInt56)value.x14;
                *((UInt56*)ptr + 15) = (UInt56)value.x15;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i8_to24(void* ptr, sbyte8 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi8(value, 7);
                v128 sign0 = shuffle_epi8(sign, new v128(0, 0, 0,   1, 1, 1,   2, 2, 2,   3, 3, 3,   4, 4, 4,   5));
                v128 sign1 = shuffle_epi8(sign, new v128(5, 5,   6, 6, 6,   7, 7, 7,   8, 8, 8,   9, 9, 9,   10, 10));

                v128 shuf0 = shuffle_epi8(value, new v128(0, -1, -1,   1, -1, -1,   2, -1, -1,   3, -1, -1,   4, -1, -1,   5));
                v128 shuf1 = shuffle_epi8(value, new v128(-1, -1,   6, -1, -1,   7, -1, -1,   8, -1, -1,   9, -1, -1,   10, -1));

                shuf0 = blendv_epi8(shuf0, sign0, new v128(0, -1, -1,   1, -1, -1,   2, -1, -1,   3, -1, -1,   4, -1, -1,   5));
                shuf1 = blendv_epi8(shuf1, sign1, new v128(-1, -1,   6, -1, -1,   7, -1, -1,   8, -1, -1,   9, -1, -1,   10, -1));
                
                *((v128*)((sbyte*)ptr + 0))  = shuf0;
                *((long*)((sbyte*)ptr + 16)) = shuf1.SLong0;
            }
            else
            {
                *((UInt24*)ptr + 0)  = (UInt24)value.x0;
                *((UInt24*)ptr + 1)  = (UInt24)value.x1;
                *((UInt24*)ptr + 2)  = (UInt24)value.x2;
                *((UInt24*)ptr + 3)  = (UInt24)value.x3;
                *((UInt24*)ptr + 4)  = (UInt24)value.x4;
                *((UInt24*)ptr + 5)  = (UInt24)value.x5;
                *((UInt24*)ptr + 6)  = (UInt24)value.x6;
                *((UInt24*)ptr + 7)  = (UInt24)value.x7;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i8_to40(void* ptr, sbyte8 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi8(value, 7);
                v128 sign0 = shuffle_epi8(sign, new v128(0, 0, 0, 0, 0,   1, 1, 1, 1, 1,   2, 2, 2, 2, 2,   3));
                v128 sign1 = shuffle_epi8(sign, new v128(3, 3, 3, 3,   4, 4, 4, 4, 4,   5, 5, 5, 5, 5,   6, 6));
                v128 sign2 = shuffle_epi8(sign, new v128(6, 6, 6,   7, 7, 7, 7, 7,   8, 8, 8, 8, 8,   9, 9, 9));

                v128 shuf0 = shuffle_epi8(value, new v128(0, -1, -1, -1, -1,   1, -1, -1, -1, -1,   2, -1, -1, -1, -1,   3));
                v128 shuf1 = shuffle_epi8(value, new v128(-1, -1, -1, -1,   4, -1, -1, -1, -1,   5, -1, -1, -1, -1,   6, -1));
                v128 shuf2 = shuffle_epi8(value, new v128(-1, -1, -1,   7, -1, -1, -1, -1,   8, -1, -1, -1, -1,   9, -1, -1));

                shuf0 = blendv_epi8(shuf0, sign0, new v128(0, -1, -1, -1, -1,   1, -1, -1, -1, -1,   2, -1, -1, -1, -1,   3));
                shuf1 = blendv_epi8(shuf1, sign1, new v128(-1, -1, -1, -1,   4, -1, -1, -1, -1,   5, -1, -1, -1, -1,   6, -1));
                shuf2 = blendv_epi8(shuf2, sign2, new v128(-1, -1, -1,   7, -1, -1, -1, -1,   8, -1, -1, -1, -1,   9, -1, -1));
                
                *((v128*)((sbyte*)ptr + 0))  = shuf0;
                *((v128*)((sbyte*)ptr + 16)) = shuf1;
                *((long*)((sbyte*)ptr + 32)) = shuf2.SLong0;
            }
            else
            {
                *((UInt40*)ptr + 0)  = (UInt40)value.x0;
                *((UInt40*)ptr + 1)  = (UInt40)value.x1;
                *((UInt40*)ptr + 2)  = (UInt40)value.x2;
                *((UInt40*)ptr + 3)  = (UInt40)value.x3;
                *((UInt40*)ptr + 4)  = (UInt40)value.x4;
                *((UInt40*)ptr + 5)  = (UInt40)value.x5;
                *((UInt40*)ptr + 6)  = (UInt40)value.x6;
                *((UInt40*)ptr + 7)  = (UInt40)value.x7;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i8_to48(void* ptr, sbyte8 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi8(value, 7);
                v128 sign0 = shuffle_epi8(sign, new v128(0, 0, 0, 0, 0, 0,   1, 1, 1, 1, 1, 1,   2, 2, 2, 2));
                v128 sign1 = shuffle_epi8(sign, new v128(2, 2,   3, 3, 3, 3, 3, 3,   4, 4, 4, 4, 4, 4,   5, 5));
                v128 sign2 = shuffle_epi8(sign, new v128(5, 5, 5, 5,   6, 6, 6, 6, 6, 6,   7, 7, 7, 7, 7, 7));

                v128 shuf0 = shuffle_epi8(value, new v128(0, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1,   2, -1, -1, -1));
                v128 shuf1 = shuffle_epi8(value, new v128(-1, -1,   3, -1, -1, -1, -1, -1,   4, -1, -1, -1, -1, -1,   5, -1));
                v128 shuf2 = shuffle_epi8(value, new v128(-1, -1, -1, -1,   6, -1, -1, -1, -1, -1,   7, -1, -1, -1, -1, -1));

                shuf0 = blendv_epi8(shuf0, sign0, new v128(0, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1,   2, -1, -1, -1));
                shuf1 = blendv_epi8(shuf1, sign1, new v128(-1, -1,   3, -1, -1, -1, -1, -1,   4, -1, -1, -1, -1, -1,   5, -1));
                shuf2 = blendv_epi8(shuf2, sign2, new v128(-1, -1, -1, -1,   6, -1, -1, -1, -1, -1,   7, -1, -1, -1, -1, -1));

                *((v128*)((sbyte*)ptr + 0))  = shuf0;
                *((v128*)((sbyte*)ptr + 16)) = shuf1;
                *((v128*)((sbyte*)ptr + 32)) = shuf2;
            }
            else
            {
                *((UInt48*)ptr + 0)  = (UInt48)value.x0;
                *((UInt48*)ptr + 1)  = (UInt48)value.x1;
                *((UInt48*)ptr + 2)  = (UInt48)value.x2;
                *((UInt48*)ptr + 3)  = (UInt48)value.x3;
                *((UInt48*)ptr + 4)  = (UInt48)value.x4;
                *((UInt48*)ptr + 5)  = (UInt48)value.x5;
                *((UInt48*)ptr + 6)  = (UInt48)value.x6;
                *((UInt48*)ptr + 7)  = (UInt48)value.x7;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i8_to56(void* ptr, sbyte8 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi8(value, 7);
                v128 sign0 = shuffle_epi8(sign, new v128(0, 0, 0, 0, 0, 0, 0,   1, 1, 1, 1, 1, 1, 1,   2, 2));
                v128 sign1 = shuffle_epi8(sign, new v128(2, 2, 2, 2, 2,   3, 3, 3, 3, 3, 3, 3,   4, 4, 4, 4));
                v128 sign2 = shuffle_epi8(sign, new v128(4, 4, 4,   5, 5, 5, 5, 5, 5, 5,   6, 6, 6, 6, 6, 6));
                v128 sign3 = shuffle_epi8(sign, new v128(6,   7, 7, 7, 7, 7, 7, 7,   8, 8, 8, 8, 8, 8, 8,   9));

                v128 shuf0 = shuffle_epi8(value, new v128(0, -1, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1, -1,   2, -1));
                v128 shuf1 = shuffle_epi8(value, new v128(-1, -1, -1, -1, -1,   3, -1, -1, -1, -1, -1, -1,   4, -1, -1, -1));
                v128 shuf2 = shuffle_epi8(value, new v128(-1, -1, -1,   5, -1, -1, -1, -1, -1, -1,   6, -1, -1, -1, -1, -1));
                v128 shuf3 = shuffle_epi8(value, new v128(-1,   7, -1, -1, -1, -1, -1, -1,   8, -1, -1, -1, -1, -1, -1,   9));

                shuf0 = blendv_epi8(shuf0, sign0, new v128(0, -1, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1, -1,   2, -1));
                shuf1 = blendv_epi8(shuf1, sign1, new v128(-1, -1, -1, -1, -1,   3, -1, -1, -1, -1, -1, -1,   4, -1, -1, -1));
                shuf2 = blendv_epi8(shuf2, sign2, new v128(-1, -1, -1,   5, -1, -1, -1, -1, -1, -1,   6, -1, -1, -1, -1, -1));
                shuf3 = blendv_epi8(shuf3, sign3, new v128(-1,   7, -1, -1, -1, -1, -1, -1,   8, -1, -1, -1, -1, -1, -1,   9));

                *((v128*)((sbyte*)ptr + 0))  = shuf0;
                *((v128*)((sbyte*)ptr + 16)) = shuf1;
                *((v128*)((sbyte*)ptr + 32)) = shuf2;
                *((long*)((sbyte*)ptr + 48)) = shuf3.SLong0;
            }
            else
            {
                *((UInt56*)ptr + 0)  = (UInt56)value.x0;
                *((UInt56*)ptr + 1)  = (UInt56)value.x1;
                *((UInt56*)ptr + 2)  = (UInt56)value.x2;
                *((UInt56*)ptr + 3)  = (UInt56)value.x3;
                *((UInt56*)ptr + 4)  = (UInt56)value.x4;
                *((UInt56*)ptr + 5)  = (UInt56)value.x5;
                *((UInt56*)ptr + 6)  = (UInt56)value.x6;
                *((UInt56*)ptr + 7)  = (UInt56)value.x7;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i8_to24(void* ptr, sbyte4 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi8(value, 7);
                sign = shuffle_epi8(sign, new v128(0, 0, 0,   1, 1, 1,   2, 2, 2,   3, 3, 3,   4, 4, 4,   5));

                v128 shuf = shuffle_epi8(value, new v128(0, -1, -1,   1, -1, -1,   2, -1, -1,   3, -1, -1,   4, -1, -1,   5));

                shuf = blendv_epi8(shuf, sign, new v128(0, -1, -1,   1, -1, -1,   2, -1, -1,   3, -1, -1,   4, -1, -1,   5));

                *((long*)((sbyte*)ptr + 0)) = shuf.SLong0;
                *((int*) ((sbyte*)ptr + 8)) = shuf.SInt2;
            }
            else
            {
                *((UInt24*)ptr + 0) = (UInt24)value.x;
                *((UInt24*)ptr + 1) = (UInt24)value.y;
                *((UInt24*)ptr + 2) = (UInt24)value.z;
                *((UInt24*)ptr + 3) = (UInt24)value.w;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i8_to40(void* ptr, sbyte4 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi8(value, 7);
                v128 sign0 = shuffle_epi8(sign, new v128(0, 0, 0, 0, 0,   1, 1, 1, 1, 1,   2, 2, 2, 2, 2,   3));
                v128 sign1 = shuffle_epi8(sign, new v128(3, 3, 3, 3,   4, 4, 4, 4, 4,   5, 5, 5, 5, 5,   6, 6));

                v128 shuf0 = shuffle_epi8(value, new v128(0, -1, -1, -1, -1,   1, -1, -1, -1, -1,   2, -1, -1, -1, -1,   3));
                v128 shuf1 = shuffle_epi8(value, new v128(-1, -1, -1, -1,   4, -1, -1, -1, -1,   5, -1, -1, -1, -1,   6, -1));

                shuf0 = blendv_epi8(shuf0, sign0, new v128(0, -1, -1, -1, -1,   1, -1, -1, -1, -1,   2, -1, -1, -1, -1,   3));
                shuf1 = blendv_epi8(shuf1, sign1, new v128(-1, -1, -1, -1,   4, -1, -1, -1, -1,   5, -1, -1, -1, -1,   6, -1));

                *((v128*)((sbyte*)ptr + 0))  = shuf0;
                *((int*) ((sbyte*)ptr + 16)) = shuf1.SInt0;
            }
            else
            {
                *((UInt40*)ptr + 0) = (UInt40)value.x;
                *((UInt40*)ptr + 1) = (UInt40)value.y;
                *((UInt40*)ptr + 2) = (UInt40)value.z;
                *((UInt40*)ptr + 3) = (UInt40)value.w;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i8_to48(void* ptr, sbyte4 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi8(value, 7);
                v128 sign0 = shuffle_epi8(sign, new v128(0, 0, 0, 0, 0, 0,   1, 1, 1, 1, 1, 1,   2, 2, 2, 2));
                v128 sign1 = shuffle_epi8(sign, new v128(2, 2,   3, 3, 3, 3, 3, 3,   4, 4, 4, 4, 4, 4,   5, 5));

                v128 shuf0 = shuffle_epi8(value, new v128(0, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1,   2, -1, -1, -1));
                v128 shuf1 = shuffle_epi8(value, new v128(-1, -1,   3, -1, -1, -1, -1, -1,   4, -1, -1, -1, -1, -1,   5, -1));

                shuf0 = blendv_epi8(shuf0, sign0, new v128(0, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1,   2, -1, -1, -1));
                shuf1 = blendv_epi8(shuf1, sign1, new v128(-1, -1,   3, -1, -1, -1, -1, -1,   4, -1, -1, -1, -1, -1,   5, -1));

                *((v128*)((sbyte*)ptr + 0))  = shuf0;
                *((long*)((sbyte*)ptr + 16)) = shuf1.SLong0;
            }
            else
            {
                *((UInt48*)ptr + 0) = (UInt48)value.x;
                *((UInt48*)ptr + 1) = (UInt48)value.y;
                *((UInt48*)ptr + 2) = (UInt48)value.z;
                *((UInt48*)ptr + 3) = (UInt48)value.w;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i8_to56(void* ptr, sbyte4 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi8(value, 7);
                v128 sign0 = shuffle_epi8(sign, new v128(0, 0, 0, 0, 0, 0, 0,   1, 1, 1, 1, 1, 1, 1,   2, 2));
                v128 sign1 = shuffle_epi8(sign, new v128(2, 2, 2, 2, 2,   3, 3, 3, 3, 3, 3, 3,   4, 4, 4, 4));

                v128 shuf0 = shuffle_epi8(value, new v128(0, -1, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1, -1,   2, -1));
                v128 shuf1 = shuffle_epi8(value, new v128(-1, -1, -1, -1, -1,   3, -1, -1, -1, -1, -1, -1,   4, -1, -1, -1));

                shuf0 = blendv_epi8(shuf0, sign0, new v128(0, -1, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1, -1,   2, -1));
                shuf1 = blendv_epi8(shuf1, sign1, new v128(-1, -1, -1, -1, -1,   3, -1, -1, -1, -1, -1, -1,   4, -1, -1, -1));

                *((v128*)((sbyte*)ptr + 0))  = shuf0;
                *((long*)((sbyte*)ptr + 16)) = shuf1.SLong0;
                *((int*) ((sbyte*)ptr + 24)) = sign1.SInt2;
            }
            else
            {
                *((UInt56*)ptr + 0) = (UInt56)value.x;
                *((UInt56*)ptr + 1) = (UInt56)value.y;
                *((UInt56*)ptr + 2) = (UInt56)value.z;
                *((UInt56*)ptr + 3) = (UInt56)value.w;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i8_to24(void* ptr, sbyte3 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi8(value, 7);
                sign = shuffle_epi8(sign, new v128(0, 0, 0,   1, 1, 1,   2, 2, 2,   3, 3, 3,   4, 4, 4,   5));

                v128 shuf = shuffle_epi8(value, new v128(0, -1, -1,   1, -1, -1,   2, -1, -1,   3, -1, -1,   4, -1, -1,   5));

                shuf = blendv_epi8(shuf, sign, new v128(0, -1, -1,   1, -1, -1,   2, -1, -1,   3, -1, -1,   4, -1, -1,   5));

                *((long*) ((sbyte*)ptr + 0)) = shuf.SLong0;
                *((sbyte*)((sbyte*)ptr + 8)) = shuf.SByte8;
            }
            else
            {
                *((UInt24*)ptr + 0) = (UInt24)value.x;
                *((UInt24*)ptr + 1) = (UInt24)value.y;
                *((UInt24*)ptr + 2) = (UInt24)value.z;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i8_to40(void* ptr, sbyte3 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi8(value, 7);
                sign = shuffle_epi8(sign, new v128(0, 0, 0, 0, 0,   1, 1, 1, 1, 1,   2, 2, 2, 2, 2,   3));

                v128 shuf = shuffle_epi8(value, new v128(0, -1, -1, -1, -1,   1, -1, -1, -1, -1,   2, -1, -1, -1, -1,   3));

                shuf = blendv_epi8(shuf, sign, new v128(0, -1, -1, -1, -1,   1, -1, -1, -1, -1,   2, -1, -1, -1, -1,   3));

                *((long*) ((sbyte*)ptr + 0))  = shuf.SLong0;
                *((int*)  ((sbyte*)ptr + 8))  = shuf.SInt2;
                *((short*)((sbyte*)ptr + 12)) = shuf.SShort6;
                *((sbyte*)((sbyte*)ptr + 14)) = shuf.SByte14;
            }
            else
            {
                *((UInt40*)ptr + 0) = (UInt40)value.x;
                *((UInt40*)ptr + 1) = (UInt40)value.y;
                *((UInt40*)ptr + 2) = (UInt40)value.z;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i8_to48(void* ptr, sbyte3 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi8(value, 7);
                sign = shuffle_epi8(sign, new v128(0, 0, 0, 0, 0, 0,   1, 1, 1, 1, 1, 1,   2, 2, 2, 2));

                v128 shuf = shuffle_epi8(value, new v128(0, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1,   2, -1, -1, -1));

                shuf = blendv_epi8(shuf, sign, new v128(0, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1,   2, -1, -1, -1));

                *((v128*) ((sbyte*)ptr + 0))  = shuf;
                *((short*)((sbyte*)ptr + 16)) = sign.SShort7;
            }
            else
            {
                *((UInt48*)ptr + 0) = (UInt48)value.x;
                *((UInt48*)ptr + 1) = (UInt48)value.y;
                *((UInt48*)ptr + 2) = (UInt48)value.z;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i8_to56(void* ptr, sbyte3 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi8(value, 7);
                sign = shuffle_epi8(sign, new v128(0, 0, 0, 0, 0, 0, 0,   1, 1, 1, 1, 1, 1, 1,   2, 2));

                v128 shuf = shuffle_epi8(value, new v128(0, -1, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1, -1,   2, -1));

                shuf = blendv_epi8(shuf, sign, new v128(0, -1, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1, -1,   2, -1));

                *((v128*) ((sbyte*)ptr + 0))  = shuf;
                *((short*)((sbyte*)ptr + 16)) = sign.SShort7;
                *((short*)((sbyte*)ptr + 18)) = sign.SShort7;
                *((sbyte*)((sbyte*)ptr + 20)) = sign.SByte15;
            }
            else
            {
                *((UInt56*)ptr + 0) = (UInt56)value.x;
                *((UInt56*)ptr + 1) = (UInt56)value.y;
                *((UInt56*)ptr + 2) = (UInt56)value.z;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i8_to24(void* ptr, sbyte2 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi8(value, 7);
                sign = shuffle_epi8(sign, new v128(0, 0, 0,   1, 1, 1,   2, 2, 2,   3, 3, 3,   4, 4, 4,   5));

                v128 shuf = shuffle_epi8(value, new v128(0, -1, -1,   1, -1, -1,   2, -1, -1,   3, -1, -1,   4, -1, -1,   5));

                shuf = blendv_epi8(shuf, sign, new v128(0, -1, -1,   1, -1, -1,   2, -1, -1,   3, -1, -1,   4, -1, -1,   5));

                *((int*)  ((sbyte*)ptr + 0)) = shuf.SInt0;
                *((short*)((sbyte*)ptr + 4)) = shuf.SShort2;
            }
            else
            {
                *((UInt24*)ptr + 0) = (UInt24)value.x;
                *((UInt24*)ptr + 1) = (UInt24)value.y;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i8_to40(void* ptr, sbyte2 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi8(value, 7);
                sign = shuffle_epi8(sign, new v128(0, 0, 0, 0, 0,   1, 1, 1, 1, 1,   2, 2, 2, 2, 2,   3));

                v128 shuf = shuffle_epi8(value, new v128(0, -1, -1, -1, -1,   1, -1, -1, -1, -1,   2, -1, -1, -1, -1,   3));

                shuf = blendv_epi8(shuf, sign, new v128(0, -1, -1, -1, -1,   1, -1, -1, -1, -1,   2, -1, -1, -1, -1,   3));

                *((long*) ((sbyte*)ptr + 0)) = shuf.SLong0;
                *((short*)((sbyte*)ptr + 8)) = sign.SShort3;
            }
            else
            {
                *((UInt40*)ptr + 0) = (UInt40)value.x;
                *((UInt40*)ptr + 1) = (UInt40)value.y;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i8_to48(void* ptr, sbyte2 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi8(value, 7);
                sign = shuffle_epi8(sign, new v128(0, 0, 0, 0, 0, 0,   1, 1, 1, 1, 1, 1,   2, 2, 2, 2));

                v128 shuf = shuffle_epi8(value, new v128(0, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1,   2, -1, -1, -1));

                shuf = blendv_epi8(shuf, sign, new v128(0, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1,   2, -1, -1, -1));

                *((long*)((sbyte*)ptr + 0)) = shuf.SLong0;
                *((int*) ((sbyte*)ptr + 8)) = sign.SInt2;
            }
            else
            {
                *((UInt48*)ptr + 0) = (UInt48)value.x;
                *((UInt48*)ptr + 1) = (UInt48)value.y;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Store_i8_to56(void* ptr, sbyte2 value)
        {
            if (BurstArchitecture.IsTableLookupSupported)
            {
                v128 sign = srai_epi8(value, 7);
                sign = shuffle_epi8(sign, new v128(0, 0, 0, 0, 0, 0, 0,   1, 1, 1, 1, 1, 1, 1,   2, 2));

                v128 shuf = shuffle_epi8(value, new v128(0, -1, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1, -1,   2, -1));

                shuf = blendv_epi8(shuf, sign, new v128(0, -1, -1, -1, -1, -1, -1,   1, -1, -1, -1, -1, -1, -1,   2, -1));

                *((long*) ((sbyte*)ptr + 0))  = shuf.SLong0;
                *((int*)  ((sbyte*)ptr + 8))  = shuf.SInt2;
                *((short*)((sbyte*)ptr + 12)) = sign.SShort6;
            }
            else
            {
                *((UInt56*)ptr + 0) = (UInt56)value.x;
                *((UInt56*)ptr + 1) = (UInt56)value.y;
            }
        }
    }
}
