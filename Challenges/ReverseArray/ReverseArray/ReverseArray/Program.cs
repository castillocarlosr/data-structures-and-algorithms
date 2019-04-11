using System;
using ReverseArray.Classes;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Reverse Arrays and Reverse Strings!");

            ReverseTypes reverseSomething = new ReverseTypes();

            Console.WriteLine("");
            int[] inputOne = new int[] { 0, 1, 2, 3, 4 };
            int[] inputTwo = new int[] { 111, 99, 88, 77, 66, 55, 44, 33, 22, 11 };
            Console.WriteLine("Input array is [0, 1, 2, 3, 4]");
            Console.WriteLine($"Reverse: [{String.Join(", ", reverseSomething.ReverseInputArray(inputOne))}]");

            Console.WriteLine("");
            Console.WriteLine("Input array is [111, 99, 88, 77, 66, 55, 44, 33, 22, 11]");
            Console.WriteLine($"Reverse: [{String.Join(", ", reverseSomething.ReverseInputArray(inputTwo))}]");

            Console.WriteLine("");
            Console.WriteLine("Input string is : 'what does the fox say' ");
            Console.WriteLine($"Reverse: {reverseSomething.ReverseInputString("what does the fox say")}");

            _ = Console.ReadLine();
        }
    }
}
