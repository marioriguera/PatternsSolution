namespace Structural.Proxy.UnitTests
{
    /// <summary>
    /// Unit tests for the Proxy pattern.
    /// </summary>
    public class ProxyTests
    {
        /// <summary>
        /// Tests that the proxy forwards requests to the real subject.
        /// </summary>
        [Fact]
        public void Request_ProxyForwardsRequestToRealSubject()
        {
            // Arrange
            var proxy = new Proxy();

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                proxy.Request();

                // Assert
                var result = sw.ToString().Trim();
                Assert.Contains("Proxy: Forwarding request to RealSubject.", result);
                Assert.Contains("RealSubject: Handling request.", result);
                Assert.Contains("Proxy: Request count: 1", result);
            }
        }

        /// <summary>
        /// Tests that the proxy keeps track of the number of requests.
        /// </summary>
        [Fact]
        public void Request_ProxyKeepsTrackOfRequestCount()
        {
            // Arrange
            var proxy = new Proxy();

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                proxy.Request();
                proxy.Request();

                // Assert
                var result = sw.ToString().Trim();
                Assert.Contains("Proxy: Request count: 1", result);
                Assert.Contains("Proxy: Request count: 2", result);
            }
        }
    }
}