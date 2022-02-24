# Lab 03: Review

Let's spend this lab assignment evaluating your overall comfort level with C# from what we have learned so far.

## Problem Domain

Create a single Console Application Project within Visual Studio. Write all of your code in the `Program.cs` file. with a method for each of the challenge below. Call each of these methods in your main method.

Be sure to use exception handling where appropriate, and write tests as outlined in each of the challenges.

Whiteboard at least one of the challenges and include it in your readme. If you are working in groups, every person in the group must have their own whiteboard for a different problem.

### Challenge 1

Write a program that asks the user for 3 numbers. Return the product of these 3 numbers multiplied together.
If the user puts in less than 3 numbers, return 0;
If the user puts in more than 3 numbers, only multiply the first 3.
If the number is not a number, default that value to 1.

Example:

```text
Please enter 3 numbers: 4 8 15
The product of these 3 numbers is: 480
```

Hint: Consider using the [split method](https://docs.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split){:target="_blank"}

Tests:

   1. Input a string of numbers and it returns a product of all numbers
   2. Input more than 3 numbers
   3. Input of less than 3 numbers
   4. Can it handle negative numbers

### Challenge 2

Create a method that asks the user to enter a number between 2-10. Then, prompt the user that number of times for random numbers.

After the user has inputted all of the numbers. Find the average of all the numbers inputted.

Specs:
    1. Do not let the user put in negative numbers
    2. Confirm each input is a real number

Example:

```text
Please enter a number between 2-10: 4

1 of 4 - Enter a number: 4
2 of 4 - Enter a number: 8
3 of 4 - Enter a number: 15
4 of 4 - Enter a number: 16
```

The average of these 4 numbers is: 10

Tests:

   1. Input different ranges of numbers and confirm averages
   2. Confirm input
   3. All numbers are 0s

### Challenge 3

Create a method that will output to the console the following design. Pay attention to spacing.

```javascript

    *
   ***
  *****
 *******
*********
 *******
  *****
   ***
    *

```

Tests:

1. No tests are required

### Challenge 4

Write a method that brings in an integer array and returns the number that appears the most times.
If there are no duplicates, return the first number in the array.
If more than one number show up the same amount of time, return the first found.

```text
 Example: Input: [1,1,2,2,3,3,3,1,1,5,5,6,7,8,2,1,1]
 output: 1
 ```

Tests:

1. Input different size arrays
2. All numbers in the array are the same value
3. No duplicates exist in the array
4. There multiple numbers that show up the same amount of times.

### Challenge 5

Write a method in that finds the maximum value in the array. The array is not sorted. You may not use `.Sort()`

```text
Example: input [5, 25, 99, 123, 78, 96, 555, 108, 4]

return: 555
```

Tests:
    1. Negative numbers
    2. All values are the same

### Challenge 6

Write a method that asks the user to input a word, and then saves that word into an external file named `words.txt`

Hint: Have a file already saved in the root of your directory with a couple of words already present in the file.

Stretch:
    1. Tests are optional for this challenge

### Challenge 7

Write a method that reads the file in from Challenge 6, and outputs the contents to the console.

Stretch:
    1. Tests are optional for this challenge

### Challenge 8

Write a method that reads in the file from Challenge 6. Removes one of the words, and rewrites it back to the file.

Stretch:
    1. Tests are optional for this challenge

### Challenge 9

Write a method that asks the user to input a sentence and returns an array that with the word and the number of characters each word has:

```text
Example: input: "This is a sentance about important things"
Output: ["this: 4","is: 2", "a: 1", "sentance: 8", "about: 5", "important: 9", "things: 6"]
```

Tests:
    1. Input a sentence, and it returns the correct array
    2. Input a sentence and confirm it returns an array
    3. Use different sentences with different symbols
