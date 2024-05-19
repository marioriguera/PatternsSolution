using Behavior.Iterator.Aggregates;

namespace Behavior.Iterator.UnitTests
{
    /// <summary>
    /// Contains unit tests for the iterator pattern implementation.
    /// </summary>
    public class IteratorTests
    {
        /// <summary>
        /// Tests that the iterator iterates over all elements in the aggregate.
        /// </summary>
        [Fact]
        public void Iterator_ShouldIterateOverAllElements()
        {
            // Arrange
            int[] numbers = [1, 2, 3, 4, 5];
            var aggregate = new ConcreteAggregate<int>(numbers);
            var iterator = aggregate.CreateIterator();
            int expected = 1;

            // Act & Assert
            while (iterator.MoveNext())
            {
                Assert.Equal(expected, iterator.Current);
                expected++;
            }
        }

        /// <summary>
        /// Tests that the iterator does not move to the next element after reaching the last element.
        /// </summary>
        [Fact]
        public void Iterator_ShouldNotMoveNextAfterLastElement()
        {
            // Arrange
            int[] numbers = [1, 2, 3];
            var aggregate = new ConcreteAggregate<int>(numbers);
            var iterator = aggregate.CreateIterator();

            // Act
            while (iterator.MoveNext())
            {
            }

            // Assert
            Assert.False(iterator.MoveNext());
        }

        /// <summary>
        /// Tests that the current element of the iterator is the last element after the last MoveNext.
        /// </summary>
        [Fact]
        public void Iterator_Current_ShouldBeLastElementAfterLastMoveNext()
        {
            // Arrange
            int[] numbers = [1, 2, 3];
            var aggregate = new ConcreteAggregate<int>(numbers);
            var iterator = aggregate.CreateIterator();

            // Act
            while (iterator.MoveNext())
            {
            }

            // Assert
            Assert.Equal(3, iterator.Current);
        }
    }
}