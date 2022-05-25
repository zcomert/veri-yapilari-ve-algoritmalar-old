using DataStructures.PriorityQueue;
using PriorityQueue;
using Xunit;

namespace PriorityQueueTests
{
    public class MinHeapTests
    {
        private BHeap<int> minHeap { get; set; }

        public MinHeapTests()
        {
            // Arrange
            minHeap = new MinHeap<int>(new int[] { 1, 2, 3, 4, 5, 6 });
        }

        [Fact]
        public void Count_Test()
        {
            //       1
            //     /  \
            //    2    3
            //   / \  / 
            //  4  5 6

            // Act
            var count = minHeap.Count;
            Assert.Equal(6, count);
        }

        [Fact]
        public void GetEnumerator_Test()
        {
            //       1
            //     /  \
            //    2    3
            //   / \  / 
            //  4  5 6

            // Act
            Assert.Collection(minHeap,
                item => Assert.Equal(1, item),
                item => Assert.Equal(2, item),
                item => Assert.Equal(3, item),
                item => Assert.Equal(4, item),
                item => Assert.Equal(5, item),
                item => Assert.Equal(6, item));
        }
        [Theory]
        [InlineData(0, 2)]
        [InlineData(1, 4)]
        [InlineData(2, 6)]
        [InlineData(3, 8)]
        [InlineData(4, 10)]

        public void GetRightChildIndex_Test(int index, int GetRightIndex)
        {
            //arrange
            var temp = new MaxHeap<int>().GetRightChildIndex(index);
            //assert
            Assert.Equal(GetRightIndex, temp);
        }

        [Theory]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        [InlineData(15)]
        public void Add_Test(int value)
        {
            //       1
            //     /  \
            //    2    3
            //   / \  / \
            //  4  5 6  [value]

            // Act
            minHeap = new MinHeap<int>(new int[] { 1, 2, 3, 4, 5, 6, value });
            Assert.Collection(minHeap,
                item => Assert.Equal(1, item),
                item => Assert.Equal(2, item),
                item => Assert.Equal(3, item),
                item => Assert.Equal(4, item),
                item => Assert.Equal(5, item),
                item => Assert.Equal(6, item),
                item => Assert.Equal(value, item));

            Assert.Equal(value, minHeap.Array.GetValue(minHeap.Count - 1));
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void HeapifyUp_Test(int value)
        {
            //      10
            //     /  \
            //    20   30
            //   / \   / \
            //  40 50 60  [value]


            //      10
            //     /  \
            //    20  [value]
            //   / \   / \
            //  40 50 60 [30]


            //    [value]
            //     /  \
            //    20  [10]
            //   / \   / \
            //  40 50 60  [30]

            // Act
            minHeap = new MinHeap<int>(new int[] { 10, 20, 30, 40, 50, 60, value });

            Assert.Collection(minHeap,
                item => Assert.Equal(value, item),
                item => Assert.Equal(20, item),
                item => Assert.Equal(10, item),
                item => Assert.Equal(40, item),
                item => Assert.Equal(50, item),
                item => Assert.Equal(60, item),
                item => Assert.Equal(30, item));

            Assert.Equal(value, minHeap.Array.GetValue(0));
        }

        [Theory]
        [InlineData(70)]
        [InlineData(80)]
        [InlineData(90)]
        [InlineData(95)]
        [InlineData(99)]
        public void Remove_Test(int value)
        {
            //      10
            //     /  \
            //    20   30
            //   / \   / \
            //  40 50 60 [value]


            //    [value]
            //     /  \
            //    20   30
            //   / \   / 
            //  40 50 60 


            //      20
            //     /  \
            // [value] 30
            //   / \   / 
            //  40 50 60 


            //      20
            //     /  \
            //    40   30
            //   / \   / 
            // [v] 50 60 


            // Act
            minHeap = new MinHeap<int>(new int[] { 10, 20, 30, 40, 50, 60, value });
            var removedItem = minHeap.DeleteMinMax();

            Assert.Collection(minHeap,
                item => Assert.Equal(20, item),
                item => Assert.Equal(40, item),
                item => Assert.Equal(30, item),
                item => Assert.Equal(value, item),
                item => Assert.Equal(50, item),
                item => Assert.Equal(60, item));

            Assert.Equal(10, removedItem);
        }
    }
}