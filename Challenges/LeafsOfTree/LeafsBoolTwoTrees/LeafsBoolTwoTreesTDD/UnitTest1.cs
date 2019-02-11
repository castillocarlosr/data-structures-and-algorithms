using System;
using Xunit;
using LeafsBoolTwoTrees.Classes;

namespace LeafsBoolTwoTreesTDD
{
    public class UnitTest1
    {
        /// <summary>
        /// Test for method that counts number of leafs
        /// </summary>
        [Fact]
        public void CountingNumberOfLeafsTest1()
        {
            FileStructureTree testTree = new FileStructureTree();
            testTree.Root = new Node("folder1");
            testTree.Root.LeftChild = new Node("folder2");
            testTree.Root.RightChild = new Node("folder3");
            int expected = 2;

            Assert.Equal(expected, testTree.TotalLeafsCount);
        }
        [Fact]
        public void CountingNumberOfLeafsTest2()
        {
            FileStructureTree testTree = new FileStructureTree();
            testTree.Root = new Node("folder1");
            testTree.Root.LeftChild = new Node("folder2");
            testTree.Root.RightChild = new Node("folder3");
            testTree.Root.LeftChild.LeftChild = new Node("folder4");
            testTree.Root.LeftChild.RightChild = new Node("folder5");
            testTree.Root.RightChild.LeftChild = new Node("folder6");
            int expected = 3;

            Assert.Equal(expected, testTree.TotalLeafsCount);
        }
        [Fact]
        public void CountingNumberOfLeafsTest3()
        {
            FileStructureTree testTree = new FileStructureTree();
            testTree.Root = new Node("folder1");
            testTree.Root.LeftChild = new Node("folder2");
            testTree.Root.RightChild = new Node("folder3");
            testTree.Root.LeftChild.LeftChild = new Node("folder4");
            testTree.Root.LeftChild.RightChild = new Node("folder5");
            testTree.Root.RightChild.LeftChild = new Node("folder6");
            testTree.Root.RightChild.RightChild = new Node("folder7");
            int expected = 4;

            Assert.Equal(expected, testTree.TotalLeafsCount);
        }

        /// <summary>
        /// Test for boolean method to return true.  Same number of leafs for each tree.
        /// </summary>
        // Small even tree
        [Fact]
        public void ReturnTrueTest1()
        {
            FileStructureTree testTreeOne = new FileStructureTree();
            testTreeOne.Root = new Node("folder1");
            testTreeOne.Root.LeftChild = new Node("folder2");
            testTreeOne.Root.RightChild = new Node("folder3");

            FileStructureTree testTreeTwo = new FileStructureTree();
            testTreeTwo.Root = new Node("folder python");
            testTreeTwo.Root.LeftChild = new Node("folder CShapr");
            testTreeTwo.Root.RightChild = new Node("Javascript");

            CompareTwoTrees compareTwoTrees = new CompareTwoTrees();

            Assert.True(compareTwoTrees.LeafsInTwoTrees(testTreeOne, testTreeTwo));
        }
        //Large even tree
        [Fact]
        public void ReturnTrueTest2()
        {
            FileStructureTree testTreeOne = new FileStructureTree();
            testTreeOne.Root = new Node("folder1");
            testTreeOne.Root.LeftChild = new Node("folder2");
            testTreeOne.Root.RightChild = new Node("folder3");
            testTreeOne.Root.LeftChild.LeftChild = new Node("folder4");
            testTreeOne.Root.LeftChild.RightChild = new Node("folder5");
            testTreeOne.Root.RightChild.LeftChild = new Node("folder6");
            testTreeOne.Root.RightChild.RightChild = new Node("folder7");

            FileStructureTree testTreeTwo = new FileStructureTree();
            testTreeTwo.Root = new Node("folder python");
            testTreeTwo.Root.LeftChild = new Node("folder CShapr");
            testTreeTwo.Root.RightChild = new Node("Javascript");
            testTreeTwo.Root.LeftChild.LeftChild = new Node("Visual Basic");
            testTreeTwo.Root.LeftChild.RightChild = new Node("C++");
            testTreeTwo.Root.RightChild.LeftChild = new Node("Ruby");
            testTreeTwo.Root.RightChild.RightChild = new Node("Ruby");

            CompareTwoTrees compareTwoTrees = new CompareTwoTrees();

            Assert.True(compareTwoTrees.LeafsInTwoTrees(testTreeOne, testTreeTwo));
        }
        //Uneven tree but same leafs counts on each tree.
        [Fact]
        public void ReturnTrueTest3()
        {
            FileStructureTree testTreeOne = new FileStructureTree();
            testTreeOne.Root = new Node("folder1");
            testTreeOne.Root.LeftChild = new Node("folder2");
            testTreeOne.Root.RightChild = new Node("folder3");
            testTreeOne.Root.LeftChild.LeftChild = new Node("folder4");
            testTreeOne.Root.LeftChild.RightChild = new Node("folder5");
            testTreeOne.Root.RightChild.LeftChild = new Node("folder6");
            testTreeOne.Root.RightChild.RightChild = new Node("folder7");

            FileStructureTree testTreeTwo = new FileStructureTree();
            testTreeTwo.Root = new Node("folder python");
            testTreeTwo.Root.LeftChild = new Node("folder CShapr");
            testTreeTwo.Root.RightChild = new Node("Javascript");
            testTreeTwo.Root.LeftChild.LeftChild = new Node("Visual Basic");
            testTreeTwo.Root.LeftChild.RightChild = new Node("C++");
            testTreeTwo.Root.RightChild.RightChild = new Node("Ruby");
            testTreeTwo.Root.RightChild.RightChild.LeftChild = new Node("Ruby");
            testTreeTwo.Root.RightChild.RightChild.RightChild = new Node("C#");

            CompareTwoTrees compareTwoTrees = new CompareTwoTrees();

            Assert.True(compareTwoTrees.LeafsInTwoTrees(testTreeOne, testTreeTwo));
        }

