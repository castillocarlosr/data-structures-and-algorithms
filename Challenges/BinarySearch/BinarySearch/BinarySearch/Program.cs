using System;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            //test array and value.  Testested both values that exsist inside and not inside array
            int[] testArray = new int[12] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
            int testValueInArray = -2;
            //int testValueNotInArray = 28;

            BinarySearch(testArray, testValueInArray);
        }

        public static int BinarySearch(int[] insideArray, int insideValue)
        {
            //setting up minumin and maximum length
            int min = 0;
            int max = insideArray.Length-1;
            int middlePoint = 0;
            bool foundValue = false;

            while (min <= max && foundValue == false && (middlePoint != -1))
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
                    foundValue = true;
                    //Console.WriteLine(middlePoint);
                    //Console.ReadLine();
                    //return middlePoint;
                }
            }
            //when the when statement breaks out because it did not find a value, it returns a -1.
            //Console.WriteLine(-1);
            //Console.ReadLine();
            //return -1;
            if(foundValue == false)
            {
                //The console will write the index but the return is -1
                Console.WriteLine($"Value outside of array {middlePoint}");
                Console.WriteLine("-1");
                Console.ReadLine();
                return -1;
            }
            else
            {
                Console.WriteLine(middlePoint);
                Console.ReadLine();
                return middlePoint;
            }
        }
    }
}
