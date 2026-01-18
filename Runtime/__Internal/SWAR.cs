using System.Runtime.CompilerServices;
using Unity.Mathematics;
using MaxMath;
using MaxMath.Intrinsics;

using static Unity.Mathematics.math;
using static MaxMath.maxmath;

namespace BitCollections
{
    internal static class SWAR
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte SignBitMask8<T>()
            where T : BitInt
        {
            return (byte)BitFieldHelper.Replicate<T>(1u << (default(T).Bits - 1));
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort SignBitMask16<T>()
            where T : BitInt
        {
            return (ushort)BitFieldHelper.Replicate<T>(1u << (default(T).Bits - 1));
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint SignBitMask32<T>()
            where T : BitInt
        {
            return BitFieldHelper.Replicate<T>(1u << (default(T).Bits - 1));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong SignBitMask64<T>()
            where T : BitInt
        {
            return BitFieldHelper.Replicate<T>(1ul << (default(T).Bits - 1));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte OneMask8<T>()
            where T : BitInt
        {
            return (byte)BitFieldHelper.Replicate<T>(1u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort OneMask16<T>()
            where T : BitInt
        {
            return (ushort)BitFieldHelper.Replicate<T>(1u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint OneMask32<T>()
            where T : BitInt
        {
            return BitFieldHelper.Replicate<T>(1u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong OneMask64<T>()
            where T : BitInt
        {
            return BitFieldHelper.Replicate<T>(1ul);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte Broadcast8<T>(byte a)
            where T : BitInt
        {
            if (default(T).Bits == 1)
            {
                return (byte)(0 - a);
            }
            else
            {
                return (byte)(a * OneMask32<T>());
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort Broadcast16<T>(ushort a)
            where T : BitInt
        {
            if (default(T).Bits == 1)
            {
                return (ushort)(0 - a);
            }
            else
            {
                return (ushort)(a * OneMask32<T>());
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint Broadcast32<T>(uint a)
            where T : BitInt
        {
            if (default(T).Bits == 1)
            {
                return 0 - a;
            }
            else
            {
                return a * OneMask32<T>();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong Broadcast64<T>(ulong a)
            where T : BitInt
        {
            if (default(T).Bits == 1)
            {
                return 0 - a;
            }
            else
            {
                return a * OneMask64<T>();
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte Neg<T>(byte a)
            where T : BitInt
        {
            byte SIGN_BITS = SignBitMask8<T>();

            return (byte)((byte)(SIGN_BITS - andnot(a, SIGN_BITS)) ^ andnot(SIGN_BITS, a));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort Neg<T>(ushort a)
            where T : BitInt
        {
            ushort SIGN_BITS = SignBitMask16<T>();
            
            return (ushort)((ushort)(SIGN_BITS - andnot(a, SIGN_BITS)) ^ andnot(SIGN_BITS, a));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint Neg<T>(uint a)
            where T : BitInt
        {
            uint SIGN_BITS = SignBitMask32<T>();
            
            return (SIGN_BITS - andnot(a, SIGN_BITS)) ^ andnot(SIGN_BITS, a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong Neg<T>(ulong a)
            where T : BitInt
        {
            ulong SIGN_BITS = SignBitMask64<T>();
            
            return (SIGN_BITS - andnot(a, SIGN_BITS)) ^ andnot(SIGN_BITS, a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint4 Neg<T>(uint4 a)
            where T : BitInt
        {
            uint4 SIGN_BITS = SignBitMask32<T>();
            
            return (SIGN_BITS - andnot(a, SIGN_BITS)) ^ andnot(SIGN_BITS, a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint8 Neg<T>(uint8 a)
            where T : BitInt
        {
            uint8 SIGN_BITS = SignBitMask32<T>();
            
            return (SIGN_BITS - andnot(a, SIGN_BITS)) ^ andnot(SIGN_BITS, a);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte NegBool<T>(byte a)
            where T : BitInt
        {
            if (default(T).Bits == 2)
            {
                return (byte)(a | (byte)(a + a));
            }
            else
            {
                return (byte)(a * bitmask8((uint)default(T).Bits));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort NegBool<T>(ushort a)
            where T : BitInt
        {
            if (default(T).Bits == 2)
            {
                return (ushort)(a | (ushort)(a + a));
            }
            else
            {
                return (ushort)(a * bitmask16((uint)default(T).Bits));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint NegBool<T>(uint a)
            where T : BitInt
        {
            if (default(T).Bits == 2)
            {
                return a | (a + a);
            }
            else
            {
                return a * bitmask32((uint)default(T).Bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong NegBool<T>(ulong a)
            where T : BitInt
        {
            if (default(T).Bits == 2)
            {
                return a | (a + a);
            }
            else
            {
                return a * bitmask64((ulong)default(T).Bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint4 NegBool<T>(uint4 a)
            where T : BitInt
        {
            if (default(T).Bits == 2)
            {
                return a | (a + a);
            }
            else
            {
                return a * bitmask32((uint)default(T).Bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint8 NegBool<T>(uint8 a)
            where T : BitInt
        {
            if (default(T).Bits == 2)
            {
                return a | (a + a);
            }
            else
            {
                return a * bitmask32((uint)default(T).Bits);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int CountBools<T>(byte a)
            where T : BitInt
        {
            return countbits(a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int CountBools<T>(ushort a)
            where T : BitInt
        {
            return countbits(a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int CountBools<T>(uint a)
            where T : BitInt
        {
            return countbits(a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int CountBools<T>(ulong a)
            where T : BitInt
        {
            return countbits(a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int CountBools<T>(uint4 a)
            where T : BitInt
        {
            return CountBools<T>(a.GetField<uint4, ulong>(0)) 
                 + CountBools<T>(a.GetField<uint4, ulong>(1));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int CountBools<T>(uint8 a)
            where T : BitInt
        {
            return CountBools<T>(a.GetField<uint8, ulong>(0)) 
                 + CountBools<T>(a.GetField<uint8, ulong>(1)) 
                 + CountBools<T>(a.GetField<uint8, ulong>(2)) 
                 + CountBools<T>(a.GetField<uint8, ulong>(3));
        }
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte Abs<T>(byte a)
            where T : BitInt
        {
            if (default(T).Bits == 2)
            {
                byte isNeg1asNeg2 = (byte)(a & ShiftLeftLogical<T>(a, 1));

                return andnot(a, isNeg1asNeg2);
            }

            byte mask = ShiftRightLogical<T>(a, default(T).Bits - 1);
            
            return Add<T>((byte)(a ^ NegBool<T>(mask)), mask);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort Abs<T>(ushort a)
            where T : BitInt
        {
            if (default(T).Bits == 2)
            {
                ushort isNeg1asNeg2 = (ushort)(a & ShiftLeftLogical<T>(a, 1));

                return andnot(a, isNeg1asNeg2);
            }

            ushort mask = ShiftRightLogical<T>(a, default(T).Bits - 1);
            
            return Add<T>((ushort)(a ^ NegBool<T>(mask)), mask);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint Abs<T>(uint a)
            where T : BitInt
        {
            if (default(T).Bits == 2)
            {
                uint isNeg1asNeg2 = a & ShiftLeftLogical<T>(a, 1);

                return andnot(a, isNeg1asNeg2);
            }

            uint mask = ShiftRightLogical<T>(a, default(T).Bits - 1);
            
            return Add<T>(a ^ NegBool<T>(mask), mask);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong Abs<T>(ulong a)
            where T : BitInt
        {
            if (default(T).Bits == 2)
            {
                ulong isNeg1asNeg2 = a & ShiftLeftLogical<T>(a, 1);

                return andnot(a, isNeg1asNeg2);
            }

            ulong mask = ShiftRightLogical<T>(a, default(T).Bits - 1);
            
            return Add<T>(a ^ NegBool<T>(mask), mask);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint4 Abs<T>(uint4 a)
            where T : BitInt
        {
            if (default(T).Bits == 2)
            {
                uint4 isNeg1asNeg2 = a & ShiftLeftLogical<T>(a, 1);

                return andnot(a, isNeg1asNeg2);
            }

            uint4 mask = ShiftRightLogical<T>(a, default(T).Bits - 1);
            
            return Add<T>(a ^ NegBool<T>(mask), mask);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint8 Abs<T>(uint8 a)
            where T : BitInt
        {
            if (default(T).Bits == 2)
            {
                uint8 isNeg1asNeg2 = a & ShiftLeftLogical<T>(a, 1);

                return andnot(a, isNeg1asNeg2);
            }

            uint8 mask = ShiftRightLogical<T>(a, default(T).Bits - 1);
            
            return Add<T>(a ^ NegBool<T>(mask), mask);
        }
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte Add<T>(byte a, byte b)
            where T : BitInt
        {
            if (constexpr.IS_TRUE(a == b))
            {
                return ShiftLeftLogical<T>(a, 1);
            }

            byte SIGN_BITS = SignBitMask8<T>();

            return (byte)((byte)(andnot(a, SIGN_BITS) + andnot(b, SIGN_BITS)) ^ (byte)((byte)(a ^ b) & SIGN_BITS));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort Add<T>(ushort a, ushort b)
            where T : BitInt
        {
            if (constexpr.IS_TRUE(a == b))
            {
                return ShiftLeftLogical<T>(a, 1);
            }

            ushort SIGN_BITS = (ushort)SignBitMask64<T>();

            return (ushort)((ushort)(andnot(a, SIGN_BITS) + andnot(b, SIGN_BITS)) ^ (ushort)((ushort)(a ^ b) & SIGN_BITS));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint Add<T>(uint a, uint b)
            where T : BitInt
        {
            if (constexpr.IS_TRUE(a == b))
            {
                return ShiftLeftLogical<T>(a, 1);
            }

            uint SIGN_BITS = (uint)SignBitMask32<T>();

            return (andnot(a, SIGN_BITS) + andnot(b, SIGN_BITS)) ^ ((a ^ b) & SIGN_BITS);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong Add<T>(ulong a, ulong b)
            where T : BitInt
        {
            if (constexpr.IS_TRUE(a == b))
            {
                return ShiftLeftLogical<T>(a, 1);
            }

            ulong SIGN_BITS = SignBitMask64<T>();

            return (andnot(a, SIGN_BITS) + andnot(b, SIGN_BITS)) ^ ((a ^ b) & SIGN_BITS);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint4 Add<T>(uint4 a, uint4 b)
            where T : BitInt
        {
            if (constexpr.IS_TRUE(a.Equals(b)))
            {
                return ShiftLeftLogical<T>(a, 1);
            }

            uint SIGN_BITS = (uint)SignBitMask32<T>();

            return (andnot(a, SIGN_BITS) + andnot(b, SIGN_BITS)) ^ ((a ^ b) & SIGN_BITS);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint8 Add<T>(uint8 a, uint8 b)
            where T : BitInt
        {
            if (constexpr.IS_TRUE(a.Equals(b)))
            {
                return ShiftLeftLogical<T>(a, 1);
            }

            uint8 SIGN_BITS = (uint)SignBitMask32<T>();

            return (andnot(a, SIGN_BITS) + andnot(b, SIGN_BITS)) ^ ((a ^ b) & SIGN_BITS);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte Sub<T>(byte a, byte b)
            where T : BitInt
        {
            byte SIGN_BITS = SignBitMask8<T>();

            return (byte)((byte)((byte)(a | SIGN_BITS) - andnot(b, SIGN_BITS)) ^ (byte)((byte)(a ^ ~b) & SIGN_BITS));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort Sub<T>(ushort a, ushort b)
            where T : BitInt
        {
            ushort SIGN_BITS = SignBitMask16<T>();

            return (ushort)((ushort)((ushort)(a | SIGN_BITS) - andnot(b, SIGN_BITS)) ^ (ushort)((ushort)(a ^ ~b) & SIGN_BITS));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint Sub<T>(uint a, uint b)
            where T : BitInt
        {
            uint SIGN_BITS = (uint)SignBitMask32<T>();

            return ((a | SIGN_BITS) - andnot(b, SIGN_BITS)) ^ ((a ^ ~b) & SIGN_BITS);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong Sub<T>(ulong a, ulong b)
            where T : BitInt
        {
            ulong SIGN_BITS = SignBitMask64<T>();

            return ((a | SIGN_BITS) - andnot(b, SIGN_BITS)) ^ ((a ^ ~b) & SIGN_BITS);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint4 Sub<T>(uint4 a, uint4 b)
            where T : BitInt
        {
            uint4 SIGN_BITS = (uint)SignBitMask32<T>();

            return ((a | SIGN_BITS) - andnot(b, SIGN_BITS)) ^ ((a ^ ~b) & SIGN_BITS);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint8 Sub<T>(uint8 a, uint8 b)
            where T : BitInt
        {
            uint8 SIGN_BITS = (uint)SignBitMask32<T>();

            return ((a | SIGN_BITS) - andnot(b, SIGN_BITS)) ^ ((a ^ ~b) & SIGN_BITS);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte ShiftLeftLogical<T>(byte a, int n)
            where T : BitInt
        {
            if (constexpr.IS_TRUE(n == 0))
            {
                return a;
            }

            byte MASK = (byte)((bitmask8((uint)default(T).Bits) << n) & bitmask8((uint)default(T).Bits));

            return (byte)((byte)(a << n) & Broadcast8<T>(MASK));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort ShiftLeftLogical<T>(ushort a, int n)
            where T : BitInt
        {
            if (constexpr.IS_TRUE(n == 0))
            {
                return a;
            }

            ushort MASK = (ushort)((bitmask16((uint)default(T).Bits) << n) & bitmask16((uint)default(T).Bits));

            return (ushort)((ushort)(a << n) & Broadcast16<T>(MASK));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint ShiftLeftLogical<T>(uint a, int n)
            where T : BitInt
        {
            if (constexpr.IS_TRUE(n == 0))
            {
                return a;
            }

            uint MASK = (bitmask32((uint)default(T).Bits) << n) & bitmask32((uint)default(T).Bits);

            return (a << n) & Broadcast32<T>(MASK);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong ShiftLeftLogical<T>(ulong a, int n)
            where T : BitInt
        {
            if (constexpr.IS_TRUE(n == 0))
            {
                return a;
            }

            ulong MASK = (bitmask64((ulong)default(T).Bits) << n) & bitmask64((ulong)default(T).Bits);

            return (a << n) & Broadcast64<T>(MASK);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint4 ShiftLeftLogical<T>(uint4 a, int n)
            where T : BitInt
        {
            if (constexpr.IS_TRUE(n == 0))
            {
                return a;
            }

            uint MASK = (bitmask32((uint)default(T).Bits) << n) & bitmask32((uint)default(T).Bits);

            return (a << n) & Broadcast32<T>(MASK);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint8 ShiftLeftLogical<T>(uint8 a, int n)
            where T : BitInt
        {
            if (constexpr.IS_TRUE(n == 0))
            {
                return a;
            }

            uint MASK = (bitmask32((uint)default(T).Bits) << n) & bitmask32((uint)default(T).Bits);

            return (a << n) & Broadcast32<T>(MASK);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte ShiftRightLogical<T>(byte a, int n)
            where T : BitInt
        {
            if (constexpr.IS_TRUE(n == 0))
            {
                return a;
            }

            byte MASK = (byte)(bitmask8((uint)default(T).Bits) >> n);

            return (byte)((byte)(a >> n) & Broadcast8<T>(MASK));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort ShiftRightLogical<T>(ushort a, int n)
            where T : BitInt
        {
            if (constexpr.IS_TRUE(n == 0))
            {
                return a;
            }

            ushort MASK = (ushort)(bitmask16((uint)default(T).Bits) >> n);

            return (ushort)((ushort)(a >> n) & Broadcast16<T>(MASK));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint ShiftRightLogical<T>(uint a, int n)
            where T : BitInt
        {
            if (constexpr.IS_TRUE(n == 0))
            {
                return a;
            }

            uint MASK = bitmask32((uint)default(T).Bits) >> n;

            return (a >> n) & Broadcast32<T>(MASK);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong ShiftRightLogical<T>(ulong a, int n)
            where T : BitInt
        {
            if (constexpr.IS_TRUE(n == 0))
            {
                return a;
            }

            ulong MASK = bitmask64((ulong)default(T).Bits) >> n;

            return (a >> n) & Broadcast64<T>(MASK);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint4 ShiftRightLogical<T>(uint4 a, int n)
            where T : BitInt
        {
            if (constexpr.IS_TRUE(n == 0))
            {
                return a;
            }

            uint MASK = bitmask32((uint)default(T).Bits) >> n;

            return (a >> n) & Broadcast32<T>(MASK);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint8 ShiftRightLogical<T>(uint8 a, int n)
            where T : BitInt
        {
            if (constexpr.IS_TRUE(n == 0))
            {
                return a;
            }

            uint MASK = bitmask32((uint)default(T).Bits) >> n;

            return (a >> n) & Broadcast32<T>(MASK);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte ShiftRightArithmetic<T>(byte a, int n)
            where T : BitInt
        {
            if (constexpr.IS_TRUE(n == 0))
            {
                return a;
            }

            if (default(T).Bits == 2)
            {
                return n == 0 ? a
                              : (byte)((a & SignBitMask8<Int2>()) | ShiftRightLogical<T>(a, 1));
            }

            if (default(T).Bits == 3)
            {
                byte signBit = (byte)(a & SignBitMask8<Int3>());
                byte shr1 = (byte)(signBit | ShiftRightLogical<T>(a, 1));
                byte shr2 = (byte)((byte)(ShiftRightLogical<T>(a, 2) | signBit) | (byte)(signBit >> 1));
                
                byte result = n != 0 ? shr1 : a;
                result      = n == 2 ? shr2 : result;
                
                return result;
            }

            byte MASK = (byte)(bitmask8((uint)default(T).Bits) >> n);
            
            byte signBits = NegBool<T>(ShiftRightLogical<T>(a, default(T).Bits - 1));
            byte logical = ShiftRightLogical<T>(a, n);

            return bits_select(signBits, logical, Broadcast8<T>(MASK));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort ShiftRightArithmetic<T>(ushort a, int n)
            where T : BitInt
        {
            if (constexpr.IS_TRUE(n == 0))
            {
                return a;
            }

            if (default(T).Bits == 2)
            {
                return n == 0 ? a
                              : (ushort)((a & SignBitMask16<Int2>()) | ShiftRightLogical<T>(a, 1));
            }

            if (default(T).Bits == 3)
            {
                ushort signBit = (ushort)(a & SignBitMask16<Int3>());
                ushort shr1 = (ushort)(signBit | ShiftRightLogical<T>(a, 1));
                ushort shr2 = (ushort)((ushort)(ShiftRightLogical<T>(a, 2) | signBit) | (ushort)(signBit >> 1));
                
                ushort result = n != 0 ? shr1 : a;
                result        = n == 2 ? shr2 : result;
                
                return result;
            }

            ushort MASK = (ushort)(bitmask16((uint)default(T).Bits) >> n);
            
            ushort signBits = NegBool<T>(ShiftRightLogical<T>(a, default(T).Bits - 1));
            ushort logical = ShiftRightLogical<T>(a, n);

            return bits_select(signBits, logical, Broadcast16<T>(MASK));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint ShiftRightArithmetic<T>(uint a, int n)
            where T : BitInt
        {
            if (constexpr.IS_TRUE(n == 0))
            {
                return a;
            }

            if (default(T).Bits == 2)
            {
                return n == 0 ? a
                              : (a & SignBitMask32<Int2>()) | ShiftRightLogical<T>(a, 1);
            }

            if (default(T).Bits == 3)
            {
                uint signBit = a & SignBitMask32<Int3>();
                uint shr1 = signBit | ShiftRightLogical<T>(a, 1);
                uint shr2 = signBit | (signBit >> 1) | ShiftRightLogical<T>(a, 2);
                
                uint result = n != 0 ? shr1 : a;
                result      = n == 2 ? shr2 : result;
                
                return result;
            }

            uint MASK = bitmask32((uint)default(T).Bits) >> n;
            
            uint signBits = NegBool<T>(ShiftRightLogical<T>(a, default(T).Bits - 1));
            uint logical = ShiftRightLogical<T>(a, n);

            return bits_select(signBits, logical, Broadcast32<T>(MASK));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong ShiftRightArithmetic<T>(ulong a, int n)
            where T : BitInt
        {
            if (constexpr.IS_TRUE(n == 0))
            {
                return a;
            }

            if (default(T).Bits == 2)
            {
                return n == 0 ? a
                              : (a & SignBitMask64<Int2>()) | ShiftRightLogical<T>(a, 1);
            }

            if (default(T).Bits == 3)
            {
                ulong signBit = a & SignBitMask64<Int3>();
                ulong shr1 = signBit | ShiftRightLogical<T>(a, 1);
                ulong shr2 = signBit | (signBit >> 1) | ShiftRightLogical<T>(a, 2);
                
                ulong result = n != 0 ? shr1 : a;
                result       = n == 2 ? shr2 : result;
                
                return result;
            }

            ulong MASK = bitmask64((ulong)default(T).Bits) >> n;
            
            ulong signBits = NegBool<T>(ShiftRightLogical<T>(a, default(T).Bits - 1));
            ulong logical = ShiftRightLogical<T>(a, n);

            return bits_select(signBits, logical, Broadcast64<T>(MASK));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint4 ShiftRightArithmetic<T>(uint4 a, int n)
            where T : BitInt
        {
            if (constexpr.IS_TRUE(n == 0))
            {
                return a;
            }

            if (default(T).Bits == 2)
            {
                return n == 0 ? a
                              : (a & SignBitMask32<Int2>()) | ShiftRightLogical<T>(a, 1);
            }

            if (default(T).Bits == 3)
            {
                uint4 signBit = a & SignBitMask32<Int3>();
                uint4 shr1 = signBit | ShiftRightLogical<T>(a, 1);
                uint4 shr2 = signBit | (signBit >> 1) | ShiftRightLogical<T>(a, 2);
                
                uint4 result = n != 0 ? shr1 : a;
                result       = n == 2 ? shr2 : result;
                
                return result;
            }

            uint MASK = bitmask32((uint)default(T).Bits) >> n;
            
            uint4 signBits = NegBool<T>(ShiftRightLogical<T>(a, default(T).Bits - 1));
            uint4 logical = ShiftRightLogical<T>(a, n);

            return bits_select(signBits, logical, Broadcast32<T>(MASK));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint8 ShiftRightArithmetic<T>(uint8 a, int n)
            where T : BitInt
        {
            if (constexpr.IS_TRUE(n == 0))
            {
                return a;
            }

            if (default(T).Bits == 2)
            {
                return n == 0 ? a
                              : (a & SignBitMask32<Int2>()) | ShiftRightLogical<T>(a, 1);
            }

            if (default(T).Bits == 3)
            {
                uint8 signBit = a & SignBitMask32<Int3>();
                uint8 shr1 = signBit | ShiftRightLogical<T>(a, 1);
                uint8 shr2 = signBit | (signBit >> 1) | ShiftRightLogical<T>(a, 2);
                
                uint8 result = n != 0 ? shr1 : a;
                result       = n == 2 ? shr2 : result;
                
                return result;
            }

            uint MASK = bitmask32((uint)default(T).Bits) >> n;
            
            uint8 signBits = NegBool<T>(ShiftRightLogical<T>(a, default(T).Bits - 1));
            uint8 logical = ShiftRightLogical<T>(a, n);

            return bits_select(signBits, logical, Broadcast32<T>(MASK));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte Mul<T>(byte a, byte b)
            where T : BitInt
        {
            byte acc = 0;
            byte bit;
            byte mask;
            byte add;
            for (int i = 0; i < default(T).Bits - 1; i++) 
            {
                bit = (byte)((byte)(b >> i) & OneMask8<T>());
                mask = NegBool<T>(bit);
                add = (byte)(ShiftLeftLogical<T>(a, i) & mask);
                acc = i == 0 ? add : Add<T>(acc, add);
            }
            
            bit = (byte)(b & SignBitMask16<T>());
            acc ^= (byte)((byte)(a << (default(T).Bits - 1)) & bit);

            return acc;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort Mul<T>(ushort a, ushort b)
            where T : BitInt
        {
            ushort acc = 0;
            ushort bit;
            ushort mask;
            ushort add;
            for (int i = 0; i < default(T).Bits - 1; i++) 
            {
                bit = (ushort)((ushort)(b >> i) & OneMask16<T>());
                mask = NegBool<T>(bit);
                add = (ushort)(ShiftLeftLogical<T>(a, i) & mask);
                acc = i == 0 ? add : Add<T>(acc, add);
            }
            
            bit = (ushort)(b & SignBitMask16<T>());
            acc ^= (ushort)((ushort)(a << (default(T).Bits - 1)) & bit);

            return acc;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint Mul<T>(uint a, uint b)
            where T : BitInt
        {
            uint acc = 0;
            uint bit;
            uint mask;
            uint add;
            for (int i = 0; i < default(T).Bits - 1; i++) 
            {
                bit = (b >> i) & OneMask32<T>();
                mask = NegBool<T>(bit);
                add = ShiftLeftLogical<T>(a, i) & mask;
                acc = i == 0 ? add : Add<T>(acc, add);
            }
            
            bit = b & SignBitMask32<T>();
            acc ^= (a << (default(T).Bits - 1)) & bit;

            return acc;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong Mul<T>(ulong a, ulong b)
            where T : BitInt
        {
            ulong acc = 0;
            ulong bit;
            ulong mask;
            ulong add;
            for (int i = 0; i < default(T).Bits - 1; i++) 
            {
                bit = (b >> i) & OneMask64<T>();
                mask = NegBool<T>(bit);
                add = ShiftLeftLogical<T>(a, i) & mask;
                acc = i == 0 ? add : Add<T>(acc, add);
            }
            
            bit = b & SignBitMask64<T>();
            acc ^= (a << (default(T).Bits - 1)) & bit;

            return acc;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint4 Mul<T>(uint4 a, uint b)
            where T : BitInt
        {
            uint4 acc = 0;
            uint4 bit;
            uint4 mask;
            uint4 add;
            for (int i = 0; i < default(T).Bits - 1; i++) 
            {
                bit = (b >> i) & OneMask32<T>();
                mask = NegBool<T>(bit);
                add = ShiftLeftLogical<T>(a, i) & mask;
                acc = i == 0 ? add : Add<T>(acc, add);
            }
            
            bit = b & SignBitMask32<T>();
            acc ^= (a << (default(T).Bits - 1)) & bit;

            return acc;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint8 Mul<T>(uint8 a, uint b)
            where T : BitInt
        {
            uint8 acc = 0;
            uint8 bit;
            uint8 mask;
            uint8 add;
            for (int i = 0; i < default(T).Bits - 1; i++) 
            {
                bit = (b >> i) & OneMask32<T>();
                mask = NegBool<T>(bit);
                add = ShiftLeftLogical<T>(a, i) & mask;
                acc = i == 0 ? add : Add<T>(acc, add);
            }
            
            bit = b & SignBitMask32<T>();
            acc ^= (a << (default(T).Bits - 1)) & bit;

            return acc;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bool ConstMul<T>(byte a, byte n, out byte result)
            where T : BitInt
        {
            if (!constexpr.IS_CONST(n))
            {
                result = 0;
                return false;
            }

            if (n == 0)
            {
                result = 0;
                return true;
            }
            if (n == 1)
            {
                result = a;
                return true;
            }

            byte cpy = n;
            int bits = countbits(n);
            
            if (constexpr.IS_CONST(bits) & bits <= 2)
            {
                int tz0 = tzcnt(cpy);
                result = ShiftLeftLogical<T>(a, tz0);
            
                if (constexpr.IS_CONST(tz0) & bits == 1)
                {
                    return true;
                }
            
                cpy ^= (byte)(1u << tz0);
                int tz1 = tzcnt(cpy);
                result = Add<T>(result, ShiftLeftLogical<T>(a, tz1));
            
                if (constexpr.IS_CONST(tz1) & bits == 2)
                {
                    return true;
                }
            }

            result = 0;
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bool ConstMul<T>(ushort a, ushort n, out ushort result)
            where T : BitInt
        {
            if (!constexpr.IS_CONST(n))
            {
                result = 0;
                return false;
            }

            if (n == 0)
            {
                result = 0;
                return true;
            }
            if (n == 1)
            {
                result = a;
                return true;
            }

            ushort cpy = n;
            int bits = countbits(n);
            
            if (constexpr.IS_CONST(bits) & bits <= 2)
            {
                int tz0 = tzcnt(cpy);
                result = ShiftLeftLogical<T>(a, tz0);
            
                if (constexpr.IS_CONST(tz0) & bits == 1)
                {
                    return true;
                }
            
                cpy ^= (ushort)(1u << tz0);
                int tz1 = tzcnt(cpy);
                result = Add<T>(result, ShiftLeftLogical<T>(a, tz1));
            
                if (constexpr.IS_CONST(tz1) & bits == 2)
                {
                    return true;
                }
            }

            result = 0;
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bool ConstMul<T>(uint a, uint n, out uint result)
            where T : BitInt
        {
            if (!constexpr.IS_CONST(n))
            {
                result = 0;
                return false;
            }

            if (n == 0)
            {
                result = 0;
                return true;
            }
            if (n == 1)
            {
                result = a;
                return true;
            }

            uint cpy = n;
            int bits = countbits(n);
            
            if (constexpr.IS_CONST(bits) & bits <= 2)
            {
                int tz0 = tzcnt(cpy);
                result = ShiftLeftLogical<T>(a, tz0);
            
                if (constexpr.IS_CONST(tz0) & bits == 1)
                {
                    return true;
                }
            
                cpy ^= 1u << tz0;
                int tz1 = tzcnt(cpy);
                result = Add<T>(result, ShiftLeftLogical<T>(a, tz1));
            
                if (constexpr.IS_CONST(tz1) & bits == 2)
                {
                    return true;
                }
            }

            result = 0;
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bool ConstMul<T>(ulong a, ulong n, out ulong result)
            where T : BitInt
        {
            if (!constexpr.IS_CONST(n))
            {
                result = 0;
                return false;
            }

            if (n == 0)
            {
                result = 0;
                return true;
            }
            if (n == 1)
            {
                result = a;
                return true;
            }

            ulong cpy = n;
            int bits = countbits(n);
            
            if (constexpr.IS_CONST(bits) & bits <= 2)
            {
                int tz0 = tzcnt(cpy);
                result = ShiftLeftLogical<T>(a, tz0);
            
                if (constexpr.IS_CONST(tz0) & bits == 1)
                {
                    return true;
                }
            
                cpy ^= 1ul << tz0;
                int tz1 = tzcnt(cpy);
                result = Add<T>(result, ShiftLeftLogical<T>(a, tz1));
            
                if (constexpr.IS_CONST(tz1) & bits == 2)
                {
                    return true;
                }
            }

            result = 0;
            return false;
        }
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte DivRem<T>(byte a, byte b, out byte remainder)
            where T : BitInt
        {
            byte negRemainder = ShiftRightLogical<T>(a, default(T).Bits - 1);
            byte negQuotient = ShiftRightLogical<T>((byte)(a ^ b), default(T).Bits - 1);
            if (default(T).IsSigned)
            {
                a = Abs<T>(a);
                b = Abs<T>(b);
            }
            
            remainder = ShiftRightLogical<T>(a, default(T).Bits - 1);
            byte subtractFromRemainder = (byte)(Equals<T>(b, OneMask8<T>()) & remainder);
            remainder -= (byte)(b & NegBool<T>(subtractFromRemainder));
            byte quotients = subtractFromRemainder;

            for (int i = default(T).Bits - 2; i >= 0; i--)
            {
                remainder <<= 1;
                quotients <<= 1;
                remainder |= (byte)(OneMask8<T>() & (byte)(a >> i));
                subtractFromRemainder = GreaterThan<T>(b, remainder, forceUnsigned: true);
                remainder -= andnot(b, NegBool<T>(subtractFromRemainder));
                quotients += (byte)(OneMask8<T>() ^ subtractFromRemainder);
            }
            
            if (default(T).IsSigned)
            {
                remainder = Add<T>((byte)(remainder ^ NegBool<T>(negRemainder)), negRemainder);
                quotients = Add<T>((byte)(quotients ^ NegBool<T>(negQuotient)), negQuotient);
            }

            return quotients;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort DivRem<T>(ushort a, ushort b, out ushort remainder)
            where T : BitInt
        {
            ushort negRemainder = ShiftRightLogical<T>(a, default(T).Bits - 1);
            ushort negQuotient = ShiftRightLogical<T>((ushort)(a ^ b), default(T).Bits - 1);
            if (default(T).IsSigned)
            {
                a = Abs<T>(a);
                b = Abs<T>(b);
            }
            
            remainder = ShiftRightLogical<T>(a, default(T).Bits - 1);
            ushort subtractFromRemainder = (ushort)(Equals<T>(b, OneMask16<T>()) & remainder);
            remainder -= (ushort)(b & NegBool<T>(subtractFromRemainder));
            ushort quotients = subtractFromRemainder;

            for (int i = default(T).Bits - 2; i >= 0; i--)
            {
                remainder <<= 1;
                quotients <<= 1;
                remainder |= (ushort)(OneMask16<T>() & (ushort)(a >> i));
                subtractFromRemainder = GreaterThan<T>(b, remainder, forceUnsigned: true);
                remainder -= andnot(b, NegBool<T>(subtractFromRemainder));
                quotients += (ushort)(OneMask16<T>() ^ subtractFromRemainder);
            }
            
            if (default(T).IsSigned)
            {
                remainder = Add<T>((ushort)(remainder ^ NegBool<T>(negRemainder)), negRemainder);
                quotients = Add<T>((ushort)(quotients ^ NegBool<T>(negQuotient)), negQuotient);
            }

            return quotients;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint DivRem<T>(uint a, uint b, out uint remainder)
            where T : BitInt
        {
            uint negRemainder = ShiftRightLogical<T>(a, default(T).Bits - 1);
            uint negQuotient = ShiftRightLogical<T>(a ^ b, default(T).Bits - 1);
            if (default(T).IsSigned)
            {
                a = Abs<T>(a);
                b = Abs<T>(b);
            }
            
            remainder = ShiftRightLogical<T>(a, default(T).Bits - 1);
            uint subtractFromRemainder = Equals<T>(b, OneMask32<T>()) & remainder;
            remainder -= b & NegBool<T>(subtractFromRemainder);
            uint quotients = subtractFromRemainder;

            for (int i = default(T).Bits - 2; i >= 0; i--)
            {
                remainder <<= 1;
                quotients <<= 1;
                remainder |= OneMask32<T>() & (a >> i);
                subtractFromRemainder = GreaterThan<T>(b, remainder, forceUnsigned: true);
                remainder -= andnot(b, NegBool<T>(subtractFromRemainder));
                quotients += OneMask32<T>() ^ subtractFromRemainder;
            }
            
            if (default(T).IsSigned)
            {
                remainder = Add<T>(remainder ^ NegBool<T>(negRemainder), negRemainder);
                quotients = Add<T>(quotients ^ NegBool<T>(negQuotient), negQuotient);
            }

            return quotients;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong DivRem<T>(ulong a, ulong b, out ulong remainder)
            where T : BitInt
        {
            ulong negRemainder = ShiftRightLogical<T>(a, default(T).Bits - 1);
            ulong negQuotient = ShiftRightLogical<T>(a ^ b, default(T).Bits - 1);
            if (default(T).IsSigned)
            {
                a = Abs<T>(a);
                b = Abs<T>(b);
            }
            
            remainder = ShiftRightLogical<T>(a, default(T).Bits - 1);
            ulong subtractFromRemainder = Equals<T>(b, OneMask64<T>()) & remainder;
            remainder -= b & NegBool<T>(subtractFromRemainder);
            ulong quotients = subtractFromRemainder;

            for (int i = default(T).Bits - 2; i >= 0; i--)
            {
                remainder <<= 1;
                quotients <<= 1;
                remainder |= OneMask64<T>() & (a >> i);
                subtractFromRemainder = GreaterThan<T>(b, remainder, forceUnsigned: true);
                remainder -= andnot(b, NegBool<T>(subtractFromRemainder));
                quotients += OneMask64<T>() ^ subtractFromRemainder;
            }
            
            if (default(T).IsSigned)
            {
                remainder = Add<T>(remainder ^ NegBool<T>(negRemainder), negRemainder);
                quotients = Add<T>(quotients ^ NegBool<T>(negQuotient), negQuotient);
            }

            return quotients;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint4 DivRem<T>(uint4 a, uint4 b, out uint4 remainder)
            where T : BitInt
        {
            uint4 negRemainder = ShiftRightLogical<T>(a, default(T).Bits - 1);
            uint4 negQuotient = ShiftRightLogical<T>(a ^ b, default(T).Bits - 1);
            if (default(T).IsSigned)
            {
                a = Abs<T>(a);
                b = Abs<T>(b);
            }
            
            remainder = ShiftRightLogical<T>(a, default(T).Bits - 1);
            uint4 subtractFromRemainder = Equals<T>(b, OneMask32<T>()) & remainder;
            remainder -= b & NegBool<T>(subtractFromRemainder);
            uint4 quotients = subtractFromRemainder;

            for (int i = default(T).Bits - 2; i >= 0; i--)
            {
                remainder <<= 1;
                quotients <<= 1;
                remainder |= OneMask32<T>() & (a >> i);
                subtractFromRemainder = GreaterThan<T>(b, remainder, forceUnsigned: true);
                remainder -= andnot(b, NegBool<T>(subtractFromRemainder));
                quotients += OneMask32<T>() ^ subtractFromRemainder;
            }
            
            if (default(T).IsSigned)
            {
                remainder = Add<T>(remainder ^ NegBool<T>(negRemainder), negRemainder);
                quotients = Add<T>(quotients ^ NegBool<T>(negQuotient), negQuotient);
            }

            return quotients;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint8 DivRem<T>(uint8 a, uint8 b, out uint8 remainder)
            where T : BitInt
        {
            uint8 negRemainder = ShiftRightLogical<T>(a, default(T).Bits - 1);
            uint8 negQuotient = ShiftRightLogical<T>(a ^ b, default(T).Bits - 1);
            if (default(T).IsSigned)
            {
                a = Abs<T>(a);
                b = Abs<T>(b);
            }
            
            remainder = ShiftRightLogical<T>(a, default(T).Bits - 1);
            uint8 subtractFromRemainder = Equals<T>(b, OneMask32<T>()) & remainder;
            remainder -= b & NegBool<T>(subtractFromRemainder);
            uint8 quotients = subtractFromRemainder;

            for (int i = default(T).Bits - 2; i >= 0; i--)
            {
                remainder <<= 1;
                quotients <<= 1;
                remainder |= OneMask32<T>() & (a >> i);
                subtractFromRemainder = GreaterThan<T>(b, remainder, forceUnsigned: true);
                remainder -= andnot(b, NegBool<T>(subtractFromRemainder));
                quotients += OneMask32<T>() ^ subtractFromRemainder;
            }
            
            if (default(T).IsSigned)
            {
                remainder = Add<T>(remainder ^ NegBool<T>(negRemainder), negRemainder);
                quotients = Add<T>(quotients ^ NegBool<T>(negQuotient), negQuotient);
            }

            return quotients;
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bool ConstDiv<T>(byte a, sbyte n, out byte result)
            where T : BitInt
        {
            if (!constexpr.IS_CONST(n))
            {
                result = 0;
                return false;
            }

            if (default(T).IsSigned)
            {
                sbyte __abs = abs(n);

                if (ispow2(__abs))
                {
                    sbyte shift = tzcnt(__abs);
                    result = a;
                    byte signs = ShiftRightLogical<T>(a, default(T).Bits - 1);
                    if (constexpr.IS_TRUE(n == 2 || n == -2))
                    {
                        result = Add<T>(result, signs);
                    }
                    else
                    {
                        byte mask = NegBool<T>(signs);
                        byte toAdd = (byte)(mask & BitFieldHelper.Replicate<T>((byte)(__abs - 1)));
                        result = Add<T>(result, toAdd);
                    }
                    result = ShiftRightArithmetic<T>(result, shift);

                    result = n < 0 ? Neg<T>(result) : result;

                    return true;
                }
            }
            else
            {
                if (ispow2(n))
                {
                    result = ShiftRightLogical<T>(a, tzcnt(n));
                    return true;
                }
                if (n == default(T).MaxValueAsLong)
                {
                    result = Equals<T>(a, byte.MaxValue);
                    return true;
                }
            }

            result = 0;
            return false;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bool ConstDiv<T>(ushort a, short n, out ushort result)
            where T : BitInt
        {
            if (!constexpr.IS_CONST(n))
            {
                result = 0;
                return false;
            }

            if (default(T).IsSigned)
            {
                short __abs = abs(n);

                if (ispow2(__abs))
                {
                    short shift = tzcnt(__abs);
                    result = a;
                    ushort signs = ShiftRightLogical<T>(a, default(T).Bits - 1);
                    if (constexpr.IS_TRUE(n == 2 || n == -2))
                    {
                        result = Add<T>(result, signs);
                    }
                    else
                    {
                        ushort mask = NegBool<T>(signs);
                        ushort toAdd = (ushort)(mask & BitFieldHelper.Replicate<T>((ushort)(__abs - 1)));
                        result = Add<T>(result, toAdd);
                    }
                    result = ShiftRightArithmetic<T>(result, shift);

                    result = n < 0 ? Neg<T>(result) : result;

                    return true;
                }
            }
            else
            {
                if (ispow2(n))
                {
                    result = ShiftRightLogical<T>(a, tzcnt(n));
                    return true;
                }
                if (n == default(T).MaxValueAsLong)
                {
                    result = Equals<T>(a, ushort.MaxValue);
                    return true;
                }
            }

            result = 0;
            return false;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bool ConstDiv<T>(uint a, int n, out uint result)
            where T : BitInt
        {
            if (!constexpr.IS_CONST(n))
            {
                result = 0;
                return false;
            }

            if (default(T).IsSigned)
            {
                int __abs = abs(n);

                if (ispow2(__abs))
                {
                    int shift = tzcnt(__abs);
                    result = a;
                    uint signs = ShiftRightLogical<T>(a, default(T).Bits - 1);
                    if (constexpr.IS_TRUE(n == 2 || n == -2))
                    {
                        result = Add<T>(result, signs);
                    }
                    else
                    {
                        uint mask = NegBool<T>(signs);
                        uint toAdd = mask & BitFieldHelper.Replicate<T>((uint)(__abs - 1));
                        result = Add<T>(result, toAdd);
                    }
                    result = ShiftRightArithmetic<T>(result, shift);

                    result = n < 0 ? Neg<T>(result) : result;

                    return true;
                }
            }
            else
            {
                if (ispow2(n))
                {
                    result = ShiftRightLogical<T>(a, tzcnt(n));
                    return true;
                }
                if (n == default(T).MaxValueAsLong)
                {
                    result = Equals<T>(a, uint.MaxValue);
                    return true;
                }
            }

            result = 0;
            return false;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bool ConstDiv<T>(ulong a, long n, out ulong result)
            where T : BitInt
        {
            if (!constexpr.IS_CONST(n))
            {
                result = 0;
                return false;
            }

            if (default(T).IsSigned)
            {
                long __abs = abs(n);

                if (ispow2(__abs))
                {
                    int shift = tzcnt(__abs);
                    result = a;
                    ulong signs = ShiftRightLogical<T>(a, default(T).Bits - 1);
                    if (constexpr.IS_TRUE(n == 2 || n == -2))
                    {
                        result = Add<T>(result, signs);
                    }
                    else
                    {
                        ulong mask = NegBool<T>(signs);
                        ulong toAdd = mask & BitFieldHelper.Replicate<T>((ulong)(__abs - 1));
                        result = Add<T>(result, toAdd);
                    }
                    result = ShiftRightArithmetic<T>(result, shift);

                    result = n < 0 ? Neg<T>(result) : result;

                    return true;
                }
            }
            else
            {
                if (ispow2(n))
                {
                    result = ShiftRightLogical<T>(a, tzcnt(n));
                    return true;
                }
                if (n == default(T).MaxValueAsLong)
                {
                    result = Equals<T>(a, ulong.MaxValue);
                    return true;
                }
            }

            result = 0;
            return false;
        }
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bool ConstRem<T>(byte a, sbyte n, out byte result)
            where T : BitInt
        {
            if (!constexpr.IS_CONST(n))
            {
                result = 0;
                return false;
            }

            if (default(T).IsSigned)
            {
                sbyte __abs = abs(n);

                if (ispow2(__abs))
                {
                    result = a;
                    byte signs = ShiftRightLogical<T>(a, default(T).Bits - 1);
                    if (constexpr.IS_TRUE(n == 2 || n == -2))
                    {
                        result = Add<T>(result, signs);
                    }
                    else
                    {
                        byte mask = NegBool<T>(signs);
                        byte toAdd = (byte)(mask & BitFieldHelper.Replicate<T>((byte)(__abs - 1)));
                        result = Add<T>(result, toAdd);
                    }

                    result = Sub<T>(a, (byte)(result & Neg<T>(BitFieldHelper.Replicate<T>((byte)__abs))));
                    return true;
                }
            }
            else
            {
                if (ispow2(n))
                {
                    result = (byte)(a & BitFieldHelper.Replicate<T>((byte)(n - 1)));
                    return true;
                }
            }

            result = 0;
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bool ConstRem<T>(ushort a, short n, out ushort result)
            where T : BitInt
        {
            if (!constexpr.IS_CONST(n))
            {
                result = 0;
                return false;
            }

            if (default(T).IsSigned)
            {
                short __abs = abs(n);

                if (ispow2(__abs))
                {
                    result = a;
                    ushort signs = ShiftRightLogical<T>(a, default(T).Bits - 1);
                    if (constexpr.IS_TRUE(n == 2 || n == -2))
                    {
                        result = Add<T>(result, signs);
                    }
                    else
                    {
                        ushort mask = NegBool<T>(signs);
                        ushort toAdd = (ushort)(mask & BitFieldHelper.Replicate<T>((ushort)(__abs - 1)));
                        result = Add<T>(result, toAdd);
                    }

                    result = Sub<T>(a, (ushort)(result & Neg<T>(BitFieldHelper.Replicate<T>((ushort)__abs))));
                    return true;
                }
            }
            else
            {
                if (ispow2(n))
                {
                    result = (ushort)(a & BitFieldHelper.Replicate<T>((ushort)(n - 1)));
                    return true;
                }
            }

            result = 0;
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bool ConstRem<T>(uint a, int n, out uint result)
            where T : BitInt
        {
            if (!constexpr.IS_CONST(n))
            {
                result = 0;
                return false;
            }

            if (default(T).IsSigned)
            {
                int __abs = abs(n);

                if (ispow2(__abs))
                {
                    result = a;
                    uint signs = ShiftRightLogical<T>(a, default(T).Bits - 1);
                    if (constexpr.IS_TRUE(n == 2 || n == -2))
                    {
                        result = Add<T>(result, signs);
                    }
                    else
                    {
                        uint mask = NegBool<T>(signs);
                        uint toAdd = mask & BitFieldHelper.Replicate<T>((uint)(__abs - 1));
                        result = Add<T>(result, toAdd);
                    }

                    result = Sub<T>(a, result & Neg<T>(BitFieldHelper.Replicate<T>((uint)__abs)));
                    return true;
                }
            }
            else
            {
                if (ispow2(n))
                {
                    result = a & BitFieldHelper.Replicate<T>((uint)(n - 1));
                    return true;
                }
            }

            result = 0;
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bool ConstRem<T>(ulong a, long n, out ulong result)
            where T : BitInt
        {
            if (!constexpr.IS_CONST(n))
            {
                result = 0;
                return false;
            }

            if (default(T).IsSigned)
            {
                long __abs = abs(n);

                if (ispow2(__abs))
                {
                    result = a;
                    ulong signs = ShiftRightLogical<T>(a, default(T).Bits - 1);
                    if (constexpr.IS_TRUE(n == 2 || n == -2))
                    {
                        result = Add<T>(result, signs);
                    }
                    else
                    {
                        ulong mask = NegBool<T>(signs);
                        ulong toAdd = mask & BitFieldHelper.Replicate<T>((ulong)(__abs - 1));
                        result = Add<T>(result, toAdd);
                    }

                    result = Sub<T>(a, result & Neg<T>(BitFieldHelper.Replicate<T>((ulong)__abs)));
                    return true;
                }
            }
            else
            {
                if (ispow2(n))
                {
                    result = a & BitFieldHelper.Replicate<T>((ulong)(n - 1));
                    return true;
                }
            }

            result = 0;
            return false;
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte IsNotZero<T>(byte a)
            where T : BitInt
        {
            if (default(T).Bits == 2)
            {
                byte shift0 = (byte)(a >> 1);

                return (byte)(OneMask8<T>() & (byte)(shift0 | a));
            }
            else if (default(T).Bits == 3)
            {
                byte shift0 = (byte)(a >> 1);
                byte shift1 = (byte)(a >> 2);

                return (byte)(OneMask8<T>() & ((byte)(a | (byte)(shift0 | shift1))));
            }
            else if (default(T).Bits == 4)
            {
                byte shift0 = (byte)(a >> 2);
                byte cmp0 = (byte)(shift0 | a);

                byte shift1 = (byte)(cmp0 >> 1);

                return (byte)(OneMask8<T>() & (byte)(shift1 | cmp0));
            }
            else
            {
                return ShiftRightLogical<T>((byte)(a | Neg<T>(a)), default(T).Bits - 1);
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort IsNotZero<T>(ushort a)
            where T : BitInt
        {
            if (default(T).Bits == 2)
            {
                ushort shift0 = (ushort)(a >> 1);

                return (ushort)(OneMask16<T>() & (ushort)(shift0 | a));
            }
            else if (default(T).Bits == 3)
            {
                ushort shift0 = (ushort)(a >> 1);
                ushort shift1 = (ushort)(a >> 2);

                return (ushort)(OneMask16<T>() & ((ushort)(a | (ushort)(shift0 | shift1))));
            }
            else if (default(T).Bits == 4)
            {
                ushort shift0 = (ushort)(a >> 2);
                ushort cmp0 = (ushort)(shift0 | a);

                ushort shift1 = (ushort)(cmp0 >> 1);

                return (ushort)(OneMask16<T>() & (ushort)(shift1 | cmp0));
            }
            else
            {
                return ShiftRightLogical<T>((ushort)(a | Neg<T>(a)), default(T).Bits - 1);
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint IsNotZero<T>(uint a)
            where T : BitInt
        {
            if (default(T).Bits == 2)
            {
                uint shift0 = a >> 1;

                return OneMask32<T>() & (shift0 | a);
            }
            else if (default(T).Bits == 3)
            {
                uint shift0 = a >> 1;
                uint shift1 = a >> 2;

                return OneMask32<T>() & (a | shift0 | shift1);
            }
            else if (default(T).Bits == 4)
            {
                uint shift0 = a >> 2;
                uint cmp0 = shift0 | a;

                uint shift1 = cmp0 >> 1;

                return OneMask32<T>() & (shift1 | cmp0);
            }
            else
            {
                return ShiftRightLogical<T>(a | Neg<T>(a), default(T).Bits - 1);
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong IsNotZero<T>(ulong a)
            where T : BitInt
        {
            if (default(T).Bits == 2)
            {
                ulong shift0 = a >> 1;

                return OneMask64<T>() & (shift0 | a);
            }
            else if (default(T).Bits == 3)
            {
                ulong shift0 = a >> 1;
                ulong shift1 = a >> 2;

                return OneMask64<T>() & (a | shift0 | shift1);
            }
            else if (default(T).Bits == 4)
            {
                ulong shift0 = a >> 2;
                ulong cmp0 = shift0 | a;

                ulong shift1 = cmp0 >> 1;

                return OneMask64<T>() & (shift1 | cmp0);
            }
            else
            {
                return ShiftRightLogical<T>(a | Neg<T>(a), default(T).Bits - 1);
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint4 IsNotZero<T>(uint4 a)
            where T : BitInt
        {
            if (default(T).Bits == 2)
            {
                uint4 shift0 = a >> 1;

                return OneMask32<T>() & (shift0 | a);
            }
            else if (default(T).Bits == 3)
            {
                uint4 shift0 = a >> 1;
                uint4 shift1 = a >> 2;

                return OneMask32<T>() & (a | shift0 | shift1);
            }
            else if (default(T).Bits == 4)
            {
                uint4 shift0 = a >> 2;
                uint4 cmp0 = shift0 | a;

                uint4 shift1 = cmp0 >> 1;

                return OneMask32<T>() & (shift1 | cmp0);
            }
            else
            {
                return ShiftRightLogical<T>(a | Neg<T>(a), default(T).Bits - 1);
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint8 IsNotZero<T>(uint8 a)
            where T : BitInt
        {
            if (default(T).Bits == 2)
            {
                uint8 shift0 = a >> 1;

                return OneMask32<T>() & (shift0 | a);
            }
            else if (default(T).Bits == 3)
            {
                uint8 shift0 = a >> 1;
                uint8 shift1 = a >> 2;

                return OneMask32<T>() & (a | shift0 | shift1);
            }
            else if (default(T).Bits == 4)
            {
                uint8 shift0 = a >> 2;
                uint8 cmp0 = shift0 | a;

                uint8 shift1 = cmp0 >> 1;

                return OneMask32<T>() & (shift1 | cmp0);
            }
            else
            {
                return ShiftRightLogical<T>(a | Neg<T>(a), default(T).Bits - 1);
            }
        }
    

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte IsZero<T>(byte a)
            where T : BitInt
        {
            if (default(T).Bits == 2)
            {
                byte MASK0 = BitFieldHelper.Replicate<T>((byte)0b10);

                byte shift0 = (byte)(andnot(MASK0, a) >> 1);

                return andnot(shift0, a);
            }
            else if (default(T).Bits == 3)
            {
                byte MASK0 = BitFieldHelper.Replicate<T>((byte)0b010);
                byte MASK1 = BitFieldHelper.Replicate<T>((byte)0b100);

                byte shift0 = (byte)(andnot(MASK0, a) >> 1);
                byte shift1 = (byte)(andnot(MASK1, a) >> 2);

                return (byte)(andnot(shift0, a) & shift1);
            }
            else if (default(T).Bits == 4)
            {
                byte MASK0 = BitFieldHelper.Replicate<T>((byte)0b1100);
                byte MASK1 = BitFieldHelper.Replicate<T>((byte)0b0010);

                byte shift0 = (byte)(andnot(MASK0, a) >> 2);
                byte cmp0 = andnot(shift0, a);

                byte shift1 = (byte)((byte)(MASK1 & cmp0) >> 1);

                return (byte)(shift1 & cmp0);
            }
            else
            {
                return ShiftRightLogical<T>(andnot(Sub<T>(a, OneMask8<T>()), a), default(T).Bits - 1);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort IsZero<T>(ushort a)
            where T : BitInt
        {
            if (default(T).Bits == 2)
            {
                ushort MASK0 = BitFieldHelper.Replicate<T>((ushort)0b10);

                ushort shift0 = (ushort)(andnot(MASK0, a) >> 1);

                return andnot(shift0, a);
            }
            else if (default(T).Bits == 3)
            {
                ushort MASK0 = BitFieldHelper.Replicate<T>((ushort)0b10);
                ushort MASK1 = BitFieldHelper.Replicate<T>((ushort)0b100);

                ushort shift0 = (ushort)(andnot(MASK0, a) >> 1);
                ushort shift1 = (ushort)(andnot(MASK1, a) >> 2);

                return (ushort)(andnot(shift0, a) & shift1);
            }
            else if (default(T).Bits == 4)
            {
                ushort MASK0 = BitFieldHelper.Replicate<T>((ushort)0b1100);
                ushort MASK1 = BitFieldHelper.Replicate<T>((ushort)0b10);

                ushort shift0 = (ushort)(andnot(MASK0, a) >> 2);
                ushort cmp0 = andnot(shift0, a);

                ushort shift1 = (ushort)((ushort)(MASK1 & cmp0) >> 1);

                return (ushort)(shift1 & cmp0);
            }
            else
            {
                return ShiftRightLogical<T>(andnot(Sub<T>(a, OneMask16<T>()), a), default(T).Bits - 1);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint IsZero<T>(uint a)
            where T : BitInt
        {
            if (default(T).Bits == 2)
            {
                uint MASK0 = BitFieldHelper.Replicate<T>((uint)0b10);

                uint shift0 = andnot(MASK0, a) >> 1;

                return andnot(shift0, a);
            }
            else if (default(T).Bits == 3)
            {
                uint MASK0 = BitFieldHelper.Replicate<T>((uint)0b10);
                uint MASK1 = BitFieldHelper.Replicate<T>((uint)0b100);

                uint shift0 = andnot(MASK0, a) >> 1;
                uint shift1 = andnot(MASK1, a) >> 2;

                return andnot(shift0, a) & shift1;
            }
            else if (default(T).Bits == 4)
            {
                uint MASK0 = BitFieldHelper.Replicate<T>((uint)0b1100);
                uint MASK1 = BitFieldHelper.Replicate<T>((uint)0b10);

                uint shift0 = andnot(MASK0, a) >> 2;
                uint cmp0 = andnot(shift0, a);

                uint shift1 = (MASK1 & cmp0) >> 1;

                return shift1 & cmp0;
            }
            else
            {
                return ShiftRightLogical<T>(andnot(Sub<T>(a, OneMask32<T>()), a), default(T).Bits - 1);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong IsZero<T>(ulong a)
            where T : BitInt
        {
            if (default(T).Bits == 2)
            {
                ulong MASK0 = BitFieldHelper.Replicate<T>((ulong)0b10);

                ulong shift0 = andnot(MASK0, a) >> 1;

                return andnot(shift0, a);
            }
            else if (default(T).Bits == 3)
            {
                ulong MASK0 = BitFieldHelper.Replicate<T>((ulong)0b10);
                ulong MASK1 = BitFieldHelper.Replicate<T>((ulong)0b100);

                ulong shift0 = andnot(MASK0, a) >> 1;
                ulong shift1 = andnot(MASK1, a) >> 2;

                return andnot(shift0, a) & shift1;
            }
            else if (default(T).Bits == 4)
            {
                ulong MASK0 = BitFieldHelper.Replicate<T>((ulong)0b1100);
                ulong MASK1 = BitFieldHelper.Replicate<T>((ulong)0b10);

                ulong shift0 = andnot(MASK0, a) >> 2;
                ulong cmp0 = andnot(shift0, a);

                ulong shift1 = (MASK1 & cmp0) >> 1;

                return shift1 & cmp0;
            }
            else
            {
                return ShiftRightLogical<T>(andnot(Sub<T>(a, OneMask64<T>()), a), default(T).Bits - 1);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint4 IsZero<T>(uint4 a)
            where T : BitInt
        {
            if (default(T).Bits == 2)
            {
                uint4 MASK0 = BitFieldHelper.Replicate<T>((uint)0b10);

                uint4 shift0 = andnot(MASK0, a) >> 1;

                return andnot(shift0, a);
            }
            else if (default(T).Bits == 3)
            {
                uint4 MASK0 = BitFieldHelper.Replicate<T>((uint)0b10);
                uint4 MASK1 = BitFieldHelper.Replicate<T>((uint)0b100);

                uint4 shift0 = andnot(MASK0, a) >> 1;
                uint4 shift1 = andnot(MASK1, a) >> 2;

                return andnot(shift0, a) & shift1;
            }
            else if (default(T).Bits == 4)
            {
                uint4 MASK0 = BitFieldHelper.Replicate<T>((uint)0b1100);
                uint4 MASK1 = BitFieldHelper.Replicate<T>((uint)0b10);

                uint4 shift0 = andnot(MASK0, a) >> 2;
                uint4 cmp0 = andnot(shift0, a);

                uint4 shift1 = (MASK1 & cmp0) >> 1;

                return shift1 & cmp0;
            }
            else
            {
                return ShiftRightLogical<T>(andnot(Sub<T>(a, OneMask32<T>()), a), default(T).Bits - 1);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint8 IsZero<T>(uint8 a)
            where T : BitInt
        {
            if (default(T).Bits == 2)
            {
                uint8 MASK0 = BitFieldHelper.Replicate<T>((uint)0b10);

                uint8 shift0 = andnot(MASK0, a) >> 1;

                return andnot(shift0, a);
            }
            else if (default(T).Bits == 3)
            {
                uint8 MASK0 = BitFieldHelper.Replicate<T>((uint)0b10);
                uint8 MASK1 = BitFieldHelper.Replicate<T>((uint)0b100);

                uint8 shift0 = andnot(MASK0, a) >> 1;
                uint8 shift1 = andnot(MASK1, a) >> 2;

                return andnot(shift0, a) & shift1;
            }
            else if (default(T).Bits == 4)
            {
                uint8 MASK0 = BitFieldHelper.Replicate<T>((uint)0b1100);
                uint8 MASK1 = BitFieldHelper.Replicate<T>((uint)0b10);

                uint8 shift0 = andnot(MASK0, a) >> 2;
                uint8 cmp0 = andnot(shift0, a);

                uint8 shift1 = (MASK1 & cmp0) >> 1;

                return shift1 & cmp0;
            }
            else
            {
                return ShiftRightLogical<T>(andnot(Sub<T>(a, OneMask32<T>()), a), default(T).Bits - 1);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte Equals<T>(byte a, byte b)
            where T : BitInt
        {
            return IsZero<T>((byte)(a ^ b));   
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort Equals<T>(ushort a, ushort b)
            where T : BitInt
        {
            return IsZero<T>((ushort)(a ^ b));   
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint Equals<T>(uint a, uint b)
            where T : BitInt
        {
            return IsZero<T>(a ^ b);  
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong Equals<T>(ulong a, ulong b)
            where T : BitInt
        {
            return IsZero<T>(a ^ b);  
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint4 Equals<T>(uint4 a, uint4 b)
            where T : BitInt
        {
            return IsZero<T>(a ^ b);  
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint8 Equals<T>(uint8 a, uint8 b)
            where T : BitInt
        {
            return IsZero<T>(a ^ b);  
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte NotEquals<T>(byte a, byte b)
            where T : BitInt
        {
            return IsNotZero<T>((byte)(a ^ b));   
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort NotEquals<T>(ushort a, ushort b)
            where T : BitInt
        {
            return IsNotZero<T>((ushort)(a ^ b));   
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint NotEquals<T>(uint a, uint b)
            where T : BitInt
        {
            return IsNotZero<T>(a ^ b);  
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong NotEquals<T>(ulong a, ulong b)
            where T : BitInt
        {
            return IsNotZero<T>(a ^ b);  
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint4 NotEquals<T>(uint4 a, uint4 b)
            where T : BitInt
        {
            return IsNotZero<T>(a ^ b);  
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint8 NotEquals<T>(uint8 a, uint8 b)
            where T : BitInt
        {
            return IsNotZero<T>(a ^ b);  
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte LessThan<T>(byte a, byte b, bool forceUnsigned = false)
            where T : BitInt
        {
            if (constexpr.IS_TRUE(b == 0))
            {
                if (default(T).IsSigned)
                {
                    return ShiftRightLogical<T>(a, default(T).Bits - 1);
                }
                else
                {
                    return 0;
                }
            }
            if (constexpr.IS_TRUE(a == 0))
            {
                if (default(T).IsSigned)
                {
                    return (byte)((byte)(OneMask8<T>() ^ ShiftRightLogical<T>(b, default(T).Bits - 1)) & IsNotZero<T>(b));
                }
                else
                {
                    return IsNotZero<T>(b);
                }
            }

            if (!default(T).IsSigned
             || forceUnsigned)
            {
                a ^= SignBitMask8<T>();
                b ^= SignBitMask8<T>();
            }

            byte sub = ShiftRightLogical<T>(Sub<T>(a, b), default(T).Bits - 1);
            byte signA = ShiftRightLogical<T>(a, default(T).Bits - 1);
            byte signB = ShiftRightLogical<T>(b, default(T).Bits - 1);

            return bits_select(sub, signA, (byte)(signA ^ signB));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort LessThan<T>(ushort a, ushort b, bool forceUnsigned = false)
            where T : BitInt
        {
            if (constexpr.IS_TRUE(b == 0))
            {
                if (default(T).IsSigned)
                {
                    return ShiftRightLogical<T>(a, default(T).Bits - 1);
                }
                else
                {
                    return 0;
                }
            }
            if (constexpr.IS_TRUE(a == 0))
            {
                if (default(T).IsSigned)
                {
                    return (ushort)((ushort)(OneMask16<T>() ^ ShiftRightLogical<T>(b, default(T).Bits - 1)) & IsNotZero<T>(b));
                }
                else
                {
                    return IsNotZero<T>(b);
                }
            }

            if (!default(T).IsSigned
             || forceUnsigned)
            {
                a ^= SignBitMask16<T>();
                b ^= SignBitMask16<T>();
            }

            ushort sub = ShiftRightLogical<T>(Sub<T>(a, b), default(T).Bits - 1);
            ushort signA = ShiftRightLogical<T>(a, default(T).Bits - 1);
            ushort signB = ShiftRightLogical<T>(b, default(T).Bits - 1);

            return bits_select(sub, signA, (ushort)(signA ^ signB));
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint LessThan<T>(uint a, uint b, bool forceUnsigned = false)
            where T : BitInt
        {
            if (constexpr.IS_TRUE(b == 0))
            {
                if (default(T).IsSigned)
                {
                    return ShiftRightLogical<T>(a, default(T).Bits - 1);
                }
                else
                {
                    return 0;
                }
            }
            if (constexpr.IS_TRUE(a == 0))
            {
                if (default(T).IsSigned)
                {
                    return (OneMask32<T>() ^ ShiftRightLogical<T>(b, default(T).Bits - 1)) & IsNotZero<T>(b);
                }
                else
                {
                    return IsNotZero<T>(b);
                }
            }

            if (!default(T).IsSigned
             || forceUnsigned)
            {
                a ^= SignBitMask32<T>();
                b ^= SignBitMask32<T>();
            }

            uint sub = ShiftRightLogical<T>(Sub<T>(a, b), default(T).Bits - 1);
            uint signA = ShiftRightLogical<T>(a, default(T).Bits - 1);
            uint signB = ShiftRightLogical<T>(b, default(T).Bits - 1);

            return bits_select(sub, signA, signA ^ signB);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong LessThan<T>(ulong a, ulong b, bool forceUnsigned = false)
            where T : BitInt
        {
            if (constexpr.IS_TRUE(b == 0))
            {
                if (default(T).IsSigned)
                {
                    return ShiftRightLogical<T>(a, default(T).Bits - 1);
                }
                else
                {
                    return 0;
                }
            }
            if (constexpr.IS_TRUE(a == 0))
            {
                if (default(T).IsSigned)
                {
                    return (OneMask64<T>() ^ ShiftRightLogical<T>(b, default(T).Bits - 1)) & IsNotZero<T>(b);
                }
                else
                {
                    return IsNotZero<T>(b);
                }
            }

            if (!default(T).IsSigned
             || forceUnsigned)
            {
                a ^= SignBitMask64<T>();
                b ^= SignBitMask64<T>();
            }

            ulong sub = ShiftRightLogical<T>(Sub<T>(a, b), default(T).Bits - 1);
            ulong signA = ShiftRightLogical<T>(a, default(T).Bits - 1);
            ulong signB = ShiftRightLogical<T>(b, default(T).Bits - 1);

            return bits_select(sub, signA, signA ^ signB);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint4 LessThan<T>(uint4 a, uint4 b, bool forceUnsigned = false)
            where T : BitInt
        {
            if (constexpr.IS_TRUE(b.Equals(0)))
            {
                if (default(T).IsSigned)
                {
                    return ShiftRightLogical<T>(a, default(T).Bits - 1);
                }
                else
                {
                    return 0;
                }
            }
            if (constexpr.IS_TRUE(a.Equals(0)))
            {
                if (default(T).IsSigned)
                {
                    return (OneMask32<T>() ^ ShiftRightLogical<T>(b, default(T).Bits - 1)) & IsNotZero<T>(b);
                }
                else
                {
                    return IsNotZero<T>(b);
                }
            }

            if (!default(T).IsSigned
             || forceUnsigned)
            {
                a ^= SignBitMask32<T>();
                b ^= SignBitMask32<T>();
            }

            uint4 sub = ShiftRightLogical<T>(Sub<T>(a, b), default(T).Bits - 1);
            uint4 signA = ShiftRightLogical<T>(a, default(T).Bits - 1);
            uint4 signB = ShiftRightLogical<T>(b, default(T).Bits - 1);

            return bits_select(sub, signA, signA ^ signB);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint8 LessThan<T>(uint8 a, uint8 b, bool forceUnsigned = false)
            where T : BitInt
        {
            if (constexpr.IS_TRUE(b.Equals(0)))
            {
                if (default(T).IsSigned)
                {
                    return ShiftRightLogical<T>(a, default(T).Bits - 1);
                }
                else
                {
                    return 0;
                }
            }
            if (constexpr.IS_TRUE(a.Equals(0)))
            {
                if (default(T).IsSigned)
                {
                    return (OneMask32<T>() ^ ShiftRightLogical<T>(b, default(T).Bits - 1)) & IsNotZero<T>(b);
                }
                else
                {
                    return IsNotZero<T>(b);
                }
            }

            if (!default(T).IsSigned
             || forceUnsigned)
            {
                a ^= SignBitMask32<T>();
                b ^= SignBitMask32<T>();
            }

            uint8 sub = ShiftRightLogical<T>(Sub<T>(a, b), default(T).Bits - 1);
            uint8 signA = ShiftRightLogical<T>(a, default(T).Bits - 1);
            uint8 signB = ShiftRightLogical<T>(b, default(T).Bits - 1);

            return bits_select(sub, signA, signA ^ signB);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte GreaterThan<T>(byte a, byte b, bool forceUnsigned = false)
            where T : BitInt
        {
            return LessThan<T>(b, a, forceUnsigned);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort GreaterThan<T>(ushort a, ushort b, bool forceUnsigned = false)
            where T : BitInt
        {
            return LessThan<T>(b, a, forceUnsigned);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint GreaterThan<T>(uint a, uint b, bool forceUnsigned = false)
            where T : BitInt
        {
            return LessThan<T>(b, a, forceUnsigned);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong GreaterThan<T>(ulong a, ulong b, bool forceUnsigned = false)
            where T : BitInt
        {
            return LessThan<T>(b, a, forceUnsigned);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint4 GreaterThan<T>(uint4 a, uint4 b, bool forceUnsigned = false)
            where T : BitInt
        {
            return LessThan<T>(b, a, forceUnsigned);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint8 GreaterThan<T>(uint8 a, uint8 b, bool forceUnsigned = false)
            where T : BitInt
        {
            return LessThan<T>(b, a, forceUnsigned);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte LessThanOrEqual<T>(byte a, byte b, bool forceUnsigned = false)
            where T : BitInt
        {
            if (constexpr.IS_TRUE(b == 0))
            {
                if (default(T).IsSigned)
                {
                    return (byte)(ShiftRightLogical<T>(a, default(T).Bits - 1) | IsZero<T>(a));
                }
                else
                {
                    return IsZero<T>(a);
                }
            }
            if (constexpr.IS_TRUE(a == 0))
            {
                if (default(T).IsSigned)
                {
                    return (byte)(OneMask8<T>() ^ ShiftRightLogical<T>(b, default(T).Bits - 1));
                }
                else
                {
                    return OneMask8<T>();
                }
            }

            return (byte)(OneMask8<T>() ^ GreaterThan<T>(a, b, forceUnsigned));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort LessThanOrEqual<T>(ushort a, ushort b, bool forceUnsigned = false)
            where T : BitInt
        {
            if (constexpr.IS_TRUE(b == 0))
            {
                if (default(T).IsSigned)
                {
                    return (ushort)(ShiftRightLogical<T>(a, default(T).Bits - 1) | IsZero<T>(a));
                }
                else
                {
                    return IsZero<T>(a);
                }
            }
            if (constexpr.IS_TRUE(a == 0))
            {
                if (default(T).IsSigned)
                {
                    return (ushort)(OneMask16<T>() ^ ShiftRightLogical<T>(b, default(T).Bits - 1));
                }
                else
                {
                    return OneMask16<T>();
                }
            }

            return (ushort)(OneMask16<T>() ^ GreaterThan<T>(a, b, forceUnsigned));
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint LessThanOrEqual<T>(uint a, uint b, bool forceUnsigned = false)
            where T : BitInt
        {
            if (constexpr.IS_TRUE(b == 0))
            {
                if (default(T).IsSigned)
                {
                    return ShiftRightLogical<T>(a, default(T).Bits - 1) | IsZero<T>(a);
                }
                else
                {
                    return IsZero<T>(a);
                }
            }
            if (constexpr.IS_TRUE(a == 0))
            {
                if (default(T).IsSigned)
                {
                    return OneMask32<T>() ^ ShiftRightLogical<T>(b, default(T).Bits - 1);
                }
                else
                {
                    return OneMask32<T>();
                }
            }

            return OneMask32<T>() ^ GreaterThan<T>(a, b, forceUnsigned);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong LessThanOrEqual<T>(ulong a, ulong b, bool forceUnsigned = false)
            where T : BitInt
        {
            if (constexpr.IS_TRUE(b == 0))
            {
                if (default(T).IsSigned)
                {
                    return ShiftRightLogical<T>(a, default(T).Bits - 1) | IsZero<T>(a);
                }
                else
                {
                    return IsZero<T>(a);
                }
            }
            if (constexpr.IS_TRUE(a == 0))
            {
                if (default(T).IsSigned)
                {
                    return OneMask64<T>() ^ ShiftRightLogical<T>(b, default(T).Bits - 1);
                }
                else
                {
                    return OneMask64<T>();
                }
            }

            return OneMask64<T>() ^ GreaterThan<T>(a, b, forceUnsigned);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint4 LessThanOrEqual<T>(uint4 a, uint4 b, bool forceUnsigned = false)
            where T : BitInt
        {
            if (constexpr.IS_TRUE(b.Equals(0)))
            {
                if (default(T).IsSigned)
                {
                    return ShiftRightLogical<T>(a, default(T).Bits - 1) | IsZero<T>(a);
                }
                else
                {
                    return IsZero<T>(a);
                }
            }
            if (constexpr.IS_TRUE(a.Equals(0)))
            {
                if (default(T).IsSigned)
                {
                    return OneMask32<T>() ^ ShiftRightLogical<T>(b, default(T).Bits - 1);
                }
                else
                {
                    return OneMask32<T>();
                }
            }

            return OneMask32<T>() ^ GreaterThan<T>(a, b, forceUnsigned);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint8 LessThanOrEqual<T>(uint8 a, uint8 b, bool forceUnsigned = false)
            where T : BitInt
        {
            if (constexpr.IS_TRUE(b.Equals(0)))
            {
                if (default(T).IsSigned)
                {
                    return ShiftRightLogical<T>(a, default(T).Bits - 1) | IsZero<T>(a);
                }
                else
                {
                    return IsZero<T>(a);
                }
            }
            if (constexpr.IS_TRUE(a.Equals(0)))
            {
                if (default(T).IsSigned)
                {
                    return OneMask32<T>() ^ ShiftRightLogical<T>(b, default(T).Bits - 1);
                }
                else
                {
                    return OneMask32<T>();
                }
            }

            return OneMask32<T>() ^ GreaterThan<T>(a, b, forceUnsigned);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte GreaterThanOrEqual<T>(byte a, byte b, bool forceUnsigned = false)
            where T : BitInt
        {
            return LessThanOrEqual<T>(b, a, forceUnsigned);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort GreaterThanOrEqual<T>(ushort a, ushort b, bool forceUnsigned = false)
            where T : BitInt
        {
            return LessThanOrEqual<T>(b, a, forceUnsigned);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint GreaterThanOrEqual<T>(uint a, uint b, bool forceUnsigned = false)
            where T : BitInt
        {
            return LessThanOrEqual<T>(b, a, forceUnsigned);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong GreaterThanOrEqual<T>(ulong a, ulong b, bool forceUnsigned = false)
            where T : BitInt
        {
            return LessThanOrEqual<T>(b, a, forceUnsigned);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint4 GreaterThanOrEqual<T>(uint4 a, uint4 b, bool forceUnsigned = false)
            where T : BitInt
        {
            return LessThanOrEqual<T>(b, a, forceUnsigned);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint8 GreaterThanOrEqual<T>(uint8 a, uint8 b, bool forceUnsigned = false)
            where T : BitInt
        {
            return LessThanOrEqual<T>(b, a, forceUnsigned);
        }
    }
}
