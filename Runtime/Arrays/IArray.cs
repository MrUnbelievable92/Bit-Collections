using System.Collections;
using System.Collections.Generic;

namespace BitCollections
{
    public interface IArray<T> : IReadOnlyArray<T>
    {
        new T this[int index] { get; set; }
    }

    public interface IReadOnlyArray<T> : IEnumerable, IEnumerable<T>
    {
        int Length { get; }

        T this[int index] { get; }
    }
}