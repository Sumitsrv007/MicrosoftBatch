using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Test_paper1
{
    class CubeNo1
    {
        static void Main(string[] args)
        {
            int a, total;
            Console.WriteLine("Enter Number");
            a = int.Parse(Console.ReadLine());
            total = a * a* a;
            Console.WriteLine(total + " is cube");
        }
    }
}
