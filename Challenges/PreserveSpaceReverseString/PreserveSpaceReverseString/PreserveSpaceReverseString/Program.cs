using System;
using PreserveSpaceReverseString.Classes;

namespace PreserveSpaceReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello new challenge.");
            Console.WriteLine("This program will reverse any string input except for the \"$\" sign.");
            Console.WriteLine("That will stay in the same place no matter what.");
            Console.WriteLine("");

            PreservingSpaceClass stringOne = new PreservingSpaceClass();

            string inputOne = "12345.  This sentence has no dollar signs. 6789";
            stringOne.ReverseInputStr(inputOne);
            string inputTwo = "12345.  This sentence has one $ dollar signs. 6789";
            stringOne.ReverseInputStr(inputTwo);
            string inputThree = "12345.  $This $ sentence has multiple $$ dol$lar signs$. 6789";
            stringOne.ReverseInputStr(inputThree);

            Console.Write("Enter your own text:  ");
            string inputFour = Console.ReadLine();

            stringOne.ReverseInputStr(inputFour);
            Console.ReadLine();
        }
    }
}
