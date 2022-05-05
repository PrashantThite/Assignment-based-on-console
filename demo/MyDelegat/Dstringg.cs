using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.MyDelegat
{
    public delegate void dele1(string a);

    class Dstringg
    {
        public void Upper(string a)
        {
            a = a.ToUpper();
            Console.WriteLine(a);
        }
        public void Lower(string a)
        {
            a = a.ToLower();
            Console.WriteLine(a);
        }
    }
    class Test7
    {
        static void Main(string[] args)
        {
            Dstringg n1 = new Dstringg();
            dele1 d1 = new dele1(n1.Upper);
            d1 += new dele1(n1.Lower);
            Delegate[] a = d1.GetInvocationList();
            foreach (Delegate item in a)
            {
                Console.WriteLine(item.Method);
                Console.WriteLine(item.DynamicInvoke("PraShanT"));
            }
        }

    }
}
