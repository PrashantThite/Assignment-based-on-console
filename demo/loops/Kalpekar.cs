using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.loops
{
    class Kalpekar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int a = Convert.ToInt32(Console.ReadLine());
            int sq = a * a;
            Console.WriteLine("Square of number="+sq);
            int sq1 = sq;
            int r;
            int count=0;
            int left, right;
            int sum;
            while (sq > 0)
            {
                r = sq % 10;               
                sq = sq / 10;
                count++;
            }
            int divieder = 1;
            for(int i=1;i<=count;i++)
            {
                if (i % 2 == 1)
                {
                    divieder = divieder * 10;
                }
                    if (count == i)
                    {
                        right = sq1 % divieder;
                        left = sq1 / divieder;
                        Console.WriteLine($"Left side={left},  Right side={right}");
                        sum = left + right;
                        if (sum == a)
                            Console.WriteLine("Its kaplekar number");
                        else
                            Console.WriteLine(" Not kaplekar number");
                    }               
                
            }

           /* if(count==4)
            {
                left = sq1 % 100;
                right = sq1 / 100;
                sum = left + right;
                if(sum==a)                
                    Console.WriteLine("its kalpekar number");
                else
                    Console.WriteLine("its not Kalpekar number");                  
            }
            else if(count==5)
            {
                left = sq1 % 1000;
                right = sq1 / 1000;
                Console.WriteLine(left+"  "+right);
                sum = left + right;
                if (sum == a)
                    Console.WriteLine("its kalpekar number");
                else
                    Console.WriteLine("its not Kalpekar number");
            }
            else if (count == 6)
            {
                left = sq1 % 1000;
                right = sq1 / 1000;
                sum = left + right;
                if (sum == a)
                    Console.WriteLine("its kalpekar number");
                else
                    Console.WriteLine("its not Kalpekar number");
            }
            else
                Console.WriteLine("Invalid statement");

            */
        }
    }
}
