namespace Behavior.Strategy
{
    /// <summary>
    /// Represents a concrete strategy B implementation.
    /// </summary>
    public class ConcreteStrategyB : IStrategy
    {
        /// <inheritdoc/>
        public void Execute()
        {
            Console.WriteLine("Executing ConcreteStrategyB.");
        }
    }
}
