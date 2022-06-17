using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.logic
{
    class MagicNumber
    {
        static void Main(string[] args)
        {
            int magicno=45;
            for (; ; )
            {
                Console.WriteLine("Enter Number:");
                int n = int.Parse(Console.ReadLine());
                if (n < magicno)
                {
                    Console.WriteLine("No is less than Magic NO.");
                    continue;
                }
                else if (n > magicno)
                {
                    Console.WriteLine("No is Greater than Magic No.");
                    continue;
                }
                else
                {
                    Console.WriteLine("Magic No is correct");
                    break;
                }
            }
        }
    }
}
