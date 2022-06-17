using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.String_Handeling
{
    class DigitSum2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            String str = Console.ReadLine();
            double sum = 0;
            for(int i=0;i<str.Length;i++)
            {
               if (Char.IsDigit(str[i]))
                    {
                    Console.WriteLine();
                    double x = Char.GetNumericValue(str[i]);
                    sum = sum + x;
                }
                Console.WriteLine("Sum"+sum);
            }
        }
    }
}
