using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class switch_calci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 NO");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Press 1=Add, 2=sub, 3=multi, 4=div");
            int c = Convert.ToInt32(Console.ReadLine());
            switch(c)
            {
                case 1: Console.WriteLine("Addition=" +a+b);
                    break;
                case 2:
                    Console.WriteLine("substraction=" + (a - b));
                    break;

                case 3:
                    Console.WriteLine("Multiplication="+ a* b);
                    break;
                case 4:
                    Console.WriteLine("Division=="+ a/ b);
                    break;
                default:
                    Console.WriteLine("Invalid statement");
                    break;

            }
        }
    }
}
