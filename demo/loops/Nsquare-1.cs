using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.loops
{
    class Nsquare_1
    {
        static void Main(string[] args)
        {
            int s;
            for (int i = 1; i <= 10; i++)
            {
                s = (i * i)-1;
                Console.WriteLine("squar of" + i + "-1 = " + s);
            }
        }
    }
}
