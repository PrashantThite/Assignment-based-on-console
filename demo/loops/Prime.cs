using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.loops
{
 
    class Prime
    {
        static void Main(string[] args)
        {
            int c = 0;
            for(int i=400;i>=300;i--)
            {
                c = 0;
                    for(int j=2;j<=i/2;j++)
                { 
                    if (i % j == 0)
                    {
                        c++;
                    } 
                }
                if (c == 0)
               
                    Console.WriteLine(i + " is prime number");                      
                      
            }
        }
    }
}
