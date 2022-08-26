using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Basic
{
    class SwitchCase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Week day Between 1 to 7");
            int day = int.Parse(Console.ReadLine());

            switch(day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuseday");
                    break;
                case 3:
                    Console.WriteLine("Wednusday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;

                default:
                    Console.WriteLine("Invalid Entery");
                    break;
            }
        }
    }
}
