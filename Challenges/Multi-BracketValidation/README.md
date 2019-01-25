# data-structures-and-algorithms
## Code Challenge 13 Multi-bracket Validation.
Code401 

## Collaborators
```
- Carlos Roberto Castillo
- Sean Miller
```


# Create a Multi-bracket Validation
<!-- Short summary or background information -->
Create a console application to take in a string and determine if the brackets have a proper open and close.

Return that true or false.

## Challenge
<!-- Description of the challenge -->
```
The challenge was to create a Method that would accept a string input with brackets and check if they are properly typed with the correct opening and closing.  Sort of like a linter.  Only it would return a true or false boolean instead.

- Round Brackets : ()
- Square Brackets : []
- Curly Brackets : {}
```

## Approach & Efficiency

<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
The approach I took was creating a method called MultiBracketValidation(string input).

The string input would be converted into a Char array.

In the method I wrote in logic that would create a stack to take in the Char characters.

The stack would then begin to pop of Char character and look for brackets.

If the first bracket is an open bracket, return fail.

If the first bracket is a close bracket, check for it's next open matching bracket.  If found, pop.  Keep repeating until stack is empty.  Then return true if all criteria is matched.  


### Big O Notation.
```
The Big O of time: O(n)
The Big O of space: O(1) 
```

### Checklist

- [x] Read all of these instructions carefully. Name things exactly as described, or you will get a ZERO without comment
- [x] Do all your work in a public repository (matching the example provided by your instructor) called data-structures-and-algorithms, with a well-formatted, detailed top-level README.md
- [x] Create a branch in your repository called multi-bracket-validation
- [x] On your branch, create a method named bool MultiBracketValidation(string input) outside of Main() in your Program.cs file. 
- [x] Call Your newly created method in Main() once complete.
- [x] Create xUnit Tests (at least three per method).  Only one method.
- [?] Pass all Tests

## Solution
<!-- Embedded whiteboard image -->
![](../../assets/MultiBracketValidation.jpg?raw=true)
![](../../assets/BracketValidation.PNG?raw=true)

Lab started on January 24, 2019 by Carlos R. Castillo
Thanks for stopping by and stay classy Seattle.
