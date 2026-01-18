using System;
using System.Runtime.CompilerServices;

using static BitCollections.BitFieldHelper;

namespace BitCollections
{		
    [Serializable]
	public struct BitField24<T0, T1>
		where T0 : BitInt
		where T1 : BitInt
	{
		private UInt24 Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T0>(Bits, value, 0, 24);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T1>(Bits, value, Index<T0>(), 24);
		}
	}
	
    [Serializable]
	public struct BitField24<T0, T1, T2>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
	{
		private UInt24 Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T0>(Bits, value, 0, 24);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T1>(Bits, value, Index<T0>(), 24);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T2>(Bits, value, Index<T0, T1>(), 24);
		}
	}
	
    [Serializable]
	public struct BitField24<T0, T1, T2, T3>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
		where T3 : BitInt
	{
		private UInt24 Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T0>(Bits, value, 0, 24);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T1>(Bits, value, Index<T0>(), 24);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T2>(Bits, value, Index<T0, T1>(), 24);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T3>(Bits, value, Index<T0, T1, T2>(), 24);
		}
	}
	
    [Serializable]
	public struct BitField24<T0, T1, T2, T3, T4>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
		where T3 : BitInt
		where T4 : BitInt
	{
		private UInt24 Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T0>(Bits, value, 0, 24);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T1>(Bits, value, Index<T0>(), 24);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T2>(Bits, value, Index<T0, T1>(), 24);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T3>(Bits, value, Index<T0, T1, T2>(), 24);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 24);
		}
	}
	
    [Serializable]
	public struct BitField24<T0, T1, T2, T3, T4, T5>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
		where T3 : BitInt
		where T4 : BitInt
		where T5 : BitInt
	{
		private UInt24 Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T0>(Bits, value, 0, 24);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T1>(Bits, value, Index<T0>(), 24);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T2>(Bits, value, Index<T0, T1>(), 24);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T3>(Bits, value, Index<T0, T1, T2>(), 24);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 24);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 24);
		}
	}
	
    [Serializable]
	public struct BitField24<T0, T1, T2, T3, T4, T5, T6>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
		where T3 : BitInt
		where T4 : BitInt
		where T5 : BitInt
		where T6 : BitInt
	{
		private UInt24 Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T0>(Bits, value, 0, 24);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T1>(Bits, value, Index<T0>(), 24);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T2>(Bits, value, Index<T0, T1>(), 24);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T3>(Bits, value, Index<T0, T1, T2>(), 24);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 24);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 24);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 24);
		}
	}
	
    [Serializable]
	public struct BitField24<T0, T1, T2, T3, T4, T5, T6, T7>
		where T0 : BitInt
		where T1 : BitInt
		where T2 : BitInt
		where T3 : BitInt
		where T4 : BitInt
		where T5 : BitInt
		where T6 : BitInt
		where T7 : BitInt
	{
		private UInt24 Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T0>(Bits, value, 0, 24);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T1>(Bits, value, Index<T0>(), 24);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T2>(Bits, value, Index<T0, T1>(), 24);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T3>(Bits, value, Index<T0, T1, T2>(), 24);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 24);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 24);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 24);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 24);
		}
	}
	
    [Serializable]
	public struct BitField24<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
		private UInt24 Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T0>(Bits, value, 0, 24);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T1>(Bits, value, Index<T0>(), 24);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T2>(Bits, value, Index<T0, T1>(), 24);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T3>(Bits, value, Index<T0, T1, T2>(), 24);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 24);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 24);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 24);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 24);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 24);
		}
	}
	
    [Serializable]
	public struct BitField24<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
		private UInt24 Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T0>(Bits, value, 0, 24);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T1>(Bits, value, Index<T0>(), 24);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T2>(Bits, value, Index<T0, T1>(), 24);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T3>(Bits, value, Index<T0, T1, T2>(), 24);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 24);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 24);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 24);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 24);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 24);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 24);
		}
	}
	
    [Serializable]
	public struct BitField24<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
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
		private UInt24 Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T0>(Bits, value, 0, 24);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T1>(Bits, value, Index<T0>(), 24);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T2>(Bits, value, Index<T0, T1>(), 24);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T3>(Bits, value, Index<T0, T1, T2>(), 24);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 24);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 24);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 24);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 24);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 24);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 24);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 24);
		}
	}
	
    [Serializable]
	public struct BitField24<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
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
		private UInt24 Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T0>(Bits, value, 0, 24);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T1>(Bits, value, Index<T0>(), 24);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T2>(Bits, value, Index<T0, T1>(), 24);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T3>(Bits, value, Index<T0, T1, T2>(), 24);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 24);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 24);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 24);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 24);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 24);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 24);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 24);
		}
		public int Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 24);
		}
	}
	
    [Serializable]
	public struct BitField24<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
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
		private UInt24 Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T0>(Bits, value, 0, 24);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T1>(Bits, value, Index<T0>(), 24);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T2>(Bits, value, Index<T0, T1>(), 24);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T3>(Bits, value, Index<T0, T1, T2>(), 24);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 24);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 24);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 24);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 24);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 24);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 24);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 24);
		}
		public int Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 24);
		}
		public int Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 24);
		}
	}
	
    [Serializable]
	public struct BitField24<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
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
		private UInt24 Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T0>(Bits, value, 0, 24);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T1>(Bits, value, Index<T0>(), 24);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T2>(Bits, value, Index<T0, T1>(), 24);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T3>(Bits, value, Index<T0, T1, T2>(), 24);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 24);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 24);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 24);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 24);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 24);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 24);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 24);
		}
		public int Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 24);
		}
		public int Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 24);
		}
		public int Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 24);
		}
	}
	
    [Serializable]
	public struct BitField24<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
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
		private UInt24 Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T0>(Bits, value, 0, 24);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T1>(Bits, value, Index<T0>(), 24);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T2>(Bits, value, Index<T0, T1>(), 24);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T3>(Bits, value, Index<T0, T1, T2>(), 24);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 24);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 24);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 24);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 24);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 24);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 24);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 24);
		}
		public int Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 24);
		}
		public int Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 24);
		}
		public int Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 24);
		}
		public int Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 24);
		}
	}
	
    [Serializable]
	public struct BitField24<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
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
		private UInt24 Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T0>(Bits, value, 0, 24);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T1>(Bits, value, Index<T0>(), 24);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T2>(Bits, value, Index<T0, T1>(), 24);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T3>(Bits, value, Index<T0, T1, T2>(), 24);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 24);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 24);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 24);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 24);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 24);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 24);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 24);
		}
		public int Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 24);
		}
		public int Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 24);
		}
		public int Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 24);
		}
		public int Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 24);
		}
		public int Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 24);
		}
	}
	
    [Serializable]
	public struct BitField24<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
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
		private UInt24 Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T0>(Bits, value, 0, 24);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T1>(Bits, value, Index<T0>(), 24);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T2>(Bits, value, Index<T0, T1>(), 24);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T3>(Bits, value, Index<T0, T1, T2>(), 24);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 24);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 24);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 24);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 24);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 24);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 24);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 24);
		}
		public int Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 24);
		}
		public int Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 24);
		}
		public int Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 24);
		}
		public int Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 24);
		}
		public int Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 24);
		}
		public int Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 24);
		}
	}
	
    [Serializable]
	public struct BitField24<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>
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
		private UInt24 Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T0>(Bits, value, 0, 24);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T1>(Bits, value, Index<T0>(), 24);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T2>(Bits, value, Index<T0, T1>(), 24);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T3>(Bits, value, Index<T0, T1, T2>(), 24);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 24);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 24);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 24);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 24);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 24);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 24);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 24);
		}
		public int Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 24);
		}
		public int Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 24);
		}
		public int Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 24);
		}
		public int Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 24);
		}
		public int Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 24);
		}
		public int Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 24);
		}
		public int Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 24);
		}
	}
	
    [Serializable]
	public struct BitField24<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>
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
		private UInt24 Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T0>(Bits, value, 0, 24);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T1>(Bits, value, Index<T0>(), 24);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T2>(Bits, value, Index<T0, T1>(), 24);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T3>(Bits, value, Index<T0, T1, T2>(), 24);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 24);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 24);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 24);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 24);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 24);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 24);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 24);
		}
		public int Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 24);
		}
		public int Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 24);
		}
		public int Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 24);
		}
		public int Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 24);
		}
		public int Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 24);
		}
		public int Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 24);
		}
		public int Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 24);
		}
		public int Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 24);
		}
	}
	
    [Serializable]
	public struct BitField24<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>
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
		private UInt24 Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T0>(Bits, value, 0, 24);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T1>(Bits, value, Index<T0>(), 24);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T2>(Bits, value, Index<T0, T1>(), 24);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T3>(Bits, value, Index<T0, T1, T2>(), 24);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 24);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 24);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 24);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 24);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 24);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 24);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 24);
		}
		public int Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 24);
		}
		public int Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 24);
		}
		public int Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 24);
		}
		public int Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 24);
		}
		public int Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 24);
		}
		public int Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 24);
		}
		public int Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 24);
		}
		public int Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 24);
		}
		public int Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 24);
		}
	}
	
    [Serializable]
	public struct BitField24<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>
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
		private UInt24 Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T0>(Bits, value, 0, 24);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T1>(Bits, value, Index<T0>(), 24);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T2>(Bits, value, Index<T0, T1>(), 24);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T3>(Bits, value, Index<T0, T1, T2>(), 24);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 24);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 24);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 24);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 24);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 24);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 24);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 24);
		}
		public int Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 24);
		}
		public int Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 24);
		}
		public int Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 24);
		}
		public int Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 24);
		}
		public int Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 24);
		}
		public int Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 24);
		}
		public int Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 24);
		}
		public int Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 24);
		}
		public int Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 24);
		}
		public int Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 24);
		}
	}
	
    [Serializable]
	public struct BitField24<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>
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
		private UInt24 Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T0>(Bits, value, 0, 24);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T1>(Bits, value, Index<T0>(), 24);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T2>(Bits, value, Index<T0, T1>(), 24);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T3>(Bits, value, Index<T0, T1, T2>(), 24);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 24);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 24);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 24);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 24);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 24);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 24);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 24);
		}
		public int Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 24);
		}
		public int Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 24);
		}
		public int Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 24);
		}
		public int Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 24);
		}
		public int Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 24);
		}
		public int Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 24);
		}
		public int Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 24);
		}
		public int Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 24);
		}
		public int Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 24);
		}
		public int Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 24);
		}
		public int Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 24);
		}
	}
	
    [Serializable]
	public struct BitField24<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>
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
		private UInt24 Bits;

		public int Field0
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T0>(Bits, 0, 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T0>(Bits, value, 0, 24);
		}
		public int Field1
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T1>(Bits, Index<T0>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T1>(Bits, value, Index<T0>(), 24);
		}
		public int Field2
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T2>(Bits, Index<T0, T1>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T2>(Bits, value, Index<T0, T1>(), 24);
		}
		public int Field3
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T3>(Bits, Index<T0, T1, T2>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T3>(Bits, value, Index<T0, T1, T2>(), 24);
		}
		public int Field4
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T4>(Bits, Index<T0, T1, T2, T3>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T4>(Bits, value, Index<T0, T1, T2, T3>(), 24);
		}
		public int Field5
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T5>(Bits, Index<T0, T1, T2, T3, T4>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T5>(Bits, value, Index<T0, T1, T2, T3, T4>(), 24);
		}
		public int Field6
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T6>(Bits, Index<T0, T1, T2, T3, T4, T5>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T6>(Bits, value, Index<T0, T1, T2, T3, T4, T5>(), 24);
		}
		public int Field7
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T7>(Bits, Index<T0, T1, T2, T3, T4, T5, T6>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T7>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6>(), 24);
		}
		public int Field8
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T8>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T8>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7>(), 24);
		}
		public int Field9
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T9>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T9>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8>(), 24);
		}
		public int Field10
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T10>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T10>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(), 24);
		}
		public int Field11
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T11>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T11>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(), 24);
		}
		public int Field12
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T12>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T12>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(), 24);
		}
		public int Field13
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T13>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T13>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(), 24);
		}
		public int Field14
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T14>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T14>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(), 24);
		}
		public int Field15
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T15>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T15>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(), 24);
		}
		public int Field16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T16>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T16>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(), 24);
		}
		public int Field17
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T17>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T17>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(), 24);
		}
		public int Field18
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T18>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T18>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(), 24);
		}
		public int Field19
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T19>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T19>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(), 24);
		}
		public int Field20
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T20>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T20>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(), 24);
		}
		public int Field21
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T21>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T21>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(), 24);
		}
		public int Field22
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => (int)Get<T22>(Bits, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 24);
			[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = (UInt24)Set<T22>(Bits, value, Index<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(), 24);
		}
	}
}
