namespace Behavior.State
{
    /// <summary>
    /// Represents a concrete state that handles requests and transitions to ConcreteStateB.
    /// </summary>
    public class ConcreteStateA : IState
    {
        /// <inheritdoc/>
        public void Handle(Context context)
        {
            Console.WriteLine("Handling request in ConcreteStateA.");
            context.State = new ConcreteStateB();
        }
    }
}
