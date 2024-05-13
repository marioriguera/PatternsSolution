namespace Creational.AbstractFactory
{
    /// <summary>
    /// Represents a concrete product of type B.
    /// </summary>
    public class ConcreteProductB2 : IProductB
    {
        /// <inheritdoc/>
        public void Operation()
        {
            /// <inheritdoc/>
            Console.WriteLine("Operation from ConcreteProductB2");
        }
    }
}
