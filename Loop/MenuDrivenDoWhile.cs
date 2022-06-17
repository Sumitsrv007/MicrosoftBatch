using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Loop
{
    class MenuDrivenDoWhile
    {
        static void Main(string[] args)
        {
            char ch;

            do
            {
                Console.WriteLine("1.Addition\n 2.Substraction\n 3.Multiplication\n 4.Division");
                Console.WriteLine("Enter Choice:");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 1st Number:");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2nd Number:");
                int num2 = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Addition:" + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("Substraction:" + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("Multiplication:" + (num1 * num2));
                        break;
                    case 4:
                        Console.WriteLine("Division:" + (num1 / num2));
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
                Console.WriteLine("Do you want to continue");
                ch = Console.ReadLine()[0];
            } while (ch == 'y' || ch == 'Y');
        }

    }
}
