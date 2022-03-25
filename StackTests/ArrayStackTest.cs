using DataStructures.Stack.Contracts;
using Xunit;

namespace StackTests
{
    public class ArrayStackTest
    {
        private readonly IStack<char> _stack;
        public ArrayStackTest()
        {
            _stack = new
                DataStructures
                .Stack
                .ArrayStack<char>(new char[] { 's', 'e', 'l', 'a', 'm' });
        }

        [Fact]
        public void Count_Test()
        {
            // act
            var count = _stack.Count;

            // Assert
            Assert.Equal(5, count);
        }

        [Fact]
        public void Pop_Test()
        {
            // act
            var pop = _stack.Pop();

            // Assert
            Assert.Equal('m', pop);
        }

        [Theory]
        [InlineData('m')]
        [InlineData('e')]
        [InlineData('r')]
        [InlineData('h')]
        [InlineData('a')]
        [InlineData('b')]
        [InlineData('a')]
        public void Push(char value)
        {
            // act
            _stack.Push(value);

            // Assert
            Assert.Equal(value, _stack.Peek());
        }
    }
}