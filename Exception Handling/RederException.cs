using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace MicrosoftBatch.Exception_Handling
{
    class RederException
    {
        static void Main(string[] args)
        {
            StreamReader sr = null;
            try
            {
                Console.WriteLine("Enter Number");
                int a = int.Parse(Console.ReadLine());
                sr = new StreamReader("F://cet.txt");
                Console.WriteLine(sr.Read());
                Console.WriteLine(sr.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("I am Finally");
                if(sr!=null)
                {
                    sr.Close();
                }
            }
        }
    }
}
