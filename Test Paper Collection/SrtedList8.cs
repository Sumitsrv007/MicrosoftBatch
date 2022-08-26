using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Test_Paper_Collection
{
    class Employee1
    {
        public string departmentname { get; set; }
    }
    class SrtedList8
    {
        static void Main(string[] args)
        {
            Employee1 e1 = new Employee1()
            { departmentname = "Marketing" };
            Employee1 e2 = new Employee1()
            { departmentname = "Operation" };
            Employee1 e3 = new Employee1()
            { departmentname = "HR" };
            SortedList<Employee1,string> s = new SortedList<Employee1,string>();
            s.Add(e1,"A");
            s.Add(e2, "B");
            s.Add(e3, "C");
            foreach (KeyValuePair<Employee1,string> item in s)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
