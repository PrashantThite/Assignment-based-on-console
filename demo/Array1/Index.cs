using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Array1
{
    // Search for given number and if exists print its index
    class Index
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 5,7,9,3,8,5,2,1,3,6,9,4 };
            Console.WriteLine("Enter number to search");
            int b = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]==b)
                {
                    Console.WriteLine("Index of number="+a[i-1]);
                }
            }
        }
    }
}
