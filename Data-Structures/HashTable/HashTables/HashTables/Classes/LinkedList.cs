using System;
using System.Collections.Generic;
using System.Text;

namespace HashTables.Classes
{
    /// <summary>
    /// New LinkedList instead of bringing in the library.
    /// </summary>
    public class LinkedList
    {
        public Node Head { get; set; }

        public Node Current { get; set; }

        public LinkedList(Node head)
        {
            Head = head;
        }

        public void Add(Node node)
        {
            Current = Head;
            node.Next = Head;
            Head = node;
            Current = Head;
        }

        public void Append(Node node)
        {
            Current = Head;

            while (Current.Next != null)
            {
                Current = Current.Next;
            }

            Current.Next = node;
            Current = Head;
        }
    }
}
