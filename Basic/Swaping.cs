using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Basic
{
    class Swaping
    {
        static void Main(string[] args)
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Befor Swaping Value of a " + a);
            Console.WriteLine("Befor Swaping Value of b " + b);

            a = a - b;
            b = a + b;
            a = a - b;

            Console.WriteLine("After Swaping value of a "+a);
            Console.WriteLine("After Swaping value of b " +b);
        }

    }
}
