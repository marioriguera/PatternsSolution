namespace Creational.AbstractFactory
{
    /// <summary>
    /// Represents a concrete product of type B.
    /// </summary>
    public class ConcreteProductB1 : IProductB
    {
        /// <inheritdoc/>
        public void Operation()
        {
            Console.WriteLine("Operation from ConcreteProductB1");
        }
    }
}
