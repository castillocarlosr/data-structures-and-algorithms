using System;
namespace QuickSort.Classes
{
    public class QuickSortClass
    {
        /// <summary>
        /// This is where the initial array will come in.
        /// Getting the length and then calling the object for the low and high pivots.
        /// </summary>
        /// <param name="arr"></param>
        public void QuickSortObject(int[] arr)
        {
            int high = arr.Length;
            int low = 0;

            QuickSortDivide(arr, low, high);
        }

        static void QuickSortDivide(int[] arr, int low, int high)
        {
            //similar to merge sort
            //divide and conque
            //will rerequire one or 3 pivots....I'll have to draw it out
            if(low < high)
            {
                //int something = callAnotherObject(arr, lowPivot, highPivot);
                // sort arr, low, pivot-1
                //sort arr, pivot+1, high
                int pivot = PartitionSort(arr, low, high);

            }

        }

        private static int PartitionSort(int[] arr,int low,int high)
        {
            int pivot = arr[low];
            //int right = arr[high];
            int result = -1;
            return result;
        }
    }
}
