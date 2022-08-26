using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Abstraction
{
    abstract class Employee
    {
        public int x = 300;
        public static int y = 100;
        public Employee(String name)//parameterised constructor
        {
            Console.WriteLine("Employee Constructor");
        }
        public abstract void show();//abstract method
        public void MyEmp()//default method
        {
            Console.WriteLine("MyEmp Method");
        }
    }
        abstract class Manager:Employee
        {
            public Manager():base("Rocky")
            {
                Console.WriteLine("Manager Constructor");
            }
        public override void show()
        {
            Console.WriteLine("Show Method" + " " + x);
        }
    }
    class SubManager:Manager
    {
        /*public override void show()
        {
            Console.WriteLine("Show Method of SubManager");
        }*/
    }

    class AbstractDemo2
    {
        static void Main(string[] args)
        {
            Employee e = new SubManager();
            e.show();
            e.MyEmp();
        }
    }
}
