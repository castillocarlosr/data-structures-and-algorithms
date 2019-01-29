using System;
using Xunit;
using System.Collections.Generic;
using FizzBuzzTree;
using Trees.Classes;

namespace FizzBuzzTreeTDD
{
    public class UnitTest1
    {
        [Fact]
        public void FizzBuzz()
        {
            Node root = new Node(15);
            Node nodeTwo = new Node(3);
            Node nodeThree = new Node(4);
            Node nodeFour = new Node(5);
            BinaryTree fizzBuzz = new BinaryTree(root);
            fizzBuzz.Root.LeftChild = nodeTwo;
            fizzBuzz.Root.RightChild = nodeThree;
            fizzBuzz.Root.LeftChild.LeftChild = nodeFour;
            List<string> Fizz = new List<string>() { "FizzBuzz" };

            Assert.Equal(Fizz, Program.TraversePreOrder(fizzBuzz.Root));
        }


        [Fact]
        public void Buzz()
        {
            Node root = new Node(10);
            Node nodeTwo = new Node(15);
            Node nodeThree = new Node(4);
            Node nodeFour = new Node(5);
            BinaryTree fizzBuzz = new BinaryTree(root);
            fizzBuzz.Root.LeftChild = nodeTwo;
            fizzBuzz.Root.RightChild = nodeThree;
            fizzBuzz.Root.LeftChild.LeftChild = nodeFour;
            List<string> Buzz = new List<string>() { "Buzz" };

            Assert.Equal(Buzz, Program.TraversePreOrder(fizzBuzz.Root));
        }

        [Fact]
        public void Fizz()
        {
            Node root = new Node(9);
            Node nodeTwo = new Node(15);
            Node nodeThree = new Node(4);
            Node nodeFour = new Node(5);
            BinaryTree fizzBuzz = new BinaryTree(root);
            fizzBuzz.Root.LeftChild = nodeTwo;
            fizzBuzz.Root.RightChild = nodeThree;
            fizzBuzz.Root.LeftChild.LeftChild = nodeFour;
            List<string> Fizz = new List<string>() { "Fizz" };

            Assert.Equal(Fizz, Program.TraversePreOrder(fizzBuzz.Root));
        }

        [Fact]
        public void NoFizzOrBuzz()
        {
            Node root = new Node(2);
            Node nodeTwo = new Node(15);
            Node nodeThree = new Node(4);
            Node nodeFour = new Node(5);
            BinaryTree fizzBuzz = new BinaryTree(root);
            fizzBuzz.Root.LeftChild = nodeTwo;
            fizzBuzz.Root.RightChild = nodeThree;
            fizzBuzz.Root.LeftChild.LeftChild = nodeFour;
            List<string> value = new List<string>() { "2" };

            Assert.Equal(value, Program.TraversePreOrder(fizzBuzz.Root));
        }
    }
}
