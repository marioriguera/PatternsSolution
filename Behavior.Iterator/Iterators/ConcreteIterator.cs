namespace Behavior.Iterator.Iterators
{
    /// <summary>
    /// Represents a concrete iterator for a collection of elements of type T.
    /// </summary>
    /// <typeparam name="T">The type of elements in the collection.</typeparam>
    public class ConcreteIterator<T> : IIterator<T>
    {
        private readonly T[] _items;
        private int _position = -1;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteIterator{T}"/> class with the specified items.
        /// </summary>
        /// <param name="items">The collection of items to iterate over.</param>
        public ConcreteIterator(T[] items)
        {
            _items = items;
        }

        /// <inheritdoc/>
        public T Current => _items[_position];

        /// <inheritdoc/>
        public bool MoveNext()
        {
            _position++;

            if (_position < _items.Length)
            {
                return true;
            }

            _position = _items.Length - 1;
            return false;
        }
    }
}
