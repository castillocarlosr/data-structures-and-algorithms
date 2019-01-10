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
            int testValue = 11;
            Assert.Equal(0, Program.BinarySearch(testArrayxUnit, testValue));
        }

        [Fact]
        public void Test12()
        {
            int[] testArrayxUnit = new int[12] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
            int testValue = 12;
            Assert.Equal(1, Program.BinarySearch(testArrayxUnit, testValue));
        }

        [Fact]
        public void Test13()
        {
            int[] testArrayxUnit = new int[12] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
            Assert.Equal(2, Program.BinarySearch(testArrayxUnit, 13));
        }

        [Fact]
        public void Test14()
        {
            int[] testArrayxUnit = new int[12] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
            Assert.Equal(3, Program.BinarySearch(testArrayxUnit, 14));
        }

        [Fact]
        public void Test17()
        {
            int[] testArrayxUnit = new int[12] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
            Assert.Equal(6, Program.BinarySearch(testArrayxUnit, 17));
        }

        [Fact]
        public void Test20()
        {
            int[] testArrayxUnit = new int[12] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
            Assert.Equal(9, Program.BinarySearch(testArrayxUnit, 20));
        }

        [Fact]
        public void Test21()
        {
            int[] testArrayxUnit = new int[12] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
            Assert.Equal(10, Program.BinarySearch(testArrayxUnit, 21));
        }

        [Fact]
        public void Test22()
        {
            int[] testArrayxUnit = new int[12] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
            Assert.Equal(11, Program.BinarySearch(testArrayxUnit, 22));
        }

        [Fact]
        public void ValueOutsidePositive()
        {
            int[] testArray = new int[12] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
            Assert.Equal(-1, Program.BinarySearch(testArray, 5));
        }

        [Fact]
        public void ValueOutsideNegative()
        {
            int[] testArray = new int[12] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
            Assert.Equal(-1, Program.BinarySearch(testArray, -2));
        }

    }
}
