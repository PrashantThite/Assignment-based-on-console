using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Positive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a==0)
                Console.WriteLine("number is neutral");
            else if(a>=1)
                Console.WriteLine("number is positive");
            else
                Console.WriteLine("number is negative");
        }
    }
}
