using System;
namespace InsertionSort.Classes
{
    public class SortTypes
    {
        public virtual void IterativeSort(int[] arr)
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
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if(arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public virtual void RecursiveSort(int[] arr)
        {
            int n = arr.Length;
            //int[] resultRecuriveSort = UtilityRecursive(arr, n);
            UtilityRecursive(arr, n);
            //return resultRecuriveSort;
        }

        public virtual void UtilityRecursive(int[] arr, int n)
        {
            if (n <= 1) return;

            UtilityRecursive(arr, n - 1);

            int k = n - 2;
            int last = arr[n - 1];

            while(k >= 0 && arr[k]>last)
            {
                arr[k + 1] = arr[k];
                k--;
            }
            arr[k + 1] = last;
        }
    }
}
