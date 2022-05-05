using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Max
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if(a>b && a>c)
                Console.WriteLine("Max number is" +a);
            else if(b>a && b>c)
                Console.WriteLine("Max number is" + b);
            else if(c>a && c>b)
                Console.WriteLine("Max number is" + c);
            else
                Console.WriteLine("all numbers are equal");




        }
    }
}
