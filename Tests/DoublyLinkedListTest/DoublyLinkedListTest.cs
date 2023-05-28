using LinkedList.Doubly;
using LinkedList.Singly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListTest
{
    public class DoublyLinkedListTest
    {
        [Fact]
        public void DbLinkedList_AddFirst_Test()
        {
            // Arrange
            var linkedList = new DoublyLinkedList<int>();

            // Act
            linkedList.AddFirst(1); // 1
            linkedList.AddFirst(2); // 2 1
            linkedList.AddFirst(3); // 3 2 1
            linkedList.AddFirst(4); // 4 3 2 1

            // Assert
            Assert.Equal(4, linkedList.Head.Value);
            Assert.Equal(3, linkedList.Head.Next.Value);
            Assert.Equal(2, linkedList.Tail.Prev.Value);
            Assert.Equal(1, linkedList.Tail.Value);
        }

        [Fact]
        public void DbLinkedList_AddLast_Test()
        {
            // Arrange
            var linkedList = new DoublyLinkedList<int>();

            // Act
            linkedList.AddLast(1); // 1
            linkedList.AddLast(2); // 1 2
            linkedList.AddLast(3); // 1 2 3
            linkedList.AddLast(4); // 1 2 3 4

            // Assert
            Assert.Equal(4, linkedList.Tail.Value);
            Assert.Equal(3, linkedList.Tail.Prev.Value);
            Assert.Equal(2, linkedList.Head.Next.Value);
            Assert.Equal(1, linkedList.Head.Value);
        }

        [Fact]
        public void DbLinkedList_RemoveFirst_Test()
        {
            // Arrange
            var linkedList = new DoublyLinkedList<int>();

            // Act
            linkedList.AddLast(1); // 1
            linkedList.AddLast(2); // 1 2
            linkedList.AddLast(3); // 1 2 3
            linkedList.AddLast(4); // 1 2 3 4

            var item1 = linkedList.RemoveFirst(); // 2 3 4
            var item2 = linkedList.RemoveFirst(); // 3 4
            var item3 = linkedList.RemoveFirst(); // 4
            var item4 = linkedList.RemoveFirst(); // null

            // Assert
            Assert.Equal(4, item4);
            Assert.Equal(3, item3);
            Assert.Equal(2, item2);
            Assert.Equal(1, item1);
        }

        [Fact]
        public void DbLinkedList_RemoveFirst_Exception_Test()
        {
            // Arrange
            var linkedList = new DoublyLinkedList<int>();

            // Act

            // Assert
            Assert.Throws<Exception>(() => linkedList.RemoveFirst());
        }


        [Fact]
        public void DbLinkedList_RemoveLast_Test()
        {
            // Arrange
            var linkedList = new DoublyLinkedList<int>();

            // Act
            linkedList.AddLast(1); // 1
            linkedList.AddLast(2); // 1 2
            linkedList.AddLast(3); // 1 2 3
            linkedList.AddLast(4); // 1 2 3 4

            var item1 = linkedList.RemoveLast(); // 1 2 3

            // Assert
            Assert.Equal(4, item1);
        }

        [Fact]
        public void DoubyLinkedList_Constructor_For_Input_Test()
        {
            // Arrange && Act
            var list = new DoublyLinkedList<int>(new int[] { 23, 16, 23, 55, 61, 23, 44 });

            // Assert
            // 44 23 61 55 23 16 23
            Assert.Collection<int>(list,
                item => Assert.Equal(23, item),
                item => Assert.Equal(16, item),
                item => Assert.Equal(23, item),
                item => Assert.Equal(55, item),
                item => Assert.Equal(61, item),
                item => Assert.Equal(23, item),
                item => Assert.Equal(44, item));
        }
    }
}
