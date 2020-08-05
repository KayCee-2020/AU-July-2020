using System;   
namespace BinaryFile
{
    class Program
    {
        public delegate int CharCount(string a, string b);

        public static int CountChar(string a, string b)
        {
            String c = a + b;
            return c.Length;
        }

        static void Main(string[] args)
        {
            CharCount cr = new CharCount(CountChar);
            String a = "Khushbu";
            String b = "Chauhan";
            Console.WriteLine(a + " " + b);
            Console.WriteLine(cr(a, b));




        }
    }
}