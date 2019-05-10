using System;
using ProductArray.Classes;

namespace ProductArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Array Product World");
            Console.WriteLine("The challenge here is to multiply all the numbers in the array except the current index it is in.");
            Console.WriteLine("");

            ProductClassArray inputArrMethod = new ProductClassArray();

            int[] inputArrOne = new int[4] { 1, 2, 3, 4};

            int[] inoutArrTwo = new int[5] { 4, 11, 2, 20, 5 };

            Console.WriteLine("Input: [1, 2, 3, 4]");
            Console.WriteLine("Output: [{0}]", string.Join(", ", inputArrMethod.ProductArrayExceptIndex(inputArrOne)));

            Console.WriteLine("");
            Console.WriteLine("Input: [4, 11, 2, 20, 5]");
            Console.WriteLine("Output: [{0}]", string.Join(", ", inputArrMethod.ProductArrayExceptIndex(inoutArrTwo)));

            Console.ReadLine();
        }
    }
}
