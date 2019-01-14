using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class LList
    {
        public Node Head { get; set; }

        public Node Current { get; set; }

        public LList()
        {
            Head = Head;
            Current = Current;
        }

        /// <summary>
        /// This will insert a node with value to the front of the linked list.
        /// </summary>
        /// <param name="value">int value</param>
        public void Insert(int value)
        {
            try
            {
                Node carlos = new Node(value);
                carlos.Next = Head;
                Head = carlos;
            }
            catch (Exception error)
            {
                Console.WriteLine($"Oh no error!: {error.Message}");
            }
        }

        /// <summary>
        /// This will return a true/false if a node exsist inside the linked list
        /// </summary>
        /// <param name="value">input passed in as a value intiger</param>
        /// <returns>bool</returns>
        public bool Includes(int value)
        {
            try
            {
                Current = Head;
                while (Current.Next != null)
                {
                    if (Current.Value == value)
                    {
                        return true;
                    }
                    Current = Current.Next;
                }
                if (Current.Value == value)
                {
                    return true;
                }
                return false;
            }
            catch (Exception error)
            {
                Console.WriteLine($"Oh no error!: {error.Message}");
            }
            return false;
        }

        /// <summary>
        /// This will print the node results out to the display when called up.
        /// </summary>
        /// <return>void</return>
        public void Print()
        {
            try
            {
                Current = Head;
                while (Current.Next != null)
                {
                    Console.WriteLine($"{Current.Value}->");
                    Current = Current.Next;
                }
                Console.WriteLine($"{Current.Value}->null");
                Current = Head;
                //Console.ReadLine();
            }
            catch (Exception error)
            {
                Console.WriteLine($"Oh no error!: {error.Message}");
            }

        }
    }
}
