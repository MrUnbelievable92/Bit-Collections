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
using System.Numerics;
using System.Runtime.InteropServices;

namespace BitCollections
{
    [Serializable]
    unsafe public struct bit64 : IArray<bool>, IEquatable<bit64>
    {
        internal ulong intern;
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(ulong value)
        {
            intern = value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(long value)
        {
            intern = (ulong)value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bool value)
        {
            intern = (ulong)(-(long)maxmath.toulong(value));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bool x0, bool x1, bool x2, bool x3, bool x4, bool x5, bool x6, bool x7, bool x8, bool x9, bool x10, bool x11, bool x12, bool x13, bool x14, bool x15, bool x16, bool x17, bool x18, bool x19, bool x20, bool x21, bool x22, bool x23, bool x24, bool x25, bool x26, bool x27, bool x28, bool x29, bool x30, bool x31, bool x32, bool x33, bool x34, bool x35, bool x36, bool x37, bool x38, bool x39, bool x40, bool x41, bool x42, bool x43, bool x44, bool x45, bool x46, bool x47, bool x48, bool x49, bool x50, bool x51, bool x52, bool x53, bool x54, bool x55, bool x56, bool x57, bool x58, bool x59, bool x60, bool x61, bool x62, bool x63)
        {
            intern = (ulong)new bit32(x0, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16, x17, x18, x19, x20, x21, x22, x23, x24, x25, x26, x27, x28, x29, x30, x31).intern 
                     | 
                     ((ulong)new bit32(x32, x33, x34, x35, x36, x37, x38, x39, x40, x41, x42, x43, x44, x45, x46, x47, x48, x49, x50, x51, x52, x53, x54, x55, x56, x57, x58, x59, x60, x61, x62, x63).intern << 32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit8 x16_23, bit8 x24_31, bit8 x32_39, bit8 x40_47, bit8 x48_55, bit8 x56_63)
        {
            intern = maxmath.csum(maxmath.shl(new ulong4(x0_7.intern, x8_15.intern, x16_23.intern, x24_31.intern),
                                              new ulong4(0L,          8L,           16L,           24L))
                                  |

                                  maxmath.shl(new ulong4(x32_39.intern, x40_47.intern, x48_55.intern, x56_63.intern),
                                              new ulong4(32L,           40L,           48L,           56L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit8 x16_23, bit8 x24_31, bit8 x32_39, bit8 x40_47, bit8 x48_55, bit8 x56_63)
        {
            intern = maxmath.csum(maxmath.shl(new ulong4(0L,          x0_15.intern, x16_23.intern, x24_31.intern),
                                              new ulong4(0L,          0L,           16L,           24L))
                                  |

                                  maxmath.shl(new ulong4(x32_39.intern, x40_47.intern, x48_55.intern, x56_63.intern),
                                              new ulong4(32L,           40L,           48L,           56L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit16 x8_23, bit8 x24_31, bit8 x32_39, bit8 x40_47, bit8 x48_55, bit8 x56_63)
        {
            intern = maxmath.csum(maxmath.shl(new ulong4(0L,          x0_7.intern, x8_23.intern, x24_31.intern),
                                              new ulong4(0L,          0L,          8L,           24L))
                                  |

                                  maxmath.shl(new ulong4(x32_39.intern, x40_47.intern, x48_55.intern, x56_63.intern),
                                              new ulong4(32L,           40L,           48L,           56L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit16 x16_31, bit8 x32_39, bit8 x40_47, bit8 x48_55, bit8 x56_63)
        {
            intern = maxmath.csum(maxmath.shl(new ulong4(0L,          x0_7.intern, x8_15.intern, x16_31.intern),
                                              new ulong4(0L,          0L,          8L,           16L))
                                  |

                                  maxmath.shl(new ulong4(x32_39.intern, x40_47.intern, x48_55.intern, x56_63.intern),
                                              new ulong4(32L,           40L,           48L,           56L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit8 x16_23, bit16 x24_39, bit8 x40_47, bit8 x48_55, bit8 x56_63)
        {
            intern = maxmath.csum(maxmath.shl(new ulong4(0L,          x0_7.intern, x8_15.intern, x16_23.intern),
                                              new ulong4(0L,          0L,          8L,           16L))
                                  |

                                  maxmath.shl(new ulong4(x24_39.intern, x40_47.intern, x48_55.intern, x56_63.intern),
                                              new ulong4(24L,           40L,           48L,           56L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit8 x16_23, bit8 x24_31, bit16 x32_47, bit8 x48_55, bit8 x56_63)
        {
            intern = maxmath.csum(maxmath.shl(new ulong4(x0_7.intern, x8_15.intern, x16_23.intern, x24_31.intern),
                                              new ulong4(0L,          8L,           16L,           24L))
                                  |

                                  maxmath.shl(new ulong4(0L,          x32_47.intern, x48_55.intern, x56_63.intern),
                                              new ulong4(0L,          32L,           48L,           56L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit8 x16_23, bit8 x24_31, bit8 x32_39, bit16 x40_55, bit8 x56_63)
        {
            intern = maxmath.csum(maxmath.shl(new ulong4(x0_7.intern, x8_15.intern, x16_23.intern, x24_31.intern),
                                              new ulong4(0L,          8L,           16L,           24L))
                                  |

                                  maxmath.shl(new ulong4(0L,          x32_39.intern, x40_55.intern, x56_63.intern),
                                              new ulong4(0L,          32L,           40L,           56L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit8 x16_23, bit8 x24_31, bit8 x32_39, bit8 x40_47, bit16 x48_63)
        {
            intern = maxmath.csum(maxmath.shl(new ulong4(x0_7.intern, x8_15.intern, x16_23.intern, x24_31.intern),
                                              new ulong4(0L,          8L,           16L,           24L))
                                  |

                                  maxmath.shl(new ulong4(0L,          x32_39.intern, x40_47.intern, x48_63.intern),
                                              new ulong4(0L,          32L,           40L,           48L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit16 x16_31, bit8 x32_39, bit8 x40_47, bit8 x48_55, bit8 x56_63)
        {
            intern = ((ulong)x0_15.intern | ((ulong)x16_31.intern << 16))
                     |
                     maxmath.csum(maxmath.shl(new ulong4(x32_39.intern, x40_47.intern, x48_55.intern, x56_63.intern),
                                              new ulong4(32L,           40L,           48L,           56L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit8 x16_23, bit16 x24_39, bit8 x40_47, bit8 x48_55, bit8 x56_63)
        {
            intern = ((ulong)x0_15.intern | ((ulong)x16_23.intern << 16))
                     |
                     maxmath.csum(maxmath.shl(new ulong4(x24_39.intern, x40_47.intern, x48_55.intern, x56_63.intern),
                                              new ulong4(24L,           40L,           48L,           56L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit8 x16_23, bit8 x24_31, bit16 x32_47, bit8 x48_55, bit8 x56_63)
        {
            intern = ((ulong)x0_15.intern | ((ulong)x16_23.intern << 16))
                     |
                     maxmath.csum(maxmath.shl(new ulong4(x24_31.intern, x32_47.intern, x48_55.intern, x56_63.intern),
                                              new ulong4(24L,           32L,           48L,           56L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit8 x16_23, bit8 x24_31, bit8 x32_39, bit16 x40_55, bit8 x56_63)
        {
            intern = ((ulong)x0_15.intern | ((ulong)x16_23.intern << 16))
                     |
                     maxmath.csum(maxmath.shl(new ulong4(x24_31.intern, x32_39.intern, x40_55.intern, x56_63.intern),
                                              new ulong4(24L,           32L,           40L,           56L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit8 x16_23, bit8 x24_31, bit8 x32_39, bit8 x40_47, bit16 x48_63)
        {
            intern = ((ulong)x0_15.intern | ((ulong)x16_23.intern << 16))
                     |
                     maxmath.csum(maxmath.shl(new ulong4(x24_31.intern, x32_39.intern, x40_47.intern, x48_63.intern),
                                              new ulong4(24L,           32L,           40L,           48L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit16 x8_23, bit16 x24_39, bit8 x40_47, bit8 x48_55, bit8 x56_63)
        {
            intern = ((ulong)x0_7.intern | ((ulong)x8_23.intern << 8))
                     |
                     maxmath.csum(maxmath.shl(new ulong4(x24_39.intern, x40_47.intern, x48_55.intern, x56_63.intern),
                                              new ulong4(24L,           40L,           48L,           56L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit16 x8_23, bit8 x24_31, bit16 x32_47, bit8 x48_55, bit8 x56_63)
        {
            intern = ((ulong)x0_7.intern | ((ulong)x8_23.intern << 8))
                     |
                     maxmath.csum(maxmath.shl(new ulong4(x24_31.intern, x32_47.intern, x48_55.intern, x56_63.intern),
                                              new ulong4(24L,           32L,           48L,           56L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit16 x8_23, bit8 x24_31, bit8 x32_39, bit16 x40_55, bit8 x56_63)
        {
            intern = ((ulong)x0_7.intern | ((ulong)x8_23.intern << 8))
                     |
                     maxmath.csum(maxmath.shl(new ulong4(x24_31.intern, x32_39.intern, x40_55.intern, x56_63.intern),
                                              new ulong4(24L,           32L,           40L,           56L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit16 x8_23, bit8 x24_31, bit8 x32_39, bit8 x40_47, bit16 x48_63)
        {
            intern = ((ulong)x0_7.intern | ((ulong)x8_23.intern << 8))
                     | 
                     maxmath.csum(maxmath.shl(new ulong4(x24_31.intern, x32_39.intern, x40_47.intern, x48_63.intern),
                                              new ulong4(24L,           32L,           40L,           48L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit16 x16_31, bit16 x32_47, bit8 x48_55, bit8 x56_63)
        {
            intern = ((ulong)x0_7.intern | ((ulong)x8_15.intern << 8))
                     |
                     maxmath.csum(maxmath.shl(new ulong4(x16_31.intern, x32_47.intern, x48_55.intern, x56_63.intern),
                                              new ulong4(16L,           32L,           48L,           56L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit16 x16_31, bit8 x32_39, bit16 x40_55, bit8 x56_63)
        {
            intern = ((ulong)x0_7.intern | ((ulong)x8_15.intern << 8))
                     |
                     maxmath.csum(maxmath.shl(new ulong4(x16_31.intern, x32_39.intern, x40_55.intern, x56_63.intern),
                                              new ulong4(16L,           32L,           40L,           56L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit16 x16_31, bit8 x32_39, bit8 x40_47, bit16 x48_63)
        {
            intern = ((ulong)x0_7.intern | ((ulong)x8_15.intern << 8))
                     |
                     maxmath.csum(maxmath.shl(new ulong4(x16_31.intern, x32_39.intern, x40_47.intern, x48_63.intern),
                                              new ulong4(16L,           32L,           40L,           48L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit8 x16_23, bit16 x24_39, bit16 x40_55, bit8 x56_63)
        {
            intern = ((ulong)x0_7.intern | ((ulong)x8_15.intern << 8))
                     |
                     maxmath.csum(maxmath.shl(new ulong4(x16_23.intern, x24_39.intern, x40_55.intern, x56_63.intern),
                                              new ulong4(16L,           24L,           40L,           56L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit8 x16_23, bit16 x24_39, bit8 x40_47, bit16 x48_63)
        {
            intern = ((ulong)x0_7.intern | ((ulong)x8_15.intern << 8))
                     |
                     maxmath.csum(maxmath.shl(new ulong4(x16_23.intern, x24_39.intern, x40_47.intern, x48_63.intern),
                                              new ulong4(16L,           24L,           40L,           48L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit8 x16_23, bit8 x24_31, bit16 x32_47, bit16 x48_63)
        {
            intern = ((ulong)x0_7.intern | ((ulong)x8_15.intern << 8))
                     |
                     maxmath.csum(maxmath.shl(new ulong4(x16_23.intern, x24_31.intern, x32_47.intern, x48_63.intern),
                                              new ulong4(16L,           24L,           32L,           48L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit16 x16_31, bit16 x32_47, bit8 x48_55, bit8 x56_63)
        {
            intern = (ulong)x0_15.intern
                     |
                     maxmath.csum(maxmath.shl(new ulong4(x16_31.intern, x32_47.intern, x48_55.intern, x56_63.intern),
                                              new ulong4(16L,           32L,           48L,           56L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit16 x16_31, bit8 x32_39, bit16 x40_55, bit8 x56_63)
        {
            intern = (ulong)x0_15.intern
                     |
                     maxmath.csum(maxmath.shl(new ulong4(x16_31.intern, x32_39.intern, x40_55.intern, x56_63.intern),
                                              new ulong4(16L,           32L,           40L,           56L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit16 x16_31, bit8 x32_39, bit8 x40_47, bit16 x48_63)
        {
            intern = (ulong)x0_15.intern
                     |
                     maxmath.csum(maxmath.shl(new ulong4(x16_31.intern, x32_39.intern, x40_47.intern, x48_63.intern),
                                              new ulong4(16L,           32L,           40L,           48L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit8 x16_23, bit16 x24_39, bit16 x40_55, bit8 x56_63)
        {
            intern = (ulong)x0_15.intern
                     |
                     maxmath.csum(maxmath.shl(new ulong4(x16_23.intern, x24_39.intern, x40_55.intern, x56_63.intern),
                                              new ulong4(16L,           24L,           40L,           56L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit8 x16_23, bit16 x24_39, bit8 x40_47, bit16 x48_63)
        {
            intern = (ulong)x0_15.intern
                     |
                     maxmath.csum(maxmath.shl(new ulong4(x16_23.intern, x24_39.intern, x40_47.intern, x48_63.intern),
                                              new ulong4(16L,           24L,           40L,           48L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit8 x16_23, bit8 x24_31, bit16 x32_47, bit16 x48_63)
        {
            intern = (ulong)x0_15.intern
                     |
                     maxmath.csum(maxmath.shl(new ulong4(x16_23.intern, x24_31.intern, x32_47.intern, x48_63.intern),
                                              new ulong4(16L,           24L,           32L,           48L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit16 x8_23, bit16 x24_39, bit16 x40_55, bit8 x56_63)
        {
            intern = (ulong)x0_7.intern
                     |
                     maxmath.csum(maxmath.shl(new ulong4(x8_23.intern, x24_39.intern, x40_55.intern, x56_63.intern),
                                              new ulong4(8L,           24L,           40L,           56L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit16 x8_23, bit16 x24_39, bit8 x40_47, bit16 x48_63)
        {
            intern = (ulong)x0_7.intern
                     |
                     maxmath.csum(maxmath.shl(new ulong4(x8_23.intern, x24_39.intern, x40_47.intern, x48_63.intern),
                                              new ulong4(8L,           24L,           40L,           48L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit16 x8_23, bit8 x24_31, bit16 x32_47, bit16 x48_63)
        {
            intern = (ulong)x0_7.intern
                     |
                     maxmath.csum(maxmath.shl(new ulong4(x8_23.intern, x24_31.intern, x32_47.intern, x48_63.intern),
                                              new ulong4(8L,           24L,           32L,           48L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit16 x16_31, bit16 x32_47, bit16 x48_63)
        {
            intern = (ulong)x0_7.intern
                     |
                     maxmath.csum(maxmath.shl(new ulong4(x8_15.intern, x16_31.intern, x32_47.intern, x48_63.intern),
                                              new ulong4(8L,           16L,           32L,           48L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit32 x0_31, bit8 x32_39, bit8 x40_47, bit8 x48_55, bit8 x56_63)
        {
            intern = (ulong)x0_31.intern
                     |
                     maxmath.csum(maxmath.shl(new ulong4(x32_39.intern, x40_47.intern, x48_55.intern, x56_63.intern),
                                              new ulong4(32L,           40L,           48L,           56L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit32 x8_39, bit8 x40_47, bit8 x48_55, bit8 x56_63)
        {
            intern = (ulong)x0_7.intern
                     |
                     maxmath.csum(maxmath.shl(new ulong4(x8_39.intern, x40_47.intern, x48_55.intern, x56_63.intern),
                                              new ulong4(8L,           40L,           48L,           56L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit32 x16_47, bit8 x48_55, bit8 x56_63)
        {
            intern = (ulong)x0_7.intern
                     |
                     maxmath.csum(maxmath.shl(new ulong4(x8_15.intern, x16_47.intern, x48_55.intern, x56_63.intern),
                                              new ulong4(8L,           16L,           48L,           56L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit8 x16_23, bit32 x24_55, bit8 x56_63)
        {
            intern = (ulong)x0_7.intern
                     |
                     maxmath.csum(maxmath.shl(new ulong4(x8_15.intern, x16_23.intern, x24_55.intern, x56_63.intern),
                                              new ulong4(8L,           16L,           24L,           56L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit8 x16_23, bit8 x24_31, bit32 x32_63)
        {
            intern = (ulong)x0_7.intern
                     |
                     maxmath.csum(maxmath.shl(new ulong4(x8_15.intern, x16_23.intern, x24_31.intern, x32_63.intern),
                                              new ulong4(8L,           16L,           24L,           32L)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit32 x0_31, bit16 x32_47, bit8 x48_55, bit8 x56_63)
        {
            intern = ((ulong)x0_31.intern | ((ulong)x32_47.intern << 32)) | (((ulong)x48_55.intern << 48) | ((ulong)x56_63.intern << 56));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit32 x0_31, bit8 x32_39, bit16 x40_55, bit8 x56_63)
        {
            intern = ((ulong)x0_31.intern | ((ulong)x32_39.intern << 32)) | (((ulong)x40_55.intern << 40) | ((ulong)x56_63.intern << 56));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit32 x0_31, bit8 x32_39, bit8 x40_47, bit16 x48_63)
        {
            intern = ((ulong)x0_31.intern | ((ulong)x32_39.intern << 32)) | (((ulong)x40_47.intern << 40) | ((ulong)x48_63.intern << 48));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit32 x8_39, bit16 x40_55, bit8 x56_63)
        {
            intern = ((ulong)x0_7.intern | ((ulong)x8_39.intern << 8)) | (((ulong)x40_55.intern << 40) | ((ulong)x56_63.intern << 56));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit32 x8_39, bit8 x40_47, bit16 x48_63)
        {
            intern = ((ulong)x0_7.intern | ((ulong)x8_39.intern << 8)) | (((ulong)x40_47.intern << 40) | ((ulong)x48_63.intern << 48));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit32 x16_47, bit16 x48_63)
        {
            intern = ((ulong)x0_7.intern | ((ulong)x8_15.intern << 8)) | (((ulong)x16_47.intern << 16) | ((ulong)x48_63.intern << 48));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit32 x16_47, bit8 x48_55, bit8 x56_63)
        {
            intern = ((ulong)x0_15.intern | ((ulong)x16_47.intern << 16)) | (((ulong)x48_55.intern << 48) | ((ulong)x56_63.intern << 56));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit8 x16_23, bit32 x24_55, bit8 x56_63)
        {
            intern = ((ulong)x0_15.intern | ((ulong)x16_23.intern << 16)) | (((ulong)x24_55.intern << 24) | ((ulong)x56_63.intern << 56));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit8 x16_23, bit8 x24_31, bit32 x32_63)
        {
            intern = ((ulong)x0_15.intern | ((ulong)x16_23.intern << 16)) | (((ulong)x24_31.intern << 24) | ((ulong)x32_63.intern << 32));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit16 x8_23, bit32 x24_55, bit8 x56_63)
        {
            intern = ((ulong)x0_7.intern | ((ulong)x8_23.intern << 8)) | (((ulong)x24_55.intern << 24) | ((ulong)x56_63.intern << 56));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit16 x8_23, bit8 x24_31, bit32 x32_63)
        {
            intern = ((ulong)x0_7.intern | ((ulong)x8_23.intern << 8)) | (((ulong)x24_31.intern << 24) | ((ulong)x32_63.intern << 32));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit16 x16_31, bit32 x32_63)
        {
            intern = ((ulong)x0_7.intern | ((ulong)x8_15.intern << 8)) | (((ulong)x16_31.intern << 16) | ((ulong)x32_63.intern << 32));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit16 x16_31, bit16 x32_47, bit16 x48_63)
        {
            intern = ((ulong)x0_15.intern | ((ulong)x16_31.intern << 16)) | (((ulong)x32_47.intern << 32) | ((ulong)x48_63.intern << 48));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit32 x0_31, bit16 x32_47, bit16 x48_63)
        {
            intern = ((ulong)x0_31.intern | ((ulong)x32_47.intern << 32)) | ((ulong)x48_63.intern << 48);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit32 x16_47, bit16 x48_63)
        {
            intern = ((ulong)x0_15.intern | ((ulong)x16_47.intern << 16)) | ((ulong)x48_63.intern << 48);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit16 x16_31, bit32 x32_63)
        {
            intern = ((ulong)x0_15.intern | ((ulong)x16_31.intern << 16)) | ((ulong)x32_63.intern << 32);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit32 x0_31, bit32 x32_63)
        {
            intern = x0_31.intern | ((ulong)x32_63.intern << 32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bool[] values, int index = 0)
        {
Assert.IsValidSubarray(index, new bit64().Length, values.Length);

            intern = 0;

            for (int i = 0; i < 64; i++, index++)
            {
                this[i] = values[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(NativeArray<bool> values, int index = 0)
        {
Assert.IsValidSubarray(index, new bit64().Length, values.Length);

            bool* ptr = (bool*)values.GetUnsafeReadOnlyPtr() + index;

            intern = (ulong)(maxmath.bitmask(*(bool32*)ptr)
                             | 
                             (maxmath.bitmask(*((bool32*)ptr + 1)) << 32));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(NativeList<bool> values, int index = 0)
        {
Assert.IsValidSubarray(index, new bit64().Length, values.Length);

            bool* ptr = (bool*)values.GetUnsafeReadOnlyPtr() + index;

            intern = (ulong)(maxmath.bitmask(*(bool32*)ptr)
                             | 
                             (maxmath.bitmask(*((bool32*)ptr + 1)) << 32));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(NativeSlice<bool> values, int index = 0)
        {
Assert.IsValidSubarray(index, new bit64().Length, values.Length);

            bool* ptr = (bool*)values.GetUnsafeReadOnlyPtr() + index;

            intern = (ulong)(maxmath.bitmask(*(bool32*)ptr)
                             | 
                             (maxmath.bitmask(*((bool32*)ptr + 1)) << 32));
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(BitArray values, int index = 0)
        {
Assert.IsValidSubarray(index, new bit64().Length, values.Length);

            bit64 result = default(bit64);

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = values[i + index];
            }

            this = result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(NativeBitArray values, int index = 0)
        {
Assert.IsValidSubarray(index, new bit64().Length, values.Length);

            uint bytes = maxmath.divrem((uint)index, 8, out uint bits);
            void* ptr = (byte*)values.GetUnsafePtr() + bytes;

            if (bits == 0)
            {
                intern = *(ulong*)ptr;
            }
            else
            {
                ulong lo = ((ulong*)ptr)[0];
                ulong hi = ((ulong*)ptr)[1];

                intern = (lo >> (int)bits) | (hi << (64 - (int)bits));
            }
        }


        public readonly int Length => 64;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator bit64(bool input)
        {
            return new bit64(input);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong(bit64 input)
        {
            return input.intern;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator long(bit64 input)
        {
            return (long)input.intern;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(bit64 input)
        {
            return *(double*)&input;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit64(ulong input)
        {
            return new bit64 { intern = input };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit64(long input)
        {
            return new bit64 { intern = (ulong)input };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit64(double input)
        {
            return *(bit64*)&input;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit64 operator ! (bit64 value)
        {
            value.intern = ~value.intern;

            return value;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit64 operator == (bit64 left, bit64 right)
        {
            return !(left != right);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit64 operator != (bit64 left, bit64 right)
        {
            return left ^ right;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit64 operator & (bit64 left, bit64 right)
        {
            left.intern &= right.intern;
    
            return left;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit64 operator | (bit64 left, bit64 right)
        {
            left.intern |= right.intern;
    
            return left;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit64 operator ^ (bit64 left, bit64 right)
        {
            left.intern ^= right.intern;
    
            return left;
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit64(bit32 value)
        {
            return new bit64{ intern = value.intern };
        }


        public static explicit operator bit32(bit64 value)
        {
            return new bit32{ intern = (uint)value.intern };
        }


        public bool this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
Assert.IsWithinArrayBounds(index, Length);
    
                ulong result = (intern >> index) & 1ul;
    
                return *(bool*)&result; 
            }
    
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsSafeBoolean(value);
Assert.IsWithinArrayBounds(index, Length);

                ulong mask = 1ul << index;

                intern = maxmath.andnot(intern, mask) | ((ulong)-*(byte*)&value & mask);
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

            void* ptr = result.GetUnsafePtr();

            ((bool32*)ptr)[0] = maxmath.tobool32((int)intern);
            ((bool32*)ptr)[1] = maxmath.tobool32((int)(intern >> 32));

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

            *(bit64*)result.GetUnsafePtr() = this;

            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyTo(bool[] array, int dstIndex, int numValues = 64, int srcIndex = 0)
        {
Assert.IsValidSubarray(dstIndex, numValues, array.Length);
Assert.IsValidSubarray(srcIndex, numValues, this.Length);

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

            uint bytes = maxmath.divrem((uint)dstIndex, 8, out uint bits);
            ulong* ptr = (ulong*)((byte*)array.GetUnsafePtr() + bytes);
            
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
                        *(uint*)ptr = (uint)(intern >> srcIndex);
            
                        return;
                    }
                    case 40:
                    {
                        *(UInt40*)ptr = (UInt40)(intern >> srcIndex);
            
                        return;
                    }
                    case 48:
                    {
                        *(UInt48*)ptr = (UInt48)(intern >> srcIndex);
            
                        return;
                    }
                    case 56:
                    {
                        *(UInt56*)ptr = (UInt56)(intern >> srcIndex);
            
                        return;
                    }
                    case 64:
                    {
                        *ptr = intern;
            
                        return;
                    }
                
                    default:
                    {
                        ulong mask = (1ul << numValues) - 1;
            
                        ulong _this = (intern >> srcIndex) & mask;
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

                    ulong _this = (intern >> srcIndex) << (int)bits;
                    ulong _array = *ptr;

                    _this = _this & mask;
                    _array = maxmath.andnot(_array, mask);

                    *ptr = _array | _this;
                }
                else
                {
                    ulong mask_lo = maxmath.bitmask64((ulong)(uint)numValues);
                    ulong2 mask = (bits == 0) ? new ulong2(mask_lo, 0) : new ulong2(mask_lo << (int)bits, mask_lo >> (64 - (int)bits));  
                    
                    ulong _this_lo = intern >> srcIndex;
                    ulong2 _this = (bits == 0) ? new ulong2(_this_lo, 0) : new ulong2(_this_lo << (int)bits, _this_lo >> (64 - (int)bits));

                    ulong2 _array = *(ulong2*)ptr;
                    
                    _this = _this & mask;
                    _array = maxmath.andnot(_array, mask);
                    
                    *(ulong2*)ptr = _array | _this;
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyTo(NativeArray<bool> array, int dstIndex, int numValues = 64, int srcIndex = 0)
        {
            CopyToArrayBase((bool*)array.GetUnsafePtr(), array.Length, dstIndex, numValues, srcIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyTo(NativeList<bool> array, int dstIndex, int numValues = 64, int srcIndex = 0)
        {
            CopyToArrayBase((bool*)array.GetUnsafePtr(), array.Length, dstIndex, numValues, srcIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyTo(NativeSlice<bool> array, int dstIndex, int numValues = 64, int srcIndex = 0)
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
                    case 64:
                    {
                        *(bool32*)(ptr)      = maxmath.tobool32((int)intern);
                        *(bool32*)(ptr + 32) = maxmath.tobool32((int)(intern >> 32)); 
                        return;
                    }
                    case 63:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(intern >> srcIndex));
                        bool32 vector_hi = maxmath.tobool32((int)(intern >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool16*)(ptr + 32) = vector_hi.v16_0;
                        *(bool8*)(ptr + 48) = vector_hi.v8_16;
                        *(bool4*)(ptr + 56) = vector_hi.v4_24;
                        *(bool3*)(ptr + 60) = vector_hi.v3_28;

                        return;
                    }
                    case 62:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(intern >> srcIndex));
                        bool32 vector_hi = maxmath.tobool32((int)(intern >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool16*)(ptr + 32) = vector_hi.v16_0;
                        *(bool8*)(ptr + 48) = vector_hi.v8_16;
                        *(bool4*)(ptr + 56) = vector_hi.v4_24;
                        *(bool2*)(ptr + 60) = vector_hi.v2_28;

                        return;
                    }
                    case 61:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(intern >> srcIndex));
                        bool32 vector_hi = maxmath.tobool32((int)(intern >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool16*)(ptr + 32) = vector_hi.v16_0;
                        *(bool8*)(ptr + 48) = vector_hi.v8_16;
                        *(bool4*)(ptr + 56) = vector_hi.v4_24;
                        *(bool*) (ptr + 60) = vector_hi.x28;

                        return;
                    }
                    case 60:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(intern >> srcIndex));
                        bool32 vector_hi = maxmath.tobool32((int)(intern >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool16*)(ptr + 32) = vector_hi.v16_0;
                        *(bool8*)(ptr + 48) = vector_hi.v8_16;
                        *(bool4*)(ptr + 56) = vector_hi.v4_24;

                        return;
                    }
                    case 59:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(intern >> srcIndex));
                        bool32 vector_hi = maxmath.tobool32((int)(intern >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool16*)(ptr + 32) = vector_hi.v16_0;
                        *(bool8*)(ptr + 48) = vector_hi.v8_16;
                        *(bool3*)(ptr + 56) = vector_hi.v3_24;

                        return;
                    }
                    case 58:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(intern >> srcIndex));
                        bool32 vector_hi = maxmath.tobool32((int)(intern >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool16*)(ptr + 32) = vector_hi.v16_0;
                        *(bool8*)(ptr + 48) = vector_hi.v8_16;
                        *(bool2*)(ptr + 56) = vector_hi.v2_24;

                        return;
                    }
                    case 57:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(intern >> srcIndex));
                        bool32 vector_hi = maxmath.tobool32((int)(intern >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool16*)(ptr + 32) = vector_hi.v16_0;
                        *(bool8*)(ptr + 48) = vector_hi.v8_16;
                        *(bool*) (ptr + 56) = vector_hi.x24;

                        return;
                    }
                    case 56:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(intern >> srcIndex));
                        bool32 vector_hi = maxmath.tobool32((int)(intern >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool16*)(ptr + 32) = vector_hi.v16_0;
                        *(bool8*)(ptr + 48) = vector_hi.v8_16;

                        return;
                    }
                    case 55:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(intern >> srcIndex));
                        bool32 vector_hi = maxmath.tobool32((int)(intern >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool16*)(ptr + 32) = vector_hi.v16_0;
                        *(bool4*)(ptr + 48) = vector_hi.v4_16;
                        *(bool3*)(ptr + 52) = vector_hi.v3_20;

                        return;
                    }
                    case 54:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(intern >> srcIndex));
                        bool32 vector_hi = maxmath.tobool32((int)(intern >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool16*)(ptr + 32) = vector_hi.v16_0;
                        *(bool4*)(ptr + 48) = vector_hi.v4_16;
                        *(bool2*)(ptr + 52) = vector_hi.v2_20;

                        return;
                    }
                    case 53:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(intern >> srcIndex));
                        bool32 vector_hi = maxmath.tobool32((int)(intern >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool16*)(ptr + 32) = vector_hi.v16_0;
                        *(bool4*)(ptr + 48) = vector_hi.v4_16;
                        *(bool*) (ptr + 52) = vector_hi.x20;

                        return;
                    }
                    case 52:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(intern >> srcIndex));
                        bool32 vector_hi = maxmath.tobool32((int)(intern >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool16*)(ptr + 32) = vector_hi.v16_0;
                        *(bool4*)(ptr + 48) = vector_hi.v4_16;

                        return;
                    }
                    case 51:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(intern >> srcIndex));
                        bool32 vector_hi = maxmath.tobool32((int)(intern >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool16*)(ptr + 32) = vector_hi.v16_0;
                        *(bool3*)(ptr + 48) = vector_hi.v3_16;

                        return;
                    }
                    case 50:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(intern >> srcIndex));
                        bool32 vector_hi = maxmath.tobool32((int)(intern >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool16*)(ptr + 32) = vector_hi.v16_0;
                        *(bool2*)(ptr + 48) = vector_hi.v2_16;

                        return;
                    }
                    case 49:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(intern >> srcIndex));
                        bool16 vector_hi = maxmath.tobool16((int)(intern >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool16*)(ptr + 32) = vector_hi;
                        *(bool*)(ptr + 48) = this[48 + srcIndex];

                        return;
                    }
                    case 48:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(intern >> srcIndex));
                        bool16 vector_hi = maxmath.tobool16((int)(intern >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool16*)(ptr + 32) = vector_hi;

                        return;
                    }
                    case 47:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(intern >> srcIndex));
                        bool16 vector_hi = maxmath.tobool16((int)(intern >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool8*)(ptr + 32) = vector_hi.v8_0;
                        *(bool4*)(ptr + 40) = vector_hi.v4_8;
                        *(bool3*)(ptr + 44) = vector_hi.v3_12;

                        return;
                    }
                    case 46:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(intern >> srcIndex));
                        bool16 vector_hi = maxmath.tobool16((int)(intern >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool8*)(ptr + 32) = vector_hi.v8_0;
                        *(bool4*)(ptr + 40) = vector_hi.v4_8;
                        *(bool2*)(ptr + 44) = vector_hi.v2_12;

                        return;
                    }
                    case 45:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(intern >> srcIndex));
                        bool16 vector_hi = maxmath.tobool16((int)(intern >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool8*)(ptr + 32) = vector_hi.v8_0;
                        *(bool4*)(ptr + 40) = vector_hi.v4_8;
                        *(bool*) (ptr + 44) = vector_hi.x12;

                        return;
                    }
                    case 44:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(intern >> srcIndex));
                        bool16 vector_hi = maxmath.tobool16((int)(intern >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool8*)(ptr + 32) = vector_hi.v8_0;
                        *(bool4*)(ptr + 40) = vector_hi.v4_8;

                        return;
                    }
                    case 43:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(intern >> srcIndex));
                        bool16 vector_hi = maxmath.tobool16((int)(intern >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool8*)(ptr + 32) = vector_hi.v8_0;
                        *(bool3*)(ptr + 40) = vector_hi.v3_8;

                        return;
                    }
                    case 42:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(intern >> srcIndex));
                        bool16 vector_hi = maxmath.tobool16((int)(intern >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool8*)(ptr + 32) = vector_hi.v8_0;
                        *(bool2*)(ptr + 40) = vector_hi.v2_8;

                        return;
                    }
                    case 41:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(intern >> srcIndex));
                        bool16 vector_hi = maxmath.tobool16((int)(intern >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool8*)(ptr + 32) = vector_hi.v8_0;
                        *(bool*) (ptr + 40) = vector_hi.x8;

                        return;
                    }
                    case 40:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(intern >> srcIndex));
                        bool8 vector_hi = maxmath.tobool8((int)(intern >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool8*)(ptr + 32) = vector_hi;

                        return;
                    }
                    case 39:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(intern >> srcIndex));
                        bool8 vector_hi = maxmath.tobool8((int)(intern >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool4*)(ptr + 32) = vector_hi.v4_0;
                        *(bool3*)(ptr + 36) = vector_hi.v3_4;

                        return;
                    }
                    case 38:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(intern >> srcIndex));
                        bool8 vector_hi = maxmath.tobool8((int)(intern >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool4*)(ptr + 32) = vector_hi.v4_0;
                        *(bool2*)(ptr + 36) = vector_hi.v2_4;

                        return;
                    }
                    case 37:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(intern >> srcIndex));
                        bool8 vector_hi = maxmath.tobool8((int)(intern >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool4*)(ptr + 32) = vector_hi.v4_0;
                        *(bool*) (ptr + 36) = vector_hi.x4;

                        return;
                    }
                    case 36:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(intern >> srcIndex));
                        bool4 vector_hi = maxmath.tobool4((int)(intern >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool4*)(ptr + 32) = vector_hi;

                        return;
                    }
                    case 35:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(intern >> srcIndex));
                        bool3 vector_hi = maxmath.tobool3((int)(intern >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool3*)(ptr + 32) = vector_hi;

                        return;
                    }
                    case 34:
                    {
                        bool32 vector_lo = maxmath.tobool32((int)(intern >> srcIndex));
                        bool2 vector_hi = maxmath.tobool2((int)(intern >> (32 + srcIndex)));

                        *(bool32*)ptr = vector_lo;
                        *(bool2*)(ptr + 32) = vector_hi;

                        return;
                    }
                    case 33:
                    {
                        *(bool32*)(ptr)      = maxmath.tobool32((int)(intern >> srcIndex));
                        *(bool*)  (ptr + 32) = this[32 + srcIndex];

                        return;
                    }
                    case 32:
                    {
                        *(bool32*)ptr = maxmath.tobool32((int)(intern >> srcIndex)); 
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
                        *(bool16*)ptr = maxmath.tobool16((int)(intern >> srcIndex)); 
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
                        *(bool8*)ptr = maxmath.tobool8((int)(intern >> srcIndex)); 
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
                ulong shifted = intern >> srcIndex;

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


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit8 Getbit8SubArray(int index)
        {
Assert.IsValidSubarray(index, new bit8().Length, Length);

            ulong temp = intern >> index;

            return *(bit8*)&temp;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit16 Getbit16SubArray(int index)
        {
Assert.IsValidSubarray(index, new bit16().Length, Length);

            ulong temp = intern >> index;

            return *(bit16*)&temp;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit32 Getbit32SubArray(int index)
        {
Assert.IsValidSubarray(index, new bit32().Length, Length);

            ulong temp = intern >> index;

            return *(bit32*)&temp;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(0, 64)] 
        public readonly int IndexOfFirst()
        {
            return math.tzcnt(intern);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(0, 64)]
        public readonly int IndexOfFirst(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return math.tzcnt(intern & (ulong)maxmath.bitmask64(numBits, index));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(-1, 63)] 
        public readonly int IndexOfLast()
        {
            return 63 - math.lzcnt(intern);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(-1, 63)]
        public readonly int IndexOfLast(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return 63 - math.lzcnt(intern & (ulong)maxmath.bitmask64(numBits, index));
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

            ulong mask = maxmath.bitmask64((ulong)(uint)numBits, (ulong)(uint)index);
            ulong reset = maxmath.bits_resetlowest(intern & mask);
            ulong remaining = maxmath.andnot(intern, mask);

            intern = reset | remaining;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetFirst()
        {
            // for X86, modulo 64/AND 63 is omitted, since it is performed in hardware when shifting anyway
            intern = intern | (1ul << (math.tzcnt(~intern) % 64));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetFirst(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            // for X86, modulo 64/AND 63 is omitted, since it is performed in hardware when shifting anyway
            ulong mask = maxmath.bitmask64((ulong)(uint)numBits, (ulong)(uint)index);
            ulong set = intern | (1ul << (math.tzcnt(maxmath.andnot(mask, intern)) % 64));

            intern = maxmath.andnot(intern, mask) | (set & mask);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ResetLast()
        {
            intern = intern & ((ulong.MaxValue >> 1) >> math.lzcnt(intern));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ResetLast(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = maxmath.bitmask64((ulong)(uint)numBits, (ulong)(uint)index);
            ulong reset = (intern & ((ulong.MaxValue >> 1) >> math.lzcnt(mask & intern)));
            ulong remaining = maxmath.andnot(intern, mask);

            intern = reset | remaining;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetLast()
        {
            int leadingOnesCount = math.lzcnt(~intern);
            intern = intern | (1ul << ((Length - 1) - leadingOnesCount));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetLast(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = maxmath.bitmask64((ulong)(uint)numBits, (ulong)(uint)index);
            int leadingOnesCount = math.lzcnt(maxmath.andnot(mask, intern));
            ulong set = intern | (1ul << ((Length - 1) - leadingOnesCount));

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

            ulong mask = (ulong)maxmath.bitmask64(numBits, index);
            ulong maskED = mask & intern;

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

            ulong mask = (ulong)maxmath.bitmask64(numBits, index);
            ulong maskED = mask & intern;

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

            ulong mask = (ulong)maxmath.bitmask64(numBits, index);
            ulong maskED = mask & intern;

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
            
            ulong mask = (ulong)maxmath.bitmask64(numBits, index);
            ulong maskED = mask & intern;

            int remainder = amount % numBits;

            maskED = mask & ((maskED >> remainder) | (maskED << (numBits - remainder)));

            intern = maxmath.andnot(intern, mask) | maskED;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Swap(int smallerIndex, int largerIndex)
        {
Assert.IsWithinArrayBounds(smallerIndex, Length);
Assert.IsWithinArrayBounds(largerIndex, Length);
            
            uint bit1 = (uint)maxmath.bits_extract(intern, smallerIndex, 1);
            uint bit2 = (uint)maxmath.bits_extract(intern, largerIndex, 1);
           
            uint swap = bit1 ^ bit2;
            ulong shifted = ((ulong)swap << smallerIndex) | ((ulong)swap << largerIndex);
 
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
            ulong shifted = ((ulong)swap << smallerIndex) | ((ulong)swap << largerIndex);
 
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

            intern ^= (ulong)maxmath.bitmask64(numBits, index);
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

            ulong mask = (ulong)maxmath.bitmask64(numBits, index);
            int shiftValue = math.mad(2, index,      numBits - Length);

            intern = (mask & ((shiftValue < 0)
                              ? math.reversebits(intern) >> math.abs(shiftValue)
                              : math.reversebits(intern) << shiftValue))
                      |
                      maxmath.andnot(intern, mask);
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)] 
        public void Shuffle(ref Random64 rngenerator)
        {
            if (X86.Bmi2.IsBmi2Supported)
            {
                ulong mask = rngenerator.NextULong();
                ulong notMask = ~mask;

                ulong lo = maxmath.bits_extractparallel(intern, mask);
                ulong hi = maxmath.bits_extractparallel(intern, notMask);

                intern = lo | (hi << math.countbits(mask));
            }
            else
            {
                for (int i = Length - 1, j = Length;    i > 0;     i--, j--)
                {
                    Swap(i, (int)rngenerator.NextULong((uint)j));
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Shuffle(int index, int numBits, ref Random64 rngenerator)
        {
Assert.IsValidSubarray(index, numBits, Length);

            if (X86.Bmi2.IsBmi2Supported)
            {
                ulong extractMask = rngenerator.NextULong();
                ulong shuffleMask = maxmath.bitmask64((ulong)(uint)numBits, (ulong)(uint)index);
                extractMask &= shuffleMask;
                ulong notExtractMask = maxmath.andnot(shuffleMask, extractMask);

                ulong lo = maxmath.bits_extractparallel(intern, extractMask);
                ulong hi = maxmath.bits_extractparallel(intern, notExtractMask);

                intern = ((lo | (hi << math.countbits(extractMask))) << index) | maxmath.andnot(intern, shuffleMask);
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
            intern = rngenerator.NextULong();
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Randomize(int index, int numBits, ref Random64 rngenerator)
        {
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = (ulong)maxmath.bitmask64(numBits, index);
    
            intern = (rngenerator.NextULong() & mask)    |    maxmath.andnot(intern, mask);
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)] 
        public void SetBits(bool value)
        {
            this = new bit64(value);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetBits(int index, int numBits, bool value)
        {
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = (ulong)maxmath.bitmask64(numBits, index);

            intern = maxmath.andnot(intern, mask) | ((ulong)-*(byte*)&value & mask);
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(0, 64)] 
        public readonly uint CountBits()
        {
            return (uint)math.countbits(intern);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]  [return: AssumeRange(0, 64)]
        public readonly uint CountBits(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return (uint)math.countbits(intern & (ulong)maxmath.bitmask64(numBits, index));
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAll()
        {
            return intern == ulong.MaxValue;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAll(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = (ulong)maxmath.bitmask64(numBits, index);
    
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

            return (intern & (ulong)maxmath.bitmask64(numBits, index)) != 0;
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestNone()
        {
            return intern == 0ul;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestNone(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return (intern & (ulong)maxmath.bitmask64(numBits, index)) == 0ul;
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestNotAll()
        {
            return intern != ulong.MaxValue;
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestNotAll(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return (intern & (ulong)maxmath.bitmask64(numBits, index)) != ulong.MaxValue;
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

            intern = (shiftedSource & mask) | maxmath.andnot(intern, mask);
        }


        public override readonly string ToString()
        {
            return Dump.Bits(this);
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
            return intern.GetHashCode();
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(bit64 other)
        {
            return this.intern == other.intern;
        }
        public override readonly bool Equals(object obj)
        {
            return Equals((bit64)obj);
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