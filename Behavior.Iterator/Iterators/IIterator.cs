namespace Behavior.Iterator.Iterators
{
    /// <summary>
    /// Represents an iterator interface.
    /// </summary>
    /// <typeparam name="T">The type of elements in the collection being iterated.</typeparam>
    public interface IIterator<T>
    {
        /// <summary>
        /// Gets the current element in the iteration.
        /// </summary>
        T Current { get; }

        /// <summary>
        /// Moves the iterator to the next element in the collection.
        /// </summary>
        /// <returns>True if the iterator was successfully moved to the next element; otherwise, false.</returns>
        bool MoveNext();
    }
}
