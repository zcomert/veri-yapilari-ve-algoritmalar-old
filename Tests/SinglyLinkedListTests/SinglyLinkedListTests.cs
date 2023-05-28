using LinkedList.Singly;

namespace SinglyLinkedListTests
{
    public class SinglyLinkedListTests
    {
        [Fact]
        public void SinglyLinkedList_AddFirst_Test()
        {
            // Arrange
            var linkedList = new SinglyLinkedList<int>();
            
            // Act
            linkedList.AddFirst(10);
            linkedList.AddFirst(20);
            linkedList.AddFirst(30);

            // Assert
            Assert.Equal(linkedList.Head.ToString(), "30");
            Assert.Equal(linkedList.Head.Next.Value, 20);
            Assert.Equal(linkedList.Head.Next.Next.Value, 10);

        }

        [Fact]
        public void SinglyLinkedList_AddLast_Test()
        {
            // Arrange
            var linkedList = new SinglyLinkedList<int>();

            // Act
            linkedList.AddLast(10);     // 10 
            linkedList.AddLast(20);     // 10 -> 20 
            linkedList.AddLast(30);     // 10 -> 20 -> 30

            // Assert
            Assert.Equal(linkedList.Head.ToString(), "10");
            Assert.Equal(linkedList.Head.Next.Value, 20);
            Assert.Equal(linkedList.Head.Next.Next.Value, 30);

        }

        [Fact]
        public void SinglyLinkedList_AddFirst_Test_2()
        {
            // arrange 
            var linkedList = new SinglyLinkedList<char>();
            
            // act
            linkedList.AddFirst('a');
            linkedList.AddFirst('b');
            linkedList.AddFirst('c');

            // assert
            Assert.Equal(linkedList.Head.Value, 'c');
            Assert.Equal(linkedList.Head.Next.Value, 'b');
            Assert.Equal(linkedList.Head.Next.Next.Value, 'a');
        }

        [Fact]
        public void SinglyLinkedList_AddLast_Test_2()
        {
            // arrange 
            var linkedList = new SinglyLinkedList<char>();

            // act
            linkedList.AddFirst('a');   // a
            linkedList.AddFirst('b');   // b - a
            linkedList.AddFirst('c');   // c - b - a
            linkedList.AddLast('x');    // c - b - a - x
            linkedList.AddLast('y');    // c - b - a - x - y
            linkedList.AddLast('z');    // c - b - a - x - y -z

            // assert
            Assert.Equal(linkedList.Head.Value, 'c');
            Assert.Equal(linkedList.Head.Next.Value, 'b');
            Assert.Equal(linkedList.Head.Next.Next.Value, 'a');
            Assert.Equal(linkedList.Head.Next.Next.Next.Value, 'x');
            Assert.Equal(linkedList.Head.Next.Next.Next.Next.Value, 'y');
            Assert.Equal(linkedList.Head.Next.Next.Next.Next.Next.Value, 'z');
        }


        [Fact]
        public void SinglyLinkedList_AddBefore_Test()
        {
            // arrange 
            var linkedList = new SinglyLinkedList<char>();
            linkedList.AddFirst('a');   // a
            linkedList.AddFirst('b');   // b - a
            linkedList.AddFirst('c');   // c - b - a

            linkedList.AddBefore(linkedList.Head.Next, 'x');  // c [x] b a
           

            // assert
            Assert.Equal(linkedList.Head.Value, 'c');
            Assert.Equal(linkedList.Head.Next.Value, 'x');
      
        }

        [Fact]
        public void SinglyLinkedList_AddBefore_Throw_ExceptionTest()
        {
            // arrange 
            var linkedList = new SinglyLinkedList<char>();
            linkedList.AddFirst('a');   // a
            linkedList.AddFirst('b');   // b - a
            linkedList.AddFirst('c');   // c - b - a

            var node = new SinglyLinkedListNode<char>('y');

            // assert
            Assert.Throws<Exception>(() => linkedList.AddBefore(node, 'x'));
        }

