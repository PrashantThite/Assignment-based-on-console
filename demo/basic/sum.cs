using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    class sum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers");
            int n1=Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int n3 = Convert.ToInt32(Console.ReadLine());
            int n4 = Convert.ToInt32(Console.ReadLine());
            int sum = n1 + n2 + n3 + n4;
            Console.WriteLine("sum of numbers="+sum);



        }
    }
}
