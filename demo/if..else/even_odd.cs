using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class even_odd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a%2==0)
                Console.WriteLine("Number is even");
            else
                Console.WriteLine("number is odd");

        }
    }
}
