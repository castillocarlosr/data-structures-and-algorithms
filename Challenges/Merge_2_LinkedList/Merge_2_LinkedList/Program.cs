using System;

public class Custome_Node
{
    public int Data { get; set; }
    public Custome_Node Next { get; set; }

    public Custome_Node(int data)
    {
        Data = data;
        Next = null;
    }
}

public class Program
{
    public static void Main()
    {
        Custome_Node list1 = new Custome_Node(1);
        list1.Next = new Custome_Node(2);
        list1.Next.Next = new Custome_Node(5);
        list1.Next.Next.Next = new Custome_Node(6);
        list1.Next.Next.Next.Next = new Custome_Node(7);
        list1.Next.Next.Next.Next.Next = new Custome_Node(9);

        Custome_Node list2 = new Custome_Node(3);
        list2.Next = new Custome_Node(4);
        list2.Next.Next = new Custome_Node(5);
        list2.Next.Next.Next = new Custome_Node(7);
        list2.Next.Next.Next.Next = new Custome_Node(10);
        list2.Next.Next.Next.Next.Next = new Custome_Node(13);
        Custome_Node mergedList = MergeAndRemoveDuplicates(list1, list2);
        PrintLinkedList(mergedList);
    }

    public static Custome_Node MergeAndRemoveDuplicates(Custome_Node list1, Custome_Node list2)
    {
        Custome_Node mergedList = new Custome_Node(0); // Dummy node for the merged list.  This will be skipped when returning the node linskedlist
        Custome_Node current = mergedList;

        while (list1 != null && list2 != null)
        {
            if (list1.Data < list2.Data)
            {
                current.Next = list1;
                list1 = list1.Next;
            }
            else if (list1.Data > list2.Data)
            {
                current.Next = list2;
                list2 = list2.Next;
            }
            else
            {
                current.Next = list2;  //I don't think it matters which list I pick if they are the same.
                list1 = list1.Next;
                list2 = list2.Next;
            }

            current = current.Next;
        }

        // Append the remaining nodes from list1 or list2.  No need to iterate for the rest of the linked list as that will already be in memory.
        if (list1 != null)
            current.Next = list1;
        else if (list2 != null)
            current.Next = list2;

        return mergedList.Next; // Skip the dummy node=Node(0) and return the actual merged list
    }

    public static void PrintLinkedList(Custome_Node head)
    {
        Custome_Node current = head;

        while (current != null)
        {
            Console.WriteLine(current.Data);
            current = current.Next;
        }
    }
}