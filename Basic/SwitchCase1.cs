using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Basic
{
    class SwitchCase1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Value of a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value of b");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Operand Symbole");
            char operand = char.Parse(Console.ReadLine());

            switch(operand)
            {
                case '+':
                    Console.WriteLine(a+b);
                    break;
                case '-':
                    Console.WriteLine(a - b);
                    break;
                case '*':
                    Console.WriteLine(a * b);
                    break;
                case '/':
                    Console.WriteLine(a / b);
                    break;

                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
    }
}
