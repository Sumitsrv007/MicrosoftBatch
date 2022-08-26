using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Collection.Dictionary
{
    class EmployeeDictionary
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee()
            {
                id = 101,
                name = "Ronny",
                designation = "Manager",
                salary = 30000
            };
            Employee emp2 = new Employee()
            {
                id = 119,
                name = "Sam",
                designation = "Developer",
                salary = 70000
            };
            Employee emp3 = new Employee()
            {
                id = 2210,
                name = "Steny",
                designation = "Assistant",
                salary = 20000
            };
            Dictionary<int, Employee> myEmp = new Dictionary<int, Employee>();
            myEmp.Add(emp1.id, emp1);
            myEmp.Add(emp2.id, emp2);
            myEmp.Add(emp3.id, emp3);
            //Console.WriteLine(myEmp.Count(emp1 => emp1.Value.name.StartsWith("S")));
            //1.Print Key
            /*foreach (int key in myEmp.Keys)
            {
                Console.WriteLine(key);
            }*/
            foreach (KeyValuePair<int,Employee> item in myEmp)
            {
                Console.WriteLine("Key="+item.Key+" Value="+item.Value);
            }

        }
    }
}
