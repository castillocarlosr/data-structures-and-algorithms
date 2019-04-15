using System;
using BubbleSort.Classes;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Bubble Sort World");
            Console.WriteLine("Not the most efficient way to sort but the easiest to code before watching Game of Thrones.");
            Console.WriteLine("");

            Bubbles bubbles = new Bubbles();
            int[] myNumbers = new int[12] { 4, 76, 22, 23, 24, 67, 99, 14, 15, 10, 2, 8 };
            bubbles.numArrSort(myNumbers);
            Console.WriteLine($"Bubble Sorted:  {bubbles.numArrSort(myNumbers)}");

            Console.ReadLine();
        }
    }
}
