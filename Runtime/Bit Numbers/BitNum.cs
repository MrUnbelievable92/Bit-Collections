using System.Runtime.CompilerServices;

#pragma warning disable IDE1006
// "IBitInt" looks worse
// ...and the "I" prefix for interfaces is a horrible convetion anyways
namespace BitCollections
{
    public interface BitNum
    {
        bool IsSigned               { [MethodImpl(MethodImplOptions.AggressiveInlining)] get; }
        byte Bits                   { [MethodImpl(MethodImplOptions.AggressiveInlining)] get; }

        /// <summary>   lcm(Bits, 8) / 8    </summary>
        byte MinFullyPackedBytes    { [MethodImpl(MethodImplOptions.AggressiveInlining)] get; }
    }

    public interface BitInt : BitNum
    {
        long MinValueAsLong { [MethodImpl(MethodImplOptions.AggressiveInlining)] get; }
        long MaxValueAsLong { [MethodImpl(MethodImplOptions.AggressiveInlining)] get; }
    }

    //public interface BitFloat : BitNum
    //{
    //    byte ExponentBits       { [MethodImpl(MethodImplOptions.AggressiveInlining)] get; }
    //    byte MantissaBits       { [MethodImpl(MethodImplOptions.AggressiveInlining)] get; }
    //
    //    float  MinValueAsFloat  { [MethodImpl(MethodImplOptions.AggressiveInlining)] get; }
    //    float  MaxValueAsFloat  { [MethodImpl(MethodImplOptions.AggressiveInlining)] get; }
    //    double MinValueAsDouble { [MethodImpl(MethodImplOptions.AggressiveInlining)] get; }
    //    double MaxValueAsDouble { [MethodImpl(MethodImplOptions.AggressiveInlining)] get; }
    //}
}
#pragma warning restore IDE1006
