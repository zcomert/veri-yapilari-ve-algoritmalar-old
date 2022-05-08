using SortingAlgorithms;
using Xunit;

namespace SortingAlgorithmsTests
{
    public class BubbleSortTests
    {
        private int[] _array;
        public BubbleSortTests()
        {
            _array = new int[] { 10, 20, 50, 30, 40 };
        }

        [Fact]
        public void Bubble_Sort_Test()
        {
            // Act
            BubbleSort.Sort(_array);
            // Assert
            Assert.Collection(_array,
                item => Assert.Equal(10, _array[0]),
                item => Assert.Equal(20, _array[1]),
                item => Assert.Equal(30, _array[2]),
                item => Assert.Equal(40, _array[3]),
                item => Assert.Equal(50, _array[4])
            );
        }
    }
}