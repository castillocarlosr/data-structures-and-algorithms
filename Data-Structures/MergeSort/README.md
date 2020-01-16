# data-structures-and-algorithms

## Sort an array

###### Coding Data Structures and Algorithims to keep my mind sharp.
* Use merge sort to sort an array from least to greatest.

### Challenge
* Given an array, return the same array from least to greatest.
- Use merge sort.
- Return that same array.

#### Logic
The idea behind MergeSort is to divide and conquer the array.  Break down the array recursively in halfs until the array is down to one.  Then start putting the seperated arrays together from least to greatest.  Repeat until a new array is built.

That is merge sort.  You can also use List<int> which makes sizing a bit easier.

### Big O
- Time: O(n log(n))
- Space: O(n)


![](../../assets/MergeSort.PNG?raw=true)

```
Carlos Castillo
```
Challenge started on January 16, 2020