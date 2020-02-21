using System;
using QuickSort.Classes;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello QUICK SORT World!");

            int[] arrayOne = new int[] { 55, 33, 22, 77, 88, 11, 99, 44 };

            Console.WriteLine("");
            Console.WriteLine("Input: [{0}]", string.Join(", ", arrayOne));

            QuickSortClass quickSort = new QuickSortClass();
            quickSort.QuickSortObject(arrayOne);

            //Console.WriteLine("Output: [{0}]", string.Join(", ", quickSort.QuickSortObject(arrayOne)));
            Console.WriteLine("Output:");
            Console.WriteLine("Output: [{0}]", string.Join(", ", arrayOne));

            Console.ReadLine();
        }
    }
}
