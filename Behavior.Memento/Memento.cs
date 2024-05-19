namespace Behavior.Memento
{
    /// <summary>
    /// Represents a memento object that stores the state of the originator.
    /// </summary>
    public class Memento
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Memento"/> class with the specified state.
        /// </summary>
        /// <param name="state">The state to store in the memento.</param>
        public Memento(string state)
        {
            State = state;
        }

        /// <summary>
        /// Gets the state stored in the memento.
        /// </summary>
        public string State { get; }
    }
}
