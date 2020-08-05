using System;
using RotateArrayLeft.Classes;

namespace RotateArrayLeft
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello meee");
            int[] test1 = new int[] { 1, 2, 3, 4, 5 };
            int d1 = 3;

            Console.WriteLine("Input1: [{0}]", string.Join(", ", test1));
            RotateArr rotateArr1 = new RotateArr();
            int[] answer1 = rotateArr1.LeftRotate(test1, d1);


            Console.WriteLine("Output: [{0}]", string.Join(", ", answer1));

            Console.ReadLine();
        }
    }
}
