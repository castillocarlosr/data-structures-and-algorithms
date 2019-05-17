using System;
using ClosestPerfectSquare.Classes;

namespace ClosestPerfectSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World of Perfect Square......");
            Console.WriteLine(".......or at least closest to it.");
            PerfectSquare checkNumber = new PerfectSquare();
            Console.Write("Enter a whole number: ");
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine($"Is {userInput} perferct square:  {checkNumber.IsPerfectSquare(userInput)}");

            Console.ReadLine();
        }
    }
}
