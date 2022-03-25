using DataStructures.Array.Generic;
using System.Collections.Generic;
using Xunit;

namespace ArrayTests
{
    public class GenericArrayTest
    {
        private Array<char> _array;
        public GenericArrayTest()
        {
            // arrange
            _array = new Array<char>(new List<char> {'s','a','m','u'});
        }

        [Theory]
        [InlineData(16)]
        [InlineData(32)]
        [InlineData(64)]
        [InlineData(128)]
        [InlineData(256)]
        public void DefaultSize_Test(int defaultSize)
        {
            // act
            var arr  = new Array<char>(defaultSize);

            // Assert
            Assert.Equal(arr.Length, defaultSize);
        }

        [Fact]
        public void Params_Test()
        {
            // arrange - act
            var arr = new Array<int>(1, 2, 3, 4);

            // assert
            Assert.Equal(4, arr.Length);
        }

        [Fact]
        public void GetValue_Test()
        {
            // act
            var c = _array.GetValue(0);

            // Assert
            Assert.Equal('s', c);
            Assert.IsType<char>(c);
            Assert.True(c is char);
            Assert.IsType(typeof(char), c);
        }

        [Fact]
        public void SetValue_Test()
        {
            // Act
            _array.SetValue('S', 0);

            // Assert
            Assert.Equal('S', _array.GetValue(0));
        }
    }
}
