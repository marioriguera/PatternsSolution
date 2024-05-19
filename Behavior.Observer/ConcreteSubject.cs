namespace Behavior.Observer
{
    /// <summary>
    /// Represents a concrete subject that maintains a list of observers and notifies them of state changes.
    /// </summary>
    public class ConcreteSubject : ISubject
    {
        private string _state = string.Empty;

        /// <summary>
        /// Gets or sets the state of the subject.
        /// Setting the state will notify all attached observers.
        /// </summary>
        public string State
        {
            get => _state;
            set
            {
                _state = value;
                Notify();
            }
        }

        /// <summary>
        /// Gets array of observers.
        /// </summary>
        public List<IObserver> Observers { get; private set; } = [];

        /// <inheritdoc/>
        public void Attach(IObserver observer)
        {
            Observers.Add(observer);
        }

        /// <inheritdoc/>
        public void Detach(IObserver observer)
        {
            Observers.Remove(observer);
        }

        /// <inheritdoc/>
        public void Notify()
        {
            foreach (var observer in Observers)
            {
                observer.Update(_state);
            }
        }
    }
}
