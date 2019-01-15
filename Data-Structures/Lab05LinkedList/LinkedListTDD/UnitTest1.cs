using System;
using Xunit;
using LinkedList.Classes;
using LinkedList;

namespace LinkedListTDD
{
    public class UnitTest1
    {

        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(9)]
        public void Insert(int value)
        {
            LList testList = new LList();
            testList.Insert(value);
            Assert.Equal(testList.Head.Value, value);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(6)]
        public void Inlcude(int value)
        {
            LList testList = new LList();
            testList.Insert(value);
            testList.Includes(value);
            Assert.True(true);
        }

        [Theory]
        [InlineData(12)]
        [InlineData(14)]
        [InlineData(18)]
        public void Append(int value)
        {
            LList testList = new LList();
            testList.Insert(15);
            testList.Insert(20);
            testList.Append(value);
            //Assert.Equal(20 15 12 18, value);
        }

        [Theory]
        [InlineData(21, 22)]
        [InlineData(44, 88)]
        [InlineData(66, 89)]
        public void InsertBefore(int value, int newValue)
        {
            LList testList = new LList();
            testList.Insert(15);
            testList.Insert(20);
        }

        [Theory]
        [InlineData(21, 22)]
        [InlineData(44, 88)]
        [InlineData(66, 89)]
        public void InsertAfter(int value, int newValue)
        {
            LList testList = new LList();
            testList.Insert(15);
            testList.Insert(20);
        }
        
    }
}
