using System;

namespace Class4
{

    /*
     * Object oriennted programming 
     * Clsass vs Object
     * What do we mean by static?
     * How do we create an object?
     * Constructors - How many constructors should/can I have? - What is a default constructor
     * Object initializers 
     * Properties , backing fields ,  auto implemented properties
     * methods
     * method overload 
     * Nested classes
     * 
     * value vs reference type
     * Stack vs Heap
     * Garbage Collection
     * 
     */

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            Person fadi = new Person("Fadi","Hadi");        // Function - Constructor  
            Console.WriteLine("The person's name is ...  " + fadi.FName + " " + fadi.LName);
            fadi.FName = "Laith";
            Console.WriteLine("The person's name is ...  " + fadi.FName + " " + fadi.LName);

            Car bmw = new Car();
            Car cadillac = new Car("Cadillac");

            Car vw = new Car {model = "vw", type="R", manufacturer="Germany" };

            Car hunda = new Car("hunda") { type = "R", manufacturer = "Japan" };

        }
    }

    public class Person             // each class has atleast 1 constructor - provided by default if you don't create it
    {   

        // proptries 
        public string FName
        { get;set;}

        public string LName
        {
            get; set;
        }



        public Person(string first, string last)
        {
            FName = first;
            LName = last;
        }

    }

    public class Car
    {
        public string model;
        public string type;
        public string manufacturer;

        public Car()
        {

        }

        // OverLoading 
        public Car(string model)
        {
            this.model = model;
        }


    }
}
