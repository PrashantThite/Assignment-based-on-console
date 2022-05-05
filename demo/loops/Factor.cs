using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.loops
{
    class Factor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
           
            for(int i=1;i<=a;i++)
            {
                if (a % i == 0 && b%i==0) 
                Console.WriteLine(i);

              

            }
        }
    }
}
