using System;
using PrimeThatNumber.Classes;

namespace PrimeThatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello PRIME World!");

            PrimeClass prime = new PrimeClass();

            int testPrime1 = 1;
            int testEven = 666;
            int testOdd = 999;
            int testPrime2 = 13;
            int testPrime3 = 1213;

            Console.WriteLine($"Input: {testPrime1}  Output: {prime.IsPrime(testPrime1)}");
            Console.WriteLine($"Input: {testEven}  Output: {prime.IsPrime(testEven)}");
            Console.WriteLine($"Input: {testOdd}  Output: {prime.IsPrime(testOdd)}");
            Console.WriteLine($"Input: {testPrime2}  Output: {prime.IsPrime(testPrime2)}");
            Console.WriteLine($"Input: {testPrime3}  Output: {prime.IsPrime(testPrime3)}");
            Console.ReadLine();
        }
    }
}
