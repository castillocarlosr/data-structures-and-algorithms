# data-structures-and-algorithms
## Code Challenge 03 Binary Search
Code401 

## Collaborators
- Carlos Roberto Castillo
- Nate Tibbals


# Find the index of a given value
<!-- Short summary or background information -->
Take in any single integer and be able to find the index position in the sorted array.

## Challenge
<!-- Description of the challenge -->
The challenge was to be given an unknow array and unknown seperate integer outside of the array.  The integer is to be located efficiently inside the array and return the index position.

## Approach & Efficiency

<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
The approach we took is using the array using the binary search.

The method takes the length of the array and divides in half to get the middle point.  The method looks at the middlepoint and compares to the value it's looking for.  If they match, GREAT!  Return index of that value.  If not, the search method looks at the number below and above the mid-point for the value it is searching.  Because the array is sorted, the method will know which side the value lays in.  The method determines which side to continue on.

The method then takes that side of the array and repeats the same steps again.
It keeps cutting the array in half until it finds the value and returns its index.

If the value does not exsist inside the array, it will break out of the binary search and return a -1.

The Big O is a Big O(log n). "logarithim notation"

### Checklist

- [x] Read all of these instructions carefully. Name things exactly as described, or you will get a ZERO without comment
- [x] Do all your work in a public repository (matching the example provided by your instructor) called data-structures-and-algorithms, with a well-formatted, detailed top-level README.md
- [x] Create a branch in your repository called InsertShiftTab
- [x] On your branch, create a method named BinarySearch() outside of Main() in your Program.cs file. Call Your newly created method in Main() once complete.
- [x] Create xUnit Tests (at least three)
- [?] Pass all Tests

## Solution
<!-- Embedded whiteboard image -->
![](../../assets/BinarySearch.JPG?raw=true)

Lab started on January 09, 2019 by Carlos R. Castillo
Thanks for stopping by and stay classy Seattle.
