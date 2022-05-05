using System;
using System.Collections.Generic;
using System.Text;

namespace Miicrosoft.Patterns
{
    class P1
    {
        static void Main(string[] args)
        {
            int k = 4;
            for(int i=1;i<=5;i++)
            {
                
                for(int s=1;s<=k;s++)
                {
                    Console.Write(" ");                 
                }
                for(int j=1;j<=i;j++)
                {
                    Console.Write(j);
                }                   
                Console.WriteLine();
                k--;
            }
           
        }
    }
    class Pattern1  
    {
        static void Main(string[] args)
        {
            for(int i=6;i>=1;i--)
            {
                for(int j=i;j<=1;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
