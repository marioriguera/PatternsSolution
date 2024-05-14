namespace Creational.Builder
{
    /// <summary>
    /// Represents a concrete builder class that constructs products.
    /// </summary>
    public class ConcreteBuilder : IBuilder
    {
        private readonly Product _product = new();

        /// <inheritdoc/>
        public void BuildPart1()
        {
            _product.Part1 = "Part 1 built";
        }

        /// <inheritdoc/>
        public void BuildPart2()
        {
            _product.Part2 = "Part 2 built";
        }

        /// <inheritdoc/>
        public void BuildPart3()
        {
            _product.Part3 = "Part 3 built";
        }

        /// <inheritdoc/>
        public Product GetResult()
        {
            return _product;
        }
    }
}
