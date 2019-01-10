using System;
using Xunit;
using BinarySearch;

namespace BinarySearchTDD
{
    public class UnitTest1
    {
        [Fact]
        public void Test11()
        {
            int[] testArrayxUnit = new int[12] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
            Assert.Equal(0, Program.BinarySearch(testArrayxUnit, 11));
        }

        [Fact]
        public void Test12()
        {
            int[] testArray = new int[12] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
            Assert.Equal(1, Program.BinarySearch(testArray, 12));
        }

        [Fact]
        public void Test13()
        {
            int[] testArray = new int[12] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
            Assert.Equal(2, Program.BinarySearch(testArray, 13));
        }

        [Fact]
        public void Test14()
        {
            int[] testArray = new int[12] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
            Assert.Equal(3, Program.BinarySearch(testArray, 14));
        }

        [Fact]
        public void Test17()
        {
            int[] testArray = new int[12] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
            Assert.Equal(6, Program.BinarySearch(testArray, 17));
        }

        [Fact]
        public void Test20()
        {
            int[] testArray = new int[12] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
            Assert.Equal(9, Program.BinarySearch(testArray, 20));
        }

        [Fact]
        public void Test21()
        {
            int[] testArray = new int[12] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
            Assert.Equal(10, Program.BinarySearch(testArray, 21));
        }

        [Fact]
        public void Test22()
        {
            int[] testArray = new int[12] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
            Assert.Equal(11, Program.BinarySearch(testArray, 22));
        }

        [Fact]
        public void ValueNegativeOne()
        {
            int[] testArray = new int[12] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
            Assert.Equal(-1, Program.BinarySearch(testArray, 5));
        }

        [Fact]
        public void ValueNegativeTwo()
        {
            int[] testArray = new int[12] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
            Assert.Equal(-1, Program.BinarySearch(testArray, -2));
        }

    }
}
