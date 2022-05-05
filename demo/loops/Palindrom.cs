using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.loops
{
    class Palindrom
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a;
            int r,sum=0;
            while(a>0)
            {
                r = a % 10;
                sum = sum * 10 + r;
                a = a / 10;
            }
           string palindrom= b == sum ? "palindrom number" : "not a palindrom number";
            Console.WriteLine(palindrom);
        }
    }
}
