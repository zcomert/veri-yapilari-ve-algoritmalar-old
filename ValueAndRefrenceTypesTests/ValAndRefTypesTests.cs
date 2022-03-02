using ValueAndReferenceTypes;
using Xunit;

namespace ValueAndRefrenceTypesTests
{
    public class ValAndRefTypesTests
    {
        [Fact]
        public void RefTypeTest()
        {
            // Arrange
            var p1 = new RefType()
            {
                X = 10,
                Y = 20
            };
            var p2 = p1;

            // Act 
            p1.X = 30;
            // Assert
            Assert.Equal(p1.X, p2.X);
        }

        [Fact]
        public void ValTypeTest()
        {
            // Arrange
            var p1 = new ValueType
            {
                X = 10,
                Y = 20
            };
            var p2 = p1;

            // Act 
            p1.X = 30;

            // Assert
            Assert.NotEqual(p1.X, p2.X);
        }

        [Fact]
        public void RecordTypeTest()
        {
            // arrange
            var p1 = new RecordType(30, 50);

            // act
            var p2 = new RecordType(3, 5);

            // assert
            Assert.NotEqual(p1, p2);
        }

        [Fact]
        public void SwapByVal()
        {
            // Arrange
            int a = 23, b = 55;
            var valType = new ValueType();
            
            // Act
            valType.Swap(a, b);

            // Assert
            Assert.Equal(55, b);
            Assert.Equal(23, a);
        }

        [Fact]
        public void SwapByRef()
        {
            // Arrange
            int a = 23, b = 55;
            var valType = new RefType();

            // Act
            valType.Swap(ref a, ref b);

            // Assert
            Assert.Equal(55, a);
            Assert.Equal(23, b);
        }

        [Fact]
        public void CheckOutKeyword()
        {
            // arrange
            var refType = new RefType();
            int b = 50;
            
            // Act
            refType.CheckOut(out b);

            // Assert
            Assert.Equal(100, b);
        }

    }
}