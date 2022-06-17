using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Array._2DArray
{
    class Create2dArray
    {
        static void Main(string[] args)
        {
            //2D Array Creation
            /*int[,] a = { { 4,5,6},
                         {7,8,3 },
                         {9,2,1 }};*/
            //int[,] a = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 9, 7, 8 } };

            int[,] a = new int[2, 2];
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("------------------");
            for(int i=0;i<a.GetLength(0);i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine(a[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------");
            for(int i=0;i<a.GetUpperBound(0);i++)
            {
                for(int j=0;j<=a.GetUpperBound(1);j++)
                {
                    Console.WriteLine(a[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
