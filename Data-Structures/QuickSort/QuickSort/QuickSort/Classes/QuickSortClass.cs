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
            int high = arr.Length - 1;
            int low = 0;

            QuickSortDivider(arr, low, high);
        }

        static void QuickSortDivider(int[] arr, int low, int high)
        {
            //similar to merge sort
            //divide and conque
            //true for first pass as low=0 and high is 1 or greater.
            if(low < high)
            {
                int pivot = PartitionSort(arr, low, high);
                //sort array, low, pivot-1
                //sort array, pivot+1, high
                if(pivot > 1)
                {
                    QuickSortDivider(arr, low, pivot - 1);
                }
                if(pivot + 1 < high)
                {
                    QuickSortDivider(arr, pivot + 1, high);
                }
                //else
                //{
                  //  QuickSortDivider(arr, pivot + 1, high);
                //}

            }

        }

        private static int PartitionSort(int[] arr,int low,int high)
        {
            //Can start on low or high.  I choose low for simplicity.
            int pivot = arr[low];
            while (true)
            {
                while (arr[low] < pivot)
                {
                    low++;
                }
                while(arr[high] > pivot)
                {
                    high--;
                }
                if(low < high)
                {
                    if(arr[low] == arr[high])
                    {
                        return high;
                    }
                    int temp = arr[low];
                    arr[low] = arr[high];
                    arr[high] = temp;
                }
                return high;
            }
        }
    }
}
