using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Inheritance
{
    class Animal
    {
        protected int legs = 0;

        public Animal()
        {
            Console.WriteLine("Animal Default Constructor");
        }
        public Animal(int x)
        {
            Console.WriteLine("X="+x);
        }
        public void foo()
        {
            Console.WriteLine("parent");
        }
    }
    class Dog:Animal
    {
        int legs = 4;
        public Dog(int x):base(x)//Method calling by base keyword
        {
            Console.WriteLine("X Child "+" "+x);
        }
        public void show()
        {
            Console.WriteLine(legs+" "+base.legs);//veriable calling by base keyword (base.legs)
        }
        public void foo()
        {
            Console.WriteLine("child");
        }
    }
    class BaseKeyword
    {
        static void Main(string[] args)
        {
            Dog d = new Dog(6);
            d.show();
            Animal a = new Animal();
            a.foo();
            Animal a1 = new Animal(5000);

        }
    }
}
