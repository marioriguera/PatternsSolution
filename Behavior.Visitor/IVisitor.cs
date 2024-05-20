namespace Behavior.Visitor
{
    /// <summary>
    /// Defines an interface for visiting concrete elements in an object structure.
    /// </summary>
    public interface IVisitor
    {
        /// <summary>
        /// Visit method for ConcreteElementA.
        /// </summary>
        /// <param name="element">The ConcreteElementA to visit.</param>
        void Visit(ConcreteElementA element);

        /// <summary>
        /// Visit method for ConcreteElementB.
        /// </summary>
        /// <param name="element">The ConcreteElementB to visit.</param>
        void Visit(ConcreteElementB element);
    }
}
