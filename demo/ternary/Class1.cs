using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Class1
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Enter alphabet");
            char ch = Convert.ToChar(Console.Read());
            if(ch>65 && ch<=90)
            {
                ch = (char)(ch + 32);
                Console.WriteLine(ch);
            }
            
else if(ch>=97 &&ch<=122)
            {
                ch = (char)(ch - 32);
                Console.WriteLine(ch);
            }
            else
                Console.WriteLine("Its not alphabet");
            
            int a = 2004;
            string leapyear = a % 4 == 0 ? "its leap year" : "not leap year";
            Console.WriteLine(leapyear);


        }


    }
}
