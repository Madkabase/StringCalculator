using Xunit;
using System;
using StringCalculator;

namespace TextCalculator.Tests
{
    public class TextCalculatorTests
    {
        private readonly StringCalculator.TextCalculator _calculator;

        public TextCalculatorTests()
        {
            _calculator = new StringCalculator.TextCalculator();
        }

        [Theory]
        [InlineData("", "0")]
        [InlineData("1", "1")]
        [InlineData("5,7", "12")]
        [InlineData("1.1,3.4", "4.5")]
        [InlineData("1,2,3,4,5", "15")]
        public void Add_ValidInput_ReturnsCorrectSum(string input, string expected)
        {
            Assert.Equal(expected, _calculator.Add(input));
        }

        [Fact]
        public void Add_MissingNumberInLastPosition_ThrowsInvalidOperationException()
        {
            var exception = Assert.Throws<InvalidOperationException>(() => _calculator.Add("1,3,"));
            Assert.Equal("Missing number in last position.", exception.Message);
        }

        [Fact]
        public void Add_SingleNegativeNumber_ThrowsInvalidOperationException()
        {
            var exception = Assert.Throws<InvalidOperationException>(() => _calculator.Add("-1,2"));
            Assert.Equal("Negative not allowed: -1", exception.Message);
        }

        [Fact]
        public void Add_MultipleNegativeNumbers_ThrowsInvalidOperationException()
        {
            var exception = Assert.Throws<InvalidOperationException>(() => _calculator.Add("7,-4,1,-5"));
            Assert.Equal("Negative not allowed: -4, -5", exception.Message);
        }

        [Fact]
        public void Add_InvalidNumberFormat_ThrowsInvalidOperationException()
        {
            var exception = Assert.Throws<InvalidOperationException>(() => _calculator.Add("1,a,3"));
            Assert.Equal("Invalid number format: a", exception.Message);
        }
    }
}