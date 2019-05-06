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
            //triangle.TriangleArraySlow(3);
            //Console.WriteLine(triangle.TriangleArraySlow(2));
            triangle.PrintPascal(5);

            Console.ReadLine();
        }
    }
}
