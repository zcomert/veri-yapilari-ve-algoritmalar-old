using DataStructures.Array;
using System;
using System.Collections.Generic;
using Xunit;

namespace ArrayTests
{
    public class ArrayListTest
    {
        private ArrayList _arrayList;
        public ArrayListTest()
        {
            // arrange
            _arrayList = new ArrayList();
        }

        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(16)]
        [InlineData(32)]
        [InlineData(64)]
        public void ArrayList_Constructor_Test(int defaultSize)
        {
            // Arrange | Act
            var _arrayList = new ArrayList(defaultSize);

            // Assert
            Assert.Equal(_arrayList.Length, defaultSize);
        }

        [Fact]
        public void ArrayList_Add_Test()
        {
            // act
            for (int i = 0; i < 50; i++)
            {
                _arrayList.Add(i);
            }

            // Asset
            Assert.Equal(64, _arrayList.Length);
        }

        [Theory]
        [InlineData(32)]
        [InlineData(64)]
        [InlineData(128)]
        [InlineData(256)]
        public void ArrayList_Remove_Test(int len)
        {
            // arrange
            for (int i = 0; i < len; i++)
            {
                _arrayList.Add(i);
            }

            Assert.Equal(len, _arrayList.Length);

            // Act
            for (int i = _arrayList.Length - 1; i > 8; i--)
            {
                _arrayList.Remove();
            }

            // Assert
            Assert.Equal(32, _arrayList.Length);
        }

        [Fact]
        public void ForEach_Test()
        {
            // arrange
            _arrayList.Add("a");
            _arrayList.Add("b");
            _arrayList.Add("c");
            _arrayList.Add("d");


            // act
            _arrayList.Remove();
            _arrayList.Remove();

            string s = "";
            foreach (var item in _arrayList)
            {
                s += item;
            }

            // assert
            Assert.Equal("ab", s);
        }

        [Fact]
        public void ArrayList_Constructor_With_IEnumerable_Test()
        {
            // arrange
            var list = new List<int> { 1, 2, 3 };

            // act
            var _arr = new DataStructures.Array.ArrayList(list);
            string s = "";
            foreach (var item in _arr)
            {
                s += item;
            }

            // assert
            Assert.Equal("123", s);
        }

        [Fact]
        public void IndexOf_Test()
        {
            // arrange 
            // a,b,c
            _arrayList.Add("a");
            _arrayList.Add("b");
            _arrayList.Add("c");

            // act
            var result = _arrayList.IndexOf("c");

            // Assert
            Assert.Equal(2, result);
        }
    }
}
