namespace Behavior.Mediator
{
    /// <summary>
    /// Represents a concrete colleague B.
    /// </summary>
    public class ColleagueB : Colleague
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ColleagueB"/> class with the specified mediator.
        /// </summary>
        /// <param name="mediator">The mediator to use for communication.</param>
        public ColleagueB(IMediator mediator)
            : base(mediator)
        {
        }

        /// <inheritdoc/>
        public override void ReceiveMessage(string message)
        {
            Console.WriteLine("Colleague B received message: " + message);
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
