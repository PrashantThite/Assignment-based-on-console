using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Patterns
{
    class E
    {
        static void Main(string[] args)
        {

            int row = 5;

            int coloumn = 5;

            for(int i=1;i<=row;i++)
            {
                
                    for (int j = 1; j <= coloumn; j++)
                    {
                    if (i % 2 == 1 || j == 1)

                        Console.Write("*");
                    }                    
                
                Console.WriteLine();
            }

        }
    }
}
