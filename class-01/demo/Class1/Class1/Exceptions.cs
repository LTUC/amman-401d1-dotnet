using System;

// User input and exceptions .. 
// How to identify, plan and handle errors through exception handling
// Control what system does when an error occurs!
namespace Class1
{
    internal class Exceptions
    {
        // 1- create an array , can we create an array without specifying a size in C#? NO.
        static int[] arrayOfIntegers = { 1, 2, 3, 4, 5 };


        public static void functionsExcutor()
        {
            // add functions calls here
            printArrayContent(arrayOfIntegers);
        }

        public static void printArrayContent(int[] arr)
        {
            Console.Write("Array content");

            try
            {
                for (int i = 0; i <= arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Something wrong happened " + e.Message);
               
            } finally
            {
                Console.WriteLine("This line comes after the error");
            }

            
        }

        /* 2- create a function that takes in an array, and prints its conntent
         - what if < is replaced with <=
         - if we have code after the one that caused the error, will it be excuted?
         - surround the code you expect to cause errors with a try, how can we deal with the error after?
         - what should we add as a type for the catch? what if I add Exception?
         - can I add multiple catch blocks? does the order make difference?
         - what if there is a peice of code that I want to run either ways?
        */
     
        /*
         * 3- create a function that takes in two numbers from the user (how?)
         * convert the user input into integers (what errors might occur here? how should we handle them?)
         * perform the basic arethmetic ooerations on the two numbers, what errors might occur?
         */

    }
}
