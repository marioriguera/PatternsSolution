namespace Creational.Singleton.UnitTests
{
    /// <summary>
    /// Represents tests for the singleton pattern implementation.
    /// </summary>
    public class SingletonTests
    {
        /// <summary>
        /// Verifies that the GetInstance method returns the same instance.
        /// </summary>
        [Fact]
        public void GetInstance_ReturnsSameInstance()
        {
            // Arrange
            var instance1 = Singleton.GetInstance();
            var instance2 = Singleton.GetInstance();

            // Act & Assert
            Assert.Same(instance1, instance2); // Verify that they are the same instance
        }
    }
}