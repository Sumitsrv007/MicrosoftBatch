using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Oops.Encapsulation
{
    //Has-A Relationship By Constructor
    class Address
    {
        public int pincode;
        public String city;

        public Address(int pincode,String city)
        {
            this.pincode = pincode;
            this.city = city;
        }
        public void show()
        {
            Console.WriteLine(pincode+" "+city);
        }
    }

    class Person
    {
        int id;
        String name;
        Address adr;

        public Person(int id,String name,Address adr)
        {
            this.id = id;
            this.name = name;
            this.adr = adr;
        }

        public void display()
        {
            Console.WriteLine(id+" "+name+" "+adr.pincode+" "+adr.city);//adr is a object of Address Class
        }
    }
    class HasARelationshipConstructor
    {
        static void Main(string[] args)
        {
            Address a = new Address(843001, "Pune");
            Person p = new Person(102, "Ronit",a);
            p.display();
        }
    }
}
