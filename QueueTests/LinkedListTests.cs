using DataStructures.Queue;
using Xunit;

namespace QueueTests
{
    public class LinkedListQueueTests
    {
        private LinkedListQueue<int> _queue;
        public LinkedListQueueTests()
        {
            _queue = new LinkedListQueue<int>(new int[] { 10, 20, 30 });
        }

        [Fact]
        public void Count_Test()
        {
            // act
            var count = _queue.Count;

            // Assert
            Assert.Equal(3, count);
        }

        [Theory]
        [InlineData(23)]
        [InlineData(44)]
        [InlineData(66)]
        [InlineData(61)]
        [InlineData(55)]
        public void Enqueue(int value)
        {
            // 10 20 30 [value]
            // act
            _queue.Enqueue(value);

            Assert.Equal(4, _queue.Count);
            Assert.Collection(_queue,
                item => Assert.Equal(10, item),
                item => Assert.Equal(20, item),
                item => Assert.Equal(30, item),
                item => Assert.Equal(value, item));
        }

        [Fact]
        public void Dequeue_Test()
        {
            // act
            // [10] 20 30
            var dequeue = _queue.Dequeue();

            Assert.Equal(2, _queue.Count);
            Assert.Collection(_queue,
                item => Assert.Equal(20, item),
                item => Assert.Equal(30, item));
            Assert.Equal(10, dequeue);
        }

        [Fact]
        public void Peek_Test()
        {
            // [10] 20 30 
            // act
            var peek = _queue.Peek();

            Assert.Equal(3, _queue.Count);
            Assert.Equal(10, peek);
        }

        [Fact]
        public void Dequue_EmptyQueueException_Test()
        {
            // act
            _queue.Dequeue();
            _queue.Dequeue();
            _queue.Dequeue();

            // Assert
            Assert.Throws<EmptyQueueException>(() => _queue.Dequeue());
        }
    }
}
