using Domain.Algorithms.Implementations.OperateOnNumbers;
using Xunit;

namespace Domain.Tests.Algorithms.Implementations
{
    public class OperateOnNumbersAlgorithmTest
    {
        [Fact]
        public void HighestNumber_Returns_Correct_Value() {
            // Arrange
            var input = DiceSets.Create(4, 1, 3, 2, 4);
            var expected = 4;
            var sut = new HighestNumberAlgorithm();
            // Act
            var actual = sut.Execute(input).Value;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LowesttNumber_Returns_Correct_Value() {
            // Arrange
            var input = DiceSets.Create(4, 1, 3, 2, 4);
            var expected = 1;
            var sut = new LowestNumberAlgorithm();
            // Act
            var actual = sut.Execute(input).Value;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddEvenNumbers_Returns_Correct_Value() {
            // Arrange
            var input = DiceSets.Create(4, 1, 3, 2, 4);
            var expected = 10;
            var sut = new AddEvenNumbersAlgorithm();
            // Act
            var actual = sut.Execute(input).Value;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SubtractEvenNumbers_Returns_Correct_Value() {
            // Arrange
            var input = DiceSets.Create(4, 1, 3, 2, 4);
            var expected = -10;
            var sut = new SubtractEvenNumbersAlgorithm();
            // Act
            var actual = sut.Execute(input).Value;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddOddNumbers_Returns_Correct_Value() {
            // Arrange
            var input = DiceSets.Create(4, 1, 3, 2, 4);
            var expected = 4;
            var sut = new AddOddNumbersAlgorithm();
            // Act
            var actual = sut.Execute(input).Value;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SubtractOddNumbers_Returns_Correct_Value() {
            // Arrange
            var input = DiceSets.Create(4, 1, 3, 2, 4);
            var expected = -4;
            var sut = new SubtractOddNumbersAlgorithm();
            // Act
            var actual = sut.Execute(input).Value;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddNumbersWithCenterDot_Returns_Correct_Value() {
            // Arrange
            var input = DiceSets.Create(4, 1, 3, 2, 4);
            var expected = 4;
            var sut = new AddNumbersWithCenterDotAlgorithm();
            // Act
            var actual = sut.Execute(input).Value;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddNumbersAroundCenterDot_Returns_Correct_Value() {
            // Arrange
            var input = DiceSets.Create(4, 1, 3, 2, 4);
            var expected = 2;
            var sut = new AddNumbersAroundCenterDotAlgorithm();
            // Act
            var actual = sut.Execute(input).Value;
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
