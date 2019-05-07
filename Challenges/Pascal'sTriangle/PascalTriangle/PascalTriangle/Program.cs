using System;
using PascalTriangle.Classes;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Pascal's Triangle World!");
            Console.WriteLine("");
            //       1
            //      1 1
            //     1 2 1
            //    1 3 3 1
            //   1 4 6 4 1
            //  1 5 10 10 5 1
            // 1 6 15 20 15 6 1
            TriangleClass triangle = new TriangleClass();
            /*
            Console.Write("Please enter an index to display that array: ");
            int inputFromUserArray = int.Parse(Console.ReadLine());
            foreach(var item in triangle.TriangleArray(inputFromUserArray))
            {
                Console.WriteLine(item.ToString());
            }
            */
            Console.Write("Please enter an index number to print the triangle:  ");
            int inputFromUserTriangle = int.Parse(Console.ReadLine());
            triangle.PrintPascal(inputFromUserTriangle + 1);

            Console.ReadLine();
        }
    }
}
