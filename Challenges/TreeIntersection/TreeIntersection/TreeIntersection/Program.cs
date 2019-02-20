using System;
using HashTables.Classes;
using Trees.Classes;
using System.Collections.Generic;

namespace TreeIntersection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Tree Intersection");
            Console.WriteLine("");
            BinaryTree treeOne = new BinaryTree();
            treeOne.Root = new Trees.Classes.Node(1);
            treeOne.Root.LeftChild = new Trees.Classes.Node(2);
            treeOne.Root.RightChild = new Trees.Classes.Node(3);
            treeOne.Root.LeftChild.LeftChild = new Trees.Classes.Node(4);
            treeOne.Root.LeftChild.RightChild = new Trees.Classes.Node(5);
            treeOne.Root.RightChild.LeftChild = new Trees.Classes.Node(6);
            treeOne.Root.RightChild.RightChild = new Trees.Classes.Node(7);

            BinaryTree treeTwo = new BinaryTree();
            treeTwo.Root = new Trees.Classes.Node(8);
            treeTwo.Root.LeftChild = new Trees.Classes.Node(2);
            treeTwo.Root.RightChild = new Trees.Classes.Node(4);
            treeTwo.Root.LeftChild.LeftChild = new Trees.Classes.Node(7);

            Console.WriteLine("Result of two binary trees input below:");

            List<int> result  = TreeIntersection(treeOne, treeTwo);
            Console.WriteLine($"[{string.Join(",", result)}]");
            
            Console.ReadLine();
        }

        public static List<int> TreeIntersection(BinaryTree one, BinaryTree two)
        {
            //Final output as List instead of int array.
            List<int> output = new List<int>();

            Hashtables hashTables = new Hashtables();

            //Pass Binary trees into List<>
            List<int> treeOneList = one.PreOrder(one.Root);
            List<int> treeTwoList = two.PreOrder(two.Root);

            //Add all of tree one into hashtable
            foreach (var item in treeOneList)
            {
                hashTables.Add(item.ToString(), item);
            }

            //compare tree two if buckets in hashtable are already occupied.
            //If collision occurs add that number to the List output.
            foreach (var item in treeTwoList)
            {   
                if (hashTables.Contains(item.ToString()))
                {
                    output.Add(item);
                }             
            }
            /*
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }*/

            return output;
        }
    }
}
