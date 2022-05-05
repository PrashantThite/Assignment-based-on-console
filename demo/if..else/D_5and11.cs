using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class D_5and11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a%5==0 && a%11==0)
                Console.WriteLine("It is divisible by 5 & 11");
            else
                Console.WriteLine("it is not divisible ");
        }
    }
}
