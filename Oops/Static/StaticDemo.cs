using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Oops.Static
{
    class StaticDemo
    {
        int x = 10;
        static int y = 20;
        static void mydata()
        {
            StaticDemo s = new StaticDemo();//creating object is mandatory
            Console.WriteLine(s.x+" "+y);//call static data member

        }
        void show()
        {
            y = 500;
            Console.WriteLine(x+" "+y);
        }
        static void Main(string[] args)
        {
            /*StaticDemo s = new StaticDemo();
            s.show();*/
            StaticDemo.mydata();

        }
    }
}
