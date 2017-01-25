using System;
using System.Collections.Generic;
using FibonacciCalculators;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace FibonacciCalculatorTests
{
    public class RecursiveCalculatorTests
    {
        private readonly ITestOutputHelper _output;

        public RecursiveCalculatorTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Theory]
        [InlineData(1, "0")]
        [InlineData(5, "0 1 1 2 3")]
        [InlineData(10, "0 1 1 2 3 5 8 13 21 34")]
        public void ComputeSequence_GivenAnInputOfTen_ShouldReturnTheCorrectSequence(uint numberOfResults, string expectedSequence)
        {
            //arrange
            RecursiveCalculator calculator = new RecursiveCalculator();
            uint a = 0;
            uint b = 1;
            uint counter = 1;
            uint number = numberOfResults;

            //act
            string actualSequence = calculator.ComputeSequence(a, b, counter, number);

            //assert
            actualSequence.Should().Be(expectedSequence);
        }
    }
}
