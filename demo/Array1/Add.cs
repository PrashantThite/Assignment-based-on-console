using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Array1
{
    class Add
    {
        // Merg
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 6, 7, 8, 9, 10 };
            int[] c =new int [a.Length + b.Length];
            for(int i=0;i<c.Length;i++)
            {
                if (i < a.Length)
                {
                    c[i] = a[i];
                    Console.WriteLine(c[i]);
                }
                else
                {
                    c[i] = b[i - a.Length];

                    Console.WriteLine(c[i]);
                }
            }
           
        }
    }
    class Add1
    {
        //alternate merg
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 6, 7, 8, 9, 10 };
            int[] c = new int[(a.Length + b.Length)];
            int k = 0;
            for (int i = 0; i < a.Length; i++)
            {                               
                    c[k] = a[i];
                k++;
                     c[k] = b[i];
                k++;    
            }

            for(int i=0; i<c.Length;i++)
            {
                Console.Write(c[i]+" ");
            }
        }
    }

    class Add2
    {
        // alternate merg for different size array
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4 };
            int[] b = { 5, 6, 7, 8, 9, 10 };
            int[] c = new int[a.Length + b.Length];
            int k = 0;
            for(int i=0;i<c.Length;)
            {
                if (k < a.Length)
                {
                    c[i] = a[k];
                    i++;
                }
                if (k < b.Length)
                {
                    c[i] = b[k];
                    i++;
                }
                k++;                                
            }
                    

            for(int i=0;i<c.Length;i++)
            {
                Console.Write(c[i]+" ");
            }
        }
    }
    class Swap
    {
        //swap first two elements with last two elements
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int k = 0,j=1;
            for(int i=0;i<a.Length/2;i++)
            {
                k=a[i];
                a[i] = a[a.Length - j];
                a[a.Length - j] = k;
                j++;
                if (i == 1)
                    break;
            }
            for(int i=0;i<a.Length;i++)
            {
                Console.Write(a[i]+" ");
            }
        }
    }
    class Max
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter numbers");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max =arr [0];
            for(int i=0;i<arr.Length;i++)
            {
                if(max<arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Max No="+max);
        }
    }
    class Frequency
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 5, 1, 2, 3, 5, 7, 6, 2, 8, 9, 7, };
            for(int i=0;i<arr.Length;i++)
            {
                int count = 0;
                for(int j=0;j<arr.Length;j++)
                {
                    if (arr[i] == arr[j])
                        count++;
                }
                Console.WriteLine($"frequancy of{arr[i]}={count}");
            }
        }
    }
    class Alternate
    {
        // Alternating positiv and negative number
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, -4, -1, 4 };
            int p = 0,n= 0;
            for(int i=0;i<a.Length;i++)
            {
                if (a[i] < 0)
                    n++;
                else
                    p++;
            }
            int[] positive = new int[p];
            int[] negative = new int[n];
             p = 0;
            n = 0;
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]>0)
                {
                    positive[p++] = a[i];
                }
                else
                {
                    negative[n++] = a[i];

                }
                
            }
            int[] alter = new int[positive.Length + negative.Length];
            int k = 0;
            for(int i=0;i<alter.Length;)
            {
                if(k<negative.Length)
                {
                    alter[i++] = negative[k];
                }
                if(k<positive.Length)
                {
                    alter[i++] = positive[k];
                }
                k++;
            }
           for(int i=0;i<alter.Length;i++)
            {
                Console.Write(alter[i]+" ");
            }
            
        }
    }
    class Merg
    {
        static void Main(string[] args)
        {
            int[] a = { 12, 0, 7, 0,3, 8, 0, 3,0,0,5 };
            
            int k = 0,c=0;
            for(int i=0;i<a.Length;i++)
            {
                if (a[i] != 0)
                {
                    a[k++] = a[i];
                }
                else
                    c++;
            }
            for(int i=a.Length-1;i>=a.Length-c;i--)
            {
                a[i] = 0;
            }
            for (int i=0;i<a.Length;i++)
            {
                Console.Write(a[i]+" ");
            }
        }
    }
    class Merg1
    {
        static void Main(string[] args)
        {
            int[] a = {0, 3, 2, 0, 2, 0, 0, 5, 0, 8 };
            int j = 0;
            for(int i=0;i<a.Length;i++)
            {
                if (a[i] != 0)
                {                  
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    j++;
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]+" ");
            }
        }
    }
}
