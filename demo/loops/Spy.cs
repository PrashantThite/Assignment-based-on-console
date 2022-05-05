using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.loops
{
    class Spy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0, multi = 1;
            while(a>0)
            {
                sum = sum + a % 10;
                multi = multi *( a % 10);
                a /= 10;
            }
            Console.WriteLine(sum+" is sum of all digit");
            Console.WriteLine(multi+" is multiplication of all digit");
            if(sum==multi)
                Console.WriteLine("Its a spy number");
            else
                Console.WriteLine("Its not a spy number");
        }
    }
}
