namespace Behavior.Visitor
{
    /// <summary>
    /// Represents an element in the object structure that can accept a visitor.
    /// </summary>
    public interface IElement
    {
        /// <summary>
        /// Accepts a visitor and allows it to perform operations on this element.
        /// </summary>
        /// <param name="visitor">The visitor to accept.</param>
        void Accept(IVisitor visitor);
    }
}
