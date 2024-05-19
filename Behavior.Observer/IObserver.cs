namespace Behavior.Observer
{
    /// <summary>
    /// Defines an observer that can receive updates from a subject.
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// Gets observer name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Updates the observer with the new state.
        /// </summary>
        /// <param name="state">The new state.</param>
        void Update(string state);
    }
}
