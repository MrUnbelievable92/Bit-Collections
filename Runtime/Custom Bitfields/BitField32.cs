using System;
using System.Runtime.CompilerServices;

using static BitCollections.BitFieldHelper;

namespace BitCollections
{		
    [Serializable]
	public struct BitField32<T0, T1>
		where T0 : BitInt
		where T1 : BitInt
	{
		private uint Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T0>(Bits, value, 0, 32);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T1>(Bits, value, Index<T0>(), 32);
		}
	}

	[Serializable]
	public struct BitField32<T0, T1, T2>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
	{
		private uint Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T0>(Bits, value, 0, 32);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T1>(Bits, value, Index<T0>(), 32);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T2>(Bits, value, Index<T0, T1>(), 32);
		}
	}

	[Serializable]
	public struct BitField32<T0, T1, T2, T3>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
		where T3 : BitInt
	{
		private uint Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T0>(Bits, value, 0, 32);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T1>(Bits, value, Index<T0>(), 32);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T2>(Bits, value, Index<T0, T1>(), 32);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T3>(Bits, value, Index<T0, T1, T2>(), 32);
		}
	}

	[Serializable]
	public struct BitField32<T0, T1, T2, T3, T4>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
		where T3 : BitInt
		where T4 : BitInt
	{
		private uint Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T0>(Bits, value, 0, 32);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T1>(Bits, value, Index<T0>(), 32);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T2>(Bits, value, Index<T0, T1>(), 32);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T3>(Bits, value, Index<T0, T1, T2>(), 32);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 32);
		}
	}

	[Serializable]
	public struct BitField32<T0, T1, T2, T3, T4, T5>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
		where T3 : BitInt
		where T4 : BitInt
		where T5 : BitInt
	{
		private uint Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T0>(Bits, value, 0, 32);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T1>(Bits, value, Index<T0>(), 32);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T2>(Bits, value, Index<T0, T1>(), 32);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T3>(Bits, value, Index<T0, T1, T2>(), 32);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 32);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 32);
		}
	}

	[Serializable]
	public struct BitField32<T0, T1, T2, T3, T4, T5, T6>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
		where T3 : BitInt
		where T4 : BitInt
		where T5 : BitInt
		where T6 : BitInt
	{
		private uint Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T0>(Bits, value, 0, 32);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T1>(Bits, value, Index<T0>(), 32);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T2>(Bits, value, Index<T0, T1>(), 32);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T3>(Bits, value, Index<T0, T1, T2>(), 32);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 32);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 32);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 32);
		}
	}

	[Serializable]
	public struct BitField32<T0, T1, T2, T3, T4, T5, T6, T7>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
		where T3 : BitInt
		where T4 : BitInt
		where T5 : BitInt
		where T6 : BitInt
		where T7 : BitInt
	{
		private uint Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T0>(Bits, value, 0, 32);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T1>(Bits, value, Index<T0>(), 32);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T2>(Bits, value, Index<T0, T1>(), 32);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T3>(Bits, value, Index<T0, T1, T2>(), 32);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 32);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 32);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 32);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
		}
	}

	[Serializable]
	public struct BitField32<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
		private uint Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T0>(Bits, value, 0, 32);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T1>(Bits, value, Index<T0>(), 32);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T2>(Bits, value, Index<T0, T1>(), 32);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T3>(Bits, value, Index<T0, T1, T2>(), 32);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 32);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 32);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 32);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
		}
	}

	[Serializable]
	public struct BitField32<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
		private uint Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T0>(Bits, value, 0, 32);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T1>(Bits, value, Index<T0>(), 32);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T2>(Bits, value, Index<T0, T1>(), 32);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T3>(Bits, value, Index<T0, T1, T2>(), 32);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 32);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 32);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 32);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
		}
	}

	[Serializable]
	public struct BitField32<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
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
		private uint Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T0>(Bits, value, 0, 32);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T1>(Bits, value, Index<T0>(), 32);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T2>(Bits, value, Index<T0, T1>(), 32);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T3>(Bits, value, Index<T0, T1, T2>(), 32);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 32);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 32);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 32);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
		}
	}

	[Serializable]
	public struct BitField32<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
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
		private uint Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T0>(Bits, value, 0, 32);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T1>(Bits, value, Index<T0>(), 32);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T2>(Bits, value, Index<T0, T1>(), 32);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T3>(Bits, value, Index<T0, T1, T2>(), 32);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 32);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 32);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 32);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
		}
		public int Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
		}
	}

	[Serializable]
	public struct BitField32<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
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
		private uint Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T0>(Bits, value, 0, 32);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T1>(Bits, value, Index<T0>(), 32);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T2>(Bits, value, Index<T0, T1>(), 32);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T3>(Bits, value, Index<T0, T1, T2>(), 32);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 32);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 32);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 32);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
		}
		public int Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
		}
		public int Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
		}
	}

	[Serializable]
	public struct BitField32<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
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
		private uint Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T0>(Bits, value, 0, 32);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T1>(Bits, value, Index<T0>(), 32);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T2>(Bits, value, Index<T0, T1>(), 32);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T3>(Bits, value, Index<T0, T1, T2>(), 32);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 32);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 32);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 32);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
		}
		public int Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
		}
		public int Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
		}
		public int Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 32);
		}
	}

	[Serializable]
	public struct BitField32<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
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
		private uint Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T0>(Bits, value, 0, 32);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T1>(Bits, value, Index<T0>(), 32);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T2>(Bits, value, Index<T0, T1>(), 32);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T3>(Bits, value, Index<T0, T1, T2>(), 32);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 32);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 32);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 32);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
		}
		public int Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
		}
		public int Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
		}
		public int Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 32);
		}
		public int Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 32);
		}
	}

	[Serializable]
	public struct BitField32<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
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
		private uint Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T0>(Bits, value, 0, 32);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T1>(Bits, value, Index<T0>(), 32);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T2>(Bits, value, Index<T0, T1>(), 32);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T3>(Bits, value, Index<T0, T1, T2>(), 32);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 32);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 32);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 32);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
		}
		public int Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
		}
		public int Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
		}
		public int Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 32);
		}
		public int Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 32);
		}
		public int Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 32);
		}
	}

	[Serializable]
	public struct BitField32<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
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
		private uint Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T0>(Bits, value, 0, 32);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T1>(Bits, value, Index<T0>(), 32);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T2>(Bits, value, Index<T0, T1>(), 32);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T3>(Bits, value, Index<T0, T1, T2>(), 32);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 32);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 32);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 32);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
		}
		public int Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
		}
		public int Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
		}
		public int Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 32);
		}
		public int Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 32);
		}
		public int Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 32);
		}
		public int Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 32);
		}
	}

	[Serializable]
	public struct BitField32<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>
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
		private uint Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T0>(Bits, value, 0, 32);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T1>(Bits, value, Index<T0>(), 32);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T2>(Bits, value, Index<T0, T1>(), 32);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T3>(Bits, value, Index<T0, T1, T2>(), 32);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 32);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 32);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 32);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
		}
		public int Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
		}
		public int Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
		}
		public int Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 32);
		}
		public int Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 32);
		}
		public int Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 32);
		}
		public int Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 32);
		}
		public int Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 32);
		}
	}

	[Serializable]
	public struct BitField32<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>
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
		private uint Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T0>(Bits, value, 0, 32);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T1>(Bits, value, Index<T0>(), 32);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T2>(Bits, value, Index<T0, T1>(), 32);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T3>(Bits, value, Index<T0, T1, T2>(), 32);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 32);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 32);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 32);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
		}
		public int Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
		}
		public int Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
		}
		public int Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 32);
		}
		public int Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 32);
		}
		public int Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 32);
		}
		public int Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 32);
		}
		public int Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 32);
		}
		public int Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 32);
		}
	}

	[Serializable]
	public struct BitField32<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>
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
		private uint Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T0>(Bits, value, 0, 32);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T1>(Bits, value, Index<T0>(), 32);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T2>(Bits, value, Index<T0, T1>(), 32);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T3>(Bits, value, Index<T0, T1, T2>(), 32);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 32);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 32);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 32);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
		}
		public int Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
		}
		public int Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
		}
		public int Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 32);
		}
		public int Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 32);
		}
		public int Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 32);
		}
		public int Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 32);
		}
		public int Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 32);
		}
		public int Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 32);
		}
		public int Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 32);
		}
	}

	[Serializable]
	public struct BitField32<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>
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
		private uint Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T0>(Bits, value, 0, 32);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T1>(Bits, value, Index<T0>(), 32);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T2>(Bits, value, Index<T0, T1>(), 32);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T3>(Bits, value, Index<T0, T1, T2>(), 32);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 32);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 32);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 32);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
		}
		public int Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
		}
		public int Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
		}
		public int Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 32);
		}
		public int Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 32);
		}
		public int Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 32);
		}
		public int Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 32);
		}
		public int Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 32);
		}
		public int Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 32);
		}
		public int Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 32);
		}
		public int Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 32);
		}
	}

	[Serializable]
	public struct BitField32<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>
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
		private uint Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T0>(Bits, value, 0, 32);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T1>(Bits, value, Index<T0>(), 32);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T2>(Bits, value, Index<T0, T1>(), 32);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T3>(Bits, value, Index<T0, T1, T2>(), 32);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 32);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 32);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 32);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
		}
		public int Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
		}
		public int Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
		}
		public int Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 32);
		}
		public int Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 32);
		}
		public int Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 32);
		}
		public int Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 32);
		}
		public int Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 32);
		}
		public int Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 32);
		}
		public int Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 32);
		}
		public int Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 32);
		}
		public int Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 32);
		}
	}

	[Serializable]
	public struct BitField32<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>
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
		private uint Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T0>(Bits, value, 0, 32);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T1>(Bits, value, Index<T0>(), 32);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T2>(Bits, value, Index<T0, T1>(), 32);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T3>(Bits, value, Index<T0, T1, T2>(), 32);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 32);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 32);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 32);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
		}
		public int Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
		}
		public int Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
		}
		public int Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 32);
		}
		public int Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 32);
		}
		public int Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 32);
		}
		public int Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 32);
		}
		public int Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 32);
		}
		public int Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 32);
		}
		public int Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 32);
		}
		public int Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 32);
		}
		public int Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 32);
		}
		public int Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 32);
		}
	}

	[Serializable]
	public struct BitField32<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>
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
		private uint Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T0>(Bits, value, 0, 32);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T1>(Bits, value, Index<T0>(), 32);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T2>(Bits, value, Index<T0, T1>(), 32);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T3>(Bits, value, Index<T0, T1, T2>(), 32);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 32);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 32);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 32);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
		}
		public int Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
		}
		public int Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
		}
		public int Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 32);
		}
		public int Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 32);
		}
		public int Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 32);
		}
		public int Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 32);
		}
		public int Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 32);
		}
		public int Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 32);
		}
		public int Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 32);
		}
		public int Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 32);
		}
		public int Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 32);
		}
		public int Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 32);
		}
		public int Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 32);
		}
	}

	[Serializable]
	public struct BitField32<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>
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
		private uint Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T0>(Bits, value, 0, 32);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T1>(Bits, value, Index<T0>(), 32);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T2>(Bits, value, Index<T0, T1>(), 32);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T3>(Bits, value, Index<T0, T1, T2>(), 32);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 32);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 32);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 32);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
		}
		public int Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
		}
		public int Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
		}
		public int Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 32);
		}
		public int Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 32);
		}
		public int Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 32);
		}
		public int Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 32);
		}
		public int Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 32);
		}
		public int Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 32);
		}
		public int Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 32);
		}
		public int Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 32);
		}
		public int Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 32);
		}
		public int Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 32);
		}
		public int Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 32);
		}
		public int Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 32);
		}
	}

	[Serializable]
	public struct BitField32<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>
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
		private uint Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T0>(Bits, value, 0, 32);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T1>(Bits, value, Index<T0>(), 32);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T2>(Bits, value, Index<T0, T1>(), 32);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T3>(Bits, value, Index<T0, T1, T2>(), 32);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 32);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 32);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 32);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
		}
		public int Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
		}
		public int Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
		}
		public int Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 32);
		}
		public int Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 32);
		}
		public int Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 32);
		}
		public int Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 32);
		}
		public int Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 32);
		}
		public int Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 32);
		}
		public int Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 32);
		}
		public int Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 32);
		}
		public int Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 32);
		}
		public int Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 32);
		}
		public int Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 32);
		}
		public int Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 32);
		}
		public int Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 32);
		}
	}

	[Serializable]
	public struct BitField32<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>
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
		private uint Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T0>(Bits, value, 0, 32);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T1>(Bits, value, Index<T0>(), 32);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T2>(Bits, value, Index<T0, T1>(), 32);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T3>(Bits, value, Index<T0, T1, T2>(), 32);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 32);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 32);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 32);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
		}
		public int Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
		}
		public int Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
		}
		public int Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 32);
		}
		public int Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 32);
		}
		public int Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 32);
		}
		public int Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 32);
		}
		public int Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 32);
		}
		public int Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 32);
		}
		public int Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 32);
		}
		public int Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 32);
		}
		public int Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 32);
		}
		public int Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 32);
		}
		public int Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 32);
		}
		public int Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 32);
		}
		public int Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 32);
		}
		public int Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 32);
		}
	}

	[Serializable]
	public struct BitField32<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>
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
		private uint Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T0>(Bits, value, 0, 32);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T1>(Bits, value, Index<T0>(), 32);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T2>(Bits, value, Index<T0, T1>(), 32);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T3>(Bits, value, Index<T0, T1, T2>(), 32);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 32);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 32);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 32);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
		}
		public int Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
		}
		public int Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
		}
		public int Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 32);
		}
		public int Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 32);
		}
		public int Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 32);
		}
		public int Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 32);
		}
		public int Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 32);
		}
		public int Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 32);
		}
		public int Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 32);
		}
		public int Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 32);
		}
		public int Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 32);
		}
		public int Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 32);
		}
		public int Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 32);
		}
		public int Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 32);
		}
		public int Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 32);
		}
		public int Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 32);
		}
		public int Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 32);
		}
	}

	[Serializable]
	public struct BitField32<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>
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
		private uint Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T0>(Bits, value, 0, 32);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T1>(Bits, value, Index<T0>(), 32);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T2>(Bits, value, Index<T0, T1>(), 32);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T3>(Bits, value, Index<T0, T1, T2>(), 32);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 32);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 32);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 32);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
		}
		public int Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
		}
		public int Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
		}
		public int Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 32);
		}
		public int Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 32);
		}
		public int Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 32);
		}
		public int Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 32);
		}
		public int Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 32);
		}
		public int Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 32);
		}
		public int Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 32);
		}
		public int Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 32);
		}
		public int Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 32);
		}
		public int Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 32);
		}
		public int Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 32);
		}
		public int Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 32);
		}
		public int Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 32);
		}
		public int Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 32);
		}
		public int Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 32);
		}
		public int Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 32);
		}
	}

	[Serializable]
	public struct BitField32<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>
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
		private uint Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T0>(Bits, value, 0, 32);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T1>(Bits, value, Index<T0>(), 32);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T2>(Bits, value, Index<T0, T1>(), 32);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T3>(Bits, value, Index<T0, T1, T2>(), 32);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 32);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 32);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 32);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
		}
		public int Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
		}
		public int Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
		}
		public int Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 32);
		}
		public int Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 32);
		}
		public int Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 32);
		}
		public int Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 32);
		}
		public int Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 32);
		}
		public int Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 32);
		}
		public int Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 32);
		}
		public int Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 32);
		}
		public int Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 32);
		}
		public int Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 32);
		}
		public int Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 32);
		}
		public int Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 32);
		}
		public int Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 32);
		}
		public int Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 32);
		}
		public int Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 32);
		}
		public int Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 32);
		}
		public int Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 32);
		}
	}

	[Serializable]
	public struct BitField32<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>
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
		private uint Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T0>(Bits, value, 0, 32);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T1>(Bits, value, Index<T0>(), 32);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T2>(Bits, value, Index<T0, T1>(), 32);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T3>(Bits, value, Index<T0, T1, T2>(), 32);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 32);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 32);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 32);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 32);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 32);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 32);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 32);
		}
		public int Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 32);
		}
		public int Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 32);
		}
		public int Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 32);
		}
		public int Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 32);
		}
		public int Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 32);
		}
		public int Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 32);
		}
		public int Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 32);
		}
		public int Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 32);
		}
		public int Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 32);
		}
		public int Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 32);
		}
		public int Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 32);
		}
		public int Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 32);
		}
		public int Field23
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T23>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T23>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(), 32);
		}
		public int Field24
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T24>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T24>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(), 32);
		}
		public int Field25
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T25>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T25>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(), 32);
		}
		public int Field26
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T26>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T26>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(), 32);
		}
		public int Field27
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T27>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T27>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(), 32);
		}
		public int Field28
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T28>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T28>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(), 32);
		}
		public int Field29
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T29>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T29>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(), 32);
		}
		public int Field30
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T30>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 32);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (uint)Set<T30>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(), 32);
		}
	}
}
