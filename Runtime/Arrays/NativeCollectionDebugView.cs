namespace BitCollections
{
    internal sealed class NativeCollectionDebugView<T>
    {
        public T[] Items;

        public NativeCollectionDebugView(IReadOnlyArray<T> array)
        {
            Items = new T[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                Items[i] = array[i];
            }
        }
    }
}
