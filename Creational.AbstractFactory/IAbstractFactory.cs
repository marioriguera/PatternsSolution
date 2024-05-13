namespace Creational.AbstractFactory
{
    /// <summary>
    /// Represents an abstract factory interface.
    /// </summary>
    public interface IAbstractFactory
    {
        /// <summary>
        /// Creates an instance of Product A based on the provided type.
        /// </summary>
        /// <param name="type">The type of Product A to create.</param>
        /// <returns>An instance of Product A.</returns>
        IProductA CreateProductA(string type);

        /// <summary>
        /// Creates an instance of Product B based on the provided type.
        /// </summary>
        /// <param name="type">The type of Product B to create.</param>
        /// <returns>An instance of Product B.</returns>
        IProductB CreateProductB(string type);
    }
}
