using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Oops.Encapsulation
{
    class Engine
    {
        public String petrol;
      public   String disel;
        public Engine(String petrol,String disel)
        {
            this.petrol = petrol;
            this.disel = disel;
        }
        public void show()
        {
            Console.WriteLine(petrol+" "+disel);
        }
    }
    class Car
    {
        Engine e;
        String name;
        String color;
        long price;
        public Car(Engine e,String name,String color,long price)
        {
            this.e = e;//object of engine class
            this.name = name;
            this.color = color;
            this.price = price;
        }

       public void display()
        {
            Console.WriteLine(e.petrol+" "+e.disel+" "+name+" "+color+" "+price);
        }
    }
    class HasARelationConstructorCar
    {
        static void Main(string[] args)
        {
            Engine e = new Engine("Car petrol Engine","Truck disel Engine");
            Car c = new Car(e,"Ford", "Red", 9800000);
            c.display();

        }
    }
}
