using Behavior.Iterator.Iterators;

namespace Behavior.Iterator.Aggregates
{
    /// <summary>
    /// Represents a concrete aggregate for a collection of elements of type T.
    /// </summary>
    /// <typeparam name="T">The type of elements in the collection.</typeparam>
    public class ConcreteAggregate<T> : IAggregate<T>
    {
        private readonly T[] _items;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteAggregate{T}"/> class with the specified items.
        /// </summary>
        /// <param name="items">The collection of items.</param>
        public ConcreteAggregate(T[] items)
        {
            _items = items;
        }

        /// <inheritdoc/>
        public IIterator<T> CreateIterator()
        {
            return new ConcreteIterator<T>(_items);
        }
    }
}
