using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.String_Handeling
{
    class DigitSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String");
            String str = Console.ReadLine();
            double sum = 0;
            for(int i=0;i<str.Length;i++)
            {
                if (str[i] > '0' && str[i] <= '9')
                {
                    Console.WriteLine(str[i]);
                    double x = Char.GetNumericValue(str[i]);
                    sum = sum + x;
                }
            }
            Console.WriteLine("Sum"+sum);
        }
    }
}
