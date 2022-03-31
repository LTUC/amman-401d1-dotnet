using System;

namespace Class7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // I can use an interfae reference, to store object instance that implements that interface
            IDrivable Idrivable = new Car();

            Employee emp = new Employee();
            emp.Drive(Idrivable);
        }
    }

    class Employee : IDrive
    {
        string Name;
        string ID;
        public string License
        {
            get; set;
        }

        public void Drive(IDrivable Drivable)
        {
            Drivable.Start();
            Drivable.Accelerate();
        }
    }

    class Airplane : IDrivable
    {
        string Type;

        public void Accelerate()
        {
            Console.WriteLine("This is how a plane accelerates");
        }

        public void Start()
        {
            Console.WriteLine("This is how a plane starts");
        }

        public void Break()
        {
            Console.WriteLine("This is how a plane breaks");
        }

        public void Stop()
        {
            Console.WriteLine("This is how a plane stops");
        }

    }

    class Car : IDrivable
    {
        string Model;
        string Manufacturer;
        string ModelYear;

        void IDrivable.Accelerate()
        {
            Console.WriteLine("This is how a car accelerates");
        }

        void IDrivable.Break()
        {
            Console.WriteLine("This is how a car breaks");
        }

        void IDrivable.Start()
        {
            Console.WriteLine("This is how a car starts");
        }

        void IDrivable.Stop()
        {
            Console.WriteLine("This is how a car stops");
        }

        // functions ... 
    }

    class Robot : IDrive,IDrivable
    {
        public string License
        {
            get;set;
        }

        public void Accelerate()
        {
            Console.WriteLine("This is how a robot accelerates");
        }

        public void Start()
        {
            Console.WriteLine("This is how a robot starts");
        }

        public void Break()
        {
            Console.WriteLine("This is how a robot breaks");
        }

        public void Stop()
        {
            Console.WriteLine("This is how a robot stops");
        }


    }

    interface IDrivable
    {
        // mutiple inheritance 
        // 
        void Start();
        void Stop();
        void Accelerate();
        void Break();
    }

    interface IDrive
    {
        string License
        {
            get;set;
        }
    }

}
