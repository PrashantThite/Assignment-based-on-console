using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Patterns
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter row no");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter coloumn no");
            int b = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= b; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
