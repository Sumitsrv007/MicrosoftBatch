using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Oops.Static
{
    class StaticConstructor
    {
        static StaticConstructor()
        {
            Console.WriteLine("This is Static Constructor");
        }
        public StaticConstructor(int x)
        {
            Console.WriteLine("This Parameterised Constructor"+x);
        }
        static void Main(string[] args)
        {
            StaticConstructor s=new StaticConstructor(400);
            StaticConstructor s1 = new StaticConstructor(500);
        }
    }
}
