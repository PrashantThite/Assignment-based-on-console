
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Patterns
{
    class Box
    {
        static void Main(string[] args)
        {
            int row = 5, coloumn = 5;

            for(int i=1;i<=row;i++)
            {
                for(int j=1;j<=coloumn; j++)
                {
                    if( j%2==1)
                    Console.Write("*");
                    else
                        Console.Write("@");
                }
                Console.WriteLine();
            }
        }
    }
}
