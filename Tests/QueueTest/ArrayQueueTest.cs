using Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueTest
{
    public class ArrayQueueTest
    {
        [Fact]
        public void ArrayQueue_Enqueue_Test()
        {
            // Arrange
            var queue = new ArrayQueue<char>("Mehmet"); // {'M', 'e', 'h', 'm', 'e', 't'}

            // Act
            queue.Enqueue('A');

            // Assert
            Assert.Equal(7, queue.Count);
        }

        [Fact]
        public void ArrayQueue_Dequeue_Test()
        {
            // Arrange
            var queue = new ArrayQueue<char>("Mehmet"); // {'M', 'e', 'h', 'm', 'e', 't'}

            // Act
            var item = queue.Dequeue(); // 'M'

            // Assert
            Assert.Equal(5, queue.Count);
            Assert.Equal('M', item);
        }

        [Fact]
        public void ArrayQueue_Dequeue_Exception_Test()
        {
            // Arrange
            var queue = new ArrayQueue<char>(); // {'M', 'e', 'h', 'm', 'e', 't'}

            // Act

            // Assert
            Assert.Throws<Exception>(() => queue.Dequeue());
        }

        [Fact]
        public void ArrayQueue_Peek_Test()
        {
            // Arrange
            var queue = new ArrayQueue<char>("Mehmet"); // {'M', 'e', 'h', 'm', 'e', 't'}

            // Act
            var item = queue.Peek();

            // Assert
            Assert.Equal('M', item);
        }
    }
}
