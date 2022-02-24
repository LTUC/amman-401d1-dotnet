# Lab 02: Unit Testing

Read the lab, in its entirety, before continuing.

## The Problem Domain

- Create a bank "ATM" program within a console application

## Program Specifications

Using Test Driven Development, build out a console application that mocks the functionality of an ATM. Your solution should include the following methods:

1. `Main` method

- Call the user interface method to activate the application

1. Testable external methods:

   - `ViewBalance()`
      - **Functionality**: Returns the value of the current balance
      - **Return**: decimal
      - Test to ensure that the balance properly shows the correct amount after each transaction
   - `Withdraw()`
      - **Functionality**: Subtracts money from the balance
      - **Return**: decimal
      - Do not allow the user to withdraw more money than what's available.
      - Do not allow the user to withdraw a value less than zero.
   - `Deposit()`
      - **Return**: decimal
      - **Functionality**: Adds money to the balance
      - Do not allow the user to deposit a negative amount
      - Variable to hold the current Balance of the account.
      - Make this a `static public decimal Balance` variable, declared *above* the `Main()` method. This will allow you to access the `Balance` variable anywhere in this `Program.cs` file.

1. User interface that prompts the user for standard ATM operations that links to each of the above external methods

- **Return** : void
- Keep asking the user to choose a transaction until they choose to 'exit' the application. (while loop??)
- This method is where you will want to hold all of your `Console.ReadLine`s.
- This method does NOT need to be tested.

1. A few things to keep in mind:

   - Make sure the user can't go below a zero balance.
   - You **cannot** unit test console `WriteLine` or `Readline`s.
   - Make sure your methods are just returning values and not reading input from the console.
   - Remember to use the proper data types while working within the program. Money is usually represented by decimals.
   - All methods within the program class should start their method signature with `static public` followed by the return type and method name. Example `public static void UserInterface()`

1. When running your application, it should activate the user interface without any direct code manipulation.

   - **Stay within scope of the what we have learned so far in the class.**
     - If we have not officially learned the concept you are trying to implement, then don't use it.
     - Ask the instructor or TA if you have any questions about the scope.

## Unit Tests

Write unit tests in a new project using the XUnit library. Test the functionality for the above application.
Here are the testing requirements:

- Test every method/action (that does not require user input); there should be a passing valid input, and a passing invalid input.
- Have at least 2 tests for every non-void method.
- **A failing test, is not a valid test** - even if the failure is expected.

## Stretch Goals

- Record each transaction the user records and when they exit, provide a receipt for every transaction they conducted.

## README

**A Readme is a requirement. No Readme == No Grade.**
Here are the requirements for a valid readme:

A README is a module consumer's first -- and maybe only -- look into your creation. The consumer wants a module to fulfill their need, so you must explain exactly what need your module fills, and how effectively it does so.

Your job is to

1. Tell them what it is (with context, provide a summary)
1. Show them what it looks like in action (Visuals)
1. Show them how they use it (Step by step directions, "Happy Path" walk through)
1. Tell them any other relevant details

This is ***your*** job. It's up to the module creator to prove that their work is a shining gem in the sea of slipshod modules. Since so many developers eyes will find their way to your README before anything else, quality here is your public-facing measure of your work.

Refer to the README templates in the class repo `Resources` folder for an example.

- [Reference](https://github.com/noffle/art-of-readme){:target="_blank"}

## Rubric

The lab rubric can be found [Here](../../resources/rubric){:target="_blank"}

## To Submit this Assignment

- Create a new repo on your personal GitHub account
- Name your repo `Lab##-TITLE`
- Create a branch named `NAME-LAB##`
- Write your code
- Commit often
- Push to your repository
- Create a pull request from your branch back to main
- Submit a link to your PR in canvas
- In Canvas, Include the actual time it took you to complete the assignment as a comment (**REQUIRED**)
- Include a `README.md` (contents described above)
