using System;
using System.Collections.Generic;
using System.Text;

namespace CyclicLList.Classes
{
    public class LList
    {
        /// <summary>
        /// This will always point to the front first node.  Never moves unless new node is inserted.
        /// </summary>
        public Node Head { get; set; }

        /// <summary>
        /// This will point to the current node through traversing the linked list.
        /// </summary>
        public Node Current { get; set; }

        /// <summary>
        /// This will insert a node with value to the front of the linked list.
        /// </summary>
        /// <param name="value">int value</param>
        public void Insert(int value)
        {
            try
            {
                Node newNode = new Node(value);
                newNode.Next = Head;
                Head = newNode;
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
                if (Head != null)
                {
                    Current = Head;
                    while (Current.Next != null)
                    {
                        Console.Write($"{Current.Value}->");
                        Current = Current.Next;
                    }
                    Console.WriteLine($"{Current.Value}->null");
                    Current = Head;
                }
                else
                {
                    Console.WriteLine("Your Linked-List is empty!!");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine($"Oh no error!: {error.Message}");
            }
        }

        /// <summary>
        /// This will append a node to the END of the linked list.  This then maked the new node point to null.
        /// </summary>
        /// <param name="value">value</param>
        public void Append(int value)
        {
            try
            {
                while (Current.Next != null)
                {
                    Current = Current.Next;
                }
                Node node = new Node(value);
                Current.Next = node;
            }
            catch (Exception error)
            {
                Console.WriteLine($"Oh no.  Error during the Append method: {error.Message}");
            }

        }

        /// <summary>
        /// This will insert a new node before another node with a value entered.
        /// </summary>
        /// <param name="value">int</param>
        /// <param name="newValue">int</param>
        public void InsertBefore(int value, int newValue)
        {
            try
            {
                Current = Head;

                if (Current.Value == value)
                {
                    Insert(newValue);
                    return;
                }

                while (Current.Next != null)
                {
                    if (Current.Next.Value == value)
                    {
                        Node node = new Node(newValue);
                        node.Next = Current.Next;
                        Current.Next = node;
                        return;
                    }
                    Current = Current.Next;
                }
            }
            catch (Exception error)
            {
                Console.WriteLine($"Oh no.  Error during the InsertBefore method: {error.Message}");
            }
        }

        /// <summary>
        /// This will insert a new node after another node with a value entered.
        /// </summary>
        /// <param name="value">int</param>
        /// <param name="newValue">int</param>
        public void InsertAfter(int value, int newValue)
        {
            try
            {
                Current = Head;

                if (Current.Value == value)
                {
                    Node node = new Node(newValue);
                    node.Next = Current.Next;
                    Current.Next = node;
                    return;
                }

                while (Current.Next != null)
                {
                    if (Current.Next.Value == value)
                    {
                        Node node = new Node(newValue);
                        node.Next = Current.Next.Next;
                        Current.Next.Next = node;
                        return;
                    }
                    Current = Current.Next;
                }
            }
            catch (Exception error)
            {
                Console.WriteLine($"Oh no.  Error during the InsertAfter method: {error.Message}");
            }
        }

        public bool IsCircular(Node node)
        {
            if (Head != null && Head.Next != null)
            {
                Node slow = Head;
                Node fast = Head.Next;
                while (slow.Next != null && fast.Next != null && fast.Next.Next != null)
                {
                    if (slow == fast)
                    {
                        return true;
                    }
                    slow = slow.Next;
                    fast = fast.Next.Next;
                }
                return false;
            }
            else
            {
                return Head != null ? (Head == Head.Next) : false;
            }
        }
    }
}
