using System;
using StringSubString.Classes;

namespace StringSubString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello String and Substrings");
            Console.WriteLine("");

            string s1 = "brave";
            string s2 = "iwanttobebraveforcode";
            string s3 = "thewordbravisnothere";;

            MatchSubString isItInString = new MatchSubString();
            Console.WriteLine($"String 1:  {s1}");
            Console.WriteLine($"String 2:  {s2}");
            Console.WriteLine($"String 3:  {s3}");
            Console.WriteLine("\n");
            Console.WriteLine($"String 1 in String 2: {isItInString.MatchSubStringBool(s1, s2)}");
            Console.WriteLine($"String 1 in String 3: {isItInString.MatchSubStringBool(s1, s3)}");

            Console.ReadLine();
        }
    }
}
