using System;
namespace InsertionSort.Classes
{
    public class SortTypes
    {
        public static void IterativeSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int j = i - 1;
                int temp = arr[i];

                while(j >= 0 && temp < arr[i])
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
        }

        public static void IterativeBubble(int[] arr)
        {

        }

        public static void RecursiveSort(int[] arr)
        {
            
        }

        public static void UtilityRecursive(int[] arr, int n)
        {

        }
    }
}
