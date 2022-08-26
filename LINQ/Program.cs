using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MicrosoftBatch.LINQ
{
    class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string companyname { get; set; }
        public int price { get; set; }
        public override string ToString()
        {
            return $"{id} -> {name} -> {companyname} -> {price}";
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product{id=1,name="Mouse",companyname="Dell",price=699},
                new Product { id = 2, name = "Ram", companyname = "Samsung", price = 2409 },
                new Product{id=3,name="Laptop",companyname="Lenovo",price=3590},
                new Product{id=4,name="Printer",companyname="HP",price=3999},
                new Product{id=5,name="Keyboard",companyname="Logitech",price=1500},
            };
            Console.WriteLine("-----------------LINQ----------------------");
            var result1 = from p in products
                          select p;

            var result2 = from p in products
                          where p.price < 2000
                          select p;

            var result3 = from p in products
                          where p.price > 2000 && p.price < 3000
                          select p;

            //var result4 = from p in products
            //              where p.CompanyName.StartsWith("D")
            //              select p;
            //var result4 = from p in products
            //              where p.CompanyName.EndsWith("o")
            //              select p;
            var result4 = from p in products
                          where p.companyname.Contains("m") || p.companyname.Contains("S")
                          select p;
            var result5 = from p in products
                          where p.price < 2500
                          orderby p.price descending
                          select p;
            foreach (Product item in result5)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------Lambda----------------------");
            //Lambda Expression
            var res1 = products.Where(p => p.price < 2000).ToList();
            var res2 = products.Where(p => p.price < 2000).OrderBy(x=>x.name).ToList();
            //retrive single record
            var res3 = products.Where(x => x.id == 1).SingleOrDefault();

            var res4 = products.Where(x => x.price < 2500).OrderBy(x => x.price).ToList().Take(3);
            var res5 = products.Where(x => x.price < 2500).OrderBy(x => x.price).ToList().Skip(3);

            foreach (Product item in res1)
            {
                Console.WriteLine(item);
            }

        }
    }
}
