using LinkedList.Classes;
using System;

namespace LinkedList
{
    class Program
    {
        //Carlos Castillo started Jan. 14, 2019
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the World of Nodes!");
            startNode();
        }

        /// <summary>
        /// Thhis is where the program starts
        /// </summary>
        static void startNode()
        {
            try
            {
                LList carlosList = new LList();
                carlosList.Insert(2);
                carlosList.Insert(4);
                carlosList.Insert(6);
                carlosList.Insert(8);
                carlosList.Insert(10);
                carlosList.Print();

                Console.WriteLine($"The current nodes being created {carlosList.Current.Value}");
                Console.WriteLine($"Does 8 exsist {carlosList.Includes(8)}");
                Console.WriteLine($"Does 12 exsist {carlosList.Includes(12)}");
                Console.ReadLine();

            }
            catch (Exception error)
            {
                Console.WriteLine($"Oh no.  Error {error.Message}!!");
            }
        }
    }
}
