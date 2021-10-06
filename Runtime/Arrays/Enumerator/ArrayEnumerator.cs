using System;
using System.Collections;
using System.Collections.Generic;

namespace BitCollections
{
    public struct ArrayEnumerator<T> : IEnumerator, IEnumerator<T>, IDisposable
    {
        private int current;
        private readonly IReadOnlyArray<T> array;


        public ArrayEnumerator(IReadOnlyArray<T> array)
        {
            this.current = -1;
            this.array = array;
        }


        public T Current => array[current];
        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            int add = current + 1;

            if (add < array.Length)
            {
                current = add;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Reset() => current = -1;
        public void Dispose() { }

        public override readonly int GetHashCode()
        {
            return array.GetHashCode() ^ current;
        }
        public override readonly bool Equals(object obj)
        {
            ArrayEnumerator<T> other = (ArrayEnumerator<T>)obj;

            return this.array.GetHashCode() == other.array.GetHashCode() &
                   this.current == other.current;
        }
        public override string ToString()
        {
            int previous = current;
            Reset();

            string values = string.Empty;

            while (MoveNext())
            {
                values += $"{ current }: { Current }\n";
            }

            current = previous;

            return values;
        }
    }
}