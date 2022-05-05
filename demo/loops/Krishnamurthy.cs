using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.loops
{
    class Krishnamurthy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int a = Convert.ToInt32(Console.ReadLine());
            int i = a;
            int r;
            int multi=1;
            int sum = 0;
            while( a>0)
            {
                r = a % 10;
                multi = 1;
                for(int j=1;j<=r;j++)
                {
                     multi = multi* j;
                }
                sum = sum + multi;
                a=a / 10;
            }
            Console.WriteLine(sum);
            if(sum==i)
                Console.WriteLine("its krishnamurthay number ");
            else
                Console.WriteLine("not krishnamurthay number");
        }
    }
}
