using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;

namespace BitCollections
{
    public struct ArrayEnumerator<TContainer, TElement> : IEnumerator, IEnumerator<TElement>, IEquatable<ArrayEnumerator<TContainer, TElement>>, IDisposable
        where TContainer : struct, IReadOnlyArray<TElement>
        where TElement : unmanaged
    {
        private int _current;
        private readonly TContainer _array;

#if ENABLE_UNITY_COLLECTIONS_CHECKS
        private readonly AtomicSafetyHandle _safety;
        private readonly bool _isThreadSafe;

        public ArrayEnumerator(TContainer array, AtomicSafetyHandle safety)
            : this(array)
        {
            _safety = safety;
            _isThreadSafe = true;
        }
#endif

        public ArrayEnumerator(TContainer array)
        {
            _current = -1;
            _array = array;

#if ENABLE_UNITY_COLLECTIONS_CHECKS
            _safety = default(AtomicSafetyHandle);
            _isThreadSafe = false;
#endif
        }

        public readonly TElement Current
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
if (_isThreadSafe)
{
    AtomicSafetyHandle.CheckReadAndThrow(_safety);
}
#endif
                return _array[_current];
            }
        }
        readonly object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            int add = _current + 1;

            if (add < _array.Length)
            {
                _current = add;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Reset() => _current = -1;
        public readonly void Dispose() { }

        public override readonly int GetHashCode()
        {
            return _array.GetHashCode() ^ _current;
        }
        public readonly bool Equals(ArrayEnumerator<TContainer, TElement> other)
        {
            return this._array.GetHashCode() == other._array.GetHashCode() &
                   this._current == other._current;
        }
        public override readonly bool Equals(object obj)
        {
            return obj is ArrayEnumerator<TContainer, TElement> converted && this.Equals(converted);
        }
        public override string ToString()
        {
            int previous = _current;
            Reset();

            string values = string.Empty;

            while (MoveNext())
            {
                values += $"{ _current }: { Current }\n";
            }

            _current = previous;

            return values;
        }
    }
}