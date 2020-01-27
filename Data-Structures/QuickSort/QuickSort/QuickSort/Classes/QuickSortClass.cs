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
        public void QuickSortMain(int[] arr)
        {
            int high = arr.Length;
            int low = 0;

            QuickSortObject(arr, low, high);
        }

        static void QuickSortObject(int[] arr, int low, int high)
        {
            //similar ro merge sort
            //divide and conque
            //will rerequire one or 3 pivots....I'll have to draw it out
            if(low < high)
            {
                //int something = callAnotherObject(arr, lowPivot, highPivot);
                // sort arr, low, pivot-1
                //sort arr, pivot+1, high
            }

        }
    }
}
