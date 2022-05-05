using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.loops
{
    class Frequancy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int a = Convert.ToInt32(Console.ReadLine());
            int c;
            int d = 0;
            while(a>0)
            {
                d = a % 10;
                a = a / 10;
                Console.WriteLine(d);
            }
        }
    }
}
