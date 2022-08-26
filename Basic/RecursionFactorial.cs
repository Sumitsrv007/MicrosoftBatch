using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Basic
{
    class RecursionFactorial
    {
        int n = 5;
        int fact = 1;
        public int Factorial()
        {
            if(n==0)
            {
                return 1;
            }
            fact = fact * n;
            n--;
            Factorial();
            return fact;
        }

        static void Main(string[] args)
        {
            RecursionFactorial r = new RecursionFactorial();
            int find=r.Factorial();
            Console.WriteLine("Factorial is="+find);
        }
    }
}
