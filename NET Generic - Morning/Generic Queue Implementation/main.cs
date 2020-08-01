
/******************************************************************************

The Generic Queue is a collection class which works on the principle 
    of First In First Out (FIFO) and this class is present in 
                System.Collections.Generic namespace

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
            Student s1 = new Student()
            {
                ID = 101,
                Name = "Pranaya",
                Gender = "Male",
                Age = 15
            };
            Student s2 = new Student()
            {
                ID = 102,
                Name = "Khushbu",
                Gender = "Female",
                Age = 16
            };
            Student s3 = new Student()
            {
                ID = 103,
                Name = "Siddharth",
                Gender = "Male",
                Age = 15
            };
            Student s4 = new Student()
            {
                ID = 104,
                Name = "Anushka",
                Gender = "Female",
                Age = 16
            };
            Student s5 = new Student()
            {
                ID = 105,
                Name = "Mohan",
                Gender = "Male",
                Age = 15
            };

            // Create a Generic Queue of Employees
            Queue<Student> queueStudent = new Queue<Student>();
            
            // To add an item into the queue, use the Enqueue() method.
            queueStudent.Enqueue(s1);
            queueStudent.Enqueue(s2);
            queueStudent.Enqueue(s3);
            queueStudent.Enqueue(s4);
            queueStudent.Enqueue(s5);
            
            //  to loop thru each items in the queue, then we can use the foreach loop 
            Console.WriteLine("Retrive Using Foreach Loop");
            foreach (Student std in queueStudent)
            {
                Console.WriteLine(std.ID + " - " +std.Name + " - " + std.Gender + " - " + std.Age);
                Console.WriteLine("Items left in the Queue = " + queueStudent.Count);
            }
            Console.WriteLine("------------------------------");
            
            // To retrieve an item from the queue, use the Dequeue() method. 
            Console.WriteLine("Retrive Using Dequeue Method");
            Student std1 = queueStudent.Dequeue();
            Console.WriteLine(std1.ID + " - " + std1.Name +" - "+ std1.Gender + " - " + std1.Age);
            Console.WriteLine("Items left in the Queue = " + queueStudent.Count);
            Student std2 = queueStudent.Dequeue();
            Console.WriteLine(std2.ID + " - " + std2.Name +" - "+ std2.Gender + " - " + std2.Age);
            Console.WriteLine("Items left in the Queue = " + queueStudent.Count);
            Student std3 = queueStudent.Dequeue();
            Console.WriteLine(std3.ID + " - " + std3.Name +" - "+ std3.Gender + " - " + std3.Age);
            Console.WriteLine("Items left in the Queue = " + queueStudent.Count);
            Student std4 = queueStudent.Dequeue();
            Console.WriteLine(std4.ID + " - " + std4.Name +" - "+ std4.Gender + " - " + std4.Age);
            Console.WriteLine("Items left in the Queue = " + queueStudent.Count);
            Student std5 = queueStudent.Dequeue();
            Console.WriteLine(std5.ID + " - " + std5.Name +" - "+ std5.Gender + " - " + std5.Age);
            Console.WriteLine("Items left in the Queue = " + queueStudent.Count);
            Console.WriteLine("------------------------------");
            // Now there will be no items left in the queue. 
            // So, let's Enqueue the five objects once again
            queueStudent.Enqueue(std1);
            queueStudent.Enqueue(std2);
            queueStudent.Enqueue(std3);
            queueStudent.Enqueue(std4);
            queueStudent.Enqueue(std5);
            
            // To retrieve an item that is present at the beginning of the queue,
            // without removing it,we use the Peek() method.
            Console.WriteLine("Retrive Using Peek Method");
            Student std6 = queueStudent.Peek();
            Console.WriteLine(std6.ID + " - " + std6.Name + " - " + std6.Gender + " - " + std6.Age);
            Console.WriteLine("Items left in the Queue = " + queueStudent.Count);
    
            // To check if an item exists in the stack, use Contains() method.
            if (queueStudent.Contains(std3))
            {
                Console.WriteLine("Student with id 103 is in Queue");
            }
            else
            {
                Console.WriteLine("Student with id 103 is not in queue");
            }
            
            Console.ReadKey();
        }
    }
}

