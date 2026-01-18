using System;
using System.Runtime.CompilerServices;

using static BitCollections.BitFieldHelper;

namespace BitCollections
{		
	[Serializable]
	public struct BitField8<T0, T1>
		where T0 : BitInt
		where T1 : BitInt
	{
		private byte Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 8);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (byte)Set<T0>(Bits, value, 0, 8);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 8);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (byte)Set<T1>(Bits, value, Index<T0>(), 8);
		}
	}

	[Serializable]
	public struct BitField8<T0, T1, T2>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
	{
		private byte Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 8);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (byte)Set<T0>(Bits, value, 0, 8);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 8);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (byte)Set<T1>(Bits, value, Index<T0>(), 8);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 8);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (byte)Set<T2>(Bits, value, Index<T0, T1>(), 8);
		}
	}

	[Serializable]
	public struct BitField8<T0, T1, T2, T3>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
		where T3 : BitInt
	{
		private byte Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 8);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (byte)Set<T0>(Bits, value, 0, 8);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 8);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (byte)Set<T1>(Bits, value, Index<T0>(), 8);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 8);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (byte)Set<T2>(Bits, value, Index<T0, T1>(), 8);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 8);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (byte)Set<T3>(Bits, value, Index<T0, T1, T2>(), 8);
		}
	}

	[Serializable]
	public struct BitField8<T0, T1, T2, T3, T4>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
		where T3 : BitInt
		where T4 : BitInt
	{
		private byte Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 8);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (byte)Set<T0>(Bits, value, 0, 8);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 8);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (byte)Set<T1>(Bits, value, Index<T0>(), 8);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 8);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (byte)Set<T2>(Bits, value, Index<T0, T1>(), 8);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 8);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (byte)Set<T3>(Bits, value, Index<T0, T1, T2>(), 8);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 8);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (byte)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 8);
		}
	}

	[Serializable]
	public struct BitField8<T0, T1, T2, T3, T4, T5>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
		where T3 : BitInt
		where T4 : BitInt
		where T5 : BitInt
	{
		private byte Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 8);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (byte)Set<T0>(Bits, value, 0, 8);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 8);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (byte)Set<T1>(Bits, value, Index<T0>(), 8);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 8);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (byte)Set<T2>(Bits, value, Index<T0, T1>(), 8);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 8);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (byte)Set<T3>(Bits, value, Index<T0, T1, T2>(), 8);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 8);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (byte)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 8);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 8);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (byte)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 8);
		}
	}

	[Serializable]
	public struct BitField8<T0, T1, T2, T3, T4, T5, T6>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
		where T3 : BitInt
		where T4 : BitInt
		where T5 : BitInt
		where T6 : BitInt
	{
		private byte Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 8);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (byte)Set<T0>(Bits, value, 0, 8);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 8);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (byte)Set<T1>(Bits, value, Index<T0>(), 8);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 8);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (byte)Set<T2>(Bits, value, Index<T0, T1>(), 8);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 8);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (byte)Set<T3>(Bits, value, Index<T0, T1, T2>(), 8);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 8);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (byte)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 8);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 8);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (byte)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 8);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 8);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (byte)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 8);
		}
	}
}

