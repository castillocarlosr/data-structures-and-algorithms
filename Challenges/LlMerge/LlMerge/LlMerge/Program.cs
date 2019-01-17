using System;
using LinkedList.Classes;
using LinkedList;

namespace LlMerge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Merging Lists!");
            Console.WriteLine("");
            LList carlosListOne = new LList();
            carlosListOne.Insert(88);
            carlosListOne.Insert(77);
            carlosListOne.Insert(66);
            carlosListOne.Insert(55);
            carlosListOne.Insert(44);
            Console.WriteLine($"Linked List One:");
            carlosListOne.Print();

            LList carlosListTwo = new LList();
            carlosListTwo.Insert(82);
            carlosListTwo.Insert(72);
            carlosListTwo.Insert(62);
            carlosListTwo.Insert(52);
            carlosListTwo.Insert(42);
            Console.WriteLine($"Linked List Two:");
            carlosListTwo.Print();

            Console.WriteLine("\n");
            Console.WriteLine("Merging Linked List");
            MergeLists(carlosListOne, carlosListTwo);
            carlosListOne.Print();
            Console.ReadLine();
        }

        public static Node MergeLists(LList ll1, LList ll2)
        {
            //Node temp = ll2.Head.Next;

            ll1.Current = ll1.Head;
            ll2.Current = ll2.Head;
            
            if(ll1.Current.Next.Value > ll2.Current.Next.Value)
            {
                Node temp = ll1.Current;
                ll1.Current = ll2.Current;
            }
            
            ll1.Current = ll1.Head;

            while(ll1.Current.Next != null && ll2.Current.Next != null)
            {
                if (ll1.Current.Next.Value < ll2.Current.Next.Value)
                {
                    ll1.Current = ll1.Current.Next;
                }
                else
                {
                    Node tempOne = ll1.Current.Next;
                    Node tempTwo = ll2.Current.Next;
                    ll1.Current.Next = ll2.Current;
                    ll2.Current.Next = tempOne;
                    ll1.Current = ll1.Current.Next;
                    ll2.Current = tempTwo;
                }
            }
            
            if(ll1.Current.Next == null)
            {
                ll1.Current.Next = ll2.Current;
                return ll1.Head;
            }
            else
            {
                return ll2.Head;
            }           
        }
    }
}
