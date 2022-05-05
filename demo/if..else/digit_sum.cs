using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class digit_sum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a / 100;
            int c = a % 10;
            int sum=a+b;
            if (a > 99 & a <1000)
                Console.WriteLine("sum of 1st and last digit" +sum);
            else
                Console.WriteLine("wrong statement");
        }
    }
}
