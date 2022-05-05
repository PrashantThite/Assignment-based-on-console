using System;
using System.Collections.Generic;
using System.Text;

namespace Miicrosoft.march23
{
    class Factor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int a = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=a;i++)
            {
               if (a % i == 0)
                    Console.WriteLine(i+"is factor of"+a);

            }



        }

    }
}
