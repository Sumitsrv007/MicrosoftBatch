using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Oops.Polymorphism
{
    class MethodOverload
    {
        //Method Overloading
        int num1, num2;
        public void calculate()
        {
            int a = 100, b = 20;
            Console.WriteLine("From Default Method Addition="+(a+b));
        }

        public void calculate(float x,float y)
        {
            Console.WriteLine("From Parameteriesed Method substraction="+(x-y));
        }

        //Constroctor Overloading
        public MethodOverload()
        {
            int i=100, j=20;
            Console.WriteLine("Default Constructor Division="+(i/j));
        }

        public MethodOverload(int num1,int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
            Console.WriteLine("Construct Multiplication=" + (num1 * num2));
        }

    }
    class MethodOverloading
    {
        static void Main(string[] args)
        {
            MethodOverload mo =new MethodOverload();
            MethodOverload mo1 = new MethodOverload(20,20);
            mo.calculate();
            mo.calculate(1.23f, 2.01f);
        }
    }
}
