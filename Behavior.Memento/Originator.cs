namespace Behavior.Memento
{
    /// <summary>
    /// Represents the originator that creates and restores mementos.
    /// </summary>
    public class Originator
    {
        private string _state = string.Empty;

        /// <summary>
        /// Gets or sets the state of the originator.
        /// </summary>
        public string State
        {
            get => _state;
            set
            {
                Console.WriteLine("Originator: Setting state to " + value);
                _state = value;
            }
        }

        /// <summary>
        /// Creates a memento containing the current state.
        /// </summary>
        /// <returns>The created memento.</returns>
        public Memento CreateMemento()
        {
            Console.WriteLine("Originator: Creating memento");
            return new Memento(_state);
        }

        /// <summary>
        /// Restores the state of the originator from a memento.
        /// </summary>
        /// <param name="memento">The memento containing the desired state.</param>
        public void RestoreMemento(Memento memento)
        {
            _state = memento.State;
            Console.WriteLine("Originator: Restoring state to " + _state);
        }
    }
}
