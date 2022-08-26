using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Collection.Ienumerable1
{
    //School is Custom Collection class,must implement IEnumerable interface,IEnumerable interface must initialise GetEnumerator method
    /*class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public string branch { get; set; }

    }
    class School : IEnumerable
    {
        List<Student> l = new List<Student>();
        public void Add(Student s)
        {
            l.Add(s);
        }

        public IEnumerator GetEnumerator()
        {
            //throw new NotImplementedException();
              return sc.GetEnumerator();
        }
    }
    class CustomCollection
    {
        static void Main(string[] args)
        {
            Student s1 = new Student()
            { id = 101, name = "Saket", branch = "CSE" };
            Student s2 = new Student()
            { id = 102, name = "Arohi", branch = "ME" };
            Student s3 = new Student()
            { id = 103, name = "Rohan", branch = "ECE" };

            School sc = new School();
            sc.Add(s1);
            sc.Add(s2);
            sc.Add(s3);

            foreach (Student item in sc)
            {
                Console.WriteLine(item.id + " " + item.name + " " + item.branch);
            }
        }
    }*/
}
