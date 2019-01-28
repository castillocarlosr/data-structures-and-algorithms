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

        [Fact]
        public void AppendOne()
        {
            LList testList = new LList();
            testList.Insert(25);
            testList.Insert(19);
            testList.Append(77);
            bool testBool = testList.Includes(77);
            Assert.True(true);
        }
        [Fact]
        public void AppendTwo()
        {
            LList testList = new LList();
            testList.Insert(34);
            testList.Insert(35);
            testList.Append(88);
            bool testBool = testList.Includes(88);
            Assert.True(true);
        }
        [Fact]
        public void AppendThree()
        {
            LList testList = new LList();
            testList.Insert(65);
            testList.Insert(62);
            testList.Append(4);
            bool testBool = testList.Includes(4);
            Assert.True(true);
        }

        [Theory]
        [InlineData(44, 75)]
        [InlineData(33, 76)]
        [InlineData(22, 77)]
        public void InsertBefore(int value, int newValue)
        {
            LList testList = new LList();
            testList.Insert(55);
            testList.Insert(44);
            testList.Insert(33);
            testList.Insert(22);
            testList.Insert(11);
            testList.InsertBefore(value, newValue);
            Assert.True(testList.Includes(newValue));
        }

        [Theory]
        [InlineData(44, 75)]
        [InlineData(33, 76)]
        [InlineData(22, 77)]
        public void InsertAfter(int value, int newValue)
        {
            LList testList = new LList();
            testList.Insert(55);
            testList.Insert(44);
            testList.Insert(33);
            testList.Insert(22);
            testList.Insert(11);
            testList.InsertAfter(value, newValue);
            Assert.True(testList.Includes(newValue));
        }
    }
}
