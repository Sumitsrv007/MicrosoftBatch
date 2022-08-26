using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Test_Paper_Collection
{
    class Employee
    {
        public string name { get; set; }
        public string designation { get; set; }
        public int salary { get; set; }
    }
    class EmployeeList2
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee()
            { name = "Amit", designation = "Manager",salary=50000 };
            Employee e2 = new Employee()
            { name = "Rohan", designation = "Executive", salary = 30000 };
            Employee e3 = new Employee()
            { name = "Priya", designation = "Assistant", salary = 20000 };

            List<Employee> l = new List<Employee>();
            l.Add(e1);
            l.Add(e2);
            l.Add(e3);
            foreach (Employee item in l)
            {
                Console.WriteLine(item.name+" "+item.designation+" "+item.salary);
            }
        }
    }
}
