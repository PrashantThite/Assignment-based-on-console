using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.loops
{
    class MaxNO
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a;
            int r, max = 0;
            while (a > 0)
            {
                r = a % 10;
                if(r>max)
                {
                    max = r;
                }        
                a = a / 10;                  
            }
            Console.WriteLine("Max digit="+max);
        }
    }
    class  MaxNo1
    {
        static void Main(string[] args)
        {
            int max = 0;
            for(int i=1;i<=3;i++)
            {
                Console.WriteLine($"Enter {i} Number");
                int a = Convert.ToInt32(Console.ReadLine());
                if(a>max)
                {
                    max = a;
                }
                    
            }
            Console.WriteLine(max);
        }
    }
}
