using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Patterns
{
    class Y
    {
        static void Main(string[] args)
        {
            int row = 5;
            int coloumn = 5;
            for (int i = 1; i <= row;i++)
            {
                for(int j=1;j<=coloumn;j++)
                {
                    if (j == 1 || j == 5 || i%2==1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();

            }
        }
    }
}
