using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class switch_day
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press : 1=mon, 2=tue, 3=wed, 4=thus, 5=fri, 6=sat, 7=sun");
            short a = Convert.ToInt16(Console.ReadLine());
            switch(a)
            {
                case 1: Console.WriteLine("Its Monday");
                    break;
                case 2:
                    Console.WriteLine("Its Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Its wednesday");
                    break;
                case 4:
                    Console.WriteLine("Its Thursday");
                    break;
                case 5:
                    Console.WriteLine("Its Friday");
                    break;
                case 6:
                    Console.WriteLine("Its Saturday");
                    break;
                case 7:
                    Console.WriteLine("Its Sunday");
                    break;
                default:
                    Console.WriteLine("error, day does not exist");
                    break;

            }
        }
    }
}
