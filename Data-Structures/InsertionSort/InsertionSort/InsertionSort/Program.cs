using System;

namespace InsertionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Insertion Sort!");
            int[] testArray = new int[9] { 5, 23, 12, 4, 1, 2, 15, 78, 222};
            Console.WriteLine("Initial Array: ");
            Console.WriteLine(String.Join(" ", testArray));

            InsertionSort(testArray);
            Console.ReadLine();
        }
        
        /// <summary>
        /// Method for insertion sort from least to greatest
        /// </summary>
        /// <param name="array"></param>
        /// <returns>int array</returns>
        public static int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i - 1;
                int temp = array[i];

                while (j >= 0 && temp < array[j])
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
                //Console.Write("After pass " + i + " : ");
                //Console.WriteLine(String.Join(" ", array));
            }
            return array;
        }
    }
}
