using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MicrosoftBatch.Multithreading
{
    class MultiDemo
    {
        static void m1()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(m1);
            t.Start();
        }
    }
}
