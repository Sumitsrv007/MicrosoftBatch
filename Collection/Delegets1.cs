using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Collection
{
    public delegate void del1();
    class Delegets1
    {
        public delegate int del2(int a,int b);
        public delegate void del3(int x);
        public static int Add(int a,int b)
            {
            Console.WriteLine("Addition="+(a+b));
            return a + b;
            }
        static void m1()
        {
            Console.WriteLine("I am m1 Method");
        }
        public static void Squree(int x)
        {
            Console.WriteLine("Squre="+(x*x));
            
        }
        static void Main(string[] args)
        {
            //SingleCast delegets
            del1 d1 = m1;
            d1();
            del2 d2 = Add;
            d2(4, 8);
            //MultiCast delegets
           /* del3 d3 = Squree;
            d3 = d3 + m1;
            d3(9);*/
        }
    }
}
