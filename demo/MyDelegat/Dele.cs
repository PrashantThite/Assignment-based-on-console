using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.MyDelegat
{
    public delegate int Mydele(int a, int b);
    class Dele
    {
        
        public int Add(int a,int b)
        {
            return a + b;
        }
        public int Multi(int a,int b)
        {
            return a * b;
        }

    }
    class Test4
    {
        static void Main(string[] args)
        {
            Dele n1 = new Dele();
            Mydele dele = new Mydele(n1.Add);
            dele += new Mydele(n1.Multi);
            Delegate[] list = dele.GetInvocationList();
            foreach (Delegate item in list)
            {
                Console.WriteLine(item.Method);
                Console.WriteLine(item.DynamicInvoke(10,20));
            }

        }
    }
}
