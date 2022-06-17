using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Test_PaperArray
{
    class Buzzz
    {
        static void Main(string[] args)
        {
            int buzz = 0, fizz = 0, buzzfizz = 0;
            for(int i=1;i<=50;i++)
            {
                if(i%10==0||i%7==0)
                {
                    if(i%3==0)
                    {
                        buzz++;
                        //.WriteLine("buzz");
                    }
                    if(i%5==0)
                    {
                        fizz++;
                       // Console.WriteLine("fizz");
                    }
                    if(i%3==0||i%5==0)
                    {
                        buzzfizz++;
                        //Console.WriteLine("buzzfizz");
                    }
                }
            }
            Console.WriteLine("Multiple of 3 Total Buzz Number:"+buzz);
            Console.WriteLine("Multiple of 5 Total Fizz Number:" + fizz);
            Console.WriteLine("Multiple of 3 & 5 Total BuzzFizz Number:" + buzzfizz);
        }
    }
}
