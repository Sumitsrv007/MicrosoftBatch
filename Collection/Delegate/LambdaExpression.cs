using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Collection.Delegate
{
    public delegate void MyDelegate1(int a,int b);
    class LambdaExpression
    {
        static void Main(string[] args)
        {
            //Statement Lambda
            MyDelegate1 m1 = (a, b) =>
              {
                  int c = a + b;
                  Console.WriteLine(c);
              };
            m1(10, 20);

            //Expression Lambda
            // MyDelegate1 m2 = (a,b) => a * b;
            //Console.WriteLine(m2.(10)); 

            /* int cube = m2(5);
             Console.WriteLine(cube);*/
        }
    }
}
