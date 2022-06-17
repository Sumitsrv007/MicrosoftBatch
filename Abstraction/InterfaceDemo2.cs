using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Abstraction
{
    public interface Iprintable
    {
        static int y = 500;
        void print();
    }
    public interface IMoveable1
    {
        static int x;
        void show1();
        static void MyMethod()
        {
            Console.WriteLine("My Static Interface Method");
        }
        void foo1()
        {
            Console.WriteLine("Foo Method");
        }
    }
    class Car1 : IMoveable1, Iprintable
    {
        public void show1()//must be public
        {
            IMoveable.x = 400;
            Console.WriteLine("My interface Method" + IMoveable1.x);
        }
        public void print()
        {
            Console.WriteLine("Hi i am Printable  "+(Iprintable.y+IMoveable1.x));
        }
    }
    class InterfaceDemo2
    {
        static void Main(string[] args)
        {
            IMoveable1 m = new Car1();
            m.show1();
            IMoveable1.MyMethod();
            m.foo1();

            Iprintable p = new Car1();
            p.print();

        }
    }
}
