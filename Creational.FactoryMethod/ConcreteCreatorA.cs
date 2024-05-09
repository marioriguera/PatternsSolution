namespace Creational.FactoryMethod
{
    /// <summary>
    /// Represents a concrete creator of type A.
    /// </summary>
    public class ConcreteCreatorA : Creator
    {
        /// <summary>
        /// Creates a concrete product of type A.
        /// </summary>
        /// <returns>A new instance of ConcreteProductA.</returns>
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }
}
