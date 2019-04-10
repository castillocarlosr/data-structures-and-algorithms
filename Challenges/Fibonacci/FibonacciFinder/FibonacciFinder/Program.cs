using System;
using FibonacciFinder.Classes;

namespace FibonacciFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Golden Ratio");
            Console.WriteLine("Fibonacci Sequence is 1,1,2,3,5,8,13,21,34,55,89,144, and that as far as I will go!");
            Console.WriteLine("");

            FibonacciClass fibonacciQuestion = new FibonacciClass();
            Console.WriteLine("***************Iterative Approach*************");
            Console.WriteLine($"12th number in Fibonacci Sequence: {fibonacciQuestion.FindSpecificIterative(12)}");
            Console.WriteLine($"1st number in Fibonacci Sequence: {fibonacciQuestion.FindSpecificIterative(1)}");
            Console.WriteLine($"2nd number in Fibonacci Sequence: {fibonacciQuestion.FindSpecificIterative(2)}");
            Console.WriteLine($"3rd number in Fibonacci Sequence: {fibonacciQuestion.FindSpecificIterative(3)}");

            Console.WriteLine("***************Recursive Approach*************");
            Console.WriteLine($"12th number in Fibonacci Sequence: {fibonacciQuestion.FindSpecificRecursive(12)}");
            //Console.WriteLine($"1st number in Fibonacci Sequence: {fibonacciQuestion.FindSpecificRecursive(1)}");
            //Console.WriteLine($"2nd number in Fibonacci Sequence: {fibonacciQuestion.FindSpecificRecursive(2)}");
            Console.WriteLine($"3rd number in Fibonacci Sequence: {fibonacciQuestion.FindSpecificRecursive(3)}");

            Console.ReadLine();
        }
    }
}
