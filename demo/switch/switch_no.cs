using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class switch_no
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            short a = Convert.ToInt16(Console.ReadLine());
            switch(a)
            {
                case 1: Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                default:
                    Console.WriteLine("INVALID INPUT");
                    break;

            }
        }
    }
}
