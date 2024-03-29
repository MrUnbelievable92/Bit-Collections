﻿using DevTools;
using System;
using System.Collections;
using System.Collections.Generic;

namespace BitCollections
{
    unsafe public struct NativeArrayEnumerator<T> : IEnumerator, IEnumerator<T>, IDisposable
        where T : unmanaged
    {
        private T* start;
        private int current;
        private readonly int length;


        public NativeArrayEnumerator(T* ptr, int length)
        {
Assert.IsNotNull(ptr);
Assert.IsNotSmaller(length, 0);

            this.start = ptr;
            this.length = length;
            this.current = -1;
        }


        public T Current => start[current];
        object IEnumerator.Current =>(object)Current;

        public bool MoveNext()
        {
            int add = current + 1;

            if (add < length)
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
        public void Dispose() => start = null;

        public override readonly int GetHashCode()
        {
            return ((IntPtr)start).GetHashCode() ^ (length ^ current);
        }
        public override readonly bool Equals(object obj)
        {
            NativeArrayEnumerator<T> other = (NativeArrayEnumerator<T>)obj;

            return this.start == other.start &
                   this.current == other.current &
                   this.length == other.length;
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