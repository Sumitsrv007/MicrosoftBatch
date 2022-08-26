using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Collection.Queue
{
    class Student
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Age { get; set; }
    }
    class QueueStudent
    {
        static void Main(string[] args)
        {
            Student s1 = new Student()
            { Id = 10023, Name = "Sam",Age=30 };
            Student s2 = new Student()
            { Id = 9272, Name = "Jhon", Age = 27 };
            Student s3 = new Student()
            { Id = 6484, Name = "Rohan", Age = 43 };
            Student s4 = new Student()
            { Id = 8262, Name = "Ziya", Age = 39 };

            Queue<Student> qq = new Queue<Student>();
            qq.Enqueue(s1);
            qq.Enqueue(s2);
            qq.Enqueue(s3);
            qq.Enqueue(s4);

            Console.WriteLine("Student Information");
            foreach (Student item in qq)
            {
                Console.WriteLine("Id="+item.Id+" Name="+item.Name+" Age="+item.Age);
            }


        }
    }
}
