using System;


namespace Delegates
{
    public delegate string AddString(string str1,string str2);
    class Program
    {

        public static string Temp = "common";
        public static  string Func1(string str1, string str2)
        {
            if (str1.Length >= str2.Length)
            {
                return Temp + str1;
            }
            else
            {
                return Temp + str2;
            }
        }

        //Concatenate temp with the longer string
        public static string Func2(string str1, string str2)
        {
            if (str1.Length <= str2.Length)
            {
                return Temp + str1;
            }
            else
            {
                return Temp + str2;
            }
        }

        //Concatenate temp with the shorter string
        static void Main(string[] args)
        {
             

            Console.WriteLine("enter first string");
            string str1 = Console.ReadLine();
            Console.WriteLine("enter Second string");
            string str2 = Console.ReadLine();

            AddString obj1 = new AddString(Func1);
            AddString obj2 = new AddString(Func2);
            AddString obj3 = obj1+ obj2;
            Console.WriteLine(obj3(str1,str2));
            //string res = obj1(str1,str2)+obj2(str1,str2);
            //Console.WriteLine(res);
        }
    }
}
