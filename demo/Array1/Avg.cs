using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Array1
{
    class Avg
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter numbers ");
            int sum = 0;
            for(int i=0;i<a.Length;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + a[i];
            }
            int avg = sum / a.Length;
            Console.WriteLine("average="+avg);
            foreach(int b in a)
            {
                Console.Write(b+" ");
            }

        }
    }
}