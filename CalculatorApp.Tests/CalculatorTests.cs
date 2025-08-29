using CalculatorApp.Services;
using Xunit;

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange: Set up the test
            var calculator = new Calculator();
            int number1 = 5;
            int number2 = 10;
            int expected = 15;

            // Act: Run the method being tested
            int result = calculator.Add(number1, number2);

            // Assert: Verify the result is correct
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(0, 0, 0)]
        [InlineData(-5, 5, -10)]
        public void Subtract_ShouldReturnCorrectDifference(int a, int b, int expected)
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            int result = calculator.Subtract(a, b);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}