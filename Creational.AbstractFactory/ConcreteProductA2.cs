namespace Creational.AbstractFactory
{
    /// <summary>
    /// Represents a concrete product of type A.
    /// </summary>
    public class ConcreteProductA2 : IProductA
    {
        /// <inheritdoc/>
        public void Operation()
        {
            Console.WriteLine("Operation from ConcreteProductA2");
        }
    }
}