        /// <summary>
        /// Test for boolean to return false.  Not same number of leafs for both trees.
        /// </summary>
        [Fact]
        public void ReturnFalseTest1()
        {
            FileStructureTree testTreeOne = new FileStructureTree();
            testTreeOne.Root = new Node("folder1");
            testTreeOne.Root.LeftChild = new Node("folder2");
            testTreeOne.Root.RightChild = new Node("folder3");

            FileStructureTree testTreeTwo = new FileStructureTree();
            testTreeTwo.Root = new Node("folder python");
            testTreeTwo.Root.LeftChild = new Node("folder CShapr");
            testTreeTwo.Root.RightChild = new Node("Javascript");
            testTreeTwo.Root.RightChild.RightChild = new Node("C#");
            testTreeTwo.Root.RightChild.LeftChild = new Node("C#");

            CompareTwoTrees compareTwoTrees = new CompareTwoTrees();

            Assert.False(compareTwoTrees.LeafsInTwoTrees(testTreeOne, testTreeTwo));
        }
        //Large tree
        [Fact]
        public void ReturnFalseTest2()
        {
            FileStructureTree testTreeOne = new FileStructureTree();
            testTreeOne.Root = new Node("folder1");
            testTreeOne.Root.LeftChild = new Node("folder2");
            testTreeOne.Root.RightChild = new Node("folder3");
            testTreeOne.Root.LeftChild.LeftChild = new Node("folder4");
            testTreeOne.Root.LeftChild.RightChild = new Node("folder5");
            testTreeOne.Root.RightChild.LeftChild = new Node("folder6");
            testTreeOne.Root.RightChild.RightChild = new Node("folder7");

            FileStructureTree testTreeTwo = new FileStructureTree();
            testTreeTwo.Root = new Node("folder python");
            testTreeTwo.Root.LeftChild = new Node("folder CShapr");
            testTreeTwo.Root.RightChild = new Node("Javascript");
            testTreeTwo.Root.LeftChild.LeftChild = new Node("Visual Basic");
            testTreeTwo.Root.LeftChild.RightChild = new Node("C++");

            CompareTwoTrees compareTwoTrees = new CompareTwoTrees();

            Assert.False(compareTwoTrees.LeafsInTwoTrees(testTreeOne, testTreeTwo));
        }
        //Another large tree.  Not same number of leafs per tree.
        [Fact]
        public void ReturnFalseTest3()
        {
            FileStructureTree testTreeOne = new FileStructureTree();
            testTreeOne.Root = new Node("folder1");
            testTreeOne.Root.LeftChild = new Node("folder2");
            testTreeOne.Root.RightChild = new Node("folder3");
            testTreeOne.Root.LeftChild.LeftChild = new Node("folder4");
            testTreeOne.Root.LeftChild.RightChild = new Node("folder5");
            testTreeOne.Root.RightChild.LeftChild = new Node("folder6");
            testTreeOne.Root.RightChild.RightChild = new Node("folder7");

            FileStructureTree testTreeTwo = new FileStructureTree();
            testTreeTwo.Root = new Node("folder python");
            testTreeTwo.Root.LeftChild = new Node("folder CShapr");
            testTreeTwo.Root.RightChild = new Node("Javascript");
            testTreeTwo.Root.LeftChild.LeftChild = new Node("Visual Basic");
            testTreeTwo.Root.LeftChild.RightChild = new Node("C++");
            testTreeTwo.Root.RightChild.RightChild = new Node("Ruby");
            testTreeTwo.Root.RightChild.LeftChild = new Node("Assets");
            testTreeTwo.Root.RightChild.RightChild.LeftChild = new Node("Ruby");
            testTreeTwo.Root.RightChild.RightChild.RightChild = new Node("C#");

            CompareTwoTrees compareTwoTrees = new CompareTwoTrees();

            Assert.False(compareTwoTrees.LeafsInTwoTrees(testTreeOne, testTreeTwo));
        }
    }
}
