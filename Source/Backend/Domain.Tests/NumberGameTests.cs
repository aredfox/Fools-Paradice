using Domain.Algorithms;
using Infrastructure;
using System.Linq;
using Xunit;

namespace Domain.Tests
{
    public class NumberGameTests
    {
        [Fact]
        public void Saves_A_Round() {
            // Arrange
            var sut = new NumberGame();
            Die[] expectedInput = null;
            // Act            
            var expectedValue = sut.Round(expectedInput);
            var actual = sut.Rounds.ElementAt(0);
            // Assert
            Assert.Equal(expectedValue, actual.Item1);
            Assert.Equal(expectedInput, actual.Item2);

        }

        [Fact]
        public void SelectAlgorithm_Returns_Object_Of_Type_AlgorithmOfInt() {
            // Arrange    
            var sut = new NumberGame();
            Enumerable.Range(1, 20)
                .ForEach(_ => {
                    // Act                    
                    var actual = sut.SelectAlgorithm();
                    // Assert
                    Assert.True(actual != null, "Returned null, expected an object.");
                    Assert.IsAssignableFrom<Algorithm<int>>(actual);
                }
            );
        }
    }
}
