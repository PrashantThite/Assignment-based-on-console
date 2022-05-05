using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Array1
{
    class Reverse
    {
        static void Main(string[] args)
        {
            int[] a = { 10,20,40,30,60,50,80,70};
            for(int i=a.Length-1;i>=0;i--)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
    class AlternateReverse
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 20, 30,40,50,60,7,80,90,100};
            for (int i = a.Length - 1; i >= 0; i-=2)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
