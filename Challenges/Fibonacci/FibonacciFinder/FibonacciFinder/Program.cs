using System;
using FibonacciFinder.Classes;

namespace FibonacciFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Golden Ratio");
            Console.WriteLine("Fibonacci Sequence is 0, 1,1,2,3,5,8,13,21,34,55,89,144, and that as far as I will go!");
            Console.WriteLine("");

            FibonacciClass fibonacciQuestion = new FibonacciClass();
            Console.WriteLine("***************Iterative Approach*************");
            Console.WriteLine($"12th number in Fibonacci Sequence: {fibonacciQuestion.FindSpecificIterative(12)}");
            Console.WriteLine($"1st number in Fibonacci Sequence: {fibonacciQuestion.FindSpecificIterative(1)}");
            Console.WriteLine($"2nd number in Fibonacci Sequence: {fibonacciQuestion.FindSpecificIterative(2)}");
            Console.WriteLine($"3rd number in Fibonacci Sequence: {fibonacciQuestion.FindSpecificIterative(3)}");

            Console.WriteLine("***************Recursive Approach*************");
            Console.WriteLine($"12th number in Fibonacci Sequence: {fibonacciQuestion.FindSpecificRecursive(12)}");
            Console.WriteLine($"1st number in Fibonacci Sequence: {fibonacciQuestion.FindSpecificRecursive(1)}");
            Console.WriteLine($"2nd number in Fibonacci Sequence: {fibonacciQuestion.FindSpecificRecursive(2)}");
            Console.WriteLine($"3rd number in Fibonacci Sequence: {fibonacciQuestion.FindSpecificRecursive(3)}");

            Console.WriteLine("***************Print Fibonacci sequence*************");
            Console.WriteLine($"Print numbers 1-12th integer: {String.Join(", ", fibonacciQuestion.PrintSequence(12))}");
            Console.WriteLine($"Print numbers 1st integer: {String.Join(", ", fibonacciQuestion.PrintSequence(1))}");
            Console.WriteLine($"Print numbers 2nd integer: {String.Join(", ", fibonacciQuestion.PrintSequence(2))}");


            Console.ReadLine();
        }
    }
}
