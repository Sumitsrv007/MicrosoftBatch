using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Inheritance
{
    class Car
    {
        public virtual void show()
        {
            Console.WriteLine("This is show method of Car class");
        }
    }
    class Audi:Car
    {
        public override void show()
        {
            Console.WriteLine("This is show method of Audi class");
        }
    }
    class Kia : Car
    {
        public override void show()
        {
            Console.WriteLine("This is show method of Kia class");
        }
    }
    class OverridingDemo
    {
        static void Main(string[] args)
        {
            Car c=new Audi();
            c.show();
            Car c1 = new Kia();
            c1.show();
        }
    }
}
