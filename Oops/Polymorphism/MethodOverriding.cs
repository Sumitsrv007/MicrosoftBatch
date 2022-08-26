using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Oops.Polymorphism
{
    class Person
    {
        public virtual void Show()
        {
            Console.WriteLine("This is virtual Show");
        }
    }
    class Name:Person
    {
        public override void Show()
        {
            base.Show();
            Console.WriteLine("This is Override Method");
        }
    }
    class MethodOverriding
    {
        static void Main(string[] args)
        {
            Name n = new Name();
            n.Show();
        }
    }
}
