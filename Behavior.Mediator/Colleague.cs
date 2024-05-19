namespace Behavior.Mediator
{
    /// <summary>
    /// Represents an abstract colleague.
    /// </summary>
    public abstract class Colleague
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Colleague"/> class with the specified mediator.
        /// </summary>
        /// <param name="mediator">The mediator to use for communication.</param>
        public Colleague(IMediator mediator)
        {
            Mediator = mediator;
        }

        /// <summary>
        /// Gets the mediator.
        /// </summary>
        protected IMediator Mediator { get; init; }

        /// <summary>
        /// Receives a message from the mediator.
        /// </summary>
        /// <param name="message">The message received.</param>
        public abstract void ReceiveMessage(string message);
    }
}
