using Domain.Algorithms.Implementations;
using Xunit;

namespace Domain.Tests.Algorithms.Implementations
{
    public class HighestNumberAlgorithmTest
    {
        [Fact]
        public void Returns_Highest_Number_From_Dice() {
            // Arrange
            var input = new Die[] {
                new Die(1), new Die(1), new Die(2),
                new Die(5), new Die(3), new Die(4)
            };
            var expected = 5;
            var sut = new HighestNumberAlgorithm();
            // Act
            var actual = sut.Execute(input).Value;
            // Assert
            Assert.Equal(actual, expected);
        }
    }
}
