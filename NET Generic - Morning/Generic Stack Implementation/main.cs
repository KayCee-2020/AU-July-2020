


/******************************************************************************

The Generic Stack in C# is a collection class which works on the 
principle of Last In First Out (LIFO) and this class is present in 
           System.Collections.Generic namespace.

*******************************************************************************/
using System;
using System.IO;
using System.Collections.Generic;
namespace GenericStackDemo
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
    }
    
    
    
    public class Demo
    {
        static void Main(string[] args)
        {
            Student std1 = new Student()
            {
                ID = 101,
                Name = "Pranaya",
                Gender = "Male",
                Age = 15
            };
            Student std2 = new Student()
            {
                ID = 102,
                Name = "Khushbu",
                Gender = "Female",
                Age = 16
            };
            Student std3 = new Student()
            {
                ID = 103,
                Name = "Siddharth",
                Gender = "Male",
                Age = 15
            };
            Student std4 = new Student()
            {
                ID = 104,
                Name = "Anushka",
                Gender = "Female",
                Age = 16
            };
            Student std5 = new Student()
            {
                ID = 105,
                Name = "Mohan",
                Gender = "Male",
                Age = 15
            };

            // Create a Generic Stack of Student
            Stack<Student> stackStudent = new Stack<Student>();

            // To add an item into the stack, use the Push() method.

            stackStudent.Push(std1);
            stackStudent.Push(std2);
            stackStudent.Push(std3);
            stackStudent.Push(std4);
            stackStudent.Push(std5);

            // to loop thru each items in the stack, we can use the foreach loop 
            Console.WriteLine("Retrive Using Foreach Loop");
            foreach (Student std in stackStudent)
            {
                Console.WriteLine(std.ID + " - " + std.Name + " - " + std.Gender + " - " + std.Age);
                Console.WriteLine("Items left in the Stack = " + stackStudent.Count);
            }
            Console.WriteLine("------------------------------");

            // To retrieve an item from the stack, use the Pop() method. 
            Console.WriteLine("Retrive Using Pop Method");
            Student e1 = stackStudent.Pop();
            Console.WriteLine(e1.ID + " - " + e1.Name + " - " + e1.Gender + " - " + e1.Age);
            Console.WriteLine("Items left in the Stack = " + stackStudent.Count);

            Student e2 = stackStudent.Pop();
            Console.WriteLine(e2.ID + " - " + e2.Name + " - " + e2.Gender + " - " + e2.Age);
            Console.WriteLine("Items left in the Stack = " + stackStudent.Count);

            Student e3 = stackStudent.Pop();
            Console.WriteLine(e3.ID + " - " + e3.Name + " - " + e3.Gender + " - " + e3.Age);
            Console.WriteLine("Items left in the Stack = " + stackStudent.Count);

            Student e4 = stackStudent.Pop();
            Console.WriteLine(e4.ID + " - " + e4.Name + " - " + e4.Gender + " - " + e4.Age);
            Console.WriteLine("Items left in the Stack = " + stackStudent.Count);

            Student e5 = stackStudent.Pop();
            Console.WriteLine(e5.ID + " - " + e5.Name + " - " + e5.Gender + " - " + e5.Age);
            Console.WriteLine("Items left in the Stack = " + stackStudent.Count);
            Console.WriteLine("------------------------------");

            stackStudent.Push(std1);
            stackStudent.Push(std2);
            stackStudent.Push(std3);
            stackStudent.Push(std4);
            stackStudent.Push(std5);

            // To retrieve an item that is present at the top of the stack, 
            // without removing it, then use the Peek() method.

            Console.WriteLine("Retrive Using Peek Method");
            Student std6 = stackStudent.Peek();
            Console.WriteLine(std6.ID + " - " + std6.Name + " - " + std6.Gender + " - " + std6.Age);
            Console.WriteLine("Items left in the Stack = " + stackStudent.Count);
            
            Console.WriteLine("------------------------------");

            // To check if an item exists in the stack, use Contains() method.
            if (stackStudent.Contains(std3))
            {
                Console.WriteLine("student with id 103 is in stack");
            }
            else
            {
                Console.WriteLine("student with id 103 is not in stack");
            }

            Console.ReadKey();
        }
    }

}
