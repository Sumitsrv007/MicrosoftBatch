using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Loop
{
    class PrimeAdd1_10
    {
        static void Main(string[] args)
        {
          
            for (int i = 0; i < 10; i++)
            {
                bool prime = true;
                for(int j=2;j<i;j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if(prime)
                {
                    Console.WriteLine(prime);
                }
            }
            
        }
    }
}
