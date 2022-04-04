using System;
using System.Collections.Generic;

namespace Class08
{
    internal class Program
    {

        /*
         * Enums 
         * Some data needs to be normalized and standarzied 
         * Avoid trusting user spelling
         * Think of boolean (true, false) (1,0)  .. but is two always an enough number ?
         * Week days? Months? ...
         * 
         * So What are enums?
         * constant values, that are behind the scenes; auto incrementing numerics
         * 
         * Think of creating a Date class ... 
         */

        /*
         * Collections
         * If the language is to provide us with a collection type that can contain any type of objects
         * how can this be done?!
         * What is the common inherited class by all created classes?
         * How can this be used in a case such as the mentioned?
         * 
         * What is a dictionary?
         * What if we need to use key-values structure?
         * How to add? how to return values?
         * Can we loop?
         * 
         * What if I want to create my own collection?!
         */


      
        static void Main(string[] args)
        {

            //Date date = new Date();
            //date.DayOfMonth = 2;
            //date.Day = DayOfTheWeek.Monday;
            //date.Month = MonthOfTheYear.Apr;

            //Date date2 = new Date();
            //date2.DayOfMonth = 2;
            //date2.Day = DayOfTheWeek.Monday;
            //date2.Month = MonthOfTheYear.Apr;



            //if (date.Equals(date2))
            //    Console.WriteLine("They are equal !! ");
            //else
            //    Console.WriteLine("They are not equal !! ");

            List<string> StudentsNames = new List<string>();
            List<Date> DatesList = new List<Date>();



            // contains .... 
            StudentsNames.Add("Haneen");
            StudentsNames.Add("Ahmad");
            StudentsNames.Add("Osama");
            StudentsNames.Add("Ola");
            StudentsNames.Add("Yousef");

            //for(int i = 0; i < StudentsNames.Count; i++)
            //{
            //    Console.WriteLine(" element " + i + ":" + StudentsNames[i]);

            //}

            //foreach(String s in StudentsNames)
            //{
            //    Console.WriteLine(s);
            //}

            //StudentsNames.ForEach(delegate (string name)
            //{
            //    Console.WriteLine(name);
            //});

            //StudentsNames.Remove("Ola");

            //StudentsNames.ForEach(delegate (string name)
            //{
            //    Console.WriteLine(name);
            //});


            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("12345","Ahmad");
            students.Add("54321", "Mohammad");
            students.Add("67891", "Fadi");

            //foreach(KeyValuePair<string,string> entry in students)
            //{
            //    Console.WriteLine(entry.Key);
            //    Console.WriteLine(entry.Value);
            //}

           Dictionary<string,string>.ValueCollection values = students.Values;
           
            students.TryGetValue("12345", out string x);
            Console.WriteLine(x);



        }
    }

    // Date class example

    class Date
    {
        public int DayOfMonth { get; set; }
        public DayOfTheWeek Day { get; set; }
        public MonthOfTheYear Month {get;set;}

        // day of week
        // month of the year
        public int Year { get; set; }

        public override string ToString()
        {
            return "date: " + this.Month + " " + this.DayOfMonth + " " + this.Year;
        }

        public override bool Equals(object obj)
        {
            return this.Day == ((Date)obj).Day && this.DayOfMonth == ((Date)obj).DayOfMonth;
        }
    }

    enum DayOfTheWeek
    {
        Saturday,   // 0
        Sunday,     // 1
        Monday,     // 2
        Tuesday,    // 3
        Wednesday,  // 4
        Thursday,   // 5
        Friday      // 6
    }

    enum MonthOfTheYear : byte
    {
        Jan,
        Feb,
        Mar,
        Apr,
        May,
        June,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec
    }
}
