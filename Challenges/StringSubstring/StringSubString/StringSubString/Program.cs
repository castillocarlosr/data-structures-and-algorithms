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
            string s3 = "thewordbravisnothere";
            string s4 = "abbccc";

            MatchSubString isItInString = new MatchSubString();
            Console.WriteLine($"Yes: {isItInString.MatchSubStringBool(s1, s2)}");
            Console.WriteLine($"Yes: {isItInString.MatchSubStringBool(s1, s3)}");
            Console.WriteLine("-----------");
            Console.WriteLine($"com: {isItInString.compressRepeats(s4)}");

            Console.ReadLine();
        }
    }
}
