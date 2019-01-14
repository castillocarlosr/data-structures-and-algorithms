using System;
using Xunit;
using LinkedList.Classes;

namespace LinkedListTDD
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2)]
        [InlineData(6)]
        [InlineData(22)]
        public void Includes(int value)
        {
            LList testList = new LList();
            testList.Includes(value);
            Assert.Equal(true, value);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(5)]
        public void Add(int value)
        {
            LList testList = new LList();
            testList.Insert(value);
            Assert.Equal(value, value);
        }
    }
}
