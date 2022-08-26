using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Oops.Encapsulation
{
    class Employee
    {
        private int id;
        private String name;
        private int salary;
        public int MyProperty { get; set; }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }

        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
    class SetterGetter1
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Id = 101;
            e.Name = "Rohan";
            e.Salary = 50000;

            Console.WriteLine(e.Id+" "+e.Name+" "+e.Salary);
        }
    }
}
