using Structural.Composite.Component;

namespace Structural.Composite.Composite
{
    /// <summary>
    /// Represents a composite graphic that can contain child graphics.
    /// </summary>
    public class CompositeGraphic : Graphic
    {
        private readonly List<Graphic> _children = [];

        /// <summary>
        /// Adds a graphic to the composite.
        /// </summary>
        /// <param name="graphic">The graphic to add.</param>
        public void Add(Graphic graphic)
        {
            _children.Add(graphic);
        }

        /// <summary>
        /// Removes a graphic from the composite.
        /// </summary>
        /// <param name="graphic">The graphic to remove.</param>
        public void Remove(Graphic graphic)
        {
            _children.Remove(graphic);
        }

        /// <inheritdoc/>
        public override void Draw()
        {
            foreach (var child in _children)
            {
                child.Draw();
            }
        }
    }
}
