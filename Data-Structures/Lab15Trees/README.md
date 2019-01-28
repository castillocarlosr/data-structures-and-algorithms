# data-structures-and-algorithms
## Code Challenge 15 Trees
Code401 

# Create a Binary Tree & Binary Search Tree
<!-- Short summary or background information -->
Create a Binary Tree that contains methods preOrder, inOrder, and postOrder.
Create a Binary Search Tree that contains methods add & contains.

## Challenge
<!-- Description of the challenge -->
```
Binray Tree:
- Be able to create a new Binary Tree.
- Be able to add node to Binary Tree.
- Be able to to traverse the Binary true using Depth First - PreOrder (Root, Left, Right).
- Be able to to traverse the Binary true using Depth First - InOrder (Left, Right, Root).
- Be able to to traverse the Binary true using Depth First - PostOrder (Left, Right, Root).
```
```
Binary Search Tree:
- Be able to create a new Binary Search Tree.
- Be able to add a node to be place in the proper place of a Binary Search Tree.
- Be able to determine if the Binary Search Tree contains a node.  Return true or false.
```
## Approach & Efficiency

<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
The approach I took was creating a three classes.  Node class, BinaryTree class, and BinarySearchTree class.
- Created properties in the Node class for value, leftChild, and rightChild.  Created method BinaryTree, PreOrder, InOrder, and PostOrder.
- Created property in the Binary Tree class for Node Root.  Created methods for Push, Pop, and Peek.
- Created properties in the Binary Search Tree for Node Root.  Created methods for BinarySearchTree, Add, and Contains.

## Big O Notation
* For all methods in Binary Tree:  time Big O(n).
* For all methods in Binary Tree:  space Big O(n).
* For all methods in Binary Search Tree:  time Big O(log n).
* For all methods in Binary Search Tree:  space Big O(n.

### Checklist

- [x] Read all of these instructions carefully. Name things exactly as described.
- [x] Do all your work in a public repository (matching the example provided by your instructor) called data-structures-and-algorithms, with a well-formatted, detailed top-level README.md
- [x] Create a branch in your repository called tree
- [x] Create xUnit Tests, at least three per method.
- [X] Pass all Tests.

## Solution
<!-- Embedded whiteboard image -->
![](../../assets/Tree.PNG?raw=true)
![](../../assets/TreeSearch.PNG?raw=true)

Lab started on January 27, 2019 by Carlos R. Castillo
Thanks for stopping by and stay classy Seattle..
