using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Collection.List
{
    class ListEmployee
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee()
            {
                name = "Amit",
                age = 29,
                designation="Manager"
            };
            Employee emp2 = new Employee()
            {
                name = "Rohan",
                age = 24,
                designation = "Assistant"
            };
            Employee emp3 = new Employee()
            {
                name = "Ziya",
                age = 27,
                designation = "Operator"
            };
            List<Employee> empList = new List<Employee>();
            empList.Add(emp1);
            empList.Add(emp2);
            empList.Add(emp3);
            foreach  (Employee emp in empList)
            {
                Console.WriteLine("Employee Name:{0}, Employee Age:{1}, Employee Designation:{2}",emp.name,emp.age,emp.designation);
            }

        }
    }
}
