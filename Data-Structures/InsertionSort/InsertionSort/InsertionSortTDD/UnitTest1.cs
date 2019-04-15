using System;
using Xunit;
using InsertionSort;
using static InsertionSort.Program;

namespace InsertionSortTDD
{
    public class UnitTest1
    {
        /// <summary>
        /// Test for Random array to return Sorted array.
        /// </summary>
        /// <param name="unSorted"></param>
        /// <param name="sorted"></param>
        [Theory]
        [InlineData(new int[4] { 11, 44, 33, 22 }, new int[4] { 11, 22, 33, 44 })]
        [InlineData(new int[5] { 3, 66, 76, 87, 23 }, new int[5] { 3, 23, 66, 76, 87 })]
        [InlineData(new int[8] { 3, 66, 76, 87, 23, 77, 88, 4 }, new int[8] { 3, 4, 23, 66, 76, 77, 87, 88 })]
        public void RandomArrayReturnsSorted(int[] unSorted, int[] sorted)
        {
            int[] expectedSort = InsertionSort.Program.InsertionSort(unSorted);
            Assert.Equal(sorted, expectedSort);
        }

        /// <summary>
        /// Sorted array returns the same Sorted array.  Nothing should change.
        /// </summary>
        /// <param name="unSorted"></param>
        /// <param name="sorted"></param>
        [Theory]
        [InlineData(new int[4] { 11, 22, 33, 44 }, new int[4] { 11, 22, 33, 44 })]
        [InlineData(new int[5] { 3, 66, 76, 87, 199 }, new int[5] { 3, 66, 76, 87, 199 })]
        [InlineData(new int[8] { 3, 44, 55, 66, 79, 92, 115, 444 }, new int[8] { 3, 44, 55, 66, 79, 92, 115, 444 })]
        public void SortedArrayReturnsSorted(int[] unSorted, int[] sorted)
        {
            int[] expectedSort = InsertionSort.Program.InsertionSort(unSorted);
            Assert.Equal(sorted, expectedSort);
        }

        /// <summary>
        /// Backwards array return Sorted array
        /// </summary>
        /// <param name="unSorted"></param>
        /// <param name="sorted"></param>
        [Theory]
        [InlineData(new int[4] { 44, 33, 22, 11 }, new int[4] { 11, 22, 33, 44 })]
        [InlineData(new int[5] { 199, 87, 76, 66, 3 }, new int[5] { 3, 66, 76, 87, 199 })]
        [InlineData(new int[8] {144, 115, 92, 79, 66, 55, 44, 3 }, new int[8] { 3, 44, 55, 66, 79, 92, 115, 144 })]
        public void BackwardsArrayReturnsSorted(int[] unSorted, int[] sorted)
        {
            int[] expectedSort = InsertionSort.Program.InsertionSort(unSorted);
            Assert.Equal(sorted, expectedSort);
        }

        /// <summary>
        /// Empty array written in different ways to return same empty array
        /// </summary>
        /// <param name="unSorted"></param>
        /// <param name="sorted"></param>
        [Theory]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(new int[0], new int[] { })]
        [InlineData(new int[0] { }, new int[] { })]
        public void EmptyArray(int[] unSorted, int[] sorted)
        {
            int[] expectedSort = InsertionSort.Program.InsertionSort(unSorted);
            Assert.Equal(sorted, expectedSort);
        }

        /// <summary>
        /// Array of only one element
        /// </summary>
        /// <param name="unSorted"></param>
        /// <param name="sorted"></param>
        [Theory]
        [InlineData(new int[1] {1}, new int[1] {1})]
        [InlineData(new int[1] { 4 }, new int[1] {4 })]
        [InlineData(new int[1] { 7628 }, new int[] {7628 })]
        public void OneElemwentArray(int[] unSorted, int[] sorted)
        {
            int[] expectedSort = InsertionSort.Program.InsertionSort(unSorted);
            Assert.Equal(sorted, expectedSort);
        }

    }
}
