using FibonacciCalculators;
using FluentAssertions;
using Xunit;

namespace FibonacciCalculatorTests
{
    public class IterativeCalculatorTests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        public void Compute_GivenSomeInputValue_ShouldReturnPreviousResult(uint inputValue, uint expectedResult)
        {
            //arrange
            IterativeCalculator calculator = new IterativeCalculator();

            //act
            uint result = calculator.Compute(inputValue);

            //assert
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(1, "0")]
        [InlineData(5, "0 1 1 2 3")]
        [InlineData(10, "0 1 1 2 3 5 8 13 21 34")]
        public void ComputeSequence_GivenSomeNumberOfResults_ShouldReturnTheCorrectFibonacciSequence(uint numberOfResults, string expectedResult)
        {
            //arrange
            IterativeCalculator calculator = new IterativeCalculator();

            //act
            string actualResult = calculator.ComputeSequence(numberOfResults);

            //assert
            actualResult.Should().Be(expectedResult);
        }
    }
}