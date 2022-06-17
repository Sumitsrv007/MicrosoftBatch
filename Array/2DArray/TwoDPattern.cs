using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Array._2DArray
{
    class TwoDPattern
    {
        static void Main(string[] args)
        {
            int[,] a = { {5,4,3,2, }, {7,5,4,1 }, {9,7,5,8 }, {3,5,7,2 } };
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if(i==0 || j==0 || i==a.GetUpperBound(0) || j==a.GetUpperBound(1))
                    {
                        Console.Write(a[i,j]+" ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
 }
    

