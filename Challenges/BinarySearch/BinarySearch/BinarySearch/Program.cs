using System;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            //test array and value.  Testested both values that exsist inside and not inside array
            int[] testArray = new int[12] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
            int testValueInArray = 17;
            //int testValueNotInArray = 28;

            //BinarySearch(testArray, testValueInArray);
            Console.WriteLine(BinarySearch(testArray, testValueInArray));
            Console.ReadLine();
        }

        public static int BinarySearch(int[] insideArray, int insideValue)
        {
            //setting up minumin and maximum length
            int min = 0;
            int max = insideArray.Length-1;
            int middlePoint = 0;
            bool foundValue = false;

            //the found value=false is if the value does not exsist.  the -1 incase a value is too low and pushes index to the left of zero and prevents infinite loop.
            while (min <= max && foundValue == false)// && (middlePoint != -1))
            {
                //middle point below.  C# automatically floors numbers.
                middlePoint = ((min + max) / 2);
                if(insideArray[middlePoint] < insideValue)
                {
                    //new minumim is set to the current middle point plus one.  (basically the right side)
                    min = middlePoint + 1;
                }
                if(insideArray[middlePoint] > insideValue)
                {
                    //new maximum is set to the current middle point plus one.  (basically the left side)
                    max = middlePoint - 1;
                }
                if(insideArray[middlePoint] == insideValue)
                {
                    //this will break out of the while loop and jump down to the else to find the mid point = value
                    foundValue = true;
                }
            }
            if(foundValue == false)
            {
                //The console will write the index but the return is -1
                //Console.WriteLine($"Value outside of array {middlePoint}");
                //Console.WriteLine("-1");
                //Console.ReadLine();
                return -1;
            }
            else
            {
                //We found the value of the array equal to the new middle point.
                //Console.WriteLine(middlePoint);
                //Console.ReadLine();
                return middlePoint;
            }
        }
    }
}
