using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class calci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 2 numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Which operation you want to perform");
            char c = Convert.ToChar(Console.ReadLine());
            if (c == '+')
                Console.WriteLine("Addition=" + a + b);
            else if (c == '-')
                Console.WriteLine("sub=" + (a - b));
            else if (c == '*')
            Console.WriteLine("multi=" + (a * b));
            else if(c=='/')
                Console.WriteLine("division"+(a/b));
            else
                Console.WriteLine("unable to perform");

        }
    }
}
