using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.While
{
    class ProductDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int a = Convert.ToInt32(Console.ReadLine());
            int multi = 1;
            int d;
            while(a>0)
            {
                d = a % 10;
                if (d != 0)
                {
                    multi = multi * d;
                }
                a = a / 10;
            }
            Console.WriteLine("multi of digit= "+multi);

        }
    }
}
