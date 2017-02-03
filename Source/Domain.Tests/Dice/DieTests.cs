using Infrastructure;
using System.Linq;
using Xunit;

namespace Domain.Tests
{
    public class DieTests
    {
        [Fact]
        public void Throws_OutOfRangeException_When_Not_Between_1_And_6() {
            // Arrange
            new int[] { -1, 0, 7, 100 }
                // Act            
                .ForEach(outOfRangeValue =>
                    // Assert
                    Assert.Throws<System.ArgumentOutOfRangeException>("value", () => {
                        new Die(outOfRangeValue);
                    })
                );
        }

        [Fact]
        public void Doesnt_Throw_OutOfRangeException_For_1_To_6() {
            // Arrange
            Enumerable.Range(1, 6)
                // Act            
                .ForEach(inRangeValue =>
                    // Assert
                    Assert.Equal(inRangeValue, new Die(inRangeValue).Value)
                );
        }
    }
}
