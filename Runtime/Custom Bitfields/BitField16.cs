using System;
using System.Runtime.CompilerServices;

using static BitCollections.BitFieldHelper;

namespace BitCollections
{		
    [Serializable]
	public struct BitField16<T0, T1>
		where T0 : BitInt
		where T1 : BitInt
	{
		private ushort Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T0>(Bits, value, 0, 16);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T1>(Bits, value, Index<T0>(), 16);
		}
	}
	
    [Serializable]
	public struct BitField16<T0, T1, T2>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
	{
		private ushort Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T0>(Bits, value, 0, 16);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T1>(Bits, value, Index<T0>(), 16);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T2>(Bits, value, Index<T0, T1>(), 16);
		}
	}
	
    [Serializable]
	public struct BitField16<T0, T1, T2, T3>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
		where T3 : BitInt
	{
		private ushort Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T0>(Bits, value, 0, 16);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T1>(Bits, value, Index<T0>(), 16);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T2>(Bits, value, Index<T0, T1>(), 16);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T3>(Bits, value, Index<T0, T1, T2>(), 16);
		}
	}
	
    [Serializable]
	public struct BitField16<T0, T1, T2, T3, T4>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
		where T3 : BitInt
		where T4 : BitInt
	{
		private ushort Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T0>(Bits, value, 0, 16);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T1>(Bits, value, Index<T0>(), 16);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T2>(Bits, value, Index<T0, T1>(), 16);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T3>(Bits, value, Index<T0, T1, T2>(), 16);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 16);
		}
	}
	
    [Serializable]
	public struct BitField16<T0, T1, T2, T3, T4, T5>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
		where T3 : BitInt
		where T4 : BitInt
		where T5 : BitInt
	{
		private ushort Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T0>(Bits, value, 0, 16);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T1>(Bits, value, Index<T0>(), 16);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T2>(Bits, value, Index<T0, T1>(), 16);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T3>(Bits, value, Index<T0, T1, T2>(), 16);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 16);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 16);
		}
	}
	
    [Serializable]
	public struct BitField16<T0, T1, T2, T3, T4, T5, T6>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
		where T3 : BitInt
		where T4 : BitInt
		where T5 : BitInt
		where T6 : BitInt
	{
		private ushort Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T0>(Bits, value, 0, 16);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T1>(Bits, value, Index<T0>(), 16);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T2>(Bits, value, Index<T0, T1>(), 16);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T3>(Bits, value, Index<T0, T1, T2>(), 16);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 16);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 16);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 16);
		}
	}
	
    [Serializable]
	public struct BitField16<T0, T1, T2, T3, T4, T5, T6, T7>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
		where T3 : BitInt
		where T4 : BitInt
		where T5 : BitInt
		where T6 : BitInt
		where T7 : BitInt
	{
		private ushort Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T0>(Bits, value, 0, 16);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T1>(Bits, value, Index<T0>(), 16);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T2>(Bits, value, Index<T0, T1>(), 16);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T3>(Bits, value, Index<T0, T1, T2>(), 16);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 16);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 16);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 16);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 16);
		}
	}
	
    [Serializable]
	public struct BitField16<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
		private ushort Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T0>(Bits, value, 0, 16);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T1>(Bits, value, Index<T0>(), 16);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T2>(Bits, value, Index<T0, T1>(), 16);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T3>(Bits, value, Index<T0, T1, T2>(), 16);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 16);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 16);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 16);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 16);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 16);
		}
	}
	
    [Serializable]
	public struct BitField16<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
		private ushort Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T0>(Bits, value, 0, 16);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T1>(Bits, value, Index<T0>(), 16);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T2>(Bits, value, Index<T0, T1>(), 16);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T3>(Bits, value, Index<T0, T1, T2>(), 16);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 16);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 16);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 16);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 16);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 16);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 16);
		}
	}
	
    [Serializable]
	public struct BitField16<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
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
		private ushort Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T0>(Bits, value, 0, 16);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T1>(Bits, value, Index<T0>(), 16);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T2>(Bits, value, Index<T0, T1>(), 16);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T3>(Bits, value, Index<T0, T1, T2>(), 16);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 16);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 16);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 16);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 16);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 16);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 16);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 16);
		}
	}
	
    [Serializable]
	public struct BitField16<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
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
		private ushort Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T0>(Bits, value, 0, 16);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T1>(Bits, value, Index<T0>(), 16);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T2>(Bits, value, Index<T0, T1>(), 16);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T3>(Bits, value, Index<T0, T1, T2>(), 16);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 16);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 16);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 16);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 16);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 16);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 16);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 16);
		}
		public int Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 16);
		}
	}
	
    [Serializable]
	public struct BitField16<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
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
		private ushort Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T0>(Bits, value, 0, 16);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T1>(Bits, value, Index<T0>(), 16);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T2>(Bits, value, Index<T0, T1>(), 16);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T3>(Bits, value, Index<T0, T1, T2>(), 16);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 16);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 16);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 16);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 16);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 16);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 16);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 16);
		}
		public int Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 16);
		}
		public int Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 16);
		}
	}
	
    [Serializable]
	public struct BitField16<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
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
		private ushort Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T0>(Bits, value, 0, 16);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T1>(Bits, value, Index<T0>(), 16);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T2>(Bits, value, Index<T0, T1>(), 16);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T3>(Bits, value, Index<T0, T1, T2>(), 16);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 16);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 16);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 16);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 16);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 16);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 16);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 16);
		}
		public int Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 16);
		}
		public int Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 16);
		}
		public int Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 16);
		}
	}
	
    [Serializable]
	public struct BitField16<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
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
		private ushort Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T0>(Bits, value, 0, 16);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T1>(Bits, value, Index<T0>(), 16);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T2>(Bits, value, Index<T0, T1>(), 16);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T3>(Bits, value, Index<T0, T1, T2>(), 16);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 16);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 16);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 16);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 16);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 16);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 16);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 16);
		}
		public int Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 16);
		}
		public int Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 16);
		}
		public int Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 16);
		}
		public int Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 16);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (ushort)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 16);
		}
	}
}
