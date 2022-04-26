using Xunit;

namespace SearchTests
{
    public class BinarySearchTest
    {
        [Theory]
        [InlineData(0, 10)]
        [InlineData(1, 20)]
        [InlineData(2, 30)]
        [InlineData(3, 40)]
        [InlineData(4, 50)]
        [InlineData(5, 60)]
        [InlineData(6, 70)]
        [InlineData(7, 80)]
        public void Binary_Search_Test(int index, int value)
        {
            var arr = new int[] { 10, 20, 30, 40, 50, 60, 70, 80 };
            int result = Search.BinarySearch.Search(arr, value);

            Assert.Equal(result, index);
            Assert.Equal(arr[result], value);
        }
    }
}