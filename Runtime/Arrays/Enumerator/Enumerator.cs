using System;
using System.Collections;
using System.Collections.Generic;

namespace BitCollections
{
    public struct Enumerator<T> : IEnumerator, IEnumerator<T>, IDisposable
    {
        private int current;
        private readonly IArray<T> array;


        public Enumerator(IArray<T> array)
        {
            this.current = -1;
            this.array = array;
        }


        public T Current => array[current];
        object IEnumerator.Current => Current;

        public bool MoveNext() => ++current < array.Length;
        public void Reset() => current = -1;
        public void Dispose() { }

        public override readonly int GetHashCode()
        {
            return array.GetHashCode() ^ current;
        }
        public override readonly bool Equals(object obj)
        {
            return this.GetHashCode() == ((Enumerator<T>)obj).GetHashCode();
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