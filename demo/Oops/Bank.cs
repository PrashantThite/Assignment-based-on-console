using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Oops
{
    // Inheritance
    class Parent
    {
        int a, b;

        public int add(int a,int b)
        {
            this.a = a;
            this.b = b;
            int sum = a + b;
            return sum;
        }
        public int multi(int a,int b)
        {
            this.a = a;
            this.b = b;
            int multi = a * b;
            return multi;
        }
    }
    class childA:Parent
    {
        static void Main(string[] args)
        {
            childA a = new childA();
           int add= a.add(5, 10);
            Console.WriteLine(add);
            int multi = a.multi(5, 10);
            Console.WriteLine(multi);
        }
    }
    class childB:Parent
    {
        static void Main(string[] args)
        {
            childB a = new childB();
            int add = a.add(10, 10);
            Console.WriteLine(add);
            int multi = a.multi(10, 10);
            Console.WriteLine(multi);
        }
    }
}
