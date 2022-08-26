using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Array
{
    class InsertElement
    {
        static void Main(string[] args)
        {
            int psn = 4;
            int element = 1000;
            int[] a = { 2, 5, 6, 7, 9 };

            for (int i = a.Length-1; i > psn-1; i--)
            {
                a[i]=a[i-1];
            }
            a[psn-1] = element;
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + " ");
            }
            
        }    
    }

    class InsertElement1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter no of Possition");
            int psn = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 1 Elements");
            int element = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert 5 Element");
            int[] a = new int[5];
            for (int i = 0; i < a.Length; i++)
            {
                int x = int.Parse(Console.ReadLine());
                a[i]=x;
            }
            for (int i = a.Length-1; i < psn-1; i--)
            {
                a[i] = a[i - 1];
            }
            a[psn - 1] = element;
            Console.WriteLine("-----------------------------------");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]+" ");
            }

        }
    }
}
