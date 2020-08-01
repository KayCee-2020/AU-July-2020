/******************************************************************************

    Create a string array with student's names. Write a method
    which returns the student name containing "ee" in it.

*******************************************************************************/
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
namespace LinqDemo
{
    class Dancer
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int ID { get; set; }
    }
    
    class Singer
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int ID { get; set; }
    }
    
    public class demo{
        static void Main()
        {
            // Create a list of dancers
            List<Dancer> Dancers = new List<Dancer> {
                new Dancer { Fname = "Terry", Lname = "Adams", ID = 522459 },
                 new Dancer { Fname = "Charlotte", Lname = "Weiss", ID = 204467 },
                 new Dancer { Fname = "Magnus", Lname = "Hedland", ID = 866200 },
                 new Dancer { Fname = "Vernette", Lname = "Price", ID = 437139 } };
        
            // Create a list of Singers
            List<Singer> Singers = new List<Singer> {
                new Singer { Fname = "Vernette", Lname = "Price", ID = 9562 },
                new Singer { Fname = "Terry", Lname = "Earls", ID = 9870 },
                new Singer { Fname = "Terry", Lname = "Adams", ID = 9913 } };
        
            // Join the two data sources based on a composite key consisting of first and last name,
            // to determine which Dancer is also a Singer.
            IEnumerable<string> query = from Dancer in Dancers
                                        join Singer in Singers
                                        on new { Dancer.Fname, Dancer.Lname }
                                        equals new {Singer.Fname, Singer.Lname }
                                        select Dancer.Fname + " " + Dancer.Lname;
        
            Console.WriteLine("The following people are both dancer and singer:");
            foreach (string name in query)
                Console.WriteLine(name);
        }
        
    }
    
}
