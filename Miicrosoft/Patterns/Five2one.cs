using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Patterns
{
    class Five2one
    {
        static void Main(string[] args)
        {
            for(int i=5;i>=1;i--)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            
        }
    }

    class Five2one2
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 5; j <=5 ; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    class P1
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=10;i+=2)
            {
                
                for(int j=1;j<=i;j++)
                {
                    if (j % 2 == 1)
                    {
                        Console.Write(j);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}



