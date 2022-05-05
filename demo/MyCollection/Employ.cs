using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Assignment.MyCollection
{
    class Employ
    {
        string name;
        int id, salary;

        public Employ(string name, int id, int salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public int Salary { get => salary; set => salary = value; }

        public override string ToString()
        {
            return $"emp name= {Name}, emp Id= {Id}, emp salary= {Salary}";
        }
    }
    class test
    {
        static void Main(string[] args)
        {
            List<Employ> emplist = new List<Employ>()
            {
                new Employ("abc",101,20000),
                new Employ("lmn",102,30000),
                new Employ("pqr",103,22000),
                new Employ("xyz",104,25000),

            };
            foreach(Employ a in emplist)
            {
                Console.WriteLine(a);
            }
        }
    }
}
