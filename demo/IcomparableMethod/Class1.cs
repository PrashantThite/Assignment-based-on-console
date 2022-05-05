using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.IcomparableMethod
{
    public class Empp : IComparable
    {
        public Empp(int salary, string name)
        {
            Salary = salary;
            Name = name;
        }

        public int Salary { get; set; }
        public string Name { get; set; }
        public int CompareTo(object obj)
        {
            Empp x = (Empp)obj;
            if (this.Salary > x.Salary)
                return 1;
            else if (this.Salary < x.Salary)
                return -1;
            else
                return 0;
            
        }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            Empp a = new Empp(30000, "abc");
            Empp b = new Empp(35000, "xyz");
            int result = a.CompareTo(b);
            if(result==1)
                Console.WriteLine(a.Name+" has more salary");
            else if(result ==-1)
                Console.WriteLine(b.Name+" has more salary");
            else
                Console.WriteLine("Both have same salary");
        }
    }
}
