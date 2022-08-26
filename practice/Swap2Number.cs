using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.practice
{
    class Swap2Number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st Number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Before Swaping "+"a="+a+" b="+b);

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After Swaping " + "a=" + a + " b=" + b);

            //using temp Variable;
            /*int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Before Swaping " + "a=" + a + " b=" + b);*/

        }
    }
}
