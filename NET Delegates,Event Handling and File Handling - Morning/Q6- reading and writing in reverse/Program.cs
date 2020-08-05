using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace BinaryFile
{
    public class Program
    {
        public static void Main()
        {
            string dir = @"C:/Users/blin/Desktop/FileIO";
            // If directory does not exist, create it
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            string fileName = @"C:/Users/blin/Desktop/FileIO/test.txt";

            try
            {


                // Create a new file     
                using (StreamWriter sw = File.CreateText(fileName))
                {
                    sw.WriteLine("New file created: {0}", DateTime.Now.ToString());
                    sw.WriteLine("Author: Khushbu chauhan");
                    sw.WriteLine("Added line 1 ");
                    sw.WriteLine("Added line 2 ");
                    sw.WriteLine("Done! Thank You");
                }

                // Write file contents on console.     
                var numberOfCharacters = File.ReadAllLines(@"C:\\Users\\blin\\Desktop\\FileIO\\test.txt").Sum(s => s.Length);
                Console.WriteLine(numberOfCharacters);

                try
                {
                    Stack <string> myStack = new Stack <string>();
                    int count = 0;
                    using (StreamReader sr = new StreamReader(@"C:\\Users\\blin\\Desktop\\FileIO\\test.txt"))
                    {
                        string line;

                        while ((line = sr.ReadLine()) != null)
                        {
                            myStack.Push(line);
                            count++;
                        }
                    }
                        using (StreamWriter sw1 = File.CreateText(@"C:\\Users\\blin\\Desktop\\FileIO\\test1.txt"))
                        {
                           while(count>0){
                            string l = myStack.Pop();
                            sw1.WriteLine(l);
                            count--;
                           }
                        }
                }
                catch (Exception e)
                {
                    // Let the user know what went wrong.
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(e.Message);
                }

            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }
    }
}