using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueue.Classes;

namespace StacksAndQueue.Classes
{
    public class Queue
    {
        /// <summary>
        /// Sets the front node
        /// </summary>
        public Node Front { get; set; }

        /// <summary>
        /// Sets the rear node.  Can be the same as the rear node when 1st node.
        /// </summary>
        public Node Rear { get; set; }

        /// <summary>
        /// When creating a new Queue, the first node becomes both Front and End
        /// </summary>
        /// <param name="node"></param>
        /// <returns>new queue</returns>
        public Queue(Node node)
        {
            Rear = node;
            Front = node;
        }

        public Node Enqueque(Node node)
        {
            if(node == null)
            {
                Console.WriteLine("Sorry.  There is no queue right now.");
                return null;
            }
            else
            {
                Rear.Next = node;
                Rear = node;
                return node;
            }
        }

        public Node Dequeque()
        {
            Node temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp;
        }

        public Node Peek()
        {
            if (Front == null)
            {
                Console.WriteLine("Empty queue.  Returning NULL!");
                return null;
            }
            else
            {
                Console.WriteLine(Front.Value);
                return Front;
            }
        }
    }
}
