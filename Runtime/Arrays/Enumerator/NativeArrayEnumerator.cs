using DevTools;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;

namespace BitCollections
{
    unsafe public struct NativeArrayEnumerator<T> : IEnumerator, IEnumerator<T>, IEquatable<NativeArrayEnumerator<T>>, IDisposable
        where T : unmanaged
    {
        private T* _start;
        private int _current;
        private readonly int _length;

#if ENABLE_UNITY_COLLECTIONS_CHECKS
        private readonly AtomicSafetyHandle _safety;
        private readonly bool _isThreadSafe;

        public NativeArrayEnumerator(T* ptr, int length, AtomicSafetyHandle safety)
            : this(ptr, length)
        {
            _safety = safety;
            _isThreadSafe = true;
        }
#endif

        public NativeArrayEnumerator(T* ptr, int length)
        {
Assert.IsNotNull(ptr);
Assert.IsNotSmaller(length, 0);

            _start = ptr;
            _length = length;
            _current = -1;

#if ENABLE_UNITY_COLLECTIONS_CHECKS
            _safety = default(AtomicSafetyHandle);
            _isThreadSafe = false;
#endif
        }


        public readonly T Current
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
if (_isThreadSafe)
{
    AtomicSafetyHandle.CheckReadAndThrow(_safety);
}
#endif
                return _start[_current];
            }
        }
        readonly object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            int add = _current + 1;

            if (add < _length)
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
        public void Dispose() => _start = null;

        public override readonly int GetHashCode()
        {
            return ((IntPtr)_start).GetHashCode() ^ (_length ^ _current);
        }
        public readonly bool Equals(NativeArrayEnumerator<T> other)
        {
            return this._start == other._start &
                   this._current == other._current &
                   this._length == other._length;
        }
        public override readonly bool Equals(object obj)
        {
            return obj is NativeArrayEnumerator<T> converted && this.Equals(converted);
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