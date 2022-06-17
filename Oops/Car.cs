using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Oops
{
    class Car
    {
        

        public void detail()
        {
            int modelNo = 136736;
            String name, color = "Red";
            long price = 900000;
            Console.WriteLine("Enter Car Name:");
            name = Console.ReadLine();
            Console.WriteLine("Name="+name);
            Console.WriteLine("Model No="+modelNo);
            Console.WriteLine("Color="+color);
            Console.WriteLine("Price="+price);
        }
        static void Main(string[] args)
        {
            Car c = new Car();
            c.detail();
        }
    }
}
