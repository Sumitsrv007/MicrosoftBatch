using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Collection
{
    public delegate int mydel1(int n);
    class LamdaFactorial
    {
        static void Main(string[] args)
        {
            mydel1 m = (n) =>
            {
                int i, f = 1;
                for (i = 1; i <= n; i++)
                {
                    f = f * i;
                }
                return f;
            };
            int e=m(5);
            Console.WriteLine(e);
        }
    }
}
