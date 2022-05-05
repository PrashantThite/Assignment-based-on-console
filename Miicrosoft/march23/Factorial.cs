using System;
using System.Collections.Generic;
using System.Text;

namespace Miicrosoft.march23
{
    class Factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum=1;
            for(int i=1;i<=a;i++)
            {
                sum*=i;
            }
            Console.WriteLine(sum);
        }
    }
}
