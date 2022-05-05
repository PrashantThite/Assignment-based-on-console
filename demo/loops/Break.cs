using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.loops
{
    class Break
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= a;)
            {
                i += 2;
                Console.WriteLine(i + "is even number");
                if (i == 6)
                {
                    break;
                }
            }
        }
    }
}
