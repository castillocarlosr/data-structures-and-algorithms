# Data-Structures-and-Algorithms

## Add values greater in Binary Search Tree

#### Coding to keep the mind sharp

### Challenge
* Given a BST(Binary Search Tree), modify it so that all the nodes are added to every node as you traverse backward starting from the rightmost leaf node.
<p>Hopefully this makes sense to you the reader because I was asked this in my interview with HCL.</p>
<p>1)  Starting from the bottom right leaf, move left which is to say move up to the parent and add the right child value to the parent node.  That is the new value of the parent node.</p>
<p>2)  Continue to move left which means traverse to the left child.  Add the parent's value to the left-child and that is the new value for the left child node.</p>
<p>3)  Continue to move left which means you traverse to the parent of the parent(already visited).  Add the parent's value to the grand-parent and that is the new value for the grand-parent node.</p>

******************************************************************************************************

* Example:
- Input:
Binary Search Tree:

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 5

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; /&nbsp; &nbsp;&nbsp;\

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;3&nbsp; &nbsp;&nbsp; 7

&nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; /&nbsp; &nbsp;\ &nbsp;&nbsp; /&nbsp; &nbsp;\

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;2&nbsp; &nbsp; 4 &nbsp; 6 &nbsp; 8

- Output:
Modified Binary Search Tree:

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 26

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; /&nbsp; &nbsp;&nbsp;\

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;33&nbsp; &nbsp;&nbsp; 15

&nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; /&nbsp; &nbsp;\ &nbsp;&nbsp; /&nbsp; &nbsp;\

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;35&nbsp; &nbsp; 30 &nbsp; 21 &nbsp; 8

******************************************************************************************************

![](../../assets/ModifyBST2.PNG?raw=true)

```
Carlos Castillo
```
The challenge started on August 11, 2019
