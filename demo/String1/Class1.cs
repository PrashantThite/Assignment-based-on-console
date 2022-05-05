using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.String1
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string a = Console.ReadLine();
            string b=a.ToUpper();
            for(int i=0;i<b.Length;i++)
            {
                Console.WriteLine(b[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = b.Length-1; i >=0; i--)
            {
                Console.WriteLine(b[i]);
            }
            
        }
    }
}
