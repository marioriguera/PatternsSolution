namespace Creational.Builder
{
    /// <summary>
    /// Represents a builder interface for constructing products.
    /// </summary>
    public interface IBuilder
    {
        /// <summary>
        /// Builds the first part of the product.
        /// </summary>
        void BuildPart1();

        /// <summary>
        /// Builds the second part of the product.
        /// </summary>
        void BuildPart2();

        /// <summary>
        /// Builds the third part of the product.
        /// </summary>
        void BuildPart3();

        /// <summary>
        /// Gets the final result of the construction process.
        /// </summary>
        /// <returns>The constructed product.</returns>
        Product GetResult();
    }
}
