using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.loops
{
    class Palindrom100
    {
        static void Main(string[] args)
        {
            
            for (int i = 100; i <= 500; i++)
            {
                int a = i; 
                int sum = 0;
                int r;
                while (a > 0)
                {
                    r =a % 10;
                    sum = sum * 10 + r;
                    a = a / 10;
                }
                if (sum == i) 
                Console.WriteLine(i+" is palindrom number");
                
                   

            }

        }
    }
}
