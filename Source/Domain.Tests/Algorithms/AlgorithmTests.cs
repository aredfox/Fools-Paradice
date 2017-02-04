using Domain.Algorithms;
using Infrastructure;
using System;
using System.Collections.Generic;
using Xunit;

namespace Domain.Tests.Algorithms
{
    public class AlgorithmTests
    {
        class TestInt32Algorithm : Algorithm<int>
        {
            public TestInt32Algorithm(int min = 1, int max = 6) : base(min, max) { }

            protected override AlgorithmResult<int> PerformAlgorithm(IEnumerable<Die> dice) {
                return new AlgorithmResult<int>(0);
            }
        }

        [Fact]
        public void Throws_Exception_When_Minimum_Range_Is_Lower_Than_One() {
            // Arrange
            var minimumRangesLowerThanOne = new int[] { -100, -1, 0, };
            // Act
            minimumRangesLowerThanOne.ForEach(
                minimumRangeValue => {
                    // Assert
                    Assert.Throws<ArgumentOutOfRangeException>(
                        () => {
                            new TestInt32Algorithm(min: minimumRangeValue);
                        }
                    );
                }
            );
        }

        [Fact]
        public void Returns_AlgorithmErrorResult_When_Input_Is_Null() {
            // Arrange
            var expected = new AlgorithmErrorResult<int>("Amount of dice is 0, expected to be between 1 and 6.");
            // Act
            var sut = new TestInt32Algorithm();
            var actual = sut.Execute(null);
            // Assert
            Assert.Equal(expected.Value, actual.Value);
            Assert.Equal(expected.HasError, actual.HasError);
            Assert.Equal(expected.ErrorMessage, actual.ErrorMessage);
        }

        [Fact]
        public void Returns_AlgorithmErrorResult_When_Input_Is_NotInRange() {
            // Arrange            
            var expected = new AlgorithmErrorResult<int>("Amount of dice is 2, expected to be between 1 and 1.");
            // Act
            var sut = new TestInt32Algorithm(1, 1);
            var actual = sut.Execute(new Die[] { new Die(), new Die() });
            // Assert
            Assert.Equal(expected.Value, actual.Value);
            Assert.Equal(expected.HasError, actual.HasError);
            Assert.Equal(expected.ErrorMessage, actual.ErrorMessage);
        }

        [Fact]
        public void Returns_AlgorithmResult() {
            // Arrange            
            var expected = new AlgorithmResult<int>(0);
            // Act
            var sut = new TestInt32Algorithm(1, 1);
            var actual = sut.Execute(new Die[] { new Die() });
            // Assert
            Assert.Equal(expected.Value, actual.Value);
            Assert.Equal(expected.HasError, actual.HasError);
            Assert.Equal(expected.ErrorMessage, actual.ErrorMessage);
        }
    }
}
