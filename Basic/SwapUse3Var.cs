using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Basic
{
    class SwapUse3Var
    {
        static void Main(string[] args)
        {
            int a = 18, b = 22,temp=0;
            Console.WriteLine("Before Swaping value of a="+a);
            Console.WriteLine("Before Swaping value of b=" + b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After Swaping value of a=" + a);
            Console.WriteLine("After Swaping value of b=" + b);
        }
    }
}
