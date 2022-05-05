using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Oops
{
    class OverLoading
    {
        public void Pattern(int a)
        {
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= a; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
            public void Pattern(int a,int b)
            {
                for (int i = 1; i <= a; i++)
                {
                    for (int j = 1; j <= b; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

            }
        static void Main(string[] args)
        {
            OverLoading a= new OverLoading();
            a.Pattern(5);
            Console.WriteLine();
            Console.WriteLine();
            a.Pattern(4, 7);
        }
    }
    
}
