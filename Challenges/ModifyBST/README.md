# Data-Structures-and-Algorithms

## Add values greater in Binary Search Tree

#### Coding to keep mind sharp

### Challenge
* Given a BST, add all the values greater than the current node starting from the greatest node and working backwards.

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
Challenge started on August 11, 2019