namespace Creational.Prototype
{
    /// <summary>
    /// Represents a prototype interface for cloning objects.
    /// </summary>
    /// <typeparam name="T">The type of object to clone.</typeparam>
    public interface IPrototype<T>
    {
        /// <summary>
        /// Clones the object.
        /// </summary>
        /// <returns>A new instance of the cloned object.</returns>
        T Clone();
    }
}
