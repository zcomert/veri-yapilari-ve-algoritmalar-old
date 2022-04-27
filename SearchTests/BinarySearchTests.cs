using Search;
using Xunit;

namespace SearchTests
{
    public class BinarySearchTests
    {
        private int[] _arr;
        public BinarySearchTests()
        {
            _arr = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
        }

        [Theory]
        [InlineData(0, 10)]
        [InlineData(1, 20)]
        [InlineData(2, 30)]
        [InlineData(3, 40)]
        [InlineData(4, 50)]
        [InlineData(5, 60)]
        [InlineData(6, 70)]
        [InlineData(7, 80)]
        [InlineData(8, 90)]
        [InlineData(-1, 100)]
        public void BinarySearch_with_Iteration(int index, int value)
        {
            // Act
            var result = BinarySearch.Search(_arr, value);

            // Assert
            Assert.Equal(result, index);
            Assert.Equal(_arr[result], value);
        }
    }
}