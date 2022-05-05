using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.While
{
    class Odd
    {
        static void Main(string[] args)
        {
            int i = 521;
            while (i >= 229)
            {
                
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                i--;               
            }
        }
    }
}
