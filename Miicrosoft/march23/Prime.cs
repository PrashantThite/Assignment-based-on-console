using System;
using System.Collections.Generic;
using System.Text;

namespace Miicrosoft.march23
{
    class Prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int a = Convert.ToInt32(Console.ReadLine());
            int c = 0;
        for(int i=2;i<a ; i++)
            {
                if (a % i == 0 )
                {
                    c++; 
                }
                }
            if (c == 0)
                Console.WriteLine(a + " is prime number");
            else
                Console.WriteLine(a + " is not prime number");
        }
    }
}
