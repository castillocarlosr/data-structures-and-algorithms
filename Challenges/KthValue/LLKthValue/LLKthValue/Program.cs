using System;
using LinkedList.Classes;
using LinkedList;

namespace LLKthValue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Kth Value of Linked List");
            Console.WriteLine("\n");
            LList carlosKth = new LList();
            carlosKth.Insert(98);
            carlosKth.Insert(87);
            carlosKth.Insert(76);
            carlosKth.Insert(65);
            carlosKth.Insert(45);
            carlosKth.Insert(34);
            carlosKth.Print();
            Console.WriteLine("Starting Linked List:");

            Console.WriteLine("");
            Console.WriteLine("The Kth value method.");
            try
            {
                Console.WriteLine($"Finding K=0: { CallKplusAll(0, carlosKth)}");
                Console.WriteLine($"Finding K=1: { CallKplusAll(1, carlosKth)}");
                Console.WriteLine($"Finding K=2: { CallKplusAll(2, carlosKth)}");
                Console.WriteLine($"Finding K=3: { CallKplusAll(3, carlosKth)}");
                Console.WriteLine($"Finding K=4: { CallKplusAll(4, carlosKth)}");
                Console.WriteLine($"Finding K=5: { CallKplusAll(5, carlosKth)}");
                Console.WriteLine($"Finding K=6: { CallKplusAll(6, carlosKth)}");
            }
            catch (Exception error)
            {
                Console.WriteLine($"Hey.  Your index went outside the area. {error.Message}");
            }
            Console.ReadLine();
        }

        public static int CallKplusAll(int kValue, LList inputLL)
        {
            try
            {
                inputLL.Current = inputLL.Head;
                Node Runner = inputLL.Head;
                int counter = 0;
                while (inputLL.Current.Next != null)
                {
                    counter++;
                    if (counter > kValue)
                    {
                        Runner = Runner.Next;
                    }
                    inputLL.Current = inputLL.Current.Next;
                }
                if(kValue > counter)
                {
                    Console.WriteLine("Oh no.  Went past the linked list K parameter number");
                    throw new Exception();
                }
                else
                {
                    return Runner.Value;
                }
            }
            catch (Exception)
            {
                //Console.WriteLine($"Oh NO!  Something happened in the \"Kth\" Value method. CallKplusALL()  Go check it out! {error.Message} ");
                throw;
            }
        }
    }
}
