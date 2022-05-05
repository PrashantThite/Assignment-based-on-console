using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Oops
{
    class Parent1
    {
        public  void M1()
        {
            Console.WriteLine("In parent m1");
        }
        public virtual void M2()
        {
            Console.WriteLine("In parent by overriding");
        }
    }
    class child : Parent1
    {
        public new void M1()
        {
            Console.WriteLine("in child M1 by method hiding");
        }
        public sealed override void M2()
        {
            Console.WriteLine("in child M2 by overriding");
        }
    }
    class child2:Parent1
    {
        public new void M1()
        {
            Console.WriteLine("In second child m1");
        }
        static void Main(string[] args)
        {
            Parent1 a = new child();
            a.M1();
            a.M2();
            Parent1 b = new child2();
            a.M1();
            a.M2();
        }
    }
}
