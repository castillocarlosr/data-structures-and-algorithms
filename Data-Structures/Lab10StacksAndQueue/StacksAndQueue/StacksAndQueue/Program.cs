using System;
using StacksAndQueue.Classes;

namespace StacksAndQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            StartStack();
        }
        
        public static void StartStack()
        {
            Console.WriteLine("Hello Stacks and Queue");
            Console.WriteLine("");

            Console.WriteLine("============Stack==========");
            Console.WriteLine("Starting with an empty stack.  Then Push() nodes with value 11, 22, 33, 44, 55, 66");
            Stack carlosstack = new Stack(null);
            Console.WriteLine(carlosstack.Peek());

            Node nodeOne = new Node(11);
            Node nodeTwo = new Node(22);
            Node nodeThree = new Node(33);
            Node nodeFour = new Node(44);
            Node nodeFive = new Node(55);
            Node nodeSix = new Node(66);
            carlosstack.Push(nodeOne);
            carlosstack.Push(nodeTwo);
            carlosstack.Push(nodeThree);
            carlosstack.Push(nodeFour);
            carlosstack.Push(nodeFive);
            carlosstack.Push(nodeSix);

            Console.WriteLine("==== Stack Peek() ====");
            carlosstack.Peek();

            Console.WriteLine("==== Stack Pop() ====");
            Console.WriteLine("First pop.  New Top:");
            carlosstack.Pop();
            carlosstack.Peek();
            Console.WriteLine("Second pop.  New Top");
            carlosstack.Pop();
            carlosstack.Peek();

            Console.WriteLine("\n");
            Console.WriteLine("============Queue=========");
            //Console.WriteLine("Starting with a new Queue that is empty.");
            Queue carlosQueue = new Queue(null);
            Console.WriteLine($"Front of Queue:  {carlosQueue.Peek()} Starting with a new Queue that is empty.");

            Console.WriteLine("===========Enqueue==============");
            carlosQueue.Enqueque(nodeOne);
            Console.WriteLine($"1st node of Queue:  {carlosQueue.Peek().Value}");
            Console.WriteLine("Then Enqueue() nodes with value 22, 33, 44, 55, 66");
            carlosQueue.Enqueque(nodeTwo);
            carlosQueue.Enqueque(nodeThree);
            carlosQueue.Enqueque(nodeFour);
            carlosQueue.Enqueque(nodeFive);
            carlosQueue.Enqueque(nodeSix);

            Console.WriteLine("");
            Console.WriteLine("====== Queue Peek() ====");
            carlosQueue.Peek();

            Console.WriteLine("====== Desqueque() ====");
            Console.WriteLine("First Desqueque.  New Front:");
            carlosQueue.Dequeque();
            carlosQueue.Peek();
            Console.WriteLine("Second Desqueque.  New Front");
            carlosQueue.Dequeque();
            carlosQueue.Peek();

            Console.ReadLine();
        }
    }
}
