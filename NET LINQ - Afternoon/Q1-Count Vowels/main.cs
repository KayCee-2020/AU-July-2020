
/******************************************************************************

    Write a Method which will take string as an input. 
    Return count of vowels as output. Implement using LINQ.

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
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
        
            Console.Write("Enter a Sentence : ");
            string word = Console.ReadLine().ToLower();
            Console.Write(word);
        
            int total = word.Count(c => vowels.Contains(c));
            Console.WriteLine(" ");
            Console.WriteLine("Your total number of vowels is: {0}", total);
            Console.ReadLine();
        }
                
    }
    

}
