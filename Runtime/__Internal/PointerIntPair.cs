//using DevTools;
//
//using static Unity.Mathematics.math;
//using static MaxMath.maxmath;
//
//namespace BitCollections
//{
//    unsafe internal interface IPointerIntPair<T>
//        where T : unmanaged
//    {
//        static uint Mask => (uint)sizeof(T) - 1;
//        static int IntBits => tzcnt(sizeof(T));
//
//        static void CheckValid(T* input)
//        {
//Assert.AreNotEqual(sizeof(T), 1);
//Assert.IsTrue(ispow2(sizeof(T)));
//Assert.IsMemoryAligned(input);
//        }
//
//        static U Init<U>(T* input)
//            where U : unmanaged, IPointerIntPair<T>
//        {
//CheckValid(input);
//
//            return *(U*)&input;
//        }
//
//        static T* GetPtr(T* bits)
//        {
//            return (T*)andnot((ulong)bits, Mask);
//        }
//
//        static T* SetPtr(T* bits, T* value)
//        {
//CheckValid(value);
//
//            return (T*)(((ulong)bits & Mask) | andnot((ulong)value, Mask));
//        }
//
//        static uint GetInt(T* bits)
//        {
//            return (uint)bits & Mask;
//        }
//
//        static T* SetInt(T* bits, uint value)
//        {
//            return (T*)((value & Mask) | andnot((ulong)bits, Mask));
//        }
//    }
//
//
//    unsafe public struct PointerUIntPair<T> : IPointerIntPair<T>
//        where T : unmanaged
//    {
//        private T* Bits;
//
//
//        public T* Pointer
//        {
//            readonly get => IPointerIntPair<T>.GetPtr(Bits);
//            set => Bits = IPointerIntPair<T>.SetPtr(Bits, value);
//        }
//
//        public uint Integer
//        {
//            readonly get => IPointerIntPair<T>.GetInt(Bits);
//            set
//            {
//Assert.IsBetween(value, 0u, (1u << IPointerIntPair<T>.IntBits) - 1);
//
//                Bits = IPointerIntPair<T>.SetInt(Bits, value);
//            }
//        }
//
//        public static implicit operator PointerUIntPair<T>(T* input) => IPointerIntPair<T>.Init<PointerUIntPair<T>>(input);
//
//        public static implicit operator T*(PointerUIntPair<T> input) => input.Pointer;
//
//}
//
//    unsafe public struct PointerIntPair<T> : IPointerIntPair<T>
//        where T : unmanaged
//    {
//        private T* Bits;
//
//
//        public T* Pointer
//        {
//            readonly get => IPointerIntPair<T>.GetPtr(Bits);
//            set => Bits = IPointerIntPair<T>.SetPtr(Bits, value);
//        }
//
//        public int Integer
//        {
//            readonly get => signextend((int)IPointerIntPair<T>.GetInt(Bits), IPointerIntPair<T>.IntBits);
//            set
//            {
//if (sizeof(T) == 2)
//Assert.IsBetween(value, 0, 1);
//else
//Assert.IsBetween(value, -(1 << (IPointerIntPair<T>.IntBits - 1)), (1 << (IPointerIntPair<T>.IntBits - 1)) - 1);
//
//                Bits = IPointerIntPair<T>.SetInt(Bits, (uint)value);
//            }
//        }
//
//
//        public static implicit operator PointerIntPair<T>(T* input) => IPointerIntPair<T>.Init<PointerIntPair<T>>(input);
//
//        public static implicit operator T*(PointerIntPair<T> input) => input.Pointer;
//    }
//}
//