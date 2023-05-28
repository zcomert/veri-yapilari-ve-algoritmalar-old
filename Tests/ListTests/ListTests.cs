namespace ListTests
{
    public class ListTests
    {

        /// <summary>
        /// Week 3 - Add Test
        /// </summary>
        [Fact]
        public void List_Add_Test()
        {
            // Arrange
            List<int> list = new List<int>();

            // Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            int capacity = list.Capacity;

            // Assert
            Assert.Equal(8, capacity);
            Assert.Collection<int>(list,
                item => Assert.Equal(1, item),
                item => Assert.Equal(2, item),
                item => Assert.Equal(3, item),
                item => Assert.Equal(4, item),
                item => Assert.Equal(5, item)
                );
        }

        [Fact]
        public void List_AddRange_Test()
        {
            // Arrange
            List<int> list = new List<int>();
            int[] intList = new int[] { 1, 2, 3, 4, 5, 6 };

            // Act
            list.AddRange(intList);

            // Assert
            Assert.Collection<int>(list,
                item => Assert.Equal(1, item),
                item => Assert.Equal(2, item),
                item => Assert.Equal(3, item),
                item => Assert.Equal(4, item),
                item => Assert.Equal(5, item),
                item => Assert.Equal(6, item)
                );
        }

        [Fact]
        public void List_Remove_Test()
        {
            // Arrange
            List<int> list = new List<int>();
            int[] intList = new int[] { 1, 2, 3, 4, 5 };

            // Act
            list.AddRange(intList);

            bool test1 = list.Remove(2);
            bool _ = list.Remove(3);
            bool test2 = list.Remove(7);

            int capacity = list.Capacity;

            // Assert
            Assert.True(test1);
            Assert.True(!test2);
            Assert.Equal(5, capacity);
            Assert.Collection<int>(list,
                item => Assert.Equal(1, item),
                item => Assert.Equal(4, item),
                item => Assert.Equal(5, item));
        }

        [Fact]
        public void List_RemoveAt_Test()
        {
            // Arrange
            List<string> list = new List<string>();
            string[] stringList = new string[] { "Mehmet", "Ahmet", "Tekin", "Ali", "Naz" };

            // Act
            list.AddRange(stringList);

            list.RemoveAt(2);

            // Assert
            Assert.Collection<string>(list,
                item => Assert.Equal("Mehmet", item),
                item => Assert.Equal("Ahmet", item),
                item => Assert.Equal("Ali", item),
                item => Assert.Equal("Naz", item));
        }

        [Fact]
        public void List_Intersect_Test()
        {
            // Arrange
            List<string> list = new List<string>() { "Mehmet", "Ali", "Nursel", "Mert", "Emir" };
            string[] stringList = new string[] { "Mehmet", "Ahmet", "Tekin", "Ali", "Naz" };

            // Act
            string[] interList = list.Intersect(stringList).ToArray();

            // Assert
            Assert.Equal("Mehmet", interList[0]);
            Assert.Equal("Ali", interList[1]);
        }

        [Fact]
        public void List_Union_Test()
        {
            // Arrange
            List<string> list = new List<string>() { "Mehmet", "Ali", "Nursel", "Mert", "Emir" };
            string[] stringList = new string[] { "Mehmet", "Ahmet", "Tekin", "Ali", "Naz" };

            // Act
            string[] interList = list.Union(stringList).ToArray();

            // Assert
            Assert.Equal("Mehmet", interList[0]);
            Assert.Equal("Ali", interList[1]);
            Assert.Equal("Nursel", interList[2]);
            Assert.Equal("Mert", interList[3]);
            Assert.Equal("Emir", interList[4]);
            Assert.Equal("Ahmet", interList[5]);
            Assert.Equal("Tekin", interList[6]);
            Assert.Equal("Naz", interList[7]);
        }

        [Fact]
        public void List_Except_Test()
        {
            // Arrange
            List<string> list = new List<string>() { "Mehmet", "Ali", "Nursel", "Mert", "Emir" };
            string[] stringList = new string[] { "Mehmet", "Ahmet","Nursel", "Ali", "Mert" };

            // Act
            string[] interList = list.Except(stringList).ToArray();

            // Assert
            Assert.Equal("Emir", interList[0]);
        }
    }
}