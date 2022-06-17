using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch
{
    class SwitchCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Value of A");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value of A");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Operation:");
            char op = char.Parse(Console.ReadLine());
            switch(op)
            {
                case '+':
                    int c = a + b;
                    Console.WriteLine(c);
                    break;

                default:
                    Console.WriteLine("Wrong");
                    break;
            }
        }
    }
}
