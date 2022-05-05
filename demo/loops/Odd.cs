using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.loops
{
    class Odd
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
               if (i % 2 != 0)
                    sum += i;

            }
            Console.WriteLine("sum= "+sum);
        }
            
    }
}
