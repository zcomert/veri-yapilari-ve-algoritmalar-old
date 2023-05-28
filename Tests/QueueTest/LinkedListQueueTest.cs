using Queue;

namespace QueueTest
{
    public class LinkedListQueueTest
    {
        [Fact]
        public void QueueEnqueueTest()
        {
            // Arrange
            var queue = new LinkedListQueue<int>();

            // Act
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            // Assert
            Assert.Equal(5, queue.Count);
            Assert.Equal(1, queue.Peek());
        }

        [Fact]
        public void QueueDequeueTest()
        {
            // Arrange
            var queue = new LinkedListQueue<int>();

            // Act
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            // Assert
            Assert.Equal(5, queue.Count);
            Assert.Equal(1, queue.Dequeue());
            Assert.Equal(2, queue.Dequeue());
            Assert.Equal(3, queue.Dequeue());
            Assert.Equal(4, queue.Dequeue());
            Assert.Equal(5, queue.Dequeue());
        }

        [Fact]
        public void QueueDequeueExceptionTest()
        {
            // Arrange
            var queue = new LinkedListQueue<int>();

            // Act


            // Assert
            Assert.Throws<Exception>(() => queue.Dequeue());
        }
    }
}