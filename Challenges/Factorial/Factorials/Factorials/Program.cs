using System;
using Factorials.Classes;

namespace Factorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Factorials");
            Console.WriteLine("");
            FactorialMethods factorialMethods = new FactorialMethods();
            Console.Write("Enter a positive number for it\'s factorial:  ");
            while (true)
            {
                try
                {
                    int userInput1 = int.Parse(Console.ReadLine());
                    if (userInput1 < 0)
                    {
                        Console.Write("You must enter a positive number:  ");
                        continue;
                    }

                    Console.WriteLine($"Factorial({userInput1}) = {factorialMethods.FactorialAnswer(userInput1)}");

                    Console.ReadLine();
                }
                catch (FormatException)
                {
                    Console.Write("You must enter a whole number.");
                    continue;
                }
                break;

            }

        }
    }
}
