using System;
using LeafsBoolTwoTrees.Classes;

namespace LeafsBoolTwoTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Two Trees with directory for leafs");
            Console.WriteLine("");

            TestTwoTreesForTrue();
            TestTwoTreesForFalse();

            Console.ReadLine();
        }

        public static void TestTwoTreesForTrue()
        {
            FileStructureTree treeOne = new FileStructureTree();
            treeOne.Root = new Node("folder1");
            treeOne.Root.LeftChild = new Node("folder2");
            treeOne.Root.RightChild = new Node("folder3");
            treeOne.Root.LeftChild.LeftChild = new Node("folder4");
            treeOne.Root.LeftChild.RightChild = new Node("folder5");
            treeOne.Root.RightChild.LeftChild = new Node("folder6");
            treeOne.Root.RightChild.RightChild = new Node("folder7");

            FileStructureTree treeTwo = new FileStructureTree();
            treeTwo.Root = new Node("folder 11");
            treeTwo.Root.LeftChild = new Node("folder 12");
            treeTwo.Root.RightChild = new Node("folder 13");
            treeTwo.Root.LeftChild.LeftChild = new Node("folder 14");
            treeTwo.Root.LeftChild.RightChild = new Node("folder 15");
            treeTwo.Root.RightChild.RightChild = new Node("folder 16");
            treeTwo.Root.RightChild.RightChild.LeftChild = new Node("folder 17");
            treeTwo.Root.RightChild.RightChild.RightChild = new Node("folder 18");

            CompareTwoTrees compareTwoTrees = new CompareTwoTrees();

            Console.WriteLine("");
            Console.WriteLine("Two trees both have 4 leafs.");
            Console.WriteLine($"Therefore will return: {compareTwoTrees.LeafsInTwoTrees(treeOne, treeTwo)}");
        }

        public static void TestTwoTreesForFalse()
        {
            FileStructureTree treeOne = new FileStructureTree();
            treeOne.Root = new Node("folder1");
            treeOne.Root.LeftChild = new Node("folder2");
            treeOne.Root.RightChild = new Node("folder3");
            treeOne.Root.LeftChild.LeftChild = new Node("folder4");
            treeOne.Root.LeftChild.RightChild = new Node("folder5");
            treeOne.Root.RightChild.LeftChild = new Node("folder6");
            treeOne.Root.RightChild.RightChild = new Node("folder7");

            FileStructureTree treeTwo = new FileStructureTree();
            treeTwo.Root = new Node("folder 11");
            treeTwo.Root.LeftChild = new Node("folder 12");
            treeTwo.Root.RightChild = new Node("folder 13");
            treeTwo.Root.LeftChild.LeftChild = new Node("folder 14");
            treeTwo.Root.LeftChild.RightChild = new Node("folder 15");
            treeTwo.Root.RightChild.RightChild = new Node("folder 16");

            CompareTwoTrees compareTwoTrees = new CompareTwoTrees();

            Console.WriteLine("");
            Console.WriteLine($"Tree One has 4 leafs.  Tree Two has 3 leafs.");
            Console.WriteLine($"Therefore will return: {compareTwoTrees.LeafsInTwoTrees(treeOne, treeTwo)}");
        }
    }
}
