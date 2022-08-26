using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Collection
{
    public delegate void mydel2(int a, int b);
    public delegate int mydel3(int a);
    class AnnonymousLamda
    {
        static void Main(string[] args)
        {
            //Annonymous finction
            mydel2 d1 = delegate (int a, int b)
              {
                  Console.WriteLine("Annonymous Multiple="+(a*b));
              };
            d1(5, 8);

            //Lambda Experetion
            //1
            mydel2 d2 = (a, b) => Console.WriteLine("Ex1.Lambda ="+(a*b));
            d2(10, 20);

            //2
            mydel3 d3 = (a) =>
            {
                return a * a;
            };
            int sq = d3(6);
            Console.WriteLine("Ex2.Lambda="+sq);

            //3
            mydel3 d4 = (a) => a * a;
            int sq1 = d4(9);
            Console.WriteLine("Ex3.Lambda="+sq1);
        }
    }
}
