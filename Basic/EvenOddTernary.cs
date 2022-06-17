using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Basic
{
    class EvenOddTernary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No.");
            int n = int.Parse(Console.ReadLine());
            string st = (n % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine(st);
        }
    }
}
