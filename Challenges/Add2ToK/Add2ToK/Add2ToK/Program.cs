using System;
using Add2ToK.Classes;

namespace Add2ToK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello K value and Int array");
            Console.WriteLine("Does any two values in an array equal to a given k value?");
            Console.WriteLine("");

            SumBoolK sumBoolK = new SumBoolK();

            int[] inputOne = { 0, 1, 2, 3, 4 };
            int[] inputTwo = { 111, 99, 88, 77, 66, 55, 44, 33, 22, 11 };
            int k = 5;

            Console.WriteLine($"{{0, 1, 2, 3, 4}} and k=5 : {sumBoolK.TwoNumInK(inputOne, k)}");
            Console.WriteLine($"{{111, 99, 88, 77, 66, 55, 44, 33, 22, 11}} and k=5 : {sumBoolK.TwoNumInK(inputTwo, k)}");

            Console.ReadLine();
        }
    }
}
