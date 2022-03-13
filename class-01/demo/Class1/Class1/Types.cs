using System;

namespace Class1
{
    internal class Types
    {
 
        // Can I just add a call o a function directly in the class?
        // Console.WriteLine("This is the types class");

        // What do we have to do so that TestPrint becomes visible in Program class?
        public static void TestPrint()
        {
            Console.WriteLine("This is the Test print Function in the Types calss .. ");
        }

        public static void CSharpTypes()
        {
            // ----------------------------------5- Data types----------------------------------
            /* 
             * 5.1 Numeric types
             * 5.1.1 Integeral types: byte / short / int / long / char
             * whole numbers / no decimal point
            */

            byte wIsOfTypeByte = 255;    // 10, -10, 300
            Console.WriteLine("The value of x is ... " + wIsOfTypeByte);

            short xIsOfTypeShort = 20;  // 20, -20, 32800
            Console.WriteLine("The value of y is ... " + xIsOfTypeShort);

            int yIsOfTypeInt = 1000;     // 30, -30,
            Console.WriteLine("The value of z is ... " + yIsOfTypeInt);

            long zIsOfTypeLong = 40;   // 40, -40
            Console.WriteLine("The value of z is ... " + zIsOfTypeLong);

            // Can we assign a byte variable to an integer variable? YES.
             yIsOfTypeInt = wIsOfTypeByte;              //implicit conversion

            // Can we assign an integer variable to a byte variable? NO.
            wIsOfTypeByte = (Byte)yIsOfTypeInt;         //explicit conversion
            Console.WriteLine("The converted integer into byte ... " + wIsOfTypeByte);

            // What is implicit conversion? and what is explicit conversion?

            // signed and unsigned ...

            // ----------------------------------
            /*
             * char stands for character, and it can hold one single character
             * but if it is a character, why considered an integral type?!
            */

            //char examples go here
            char character = 'A';
            yIsOfTypeInt = character;
            Console.WriteLine("This is the character " + character);
            Console.WriteLine("This is the integer " + yIsOfTypeInt);
            // ----------------------------------

            /*
             * 5.1.2 Floating point types: float, double decimal
             */

            
            float fIsOfFloatType = 1.2f; // why the f?
            Console.WriteLine("The value of f is ... " + fIsOfFloatType);

            double dIsOfDoubleType = 1.2;
            Console.WriteLine("The value of d is ... " + dIsOfDoubleType);

            decimal mIsOfDecimalType = 1.2m;
            Console.WriteLine("The value of m is ..." + mIsOfDecimalType);

            // Which of the previous types can be implicitly coverted to the other? think of it, and test it...

            // ----------------------------------
            /*
             * 5.2 Non-Numeric types
             * 5.2.1 Boolean type
             */

            
            bool thisIsTrue = true;   // 1
            bool thisIsFalse = false; // 0 

            Console.WriteLine("The true variable " + thisIsTrue);



            /*
            * 5.2.2 Strings
            */

            
            String name = "FirstName LastName";
            Console.WriteLine("This is the string that we have " + name);



            // do you think we can do this in C#?
            /*
            var x = "hello";
            var y = 123;
            var z = true;
            */


        }

    }
}











