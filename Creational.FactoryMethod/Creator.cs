namespace Creational.FactoryMethod
{
    /// <summary>
    /// Defines an abstract class for creators.
    /// </summary>
    public abstract class Creator
    {
        /// <summary>
        /// Defines the factory method to create products.
        /// </summary>
        /// <returns>A product created by the factory method.</returns>
        public abstract IProduct FactoryMethod();

        /// <summary>
        /// An operation performed by the creator.
        /// </summary>
        public void AnOperation()
        {
            // Use the factory method to create a product
            IProduct product = FactoryMethod();

            // Perform an operation on the product
            product.Operation();
        }
    }
}
