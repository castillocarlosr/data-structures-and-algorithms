using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using StacksAndQueue.Classes;
using QueueWithStacks.Classes;

namespace QueueWithStacks
{
    public class PseudoQueue
    {
        Stack stackLoad = new Stack();

        Stack stackUnLoad = new Stack();

        /// <summary>
        /// This adds a node to the Load Stack if the Unload stack is empty
        /// If the Unload still has node, it moves them back over before adding the new node.
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public Node Enqueue(Node node)
        {
            while(stackUnLoad.Peek() != null)
            {
                Node temp = stackUnLoad.Pop();
                stackLoad.Push(temp);
            }
            stackLoad.Push(node);
            return node;
        }

        /// <summary>
        /// This moves over the nodes from the Load Stack to the UnLoad Stack and POP the last node.
        /// </summary>
        /// <returns></returns>
        public Node Desqueue()
        {
            
            while(stackLoad.Peek() != null)
            {
                Node temp = stackLoad.Pop();
                stackUnLoad.Push(temp);
            }
            return stackUnLoad.Pop();
        }

        /// <summary>
        /// Not required but wanted to see the top Node in the Main Program.
        /// </summary>
        public void PseudoPeek()
        {

            if(stackLoad.Top == null)
            {
                Console.WriteLine("Empty Queue and Stack");
            }
            else
            {
                Console.WriteLine(stackLoad.Top.Value);
            }
        }
    }
}
