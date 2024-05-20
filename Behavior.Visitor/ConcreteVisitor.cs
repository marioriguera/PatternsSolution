namespace Behavior.Visitor
{
    /// <summary>
    /// Represents a concrete visitor that performs operations on elements of the object structure.
    /// </summary>
    public class ConcreteVisitor : IVisitor
    {
        /// <inheritdoc/>
        public void Visit(ConcreteElementA element)
        {
            Console.WriteLine($"ConcreteVisitor: Performing specific operation of ConcreteElementA: {ConcreteElementA.OperationA()}");
        }

        /// <inheritdoc/>
        public void Visit(ConcreteElementB element)
        {
            Console.WriteLine($"ConcreteVisitor: Performing specific operation of ConcreteElementB: {ConcreteElementB.OperationB()}");
        }
    }
}
