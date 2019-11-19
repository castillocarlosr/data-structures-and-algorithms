# data-structures-and-algorithms
## Implementation Insertion Sort


## Collaborators
- Carlos Roberto Castillo

# Implement a Insertion Sort
<!-- Short summary or background information -->
Implement an Insertion Sort method:

## Challenge
<!-- Description of the challenge -->
Create a method for Insertion Sort.
- Take in a integer array of any length.
- Return a sorted array.

## Approach & Efficiency

<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
The approach I took was creating a method outside of static Main().
 I start with an outer for-loop on the array.
  I create a temp integer to hold the value at the index.
  I use a while loop to shift all the values of the array over by one.

## Big O Notation
* Average Big O(n^2).  random integers in array will produce a quadratic approach.
* Worst Big O(n^2).  reversed order integers in array will produce a quadratic approach.
* Best Big O(n).  sorted integers in array will simply run through array without sorting.

### Checklist

- [x] Read all of these instructions carefully. Name things exactly as described.
- [x] Do all your work in a public repository called data-structures-and-algorithms, with a well-formatted, detailed top-level README.md
- [x] Create a method called InsertionSort()
- [x] Create a branch in your repository called insertion-sort
- [x] Create xUnit Tests (at least three)
- [X] Pass all Tests.  Tests include randomArray, sortedArray, backwardArray, emptyArray, singleArray

## Solution
<!-- Embedded whiteboard image -->
![](../../assets/InsertionSort.PNG?raw=true)

Lab started on February 17, 2019 by Carlos R. Castillo
Updated on November 19, 2019.
Thanks for stopping by and stay classy Seattle..
