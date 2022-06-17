using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Test_paper1
{
    class SimpleInterest
    {
        static void Main(string[] args)
        {
            int p,t,r,si;
            Console.WriteLine("Enter Principle");
            p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Time");
            t = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Rate");
            r = int.Parse(Console.ReadLine());
            si = p * t * r / 100;
            Console.WriteLine(si+" is Simple Interest");
        }
    }
}
