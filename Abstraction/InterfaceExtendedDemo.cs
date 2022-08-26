using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Abstraction
{
    interface Imove
    {
        //Defination of Interface Method Access modifier must be public
        //Interface contains only static veriable and methods
        //Interface methods are by default public and abstract
        //Interface does not contain constructor
        void show();
        static int x = 100;

    }
    interface Idraw:Imove
    {
        void display();
    }
    class Test:Idraw
    {
        public void show()
        {
            Console.WriteLine("x="+Imove.x);
            Console.WriteLine("Show Method of Imove");
        }
        public void display()
        {
            Console.WriteLine("display Mothod of Idraw");
        }
    }
    class InterfaceExtendedDemo
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            t.show();
            t.display();
            
        }
    }
}
