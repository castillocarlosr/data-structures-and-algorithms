# Data-Structures-and-Algorithms
## Code Challenge: First repeated word in a book. 

## Collaborators
```
Carlos Roberto Castillo
```

# Find the height of a binary tree.
<!-- Short summary or background information -->
Given a string, find the first repeated word.

Return that repeated word.

## Challenge
<!-- Description of the challenge -->
The challenge was to create a Method that would accept a string of any number or words.  Find the first word that is repeated twice and return that word.  Return none if no repeats are found.

## Approach & Efficiency

<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
The approach I took was to bring in the HashTable class used in a previously code challenge  

I created a nethod that took in a string and modified to lowercase.
 The string was then split into an array of words.
  Using a for loop to go through the array and add the words into a HashTable.
   When a collision occurs, return that word.  That is the first repeated word.

### Big O Notation.
```
The Big O of time: O(n)  => has to traverse through the whole array.
The Big O of space: O(n)  => maintains the same size of hashtable.
```

### Checklist

- [x] Read all of these instructions carefully. Name things exactly as described.
- [x] Do all your work in a public repository (matching the example provided by your instructor) called data-structures-and-algorithms, with a well-formatted, detailed top-level README.md
- [x] Create a method called int RepeatedWord()
- [x] Create a branch in your repository named repeated_word
- [x] Create xUnit Tests (at least three per method).
- [x] Pass all Tests

## Solution
<!-- Embedded whiteboard image -->
![](../../assets/firstRepeat.jpg?raw=true)
![](../../assets/FirstRepeat.PNG?raw=true)

Lab started on February 18, 2019 by Carlos R. Castillo
Thanks for stopping by and stay classy Seattle.