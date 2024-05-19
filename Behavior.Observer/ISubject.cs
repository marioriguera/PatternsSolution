namespace Behavior.Observer
{
    /// <summary>
    /// Defines a subject that can be observed by observers.
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        /// Attaches an observer to the subject.
        /// </summary>
        /// <param name="observer">The observer to attach.</param>
        void Attach(IObserver observer);

        /// <summary>
        /// Detaches an observer from the subject.
        /// </summary>
        /// <param name="observer">The observer to detach.</param>
        void Detach(IObserver observer);

        /// <summary>
        /// Notifies all attached observers of a state change.
        /// </summary>
        void Notify();
    }
}
