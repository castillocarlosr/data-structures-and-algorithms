﻿using System;
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
            Console.WriteLine($"Input:  how much does a wooden doll weigh! {reverseSomeThing.ReverseWord("how much does a wooden doll weigh!")}");

            Console.ReadLine();
        }
    }
}
