namespace Creational.FactoryMethod
{
    /// <summary>
    /// Represents a concrete creator of type B.
    /// </summary>
    public class ConcreteCreatorB : Creator
    {
        /// <summary>
        /// Creates a concrete product of type B.
        /// </summary>
        /// <returns>A new instance of ConcreteProductB.</returns>
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}
