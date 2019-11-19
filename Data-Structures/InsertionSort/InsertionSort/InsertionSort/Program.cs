using System;
using InsertionSort.Classes;

namespace InsertionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Insertion Sort!");
            Console.WriteLine("");
            int[] arrayOne = new int[9] { 5, 23, 12, 4, 1, 2, 15, 78, 222};
            int[] arrayTwo = new int[7] { 66, 22, 55,33, 44, 77, 11};
            int[] arrayThree = new int[7] { 22, 66, 55, 33, 44, 77, 11 };
            Console.Write("Initial Array: ");
            for (int i = 0; i < arrayOne.Length-1; i++)
            {
                Console.Write(arrayOne[i] + " ");
            }
            SortTypes sortArray = new SortTypes();
            sortArray.IterativeSort(arrayOne);
            Console.WriteLine("Sorted: ");
            Console.WriteLine(String.Join(" ", arrayOne));

            Console.Write("Initial Array: ");
            for (int i = 0; i < arrayTwo.Length - 1; i++)
            {
                Console.Write(arrayTwo[i] + " ");
            }
            sortArray.RecursiveSort(arrayTwo);
            Console.WriteLine("Sorted: ");
            Console.WriteLine(String.Join(" ", arrayTwo));

            Console.Write("Initial Array: ");
            for (int i = 0; i < arrayThree.Length - 1; i++)
            {
                Console.Write(arrayThree[i] + " ");
            }
            sortArray.RecursiveSort(arrayThree);
            Console.WriteLine("Sorted: ");
            Console.WriteLine(String.Join(" ", arrayThree));

            Console.ReadLine();
        }
    }
}
