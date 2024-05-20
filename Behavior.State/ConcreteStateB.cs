namespace Behavior.State
{
    /// <summary>
    /// Represents a concrete state that handles requests and transitions to ConcreteStateA.
    /// </summary>
    public class ConcreteStateB : IState
    {
        /// <inheritdoc/>
        public void Handle(Context context)
        {
            Console.WriteLine("Handling request in ConcreteStateB.");
            context.State = new ConcreteStateA();
        }
    }
}
