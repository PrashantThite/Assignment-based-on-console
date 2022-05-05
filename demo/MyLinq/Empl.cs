using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.MyLinq
{
    // Linq basics

    class Empl
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double Salary { get; set; }
        public string Dept { get; set; }
    }
    class Test10
    {
        static void Main(string[] args)
        {
            List<Empl> list1 = new List<Empl>()
            {
                new Empl{Id=1,Name="Anuragh",City="Pune",Salary=30000,Dept="Bgv"},
                new Empl{Id=2,Name="Ramesh",City="Nashik",Salary=31000,Dept="Hr"},
                new Empl{Id=3,Name="Harish",City="Mumbai",Salary=32000,Dept="Bgv"},
                new Empl{Id=4,Name="Aniket",City="Thane",Salary=33000,Dept="Payroll"},
                new Empl{Id=5,Name="Yogesh",City="Pune",Salary=40000,Dept="Hr"},
                new Empl{Id=6,Name="Kunal",City="Nashik",Salary=41000,Dept="Payroll"},
                new Empl{Id=7,Name="Prashant",City="Mumbai",Salary=42000,Dept="Bgv"},
                new Empl{Id=8,Name="Omkar",City="Thane",Salary=43000,Dept="Hr"},
                new Empl{Id=9,Name="Rishi",City="Pune",Salary=50000,Dept="Bgv"},
                new Empl{Id=10,Name="Aniket",City="Mumbai",Salary=51000,Dept="Hr"},
                new Empl{Id=11,Name="Yogesh",City="Nashik",Salary=52000,Dept="Hr"},
                new Empl{Id=12,Name="Rohit",City="Pune",Salary=53000,Dept="Payroll"},
                new Empl{Id=13,Name="Rohan",City="Thane",Salary=54000,Dept="Bgv"}

            };

            var filter1 = from a in list1
                          where a.Salary > 45000
                          select a;

            var filter2 = from b in list1
                          orderby b.Name
                          select b;

            var filter3 = from c in list1
                          where c.City.Contains("Mumbai")
                          select c;

            var filter4 = from d in list1
                          where d.Dept.Contains("Hr")
                          select d;

            var filter5 = from e in list1
                          orderby e.Salary descending
                          select e;

            var filter6 = from f in list1
                          where f.Name.StartsWith('a') || f.Name.StartsWith('A')|| f.Name.StartsWith('k')|| f.Name.StartsWith('K')
                          select f;

            var filter7 = from g in list1
                          where g.Salary<40000 && g.City.Contains("Pune")
                          select g;

            foreach (Empl i in filter2)
            {
                Console.WriteLine($"Id= {i.Id}, Name= {i.Name}");
            }
        }
    }
}
