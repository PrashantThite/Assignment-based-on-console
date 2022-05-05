using System;
using System.Collections.Generic;
using System.Text;

namespace Miicrosoft.march23
{
    class Sum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i=1;i<=a;i++)
            {
                sum += i;
            }
            Console.WriteLine("addition of 1st 10 No"+sum);
        }
    }
}
