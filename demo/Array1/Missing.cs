using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Array1
{
    class Missing
    {
        // Find Missing numbers
        static void Main(string[] args)
        {
            int[] a = {1,6,5,0,3,7,8,0,10,0};
            Array.Sort(a);
           
           for(int i=0;i<a.Length-1;i++)
            {
                if (a[i] != 0)
                {
                    if (a[i + 1] != a[i] + 1)
                    {
                        Console.Write(a[i] + 1 + " ");
                    }
                }
            }
                
            
        }
    }
}
