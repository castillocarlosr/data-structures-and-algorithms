using System;

namespace ArrayShift
{
    public class Program
    {
        static void Main(string[] args)
        {
            //The two below are just example array and value to test method
            int[] testArray = new int[4] { 11, 22, 33, 44 };
            int testValue = 55;

            //calling method array int below
            InsertShiftArray(testArray, testValue);
        }

        public static int[] InsertShiftArray(int[] insideArray, int insideValue)
        {
            int sizeOfArray = insideArray.Length;  //getting the size of original array
            int halfArray = sizeOfArray / 2;    //getting the middle of original array
            int[] newArray = new int[sizeOfArray + 1];  //new array with size 1 plus from old array
            for (int i = 0; i < insideArray.Length; i++)  //for-loop 
            {
                if (i < halfArray) //fill in the first half of new array
                {
                    newArray[i] = insideArray[i];
                }
                else if (i == halfArray) //when the middle index is meet
                {
                    newArray[i] = insideValue; //adding the number value to the middle of new array
                    newArray[i + 1] = insideArray[i]; //because the new array was shifted by one compared to the old array
                }
                else
                    newArray[i + 1] = insideArray[i]; //continues the same from here on out because of the shift.
            }
            //The console below is to display the new array and visually see the new array is working.
            //I ran the debug and it worked showing the newArray filling up in the proper order.
            //From first half of old array, then the value number, then the last half of old array.
            Console.WriteLine(string.Join(",", newArray));
            Console.ReadLine();
            return newArray;
        }
    }
}
