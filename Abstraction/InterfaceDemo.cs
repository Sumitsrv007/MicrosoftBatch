using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Abstraction
{
    interface IMoveable
    {
        void show();
        static int x;
        static void Mymethod()
        {
            Console.WriteLine("My static interface method");
        }
        void foo()
        {
            Console.WriteLine("Foo Method");
        }
    }
        class Car:IMoveable
        {
            public void show()
            {
                IMoveable.x=400;
                Console.WriteLine("My Interface Method "+IMoveable.x);
            }
        }
    
    class InterfaceDemo
    {
        static void Main(string[] args)
        {
            IMoveable m = new Car();
            m.show();
            IMoveable.Mymethod();
            m.foo();
        }
    }
}
