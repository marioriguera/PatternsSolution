namespace Behavior.Memento
{
    /// <summary>
    /// Represents the caretaker responsible for storing and retrieving mementos.
    /// </summary>
    public class Caretaker
    {
        private Memento? _memento;

        /// <summary>
        /// Saves a memento.
        /// </summary>
        /// <param name="memento">The memento to save.</param>
        public void SaveMemento(Memento memento)
        {
            _memento = memento;
        }

        /// <summary>
        /// Retrieves the saved memento.
        /// </summary>
        /// <returns>The saved memento.</returns>
        public Memento RetrieveMemento()
        {
            return _memento ?? throw new NullReferenceException($"Field {nameof(_memento)} can't be null.");
        }
    }
}
