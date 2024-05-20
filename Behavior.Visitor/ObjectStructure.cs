namespace Behavior.Visitor
{
    /// <summary>
    /// Represents a collection of elements and provides methods to manage them.
    /// </summary>
    public class ObjectStructure
    {
        private readonly List<IElement> _elements = [];

        /// <summary>
        /// Attaches an element to the object structure.
        /// </summary>
        /// <param name="element">The element to attach.</param>
        public void Attach(IElement element)
        {
            _elements.Add(element);
        }

        /// <summary>
        /// Detaches an element from the object structure.
        /// </summary>
        /// <param name="element">The element to detach.</param>
        public void Detach(IElement element)
        {
            _elements.Remove(element);
        }

        /// <summary>
        /// Accepts a visitor and lets it visit each element in the object structure.
        /// </summary>
        /// <param name="visitor">The visitor to accept.</param>
        public void Accept(IVisitor visitor)
        {
            foreach (var element in _elements)
            {
                element.Accept(visitor);
            }
        }
    }
}
