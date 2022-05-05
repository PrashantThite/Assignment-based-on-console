using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Oops
{
    class Recursion
    {
        public static int factorial( int a)
        {
            if (a == 1)
                return 1;
            else
            {
                int ans = factorial(a - 1);
                return a * ans;
            }
        }
        static void Main(string[] args)
        {
         int ans=   Recursion.factorial(5);
            Console.WriteLine(ans);
        }
    }
}
