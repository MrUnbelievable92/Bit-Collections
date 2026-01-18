using System;
using System.Runtime.CompilerServices;

using static BitCollections.BitFieldHelper;

namespace BitCollections
{		
	[Serializable]
	public struct BitField56<T0, T1>
		where T0 : BitInt
		where T1 : BitInt
	{
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
	{
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
		where T3 : BitInt
	{
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
		where T3 : BitInt
		where T4 : BitInt
	{
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
		where T3 : BitInt
		where T4 : BitInt
		where T5 : BitInt
	{
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
		where T3 : BitInt
		where T4 : BitInt
		where T5 : BitInt
		where T6 : BitInt
	{
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
		where T3 : BitInt
		where T4 : BitInt
		where T5 : BitInt
		where T6 : BitInt
		where T7 : BitInt
	{
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 56);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 56);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 56);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 56);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 56);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 56);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 56);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 56);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 56);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 56);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 56);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 56);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 56);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 56);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 56);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 56);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 56);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 56);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 56);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 56);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 56);
		}
		public long Field43
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T43>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T43>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 56);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 56);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 56);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 56);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 56);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 56);
		}
		public long Field43
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T43>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T43>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 56);
		}
		public long Field44
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T44>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T44>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 56);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 56);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 56);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 56);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 56);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 56);
		}
		public long Field43
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T43>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T43>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 56);
		}
		public long Field44
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T44>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T44>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 56);
		}
		public long Field45
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T45>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T45>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 56);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 56);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 56);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 56);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 56);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 56);
		}
		public long Field43
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T43>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T43>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 56);
		}
		public long Field44
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T44>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T44>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 56);
		}
		public long Field45
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T45>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T45>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 56);
		}
		public long Field46
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T46>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T46>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 56);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 56);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 56);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 56);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 56);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 56);
		}
		public long Field43
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T43>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T43>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 56);
		}
		public long Field44
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T44>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T44>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 56);
		}
		public long Field45
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T45>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T45>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 56);
		}
		public long Field46
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T46>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T46>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 56);
		}
		public long Field47
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T47>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T47>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 56);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 56);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 56);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 56);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 56);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 56);
		}
		public long Field43
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T43>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T43>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 56);
		}
		public long Field44
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T44>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T44>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 56);
		}
		public long Field45
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T45>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T45>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 56);
		}
		public long Field46
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T46>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T46>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 56);
		}
		public long Field47
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T47>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T47>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 56);
		}
		public long Field48
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T48>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T48>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 56);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 56);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 56);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 56);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 56);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 56);
		}
		public long Field43
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T43>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T43>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 56);
		}
		public long Field44
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T44>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T44>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 56);
		}
		public long Field45
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T45>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T45>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 56);
		}
		public long Field46
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T46>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T46>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 56);
		}
		public long Field47
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T47>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T47>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 56);
		}
		public long Field48
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T48>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T48>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 56);
		}
		public long Field49
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T49>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T49>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 56);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 56);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 56);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 56);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 56);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 56);
		}
		public long Field43
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T43>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T43>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 56);
		}
		public long Field44
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T44>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T44>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 56);
		}
		public long Field45
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T45>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T45>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 56);
		}
		public long Field46
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T46>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T46>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 56);
		}
		public long Field47
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T47>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T47>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 56);
		}
		public long Field48
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T48>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T48>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 56);
		}
		public long Field49
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T49>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T49>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 56);
		}
		public long Field50
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T50>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T50>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 56);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 56);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 56);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 56);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 56);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 56);
		}
		public long Field43
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T43>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T43>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 56);
		}
		public long Field44
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T44>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T44>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 56);
		}
		public long Field45
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T45>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T45>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 56);
		}
		public long Field46
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T46>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T46>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 56);
		}
		public long Field47
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T47>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T47>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 56);
		}
		public long Field48
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T48>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T48>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 56);
		}
		public long Field49
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T49>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T49>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 56);
		}
		public long Field50
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T50>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T50>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(), 56);
		}
		public long Field51
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T51>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T51>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 56);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 56);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 56);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 56);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 56);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 56);
		}
		public long Field43
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T43>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T43>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 56);
		}
		public long Field44
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T44>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T44>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 56);
		}
		public long Field45
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T45>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T45>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 56);
		}
		public long Field46
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T46>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T46>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 56);
		}
		public long Field47
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T47>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T47>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 56);
		}
		public long Field48
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T48>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T48>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 56);
		}
		public long Field49
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T49>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T49>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 56);
		}
		public long Field50
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T50>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T50>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(), 56);
		}
		public long Field51
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T51>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T51>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(), 56);
		}
		public long Field52
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T52>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T52>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 56);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 56);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 56);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 56);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 56);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 56);
		}
		public long Field43
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T43>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T43>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 56);
		}
		public long Field44
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T44>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T44>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 56);
		}
		public long Field45
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T45>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T45>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 56);
		}
		public long Field46
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T46>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T46>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 56);
		}
		public long Field47
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T47>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T47>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 56);
		}
		public long Field48
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T48>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T48>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 56);
		}
		public long Field49
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T49>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T49>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 56);
		}
		public long Field50
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T50>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T50>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(), 56);
		}
		public long Field51
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T51>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T51>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(), 56);
		}
		public long Field52
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T52>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T52>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>(), 56);
		}
		public long Field53
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T53>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T53>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52>(), 56);
		}
	}

	[Serializable]
	public struct BitField56<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54>
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
		private UInt56 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T0>(Bits, value, 0, 56);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T1>(Bits, value, Index<T0>(), 56);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T2>(Bits, value, Index<T0, T1>(), 56);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T3>(Bits, value, Index<T0, T1, T2>(), 56);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 56);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 56);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 56);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 56);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 56);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 56);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 56);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 56);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 56);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 56);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 56);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 56);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 56);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 56);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 56);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 56);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 56);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 56);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 56);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 56);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 56);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 56);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 56);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 56);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 56);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 56);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 56);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 56);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 56);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 56);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 56);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 56);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 56);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 56);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 56);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 56);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 56);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 56);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 56);
		}
		public long Field43
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T43>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T43>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 56);
		}
		public long Field44
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T44>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T44>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 56);
		}
		public long Field45
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T45>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T45>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 56);
		}
		public long Field46
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T46>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T46>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 56);
		}
		public long Field47
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T47>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T47>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(), 56);
		}
		public long Field48
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T48>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T48>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(), 56);
		}
		public long Field49
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T49>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T49>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(), 56);
		}
		public long Field50
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T50>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T50>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(), 56);
		}
		public long Field51
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T51>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T51>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(), 56);
		}
		public long Field52
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T52>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T52>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>(), 56);
		}
		public long Field53
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T53>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T53>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52>(), 56);
		}
		public long Field54
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T54>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53>(), 56);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt56)Set<T54>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53>(), 56);
		}
	}
}
