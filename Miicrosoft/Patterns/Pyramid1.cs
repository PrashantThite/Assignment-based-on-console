using System;
using System.Collections.Generic;
using System.Text;

namespace Miicrosoft.Patterns
{
    class Pyramid1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int r = Convert.ToInt32(Console.ReadLine());
                int k = r/2;
            for (int i = 1; i <= r; i+=2)
            {
                for(int s = 1; s <= k; s++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <=i ; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                k--;
            }           

        }
    }
}
