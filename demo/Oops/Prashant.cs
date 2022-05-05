using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Oops
{
    class Prashant
    {
        public void M1()
        {
            Console.WriteLine("its M1");
            M2();
        }
        public void M2()
        {
            Console.WriteLine("Its M2");
            
        }
        public static void M3()
        {
            Console.WriteLine("its m3");
            M4();
        }
        public static void M4()
        {
            Console.WriteLine("its m4");
        }
    }

    class Prashant1
    {
        static void Main(string[] args)
        {
            Prashant a = new Prashant();
            a.M1();
            Prashant.M3();
        }

    }

}
