using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Test_paper1
{
    class ArthmeticOperation
    {
        static void Main(string[] args)
        {
            int a, b, c;
            char operation;
            Console.WriteLine("Enter 1st Number:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Operands:");
            operation = char.Parse(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    c = a + b;
                    Console.WriteLine(c);
                    break;
                case '-':
                    c = a - b;
                    Console.WriteLine(c);
                    break;
                case '*':
                    c = a * b;
                    Console.WriteLine(c);
                    break;
                case '/':
                    c = a / b;
                    Console.WriteLine(c);
                    break;
                default:
                    Console.WriteLine("This is Default");
                    break;
            }
        }
    }
}
   
