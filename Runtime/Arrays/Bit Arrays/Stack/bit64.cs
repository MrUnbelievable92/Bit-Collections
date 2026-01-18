using DevTools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;

using static MaxMath.maxmath;
using static Unity.Mathematics.math;

namespace BitCollections
{
    [Serializable]
    unsafe public struct bit64 : IArray<bool>, IEquatable<bit64>
    {
        public ulong Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(ulong value)
        {
            Bits = value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(long value)
        {
            Bits = (ulong)value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bool value)
        {
            Bits = (ulong)(-(long)toulong(value));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bool x0, bool x1, bool x2, bool x3, bool x4, bool x5, bool x6, bool x7, bool x8, bool x9, bool x10, bool x11, bool x12, bool x13, bool x14, bool x15, bool x16, bool x17, bool x18, bool x19, bool x20, bool x21, bool x22, bool x23, bool x24, bool x25, bool x26, bool x27, bool x28, bool x29, bool x30, bool x31, bool x32, bool x33, bool x34, bool x35, bool x36, bool x37, bool x38, bool x39, bool x40, bool x41, bool x42, bool x43, bool x44, bool x45, bool x46, bool x47, bool x48, bool x49, bool x50, bool x51, bool x52, bool x53, bool x54, bool x55, bool x56, bool x57, bool x58, bool x59, bool x60, bool x61, bool x62, bool x63)
        {
            Bits = (ulong)new bit32(x0, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16, x17, x18, x19, x20, x21, x22, x23, x24, x25, x26, x27, x28, x29, x30, x63).Bits
                     |
                     ((ulong)new bit32(x32, x33, x34, x35, x36, x37, x38, x39, x40, x41, x42, x43, x44, x45, x46, x47, x48, x49, x50, x51, x52, x53, x54, x55, x56, x57, x58, x59, x60, x61, x62, x63).Bits << 32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit8 x16_23, bit8 x24_63, bit8 x32_39, bit8 x40_47, bit8 x48_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_63.Bits << 24) 
                  | ((ulong)x32_39.Bits << 32) 
                  | ((ulong)x40_47.Bits << 40)
                  | ((ulong)x48_55.Bits << 48)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit8 x16_23, bit8 x24_63, bit8 x32_39, bit8 x40_47, bit8 x48_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_63.Bits << 24) 
                  | ((ulong)x32_39.Bits << 32) 
                  | ((ulong)x40_47.Bits << 40)
                  | ((ulong)x48_55.Bits << 48)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit16 x8_23, bit8 x24_63, bit8 x32_39, bit8 x40_47, bit8 x48_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_23.Bits << 8) 
                  | ((ulong)x24_63.Bits << 24) 
                  | ((ulong)x32_39.Bits << 32) 
                  | ((ulong)x40_47.Bits << 40)
                  | ((ulong)x48_55.Bits << 48)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit16 x16_63, bit8 x32_39, bit8 x40_47, bit8 x48_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_63.Bits << 16) 
                  | ((ulong)x32_39.Bits << 32) 
                  | ((ulong)x40_47.Bits << 40)
                  | ((ulong)x48_55.Bits << 48)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit8 x16_23, bit16 x24_39, bit8 x40_47, bit8 x48_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_39.Bits << 24) 
                  | ((ulong)x40_47.Bits << 40)
                  | ((ulong)x48_55.Bits << 48)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit8 x16_23, bit8 x24_63, bit16 x32_47, bit8 x48_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_63.Bits << 24) 
                  | ((ulong)x32_47.Bits << 32)
                  | ((ulong)x48_55.Bits << 48)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit8 x16_23, bit8 x24_63, bit8 x32_39, bit16 x40_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_63.Bits << 24) 
                  | ((ulong)x32_39.Bits << 32) 
                  | ((ulong)x40_55.Bits << 40)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit8 x16_23, bit8 x24_63, bit8 x32_39, bit8 x40_47, bit16 x48_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_63.Bits << 24) 
                  | ((ulong)x32_39.Bits << 32) 
                  | ((ulong)x40_47.Bits << 40)
                  | ((ulong)x48_63.Bits << 48);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit16 x16_63, bit8 x32_39, bit8 x40_47, bit8 x48_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_63.Bits << 16) 
                  | ((ulong)x32_39.Bits << 32) 
                  | ((ulong)x40_47.Bits << 40)
                  | ((ulong)x48_55.Bits << 48)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit8 x16_23, bit16 x24_39, bit8 x40_47, bit8 x48_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_39.Bits << 24) 
                  | ((ulong)x40_47.Bits << 40)
                  | ((ulong)x48_55.Bits << 48)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit8 x16_23, bit8 x24_63, bit16 x32_47, bit8 x48_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_63.Bits << 24) 
                  | ((ulong)x32_47.Bits << 32) 
                  | ((ulong)x48_55.Bits << 48)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit8 x16_23, bit8 x24_63, bit8 x32_39, bit16 x40_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_63.Bits << 24) 
                  | ((ulong)x32_39.Bits << 32) 
                  | ((ulong)x40_55.Bits << 40)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit8 x16_23, bit8 x24_63, bit8 x32_39, bit8 x40_47, bit16 x48_63)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_63.Bits << 24) 
                  | ((ulong)x32_39.Bits << 32) 
                  | ((ulong)x40_47.Bits << 40)
                  | ((ulong)x48_63.Bits << 48);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit16 x8_23, bit16 x24_39, bit8 x40_47, bit8 x48_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_23.Bits << 8) 
                  | ((ulong)x24_39.Bits << 24) 
                  | ((ulong)x40_47.Bits << 40)
                  | ((ulong)x48_55.Bits << 48)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit16 x8_23, bit8 x24_63, bit16 x32_47, bit8 x48_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_23.Bits << 8) 
                  | ((ulong)x24_63.Bits << 24) 
                  | ((ulong)x32_47.Bits << 32) 
                  | ((ulong)x48_55.Bits << 48)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit16 x8_23, bit8 x24_63, bit8 x32_39, bit16 x40_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_23.Bits << 8) 
                  | ((ulong)x24_63.Bits << 24) 
                  | ((ulong)x32_39.Bits << 32) 
                  | ((ulong)x40_55.Bits << 40)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit16 x8_23, bit8 x24_63, bit8 x32_39, bit8 x40_47, bit16 x48_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_23.Bits << 8) 
                  | ((ulong)x24_63.Bits << 24) 
                  | ((ulong)x32_39.Bits << 32) 
                  | ((ulong)x40_47.Bits << 40)
                  | ((ulong)x48_63.Bits << 48);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit16 x16_63, bit16 x32_47, bit8 x48_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_63.Bits << 16) 
                  | ((ulong)x32_47.Bits << 32) 
                  | ((ulong)x48_55.Bits << 48)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit16 x16_63, bit8 x32_39, bit16 x40_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_63.Bits << 16) 
                  | ((ulong)x32_39.Bits << 32) 
                  | ((ulong)x40_55.Bits << 40)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit16 x16_63, bit8 x32_39, bit8 x40_47, bit16 x48_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_63.Bits << 16) 
                  | ((ulong)x32_39.Bits << 32) 
                  | ((ulong)x40_47.Bits << 40)
                  | ((ulong)x48_63.Bits << 48);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit8 x16_23, bit16 x24_39, bit16 x40_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_39.Bits << 24)
                  | ((ulong)x40_55.Bits << 40)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit8 x16_23, bit16 x24_39, bit8 x40_47, bit16 x48_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_39.Bits << 24)
                  | ((ulong)x40_47.Bits << 40)
                  | ((ulong)x48_63.Bits << 48);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit8 x16_23, bit8 x24_63, bit16 x32_47, bit16 x48_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_63.Bits << 24) 
                  | ((ulong)x32_47.Bits << 32)
                  | ((ulong)x48_63.Bits << 48);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit16 x16_63, bit16 x32_47, bit8 x48_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_63.Bits << 16) 
                  | ((ulong)x32_47.Bits << 32) 
                  | ((ulong)x48_55.Bits << 48)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit16 x16_63, bit8 x32_39, bit16 x40_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_63.Bits << 16) 
                  | ((ulong)x32_39.Bits << 32) 
                  | ((ulong)x40_55.Bits << 40)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit16 x16_63, bit8 x32_39, bit8 x40_47, bit16 x48_63)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_63.Bits << 16) 
                  | ((ulong)x32_39.Bits << 32) 
                  | ((ulong)x40_47.Bits << 40)
                  | ((ulong)x48_63.Bits << 48);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit8 x16_23, bit16 x24_39, bit16 x40_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_39.Bits << 24) 
                  | ((ulong)x40_55.Bits << 40) 
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit8 x16_23, bit16 x24_39, bit8 x40_47, bit16 x48_63)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_39.Bits << 24) 
                  | ((ulong)x40_47.Bits << 40) 
                  | ((ulong)x48_63.Bits << 48);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit8 x16_23, bit8 x24_63, bit16 x32_47, bit16 x48_63)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_63.Bits << 24) 
                  | ((ulong)x32_47.Bits << 32) 
                  | ((ulong)x48_63.Bits << 48);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit16 x8_23, bit16 x24_39, bit16 x40_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_23.Bits << 8) 
                  | ((ulong)x24_39.Bits << 24) 
                  | ((ulong)x40_55.Bits << 40) 
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit16 x8_23, bit16 x24_39, bit8 x40_47, bit16 x48_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_23.Bits << 8) 
                  | ((ulong)x24_39.Bits << 24) 
                  | ((ulong)x40_47.Bits << 40) 
                  | ((ulong)x48_63.Bits << 48);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit16 x8_23, bit8 x24_63, bit16 x32_47, bit16 x48_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_23.Bits << 8) 
                  | ((ulong)x24_63.Bits << 24) 
                  | ((ulong)x32_47.Bits << 32) 
                  | ((ulong)x48_63.Bits << 48);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit16 x16_63, bit16 x32_47, bit16 x48_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_63.Bits << 16) 
                  | ((ulong)x32_47.Bits << 32) 
                  | ((ulong)x48_63.Bits << 48);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit16 x16_63, bit16 x32_47, bit16 x48_63)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_63.Bits << 16) 
                  | ((ulong)x32_47.Bits << 32) 
                  | ((ulong)x48_63.Bits << 48);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit24 x0_23, bit8 x24_63, bit8 x32_39, bit8 x40_47, bit8 x48_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_23.Bits << 0) 
                  | ((ulong)x24_63.Bits << 24) 
                  | ((ulong)x32_39.Bits << 32) 
                  | ((ulong)x40_47.Bits << 40)
                  | ((ulong)x48_55.Bits << 48)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit24 x8_63, bit8 x32_39, bit8 x40_47, bit8 x48_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_63.Bits << 8) 
                  | ((ulong)x32_39.Bits << 32) 
                  | ((ulong)x40_47.Bits << 40)
                  | ((ulong)x48_55.Bits << 48)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit24 x16_39, bit8 x40_47, bit8 x48_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_39.Bits << 16) 
                  | ((ulong)x40_47.Bits << 40)
                  | ((ulong)x48_55.Bits << 48)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit8 x16_23, bit24 x24_47, bit8 x48_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_47.Bits << 24)
                  | ((ulong)x48_55.Bits << 48)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit8 x16_23, bit8 x24_63, bit24 x32_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_63.Bits << 24)
                  | ((ulong)x32_55.Bits << 32)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit8 x16_23, bit8 x24_63, bit8 x32_39, bit24 x40_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_63.Bits << 24)
                  | ((ulong)x32_39.Bits << 32)
                  | ((ulong)x40_63.Bits << 40);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit24 x0_23, bit24 x24_47, bit8 x48_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_23.Bits << 0) 
                  | ((ulong)x24_47.Bits << 24) 
                  | ((ulong)x48_55.Bits << 48)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit24 x0_23, bit8 x24_63, bit24 x32_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_23.Bits << 0) 
                  | ((ulong)x24_63.Bits << 24) 
                  | ((ulong)x32_55.Bits << 32)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit24 x0_23, bit8 x24_63, bit8 x32_39, bit24 x40_63)
        {
            Bits = ((ulong)x0_23.Bits << 0) 
                  | ((ulong)x24_63.Bits << 24) 
                  | ((ulong)x32_39.Bits << 32)
                  | ((ulong)x40_63.Bits << 40);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit24 x8_63, bit24 x32_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_63.Bits << 8) 
                  | ((ulong)x32_55.Bits << 32)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit24 x8_63, bit8 x32_39, bit24 x40_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_63.Bits << 8) 
                  | ((ulong)x32_39.Bits << 32)
                  | ((ulong)x40_63.Bits << 40);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit24 x16_39, bit24 x40_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_39.Bits << 16)
                  | ((ulong)x40_63.Bits << 40);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit24 x0_23, bit16 x24_39, bit8 x40_47, bit8 x48_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_23.Bits << 0) 
                  | ((ulong)x24_39.Bits << 24) 
                  | ((ulong)x40_47.Bits << 40)
                  | ((ulong)x48_55.Bits << 48)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit24 x0_23, bit8 x24_63, bit16 x32_47, bit8 x48_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_23.Bits << 0) 
                  | ((ulong)x24_63.Bits << 24) 
                  | ((ulong)x32_47.Bits << 32)
                  | ((ulong)x48_55.Bits << 48)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit24 x0_23, bit8 x24_63, bit8 x32_39, bit16 x40_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_23.Bits << 0) 
                  | ((ulong)x24_63.Bits << 24) 
                  | ((ulong)x32_39.Bits << 32)
                  | ((ulong)x40_55.Bits << 40)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit24 x0_23, bit8 x24_63, bit8 x32_39, bit8 x40_47, bit16 x48_63)
        {
            Bits = ((ulong)x0_23.Bits << 0) 
                  | ((ulong)x24_63.Bits << 24) 
                  | ((ulong)x32_39.Bits << 32)
                  | ((ulong)x40_47.Bits << 40)
                  | ((ulong)x48_63.Bits << 48);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit24 x8_63, bit16 x32_47, bit8 x48_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_63.Bits << 8) 
                  | ((ulong)x32_47.Bits << 32) 
                  | ((ulong)x48_55.Bits << 48)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit24 x8_63, bit8 x32_39, bit16 x40_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_63.Bits << 8) 
                  | ((ulong)x32_39.Bits << 32) 
                  | ((ulong)x40_55.Bits << 40)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit24 x8_63, bit8 x32_39, bit8 x40_47, bit16 x48_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_63.Bits << 8) 
                  | ((ulong)x32_39.Bits << 32) 
                  | ((ulong)x40_47.Bits << 40)
                  | ((ulong)x48_63.Bits << 48);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit24 x16_39, bit8 x40_47, bit8 x48_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_39.Bits << 16) 
                  | ((ulong)x40_47.Bits << 40)
                  | ((ulong)x48_55.Bits << 48)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit24 x16_39, bit16 x40_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_39.Bits << 16) 
                  | ((ulong)x40_55.Bits << 40)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit24 x16_39, bit8 x40_47, bit16 x48_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_39.Bits << 16) 
                  | ((ulong)x40_47.Bits << 40)
                  | ((ulong)x48_63.Bits << 48);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit8 x16_23, bit24 x24_47, bit8 x48_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_47.Bits << 24)
                  | ((ulong)x48_55.Bits << 48)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit16 x8_23, bit24 x24_47, bit8 x48_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_23.Bits << 8) 
                  | ((ulong)x24_47.Bits << 24)
                  | ((ulong)x48_55.Bits << 48)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit8 x16_23, bit24 x24_47, bit16 x48_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_47.Bits << 24)
                  | ((ulong)x48_63.Bits << 48);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit8 x16_23, bit8 x24_63, bit24 x32_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_63.Bits << 24)
                  | ((ulong)x32_55.Bits << 32)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit16 x8_23, bit8 x24_63, bit24 x32_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_23.Bits << 8) 
                  | ((ulong)x24_63.Bits << 24)
                  | ((ulong)x32_55.Bits << 32)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit16 x16_63, bit24 x32_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_63.Bits << 16) 
                  | ((ulong)x32_55.Bits << 32)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit8 x16_23, bit8 x24_63, bit8 x32_39, bit24 x40_63)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_63.Bits << 24)
                  | ((ulong)x32_39.Bits << 32)
                  | ((ulong)x40_63.Bits << 40);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit16 x8_23, bit8 x24_63, bit8 x32_39, bit24 x40_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_23.Bits << 8) 
                  | ((ulong)x24_63.Bits << 24)
                  | ((ulong)x32_39.Bits << 32)
                  | ((ulong)x40_63.Bits << 40);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit16 x16_63, bit8 x32_39, bit24 x40_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_63.Bits << 16) 
                  | ((ulong)x32_39.Bits << 32)
                  | ((ulong)x40_63.Bits << 40);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit8 x16_23, bit16 x24_39, bit24 x40_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_39.Bits << 24)
                  | ((ulong)x40_63.Bits << 40);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit24 x0_23, bit16 x24_39, bit16 x40_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_23.Bits << 0) 
                  | ((ulong)x24_39.Bits << 24) 
                  | ((ulong)x40_55.Bits << 40)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit24 x0_23, bit16 x24_39, bit8 x40_47, bit16 x48_63)
        {
            Bits = ((ulong)x0_23.Bits << 0) 
                  | ((ulong)x24_39.Bits << 24) 
                  | ((ulong)x40_47.Bits << 40)
                  | ((ulong)x48_63.Bits << 48);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit24 x0_23, bit8 x24_63, bit16 x32_47, bit16 x48_63)
        {
            Bits = ((ulong)x0_23.Bits << 0) 
                  | ((ulong)x24_63.Bits << 24) 
                  | ((ulong)x32_47.Bits << 32)
                  | ((ulong)x48_63.Bits << 48);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit24 x8_63, bit16 x32_47, bit16 x48_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_63.Bits << 8) 
                  | ((ulong)x32_47.Bits << 32) 
                  | ((ulong)x48_63.Bits << 48);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit24 x16_39, bit16 x40_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_39.Bits << 16) 
                  | ((ulong)x40_55.Bits << 40)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit24 x16_39, bit8 x40_47, bit16 x48_63)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_39.Bits << 16) 
                  | ((ulong)x40_47.Bits << 40)
                  | ((ulong)x48_63.Bits << 48);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit8 x16_23, bit24 x24_47, bit16 x48_63)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_47.Bits << 24)
                  | ((ulong)x48_63.Bits << 48);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit16 x8_23, bit24 x24_47, bit16 x48_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_23.Bits << 8) 
                  | ((ulong)x24_47.Bits << 24)
                  | ((ulong)x48_63.Bits << 48);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit16 x16_63, bit24 x32_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_63.Bits << 16) 
                  | ((ulong)x32_55.Bits << 32)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit16 x16_63, bit8 x32_39, bit24 x40_63)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_63.Bits << 16) 
                  | ((ulong)x32_39.Bits << 32)
                  | ((ulong)x40_63.Bits << 40);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit8 x16_23, bit16 x24_39, bit24 x40_63)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_39.Bits << 24)
                  | ((ulong)x40_63.Bits << 40);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit16 x8_23, bit16 x24_39, bit24 x40_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_23.Bits << 8) 
                  | ((ulong)x24_39.Bits << 24)
                  | ((ulong)x40_63.Bits << 40);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit24 x0_23, bit24 x24_47, bit16 x48_63)
        {
            Bits = ((ulong)x0_23.Bits << 0) 
                  | ((ulong)x24_47.Bits << 24)
                  | ((ulong)x48_63.Bits << 48);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit24 x0_23, bit16 x24_39, bit24 x40_63)
        {
            Bits = ((ulong)x0_23.Bits << 0) 
                  | ((ulong)x24_39.Bits << 24)
                  | ((ulong)x40_63.Bits << 40);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit24 x16_39, bit24 x40_63)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_39.Bits << 16)
                  | ((ulong)x40_63.Bits << 40);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit32 x0_63, bit8 x32_39, bit8 x40_47, bit8 x48_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_63.Bits << 0) 
                  | ((ulong)x32_39.Bits << 32) 
                  | ((ulong)x40_47.Bits << 40)
                  | ((ulong)x48_55.Bits << 48)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit32 x8_39, bit8 x40_47, bit8 x48_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_39.Bits << 8) 
                  | ((ulong)x40_47.Bits << 40)
                  | ((ulong)x48_55.Bits << 48)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit32 x16_47, bit8 x48_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_47.Bits << 16) 
                  | ((ulong)x48_55.Bits << 48)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit8 x16_23, bit32 x24_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_55.Bits << 24) 
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit8 x16_23, bit8 x24_63, bit32 x32_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_63.Bits << 24) 
                  | ((ulong)x32_63.Bits << 32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit32 x0_63, bit16 x32_47, bit8 x48_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_63.Bits << 0) 
                  | ((ulong)x32_47.Bits << 32) 
                  | ((ulong)x48_55.Bits << 48)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit32 x0_63, bit8 x32_39, bit16 x40_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_63.Bits << 0) 
                  | ((ulong)x32_39.Bits << 32) 
                  | ((ulong)x40_55.Bits << 40)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit32 x0_63, bit8 x32_39, bit8 x40_47, bit16 x48_63)
        {
            Bits = ((ulong)x0_63.Bits << 0) 
                  | ((ulong)x32_39.Bits << 32) 
                  | ((ulong)x40_47.Bits << 40)
                  | ((ulong)x48_63.Bits << 48);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit32 x8_39, bit16 x40_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_39.Bits << 8) 
                  | ((ulong)x40_55.Bits << 40)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit32 x8_39, bit8 x40_47, bit16 x48_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_39.Bits << 8) 
                  | ((ulong)x40_47.Bits << 40)
                  | ((ulong)x48_63.Bits << 48);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit32 x16_47, bit8 x48_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_47.Bits << 16) 
                  | ((ulong)x48_55.Bits << 48)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit32 x16_47, bit16 x48_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_47.Bits << 16) 
                  | ((ulong)x48_63.Bits << 48);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit8 x16_23, bit32 x24_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_55.Bits << 24) 
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit16 x8_23, bit32 x24_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_23.Bits << 8) 
                  | ((ulong)x24_55.Bits << 24) 
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit8 x16_23, bit8 x24_63, bit32 x32_63)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_63.Bits << 24) 
                  | ((ulong)x32_63.Bits << 32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit16 x8_23, bit8 x24_63, bit32 x32_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_23.Bits << 8) 
                  | ((ulong)x24_63.Bits << 24) 
                  | ((ulong)x32_63.Bits << 32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit16 x16_63, bit32 x32_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_63.Bits << 16) 
                  | ((ulong)x32_63.Bits << 32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit32 x0_63, bit16 x32_47, bit16 x48_63)
        {
            Bits = ((ulong)x0_63.Bits << 0) 
                  | ((ulong)x32_47.Bits << 32) 
                  | ((ulong)x48_63.Bits << 48);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit32 x16_47, bit16 x48_63)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_47.Bits << 16) 
                  | ((ulong)x48_63.Bits << 48);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit16 x16_63, bit32 x32_63)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_63.Bits << 16) 
                  | ((ulong)x32_63.Bits << 32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit32 x0_63, bit24 x32_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_63.Bits << 0) 
                  | ((ulong)x32_55.Bits << 32) 
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit32 x0_63, bit8 x32_39, bit24 x40_63)
        {
            Bits = ((ulong)x0_63.Bits << 0) 
                  | ((ulong)x32_39.Bits << 32) 
                  | ((ulong)x40_63.Bits << 40);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit32 x8_39, bit24 x40_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_39.Bits << 8) 
                  | ((ulong)x40_63.Bits << 40);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit24 x8_63, bit32 x32_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_63.Bits << 8) 
                  | ((ulong)x32_63.Bits << 32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit24 x0_23, bit8 x24_63, bit32 x32_63)
        {
            Bits = ((ulong)x0_23.Bits << 0) 
                  | ((ulong)x24_63.Bits << 24) 
                  | ((ulong)x32_63.Bits << 32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit32 x0_63, bit32 x32_63)
        {
            Bits = ((ulong)x0_63.Bits << 0) 
                  | ((ulong)x32_63.Bits << 32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit40 x0_39, bit8 x40_47, bit8 x48_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_39.Bits << 0) 
                  | ((ulong)x40_47.Bits << 40)
                  | ((ulong)x48_55.Bits << 48)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit40 x8_47, bit8 x48_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_47.Bits << 8) 
                  | ((ulong)x48_55.Bits << 48)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit40 x16_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_55.Bits << 16) 
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit8 x16_23, bit40 x24_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_23.Bits << 16) 
                  | ((ulong)x24_63.Bits << 24);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit40 x0_39, bit16 x40_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_39.Bits << 0) 
                  | ((ulong)x40_55.Bits << 40)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit40 x0_39, bit8 x40_47, bit16 x48_63)
        {
            Bits = ((ulong)x0_39.Bits << 0) 
                  | ((ulong)x40_47.Bits << 40)
                  | ((ulong)x48_63.Bits << 48);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit40 x8_47, bit16 x48_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_47.Bits << 8) 
                  | ((ulong)x48_63.Bits << 48);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit40 x16_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_55.Bits << 16) 
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit40 x0_39, bit24 x40_63)
        {
            Bits = ((ulong)x0_39.Bits << 0) 
                  | ((ulong)x40_63.Bits << 40);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit24 x0_23, bit40 x24_63)
        {
            Bits = ((ulong)x0_23.Bits << 0) 
                  | ((ulong)x24_63.Bits << 24);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit48 x0_47, bit8 x48_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_47.Bits << 0) 
                  | ((ulong)x48_55.Bits << 48)
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit48 x8_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_55.Bits << 8) 
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit8 x8_15, bit48 x16_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_15.Bits << 8) 
                  | ((ulong)x16_63.Bits << 16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit48 x0_47, bit16 x48_63)
        {
            Bits = ((ulong)x0_47.Bits << 0) 
                  | ((ulong)x48_63.Bits << 48);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit16 x0_15, bit48 x16_63)
        {
            Bits = ((ulong)x0_15.Bits << 0) 
                  | ((ulong)x16_63.Bits << 16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit56 x0_55, bit8 x56_63)
        {
            Bits = ((ulong)x0_55.Bits << 0) 
                  | ((ulong)x56_63.Bits << 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bit64(bit8 x0_7, bit56 x8_63)
        {
            Bits = ((ulong)x0_7.Bits << 0) 
                  | ((ulong)x8_63.Bits << 8);
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
            return input.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator long(bit64 input)
        {
            return (long)input.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(bit64 input)
        {
            return *(double*)&input;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit64(ulong input)
        {
            return new bit64 { Bits = input };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit64(long input)
        {
            return new bit64 { Bits = (ulong)input };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit64(double input)
        {
            return *(bit64*)&input;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit64 operator ! (bit64 value)
        {
            value.Bits = ~value.Bits;

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
            left.Bits &= right.Bits;

            return left;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit64 operator | (bit64 left, bit64 right)
        {
            left.Bits |= right.Bits;

            return left;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bit64 operator ^ (bit64 left, bit64 right)
        {
            left.Bits ^= right.Bits;

            return left;
        }


        public bool this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return tobool(BitFieldHelper.Get<Bit>(Bits, index, 64));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Bits = BitFieldHelper.Set<Bit>(Bits, tobyte(value), index, 64);
            }
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit64 SetReplicate(bool value)
        {
            return new bit64(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit64 SetReplicate(int index, int numBits, bool value)
        {
            return new bit64 { Bits = BitFieldHelper.SetReplicate<Bit>(Bits, toint(value), numBits, index, Length) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit64 ResetFirst()
        {
            return new bit64 { Bits = bits_resetlowest(Bits) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit64 ResetFirst(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = bitmask64((ulong)numBits, (ulong)index);
            ulong reset = bits_resetlowest(Bits & mask);
            ulong remaining = andnot(Bits, mask);

            return new bit64 { Bits = reset | remaining };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit64 SetFirst()
        {
            return new bit64 { Bits = bits_setlowest(Bits) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit64 SetFirst(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = bitmask64((ulong)numBits, (ulong)index);
            ulong set = bits_setlowest(~mask | Bits);

            return new bit64 { Bits = bits_select(Bits, set, mask) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit64 ResetLast()
        {
            return new bit64 { Bits = Bits & ((ulong.MaxValue >> 1) >> lzcnt(Bits)) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit64 ResetLast(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);
            
            ulong mask = bitmask64((ulong)numBits, (ulong)index);

            return new bit64 { Bits = andnot(Bits, toulong((Bits & mask) != 0) << (63 - lzcnt(mask & Bits))) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit64 SetLast()
        {
            int leadingOnesCount = lzcnt(~Bits);
            return new bit64 { Bits = Bits | (1ul << ((Length - 1) - leadingOnesCount)) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit64 SetLast(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = bitmask64((ulong)numBits, (ulong)index);
            
            return new bit64 { Bits = Bits | (toulong((Bits & mask) != mask) << (63 - lzcnt(andnot(mask, Bits)))) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit64 ShiftLeft(int amount)
        {
            return new bit64 { Bits = Bits << amount };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit64 ShiftLeft(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = bitmask64((ulong)numBits, (ulong)index);
            ulong maskED = mask & Bits;

            return new bit64 { Bits = bits_select(Bits, maskED << amount, mask) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit64 ShiftRight(int amount)
        {
            return new bit64 { Bits = Bits >> amount };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit64 ShiftRight(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = (ulong)bitmask64(numBits, index);
            ulong maskED = mask & Bits;

            return new bit64 { Bits = bits_select(Bits, maskED >> amount, mask) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit64 RotateLeft(int amount)
        {
            return new bit64 { Bits = rol(Bits, amount) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit64 RotateLeft(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = (ulong)bitmask64(numBits, index);
            ulong maskED = mask & Bits;

            int remainder = (int)((uint)amount % (uint)numBits);

            maskED = (maskED << remainder) | (maskED >> (numBits - remainder));
            
            return new bit64 { Bits = bits_select(Bits, maskED, mask) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit64 RotateRight(int amount)
        {
            return new bit64 { Bits = ror(Bits, amount) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit64 RotateRight(int index, int numBits, int amount)
        {
Assert.IsNonNegative(amount);
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = (ulong)bitmask64(numBits, index);
            ulong maskED = mask & Bits;
            
            int remainder = (int)((uint)amount % (uint)numBits);

            maskED = (maskED >> remainder) | (maskED << (numBits - remainder));
            
            return new bit64 { Bits = bits_select(Bits, maskED, mask) };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit64 Reverse()
        {
            return new bit64 { Bits = reversebits(Bits) };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit64 Reverse(int index, int numBits)
        {
            ulong rev = reversebits(Bits);
            int shift = (int)((ulong)(2 * index + numBits - 64) % 64u); 
            rev = rol(rev, shift); 

            return new bit64 { Bits = bits_select(Bits, rev, bitmask64((ulong)numBits, (ulong)index)) };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit64 Swap(int index0, int index1)
        {
Assert.IsWithinArrayBounds(index0, Length);
Assert.IsWithinArrayBounds(index1, Length);

            ulong bit1 = bits_extract(Bits, index0, 1);
            ulong bit2 = bits_extract(Bits, index1, 1);

            ulong swap = bit1 ^ bit2;
            ulong shifted = (swap << index0) | (swap << index1);

            return new bit64 { Bits = Bits ^ shifted };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit64 Swap(int index0, int index1, int numBits)
        {
Assert.IsValidSubarray(index0, numBits, Length);
Assert.IsValidSubarray(index1, numBits, Length);
Assert.SubarraysDoNotOverlap(index0, index1, numBits, numBits);

            ulong bits1 = bits_extract(Bits, index0, numBits);
            ulong bits2 = bits_extract(Bits, index1, numBits);

            ulong swap = bits1 ^ bits2;
            ulong shifted = (swap << index0) | (swap << index1);

            return new bit64 { Bits = Bits ^ shifted };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit64 Flip()
        {
            return !this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bit64 Flip(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return new bit64 { Bits = Bits ^ bitmask64((ulong)numBits, (ulong)index) };
        }

        
        [return: AssumeRange(0, 64)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int IndexOfFirst()
        {
            return tzcnt(Bits);
        }

        [return: AssumeRange(0, 64)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int IndexOfFirst(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return tzcnt(Bits & bitmask64((ulong)numBits, (ulong)index));
        }

        [return: AssumeRange(-1, 63)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int IndexOfLast()
        {
            return 63 - lzcnt(Bits);
        }

        [return: AssumeRange(-1, 63)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int IndexOfLast(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return 63 - lzcnt(Bits & bitmask64((ulong)numBits, (ulong)index));
        }

        [return: AssumeRange(0ul, 64ul)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint CountBits()
        {
            return (uint)countbits(Bits);
        }

        [return: AssumeRange(0ul, 64ul)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint CountBits(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return (uint)countbits(Bits & (ulong)bitmask64(numBits, index));
        }

        [return: AssumeRange(0ul, 64ul)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int FindString(bool value, int amount)
        {
            return BitAlgorithms.Find1String(value ? Bits : ~Bits, amount);
        }

        [return: AssumeRange(0ul, 64ul)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int FindString(int index, int numBits, bool value, int amount)
        {
Assert.IsValidSubarray(index, numBits, Length);
            
            ulong mask = bitmask64((ulong)numBits, (ulong)index);

            return BitAlgorithms.Find1String(value ? (mask & Bits) : andnot(mask, Bits), amount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAll()
        {
            return Bits == ulong.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAll(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            ulong mask = (ulong)bitmask64(numBits, index);

            return (Bits & mask) == mask;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAny()
        {
            return Bits != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAny(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return (Bits & (ulong)bitmask64(numBits, index)) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestNone()
        {
            return Bits == 0ul;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestNone(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);

            return (Bits & (ulong)bitmask64(numBits, index)) == 0ul;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestNotAll()
        {
            return Bits != ulong.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestNotAll(int index, int numBits)
        {
Assert.IsValidSubarray(index, numBits, Length);
            
            ulong mask = (ulong)bitmask64(numBits, index);

            return (Bits & mask) != mask;
        }


        public override readonly string ToString()
        {
            return Dump.Bits(this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
            return Bits.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(bit64 other)
        {
            return this.Bits == other.Bits;
        }
        public override readonly bool Equals(object obj)
        {
            return obj is bit64 converted && this.Equals(converted);
        }
        public readonly IEnumerator<bool> GetEnumerator()
        {
            return new ArrayEnumerator<bit64, bool>(this);
        }
        readonly IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<bit64, bool>(this);
        }
    }
}