using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Array
{
    class AssendingArray
    {
        static void Main(string[] args)
        {
            char[] a = new char[5];
            Console.WriteLine("Enter character: ");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine(String.Join(" ",a));

            for(int i=0;i<a.Length;i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                    if (a[i] > a[j])
                    {
                        char temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine("After Swaping Character:");
            Console.WriteLine(String.Join(" ",a));
        }
    }
}
