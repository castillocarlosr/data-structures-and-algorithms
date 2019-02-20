using System;
using Xunit;
using Trees.Classes;
using System.Collections.Generic;
using TreeIntersection;

namespace TreeIntersectionTDD
{
    public class UnitTest1
    {
        [Fact]
        public void TwoBinaryTreesPair()
        {
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
            List<int> expected = new List<int>{ 2, 7, 4 };

            Assert.Equal(expected, Program.TreeIntersection(treeOne, treeTwo));
        }

        [Fact]
        public void TwoBinaryTreesDifferent()
        {
            BinaryTree treeOne = new BinaryTree();
            treeOne.Root = new Trees.Classes.Node(1);
            treeOne.Root.LeftChild = new Trees.Classes.Node(2);
            treeOne.Root.RightChild = new Trees.Classes.Node(3);
            treeOne.Root.LeftChild.LeftChild = new Trees.Classes.Node(4);
            treeOne.Root.LeftChild.RightChild = new Trees.Classes.Node(5);
            treeOne.Root.RightChild.LeftChild = new Trees.Classes.Node(6);
            treeOne.Root.RightChild.RightChild = new Trees.Classes.Node(7);

            BinaryTree treeTwo = new BinaryTree();
            treeTwo.Root = new Trees.Classes.Node(1);
            treeTwo.Root.LeftChild = new Trees.Classes.Node(2);
            treeTwo.Root.RightChild = new Trees.Classes.Node(3);
            treeTwo.Root.LeftChild.LeftChild = new Trees.Classes.Node(4);
            treeTwo.Root.LeftChild.RightChild = new Trees.Classes.Node(5);
            treeTwo.Root.RightChild.LeftChild = new Trees.Classes.Node(6);
            List<int> expected = new List<int> { 1, 2, 4, 5, 3, 6};

            Assert.Equal(expected, Program.TreeIntersection(treeOne, treeTwo));
        }

        [Fact]
        public void TwoBinaryTreessmall()
        {
            BinaryTree treeOne = new BinaryTree();
            treeOne.Root = new Trees.Classes.Node(7);
            treeOne.Root.LeftChild = new Trees.Classes.Node(22);
            treeOne.Root.RightChild = new Trees.Classes.Node(55);

            BinaryTree treeTwo = new BinaryTree();
            treeTwo.Root = new Trees.Classes.Node(1);
            treeTwo.Root.LeftChild = new Trees.Classes.Node(22);

            List<int> expected = new List<int> { 22 };

            Assert.Equal(expected, Program.TreeIntersection(treeOne, treeTwo));
        }

        [Fact]
        public void NoMatch()
        {
            BinaryTree treeOne = new BinaryTree();
            treeOne.Root = new Trees.Classes.Node(7);
            treeOne.Root.LeftChild = new Trees.Classes.Node(99);
            treeOne.Root.RightChild = new Trees.Classes.Node(55);

            BinaryTree treeTwo = new BinaryTree();
            treeTwo.Root = new Trees.Classes.Node(3);
            treeTwo.Root.LeftChild = new Trees.Classes.Node(22);

            List<int> expected = new List<int> {  };

            Assert.Equal(expected, Program.TreeIntersection(treeOne, treeTwo));
        }
    }
}
