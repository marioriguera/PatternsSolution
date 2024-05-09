namespace Creational.FactoryMethod
{
    /// <summary>
    /// Represents a concrete implementation of Product A.
    /// </summary>
    public class ConcreteProductA : IProduct
    {
        /// <summary>
        /// Performs an operation specific to ConcreteProductA.
        /// </summary>
        public void Operation()
        {
            Console.WriteLine("Operation from ConcreteProductA");
        }
    }
}
