using System;

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

        /// <summary>
        /// This add a new node to the rear of the queue
        /// </summary>
        /// <param name="node"></param>
        /// <returns>node for testing only</returns>
        public Node Enqueque(Node node)
        {
            try
            {   
                if (Front == null)
                {
                    Rear = node;
                    Front = node;
                    //Console.WriteLine("Sorry.  There is no queue right now.");
                    //return null;
                }
                else
                {
                
                    Rear.Next = node;
                    Rear = node;
                    return node;
                }
            }
            catch (Exception error)
            {
                Console.WriteLine($"Oh no.  This happened in Enqueque Method.  Message:{error.Message}");
            }
            return node;
        }

        /// <summary>
        /// This removes the front node in the queue and sets the previous node as the new head.
        /// </summary>
        /// <returns>Front for testint only</returns>
        public Node Dequeque()
        {
            try
            {
                Node temp = Front;
                Front = Front.Next;
                temp.Next = null;
                return temp;
            }
            catch (Exception error)
            {
                Console.WriteLine($"Oh no.  This happened in Dequeque Method.  Message:{error.Message}");
            }
            return Front;
        }

        /// <summary>
        /// Return the fron node only.  Nothing changed to the queue
        /// </summary>
        /// <returns></returns>
        public Node Peek()
        {
            try
            {
                if ((Front == null) && (Rear == null))
                {
                    Console.WriteLine("Empty queue.  Returning NULL!");
                    return Front;
                }
                else
                {
                    Console.WriteLine(Front.Value);
                    return Front;
                }
            }
            catch (Exception error)
            {
                Console.WriteLine($"Oh no.  This happened in Queue Peek Method.  Message:{error.Message}");
            }
            return Front;
        }
    }
}
