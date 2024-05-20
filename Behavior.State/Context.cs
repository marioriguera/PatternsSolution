namespace Behavior.State
{
    /// <summary>
    /// Represents the context in which states are managed and transitioned.
    /// </summary>
    public class Context
    {
        private IState? _state;

        /// <summary>
        /// Initializes a new instance of the <see cref="Context"/> class with the specified initial state.
        /// </summary>
        /// <param name="state">The initial state of the context.</param>
        public Context(IState state) => State = state;

        /// <summary>
        /// Gets or sets the current state of the context.
        /// </summary>
        public IState? State
        {
            get => _state;
            set
            {
                _state = value;
                Console.WriteLine($"State changed to {value?.GetType().Name}");
            }
        }

        /// <summary>
        /// Requests the current state to handle its behavior and possibly transition to another state.
        /// </summary>
        public void Request()
        {
            _state?.Handle(this);
        }
    }
}
