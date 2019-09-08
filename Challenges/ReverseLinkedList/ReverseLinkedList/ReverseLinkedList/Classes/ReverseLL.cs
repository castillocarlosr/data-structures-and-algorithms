using System;
namespace ReverseLinkedList.Classes
{
    public class ReverseLL
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
        /// Adds node to the end.
        /// </summary>
        /// <param name="inputNode"></param>
        public void AddNodeToEnd(Node inputNode)
        {
            if(Head == null)
            {
                Head = inputNode;
            }
            else
            {
                Node temp = Head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = inputNode;
            }
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
        /// This is where the magic happens
        /// </summary>
        public void ActionToReverseLL()
        {
            Node prev = null;
            Node nextTemp = null;
            Current = Head;
            while(Current != null)
            {
                nextTemp = Current.Next;
                Current.Next = prev;
                prev = Current;
                Current = nextTemp;
            }
            Head = prev;
        }
    }
}
