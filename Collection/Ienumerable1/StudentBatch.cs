using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Collection.IEnumerable
{


    class StudentBatch
    {
        static void Main(string[] args)
        {
            Student s1 = new Student()
            { id = 101, name = "Saket", branch = "CSE" };
            Student s2 = new Student()
            { id = 102, name = "Arohi", branch = "ME" };
            Student s3 = new Student()
            { id = 103, name = "Rohan", branch = "ECE" };

            List<Student> l = new List<Student>();
            l.Add(s1);
            l.Add(s2);
            l.Add(s3);

            foreach (Student item in l)
            {
                Console.WriteLine(item.id+" "+item.name+" "+item.branch);
            }
        }
    }
}
