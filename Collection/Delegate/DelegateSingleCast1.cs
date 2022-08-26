using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Collection.Delegate
{

    public delegate void Addition(int a, int b);
    public delegate int Subtaction(int a, int b);
    class DelegateSingleCast1
    {
        public static void Add(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("Addition=" + sum);
        }
        public static int Subtact(int a, int b)
        {
            int sub = a - b;
            Console.WriteLine("Subtaction=" + sub);
            return sub;
        }
        static void Main(string[] args)
        {
            Addition a = Add;
            a(4, 6);
            Subtaction s = Subtact;
            s(200, 80);

        }
    }
}
