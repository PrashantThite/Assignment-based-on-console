using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.loops
{
    class Table
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int a = Convert.ToInt32(Console.ReadLine());
            int multi = 1;

            for (int i = 1; i <= 10; i++)
            {
                multi = a * i;
                Console.WriteLine(multi);
            }
        }

    }
}
