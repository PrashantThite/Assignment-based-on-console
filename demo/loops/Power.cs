using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.loops
{
    class Power
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter base");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter index");
            int b = Convert.ToInt32(Console.ReadLine());
            
            int multi = 1;

            for(int i=1; i<=b;i++)
            {
                multi = multi * a;
            }
            Console.WriteLine(multi);
            
        }
    }
}
