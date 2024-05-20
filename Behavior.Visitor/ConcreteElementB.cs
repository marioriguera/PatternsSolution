namespace Behavior.Visitor
{
    /// <summary>
    /// Represents a concrete element that implements the <see cref="IElement"/> interface.
    /// </summary>
    public class ConcreteElementB : IElement
    {
        /// <summary>
        /// Performs a specific operation for ConcreteElementB.
        /// </summary>
        /// <returns>The result of the operation.</returns>
        public static string OperationB()
        {
            return "Specific operation of ConcreteElementB";
        }

        /// <inheritdoc/>
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
