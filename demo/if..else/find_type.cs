using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class find_type
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter character");
            char a1 = Convert.ToChar(Console.ReadLine());
            if((a1>='a' && a1<='z') || (a1>='A' && a1<='z'))
                Console.WriteLine("its alphabet");
            else if (a1<='9' && a1>='0' )
                Console.WriteLine("its a number");
            else
                Console.WriteLine("its special character");
        }
    }
}
