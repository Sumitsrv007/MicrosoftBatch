using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Collection.Delegate
{
    public delegate void Calculation(int a, int b);
    public delegate int Division(int a, int b);
    public delegate double Multiplication(int a, int b);
    class DelegateSingleCast2
    {
        public static void Add(int a,int b)
        {
            int result = a + b;
            Console.WriteLine("Addition="+result);
        }
        public static void Sub(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Substraction=" + result);
        }
        public static double Mul(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiplecation=" + result);
            return result;
        }
        public static int Div(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("Division=" + result);
            return result;
        }
        static void Main(string[] args)
        {
            Calculation c1 = new Calculation(DelegateSingleCast2.Add);
            c1(10, 27);
            Calculation c2 = new Calculation(DelegateSingleCast2.Sub);
            c2(30,19);
            Multiplication m = Mul;
            m(10,60);
            Division d = Div;
            d(100,5);
        }
    }
}
