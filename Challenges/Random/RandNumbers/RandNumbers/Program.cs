using System;


namespace RandNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World of Random Numbers!");
            FiveReturn();

            Console.ReadLine();
        }

        /// <summary>
        /// Just a quick way for random numbers for my mom to pick her lottery numbers.
        /// </summary>
        public static void FiveReturn()
        {
            RandomFive randomFive = new RandomFive();

            
            Console.WriteLine($"Results for 1st drawing is {string.Join(",", randomFive.FiveNumbers(1, 39))}");
            Console.WriteLine($"Results for 2st drawing is {string.Join(",", randomFive.SixNumbers(1, 49))}");
            Console.WriteLine($"Results for 3st drawing is {string.Join(",", randomFive.SixNumbers(1, 49))}");
        }
    }
}
