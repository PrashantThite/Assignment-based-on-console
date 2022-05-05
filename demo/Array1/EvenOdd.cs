using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Array1
{
    class EvenOdd
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int E = 0;
            int O = 0;
            for(int i=0;i<=a.Length;i++)
            {
                if (a[i] % 2 == 0)
                    E++;
                else
                    O++;
            }
            int[] e = new int[E];
            int[] o = new int[O];
             E = 0;
             O = 0;
            for(int i=0;i<a.Length;i++)
            {
                if (a[i] % 2 == 0)
                {
                    e[E] = a[i];
                        E++;
                }
                else
                {
                    o[O] = a[i];
                    O++;
                }
            }
            for(int i=0;i<e.Length;i++)
            {
                Console.Write(e[i]+" ");

            }
            Console.WriteLine("");
            for (int i = 0; i < o.Length; i++)
            {
                Console.Write(o[i] + " ");

            }
        }
    }
}
