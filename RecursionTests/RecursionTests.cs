using Xunit;

namespace RecursionTests
{
    public class RecursionTests
    {
        [Theory]
        [InlineData(-1, 1)]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 6)]
        [InlineData(4, 24)]
        [InlineData(5, 120)]
        public void Factorial_Test(int input, int output)
        {
            // Act
            var result = Recursion.Math.Factorial(input);

            // Assert
            Assert.Equal(output, result);

        }

        [Theory]
        [InlineData(-1, 1)]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 6)]
        [InlineData(4, 24)]
        [InlineData(5, 120)]
        public void FactorialRecursion_Test(int input, int output)
        {
            // Act
            var result = Recursion.Math.FactorialRecursion(input);

            // Assert
            Assert.Equal(output, result);
        }
    }
}