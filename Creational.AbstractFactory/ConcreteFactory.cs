namespace Creational.AbstractFactory
{
    /// <summary>
    /// Represents a concrete factory implementation.
    /// </summary>
    public class ConcreteFactory : IAbstractFactory
    {
        /// <inheritdoc/>
        public IProductA CreateProductA(string type)
        {
            return type switch
            {
                "A1" => new ConcreteProductA1(),
                "A2" => new ConcreteProductA2(),
                _ => throw new ArgumentException("Invalid type for ProductA"),
            };
        }

        /// <inheritdoc/>
        public IProductB CreateProductB(string type)
        {
            return type switch
            {
                "B1" => new ConcreteProductB1(),
                "B2" => new ConcreteProductB2(),
                _ => throw new ArgumentException("Invalid type for ProductB"),
            };
        }
    }
}
