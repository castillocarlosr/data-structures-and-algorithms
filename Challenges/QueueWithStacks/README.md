# data-structures-and-algorithms
## Code Challenge 11 Implement a Queue using two Stacks
Code401 

## Collaborators
- Carlos Roberto Castillo
- Sean Miller


# Create a PseudoQueue class
<!-- Short summary or background information -->
Create a new PseudoQueue class that acts like a Queue but uses Two Stacks to do so.

Return that value.

## Challenge
<!-- Description of the challenge -->
The challenge was to be given a parameter of k as an integer.  That K is the starting position from the end of the linked list.  Starting from null working its way to head.
The challenge was to use implement a standard queue interface but internally only use two stack objects.
The class should have Enqueue and Desqueue methods and operate as such.

## Approach & Efficiency

<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
The approach I took was creating two stack.  One for "loading" and another for "unloading" nodes.  

I then declare an Enqueue method that creates a temp node and pop's the Unload method while assigning the node to temp.  Then that temp is pushed into the Load stack.

I then declare an Desqueue method that creates a temp node and pop's the Load method while assigning it to node temp.  Then the temp is pushed into the Unload stack.   When the Load stack is empty, the Unstack method then Pop's the top node.


The Big O of time: O(n)
The Big O of space: O(1) 

### Checklist

- [x] Read all of these instructions carefully. Name things exactly as described, or you will get a ZERO without comment
- [x] Do all your work in a public repository (matching the example provided by your instructor) called data-structures-and-algorithms, with a well-formatted, detailed top-level README.md
- [x] Create a branch in your repository called InsertShiftTab
- [x] On your branch, create a method named ll_kth_from_end() outside of Main() in your Program.cs file. Call Your newly created method in Main() once complete.
- [x] Create xUnit Tests (at least three)
- [x] Pass all Tests

## Solution
<!-- Embedded whiteboard image -->
![](../../assets/QueueWithStacks.jpg?raw=true)
![](../../assets/QueueWithStacks.PNG?raw=true)
The screenshot shows a console writeline from the previous reference that would return a "Null returned" in the console but actually returns a value.

Lab started on January 22, 2019 by Carlos R. Castillo
Thanks for stopping by and stay classy Seattle.
