namespace Behavior.Mediator
{
    /// <summary>
    /// Represents a concrete mediator implementation.
    /// </summary>
    public class ConcreteMediator : IMediator
    {
        private ColleagueA? _colleagueA;
        private ColleagueB? _colleagueB;

        /// <summary>
        /// Sets the colleague A for the mediator.
        /// </summary>
        public ColleagueA ColleagueA
        {
            set { _colleagueA = value; }
        }

        /// <summary>
        /// Sets the colleague B for the mediator.
        /// </summary>
        public ColleagueB ColleagueB
        {
            set { _colleagueB = value; }
        }

        /// <inheritdoc/>
        public void SendMessage(string message, Colleague sender)
        {
            if (sender == _colleagueA)
            {
                _colleagueB?.ReceiveMessage(message);
            }
            else if (sender == _colleagueB)
            {
                _colleagueA?.ReceiveMessage(message);
            }
        }
    }
}
