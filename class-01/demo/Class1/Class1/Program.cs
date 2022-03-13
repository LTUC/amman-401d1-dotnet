/*1- 
 * using, allows to use types defined in a namespace
 * so the following using statement means we can use any types inside System namespace directly
 */
using System;
/* 2- 
 * But what is a namespace?
 * Namespaces are used to organize the classes
 * They are also used to control scopes of class and method names in large projects
 * Syntac to create a namespace: 
 * namespace namescpace-name {}
 */
namespace Class1
{
    /* 3- 
     * What is object oriented?
     * What is a class? and what is an object?
     * What are access modifiers? (public, protected, internal, private) - will be detailed shortly
     */
    internal class Program
    {
        /* 4-
         * functions or methods
         * function in C# vs in Javascript
         * what is static? why should the main function always be static? what is the entry point?
         */
        static void Main(string[] args)                        //Starting point of the application
        {
            // Where did console come from?
            Console.WriteLine("Hello World!");                  //WriteLine is a static function

            printGoodBye();                                     // we cannot use any non-static members from inside static functions

            Types.TestPrint();

            Types.CSharpTypes();

            Exceptions.functionsExcutor();

            // What if we want to call the TestPrintFunction in the Types Class?

            // What is types class is in a different namespace?

            // C# data types , go to Types class ..

            // Arrays, user input and exceptions. go to Exceptions class
            // Exceptions.functionsExcutor();
        }

        static void printGoodBye()
        {
            Console.WriteLine("Goodbye!");
        }
    }
}
