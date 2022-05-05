
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.loops
{
    class Autoporphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbeer");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a;
            int square = a * a;            
            int digit = 0;

            while (b > 0)
            {
                b = b / 10;
                digit++;
            }

            int divider = 10;
            int auto = 0;
            for (int i = 1; i <= digit; i++)
            {                
                    auto = square % divider;
                    divider = divider * 10;            
            }
            if (auto == a)
                Console.WriteLine("its automorphic number");
            else
                Console.WriteLine("Its not automorphic");



            /*   if(d==1)
                {
                    int auto = square % 10;
                    if(a==auto)
                        Console.WriteLine("its automorphic number");
                    else
                        Console.WriteLine("its not automorphic");
                }
             else   if (d == 2)
                {
                    int auto = square % 100;
                    if (a == auto)
                        Console.WriteLine("its automorphic number");
                    else
                        Console.WriteLine("its not automorphic");
                }
                else if (d == 3)
                {
                    int auto = square % 1000;
                    if (a == auto)
                        Console.WriteLine("its automorphic number");
                    else
                        Console.WriteLine("its not automorphic");
                }
            */

        }

    }
}
