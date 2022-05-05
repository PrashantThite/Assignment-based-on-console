using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter No");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a%7==0)
                Console.WriteLine(a+"divisiable by 7");
            else
                Console.WriteLine(a+"not divisiable by 7");

        }
    }
}
