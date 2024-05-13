namespace Creational.AbstractFactory
{
    /// <summary>
    /// Represents a concrete product of type A.
    /// </summary>
    public class ConcreteProductA1 : IProductA
    {
        /// <inheritdoc/>
        public void Operation()
        {
            Console.WriteLine("Operation from ConcreteProductA1");
        }
    }
}
