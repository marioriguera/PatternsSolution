namespace Creational.Builder
{
    /// <summary>
    /// Represents a director class that oversees the construction process.
    /// </summary>
    public class Director
    {
        private readonly IBuilder _builder;

        /// <summary>
        /// Initializes a new instance of the <see cref="Director"/> class with the specified builder.
        /// </summary>
        /// <param name="builder">The builder to use for construction.</param>
        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        /// <summary>
        /// Constructs a product using the specified builder.
        /// </summary>
        public void Construct()
        {
            _builder.BuildPart1();
            _builder.BuildPart2();
            _builder.BuildPart3();
        }
    }
}
