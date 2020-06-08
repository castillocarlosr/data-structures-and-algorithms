using System;
using MergeSort.Classes;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Merge Sort World!");

            int[] arrayOne = new int[] { 5, 8, 4, 0, 1, 2, 3, 9, 7, 6 };
            int[] arrayTwo = new int[] { -44, 66, 2, 0, 777 };
            int[] arrayThree = new int[] { 2, 4, 6, 8, 10, 20 };


            Console.WriteLine("Input: [{0}]", string.Join(", ", arrayOne));
            MergeClass merge = new MergeClass();
            merge.MergeSortInput(arrayOne);
            Console.WriteLine("Output: [{0}]", string.Join(", ", merge.MergeSortInput(arrayOne)));

            Console.WriteLine("");

            Console.WriteLine("Input: [{0}]", string.Join(", ", arrayTwo));
            Console.WriteLine("Output: [{0}]", string.Join(", ", merge.MergeSortInput(arrayTwo)));

            Console.WriteLine("");

            Console.WriteLine("Input: [{0}]", string.Join(", ", arrayThree));
            Console.WriteLine("Output: [{0}]", string.Join(", ", merge.MergeSortInput(arrayThree)));

            Console.ReadLine();
        }
    }
}
