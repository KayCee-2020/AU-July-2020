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
    public class demo{
        static void Main()
        {
                // Build a list of vowels up front:
                String[] StudentNames = {"Khushbu","Anusheeka","Siddharth","Seema","Meena","Bobby"};
        
            // Creating LINQ Query 
            var res = from s in StudentNames 
                      where s.Contains("ee") 
                      select s; 
      
            // Executing LINQ Query 
            foreach(var q in res) 
            { 
                Console.WriteLine(q); 
            } 
                
        }
    }
    

}
