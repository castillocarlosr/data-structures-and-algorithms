using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueue.Classes;

namespace StacksAndQueue.Classes
{
    public class Stack
    {
        /// <summary>
        /// Set the top new node to TOP
        /// </summary>
        public Node Top { get; set; }

        /// <summary>
        /// instantiate the new Node starting the Stack
        /// </summary>
        /// <param name="node"></param>
        public Stack(Node node)
        {
            Top = node;
        }

        public Stack()
        {

        }

        /// <summary>
        /// Will add a new node to the top of the stack
        /// </summary>
        /// <param name="node"></param>
        public Node Push(Node node)
        {
            try
            {
                node.Next = Top;
                Top = node;
                return node;
            }
            catch (Exception error)
            {
                Console.WriteLine($"Oh no.  This happened in Push Method.  Message:{error.Message}");
            }
            return node;
        }

        /// <summary>
        /// will remove the top node.  Move TOP to the lower node.
        /// </summary>
        /// <returns></returns>
        public Node Pop()
        {
            try
            {
                Node temp = Top;
                Top = Top.Next;
                temp.Next = null;
                return temp;
            }
            catch (Exception error)
            {
                Console.WriteLine($"Oh no.  This happened in Pop Method.  Message:{error.Message}");
            }
            return Top;
        }

        /// <summary>
        /// Just look at the top node.
        /// </summary>
        /// <returns></returns>
        public Node Peek()
        {
            try
            {
                if (Top == null)
                {
                    Console.WriteLine("Empty stack.  Returning NULL!");
                    return null;
                }
                else
                {
                    Console.WriteLine(Top.Value);
                    return Top;
                }
            }
            catch (Exception error)
            {
                Console.WriteLine($"Oh no.  This happened in Stack Peek Method.  Message:{error.Message}");
            }
            return Top;
        }
    }
}
