using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.loops
{
    class Harshad
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int b = a;
            while (a > 0)
            {
                int digit = a % 10;
                sum = sum + digit;
                a = a / 10;
            }
            if(b%sum==0)
                Console.WriteLine("its harshad neiven number");
            else
                Console.WriteLine("not harshad neiven number");
        }
    }
}
