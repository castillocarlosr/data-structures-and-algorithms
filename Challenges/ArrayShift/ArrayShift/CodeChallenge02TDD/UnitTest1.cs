using System;
using Xunit;
using ArrayShift;


namespace CodeChallenge02TDD
{
    public class UnitTest1
    {
        [Fact]
        public void Test1ArrayLength()
        {
            int[] test1 = new int[6] { 8, 9, 10, 11, 12, 13 };
            int[] expectedTest1 = new int[7] { 8, 9, 10, 55, 11, 12, 13 };
            Assert.Equal(expectedTest1, Program.InsertShiftArray(test1, 55));
            //Assert.Equal(55, 55);
        }

        [Fact]
        public void Test2ArrayValue()
        {
            int[] testArray = new int[4] { 11, 22, 33, 44 };
            int test2 = 77;
            int[] expectedTest2 = new int[5] { 11, 22, 77, 33, 44 };
            Assert.Equal(expectedTest2, Program.InsertShiftArray(testArray, test2));
        }

        [Fact]
        public void Test3ArrayBoth()
        {
            int[] test3Array = new int[2] { 2, 6};
            int test3Value = 4;
            int[] expectedTest1 = new int[3] { 2, 4, 6 };
            Assert.Equal(expectedTest1, Program.InsertShiftArray(test3Array, test3Value));
        }
    }
}

