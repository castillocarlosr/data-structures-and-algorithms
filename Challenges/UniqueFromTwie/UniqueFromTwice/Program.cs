using System;
using System.Collections.Generic;

namespace UniqueFromTwice 
{
    public class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Given an array of integers, where all elements but one occur twice, find the unique element.");
            List<int> numbers = new List<int> { 1, 2, 3, 2, 1 };
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            int uniqueElement = LonelyInteger(numbers);
            Console.WriteLine("The unique element is: " + uniqueElement);

        }

        public static int LonelyInteger(List<int> arr)
        {
            int result = 0;
            foreach (int number in arr)
            {
                result = result ^ number;
                //result ^= number;
            }
            return result;
        }
    }

    
}