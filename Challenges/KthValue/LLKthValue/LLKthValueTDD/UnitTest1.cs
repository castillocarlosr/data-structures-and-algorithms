using System;
using Xunit;
using LinkedList.Classes;
using LLKthValue;

namespace LLKthValueTDD
{
    public class UnitTest1
    {
        [Fact]
        public void FindingKth()
        {
            LList testList = new LList();
            testList.Insert(58);
            testList.Insert(50);
            testList.Insert(48);
            testList.Insert(40);
            Assert.Equal(50, Program.CallKplusAll(1, testList));
        }
        /*
        [Fact]
        public void OutsideRangeKth()
        {
            LList testList = new LList();
            testList.Insert(58);
            testList.Insert(50);
            testList.Insert(48);
            testList.Insert(40);
            Assert.Equal(System.Exception, Program.CallKplusAll(8, testList));
        }
        8/
    }
}
