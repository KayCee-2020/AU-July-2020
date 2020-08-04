using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\Lesson22\Exampl.txt");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not found!");
                Console.WriteLine("Caught exception {0}",ex);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Directory not found");
                Console.WriteLine(@"Caught exception C:\Lesson22 existiert : {0}",ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception caught");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Closing application now . . .");
            }
            Console.ReadLine();
        }
    }
}

