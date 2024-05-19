namespace Behavior.Observer
{
    /// <summary>
    /// Represents a concrete observer that receives updates from a subject.
    /// </summary>
    public class ConcreteObserver : IObserver
    {
        private string _observerState = string.Empty;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteObserver"/> class with the specified name.
        /// </summary>
        /// <param name="name">The name of the observer.</param>
        public ConcreteObserver(string name)
        {
            Name = name;
        }

        /// <inheritdoc/>
        public string Name { get; private set; } = string.Empty;

        /// <inheritdoc/>
        public void Update(string state)
        {
            _observerState = state;
            Console.WriteLine($"Observer {Name} updated with state: {_observerState}");
        }
    }
}
