# data-structures-and-algorithms
## Code Challenge 02 Insert Shift Array
Code401 

## Collaborators
- Carlos Roberto Castillo
- Nate Tibbals


# Insert and shift middle index of array
<!-- Short summary or background information -->
Take in any single integer and be able to insert in the middle of a given array and shift the rest of the numbers to the right in the array.

## Challenge
<!-- Description of the challenge -->
The challenge was to be given an unknow array and unknown seperate integer outside of the array.  The integer was to be inserted into the middle of the array.

## Approach & Efficiency

<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
The approach we took is creating a new array compared to the old array but adding one to the length.

Next step was getting the length of the old array, divide by 2, and set that as a "mid point" variable.  Then create a for loop to push the items of the old array to the new array until the middle point(the mid point variable).  

The outside value would then be added to the new array.
The for loop would then continue filling the new array from the old array.

The Big O was a O(n) linear notation.

### Checklist

- [x] Read all of these instructions carefully. Name things exactly as described, or you will get a ZERO without comment
- [x] Do all your work in a public repository (matching the example provided by your instructor) called data-structures-and-algorithms, with a well-formatted, detailed top-level README.md
- [x] Create a branch in your repository called InsertShiftTab
- [x] On your branch, create a method named ArrayShift() outside of Main() in your Program.cs file. Call Your newly created method in Main() once complete.
- [x] Create xUnit Tests (at least three)
- [x] Pass all Tests

## Solution
<!-- Embedded whiteboard image -->
![](/../assets/insertShiftArray1.PNG?raw=true)

Lab started on January 08, 2019 by Carlos R. Castillo
Thanks for stopping by and stay classy Seattle.
