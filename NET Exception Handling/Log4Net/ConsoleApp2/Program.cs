using System;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            Boolean flag = true;
            log.Info("Program Started Executing");
            try
            {
                string content = File.ReadAllText(@"C:\Lesson22\Exampl.txt");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {
                flag = false;
                Console.WriteLine("File not found!");
                Console.WriteLine("Caught exception {0}", ex);
                log.Error(ex.StackTrace);
            }
            catch (DirectoryNotFoundException ex)
            {
                flag = false;
                Console.WriteLine("Directory not found");
                Console.WriteLine(@"Caught exception C:\Lesson22 existiert : {0}", ex.Message);
                log.Error(ex.StackTrace);
            }
            catch (IOException ex)
            {
                flag = false;
                Console.WriteLine("\nAn Input Output Error has occured\n");
                log.Error(ex.StackTrace);
            }
            catch (Exception ex)
            {
                flag = false;
                Console.WriteLine("An exception caught");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (!flag)
                {
                    log.Warn("Unsuccessful File Read");
                }
                else
                {
                    Console.WriteLine("Closing application now . . .");
                    log.Info("Program Execution Ended\n\n");
                }
                
            }
            Console.ReadLine();
        }

    }
}

