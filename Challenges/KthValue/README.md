# data-structures-and-algorithms
## Code Challenge 07 K-th Value
Code401 

## Collaborators
- Carlos Roberto Castillo
- Shalom Belaineh


# Find the index of a given value
<!-- Short summary or background information -->
Take in any value as "k" to be the parameter as the number starting from the end of the linked list working to the front.

Return that value.

## Challenge
<!-- Description of the challenge -->
The challenge was to be given a parameter of k as an integer.  That K is the starting position from the end of the linked list.  Starting from null working its way to head.

## Approach & Efficiency

<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
The approach we took is using the current "Current", "Head", and adding a new node like "Current" called "Pointer".  Also made a counter starting at zero and counting every time the current.next moves.

The method takes the value of K and starts the method.  The Current and counter move while Pointer stays still until counter is greater than K.  The Pointer moves until Current hits null.  When that happens, where Pointer lands is where that Value is returned.


The Big O is a Big O(n). 

### Checklist

- [x] Read all of these instructions carefully. Name things exactly as described, or you will get a ZERO without comment
- [x] Do all your work in a public repository (matching the example provided by your instructor) called data-structures-and-algorithms, with a well-formatted, detailed top-level README.md
- [x] Create a branch in your repository called InsertShiftTab
- [x] On your branch, create a method named ll_kth_from_end() outside of Main() in your Program.cs file. Call Your newly created method in Main() once complete.
- [x] Create xUnit Tests (at least three)
- [?] Pass all Tests

## Solution
<!-- Embedded whiteboard image -->
![](../../assets/KthValue.jpg?raw=true)
![](../../assets/KthValue.PNG?raw=true)

Lab started on January 16, 2019 by Carlos R. Castillo
Thanks for stopping by and stay classy Seattle.
