using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Basic
{
    class AreaCircle
    {
        static void Main(string[] args)
        {
            int r;
            float area,pi = 3.14F;
            Console.WriteLine("Enter value of r two times:");
            r = int.Parse(Console.ReadLine());
            r = int.Parse(Console.ReadLine());
            area = pi * r * r;
            Console.WriteLine("Area of circle:"+area);
        }
    }
}
