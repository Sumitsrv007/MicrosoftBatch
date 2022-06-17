using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Abstraction
{
    interface Drawable
    {
        void draw();
    }
    abstract class Shap
    {
        public abstract void Fill();
    }
    class Circle:Shap,Drawable//1st possition abstract class and 2nd interface
    {
        public override void Fill()
        {
            Console.WriteLine("Circle is fill with Red color");
        }
        public void draw()
        {
            Console.WriteLine("This is Draw Method");
        }
    }
    class InterfaceDemo3
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.Fill();
            c.draw();
        }
    }
}
