using System;
using System.Runtime.CompilerServices;

using static BitCollections.BitFieldHelper;

namespace BitCollections
{		
	[Serializable]
	public struct BitField64<T0, T1>
		where T0 : BitInt
		where T1 : BitInt
	{
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
	{
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
		where T3 : BitInt
	{
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
		where T3 : BitInt
		where T4 : BitInt
	{
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
		where T3 : BitInt
		where T4 : BitInt
		where T5 : BitInt
	{
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
		where T3 : BitInt
		where T4 : BitInt
		where T5 : BitInt
		where T6 : BitInt
	{
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
		where T3 : BitInt
		where T4 : BitInt
		where T5 : BitInt
		where T6 : BitInt
		where T7 : BitInt
	{
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
		}
		public long Field43
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T43>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T43>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
		}
		public long Field43
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T43>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T43>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
		}
		public long Field44
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T44>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T44>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
		}
		public long Field43
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T43>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T43>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
		}
		public long Field44
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T44>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T44>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
		}
		public long Field45
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T45>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T45>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
		}
		public long Field43
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T43>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T43>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
		}
		public long Field44
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T44>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T44>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
		}
		public long Field45
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T45>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T45>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 64);
		}
		public long Field46
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T46>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T46>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
		}
		public long Field43
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T43>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T43>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
		}
		public long Field44
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T44>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T44>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
		}
		public long Field45
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T45>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T45>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 64);
		}
		public long Field46
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T46>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T46>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 64);
		}
		public long Field47
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T47>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T47>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
		}
		public long Field43
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T43>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T43>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
		}
		public long Field44
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T44>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T44>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
		}
		public long Field45
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T45>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T45>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 64);
		}
		public long Field46
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T46>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T46>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 64);
		}
		public long Field47
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T47>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T47>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 64);
		}
		public long Field48
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T48>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T48>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
		}
		public long Field43
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T43>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T43>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
		}
		public long Field44
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T44>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T44>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
		}
		public long Field45
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T45>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T45>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 64);
		}
		public long Field46
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T46>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T46>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 64);
		}
		public long Field47
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T47>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T47>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 64);
		}
		public long Field48
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T48>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T48>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 64);
		}
		public long Field49
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T49>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T49>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
		}
		public long Field43
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T43>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T43>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
		}
		public long Field44
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T44>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T44>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
		}
		public long Field45
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T45>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T45>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 64);
		}
		public long Field46
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T46>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T46>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 64);
		}
		public long Field47
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T47>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T47>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 64);
		}
		public long Field48
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T48>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T48>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 64);
		}
		public long Field49
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T49>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T49>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 64);
		}
		public long Field50
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T50>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T50>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
		}
		public long Field43
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T43>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T43>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
		}
		public long Field44
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T44>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T44>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
		}
		public long Field45
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T45>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T45>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 64);
		}
		public long Field46
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T46>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T46>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 64);
		}
		public long Field47
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T47>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T47>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 64);
		}
		public long Field48
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T48>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T48>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 64);
		}
		public long Field49
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T49>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T49>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 64);
		}
		public long Field50
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T50>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T50>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(), 64);
		}
		public long Field51
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T51>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T51>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
		}
		public long Field43
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T43>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T43>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
		}
		public long Field44
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T44>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T44>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
		}
		public long Field45
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T45>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T45>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 64);
		}
		public long Field46
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T46>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T46>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 64);
		}
		public long Field47
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T47>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T47>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 64);
		}
		public long Field48
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T48>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T48>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 64);
		}
		public long Field49
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T49>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T49>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 64);
		}
		public long Field50
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T50>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T50>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(), 64);
		}
		public long Field51
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T51>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T51>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(), 64);
		}
		public long Field52
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T52>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T52>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
		}
		public long Field43
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T43>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T43>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
		}
		public long Field44
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T44>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T44>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
		}
		public long Field45
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T45>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T45>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 64);
		}
		public long Field46
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T46>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T46>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 64);
		}
		public long Field47
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T47>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T47>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 64);
		}
		public long Field48
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T48>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T48>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 64);
		}
		public long Field49
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T49>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T49>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 64);
		}
		public long Field50
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T50>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T50>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(), 64);
		}
		public long Field51
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T51>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T51>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(), 64);
		}
		public long Field52
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T52>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T52>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>(), 64);
		}
		public long Field53
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T53>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T53>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
		}
		public long Field43
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T43>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T43>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
		}
		public long Field44
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T44>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T44>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
		}
		public long Field45
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T45>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T45>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 64);
		}
		public long Field46
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T46>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T46>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 64);
		}
		public long Field47
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T47>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T47>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 64);
		}
		public long Field48
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T48>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T48>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 64);
		}
		public long Field49
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T49>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T49>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 64);
		}
		public long Field50
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T50>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T50>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(), 64);
		}
		public long Field51
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T51>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T51>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(), 64);
		}
		public long Field52
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T52>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T52>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>(), 64);
		}
		public long Field53
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T53>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T53>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52>(), 64);
		}
		public long Field54
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T54>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T54>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
		}
		public long Field43
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T43>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T43>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
		}
		public long Field44
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T44>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T44>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
		}
		public long Field45
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T45>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T45>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 64);
		}
		public long Field46
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T46>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T46>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 64);
		}
		public long Field47
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T47>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T47>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 64);
		}
		public long Field48
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T48>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T48>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 64);
		}
		public long Field49
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T49>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T49>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 64);
		}
		public long Field50
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T50>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T50>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(), 64);
		}
		public long Field51
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T51>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T51>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(), 64);
		}
		public long Field52
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T52>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T52>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>(), 64);
		}
		public long Field53
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T53>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T53>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52>(), 64);
		}
		public long Field54
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T54>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T54>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53>(), 64);
		}
		public long Field55
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T55>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T55>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
		}
		public long Field43
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T43>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T43>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
		}
		public long Field44
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T44>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T44>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
		}
		public long Field45
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T45>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T45>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 64);
		}
		public long Field46
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T46>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T46>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 64);
		}
		public long Field47
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T47>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T47>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 64);
		}
		public long Field48
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T48>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T48>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 64);
		}
		public long Field49
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T49>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T49>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 64);
		}
		public long Field50
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T50>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T50>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(), 64);
		}
		public long Field51
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T51>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T51>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(), 64);
		}
		public long Field52
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T52>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T52>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>(), 64);
		}
		public long Field53
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T53>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T53>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52>(), 64);
		}
		public long Field54
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T54>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T54>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53>(), 64);
		}
		public long Field55
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T55>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T55>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54>(), 64);
		}
		public long Field56
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T56>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T56>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
		}
		public long Field43
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T43>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T43>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
		}
		public long Field44
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T44>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T44>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
		}
		public long Field45
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T45>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T45>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 64);
		}
		public long Field46
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T46>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T46>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 64);
		}
		public long Field47
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T47>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T47>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 64);
		}
		public long Field48
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T48>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T48>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 64);
		}
		public long Field49
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T49>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T49>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 64);
		}
		public long Field50
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T50>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T50>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(), 64);
		}
		public long Field51
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T51>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T51>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(), 64);
		}
		public long Field52
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T52>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T52>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>(), 64);
		}
		public long Field53
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T53>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T53>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52>(), 64);
		}
		public long Field54
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T54>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T54>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53>(), 64);
		}
		public long Field55
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T55>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T55>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54>(), 64);
		}
		public long Field56
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T56>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T56>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55>(), 64);
		}
		public long Field57
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T57>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T57>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
		}
		public long Field43
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T43>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T43>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
		}
		public long Field44
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T44>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T44>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
		}
		public long Field45
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T45>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T45>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 64);
		}
		public long Field46
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T46>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T46>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 64);
		}
		public long Field47
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T47>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T47>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 64);
		}
		public long Field48
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T48>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T48>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 64);
		}
		public long Field49
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T49>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T49>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 64);
		}
		public long Field50
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T50>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T50>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(), 64);
		}
		public long Field51
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T51>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T51>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(), 64);
		}
		public long Field52
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T52>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T52>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>(), 64);
		}
		public long Field53
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T53>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T53>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52>(), 64);
		}
		public long Field54
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T54>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T54>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53>(), 64);
		}
		public long Field55
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T55>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T55>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54>(), 64);
		}
		public long Field56
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T56>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T56>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55>(), 64);
		}
		public long Field57
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T57>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T57>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56>(), 64);
		}
		public long Field58
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T58>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T58>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
		}
		public long Field43
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T43>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T43>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
		}
		public long Field44
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T44>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T44>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
		}
		public long Field45
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T45>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T45>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 64);
		}
		public long Field46
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T46>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T46>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 64);
		}
		public long Field47
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T47>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T47>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 64);
		}
		public long Field48
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T48>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T48>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 64);
		}
		public long Field49
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T49>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T49>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 64);
		}
		public long Field50
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T50>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T50>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(), 64);
		}
		public long Field51
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T51>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T51>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(), 64);
		}
		public long Field52
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T52>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T52>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>(), 64);
		}
		public long Field53
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T53>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T53>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52>(), 64);
		}
		public long Field54
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T54>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T54>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53>(), 64);
		}
		public long Field55
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T55>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T55>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54>(), 64);
		}
		public long Field56
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T56>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T56>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55>(), 64);
		}
		public long Field57
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T57>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T57>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56>(), 64);
		}
		public long Field58
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T58>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T58>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57>(), 64);
		}
		public long Field59
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T59>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T59>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
		}
		public long Field43
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T43>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T43>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
		}
		public long Field44
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T44>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T44>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
		}
		public long Field45
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T45>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T45>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 64);
		}
		public long Field46
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T46>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T46>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 64);
		}
		public long Field47
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T47>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T47>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 64);
		}
		public long Field48
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T48>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T48>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 64);
		}
		public long Field49
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T49>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T49>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 64);
		}
		public long Field50
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T50>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T50>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(), 64);
		}
		public long Field51
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T51>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T51>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(), 64);
		}
		public long Field52
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T52>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T52>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>(), 64);
		}
		public long Field53
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T53>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T53>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52>(), 64);
		}
		public long Field54
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T54>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T54>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53>(), 64);
		}
		public long Field55
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T55>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T55>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54>(), 64);
		}
		public long Field56
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T56>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T56>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55>(), 64);
		}
		public long Field57
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T57>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T57>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56>(), 64);
		}
		public long Field58
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T58>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T58>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57>(), 64);
		}
		public long Field59
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T59>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T59>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(), 64);
		}
		public long Field60
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T60>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T60>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61>
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
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
		}
		public long Field43
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T43>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T43>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
		}
		public long Field44
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T44>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T44>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
		}
		public long Field45
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T45>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T45>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 64);
		}
		public long Field46
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T46>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T46>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 64);
		}
		public long Field47
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T47>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T47>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 64);
		}
		public long Field48
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T48>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T48>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 64);
		}
		public long Field49
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T49>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T49>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 64);
		}
		public long Field50
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T50>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T50>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(), 64);
		}
		public long Field51
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T51>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T51>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(), 64);
		}
		public long Field52
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T52>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T52>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>(), 64);
		}
		public long Field53
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T53>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T53>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52>(), 64);
		}
		public long Field54
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T54>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T54>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53>(), 64);
		}
		public long Field55
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T55>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T55>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54>(), 64);
		}
		public long Field56
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T56>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T56>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55>(), 64);
		}
		public long Field57
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T57>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T57>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56>(), 64);
		}
		public long Field58
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T58>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T58>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57>(), 64);
		}
		public long Field59
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T59>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T59>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(), 64);
		}
		public long Field60
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T60>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T60>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59>(), 64);
		}
		public long Field61
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T61>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T61>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60>(), 64);
		}
	}

	[Serializable]
	public struct BitField64<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61, T62>
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
		where T62 : BitInt
	{
		private ulong Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T0>(Bits, value, 0, 64);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T1>(Bits, value, Index<T0>(), 64);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T2>(Bits, value, Index<T0, T1>(), 64);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T3>(Bits, value, Index<T0, T1, T2>(), 64);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 64);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 64);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 64);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 64);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 64);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 64);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 64);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 64);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 64);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 64);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 64);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 64);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 64);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 64);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 64);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 64);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 64);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 64);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 64);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 64);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 64);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 64);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 64);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 64);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 64);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 64);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 64);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 64);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 64);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 64);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 64);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 64);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 64);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 64);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 64);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 64);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 64);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 64);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 64);
		}
		public long Field43
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T43>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T43>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 64);
		}
		public long Field44
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T44>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T44>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 64);
		}
		public long Field45
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T45>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T45>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 64);
		}
		public long Field46
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T46>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T46>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 64);
		}
		public long Field47
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T47>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T47>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 64);
		}
		public long Field48
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T48>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T48>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 64);
		}
		public long Field49
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T49>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T49>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 64);
		}
		public long Field50
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T50>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T50>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(), 64);
		}
		public long Field51
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T51>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T51>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(), 64);
		}
		public long Field52
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T52>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T52>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>(), 64);
		}
		public long Field53
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T53>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T53>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52>(), 64);
		}
		public long Field54
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T54>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T54>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53>(), 64);
		}
		public long Field55
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T55>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T55>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54>(), 64);
		}
		public long Field56
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T56>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T56>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55>(), 64);
		}
		public long Field57
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T57>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T57>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56>(), 64);
		}
		public long Field58
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T58>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T58>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57>(), 64);
		}
		public long Field59
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T59>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T59>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(), 64);
		}
		public long Field60
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T60>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T60>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59>(), 64);
		}
		public long Field61
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T61>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T61>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60>(), 64);
		}
		public long Field62
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T62>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61>(), 64);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = Set<T62>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61>(), 64);
		}
	}
}
