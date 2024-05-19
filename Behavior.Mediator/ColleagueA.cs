namespace Behavior.Mediator
{
    /// <summary>
    /// Represents a concrete colleague A.
    /// </summary>
    public class ColleagueA : Colleague
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ColleagueA"/> class with the specified mediator.
        /// </summary>
        /// <param name="mediator">The mediator to use for communication.</param>
        public ColleagueA(IMediator mediator)
            : base(mediator)
        {
        }

        /// <inheritdoc/>
        public override void ReceiveMessage(string message)
        {
            Console.WriteLine("Colleague A received message: " + message);
        }

        /// <summary>
        /// Sends a message through the mediator.
        /// </summary>
        /// <param name="message">The message to send.</param>
        public void SendMessage(string message)
        {
            Mediator.SendMessage(message, this);
        }
    }
}
