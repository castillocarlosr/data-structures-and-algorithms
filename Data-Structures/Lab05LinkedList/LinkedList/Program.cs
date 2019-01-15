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
                Console.WriteLine("");
                Console.WriteLine("Starting with empty node");
                carlosList.Print();

                carlosList.Insert(77);
                carlosList.Insert(66);
                carlosList.Insert(55);
                carlosList.Insert(44);
                carlosList.Insert(33);
                Console.WriteLine("");
                Console.WriteLine("Linked List with Insert numbers 77,66,55,44.");
                carlosList.Print();

                Console.WriteLine("");
                Console.WriteLine($"Does 66 exsist {carlosList.Includes(66)}");
                Console.WriteLine($"Does 12 exsist {carlosList.Includes(12)}");

                carlosList.Append(88);
                carlosList.Append(99);
                Console.WriteLine("");
                Console.WriteLine("The appended linked list.  Appended 88,99.");
                carlosList.Print();

                carlosList.InsertBefore(66, 61);
                carlosList.InsertBefore(33, 31);
                Console.WriteLine("");
                Console.WriteLine("The InsertBefore Linked List.  Insert before 66, newValue 61.");
                Console.WriteLine("The InsertBefore Linked List.  Insert before 33, newValue 31."); //head of LL
                carlosList.Print();

                carlosList.InsertAfter(44, 49);
                carlosList.InsertAfter(31, 32);
                Console.WriteLine("");
                Console.WriteLine("The InsertAfter Linked List.  Insert after 44, newValue 49.");
                Console.WriteLine("The InsertAfter Linked List.  Insert after 31, newValue 32."); //head of LL
                carlosList.Print();

                Console.ReadLine();
            }
            catch (Exception error)
            {
                Console.WriteLine($"Oh no.  Error {error.Message}!!");
            }
        }
    }
}
