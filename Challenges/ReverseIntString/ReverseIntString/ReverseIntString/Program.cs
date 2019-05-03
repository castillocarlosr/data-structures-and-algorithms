using System;
using ReverseIntString.Classes;

namespace ReverseIntString
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World or Integers and Strings");
            Console.WriteLine();
            ReverseTypes reverseSomeThing = new ReverseTypes();

            Console.Write("Enter a number:   ");
            int InputNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"Reverse of that number: {reverseSomeThing.ReverseIntegers(InputNumber)}");

            Console.WriteLine();
            Console.Write("Enter a set of words: ");
            string InputWords = Console.ReadLine();
            Console.WriteLine($"Reverse order of those words:  {reverseSomeThing.ReverseWord(InputWords)}");
            Console.WriteLine($"Reverse letters in each word:  {reverseSomeThing.ReverseLettersInEachWord(InputWords)}");
            Console.WriteLine($"Reverse all letters in sentence:  {reverseSomeThing.ReverseAllLetters(InputWords)}");

            Console.ReadLine();
        }
    }
}
