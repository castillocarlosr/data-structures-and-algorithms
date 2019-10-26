using System;
using PreserveSpaceReverseString.Classes;

namespace PreserveSpaceReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello new challenge.");
            Console.WriteLine("This program will reverse any string input except for the $ sign.");
            Console.WriteLine("That will stay in the same place no matter what.");
            Console.WriteLine("");
            Console.WriteLine("");

            PreservingSpaceClass stringOne = new PreservingSpaceClass();

            string inputOne = "1234. This sentence has no dollar signs. 5678";
            string answer1 = stringOne.ReverseInputStr(inputOne);
            Console.WriteLine(inputOne);
            Console.WriteLine(answer1);
            Console.WriteLine("");

            string inputTwo = "ABC. This sentence has one $ dollar signs. DEFG";
            Console.WriteLine(inputTwo);
            Console.WriteLine(stringOne.ReverseInputStr(inputTwo));
            Console.WriteLine("");

            string inputThree = "$This $ sentence has multiple $$ dol$lar signs$";
            Console.WriteLine(inputThree);
            Console.WriteLine(stringOne.ReverseInputStr(inputThree));
            Console.WriteLine("");

            Console.Write("Enter your own text:  ");
            string inputFour = Console.ReadLine();
            Console.WriteLine(stringOne.ReverseInputStr(inputFour));

            //stringOne.ReverseInputStr(inputFour);
            Console.ReadLine();
        }
    }
}
