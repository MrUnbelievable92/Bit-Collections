using System.Runtime.CompilerServices;
using Unity.Mathematics;
using DevTools;
using MaxMath;
using SIMDAlgorithms;

namespace BitCollections
{
    internal static class ComparisonExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte CompareSWAR<T>(this Comparison c, byte a, byte b)
            where T : BitInt
        {
            switch (c)
            {
                case Comparison.EqualTo:                return SWAR.Equals<T>(a, b);
                case Comparison.NotEqualTo:             return SWAR.NotEquals<T>(a, b);
                case Comparison.GreaterThan:            return SWAR.GreaterThan<T>(a, b);
                case Comparison.LessThan:               return SWAR.LessThan<T>(a, b);
                case Comparison.GreaterThanOrEqualTo:   return SWAR.GreaterThanOrEqual<T>(a, b);
                case Comparison.LessThanOrEqualTo:      return SWAR.LessThanOrEqual<T>(a, b);
                
                default: throw Assert.Unreachable();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ushort CompareSWAR<T>(this Comparison c, ushort a, ushort b)
            where T : BitInt
        {
            switch (c)
            {
                case Comparison.EqualTo:                return SWAR.Equals<T>(a, b);
                case Comparison.NotEqualTo:             return SWAR.NotEquals<T>(a, b);
                case Comparison.GreaterThan:            return SWAR.GreaterThan<T>(a, b);
                case Comparison.LessThan:               return SWAR.LessThan<T>(a, b);
                case Comparison.GreaterThanOrEqualTo:   return SWAR.GreaterThanOrEqual<T>(a, b);
                case Comparison.LessThanOrEqualTo:      return SWAR.LessThanOrEqual<T>(a, b);
                
                default: throw Assert.Unreachable();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint CompareSWAR<T>(this Comparison c, uint a, uint b)
            where T : BitInt
        {
            switch (c)
            {
                case Comparison.EqualTo:                return SWAR.Equals<T>(a, b);
                case Comparison.NotEqualTo:             return SWAR.NotEquals<T>(a, b);
                case Comparison.GreaterThan:            return SWAR.GreaterThan<T>(a, b);
                case Comparison.LessThan:               return SWAR.LessThan<T>(a, b);
                case Comparison.GreaterThanOrEqualTo:   return SWAR.GreaterThanOrEqual<T>(a, b);
                case Comparison.LessThanOrEqualTo:      return SWAR.LessThanOrEqual<T>(a, b);
                
                default: throw Assert.Unreachable();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ulong CompareSWAR<T>(this Comparison c, ulong a, ulong b)
            where T : BitInt
        {
            switch (c)
            {
                case Comparison.EqualTo:                return SWAR.Equals<T>(a, b);
                case Comparison.NotEqualTo:             return SWAR.NotEquals<T>(a, b);
                case Comparison.GreaterThan:            return SWAR.GreaterThan<T>(a, b);
                case Comparison.LessThan:               return SWAR.LessThan<T>(a, b);
                case Comparison.GreaterThanOrEqualTo:   return SWAR.GreaterThanOrEqual<T>(a, b);
                case Comparison.LessThanOrEqualTo:      return SWAR.LessThanOrEqual<T>(a, b);
                
                default: throw Assert.Unreachable();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint4 CompareSWAR<T>(this Comparison c, uint4 a, uint4 b)
            where T : BitInt
        {
            switch (c)
            {
                case Comparison.EqualTo:                return SWAR.Equals<T>(a, b);
                case Comparison.NotEqualTo:             return SWAR.NotEquals<T>(a, b);
                case Comparison.GreaterThan:            return SWAR.GreaterThan<T>(a, b);
                case Comparison.LessThan:               return SWAR.LessThan<T>(a, b);
                case Comparison.GreaterThanOrEqualTo:   return SWAR.GreaterThanOrEqual<T>(a, b);
                case Comparison.LessThanOrEqualTo:      return SWAR.LessThanOrEqual<T>(a, b);
                
                default: throw Assert.Unreachable();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint8 CompareSWAR<T>(this Comparison c, uint8 a, uint8 b)
            where T : BitInt
        {
            switch (c)
            {
                case Comparison.EqualTo:                return SWAR.Equals<T>(a, b);
                case Comparison.NotEqualTo:             return SWAR.NotEquals<T>(a, b);
                case Comparison.GreaterThan:            return SWAR.GreaterThan<T>(a, b);
                case Comparison.LessThan:               return SWAR.LessThan<T>(a, b);
                case Comparison.GreaterThanOrEqualTo:   return SWAR.GreaterThanOrEqual<T>(a, b);
                case Comparison.LessThanOrEqualTo:      return SWAR.LessThanOrEqual<T>(a, b);
                
                default: throw Assert.Unreachable();
            }
        }
    }
}
