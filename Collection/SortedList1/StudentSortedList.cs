using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Collection.SortedList1
{
    class StudentSortedList
    {
        static void Main(string[] args)
        {

            Student s1 = new Student()
            { Name = "Jhon", Course = "Java", Branch = "Cse" };
            Student s2 = new Student()
            { Name = "zain", Course = "C-Sharp", Branch = "It" };
            Student s3 = new Student()
            { Name = "Jhon", Course = "PHP", Branch = "Ece" };
            Student s4 = new Student()
            { Name = "Jhon", Course = "Python", Branch = "Ex" };

            SortedList<int, Student> srt = new SortedList<int, Student>();
            srt.Add(110, s1);
            srt.Add(210, s2);
            srt.Add(1018, s3);
            srt.Add(827, s4);

            Console.WriteLine();
            Console.WriteLine("Student Information");
            foreach (KeyValuePair<int,Student> item in srt)
            {
                Student s = srt[item.Key];//search by Id
                Console.WriteLine(" Id="+item.Key);
                Console.Write("  Name=" + s.Name);
                Console.Write("  Course=" + s.Course);
                Console.WriteLine("  Branch=" + s.Branch);
                Console.WriteLine("-----------------------------------------------");
            }
        }
    }
}
