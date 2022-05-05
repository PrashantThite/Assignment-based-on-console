using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Array1
{
    class Array2d
    {
        static void Main(string[] args)
        {
            int[, ]a= new int[4, 3];
            for(int i=0;i<a.GetLength(0);i++)
            {
                Console.WriteLine("Enter elements for row" + i);
                for(int j=0;j<a.GetLength(1);j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i,j]+" ");
                }
            }
        }
    }
    class Max1
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 4];
            for(int i=0;i<a.GetLength(0);i++)
            {
                Console.WriteLine($"Enter {a.GetLength(1)}elements in row{i}");
                for(int j=0;j<a.GetLength(1);j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int max = a[0, 0];
            for(int i =0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    if (max < a[i, j])
                        max = a[i, j];
                }
            }
            Console.WriteLine("max number= "+max);
        }
    }
    class Reverse1
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
            int[,] b = new int[a.GetLength(0),a.GetLength(1)];
            int k = 0; 
            for(int i=0;i<a.GetLength(0); i++)
            {
                int l = 0;
                for(int j=a.GetLength(1)-1;j>=0 ;j--)
                {
                    b[k, l++] = a[i, j];
                }
                k++;
            }
            for(int i=0;i<b.GetLength(0);i++)
            {
                for(int j=0; j<b.GetLength(1);j++)
                {
                    Console.Write(b[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
    class max2
    {
        // Max in row
        static void Main(string[] args)
        {
            int[,] a = { { 22, 31, 9 }, { 12, 25, 16 } ,{ 25, 36, 20 } };
            for(int i=0; i<a.GetLength(0);i++)
            {
                int max =a[i, 0];
                for(int j=0;j<a.GetLength(1);j++)
                {
                    if (max < a[i, j])
                        max = a[i, j];
                }
                Console.WriteLine($"max of row{i}={max}");
            }

        }
    }
    class Digonal
    {
        static void Main(string[] args)
        {
            int[,] a = new int[5, 5];
            for(int i=0;i<a.GetLength(0);i++)
            {
                Console.WriteLine($"Enter number for{i} row");
                for (int j = 0; j < a.GetLength(1);j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    if(i==j || i+j==a.GetLength(0)-1)
                    {
                        Console.Write(a[i,j]);
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
    class Min
    {
        // Minimum number in every row
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3];
            for(int i=0;i<a.GetLength(0);i++)
            {
                Console.WriteLine($"Enter Numer for{i} row");
                for(int j=0;j<a.GetLength(1);j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int min = a[i, 0];
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (min > a[i, j])
                        min = a[i, j];
                }
                Console.WriteLine($"Minimum number of row{i}= {min}");
            }

        }
    }
}
