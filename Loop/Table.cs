using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Loop
{
    class Table
    {
        static void Main(string[] args)
        {
            int table = 1;
            Console.WriteLine("Enter Number:");
            int a = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= 10; i++)
            {
                table= a * i;
                Console.WriteLine(table);
            }
        }
    }
}
