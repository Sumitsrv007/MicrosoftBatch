using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Oops.Encapsulation
{

    class Department
    {
        private int did;
        private String dname;
        public int Did
        {
            get { return Did; }
            set { Did = value; }
        }
        public String Dname
        {
            get { return dname; }
            set { dname = value; }
        }
    }
    class EmpSetterGetter
    {
        private int id;
        private String name;
        private Department dept;

        public int Id
        {
            get;
            set;
        }
        public String Name
        {
            get { return name; }
            set { name = value; }

        }
        public Department Dept
        {
            get { return dept; }
            set { dept = value; }
        }
        static void Main(string[] args)
        {
            /*Department d = new Department();
            d.Did = 10;
            d.Dname = "Sales";
            EmpSetterGetter e = new EmpSetterGetter();
            e.Id = 877;
            e.Name = "Nikita";
            e.Dept = d;
            Console.WriteLine(e.Id+" "+e.Name+" "+d.Did+" "+d.Dname);*/

            /*EmpSetterGetter e = new EmpSetterGetter();
            e.Id = 111;
            e.Name = "Omkar";
            e.Dept = new Department();
            e.Dept.Did = 109;
            e.Dept.Dname = "HR";
            Console.WriteLine(e.Id + " " + e.Name + " " + e.Dept.Did + " " + e.Dept.Dname); */

            EmpSetterGetter e = new EmpSetterGetter();
            e.Id = 536;
            e.Name = "Omkar";
            e.Dept = new Department();
            Department d = e.Dept;
            d.Did = 299;
            d.Dname = "Marketing";
            Console.WriteLine(e.Id + " " + e.Name + " " + d.Did + " " +d.Dname);
        }
    }
}
