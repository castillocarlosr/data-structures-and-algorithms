using System;
using MostCommonElement.Classes;

namespace MostCommonElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Given an array of integers, find the most common number in the array?");
            Console.WriteLine("");
            Console.WriteLine("Array input: [2, 6, 5, 88, 5, 89, 88, 104, 88, 5, 88]");

            HighestFreqClass highestKey = new HighestFreqClass();
            int[] input1 = new int[] { 2, 6, 5, 88, 5, 89, 88, 104, 88, 5, 88 };
            int resultKey = highestKey.HighestNumber(input1);
            Console.WriteLine($"Highest number in array is: {resultKey}");

            int resultValue = highestKey.HighestFrequencyCount(input1);
            Console.WriteLine($"Highes frequency count of that key number is: {resultValue}");

            Console.ReadLine();
        }
    }
}
