using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Array1
{
    class Emp
    {
        // create array of 5 employee and display the employee who has salary above 40000.
        int id, salary;
        string name;

        public int Id { get => id; set => id = value; }
        public int Salary { get => salary; set => salary = value; }
        public string Name { get => name; set => name = value; }

        static void Main(string[] args)
        {

            Emp[] a = new Emp[5] {
                new Emp{Id=1,Name="A",Salary=25000},
                new Emp{Id=2,Name="B",Salary=41000},
                new Emp{Id=3,Name="C",Salary=30000},
                new Emp{Id=4,Name="D",Salary=45000},
                new Emp{Id=5,Name="E",Salary=20000},
            };

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Salary > 40000)
                {
                    Console.WriteLine(a[i].Name + " Employee has salary above Rs 40000");
                }
            }

        }


    }
}