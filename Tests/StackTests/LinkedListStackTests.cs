using Stack;

namespace StackTests
{
    public class LinkedListStackTests
    {
        [Fact]
        public void LinkedListStack_Push_Test()
        {
            // arrange
            var stack = new LinkedListStack<int>();
            
            // act
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // Assert
            Assert.Equal(3, stack.Count);

        }

        [Fact]
        public void LinkedListStack_Pop_Test()
        {
            // arrange    3 2 1
            var stack = new LinkedListStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            var result = stack.Pop();

            // Assert
            Assert.Equal(2, stack.Count);
            Assert.Equal(3, result);
        }


        [Fact]
        public void LinkedListStack_Peek_Test()
        {
            // arrange    
            var stack = new LinkedListStack<string>();
            stack.Push("Ahmet");
            stack.Push("Fatma");
            stack.Push("Can");

            var result = stack.Peek();
           

            // Assert
            Assert.Equal(3, stack.Count);
            Assert.Equal("Can", result);

        }

        [Fact]
        public void LinkedListStack_Constructor_IEnumerable_Test()
        {
            // Arrange & Act
            var stack = new ArrayStack<int>(new List<int>() { 10, 20, 30 });

            // Assert
            Assert.Equal(stack.Count, 3);
            Assert.Equal(stack.Peek(), 30);
        }
    }
}