        /// <summary>
        /// Week 4 - AddAfter Test
        /// </summary>
        [Fact]
        public void SinglyLinkedList_AddAfter_Test()
        {
            // arrange 
            var linkedList = new SinglyLinkedList<char>();
            linkedList.AddFirst('a');   // a
            linkedList.AddFirst('b');   // b - a
            linkedList.AddFirst('c');   // c - b - a

            linkedList.AddAfter(linkedList.Head.Next, 'x');  // c b [x] a


            // assert
            Assert.Equal(linkedList.Head.Value, 'c');
            Assert.Equal(linkedList.Head.Next.Next.Value, 'x');

        }

        /// <summary>
        /// Week 4 - AddAfter Hata Firlatma Test
        /// </summary>
        [Fact]
        public void SinglyLinkedList_AddAfter_Throw_ExceptionTest()
        {
            // arrange 
            var linkedList = new SinglyLinkedList<char>();
            linkedList.AddFirst('a');   // a
            linkedList.AddFirst('b');   // b - a
            linkedList.AddFirst('c');   // c - b - a

            var node = new SinglyLinkedListNode<char>('y');

            // assert
            Assert.Throws<Exception>(() => linkedList.AddAfter(node, 'x'));
        }

        /// <summary>
        /// Week 4 - RemoveFirst Test
        /// </summary>
        [Fact]
        public void SinglyLinkedList_RemoveFirst_Test()
        {
            // arrange 
            var linkedList = new SinglyLinkedList<char>();
            linkedList.AddFirst('a');   // a
            linkedList.AddFirst('b');   // b - a
            linkedList.AddFirst('c');   // c - b - a

            var item = linkedList.RemoveFirst();  // b a


            // assert
            Assert.Equal('c', item);
            Assert.Equal('b', linkedList.Head.Value);
        }

        /// <summary>
        /// Week 4 - RemoveFirst Tek Eleman Test
        /// </summary>
        [Fact]
        public void SinglyLinkedList_RemoveFirst_One_Item_Test()
        {
            // arrange 
            var linkedList = new SinglyLinkedList<char>();
            linkedList.AddFirst('a');   // a

            var item = linkedList.RemoveFirst();  // null


            // assert
            Assert.Equal('a', item);
            Assert.True(linkedList.Head is null);
        }

        /// <summary>
        /// Week 4 - RemoveFirst Hata Firlatma Test
        /// </summary>
        [Fact]
        public void SinglyLinkedList_RemoveFirst_Exception_Test()
        {
            // arrange 
            var linkedList = new SinglyLinkedList<char>();

            // assert
            Assert.Throws<Exception>(() => linkedList.RemoveFirst());
        }

        /// <summary>
        /// Week 4 - RemoveLast Test
        /// </summary>
        [Fact]
        public void SinglyLinkedList_RemoveLast_Test()
        {
            // arrange 
            var linkedList = new SinglyLinkedList<char>();
            linkedList.AddFirst('a');   // a
            linkedList.AddFirst('b');   // b - a
            linkedList.AddFirst('c');   // c - b - a

            // act
            var item1 = linkedList.RemoveLast();
            var item2 = linkedList.RemoveLast();
            var item3 = linkedList.RemoveLast();

            // assert
            Assert.Equal('a', item1);
            Assert.Equal('b', item2);
            
            // -> Son eleman
            Assert.Equal('c', item3);
        }

        /// <summary>
        /// Week 4 - RemoveLast Hata Firlatma Test
        /// </summary>
        [Fact]
        public void SinglyLinkedList_RemoveLast_Exception_Test()
        {
            // arrange 
            var linkedList = new SinglyLinkedList<char>();

            // assert
            Assert.Throws<Exception>(() => linkedList.RemoveLast());
        }

