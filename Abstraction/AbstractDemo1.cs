using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Abstraction
{
    abstract class Animal
    {
        public int b = 3;
        public static int a = 300;//only static variable is allow
        public abstract void show();
        public void MyAnimal()//concret Method
        {
            Console.WriteLine("Myanimal Method");
        }
        public Animal()//constructor
        {
            Console.WriteLine("Animal Constructor");
        }
    }
    class Dog : Animal 
    {
        public Dog(int x):base()
        {
            Console.WriteLine("x value of Dog Constructor "+x+" "+a);
        }
        public override void show()
        {
            Console.WriteLine("Show Method"+" "+b);
        }
    }
    class AbstractDemo1
    {
        static void Main(string[] args)
        {
            Animal a = new Dog(500);
            a.show();
            a.MyAnimal();
        }
    }
}
