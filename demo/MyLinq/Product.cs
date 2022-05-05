using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.MyLinq
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }


    }
    class Test9
    {
        static void Main(string[] args)
        {
            List<Product> List1 = new List<Product>()
            {
                new Product{Id=1, Name="Hp", Price=30000},
                new Product{Id=2, Name="Dell", Price=31000},
                new Product{Id=3, Name="Acer", Price=32000},
                new Product{Id=4, Name="Lenovo", Price=34000},
                new Product{Id=5, Name="Asus", Price=35000},
                new Product{Id=6, Name="Lg", Price=36000},
                new Product{Id=7, Name="Hp", Price=37000},
            };

         var filter1=   from p in List1
            where p.Price < 34000
            orderby p.Name
            select p;

            foreach (Product i in filter1)
            {
                Console.WriteLine($"Id = {i.Id}, Name= {i.Name}, Price= {i.Price}");
            }

            var filter2 = from a in List1
                          where a.Name.StartsWith('l') || a.Name.StartsWith('L')
                          select a;
            foreach (Product i in filter2)
            {
                Console.WriteLine($"Id = {i.Id}, Name= {i.Name}, Price= {i.Price}");
            }

            var filter3 = from b in List1
                          where b.Name.Contains("Dell")
                          select b;
            foreach (Product i in filter3)
            {
                Console.WriteLine($"Id = {i.Id}, Name= {i.Name}, Price= {i.Price}");
            }



        }
    }
}
