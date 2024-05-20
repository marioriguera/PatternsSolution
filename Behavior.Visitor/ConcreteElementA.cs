namespace Behavior.Visitor
{
    /// <summary>
    /// Represents a concrete element that implements the <see cref="IElement"/> interface.
    /// </summary>
    public class ConcreteElementA : IElement
    {
        /// <summary>
        /// Performs a specific operation for ConcreteElementA.
        /// </summary>
        /// <returns>The result of the operation.</returns>
        public static string OperationA()
        {
            return "Specific operation of ConcreteElementA";
        }

        /// <inheritdoc/>
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
