using Moq;
using Structural.Facade.Facade;
using Structural.Facade.Subsystems;

namespace Structural.Facade.UnitTests
{
    public class FacadeTests
    {
        [Fact]
        public void Start_CarFacade_CallsSubsystemMethodsInOrder()
        {
            // Arrange
            var engineMock = new Mock<IEngine>();
            var fuelInjectorMock = new Mock<IFuelInjector>();
            var ignitionMock = new Mock<IIgnition>();

            CarFacade car = new(engineMock.Object, fuelInjectorMock.Object, ignitionMock.Object);

            // Act
            car.Start();

            // Assert
            engineMock.Verify(e => e.Start(), Times.Once);
            fuelInjectorMock.Verify(f => f.On(), Times.Once);
            ignitionMock.Verify(i => i.Ignite(), Times.Once);
        }

        [Fact]
        public void Stop_CarFacade_CallsSubsystemMethodsInOrder()
        {
            // Arrange
            var engineMock = new Mock<IEngine>();
            var fuelInjectorMock = new Mock<IFuelInjector>();
            var ignitionMock = new Mock<IIgnition>();

            CarFacade car = new(engineMock.Object, fuelInjectorMock.Object, ignitionMock.Object);

            // Act
            car.Stop();

            // Assert
            engineMock.Verify(e => e.Stop(), Times.Once);
            fuelInjectorMock.Verify(f => f.Off(), Times.Once);
        }
    }
}