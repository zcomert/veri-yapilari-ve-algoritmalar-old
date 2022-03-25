using DataStructures.LinkedList.DoblyLinkedList;
using System;
using Xunit;

namespace LinkedListTests
{
    public class DoubyLinkedListTests
    {
        private DoublyLinkedList<char> _list;
        public DoubyLinkedListTests()
        {
            // a z
            _list = new DoublyLinkedList<char>(new char[] { 'a', 'z' });
        }

        [Theory]
        [InlineData('f')]
        [InlineData('e')]
        [InlineData('m')]
        [InlineData('o')]
        [InlineData('t')]
        public void AddFirst_Test(char value)
        {
            // f z a

            // act
            _list.AddFirst(value);

            // assert
            Assert.Equal(value, _list.Head.Value);
        }

        [Fact]
        public void Count_Test()
        {
            // act
            var count = _list.Count;

            // Assert
            Assert.Equal(2, count);
        }

        [Theory]
        [InlineData('ı')]
        [InlineData('a')]
        [InlineData('k')]
        [InlineData('e')]
        [InlineData('i')]
        public void AddLast_Test(char value)
        {
            // a z [value]
            // act
            _list.AddLast(value);
            var tailValue = _list.Tail.Value;

            // Assert
            Assert.Equal(value, tailValue);
            
            Assert.Collection(_list,
                item => Assert.Equal(item, 'a'),       // O(1)
                item => Assert.Equal(item, 'z'),       // O(n)
                item => Assert.Equal(item, value));    // O(1)
        }

        [Theory]
        [InlineData('k')]
        [InlineData('m')]
        [InlineData('n')]
        [InlineData('r')]
        [InlineData('s')]
        public void AddBefore_Test(char value)
        {
            // _list : a [value] z 
            // act
            _list.AddBefore(_list.Head.Next, value);

            // Assert
            Assert.Equal(value, _list.Head.Next.Value);
            
            Assert.Collection(_list,
                item => Assert.Equal(item, 'a'),
                item => Assert.Equal(item, value),
                item => Assert.Equal(item, 'z'));
        }

        [Fact]
        public void AddBefore_ArgumentException_Test()
        {
            DbNode<char> node = new DbNode<char>('x');
            //Assert
            Assert.Throws<ArgumentException>(() => 
            _list.AddBefore(node, node.Value));
        }

        [Theory]
        [InlineData('k')]
        [InlineData('m')]
        [InlineData('n')]
        [InlineData('r')]
        [InlineData('s')]
        public void AddAfter_Test(char value)
        {
            // _list : a,z
            // _list : a,z, value
            // act
            _list.AddAfter(_list.Head.Next, value);

            // Assert
            Assert.Equal(value, _list.Tail.Value);
            
            Assert.Collection(_list,
                item => Assert.Equal(item, _list.Head.Value),
                item => Assert.Equal(item, _list.Head.Next.Value),
                item => Assert.Equal(value, _list.Tail.Value));
        }

        [Fact]
        public void RemoveFirst_Test()
        {
            // a, z
            // z
            // Act
            _list.RemoveFirst();

            // Assert
            Assert.Collection(_list, item => Assert.Equal(item, 'z'));

        }

        [Fact]
        public void RemoveLast_Exception_Test()
        {
            // a, z
            // Act
            var r1 = _list.RemoveLast(); // z
            var r2 = _list.RemoveLast(); // a

            // Assert
            Assert.Equal(r1, 'z');
            Assert.Equal(r2, 'a');

            Assert.Throws<Exception>(() => _list.RemoveLast());
        }

        [Fact]
        public void Remove_Exception_Test()
        {
            // Act
            _list.Remove('a');
            _list.Remove('z');

            // Assert
            Assert.Throws<Exception>(() => _list.Remove('x'));
        }

        [Fact]
        public void ToList_Test()
        {
            // act
            var list = _list.ToList();

            // Assert
            Assert.Collection(list, 
                item => Assert.Equal(item, _list.Head.Value),
                item => Assert.Equal(item, _list.Head.Next.Value));
        }

    }
}
