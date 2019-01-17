using System;
using Xunit;
using LinkedList.Classes;
using LlMerge;

namespace LlMerge
{
    public class UnitTest1
    {
        [Fact]
        public void Merge()
        {
            LList testListOne = new LList();
            LList testListTwo = new LList();
            testListOne.Insert(25);
            testListOne.Insert(23);
            testListOne.Insert(21);

            testListTwo.Insert(24);
            testListTwo.Insert(22);
            testListTwo.Insert(20);

            Assert.Equal(testListTwo.Head, Program.MergeLists(testListOne, testListTwo));
        }

        [Fact]
        public void DifferentSize()
        {
            LList testListOne = new LList();
            LList testListTwo = new LList();
            testListOne.Insert(25);
            testListOne.Insert(23);
            testListOne.Insert(21);

            testListTwo.Insert(24);
            testListTwo.Insert(22);
            testListTwo.Insert(20);
            testListTwo.Insert(19);
            testListTwo.Insert(18);
            testListTwo.Insert(17);

            Assert.Equal(testListTwo.Head, Program.MergeLists(testListOne, testListTwo));
        }
    }
}
