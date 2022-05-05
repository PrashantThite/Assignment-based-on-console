using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.loops
{
    class Factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int a = Convert.ToInt32(Console.ReadLine());
             long multi = 1;
            long sum = 0;

            for(int i=1;i<=a;i++)
            {
                multi = multi * i;
                sum = sum + multi;
            }
            Console.WriteLine("Factorial of given number= "+multi);
            Console.WriteLine("Sum of factorials = "+sum  );
        }
    }
}
