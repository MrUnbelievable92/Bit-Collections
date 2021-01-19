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
            intern = (ulong)(-(long)maxmath.touint64(value));
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
Assert.IsWithinArrayBounds(index + 63, values.Length);

            fixed (void* ptr = &values[index])
            {
                intern = (ulong)(maxmath.bitmask(*(bool32*)ptr)
                                 | 
                                 (maxmath.bitmask(*((bool32*)ptr + 1)) << 32));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(NativeArray<bool> values, int index = 0)
        {
Assert.IsWithinArrayBounds(index + 63, values.Length);

            bool* ptr = (bool*)values.GetUnsafePtr() + index;

            intern = (ulong)(maxmath.bitmask(*(bool32*)ptr)
                             | 
                             (maxmath.bitmask(*((bool32*)ptr + 1)) << 32));
        }


        public readonly int Length => 64;


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
            return *(bit64*)&input;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit64(long input)
        {
            return *(bit64*)&input;
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
        public readonly bits<T> Reinterpret<T>()
            where T : unmanaged
        {
Assert.AreEqual(sizeof(bit64), sizeof(T));

            ulong temp = intern;

            return *(bits<T>*)&temp;
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


        public readonly bool[] ToArray()
        {      
            bool[] result = new bool[Length];

            fixed (void* ptr = &result[0])
            {
                ((bool32*)ptr)[0] = maxmath.tobool32((int)intern);
                ((bool32*)ptr)[1] = maxmath.tobool32((int)(intern >> 32));
            }

            return result;
        }

        public readonly NativeArray<bool> ToArray(Allocator allocator)
        {
            NativeArray<bool> result = new NativeArray<bool>(Length, allocator, NativeArrayOptions.UninitializedMemory);

            void* ptr = result.GetUnsafePtr();

            ((bool32*)ptr)[0] = maxmath.tobool32((int)intern);
            ((bool32*)ptr)[1] = maxmath.tobool32((int)(intern >> 32));

            return result;
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

            maskED = (mask & (maskED << remainder))   |   (mask & (maskED >> (numBits - remainder)));

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

            maskED = (mask & (maskED >> remainder))   |   (mask & (maskED << (numBits - remainder)));

            intern = maxmath.andnot(intern, mask) | maskED;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Swap(int smallerIndex, int largerIndex)
        {
Assert.IsWithinArrayBounds(smallerIndex, Length);
Assert.IsWithinArrayBounds(largerIndex, Length);

            ulong2 field = intern;
            ulong2 packed = (ulong2)new long2(smallerIndex, largerIndex);

            ulong2 result = 1 & maxmath.shrl(field, packed);
            result ^= result.yx;
            result = maxmath.shl(result, packed);

            intern = (field ^ (result | result.yx)).x;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Swap(int smallerIndex, int largerIndex, int numBits)
        {
Assert.IsGreater(largerIndex, smallerIndex);
Assert.IsValidSubarray(smallerIndex, numBits, Length);
Assert.IsValidSubarray(largerIndex, numBits, Length);
Assert.SubarraysDoNotOverlap(smallerIndex, largerIndex, numBits, numBits);

            // inlined bitmask
            // x: mask for lower subarray, y: mask for upper subarray, 
            ulong3 masks = maxmath.shl(ulong.MaxValue, new ulong3((ulong)smallerIndex, (ulong)largerIndex, 0ul));
            masks = maxmath.andnot(masks, masks << numBits);
            // z: mask for deleting elements in the array
            masks.z = ~(masks.x | masks.y);

            // delete in z, grab values in x & y
            masks &= intern;

            // swap positions; blend together
            int indexDelta = largerIndex - smallerIndex;
            intern = ((masks.z | (masks.x << indexDelta)) | (masks.y >> indexDelta));
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

            ulong2 invert = new ulong2((ulong)maxmath.bitmask64(numBits, index),     intern);
    
            invert = maxmath.andnot(invert, invert.yx);
    
            intern = (invert | invert.yx).x;
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
    
            for (int2 i = new int2(startingIndex - 1, startingIndex);    (i > 0).x;      i--)  
            {
                Swap(i.x, rngenerator.NextInt(0, i.y));
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


        public override string ToString()
        {
            return Log.Bits(this);
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