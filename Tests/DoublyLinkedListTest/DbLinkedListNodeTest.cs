using LinkedList.Doubly;

namespace DoublyLinkedListTest
{
    public class DbLinkedListNodeTest
    {
        [Fact]
        public void DbNode_Test()
        {
            // Arrange
            var node = new DbNode<int>();

            // Act
            node.Value = 1;                                 // 1
            node.Next = new DbNode<int> { Value = 2 };      // 2
            node.Next.Prev = node;
            node.Next.Next = new DbNode<int> { Value = 3};  // 3
            node.Next.Next.Prev = node.Next;

            // Assert
            Assert.Equal(1, node.Value);
            Assert.Equal(2, node.Next.Value);
            Assert.Equal(1, node.Next.Prev.Value);
            Assert.Equal(3, node.Next.Next.Value);
        }

        [Fact]
        public void DbNode_Test2()
        {
            // Arrange
            var node = new DbNode<char>('a');

            // Act
            node.Next = new DbNode<char>('b');
            node.Next.Prev = node;
            node.Next.Next = new DbNode<char>('c');
            node.Next.Next.Prev = node.Next;

            // Assert
            Assert.Equal('a', node.Value);
            Assert.Equal('b', node.Next.Value);
            Assert.Equal('a', node.Next.Prev.Value);

        }
    }
}