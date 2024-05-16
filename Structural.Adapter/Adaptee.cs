namespace Structural.Adapter
{
    /// <summary>
    /// Represents the class with a specific id that needs to be adapted.
    /// Existing class with an incompatible interface.
    /// </summary>
    public class Adaptee
    {
        private readonly int _id = 154;

        /// <summary>
        /// Gets the specific id.
        /// </summary>
        /// <returns>A int representing the specific id.</returns>
        public int GetSpecificId()
        {
            return _id;
        }
    }
}
