namespace MotoApp
{
    internal class BasicStack<T>
    {
        private readonly T[] _items;
        public BasicStack() => _items = new T[10];
        private int _currentIndex = -1;

        public void Push(T item) => _items[++_currentIndex] = item;
        public T Pop() => _items[_currentIndex--];
        public int Count => _currentIndex + 1;
    }
}