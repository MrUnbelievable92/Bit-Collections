using System;
using System.Runtime.CompilerServices;

using static BitCollections.BitFieldHelper;

namespace BitCollections
{		
	[Serializable]
	public struct BitField48<T0, T1>
		where T0 : BitInt
		where T1 : BitInt
	{
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
	{
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
		where T3 : BitInt
	{
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
		where T3 : BitInt
		where T4 : BitInt
	{
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
		where T3 : BitInt
		where T4 : BitInt
		where T5 : BitInt
	{
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
		where T3 : BitInt
		where T4 : BitInt
		where T5 : BitInt
		where T6 : BitInt
	{
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
		where T3 : BitInt
		where T4 : BitInt
		where T5 : BitInt
		where T6 : BitInt
		where T7 : BitInt
	{
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 48);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 48);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 48);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 48);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 48);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 48);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 48);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 48);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 48);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 48);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 48);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 48);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 48);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 48);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 48);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 48);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 48);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 48);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 48);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 48);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 48);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 48);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 48);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 48);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 48);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 48);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 48);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 48);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 48);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 48);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 48);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 48);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 48);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 48);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 48);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 48);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 48);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 48);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 48);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 48);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 48);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 48);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 48);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 48);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 48);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 48);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 48);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 48);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 48);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 48);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 48);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 48);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 48);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 48);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 48);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 48);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 48);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 48);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 48);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 48);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 48);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 48);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 48);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 48);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 48);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 48);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 48);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 48);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 48);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 48);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 48);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 48);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 48);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 48);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 48);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 48);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 48);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 48);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 48);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 48);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 48);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 48);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 48);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 48);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 48);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 48);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 48);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 48);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 48);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 48);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 48);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 48);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 48);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 48);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 48);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 48);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 48);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 48);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 48);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 48);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 48);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 48);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 48);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 48);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 48);
		}
		public long Field43
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T43>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T43>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 48);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 48);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 48);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 48);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 48);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 48);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 48);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 48);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 48);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 48);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 48);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 48);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 48);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 48);
		}
		public long Field43
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T43>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T43>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 48);
		}
		public long Field44
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T44>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T44>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 48);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 48);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 48);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 48);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 48);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 48);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 48);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 48);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 48);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 48);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 48);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 48);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 48);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 48);
		}
		public long Field43
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T43>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T43>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 48);
		}
		public long Field44
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T44>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T44>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 48);
		}
		public long Field45
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T45>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T45>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 48);
		}
	}

	[Serializable]
	public struct BitField48<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>
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
		private UInt48 Bits;

		public long Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T0>(Bits, 0, 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T0>(Bits, value, 0, 48);
		}
		public long Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T1>(Bits, Index<T0>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T1>(Bits, value, Index<T0>(), 48);
		}
		public long Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T2>(Bits, Index<T0, T1>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T2>(Bits, value, Index<T0, T1>(), 48);
		}
		public long Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T3>(Bits, Index<T0, T1, T2>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T3>(Bits, value, Index<T0, T1, T2>(), 48);
		}
		public long Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T4>(Bits, Index<T0, T1, T2, T3>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 48);
		}
		public long Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 48);
		}
		public long Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 48);
		}
		public long Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 48);
		}
		public long Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 48);
		}
		public long Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 48);
		}
		public long Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 48);
		}
		public long Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 48);
		}
		public long Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 48);
		}
		public long Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 48);
		}
		public long Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 48);
		}
		public long Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 48);
		}
		public long Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 48);
		}
		public long Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 48);
		}
		public long Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 48);
		}
		public long Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 48);
		}
		public long Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 48);
		}
		public long Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 48);
		}
		public long Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 48);
		}
		public long Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 48);
		}
		public long Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 48);
		}
		public long Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 48);
		}
		public long Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 48);
		}
		public long Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 48);
		}
		public long Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 48);
		}
		public long Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 48);
		}
		public long Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 48);
		}
		public long Field31
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T31>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T31>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(), 48);
		}
		public long Field32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T32>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T32>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(), 48);
		}
		public long Field33
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T33>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T33>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(), 48);
		}
		public long Field34
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T34>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T34>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(), 48);
		}
		public long Field35
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T35>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T35>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(), 48);
		}
		public long Field36
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T36>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T36>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(), 48);
		}
		public long Field37
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T37>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T37>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(), 48);
		}
		public long Field38
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T38>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T38>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(), 48);
		}
		public long Field39
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T39>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T39>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(), 48);
		}
		public long Field40
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T40>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T40>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(), 48);
		}
		public long Field41
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T41>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T41>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(), 48);
		}
		public long Field42
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T42>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T42>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(), 48);
		}
		public long Field43
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T43>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T43>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(), 48);
		}
		public long Field44
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T44>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T44>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(), 48);
		}
		public long Field45
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T45>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T45>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(), 48);
		}
		public long Field46
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => Get<T46>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 48);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt48)Set<T46>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(), 48);
		}
	}
}
