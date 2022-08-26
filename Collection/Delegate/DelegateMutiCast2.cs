using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Collection.Delegate
{
    public delegate void Calculate();
    class DelegateMutiCast2
    {
        public static void Add()
        {
            int a = 10;
            int b = 5;
            Console.WriteLine("Addition is="+(a+b));
        }
        public static void Plus()
        {
            float a = 9.12f;
            float b = 5.3f;
            Console.WriteLine("Addition is="+(a + b));
        }

        static void Main(string[] args)
        {
            Calculate c = new Calculate(Add);
            c += Plus;
            c();
        }
    }
}
