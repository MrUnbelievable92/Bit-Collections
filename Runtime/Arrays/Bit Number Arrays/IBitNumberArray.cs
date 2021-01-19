using System;

namespace BitCollections
{
    public interface IBitNumberArray<T> : IArray<T>
        where T : unmanaged, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
    {
        T MinValue { get; }
        T MaxValue { get; }

        int BitsPerNumber { get; }
    }

    public interface IReadOnlyBitNumberArray<T> : IReadOnlyArray<T>
        where T : unmanaged, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
    {
        T MinValue { get; }
        T MaxValue { get; }

        int BitsPerNumber { get; }
    }
}