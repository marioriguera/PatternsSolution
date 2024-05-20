namespace Behavior.Strategy
{
    /// <summary>
    /// Represents a concrete strategy A implementation.
    /// </summary>
    public class ConcreteStrategyA : IStrategy
    {
        /// <inheritdoc/>
        public void Execute()
        {
            Console.WriteLine("Executing ConcreteStrategyA.");
        }
    }
}
