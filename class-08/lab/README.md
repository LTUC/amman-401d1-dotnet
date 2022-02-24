# Lab 08: Phil's Lending Library

## The Problem Domain

Use TDD to create your own Lending Library filled with Books, and a Backpack to hold borrowed Books.

## Program Specifications

Your solution should include the following:

1. Create a `Book` class to hold appropriate properties (e.g. `Title`, `Author`)

1. Copy this interface into your project, then create a `Library` class that implements it:

    ```csharp
    public interface ILibrary : IReadOnlyCollection<Book>
    {
        /// <summary>
        /// Add a Book to the library.
        /// </summary>
        void Add(string title, string firstName, string lastName, int numberOfPages);

        /// <summary>
        /// Remove a Book from the library with the given title.
        /// </summary>
        /// <returns>The Book, or null if not found.</returns>
        Book Borrow(string title);

        /// <summary>
        /// Return a Book to the library.
        /// </summary>
        void Return(Book book);
    }
    ```

    - Since books need to be borrowed by `Title`, use a `private Dictionary<string, Book>` for storage.

1. Copy this interface into your project, then create a generic `Backpack<T>` class that implements it to hold _anything_ (like borrowed `Book`s!):

    ```csharp
    public interface IBag<T> : IEnumerable<T>
    {
        /// <summary>
        /// Add an item to the bag. <c>null</c> items are ignored.
        /// </summary>
        void Pack(T item);

        /// <summary>
        /// Remove the item from the bag at the given index.
        /// </summary>
        /// <returns>The item that was removed.</returns>
        T Unpack(int index);
    }
    ```

    - Since items need to be unpacked by index, use a `private List<T>` for storage.

## Unit Tests

Test that your program has the following functionality:

1. Add a Book to your Library
1. Borrowing an existing title returns the `Book` and remove it
    - Hint: `Assert.DoesNotContain(book, library)`
    - Hint: `Count` should decrease
1. Borrowing a missing title returns `null`
1. A returned book is once again in the Library
    - Hint: `Assert.Contains(book, library)`
    - Hint: `Count` should increase
1. Pack and Unpack your Backpack
    - Hint: Backpack can store _anything_ so it may be easier to test with `string` or `int` instead of Book`

## Stretch Goals

1. Update your DSA `LinkedList` to implement `IEnumerable<int>`
    - Hint: `Assert.Equals(list, new[] { 1, 2, 3 })`
1. Update your DSA `LinkedList` to be generic, i.e. `class LinkedList<T> : IEnumerable<T>`
    - Be careful with `using`s, as `System.Collections.Generic` also contains `LinkedList<T>`
1. Update `Library` to allow case-insensitive search by title
1. Add a Console user interface:
    - Use a method `LoadBooks()` to add some initial books to your Library.
    - Use a method `UserInterface` to prompt the user with different options:
      - View all Books
        - Hint: Consider overriding `ToString()` on `Book` to make displaying easier
      - Add a Book
        - Prompt for all properties, then add to your `Library`
      - Borrow a book
        - Prompt for title
        - What if Library is empty?
      - Return a book
        - List numbered book bag and prompt for index (or maybe number, since normal people don't count from 0?)
        - What if book bag is empty?
      - View Book Bag
      - Exit
    - Use individual methods to implement each option

## README

**A Readme is a requirement. No Readme == No Grade.**

Here are the requirements for a valid readme:

A README is a module consumer's first -- and maybe only -- look into your creation. The consumer wants a module to fulfill their need, so you must explain exactly what need your module fills, and how effectively it does so.

Your job is to:

1. tell them what it is (with context, provide a summary)
1. show them what it looks like in action (Visuals)
1. show them how they use it (Step by step directions, "Happy Path" walk through)
1. tell them any other relevant details

This is ***your*** job. It's up to the module creator to prove that their work is a shining gem in the sea of slipshod modules. Since so many developers' eyes will find their way to your README before anything else, quality here is your public-facing measure of your work.

Refer to the sample-README in the class repo `Resources` folder for an example.

- [Reference](https://github.com/noffle/art-of-readme){:target="_blank"}

## Rubric

The lab rubric can be found [HERE](../../resources/rubric){:target="_blank"}

## To Submit this Assignment

- Create a new repo on your personal GitHub account
- Name your repo `Lab##-TITLE`
- Create a branch named `NAME-LAB##`
- Write your code
- Commit often
- Push to your repository
- Create a pull request from your branch back your `main` branch.
- Submit a link to your PR in canvas
- Merge your PR back into main
- In Canvas, Include the actual time it took you to complete the assignment as a comment (**REQUIRED**)
- Include a `README.md` (contents described above)
