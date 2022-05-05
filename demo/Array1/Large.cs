using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Array1
{
    // to find largest string from string array
    class Large
    {
        static void Main(string[] args)
        {
            string aa = "Prashant Deepak Thite";
            string []a=aa.Split(" ");
            string large = a[0];
            for(int i=0;i<a.Length;i++)
            {
                if(large.Length<a[i].Length)
                {
                    large = a[i];
                }
            }
            Console.WriteLine(large);
        }
    }
}
