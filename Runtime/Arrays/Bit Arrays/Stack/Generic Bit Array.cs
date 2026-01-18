using DevTools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst.CompilerServices;
using MaxMath;

using static MaxMath.maxmath;
using static Unity.Mathematics.math;

namespace BitCollections
{
    [Serializable]
    unsafe public struct bits<T> : IArray<bool>, IEquatable<bits<T>>
        where T : unmanaged
    {
        public T Bits;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bits(T value)
        {
Assert.IsNotGreater(sizeof(T), 8);

            Bits = value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bits(bool value)
        {
Assert.IsNotGreater(sizeof(T), 8);

            ulong temp = (ulong)(-tolong(value));

            Bits = *(T*)&temp;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator T(bits<T> input)
        {
Assert.IsNotGreater(sizeof(T), 8);

            return input.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator bits<T>(T input)
        {
Assert.IsNotGreater(sizeof(T), 8);

            return new bits<T>(input);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bits<T> operator ! (bits<T> value)
        {
Assert.IsNotGreater(sizeof(T), 8);

            ulong temp = ~(value.AsULong);

            return *(bits<T>*)&temp;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bits<T> operator == (bits<T> left, bits<T> right)
        {
Assert.IsNotGreater(sizeof(T), 8);

            ulong temp = ~(left.AsULong ^ right.AsULong);

            return *(bits<T>*)&temp;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bits<T> operator != (bits<T> left, bits<T> right)
        {
Assert.IsNotGreater(sizeof(T), 8);

            ulong temp = left.AsULong ^ right.AsULong;

            return *(bits<T>*)&temp;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bits<T> operator & (bits<T> left, bits<T> right)
        {
Assert.IsNotGreater(sizeof(T), 8);

            ulong temp = left.AsULong & right.AsULong;

            return *(bits<T>*)&temp;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bits<T> operator | (bits<T> left, bits<T> right)
        {
Assert.IsNotGreater(sizeof(T), 8);

            ulong temp = left.AsULong | right.AsULong;

            return *(bits<T>*)&temp;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bits<T> operator ^ (bits<T> left, bits<T> right)
        {
Assert.IsNotGreater(sizeof(T), 8);

            ulong temp = left.AsULong ^ right.AsULong;

            return *(bits<T>*)&temp;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit8(bits<T> value)
        {
Assert.IsNotGreater(sizeof(T), 8);

            return *(bit8*)&value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit16(bits<T> value)
        {
Assert.IsNotGreater(sizeof(T), 8);

            return sizeof(T) switch
            {
                1 => new bit16{ Bits = *(byte*)&value},

                _ => *(bit16*)&value,
            };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit24(bits<T> value)
        {
Assert.IsNotGreater(sizeof(T), 8);

            return sizeof(T) switch
            {
                1 => new bit24{ Bits = *(byte*)&value},
                2 => new bit24{ Bits = *(ushort*)&value},

                _ => *(bit24*)&value,
            };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit32(bits<T> value)
        {
Assert.IsNotGreater(sizeof(T), 8);

            return sizeof(T) switch
            {
                1 => new bit32{ Bits = *(byte*)&value},
                2 => new bit32{ Bits = *(ushort*)&value},
                3 => new bit32{ Bits = *(UInt24*)&value},

                _ => *(bit32*)&value,
            };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit40(bits<T> value)
        {
Assert.IsNotGreater(sizeof(T), 8);

            return sizeof(T) switch
            {
                1 => new bit40{ Bits = *(byte*)&value},
                2 => new bit40{ Bits = *(ushort*)&value},
                3 => new bit40{ Bits = *(UInt24*)&value},
                4 => new bit40{ Bits = *(uint*)&value},

                _ => *(bit40*)&value,
            };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit48(bits<T> value)
        {
Assert.IsNotGreater(sizeof(T), 8);

            return sizeof(T) switch
            {
                1 => new bit48{ Bits = *(byte*)&value},
                2 => new bit48{ Bits = *(ushort*)&value},
                3 => new bit48{ Bits = *(UInt24*)&value},
                4 => new bit48{ Bits = *(uint*)&value},
                5 => new bit48{ Bits = *(UInt40*)&value},

                _ => *(bit48*)&value,
            };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit56(bits<T> value)
        {
Assert.IsNotGreater(sizeof(T), 8);

            return sizeof(T) switch
            {
                1 => new bit56{ Bits = *(byte*)&value},
                2 => new bit56{ Bits = *(ushort*)&value},
                3 => new bit56{ Bits = *(UInt24*)&value},
                4 => new bit56{ Bits = *(uint*)&value},
                5 => new bit56{ Bits = *(UInt40*)&value},
                6 => new bit56{ Bits = *(UInt48*)&value},

                _ => *(bit56*)&value,
            };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bit64(bits<T> value)
        {
Assert.IsNotGreater(sizeof(T), 8);

            return sizeof(T) switch
            {
                1 => new bit64{ Bits = *(byte*)&value},
                2 => new bit64{ Bits = *(ushort*)&value},
                3 => new bit64{ Bits = *(UInt24*)&value},
                4 => new bit64{ Bits = *(uint*)&value},
                5 => new bit64{ Bits = *(UInt40*)&value},
                6 => new bit64{ Bits = *(UInt48*)&value},
                7 => new bit64{ Bits = *(UInt56*)&value},

                _ => *(bit64*)&value,
            };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bits<T>(bit8 value)
        {
Assert.IsNotGreater(sizeof(T), 8);

            ulong field = value.Bits;

            return *(bits<T>*)&field;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bits<T>(bit16 value)
        {
Assert.IsNotGreater(sizeof(T), 8);

            ulong field = value.Bits;

            return *(bits<T>*)&field;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bits<T>(bit24 value)
        {
Assert.IsNotGreater(sizeof(T), 8);

            ulong field = value.Bits;

            return *(bits<T>*)&field;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bits<T>(bit32 value)
        {
Assert.IsNotGreater(sizeof(T), 8);

            ulong field = value.Bits;

            return *(bits<T>*)&field;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bits<T>(bit40 value)
        {
Assert.IsNotGreater(sizeof(T), 8);

            ulong field = value.Bits;

            return *(bits<T>*)&field;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bits<T>(bit48 value)
        {
Assert.IsNotGreater(sizeof(T), 8);

            ulong field = value.Bits;

            return *(bits<T>*)&field;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bits<T>(bit56 value)
        {
Assert.IsNotGreater(sizeof(T), 8);

            ulong field = value.Bits;

            return *(bits<T>*)&field;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bits<T>(bit64 value)
        {
Assert.IsNotGreater(sizeof(T), 8);

            ulong field = value.Bits;

            return *(bits<T>*)&field;
        }


        public readonly int Length
        {
            [return: AssumeRange(0, 64)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
Assert.IsNotGreater(sizeof(T), 8);

                return 8 * sizeof(T);
            }
        }

        internal readonly ulong AsULong
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                T temp = Bits;

                switch (sizeof(T))
                {
                    case 1:  return *(byte*)&temp;
                    case 2:  return *(ushort*)&temp;
                    case 3:  return *(UInt24*)&temp;
                    case 4:  return *(uint*)&temp;
                    case 5:  return *(UInt40*)&temp;
                    case 6:  return *(UInt48*)&temp;
                    case 7:  return *(UInt56*)&temp;
                    default: return *(ulong*)&temp;
                }
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bits<U> Reinterpret<U>()
            where U : unmanaged
        {
Assert.IsNotGreater(sizeof(T), 8);
Assert.AreEqual(sizeof(T), sizeof(U));

            T temp = Bits;

            return *(bits<U>*)&temp;
        }


        public bool this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
Assert.IsNotGreater(sizeof(T), 8);

                return tobool(BitFieldHelper.Get<Bit>(AsULong, index, 8 * sizeof(T)));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsNotGreater(sizeof(T), 8);

                ulong result = BitFieldHelper.Set<Bit>(AsULong, tobyte(value), index, 8 * sizeof(T));
                Bits = *(T*)&result;
            }
        }
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bits<T> SetReplicate(bool value)
        {
            switch (sizeof(T))
            {
                case 1: return (bits<T>)((bit8)this).SetReplicate(value);
                case 2: return (bits<T>)((bit16)this).SetReplicate(value);
                case 3: return (bits<T>)((bit24)this).SetReplicate(value);
                case 4: return (bits<T>)((bit32)this).SetReplicate(value);
                case 5: return (bits<T>)((bit40)this).SetReplicate(value);
                case 6: return (bits<T>)((bit48)this).SetReplicate(value);
                case 7: return (bits<T>)((bit56)this).SetReplicate(value);
                case 8: return (bits<T>)((bit64)this).SetReplicate(value);

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bits<T> SetReplicate(int index, int numBits, bool value)
        {
            switch (sizeof(T))
            {
                case 1: return (bits<T>)((bit8)this).SetReplicate(index, numBits, value);
                case 2: return (bits<T>)((bit16)this).SetReplicate(index, numBits, value);
                case 3: return (bits<T>)((bit24)this).SetReplicate(index, numBits, value);
                case 4: return (bits<T>)((bit32)this).SetReplicate(index, numBits, value);
                case 5: return (bits<T>)((bit40)this).SetReplicate(index, numBits, value);
                case 6: return (bits<T>)((bit48)this).SetReplicate(index, numBits, value);
                case 7: return (bits<T>)((bit56)this).SetReplicate(index, numBits, value);
                case 8: return (bits<T>)((bit64)this).SetReplicate(index, numBits, value);

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bits<T> ResetFirst()
        {
            switch (sizeof(T))
            {
                case 1: return (bits<T>)((bit8)this).ResetFirst();
                case 2: return (bits<T>)((bit16)this).ResetFirst();
                case 3: return (bits<T>)((bit24)this).ResetFirst();
                case 4: return (bits<T>)((bit32)this).ResetFirst();
                case 5: return (bits<T>)((bit40)this).ResetFirst();
                case 6: return (bits<T>)((bit48)this).ResetFirst();
                case 7: return (bits<T>)((bit56)this).ResetFirst();
                case 8: return (bits<T>)((bit64)this).ResetFirst();

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bits<T> ResetFirst(int index, int numBits)
        {
            switch (sizeof(T))
            {
                case 1: return (bits<T>)((bit8)this).ResetFirst(index, numBits);
                case 2: return (bits<T>)((bit16)this).ResetFirst(index, numBits);
                case 3: return (bits<T>)((bit24)this).ResetFirst(index, numBits);
                case 4: return (bits<T>)((bit32)this).ResetFirst(index, numBits);
                case 5: return (bits<T>)((bit40)this).ResetFirst(index, numBits);
                case 6: return (bits<T>)((bit48)this).ResetFirst(index, numBits);
                case 7: return (bits<T>)((bit56)this).ResetFirst(index, numBits);
                case 8: return (bits<T>)((bit64)this).ResetFirst(index, numBits);

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bits<T> SetFirst()
        {
            switch (sizeof(T))
            {
                case 1: return (bits<T>)((bit8)this).SetFirst();
                case 2: return (bits<T>)((bit16)this).SetFirst();
                case 3: return (bits<T>)((bit24)this).SetFirst();
                case 4: return (bits<T>)((bit32)this).SetFirst();
                case 5: return (bits<T>)((bit40)this).SetFirst();
                case 6: return (bits<T>)((bit48)this).SetFirst();
                case 7: return (bits<T>)((bit56)this).SetFirst();
                case 8: return (bits<T>)((bit64)this).SetFirst();

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bits<T> SetFirst(int index, int numBits)
        {
            switch (sizeof(T))
            {
                case 1: return (bits<T>)((bit8)this).SetFirst(index, numBits);
                case 2: return (bits<T>)((bit16)this).SetFirst(index, numBits);
                case 3: return (bits<T>)((bit24)this).SetFirst(index, numBits);
                case 4: return (bits<T>)((bit32)this).SetFirst(index, numBits);
                case 5: return (bits<T>)((bit40)this).SetFirst(index, numBits);
                case 6: return (bits<T>)((bit48)this).SetFirst(index, numBits);
                case 7: return (bits<T>)((bit56)this).SetFirst(index, numBits);
                case 8: return (bits<T>)((bit64)this).SetFirst(index, numBits);

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bits<T> ResetLast()
        {
            switch (sizeof(T))
            {
                case 1: return (bits<T>)((bit8)this).ResetLast();
                case 2: return (bits<T>)((bit16)this).ResetLast();
                case 3: return (bits<T>)((bit24)this).ResetLast();
                case 4: return (bits<T>)((bit32)this).ResetLast();
                case 5: return (bits<T>)((bit40)this).ResetLast();
                case 6: return (bits<T>)((bit48)this).ResetLast();
                case 7: return (bits<T>)((bit56)this).ResetLast();
                case 8: return (bits<T>)((bit64)this).ResetLast();

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bits<T> ResetLast(int index, int numBits)
        {
            switch (sizeof(T))
            {
                case 1: return (bits<T>)((bit8)this).ResetLast(index, numBits);
                case 2: return (bits<T>)((bit16)this).ResetLast(index, numBits);
                case 3: return (bits<T>)((bit24)this).ResetLast(index, numBits);
                case 4: return (bits<T>)((bit32)this).ResetLast(index, numBits);
                case 5: return (bits<T>)((bit40)this).ResetLast(index, numBits);
                case 6: return (bits<T>)((bit48)this).ResetLast(index, numBits);
                case 7: return (bits<T>)((bit56)this).ResetLast(index, numBits);
                case 8: return (bits<T>)((bit64)this).ResetLast(index, numBits);

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bits<T> SetLast()
        {
            switch (sizeof(T))
            {
                case 1: return (bits<T>)((bit8)this).SetLast();
                case 2: return (bits<T>)((bit16)this).SetLast();
                case 3: return (bits<T>)((bit24)this).SetLast();
                case 4: return (bits<T>)((bit32)this).SetLast();
                case 5: return (bits<T>)((bit40)this).SetLast();
                case 6: return (bits<T>)((bit48)this).SetLast();
                case 7: return (bits<T>)((bit56)this).SetLast();
                case 8: return (bits<T>)((bit64)this).SetLast();

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bits<T> SetLast(int index, int numBits)
        {
            switch (sizeof(T))
            {
                case 1: return (bits<T>)((bit8)this).SetLast(index, numBits);
                case 2: return (bits<T>)((bit16)this).SetLast(index, numBits);
                case 3: return (bits<T>)((bit24)this).SetLast(index, numBits);
                case 4: return (bits<T>)((bit32)this).SetLast(index, numBits);
                case 5: return (bits<T>)((bit40)this).SetLast(index, numBits);
                case 6: return (bits<T>)((bit48)this).SetLast(index, numBits);
                case 7: return (bits<T>)((bit56)this).SetLast(index, numBits);
                case 8: return (bits<T>)((bit64)this).SetLast(index, numBits);

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bits<T> ShiftLeft(int amount)
        {
            switch (sizeof(T))
            {
                case 1: return (bits<T>)((bit8)this).ShiftLeft(amount);
                case 2: return (bits<T>)((bit16)this).ShiftLeft(amount);
                case 3: return (bits<T>)((bit24)this).ShiftLeft(amount);
                case 4: return (bits<T>)((bit32)this).ShiftLeft(amount);
                case 5: return (bits<T>)((bit40)this).ShiftLeft(amount);
                case 6: return (bits<T>)((bit48)this).ShiftLeft(amount);
                case 7: return (bits<T>)((bit56)this).ShiftLeft(amount);
                case 8: return (bits<T>)((bit64)this).ShiftLeft(amount);

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bits<T> ShiftLeft(int index, int numBits, int amount)
        {
            switch (sizeof(T))
            {
                case 1: return (bits<T>)((bit8)this).ShiftLeft(index, numBits, amount);
                case 2: return (bits<T>)((bit16)this).ShiftLeft(index, numBits, amount);
                case 3: return (bits<T>)((bit24)this).ShiftLeft(index, numBits, amount);
                case 4: return (bits<T>)((bit32)this).ShiftLeft(index, numBits, amount);
                case 5: return (bits<T>)((bit40)this).ShiftLeft(index, numBits, amount);
                case 6: return (bits<T>)((bit48)this).ShiftLeft(index, numBits, amount);
                case 7: return (bits<T>)((bit56)this).ShiftLeft(index, numBits, amount);
                case 8: return (bits<T>)((bit64)this).ShiftLeft(index, numBits, amount);

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bits<T> ShiftRight(int amount)
        {
            switch (sizeof(T))
            {
                case 1: return (bits<T>)((bit8)this).ShiftRight(amount);
                case 2: return (bits<T>)((bit16)this).ShiftRight(amount);
                case 3: return (bits<T>)((bit24)this).ShiftRight(amount);
                case 4: return (bits<T>)((bit32)this).ShiftRight(amount);
                case 5: return (bits<T>)((bit40)this).ShiftRight(amount);
                case 6: return (bits<T>)((bit48)this).ShiftRight(amount);
                case 7: return (bits<T>)((bit56)this).ShiftRight(amount);
                case 8: return (bits<T>)((bit64)this).ShiftRight(amount);

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bits<T> ShiftRight(int index, int numBits, int amount)
        {
            switch (sizeof(T))
            {
                case 1: return (bits<T>)((bit8)this).ShiftRight(index, numBits, amount);
                case 2: return (bits<T>)((bit16)this).ShiftRight(index, numBits, amount);
                case 3: return (bits<T>)((bit24)this).ShiftRight(index, numBits, amount);
                case 4: return (bits<T>)((bit32)this).ShiftRight(index, numBits, amount);
                case 5: return (bits<T>)((bit40)this).ShiftRight(index, numBits, amount);
                case 6: return (bits<T>)((bit48)this).ShiftRight(index, numBits, amount);
                case 7: return (bits<T>)((bit56)this).ShiftRight(index, numBits, amount);
                case 8: return (bits<T>)((bit64)this).ShiftRight(index, numBits, amount);

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bits<T> RotateLeft(int amount)
        {
            switch (sizeof(T))
            {
                case 1: return (bits<T>)((bit8)this).RotateLeft(amount);
                case 2: return (bits<T>)((bit16)this).RotateLeft(amount);
                case 3: return (bits<T>)((bit24)this).RotateLeft(amount);
                case 4: return (bits<T>)((bit32)this).RotateLeft(amount);
                case 5: return (bits<T>)((bit40)this).RotateLeft(amount);
                case 6: return (bits<T>)((bit48)this).RotateLeft(amount);
                case 7: return (bits<T>)((bit56)this).RotateLeft(amount);
                case 8: return (bits<T>)((bit64)this).RotateLeft(amount);

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bits<T> RotateLeft(int index, int numBits, int amount)
        {
            switch (sizeof(T))
            {
                case 1: return (bits<T>)((bit8)this).RotateLeft(index, numBits, amount);
                case 2: return (bits<T>)((bit16)this).RotateLeft(index, numBits, amount);
                case 3: return (bits<T>)((bit24)this).RotateLeft(index, numBits, amount);
                case 4: return (bits<T>)((bit32)this).RotateLeft(index, numBits, amount);
                case 5: return (bits<T>)((bit40)this).RotateLeft(index, numBits, amount);
                case 6: return (bits<T>)((bit48)this).RotateLeft(index, numBits, amount);
                case 7: return (bits<T>)((bit56)this).RotateLeft(index, numBits, amount);
                case 8: return (bits<T>)((bit64)this).RotateLeft(index, numBits, amount);

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bits<T> RotateRight(int amount)
        {
            switch (sizeof(T))
            {
                case 1: return (bits<T>)((bit8)this).RotateRight(amount);
                case 2: return (bits<T>)((bit16)this).RotateRight(amount);
                case 3: return (bits<T>)((bit24)this).RotateRight(amount);
                case 4: return (bits<T>)((bit32)this).RotateRight(amount);
                case 5: return (bits<T>)((bit40)this).RotateRight(amount);
                case 6: return (bits<T>)((bit48)this).RotateRight(amount);
                case 7: return (bits<T>)((bit56)this).RotateRight(amount);
                case 8: return (bits<T>)((bit64)this).RotateRight(amount);

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bits<T> RotateRight(int index, int numBits, int amount)
        {
            switch (sizeof(T))
            {
                case 1: return (bits<T>)((bit8)this).RotateRight(index, numBits, amount);
                case 2: return (bits<T>)((bit16)this).RotateRight(index, numBits, amount);
                case 3: return (bits<T>)((bit24)this).RotateRight(index, numBits, amount);
                case 4: return (bits<T>)((bit32)this).RotateRight(index, numBits, amount);
                case 5: return (bits<T>)((bit40)this).RotateRight(index, numBits, amount);
                case 6: return (bits<T>)((bit48)this).RotateRight(index, numBits, amount);
                case 7: return (bits<T>)((bit56)this).RotateRight(index, numBits, amount);
                case 8: return (bits<T>)((bit64)this).RotateRight(index, numBits, amount);

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bits<T> Reverse()
        {
            switch (sizeof(T))
            {
                case 1: return (bits<T>)((bit8)this).Reverse();
                case 2: return (bits<T>)((bit16)this).Reverse();
                case 3: return (bits<T>)((bit24)this).Reverse();
                case 4: return (bits<T>)((bit32)this).Reverse();
                case 5: return (bits<T>)((bit40)this).Reverse();
                case 6: return (bits<T>)((bit48)this).Reverse();
                case 7: return (bits<T>)((bit56)this).Reverse();
                case 8: return (bits<T>)((bit64)this).Reverse();

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bits<T> Reverse(int index, int numBits)
        {
            switch (sizeof(T))
            {
                case 1: return (bits<T>)((bit8)this).Reverse(index, numBits);
                case 2: return (bits<T>)((bit16)this).Reverse(index, numBits);
                case 3: return (bits<T>)((bit24)this).Reverse(index, numBits);
                case 4: return (bits<T>)((bit32)this).Reverse(index, numBits);
                case 5: return (bits<T>)((bit40)this).Reverse(index, numBits);
                case 6: return (bits<T>)((bit48)this).Reverse(index, numBits);
                case 7: return (bits<T>)((bit56)this).Reverse(index, numBits);
                case 8: return (bits<T>)((bit64)this).Reverse(index, numBits);

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bits<T> Swap(int index0, int index1)
        {
            switch (sizeof(T))
            {
                case 1: return (bits<T>)((bit8)this).Swap(index0, index1);
                case 2: return (bits<T>)((bit16)this).Swap(index0, index1);
                case 3: return (bits<T>)((bit24)this).Swap(index0, index1);
                case 4: return (bits<T>)((bit32)this).Swap(index0, index1);
                case 5: return (bits<T>)((bit40)this).Swap(index0, index1);
                case 6: return (bits<T>)((bit48)this).Swap(index0, index1);
                case 7: return (bits<T>)((bit56)this).Swap(index0, index1);
                case 8: return (bits<T>)((bit64)this).Swap(index0, index1);

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bits<T> Swap(int index0, int index1, int numBits)
        {
            switch (sizeof(T))
            {
                case 1: return (bits<T>)((bit8)this).Swap(index0, index1, numBits);
                case 2: return (bits<T>)((bit16)this).Swap(index0, index1, numBits);
                case 3: return (bits<T>)((bit24)this).Swap(index0, index1, numBits);
                case 4: return (bits<T>)((bit32)this).Swap(index0, index1, numBits);
                case 5: return (bits<T>)((bit40)this).Swap(index0, index1, numBits);
                case 6: return (bits<T>)((bit48)this).Swap(index0, index1, numBits);
                case 7: return (bits<T>)((bit56)this).Swap(index0, index1, numBits);
                case 8: return (bits<T>)((bit64)this).Swap(index0, index1, numBits);

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bits<T> Flip()
        {
            switch (sizeof(T))
            {
                case 1: return (bits<T>)((bit8)this).Flip();
                case 2: return (bits<T>)((bit16)this).Flip();
                case 3: return (bits<T>)((bit24)this).Flip();
                case 4: return (bits<T>)((bit32)this).Flip();
                case 5: return (bits<T>)((bit40)this).Flip();
                case 6: return (bits<T>)((bit48)this).Flip();
                case 7: return (bits<T>)((bit56)this).Flip();
                case 8: return (bits<T>)((bit64)this).Flip();

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bits<T> Flip(int index, int numBits)
        {
            switch (sizeof(T))
            {
                case 1: return (bits<T>)((bit8)this).Flip(index, numBits);
                case 2: return (bits<T>)((bit16)this).Flip(index, numBits);
                case 3: return (bits<T>)((bit24)this).Flip(index, numBits);
                case 4: return (bits<T>)((bit32)this).Flip(index, numBits);
                case 5: return (bits<T>)((bit40)this).Flip(index, numBits);
                case 6: return (bits<T>)((bit48)this).Flip(index, numBits);
                case 7: return (bits<T>)((bit56)this).Flip(index, numBits);
                case 8: return (bits<T>)((bit64)this).Flip(index, numBits);

                default: throw new InvalidCastException();
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int IndexOfFirst()
        {
            switch (sizeof(T))
            {
                case 1: return ((bit8)this).IndexOfFirst();
                case 2: return ((bit16)this).IndexOfFirst();
                case 3: return ((bit24)this).IndexOfFirst();
                case 4: return ((bit32)this).IndexOfFirst();
                case 5: return ((bit40)this).IndexOfFirst();
                case 6: return ((bit48)this).IndexOfFirst();
                case 7: return ((bit56)this).IndexOfFirst();
                case 8: return ((bit64)this).IndexOfFirst();

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int IndexOfFirst(int index, int numBits)
        {
            switch (sizeof(T))
            {
                case 1: return ((bit8)this).IndexOfFirst(index, numBits);
                case 2: return ((bit16)this).IndexOfFirst(index, numBits);
                case 3: return ((bit24)this).IndexOfFirst(index, numBits);
                case 4: return ((bit32)this).IndexOfFirst(index, numBits);
                case 5: return ((bit40)this).IndexOfFirst(index, numBits);
                case 6: return ((bit48)this).IndexOfFirst(index, numBits);
                case 7: return ((bit56)this).IndexOfFirst(index, numBits);
                case 8: return ((bit64)this).IndexOfFirst(index, numBits);

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int IndexOfLast()
        {
            switch (sizeof(T))
            {
                case 1: return ((bit8)this).IndexOfLast();
                case 2: return ((bit16)this).IndexOfLast();
                case 3: return ((bit24)this).IndexOfLast();
                case 4: return ((bit32)this).IndexOfLast();
                case 5: return ((bit40)this).IndexOfLast();
                case 6: return ((bit48)this).IndexOfLast();
                case 7: return ((bit56)this).IndexOfLast();
                case 8: return ((bit64)this).IndexOfLast();

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int IndexOfLast(int index, int numBits)
        {
            switch (sizeof(T))
            {
                case 1: return ((bit8)this).IndexOfLast(index, numBits);
                case 2: return ((bit16)this).IndexOfLast(index, numBits);
                case 3: return ((bit24)this).IndexOfLast(index, numBits);
                case 4: return ((bit32)this).IndexOfLast(index, numBits);
                case 5: return ((bit40)this).IndexOfLast(index, numBits);
                case 6: return ((bit48)this).IndexOfLast(index, numBits);
                case 7: return ((bit56)this).IndexOfLast(index, numBits);
                case 8: return ((bit64)this).IndexOfLast(index, numBits);

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint CountBits()
        {
            switch (sizeof(T))
            {
                case 1: return ((bit8)this).CountBits();
                case 2: return ((bit16)this).CountBits();
                case 3: return ((bit24)this).CountBits();
                case 4: return ((bit32)this).CountBits();
                case 5: return ((bit40)this).CountBits();
                case 6: return ((bit48)this).CountBits();
                case 7: return ((bit56)this).CountBits();
                case 8: return ((bit64)this).CountBits();

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint CountBits(int index, int numBits)
        {
            switch (sizeof(T))
            {
                case 1: return ((bit8)this).CountBits(index, numBits);
                case 2: return ((bit16)this).CountBits(index, numBits);
                case 3: return ((bit24)this).CountBits(index, numBits);
                case 4: return ((bit32)this).CountBits(index, numBits);
                case 5: return ((bit40)this).CountBits(index, numBits);
                case 6: return ((bit48)this).CountBits(index, numBits);
                case 7: return ((bit56)this).CountBits(index, numBits);
                case 8: return ((bit64)this).CountBits(index, numBits);

                default: throw new InvalidCastException();
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int FindString(bool value, int amount)
        {
            switch (sizeof(T))
            {
                case 1: return ((bit8)this).FindString(value, amount);
                case 2: return ((bit16)this).FindString(value, amount);
                case 3: return ((bit24)this).FindString(value, amount);
                case 4: return ((bit32)this).FindString(value, amount);
                case 5: return ((bit40)this).FindString(value, amount);
                case 6: return ((bit48)this).FindString(value, amount);
                case 7: return ((bit56)this).FindString(value, amount);
                case 8: return ((bit64)this).FindString(value, amount);

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int FindString(int index, int numBits, bool value, int amount)
        {
            switch (sizeof(T))
            {
                case 1: return ((bit8)this).FindString(index, numBits, value, amount);
                case 2: return ((bit16)this).FindString(index, numBits, value, amount);
                case 3: return ((bit24)this).FindString(index, numBits, value, amount);
                case 4: return ((bit32)this).FindString(index, numBits, value, amount);
                case 5: return ((bit40)this).FindString(index, numBits, value, amount);
                case 6: return ((bit48)this).FindString(index, numBits, value, amount);
                case 7: return ((bit56)this).FindString(index, numBits, value, amount);
                case 8: return ((bit64)this).FindString(index, numBits, value, amount);

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAll()
        {
            switch (sizeof(T))
            {
                case 1: return ((bit8)this).TestAll();
                case 2: return ((bit16)this).TestAll();
                case 3: return ((bit24)this).TestAll();
                case 4: return ((bit32)this).TestAll();
                case 5: return ((bit40)this).TestAll();
                case 6: return ((bit48)this).TestAll();
                case 7: return ((bit56)this).TestAll();
                case 8: return ((bit64)this).TestAll();

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAll(int index, int numBits)
        {
            switch (sizeof(T))
            {
                case 1: return ((bit8)this).TestAll(index, numBits);
                case 2: return ((bit16)this).TestAll(index, numBits);
                case 3: return ((bit24)this).TestAll(index, numBits);
                case 4: return ((bit32)this).TestAll(index, numBits);
                case 5: return ((bit40)this).TestAll(index, numBits);
                case 6: return ((bit48)this).TestAll(index, numBits);
                case 7: return ((bit56)this).TestAll(index, numBits);
                case 8: return ((bit64)this).TestAll(index, numBits);

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAny()
        {
            switch (sizeof(T))
            {
                case 1: return ((bit8)this).TestAny();
                case 2: return ((bit16)this).TestAny();
                case 3: return ((bit24)this).TestAny();
                case 4: return ((bit32)this).TestAny();
                case 5: return ((bit40)this).TestAny();
                case 6: return ((bit48)this).TestAny();
                case 7: return ((bit56)this).TestAny();
                case 8: return ((bit64)this).TestAny();

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestAny(int index, int numBits)
        {
            switch (sizeof(T))
            {
                case 1: return ((bit8)this).TestAny(index, numBits);
                case 2: return ((bit16)this).TestAny(index, numBits);
                case 3: return ((bit24)this).TestAny(index, numBits);
                case 4: return ((bit32)this).TestAny(index, numBits);
                case 5: return ((bit40)this).TestAny(index, numBits);
                case 6: return ((bit48)this).TestAny(index, numBits);
                case 7: return ((bit56)this).TestAny(index, numBits);
                case 8: return ((bit64)this).TestAny(index, numBits);

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestNone()
        {
            switch (sizeof(T))
            {
                case 1: return ((bit8)this).TestNone();
                case 2: return ((bit16)this).TestNone();
                case 3: return ((bit24)this).TestNone();
                case 4: return ((bit32)this).TestNone();
                case 5: return ((bit40)this).TestNone();
                case 6: return ((bit48)this).TestNone();
                case 7: return ((bit56)this).TestNone();
                case 8: return ((bit64)this).TestNone();

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestNone(int index, int numBits)
        {
            switch (sizeof(T))
            {
                case 1: return ((bit8)this).TestNone(index, numBits);
                case 2: return ((bit16)this).TestNone(index, numBits);
                case 3: return ((bit24)this).TestNone(index, numBits);
                case 4: return ((bit32)this).TestNone(index, numBits);
                case 5: return ((bit40)this).TestNone(index, numBits);
                case 6: return ((bit48)this).TestNone(index, numBits);
                case 7: return ((bit56)this).TestNone(index, numBits);
                case 8: return ((bit64)this).TestNone(index, numBits);

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestNotAll()
        {
            switch (sizeof(T))
            {
                case 1: return ((bit8)this).TestNotAll();
                case 2: return ((bit16)this).TestNotAll();
                case 3: return ((bit24)this).TestNotAll();
                case 4: return ((bit32)this).TestNotAll();
                case 5: return ((bit40)this).TestNotAll();
                case 6: return ((bit48)this).TestNotAll();
                case 7: return ((bit56)this).TestNotAll();
                case 8: return ((bit64)this).TestNotAll();

                default: throw new InvalidCastException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TestNotAll(int index, int numBits)
        {
            switch (sizeof(T))
            {
                case 1: return ((bit8)this).TestNotAll(index, numBits);
                case 2: return ((bit16)this).TestNotAll(index, numBits);
                case 3: return ((bit24)this).TestNotAll(index, numBits);
                case 4: return ((bit32)this).TestNotAll(index, numBits);
                case 5: return ((bit40)this).TestNotAll(index, numBits);
                case 6: return ((bit48)this).TestNotAll(index, numBits);
                case 7: return ((bit56)this).TestNotAll(index, numBits);
                case 8: return ((bit64)this).TestNotAll(index, numBits);

                default: throw new InvalidCastException();
            }
        }

        public override readonly string ToString()
        {
Assert.IsNotGreater(sizeof(T), 8);

            return Dump.Bits(this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
Assert.IsNotGreater(sizeof(T), 8);

            if (sizeof(T) > 4)
            {
                ulong masked = AsULong;

                return (int)(masked ^ (masked >> 32));
            }
            else
            {
                return (int)AsULong;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(bits<T> other)
        {
Assert.IsNotGreater(sizeof(T), 8);

            return this.AsULong == other.AsULong;
        }
        public override readonly bool Equals(object obj)
        {
Assert.IsNotGreater(sizeof(T), 8);

            return obj is bits<T> converted && this.Equals(converted);
        }
        public readonly IEnumerator<bool> GetEnumerator()
        {
Assert.IsNotGreater(sizeof(T), 8);

            return new ArrayEnumerator<bits<T>, bool>(this);
        }
        readonly IEnumerator IEnumerable.GetEnumerator()
        {
Assert.IsNotGreater(sizeof(T), 8);

            return new ArrayEnumerator<bits<T>, bool>(this);
        }
    }
}