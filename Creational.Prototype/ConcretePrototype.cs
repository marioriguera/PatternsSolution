namespace Creational.Prototype
{
    /// <summary>
    /// Represents a concrete prototype class that implements cloning functionality.
    /// </summary>
    public class ConcretePrototype : IPrototype<ConcretePrototype>
    {
        /// <summary>
        /// Gets or sets the identifier of the prototype.
        /// </summary>
        public int Id { get; set; }

        /// <inheritdoc/>
        public ConcretePrototype Clone()
        {
            return new ConcretePrototype { Id = Id };
        }
    }
}
