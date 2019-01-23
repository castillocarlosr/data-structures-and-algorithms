using System;
using StacksAndQueue.Classes;

namespace QueueWithStacks
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Queue with Stacks");
            Console.WriteLine("\n");
            QueueWithStacks();
            Console.ReadLine();
        }

        public static void QueueWithStacks()
        {
            Console.WriteLine("Starting with empty Pseudo Queue");
            
            Node nodeOne = new Node(11);
            Node nodeTwo = new Node(22);
            Node nodeThree = new Node(33);
            Node nodeFour = new Node(44);
            PseudoQueue carlosPseudoQueue = new PseudoQueue();

            Console.WriteLine("=======Pseudo  Enqueue======");
            Console.WriteLine($"First node added:  {carlosPseudoQueue.Enqueue(nodeOne).Value}");
            Console.WriteLine($"Second node added:  {carlosPseudoQueue.Enqueue(nodeTwo).Value}");

            Console.WriteLine("=======Pseudo  Desqueue======");
            Console.WriteLine($"Node removed:  {carlosPseudoQueue.Desqueue().Value}");
        }
    }
}
