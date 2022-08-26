using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.practice
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            String str = " C# Programing Language ";
            String reverse = "";
            for(int i=str.Length-1;i>0;i--)
            {
                reverse = reverse + str[i];
            }
            Console.WriteLine(reverse);
        }
    }
}
