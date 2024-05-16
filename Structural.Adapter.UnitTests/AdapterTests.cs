namespace Structural.Adapter.UnitTests
{
    /// <summary>
    /// Represents tests for the adapter pattern implementation.
    /// </summary>
    public class AdapterTests
    {
        /// <summary>
        /// Verifies that the adapter transforms the specific request to the expected format.
        /// </summary>
        [Fact]
        public void Adapter_TransformsRequestToStringMessageCorrectly()
        {
            // Arrange
            Adaptee adaptee = new();
            ITarget adapter = new Adapter(adaptee);

            // Act
            string result = adapter.GetRequest();

            // Assert
            Assert.Equal("This is the id: 154 .", result);
        }
    }
}