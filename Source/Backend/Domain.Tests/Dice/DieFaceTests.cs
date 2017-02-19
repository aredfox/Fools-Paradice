using Infrastructure;
using Xunit;


namespace Domain.Tests
{
    [Trait("Category", "Die")]
    public class DieFaceTests
    {
        [Fact]
        public void Returns_Correct_Value() {
            DieFaceGrids.Grids
                .ForEach(gridKvp => {
                    // Arrange
                    var sut = new DieFace(gridKvp.Value);
                    var expected = gridKvp.Key;
                    // Act
                    var actual = sut.Value;
                    // Assert
                    Assert.Equal(expected, actual);
                });
        }
    }
}