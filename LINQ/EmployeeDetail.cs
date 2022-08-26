using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MicrosoftBatch.LINQ
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string City { get; set; }
        public override string ToString()
        {
            return $"{Id} {Name} {Salary} {City} ";
        }
    }
    class EmployeeDetail
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>()
            {
                new Employee{Id=101,Name="Rohan",Salary=35000,City="Mumbai"},
                new Employee{Id=102,Name="Amit",Salary=44000,City="Nasik"},
                new Employee{Id=103,Name="Ziya",Salary=23000,City="Pune"},
                new Employee{Id=104,Name="Neha",Salary=37000,City="Bangaluru"},
                new Employee{Id=105,Name="Zain",Salary=24000,City="Chennai"},
            };
            var output1 = from o in emp
                          select o;

            var output2 = from o in emp
                          orderby o.Name ascending
                          select o;

            var output3 = from o in emp
                          where o.Salary > 25000
                          select o;

            var output4 = from o in emp
                          where o.City == "Pune"
                          select o;

            var output5 = from o in emp
                          orderby o.Salary descending
                          select o;

            var output6 = from o in emp
                          where o.Name.StartsWith('R')
                          select o;

            var output7 = from o in emp
                          where o.Salary > 25000 && o.City=="Mumbai"
                          select o;
            foreach (Employee item in output6)
            {
                Console.WriteLine(item);
            }

            
        }
    }
}
