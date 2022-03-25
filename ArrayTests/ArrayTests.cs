using DataStructures.Array;
using Xunit;

namespace ArrayTests
{
    public class ArrayTests
    {
        [Theory]
        [InlineData(16)]
        [InlineData(32)]
        [InlineData(64)]
        [InlineData(128)]
        [InlineData(256)]
        public void Check_Array_Constructor(int defaultSize)
        {
            // Arrange | Act
            var arr = new Array(defaultSize);

            // Assert
            Assert.Equal(defaultSize, arr.Length);
        }

        [Fact]
        public void Check_Array_Constructor_with_params()
        {
            // Arrange & Act
            var array = new DataStructures.Array.Array(1, 2, 3, 4, 5);
            // Assert
            Assert.Equal(5, array.Length);
        }

        [Fact]
        public void Get_and_Set_Values_in_Array()
        {
            // Arrange
            var array = new DataStructures.Array.Array();

            // Act
            array.SetValue(10, 0);
            array.SetValue(20, 1);

            // Assert
            Assert.Equal(10, array.GetValue(0));
            Assert.Equal(20, array.GetValue(1));
            Assert.Null(array.GetValue(2));
        }

        [Fact]
        public void Array_Clone_Test()
        {
            // arrange
            var array = new DataStructures.Array.Array(1, 2, 3);

            // act
            var clonedArray = array.Clone() as DataStructures.Array.Array;

            // Assert
            Assert.NotNull(clonedArray);
            Assert.Equal(array.Length, clonedArray.Length);
            Assert.NotEqual(array.GetHashCode(), clonedArray.GetHashCode());
        }

        [Fact]
        public void Array_GetEnumerator_Test()
        {
            // arrange 
            var array = new DataStructures.Array.Array(10, 20, 30);

            // act
            string s = "";
            foreach (var item in array)
            {
                s += item;
            }

            // assert
            Assert.Equal("102030", s);
        }



    }
}