using System.Runtime.CompilerServices;
using DevTools;
using MaxMath;
using MaxMath.Intrinsics;
using Unity.Burst.CompilerServices;
using static MaxMath.maxmath;

namespace BitCollections
{
	unsafe internal static class BitFieldHelper
	{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Get<T>(uint bits, int bitIndex, int bitsInField)
			where T : BitInt
		{
Assert.IsValidSubarray(bitIndex, default(T).Bits, bitsInField);
			
			int value;

			if (default(T).IsSigned)
			{
				int losslessShift = 8 * sizeof(int) - default(T).Bits;
				
				// manual sign extend => 1 bitshift less; same if 'index' is not a compile time constant
				value = ((int)bits << (losslessShift - bitIndex)) >> losslessShift;
			}
			else
			{
				if (constexpr.IS_TRUE(bitIndex == 0))
				{
				    value = (int)(bits & (uint)bitmask32((uint)default(T).Bits));
				}
				else if (constexpr.IS_TRUE(bitIndex == bitsInField - default(T).Bits))
				{
				    value = (int)(bits >> bitIndex);
				}
				else
				{
					value = (int)bits_extract(bits, bitIndex, default(T).Bits);
				}
			}

			constexpr.ASSUME(value >= default(T).MinValueAsLong);
			constexpr.ASSUME(value <= default(T).MaxValueAsLong);
			return value;
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static long Get<T>(ulong bits, int bitIndex, int bitsInField)
			where T : BitInt
		{
Assert.IsValidSubarray(bitIndex, default(T).Bits, bitsInField);

			long value;

			if (default(T).IsSigned)
			{
				int losslessShift = 8 * sizeof(long) - default(T).Bits;

				// manual sign extend => 1 bitshift less; same if 'index' is not a compile time constant
			    value = ((long)bits << (losslessShift - bitIndex)) >> losslessShift;
			}
			else
			{
				if (constexpr.IS_TRUE(bitIndex == 0))
				{
				    value = (long)(bits & (ulong)bitmask64((ulong)default(T).Bits));
				}
				else if (constexpr.IS_TRUE(bitIndex == bitsInField - default(T).Bits))
				{
				    value = (long)(bits >> bitIndex);
				}
				else
				{
					value = (long)bits_extract(bits, bitIndex, default(T).Bits);
				}
			}

			constexpr.ASSUME(value >= default(T).MinValueAsLong);
			constexpr.ASSUME(value <= default(T).MaxValueAsLong);
			return value;
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static long Get<T>(UInt128 bits, int bitIndex, int bitsInField)
			where T : BitInt
		{
Assert.IsValidSubarray(bitIndex, default(T).Bits, bitsInField);

			long value;

			if (default(T).IsSigned)
			{
				int losslessShift = 8 * sizeof(UInt128) - default(T).Bits;

				// manual sign extend => 1 bitshift less; same if 'index' is not a compile time constant
			    value = (long)(((Int128)bits << (losslessShift - bitIndex)) >> losslessShift);
			}
			else
			{
				if (constexpr.IS_TRUE(bitIndex == 0))
				{
				    value = (long)(bits.lo64 & (ulong)bitmask64((ulong)default(T).Bits));
				}
				else if (constexpr.IS_TRUE(bitIndex == bitsInField - default(T).Bits))
				{
				    value = (long)(bits.hi64 >> (bitIndex - 64));
				}
				else
				{
					value = (long)bits_extract(bits, bitIndex, default(T).Bits);
				}
			}

			constexpr.ASSUME(value >= default(T).MinValueAsLong);
			constexpr.ASSUME(value <= default(T).MaxValueAsLong);
			return value;
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint Set<T>(uint bits, int value, int bitIndex, int bitsInField)
			where T : BitInt
		{
Assert.IsBetween(value, default(T).MinValueAsLong, default(T).MaxValueAsLong);
Assert.IsValidSubarray(bitIndex, default(T).Bits, bitsInField);
			
            if (constexpr.IS_TRUE(bitIndex == bitsInField - default(T).Bits) 
		     && constexpr.IS_TRUE(value == 0))
			{
				return bits_zerohigh(bits, bitsInField - default(T).Bits);
			}
			else
			{
				uint mask = (uint)bitmask32(default(T).Bits, bitIndex);
				uint shiftedValue = (uint)value << bitIndex;
				if (default(T).IsSigned)
				{
					if (!constexpr.IS_TRUE(value >= 0))
					{
						shiftedValue &= mask;
					}
				}

				return andnot(bits, mask) | shiftedValue;
			}
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong Set<T>(ulong bits, long value, int bitIndex, int bitsInField)
			where T : BitInt
		{
Assert.IsBetween(value, default(T).MinValueAsLong, default(T).MaxValueAsLong);
Assert.IsValidSubarray(bitIndex, default(T).Bits, bitsInField);
			
            if (constexpr.IS_TRUE(bitIndex == bitsInField - default(T).Bits) 
		     && constexpr.IS_TRUE(value == 0))
			{
				return bits_zerohigh(bits, bitsInField - default(T).Bits);
			}
			else
			{
				ulong mask = bitmask64(default(T).Bits, (ulong)bitIndex);
				ulong shiftedValue = (ulong)(uint)value << bitIndex;
				if (default(T).IsSigned)
				{
					if (!constexpr.IS_TRUE(value >= 0))
					{
						shiftedValue &= mask;
					}
				}

				return andnot(bits, mask) | shiftedValue;
			}
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static UInt128 Set<T>(UInt128 bits, long value, int bitIndex, int bitsInField)
			where T : BitInt
		{
Assert.IsBetween(value, default(T).MinValueAsLong, default(T).MaxValueAsLong);
Assert.IsValidSubarray(bitIndex, default(T).Bits, bitsInField);
			
            if (constexpr.IS_TRUE(bitIndex == bitsInField - default(T).Bits) 
		     && constexpr.IS_TRUE(value == 0))
			{
				return bits_zerohigh(bits, bitsInField - default(T).Bits);
			}
			else
			{
				UInt128 mask = bitmask128(default(T).Bits, (ulong)bitIndex);
				UInt128 shiftedValue = (UInt128)(ulong)value << bitIndex;
				if (default(T).IsSigned)
				{
					if (!constexpr.IS_TRUE(value >= 0))
					{
						shiftedValue &= mask;
					}
				}

				return andnot(bits, mask) | shiftedValue;
			}
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint SetReplicate<T>(uint bits, int value, int numValues, int bitIndex, int bitsInField)
			where T : BitInt
		{
Assert.IsBetween(value, default(T).MinValueAsLong, default(T).MaxValueAsLong);
Assert.IsValidSubarray(bitIndex, default(T).Bits, bitsInField);
			
            if (Constant.IsConstantExpression(value))
            {
                if (constexpr.IS_TRUE(default(T).Bits * bitIndex + default(T).Bits * numValues == bitsInField) 
				 && value == 0)
                {
                    if (bitIndex == 0)
                    {
                        return 0u;
                    }
                    else
                    {
                        return bits_zerohigh(bits, bitIndex);
                    }
                }
            }

			if (default(T).IsSigned)
			{
				value = ValueHelper.TruncBits<T>(value);
			}

			uint splat = SWAR.Broadcast32<T>((uint)value);
			uint mask = (uint)bitmask32(numValues * default(T).Bits, bitIndex);
			return bits_select(bits, splat, mask);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong SetReplicate<T>(ulong bits, long value, int numValues, int bitIndex, int bitsInField)
			where T : BitInt
		{
Assert.IsBetween(value, default(T).MinValueAsLong, default(T).MaxValueAsLong);
Assert.IsValidSubarray(bitIndex, default(T).Bits, bitsInField);
			
            if (Constant.IsConstantExpression(value))
            {
                if (constexpr.IS_TRUE(default(T).Bits * bitIndex + default(T).Bits * numValues == bitsInField) 
				 && value == 0)
                {
                    if (bitIndex == 0)
                    {
                        return 0ul;
                    }
                    else
                    {
                        return bits_zerohigh(bits, bitIndex);
                    }
                }
            }

			if (default(T).IsSigned)
			{
				value = ValueHelper.TruncBits<T>(value);
			}

			ulong splat = SWAR.Broadcast64<T>((ulong)value);
			ulong mask = (ulong)bitmask64(numValues * default(T).Bits, bitIndex);
			return bits_select(bits, splat, mask);
		}


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte Replicate<T>(byte value)
			where T : BitInt
		{
										   value |= (byte)(value << (1  * default(T).Bits));
			if (2  * default(T).Bits <= 8) value |= (byte)(value << (2  * default(T).Bits));
			if (4  * default(T).Bits <= 8) value |= (byte)(value << (4  * default(T).Bits));
			if (8  * default(T).Bits <= 8) value |= (byte)(value << (8  * default(T).Bits));

			return value;
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ushort Replicate<T>(ushort value)
			where T : BitInt
		{
										    value |= (ushort)(value << (1  * default(T).Bits));
			if (2  * default(T).Bits <= 16) value |= (ushort)(value << (2  * default(T).Bits));
			if (4  * default(T).Bits <= 16) value |= (ushort)(value << (4  * default(T).Bits));
			if (8  * default(T).Bits <= 16) value |= (ushort)(value << (8  * default(T).Bits));
			if (16 * default(T).Bits <= 16) value |= (ushort)(value << (16 * default(T).Bits));

			return value;
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint Replicate<T>(uint value)
			where T : BitInt
		{
										    value |= value << (1  * default(T).Bits);
			if (2  * default(T).Bits <= 32) value |= value << (2  * default(T).Bits);
			if (4  * default(T).Bits <= 32) value |= value << (4  * default(T).Bits);
			if (8  * default(T).Bits <= 32) value |= value << (8  * default(T).Bits);
			if (16 * default(T).Bits <= 32) value |= value << (16 * default(T).Bits);
			if (32 * default(T).Bits <= 32) value |= value << (32 * default(T).Bits);

			return value;
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong Replicate<T>(ulong value)
			where T : BitInt
		{
										    value |= value << (1  * default(T).Bits);
			if (2  * default(T).Bits <= 64) value |= value << (2  * default(T).Bits);
			if (4  * default(T).Bits <= 64) value |= value << (4  * default(T).Bits);
			if (8  * default(T).Bits <= 64) value |= value << (8  * default(T).Bits);
			if (16 * default(T).Bits <= 64) value |= value << (16 * default(T).Bits);
			if (32 * default(T).Bits <= 64) value |= value << (32 * default(T).Bits);
			if (64 * default(T).Bits <= 64) value |= value << (64 * default(T).Bits);

			return value;
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static UInt128 Replicate<T>(UInt128 value)
			where T : BitInt
		{
										     value |= value << (1  * default(T).Bits);
			if (2  * default(T).Bits <= 128) value |= value << (2  * default(T).Bits);
			if (4  * default(T).Bits <= 128) value |= value << (4  * default(T).Bits);
			if (8  * default(T).Bits <= 128) value |= value << (8  * default(T).Bits);
			if (16 * default(T).Bits <= 128) value |= value << (16 * default(T).Bits);
			if (32 * default(T).Bits <= 128) value |= value << (32 * default(T).Bits);
			if (64 * default(T).Bits <= 128) value |= value << (64 * default(T).Bits);

			return value;
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt256__ Replicate<T>(__UInt256__ value)
			where T : BitInt
		{
										     value |= value << (1  * default(T).Bits);
			if (2  * default(T).Bits <= 256) value |= value << (2  * default(T).Bits);
			if (4  * default(T).Bits <= 256) value |= value << (4  * default(T).Bits);
			if (8  * default(T).Bits <= 256) value |= value << (8  * default(T).Bits);
			if (16 * default(T).Bits <= 256) value |= value << (16 * default(T).Bits);
			if (32 * default(T).Bits <= 256) value |= value << (32 * default(T).Bits);
			if (64 * default(T).Bits <= 256) value |= value << (64 * default(T).Bits);

			return value;
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt512__ Replicate<T>(__UInt512__ value)
			where T : BitInt
		{
										     value |= value << (1  * default(T).Bits);
			if (2  * default(T).Bits <= 512) value |= value << (2  * default(T).Bits);
			if (4  * default(T).Bits <= 512) value |= value << (4  * default(T).Bits);
			if (8  * default(T).Bits <= 512) value |= value << (8  * default(T).Bits);
			if (16 * default(T).Bits <= 512) value |= value << (16 * default(T).Bits);
			if (32 * default(T).Bits <= 512) value |= value << (32 * default(T).Bits);
			if (64 * default(T).Bits <= 512) value |= value << (64 * default(T).Bits);

			return value;
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt1024__ Replicate<T>(__UInt1024__ value)
			where T : BitInt
		{
										      value |= value << (1  * default(T).Bits);
			if (2  * default(T).Bits <= 1024) value |= value << (2  * default(T).Bits);
			if (4  * default(T).Bits <= 1024) value |= value << (4  * default(T).Bits);
			if (8  * default(T).Bits <= 1024) value |= value << (8  * default(T).Bits);
			if (16 * default(T).Bits <= 1024) value |= value << (16 * default(T).Bits);
			if (32 * default(T).Bits <= 1024) value |= value << (32 * default(T).Bits);
			if (64 * default(T).Bits <= 1024) value |= value << (64 * default(T).Bits);

			return value;
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt2048__ Replicate<T>(__UInt2048__ value)
			where T : BitInt
		{
										      value |= value << (1  * default(T).Bits);
			if (2  * default(T).Bits <= 2048) value |= value << (2  * default(T).Bits);
			if (4  * default(T).Bits <= 2048) value |= value << (4  * default(T).Bits);
			if (8  * default(T).Bits <= 2048) value |= value << (8  * default(T).Bits);
			if (16 * default(T).Bits <= 2048) value |= value << (16 * default(T).Bits);
			if (32 * default(T).Bits <= 2048) value |= value << (32 * default(T).Bits);
			if (64 * default(T).Bits <= 2048) value |= value << (64 * default(T).Bits);

			return value;
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static __UInt4096__ Replicate<T>(__UInt4096__ value)
			where T : BitInt
		{
										      value |= value << (1  * default(T).Bits);
			if (2  * default(T).Bits <= 4096) value |= value << (2  * default(T).Bits);
			if (4  * default(T).Bits <= 4096) value |= value << (4  * default(T).Bits);
			if (8  * default(T).Bits <= 4096) value |= value << (8  * default(T).Bits);
			if (16 * default(T).Bits <= 4096) value |= value << (16 * default(T).Bits);
			if (32 * default(T).Bits <= 4096) value |= value << (32 * default(T).Bits);
			if (64 * default(T).Bits <= 4096) value |= value << (64 * default(T).Bits);

			return value;
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0>()
			where T0 : BitInt
		{
			return default(T0).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1>()
			where T0 : BitInt
			where T1 : BitInt
		{
			return default(T0).Bits + default(T1).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
			where T26 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits + default(T26).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
			where T26 : BitInt
			where T27 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits + default(T26).Bits + default(T27).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
			where T26 : BitInt
			where T27 : BitInt
			where T28 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits + default(T26).Bits + default(T27).Bits + default(T28).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
			where T26 : BitInt
			where T27 : BitInt
			where T28 : BitInt
			where T29 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits + default(T26).Bits + default(T27).Bits + default(T28).Bits + default(T29).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
			where T26 : BitInt
			where T27 : BitInt
			where T28 : BitInt
			where T29 : BitInt
			where T30 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits + default(T26).Bits + default(T27).Bits + default(T28).Bits + default(T29).Bits + default(T30).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
			where T26 : BitInt
			where T27 : BitInt
			where T28 : BitInt
			where T29 : BitInt
			where T30 : BitInt
			where T31 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits + default(T26).Bits + default(T27).Bits + default(T28).Bits + default(T29).Bits + default(T30).Bits + default(T31).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
			where T26 : BitInt
			where T27 : BitInt
			where T28 : BitInt
			where T29 : BitInt
			where T30 : BitInt
			where T31 : BitInt
			where T32 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits + default(T26).Bits + default(T27).Bits + default(T28).Bits + default(T29).Bits + default(T30).Bits + default(T31).Bits + default(T32).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
			where T26 : BitInt
			where T27 : BitInt
			where T28 : BitInt
			where T29 : BitInt
			where T30 : BitInt
			where T31 : BitInt
			where T32 : BitInt
			where T33 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits + default(T26).Bits + default(T27).Bits + default(T28).Bits + default(T29).Bits + default(T30).Bits + default(T31).Bits + default(T32).Bits + default(T33).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
			where T26 : BitInt
			where T27 : BitInt
			where T28 : BitInt
			where T29 : BitInt
			where T30 : BitInt
			where T31 : BitInt
			where T32 : BitInt
			where T33 : BitInt
			where T34 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits + default(T26).Bits + default(T27).Bits + default(T28).Bits + default(T29).Bits + default(T30).Bits + default(T31).Bits + default(T32).Bits + default(T33).Bits + default(T34).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
			where T26 : BitInt
			where T27 : BitInt
			where T28 : BitInt
			where T29 : BitInt
			where T30 : BitInt
			where T31 : BitInt
			where T32 : BitInt
			where T33 : BitInt
			where T34 : BitInt
			where T35 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits + default(T26).Bits + default(T27).Bits + default(T28).Bits + default(T29).Bits + default(T30).Bits + default(T31).Bits + default(T32).Bits + default(T33).Bits + default(T34).Bits + default(T35).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
			where T26 : BitInt
			where T27 : BitInt
			where T28 : BitInt
			where T29 : BitInt
			where T30 : BitInt
			where T31 : BitInt
			where T32 : BitInt
			where T33 : BitInt
			where T34 : BitInt
			where T35 : BitInt
			where T36 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits + default(T26).Bits + default(T27).Bits + default(T28).Bits + default(T29).Bits + default(T30).Bits + default(T31).Bits + default(T32).Bits + default(T33).Bits + default(T34).Bits + default(T35).Bits + default(T36).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
			where T26 : BitInt
			where T27 : BitInt
			where T28 : BitInt
			where T29 : BitInt
			where T30 : BitInt
			where T31 : BitInt
			where T32 : BitInt
			where T33 : BitInt
			where T34 : BitInt
			where T35 : BitInt
			where T36 : BitInt
			where T37 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits + default(T26).Bits + default(T27).Bits + default(T28).Bits + default(T29).Bits + default(T30).Bits + default(T31).Bits + default(T32).Bits + default(T33).Bits + default(T34).Bits + default(T35).Bits + default(T36).Bits + default(T37).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
			where T26 : BitInt
			where T27 : BitInt
			where T28 : BitInt
			where T29 : BitInt
			where T30 : BitInt
			where T31 : BitInt
			where T32 : BitInt
			where T33 : BitInt
			where T34 : BitInt
			where T35 : BitInt
			where T36 : BitInt
			where T37 : BitInt
			where T38 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits + default(T26).Bits + default(T27).Bits + default(T28).Bits + default(T29).Bits + default(T30).Bits + default(T31).Bits + default(T32).Bits + default(T33).Bits + default(T34).Bits + default(T35).Bits + default(T36).Bits + default(T37).Bits + default(T38).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
			where T26 : BitInt
			where T27 : BitInt
			where T28 : BitInt
			where T29 : BitInt
			where T30 : BitInt
			where T31 : BitInt
			where T32 : BitInt
			where T33 : BitInt
			where T34 : BitInt
			where T35 : BitInt
			where T36 : BitInt
			where T37 : BitInt
			where T38 : BitInt
			where T39 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits + default(T26).Bits + default(T27).Bits + default(T28).Bits + default(T29).Bits + default(T30).Bits + default(T31).Bits + default(T32).Bits + default(T33).Bits + default(T34).Bits + default(T35).Bits + default(T36).Bits + default(T37).Bits + default(T38).Bits + default(T39).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
			where T26 : BitInt
			where T27 : BitInt
			where T28 : BitInt
			where T29 : BitInt
			where T30 : BitInt
			where T31 : BitInt
			where T32 : BitInt
			where T33 : BitInt
			where T34 : BitInt
			where T35 : BitInt
			where T36 : BitInt
			where T37 : BitInt
			where T38 : BitInt
			where T39 : BitInt
			where T40 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits + default(T26).Bits + default(T27).Bits + default(T28).Bits + default(T29).Bits + default(T30).Bits + default(T31).Bits + default(T32).Bits + default(T33).Bits + default(T34).Bits + default(T35).Bits + default(T36).Bits + default(T37).Bits + default(T38).Bits + default(T39).Bits + default(T40).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
			where T26 : BitInt
			where T27 : BitInt
			where T28 : BitInt
			where T29 : BitInt
			where T30 : BitInt
			where T31 : BitInt
			where T32 : BitInt
			where T33 : BitInt
			where T34 : BitInt
			where T35 : BitInt
			where T36 : BitInt
			where T37 : BitInt
			where T38 : BitInt
			where T39 : BitInt
			where T40 : BitInt
			where T41 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits + default(T26).Bits + default(T27).Bits + default(T28).Bits + default(T29).Bits + default(T30).Bits + default(T31).Bits + default(T32).Bits + default(T33).Bits + default(T34).Bits + default(T35).Bits + default(T36).Bits + default(T37).Bits + default(T38).Bits + default(T39).Bits + default(T40).Bits + default(T41).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
			where T26 : BitInt
			where T27 : BitInt
			where T28 : BitInt
			where T29 : BitInt
			where T30 : BitInt
			where T31 : BitInt
			where T32 : BitInt
			where T33 : BitInt
			where T34 : BitInt
			where T35 : BitInt
			where T36 : BitInt
			where T37 : BitInt
			where T38 : BitInt
			where T39 : BitInt
			where T40 : BitInt
			where T41 : BitInt
			where T42 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits + default(T26).Bits + default(T27).Bits + default(T28).Bits + default(T29).Bits + default(T30).Bits + default(T31).Bits + default(T32).Bits + default(T33).Bits + default(T34).Bits + default(T35).Bits + default(T36).Bits + default(T37).Bits + default(T38).Bits + default(T39).Bits + default(T40).Bits + default(T41).Bits + default(T42).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
			where T26 : BitInt
			where T27 : BitInt
			where T28 : BitInt
			where T29 : BitInt
			where T30 : BitInt
			where T31 : BitInt
			where T32 : BitInt
			where T33 : BitInt
			where T34 : BitInt
			where T35 : BitInt
			where T36 : BitInt
			where T37 : BitInt
			where T38 : BitInt
			where T39 : BitInt
			where T40 : BitInt
			where T41 : BitInt
			where T42 : BitInt
			where T43 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits + default(T26).Bits + default(T27).Bits + default(T28).Bits + default(T29).Bits + default(T30).Bits + default(T31).Bits + default(T32).Bits + default(T33).Bits + default(T34).Bits + default(T35).Bits + default(T36).Bits + default(T37).Bits + default(T38).Bits + default(T39).Bits + default(T40).Bits + default(T41).Bits + default(T42).Bits + default(T43).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
			where T26 : BitInt
			where T27 : BitInt
			where T28 : BitInt
			where T29 : BitInt
			where T30 : BitInt
			where T31 : BitInt
			where T32 : BitInt
			where T33 : BitInt
			where T34 : BitInt
			where T35 : BitInt
			where T36 : BitInt
			where T37 : BitInt
			where T38 : BitInt
			where T39 : BitInt
			where T40 : BitInt
			where T41 : BitInt
			where T42 : BitInt
			where T43 : BitInt
			where T44 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits + default(T26).Bits + default(T27).Bits + default(T28).Bits + default(T29).Bits + default(T30).Bits + default(T31).Bits + default(T32).Bits + default(T33).Bits + default(T34).Bits + default(T35).Bits + default(T36).Bits + default(T37).Bits + default(T38).Bits + default(T39).Bits + default(T40).Bits + default(T41).Bits + default(T42).Bits + default(T43).Bits + default(T44).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
			where T26 : BitInt
			where T27 : BitInt
			where T28 : BitInt
			where T29 : BitInt
			where T30 : BitInt
			where T31 : BitInt
			where T32 : BitInt
			where T33 : BitInt
			where T34 : BitInt
			where T35 : BitInt
			where T36 : BitInt
			where T37 : BitInt
			where T38 : BitInt
			where T39 : BitInt
			where T40 : BitInt
			where T41 : BitInt
			where T42 : BitInt
			where T43 : BitInt
			where T44 : BitInt
			where T45 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits + default(T26).Bits + default(T27).Bits + default(T28).Bits + default(T29).Bits + default(T30).Bits + default(T31).Bits + default(T32).Bits + default(T33).Bits + default(T34).Bits + default(T35).Bits + default(T36).Bits + default(T37).Bits + default(T38).Bits + default(T39).Bits + default(T40).Bits + default(T41).Bits + default(T42).Bits + default(T43).Bits + default(T44).Bits + default(T45).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
			where T26 : BitInt
			where T27 : BitInt
			where T28 : BitInt
			where T29 : BitInt
			where T30 : BitInt
			where T31 : BitInt
			where T32 : BitInt
			where T33 : BitInt
			where T34 : BitInt
			where T35 : BitInt
			where T36 : BitInt
			where T37 : BitInt
			where T38 : BitInt
			where T39 : BitInt
			where T40 : BitInt
			where T41 : BitInt
			where T42 : BitInt
			where T43 : BitInt
			where T44 : BitInt
			where T45 : BitInt
			where T46 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits + default(T26).Bits + default(T27).Bits + default(T28).Bits + default(T29).Bits + default(T30).Bits + default(T31).Bits + default(T32).Bits + default(T33).Bits + default(T34).Bits + default(T35).Bits + default(T36).Bits + default(T37).Bits + default(T38).Bits + default(T39).Bits + default(T40).Bits + default(T41).Bits + default(T42).Bits + default(T43).Bits + default(T44).Bits + default(T45).Bits + default(T46).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
			where T26 : BitInt
			where T27 : BitInt
			where T28 : BitInt
			where T29 : BitInt
			where T30 : BitInt
			where T31 : BitInt
			where T32 : BitInt
			where T33 : BitInt
			where T34 : BitInt
			where T35 : BitInt
			where T36 : BitInt
			where T37 : BitInt
			where T38 : BitInt
			where T39 : BitInt
			where T40 : BitInt
			where T41 : BitInt
			where T42 : BitInt
			where T43 : BitInt
			where T44 : BitInt
			where T45 : BitInt
			where T46 : BitInt
			where T47 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits + default(T26).Bits + default(T27).Bits + default(T28).Bits + default(T29).Bits + default(T30).Bits + default(T31).Bits + default(T32).Bits + default(T33).Bits + default(T34).Bits + default(T35).Bits + default(T36).Bits + default(T37).Bits + default(T38).Bits + default(T39).Bits + default(T40).Bits + default(T41).Bits + default(T42).Bits + default(T43).Bits + default(T44).Bits + default(T45).Bits + default(T46).Bits + default(T47).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
			where T26 : BitInt
			where T27 : BitInt
			where T28 : BitInt
			where T29 : BitInt
			where T30 : BitInt
			where T31 : BitInt
			where T32 : BitInt
			where T33 : BitInt
			where T34 : BitInt
			where T35 : BitInt
			where T36 : BitInt
			where T37 : BitInt
			where T38 : BitInt
			where T39 : BitInt
			where T40 : BitInt
			where T41 : BitInt
			where T42 : BitInt
			where T43 : BitInt
			where T44 : BitInt
			where T45 : BitInt
			where T46 : BitInt
			where T47 : BitInt
			where T48 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits + default(T26).Bits + default(T27).Bits + default(T28).Bits + default(T29).Bits + default(T30).Bits + default(T31).Bits + default(T32).Bits + default(T33).Bits + default(T34).Bits + default(T35).Bits + default(T36).Bits + default(T37).Bits + default(T38).Bits + default(T39).Bits + default(T40).Bits + default(T41).Bits + default(T42).Bits + default(T43).Bits + default(T44).Bits + default(T45).Bits + default(T46).Bits + default(T47).Bits + default(T48).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
			where T26 : BitInt
			where T27 : BitInt
			where T28 : BitInt
			where T29 : BitInt
			where T30 : BitInt
			where T31 : BitInt
			where T32 : BitInt
			where T33 : BitInt
			where T34 : BitInt
			where T35 : BitInt
			where T36 : BitInt
			where T37 : BitInt
			where T38 : BitInt
			where T39 : BitInt
			where T40 : BitInt
			where T41 : BitInt
			where T42 : BitInt
			where T43 : BitInt
			where T44 : BitInt
			where T45 : BitInt
			where T46 : BitInt
			where T47 : BitInt
			where T48 : BitInt
			where T49 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits + default(T26).Bits + default(T27).Bits + default(T28).Bits + default(T29).Bits + default(T30).Bits + default(T31).Bits + default(T32).Bits + default(T33).Bits + default(T34).Bits + default(T35).Bits + default(T36).Bits + default(T37).Bits + default(T38).Bits + default(T39).Bits + default(T40).Bits + default(T41).Bits + default(T42).Bits + default(T43).Bits + default(T44).Bits + default(T45).Bits + default(T46).Bits + default(T47).Bits + default(T48).Bits + default(T49).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
			where T26 : BitInt
			where T27 : BitInt
			where T28 : BitInt
			where T29 : BitInt
			where T30 : BitInt
			where T31 : BitInt
			where T32 : BitInt
			where T33 : BitInt
			where T34 : BitInt
			where T35 : BitInt
			where T36 : BitInt
			where T37 : BitInt
			where T38 : BitInt
			where T39 : BitInt
			where T40 : BitInt
			where T41 : BitInt
			where T42 : BitInt
			where T43 : BitInt
			where T44 : BitInt
			where T45 : BitInt
			where T46 : BitInt
			where T47 : BitInt
			where T48 : BitInt
			where T49 : BitInt
			where T50 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits + default(T26).Bits + default(T27).Bits + default(T28).Bits + default(T29).Bits + default(T30).Bits + default(T31).Bits + default(T32).Bits + default(T33).Bits + default(T34).Bits + default(T35).Bits + default(T36).Bits + default(T37).Bits + default(T38).Bits + default(T39).Bits + default(T40).Bits + default(T41).Bits + default(T42).Bits + default(T43).Bits + default(T44).Bits + default(T45).Bits + default(T46).Bits + default(T47).Bits + default(T48).Bits + default(T49).Bits + default(T50).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
			where T26 : BitInt
			where T27 : BitInt
			where T28 : BitInt
			where T29 : BitInt
			where T30 : BitInt
			where T31 : BitInt
			where T32 : BitInt
			where T33 : BitInt
			where T34 : BitInt
			where T35 : BitInt
			where T36 : BitInt
			where T37 : BitInt
			where T38 : BitInt
			where T39 : BitInt
			where T40 : BitInt
			where T41 : BitInt
			where T42 : BitInt
			where T43 : BitInt
			where T44 : BitInt
			where T45 : BitInt
			where T46 : BitInt
			where T47 : BitInt
			where T48 : BitInt
			where T49 : BitInt
			where T50 : BitInt
			where T51 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits + default(T26).Bits + default(T27).Bits + default(T28).Bits + default(T29).Bits + default(T30).Bits + default(T31).Bits + default(T32).Bits + default(T33).Bits + default(T34).Bits + default(T35).Bits + default(T36).Bits + default(T37).Bits + default(T38).Bits + default(T39).Bits + default(T40).Bits + default(T41).Bits + default(T42).Bits + default(T43).Bits + default(T44).Bits + default(T45).Bits + default(T46).Bits + default(T47).Bits + default(T48).Bits + default(T49).Bits + default(T50).Bits + default(T51).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
			where T26 : BitInt
			where T27 : BitInt
			where T28 : BitInt
			where T29 : BitInt
			where T30 : BitInt
			where T31 : BitInt
			where T32 : BitInt
			where T33 : BitInt
			where T34 : BitInt
			where T35 : BitInt
			where T36 : BitInt
			where T37 : BitInt
			where T38 : BitInt
			where T39 : BitInt
			where T40 : BitInt
			where T41 : BitInt
			where T42 : BitInt
			where T43 : BitInt
			where T44 : BitInt
			where T45 : BitInt
			where T46 : BitInt
			where T47 : BitInt
			where T48 : BitInt
			where T49 : BitInt
			where T50 : BitInt
			where T51 : BitInt
			where T52 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits + default(T26).Bits + default(T27).Bits + default(T28).Bits + default(T29).Bits + default(T30).Bits + default(T31).Bits + default(T32).Bits + default(T33).Bits + default(T34).Bits + default(T35).Bits + default(T36).Bits + default(T37).Bits + default(T38).Bits + default(T39).Bits + default(T40).Bits + default(T41).Bits + default(T42).Bits + default(T43).Bits + default(T44).Bits + default(T45).Bits + default(T46).Bits + default(T47).Bits + default(T48).Bits + default(T49).Bits + default(T50).Bits + default(T51).Bits + default(T52).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
			where T26 : BitInt
			where T27 : BitInt
			where T28 : BitInt
			where T29 : BitInt
			where T30 : BitInt
			where T31 : BitInt
			where T32 : BitInt
			where T33 : BitInt
			where T34 : BitInt
			where T35 : BitInt
			where T36 : BitInt
			where T37 : BitInt
			where T38 : BitInt
			where T39 : BitInt
			where T40 : BitInt
			where T41 : BitInt
			where T42 : BitInt
			where T43 : BitInt
			where T44 : BitInt
			where T45 : BitInt
			where T46 : BitInt
			where T47 : BitInt
			where T48 : BitInt
			where T49 : BitInt
			where T50 : BitInt
			where T51 : BitInt
			where T52 : BitInt
			where T53 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits + default(T26).Bits + default(T27).Bits + default(T28).Bits + default(T29).Bits + default(T30).Bits + default(T31).Bits + default(T32).Bits + default(T33).Bits + default(T34).Bits + default(T35).Bits + default(T36).Bits + default(T37).Bits + default(T38).Bits + default(T39).Bits + default(T40).Bits + default(T41).Bits + default(T42).Bits + default(T43).Bits + default(T44).Bits + default(T45).Bits + default(T46).Bits + default(T47).Bits + default(T48).Bits + default(T49).Bits + default(T50).Bits + default(T51).Bits + default(T52).Bits + default(T53).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
			where T26 : BitInt
			where T27 : BitInt
			where T28 : BitInt
			where T29 : BitInt
			where T30 : BitInt
			where T31 : BitInt
			where T32 : BitInt
			where T33 : BitInt
			where T34 : BitInt
			where T35 : BitInt
			where T36 : BitInt
			where T37 : BitInt
			where T38 : BitInt
			where T39 : BitInt
			where T40 : BitInt
			where T41 : BitInt
			where T42 : BitInt
			where T43 : BitInt
			where T44 : BitInt
			where T45 : BitInt
			where T46 : BitInt
			where T47 : BitInt
			where T48 : BitInt
			where T49 : BitInt
			where T50 : BitInt
			where T51 : BitInt
			where T52 : BitInt
			where T53 : BitInt
			where T54 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits + default(T26).Bits + default(T27).Bits + default(T28).Bits + default(T29).Bits + default(T30).Bits + default(T31).Bits + default(T32).Bits + default(T33).Bits + default(T34).Bits + default(T35).Bits + default(T36).Bits + default(T37).Bits + default(T38).Bits + default(T39).Bits + default(T40).Bits + default(T41).Bits + default(T42).Bits + default(T43).Bits + default(T44).Bits + default(T45).Bits + default(T46).Bits + default(T47).Bits + default(T48).Bits + default(T49).Bits + default(T50).Bits + default(T51).Bits + default(T52).Bits + default(T53).Bits + default(T54).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
			where T26 : BitInt
			where T27 : BitInt
			where T28 : BitInt
			where T29 : BitInt
			where T30 : BitInt
			where T31 : BitInt
			where T32 : BitInt
			where T33 : BitInt
			where T34 : BitInt
			where T35 : BitInt
			where T36 : BitInt
			where T37 : BitInt
			where T38 : BitInt
			where T39 : BitInt
			where T40 : BitInt
			where T41 : BitInt
			where T42 : BitInt
			where T43 : BitInt
			where T44 : BitInt
			where T45 : BitInt
			where T46 : BitInt
			where T47 : BitInt
			where T48 : BitInt
			where T49 : BitInt
			where T50 : BitInt
			where T51 : BitInt
			where T52 : BitInt
			where T53 : BitInt
			where T54 : BitInt
			where T55 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits + default(T26).Bits + default(T27).Bits + default(T28).Bits + default(T29).Bits + default(T30).Bits + default(T31).Bits + default(T32).Bits + default(T33).Bits + default(T34).Bits + default(T35).Bits + default(T36).Bits + default(T37).Bits + default(T38).Bits + default(T39).Bits + default(T40).Bits + default(T41).Bits + default(T42).Bits + default(T43).Bits + default(T44).Bits + default(T45).Bits + default(T46).Bits + default(T47).Bits + default(T48).Bits + default(T49).Bits + default(T50).Bits + default(T51).Bits + default(T52).Bits + default(T53).Bits + default(T54).Bits + default(T55).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
			where T26 : BitInt
			where T27 : BitInt
			where T28 : BitInt
			where T29 : BitInt
			where T30 : BitInt
			where T31 : BitInt
			where T32 : BitInt
			where T33 : BitInt
			where T34 : BitInt
			where T35 : BitInt
			where T36 : BitInt
			where T37 : BitInt
			where T38 : BitInt
			where T39 : BitInt
			where T40 : BitInt
			where T41 : BitInt
			where T42 : BitInt
			where T43 : BitInt
			where T44 : BitInt
			where T45 : BitInt
			where T46 : BitInt
			where T47 : BitInt
			where T48 : BitInt
			where T49 : BitInt
			where T50 : BitInt
			where T51 : BitInt
			where T52 : BitInt
			where T53 : BitInt
			where T54 : BitInt
			where T55 : BitInt
			where T56 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits + default(T26).Bits + default(T27).Bits + default(T28).Bits + default(T29).Bits + default(T30).Bits + default(T31).Bits + default(T32).Bits + default(T33).Bits + default(T34).Bits + default(T35).Bits + default(T36).Bits + default(T37).Bits + default(T38).Bits + default(T39).Bits + default(T40).Bits + default(T41).Bits + default(T42).Bits + default(T43).Bits + default(T44).Bits + default(T45).Bits + default(T46).Bits + default(T47).Bits + default(T48).Bits + default(T49).Bits + default(T50).Bits + default(T51).Bits + default(T52).Bits + default(T53).Bits + default(T54).Bits + default(T55).Bits + default(T56).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
			where T26 : BitInt
			where T27 : BitInt
			where T28 : BitInt
			where T29 : BitInt
			where T30 : BitInt
			where T31 : BitInt
			where T32 : BitInt
			where T33 : BitInt
			where T34 : BitInt
			where T35 : BitInt
			where T36 : BitInt
			where T37 : BitInt
			where T38 : BitInt
			where T39 : BitInt
			where T40 : BitInt
			where T41 : BitInt
			where T42 : BitInt
			where T43 : BitInt
			where T44 : BitInt
			where T45 : BitInt
			where T46 : BitInt
			where T47 : BitInt
			where T48 : BitInt
			where T49 : BitInt
			where T50 : BitInt
			where T51 : BitInt
			where T52 : BitInt
			where T53 : BitInt
			where T54 : BitInt
			where T55 : BitInt
			where T56 : BitInt
			where T57 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits + default(T26).Bits + default(T27).Bits + default(T28).Bits + default(T29).Bits + default(T30).Bits + default(T31).Bits + default(T32).Bits + default(T33).Bits + default(T34).Bits + default(T35).Bits + default(T36).Bits + default(T37).Bits + default(T38).Bits + default(T39).Bits + default(T40).Bits + default(T41).Bits + default(T42).Bits + default(T43).Bits + default(T44).Bits + default(T45).Bits + default(T46).Bits + default(T47).Bits + default(T48).Bits + default(T49).Bits + default(T50).Bits + default(T51).Bits + default(T52).Bits + default(T53).Bits + default(T54).Bits + default(T55).Bits + default(T56).Bits + default(T57).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
			where T26 : BitInt
			where T27 : BitInt
			where T28 : BitInt
			where T29 : BitInt
			where T30 : BitInt
			where T31 : BitInt
			where T32 : BitInt
			where T33 : BitInt
			where T34 : BitInt
			where T35 : BitInt
			where T36 : BitInt
			where T37 : BitInt
			where T38 : BitInt
			where T39 : BitInt
			where T40 : BitInt
			where T41 : BitInt
			where T42 : BitInt
			where T43 : BitInt
			where T44 : BitInt
			where T45 : BitInt
			where T46 : BitInt
			where T47 : BitInt
			where T48 : BitInt
			where T49 : BitInt
			where T50 : BitInt
			where T51 : BitInt
			where T52 : BitInt
			where T53 : BitInt
			where T54 : BitInt
			where T55 : BitInt
			where T56 : BitInt
			where T57 : BitInt
			where T58 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits + default(T26).Bits + default(T27).Bits + default(T28).Bits + default(T29).Bits + default(T30).Bits + default(T31).Bits + default(T32).Bits + default(T33).Bits + default(T34).Bits + default(T35).Bits + default(T36).Bits + default(T37).Bits + default(T38).Bits + default(T39).Bits + default(T40).Bits + default(T41).Bits + default(T42).Bits + default(T43).Bits + default(T44).Bits + default(T45).Bits + default(T46).Bits + default(T47).Bits + default(T48).Bits + default(T49).Bits + default(T50).Bits + default(T51).Bits + default(T52).Bits + default(T53).Bits + default(T54).Bits + default(T55).Bits + default(T56).Bits + default(T57).Bits + default(T58).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
			where T26 : BitInt
			where T27 : BitInt
			where T28 : BitInt
			where T29 : BitInt
			where T30 : BitInt
			where T31 : BitInt
			where T32 : BitInt
			where T33 : BitInt
			where T34 : BitInt
			where T35 : BitInt
			where T36 : BitInt
			where T37 : BitInt
			where T38 : BitInt
			where T39 : BitInt
			where T40 : BitInt
			where T41 : BitInt
			where T42 : BitInt
			where T43 : BitInt
			where T44 : BitInt
			where T45 : BitInt
			where T46 : BitInt
			where T47 : BitInt
			where T48 : BitInt
			where T49 : BitInt
			where T50 : BitInt
			where T51 : BitInt
			where T52 : BitInt
			where T53 : BitInt
			where T54 : BitInt
			where T55 : BitInt
			where T56 : BitInt
			where T57 : BitInt
			where T58 : BitInt
			where T59 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits + default(T26).Bits + default(T27).Bits + default(T28).Bits + default(T29).Bits + default(T30).Bits + default(T31).Bits + default(T32).Bits + default(T33).Bits + default(T34).Bits + default(T35).Bits + default(T36).Bits + default(T37).Bits + default(T38).Bits + default(T39).Bits + default(T40).Bits + default(T41).Bits + default(T42).Bits + default(T43).Bits + default(T44).Bits + default(T45).Bits + default(T46).Bits + default(T47).Bits + default(T48).Bits + default(T49).Bits + default(T50).Bits + default(T51).Bits + default(T52).Bits + default(T53).Bits + default(T54).Bits + default(T55).Bits + default(T56).Bits + default(T57).Bits + default(T58).Bits + default(T59).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
			where T26 : BitInt
			where T27 : BitInt
			where T28 : BitInt
			where T29 : BitInt
			where T30 : BitInt
			where T31 : BitInt
			where T32 : BitInt
			where T33 : BitInt
			where T34 : BitInt
			where T35 : BitInt
			where T36 : BitInt
			where T37 : BitInt
			where T38 : BitInt
			where T39 : BitInt
			where T40 : BitInt
			where T41 : BitInt
			where T42 : BitInt
			where T43 : BitInt
			where T44 : BitInt
			where T45 : BitInt
			where T46 : BitInt
			where T47 : BitInt
			where T48 : BitInt
			where T49 : BitInt
			where T50 : BitInt
			where T51 : BitInt
			where T52 : BitInt
			where T53 : BitInt
			where T54 : BitInt
			where T55 : BitInt
			where T56 : BitInt
			where T57 : BitInt
			where T58 : BitInt
			where T59 : BitInt
			where T60 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits + default(T26).Bits + default(T27).Bits + default(T28).Bits + default(T29).Bits + default(T30).Bits + default(T31).Bits + default(T32).Bits + default(T33).Bits + default(T34).Bits + default(T35).Bits + default(T36).Bits + default(T37).Bits + default(T38).Bits + default(T39).Bits + default(T40).Bits + default(T41).Bits + default(T42).Bits + default(T43).Bits + default(T44).Bits + default(T45).Bits + default(T46).Bits + default(T47).Bits + default(T48).Bits + default(T49).Bits + default(T50).Bits + default(T51).Bits + default(T52).Bits + default(T53).Bits + default(T54).Bits + default(T55).Bits + default(T56).Bits + default(T57).Bits + default(T58).Bits + default(T59).Bits + default(T60).Bits;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61>()
			where T0 : BitInt
			where T1 : BitInt
			where T2 : BitInt
			where T3 : BitInt
			where T4 : BitInt
			where T5 : BitInt
			where T6 : BitInt
			where T7 : BitInt
			where T8 : BitInt
			where T9 : BitInt
			where T10 : BitInt
			where T11 : BitInt
			where T12 : BitInt
			where T13 : BitInt
			where T14 : BitInt
			where T15 : BitInt
			where T16 : BitInt
			where T17 : BitInt
			where T18 : BitInt
			where T19 : BitInt
			where T20 : BitInt
			where T21 : BitInt
			where T22 : BitInt
			where T23 : BitInt
			where T24 : BitInt
			where T25 : BitInt
			where T26 : BitInt
			where T27 : BitInt
			where T28 : BitInt
			where T29 : BitInt
			where T30 : BitInt
			where T31 : BitInt
			where T32 : BitInt
			where T33 : BitInt
			where T34 : BitInt
			where T35 : BitInt
			where T36 : BitInt
			where T37 : BitInt
			where T38 : BitInt
			where T39 : BitInt
			where T40 : BitInt
			where T41 : BitInt
			where T42 : BitInt
			where T43 : BitInt
			where T44 : BitInt
			where T45 : BitInt
			where T46 : BitInt
			where T47 : BitInt
			where T48 : BitInt
			where T49 : BitInt
			where T50 : BitInt
			where T51 : BitInt
			where T52 : BitInt
			where T53 : BitInt
			where T54 : BitInt
			where T55 : BitInt
			where T56 : BitInt
			where T57 : BitInt
			where T58 : BitInt
			where T59 : BitInt
			where T60 : BitInt
			where T61 : BitInt
		{
			return default(T0).Bits + default(T1).Bits + default(T2).Bits + default(T3).Bits + default(T4).Bits + default(T5).Bits + default(T6).Bits + default(T7).Bits + default(T8).Bits + default(T9).Bits + default(T10).Bits + default(T11).Bits + default(T12).Bits + default(T13).Bits + default(T14).Bits + default(T15).Bits + default(T16).Bits + default(T17).Bits + default(T18).Bits + default(T19).Bits + default(T20).Bits + default(T21).Bits + default(T22).Bits + default(T23).Bits + default(T24).Bits + default(T25).Bits + default(T26).Bits + default(T27).Bits + default(T28).Bits + default(T29).Bits + default(T30).Bits + default(T31).Bits + default(T32).Bits + default(T33).Bits + default(T34).Bits + default(T35).Bits + default(T36).Bits + default(T37).Bits + default(T38).Bits + default(T39).Bits + default(T40).Bits + default(T41).Bits + default(T42).Bits + default(T43).Bits + default(T44).Bits + default(T45).Bits + default(T46).Bits + default(T47).Bits + default(T48).Bits + default(T49).Bits + default(T50).Bits + default(T51).Bits + default(T52).Bits + default(T53).Bits + default(T54).Bits + default(T55).Bits + default(T56).Bits + default(T57).Bits + default(T58).Bits + default(T59).Bits + default(T60).Bits + default(T61).Bits;
		}
	}
}
