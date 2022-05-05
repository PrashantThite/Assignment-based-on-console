using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.loops
{
    class Fabbonaci
    {
        static void Main(string[] args)
        {
            int a = 10;
            int s1 = 0, s2 = 1;
            
            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine(s1);
                int temp = s1 + s2;
                s1 = s2;
                s2 = temp;
            }
            Console.WriteLine(s1);
        }
    }
    class Label1
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0;
        start:
            i++;
            j += i;
            if(i<10)
            {
                Console.WriteLine(i+" ");
                goto start;
            }


        }
    }
    class AP
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three number");
            int a2 = Convert.ToInt32(Console.ReadLine());
            int a3 = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            arr[2] = a3;
            int d;
            if (a2 >= a3)
                d = a2 + a3;
            else
                d = a3 - a2;

            for(int i=3;i<n;i++)
            {
                arr[i]=arr[i - 1] + d;
            }
            Console.WriteLine(arr[n-1]);
        }
    }
}
