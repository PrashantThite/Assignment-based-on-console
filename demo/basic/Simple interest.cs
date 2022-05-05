using System;
using System.Collections.Generic;
using System.Text;

namespace A
{
    class class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Given");
            Console.WriteLine("enter muddal");
        int m1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter mudat");
            int m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter dar");
            int m3 = Convert.ToInt32(Console.ReadLine());

            int SI = m1 * m2 * m3 / 100;
            Console.WriteLine("simple interest =" +SI);


        }
    }
}
