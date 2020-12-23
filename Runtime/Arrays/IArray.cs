using System.Collections;
using System.Collections.Generic;

namespace BitCollections
{
    public interface IArray<T> : IEnumerable, IEnumerable<T>
    {
        int Length { get; }

        T this[int index] { get; set; }
    }
}