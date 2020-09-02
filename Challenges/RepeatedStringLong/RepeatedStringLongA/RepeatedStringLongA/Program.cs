using System;
using RepeatedStringLongA.Classes;

namespace RepeatedStringLongA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World of repeating strings!");
            Console.WriteLine("");

            StringRepeatA stringRepeat1 = new StringRepeatA();
            string s = "aba";
            long n = 10;
            Console.WriteLine($"Input string = {s} and  long = {n}");
            Console.WriteLine($"Output = {stringRepeat1.repeatedString(s, n)}");

            Console.WriteLine("");
            string a = "a";
            long b = 15;
            Console.WriteLine($"Input string = {a} and  long = {b}");
            Console.WriteLine($"Output = {stringRepeat1.repeatedString(a, b)}");

            Console.WriteLine("");
            string c = "zzzxy";
            Console.WriteLine($"Input string = {c} and  long = {n}");
            Console.WriteLine($"Output = {stringRepeat1.repeatedString(c, n)}");

            Console.WriteLine("");
            string d = "xyzabcaa";
            long e = 155;
            Console.WriteLine($"Input string = {d} and  long = {e}");
            Console.WriteLine($"Output = {stringRepeat1.repeatedString(d, e)}");

            Console.ReadLine();
        }
    }
}
