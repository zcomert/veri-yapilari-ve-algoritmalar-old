namespace CollectionTests
{
    public class ListTests
    {
        [Fact]
        public void Collection_Intersection_Test()
        {
            // Arrange
            var l1 = new List<int>() { 1, 3, 4, 5, 6 };
            var l2 = new List<int>() { 1, 3, 7 };
            
            // Act
            var list = l1
                .Intersect(l2)
                .ToList();
            

            // Assert
            Assert.Equal(2,list.Count);
        }


        [Fact]
        public void Collection_Union_Test()
        {
            // Arrange
            var list1 = new List<char>() { 'a', 'x', 'y', 'w' };
            var list2 = new List<char>() { 'b', 'w', 'z', 'a' };

            // Act
            var result = list1.Union(list2).ToList();

            // Assert
            Assert.Equal(6,result.Count);
            Assert.Collection<char>(result,
                    item => Assert.Equal('a', item),
                    item => Assert.Equal('x', item),
                    item => Assert.Equal('y', item),
                    item => Assert.Equal('w', item),
                    item => Assert.Equal('b', item),
                    item => Assert.Equal('z', item));

        }

        [Fact]
        public void Unique_Char_Set_Test()
        {
            // meltem -> melt
            // A
            var list = new List<char>() { 'm', 'e', 'l', 't', 'e', 'm' };
            var result = new List<char>();
            
            // Act
            foreach(var item in list)
            {
                if (!result.Contains(item))
                {
                    result.Add(item);
                }
            }

            // Assert
            Assert.Equal(4, result.Count);
            
            Assert.Collection<char>(result,
                item => Assert.Equal('m', item),
                item => Assert.Equal('e', item),
                item => Assert.Equal('l', item),
                item => Assert.Equal('t', item));
        }

        [Fact]
        public void Hash_Set_Test()
        {

            var list = new HashSet<char>("cerenyolur");

            Assert.Collection<char>(list, 
                item => Assert.Equal('c', item),
                item => Assert.Equal('e', item),
                item => Assert.Equal('r', item),
                item => Assert.Equal('n', item),
                item => Assert.Equal('y', item),
                item => Assert.Equal('o', item),
                item => Assert.Equal('l', item),
                item => Assert.Equal('u', item)
                );

        }
    }
}   