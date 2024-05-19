using Behavior.Iterator.Iterators;

namespace Behavior.Iterator.Aggregates
{
    /// <summary>
    /// Represents an aggregate interface.
    /// </summary>
    /// <typeparam name="T">The type of elements in the aggregate.</typeparam>
    public interface IAggregate<T>
    {
        /// <summary>
        /// Creates an iterator for the aggregate.
        /// </summary>
        /// <returns>An iterator for the aggregate.</returns>
        IIterator<T> CreateIterator();
    }
}
