namespace Creational.Builder
{
    /// <summary>
    /// Represents a product class with multiple parts.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or sets the first part of the product.
        /// </summary>
        public string Part1 { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the second part of the product.
        /// </summary>
        public string Part2 { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the third part of the product.
        /// </summary>
        public string Part3 { get; set; } = string.Empty;

        /// <summary>
        /// Displays information about the product.
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine($"Part 1: {Part1}");
            Console.WriteLine($"Part 2: {Part2}");
            Console.WriteLine($"Part 3: {Part3}");
        }
    }
}
