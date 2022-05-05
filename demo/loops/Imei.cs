using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.loops
{
    class Imei
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            long a = Convert.ToInt64(Console.ReadLine());
            long b = a;
            int c = 0;
            while (b > 0)
            {
                b = b / 10;
                c++;
            }
            b = a;
            if(c==15)
            {
                for (int i = 1; i <= 15; i++)
                {
                    int d = (int)(b % 10);
                    int sum1 = 0,sum2=0;
                    if (i % 2 == 0)
                    {
                        d = d * 2;
                        if(d>9)
                        while (d >0)
                        {
                            sum1 = sum1 + (d % 10);
                            d = d / 10;
                        }
                    }
                    else
                        sum2 = sum2 + d;
                        
                        

                }
            }
            else
                Console.WriteLine("its not 15 digit number");

        }

        
    }
}
