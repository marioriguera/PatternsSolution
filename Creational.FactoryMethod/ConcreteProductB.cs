namespace Creational.FactoryMethod
{
    /// <summary>
    /// Represents a concrete product of type B.
    /// </summary>
    public class ConcreteProductB : IProduct
    {
        /// <summary>
        /// Performs an operation specific to ConcreteProductB.
        /// </summary>
        public void Operation()
        {
            Console.WriteLine("Operation from ConcreteProductB");
        }
    }
}
