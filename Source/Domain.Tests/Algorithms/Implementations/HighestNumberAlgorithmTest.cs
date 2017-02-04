using Domain.Algorithms.Implementations;
using Xunit;

namespace Domain.Tests.Algorithms.Implementations
{
    public class HighestNumberAlgorithmTest
    {
        [Fact]
        public void Returns_Highest_Number_From_Dice() {
            // Arrange
            var input = DiceSets.Create(1, 5, 2, 2, 3);
            var expected = 5;
            var sut = new HighestNumberAlgorithm();
            // Act
            var actual = sut.Execute(input).Value;
            // Assert
            Assert.Equal(actual, expected);
        }
    }
}