        [Fact]
        public void SinglyLinkedList_Remove_LastItem_Test()
        {
            // arrange 
            var linkedList = new SinglyLinkedList<char>();
            linkedList.AddFirst('a');   // a
            linkedList.AddFirst('b');   // b - a
            linkedList.AddFirst('c');   // c - b - a

            var node = new SinglyLinkedListNode<char>('a');

            // act
            var item1 = linkedList.Remove(node);

            // assert
            Assert.Equal('a', item1);
        }

        [Fact]
        public void SinglyLinkedList_Remove_MiddleItem_Test()
        {
            // arrange 
            var linkedList = new SinglyLinkedList<char>();
            linkedList.AddFirst('a');   // a
            linkedList.AddFirst('b');   // b - a
            linkedList.AddFirst('c');   // c - b - a

            var node = new SinglyLinkedListNode<char>('b');

            // act
            var item1 = linkedList.Remove(node);

            // assert
            Assert.Equal('b', item1);
        }

        [Fact]
        public void SinglyLinkedList_Remove_FirstItem_Test()
        {
            // arrange 
            var linkedList = new SinglyLinkedList<char>();
            linkedList.AddFirst('a');   // a
            linkedList.AddFirst('b');   // b - a
            linkedList.AddFirst('c');   // c - b - a

            var node = new SinglyLinkedListNode<char>('c');

            // act
            var item1 = linkedList.Remove(node);

            // assert
            Assert.Equal('c', item1);
        }

        [Fact]
        public void SinglyLinkedList_Remove_Exception_Test()
        {
            // arrange 
            var linkedList = new SinglyLinkedList<char>();

            var node = new SinglyLinkedListNode<char>('b');

            // act

            // assert
            Assert.Throws<Exception>(()=> linkedList.Remove(node));
        }

        [Fact]
        public void SinglyLinkedList_Remove_Exception2_Test()
        {
            // arrange 
            var linkedList = new SinglyLinkedList<char>();
            linkedList.AddFirst('a');   // a
            linkedList.AddFirst('b');   // b - a
            linkedList.AddFirst('c');   // c - b - a

            var node = new SinglyLinkedListNode<char>('x');

            // act

            // assert
            Assert.Throws<Exception>(() => linkedList.Remove(node));
        }

        [Fact]
        public void SinglyLinkedList_Get_Enumerator_Test()
        {
            // Arrange && Act
            var list = new SinglyLinkedList<int>();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);

            Assert.Collection<int>(list,
                item => Assert.Equal(10, item),
                item => Assert.Equal(20, item),
                item => Assert.Equal(30, item));

        }


        [Fact]
        public void SinglyLinkedList_Constructor_For_Char_Array_Input_Test()
        {
            // Arrange && Act
            var list = new SinglyLinkedList<char>("meltem".ToArray());
          
            // Assert
            // m e t l e m 
            Assert.Collection<char>(list,
                item => Assert.Equal('m', item),
                item => Assert.Equal('e', item),
                item => Assert.Equal('t', item),
                item => Assert.Equal('l', item),
                item => Assert.Equal('e', item),
                item => Assert.Equal('m', item));
        }

        [Fact]
        public void SinglyLinkedList_Constructor_For_List_Input_Test()
        {
            // Arrange && Act
            var list = new SinglyLinkedList<int>(new List<int>() { 5,10,15,20});

            // Assert
            // 20 15 10 5
            Assert.Collection<int>(list,
                item => Assert.Equal(20, item),
                item => Assert.Equal(15, item),
                item => Assert.Equal(10, item),
                item => Assert.Equal(5, item));
        }

        [Fact]
        public void SinglyLinkedList_Constructor_For_SortedSet_Input_Test()
        {
            // Arrange && Act
            var list = new SinglyLinkedList<int>(new SortedSet<int>() { 23, 16, 23, 55, 61, 23, 44});

            // Assert
            // 16 23 23 44 55 61 
            // 61 55 44 23 16
            Assert.Collection<int>(list,
                item => Assert.Equal(61, item),
                item => Assert.Equal(55, item),
                item => Assert.Equal(44, item),
                item => Assert.Equal(23, item),
                item => Assert.Equal(16, item));
        }


    }
}