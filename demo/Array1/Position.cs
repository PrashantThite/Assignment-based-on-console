
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Array1
{
    class Position
    {
        // To insert an element in specific position
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter how many Numbers you wan to insert");
            int size = Convert.ToInt32(Console.ReadLine());
            
            for(int i=0;i<size;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
               
            }
            Console.WriteLine("Enter which number you want to insert");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the position where you want to insert");
            int pos = Convert.ToInt32(Console.ReadLine());
           if(pos==size)
            {
                arr[size]=n1;
                size++;
            }
            else if(pos>=0 && pos<size)
            {
                for(int i=size-1;i>=pos;i--)
                {
                    arr[i+1] = arr[i];
                   
                }
                arr[pos] = n1;
            }
           for(int i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
