using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.While
{
    class Digit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int a = Convert.ToInt32(Console.ReadLine());
           
            int c = 0;

            while(a>0)
            {
                
                    a = a   / 10;
                c++;
            }
            Console.WriteLine("Total digit= "+c);
        }
    }
}
