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
            int[] myNumbers = new int[12] { 4, 76, 22, 23, 24, 67, 99, 14, 15, 10, 8, 5 };
            //bubbles.numArrSort(myNumbers);
            Console.WriteLine($"Input array: {string.Join(", ", myNumbers)}");
            Console.WriteLine($"Bubble Sorted:  {String.Join(", ", bubbles.numArrSort(myNumbers))}");

            Console.WriteLine("");
            Console.WriteLine("Printed line by line");
            Console.WriteLine($"Input array: {string.Join(", ", myNumbers)}");
            printsEveryLine(myNumbers);

            Console.ReadLine();
        }

        public static void printsEveryLine(int[] input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = 0; j < input.Length - i - 1; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        int temp = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = temp;
                    }
                }
                Console.Write($"This is pass {i}:");
                Console.WriteLine($"{string.Join(" ", input)}");
            }
        }
    }
}
